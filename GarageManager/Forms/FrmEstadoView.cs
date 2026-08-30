using System;
using System.Drawing;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;

namespace GarageManager.Forms
{
    public class FrmEstadoView : Form
    {
        private DataGridView grid;
        private Button btnFechar;

        public FrmEstadoView()
        {
            InitializeComponent();
            Carregar();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            btnFechar = new Button
            {
                Text = "Fechar",
                Dock = DockStyle.Bottom,
                Height = 32
            };
            btnFechar.Click += (s, e) => Close();
            Controls.Add(grid);
            Controls.Add(btnFechar);
            Text = "Estados (somente leitura)";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(600, 400);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ResumeLayout(false);
        }

        private void Carregar()
        {
            using (var conn = GarageDb.OpenConnection())
            {
                var dados = conn.Query("SELECT id AS Id, nome AS Nome, sigla AS Sigla, codigo_ibge AS CodigoIbge FROM estado ORDER BY nome");
                grid.DataSource = dados;
            }
        }
    }
}
