namespace VNS.ERP.GUI.Accounting
{
    partial class FormEditAccountTransactionStock
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
            this.ucAccountTransactionStock11 = new VNS.ERP.GUI.UserControls.UCAccountTransactionStock1();
            this.btnPrintCTPS = new DevExpress.XtraEditors.SimpleButton();
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
            // ucAccountTransactionStock11
            // 
            this.ucAccountTransactionStock11.AccountTransactionTypeCode = null;
            this.ucAccountTransactionStock11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAccountTransactionStock11.Description = "";
            this.ucAccountTransactionStock11.Location = new System.Drawing.Point(0, 42);
            this.ucAccountTransactionStock11.Name = "ucAccountTransactionStock11";
            this.ucAccountTransactionStock11.Size = new System.Drawing.Size(954, 393);
            this.ucAccountTransactionStock11.StockTransactionTypeCode = null;
            this.ucAccountTransactionStock11.StrObject = "";
            this.ucAccountTransactionStock11.TabIndex = 5;
            // 
            // btnPrintCTPS
            // 
            this.btnPrintCTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCTPS.Location = new System.Drawing.Point(825, 438);
            this.btnPrintCTPS.Name = "btnPrintCTPS";
            this.btnPrintCTPS.Size = new System.Drawing.Size(91, 23);
            this.btnPrintCTPS.TabIndex = 105;
            this.btnPrintCTPS.Text = "In CTPS";
            this.btnPrintCTPS.Click += new System.EventHandler(this.btnPrintCTPS_Click);
            // 
            // FormEditAccountTransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 490);
            this.Controls.Add(this.btnPrintCTPS);
            this.Controls.Add(this.ucAccountTransactionStock11);
            this.EditControl = this.ucAccountTransactionStock11;
            this.Name = "FormEditAccountTransactionStock";
            this.Text = "FormEditAccountTransactionStock";
            this.Load += new System.EventHandler(this.FormEditAccountTransactionStock_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditAccountTransactionStock_FormClosing);
            this.Controls.SetChildIndex(this.ucAccountTransactionStock11, 0);
            this.Controls.SetChildIndex(this.btnPrintCTPS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.UCAccountTransactionStock1 ucAccountTransactionStock11;
        private DevExpress.XtraEditors.SimpleButton btnPrintCTPS;
    }
}