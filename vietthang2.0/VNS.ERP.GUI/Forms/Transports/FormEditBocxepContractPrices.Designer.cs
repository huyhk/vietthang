
namespace VNS.ERP.GUI.Transports
{
    partial class FormEditBocxepContractPrices
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
            this.ucBocxepContractPrices2 = new UCBocxepContractPrices();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
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
            // ucBocxepContractPrices2
            // 
            this.ucBocxepContractPrices2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBocxepContractPrices2.Business = null;
            this.ucBocxepContractPrices2.ContractID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucBocxepContractPrices2.DataSource = null;
            this.ucBocxepContractPrices2.Location = new System.Drawing.Point(0, 45);
            this.ucBocxepContractPrices2.Name = "ucBocxepContractPrices2";
            this.ucBocxepContractPrices2.Size = new System.Drawing.Size(932, 413);
            this.ucBocxepContractPrices2.TabIndex = 6;
            // 
            // FormEditBocxepContractPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 487);
            this.Controls.Add(this.ucBocxepContractPrices2);
            this.EditControl = this.ucBocxepContractPrices2;
            this.Name = "FormEditBocxepContractPrices";
            this.Text = "Bảng giá  bốc xếp";
            this.Controls.SetChildIndex(this.ucBocxepContractPrices2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCBocxepContractPrices ucBocxepContractPrices2;
    }
}