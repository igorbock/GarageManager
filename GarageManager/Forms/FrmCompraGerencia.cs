using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmCompraGerencia : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Home MainForm { get; set; }

        public FrmCompraGerencia(Home main)
        {
            MainForm = main;
            InitializeComponent();
            comboStatus.SelectedIndex = 0;
        }

        private void FrmCompraGerencia_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv.IsCurrentCellDirty && dgv.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            dtpInicio.Checked = false;
            dtpFim.Checked = false;
            //txtFornecedor.Text = "";
            comboStatus.SelectedIndex = 0;
            CarregarGrid();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            var f = new FrmCompra { IdCompra = 0 };
            f.ShowDialog();
            CarregarGrid();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregarGrid()
        {
            var where = new List<string>();
            var param = new DynamicParameters();
            param.Add("eid", Sessao.EmpresaId ?? 1);

            if (dtpInicio.Checked)
            {
                where.Add("date(c.data) >= date(@inicio)");
                param.Add("inicio", dtpInicio.Value.ToString("yyyy-MM-dd"));
            }
            if (dtpFim.Checked)
            {
                where.Add("date(c.data) <= date(@fim)");
                param.Add("fim", dtpFim.Value.ToString("yyyy-MM-dd"));
            }
            //if (!string.IsNullOrWhiteSpace(txtFornecedor.Text))
            //{
            //    where.Add("p.nome LIKE @forn");
            //    param.Add("forn", "%" + txtFornecedor.Text.Trim() + "%");
            //}
            string filtro = comboStatus.SelectedItem?.ToString();
            if (filtro != null && filtro != "Todas")
            {
                where.Add("c.status=@st");
                param.Add("st", filtro);
            }
            string whereClause = where.Count > 0 ? " AND " + string.Join(" AND ", where) : "";
            using (var conn = GarageDb.OpenConnection())
            {
                var dados = conn.Query(
                    @"SELECT c.id AS Id, strftime('%d/%m/%Y', c.data) AS Data, COALESCE(p.nome,'Avulso') AS Fornecedor, c.total AS Total, c.status AS Status, c.observacao AS Observacao
                      FROM compra c LEFT JOIN pessoa p ON p.id=c.id_fornecedor
                      WHERE c.id_empresa=@eid " + whereClause + " ORDER BY c.id DESC", param).ToList();
                dgv.DataSource = null;
                dgv.DataSource = dados;
            }
        }

        private void Editar()
        {
            var selecionados = ObterIdsSelecionados();
            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var frm = new FrmCompra { IdCompra = selecionados[0] };
            frm.ShowDialog();
            CarregarGrid();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterIdsSelecionados();
            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = selecionados[0];
            var repo = new Repository<Compra>();
            var c = repo.GetById(id);
            if (c == null) return;
            if (c.Status == "FECHADA" || c.Status == "CANCELADA")
            {
                MessageBox.Show("Compra fechada/cancelada não pode ser excluída. Use CANCELADA para estornar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Excluir compra #" + id + "?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            var repoItem = new Repository<CompraItem>();
            var itens = repoItem.GetAll().Where(x => x.IdCompra == id).ToList();
            foreach (var it in itens) repoItem.Delete(it.Id);
            repo.Delete(id);
            MessageBox.Show("Compra excluída.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }

        private List<int> ObterIdsSelecionados()
        {
            var ids = new List<int>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                }
            }
            return ids;
        }
    }
}
