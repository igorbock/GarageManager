using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            label_versao.Text = "Versão " + Application.ProductVersion;
        }

        private void Button_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                string status = null;
                if (radioButton_aguardo.Checked)
                {
                    status = radioButton_aguardo.Text;
                }
                else if (radioButton_servico.Checked)
                {
                    status = radioButton_servico.Text;
                }

                using (var conn = GarageDb.OpenConnection())
                {
                    conn.Execute(
                        @"INSERT INTO OrdemServico
                            (HoraInicio, DataInicio, Placa_veiculo, Modelo_veiculo, Cor_veiculo, Ano_veiculo,
                             Km_veiculo, Nome_cliente, Telefone_cliente, Servicos_esperados, Status)
                          VALUES
                            (@horaInicio, @dataInicio, @placa, @modelo, @cor, @ano,
                             @km, @nome, @telefone, @servicos, @status)",
                        new
                        {
                            horaInicio = DateTime.Now.ToShortTimeString(),
                            dataInicio = DateTime.Now.ToShortDateString(),
                            placa = textBox_placa.Text,
                            modelo = textBox_modelo.Text,
                            cor = textBox_cor.Text,
                            ano = textBox_ano.Text,
                            km = textBox_km.Text,
                            nome = textBox_nome.Text,
                            telefone = textBox_telefone.Text,
                            servicos = textBox_servicos.Text,
                            status
                        });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível abrir a ordem de serviço\nErro: " + exception.Message, "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("A ordem de serviço foi aberta com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabControl1.SelectedTab = tabPage_home;
            }
        }

        private void TabPage_abrirOS_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    int id_ordemServico = conn.QuerySingle<int>("SELECT COALESCE(MAX(Id), 0) + 1 FROM OrdemServico");
                    label_id.Text = "#Id " + id_ordemServico;
                }
            }
            catch (Exception error)
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
        }

        private void TabPage_consultarAberta_Layout(object sender, LayoutEventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> ordemServicos = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             DataInicio AS Data,
                             Nome_cliente,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Status
                      FROM OrdemServico
                      WHERE Status NOT IN ('Pronta', 'Finalizada')
                      ORDER BY Id DESC");

                dataGridView1.DataSource = ordemServicos;
            }

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
        }

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

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 && dataGridView1.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                OS_Info ordemServico = new OS_Info(id) { MainForm = this };
                ordemServico.Show();
            }
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            OS_Info ordemServico = new OS_Info(id) { MainForm = this };
            ordemServico.Show();
        }

        private void TabPage_consultarEncerrada_Layout(object sender, LayoutEventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> ordemServicos = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             DataFim AS Data,
                             Nome_cliente,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Status
                      FROM OrdemServico
                      WHERE Status = 'Pronta'
                      ORDER BY Id DESC");

                dataGridView_encerradas.DataSource = ordemServicos;
            }

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

            OS_Info ordemServico = new OS_Info(id) { MainForm = this };
            ordemServico.Show();
        }

        private void DataGridView_encerradas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 && dataGridView_encerradas.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView_encerradas.CurrentRow.Cells["Id"].Value);

                OS_Info ordemServico = new OS_Info(id) { MainForm = this };
                ordemServico.Show();
            }
        }

        private void TextBox_pesquisaPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status,
                                 DataInicio AS Data
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                            AND Status NOT IN ('Pronta', 'Finalizada')
                          ORDER BY Id DESC",
                        new { placa = textBox_pesquisaPlacaAberta.Text });

                    dataGridView1.DataSource = pesquisa;

                    if (pesquisa.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_pesquisaPlacaAberta.Text = "";
                    }
                }
            }
        }

        private void TabPage_historico_Layout(object sender, LayoutEventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> load = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             (DataInicio || ' - ' || DataFim) AS Data,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Nome_cliente,
                             Status
                      FROM OrdemServico
                      WHERE Status = 'Finalizada'
                      ORDER BY Id DESC");

                dataGridView_historico.DataSource = load;
            }

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
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                            AND Status = 'Pronta'
                          ORDER BY Id DESC",
                        new { placa = textBox_pesquisaPlacaEncerrada.Text });

                    dataGridView_encerradas.DataSource = pesquisa;

                    if (pesquisa.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TextBox_pesquisaPlacaHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status,
                                 (DataInicio || ' - ' || DataFim) AS Data
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                            AND Status = 'Finalizada'
                          ORDER BY Id DESC",
                        new { placa = textBox_pesquisaPlacaHistorico.Text });

                    dataGridView_historico.DataSource = pesquisa;

                    if (pesquisa.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_pesquisaPlacaHistorico.Text = "";
                    }
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

                OS_Info ordemServico = new OS_Info(id) { MainForm = this };
                ordemServico.Show();
            }
        }

        private void DataGridView_historico_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_historico.CurrentRow.Cells["Id"].Value);

            OS_Info ordemServico = new OS_Info(id) { MainForm = this };
            ordemServico.Show();
        }

        private void TabPage_home_Layout(object sender, LayoutEventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                int emServico = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Em serviço'");
                int aguardando = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Aguardando serviço'");
                int prontas = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Pronta'");
                int finalizadas = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Finalizada'");

                string OrdensAbertasEmServico = emServico + " ordens de serviço em trabalho abertas.";
                string OrdensAbertasAguardando = aguardando + " ordens de serviço paradas ou aguardando trabalho.";
                string OrdensProntas = "Encontra-se " + prontas + " ordens de serviço prontas.";
                string OrdensFinalizadas = finalizadas + " ordens de serviço finalizadas.";

                label_homeInformacoes.Text = OrdensAbertasEmServico + "\n\n" + OrdensAbertasAguardando + "\n\n" + OrdensProntas + "\n\n" + OrdensFinalizadas;
            }
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
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisaVeiculo = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status,
                                 (DataInicio || ' - ' || DataFim) AS Data
                          FROM OrdemServico
                          WHERE LOWER(Modelo_veiculo) LIKE '%' || LOWER(@modelo) || '%'
                            AND Status = 'Finalizada'
                          ORDER BY Id DESC",
                        new { modelo = textBox_pesquisaVeiculoHistorico.Text.Trim() });

                    dataGridView_historico.DataSource = pesquisaVeiculo;

                    if (pesquisaVeiculo.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo modelo e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_pesquisaVeiculoHistorico.Text = "";
                    }
                }
            }
        }

        private void TextBox_pesquisaNomeHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisaNome = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status,
                                 (DataInicio || ' - ' || DataFim) AS Data
                          FROM OrdemServico
                          WHERE LOWER(Nome_cliente) LIKE '%' || LOWER(@nome) || '%'
                            AND Status = 'Finalizada'
                          ORDER BY Id DESC",
                        new { nome = textBox_pesquisaNomeHistorico.Text.Trim() });

                    dataGridView_historico.DataSource = pesquisaNome;

                    if (pesquisaNome.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo nome e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_pesquisaNomeHistorico.Text = "";
                    }
                }
            }
        }

        private void TextBox_placa_TextChanged(object sender, EventArgs e)
        {
            if(textBox_placa.TextLength == 7)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    OrdemServicoDTO placaCadastrada = conn.QueryFirstOrDefault<OrdemServicoDTO>(
                        @"SELECT Id,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Nome_cliente,
                                 Status
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                          ORDER BY Id DESC
                          LIMIT 1",
                        new { placa = textBox_placa.Text });

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
                    else if (placaCadastrada != null && placaCadastrada.Status != "Finalizada")
                    {
                        MessageBox.Show("Esta placa já tem um cadastro aberto. Confira os registros e procure pela ordem de serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_placa.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Este veículo é novo na oficina. Preencha os dados restantes.\n\nNão foi encontrado nenhum registro anterior.", "Novo veículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_modelo.Focus();
                    }
                }
            }
        }
    }
}