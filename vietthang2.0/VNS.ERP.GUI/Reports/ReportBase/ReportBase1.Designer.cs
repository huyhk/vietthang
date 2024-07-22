namespace VNS.ERP.GUI
{
    partial class ReportBase1
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBase1));
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.picLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.picLogo});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 83);
            this.picLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // ReportBase1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader});
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        //private DevExpress.XtraReports.UI.DetailBand Detail;
        public DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPictureBox picLogo;
    }
}
