namespace VNS.ERP.GUI.Transports
{
    partial class FormEditTCContract
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
            this.uctcContract1 = new VNS.ERP.GUI.UserControls.Transports.UCTCContract();
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
            // uctcContract1
            // 
            this.uctcContract1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctcContract1.Location = new System.Drawing.Point(0, 42);
            this.uctcContract1.Name = "uctcContract1";
            this.uctcContract1.Size = new System.Drawing.Size(791, 727);
            this.uctcContract1.TabIndex = 105;
            // 
            // FormEditTCContract
            // 
            this.ClientSize = new System.Drawing.Size(791, 792);
            this.Controls.Add(this.uctcContract1);
            this.EditControl = this.uctcContract1;
            this.Name = "FormEditTCContract";
            this.Text = "Hợp đồng trung chuyển";
            this.Controls.SetChildIndex(this.uctcContract1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.Transports.UCTCContract uctcContract1;
    }
}
