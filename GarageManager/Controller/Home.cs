using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data;
using Dominio;
using GarageManager.Controller;
using System.Data.Entity.Validation;

namespace GarageManager
{
    public partial class Form1 : Form
    {
        private GarageDbContext context;

        public Form1()
        {
            InitializeComponent();

            context = new GarageDbContext();

            label_versao.Text = "Versão " + Application.ProductVersion;
        }

        private void Button_salvar_Click(object sender, System.EventArgs e)
        {
            //Salvando uma nova ordem de serviço
            try
            {
                //Define o valor para o campo status do objeto OrdemServico
                string status = null;
                if (radioButton_aguardo.Checked)
                {
                    status = radioButton_aguardo.Text;
                }
                else if (radioButton_servico.Checked)
                {
                    status = radioButton_servico.Text;
                }

                //Instancia o objeto e define as suas propriedades
                OrdemServico ordemServico = new OrdemServico()
                {
                    DataInicio = DateTime.Now.ToShortDateString(),
                    HoraInicio = DateTime.Now.ToShortTimeString(),
                    Placa_veiculo = textBox_placa.Text,
                    Modelo_veiculo = textBox_modelo.Text,
                    Cor_veiculo = textBox_cor.Text,
                    Ano_veiculo = textBox_ano.Text,
                    Km_veiculo = textBox_km.Text,
                    Nome_cliente = textBox_nome.Text,
                    Telefone_cliente = textBox_telefone.Text,
                    Servicos_esperados = textBox_servicos.Text,
                    Status = status
                };

                context.OrdemServico.Add(ordemServico);

                context.SaveChanges();
            }
            catch (DbEntityValidationException exception)
            {
                //Menssagem do exception 
                MessageBox.Show("Não foi possível abrir a ordem de serviço\nErro: " + exception.Message, "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            finally
            {
                //Em caso de sucesso
                MessageBox.Show("A ordem de serviço foi aberta com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Passando para uma nova tab
                tabControl1.SelectedTab = tabPage_home;
            }
        }

        private void TabPage_abrirOS_Layout(object sender, LayoutEventArgs e)
        {
            //Define os valores para os controles quando a aba é aberta
            context = new GarageDbContext();

            try
            {
                int id_ordemServico = context.OrdemServico.Count() + 1;
                label_id.Text = "#Id " + id_ordemServico;
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro: " + error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            label_dataInicio.Text = DateTime.Now.ToShortDateString();
            label_horaInicio.Text = DateTime.Now.ToShortTimeString();

            textBox_placa.Text = "Placa";
            textBox_placa.ForeColor = Color.DarkBlue;
            textBox_modelo.Text = "Modelo do veículo";
            textBox_modelo.ForeColor = Color.DarkBlue;
            textBox_cor.Text = "Cor";
            textBox_cor.ForeColor = Color.DarkBlue;
            textBox_ano.Text = "Ano";
            textBox_ano.ForeColor = Color.DarkBlue;
            textBox_km.Text = "Km";
            textBox_km.ForeColor = Color.DarkBlue;
            textBox_servicos.Text = "Serviços esperados";
            textBox_servicos.ForeColor = Color.DarkBlue;
            textBox_nome.Text = "Nome";
            textBox_nome.ForeColor = Color.DarkBlue;
            textBox_telefone.Text = "Telefone";
            textBox_telefone.ForeColor = Color.DarkBlue;

            radioButton_aguardo.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'garageDatabaseOSAbertaDataSet.OrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            //this.ordemServicoTableAdapter.Fill(this.garageDatabaseOSAbertaDataSet.OrdemServico);

        }

        private void TabPage_consultarAberta_Layout(object sender, LayoutEventArgs e)
        {
            //Faz a busca pelas Ordens de Serviço
            IEnumerable<OrdemServicoDTO> ordemServicos = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Data = p.DataInicio, Nome_cliente = p.Nome_cliente, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Status = p.Status }).Where(p => p.Status != "Pronta" && p.Status != "Finalizada").OrderByDescending(p => p.Id).ToList();
            dataGridView1.DataSource = ordemServicos;

            dataGridView1.Columns[0].HeaderText = "Identificador";
            dataGridView1.Columns[1].HeaderText = "Data de ínicio";
            dataGridView1.Columns[2].HeaderText = "Nome";
            dataGridView1.Columns[2].Width      = 150;
            dataGridView1.Columns[3].HeaderText = "Placa";
            dataGridView1.Columns[4].HeaderText = "Modelo";
            dataGridView1.Columns[5].HeaderText = "Cor";
            dataGridView1.Columns[6].HeaderText = "Ano";
            dataGridView1.Columns[7].HeaderText = "Status";
            dataGridView1.Columns[7].Width      = 200;

            //ordemServicoTableAdapter.Fill(garageDatabaseOSAbertaDataSet.OrdemServico);
        }


        //REALIZANDO O CLIQUE NOS BOTÕES
        //
        private void Button1_Click(object sender, System.EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_abrirOS;
        }

        private void Button_consultarAbertas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_consultarAberta;
        }

        private void Button_consultarEncerradas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_consultarEncerrada;
        }

