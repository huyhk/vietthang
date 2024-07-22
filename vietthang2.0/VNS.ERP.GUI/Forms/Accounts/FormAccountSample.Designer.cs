namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountSample
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
            this.ucAccountSample1 = new VNS.ERP.GUI.UserControls.UCAccountSample();
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
            // ucAccountSample1
            // 
            this.ucAccountSample1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAccountSample1.Business = null;
            this.ucAccountSample1.DataSource = null;
            this.ucAccountSample1.Location = new System.Drawing.Point(5, 45);
            this.ucAccountSample1.Name = "ucAccountSample1";
            this.ucAccountSample1.Size = new System.Drawing.Size(907, 471);
            this.ucAccountSample1.TabIndex = 5;
            // 
            // FormAccountSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 545);
            this.Controls.Add(this.ucAccountSample1);
            this.EditControl = this.ucAccountSample1;
            this.Name = "FormAccountSample";
            this.Text = "FormAccountSample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAccountSample_FormClosing);
            this.Controls.SetChildIndex(this.ucAccountSample1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.UCAccountSample ucAccountSample1;
    }
}