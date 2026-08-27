namespace GarageManager.Forms.Cadastros
{
    partial class FrmBaseCadastro
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
            propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            btnInserir = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnExcluir = new System.Windows.Forms.Button();
            btnFechar = new System.Windows.Forms.Button();
            btnSalvar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            statusStrip = new System.Windows.Forms.StatusStrip();
            btnOpcoes = new System.Windows.Forms.ToolStripSplitButton();
            imprimirListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportarXLSXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportarDOCXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            statusStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = System.Drawing.SystemColors.Control;
            propertyGrid1.Location = new System.Drawing.Point(1, 44);
            propertyGrid1.Margin = new System.Windows.Forms.Padding(1);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.SelectedObject = propertyGrid1;
            propertyGrid1.Size = new System.Drawing.Size(401, 308);
            propertyGrid1.TabIndex = 0;
            propertyGrid1.ToolbarVisible = false;
            // 
            // btnInserir
            // 
            btnInserir.Location = new System.Drawing.Point(1, 353);
            btnInserir.Margin = new System.Windows.Forms.Padding(1);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new System.Drawing.Size(75, 25);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(75, 353);
            btnEditar.Margin = new System.Windows.Forms.Padding(1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(75, 25);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new System.Drawing.Point(149, 353);
            btnExcluir.Margin = new System.Windows.Forms.Padding(1);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new System.Drawing.Size(75, 25);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new System.Drawing.Point(223, 353);
            btnFechar.Margin = new System.Windows.Forms.Padding(1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new System.Drawing.Size(75, 25);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(1, 353);
            btnSalvar.Margin = new System.Windows.Forms.Padding(1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(75, 25);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(75, 353);
            btnCancelar.Margin = new System.Windows.Forms.Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 25);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnOpcoes });
            statusStrip.Location = new System.Drawing.Point(0, 379);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(403, 22);
            statusStrip.TabIndex = 7;
            statusStrip.Text = "statusStrip1";
            // 
            // btnOpcoes
            // 
            btnOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { imprimirListaToolStripMenuItem, exportarXLSXToolStripMenuItem, exportarDOCXToolStripMenuItem, exportarPDFToolStripMenuItem });
            btnOpcoes.Image = Properties.Resources.print;
            btnOpcoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnOpcoes.Name = "btnOpcoes";
            btnOpcoes.Size = new System.Drawing.Size(133, 20);
            btnOpcoes.Text = "Imprimir/Exportar";
            // 
            // imprimirListaToolStripMenuItem
            // 
            imprimirListaToolStripMenuItem.Name = "imprimirListaToolStripMenuItem";
            imprimirListaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            imprimirListaToolStripMenuItem.Text = "Imprimir Lista";
            // 
            // exportarXLSXToolStripMenuItem
            // 
            exportarXLSXToolStripMenuItem.Name = "exportarXLSXToolStripMenuItem";
            exportarXLSXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            exportarXLSXToolStripMenuItem.Text = "Exportar XLSX";
            // 
            // exportarDOCXToolStripMenuItem
            // 
            exportarDOCXToolStripMenuItem.Name = "exportarDOCXToolStripMenuItem";
            exportarDOCXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            exportarDOCXToolStripMenuItem.Text = "Exportar DOCX";
            // 
            // exportarPDFToolStripMenuItem
            // 
            exportarPDFToolStripMenuItem.Name = "exportarPDFToolStripMenuItem";
            exportarPDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            exportarPDFToolStripMenuItem.Text = "Exportar PDF";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 15;
            comboBox1.Location = new System.Drawing.Point(6, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(389, 23);
            comboBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new System.Drawing.Point(1, 1);
            groupBox1.Margin = new System.Windows.Forms.Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(401, 43);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um registro";
            // 
            // FrmBaseCadastro
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(403, 401);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(propertyGrid1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBaseCadastro";
            Text = "FrmBaseCadastro";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSplitButton btnOpcoes;
        private System.Windows.Forms.ToolStripMenuItem exportarXLSXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDOCXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirListaToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}