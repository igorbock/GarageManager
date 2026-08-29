namespace GarageManager.Forms.Auth
{
    partial class FrmAuth
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
            txtUsuario = new System.Windows.Forms.TextBox();
            txtSenha = new System.Windows.Forms.TextBox();
            lblUsuario = new System.Windows.Forms.Label();
            lblSenha = new System.Windows.Forms.Label();
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            btnSair = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            tableLayoutPanel.SetColumnSpan(txtUsuario, 2);
            txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUsuario.Location = new System.Drawing.Point(67, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(211, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            tableLayoutPanel.SetColumnSpan(txtSenha, 2);
            txtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSenha.Location = new System.Drawing.Point(67, 32);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new System.Drawing.Size(211, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(3, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(58, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Location = new System.Drawing.Point(3, 36);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(58, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.0284653F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.9715347F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel.Controls.Add(lblUsuario, 0, 0);
            tableLayoutPanel.Controls.Add(txtSenha, 1, 1);
            tableLayoutPanel.Controls.Add(lblSenha, 0, 1);
            tableLayoutPanel.Controls.Add(txtUsuario, 1, 0);
            tableLayoutPanel.Controls.Add(btnSair, 2, 2);
            tableLayoutPanel.Controls.Add(btnLogin, 1, 2);
            tableLayoutPanel.Location = new System.Drawing.Point(63, 47);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel.Size = new System.Drawing.Size(281, 88);
            tableLayoutPanel.TabIndex = 4;
            // 
            // btnSair
            // 
            btnSair.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSair.Location = new System.Drawing.Point(203, 61);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(75, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(67, 61);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // FrmAuth
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(399, 191);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmAuth";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmAuth";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogin;
    }
}