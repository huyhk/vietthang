namespace VNS.ERP.GUI.Transports
{
    partial class FormEditTransportContract
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
            this.ucTransportContract1 = new VNS.ERP.GUI.Transports.UCTransportContract();
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
            // ucTransportContract1
            // 
            this.ucTransportContract1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransportContract1.Location = new System.Drawing.Point(0, 42);
            this.ucTransportContract1.Name = "ucTransportContract1";
            this.ucTransportContract1.Size = new System.Drawing.Size(882, 538);
            this.ucTransportContract1.TabIndex = 5;
            // 
            // FormEditTransportContract
            // 
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.ucTransportContract1);
            this.EditControl = this.ucTransportContract1;
            this.Name = "FormEditTransportContract";
            this.Text = "FormEditTransportContract";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.ucTransportContract1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.Transports.UCTransportContract ucTransportContract1;
    }
}
