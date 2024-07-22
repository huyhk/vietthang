namespace VNS.ERP.GUI.Transports
{
    partial class FormEditTransportCompensationPrice
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
            this.ucTransportCompensationPrice1 = new VNS.ERP.GUI.Transports.UCTransportCompensationPrice();
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
            // ucTransportCompensationPrice1
            // 
            this.ucTransportCompensationPrice1.Business = null;
            this.ucTransportCompensationPrice1.DataSource = null;
            this.ucTransportCompensationPrice1.Location = new System.Drawing.Point(107, 54);
            this.ucTransportCompensationPrice1.Name = "ucTransportCompensationPrice1";
            this.ucTransportCompensationPrice1.Size = new System.Drawing.Size(525, 54);
            this.ucTransportCompensationPrice1.TabIndex = 5;
            // 
            // FormEditTransportCompensationPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(757, 147);
            this.Controls.Add(this.ucTransportCompensationPrice1);
            this.EditControl = this.ucTransportCompensationPrice1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(763, 179);
            this.MinimumSize = new System.Drawing.Size(763, 179);
            this.Name = "FormEditTransportCompensationPrice";
            this.Text = "FormEditTransportCompensationPrice";
            this.Controls.SetChildIndex(this.ucTransportCompensationPrice1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.Transports.UCTransportCompensationPrice ucTransportCompensationPrice1;
    }
}
