using Dominio.Interfaces;
using Dominio.Modelos;
using GarageManager.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace GarageManager.Forms.Cadastro
{
    public partial class FrmCadMarca2 : Form, IFormCadastro
    {
        private Marca Marca { get; set; }

        public FrmCadMarca2()
        {
            InitializeComponent();
            // Eventos
            Load += (s, e) => CarregarForm();
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Insert)
                    Inserir();
            };
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F3)
                    Editar();
            };
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                    Excluir();
            };
            // Controles
            BtnInserir.Click += (s, e) => Inserir();
            BtnEditar.Click += (s, e) => Editar();
            BtnExcluir.Click += (s, e) => Excluir();
            BtnFechar.Click += (s, e) => Fechar();
            BtnSalvar.Click += (s, e) => Salvar();
            BtnCancelar.Click += (s, e) => Cancelar();
            BtnImprimirGrid.Click += (s, e) => ImprimirGrid();
            CmbEntidade.SelectedValueChanged += (s, e) => SelecionarEntidade();
            CmbEntidade.KeyDown += (s, e) => RemoverValue(e);
        }

        private void CarregarForm()
        {
            try
            {
                Marca = new Marca();
                // Carregar itens no ComboBox
                var DTMarcas = DatabaseManager.Consultar("SELECT id, nome FROM marca_veiculo");
                BSEntidade.DataSource = DTMarcas;

                DesabilitarSalvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelecionarEntidade()
        {
            try
            {
                var ObjIdValue = CmbEntidade.SelectedValue;
                if (ObjIdValue is null)
                {
                    Marca = new Marca();
                    PGEntidade.SelectedObject = Marca;
                    return;
                }
                var LngIdMarca = long.Parse(ObjIdValue.ToString());
                var DTEntidade = DatabaseManager.Consultar($"SELECT id, nome FROM marca_veiculo WHERE id={LngIdMarca}");
                Marca = new Marca
                {
                    Id = DTEntidade.Rows[0].Field<long>("id"),
                    Nome = DTEntidade.Rows[0].Field<string>("nome")
                };
                PGEntidade.SelectedObject = Marca;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoverValue(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete or Keys.Back:
                    Marca = new Marca();
                    PGEntidade.SelectedObject = Marca;
                    break;
            }
        }

        public void Inserir()
        {
            try
            {
                Marca = new Marca();
                HabilitarSalvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public void Fechar() => Close();

        public void Salvar()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cancelar()
        {
            try
            {
                Marca = new Marca();
                DesabilitarSalvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ImprimirGrid()
        {
            throw new NotImplementedException();
        }

        private void HabilitarSalvar()
        {
            BtnInserir.Visible = false;
            BtnEditar.Visible = false;
            BtnExcluir.Visible = false;
            BtnFechar.Visible = false;
            BtnSalvar.Visible = true;
            BtnCancelar.Visible = true;
            PGEntidade.Enabled = true;
            PGEntidade.SelectedObject = Marca;
            CmbEntidade.Enabled = false;
        }

        private void DesabilitarSalvar()
        {
            try
            {
                BtnInserir.Visible = true;
                BtnEditar.Visible = true;
                BtnExcluir.Visible = true;
                BtnFechar.Visible = true;
                BtnSalvar.Visible = false;
                BtnCancelar.Visible = false;
                PGEntidade.Enabled = false;
                PGEntidade.SelectedObject = Marca;
                CmbEntidade.Enabled = true;
                CmbEntidade.SelectedItem = null;
            }
            catch (Exception)
            {
            }
        }
    }
}
