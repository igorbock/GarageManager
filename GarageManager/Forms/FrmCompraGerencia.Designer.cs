namespace GarageManager.Forms
{
    partial class FrmCompraGerencia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgv = new System.Windows.Forms.DataGridView();
            btnAdicionar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnExcluir = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            groupBoxFiltros = new System.Windows.Forms.GroupBox();
            labelInicio = new System.Windows.Forms.Label();
            dtpInicio = new System.Windows.Forms.DateTimePicker();
            labelFim = new System.Windows.Forms.Label();
            dtpFim = new System.Windows.Forms.DateTimePicker();
            labelFornecedor = new System.Windows.Forms.Label();
            txtFornecedor = new System.Windows.Forms.TextBox();
            labelStatus = new System.Windows.Forms.Label();
            comboStatus = new System.Windows.Forms.ComboBox();
            btnFiltrar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();
            groupBoxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv.AutoGenerateColumns = false;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            new System.Windows.Forms.DataGridViewCheckBoxColumn { Name = "Selecionar", HeaderText = "", Width = 40, FalseValue = false, TrueValue = true },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "Id", Visible = false },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Data", DataPropertyName = "Data", HeaderText = "Data", Width = 90 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Fornecedor", DataPropertyName = "Fornecedor", HeaderText = "Fornecedor", Width = 150 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Total", DataPropertyName = "Total", HeaderText = "Total", Width = 80 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Status", Width = 90 },
            new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Observacao", DataPropertyName = "Observacao", HeaderText = "Observação", Width = 200 }});
            dgv.Location = new System.Drawing.Point(12, 85);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(560, 205);
            dgv.TabIndex = 0;
            dgv.CurrentCellDirtyStateChanged += Dgv_CurrentCellDirtyStateChanged;
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxFiltros.Controls.Add(labelInicio);
            groupBoxFiltros.Controls.Add(dtpInicio);
            groupBoxFiltros.Controls.Add(labelFim);
            groupBoxFiltros.Controls.Add(dtpFim);
            groupBoxFiltros.Controls.Add(labelFornecedor);
            groupBoxFiltros.Controls.Add(txtFornecedor);
            groupBoxFiltros.Controls.Add(labelStatus);
            groupBoxFiltros.Controls.Add(comboStatus);
            groupBoxFiltros.Controls.Add(btnFiltrar);
            groupBoxFiltros.Controls.Add(btnLimpar);
            groupBoxFiltros.Location = new System.Drawing.Point(12, 7);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Size = new System.Drawing.Size(560, 70);
            groupBoxFiltros.TabIndex = 1;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros";
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new System.Drawing.Point(10, 22);
            labelInicio.Name = "labelInicio";
            labelInicio.Size = new System.Drawing.Size(39, 15);
            labelInicio.TabIndex = 0;
            labelInicio.Text = "Início:";
            // 
            // dtpInicio
            // 
            dtpInicio.Checked = false;
            dtpInicio.CustomFormat = "dd/MM/yyyy";
            dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpInicio.Location = new System.Drawing.Point(55, 18);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowCheckBox = true;
            dtpInicio.Size = new System.Drawing.Size(120, 23);
            dtpInicio.TabIndex = 1;
            // 
            // labelFim
            // 
            labelFim.AutoSize = true;
            labelFim.Location = new System.Drawing.Point(185, 22);
            labelFim.Name = "labelFim";
            labelFim.Size = new System.Drawing.Size(28, 15);
            labelFim.TabIndex = 2;
            labelFim.Text = "Fim:";
            // 
            // dtpFim
            // 
            dtpFim.Checked = false;
            dtpFim.CustomFormat = "dd/MM/yyyy";
            dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFim.Location = new System.Drawing.Point(219, 18);
            dtpFim.Name = "dtpFim";
            dtpFim.ShowCheckBox = true;
            dtpFim.Size = new System.Drawing.Size(120, 23);
            dtpFim.TabIndex = 2;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.Location = new System.Drawing.Point(10, 48);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new System.Drawing.Size(68, 15);
            labelFornecedor.TabIndex = 3;
            labelFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new System.Drawing.Point(80, 44);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new System.Drawing.Size(150, 23);
            txtFornecedor.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new System.Drawing.Point(240, 48);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(42, 15);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status:";
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Todas", "ABERTA", "FECHADA", "CANCELADA" });
            comboStatus.Location = new System.Drawing.Point(288, 44);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new System.Drawing.Size(120, 23);
            comboStatus.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new System.Drawing.Point(430, 18);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(60, 23);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += BtnFiltrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new System.Drawing.Point(496, 18);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(60, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += BtnLimpar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new System.Drawing.Point(12, 300);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(80, 28);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(100, 300);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(80, 28);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new System.Drawing.Point(188, 300);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(80, 28);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new System.Drawing.Point(492, 300);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(80, 28);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += BtnFechar_Click;
            // 
            // FrmCompraGerencia
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 341);
            Controls.Add(groupBoxFiltros);
            Controls.Add(dgv);
            Controls.Add(btnAdicionar);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnFechar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompraGerencia";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Compras - Entrada de Estoque";
            Load += FrmCompraGerencia_Load;
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgv)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}
