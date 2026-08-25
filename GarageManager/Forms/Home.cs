using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GarageManager.Forms
{
    public partial class Home : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Home()
        {
            InitializeComponent();

            toolStripStatusLabel_versao.Text = "Garage Manager - Versão " + Application.ProductVersion;
            btnFechar.Click += Fechar;
            btnMinimizar.Click += Minimizar;
            panel1.MouseMove += MovimentarJanela;
            menuInicio.Click += (s, e) => AbrirInicio();
            menuOrdemServico.Click += (s, e) => AbrirConsultarAbertas();
            menuAjuda.Click += (s, e) => AbrirSobre();
        }

        private void Fechar(object sender, EventArgs e) => Close();
        private void Minimizar(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void MovimentarJanela(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirInicio();
        }



        private void MenuInicio_Click(object sender, EventArgs e)
        {
            AbrirInicio();
        }

        private void MenuAbrirOS_Click(object sender, EventArgs e)
        {
            AbrirAbrirOS();
        }

        private void MenuConsultarAbertas_Click(object sender, EventArgs e)
        {
            AbrirConsultarAbertas();
        }

        private void MenuConsultarProntas_Click(object sender, EventArgs e)
        {
            AbrirConsultarProntas();
        }

        private void MenuHistorico_Click(object sender, EventArgs e)
        {
            AbrirHistorico();
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            AbrirSobre();
        }

        public void AbrirInicio()
        {
            FrmInicio inicio = (FrmInicio)ObterFilho(typeof(FrmInicio));

            if (inicio == null)
            {
                inicio = new FrmInicio { MdiParent = this };
                inicio.Show();
            }

            inicio.Activate();
        }

        public void AbrirAbrirOS()
        {
            FrmAbrirOS abrirOS = (FrmAbrirOS)ObterFilho(typeof(FrmAbrirOS));

            if (abrirOS == null)
            {
                abrirOS = new FrmAbrirOS { MdiParent = this };
                abrirOS.Show();
            }

            abrirOS.Activate();
        }

        public void AbrirConsultarAbertas()
        {
            FrmConsultarAbertas consulta = (FrmConsultarAbertas)ObterFilho(typeof(FrmConsultarAbertas));

            if (consulta == null)
            {
                consulta = new FrmConsultarAbertas(this) { MdiParent = this };
                consulta.Show();
            }

            consulta.Activate();
        }

        public void AbrirConsultarProntas()
        {
            FrmConsultarProntas consulta = (FrmConsultarProntas)ObterFilho(typeof(FrmConsultarProntas));

            if (consulta == null)
            {
                consulta = new FrmConsultarProntas(this) { MdiParent = this };
                consulta.Show();
            }

            consulta.Activate();
        }

        public void AbrirHistorico()
        {
            FrmHistorico historico = (FrmHistorico)ObterFilho(typeof(FrmHistorico));

            if (historico == null)
            {
                historico = new FrmHistorico(this) { MdiParent = this };
                historico.Show();
            }

            historico.Activate();
        }

        public void AbrirOSInfo(int id)
        {
            OS_Info ordemServico = new OS_Info(id) { MainForm = this, MdiParent = this };
            ordemServico.Show();
        }

        private Form ObterFilho(Type tipo)
        {
            return MdiChildren.FirstOrDefault(filho => filho.GetType() == tipo);
        }

        private void AbrirSobre()
        {
            MessageBox.Show(Application.ProductVersion + "\n\n" +
                "***Atualizações***\n" +
                "--> Campos de buscas para O.S. abertas, prontas e encerradas\n" +
                "--> Regras para inserção de produtos incrementada nas ordens de serviço\n\n" +
                "***Reparos***\n" +
                "--> O.S. pode ser encerrada somente quando estiver pronta", "Garage Manager", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}