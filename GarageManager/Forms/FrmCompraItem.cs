using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmCompraItem : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdCompra { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdItem { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CompraItem ItemResultado { get; private set; }

        public FrmCompraItem()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmCompraItem_Load(object sender, EventArgs e)
        {
            var repoProd = new Repository<Produto>();
            entityComboBox_produto.Reload(repoProd.GetAll());
            entityComboBox_produto.ReloadAction = () =>
            {
                using (var frm = new Cadastros.FrmCadProduto()) frm.ShowDialog();
                entityComboBox_produto.Reload(repoProd.GetAll());
            };
            if (IdItem > 0)
            {
                var repoItem = new Repository<CompraItem>();
                var item = repoItem.GetById(IdItem);
                if (item != null)
                {
                    entityComboBox_produto.SelectedValue = item.IdProduto;
                    nudQuantidade.Value = item.Quantidade;
                    txtCusto.Text = item.CustoUnitario.ToString("N2");
                }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (entityComboBox_produto.SelectedValue <= 0)
            {
                MessageBox.Show("Selecione um produto.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCusto.Text, out decimal custo) || custo < 0)
            {
                MessageBox.Show("Custo inválido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // modo memória: compra ainda não salva (IdCompra==0) -> não persiste, devolve ItemResultado
                if (IdCompra == 0 && IdItem == 0)
                {
                    ItemResultado = new CompraItem
                    {
                        IdCompra = 0,
                        IdProduto = entityComboBox_produto.SelectedValue,
                        Quantidade = (int)nudQuantidade.Value,
                        CustoUnitario = custo
                    };
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var repo = new Repository<CompraItem>();
                if (IdItem > 0)
                {
                    var item = repo.GetById(IdItem);
                    item.IdProduto = entityComboBox_produto.SelectedValue;
                    item.Quantidade = (int)nudQuantidade.Value;
                    item.CustoUnitario = custo;
                    repo.Update(item);
                }
                else
                {
                    var item = new CompraItem
                    {
                        IdCompra = IdCompra,
                        IdProduto = entityComboBox_produto.SelectedValue,
                        Quantidade = (int)nudQuantidade.Value,
                        CustoUnitario = custo
                    };
                    repo.Insert(item);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE") || ex.Message.Contains("uk_compra_item"))
                    MessageBox.Show("Produto já adicionado nesta compra. Edite a quantidade.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ex.Message.Contains("Estoque insuficiente"))
                    MessageBox.Show(ex.Message, "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Erro ao salvar item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
