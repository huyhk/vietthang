namespace VNS.Windows.Controls
{
    partial class UCNotify
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.AutoSize = true;
            this.tblLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblLayoutPanel.ColumnCount = 1;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 1;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(645, 192);
            this.tblLayoutPanel.TabIndex = 1;
            // 
            // UCNotify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutPanel);
            this.Name = "UCNotify";
            this.Size = new System.Drawing.Size(645, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
    }
}
