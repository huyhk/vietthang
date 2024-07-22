namespace VNS.ERP.GUI.KCS
{
    partial class FormEditTechnicalTestReturn
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
            this.ucTechnicalTestReturn1 = new UCTechnicalTestReturn();
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
            // ucTechnicalTestReturn1
            // 
            this.ucTechnicalTestReturn1.Business = null;
            this.ucTechnicalTestReturn1.DataSource = null;
            this.ucTechnicalTestReturn1.Department = VNS.ERP.Data.enumKCSDepartment.PTN;
            this.ucTechnicalTestReturn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTechnicalTestReturn1.Location = new System.Drawing.Point(0, 42);
            this.ucTechnicalTestReturn1.Name = "ucTechnicalTestReturn1";
            this.ucTechnicalTestReturn1.Size = new System.Drawing.Size(880, 549);
            this.ucTechnicalTestReturn1.TabIndex = 5;
            // 
            // FormEditTechnicalTestReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(880, 614);
            this.Controls.Add(this.ucTechnicalTestReturn1);
            this.EditControl = this.ucTechnicalTestReturn1;
            this.Name = "FormEditTechnicalTestReturn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.ucTechnicalTestReturn1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTechnicalTestReturn ucTechnicalTestReturn1;
    }
}
