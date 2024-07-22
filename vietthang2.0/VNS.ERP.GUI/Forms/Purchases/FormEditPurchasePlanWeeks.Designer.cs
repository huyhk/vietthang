namespace VNS.ERP.GUI
{
    partial class FormEditPurchasePlanWeeks
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
            this.ucPurchasePlanWeeks1 = new VNS.ERP.GUI.UCPurchasePlanWeeks();
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
            this.tableLayoutPanel1.Controls.Add(this.ucPurchasePlanWeeks1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 402);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ucPurchasePlanWeeks1
            // 
            this.ucPurchasePlanWeeks1.Business = null;
            this.ucPurchasePlanWeeks1.DataSource = null;
            this.ucPurchasePlanWeeks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPurchasePlanWeeks1.Location = new System.Drawing.Point(3, 3);
            this.ucPurchasePlanWeeks1.Name = "ucPurchasePlanWeeks1";
            this.ucPurchasePlanWeeks1.Size = new System.Drawing.Size(832, 396);
            this.ucPurchasePlanWeeks1.TabIndex = 0;
            // 
            // FormEditPurchasePlanWeeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(838, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucPurchasePlanWeeks1;
            this.Name = "FormEditPurchasePlanWeeks";
            this.Text = "FormEditPurchasePlanWeeks";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCPurchasePlanWeeks ucPurchasePlanWeeks1;
    }
}
