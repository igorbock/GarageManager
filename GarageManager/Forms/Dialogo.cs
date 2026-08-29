using System;
using System.Windows.Forms;
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
            new Repository<Peca>().Delete(identificador);
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
            Peca peca = new Repository<Peca>().GetById(identificador);
            if (peca != null) label_produto.Text = peca.Descricao_peca + " - " + peca.Marca_peca;
        }
    }
}