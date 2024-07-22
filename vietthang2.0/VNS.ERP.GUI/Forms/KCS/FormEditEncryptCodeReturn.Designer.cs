namespace VNS.ERP.GUI.KCS
{
    partial class FormEditEncryptCodeReturn
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
            this.ucEncryptCodeReturn1 = new UCEncryptCodeReturn();
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
            // ucEncryptCodeReturn1
            // 
            this.ucEncryptCodeReturn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEncryptCodeReturn1.Business = null;
            this.ucEncryptCodeReturn1.DataSource = null;
            this.ucEncryptCodeReturn1.Location = new System.Drawing.Point(5, 41);
            this.ucEncryptCodeReturn1.Name = "ucEncryptCodeReturn1";
            this.ucEncryptCodeReturn1.Size = new System.Drawing.Size(826, 364);
            this.ucEncryptCodeReturn1.SubjectCode = "";
            this.ucEncryptCodeReturn1.TabIndex = 5;
            // 
            // FormEditEncryptCodeReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 434);
            this.Controls.Add(this.ucEncryptCodeReturn1);
            this.EditControl = this.ucEncryptCodeReturn1;
            this.Name = "FormEditEncryptCodeReturn";
            this.Controls.SetChildIndex(this.ucEncryptCodeReturn1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCEncryptCodeReturn ucEncryptCodeReturn1;
    }
}
