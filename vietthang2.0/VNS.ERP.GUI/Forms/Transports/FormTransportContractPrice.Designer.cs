namespace VNS.ERP.GUI.Transports
{
    partial class FormTransportContractPrice
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
            this.ucTransportContractPrice1 = new VNS.ERP.GUI.Transports.UCTransportContractPrice();
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
            // ucTransportContractPrice1
            // 
            this.ucTransportContractPrice1.Business = null;
            this.ucTransportContractPrice1.ContractID = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.ucTransportContractPrice1.DataSource = null;
            this.ucTransportContractPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTransportContractPrice1.Location = new System.Drawing.Point(0, 42);
            this.ucTransportContractPrice1.Name = "ucTransportContractPrice1";
            this.ucTransportContractPrice1.Size = new System.Drawing.Size(833, 436);
            this.ucTransportContractPrice1.TabIndex = 5;
            // 
            // FormTransportContractPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 501);
            this.Controls.Add(this.ucTransportContractPrice1);
            this.EditControl = this.ucTransportContractPrice1;
            this.Name = "FormTransportContractPrice";
            this.Text = "FormTransportContractPrice";
            this.Controls.SetChildIndex(this.ucTransportContractPrice1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.Transports.UCTransportContractPrice ucTransportContractPrice1;
    }
}
