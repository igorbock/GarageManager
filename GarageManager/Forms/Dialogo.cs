using System;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;
using GarageManager.Models;

namespace GarageManager.Forms
{
    public partial class Dialogo : Form
    {
        public int identificador;
        public OS_Info form;
        public Home MainForm;

        public Dialogo()
        {
            InitializeComponent();
        }

        private void Button_excluir_Click(object sender, EventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                conn.Execute("DELETE FROM Pecas WHERE Id = @id", new { id = identificador });
            }

            form.Close();
            MainForm.AbrirOSInfo(form.id_os);

            Close();
        }

        private void Button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dialogo_Load(object sender, EventArgs e)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                Peca peca = conn.QuerySingleOrDefault<Peca>("SELECT * FROM Pecas WHERE Id = @id", new { id = identificador });

                if (peca != null)
                {
                    label_produto.Text = peca.Descricao_peca + " - " + peca.Marca_peca;
                }
            }
        }
    }
}