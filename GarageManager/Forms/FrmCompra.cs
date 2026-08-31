using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmCompra : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int IdCompra { get; set; }
        private Compra compra;
        private List<CompraItem> itensMemoria = new List<CompraItem>();

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            var repoPessoa = new Repository<Pessoa>();
            entityComboBox_fornecedor.Reload(repoPessoa.GetAll());
            entityComboBox_fornecedor.ReloadAction = () =>
            {
                using (var frm = new Cadastros.FrmCadPessoa()) frm.ShowDialog();
                entityComboBox_fornecedor.Reload(repoPessoa.GetAll());
            };

            if (IdCompra > 0)
            {
                var repo = new Repository<Compra>();
                compra = repo.GetById(IdCompra);
                if (compra != null)
                {
                    if (compra.IdFornecedor.HasValue) entityComboBox_fornecedor.SelectedValue = compra.IdFornecedor.Value;
                    comboStatus.SelectedItem = compra.Status;
                    txtObservacao.Text = compra.Observacao;
                    if (compra.Status == "FECHADA" || compra.Status == "CANCELADA")
                    {
                        btnAdicionar.Enabled = false;
                        btnRemover.Enabled = false;
                        entityComboBox_fornecedor.Enabled = false;
                    }
                }
            }
            else
            {
                compra = new Compra { Status = "ABERTA", IdEmpresa = Sessao.EmpresaId ?? 1, Total = 0, Observacao = "" };
                comboStatus.SelectedItem = "ABERTA";
                itensMemoria = new List<CompraItem>();
            }
            CarregarItens();
        }

        private void CarregarItens()
        {
            if (IdCompra > 0)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    var dados = conn.Query(
                        @"SELECT ci.id AS Id, p.nome AS Produto, ci.quantidade AS Quantidade, ci.custo_unitario AS Custo, (ci.quantidade * ci.custo_unitario) AS Subtotal, ci.id_produto AS IdProduto
                          FROM compra_item ci JOIN produto p ON p.id=ci.id_produto WHERE ci.id_compra=@id",
                        new { id = IdCompra }).ToList();
                    dgvItens.DataSource = null;
                    dgvItens.DataSource = dados;
                    if (dgvItens.Columns["Id"] != null) dgvItens.Columns["Id"].Visible = false;
                    if (dgvItens.Columns["IdProduto"] != null) dgvItens.Columns["IdProduto"].Visible = false;
                    decimal total = dados.Sum(x => (decimal)x.Subtotal);
                    lblTotal.Text = "Total: " + total.ToString("C");
                    if (compra != null && compra.Status == "ABERTA")
                    {
                        compra.Total = total;
                    }
                }
            }
            else
            {
                // modo memória (nova compra ainda não salva)
                var dados = itensMemoria.Select((it, idx) => new
                {
                    Id = -(idx + 1),
                    Produto = GetProdutoNome(it.IdProduto),
                    Quantidade = it.Quantidade,
                    Custo = it.CustoUnitario,
                    Subtotal = it.Quantidade * it.CustoUnitario,
                    IdProduto = it.IdProduto
                }).ToList();
                dgvItens.DataSource = null;
                dgvItens.DataSource = dados;
                if (dgvItens.Columns["Id"] != null) dgvItens.Columns["Id"].Visible = false;
                if (dgvItens.Columns["IdProduto"] != null) dgvItens.Columns["IdProduto"].Visible = false;
                decimal total = dados.Sum(x => x.Subtotal);
                lblTotal.Text = "Total: " + total.ToString("C");
                compra.Total = total;
            }
        }

        private string GetProdutoNome(int idProduto)
        {
            try { var p = new Repository<Produto>().GetById(idProduto); return p?.Nome ?? $"Produto {idProduto}"; }
            catch { return $"Produto {idProduto}"; }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (compra != null && (compra.Status == "FECHADA" || compra.Status == "CANCELADA"))
            {
                MessageBox.Show("Compra fechada/cancelada não pode receber itens.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new FrmCompraItem { IdCompra = IdCompra };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (IdCompra == 0 && frm.ItemResultado != null)
                {
                    itensMemoria.Add(frm.ItemResultado);
                }
                CarregarItens();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (compra != null && (compra.Status == "FECHADA" || compra.Status == "CANCELADA"))
            {
                MessageBox.Show("Compra fechada/cancelada não pode remover itens.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idItem = Convert.ToInt32(dgvItens.CurrentRow.Cells["Id"].Value);
            if (MessageBox.Show("Remover item?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                if (IdCompra == 0)
                {
                    // memória - id negativo é índice
                    int idx = -(idItem + 1);
                    if (idx >= 0 && idx < itensMemoria.Count) itensMemoria.RemoveAt(idx);
                }
                else
                {
                    new Repository<CompraItem>().Delete(idItem);
                }
                CarregarItens();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdCompra == 0)
                {
                    // nova compra - persiste só agora
                    compra.IdFornecedor = entityComboBox_fornecedor.SelectedValue > 0 ? entityComboBox_fornecedor.SelectedValue : (int?)null;
                    compra.Observacao = txtObservacao.Text;
                    compra.Status = comboStatus.SelectedItem?.ToString() ?? "ABERTA";
                    compra.Total = itensMemoria.Sum(x => x.Quantidade * x.CustoUnitario);
                    var repo = new Repository<Compra>();
                    int novoId = repo.Insert(compra);
                    IdCompra = novoId;
                    compra.Id = novoId;
                    // insere itens da memória
                    var repoItem = new Repository<CompraItem>();
                    foreach (var it in itensMemoria)
                    {
                        it.IdCompra = novoId;
                        repoItem.Insert(it);
                    }
                    itensMemoria.Clear();
                    MessageBox.Show("Compra salva. Status: " + compra.Status, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var repo2 = new Repository<Compra>();
                var c = repo2.GetById(IdCompra);
                if (c == null) return;
                c.IdFornecedor = entityComboBox_fornecedor.SelectedValue > 0 ? entityComboBox_fornecedor.SelectedValue : (int?)null;
                c.Observacao = txtObservacao.Text;
                string novoStatus = comboStatus.SelectedItem?.ToString() ?? c.Status;
                if (c.Status == "FECHADA" && novoStatus == "ABERTA")
                {
                    MessageBox.Show("Compra fechada não pode voltar para ABERTA.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                c.Status = novoStatus;
                using (var conn = GarageDb.OpenConnection())
                {
                    decimal tot = conn.ExecuteScalar<decimal>("SELECT COALESCE(SUM(quantidade*custo_unitario),0) FROM compra_item WHERE id_compra=@id", new { id = IdCompra });
                    c.Total = tot;
                }
                repo2.Update(c);
                compra = c;
                MessageBox.Show("Compra salva. Status: " + c.Status, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (c.Status == "FECHADA" || c.Status == "CANCELADA")
                {
                    btnAdicionar.Enabled = false;
                    btnRemover.Enabled = false;
                    entityComboBox_fornecedor.Enabled = false;
                }
                else
                {
                    btnAdicionar.Enabled = true;
                    btnRemover.Enabled = true;
                    entityComboBox_fornecedor.Enabled = true;
                }
                CarregarItens();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Estoque insuficiente"))
                    MessageBox.Show("Erro ao fechar: " + ex.Message, "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVerEstoque_Click(object sender, EventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                var dados = conn.Query("SELECT produto AS Produto, marca AS Marca, saldo AS Saldo, estoque_minimo AS Minimo FROM vw_estoque_atual WHERE id_empresa=@eid ORDER BY produto", new { eid = Sessao.EmpresaId ?? 1 }).ToList();
                string msg = string.Join("\n", dados.Select(d => $"{d.Produto} ({d.Marca}): {d.Saldo} (mín {d.Minimo})").Take(20));
                if (string.IsNullOrWhiteSpace(msg)) msg = "Nenhum produto.";
                MessageBox.Show(msg, "Estoque Atual", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
