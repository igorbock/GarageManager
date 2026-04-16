using System;
using System.Data;
using System.Windows.Forms;

namespace GarageManager.Forms
{
    public partial class FrmListaOS : Form
    {
        public FrmListaOS()
        {
            InitializeComponent();

            Load += (s, e) => CarregarForm();
        }

        public void CarregarForm()
        {
            var table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("DATA", typeof(DateTime));
            table.Columns.Add("CLIENTE", typeof(string));
            table.Columns.Add("PLACA", typeof(string));

            table.Rows.Add(1, new DateTime(2026, 1, 10), "Acme Automotiva", "BRA2-3C45");
            table.Rows.Add(2, new DateTime(2026, 1, 12), "Vera Comércio Ltda", "KLM4-1A11");
            table.Rows.Add(3, new DateTime(2026, 1, 14), "Grupo Horizonte", "QWE9-8765");
            table.Rows.Add(4, new DateTime(2026, 1, 16), "Construtora Aurora", "RTY7-2B34");
            table.Rows.Add(5, new DateTime(2026, 1, 18), "Clínica São Miguel", "HJK1-4D22");
            table.Rows.Add(6, new DateTime(2026, 1, 20), "Transportes Rápidos", "ZXC3-1E33");
            table.Rows.Add(7, new DateTime(2026, 1, 22), "Padaria Sol Nascente", "ASD8-9012");
            table.Rows.Add(8, new DateTime(2026, 1, 24), "Eletro Center", "FGH5-6F78");
            table.Rows.Add(9, new DateTime(2026, 1, 26), "Imobiliária Atlântico", "JUI6-7G90");
            table.Rows.Add(10, new DateTime(2026, 1, 28), "Oficina Mecânica Alfa", "POI2-1H44");

            GOrdemServico.DataSource = table;
        }
    }
}
