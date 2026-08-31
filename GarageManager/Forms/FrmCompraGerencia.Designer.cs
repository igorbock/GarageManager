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
            comboStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(dgv)).BeginInit();
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
            dgv.Location = new System.Drawing.Point(12, 40);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new System.Drawing.Size(560, 250);
            dgv.TabIndex = 0;
            dgv.CurrentCellDirtyStateChanged += Dgv_CurrentCellDirtyStateChanged;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboStatus.FormattingEnabled = true;
            comboStatus.Items.AddRange(new object[] { "Todas", "ABERTA", "FECHADA", "CANCELADA" });
            comboStatus.Location = new System.Drawing.Point(12, 12);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new System.Drawing.Size(120, 23);
            comboStatus.TabIndex = 1;
            comboStatus.SelectedIndexChanged += ComboStatus_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new System.Drawing.Point(12, 300);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(80, 28);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(100, 300);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(80, 28);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new System.Drawing.Point(188, 300);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(80, 28);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += BtnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new System.Drawing.Point(492, 300);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(80, 28);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += BtnFechar_Click;
            // 
            // FrmCompraGerencia
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 341);
            Controls.Add(comboStatus);
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
    }
}
