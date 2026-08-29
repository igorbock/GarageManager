using System;
using System.Windows.Forms;

namespace GarageManager.Forms.Auth
{
    public partial class FrmAuth : Form
    {
        public FrmAuth()
        {
            InitializeComponent();

            btnLogin.Click += (s, e) => Login();
            btnSair.Click += (s, e) => Sair();
            txtSenha.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) Login(); };
            txtUsuario.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtSenha.Focus(); };
            AcceptButton = btnLogin;
        }

        private void Login()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe usuário e senha.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var auth = new GarageManager.Auth.AuthService();
                auth.Autenticar(txtUsuario.Text.Trim(), txtSenha.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar: " + ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sair()
        {
            var objConfirmacao = MessageBox.Show("Você confirma sair do sistema?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (objConfirmacao == DialogResult.No) return;
            Application.Exit();
        }
    }
}
