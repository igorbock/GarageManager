namespace GarageManager.Controller
{
    partial class Dialogo
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
            this.label_mensagem = new System.Windows.Forms.Label();
            this.label_produto = new System.Windows.Forms.Label();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_mensagem
            // 
            this.label_mensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mensagem.Location = new System.Drawing.Point(39, 9);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(247, 52);
            this.label_mensagem.TabIndex = 4;
            this.label_mensagem.Text = "Você deseja realmente exluir o seguinte produto da OS?";
            this.label_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_produto
            // 
            this.label_produto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_produto.Location = new System.Drawing.Point(39, 61);
            this.label_produto.Name = "label_produto";
            this.label_produto.Size = new System.Drawing.Size(247, 73);
            this.label_produto.TabIndex = 3;
            this.label_produto.Text = "Produto";
            this.label_produto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(42, 137);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 2;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.Button_cancelar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(211, 137);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(75, 23);
            this.button_excluir.TabIndex = 1;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.Button_excluir_Click);
            // 
            // Dialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 186);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.label_produto);
            this.Controls.Add(this.label_mensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção";
            this.Load += new System.EventHandler(this.Dialogo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_mensagem;
        private System.Windows.Forms.Label label_produto;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_excluir;
    }
}