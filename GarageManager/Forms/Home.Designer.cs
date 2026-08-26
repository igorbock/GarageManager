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
            menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel_versao = new System.Windows.Forms.ToolStripStatusLabel();
            panel1 = new System.Windows.Forms.Panel();
            btnMinimizar = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuInicio, menuOrdemServico, menuAjuda });
            menuStrip1.Location = new System.Drawing.Point(0, 32);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(647, 61);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuInicio
            // 
            menuInicio.Image = Properties.Resources.inicio;
            menuInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new System.Drawing.Size(48, 57);
            menuInicio.Text = "Início";
            menuInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            menuInicio.Click += MenuInicio_Click;
            // 
            // menuOrdemServico
            // 
            menuOrdemServico.Image = Properties.Resources.ordem_servico;
            menuOrdemServico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuOrdemServico.Name = "menuOrdemServico";
            menuOrdemServico.Size = new System.Drawing.Size(113, 57);
            menuOrdemServico.Text = "Ordem de Serviço";
            menuOrdemServico.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            menuOrdemServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuAjuda
            // 
            menuAjuda.Image = Properties.Resources.sobre;
            menuAjuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            menuAjuda.Name = "menuAjuda";
            menuAjuda.Size = new System.Drawing.Size(50, 57);
            menuAjuda.Text = "Ajuda";
            menuAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(647, 93);
            panel1.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMinimizar.Image = Properties.Resources.circulo_minimizar;
            btnMinimizar.Location = new System.Drawing.Point(598, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new System.Drawing.Size(20, 29);
            btnMinimizar.TabIndex = 6;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFechar.Image = Properties.Resources.circulo_fechar;
            btnFechar.Location = new System.Drawing.Point(622, 1);
            btnFechar.Margin = new System.Windows.Forms.Padding(1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(24, 32);
            btnFechar.TabIndex = 5;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Oswald SemiBold", 14F);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(1, 1);
            label1.Margin = new System.Windows.Forms.Padding(1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(593, 33);
            label1.TabIndex = 4;
            label1.Text = "Garage Manager";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMinimizar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnFechar, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(647, 35);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(647, 337);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuInicio;
        private System.Windows.Forms.ToolStripMenuItem menuOrdemServico;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_versao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}