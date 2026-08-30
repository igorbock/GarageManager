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
            button_salvar = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textBox_telefone = new System.Windows.Forms.TextBox();
            textBox_nome = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            entityComboBox1 = new GarageManager.Controls.EntityComboBox();
            radioButton_servico = new System.Windows.Forms.RadioButton();
            radioButton_aguardo = new System.Windows.Forms.RadioButton();
            label_status = new System.Windows.Forms.Label();
            textBox_servicos = new System.Windows.Forms.TextBox();
            textBox_km = new System.Windows.Forms.TextBox();
            textBox_ano = new System.Windows.Forms.TextBox();
            textBox_cor = new System.Windows.Forms.TextBox();
            textBox_placa = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label_horaInicio = new System.Windows.Forms.Label();
            label_dataInicio = new System.Windows.Forms.Label();
            label_id = new System.Windows.Forms.Label();
            entityComboBox_mecanico = new GarageManager.Controls.EntityComboBox();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button_salvar
            // 
            button_salvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_salvar.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_salvar.Location = new System.Drawing.Point(7, 415);
            button_salvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new System.Drawing.Size(88, 43);
            button_salvar.TabIndex = 9;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += Button_salvar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox4.Controls.Add(textBox_telefone);
            groupBox4.Controls.Add(textBox_nome);
            groupBox4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            groupBox4.Location = new System.Drawing.Point(7, 345);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(803, 63);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Cliente";
            // 
            // textBox_telefone
            // 
            textBox_telefone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBox_telefone.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_telefone.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_telefone.Location = new System.Drawing.Point(446, 22);
            textBox_telefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_telefone.MaxLength = 30;
            textBox_telefone.Name = "textBox_telefone";
            textBox_telefone.Size = new System.Drawing.Size(349, 27);
            textBox_telefone.TabIndex = 8;
            textBox_telefone.Text = "Telefone";
            textBox_telefone.Enter += TextBox_telefone_Enter;
            textBox_telefone.Leave += TextBox_telefone_Leave;
            // 
            // textBox_nome
            // 
            textBox_nome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_nome.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_nome.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_nome.Location = new System.Drawing.Point(10, 22);
            textBox_nome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_nome.MaxLength = 100;
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new System.Drawing.Size(428, 27);
            textBox_nome.TabIndex = 7;
            textBox_nome.Text = "Nome";
            textBox_nome.Enter += TextBox_nome_Enter;
            textBox_nome.Leave += TextBox_nome_Leave;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(entityComboBox1);
            groupBox3.Controls.Add(radioButton_servico);
            groupBox3.Controls.Add(radioButton_aguardo);
            groupBox3.Controls.Add(label_status);
            groupBox3.Controls.Add(textBox_servicos);
            groupBox3.Controls.Add(textBox_km);
            groupBox3.Controls.Add(textBox_ano);
            groupBox3.Controls.Add(textBox_cor);
            groupBox3.Controls.Add(textBox_placa);
            groupBox3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.Location = new System.Drawing.Point(7, 65);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(803, 218);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Veículo";
            // 
            // entityComboBox1
            // 
            entityComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            entityComboBox1.LabelText = "Modelo:";
            entityComboBox1.Location = new System.Drawing.Point(10, 67);
            entityComboBox1.Margin = new System.Windows.Forms.Padding(0);
            entityComboBox1.Name = "entityComboBox1";
            entityComboBox1.Size = new System.Drawing.Size(241, 27);
            entityComboBox1.TabIndex = 11;
            // 
            // radioButton_servico
            // 
            radioButton_servico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton_servico.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radioButton_servico.Location = new System.Drawing.Point(691, 25);
            radioButton_servico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_servico.Name = "radioButton_servico";
            radioButton_servico.Size = new System.Drawing.Size(105, 20);
            radioButton_servico.TabIndex = 2;
            radioButton_servico.TabStop = true;
            radioButton_servico.Text = "Em serviço";
            radioButton_servico.UseVisualStyleBackColor = true;
            // 
            // radioButton_aguardo
            // 
            radioButton_aguardo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton_aguardo.Font = new System.Drawing.Font("Candara Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radioButton_aguardo.Location = new System.Drawing.Point(520, 25);
            radioButton_aguardo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButton_aguardo.Name = "radioButton_aguardo";
            radioButton_aguardo.Size = new System.Drawing.Size(163, 20);
            radioButton_aguardo.TabIndex = 1;
            radioButton_aguardo.TabStop = true;
            radioButton_aguardo.Text = "Aguardando serviço";
            radioButton_aguardo.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            label_status.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label_status.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_status.Location = new System.Drawing.Point(385, 28);
            label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_status.Name = "label_status";
            label_status.Size = new System.Drawing.Size(128, 15);
            label_status.TabIndex = 6;
            label_status.Text = "Status do veículo:";
            // 
            // textBox_servicos
            // 
            textBox_servicos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_servicos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_servicos.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_servicos.Location = new System.Drawing.Point(10, 108);
            textBox_servicos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_servicos.MaxLength = 500;
            textBox_servicos.Multiline = true;
            textBox_servicos.Name = "textBox_servicos";
            textBox_servicos.Size = new System.Drawing.Size(784, 102);
            textBox_servicos.TabIndex = 6;
            textBox_servicos.Text = "Serviços esperados";
            textBox_servicos.Enter += TextBox_servicos_Enter;
            textBox_servicos.Leave += TextBox_servicos_Leave;
            // 
            // textBox_km
            // 
            textBox_km.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBox_km.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_km.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_km.Location = new System.Drawing.Point(621, 67);
            textBox_km.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_km.MaxLength = 10;
            textBox_km.Name = "textBox_km";
            textBox_km.Size = new System.Drawing.Size(174, 27);
            textBox_km.TabIndex = 5;
            textBox_km.Text = "Km";
            textBox_km.Enter += TextBox_km_Enter;
            textBox_km.Leave += TextBox_km_Leave;
            // 
            // textBox_ano
            // 
            textBox_ano.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBox_ano.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_ano.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_ano.Location = new System.Drawing.Point(439, 67);
            textBox_ano.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_ano.MaxLength = 7;
            textBox_ano.Name = "textBox_ano";
            textBox_ano.Size = new System.Drawing.Size(174, 27);
            textBox_ano.TabIndex = 4;
            textBox_ano.Text = "Ano";
            textBox_ano.Enter += TextBox_ano_Enter;
            textBox_ano.Leave += TextBox_ano_Leave;
            // 
            // textBox_cor
            // 
            textBox_cor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBox_cor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_cor.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_cor.Location = new System.Drawing.Point(259, 67);
            textBox_cor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_cor.MaxLength = 30;
            textBox_cor.Name = "textBox_cor";
            textBox_cor.Size = new System.Drawing.Size(174, 27);
            textBox_cor.TabIndex = 3;
            textBox_cor.Text = "Cor";
            textBox_cor.Enter += TextBox_cor_Enter;
            textBox_cor.Leave += TextBox_cor_Leave;
            // 
            // textBox_placa
            // 
            textBox_placa.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_placa.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            textBox_placa.ForeColor = System.Drawing.SystemColors.GrayText;
            textBox_placa.Location = new System.Drawing.Point(10, 22);
            textBox_placa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_placa.MaxLength = 7;
            textBox_placa.Name = "textBox_placa";
            textBox_placa.PlaceholderText = "Placa";
            textBox_placa.Size = new System.Drawing.Size(241, 33);
            textBox_placa.TabIndex = 1;
            textBox_placa.TextChanged += TextBox_placa_TextChanged;
            textBox_placa.Enter += TextBox_placa_Enter;
            textBox_placa.Leave += TextBox_placa_Leave;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(label_horaInicio);
            groupBox2.Controls.Add(label_dataInicio);
            groupBox2.Controls.Add(label_id);
            groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.Location = new System.Drawing.Point(7, 7);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(803, 52);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ordem de Serviço";
            // 
            // label_horaInicio
            // 
            label_horaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_horaInicio.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label_horaInicio.Location = new System.Drawing.Point(714, 18);
            label_horaInicio.Margin = new System.Windows.Forms.Padding(0);
            label_horaInicio.Name = "label_horaInicio";
            label_horaInicio.Size = new System.Drawing.Size(82, 23);
            label_horaInicio.TabIndex = 2;
            label_horaInicio.Text = "#12:34:56";
            // 
            // label_dataInicio
            // 
            label_dataInicio.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            label_dataInicio.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label_dataInicio.Location = new System.Drawing.Point(350, 18);
            label_dataInicio.Margin = new System.Windows.Forms.Padding(0);
            label_dataInicio.Name = "label_dataInicio";
            label_dataInicio.Size = new System.Drawing.Size(82, 23);
            label_dataInicio.TabIndex = 1;
            label_dataInicio.Text = "#12/34/4567";
            // 
            // label_id
            // 
            label_id.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label_id.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label_id.Location = new System.Drawing.Point(12, 18);
            label_id.Margin = new System.Windows.Forms.Padding(0);
            label_id.Name = "label_id";
            label_id.Size = new System.Drawing.Size(70, 23);
            label_id.TabIndex = 0;
            label_id.Text = "#id";
            // 
            // entityComboBox_mecanico
            // 
            entityComboBox_mecanico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            entityComboBox_mecanico.LabelText = "Mecânico:";
            entityComboBox_mecanico.Location = new System.Drawing.Point(7, 290);
            entityComboBox_mecanico.Margin = new System.Windows.Forms.Padding(0);
            entityComboBox_mecanico.Name = "entityComboBox_mecanico";
            entityComboBox_mecanico.Size = new System.Drawing.Size(803, 27);
            entityComboBox_mecanico.TabIndex = 10;
            // 
            // FrmOrdemServico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 493);
            Controls.Add(entityComboBox_mecanico);
            Controls.Add(button_salvar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOrdemServico";
            Text = "Abrir Nova Ordem de Serviço";
            Activated += FrmOrdemServico_Activated;
            Load += FrmOrdemServico_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_horaInicio;
        private System.Windows.Forms.Label label_dataInicio;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_placa;
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
        private Controls.EntityComboBox entityComboBox_mecanico;
        private Controls.EntityComboBox entityComboBox1;
    }
}