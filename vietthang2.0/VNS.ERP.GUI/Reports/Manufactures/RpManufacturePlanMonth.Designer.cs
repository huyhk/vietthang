namespace VNS.ERP.GUI
{
    partial class RpManufacturePlanMonth
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
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellItemCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellItemName = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.cellStockName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.cellMonthNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.cellYearNo = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBaobi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSanxuat = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKhovan = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNoinhan = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.cellYearNo,
            this.xrLabel6,
            this.cellMonthNo,
            this.xrLabel4,
            this.cellStockName,
            this.xrLabel1,
            this.xrLabel3});
            this.ReportHeader.Height = 75;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.Height = 25;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.Location = new System.Drawing.Point(1, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.ParentStyleUsing.UseBorders = false;
            this.xrTable2.ParentStyleUsing.UseFont = false;
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(783, 25);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellItemCode,
            this.cellItemName,
            this.cellQuantity,
            this.cellDescription});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(783, 25);
            // 
            // cellItemCode
            // 
            this.cellItemCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellItemCode.Location = new System.Drawing.Point(0, 0);
            this.cellItemCode.Name = "cellItemCode";
            this.cellItemCode.ParentStyleUsing.UseFont = false;
            this.cellItemCode.Size = new System.Drawing.Size(100, 25);
            this.cellItemCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.cellItemCode.AfterPrint += new System.EventHandler(this.cellItemCode_AfterPrint);
            this.cellItemCode.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.cellItemCode_BeforePrint);
            // 
            // cellItemName
            // 
            this.cellItemName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellItemName.Location = new System.Drawing.Point(100, 0);
            this.cellItemName.Name = "cellItemName";
            this.cellItemName.ParentStyleUsing.UseFont = false;
            this.cellItemName.Size = new System.Drawing.Size(183, 25);
            this.cellItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellQuantity
            // 
            this.cellQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellQuantity.Location = new System.Drawing.Point(283, 0);
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.ParentStyleUsing.UseFont = false;
            this.cellQuantity.Size = new System.Drawing.Size(100, 25);
            xrSummary3.FormatString = "{0:n2}";
            this.cellQuantity.Summary = xrSummary3;
            this.cellQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellDescription
            // 
            this.cellDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDescription.Location = new System.Drawing.Point(383, 0);
            this.cellDescription.Name = "cellDescription";
            this.cellDescription.ParentStyleUsing.UseFont = false;
            this.cellDescription.Size = new System.Drawing.Size(400, 25);
            this.cellDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.Height = 25;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.Location = new System.Drawing.Point(1, 0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.ParentStyleUsing.UseBorders = false;
            this.xrTable1.ParentStyleUsing.UseFont = false;
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(783, 25);
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell5,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(783, 25);
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell4.Text = "Mã TP";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Location = new System.Drawing.Point(100, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Size = new System.Drawing.Size(183, 25);
            this.xrTableCell1.Text = "Tên TP";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Location = new System.Drawing.Point(283, 0);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell5.Text = "Số lượng";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Location = new System.Drawing.Point(383, 0);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Size = new System.Drawing.Size(400, 25);
            this.xrTableCell3.Text = "Ghi chú";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(183, 0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(392, 42);
            this.xrLabel3.Text = "KẾ HOẠCH SẢN XUẤT";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.Location = new System.Drawing.Point(175, 50);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(109, 25);
            this.xrLabel1.Text = "NHÀ MÁY:";
            // 
            // cellStockName
            // 
            this.cellStockName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellStockName.Location = new System.Drawing.Point(283, 50);
            this.cellStockName.Name = "cellStockName";
            this.cellStockName.ParentStyleUsing.UseFont = false;
            this.cellStockName.Size = new System.Drawing.Size(116, 25);
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(408, 50);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(84, 25);
            this.xrLabel4.Text = "THÁNG:";
            // 
            // cellMonthNo
            // 
            this.cellMonthNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMonthNo.Location = new System.Drawing.Point(492, 48);
            this.cellMonthNo.Name = "cellMonthNo";
            this.cellMonthNo.ParentStyleUsing.UseFont = false;
            this.cellMonthNo.Size = new System.Drawing.Size(34, 25);
            this.cellMonthNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.Location = new System.Drawing.Point(525, 44);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.Size = new System.Drawing.Size(13, 25);
            this.xrLabel6.Text = "/";
            // 
            // cellYearNo
            // 
            this.cellYearNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellYearNo.Location = new System.Drawing.Point(533, 48);
            this.cellYearNo.Name = "cellYearNo";
            this.cellYearNo.ParentStyleUsing.UseFont = false;
            this.cellYearNo.Size = new System.Drawing.Size(74, 25);
            this.cellYearNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.lblBaobi,
            this.lblSanxuat,
            this.lblKhovan,
            this.lblNoinhan,
            this.xrTable3});
            this.ReportFooter.Height = 176;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.Location = new System.Drawing.Point(0, 25);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.ParentStyleUsing.UseFont = false;
            this.xrLabel8.Size = new System.Drawing.Size(209, 25);
            this.xrLabel8.Text = "NGƯỜI LẬP KẾ HOẠCH";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblBaobi
            // 
            this.lblBaobi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaobi.Location = new System.Drawing.Point(617, 100);
            this.lblBaobi.Name = "lblBaobi";
            this.lblBaobi.ParentStyleUsing.UseFont = false;
            this.lblBaobi.Size = new System.Drawing.Size(167, 25);
            this.lblBaobi.Text = "BAO BÌ";
            this.lblBaobi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblSanxuat
            // 
            this.lblSanxuat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanxuat.Location = new System.Drawing.Point(617, 75);
            this.lblSanxuat.Name = "lblSanxuat";
            this.lblSanxuat.ParentStyleUsing.UseFont = false;
            this.lblSanxuat.Size = new System.Drawing.Size(167, 25);
            this.lblSanxuat.Text = "SẢN XUẤT";
            this.lblSanxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblKhovan
            // 
            this.lblKhovan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhovan.Location = new System.Drawing.Point(617, 50);
            this.lblKhovan.Name = "lblKhovan";
            this.lblKhovan.ParentStyleUsing.UseFont = false;
            this.lblKhovan.Size = new System.Drawing.Size(167, 25);
            this.lblKhovan.Text = "KHO VẬN";
            this.lblKhovan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblNoinhan
            // 
            this.lblNoinhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoinhan.Location = new System.Drawing.Point(617, 25);
            this.lblNoinhan.Name = "lblNoinhan";
            this.lblNoinhan.ParentStyleUsing.UseFont = false;
            this.lblNoinhan.Size = new System.Drawing.Size(167, 25);
            this.lblNoinhan.Text = "NƠI NHẬN KẾ HOẠCH:";
            this.lblNoinhan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable3.Location = new System.Drawing.Point(1, 0);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.ParentStyleUsing.UseBorders = false;
            this.xrTable3.ParentStyleUsing.UseFont = false;
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.Size = new System.Drawing.Size(783, 25);
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.cellTotalQuantity,
            this.xrTableCell9});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Size = new System.Drawing.Size(783, 25);
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell6.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.ParentStyleUsing.UseFont = false;
            this.xrTableCell6.Size = new System.Drawing.Size(283, 25);
            this.xrTableCell6.Text = "Tổng cộng";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellTotalQuantity
            // 
            this.cellTotalQuantity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalQuantity.Location = new System.Drawing.Point(283, 0);
            this.cellTotalQuantity.Name = "cellTotalQuantity";
            this.cellTotalQuantity.ParentStyleUsing.UseFont = false;
            this.cellTotalQuantity.Size = new System.Drawing.Size(100, 25);
            xrSummary4.FormatString = "{0:n0}";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalQuantity.Summary = xrSummary4;
            this.cellTotalQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Location = new System.Drawing.Point(383, 0);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.ParentStyleUsing.UseFont = false;
            this.xrTableCell9.Size = new System.Drawing.Size(400, 25);
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel2.Location = new System.Drawing.Point(683, 50);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.ParentStyleUsing.UseFont = false;
            this.xrLabel2.Size = new System.Drawing.Size(100, 25);
            this.xrLabel2.Text = "ĐVT: Kg";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RpManufacturePlanMonth
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 39, 40);
            this.PageHeight = 1299;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Plus;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel cellYearNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel cellMonthNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel cellStockName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellItemCode;
        private DevExpress.XtraReports.UI.XRTableCell cellQuantity;
        private DevExpress.XtraReports.UI.XRTableCell cellDescription;
        private DevExpress.XtraReports.UI.XRTableCell cellItemName;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalQuantity;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel lblBaobi;
        private DevExpress.XtraReports.UI.XRLabel lblSanxuat;
        private DevExpress.XtraReports.UI.XRLabel lblKhovan;
        private DevExpress.XtraReports.UI.XRLabel lblNoinhan;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
