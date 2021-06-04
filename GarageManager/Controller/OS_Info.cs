using Data;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace GarageManager.Controller
{
    public partial class OS_Info : Form
    {
        public int id_os;
        private GarageDbContext context;
        private OrdemServico ordemServico;
        private List<PecaDTO> pecas;
        ToolStripStatusLabel info;
        ToolStripStatusLabel info_encerrar;
        decimal valorTotal = 0;

        public Form1 Home;

        public OS_Info(int Id)
        {
            InitializeComponent();
            id_os = Id;
            textBox_id.Text = "ID #" + id_os.ToString();

            context = new GarageDbContext();

            ordemServico = context.OrdemServico.Find(id_os);

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

        //EVENTO LOAD DO FORM
        private void OS_Info_Load(object sender, EventArgs e)
        {
            //Verificar qual o status da ordem

            if(ordemServico.Status == "Pronta" || ordemServico.Status == "Finalizada")
            {
                //Controles não responderão ao usuário com a ordem de serviço encerrada
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
                    //Adiciona ToolStripLabel na barra inferior
                    statusStrip_infoOS.Items.Add(info_encerrar);
                    button_alterar.Enabled = false;
                }
                

                //Controles previamente setados e configurados

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

                pecas = new List<PecaDTO>();
                pecas = context.Pecas.Select(p => new PecaDTO { Id = p.Id, Descricao_peca = p.Descricao_peca, Marca_peca = p.Marca_peca, Quantidade_peca = p.Quantidade_peca, Valor_peca = p.Valor_peca, Valor_total = p.Valor_total, OrdemServicoId = p.OrdemServicoId}).Where(p => p.OrdemServicoId == id_os).ToList();

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

                
                foreach (DataGridViewRow row in dataGridView_pecas_ordem.Rows)
                {
                    valorTotal += Convert.ToDecimal(row.Cells["subTotal"].Value);
                }

                textBox_total.Text = valorTotal.ToString();
            }
            else
            {
                //Checkbox para retornar OS ativa novamente
                checkBox_voltar.Enabled = false;
                checkBox_voltar.Visible = false;

                //Controles normais
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
                //textBox_dataFinal.Text = ordemServico.DataFim;
                //textBox_horaFinal.Text = ordemServico.HoraFim;
                label_status.Text = ordemServico.Status;
                comboBox_status.SelectedItem = ordemServico.Status;
                textBox_mecanico.Text = ordemServico.Mecanico;
                checkBox_lavado.Checked = ordemServico.Lavacao;
                statusStrip_infoOS.Items.Add(info_encerrar);

                pecas = new List<PecaDTO>();
                pecas = context.Pecas.Select(p => new PecaDTO { Id = p.Id, Descricao_peca = p.Descricao_peca, Marca_peca = p.Marca_peca, Quantidade_peca = p.Quantidade_peca, Valor_peca = p.Valor_peca, Valor_total = p.Valor_total, OrdemServicoId = p.OrdemServicoId }).Where(p => p.OrdemServicoId == id_os).ToList();

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

                
                foreach (DataGridViewRow row in dataGridView_pecas_ordem.Rows)
                {
                    valorTotal += Convert.ToDecimal(row.Cells["subTotal"].Value);
                }

                textBox_total.Text = "R$ " + valorTotal.ToString();

            }

            
        }

        //ABRE A FORM PARA ADICIONAR NOVAS PEÇAS A ORDEM DE SERVIÇO
        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            PecasMaoObra novas = new PecasMaoObra() {id_ordem = id_os, form = this, home = Home};
            novas.Show();
        }

        //EXCLUINDO UMA PEÇA DA ORDEM DE SERVIÇO
        private void DataGridView_pecas_ordem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7 && dataGridView_pecas_ordem.Rows.Count > 0 && ordemServico.Status != "Finalizada" && ordemServico.Status != "Pronta")
            {
                Dialogo dialogo = new Dialogo() { identificador = Convert.ToInt32(dataGridView_pecas_ordem.CurrentRow.Cells["Id"].Value), form = this};
                dialogo.Show();

                dataGridView_pecas_ordem.Update();
            }
        }

        //SALVAR ALTERAÇÕES NA ORDEM DE SERVIÇO
        private void Button_salvar_Click(object sender, EventArgs e)
        {
            OrdemServico ordemServico = context.OrdemServico.Find(id_os);
            
            if (ordemServico.Status.Equals(comboBox_status.SelectedItem.ToString()))
            {
                if(ordemServico.Servicos_realizados != textBox_realizados.Text || ordemServico.Mecanico != textBox_mecanico.Text)
                {
                    ordemServico.Servicos_realizados = textBox_realizados.Text;
                    ordemServico.Mecanico = textBox_mecanico.Text;
                    ordemServico.Lavacao = checkBox_lavado.Checked;

                    try
                    {
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível salvar as alterações. Tente novamente", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }catch(DbEntityValidationException ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi realizada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                switch (comboBox_status.SelectedItem.ToString())
                {
                    case "Em serviço":
                        ordemServico.Status = "Em serviço";
                        ordemServico.Mecanico = textBox_mecanico.Text;
                        ordemServico.Servicos_realizados = textBox_realizados.Text;
                        ordemServico.Lavacao = checkBox_lavado.Checked;
                        try
                        {
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                label_status.Text = "Em serviço";
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma alteração foi realizada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }catch(DbEntityValidationException ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Aguardando serviço":
                        ordemServico.Status = "Aguardando serviço";
                        ordemServico.Mecanico = textBox_mecanico.Text;
                        ordemServico.Servicos_realizados = textBox_realizados.Text;
                        ordemServico.Lavacao = checkBox_lavado.Checked;
                        try
                        {
                            if(context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Alterações salvas com sucesso!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                label_status.Text = "Aguardando serviço";
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma alteração foi realizada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (DbEntityValidationException ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;

                    case "Pronta":
                        ordemServico.Status = "Pronta";
                        ordemServico.Mecanico = textBox_mecanico.Text;
                        ordemServico.Servicos_realizados = textBox_realizados.Text;
                        ordemServico.Lavacao = checkBox_lavado.Checked;

                        if (DialogResult.Yes == MessageBox.Show("Você deseja realmente tornar esta ordem de serviço pronta?\n\nValor total: " + textBox_total.Text + "\nMecânico: " + textBox_mecanico.Text, "Ordem de Serviço", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            ordemServico.Status = "Pronta";
                            ordemServico.DataFim = DateTime.Now.ToShortDateString();
                            ordemServico.HoraFim = DateTime.Now.ToShortTimeString();
                            try
                            {
                                if (context.SaveChanges() > 0)
                                {
                                    MessageBox.Show("A ordem de serviço foi encerrada!", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("A ordem de serviço não foi encerrada! Um erro aconteceu. Tente novamente.", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }catch(DbEntityValidationException ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                Close();
                            }

                            /*
                            try
                            {
                                Home.tabControl1.SelectedTab = Home.tabPage_home;
                            }catch(NullReferenceException ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message, "Garage Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                Close();
                            }*/
                        }
                        break;
                }
            }
        }

        //MOUSE SOBRE DATAGRIDVIEW EXIBE STATUSLABEL DIFERENTE
        private void DataGridView_pecas_ordem_MouseHover(object sender, EventArgs e)
        {
            if(!statusStrip_infoOS.Items.Contains(info) && ordemServico.Status != "Finalizada" && ordemServico.Pecas_servico.Count > 0)
            {
                statusStrip_infoOS.Items.Add(info);
            }
            else
            {
                info.Text = "A ordem de serviço está aguardando peças";
                statusStrip_infoOS.Items.Add(info);
            }
        }

        //MOUSE SAINDO DO DATAGRIDVIEW REMOVE STATUSLABEL
        private void DataGridView_pecas_ordem_MouseLeave(object sender, EventArgs e)
        {
            statusStrip_infoOS.Items.Remove(info);
        }

        //QUANDO A CHECK BOX DE ATIVAR ESTIVER CHECADA E O FORMULARIO ESTIVER FECHAND
        //O STATUS RECEBE UPDATE PARA Em Serviço, VOLTANDO A GUIA DOS SERVIÇOS ABERTOS
        private void OS_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBox_voltar.Checked)
            {
                ordemServico.Status = "Em serviço";
                if(context.SaveChanges() > 0)
                {
                    MessageBox.Show("A ordem de serviço está ativa novamente.", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Home.tabControl1.SelectedTab = Home.tabPage_home;
            }
        }

        //QUANDO O USUARIO APERTAR F2 A ORDEM DE SERVIÇO ESTARÁ FINALIZADA
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

                            try
                            {
                                if (context.SaveChanges() > 0)
                                {
                                    MessageBox.Show("A ordem de serviço foi finalizada!\nPara realizar uma consulta procure pela placa no histórico.", "Ordem de serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();

                                    Home.tabControl1.SelectedTab = Home.tabPage_home;
                                }
                            }
                            catch (DbEntityValidationException ex)
                            {
                                MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        //MANIPULAÇÃO DO BOTÃO DE ALTERAR DADOS/SALVAR/FORMA PAGAMENTO  
        private void Button_alterar_Click(object sender, EventArgs e)
        {
            //CASO O TEXTO FOR Alterar dados E O STATUS Pronta, A ALTERAÇÃO DOS CAMPOS VAI SER HABILITADA
            if (button_alterar.Text == "Alterar dados" && ordemServico.Status != "Pronta")
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

                //BOTÃO VAI RECEBER UM NOVO TEXTO PARA RETORNAR OU SALVAR OS DADOS EDITADOS
                button_alterar.Text = "Retornar/Salvar";

            }
            //CASO O TEXTO FOR Retornar/Salvar E O STATUS Pronta, OS DADOS VÃO SOFRER UPDATE NO BANCO
            else if (button_alterar.Text == "Retornar/Salvar" && ordemServico.Status != "Pronta")
            {
                try
                {
                    ordemServico.Modelo_veiculo = textBox_veiculo.Text;
                    ordemServico.Cor_veiculo = textBox_cor.Text;
                    ordemServico.Ano_veiculo = textBox_ano.Text;
                    ordemServico.Km_veiculo = textBox_km.Text;
                    ordemServico.Placa_veiculo = textBox_placa.Text;
                    ordemServico.Servicos_esperados = textBox_servicos.Text;
                    ordemServico.Nome_cliente = textBox_nome.Text;
                    ordemServico.Telefone_cliente = textBox_telefone.Text;

                    //UPDATE COM SUCESSO VAI EXIBIR NOTIFICAÇÃO DE SUCESSO NA TELA
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Os dados foram alterados com sucesso!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_alterar.Text = "Alterar dados";

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
                    else
                    //UPDATE SEM SUCESSO OU SEM ALTERAÇÃO EXIBE MENSAGEM NA TELA
                    {
                        MessageBox.Show("Não foi realizada nenhuma alteração nos dados!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_alterar.Text = "Alterar dados";

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
                }catch(DbEntityValidationException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //BOTÃO COM TEXTO Forma Pagamento E STATUS Finalizada, ABRE TELA DOS PAGAMENTOS
            if (button_alterar.Text == "Forma Pagamento" && ordemServico.Status == "Finalizada")
            {
                Pagamento parcela = new Pagamento() { id_os = id_os};
                parcela.Show();
            }
        }

        //MANIPULAÇÃO DA CHECK BOX RESPONSÁVEL PELA LAVAÇÃO DA ORDEM DE SERVIÇO
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
                if (checkBox_lavado.Checked == true)
                {
                    ordemServico.Lavacao = true;
                }
                else
                {
                    ordemServico.Lavacao = false;
                }

                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + "\n" + ex.Source + "\n" + ex.TargetSite + "\n" + ex.EntityValidationErrors + "\n\nEntre em contato com o desenvolvedor", "Exceção do software", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            //PrintDialog printDialog = printDialog1;

            //printDialog.ShowDialog();
            //printDialog.Document
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
            foreach(Peca peca in ordemServico.Pecas_servico)
            {
                e.Graphics.DrawString(peca.Descricao_peca + " ----- Marca: " + peca.Marca_peca + " ----- Quant: " + peca.Quantidade_peca + " ----- SubTotal: R$" + peca.Valor_total, this.Font, Brushes.Black, x, y, StringFormat.GenericTypographic);
                y += 15;
            }
        }
    }
}
