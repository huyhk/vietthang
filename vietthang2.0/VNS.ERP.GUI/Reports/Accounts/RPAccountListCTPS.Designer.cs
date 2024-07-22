namespace VNS.ERP.GUI.Reports.Accounts
{
    partial class RPAccountListCTPS
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.subreport1 = new DevExpress.XtraReports.UI.Subreport();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.rpAccountCTPS1 = new VNS.ERP.GUI.RPAccountCTPS();
            ((System.ComponentModel.ISupportInitialize)(this.rpAccountCTPS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.subreport1});
            this.Detail.Height = 33;
            this.Detail.Name = "Detail";
            // 
            // subreport1
            // 
            this.subreport1.Location = new System.Drawing.Point(0, 0);
            this.subreport1.Name = "subreport1";
            this.subreport1.ReportSource = this.rpAccountCTPS1;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            // 
            // RPAccountListCTPS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            ((System.ComponentModel.ISupportInitialize)(this.rpAccountCTPS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.Subreport subreport1;
        private RPAccountCTPS rpAccountCTPS1;
    }
}
