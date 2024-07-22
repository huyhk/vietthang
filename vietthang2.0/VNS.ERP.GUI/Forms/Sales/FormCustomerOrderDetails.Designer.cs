namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerOrderDetails
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
            this.ucCustomerOrderDetail1 = new UCCustomerOrderDetail();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            // ucCustomerOrderDetail1
            // 
            this.ucCustomerOrderDetail1.Business = null;
            this.ucCustomerOrderDetail1.DataSource = null;
            this.ucCustomerOrderDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerOrderDetail1.Location = new System.Drawing.Point(3, 3);
            this.ucCustomerOrderDetail1.Name = "ucCustomerOrderDetail1";
            this.ucCustomerOrderDetail1.Size = new System.Drawing.Size(830, 551);
            this.ucCustomerOrderDetail1.StockCode = null;
            this.ucCustomerOrderDetail1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucCustomerOrderDetail1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 557);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormCustomerOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucCustomerOrderDetail1;
            this.Name = "FormCustomerOrderDetails";
            this.Text = "CustomerOderDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCustomerOderDetails_FormClosing);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCCustomerOrderDetail ucCustomerOrderDetail1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}