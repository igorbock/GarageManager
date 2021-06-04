namespace GarageManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_abrirOS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_historico = new System.Windows.Forms.Button();
            this.button_consultarEncerradas = new System.Windows.Forms.Button();
            this.button_consultarAbertas = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_home = new System.Windows.Forms.TabPage();
            this.label_homeInformacoes = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.tabPage_abrirOS = new System.Windows.Forms.TabPage();
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
            this.tabPage_consultarAberta = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_pesquisaPlacaAberta = new System.Windows.Forms.Label();
            this.textBox_pesquisaPlacaAberta = new System.Windows.Forms.TextBox();
            this.tabPage_consultarEncerrada = new System.Windows.Forms.TabPage();
            this.dataGridView_encerradas = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_pesquisaPlacaEncerrada = new System.Windows.Forms.TextBox();
            this.label_pesquisaPlacaEncerrada = new System.Windows.Forms.Label();
            this.tabPage_historico = new System.Windows.Forms.TabPage();
            this.dataGridView_historico = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_pesquisaNomeHistorico = new System.Windows.Forms.TextBox();
            this.label_pesquisaNomeHistorico = new System.Windows.Forms.Label();
            this.label_pesquisaVeiculoHistorico = new System.Windows.Forms.Label();
            this.textBox_pesquisaVeiculoHistorico = new System.Windows.Forms.TextBox();
            this.textBox_pesquisaPlacaHistorico = new System.Windows.Forms.TextBox();
            this.label_pesquisaPlacaHistorico = new System.Windows.Forms.Label();
            this.label_versao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_home.SuspendLayout();
            this.tabPage_abrirOS.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage_consultarAberta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage_consultarEncerrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encerradas)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage_historico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historico)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_abrirOS
            // 
            this.button_abrirOS.Location = new System.Drawing.Point(6, 19);
            this.button_abrirOS.Name = "button_abrirOS";
            this.button_abrirOS.Size = new System.Drawing.Size(302, 23);
            this.button_abrirOS.TabIndex = 0;
            this.button_abrirOS.Text = "Abrir Nova Ordem de Serviço";
            this.button_abrirOS.UseVisualStyleBackColor = true;
            this.button_abrirOS.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_historico);
            this.groupBox1.Controls.Add(this.button_consultarEncerradas);
            this.groupBox1.Controls.Add(this.button_consultarAbertas);
            this.groupBox1.Controls.Add(this.button_abrirOS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // button_historico
            // 
            this.button_historico.Location = new System.Drawing.Point(6, 106);
            this.button_historico.Name = "button_historico";
            this.button_historico.Size = new System.Drawing.Size(302, 23);
            this.button_historico.TabIndex = 12;
            this.button_historico.Text = "Histórico de O.S. Encerradas";
            this.button_historico.UseVisualStyleBackColor = true;
            this.button_historico.Click += new System.EventHandler(this.Button_historico_Click);
            // 
            // button_consultarEncerradas
            // 
            this.button_consultarEncerradas.Location = new System.Drawing.Point(6, 77);
            this.button_consultarEncerradas.Name = "button_consultarEncerradas";
            this.button_consultarEncerradas.Size = new System.Drawing.Size(302, 23);
            this.button_consultarEncerradas.TabIndex = 11;
            this.button_consultarEncerradas.Text = "Consultar Ordens de Serviço Prontas";
            this.button_consultarEncerradas.UseVisualStyleBackColor = true;
            this.button_consultarEncerradas.Click += new System.EventHandler(this.Button_consultarEncerradas_Click);
            // 
            // button_consultarAbertas
            // 
            this.button_consultarAbertas.Location = new System.Drawing.Point(6, 48);
            this.button_consultarAbertas.Name = "button_consultarAbertas";
            this.button_consultarAbertas.Size = new System.Drawing.Size(302, 23);
            this.button_consultarAbertas.TabIndex = 10;
            this.button_consultarAbertas.Text = "Consultar Ordens de Serviço Abertas";
            this.button_consultarAbertas.UseVisualStyleBackColor = true;
            this.button_consultarAbertas.Click += new System.EventHandler(this.Button_consultarAbertas_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_home);
            this.tabControl1.Controls.Add(this.tabPage_abrirOS);
            this.tabControl1.Controls.Add(this.tabPage_consultarAberta);
            this.tabControl1.Controls.Add(this.tabPage_consultarEncerrada);
            this.tabControl1.Controls.Add(this.tabPage_historico);
            this.tabControl1.Location = new System.Drawing.Point(332, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 381);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage_home
            // 
            this.tabPage_home.Controls.Add(this.label_homeInformacoes);
            this.tabPage_home.Controls.Add(this.label_home);
            this.tabPage_home.Location = new System.Drawing.Point(4, 22);
            this.tabPage_home.Name = "tabPage_home";
            this.tabPage_home.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_home.Size = new System.Drawing.Size(700, 355);
            this.tabPage_home.TabIndex = 0;
            this.tabPage_home.Text = "Home";
            this.tabPage_home.UseVisualStyleBackColor = true;
            this.tabPage_home.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabPage_home_Layout);
            // 
            // label_homeInformacoes
            // 
            this.label_homeInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_homeInformacoes.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_homeInformacoes.Location = new System.Drawing.Point(124, 67);
            this.label_homeInformacoes.Name = "label_homeInformacoes";
            this.label_homeInformacoes.Size = new System.Drawing.Size(500, 200);
            this.label_homeInformacoes.TabIndex = 1;
            this.label_homeInformacoes.Text = "Informações";
            // 
            // label_home
            // 
            this.label_home.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_home.Font = new System.Drawing.Font("Ink Free", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(239, 13);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(265, 39);
            this.label_home.TabIndex = 0;
            this.label_home.Text = "Garage Manager";
            // 
            // tabPage_abrirOS
            // 
            this.tabPage_abrirOS.Controls.Add(this.button_salvar);
            this.tabPage_abrirOS.Controls.Add(this.groupBox4);
            this.tabPage_abrirOS.Controls.Add(this.groupBox3);
            this.tabPage_abrirOS.Controls.Add(this.groupBox2);
            this.tabPage_abrirOS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_abrirOS.Name = "tabPage_abrirOS";
            this.tabPage_abrirOS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_abrirOS.Size = new System.Drawing.Size(700, 355);
            this.tabPage_abrirOS.TabIndex = 1;
            this.tabPage_abrirOS.Text = "Abrir O.S.";
            this.tabPage_abrirOS.UseVisualStyleBackColor = true;
            this.tabPage_abrirOS.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabPage_abrirOS_Layout);
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
            // tabPage_consultarAberta
            // 
            this.tabPage_consultarAberta.Controls.Add(this.dataGridView1);
            this.tabPage_consultarAberta.Controls.Add(this.groupBox5);
            this.tabPage_consultarAberta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consultarAberta.Name = "tabPage_consultarAberta";
            this.tabPage_consultarAberta.Size = new System.Drawing.Size(700, 355);
            this.tabPage_consultarAberta.TabIndex = 2;
            this.tabPage_consultarAberta.Text = "Consultar O.S. Abertas";
            this.tabPage_consultarAberta.UseVisualStyleBackColor = true;
            this.tabPage_consultarAberta.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabPage_consultarAberta_Layout);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(691, 290);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label_pesquisaPlacaAberta);
            this.groupBox5.Controls.Add(this.textBox_pesquisaPlacaAberta);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(691, 50);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pesquisar";
            // 
            // label_pesquisaPlacaAberta
            // 
            this.label_pesquisaPlacaAberta.AutoSize = true;
            this.label_pesquisaPlacaAberta.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaAberta.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaAberta.Name = "label_pesquisaPlacaAberta";
            this.label_pesquisaPlacaAberta.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaAberta.TabIndex = 1;
            this.label_pesquisaPlacaAberta.Text = "Placa:";
            // 
            // textBox_pesquisaPlacaAberta
            // 
            this.textBox_pesquisaPlacaAberta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaAberta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_pesquisaPlacaAberta.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaAberta.MaxLength = 7;
            this.textBox_pesquisaPlacaAberta.Name = "textBox_pesquisaPlacaAberta";
            this.textBox_pesquisaPlacaAberta.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaAberta.TabIndex = 0;
            this.textBox_pesquisaPlacaAberta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaPlaca_KeyDown);
            this.textBox_pesquisaPlacaAberta.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaAberta_Leave);
            // 
            // tabPage_consultarEncerrada
            // 
            this.tabPage_consultarEncerrada.Controls.Add(this.dataGridView_encerradas);
            this.tabPage_consultarEncerrada.Controls.Add(this.groupBox6);
            this.tabPage_consultarEncerrada.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consultarEncerrada.Name = "tabPage_consultarEncerrada";
            this.tabPage_consultarEncerrada.Size = new System.Drawing.Size(700, 355);
            this.tabPage_consultarEncerrada.TabIndex = 3;
            this.tabPage_consultarEncerrada.Text = "Consultar O.S. Prontas";
            this.tabPage_consultarEncerrada.UseVisualStyleBackColor = true;
            this.tabPage_consultarEncerrada.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabPage_consultarEncerrada_Layout);
            // 
            // dataGridView_encerradas
            // 
            this.dataGridView_encerradas.AllowUserToAddRows = false;
            this.dataGridView_encerradas.AllowUserToDeleteRows = false;
            this.dataGridView_encerradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_encerradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_encerradas.Location = new System.Drawing.Point(6, 62);
            this.dataGridView_encerradas.MultiSelect = false;
            this.dataGridView_encerradas.Name = "dataGridView_encerradas";
            this.dataGridView_encerradas.ReadOnly = true;
            this.dataGridView_encerradas.RowHeadersVisible = false;
            this.dataGridView_encerradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_encerradas.Size = new System.Drawing.Size(691, 290);
            this.dataGridView_encerradas.TabIndex = 1;
            this.dataGridView_encerradas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_encerradas_CellMouseDoubleClick);
            this.dataGridView_encerradas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_encerradas_KeyDown);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.textBox_pesquisaPlacaEncerrada);
            this.groupBox6.Controls.Add(this.label_pesquisaPlacaEncerrada);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(691, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesquisar";
            // 
            // textBox_pesquisaPlacaEncerrada
            // 
            this.textBox_pesquisaPlacaEncerrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaEncerrada.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaEncerrada.MaxLength = 7;
            this.textBox_pesquisaPlacaEncerrada.Name = "textBox_pesquisaPlacaEncerrada";
            this.textBox_pesquisaPlacaEncerrada.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaEncerrada.TabIndex = 1;
            this.textBox_pesquisaPlacaEncerrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            this.textBox_pesquisaPlacaEncerrada.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaEncerrada_Leave);
            // 
            // label_pesquisaPlacaEncerrada
            // 
            this.label_pesquisaPlacaEncerrada.AutoSize = true;
            this.label_pesquisaPlacaEncerrada.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaEncerrada.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaEncerrada.Name = "label_pesquisaPlacaEncerrada";
            this.label_pesquisaPlacaEncerrada.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaEncerrada.TabIndex = 0;
            this.label_pesquisaPlacaEncerrada.Text = "Placa:";
            // 
            // tabPage_historico
            // 
            this.tabPage_historico.Controls.Add(this.dataGridView_historico);
            this.tabPage_historico.Controls.Add(this.groupBox7);
            this.tabPage_historico.Location = new System.Drawing.Point(4, 22);
            this.tabPage_historico.Name = "tabPage_historico";
            this.tabPage_historico.Size = new System.Drawing.Size(700, 355);
            this.tabPage_historico.TabIndex = 4;
            this.tabPage_historico.Text = "Histórico de O.S. Encerradas";
            this.tabPage_historico.UseVisualStyleBackColor = true;
            this.tabPage_historico.Layout += new System.Windows.Forms.LayoutEventHandler(this.TabPage_historico_Layout);
            // 
            // dataGridView_historico
            // 
            this.dataGridView_historico.AllowUserToAddRows = false;
            this.dataGridView_historico.AllowUserToDeleteRows = false;
            this.dataGridView_historico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historico.Location = new System.Drawing.Point(6, 62);
            this.dataGridView_historico.Name = "dataGridView_historico";
            this.dataGridView_historico.ReadOnly = true;
            this.dataGridView_historico.RowHeadersVisible = false;
            this.dataGridView_historico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_historico.Size = new System.Drawing.Size(691, 290);
            this.dataGridView_historico.TabIndex = 1;
            this.dataGridView_historico.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_historico_CellMouseDoubleClick);
            this.dataGridView_historico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_historico_KeyDown);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.textBox_pesquisaNomeHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaNomeHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaVeiculoHistorico);
            this.groupBox7.Controls.Add(this.textBox_pesquisaVeiculoHistorico);
            this.groupBox7.Controls.Add(this.textBox_pesquisaPlacaHistorico);
            this.groupBox7.Controls.Add(this.label_pesquisaPlacaHistorico);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(691, 50);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pesquisar";
            // 
            // textBox_pesquisaNomeHistorico
            // 
            this.textBox_pesquisaNomeHistorico.Location = new System.Drawing.Point(435, 19);
            this.textBox_pesquisaNomeHistorico.Name = "textBox_pesquisaNomeHistorico";
            this.textBox_pesquisaNomeHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaNomeHistorico.TabIndex = 5;
            this.textBox_pesquisaNomeHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaNomeHistorico_KeyDown);
            // 
            // label_pesquisaNomeHistorico
            // 
            this.label_pesquisaNomeHistorico.AutoSize = true;
            this.label_pesquisaNomeHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaNomeHistorico.Location = new System.Drawing.Point(375, 19);
            this.label_pesquisaNomeHistorico.Name = "label_pesquisaNomeHistorico";
            this.label_pesquisaNomeHistorico.Size = new System.Drawing.Size(54, 19);
            this.label_pesquisaNomeHistorico.TabIndex = 4;
            this.label_pesquisaNomeHistorico.Text = "Nome:";
            // 
            // label_pesquisaVeiculoHistorico
            // 
            this.label_pesquisaVeiculoHistorico.AutoSize = true;
            this.label_pesquisaVeiculoHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaVeiculoHistorico.Location = new System.Drawing.Point(186, 19);
            this.label_pesquisaVeiculoHistorico.Name = "label_pesquisaVeiculoHistorico";
            this.label_pesquisaVeiculoHistorico.Size = new System.Drawing.Size(63, 19);
            this.label_pesquisaVeiculoHistorico.TabIndex = 3;
            this.label_pesquisaVeiculoHistorico.Text = "Veículo:";
            // 
            // textBox_pesquisaVeiculoHistorico
            // 
            this.textBox_pesquisaVeiculoHistorico.Location = new System.Drawing.Point(256, 19);
            this.textBox_pesquisaVeiculoHistorico.Name = "textBox_pesquisaVeiculoHistorico";
            this.textBox_pesquisaVeiculoHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaVeiculoHistorico.TabIndex = 2;
            this.textBox_pesquisaVeiculoHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaVeiculoHistorico_KeyDown);
            // 
            // textBox_pesquisaPlacaHistorico
            // 
            this.textBox_pesquisaPlacaHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_pesquisaPlacaHistorico.Location = new System.Drawing.Point(64, 19);
            this.textBox_pesquisaPlacaHistorico.MaxLength = 7;
            this.textBox_pesquisaPlacaHistorico.Name = "textBox_pesquisaPlacaHistorico";
            this.textBox_pesquisaPlacaHistorico.Size = new System.Drawing.Size(100, 20);
            this.textBox_pesquisaPlacaHistorico.TabIndex = 1;
            this.textBox_pesquisaPlacaHistorico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_pesquisaPlacaHistorico_KeyDown);
            this.textBox_pesquisaPlacaHistorico.Leave += new System.EventHandler(this.TextBox_pesquisaPlacaHistorico_Leave);
            // 
            // label_pesquisaPlacaHistorico
            // 
            this.label_pesquisaPlacaHistorico.AutoSize = true;
            this.label_pesquisaPlacaHistorico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pesquisaPlacaHistorico.Location = new System.Drawing.Point(6, 18);
            this.label_pesquisaPlacaHistorico.Name = "label_pesquisaPlacaHistorico";
            this.label_pesquisaPlacaHistorico.Size = new System.Drawing.Size(52, 19);
            this.label_pesquisaPlacaHistorico.TabIndex = 0;
            this.label_pesquisaPlacaHistorico.Text = "Placa:";
            // 
            // label_versao
            // 
            this.label_versao.AutoSize = true;
            this.label_versao.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versao.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_versao.Location = new System.Drawing.Point(13, 164);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(57, 19);
            this.label_versao.TabIndex = 18;
            this.label_versao.Text = "Versão";
            this.label_versao.Click += new System.EventHandler(this.Label_versao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Garage Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_home.ResumeLayout(false);
            this.tabPage_abrirOS.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage_consultarAberta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage_consultarEncerrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_encerradas)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage_historico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historico)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_abrirOS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_historico;
        private System.Windows.Forms.Button button_consultarEncerradas;
        private System.Windows.Forms.Button button_consultarAbertas;
        private System.Windows.Forms.TabPage tabPage_abrirOS;
        private System.Windows.Forms.TabPage tabPage_consultarAberta;
        private System.Windows.Forms.TabPage tabPage_consultarEncerrada;
        private System.Windows.Forms.TabPage tabPage_historico;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_horaInicio;
        private System.Windows.Forms.Label label_dataInicio;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.TextBox textBox_cor;
        private System.Windows.Forms.TextBox textBox_modelo;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_km;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.TextBox textBox_servicos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton_servico;
        private System.Windows.Forms.RadioButton radioButton_aguardo;
        private System.Windows.Forms.Label label_status;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage_home;
        private System.Windows.Forms.DataGridView dataGridView_encerradas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaAberta;
        private System.Windows.Forms.DataGridView dataGridView_historico;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_pesquisaPlacaAberta;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaEncerrada;
        private System.Windows.Forms.Label label_pesquisaPlacaEncerrada;
        private System.Windows.Forms.TextBox textBox_pesquisaPlacaHistorico;
        private System.Windows.Forms.Label label_pesquisaPlacaHistorico;
        private System.Windows.Forms.Label label_homeInformacoes;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Label label_pesquisaVeiculoHistorico;
        private System.Windows.Forms.TextBox textBox_pesquisaVeiculoHistorico;
        private System.Windows.Forms.TextBox textBox_pesquisaNomeHistorico;
        private System.Windows.Forms.Label label_pesquisaNomeHistorico;
    }
}

