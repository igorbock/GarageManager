namespace GarageManager.Forms
{
    partial class FrmCompraItem
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
            entityComboBox_produto = new GarageManager.Controls.EntityComboBox();
            nudQuantidade = new System.Windows.Forms.NumericUpDown();
            txtCusto = new System.Windows.Forms.TextBox();
            btnSalvar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            lblQtd = new System.Windows.Forms.Label();
            lblCusto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(nudQuantidade)).BeginInit();
            SuspendLayout();
            // 
            // entityComboBox_produto
            // 
            entityComboBox_produto.LabelText = "Produto";
            entityComboBox_produto.Location = new System.Drawing.Point(12, 12);
            entityComboBox_produto.Name = "entityComboBox_produto";
            entityComboBox_produto.Size = new System.Drawing.Size(360, 27);
            entityComboBox_produto.TabIndex = 0;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new System.Drawing.Point(12, 50);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new System.Drawing.Size(69, 15);
            lblQtd.TabIndex = 1;
            lblQtd.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new System.Drawing.Point(12, 68);
            nudQuantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new System.Drawing.Size(100, 23);
            nudQuantidade.TabIndex = 2;
            nudQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Location = new System.Drawing.Point(130, 50);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new System.Drawing.Size(75, 15);
            lblCusto.TabIndex = 3;
            lblCusto.Text = "Custo Unit.:";
            // 
            // txtCusto
            // 
            txtCusto.Location = new System.Drawing.Point(130, 68);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new System.Drawing.Size(100, 23);
            txtCusto.TabIndex = 4;
            txtCusto.Text = "0,00";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(12, 105);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(80, 28);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += BtnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(100, 105);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(80, 28);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmCompraItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(384, 145);
            Controls.Add(entityComboBox_produto);
            Controls.Add(lblQtd);
            Controls.Add(nudQuantidade);
            Controls.Add(lblCusto);
            Controls.Add(txtCusto);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCompraItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Item da Compra";
            Load += FrmCompraItem_Load;
            ((System.ComponentModel.ISupportInitialize)(nudQuantidade)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GarageManager.Controls.EntityComboBox entityComboBox_produto;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblCusto;
    }
}
