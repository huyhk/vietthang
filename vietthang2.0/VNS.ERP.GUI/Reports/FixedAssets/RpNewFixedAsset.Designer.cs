namespace VNS.ERP.GUI
{
    partial class RpNewFixedAsset
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrFixedAssetName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTangtrongky = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSumTangtrongky = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.Height = 23;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Location = new System.Drawing.Point(508, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(559, 23);
            this.xrTable2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTable2_BeforePrint);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrFixedAssetName,
            this.xrTangtrongky});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(559, 23);
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.ParentStyleUsing.UseBorders = false;
            this.xrTableCell2.Size = new System.Drawing.Size(33, 23);
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrFixedAssetName
            // 
            this.xrFixedAssetName.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrFixedAssetName.Location = new System.Drawing.Point(33, 0);
            this.xrFixedAssetName.Name = "xrFixedAssetName";
            this.xrFixedAssetName.ParentStyleUsing.UseBorders = false;
            this.xrFixedAssetName.Size = new System.Drawing.Size(368, 23);
            this.xrFixedAssetName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTangtrongky
            // 
            this.xrTangtrongky.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTangtrongky.Location = new System.Drawing.Point(401, 0);
            this.xrTangtrongky.Name = "xrTangtrongky";
            this.xrTangtrongky.ParentStyleUsing.UseBorders = false;
            this.xrTangtrongky.Size = new System.Drawing.Size(158, 23);
            this.xrTangtrongky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 23;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.Visible = false;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportHeader.Height = 23;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTable1.Location = new System.Drawing.Point(508, 0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.ParentStyleUsing.UseBorders = false;
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(559, 23);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrSumTangtrongky});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(559, 23);
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.ParentStyleUsing.UseBorders = false;
            this.xrTableCell1.ParentStyleUsing.UseFont = false;
            this.xrTableCell1.Size = new System.Drawing.Size(401, 23);
            this.xrTableCell1.Text = "Tổng nguyên giá TSCĐ tăng trong tháng";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrSumTangtrongky
            // 
            this.xrSumTangtrongky.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrSumTangtrongky.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrSumTangtrongky.Location = new System.Drawing.Point(401, 0);
            this.xrSumTangtrongky.Name = "xrSumTangtrongky";
            this.xrSumTangtrongky.ParentStyleUsing.UseBorders = false;
            this.xrSumTangtrongky.ParentStyleUsing.UseFont = false;
            this.xrSumTangtrongky.Size = new System.Drawing.Size(158, 23);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrSumTangtrongky.Summary = xrSummary1;
            this.xrSumTangtrongky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RpNewFixedAsset
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.ReportHeader});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(30, 30, 30, 34);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrFixedAssetName;
        private DevExpress.XtraReports.UI.XRTableCell xrTangtrongky;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrSumTangtrongky;
    }
}
