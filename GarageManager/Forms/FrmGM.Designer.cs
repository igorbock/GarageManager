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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.MIMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.MIModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.MIPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.MIAbrirOS = new System.Windows.Forms.ToolStripMenuItem();
            this.MIListarOS = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCadastros,
            this.MServicos});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "Menu";
            // 
            // MCadastros
            // 
            this.MCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIMarca,
            this.MIModelo,
            this.MIPessoa});
            this.MCadastros.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MCadastros.ForeColor = System.Drawing.Color.Black;
            this.MCadastros.Name = "MCadastros";
            this.MCadastros.Size = new System.Drawing.Size(71, 20);
            this.MCadastros.Text = "&Cadastros";
            // 
            // MIMarca
            // 
            this.MIMarca.Name = "MIMarca";
            this.MIMarca.Size = new System.Drawing.Size(180, 22);
            this.MIMarca.Tag = "FrmCadMarca";
            this.MIMarca.Text = "Marca";
            // 
            // MIModelo
            // 
            this.MIModelo.Name = "MIModelo";
            this.MIModelo.Size = new System.Drawing.Size(180, 22);
            this.MIModelo.Text = "Modelo";
            // 
            // MIPessoa
            // 
            this.MIPessoa.Name = "MIPessoa";
            this.MIPessoa.Size = new System.Drawing.Size(180, 22);
            this.MIPessoa.Text = "Pessoa";
            // 
            // MServicos
            // 
            this.MServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIAbrirOS,
            this.MIListarOS});
            this.MServicos.Name = "MServicos";
            this.MServicos.Size = new System.Drawing.Size(62, 20);
            this.MServicos.Text = "&Servicos";
            // 
            // MIAbrirOS
            // 
            this.MIAbrirOS.Name = "MIAbrirOS";
            this.MIAbrirOS.Size = new System.Drawing.Size(180, 22);
            this.MIAbrirOS.Text = "Abrir O.S. (F2)";
            // 
            // MIListarOS
            // 
            this.MIListarOS.Name = "MIListarOS";
            this.MIListarOS.Size = new System.Drawing.Size(180, 22);
            this.MIListarOS.Text = "Listar O.S. (F3)";
            // 
            // FrmGM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmGM";
            this.Text = "Garage Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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