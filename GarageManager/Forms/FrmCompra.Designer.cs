namespace GarageManager.Forms
{
    partial class FrmCompra
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
            entityComboBox_fornecedor = new GarageManager.Controls.EntityComboBox();
            comboStatus = new System.Windows.Forms.ComboBox();
            txtObservacao = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            dgvItens = new System.Windows.Forms.DataGridView();
            btnAdicionar = new System.Windows.Forms.Button();
            btnRemover = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            btnVerEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvItens)).BeginInit();
            SuspendLayout();
            // 
            // entityComboBox_fornecedor
            // 
            entityComboBox_fornecedor.LabelText = "Fornecedor";
            entityComboBox_fornecedor.Location = new System.Drawing.Point(12, 12);
            entityComboBox_fornecedor.Name = "entityComboBox_fornecedor";
            entityComboBox_fornecedor.Size = new System.Drawing.Size(400, 27);
            entityComboBox_fornecedor.TabIndex = 0;
            // 
            // comboStatus
            // 
            comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboStatus.Items.AddRange(new object[] { "ABERTA", "FECHADA", "CANCELADA" });
            comboStatus.Location = new System.Drawing.Point(430, 12);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new System.Drawing.Size(120, 23);
            comboStatus.TabIndex = 1;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new System.Drawing.Point(12, 50);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PlaceholderText = "Observação";
            txtObservacao.Size = new System.Drawing.Size(538, 23);
            txtObservacao.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTotal.Location = new System.Drawing.Point(12, 80);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(200, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total: R$ 0,00";
            // 
            // dgvItens
            // 
            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Location = new System.Drawing.Point(12, 100);
            dgvItens.Name = "dgvItens";
            dgvItens.ReadOnly = true;
            dgvItens.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvItens.Size = new System.Drawing.Size(538, 220);
            dgvItens.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new System.Drawing.Point(12, 330);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(80, 28);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += BtnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new System.Drawing.Point(100, 330);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new System.Drawing.Size(80, 28);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += BtnRemover_Click;
            // 
            // btnVerEstoque
            // 
            btnVerEstoque.Location = new System.Drawing.Point(188, 330);
            btnVerEstoque.Name = "btnVerEstoque";
            btnVerEstoque.Size = new System.Drawing.Size(90, 28);
            btnVerEstoque.TabIndex = 7;
            btnVerEstoque.Text = "Ver Estoque";
            btnVerEstoque.UseVisualStyleBackColor = true;
            btnVerEstoque.Click += BtnVerEstoque_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(380, 330);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(80, 28);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new System.Drawing.Point(470, 330);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(80, 28);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += BtnFechar_Click;
            // 
            // FrmCompra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(562, 370);
            Controls.Add(entityComboBox_fornecedor);
            Controls.Add(comboStatus);
            Controls.Add(txtObservacao);
            Controls.Add(lblTotal);
            Controls.Add(dgvItens);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(btnVerEstoque);
            Controls.Add(btnSalvar);
            Controls.Add(btnFechar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompra";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Compra - Entrada de Estoque";
            Load += FrmCompra_Load;
            ((System.ComponentModel.ISupportInitialize)(dgvItens)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GarageManager.Controls.EntityComboBox entityComboBox_fornecedor;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVerEstoque;
    }
}
