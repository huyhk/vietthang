namespace VNS.ERP.GUI.Transports
{
    partial class FormEditVesselExchangeContract
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
            this.ucVesselExchangeContract1 = new UCVesselExchangeContract();
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
            // ucVesselExchangeContract1
            // 
            this.ucVesselExchangeContract1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVesselExchangeContract1.Business = null;
            this.ucVesselExchangeContract1.DataSource = null;
            this.ucVesselExchangeContract1.Location = new System.Drawing.Point(6, 45);
            this.ucVesselExchangeContract1.Name = "ucVesselExchangeContract1";
            this.ucVesselExchangeContract1.Size = new System.Drawing.Size(748, 400);
            this.ucVesselExchangeContract1.TabIndex = 5;
            // 
            // FormEditVesselExchangeContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 474);
            this.Controls.Add(this.ucVesselExchangeContract1);
            this.EditControl = this.ucVesselExchangeContract1;
            this.Name = "FormEditVesselExchangeContract";
            this.Text = "FormEditUCVesselExchangeContract";
            this.Controls.SetChildIndex(this.ucVesselExchangeContract1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCVesselExchangeContract ucVesselExchangeContract1;
    }
}