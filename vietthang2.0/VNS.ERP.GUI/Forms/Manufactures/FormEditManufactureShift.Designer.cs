namespace VNS.ERP.GUI.Manufactures
{
    partial class FormEditManufactureShift
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucManufactureShifts1 = new VNS.ERP.GUI.Manufactures.UCManufactureShifts();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            this.defaultLookAndFeel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // defaultBarAndDocking
            // 
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucManufactureShifts1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 393);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // ucManufactureShifts1
            // 
            this.ucManufactureShifts1.BackColor = System.Drawing.Color.Transparent;
            this.ucManufactureShifts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManufactureShifts1.Location = new System.Drawing.Point(3, 3);
            this.ucManufactureShifts1.Name = "ucManufactureShifts1";
            this.ucManufactureShifts1.Size = new System.Drawing.Size(467, 387);
            this.ucManufactureShifts1.StockCode = null;
            this.ucManufactureShifts1.TabIndex = 0;
            // 
            // FormEditManufactureShift
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucManufactureShifts1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 316);
            this.Name = "FormEditManufactureShift";
            this.Text = "Phiếu sản xuất";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditManufactureShift_FormClosing);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCManufactureShifts ucManufactureShifts1;
    }
}