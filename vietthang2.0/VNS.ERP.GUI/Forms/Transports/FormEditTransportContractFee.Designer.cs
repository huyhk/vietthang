namespace VNS.ERP.GUI.Transports
{
    partial class FormEditTransportContractFee
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
            this.ucTransportContractFee1 = new VNS.ERP.GUI.UserControls.Transports.UCTransportContractFee();
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
            // ucTransportContractFee1
            // 
            this.ucTransportContractFee1.ContractID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucTransportContractFee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransportContractFee1.Location = new System.Drawing.Point(0, 42);
            this.ucTransportContractFee1.Name = "ucTransportContractFee1";
            this.ucTransportContractFee1.Size = new System.Drawing.Size(931, 308);
            this.ucTransportContractFee1.TabIndex = 105;
            // 
            // FormEditTransportContractFee
            // 
            this.ClientSize = new System.Drawing.Size(931, 373);
            this.Controls.Add(this.ucTransportContractFee1);
            this.EditControl = this.ucTransportContractFee1;
            this.Name = "FormEditTransportContractFee";
            this.Text = "Form Edit Transport Contract Fee";
            this.Controls.SetChildIndex(this.ucTransportContractFee1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.Transports.UCTransportContractFee ucTransportContractFee1;

    }
}
