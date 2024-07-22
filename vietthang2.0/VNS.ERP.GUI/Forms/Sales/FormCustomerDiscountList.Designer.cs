namespace VNS.ERP.GUI.Forms.Sales
{
    partial class FormCustomerDiscountList
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
            this.ucCustomerDiscountList1 = new VNS.ERP.GUI.UserControls.UCCustomerDiscountList();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // ucCustomerDiscountList1
            // 
            this.ucCustomerDiscountList1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCustomerDiscountList1.Location = new System.Drawing.Point(5, 241);
            this.ucCustomerDiscountList1.Name = "ucCustomerDiscountList1";
            this.ucCustomerDiscountList1.Size = new System.Drawing.Size(574, 184);
            this.ucCustomerDiscountList1.TabIndex = 105;
            // 
            // FormCustomerDiscountList
            // 
            this.ClientSize = new System.Drawing.Size(584, 459);
            this.Controls.Add(this.ucCustomerDiscountList1);
            this.Name = "FormCustomerDiscountList";
            this.Text = "Danh sách chiết khấu bán hàng";
            this.Controls.SetChildIndex(this.ucCustomerDiscountList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.UCCustomerDiscountList ucCustomerDiscountList1;
    }
}
