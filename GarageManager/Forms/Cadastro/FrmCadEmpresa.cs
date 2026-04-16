using GarageManager.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GarageManager.Forms.Cadastro
{
    public partial class FrmCadEmpresa : Form
    {
        private DataTable DataSourceEntidade { get; set; }
        private EventHandler InserirHandler { get; set; }
        private EventHandler EditarHandler { get; set; }
        private EventHandler SalvarHandler { get; set; }
        private EventHandler CancelarHandler { get; set; }
        private bool EhSalvando { get; set; }

        public FrmCadEmpresa()
        {
            InitializeComponent();
            // Eventos
            Load += (s, e) => CarregarEntidades();
            FormClosing += Fechar;
            // Configurações iniciais
            InserirHandler = (s, e) => InserirEntidade();
            EditarHandler = (s, e) => EditarEntidade();
            SalvarHandler = (s, e) => SalvarEntidade();
            CancelarHandler = (s, e) => Cancelar();
            // Controles
            BtnInserir.Click += InserirHandler;
            BtnEditar.Click += EditarHandler;
            BtnExcluir.Click += (s, e) => ExcluirEntidade();
            BtnFechar.Click += (s, e) => Close();
        }

        public void CarregarEntidades()
        {
            try
            {
                DataSourceEntidade = DatabaseManager.Consultar("SELECT id as \"ID\", nome as \"DESCRICAO\" FROM empresa");
                CmbEntidade.Items.AddRange(DataSourceEntidade.Rows.Cast<DataRow>().Select(row => new { Id = row["ID"], Nome = row["DESCRICAO"] }).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            TxtNome.Text = string.Empty;
        }
        public void InserirEntidade()
        {
            try
            {
                CmbEntidade.SelectedIndex = -1;
                LimparCampos();
                AlterarBotoes(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void EditarEntidade()
        {
            try
            {
                if (CmbEntidade.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um item para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var selected = CmbEntidade.SelectedItem.GetType().GetProperty("ID").GetValue(CmbEntidade.SelectedItem, null);
                var dataSource = DatabaseManager.Consultar($"SELECT id as \"ID\", nome as \"DESCRICAO\" FROM empresa WHERE id = {selected}");
                if (dataSource.Rows.Count > 0)
                {
                    TxtNome.Text = dataSource.Rows[0]["DESCRICAO"].ToString();
                }
                AlterarBotoes(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExcluirEntidade()
        {
            try
            {
                if (CmbEntidade.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um item para excluir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta marca?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.No)
                    return;

                var selected = CmbEntidade.SelectedItem.GetType().GetProperty("ID").GetValue(CmbEntidade.SelectedItem, null);
                DatabaseManager.Executar($"DELETE empresa WHERE id={selected}");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SalvarEntidade()
        {
            try
            {
                if (string.IsNullOrEmpty(TxtNome.Text))
                {
                    MessageBox.Show("Preencha o campo de nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (CmbEntidade.SelectedItem == null)
                {
                    DatabaseManager.Executar($"INSERT INTO empresa(nome, guid_empresa) VALUES('{TxtNome.Text}', '{Guid.NewGuid()}')");
                }
                else
                {
                    var selected = CmbEntidade.SelectedItem.GetType().GetProperty("ID").GetValue(CmbEntidade.SelectedItem, null);
                    DatabaseManager.Executar($"UPDATE empresa SET nome='{TxtNome.Text}' WHERE id={selected}");
                }
                LimparCampos();
                AlterarBotoes(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Cancelar()
        {
            try
            {
                CmbEntidade.SelectedIndex = -1;
                LimparCampos();
                AlterarBotoes(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AlterarBotoes(bool eh_salvar = false)
        {
            if (eh_salvar)
            {
                BtnInserir.Text = "Salvar";
                BtnInserir.Image = Properties.Resources.salvar;
                BtnEditar.Text = "Cancelar";
                BtnEditar.Image = Properties.Resources.cancelar;
                BtnExcluir.Visible = false;
                BtnFechar.Visible = false;
                // Alterar métodos dos botões
                BtnInserir.Click -= InserirHandler;
                BtnEditar.Click -= EditarHandler;
                BtnInserir.Click += SalvarHandler;
                BtnEditar.Click += CancelarHandler;
                // Desabilitar campos
                CmbEntidade.Enabled = false;
                TxtNome.Enabled = true;
                // Marcar que estamos salvando
                EhSalvando = true;
            }
            else
            {
                BtnInserir.Text = "Inserir";
                BtnInserir.Image = Properties.Resources.inserir;
                BtnEditar.Text = "Editar";
                BtnEditar.Image = Properties.Resources.editar;
                BtnExcluir.Visible = true;
                BtnFechar.Visible = true;
                // Alterar métodos dos botões
                BtnInserir.Click -= SalvarHandler;
                BtnEditar.Click -= CancelarHandler;
                BtnInserir.Click += InserirHandler;
                BtnEditar.Click += EditarHandler;
                // Habilitar campos
                CmbEntidade.Enabled = true;
                TxtNome.Enabled = false;
                // Marcar que não estamos salvando
                EhSalvando = false;
            }
        }
        private void Fechar(object sender, FormClosingEventArgs e)
        {
            if (EhSalvando)
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja fechar o formulário? As alterações não salvas serão perdidas.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
