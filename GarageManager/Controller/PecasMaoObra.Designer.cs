namespace GarageManager.Controller
{
    partial class PecasMaoObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PecasMaoObra));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_pecas = new System.Windows.Forms.TabPage();
            this.label_percentual = new System.Windows.Forms.Label();
            this.numericUpDown_percentual = new System.Windows.Forms.NumericUpDown();
            this.label_taxaIncremental = new System.Windows.Forms.Label();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_valor = new System.Windows.Forms.TextBox();
            this.numericUpDown_quant = new System.Windows.Forms.NumericUpDown();
            this.textBox_marca = new System.Windows.Forms.TextBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.tabPage_maoObra = new System.Windows.Forms.TabPage();
            this.label_quantServico = new System.Windows.Forms.Label();
            this.label_totalServico = new System.Windows.Forms.Label();
            this.textBox_valorServico = new System.Windows.Forms.TextBox();
            this.button_adicionarServico = new System.Windows.Forms.Button();
            this.numericUpDown_quantidade = new System.Windows.Forms.NumericUpDown();
            this.label_valor = new System.Windows.Forms.Label();
            this.textBox_servico = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_pecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percentual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quant)).BeginInit();
            this.tabPage_maoObra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_pecas);
            this.tabControl1.Controls.Add(this.tabPage_maoObra);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 77);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_pecas
            // 
            this.tabPage_pecas.Controls.Add(this.label_percentual);
            this.tabPage_pecas.Controls.Add(this.numericUpDown_percentual);
            this.tabPage_pecas.Controls.Add(this.label_taxaIncremental);
            this.tabPage_pecas.Controls.Add(this.button_adicionar);
            this.tabPage_pecas.Controls.Add(this.label_total);
            this.tabPage_pecas.Controls.Add(this.textBox_valor);
            this.tabPage_pecas.Controls.Add(this.numericUpDown_quant);
            this.tabPage_pecas.Controls.Add(this.textBox_marca);
            this.tabPage_pecas.Controls.Add(this.textBox_descricao);
            this.tabPage_pecas.Location = new System.Drawing.Point(4, 22);
            this.tabPage_pecas.Name = "tabPage_pecas";
            this.tabPage_pecas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_pecas.Size = new System.Drawing.Size(897, 51);
            this.tabPage_pecas.TabIndex = 0;
            this.tabPage_pecas.Text = "Peças";
            this.tabPage_pecas.UseVisualStyleBackColor = true;
            // 
            // label_percentual
            // 
            this.label_percentual.AutoSize = true;
            this.label_percentual.Location = new System.Drawing.Point(629, 20);
            this.label_percentual.Name = "label_percentual";
            this.label_percentual.Size = new System.Drawing.Size(15, 13);
            this.label_percentual.TabIndex = 6;
            this.label_percentual.Text = "%";
            // 
            // numericUpDown_percentual
            // 
            this.numericUpDown_percentual.Location = new System.Drawing.Point(575, 14);
            this.numericUpDown_percentual.Name = "numericUpDown_percentual";
            this.numericUpDown_percentual.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown_percentual.TabIndex = 5;
            this.numericUpDown_percentual.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // label_taxaIncremental
            // 
            this.label_taxaIncremental.AutoSize = true;
            this.label_taxaIncremental.Location = new System.Drawing.Point(478, 19);
            this.label_taxaIncremental.Name = "label_taxaIncremental";
            this.label_taxaIncremental.Size = new System.Drawing.Size(91, 13);
            this.label_taxaIncremental.TabIndex = 4;
            this.label_taxaIncremental.Text = "Taxa incremental:";
            // 
            // button_adicionar
            // 
            this.button_adicionar.Location = new System.Drawing.Point(816, 14);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_adicionar.TabIndex = 8;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.UseVisualStyleBackColor = true;
            this.button_adicionar.Click += new System.EventHandler(this.Button_adicionar_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(679, 19);
            this.label_total.Margin = new System.Windows.Forms.Padding(15);
            this.label_total.Name = "label_total";
            this.label_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_total.Size = new System.Drawing.Size(69, 13);
            this.label_total.TabIndex = 7;
            this.label_total.Text = "Sub-total: R$";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_valor
            // 
            this.textBox_valor.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_valor.Location = new System.Drawing.Point(372, 13);
            this.textBox_valor.Name = "textBox_valor";
            this.textBox_valor.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor.TabIndex = 3;
            this.textBox_valor.Text = "Custo";
            this.textBox_valor.Enter += new System.EventHandler(this.TextBox_valor_Enter);
            this.textBox_valor.Leave += new System.EventHandler(this.TextBox_valor_Leave);
            // 
            // numericUpDown_quant
            // 
            this.numericUpDown_quant.DecimalPlaces = 2;
            this.numericUpDown_quant.Location = new System.Drawing.Point(289, 14);
            this.numericUpDown_quant.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown_quant.Name = "numericUpDown_quant";
            this.numericUpDown_quant.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown_quant.TabIndex = 2;
            this.numericUpDown_quant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_quant.Leave += new System.EventHandler(this.NumericUpDown_quant_Leave);
            // 
            // textBox_marca
            // 
            this.textBox_marca.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_marca.Location = new System.Drawing.Point(176, 13);
            this.textBox_marca.MaxLength = 50;
            this.textBox_marca.Name = "textBox_marca";
            this.textBox_marca.Size = new System.Drawing.Size(100, 20);
            this.textBox_marca.TabIndex = 1;
            this.textBox_marca.Text = "Marca";
            this.textBox_marca.Enter += new System.EventHandler(this.TextBox_marca_Enter);
            this.textBox_marca.Leave += new System.EventHandler(this.TextBox_marca_Leave);
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_descricao.Location = new System.Drawing.Point(13, 13);
            this.textBox_descricao.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_descricao.MaxLength = 100;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(150, 20);
            this.textBox_descricao.TabIndex = 0;
            this.textBox_descricao.Text = "Descrição";
            this.textBox_descricao.Enter += new System.EventHandler(this.TextBox_descricao_Enter);
            this.textBox_descricao.Leave += new System.EventHandler(this.TextBox_descricao_Leave);
            // 
            // tabPage_maoObra
            // 
            this.tabPage_maoObra.Controls.Add(this.label_quantServico);
            this.tabPage_maoObra.Controls.Add(this.label_totalServico);
            this.tabPage_maoObra.Controls.Add(this.textBox_valorServico);
            this.tabPage_maoObra.Controls.Add(this.button_adicionarServico);
            this.tabPage_maoObra.Controls.Add(this.numericUpDown_quantidade);
            this.tabPage_maoObra.Controls.Add(this.label_valor);
            this.tabPage_maoObra.Controls.Add(this.textBox_servico);
            this.tabPage_maoObra.Location = new System.Drawing.Point(4, 22);
            this.tabPage_maoObra.Name = "tabPage_maoObra";
            this.tabPage_maoObra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_maoObra.Size = new System.Drawing.Size(897, 51);
            this.tabPage_maoObra.TabIndex = 1;
            this.tabPage_maoObra.Text = "Mão de Obra";
            this.tabPage_maoObra.UseVisualStyleBackColor = true;
            // 
            // label_quantServico
            // 
            this.label_quantServico.AutoSize = true;
            this.label_quantServico.Location = new System.Drawing.Point(466, 16);
            this.label_quantServico.Name = "label_quantServico";
            this.label_quantServico.Size = new System.Drawing.Size(65, 13);
            this.label_quantServico.TabIndex = 3;
            this.label_quantServico.Text = "Quantidade:";
            // 
            // label_totalServico
            // 
            this.label_totalServico.AutoSize = true;
            this.label_totalServico.Location = new System.Drawing.Point(677, 16);
            this.label_totalServico.Name = "label_totalServico";
            this.label_totalServico.Size = new System.Drawing.Size(51, 13);
            this.label_totalServico.TabIndex = 5;
            this.label_totalServico.Text = "Total: R$";
            // 
            // textBox_valorServico
            // 
            this.textBox_valorServico.Location = new System.Drawing.Point(320, 13);
            this.textBox_valorServico.Name = "textBox_valorServico";
            this.textBox_valorServico.Size = new System.Drawing.Size(100, 20);
            this.textBox_valorServico.TabIndex = 2;
            this.textBox_valorServico.Leave += new System.EventHandler(this.TextBox_valorServico_Leave);
            // 
            // button_adicionarServico
            // 
            this.button_adicionarServico.Location = new System.Drawing.Point(816, 15);
            this.button_adicionarServico.Name = "button_adicionarServico";
            this.button_adicionarServico.Size = new System.Drawing.Size(75, 23);
            this.button_adicionarServico.TabIndex = 6;
            this.button_adicionarServico.Text = "Adicionar";
            this.button_adicionarServico.UseVisualStyleBackColor = true;
            this.button_adicionarServico.Click += new System.EventHandler(this.Button_adicionarServico_Click);
            // 
            // numericUpDown_quantidade
            // 
            this.numericUpDown_quantidade.Location = new System.Drawing.Point(537, 14);
            this.numericUpDown_quantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_quantidade.Name = "numericUpDown_quantidade";
            this.numericUpDown_quantidade.Size = new System.Drawing.Size(63, 20);
            this.numericUpDown_quantidade.TabIndex = 4;
            this.numericUpDown_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_quantidade.ValueChanged += new System.EventHandler(this.NumericUpDown_quantidade_ValueChanged);
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.Location = new System.Drawing.Point(280, 15);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(34, 13);
            this.label_valor.TabIndex = 1;
            this.label_valor.Text = "Valor:";
            // 
            // textBox_servico
            // 
            this.textBox_servico.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_servico.Location = new System.Drawing.Point(13, 13);
            this.textBox_servico.MaxLength = 100;
            this.textBox_servico.Name = "textBox_servico";
            this.textBox_servico.Size = new System.Drawing.Size(250, 20);
            this.textBox_servico.TabIndex = 0;
            this.textBox_servico.Text = "Mão de obra ou serviço";
            this.textBox_servico.Enter += new System.EventHandler(this.TextBox_servico_Enter);
            this.textBox_servico.Leave += new System.EventHandler(this.TextBox_servico_Leave);
            // 
            // PecasMaoObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 108);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PecasMaoObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Peças e mão de obra";
            this.Load += new System.EventHandler(this.PecasMaoObra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_pecas.ResumeLayout(false);
            this.tabPage_pecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percentual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quant)).EndInit();
            this.tabPage_maoObra.ResumeLayout(false);
            this.tabPage_maoObra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_pecas;
        private System.Windows.Forms.TabPage tabPage_maoObra;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.NumericUpDown numericUpDown_quant;
        private System.Windows.Forms.TextBox textBox_marca;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_valor;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Button button_adicionarServico;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantidade;
        private System.Windows.Forms.Label label_valor;
        private System.Windows.Forms.TextBox textBox_servico;
        private System.Windows.Forms.Label label_totalServico;
        private System.Windows.Forms.TextBox textBox_valorServico;
        private System.Windows.Forms.Label label_percentual;
        private System.Windows.Forms.NumericUpDown numericUpDown_percentual;
        private System.Windows.Forms.Label label_taxaIncremental;
        private System.Windows.Forms.Label label_quantServico;
    }
}