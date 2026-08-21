namespace GarageManager.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrdemServico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbrirOS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarAbertas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarProntas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_versao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.menuOrdemServico,
            this.menuAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuInicio
            // 
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(45, 20);
            this.menuInicio.Text = "Início";
            this.menuInicio.Click += new System.EventHandler(this.MenuInicio_Click);
            // 
            // menuOrdemServico
            // 
            this.menuOrdemServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbrirOS,
            this.menuConsultarAbertas,
            this.menuConsultarProntas,
            this.menuHistorico});
            this.menuOrdemServico.Name = "menuOrdemServico";
            this.menuOrdemServico.Size = new System.Drawing.Size(105, 20);
            this.menuOrdemServico.Text = "Ordem de Serviço";
            // 
            // menuAbrirOS
            // 
            this.menuAbrirOS.Name = "menuAbrirOS";
            this.menuAbrirOS.Size = new System.Drawing.Size(236, 22);
            this.menuAbrirOS.Text = "Abrir Nova O.S.";
            this.menuAbrirOS.Click += new System.EventHandler(this.MenuAbrirOS_Click);
            // 
            // menuConsultarAbertas
            // 
            this.menuConsultarAbertas.Name = "menuConsultarAbertas";
            this.menuConsultarAbertas.Size = new System.Drawing.Size(236, 22);
            this.menuConsultarAbertas.Text = "Consultar O.S. Abertas";
            this.menuConsultarAbertas.Click += new System.EventHandler(this.MenuConsultarAbertas_Click);
            // 
            // menuConsultarProntas
            // 
            this.menuConsultarProntas.Name = "menuConsultarProntas";
            this.menuConsultarProntas.Size = new System.Drawing.Size(236, 22);
            this.menuConsultarProntas.Text = "Consultar O.S. Prontas";
            this.menuConsultarProntas.Click += new System.EventHandler(this.MenuConsultarProntas_Click);
            // 
            // menuHistorico
            // 
            this.menuHistorico.Name = "menuHistorico";
            this.menuHistorico.Size = new System.Drawing.Size(236, 22);
            this.menuHistorico.Text = "Histórico de O.S.";
            this.menuHistorico.Click += new System.EventHandler(this.MenuHistorico_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuAjuda.Text = "Ajuda";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(180, 22);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_versao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1052, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_versao
            // 
            this.toolStripStatusLabel_versao.Name = "toolStripStatusLabel_versao";
            this.toolStripStatusLabel_versao.Size = new System.Drawing.Size(103, 19);
            this.toolStripStatusLabel_versao.Text = "Garage Manager";
            this.toolStripStatusLabel_versao.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Garage Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripMenuItem menuOrdemServico;
        private System.Windows.Forms.ToolStripMenuItem menuAbrirOS;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarAbertas;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarProntas;
        private System.Windows.Forms.ToolStripMenuItem menuHistorico;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_versao;
    }
}