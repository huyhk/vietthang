namespace VNS.ERP.GUI.KCS
{
    partial class FormEditTestRequestReturn
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
            this.ucTestRequestReturn1 = new UCTestRequestReturn();
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
            // ucTestRequestReturn1
            // 
            this.ucTestRequestReturn1.Business = null;
            this.ucTestRequestReturn1.DataSource = null;
            this.ucTestRequestReturn1.Department = VNS.ERP.Data.enumKCSDepartment.QLCL;
            this.ucTestRequestReturn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTestRequestReturn1.Location = new System.Drawing.Point(0, 42);
            this.ucTestRequestReturn1.Name = "ucTestRequestReturn1";
            this.ucTestRequestReturn1.Size = new System.Drawing.Size(833, 495);
            this.ucTestRequestReturn1.TabIndex = 5;
            // 
            // FormEditTestRequestReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 560);
            this.Controls.Add(this.ucTestRequestReturn1);
            this.EditControl = this.ucTestRequestReturn1;
            this.Name = "FormEditTestRequestReturn";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.ucTestRequestReturn1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTestRequestReturn ucTestRequestReturn1;
    }
}