        private void Button_historico_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage_historico;
        }

        //Adicionando placeholder / hint nos TextBoxes
        //
        private void TextBox_placa_Enter(object sender, System.EventArgs e)
        {
            if (textBox_placa.Text == "Placa" || textBox_placa.Text == "PLACA")
            {
                textBox_placa.Text = "";
                textBox_placa.CharacterCasing = CharacterCasing.Upper;

                textBox_placa.ForeColor = Color.Black;
            }
        }

        private void TextBox_placa_Leave(object sender, System.EventArgs e)
        {
            if (textBox_placa.Text == "")
            {
                textBox_placa.Text = "Placa";
                textBox_placa.CharacterCasing = CharacterCasing.Normal;

                textBox_placa.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_modelo_Enter(object sender, EventArgs e)
        {
            if(textBox_modelo.Text == "Modelo do veículo")
            {
                textBox_modelo.Text = "";

                textBox_modelo.ForeColor = Color.Black;
            }
        }

        private void TextBox_modelo_Leave(object sender, EventArgs e)
        {
            if(textBox_modelo.Text == "")
            {
                textBox_modelo.Text = "Modelo do veículo";

                textBox_modelo.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_cor_Enter(object sender, EventArgs e)
        {
            if(textBox_cor.Text == "Cor")
            {
                textBox_cor.Text = "";

                textBox_cor.ForeColor = Color.Black;
            }
        }

        private void TextBox_cor_Leave(object sender, EventArgs e)
        {
            if(textBox_cor.Text == "")
            {
                textBox_cor.Text = "Cor";

                textBox_cor.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_ano_Enter(object sender, EventArgs e)
        {
            if(textBox_ano.Text == "Ano")
            {
                textBox_ano.Text = "";

                textBox_ano.ForeColor = Color.Black;
            }
        }

        private void TextBox_ano_Leave(object sender, EventArgs e)
        {
            if(textBox_ano.Text == "")
            {
                textBox_ano.Text = "Ano";

                textBox_ano.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_km_Enter(object sender, EventArgs e)
        {
            if(textBox_km.Text == "Km")
            {
                textBox_km.Text = "";

                textBox_km.ForeColor = Color.Black;
            }
        }

        private void TextBox_km_Leave(object sender, EventArgs e)
        {
            if(textBox_km.Text == "")
            {
                textBox_km.Text = "Km";

                textBox_km.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_servicos_Enter(object sender, EventArgs e)
        {
            if(textBox_servicos.Text == "Serviços esperados")
            {
                textBox_servicos.Text = "";

                textBox_servicos.ForeColor = Color.Black;
            }
        }

        private void TextBox_servicos_Leave(object sender, EventArgs e)
        {
            if(textBox_servicos.Text == "")
            {
                textBox_servicos.Text = "Serviços esperados";

                textBox_servicos.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_nome_Enter(object sender, EventArgs e)
        {
            if(textBox_nome.Text == "Nome")
            {
                textBox_nome.Text = "";

                textBox_nome.ForeColor = Color.Black;
            }
        }

        private void TextBox_nome_Leave(object sender, EventArgs e)
        {
            if(textBox_nome.Text == "")
            {
                textBox_nome.Text = "Nome";

                textBox_nome.ForeColor = Color.DarkBlue;
            }
        }

        private void TextBox_telefone_Enter(object sender, EventArgs e)
        {
            if(textBox_telefone.Text == "Telefone")
            {
                textBox_telefone.Text = "";

                textBox_telefone.ForeColor = Color.Black;
            }
        }

        private void TextBox_telefone_Leave(object sender, EventArgs e)
        {
            if(textBox_telefone.Text == "")
            {
                textBox_telefone.Text = "Telefone";

                textBox_telefone.ForeColor = Color.DarkBlue;
            }
        }


        //Quando o usuário clica em alguma linha ou célula
        //Com o teclado *Enter
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 && dataGridView1.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                OS_Info ordemServico = new OS_Info(id) { Home = this};
                ordemServico.Show();
            }

            
        }
        //Com o mouse *DoubleClick
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            OS_Info ordemServico = new OS_Info(id) { Home = this};
            ordemServico.Show();
        }

        private void TabPage_consultarEncerrada_Layout(object sender, LayoutEventArgs e)
        {
            //Faz a busca pelas ordens de serviço com status encerrado
            IEnumerable<OrdemServicoDTO> ordemServicos = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Data = p.DataFim, Nome_cliente = p.Nome_cliente, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Status = p.Status }).Where(p => p.Status == "Pronta").OrderByDescending(p => p.Id).ToList();
            dataGridView_encerradas.DataSource = ordemServicos;

            dataGridView_encerradas.Columns[0].HeaderText = "Identificador";
            dataGridView_encerradas.Columns[1].HeaderText = "Data de encerramento";
            dataGridView_encerradas.Columns[1].Width      = 180;
            dataGridView_encerradas.Columns[2].HeaderText = "Nome";
            dataGridView_encerradas.Columns[2].Width      = 150;
            dataGridView_encerradas.Columns[3].HeaderText = "Placa";
            dataGridView_encerradas.Columns[4].HeaderText = "Modelo";
            dataGridView_encerradas.Columns[5].HeaderText = "Cor";
            dataGridView_encerradas.Columns[6].HeaderText = "Ano";
            dataGridView_encerradas.Columns[7].HeaderText = "Status";
        }

        private void DataGridView_encerradas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_encerradas.CurrentRow.Cells["Id"].Value);

            OS_Info ordemServico = new OS_Info(id) { Home = this };
            ordemServico.Show();
        }

        private void DataGridView_encerradas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 && dataGridView_encerradas.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_encerradas.CurrentRow.Cells["Id"].Value);

                OS_Info ordemServico = new OS_Info(id) { Home = this};
                ordemServico.Show();
            }
        }
        private void TextBox_pesquisaPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IEnumerable<OrdemServicoDTO> pesquisa = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status, Data = p.DataInicio}).Where(p => p.Placa_veiculo == textBox_pesquisaPlacaAberta.Text && p.Status != "Pronta" && p.Status != "Finalizada").OrderByDescending(p => p.Id).ToList();
                dataGridView1.DataSource = pesquisa;

