namespace VNS.ERP.GUI
{
    partial class RpSaleRequestForItemMaster
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
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.subreport2 = new DevExpress.XtraReports.UI.Subreport();
            this.subreport1 = new DevExpress.XtraReports.UI.Subreport();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.rpSaleRequestForItemSub1 = new VNS.ERP.GUI.RpSaleRequestForItemSub();
            this.rpSaleRequestForItemSub2 = new VNS.ERP.GUI.RpSaleRequestForItemSub();
            ((System.ComponentModel.ISupportInitialize)(this.rpSaleRequestForItemSub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpSaleRequestForItemSub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.subreport2,
            this.subreport1});
            this.PageHeader.Height = 144;
            this.PageHeader.Name = "PageHeader";
            // 
            // subreport2
            // 
            this.subreport2.Location = new System.Drawing.Point(0, 111);
            this.subreport2.Name = "subreport2";
            this.subreport2.ReportSource = this.rpSaleRequestForItemSub2;
            // 
            // subreport1
            // 
            this.subreport1.Location = new System.Drawing.Point(0, 0);
            this.subreport1.Name = "subreport1";
            this.subreport1.ReportSource = this.rpSaleRequestForItemSub1;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            // 
            // RpSaleRequestForItemMaster
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ((System.ComponentModel.ISupportInitialize)(this.rpSaleRequestForItemSub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpSaleRequestForItemSub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.Subreport subreport2;
        private DevExpress.XtraReports.UI.Subreport subreport1;
        private RpSaleRequestForItemSub rpSaleRequestForItemSub2;
        private RpSaleRequestForItemSub rpSaleRequestForItemSub1;
    }
}
