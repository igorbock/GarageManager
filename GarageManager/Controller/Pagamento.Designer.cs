namespace GarageManager.Controller
{
    partial class Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pagamento = new System.Windows.Forms.TextBox();
            this.label_infoPagamento = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_pagamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de pagamentos e mais informações";
            // 
            // textBox_pagamento
            // 
            this.textBox_pagamento.Location = new System.Drawing.Point(6, 19);
            this.textBox_pagamento.Multiline = true;
            this.textBox_pagamento.Name = "textBox_pagamento";
            this.textBox_pagamento.Size = new System.Drawing.Size(524, 241);
            this.textBox_pagamento.TabIndex = 0;
            // 
            // label_infoPagamento
            // 
            this.label_infoPagamento.AutoSize = true;
            this.label_infoPagamento.Location = new System.Drawing.Point(15, 291);
            this.label_infoPagamento.Name = "label_infoPagamento";
            this.label_infoPagamento.Size = new System.Drawing.Size(352, 13);
            this.label_infoPagamento.TabIndex = 1;
            this.label_infoPagamento.Text = "Todos os pagamentos registrados aqui ficam salvos após clicar no botão.";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(473, 286);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 2;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 324);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.label_infoPagamento);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.Pagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pagamento;
        private System.Windows.Forms.Label label_infoPagamento;
        private System.Windows.Forms.Button button_salvar;
    }
}