namespace VNS.ERP.GUI.Transports
{
    partial class FormRPChiphikhovan
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
            this.txtYear = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).BeginInit();
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
            // txtYear
            // 
            this.txtYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtYear.Location = new System.Drawing.Point(197, 47);
            this.txtYear.Name = "txtYear";
            this.txtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYear.Properties.UseCtrlIncrement = false;
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(126, 130);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "simpleButton1";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(247, 130);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // FormRPChiphikhovan
            // 
            this.ClientSize = new System.Drawing.Size(385, 263);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYear);
            this.Name = "FormRPChiphikhovan";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit txtYear;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
