namespace GarageManager.Forms.Cadastro
{
    partial class FrmCadModelo
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
            this.TPCadastro = new System.Windows.Forms.TableLayoutPanel();
            this.CmbEntidade = new System.Windows.Forms.ComboBox();
            this.LEntidade = new System.Windows.Forms.Label();
            this.LNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LMarca = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.TPCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPCadastro
            // 
            this.TPCadastro.ColumnCount = 4;
            this.TPCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TPCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TPCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TPCadastro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TPCadastro.Controls.Add(this.CmbEntidade, 1, 0);
            this.TPCadastro.Controls.Add(this.LEntidade, 0, 0);
            this.TPCadastro.Controls.Add(this.BtnInserir, 0, 5);
            this.TPCadastro.Controls.Add(this.BtnEditar, 1, 5);
            this.TPCadastro.Controls.Add(this.BtnExcluir, 2, 5);
            this.TPCadastro.Controls.Add(this.BtnFechar, 3, 5);
            this.TPCadastro.Controls.Add(this.LNome, 0, 2);
            this.TPCadastro.Controls.Add(this.TxtNome, 1, 2);
            this.TPCadastro.Controls.Add(this.LMarca, 0, 3);
            this.TPCadastro.Controls.Add(this.CmbMarca, 1, 3);
            this.TPCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.TPCadastro.Location = new System.Drawing.Point(0, 0);
            this.TPCadastro.Margin = new System.Windows.Forms.Padding(1);
            this.TPCadastro.Name = "TPCadastro";
            this.TPCadastro.RowCount = 6;
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TPCadastro.Size = new System.Drawing.Size(400, 300);
            this.TPCadastro.TabIndex = 0;
            // 
            // CmbEntidade
            // 
            this.TPCadastro.SetColumnSpan(this.CmbEntidade, 3);
            this.CmbEntidade.DisplayMember = "DESCRICAO";
            this.CmbEntidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbEntidade.Font = new System.Drawing.Font("Tahoma", 15.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEntidade.ItemHeight = 25;
            this.CmbEntidade.Location = new System.Drawing.Point(101, 1);
            this.CmbEntidade.Margin = new System.Windows.Forms.Padding(1);
            this.CmbEntidade.Name = "CmbEntidade";
            this.CmbEntidade.Size = new System.Drawing.Size(298, 33);
            this.CmbEntidade.TabIndex = 1;
            this.CmbEntidade.ValueMember = "ID";
            // 
            // LEntidade
            // 
            this.LEntidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LEntidade.AutoSize = true;
            this.LEntidade.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEntidade.Location = new System.Drawing.Point(3, 7);
            this.LEntidade.Name = "LEntidade";
            this.LEntidade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LEntidade.Size = new System.Drawing.Size(94, 18);
            this.LEntidade.TabIndex = 1;
            this.LEntidade.Text = ":Entidade";
            // 
            // LNome
            // 
            this.LNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LNome.AutoSize = true;
            this.LNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNome.Location = new System.Drawing.Point(3, 43);
            this.LNome.Name = "LNome";
            this.LNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LNome.Size = new System.Drawing.Size(94, 13);
            this.LNome.TabIndex = 6;
            this.LNome.Text = ":Nome";
            // 
            // TxtNome
            // 
            this.TPCadastro.SetColumnSpan(this.TxtNome, 3);
            this.TxtNome.Enabled = false;
            this.TxtNome.Font = new System.Drawing.Font("Tahoma", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(101, 42);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(1);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(298, 18);
            this.TxtNome.TabIndex = 7;
            // 
            // LMarca
            // 
            this.LMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LMarca.AutoSize = true;
            this.LMarca.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarca.Location = new System.Drawing.Point(3, 61);
            this.LMarca.Name = "LMarca";
            this.LMarca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LMarca.Size = new System.Drawing.Size(94, 13);
            this.LMarca.TabIndex = 8;
            this.LMarca.Text = ":Marca";
            // 
            // CmbMarca
            // 
            this.TPCadastro.SetColumnSpan(this.CmbMarca, 3);
            this.CmbMarca.DisplayMember = "DESCRICAO";
            this.CmbMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbMarca.Enabled = false;
            this.CmbMarca.Font = new System.Drawing.Font("Tahoma", 6.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(101, 60);
            this.CmbMarca.Margin = new System.Windows.Forms.Padding(1);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(298, 18);
            this.CmbMarca.TabIndex = 9;
            this.CmbMarca.ValueMember = "ID";
            // 
            // BtnInserir
            // 
            this.BtnInserir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnInserir.Image = global::GarageManager.Properties.Resources.inserir;
            this.BtnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInserir.Location = new System.Drawing.Point(1, 276);
            this.BtnInserir.Margin = new System.Windows.Forms.Padding(1);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(98, 23);
            this.BtnInserir.TabIndex = 2;
            this.BtnInserir.Tag = "Salvar";
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInserir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEditar.Image = global::GarageManager.Properties.Resources.editar;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar.Location = new System.Drawing.Point(101, 276);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 23);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Tag = "Cancelar";
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExcluir.Image = global::GarageManager.Properties.Resources.excluir;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.Location = new System.Drawing.Point(201, 276);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(1);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(98, 23);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFechar.Image = global::GarageManager.Properties.Resources.fechar;
            this.BtnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFechar.Location = new System.Drawing.Point(301, 276);
            this.BtnFechar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(98, 23);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmCadModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 301);
            this.ControlBox = false;
            this.Controls.Add(this.TPCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Modelos de Veículos";
            this.TPCadastro.ResumeLayout(false);
            this.TPCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TPCadastro;
        private System.Windows.Forms.Label LEntidade;
        private System.Windows.Forms.ComboBox CmbEntidade;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LMarca;
        private System.Windows.Forms.ComboBox CmbMarca;
    }
}