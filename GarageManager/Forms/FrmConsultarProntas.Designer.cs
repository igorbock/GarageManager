namespace GarageManager.Forms
{
    partial class FrmConsultarProntas
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
            this.dataGridView_encerradas = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_pesquisaPlacaEncerrada = new System.Windows.Forms.TextBox();
            this.label_pesquisaPlacaEncerrada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encerradas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_encerradas
            // 
            this.dataGridView_encerradas.AllowUserToAddRows = false;
            this.dataGridView_encerradas.AllowUserToDeleteRows = false;
            this.dataGridView_encerradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_encerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_encerradas.Location = new System.Drawing.Point(6, 62);
            this.dataGridView_encerradas.MultiSelect = false;
            this.dataGridView_encerradas.Name = "dataGridView_encerradas";
            this.dataGridView_encerradas.RowHeadersVisible = false;
            this.dataGridView_encerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_encerradas.Size = new System.Drawing.Size(688, 300);
            this.dataGridView_encerradas.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.textBox_pesquisaPlacaEncerrada);
            this.groupBox6.Controls.Add(this.label_pesquisaPlacaEncerrada);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(688, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesquisar";
            // 
            // textBox_pesquisaPlacaEncerrada
            // 
            this.textBox_pesquisaPlacaEncerrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaEncerrada.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaEncerrada.MaxLength = 7;
            this.textBox_pesquisaPlacaEncerrada.Name = "textBox_pesquisaPlacaEncerrada";
            this.textBox_pesquisaPlacaEncerrada.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaEncerrada.TabIndex = 1;
            this.textBox_pesquisaPlacaEncerrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            this.textBox_pesquisaPlacaEncerrada.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaEncerrada_Leave);
            // 
            // label_pesquisaPlacaEncerrada
            // 
            this.label_pesquisaPlacaEncerrada.AutoSize = true;
            this.label_pesquisaPlacaEncerrada.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaEncerrada.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaEncerrada.Name = "label_pesquisaPlacaEncerrada";
            this.label_pesquisaPlacaEncerrada.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaEncerrada.TabIndex = 0;
            this.label_pesquisaPlacaEncerrada.Text = "Placa:";
            // 
            // FrmConsultarProntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.dataGridView_encerradas);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarProntas";
            this.Text = "Consultar O.S. Prontas";
            this.Activated += new System.EventHandler(this.FrmConsultarProntas_Activated);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encerradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaEncerrada;
        private System.Windows.Forms.Label label_pesquisaPlacaEncerrada;
        private System.Windows.Forms.DataGridView dataGridView_encerradas;
    }
}