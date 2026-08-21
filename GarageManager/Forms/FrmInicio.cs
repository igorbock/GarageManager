using System;
using System.Windows.Forms;
using Dapper;
using GarageManager.Data;

namespace GarageManager.Forms
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Activated(object sender, EventArgs e)
        {
            AtualizarInformacoes();
        }

        private void AtualizarInformacoes()
        {
            using (var conn = GarageDb.OpenConnection())
            {
                int emServico = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Em serviço'");
                int aguardando = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Aguardando serviço'");
                int prontas = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Pronta'");
                int finalizadas = conn.QuerySingle<int>("SELECT COUNT(*) FROM OrdemServico WHERE Status = 'Finalizada'");

                label_homeInformacoes.Text =
                    emServico + " ordens de serviço em trabalho abertas.\n\n" +
                    aguardando + " ordens de serviço paradas ou aguardando trabalho.\n\n" +
                    "Encontra-se " + prontas + " ordens de serviço prontas.\n\n" +
                    finalizadas + " ordens de serviço finalizadas.";
            }
        }
    }
}