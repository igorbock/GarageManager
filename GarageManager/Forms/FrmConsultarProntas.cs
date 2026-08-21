using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmConsultarProntas : Form
    {
        public Home MainForm;

        public FrmConsultarProntas(Home main)
        {
            InitializeComponent();
            MainForm = main;
        }

        private void FrmConsultarProntas_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dataGridView_encerradas.DataSource = null;
            dataGridView_encerradas.Columns.Clear();

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

            if (dataGridView_encerradas.Columns.Count >= 8)
            {
                var check = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 50,
                    FalseValue = false,
                    ReadOnly = false
                };
                dataGridView_encerradas.Columns.Insert(0, check);

                dataGridView_encerradas.Columns["Id"].Visible = false;
                dataGridView_encerradas.Columns[2].HeaderText = "Data de encerramento";
                dataGridView_encerradas.Columns[2].Width = 150;
                dataGridView_encerradas.Columns[3].HeaderText = "Nome";
                dataGridView_encerradas.Columns[3].Width = 150;
                dataGridView_encerradas.Columns[4].HeaderText = "Placa";
                dataGridView_encerradas.Columns[5].HeaderText = "Modelo";
                dataGridView_encerradas.Columns[6].HeaderText = "Cor";
                dataGridView_encerradas.Columns[7].HeaderText = "Ano";
                dataGridView_encerradas.Columns[8].HeaderText = "Status";
                dataGridView_encerradas.Columns[8].Width = 200;

                foreach (DataGridViewColumn col in dataGridView_encerradas.Columns)
                {
                    if (col is DataGridViewCheckBoxColumn) continue;
                    col.ReadOnly = true;
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var conn = GarageDb.OpenConnection())
                {
                    IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                        @"SELECT Id,
                                 DataFim AS Data,
                                 Nome_cliente,
                                 Placa_veiculo,
                                 Modelo_veiculo,
                                 Cor_veiculo,
                                 Ano_veiculo,
                                 Status
                          FROM OrdemServico
                          WHERE Placa_veiculo = @placa
                            AND Status = 'Pronta'
                          ORDER BY Id DESC",
                        new { placa = textBox_pesquisaPlacaEncerrada.Text });

                    dataGridView_encerradas.DataSource = null;
                    dataGridView_encerradas.Columns.Clear();
                    dataGridView_encerradas.DataSource = pesquisa;

                    if (dataGridView_encerradas.Columns.Count >= 8)
                    {
                        var check = new DataGridViewCheckBoxColumn
                        {
                            Name = "Selecionar",
                            HeaderText = "",
                            Width = 50,
                            FalseValue = false,
                            ReadOnly = false
                        };
                        dataGridView_encerradas.Columns.Insert(0, check);

                        dataGridView_encerradas.Columns["Id"].Visible = false;
                        dataGridView_encerradas.Columns[2].HeaderText = "Data de encerramento";
                        dataGridView_encerradas.Columns[3].HeaderText = "Nome";
                        dataGridView_encerradas.Columns[3].Width = 150;
                        dataGridView_encerradas.Columns[4].HeaderText = "Placa";
                        dataGridView_encerradas.Columns[5].HeaderText = "Modelo";
                        dataGridView_encerradas.Columns[6].HeaderText = "Cor";
                        dataGridView_encerradas.Columns[7].HeaderText = "Ano";
                        dataGridView_encerradas.Columns[8].HeaderText = "Status";
                        dataGridView_encerradas.Columns[8].Width = 200;

                        foreach (DataGridViewColumn col in dataGridView_encerradas.Columns)
                        {
                            if (col is DataGridViewCheckBoxColumn) continue;
                            col.ReadOnly = true;
                        }
                    }

                    if (pesquisa.Count() == 0)
                    {
                        MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TextBox_pesquisaPlacaEncerrada_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaEncerrada.Text = "";
        }
    }
}