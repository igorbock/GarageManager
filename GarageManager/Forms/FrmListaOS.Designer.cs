namespace GarageManager.Forms
{
    partial class FrmListaOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GOrdemServico = new System.Windows.Forms.DataGridView();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBFiltragem = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblDataFinal = new System.Windows.Forms.Label();
            this.LblDataInicial = new System.Windows.Forms.Label();
            this.TxtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.TxtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TLPOrdem = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GOrdemServico)).BeginInit();
            this.GBFiltragem.SuspendLayout();
            this.TLPOrdem.SuspendLayout();
            this.SuspendLayout();
            // 
            // GOrdemServico
            // 
            this.GOrdemServico.AllowUserToAddRows = false;
            this.GOrdemServico.AllowUserToDeleteRows = false;
            this.GOrdemServico.AllowUserToOrderColumns = true;
            this.GOrdemServico.AllowUserToResizeColumns = false;
            this.GOrdemServico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GOrdemServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GOrdemServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GOrdemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GOrdemServico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colData,
            this.colCliente,
            this.colPlaca,
            this.colId});
            this.GOrdemServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GOrdemServico.Location = new System.Drawing.Point(3, 73);
            this.GOrdemServico.MultiSelect = false;
            this.GOrdemServico.Name = "GOrdemServico";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GOrdemServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GOrdemServico.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GOrdemServico.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GOrdemServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GOrdemServico.ShowCellErrors = false;
            this.GOrdemServico.ShowCellToolTips = false;
            this.GOrdemServico.ShowEditingIcon = false;
            this.GOrdemServico.ShowRowErrors = false;
            this.GOrdemServico.Size = new System.Drawing.Size(679, 374);
            this.GOrdemServico.TabIndex = 13;
            this.GOrdemServico.TabStop = false;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "DATA";
            this.colData.Frozen = true;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "CLIENTE";
            this.colCliente.Frozen = true;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colPlaca
            // 
            this.colPlaca.DataPropertyName = "PLACA";
            this.colPlaca.Frozen = true;
            this.colPlaca.HeaderText = "Placa";
            this.colPlaca.Name = "colPlaca";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            this.colId.Frozen = true;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // GBFiltragem
            // 
            this.GBFiltragem.Controls.Add(this.BtnLimpar);
            this.GBFiltragem.Controls.Add(this.BtnFiltrar);
            this.GBFiltragem.Controls.Add(this.LblPlaca);
            this.GBFiltragem.Controls.Add(this.LblCliente);
            this.GBFiltragem.Controls.Add(this.LblDataFinal);
            this.GBFiltragem.Controls.Add(this.LblDataInicial);
            this.GBFiltragem.Controls.Add(this.TxtDataFinal);
            this.GBFiltragem.Controls.Add(this.TxtDataInicial);
            this.GBFiltragem.Controls.Add(this.TxtPlaca);
            this.GBFiltragem.Controls.Add(this.TxtCliente);
            this.GBFiltragem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBFiltragem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFiltragem.Location = new System.Drawing.Point(3, 3);
            this.GBFiltragem.Name = "GBFiltragem";
            this.GBFiltragem.Size = new System.Drawing.Size(679, 64);
            this.GBFiltragem.TabIndex = 1;
            this.GBFiltragem.TabStop = false;
            this.GBFiltragem.Text = "Fitragem";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(570, 35);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(103, 23);
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar Filtro";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(570, 11);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(103, 23);
            this.BtnFiltrar.TabIndex = 10;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Location = new System.Drawing.Point(318, 40);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(40, 13);
            this.LblPlaca.TabIndex = 8;
            this.LblPlaca.Text = "Placa:";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(31, 40);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(49, 13);
            this.LblCliente.TabIndex = 6;
            this.LblCliente.Text = "Cliente:";
            // 
            // LblDataFinal
            // 
            this.LblDataFinal.AutoSize = true;
            this.LblDataFinal.Location = new System.Drawing.Point(292, 17);
            this.LblDataFinal.Name = "LblDataFinal";
            this.LblDataFinal.Size = new System.Drawing.Size(66, 13);
            this.LblDataFinal.TabIndex = 4;
            this.LblDataFinal.Text = "Data Final:";
            // 
            // LblDataInicial
            // 
            this.LblDataInicial.AutoSize = true;
            this.LblDataInicial.Location = new System.Drawing.Point(6, 17);
            this.LblDataInicial.Name = "LblDataInicial";
            this.LblDataInicial.Size = new System.Drawing.Size(74, 13);
            this.LblDataInicial.TabIndex = 2;
            this.LblDataInicial.Text = "Data Inicial:";
            // 
            // TxtDataFinal
            // 
            this.TxtDataFinal.Location = new System.Drawing.Point(364, 11);
            this.TxtDataFinal.Name = "TxtDataFinal";
            this.TxtDataFinal.Size = new System.Drawing.Size(200, 21);
            this.TxtDataFinal.TabIndex = 5;
            // 
            // TxtDataInicial
            // 
            this.TxtDataInicial.Location = new System.Drawing.Point(86, 11);
            this.TxtDataInicial.Name = "TxtDataInicial";
            this.TxtDataInicial.Size = new System.Drawing.Size(200, 21);
            this.TxtDataInicial.TabIndex = 3;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(364, 37);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(200, 21);
            this.TxtPlaca.TabIndex = 9;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(86, 37);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(200, 21);
            this.TxtCliente.TabIndex = 7;
            // 
            // TLPOrdem
            // 
            this.TLPOrdem.ColumnCount = 1;
            this.TLPOrdem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPOrdem.Controls.Add(this.GOrdemServico, 0, 1);
            this.TLPOrdem.Controls.Add(this.GBFiltragem, 0, 0);
            this.TLPOrdem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPOrdem.Location = new System.Drawing.Point(0, 0);
            this.TLPOrdem.Margin = new System.Windows.Forms.Padding(0);
            this.TLPOrdem.Name = "TLPOrdem";
            this.TLPOrdem.RowCount = 2;
            this.TLPOrdem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.TLPOrdem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.TLPOrdem.Size = new System.Drawing.Size(685, 450);
            this.TLPOrdem.TabIndex = 2;
            // 
            // FrmListaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.TLPOrdem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            ((System.ComponentModel.ISupportInitialize)(this.GOrdemServico)).EndInit();
            this.GBFiltragem.ResumeLayout(false);
            this.GBFiltragem.PerformLayout();
            this.TLPOrdem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBFiltragem;
        private System.Windows.Forms.TableLayoutPanel TLPOrdem;
        private System.Windows.Forms.DataGridView GOrdemServico;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.Label LblDataInicial;
        private System.Windows.Forms.DateTimePicker TxtDataFinal;
        private System.Windows.Forms.DateTimePicker TxtDataInicial;
        private System.Windows.Forms.Label LblDataFinal;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblCliente;
    }
}