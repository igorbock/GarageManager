namespace GarageManager.Forms
{
    partial class FrmGM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MenuStrip = new System.Windows.Forms.MenuStrip();
            MCadastros = new System.Windows.Forms.ToolStripMenuItem();
            MIMarca = new System.Windows.Forms.ToolStripMenuItem();
            MIModelo = new System.Windows.Forms.ToolStripMenuItem();
            MIPessoa = new System.Windows.Forms.ToolStripMenuItem();
            MServicos = new System.Windows.Forms.ToolStripMenuItem();
            MIAbrirOS = new System.Windows.Forms.ToolStripMenuItem();
            MIListarOS = new System.Windows.Forms.ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MCadastros, MServicos });
            MenuStrip.Location = new System.Drawing.Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new System.Drawing.Size(800, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "Menu";
            // 
            // MCadastros
            // 
            MCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MIMarca, MIModelo, MIPessoa });
            MCadastros.Font = new System.Drawing.Font("Tahoma", 9F);
            MCadastros.ForeColor = System.Drawing.Color.Black;
            MCadastros.Name = "MCadastros";
            MCadastros.Size = new System.Drawing.Size(71, 20);
            MCadastros.Text = "&Cadastros";
            // 
            // MIMarca
            // 
            MIMarca.Name = "MIMarca";
            MIMarca.Size = new System.Drawing.Size(180, 22);
            MIMarca.Tag = "FrmCadMarca2";
            MIMarca.Text = "Marca";
            // 
            // MIModelo
            // 
            MIModelo.Name = "MIModelo";
            MIModelo.Size = new System.Drawing.Size(180, 22);
            MIModelo.Tag = "FrmCadModelo";
            MIModelo.Text = "Modelo";
            // 
            // MIPessoa
            // 
            MIPessoa.Name = "MIPessoa";
            MIPessoa.Size = new System.Drawing.Size(180, 22);
            MIPessoa.Tag = "FrmCadPessoa";
            MIPessoa.Text = "Pessoa";
            // 
            // MServicos
            // 
            MServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MIAbrirOS, MIListarOS });
            MServicos.Name = "MServicos";
            MServicos.Size = new System.Drawing.Size(62, 20);
            MServicos.Text = "&Servicos";
            // 
            // MIAbrirOS
            // 
            MIAbrirOS.Name = "MIAbrirOS";
            MIAbrirOS.Size = new System.Drawing.Size(149, 22);
            MIAbrirOS.Text = "Abrir O.S. (F2)";
            // 
            // MIListarOS
            // 
            MIListarOS.Name = "MIListarOS";
            MIListarOS.Size = new System.Drawing.Size(149, 22);
            MIListarOS.Text = "Listar O.S. (F3)";
            // 
            // FrmGM
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(MenuStrip);
            Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            MaximizeBox = false;
            Name = "FrmGM";
            Text = "Garage Manager";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MCadastros;
        private System.Windows.Forms.ToolStripMenuItem MIMarca;
        private System.Windows.Forms.ToolStripMenuItem MIModelo;
        private System.Windows.Forms.ToolStripMenuItem MIPessoa;
        private System.Windows.Forms.ToolStripMenuItem MServicos;
        private System.Windows.Forms.ToolStripMenuItem MIAbrirOS;
        private System.Windows.Forms.ToolStripMenuItem MIListarOS;
    }
}