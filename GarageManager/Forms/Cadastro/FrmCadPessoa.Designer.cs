namespace GarageManager.Forms.Cadastro
{
    partial class FrmCadPessoa
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
            this.LTelefone = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
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
            this.TPCadastro.Controls.Add(this.BtnInserir, 0, 6);
            this.TPCadastro.Controls.Add(this.BtnEditar, 1, 6);
            this.TPCadastro.Controls.Add(this.BtnExcluir, 2, 6);
            this.TPCadastro.Controls.Add(this.BtnFechar, 3, 6);
            this.TPCadastro.Controls.Add(this.LNome, 0, 2);
            this.TPCadastro.Controls.Add(this.TxtNome, 1, 2);
            this.TPCadastro.Controls.Add(this.LTelefone, 0, 3);
            this.TPCadastro.Controls.Add(this.LEmail, 0, 4);
            this.TPCadastro.Controls.Add(this.TxtTelefone, 1, 3);
            this.TPCadastro.Controls.Add(this.TxtEmail, 1, 4);
            this.TPCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.TPCadastro.Location = new System.Drawing.Point(0, 0);
            this.TPCadastro.Margin = new System.Windows.Forms.Padding(1);
            this.TPCadastro.Name = "TPCadastro";
            this.TPCadastro.RowCount = 7;
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.TPCadastro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
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
            this.CmbEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.TxtNome.MaxLength = 150;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(298, 18);
            this.TxtNome.TabIndex = 7;
            // 
            // LTelefone
            // 
            this.LTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LTelefone.AutoSize = true;
            this.LTelefone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefone.Location = new System.Drawing.Point(3, 61);
            this.LTelefone.Name = "LTelefone";
            this.LTelefone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LTelefone.Size = new System.Drawing.Size(94, 13);
            this.LTelefone.TabIndex = 8;
            this.LTelefone.Text = ":Telefone";
            // 
            // LEmail
            // 
            this.LEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(3, 79);
            this.LEmail.Name = "LEmail";
            this.LEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LEmail.Size = new System.Drawing.Size(94, 13);
            this.LEmail.TabIndex = 9;
            this.LEmail.Text = ":Email";
            // 
            // TxtTelefone
            // 
            this.TPCadastro.SetColumnSpan(this.TxtTelefone, 3);
            this.TxtTelefone.Enabled = false;
            this.TxtTelefone.Font = new System.Drawing.Font("Tahoma", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(101, 60);
            this.TxtTelefone.Margin = new System.Windows.Forms.Padding(1);
            this.TxtTelefone.MaxLength = 30;
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(298, 18);
            this.TxtTelefone.TabIndex = 10;
            // 
            // TxtEmail
            // 
            this.TPCadastro.SetColumnSpan(this.TxtEmail, 3);
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Tahoma", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(101, 78);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(298, 18);
            this.TxtEmail.TabIndex = 11;
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
            // FrmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 301);
            this.ControlBox = false;
            this.Controls.Add(this.TPCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
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
        private System.Windows.Forms.Label LTelefone;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}