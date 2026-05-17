using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageManager.Forms.Base
{
    public partial class FrmCadastroBase : Form
    {
        public FrmCadastroBase()
        {
            InitializeComponent();

            BtnImprimirGrid.Click += (s, e) => ImprimirGrid();
        }

        private void ImprimirGrid()
        {
            throw new NotImplementedException();
        }
    }
}
