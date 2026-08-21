namespace GarageManager.Forms
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_homeInformacoes = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_homeInformacoes
            // 
            this.label_homeInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_homeInformacoes.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homeInformacoes.Location = new System.Drawing.Point(100, 67);
            this.label_homeInformacoes.Name = "label_homeInformacoes";
            this.label_homeInformacoes.Size = new System.Drawing.Size(500, 220);
            this.label_homeInformacoes.TabIndex = 1;
            this.label_homeInformacoes.Text = "Informações";
            // 
            // label_home
            // 
            this.label_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_home.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(215, 13);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(265, 39);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Garage Manager";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.label_homeInformacoes);
            this.Controls.Add(this.label_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Início";
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_homeInformacoes;
        private System.Windows.Forms.Label label_home;
    }
}