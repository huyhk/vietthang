namespace VNS.ERP.GUI.KCS
{
    partial class FormEditEncryptCodeSend
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
            this.ucEncryptCodeSend1 = new VNS.ERP.GUI.KCS.UCEncryptCodeSend();
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
            // ucEncryptCodeSend1
            // 
            this.ucEncryptCodeSend1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEncryptCodeSend1.Business = null;
            this.ucEncryptCodeSend1.DataSource = null;
            this.ucEncryptCodeSend1.Location = new System.Drawing.Point(5, 46);
            this.ucEncryptCodeSend1.Name = "ucEncryptCodeSend1";
            this.ucEncryptCodeSend1.Size = new System.Drawing.Size(926, 367);
            this.ucEncryptCodeSend1.SubjectCode = "";
            this.ucEncryptCodeSend1.TabIndex = 5;
            // 
            // FormEditEncryptCodeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(938, 442);
            this.Controls.Add(this.ucEncryptCodeSend1);
            this.EditControl = this.ucEncryptCodeSend1;
            this.Name = "FormEditEncryptCodeSend";
            this.Controls.SetChildIndex(this.ucEncryptCodeSend1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCEncryptCodeSend ucEncryptCodeSend1;
    }
}
