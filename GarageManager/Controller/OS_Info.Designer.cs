namespace GarageManager.Controller
{
    partial class OS_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OS_Info));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_alterar = new System.Windows.Forms.Button();
            this.checkBox_voltar = new System.Windows.Forms.CheckBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_dataFinal = new System.Windows.Forms.Label();
            this.label_dataInicio = new System.Windows.Forms.Label();
            this.label_horaFinal = new System.Windows.Forms.Label();
            this.label_horaInicio = new System.Windows.Forms.Label();
            this.textBox_horaFinal = new System.Windows.Forms.TextBox();
            this.textBox_dataFinal = new System.Windows.Forms.TextBox();
            this.textBox_horaInicio = new System.Windows.Forms.TextBox();
            this.textBox_dataInicio = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_km = new System.Windows.Forms.TextBox();
            this.textBox_ano = new System.Windows.Forms.TextBox();
            this.textBox_cor = new System.Windows.Forms.TextBox();
            this.checkBox_lavado = new System.Windows.Forms.CheckBox();
            this.textBox_placa = new System.Windows.Forms.TextBox();
            this.textBox_servicos = new System.Windows.Forms.TextBox();
            this.textBox_veiculo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_realizados = new System.Windows.Forms.TextBox();
            this.dataGridView_pecas_ordem = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_mecanico = new System.Windows.Forms.TextBox();
            this.label_mecanico = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_comboBoxStatus = new System.Windows.Forms.Label();
            this.statusStrip_infoOS = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_garageManager = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument_os = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.imprimirOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pecas_ordem)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip_infoOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_alterar);
            this.groupBox1.Controls.Add(this.checkBox_voltar);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.label_dataFinal);
            this.groupBox1.Controls.Add(this.label_dataInicio);
            this.groupBox1.Controls.Add(this.label_horaFinal);
            this.groupBox1.Controls.Add(this.label_horaInicio);
            this.groupBox1.Controls.Add(this.textBox_horaFinal);
            this.groupBox1.Controls.Add(this.textBox_dataFinal);
            this.groupBox1.Controls.Add(this.textBox_horaInicio);
            this.groupBox1.Controls.Add(this.textBox_dataInicio);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem de Serviço";
            // 
            // button_alterar
            // 
            this.button_alterar.Location = new System.Drawing.Point(663, 52);
            this.button_alterar.Name = "button_alterar";
            this.button_alterar.Size = new System.Drawing.Size(106, 23);
            this.button_alterar.TabIndex = 12;
            this.button_alterar.Text = "Alterar dados";
            this.button_alterar.UseVisualStyleBackColor = true;
            this.button_alterar.Click += new System.EventHandler(this.Button_alterar_Click);
            // 
            // checkBox_voltar
            // 
            this.checkBox_voltar.AutoSize = true;
            this.checkBox_voltar.Location = new System.Drawing.Point(663, 20);
            this.checkBox_voltar.Name = "checkBox_voltar";
            this.checkBox_voltar.Size = new System.Drawing.Size(106, 17);
            this.checkBox_voltar.TabIndex = 11;
            this.checkBox_voltar.Text = "Ativa novamente";
            this.checkBox_voltar.UseVisualStyleBackColor = true;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_status.Location = new System.Drawing.Point(9, 52);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(147, 29);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "Status da OS";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(10, 18);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(27, 19);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "Id:";
            // 
            // label_dataFinal
            // 
            this.label_dataFinal.AutoSize = true;
            this.label_dataFinal.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dataFinal.Location = new System.Drawing.Point(236, 52);
            this.label_dataFinal.Name = "label_dataFinal";
            this.label_dataFinal.Size = new System.Drawing.Size(83, 19);
            this.label_dataFinal.TabIndex = 8;
            this.label_dataFinal.Text = "Data final:";
            // 
            // label_dataInicio
            // 
            this.label_dataInicio.AutoSize = true;
            this.label_dataInicio.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dataInicio.Location = new System.Drawing.Point(226, 18);
            this.label_dataInicio.Name = "label_dataInicio";
            this.label_dataInicio.Size = new System.Drawing.Size(93, 19);
            this.label_dataInicio.TabIndex = 7;
            this.label_dataInicio.Text = "Data inicial:";
            // 
            // label_horaFinal
            // 
            this.label_horaFinal.AutoSize = true;
            this.label_horaFinal.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horaFinal.Location = new System.Drawing.Point(448, 52);
            this.label_horaFinal.Name = "label_horaFinal";
            this.label_horaFinal.Size = new System.Drawing.Size(82, 19);
            this.label_horaFinal.TabIndex = 6;
            this.label_horaFinal.Text = "Hora final:";
            // 
            // label_horaInicio
            // 
            this.label_horaInicio.AutoSize = true;
            this.label_horaInicio.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_horaInicio.Location = new System.Drawing.Point(448, 19);
            this.label_horaInicio.Name = "label_horaInicio";
            this.label_horaInicio.Size = new System.Drawing.Size(92, 19);
            this.label_horaInicio.TabIndex = 5;
            this.label_horaInicio.Text = "Hora inicial:";
            // 
            // textBox_horaFinal
            // 
            this.textBox_horaFinal.Enabled = false;
            this.textBox_horaFinal.Location = new System.Drawing.Point(546, 54);
            this.textBox_horaFinal.Name = "textBox_horaFinal";
            this.textBox_horaFinal.Size = new System.Drawing.Size(100, 20);
            this.textBox_horaFinal.TabIndex = 4;
            this.textBox_horaFinal.Text = "--:--:--";
            // 
            // textBox_dataFinal
            // 
            this.textBox_dataFinal.Enabled = false;
            this.textBox_dataFinal.Location = new System.Drawing.Point(325, 54);
            this.textBox_dataFinal.Name = "textBox_dataFinal";
            this.textBox_dataFinal.Size = new System.Drawing.Size(100, 20);
            this.textBox_dataFinal.TabIndex = 3;
            this.textBox_dataFinal.Text = "--/--/--";
            // 
            // textBox_horaInicio
            // 
            this.textBox_horaInicio.Enabled = false;
            this.textBox_horaInicio.Location = new System.Drawing.Point(546, 19);
            this.textBox_horaInicio.Name = "textBox_horaInicio";
            this.textBox_horaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBox_horaInicio.TabIndex = 2;
            // 
            // textBox_dataInicio
            // 
            this.textBox_dataInicio.Enabled = false;
            this.textBox_dataInicio.Location = new System.Drawing.Point(325, 19);
            this.textBox_dataInicio.Name = "textBox_dataInicio";
            this.textBox_dataInicio.Size = new System.Drawing.Size(100, 20);
            this.textBox_dataInicio.TabIndex = 1;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Location = new System.Drawing.Point(43, 19);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(75, 20);
            this.textBox_id.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_km);
            this.groupBox2.Controls.Add(this.textBox_ano);
            this.groupBox2.Controls.Add(this.textBox_cor);
            this.groupBox2.Controls.Add(this.checkBox_lavado);
            this.groupBox2.Controls.Add(this.textBox_placa);
            this.groupBox2.Controls.Add(this.textBox_servicos);
            this.groupBox2.Controls.Add(this.textBox_veiculo);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículo";
            // 
            // textBox_km
            // 
            this.textBox_km.Enabled = false;
            this.textBox_km.Location = new System.Drawing.Point(374, 19);
            this.textBox_km.Name = "textBox_km";
            this.textBox_km.Size = new System.Drawing.Size(100, 20);
            this.textBox_km.TabIndex = 6;
            // 
            // textBox_ano
            // 
            this.textBox_ano.Enabled = false;
            this.textBox_ano.Location = new System.Drawing.Point(268, 19);
            this.textBox_ano.Name = "textBox_ano";
            this.textBox_ano.Size = new System.Drawing.Size(100, 20);
            this.textBox_ano.TabIndex = 5;
            // 
            // textBox_cor
            // 
            this.textBox_cor.Enabled = false;
            this.textBox_cor.Location = new System.Drawing.Point(162, 19);
            this.textBox_cor.Name = "textBox_cor";
            this.textBox_cor.Size = new System.Drawing.Size(100, 20);
            this.textBox_cor.TabIndex = 4;
            // 
            // checkBox_lavado
            // 
            this.checkBox_lavado.AutoSize = true;
            this.checkBox_lavado.Location = new System.Drawing.Point(701, 19);
            this.checkBox_lavado.Name = "checkBox_lavado";
            this.checkBox_lavado.Size = new System.Drawing.Size(68, 17);
            this.checkBox_lavado.TabIndex = 3;
            this.checkBox_lavado.Text = "Lavação";
            this.checkBox_lavado.UseVisualStyleBackColor = true;
            this.checkBox_lavado.CheckedChanged += new System.EventHandler(this.CheckBox_lavado_CheckedChanged);
            this.checkBox_lavado.CheckStateChanged += new System.EventHandler(this.CheckBox_lavado_CheckStateChanged);
            this.checkBox_lavado.Click += new System.EventHandler(this.CheckBox_lavado_Click);
            // 
            // textBox_placa
            // 
            this.textBox_placa.Enabled = false;
            this.textBox_placa.Location = new System.Drawing.Point(546, 19);
            this.textBox_placa.Name = "textBox_placa";
            this.textBox_placa.Size = new System.Drawing.Size(121, 20);
            this.textBox_placa.TabIndex = 2;
            // 
            // textBox_servicos
            // 
            this.textBox_servicos.Enabled = false;
            this.textBox_servicos.Location = new System.Drawing.Point(6, 45);
            this.textBox_servicos.Multiline = true;
            this.textBox_servicos.Name = "textBox_servicos";
            this.textBox_servicos.Size = new System.Drawing.Size(764, 53);
            this.textBox_servicos.TabIndex = 1;
            // 
            // textBox_veiculo
            // 
            this.textBox_veiculo.Enabled = false;
            this.textBox_veiculo.Location = new System.Drawing.Point(6, 19);
            this.textBox_veiculo.Name = "textBox_veiculo";
            this.textBox_veiculo.Size = new System.Drawing.Size(150, 20);
            this.textBox_veiculo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_telefone);
            this.groupBox3.Controls.Add(this.textBox_nome);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Enabled = false;
            this.textBox_telefone.Location = new System.Drawing.Point(482, 19);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(288, 20);
            this.textBox_telefone.TabIndex = 1;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Location = new System.Drawing.Point(6, 19);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(470, 20);
            this.textBox_nome.TabIndex = 0;
            // 
            // textBox_realizados
            // 
            this.textBox_realizados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_realizados.Location = new System.Drawing.Point(6, 19);
            this.textBox_realizados.MaxLength = 500;
            this.textBox_realizados.Multiline = true;
            this.textBox_realizados.Name = "textBox_realizados";
            this.textBox_realizados.Size = new System.Drawing.Size(661, 47);
            this.textBox_realizados.TabIndex = 0;
            this.textBox_realizados.Text = "Observações e alegações são itens importantes para o histórico do veículo";
            this.textBox_realizados.Enter += new System.EventHandler(this.TextBox_realizados_Enter);
            this.textBox_realizados.Leave += new System.EventHandler(this.TextBox_realizados_Leave);
            // 
            // dataGridView_pecas_ordem
            // 
            this.dataGridView_pecas_ordem.AllowUserToAddRows = false;
            this.dataGridView_pecas_ordem.AllowUserToDeleteRows = false;
            this.dataGridView_pecas_ordem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pecas_ordem.Location = new System.Drawing.Point(6, 72);
            this.dataGridView_pecas_ordem.MultiSelect = false;
            this.dataGridView_pecas_ordem.Name = "dataGridView_pecas_ordem";
            this.dataGridView_pecas_ordem.ReadOnly = true;
            this.dataGridView_pecas_ordem.RowHeadersVisible = false;
            this.dataGridView_pecas_ordem.RowHeadersWidth = 62;
            this.dataGridView_pecas_ordem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pecas_ordem.Size = new System.Drawing.Size(763, 122);
            this.dataGridView_pecas_ordem.TabIndex = 1;
            this.dataGridView_pecas_ordem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView_pecas_ordem_KeyDown);
            this.dataGridView_pecas_ordem.MouseLeave += new System.EventHandler(this.DataGridView_pecas_ordem_MouseLeave);
            this.dataGridView_pecas_ordem.MouseHover += new System.EventHandler(this.DataGridView_pecas_ordem_MouseHover);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_pecas_ordem);
            this.groupBox4.Controls.Add(this.button_adicionar);
            this.groupBox4.Controls.Add(this.textBox_realizados);
            this.groupBox4.Location = new System.Drawing.Point(12, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 200);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviços realizados e peças";
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(670, 19);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(100, 47);
            this.button_adicionar.TabIndex = 2;
            this.button_adicionar.Text = "Adicionar peças";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.Button_adicionar_Click);
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(713, 481);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 4;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.Button_salvar_Click);
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(70, 484);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(100, 20);
            this.textBox_total.TabIndex = 5;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(15, 483);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(49, 19);
            this.label_total.TabIndex = 6;
            this.label_total.Text = "Total:";
            // 
            // textBox_mecanico
            // 
            this.textBox_mecanico.Location = new System.Drawing.Point(337, 484);
            this.textBox_mecanico.MaxLength = 50;
            this.textBox_mecanico.Name = "textBox_mecanico";
            this.textBox_mecanico.Size = new System.Drawing.Size(100, 20);
            this.textBox_mecanico.TabIndex = 7;
            // 
            // label_mecanico
            // 
            this.label_mecanico.AutoSize = true;
            this.label_mecanico.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mecanico.Location = new System.Drawing.Point(252, 483);
            this.label_mecanico.Name = "label_mecanico";
            this.label_mecanico.Size = new System.Drawing.Size(79, 19);
            this.label_mecanico.TabIndex = 8;
            this.label_mecanico.Text = "Mecânico:";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Em serviço",
            "Aguardando serviço",
            "Pronta"});
            this.comboBox_status.Location = new System.Drawing.Point(558, 483);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status.TabIndex = 9;
            // 
            // label_comboBoxStatus
            // 
            this.label_comboBoxStatus.AutoSize = true;
            this.label_comboBoxStatus.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comboBoxStatus.Location = new System.Drawing.Point(493, 483);
            this.label_comboBoxStatus.Name = "label_comboBoxStatus";
            this.label_comboBoxStatus.Size = new System.Drawing.Size(59, 19);
            this.label_comboBoxStatus.TabIndex = 10;
            this.label_comboBoxStatus.Text = "Status:";
            // 
            // statusStrip_infoOS
            // 
            this.statusStrip_infoOS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_infoOS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_garageManager,
            this.toolStripSplitButton1});
            this.statusStrip_infoOS.Location = new System.Drawing.Point(0, 516);
            this.statusStrip_infoOS.Name = "statusStrip_infoOS";
            this.statusStrip_infoOS.Size = new System.Drawing.Size(800, 30);
            this.statusStrip_infoOS.TabIndex = 11;
            this.statusStrip_infoOS.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_garageManager
            // 
            this.toolStripStatusLabel_garageManager.Name = "toolStripStatusLabel_garageManager";
            this.toolStripStatusLabel_garageManager.Size = new System.Drawing.Size(94, 25);
            this.toolStripStatusLabel_garageManager.Text = "Garage Manager";
            // 
            // printDocument_os
            // 
            this.printDocument_os.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_os_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirOSToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::GarageManager.Properties.Resources.printer;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(40, 28);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // imprimirOSToolStripMenuItem
            // 
            this.imprimirOSToolStripMenuItem.Image = global::GarageManager.Properties.Resources.print;
            this.imprimirOSToolStripMenuItem.Name = "imprimirOSToolStripMenuItem";
            this.imprimirOSToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.imprimirOSToolStripMenuItem.Text = "Imprimir O.S.";
            this.imprimirOSToolStripMenuItem.Click += new System.EventHandler(this.imprimirOSToolStripMenuItem_Click);
            // 
            // OS_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.statusStrip_infoOS);
            this.Controls.Add(this.label_comboBoxStatus);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_mecanico);
            this.Controls.Add(this.textBox_mecanico);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "OS_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordem de Serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OS_Info_FormClosing);
            this.Load += new System.EventHandler(this.OS_Info_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OS_Info_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pecas_ordem)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip_infoOS.ResumeLayout(false);
            this.statusStrip_infoOS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_horaInicio;
        private System.Windows.Forms.TextBox textBox_dataInicio;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_servicos;
        private System.Windows.Forms.TextBox textBox_veiculo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.TextBox textBox_realizados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label_total;
        public System.Windows.Forms.DataGridView dataGridView_pecas_ordem;
        private System.Windows.Forms.TextBox textBox_mecanico;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_dataFinal;
        private System.Windows.Forms.Label label_dataInicio;
        private System.Windows.Forms.Label label_horaFinal;
        private System.Windows.Forms.Label label_horaInicio;
        private System.Windows.Forms.TextBox textBox_horaFinal;
        private System.Windows.Forms.TextBox textBox_dataFinal;
        private System.Windows.Forms.Label label_mecanico;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label_comboBoxStatus;
        private System.Windows.Forms.StatusStrip statusStrip_infoOS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_garageManager;
        private System.Windows.Forms.CheckBox checkBox_voltar;
        private System.Windows.Forms.CheckBox checkBox_lavado;
        private System.Windows.Forms.Button button_alterar;
        private System.Windows.Forms.TextBox textBox_km;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.TextBox textBox_cor;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem imprimirOSToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument_os;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}