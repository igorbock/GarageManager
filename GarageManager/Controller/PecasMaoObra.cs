using Data;
using Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GarageManager.Controller
{
    public partial class PecasMaoObra : Form
    {
        public int id_ordem;
        public OS_Info form;
        public Form1 home;
        GarageDbContext context;

        decimal valor_produto;
        decimal quant_produto;

        public PecasMaoObra()
        {
            InitializeComponent();

            context = new GarageDbContext();
        }

        private void TextBox_descricao_Enter(object sender, EventArgs e)
        {
            if(textBox_descricao.Text == "Descrição")
            {
                textBox_descricao.Text = "";
                textBox_descricao.ForeColor = Color.Black;
            }
        }

        private void TextBox_descricao_Leave(object sender, EventArgs e)
        {
            if(textBox_descricao.Text == "")
            {
                textBox_descricao.Text = "Descrição";
                textBox_descricao.ForeColor = Color.Silver;
            }
        }

        private void TextBox_marca_Enter(object sender, EventArgs e)
        {
            if(textBox_marca.Text == "Marca")
            {
                textBox_marca.Text = "";
                textBox_marca.ForeColor = Color.Black;
            }
        }

        private void TextBox_marca_Leave(object sender, EventArgs e)
        {
            if(textBox_marca.Text == "")
            {
                textBox_marca.Text = "Marca";
                textBox_marca.ForeColor = Color.Silver;
            }
        }

        private void TextBox_valor_Enter(object sender, EventArgs e)
        {
            if(textBox_valor.Text == "Custo")
            {
                textBox_valor.Text = "";
                textBox_valor.ForeColor = Color.Black;
            }
        }

        private void TextBox_valor_Leave(object sender, EventArgs e)
        {
            if(textBox_valor.Text == "")
            {
                textBox_valor.Text = "Custo";
                textBox_valor.ForeColor = Color.Silver;
            }
            else if(Convert.ToDecimal(textBox_valor.Text) > 0 && textBox_valor.Text != "Custo")
            {
                valor_produto = Convert.ToDecimal(textBox_valor.Text);
                quant_produto = Convert.ToDecimal(numericUpDown_quant.Value);

                label_total.Text = "Sub-total: " + (valor_produto * quant_produto).ToString("C");
            }
        }

        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            if (!textBox_descricao.Text.Equals("Descrição") && !textBox_descricao.Text.Equals("") && valor_produto > 0)
            {
                //FAZ A BUSCA PELA ORDEM DE SERVIÇO REFERENTE A INSERÇÃO DA PEÇA
                OrdemServico OS = context.OrdemServico.Find(id_ordem);

                //SETA OS ATRIBUTOS DO SERVIÇO
                string marca;
                string produto = textBox_descricao.Text;

                if (textBox_marca.Text.Equals("Marca"))
                {
                    marca = "-----";
                }
                else
                {
                    marca = textBox_marca.Text;
                }

                decimal valor_produto = Convert.ToDecimal(textBox_valor.Text);
                decimal valor_unitario = ((valor_produto / 100) * numericUpDown_percentual.Value) + valor_produto;
                decimal valor_total = valor_unitario * numericUpDown_quant.Value;

                Peca novaPeca = new Peca()
                {
                    Descricao_peca = produto,
                    Marca_peca = marca,
                    Valor_peca = valor_unitario,
                    Quantidade_peca = numericUpDown_quant.Value,
                    Valor_total = valor_total.ToString("N"),
                    OrdemServicoId = id_ordem
                };

                context.Pecas.Add(novaPeca);
                OS.Pecas_servico.Add(novaPeca);
                context.SaveChanges();

                form.Close();
                form = new OS_Info(id_ordem);
                form.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Insira um nome na peça ou produto", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox_descricao.Focus();
            }
        }

        private void Button_adicionarServico_Click(object sender, EventArgs e)
        {
            OrdemServico ordemServico = context.OrdemServico.Find(id_ordem);

            if(!textBox_servico.Text.Equals("Mão de obra ou serviço") && textBox_valorServico.Text.Length > 0 && numericUpDown_quantidade.Value > 0)
            {
                Peca maoObra = new Peca()
                {
                    Descricao_peca = textBox_servico.Text,
                    Marca_peca = "Mão-de-obra/Serviço",
                    Valor_peca = Convert.ToDecimal(textBox_valorServico.Text),
                    Quantidade_peca = numericUpDown_quantidade.Value,
                    Valor_total = (Convert.ToDecimal(textBox_valorServico.Text) * numericUpDown_quantidade.Value).ToString("N"),
                    OrdemServicoId = id_ordem
                };

                context.Pecas.Add(maoObra);
                ordemServico.Pecas_servico.Add(maoObra);
                context.SaveChanges();

                form.Close();
                form = new OS_Info(id_ordem) { Home = home};
                form.Show();

                Close();
                
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente!", "Ordem de Serviço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox_servico.Focus();
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //valor_produto = Convert.ToDecimal(textBox_valor.Text);
            quant_produto = Convert.ToDecimal(numericUpDown_quant.Value);

            label_total.Text = "Sub-total: " + (((valor_produto / 100 * numericUpDown_percentual.Value) + valor_produto) * quant_produto).ToString("C");

        }


        private void TextBox_servico_Enter(object sender, EventArgs e)
        {
            if(textBox_servico.Text == "Mão de obra ou serviço")
            {
                textBox_servico.Text = "";

                textBox_servico.ForeColor = Color.Black;
            }
        }

        private void TextBox_servico_Leave(object sender, EventArgs e)
        {
            if(textBox_servico.Text == "")
            {
                textBox_servico.Text = "Mão de obra ou serviço";

                textBox_servico.ForeColor = Color.Silver;
            }
        }

        private void TextBox_valorServico_Leave(object sender, EventArgs e)
        {
            if(textBox_valorServico.Text == "")
            {
                textBox_valorServico.Text = "0";
            }

            label_totalServico.Text = "Total: " + (Convert.ToDecimal(textBox_valorServico.Text) * numericUpDown_quantidade.Value).ToString("C");
        }

        private void NumericUpDown_quantidade_ValueChanged(object sender, EventArgs e)
        {
            if (textBox_valorServico.Text == "")
            {
                textBox_valorServico.Text = "0";
            }

            label_totalServico.Text = "Total: " + (Convert.ToDecimal(textBox_valorServico.Text) * numericUpDown_quantidade.Value).ToString("C");
        }

        private void NumericUpDown_quant_Leave(object sender, EventArgs e)
        {
            if (numericUpDown_quant.Text.Contains(","))
            {
                quant_produto = Convert.ToDecimal(numericUpDown_quant.Text.Replace(",", "."));
            }
            else
            {
                quant_produto = Convert.ToDecimal(numericUpDown_quant.Text);
            }

            label_total.Text = "Sub-total: " + (((valor_produto / 100 * numericUpDown_percentual.Value) + valor_produto) * quant_produto).ToString("C");

        }

        private void PecasMaoObra_Load(object sender, EventArgs e)
        {
            if (textBox_valor.Text.Equals("Custo"))
            {
                valor_produto = 0;
            }
        }
    }
}
