using Ninject;
using System;
using System.Windows.Forms;

namespace GarageManager.Forms
{
    public partial class FrmGM : Form
    {
        private readonly StandardKernel _kernel;

        public FrmGM(StandardKernel kernel)
        {
            InitializeComponent();
            // Atribui as propriedades
            _kernel = kernel;
            // Atribui a chamada para cada item do menu
            MIMarca.Click += AbrirFormulario;
            MIModelo.Click += AbrirFormulario;
            MIPessoa.Click += AbrirFormulario;
        }

        private void AbrirFormulario(object sender, EventArgs e)
        {
            try
            {
                // Primeiro busca o controle que chamou o evento e pega o valor de Tag
                var nomeCompletoForm = ((ToolStripMenuItem)sender).Tag.ToString();
                // Cria instância
                var form = _kernel.Get<Form>(nomeCompletoForm) ?? throw new Exception("Formulário não encontrado");
                form.MdiParent = this;
                // Exibe
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
