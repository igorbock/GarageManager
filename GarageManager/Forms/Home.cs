using GarageManager.Auth;
using GarageManager.Data;
using GarageManager.Forms.Cadastros;
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
            menuOrdemServico.Click += (s, e) => AbrirOrdemServicoGerencia();
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
            MaximizarNaAreaDeTrabalho();
            Hide();
            VerificarAutenticacao();
        }

        private void VerificarAutenticacao()
        {
            if (Sessao.EstaAutenticado())
            {
                AplicarEstadoAutenticado();
                return;
            }
            menuStrip1.Enabled = false;
            using (var login = new Forms.Auth.FrmAuth())
            {
                var result = login.ShowDialog(this);
                if (result != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }
            AplicarEstadoAutenticado();
        }

        private void AplicarEstadoAutenticado()
        {
            Show();
            MaximizarNaAreaDeTrabalho();
            menuStrip1.Enabled = true;
            toolStripStatusLabel_versao.Text = $"Garage Manager - Versão {Application.ProductVersion} | {Sessao.UsuarioNome}";
            AbrirInicio();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair e voltar ao login?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            new AuthService().Logout();
            foreach (var f in MdiChildren) f.Close();
            menuStrip1.Enabled = false;
            toolStripStatusLabel_versao.Text = "Garage Manager - Versão " + Application.ProductVersion;
            Hide();
            VerificarAutenticacao();
        }

        private void MaximizarNaAreaDeTrabalho()
        {
            var area = Screen.PrimaryScreen.WorkingArea;
            this.Location = new System.Drawing.Point(area.X, area.Y);
            this.Size = new System.Drawing.Size(area.Width, area.Height);
        }

        private void MenuInicio_Click(object sender, EventArgs e)
        {
            AbrirInicio();
        }

        private void MenuOrdemServico_Click(object sender, EventArgs e)
        {
            AbrirOrdemServicoGerencia();
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            AbrirSobre();
        }

        private void MenuCadMecanico_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadMecanico();
            frm.ShowDialog();
        }

        private void MenuCadCliente_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadCliente();
            frm.ShowDialog();
        }

        private void MenuCadServico_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadServico();
            frm.ShowDialog();
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

        public void AbrirOrdemServico()
        {
            FrmOrdemServico frm = (FrmOrdemServico)ObterFilho(typeof(FrmOrdemServico));

            if (frm == null)
            {
                frm = new FrmOrdemServico { MdiParent = this };
                frm.Show();
            }

            frm.Activate();
        }

        public void AbrirOrdemServicoGerencia()
        {
            FrmOrdemServicoGerencia frm = (FrmOrdemServicoGerencia)ObterFilho(typeof(FrmOrdemServicoGerencia));

            if (frm == null)
            {
                frm = new FrmOrdemServicoGerencia(this) { MdiParent = this };
                frm.Show();
            }

            frm.Activate();
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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente frmCadCliente = new FrmCadCliente() { MdiParent = this };
            frmCadCliente.Show();
        }

        private void servicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadServico frmCadServico = new FrmCadServico() { MdiParent = this };
            frmCadServico.Show();
        }

        private void mecânicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadMecanico frmCadMecanico = new FrmCadMecanico() { MdiParent = this };
            frmCadMecanico.Show();
        }
    }
}