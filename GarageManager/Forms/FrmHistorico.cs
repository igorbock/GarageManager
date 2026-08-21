using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmHistorico : Form
    {
        public Home MainForm;

        public FrmHistorico(Home main)
        {
            InitializeComponent();
            MainForm = main;
        }

        private void FrmHistorico_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dataGridView_historico.DataSource = null;
            dataGridView_historico.Columns.Clear();

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

            if (dataGridView_historico.Columns.Count >= 8)
            {
                var check = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 50,
                    FalseValue = false,
                    ReadOnly = false
                };
                dataGridView_historico.Columns.Insert(0, check);

                dataGridView_historico.Columns["Id"].Visible = false;
                dataGridView_historico.Columns[2].HeaderText = "Início / Encerramento";
                dataGridView_historico.Columns[2].Width = 180;
                dataGridView_historico.Columns[3].HeaderText = "Placa";
                dataGridView_historico.Columns[4].HeaderText = "Modelo";
                dataGridView_historico.Columns[5].HeaderText = "Cor";
                dataGridView_historico.Columns[6].HeaderText = "Ano";
                dataGridView_historico.Columns[7].HeaderText = "Nome";
                dataGridView_historico.Columns[7].Width = 150;
                dataGridView_historico.Columns[8].HeaderText = "Status";
                dataGridView_historico.Columns[8].Width = 200;
            }
        }

        private void AplicarColunasCheckBox()
        {
            if (dataGridView_historico.Columns.Count >= 8 && !dataGridView_historico.Columns.Contains("Selecionar"))
            {
                var check = new DataGridViewCheckBoxColumn
                {
                    Name = "Selecionar",
                    HeaderText = "",
                    Width = 50,
                    FalseValue = false,
                    ReadOnly = false
                };
                dataGridView_historico.Columns.Insert(0, check);

                dataGridView_historico.Columns["Id"].Visible = false;
                dataGridView_historico.Columns[2].HeaderText = "Início / Encerramento";
                dataGridView_historico.Columns[2].Width = 180;
                dataGridView_historico.Columns[3].HeaderText = "Placa";
                dataGridView_historico.Columns[4].HeaderText = "Modelo";
                dataGridView_historico.Columns[5].HeaderText = "Cor";
                dataGridView_historico.Columns[6].HeaderText = "Ano";
                dataGridView_historico.Columns[7].HeaderText = "Nome";
                dataGridView_historico.Columns[7].Width = 150;
                dataGridView_historico.Columns[8].HeaderText = "Status";
                dataGridView_historico.Columns[8].Width = 200;

                foreach (DataGridViewColumn col in dataGridView_historico.Columns)
                {
                    if (col is DataGridViewCheckBoxColumn) continue;
                    col.ReadOnly = true;
                }
            }
        }

        private void PesquisarPlaca(string placa)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> pesquisa = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             (DataInicio || ' - ' || DataFim) AS Data,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Nome_cliente,
                             Status
                      FROM OrdemServico
                      WHERE Placa_veiculo = @placa
                        AND Status = 'Finalizada'
                      ORDER BY Id DESC",
                    new { placa });

                dataGridView_historico.DataSource = null;
                dataGridView_historico.Columns.Clear();
                dataGridView_historico.DataSource = pesquisa;
                AplicarColunasCheckBox();

                if (pesquisa.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira uma nova placa e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaPlacaHistorico.Text = "";
                }
            }
        }

        private void PesquisarVeiculo(string modelo)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> pesquisaVeiculo = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             (DataInicio || ' - ' || DataFim) AS Data,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Nome_cliente,
                             Status
                      FROM OrdemServico
                      WHERE LOWER(Modelo_veiculo) LIKE '%' || LOWER(@modelo) || '%'
                        AND Status = 'Finalizada'
                      ORDER BY Id DESC",
                    new { modelo });

                dataGridView_historico.DataSource = null;
                dataGridView_historico.Columns.Clear();
                dataGridView_historico.DataSource = pesquisaVeiculo;
                AplicarColunasCheckBox();

                if (pesquisaVeiculo.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo modelo e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaVeiculoHistorico.Text = "";
                }
            }
        }

        private void PesquisarNome(string nome)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> pesquisaNome = conn.Query<OrdemServicoDTO>(
                    @"SELECT Id,
                             (DataInicio || ' - ' || DataFim) AS Data,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Nome_cliente,
                             Status
                      FROM OrdemServico
                      WHERE LOWER(Nome_cliente) LIKE '%' || LOWER(@nome) || '%'
                        AND Status = 'Finalizada'
                      ORDER BY Id DESC",
                    new { nome });

                dataGridView_historico.DataSource = null;
                dataGridView_historico.Columns.Clear();
                dataGridView_historico.DataSource = pesquisaNome;
                AplicarColunasCheckBox();

                if (pesquisaNome.Count() == 0)
                {
                    MessageBox.Show("Não foi possível encontrar nenhum resultado. Insira um novo nome e tente novamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_pesquisaNomeHistorico.Text = "";
                }
            }
        }

        private void TextBox_pesquisaPlacaHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarPlaca(textBox_pesquisaPlacaHistorico.Text);
            }
        }

        private void TextBox_pesquisaVeiculoHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarVeiculo(textBox_pesquisaVeiculoHistorico.Text.Trim());
            }
        }

        private void TextBox_pesquisaNomeHistorico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarNome(textBox_pesquisaNomeHistorico.Text.Trim());
            }
        }

        private void TextBox_pesquisaPlacaHistorico_Leave(object sender, EventArgs e)
        {
            textBox_pesquisaPlacaHistorico.Text = "";
        }
    }
}