                if(pesquisa.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaPlacaAberta.Text = "";
                }
            }
        }
        private void TabPage_historico_Layout(object sender, LayoutEventArgs e)
        {
            //Faz a busca pelas ordens de serviço finalizadas
            IEnumerable<OrdemServicoDTO> load = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Data = p.DataInicio + " - " + p.DataFim, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status }).Where(p => p.Status == "Finalizada").OrderByDescending(p => p.Id).ToList();
            dataGridView_historico.DataSource = load;

            dataGridView_historico.Columns[0].HeaderText = "Identificador";
            dataGridView_historico.Columns[1].HeaderText = "Início / Encerramento";
            dataGridView_historico.Columns[1].Width      = 180;
            dataGridView_historico.Columns[2].HeaderText = "Nome";
            dataGridView_historico.Columns[2].Width      = 150;
            dataGridView_historico.Columns[3].HeaderText = "Placa";
            dataGridView_historico.Columns[4].HeaderText = "Modelo";
            dataGridView_historico.Columns[5].HeaderText = "Cor";
            dataGridView_historico.Columns[6].HeaderText = "Ano";
            dataGridView_historico.Columns[7].HeaderText = "Status";
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IEnumerable<OrdemServicoDTO> pesquisa = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status }).Where(p => p.Placa_veiculo == textBox_pesquisaPlacaEncerrada.Text && p.Status == "Pronta").OrderByDescending(p => p.Id).ToList();
                dataGridView_encerradas.DataSource = pesquisa;

                if (pesquisa.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TextBox_pesquisaPlacaHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IEnumerable<OrdemServicoDTO> pesquisa = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status, Data = p.DataInicio + " - " + p.DataFim}).Where(p => p.Placa_veiculo == textBox_pesquisaPlacaHistorico.Text && p.Status == "Finalizada").OrderByDescending(p => p.Id).ToList();
                dataGridView_historico.DataSource = pesquisa;

                if (pesquisa.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaPlacaHistorico.Text = "";
                }
            }
        }

        private void TextBox_pesquisaPlacaAberta_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaAberta.Text = "";
        }

        private void TextBox_pesquisaPlacaEncerrada_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaEncerrada.Text = "";
        }

        private void TextBox_pesquisaPlacaHistorico_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaHistorico.Text = "";
        }

        private void DataGridView_historico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && dataGridView_historico.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_historico.CurrentRow.Cells["Id"].Value);

                OS_Info ordemServico = new OS_Info(id) { Home = this };
                ordemServico.Show();
            }
        }

        private void DataGridView_historico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_historico.CurrentRow.Cells["Id"].Value);

            OS_Info ordemServico = new OS_Info(id) { Home = this };
            ordemServico.Show();
        }

        private void TabPage_home_Layout(object sender, LayoutEventArgs e)
        {
            context = new GarageDbContext();

            string OrdensAbertasEmServico = context.OrdemServico.Where(p => p.Status == "Em serviço").Count() + " ordens de serviço em trabalho abertas.";
            string OrdensAbertasAguardando = context.OrdemServico.Where(p => p.Status == "Aguardando serviço").Count() + " ordens de serviço paradas ou aguardando trabalho.";
            string OrdensProntas = "Encontra-se " + context.OrdemServico.Where(p => p.Status == "Pronta").Count() + " ordens de serviço prontas.";
            string OrdensFinalizadas = context.OrdemServico.Where(p => p.Status == "Finalizada").Count() + " ordens de serviço finalizadas.";

            label_homeInformacoes.Text = OrdensAbertasEmServico + "\n\n" + OrdensAbertasAguardando + "\n\n" + OrdensProntas + "\n\n" + OrdensFinalizadas;

            
        }

        private void Label_versao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductVersion + "\n\n" +
                "***Atualizações***\n" +
                "--> Campos de buscas para O.S. abertas, prontas e encerradas\n" +
                "--> Regras para inserção de produtos incrementada nas ordens de serviço\n\n" +
                "***Reparos***\n" +
                "--> O.S. pode ser encerrada somente quando estiver pronta", "Garage Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TextBox_pesquisaVeiculoHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IEnumerable<OrdemServicoDTO> pesquisaVeiculo = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status, Data = p.DataInicio + " - " + p.DataFim }).Where(p => p.Modelo_veiculo.ToUpper().Contains(textBox_pesquisaVeiculoHistorico.Text.ToUpper().Trim()) && p.Status == "Finalizada").OrderByDescending(p => p.Id).ToList();
                dataGridView_historico.DataSource = pesquisaVeiculo;

                if(pesquisaVeiculo.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo modelo e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaVeiculoHistorico.Text = "";
                }
            }
        }

        private void TextBox_pesquisaNomeHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                IEnumerable<OrdemServicoDTO> pesquisaNome = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status, Data = p.DataInicio + " - " + p.DataFim }).Where(p => p.Nome_cliente.ToUpper().Contains(textBox_pesquisaNomeHistorico.Text.ToUpper().Trim()) && p.Status == "Finalizada").OrderByDescending(p => p.Id).ToList();
                dataGridView_historico.DataSource = pesquisaNome;

                if(pesquisaNome.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo nome e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaNomeHistorico.Text = "";
                }
            }
        }

        private void TextBox_placa_TextChanged(object sender, EventArgs e)
        {
            if(textBox_placa.TextLength == 7)
            {
                try
                {
                    OrdemServicoDTO placaCadastrada = context.OrdemServico.Select(p => new OrdemServicoDTO { Id = p.Id, Placa_veiculo = p.Placa_veiculo, Modelo_veiculo = p.Modelo_veiculo, Cor_veiculo = p.Cor_veiculo, Ano_veiculo = p.Ano_veiculo, Nome_cliente = p.Nome_cliente, Status = p.Status }).Where(p => p.Placa_veiculo == textBox_placa.Text).OrderByDescending(p => p.Id).First();

                    if (placaCadastrada != null && placaCadastrada.Status == "Finalizada")
                    {
                        MessageBox.Show("Esta placa já realizou serviços na oficina. Confira os dados do cliente e preencha o restante do formulário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox_modelo.ForeColor = Color.Black;
                        textBox_cor.ForeColor = Color.Black;
                        textBox_ano.ForeColor = Color.Black;
                        textBox_nome.ForeColor = Color.Black;

                        textBox_modelo.Text = placaCadastrada.Modelo_veiculo;
                        textBox_cor.Text = placaCadastrada.Cor_veiculo;
                        textBox_ano.Text = placaCadastrada.Ano_veiculo;
                        textBox_nome.Text = placaCadastrada.Nome_cliente;

                        textBox_km.Focus();
                    }
                    else if (placaCadastrada.Status != "Finalizada")
                    {
                        MessageBox.Show("Esta placa já tem um cadastro aberto. Confira os registros e procure pela ordem de serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_placa.Text = "";
                    }
                } catch(InvalidOperationException error)
                {
                    MessageBox.Show("Este veículo é novo na oficina. Preencha os dados restantes.\n\nNão foi encontrado nenhum registro anterior. " + error.Message + ".", "Novo veículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_modelo.Focus();
                }
                
            }
        }
    }
}
