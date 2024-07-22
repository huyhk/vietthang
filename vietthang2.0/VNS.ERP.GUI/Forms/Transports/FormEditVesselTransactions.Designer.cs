namespace VNS.ERP.GUI.Transports
{
    partial class FormEditVesselTransactions
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
            this.ucVesselTransactions1 = new UCVesselTransactions();
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
            // ucVesselTransactions1
            // 
            this.ucVesselTransactions1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVesselTransactions1.Business = null;
            this.ucVesselTransactions1.DataSource = null;
            this.ucVesselTransactions1.Location = new System.Drawing.Point(6, 48);
            this.ucVesselTransactions1.Name = "ucVesselTransactions1";
            this.ucVesselTransactions1.Size = new System.Drawing.Size(672, 454);
            this.ucVesselTransactions1.TabIndex = 5;
            // 
            // FormEditVesselTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 531);
            this.Controls.Add(this.ucVesselTransactions1);
            this.EditControl = this.ucVesselTransactions1;
            this.Name = "FormEditVesselTransactions";
            this.Text = "FormEditVesselTransactions";
            this.Controls.SetChildIndex(this.ucVesselTransactions1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCVesselTransactions ucVesselTransactions1;
    }
}