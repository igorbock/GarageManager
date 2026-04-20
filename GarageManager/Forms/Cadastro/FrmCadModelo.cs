using GarageManager.Database;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GarageManager.Forms.Cadastro
{
    public partial class FrmCadModelo : Form
    {
        private DataTable DataSourceEntidade { get; set; }
        private DataTable DataSourceMarca { get; set; }
        private EventHandler InserirHandler { get; set; }
        private EventHandler EditarHandler { get; set; }
        private EventHandler SalvarHandler { get; set; }
        private EventHandler CancelarHandler { get; set; }
        private bool EhSalvando { get; set; }

        public FrmCadModelo()
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
                // Busca os valores no banco
                DataSourceEntidade = DatabaseManager.Consultar("SELECT id as \"ID\", nome as \"DESCRICAO\", id_marca as \"ID_MARCA\" FROM modelo_veiculo");
                DataSourceMarca = DatabaseManager.Consultar("SELECT id as \"ID\", nome as \"DESCRICAO\" FROM marca_veiculo");
                // Preenche os controles
                CmbEntidade.DataSource = DataSourceEntidade;
                CmbEntidade.SelectedIndex = -1;
                CmbMarca.DataSource = DataSourceMarca;
                CmbMarca.SelectedIndex = -1;
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
                CmbMarca.SelectedValue = valor.Field<long>("ID_MARCA").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LimparCampos()
        {
            TxtNome.Text = string.Empty;
            CmbMarca.SelectedIndex = -1;
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
                var dataSource = DatabaseManager.Consultar($"SELECT id as \"ID\", nome as \"DESCRICAO\", id_marca as \"ID_MARCA\" FROM modelo_veiculo WHERE id = {selected}");
                if (dataSource.Rows.Count > 0)
                {
                    TxtNome.Text = dataSource.Rows[0]["DESCRICAO"].ToString();
                    CmbMarca.SelectedItem = dataSource.Rows[0]["ID_MARCA"].ToString();
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
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir este modelo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.No)
                    return;

                var modelo = CmbEntidade.SelectedValue;
                DatabaseManager.Executar($"DELETE FROM modelo_veiculo WHERE id={modelo}");
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
                //Validação
                if (string.IsNullOrEmpty(TxtNome.Text))
                    throw new Exception("Preencha o campo de nome");
                if (CmbMarca.SelectedItem == null)
                    throw new Exception("Preencha o campo de marca");

                if (CmbEntidade.SelectedItem == null)
                {
                    var marca = (DataRowView)CmbMarca.SelectedItem;
                    DatabaseManager.Executar($"INSERT INTO modelo_veiculo(nome, id_marca) VALUES('{TxtNome.Text}',{marca.Row.Field<long>("ID")})");
                }
                else
                {
                    var selected = CmbEntidade.SelectedValue;
                    var marca = (DataRowView)CmbMarca.SelectedItem;
                    DatabaseManager.Executar($"UPDATE modelo_veiculo SET nome='{TxtNome.Text}', id_marca={marca.Row.Field<long>("ID")} WHERE id={selected}");
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
                CmbMarca.Enabled = true;
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
                CmbMarca.Enabled= false;
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
