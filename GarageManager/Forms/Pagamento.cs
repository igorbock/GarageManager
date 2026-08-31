using System;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class Pagamento : Form
    {
        OrdemServico ordemServico;
        public int id_os;

        public Pagamento()
        {
            InitializeComponent();
        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            ordemServico.Pagamento = textBox_pagamento.Text;
            new Repository<OrdemServico>().Update(ordemServico);
            MessageBox.Show("Salvo com sucesso", "Pagamento O.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                ordemServico = conn.QuerySingleOrDefault<OrdemServico>(
                    "SELECT * FROM OrdemServico WHERE Id = @id", new { id = id_os });
            }

            textBox_pagamento.Text = ordemServico?.Pagamento;
        }
    }
}