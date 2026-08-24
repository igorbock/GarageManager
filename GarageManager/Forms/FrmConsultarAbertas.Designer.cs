namespace GarageManager.Forms
{
    partial class FrmConsultarAbertas
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            groupBox5 = new System.Windows.Forms.GroupBox();
            label_data = new System.Windows.Forms.Label();
            dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            label_ate = new System.Windows.Forms.Label();
            dateTimePicker_ate = new System.Windows.Forms.DateTimePicker();
            label_periodo = new System.Windows.Forms.Label();
            comboBox_periodo = new System.Windows.Forms.ComboBox();
            label_cliente = new System.Windows.Forms.Label();
            textBox_cliente = new System.Windows.Forms.TextBox();
            label_placa = new System.Windows.Forms.Label();
            textBox_placa = new System.Windows.Forms.TextBox();
            label_modelo = new System.Windows.Forms.Label();
            textBox_modelo = new System.Windows.Forms.TextBox();
            label_ano = new System.Windows.Forms.Label();
            textBox_ano = new System.Windows.Forms.TextBox();
            label_situacao = new System.Windows.Forms.Label();
            comboBox_situacao = new System.Windows.Forms.ComboBox();
            button_filtrar = new System.Windows.Forms.Button();
            button_limpar = new System.Windows.Forms.Button();
            button_adicionar = new System.Windows.Forms.Button();
            button_editar = new System.Windows.Forms.Button();
            button_excluir = new System.Windows.Forms.Button();
            button_imprimir = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(7, 120);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(826, 381);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox5.Controls.Add(label_data);
            groupBox5.Controls.Add(dateTimePicker_data);
            groupBox5.Controls.Add(label_ate);
            groupBox5.Controls.Add(dateTimePicker_ate);
            groupBox5.Controls.Add(label_periodo);
            groupBox5.Controls.Add(comboBox_periodo);
            groupBox5.Controls.Add(label_cliente);
            groupBox5.Controls.Add(textBox_cliente);
            groupBox5.Controls.Add(label_placa);
            groupBox5.Controls.Add(textBox_placa);
            groupBox5.Controls.Add(label_modelo);
            groupBox5.Controls.Add(textBox_modelo);
            groupBox5.Controls.Add(label_ano);
            groupBox5.Controls.Add(textBox_ano);
            groupBox5.Controls.Add(label_situacao);
            groupBox5.Controls.Add(comboBox_situacao);
            groupBox5.Controls.Add(button_filtrar);
            groupBox5.Controls.Add(button_limpar);
            groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox5.Location = new System.Drawing.Point(7, 7);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(826, 106);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Pesquisar";
            toolTip1.SetToolTip(groupBox5, "Área de filtragem das propriedades das O.S.");
            // 
            // label_data
            // 
            label_data.AutoSize = true;
            label_data.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_data.Location = new System.Drawing.Point(7, 25);
            label_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_data.Name = "label_data";
            label_data.Size = new System.Drawing.Size(34, 13);
            label_data.TabIndex = 0;
            label_data.Text = "Data:";
            // 
            // dateTimePicker_data
            // 
            dateTimePicker_data.Checked = false;
            dateTimePicker_data.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_data.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker_data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker_data.Location = new System.Drawing.Point(54, 22);
            dateTimePicker_data.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker_data.Name = "dateTimePicker_data";
            dateTimePicker_data.ShowCheckBox = true;
            dateTimePicker_data.Size = new System.Drawing.Size(122, 21);
            dateTimePicker_data.TabIndex = 1;
            // 
            // label_ate
            // 
            label_ate.AutoSize = true;
            label_ate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_ate.Location = new System.Drawing.Point(181, 25);
            label_ate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_ate.Name = "label_ate";
            label_ate.Size = new System.Drawing.Size(28, 13);
            label_ate.TabIndex = 2;
            label_ate.Text = "Até:";
            // 
            // dateTimePicker_ate
            // 
            dateTimePicker_ate.Checked = false;
            dateTimePicker_ate.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_ate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dateTimePicker_ate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker_ate.Location = new System.Drawing.Point(218, 22);
            dateTimePicker_ate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker_ate.Name = "dateTimePicker_ate";
            dateTimePicker_ate.ShowCheckBox = true;
            dateTimePicker_ate.Size = new System.Drawing.Size(122, 21);
            dateTimePicker_ate.TabIndex = 3;
            // 
            // label_periodo
            // 
            label_periodo.AutoSize = true;
            label_periodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_periodo.Location = new System.Drawing.Point(348, 25);
            label_periodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_periodo.Name = "label_periodo";
            label_periodo.Size = new System.Drawing.Size(47, 13);
            label_periodo.TabIndex = 4;
            label_periodo.Text = "Período:";
            // 
            // comboBox_periodo
            // 
            comboBox_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_periodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox_periodo.FormattingEnabled = true;
            comboBox_periodo.Items.AddRange(new object[] { "Entrada", "Saída" });
            comboBox_periodo.Location = new System.Drawing.Point(408, 22);
            comboBox_periodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_periodo.Name = "comboBox_periodo";
            comboBox_periodo.Size = new System.Drawing.Size(122, 21);
            comboBox_periodo.TabIndex = 5;
            // 
            // label_cliente
            // 
            label_cliente.AutoSize = true;
            label_cliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_cliente.Location = new System.Drawing.Point(540, 25);
            label_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_cliente.Name = "label_cliente";
            label_cliente.Size = new System.Drawing.Size(44, 13);
            label_cliente.TabIndex = 6;
            label_cliente.Text = "Cliente:";
            // 
            // textBox_cliente
            // 
            textBox_cliente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_cliente.Location = new System.Drawing.Point(598, 22);
            textBox_cliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_cliente.Name = "textBox_cliente";
            textBox_cliente.Size = new System.Drawing.Size(151, 21);
            textBox_cliente.TabIndex = 7;
            // 
            // label_placa
            // 
            label_placa.AutoSize = true;
            label_placa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_placa.Location = new System.Drawing.Point(7, 67);
            label_placa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_placa.Name = "label_placa";
            label_placa.Size = new System.Drawing.Size(36, 13);
            label_placa.TabIndex = 9;
            label_placa.Text = "Placa:";
            // 
            // textBox_placa
            // 
            textBox_placa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            textBox_placa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_placa.Location = new System.Drawing.Point(54, 63);
            textBox_placa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_placa.MaxLength = 7;
            textBox_placa.Name = "textBox_placa";
            textBox_placa.Size = new System.Drawing.Size(98, 21);
            textBox_placa.TabIndex = 10;
            // 
            // label_modelo
            // 
            label_modelo.AutoSize = true;
            label_modelo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_modelo.Location = new System.Drawing.Point(160, 67);
            label_modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_modelo.Name = "label_modelo";
            label_modelo.Size = new System.Drawing.Size(81, 13);
            label_modelo.TabIndex = 11;
            label_modelo.Text = "Modelo Veículo:";
            // 
            // textBox_modelo
            // 
            textBox_modelo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_modelo.Location = new System.Drawing.Point(275, 63);
            textBox_modelo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_modelo.Name = "textBox_modelo";
            textBox_modelo.Size = new System.Drawing.Size(151, 21);
            textBox_modelo.TabIndex = 12;
            // 
            // label_ano
            // 
            label_ano.AutoSize = true;
            label_ano.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_ano.Location = new System.Drawing.Point(434, 67);
            label_ano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_ano.Name = "label_ano";
            label_ano.Size = new System.Drawing.Size(30, 13);
            label_ano.TabIndex = 13;
            label_ano.Text = "Ano:";
            // 
            // textBox_ano
            // 
            textBox_ano.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textBox_ano.Location = new System.Drawing.Point(475, 63);
            textBox_ano.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_ano.MaxLength = 4;
            textBox_ano.Name = "textBox_ano";
            textBox_ano.Size = new System.Drawing.Size(58, 21);
            textBox_ano.TabIndex = 14;
            // 
            // label_situacao
            // 
            label_situacao.AutoSize = true;
            label_situacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_situacao.Location = new System.Drawing.Point(540, 67);
            label_situacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_situacao.Name = "label_situacao";
            label_situacao.Size = new System.Drawing.Size(52, 13);
            label_situacao.TabIndex = 15;
            label_situacao.Text = "Situação:";
            // 
            // comboBox_situacao
            // 
            comboBox_situacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_situacao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox_situacao.FormattingEnabled = true;
            comboBox_situacao.Items.AddRange(new object[] { "Todos", "Aberta", "Em Andamento", "Finalizada" });
            comboBox_situacao.Location = new System.Drawing.Point(608, 63);
            comboBox_situacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_situacao.Name = "comboBox_situacao";
            comboBox_situacao.Size = new System.Drawing.Size(142, 21);
            comboBox_situacao.TabIndex = 16;
            // 
            // button_filtrar
            // 
            button_filtrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_filtrar.Location = new System.Drawing.Point(757, 21);
            button_filtrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_filtrar.Name = "button_filtrar";
            button_filtrar.Size = new System.Drawing.Size(64, 27);
            button_filtrar.TabIndex = 8;
            button_filtrar.Text = "Filtrar";
            toolTip1.SetToolTip(button_filtrar, "Filtrar com os valores informados");
            button_filtrar.UseVisualStyleBackColor = true;
            button_filtrar.Click += Button_filtrar_Click;
            // 
            // button_limpar
            // 
            button_limpar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_limpar.Location = new System.Drawing.Point(757, 62);
            button_limpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_limpar.Name = "button_limpar";
            button_limpar.Size = new System.Drawing.Size(64, 27);
            button_limpar.TabIndex = 17;
            button_limpar.Text = "Limpar";
            toolTip1.SetToolTip(button_limpar, "Limpar os valores da filtragem");
            button_limpar.UseVisualStyleBackColor = true;
            button_limpar.Click += Button_limpar_Click;
            // 
            // button_adicionar
            // 
            button_adicionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_adicionar.Location = new System.Drawing.Point(7, 508);
            button_adicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_adicionar.Name = "button_adicionar";
            button_adicionar.Size = new System.Drawing.Size(117, 29);
            button_adicionar.TabIndex = 2;
            button_adicionar.Text = "Adicionar";
            toolTip1.SetToolTip(button_adicionar, "Adicionar uma nova O.S.");
            button_adicionar.UseVisualStyleBackColor = true;
            button_adicionar.Click += Button_adicionar_Click;
            // 
            // button_editar
            // 
            button_editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_editar.Location = new System.Drawing.Point(131, 508);
            button_editar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_editar.Name = "button_editar";
            button_editar.Size = new System.Drawing.Size(117, 29);
            button_editar.TabIndex = 3;
            button_editar.Text = "Editar";
            toolTip1.SetToolTip(button_editar, "Selecione uma O.S. para editar");
            button_editar.UseVisualStyleBackColor = true;
            button_editar.Click += Button_editar_Click;
            // 
            // button_excluir
            // 
            button_excluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_excluir.Location = new System.Drawing.Point(254, 508);
            button_excluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new System.Drawing.Size(117, 29);
            button_excluir.TabIndex = 4;
            button_excluir.Text = "Excluir";
            toolTip1.SetToolTip(button_excluir, "Selecione uma O.S. para excluir");
            button_excluir.UseVisualStyleBackColor = true;
            button_excluir.Click += Button_excluir_Click;
            // 
            // button_imprimir
            // 
            button_imprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button_imprimir.Location = new System.Drawing.Point(378, 508);
            button_imprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_imprimir.Name = "button_imprimir";
            button_imprimir.Size = new System.Drawing.Size(117, 29);
            button_imprimir.TabIndex = 5;
            button_imprimir.Text = "Imprimir";
            toolTip1.SetToolTip(button_imprimir, "Imprimir relatórios de O.S.");
            button_imprimir.UseVisualStyleBackColor = true;
            button_imprimir.Click += Button_imprimir_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmConsultarAbertas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(840, 545);
            Controls.Add(button_imprimir);
            Controls.Add(button_excluir);
            Controls.Add(button_editar);
            Controls.Add(button_adicionar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultarAbertas";
            Text = "Consultar O.S. Abertas";
            Activated += FrmConsultarAbertas_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.Label label_ate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ate;
        private System.Windows.Forms.Label label_periodo;
        private System.Windows.Forms.ComboBox comboBox_periodo;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.Label label_placa;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.Label label_modelo;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.Label label_ano;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.Label label_situacao;
        private System.Windows.Forms.ComboBox comboBox_situacao;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_imprimir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}