using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Dominio;

namespace GarageManager.Controller
{
    public partial class Pagamento : Form
    {
        GarageDbContext context;
        OrdemServico ordemServico;
        public int id_os;

        public Pagamento()
        {
            InitializeComponent();

        }

        private void Button_salvar_Click(object sender, EventArgs e)
        {
            ordemServico.Pagamento = textBox_pagamento.Text;

            if(context.SaveChanges() > 0)
            {
                MessageBox.Show("Salvo com sucesso", "Pagamento O.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            context = new GarageDbContext();

            ordemServico = context.OrdemServico.Find(id_os);
            textBox_pagamento.Text = ordemServico.Pagamento;
        }
    }
}
