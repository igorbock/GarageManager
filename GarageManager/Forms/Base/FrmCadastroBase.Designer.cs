namespace GarageManager.Forms.Base
{
    partial class FrmCadastroBase
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
            TSStatus = new System.Windows.Forms.ToolStrip();
            BtnStatus = new System.Windows.Forms.ToolStripSplitButton();
            BtnImprimirGrid = new System.Windows.Forms.ToolStripMenuItem();
            PGEntidade = new System.Windows.Forms.PropertyGrid();
            GBEntidade = new System.Windows.Forms.GroupBox();
            CmbEntidade = new System.Windows.Forms.ComboBox();
            BtnInserir = new System.Windows.Forms.Button();
            BtnEditar = new System.Windows.Forms.Button();
            BtnExcluir = new System.Windows.Forms.Button();
            BtnFechar = new System.Windows.Forms.Button();
            BtnSalvar = new System.Windows.Forms.Button();
            BtnCancelar = new System.Windows.Forms.Button();
            TSStatus.SuspendLayout();
            GBEntidade.SuspendLayout();
            SuspendLayout();
            // 
            // TSStatus
            // 
            TSStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            TSStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { BtnStatus });
            TSStatus.Location = new System.Drawing.Point(0, 322);
            TSStatus.Name = "TSStatus";
            TSStatus.Size = new System.Drawing.Size(467, 25);
            TSStatus.TabIndex = 0;
            TSStatus.Text = "toolStrip1";
            // 
            // BtnStatus
            // 
            BtnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            BtnStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { BtnImprimirGrid });
            BtnStatus.Image = Properties.Resources.barra_status;
            BtnStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            BtnStatus.Name = "BtnStatus";
            BtnStatus.Size = new System.Drawing.Size(32, 22);
            BtnStatus.Text = "toolStripSplitButton1";
            // 
            // BtnImprimirGrid
            // 
            BtnImprimirGrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            BtnImprimirGrid.ForeColor = System.Drawing.Color.Black;
            BtnImprimirGrid.Image = Properties.Resources.impressora;
            BtnImprimirGrid.Name = "BtnImprimirGrid";
            BtnImprimirGrid.Size = new System.Drawing.Size(153, 22);
            BtnImprimirGrid.Text = "Imprimir Grid";
            // 
            // PGEntidade
            // 
            PGEntidade.BackColor = System.Drawing.SystemColors.Control;
            PGEntidade.Location = new System.Drawing.Point(1, 46);
            PGEntidade.Margin = new System.Windows.Forms.Padding(1);
            PGEntidade.Name = "PGEntidade";
            PGEntidade.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            PGEntidade.Size = new System.Drawing.Size(465, 250);
            PGEntidade.TabIndex = 3;
            // 
            // GBEntidade
            // 
            GBEntidade.Controls.Add(CmbEntidade);
            GBEntidade.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            GBEntidade.ForeColor = System.Drawing.Color.Black;
            GBEntidade.Location = new System.Drawing.Point(1, 1);
            GBEntidade.Margin = new System.Windows.Forms.Padding(1);
            GBEntidade.Name = "GBEntidade";
            GBEntidade.Size = new System.Drawing.Size(465, 43);
            GBEntidade.TabIndex = 4;
            GBEntidade.TabStop = false;
            GBEntidade.Text = "Selecione um Item";
            // 
            // CmbEntidade
            // 
            CmbEntidade.ForeColor = System.Drawing.Color.Black;
            CmbEntidade.FormattingEnabled = true;
            CmbEntidade.Location = new System.Drawing.Point(4, 16);
            CmbEntidade.Margin = new System.Windows.Forms.Padding(1);
            CmbEntidade.Name = "CmbEntidade";
            CmbEntidade.Size = new System.Drawing.Size(456, 22);
            CmbEntidade.TabIndex = 0;
            // 
            // BtnInserir
            // 
            BtnInserir.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnInserir.ForeColor = System.Drawing.Color.Black;
            BtnInserir.Image = Properties.Resources.adicionar;
            BtnInserir.Location = new System.Drawing.Point(1, 296);
            BtnInserir.Margin = new System.Windows.Forms.Padding(1);
            BtnInserir.Name = "BtnInserir";
            BtnInserir.Size = new System.Drawing.Size(100, 25);
            BtnInserir.TabIndex = 5;
            BtnInserir.Text = "Inserir (Ins)";
            BtnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnInserir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnEditar.ForeColor = System.Drawing.Color.Black;
            BtnEditar.Image = Properties.Resources.edit;
            BtnEditar.Location = new System.Drawing.Point(100, 296);
            BtnEditar.Margin = new System.Windows.Forms.Padding(1);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new System.Drawing.Size(100, 25);
            BtnEditar.TabIndex = 6;
            BtnEditar.Text = "Editar (F3)";
            BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnExcluir.ForeColor = System.Drawing.Color.Black;
            BtnExcluir.Image = Properties.Resources.remover;
            BtnExcluir.Location = new System.Drawing.Point(199, 296);
            BtnExcluir.Margin = new System.Windows.Forms.Padding(1);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new System.Drawing.Size(100, 25);
            BtnExcluir.TabIndex = 7;
            BtnExcluir.Text = "Excluir (Del)";
            BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnFechar.ForeColor = System.Drawing.Color.Black;
            BtnFechar.Image = Properties.Resources.sair;
            BtnFechar.Location = new System.Drawing.Point(298, 296);
            BtnFechar.Margin = new System.Windows.Forms.Padding(1);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new System.Drawing.Size(100, 25);
            BtnFechar.TabIndex = 8;
            BtnFechar.Text = "Fechar (Esc)";
            BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnSalvar.ForeColor = System.Drawing.Color.Black;
            BtnSalvar.Image = Properties.Resources.save;
            BtnSalvar.Location = new System.Drawing.Point(1, 296);
            BtnSalvar.Margin = new System.Windows.Forms.Padding(1);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new System.Drawing.Size(100, 25);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar (F6)";
            BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            BtnCancelar.ForeColor = System.Drawing.Color.Black;
            BtnCancelar.Image = Properties.Resources.cancel;
            BtnCancelar.Location = new System.Drawing.Point(100, 296);
            BtnCancelar.Margin = new System.Windows.Forms.Padding(1);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new System.Drawing.Size(100, 25);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 347);
            ControlBox = false;
            Controls.Add(BtnFechar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnInserir);
            Controls.Add(GBEntidade);
            Controls.Add(PGEntidade);
            Controls.Add(TSStatus);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadastroBase";
            Text = "FrmCadastroBase";
            TSStatus.ResumeLayout(false);
            TSStatus.PerformLayout();
            GBEntidade.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSStatus;
        private System.Windows.Forms.ToolStripSplitButton BtnStatus;
        private System.Windows.Forms.ToolStripMenuItem BtnImprimirGrid;
        private System.Windows.Forms.PropertyGrid PGEntidade;
        private System.Windows.Forms.GroupBox GBEntidade;
        private System.Windows.Forms.ComboBox CmbEntidade;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}