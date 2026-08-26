namespace GarageManager.Forms
{
    partial class FrmOrdemServico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton_servico = new System.Windows.Forms.RadioButton();
            this.radioButton_aguardo = new System.Windows.Forms.RadioButton();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox_servicos = new System.Windows.Forms.TextBox();
            this.textBox_km = new System.Windows.Forms.TextBox();
            this.textBox_ano = new System.Windows.Forms.TextBox();
            this.textBox_cor = new System.Windows.Forms.TextBox();
            this.textBox_modelo = new System.Windows.Forms.TextBox();
            this.textBox_placa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_horaInicio = new System.Windows.Forms.Label();
            this.label_dataInicio = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_salvar
            // 
            this.button_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_salvar.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.Location = new System.Drawing.Point(6, 312);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 37);
            this.button_salvar.TabIndex = 9;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.textBox_telefone);
            this.groupBox4.Controls.Add(this.textBox_nome);
            this.groupBox4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(688, 55);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_telefone.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_telefone.Location = new System.Drawing.Point(382, 19);
            this.textBox_telefone.MaxLength = 30;
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(300, 27);
            this.textBox_telefone.TabIndex = 8;
            this.textBox_telefone.Text = "Telefone";
            this.textBox_telefone.Enter += new System.EventHandler(this.TextBox_telefone_Enter);
            this.textBox_telefone.Leave += new System.EventHandler(this.TextBox_telefone_Leave);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_nome.Location = new System.Drawing.Point(9, 19);
            this.textBox_nome.MaxLength = 100;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(367, 27);
            this.textBox_nome.TabIndex = 7;
            this.textBox_nome.Text = "Nome";
            this.textBox_nome.Enter += new System.EventHandler(this.TextBox_nome_Enter);
            this.textBox_nome.Leave += new System.EventHandler(this.TextBox_nome_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButton_servico);
            this.groupBox3.Controls.Add(this.radioButton_aguardo);
            this.groupBox3.Controls.Add(this.label_status);
            this.groupBox3.Controls.Add(this.textBox_servicos);
            this.groupBox3.Controls.Add(this.textBox_km);
            this.groupBox3.Controls.Add(this.textBox_ano);
            this.groupBox3.Controls.Add(this.textBox_cor);
            this.groupBox3.Controls.Add(this.textBox_modelo);
            this.groupBox3.Controls.Add(this.textBox_placa);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 189);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veículo";
            // 
            // radioButton_servico
            // 
            this.radioButton_servico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_servico.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_servico.Location = new System.Drawing.Point(592, 22);
            this.radioButton_servico.Name = "radioButton_servico";
            this.radioButton_servico.Size = new System.Drawing.Size(90, 17);
            this.radioButton_servico.TabIndex = 2;
            this.radioButton_servico.TabStop = true;
            this.radioButton_servico.Text = "Em serviço";
            this.radioButton_servico.UseVisualStyleBackColor = true;
            // 
            // radioButton_aguardo
            // 
            this.radioButton_aguardo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_aguardo.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_aguardo.Location = new System.Drawing.Point(446, 22);
            this.radioButton_aguardo.Name = "radioButton_aguardo";
            this.radioButton_aguardo.Size = new System.Drawing.Size(140, 17);
            this.radioButton_aguardo.TabIndex = 1;
            this.radioButton_aguardo.TabStop = true;
            this.radioButton_aguardo.Text = "Aguardando serviço";
            this.radioButton_aguardo.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(330, 24);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(110, 13);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "Status do veículo:";
            // 
            // textBox_servicos
            // 
            this.textBox_servicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_servicos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_servicos.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_servicos.Location = new System.Drawing.Point(9, 94);
            this.textBox_servicos.MaxLength = 500;
            this.textBox_servicos.Multiline = true;
            this.textBox_servicos.Name = "textBox_servicos";
            this.textBox_servicos.Size = new System.Drawing.Size(673, 89);
            this.textBox_servicos.TabIndex = 6;
            this.textBox_servicos.Text = "Serviços esperados";
            this.textBox_servicos.Enter += new System.EventHandler(this.TextBox_servicos_Enter);
            this.textBox_servicos.Leave += new System.EventHandler(this.TextBox_servicos_Leave);
            // 
            // textBox_km
            // 
            this.textBox_km.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_km.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_km.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_km.Location = new System.Drawing.Point(532, 58);
            this.textBox_km.MaxLength = 10;
            this.textBox_km.Name = "textBox_km";
            this.textBox_km.Size = new System.Drawing.Size(150, 27);
            this.textBox_km.TabIndex = 5;
            this.textBox_km.Text = "Km";
            this.textBox_km.Enter += new System.EventHandler(this.TextBox_km_Enter);
            this.textBox_km.Leave += new System.EventHandler(this.TextBox_km_Leave);
            // 
            // textBox_ano
            // 
            this.textBox_ano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ano.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ano.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_ano.Location = new System.Drawing.Point(376, 58);
            this.textBox_ano.MaxLength = 7;
            this.textBox_ano.Name = "textBox_ano";
            this.textBox_ano.Size = new System.Drawing.Size(150, 27);
            this.textBox_ano.TabIndex = 4;
            this.textBox_ano.Text = "Ano";
            this.textBox_ano.Enter += new System.EventHandler(this.TextBox_ano_Enter);
            this.textBox_ano.Leave += new System.EventHandler(this.TextBox_ano_Leave);
            // 
            // textBox_cor
            // 
            this.textBox_cor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_cor.Location = new System.Drawing.Point(222, 58);
            this.textBox_cor.MaxLength = 30;
            this.textBox_cor.Name = "textBox_cor";
            this.textBox_cor.Size = new System.Drawing.Size(150, 27);
            this.textBox_cor.TabIndex = 3;
            this.textBox_cor.Text = "Cor";
            this.textBox_cor.Enter += new System.EventHandler(this.TextBox_cor_Enter);
            this.textBox_cor.Leave += new System.EventHandler(this.TextBox_cor_Leave);
            // 
            // textBox_modelo
            // 
            this.textBox_modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_modelo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_modelo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_modelo.Location = new System.Drawing.Point(9, 58);
            this.textBox_modelo.MaxLength = 100;
            this.textBox_modelo.Name = "textBox_modelo";
            this.textBox_modelo.Size = new System.Drawing.Size(207, 27);
            this.textBox_modelo.TabIndex = 2;
            this.textBox_modelo.Text = "Modelo do veículo";
            this.textBox_modelo.Enter += new System.EventHandler(this.TextBox_modelo_Enter);
            this.textBox_modelo.Leave += new System.EventHandler(this.TextBox_modelo_Leave);
            // 
            // textBox_placa
            // 
            this.textBox_placa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_placa.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_placa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_placa.Location = new System.Drawing.Point(9, 19);
            this.textBox_placa.MaxLength = 7;
            this.textBox_placa.Name = "textBox_placa";
            this.textBox_placa.Size = new System.Drawing.Size(207, 33);
            this.textBox_placa.TabIndex = 1;
            this.textBox_placa.Text = "Placa";
            this.textBox_placa.TextChanged += new System.EventHandler(this.TextBox_placa_TextChanged);
            this.textBox_placa.Enter += new System.EventHandler(this.TextBox_placa_Enter);
            this.textBox_placa.Leave += new System.EventHandler(this.TextBox_placa_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label_horaInicio);
            this.groupBox2.Controls.Add(this.label_dataInicio);
            this.groupBox2.Controls.Add(this.label_id);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordem de Serviço";
            // 
            // label_horaInicio
            // 
            this.label_horaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_horaInicio.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horaInicio.Location = new System.Drawing.Point(612, 16);
            this.label_horaInicio.Margin = new System.Windows.Forms.Padding(0);
            this.label_horaInicio.Name = "label_horaInicio";
            this.label_horaInicio.Size = new System.Drawing.Size(70, 20);
            this.label_horaInicio.TabIndex = 2;
            this.label_horaInicio.Text = "#12:34:56";
            // 
            // label_dataInicio
            // 
            this.label_dataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_dataInicio.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dataInicio.Location = new System.Drawing.Point(300, 16);
            this.label_dataInicio.Margin = new System.Windows.Forms.Padding(0);
            this.label_dataInicio.Name = "label_dataInicio";
            this.label_dataInicio.Size = new System.Drawing.Size(70, 20);
            this.label_dataInicio.TabIndex = 1;
            this.label_dataInicio.Text = "#12/34/4567";
            // 
            // label_id
            // 
            this.label_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_id.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(10, 16);
            this.label_id.Margin = new System.Windows.Forms.Padding(0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(60, 20);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "#id";
            // 
            // FrmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 380);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdemServico";
            this.Text = "Abrir Nova Ordem de Serviço";
            this.Activated += new System.EventHandler(this.FrmOrdemServico_Activated);
            this.Load += new System.EventHandler(this.FrmOrdemServico_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_horaInicio;
        private System.Windows.Forms.Label label_dataInicio;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.TextBox textBox_cor;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.TextBox textBox_km;
        private System.Windows.Forms.TextBox textBox_servicos;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RadioButton radioButton_aguardo;
        private System.Windows.Forms.RadioButton radioButton_servico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_telefone;
    }
}