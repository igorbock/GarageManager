using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class FrmOrdemServicoGerencia : Form
    {
        public Home MainForm;

        public FrmOrdemServicoGerencia(Home main)
        {
            InitializeComponent();
            MainForm = main;
            comboBox_periodo.SelectedIndex = 0;
            comboBox_situacao.SelectedIndex = 0;
            dateTimePicker_data.Checked = true;
            dateTimePicker_ate.Checked = true;
        }

        private void FrmOrdemServicoGerencia_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            var LstWhere = new List<string>();
            var DPParametros = new DynamicParameters();

            int IntPeriodo = comboBox_periodo.SelectedIndex;
            if (dateTimePicker_data.Checked)
            {
                if (IntPeriodo == 0)
                {
                    LstWhere.Add("DataInicio >= @dataInicio");
                    DPParametros.Add("dataInicio", dateTimePicker_data.Value.ToString("dd/MM/yyyy"));
                }
                else
                {
                    LstWhere.Add("DataFim >= @dataInicio");
                    DPParametros.Add("dataInicio", dateTimePicker_data.Value.ToString("dd/MM/yyyy"));
                }
                
            }

            if (dateTimePicker_ate.Checked)
            {
                if (IntPeriodo == 0)
                {
                    LstWhere.Add("DataInicio <= @dataFim");
                    DPParametros.Add("dataFim", dateTimePicker_ate.Value.ToString("dd/MM/yyyy"));
                } 
                else
                {
                    LstWhere.Add("DataFim <= @dataFim");
                    DPParametros.Add("dataFim", dateTimePicker_ate.Value.ToString("dd/MM/yyyy"));
                }    
            }

            if (!string.IsNullOrWhiteSpace(textBox_cliente.Text))
            {
                LstWhere.Add("Nome_cliente LIKE @cliente");
                DPParametros.Add("cliente", $"%{textBox_cliente.Text.Trim()}%");
            }

            if (!string.IsNullOrWhiteSpace(textBox_placa.Text))
            {
                LstWhere.Add("Placa_veiculo LIKE @placa");
                DPParametros.Add("placa", $"%{textBox_placa.Text.Trim()}%");
            }

            if (!string.IsNullOrWhiteSpace(textBox_modelo.Text))
            {
                LstWhere.Add("Modelo_veiculo LIKE @modelo");
                DPParametros.Add("modelo", "%" + textBox_modelo.Text.Trim() + "%");
            }

            if (!string.IsNullOrWhiteSpace(textBox_ano.Text))
            {
                LstWhere.Add("Ano_veiculo LIKE @ano");
                DPParametros.Add("ano", "%" + textBox_ano.Text.Trim() + "%");
            }

            string situacao = comboBox_situacao.SelectedItem?.ToString();
            if (situacao == "Aberta")
            {
                LstWhere.Add("Status = @status");
                DPParametros.Add("status", "Em serviço");
            }
            else if (situacao == "Em Andamento")
            {
                LstWhere.Add("Status = @status");
                DPParametros.Add("status", "Aguardando serviço");
            }
            else if (situacao == "Finalizada")
            {
                LstWhere.Add("Status = @status");
                DPParametros.Add("status", "Finalizada");
            }

            string whereClause = LstWhere.Count > 0 ? "WHERE " + string.Join(" AND ", LstWhere) : "";

            using (var conn = GarageDb.OpenConnection())
            {
                IEnumerable<OrdemServicoDTO> ordemServicos = conn.Query<OrdemServicoDTO>(
                    $@"SELECT Id,
                             DataInicio AS Data,
                             Nome_cliente,
                             Placa_veiculo,
                             Modelo_veiculo,
                             Cor_veiculo,
                             Ano_veiculo,
                             Status,
                             DataFim
                      FROM OrdemServico
                      {whereClause}
                      ORDER BY Id DESC",
                    DPParametros);

                dataGridView1.DataSource = ordemServicos;
            }

            if (dataGridView1.Columns.Count >= 9)
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
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[9].HeaderText = "Data fim";
                dataGridView1.Columns[9].Width = 110;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col is DataGridViewCheckBoxColumn) continue;
                    col.ReadOnly = true;
                }
            }
        }

        private void Button_filtrar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void Button_limpar_Click(object sender, EventArgs e)
        {
            dateTimePicker_data.Checked = true;
            dateTimePicker_data.Value = DateTime.Today;
            dateTimePicker_ate.Checked = true;
            dateTimePicker_ate.Value = DateTime.Today;
            comboBox_periodo.SelectedIndex = 0;
            textBox_cliente.Text = "";
            textBox_placa.Text = "";
            textBox_modelo.Text = "";
            textBox_ano.Text = "";
            comboBox_situacao.SelectedIndex = 0;
            CarregarGrid();
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

        private void Button_adicionar_Click(object sender, EventArgs e)
        {
            MainForm.AbrirOrdemServico();
        }

        private void Button_excluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterIdsSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selecionados.Count > 1)
            {
                MessageBox.Show("Selecione somente 1 registro.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = selecionados[0];

            if (DialogResult.Yes != MessageBox.Show(
                "Deseja realmente excluir esta ordem de serviço?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            using (var conn = GarageDb.OpenConnection())
            {
                string status = conn.QuerySingleOrDefault<string>(
                    "SELECT Status FROM OrdemServico WHERE Id = @id", new { id });

                if (status == "Pronta" || status == "Finalizada")
                {
                    MessageBox.Show("Ordens de serviço prontas ou finalizadas não podem ser removidas.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn.Execute("DELETE FROM Pecas WHERE OrdemServicoId = @id", new { id });
                conn.Execute("DELETE FROM OrdemServico WHERE Id = @id", new { id });
            }

            MessageBox.Show("Registro excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregarGrid();
        }

        private void Button_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado.", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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