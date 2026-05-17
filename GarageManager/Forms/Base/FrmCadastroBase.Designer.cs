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
            this.TSStatus = new System.Windows.Forms.ToolStrip();
            this.BtnStatus = new System.Windows.Forms.ToolStripSplitButton();
            this.BtnImprimirGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TSStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSStatus
            // 
            this.TSStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TSStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnStatus});
            this.TSStatus.Location = new System.Drawing.Point(0, 276);
            this.TSStatus.Name = "TSStatus";
            this.TSStatus.Size = new System.Drawing.Size(400, 25);
            this.TSStatus.TabIndex = 0;
            this.TSStatus.Text = "toolStrip1";
            // 
            // BtnStatus
            // 
            this.BtnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnImprimirGrid});
            this.BtnStatus.Image = global::GarageManager.Properties.Resources.barra_status;
            this.BtnStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(32, 22);
            this.BtnStatus.Text = "toolStripSplitButton1";
            // 
            // BtnImprimirGrid
            // 
            this.BtnImprimirGrid.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BtnImprimirGrid.ForeColor = System.Drawing.Color.Black;
            this.BtnImprimirGrid.Image = global::GarageManager.Properties.Resources.impressora;
            this.BtnImprimirGrid.Name = "BtnImprimirGrid";
            this.BtnImprimirGrid.Size = new System.Drawing.Size(180, 22);
            this.BtnImprimirGrid.Text = "Imprimir Grid";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmCadastroBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 301);
            this.ControlBox = false;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TSStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroBase";
            this.Text = "FrmCadastroBase";
            this.TSStatus.ResumeLayout(false);
            this.TSStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSStatus;
        private System.Windows.Forms.ToolStripSplitButton BtnStatus;
        private System.Windows.Forms.ToolStripMenuItem BtnImprimirGrid;
        private System.Windows.Forms.ListView listView1;
    }
}