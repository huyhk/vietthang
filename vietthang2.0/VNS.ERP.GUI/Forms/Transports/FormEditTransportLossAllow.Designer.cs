namespace VNS.ERP.GUI.Transports
{
    partial class FormEditTransportLossAllow
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
            this.ucTransportLossAllow1 = new VNS.ERP.GUI.Transports.UCTransportLossAllow();
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
            // ucTransportLossAllow1
            // 
            this.ucTransportLossAllow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransportLossAllow1.Location = new System.Drawing.Point(0, 42);
            this.ucTransportLossAllow1.Name = "ucTransportLossAllow1";
            this.ucTransportLossAllow1.Size = new System.Drawing.Size(784, 358);
            this.ucTransportLossAllow1.TabIndex = 105;
            // 
            // FormEditTransportLossAllow
            // 
            this.ClientSize = new System.Drawing.Size(784, 423);
            this.Controls.Add(this.ucTransportLossAllow1);
            this.EditControl = this.ucTransportLossAllow1;
            this.Name = "FormEditTransportLossAllow";
            this.Controls.SetChildIndex(this.ucTransportLossAllow1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTransportLossAllow ucTransportLossAllow1;
    }
}
