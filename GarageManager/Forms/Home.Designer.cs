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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuInicio = new System.Windows.Forms.ToolStripMenuItem();
            menuOrdemServico = new System.Windows.Forms.ToolStripMenuItem();
            menuAbrirOS = new System.Windows.Forms.ToolStripMenuItem();
            menuConsultarAbertas = new System.Windows.Forms.ToolStripMenuItem();
            menuConsultarProntas = new System.Windows.Forms.ToolStripMenuItem();
            menuHistorico = new System.Windows.Forms.ToolStripMenuItem();
            menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel_versao = new System.Windows.Forms.ToolStripStatusLabel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuInicio, menuOrdemServico, menuAjuda });
            menuStrip1.Location = new System.Drawing.Point(0, 33);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(647, 99);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuInicio
            // 
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new System.Drawing.Size(48, 95);
            menuInicio.Text = "Início";
            menuInicio.Click += MenuInicio_Click;
            // 
            // menuOrdemServico
            // 
            menuOrdemServico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuAbrirOS, menuConsultarAbertas, menuConsultarProntas, menuHistorico });
            menuOrdemServico.Name = "menuOrdemServico";
            menuOrdemServico.Size = new System.Drawing.Size(113, 95);
            menuOrdemServico.Text = "Ordem de Serviço";
            // 
            // menuAbrirOS
            // 
            menuAbrirOS.Name = "menuAbrirOS";
            menuAbrirOS.Size = new System.Drawing.Size(192, 22);
            menuAbrirOS.Text = "Abrir Nova O.S.";
            menuAbrirOS.Click += MenuAbrirOS_Click;
            // 
            // menuConsultarAbertas
            // 
            menuConsultarAbertas.Name = "menuConsultarAbertas";
            menuConsultarAbertas.Size = new System.Drawing.Size(192, 22);
            menuConsultarAbertas.Text = "Consultar O.S. Abertas";
            menuConsultarAbertas.Click += MenuConsultarAbertas_Click;
            // 
            // menuConsultarProntas
            // 
            menuConsultarProntas.Name = "menuConsultarProntas";
            menuConsultarProntas.Size = new System.Drawing.Size(192, 22);
            menuConsultarProntas.Text = "Consultar O.S. Prontas";
            menuConsultarProntas.Click += MenuConsultarProntas_Click;
            // 
            // menuHistorico
            // 
            menuHistorico.Name = "menuHistorico";
            menuHistorico.Size = new System.Drawing.Size(192, 22);
            menuHistorico.Text = "Histórico de O.S.";
            menuHistorico.Click += MenuHistorico_Click;
            // 
            // menuAjuda
            // 
            menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuSobre });
            menuAjuda.Name = "menuAjuda";
            menuAjuda.Size = new System.Drawing.Size(50, 95);
            menuAjuda.Text = "Ajuda";
            // 
            // menuSobre
            // 
            menuSobre.Name = "menuSobre";
            menuSobre.Size = new System.Drawing.Size(104, 22);
            menuSobre.Text = "Sobre";
            menuSobre.Click += MenuSobre_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel_versao });
            statusStrip1.Location = new System.Drawing.Point(0, 315);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(647, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_versao
            // 
            toolStripStatusLabel_versao.Name = "toolStripStatusLabel_versao";
            toolStripStatusLabel_versao.Size = new System.Drawing.Size(94, 17);
            toolStripStatusLabel_versao.Text = "Garage Manager";
            toolStripStatusLabel_versao.Click += MenuSobre_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(647, 32);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Oswald SemiBold", 14F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(10, -1);
            label1.Margin = new System.Windows.Forms.Padding(1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(138, 32);
            label1.TabIndex = 4;
            label1.Text = "Garage Manager";
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(647, 337);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Home";
            Text = "Garage Manager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}