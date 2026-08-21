namespace GarageManager.Forms
{
    partial class FrmConsultarAbertas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_pesquisaPlacaAberta = new System.Windows.Forms.Label();
            this.textBox_pesquisaPlacaAberta = new System.Windows.Forms.TextBox();
            this.button_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(688, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_editar
            // 
            this.button_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_editar.Location = new System.Drawing.Point(6, 368);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(100, 25);
            this.button_editar.TabIndex = 2;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.Button_editar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label_pesquisaPlacaAberta);
            this.groupBox5.Controls.Add(this.textBox_pesquisaPlacaAberta);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(688, 50);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisar";
            // 
            // label_pesquisaPlacaAberta
            // 
            this.label_pesquisaPlacaAberta.AutoSize = true;
            this.label_pesquisaPlacaAberta.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaAberta.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaAberta.Name = "label_pesquisaPlacaAberta";
            this.label_pesquisaPlacaAberta.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaAberta.TabIndex = 1;
            this.label_pesquisaPlacaAberta.Text = "Placa:";
            // 
            // textBox_pesquisaPlacaAberta
            // 
            this.textBox_pesquisaPlacaAberta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaAberta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_pesquisaPlacaAberta.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaAberta.MaxLength = 7;
            this.textBox_pesquisaPlacaAberta.Name = "textBox_pesquisaPlacaAberta";
            this.textBox_pesquisaPlacaAberta.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaAberta.TabIndex = 0;
            this.textBox_pesquisaPlacaAberta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaPlaca_KeyDown);
            this.textBox_pesquisaPlacaAberta.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaAberta_Leave);
            // 
            // FrmConsultarAbertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarAbertas";
            this.Text = "Consultar O.S. Abertas";
            this.Activated += new System.EventHandler(this.FrmConsultarAbertas_Activated);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_pesquisaPlacaAberta;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaAberta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_editar;
    }
}