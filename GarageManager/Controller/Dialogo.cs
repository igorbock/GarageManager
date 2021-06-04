using Data;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.Controller
{
    public partial class Dialogo : Form
    {
        public int identificador;
        public GarageDbContext dbContext;
        public OS_Info form;
        public Form1 home;

        public Dialogo()
        {
            InitializeComponent();

            dbContext = new GarageDbContext();
            
        }

        private void Button_excluir_Click(object sender, EventArgs e)
        {
            Peca remover = dbContext.Pecas.Find(identificador);
            
            dbContext.Pecas.Remove(remover);

            dbContext.SaveChanges();

            form.Close();
            form = new OS_Info(form.id_os) { Home = home};
            form.Show();

            Close();
        }

        private void Button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dialogo_Load(object sender, EventArgs e)
        {
            label_produto.Text = dbContext.Pecas.Find(identificador).Descricao_peca + " - " + dbContext.Pecas.Find(identificador).Marca_peca;
        }
    }
}
