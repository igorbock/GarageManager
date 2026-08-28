namespace GarageManager.Controls
{
    partial class EntityComboBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelEntidade = new System.Windows.Forms.Label();
            comboBoxEntidade = new System.Windows.Forms.ComboBox();
            btnAbrir = new System.Windows.Forms.Button();
            toolTip = new System.Windows.Forms.ToolTip(components);
            tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // labelEntidade
            // 
            labelEntidade.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelEntidade.AutoSize = true;
            labelEntidade.Font = new System.Drawing.Font("Tahoma", 9F);
            labelEntidade.Location = new System.Drawing.Point(3, 4);
            labelEntidade.Name = "labelEntidade";
            labelEntidade.Size = new System.Drawing.Size(94, 14);
            labelEntidade.TabIndex = 0;
            labelEntidade.Text = "Entidade";
            // 
            // comboBoxEntidade
            // 
            comboBoxEntidade.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBoxEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEntidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            comboBoxEntidade.Location = new System.Drawing.Point(100, 0);
            comboBoxEntidade.Margin = new System.Windows.Forms.Padding(0);
            comboBoxEntidade.Name = "comboBoxEntidade";
            comboBoxEntidade.Size = new System.Drawing.Size(260, 23);
            comboBoxEntidade.TabIndex = 1;
            toolTip.SetToolTip(comboBoxEntidade, "Selecione um registro\r\n");
            // 
            // btnAbrir
            // 
            btnAbrir.Dock = System.Windows.Forms.DockStyle.Fill;
            btnAbrir.FlatAppearance.BorderSize = 0;
            btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAbrir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            btnAbrir.Image = Properties.Resources.novo;
            btnAbrir.Location = new System.Drawing.Point(361, 1);
            btnAbrir.Margin = new System.Windows.Forms.Padding(1);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new System.Drawing.Size(21, 21);
            btnAbrir.TabIndex = 2;
            toolTip.SetToolTip(btnAbrir, "Inserir um novo registro");
            btnAbrir.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel.Controls.Add(btnAbrir, 2, 0);
            tableLayoutPanel.Controls.Add(labelEntidade, 0, 0);
            tableLayoutPanel.Controls.Add(comboBoxEntidade, 1, 0);
            tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel.Size = new System.Drawing.Size(383, 23);
            tableLayoutPanel.TabIndex = 3;
            // 
            // EntityComboBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Margin = new System.Windows.Forms.Padding(1);
            Name = "EntityComboBox";
            Size = new System.Drawing.Size(383, 23);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelEntidade;
        private System.Windows.Forms.ComboBox comboBoxEntidade;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
