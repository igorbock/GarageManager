namespace GarageManager.Forms
{
    partial class FrmHistorico
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
            this.dataGridView_historico = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_pesquisaNomeHistorico = new System.Windows.Forms.TextBox();
            this.label_pesquisaNomeHistorico = new System.Windows.Forms.Label();
            this.label_pesquisaVeiculoHistorico = new System.Windows.Forms.Label();
            this.textBox_pesquisaVeiculoHistorico = new System.Windows.Forms.TextBox();
            this.textBox_pesquisaPlacaHistorico = new System.Windows.Forms.TextBox();
            this.label_pesquisaPlacaHistorico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historico)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_historico
            // 
            this.dataGridView_historico.AllowUserToAddRows = false;
            this.dataGridView_historico.AllowUserToDeleteRows = false;
            this.dataGridView_historico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historico.Location = new System.Drawing.Point(6, 62);
            this.dataGridView_historico.Name = "dataGridView_historico";
            this.dataGridView_historico.RowHeadersVisible = false;
            this.dataGridView_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_historico.Size = new System.Drawing.Size(688, 300);
            this.dataGridView_historico.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.textBox_pesquisaNomeHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaNomeHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaVeiculoHistorico);
            this.groupBox7.Controls.Add(this.textBox_pesquisaVeiculoHistorico);
            this.groupBox7.Controls.Add(this.textBox_pesquisaPlacaHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaPlacaHistorico);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(688, 50);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pesquisar";
            // 
            // textBox_pesquisaNomeHistorico
            // 
            this.textBox_pesquisaNomeHistorico.Location = new System.Drawing.Point(432, 19);
            this.textBox_pesquisaNomeHistorico.Name = "textBox_pesquisaNomeHistorico";
            this.textBox_pesquisaNomeHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaNomeHistorico.TabIndex = 5;
            this.textBox_pesquisaNomeHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaNomeHistorico_KeyDown);
            // 
            // label_pesquisaNomeHistorico
            // 
            this.label_pesquisaNomeHistorico.AutoSize = true;
            this.label_pesquisaNomeHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaNomeHistorico.Location = new System.Drawing.Point(372, 19);
            this.label_pesquisaNomeHistorico.Name = "label_pesquisaNomeHistorico";
            this.label_pesquisaNomeHistorico.Size = new System.Drawing.Size(54, 19);
            this.label_pesquisaNomeHistorico.TabIndex = 4;
            this.label_pesquisaNomeHistorico.Text = "Nome:";
            // 
            // label_pesquisaVeiculoHistorico
            // 
            this.label_pesquisaVeiculoHistorico.AutoSize = true;
            this.label_pesquisaVeiculoHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaVeiculoHistorico.Location = new System.Drawing.Point(183, 19);
            this.label_pesquisaVeiculoHistorico.Name = "label_pesquisaVeiculoHistorico";
            this.label_pesquisaVeiculoHistorico.Size = new System.Drawing.Size(63, 19);
            this.label_pesquisaVeiculoHistorico.TabIndex = 3;
            this.label_pesquisaVeiculoHistorico.Text = "Veículo:";
            // 
            // textBox_pesquisaVeiculoHistorico
            // 
            this.textBox_pesquisaVeiculoHistorico.Location = new System.Drawing.Point(253, 19);
            this.textBox_pesquisaVeiculoHistorico.Name = "textBox_pesquisaVeiculoHistorico";
            this.textBox_pesquisaVeiculoHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaVeiculoHistorico.TabIndex = 2;
            this.textBox_pesquisaVeiculoHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaVeiculoHistorico_KeyDown);
            // 
            // textBox_pesquisaPlacaHistorico
            // 
            this.textBox_pesquisaPlacaHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaHistorico.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaHistorico.MaxLength = 7;
            this.textBox_pesquisaPlacaHistorico.Name = "textBox_pesquisaPlacaHistorico";
            this.textBox_pesquisaPlacaHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaHistorico.TabIndex = 1;
            this.textBox_pesquisaPlacaHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaPlacaHistorico_KeyDown);
            this.textBox_pesquisaPlacaHistorico.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaHistorico_Leave);
            // 
            // label_pesquisaPlacaHistorico
            // 
            this.label_pesquisaPlacaHistorico.AutoSize = true;
            this.label_pesquisaPlacaHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaHistorico.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaHistorico.Name = "label_pesquisaPlacaHistorico";
            this.label_pesquisaPlacaHistorico.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaHistorico.TabIndex = 0;
            this.label_pesquisaPlacaHistorico.Text = "Placa:";
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.dataGridView_historico);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorico";
            this.Text = "Histórico de O.S. Encerradas";
            this.Activated += new System.EventHandler(this.FrmHistorico_Activated);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaHistorico;
        private System.Windows.Forms.Label label_pesquisaPlacaHistorico;
        private System.Windows.Forms.Label label_pesquisaVeiculoHistorico;
        private System.Windows.Forms.TextBox textBox_pesquisaVeiculoHistorico;
        private System.Windows.Forms.TextBox textBox_pesquisaNomeHistorico;
        private System.Windows.Forms.Label label_pesquisaNomeHistorico;
        private System.Windows.Forms.DataGridView dataGridView_historico;
    }
}