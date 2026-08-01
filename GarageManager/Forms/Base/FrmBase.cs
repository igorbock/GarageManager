using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GarageManager.Forms.Base;

public partial class FrmBase : Form
{
    private Panel pnlTitleBar;
    private Label lblTitle;
    private Button btnMinimize;
    private Button btnMaximize;
    private Button btnClose;

    public FrmBase()
    {
        InitializeComponent();

        CriarLayout();

        pnlTitleBar.DoubleClick += (s, e) =>
        {
            WindowState =
                WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        };
    }

    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll")]
    public static extern IntPtr SendMessage(
        IntPtr hWnd,
        int Msg,
        int wParam,
        int lParam);

    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HTCAPTION = 0x2;

    protected override CreateParams CreateParams
    {
        get
        {
            const int CS_DROPSHADOW = 0x20000;

            CreateParams cp = base.CreateParams;
            cp.ClassStyle |= CS_DROPSHADOW;

            return cp;
        }
    }

    private void CriarLayout()
    {
        FormBorderStyle = FormBorderStyle.None;
        StartPosition = FormStartPosition.CenterScreen;

        BackColor = Color.White;

        pnlTitleBar = new Panel();
        pnlTitleBar.Dock = DockStyle.Top;
        pnlTitleBar.Height = 40;

        pnlTitleBar.BackColor =
            Color.FromArgb(0, 120, 215);

        pnlTitleBar.MouseDown += PnlTitleBar_MouseDown;

        Controls.Add(pnlTitleBar);

        lblTitle = new Label();
        lblTitle.Text = Text;
        lblTitle.ForeColor = Color.White;
        lblTitle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

        lblTitle.AutoSize = true;
        lblTitle.Location = new Point(12, 11);

        lblTitle.MouseDown += PnlTitleBar_MouseDown;

        pnlTitleBar.Controls.Add(lblTitle);

        CriarBotoes();
    }

    private void CriarBotoes()
    {
        btnClose = CriarBotao("✕");
        btnMaximize = CriarBotao("□");
        btnMinimize = CriarBotao("─");

        btnClose.Click += (s, e) => Close();

        btnMinimize.Click += (s, e) =>
            WindowState = FormWindowState.Minimized;

        btnMaximize.Click += (s, e) =>
        {
            WindowState =
                WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        };

        btnClose.Location =
            new Point(Width - 45, 0);

        btnMaximize.Location =
            new Point(Width - 90, 0);

        btnMinimize.Location =
            new Point(Width - 135, 0);

        pnlTitleBar.Controls.Add(btnClose);
        pnlTitleBar.Controls.Add(btnMaximize);
        pnlTitleBar.Controls.Add(btnMinimize);
    }

    private Button CriarBotao(string texto)
    {
        Button btn = new Button();

        btn.Text = texto;

        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderSize = 0;

        btn.ForeColor = Color.White;

        btn.BackColor =
            Color.FromArgb(0, 120, 215);

        btn.Size = new Size(45, 40);

        btn.Anchor =
            AnchorStyles.Top |
            AnchorStyles.Right;

        btn.Font =
            new Font("Segoe UI", 10);

        btn.MouseEnter += (s, e) =>
        {
            btn.BackColor =
                Color.FromArgb(30, 144, 255);
        };

        btn.MouseLeave += (s, e) =>
        {
            btn.BackColor =
                Color.FromArgb(0, 120, 215);
        };

        return btn;
    }

    private void PnlTitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();

        SendMessage(
            Handle,
            WM_NCLBUTTONDOWN,
            HTCAPTION,
            0);
    }

    private void AtualizarRegiao()
    {
        int raio = 12;

        GraphicsPath path = new GraphicsPath();

        path.AddArc(0, 0, raio, raio, 180, 90);
        path.AddArc(Width - raio, 0, raio, raio, 270, 90);
        path.AddArc(Width - raio, Height - raio, raio, raio, 0, 90);
        path.AddArc(0, Height - raio, raio, raio, 90, 90);

        path.CloseFigure();

        Region = new Region(path);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        AtualizarRegiao();
    }
}
