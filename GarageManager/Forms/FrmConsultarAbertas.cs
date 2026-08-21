using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmConsultarAbertas : Form
    {
        public Home MainForm;

        public FrmConsultarAbertas(Home main)
        {
            InitializeComponent();
            MainForm = main;
        }

        private void FrmConsultarAbertas_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

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

            if (dataGridView1.Columns.Count >= 8)
            {
                var check = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 50,
                    FalseValue = false,
                    ReadOnly = false
                };
                dataGridView1.Columns.Insert(0, check);

                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns[2].HeaderText = "Data de início";
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].HeaderText = "Nome";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].HeaderText = "Placa";
                dataGridView1.Columns[5].HeaderText = "Modelo";
                dataGridView1.Columns[6].HeaderText = "Cor";
                dataGridView1.Columns[7].HeaderText = "Ano";
                dataGridView1.Columns[8].HeaderText = "Status";
                dataGridView1.Columns[8].Width = 200;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col is DataGridViewCheckBoxColumn) continue;
                    col.ReadOnly = true;
                }
            }
        }

        private void TextBox_pesquisaPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 DataInicio AS Data,
                                 Nome_cliente,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Status
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                            AND Status NOT IN ('Pronta', 'Finalizada')
                          ORDER BY Id DESC",
                        new { placa = textBox_pesquisaPlacaAberta.Text });

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = pesquisa;

                    if (dataGridView1.Columns.Count >= 8)
                    {
                        var check = new DataGridViewCheckBoxColumn
                        {
                            Name = "Selecionar",
                            HeaderText = "",
                            Width = 50,
                            FalseValue = false,
                            ReadOnly = false
                        };
                        dataGridView1.Columns.Insert(0, check);

                        dataGridView1.Columns["Id"].Visible = false;
                        dataGridView1.Columns[2].HeaderText = "Data de início";
                        dataGridView1.Columns[3].HeaderText = "Nome";
                        dataGridView1.Columns[3].Width = 150;
                        dataGridView1.Columns[4].HeaderText = "Placa";
                        dataGridView1.Columns[5].HeaderText = "Modelo";
                        dataGridView1.Columns[6].HeaderText = "Cor";
                        dataGridView1.Columns[7].HeaderText = "Ano";
                        dataGridView1.Columns[8].HeaderText = "Status";
                        dataGridView1.Columns[8].Width = 200;

                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col is DataGridViewCheckBoxColumn) continue;
                            col.ReadOnly = true;
                        }
                    }

                    if (pesquisa.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_pesquisaPlacaAberta.Text = "";
                    }
                }
            }
        }

        private void TextBox_pesquisaPlacaAberta_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaAberta.Text = "";
        }

        private void Button_editar_Click(object sender, EventArgs e)
        {
            var selecionados = ObterIdsSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainForm.AbrirOSInfo(selecionados[0]);
            }
        }

        private List<int> ObterIdsSelecionados()
        {
            var ids = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Selecionar"].Value is bool marcado && marcado)
                {
                    ids.Add(Convert.ToInt32(row.Cells["Id"].Value));
                }
            }

            return ids;
        }
    }
}