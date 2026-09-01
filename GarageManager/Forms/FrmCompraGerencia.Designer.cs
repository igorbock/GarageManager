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
            entityComboBox1 = new GarageManager.Controls.EntityComboBox();
            labelInicio = new System.Windows.Forms.Label();
            dtpInicio = new System.Windows.Forms.DateTimePicker();
            labelFim = new System.Windows.Forms.Label();
            dtpFim = new System.Windows.Forms.DateTimePicker();
            labelStatus = new System.Windows.Forms.Label();
            comboStatus = new System.Windows.Forms.ComboBox();
            btnFiltrar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBoxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new System.Drawing.Point(12, 85);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(560, 205);
            dgv.TabIndex = 0;
            dgv.CurrentCellDirtyStateChanged += Dgv_CurrentCellDirtyStateChanged;
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
            // groupBoxFiltros
            // 
            groupBoxFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBoxFiltros.Controls.Add(entityComboBox1);
            groupBoxFiltros.Controls.Add(labelInicio);
            groupBoxFiltros.Controls.Add(dtpInicio);
            groupBoxFiltros.Controls.Add(labelFim);
            groupBoxFiltros.Controls.Add(dtpFim);
            groupBoxFiltros.Controls.Add(labelStatus);
            groupBoxFiltros.Controls.Add(comboStatus);
            groupBoxFiltros.Controls.Add(btnFiltrar);
            groupBoxFiltros.Controls.Add(btnLimpar);
            groupBoxFiltros.Location = new System.Drawing.Point(1, 1);
            groupBoxFiltros.Margin = new System.Windows.Forms.Padding(1);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Size = new System.Drawing.Size(582, 70);
            groupBoxFiltros.TabIndex = 0;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros";
            // 
            // entityComboBox1
            // 
            entityComboBox1.Location = new System.Drawing.Point(11, 41);
            entityComboBox1.Margin = new System.Windows.Forms.Padding(0);
            entityComboBox1.Name = "entityComboBox1";
            entityComboBox1.Size = new System.Drawing.Size(499, 27);
            entityComboBox1.TabIndex = 6;
            // 
            // labelInicio
            // 
            labelInicio.AutoSize = true;
            labelInicio.Location = new System.Drawing.Point(10, 19);
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
            dtpInicio.Location = new System.Drawing.Point(55, 15);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowCheckBox = true;
            dtpInicio.Size = new System.Drawing.Size(120, 23);
            dtpInicio.TabIndex = 1;
            // 
            // labelFim
            // 
            labelFim.AutoSize = true;
            labelFim.Location = new System.Drawing.Point(185, 19);
            labelFim.Name = "labelFim";
            labelFim.Size = new System.Drawing.Size(30, 15);
            labelFim.TabIndex = 2;
            labelFim.Text = "Fim:";
            // 
            // dtpFim
            // 
            dtpFim.Checked = false;
            dtpFim.CustomFormat = "dd/MM/yyyy";
            dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFim.Location = new System.Drawing.Point(219, 15);
            dtpFim.Name = "dtpFim";
            dtpFim.ShowCheckBox = true;
            dtpFim.Size = new System.Drawing.Size(120, 23);
            dtpFim.TabIndex = 3;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new System.Drawing.Point(342, 19);
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
            comboStatus.Location = new System.Drawing.Point(390, 15);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new System.Drawing.Size(120, 23);
            comboStatus.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new System.Drawing.Point(516, 14);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new System.Drawing.Size(60, 23);
            btnFiltrar.TabIndex = 7;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += BtnFiltrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new System.Drawing.Point(516, 40);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(60, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += BtnLimpar_Click;
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
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
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
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
        private Controls.EntityComboBox entityComboBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
