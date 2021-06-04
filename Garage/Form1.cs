using Garage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class Form1 : Form
    {
        private GarageDBContext context;

        public Form1()
        {
            InitializeComponent();

            context = new GarageDBContext();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrdemServico ordem = new OrdemServico()
            {
                Placa_veiculo = "ILJ0F07",
                Modelo_veiculo = "NX-4 Falcon",
                Ano_veiculo = "2003",
                Cor_veiculo = "Vermelho",
                Nome_cliente = "Igor",
                Telefone_cliente = "51 996347293"
            };

            context.OrdensServicos.Add(ordem);
            context.SaveChanges();
        }
    }
}
