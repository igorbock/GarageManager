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
    public partial class OS_Info : Form
    {
        public int id_os;
        private OrdemServico ordemServico;
        private List<PecaDTO> pecas;
        ToolStripStatusLabel info;
        ToolStripStatusLabel info_encerrar;
        decimal valorTotal = 0;

        public Home MainForm;

        public OS_Info(int Id)
        {
            InitializeComponent();
            id_os = Id;
            textBox_id.Text = "ID #" + id_os.ToString();

            using (var conn = GarageDb.OpenConnection())
            {
                ordemServico = conn.QuerySingleOrDefault<OrdemServico>(
                    "SELECT * FROM OrdemServico WHERE Id = @id", new { id = id_os });
            }

            info = new ToolStripStatusLabel
            {
               Text = "Para remover um item, selecione-o e aperte F7"
            };
            info_encerrar = new ToolStripStatusLabel
            {
               Text = "Para encerrar a O.S. aperte o botão F2"
            };
        }

        private void TextBox_realizados_Enter(object sender, EventArgs e)
        {
            if(textBox_realizados.Text == "Observações e alegações são itens importantes para o histórico do veículo")
            {
                textBox_realizados.Text = "";

                textBox_realizados.ForeColor = Color.Black;
            }
        }

        private void TextBox_realizados_Leave(object sender, EventArgs e)
        {
            if(textBox_realizados.Text == "")
            {
                textBox_realizados.Text = "Observações e alegações são itens importantes para o histórico do veículo";

                textBox_realizados.ForeColor = Color.Silver;
            }
        }

        private void OS_Info_Load(object sender, EventArgs e)
        {
            CarregarPecas();

            if(ordemServico.Status == "Pronta" || ordemServico.Status == "Finalizada")
            {
                textBox_realizados.Enabled = false;
                comboBox_status.Enabled = false;
                textBox_mecanico.Enabled = false;
                button_salvar.Enabled = false;
                button_adicionar.Enabled = false;
                dataGridView_pecas_ordem.Enabled = true;
                label_status.ForeColor = Color.Red;
                checkBox_lavado.Enabled = false;

                if(ordemServico.Status == "Finalizada")
                {
                    checkBox_voltar.Enabled = false;
                    checkBox_voltar.Visible = false;
                    button_alterar.Text = "Forma Pagamento";
                }
                else
                {
                    checkBox_voltar.Enabled = true;
                    checkBox_voltar.Visible = true;
                    statusStrip_infoOS.Items.Add(info_encerrar);
                    button_alterar.Enabled = false;
                }

                PreencherControles(exibirDataFinal: true);
                textBox_total.Text = valorTotal.ToString();
            }
            else
            {
                checkBox_voltar.Enabled = false;
                checkBox_voltar.Visible = false;

                PreencherControles(exibirDataFinal: false);
                statusStrip_infoOS.Items.Add(info_encerrar);
                textBox_total.Text = "R$ " + valorTotal.ToString();
            }
        }

        private void PreencherControles(bool exibirDataFinal)
        {
            textBox_dataInicio.Text = ordemServico.DataInicio;
            textBox_horaInicio.Text = ordemServico.HoraInicio;
            textBox_placa.Text = ordemServico.Placa_veiculo;
            textBox_veiculo.Text = ordemServico.Modelo_veiculo;
            textBox_cor.Text = ordemServico.Cor_veiculo;
            textBox_ano.Text = ordemServico.Ano_veiculo;
            textBox_km.Text = ordemServico.Km_veiculo;
            textBox_servicos.Text = ordemServico.Servicos_esperados;
            textBox_nome.Text = ordemServico.Nome_cliente;
            textBox_telefone.Text = ordemServico.Telefone_cliente;
            textBox_realizados.Text = ordemServico.Servicos_realizados;
            textBox_dataFinal.Text = ordemServico.DataFim;
            textBox_horaFinal.Text = ordemServico.HoraFim;
            label_status.Text = ordemServico.Status;
            comboBox_status.SelectedItem = ordemServico.Status;
            textBox_mecanico.Text = ordemServico.Mecanico;
            checkBox_lavado.Checked = ordemServico.Lavacao;

            if (!exibirDataFinal)
            {
                textBox_dataFinal.Text = "";
                textBox_horaFinal.Text = "";
            }
        }

        private void CarregarPecas()
        {
            using (var conn = GarageDb.OpenConnection())
            {
                pecas = conn.Query<PecaDTO>(
                    @"SELECT Id, Descricao_peca, Marca_peca, Quantidade_peca, Valor_peca, Valor_total, OrdemServicoId
                      FROM Pecas
                      WHERE OrdemServicoId = @id",
                    new { id = id_os }).ToList();
            }

            dataGridView_pecas_ordem.DataSource = pecas;

            dataGridView_pecas_ordem.Columns[0].Name = "Id";
            dataGridView_pecas_ordem.Columns[0].Visible = false;
            dataGridView_pecas_ordem.Columns[1].HeaderText = "Descrição";
            dataGridView_pecas_ordem.Columns[1].Width = 300;
            dataGridView_pecas_ordem.Columns[2].HeaderText = "Marca";
            dataGridView_pecas_ordem.Columns[2].Width = 200;
            dataGridView_pecas_ordem.Columns[3].HeaderText = "Quantidade";
            dataGridView_pecas_ordem.Columns[4].HeaderText = "Valor unitário";
            dataGridView_pecas_ordem.Columns[5].HeaderText = "Sub-Total";
            dataGridView_pecas_ordem.Columns[5].Name = "subTotal";
            dataGridView_pecas_ordem.Columns[6].Visible = false;
            dataGridView_pecas_ordem.Columns["OrdemServicoId"].Visible = false;

            valorTotal = 0;
            foreach (DataGridViewRow row in dataGridView_pecas_ordem.Rows)
            {
                if (row.Cells["subTotal"].Value != null)
                {
                    valorTotal += Convert.ToDecimal(row.Cells["subTotal"].Value);
                }
            }
        }

        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            PecasMaoObra novas = new PecasMaoObra() { id_ordem = id_os, form = this, MainForm = MainForm, MdiParent = this.MdiParent };
            novas.Show();
        }

        private void DataGridView_pecas_ordem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && dataGridView_pecas_ordem.Rows.Count > 0 && ordemServico.Status != "Finalizada" && ordemServico.Status != "Pronta")
            {
                Dialogo dialogo = new Dialogo() { identificador = Convert.ToInt32(dataGridView_pecas_ordem.CurrentRow.Cells["Id"].Value), form = this, MainForm = MainForm, MdiParent = this.MdiParent };
                dialogo.Show();

                dataGridView_pecas_ordem.Update();
            }
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            string statusSelecionado = comboBox_status.SelectedItem.ToString();

            if (ordemServico.Status.Equals(statusSelecionado))
            {
                if (ordemServico.Servicos_realizados != textBox_realizados.Text || ordemServico.Mecanico != textBox_mecanico.Text)
                {
                    SalvarServicoRealizado();
                    MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi realizada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                switch (statusSelecionado)
                {
                    case "Em serviço":
                        AlterarStatus("Em serviço");
                        MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Aguardando serviço":
                        AlterarStatus("Aguardando serviço");
                        MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Pronta":
                        if (DialogResult.Yes == MessageBox.Show("Você deseja realmente tornar esta ordem de serviço pronta?\n\nValor total: " + textBox_total.Text + "\nMecânico: " + textBox_mecanico.Text, "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            EncerrarComoPronta();
                            MessageBox.Show("A ordem de serviço foi encerrada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        break;
                }
            }
        }

        private void SalvarServicoRealizado()
        {
            ordemServico.Servicos_realizados = textBox_realizados.Text;
            ordemServico.Mecanico = textBox_mecanico.Text;
            ordemServico.Lavacao = checkBox_lavado.Checked;
            new Repository<OrdemServico>().Update(ordemServico);
        }

        private void AlterarStatus(string status)
        {
            ordemServico.Status = status;
            ordemServico.Mecanico = textBox_mecanico.Text;
            ordemServico.Servicos_realizados = textBox_realizados.Text;
            ordemServico.Lavacao = checkBox_lavado.Checked;
            new Repository<OrdemServico>().Update(ordemServico);
            label_status.Text = status;
        }

        private void EncerrarComoPronta()
        {
            ordemServico.Status = "Pronta";
            ordemServico.Mecanico = textBox_mecanico.Text;
            ordemServico.Servicos_realizados = textBox_realizados.Text;
            ordemServico.Lavacao = checkBox_lavado.Checked;
            ordemServico.DataFim = DateTime.Now.ToShortDateString();
            ordemServico.HoraFim = DateTime.Now.ToShortTimeString();
            new Repository<OrdemServico>().Update(ordemServico);
        }

        private void DataGridView_pecas_ordem_MouseHover(object sender, EventArgs e)
        {
            if(!statusStrip_infoOS.Items.Contains(info) && ordemServico.Status != "Finalizada" && pecas.Count > 0)
            {
                statusStrip_infoOS.Items.Add(info);
            }
            else
            {
                info.Text = "A ordem de serviço está aguardando peças";
                if (!statusStrip_infoOS.Items.Contains(info))
                {
                    statusStrip_infoOS.Items.Add(info);
                }
            }
        }

        private void DataGridView_pecas_ordem_MouseLeave(object sender, EventArgs e)
        {
            statusStrip_infoOS.Items.Remove(info);
        }

        private void OS_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox_voltar.Checked)
            {
                ordemServico.Status = "Em serviço";
                new Repository<OrdemServico>().Update(ordemServico);
                MessageBox.Show("A ordem de serviço está ativa novamente.", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.AbrirInicio();
            }
        }

        private void OS_Info_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                switch (ordemServico.Status)
                {
                    case "Pronta":
                        if (DialogResult.Yes == MessageBox.Show("Você deseja finalizar a ordem de serviço?", "Ordem de serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            ordemServico.Status = "Finalizada";
                            ordemServico.Mecanico = textBox_mecanico.Text;
                            ordemServico.Servicos_realizados = textBox_realizados.Text;
                            ordemServico.DataFim = DateTime.Now.ToShortDateString();
                            ordemServico.HoraFim = DateTime.Now.ToShortTimeString();
                            new Repository<OrdemServico>().Update(ordemServico);
                            MessageBox.Show("A ordem de serviço foi finalizada!\nPara realizar uma consulta procure pela placa no histórico.", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            MainForm.AbrirInicio();
                        }

                        break;

                    case "Finalizada":
                        MessageBox.Show("A ordem de serviço já está finalizada!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;

                    default:
                        MessageBox.Show("Você deve deixar o status da ordem de serviço como pronta!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                }
            }
        }

        private void Button_alterar_Click(object sender, EventArgs e)
        {
            if (button_alterar.Text == "Alterar dados" && ordemServico.Status != "Pronta")
            {
                HabilitarEdicaoDados();
                button_alterar.Text = "Retornar/Salvar";
            }
            else             if (button_alterar.Text == "Retornar/Salvar" && ordemServico.Status != "Pronta")
            {
                ordemServico.Modelo_veiculo = textBox_veiculo.Text;
                ordemServico.Cor_veiculo = textBox_cor.Text;
                ordemServico.Ano_veiculo = textBox_ano.Text;
                ordemServico.Km_veiculo = textBox_km.Text;
                ordemServico.Placa_veiculo = textBox_placa.Text;
                ordemServico.Servicos_esperados = textBox_servicos.Text;
                ordemServico.Nome_cliente = textBox_nome.Text;
                ordemServico.Telefone_cliente = textBox_telefone.Text;
                try
                {
                    new Repository<OrdemServico>().Update(ordemServico);
                    MessageBox.Show("Os dados foram alterados com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Não foi realizada nenhuma alteração nos dados!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DesabilitarEdicaoDados();
                button_alterar.Text = "Alterar dados";
            }

            if (button_alterar.Text == "Forma Pagamento" && ordemServico.Status == "Finalizada")
            {
                Pagamento parcela = new Pagamento() { id_os = id_os, MdiParent = this.MdiParent };
                parcela.Show();
            }
        }

        private void HabilitarEdicaoDados()
        {
            textBox_placa.Enabled = true;
            textBox_veiculo.Enabled = true;
            textBox_cor.Enabled = true;
            textBox_ano.Enabled = true;
            textBox_km.Enabled = true;
            textBox_servicos.Enabled = true;
            textBox_nome.Enabled = true;
            textBox_telefone.Enabled = true;

            textBox_realizados.Enabled = false;
            button_adicionar.Enabled = false;
            dataGridView_pecas_ordem.Enabled = false;
            textBox_mecanico.Enabled = false;
            comboBox_status.Enabled = false;
            button_salvar.Enabled = false;
            checkBox_lavado.Enabled = false;
        }

        private void DesabilitarEdicaoDados()
        {
            textBox_placa.Enabled = false;
            textBox_veiculo.Enabled = false;
            textBox_cor.Enabled = false;
            textBox_ano.Enabled = false;
            textBox_km.Enabled = false;
            textBox_servicos.Enabled = false;
            textBox_nome.Enabled = false;
            textBox_telefone.Enabled = false;

            textBox_realizados.Enabled = true;
            button_adicionar.Enabled = true;
            dataGridView_pecas_ordem.Enabled = true;
            textBox_mecanico.Enabled = true;
            comboBox_status.Enabled = true;
            button_salvar.Enabled = true;
            checkBox_lavado.Enabled = true;
        }

        private void CheckBox_lavado_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CheckBox_lavado_CheckStateChanged(object sender, EventArgs e)
        {
        }

        private void CheckBox_lavado_Click(object sender, EventArgs e)
        {
            try
            {
                ordemServico.Lavacao = checkBox_lavado.Checked;
                new Repository<OrdemServico>().Update(ordemServico);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Atributo lavação alterado com sucesso", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void imprimirOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Name = "Realizando a impressão";
            printPreviewDialog1.Document = printDocument_os;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument_os_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x1 = 100.00F;
            float y1 = 80.00F;
            float x = 100.00F;
            float y = 450.00F;

            e.Graphics.DrawString("Ordem de serviço: #000" + ordemServico.Id + " ---------- " + ordemServico.Status + "\n" +
                "\nPlaca: " + ordemServico.Placa_veiculo + "\nData de Inicio: " + ordemServico.DataInicio + " ----- Data de Saída: " + ordemServico.DataFim +
                "\n\nModelo do Veículo: " + ordemServico.Modelo_veiculo + " ----- Cor: " + ordemServico.Cor_veiculo + " ----- Ano: " + ordemServico.Ano_veiculo + " ----- Km: " + ordemServico.Km_veiculo +
                "\n\n----- Dados do Cliente ----- \nNome: " + ordemServico.Nome_cliente + "\nTelefone: " + ordemServico.Telefone_cliente +
                "\n\nServiços esperados: " + ordemServico.Servicos_esperados +
                "\n\nObservações: " + ordemServico.Servicos_realizados +
                "\n\nMecanico: " + ordemServico.Mecanico +
                "\n\nTotal: R$" + valorTotal +
                "\n\nPagamento: " + ordemServico.Pagamento +
                "\n\n ----- Peças ----- \n", this.Font, Brushes.Black, x1, y1, StringFormat.GenericTypographic);

            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<Peca> pecasParaImprimir = conn.Query<Peca>(
                    "SELECT * FROM Pecas WHERE OrdemServicoId = @id", new { id = id_os });

                foreach(Peca peca in pecasParaImprimir)
                {
                    e.Graphics.DrawString(peca.Descricao_peca + " ----- Marca: " + peca.Marca_peca + " ----- Quant: " + peca.Quantidade_peca + " ----- SubTotal: R$" + peca.Valor_total, this.Font, Brushes.Black, x, y, StringFormat.GenericTypographic);
                    y += 15;
                }
            }
        }
    }
}