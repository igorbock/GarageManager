using System;
using System.Drawing;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmAbrirOS : Form
    {
        public FrmAbrirOS()
        {
            InitializeComponent();
        }

        private void FrmAbrirOS_Load(object sender, EventArgs e)
        {
            ResetarFormulario();
        }

        private void FrmAbrirOS_Activated(object sender, EventArgs e)
        {
            AtualizarIdEData();
        }

        private void AtualizarIdEData()
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
        }

        private void ResetarFormulario()
        {
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

            AtualizarIdEData();
        }

        private void Button_salvar_Click(object sender, EventArgs e)
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

                ResetarFormulario();
            }
        }

        private void TextBox_placa_Enter(object sender, EventArgs e)
        {
            if (textBox_placa.Text == "Placa" || textBox_placa.Text == "PLACA")
            {
                textBox_placa.Text = "";
                textBox_placa.CharacterCasing = CharacterCasing.Upper;

                textBox_placa.ForeColor = Color.Black;
            }
        }

        private void TextBox_placa_Leave(object sender, EventArgs e)
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