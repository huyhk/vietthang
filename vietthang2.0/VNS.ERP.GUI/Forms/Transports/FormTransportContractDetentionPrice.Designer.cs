namespace VNS.ERP.GUI.Transports
{
    partial class FormTransportContractDetentionPrice
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
            this.ucTransportContractDetentionPrice1 = new VNS.ERP.GUI.UserControls.Transports.UCTransportContractDetentionPrice();
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
            // ucTransportContractDetentionPrice1
            // 
            this.ucTransportContractDetentionPrice1.ContractID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucTransportContractDetentionPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransportContractDetentionPrice1.Location = new System.Drawing.Point(0, 42);
            this.ucTransportContractDetentionPrice1.Name = "ucTransportContractDetentionPrice1";
            this.ucTransportContractDetentionPrice1.Size = new System.Drawing.Size(771, 308);
            this.ucTransportContractDetentionPrice1.TabIndex = 105;
            // 
            // FormTransportContractDetentionPrice
            // 
            this.ClientSize = new System.Drawing.Size(771, 373);
            this.Controls.Add(this.ucTransportContractDetentionPrice1);
            this.EditControl = this.ucTransportContractDetentionPrice1;
            this.Name = "FormTransportContractDetentionPrice";
            this.Text = "FormTransportContractDetentionPrice";
            this.Controls.SetChildIndex(this.ucTransportContractDetentionPrice1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.Transports.UCTransportContractDetentionPrice ucTransportContractDetentionPrice1;
    }
}
