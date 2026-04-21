using GarageManager.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GarageManager.Forms.Cadastro
{
    public partial class FrmCadPessoa : Form
    {
        private DataTable DataSourceEntidade { get; set; }
        private EventHandler InserirHandler { get; set; }
        private EventHandler EditarHandler { get; set; }
        private EventHandler SalvarHandler { get; set; }
        private EventHandler CancelarHandler { get; set; }
        private bool EhSalvando { get; set; }

        public FrmCadPessoa()
        {
            InitializeComponent();
            // Eventos
            Load += (s, e) => CarregarEntidades();
            FormClosing += Fechar;
            CmbEntidade.SelectedValueChanged += (s, e) => Selecionar();
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
                DataSourceEntidade = DatabaseManager.Consultar("SELECT id as \"ID\", nome as \"DESCRICAO\", telefone as \"TELEFONE\", email as \"EMAIL\" FROM pessoa");
                CmbEntidade.DataSource = DataSourceEntidade;
                CmbEntidade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Selecionar()
        {
            try
            {
                var idSelecionado = CmbEntidade.SelectedValue;
                if (idSelecionado == null)
                {
                    LimparCampos();
                    return;
                }
                var int64Id = long.Parse(idSelecionado.ToString());
                var valor = DataSourceEntidade.AsEnumerable().FirstOrDefault(a => a.Field<long>("ID") == int64Id);
                if (valor == null)
                {
                    LimparCampos();
                    return;
                }
                TxtNome.Text = valor.Field<string>("DESCRICAO").ToString();
                TxtTelefone.Text = valor.Field<string>("TELEFONE").ToString();
                TxtEmail.Text = valor.Field<string>("EMAIL").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            TxtNome.Text = string.Empty;
            TxtTelefone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
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
                var selected = CmbEntidade.SelectedValue;
                var int64Id = long.Parse(selected.ToString());
                var valor = DataSourceEntidade.AsEnumerable().FirstOrDefault(a => a.Field<long>("ID") == int64Id);
                if (valor == null)
                {
                    LimparCampos();
                    return;
                }
                TxtNome.Text = valor.Field<string>("DESCRICAO").ToString();
                TxtTelefone.Text = valor.Field<string>("TELEFONE").ToString();
                TxtEmail.Text = valor.Field<string>("EMAIL").ToString();
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
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir esta pessoa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.No)
                    return;

                var selected = CmbEntidade.SelectedValue;
                DatabaseManager.Executar($"DELETE FROM pessoa WHERE id={selected}");
                LimparCampos();
                CarregarEntidades();
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
                    DatabaseManager.Executar($"INSERT INTO pessoa(nome, telefone, email) VALUES('{TxtNome.Text}', '{TxtTelefone.Text}', '{TxtEmail.Text}')");
                }
                else
                {
                    var selected = CmbEntidade.SelectedValue;
                    DatabaseManager.Executar($"UPDATE pessoa SET nome='{TxtNome.Text}', telefone='{TxtTelefone.Text}', email='{TxtEmail.Text}' WHERE id={selected}");
                }
                LimparCampos();
                AlterarBotoes(false);
                CarregarEntidades();
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
                // Desabilitar campos para evitar mudanças de contexto
                CmbEntidade.Enabled = false;
                TxtNome.Enabled = true;
                TxtTelefone.Enabled = true;
                TxtEmail.Enabled = true;
                // Marcar que está salvando para evitar mudanças de contexto
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
                // Habilitar campos para permitir mudanças de contexto
                CmbEntidade.Enabled = true;
                TxtNome.Enabled = false;
                TxtTelefone.Enabled = false;
                TxtEmail.Enabled = false;
                // Marcar que não está salvando para permitir mudanças de contexto
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
