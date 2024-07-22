namespace VNS.ERP.GUI
{
    partial class RpDiscountDetail
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
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellInvoiceNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellSaleRequestDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellInvoiceAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDiscountAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.captionDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.captionDiscount2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtEndDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtStartDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustomerCode = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustomerName = new DevExpress.XtraReports.UI.XRLabel();
            this.txtCustomerName1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalInvoiceAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalDiscountAmount = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtCustomerName1,
            this.txtCustomerName,
            this.txtCustomerCode,
            this.xrLabel1,
            this.xrLabel3,
            this.xrLabel5,
            this.txtStartDate,
            this.xrLabel7,
            this.txtEndDate});
            this.ReportHeader.Height = 114;
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
            this.xrTable2.Location = new System.Drawing.Point(7, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.ParentStyleUsing.UseBorders = false;
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellInvoiceNo,
            this.cellSaleRequestDate,
            this.cellInvoiceAmount,
            this.cellDiscount,
            this.cellDiscountAmount});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(750, 25);
            // 
            // cellInvoiceNo
            // 
            this.cellInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellInvoiceNo.Location = new System.Drawing.Point(0, 0);
            this.cellInvoiceNo.Name = "cellInvoiceNo";
            this.cellInvoiceNo.ParentStyleUsing.UseFont = false;
            this.cellInvoiceNo.Size = new System.Drawing.Size(100, 25);
            this.cellInvoiceNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellSaleRequestDate
            // 
            this.cellSaleRequestDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellSaleRequestDate.Location = new System.Drawing.Point(100, 0);
            this.cellSaleRequestDate.Name = "cellSaleRequestDate";
            this.cellSaleRequestDate.ParentStyleUsing.UseFont = false;
            this.cellSaleRequestDate.Size = new System.Drawing.Size(106, 25);
            this.cellSaleRequestDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellInvoiceAmount
            // 
            this.cellInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellInvoiceAmount.Location = new System.Drawing.Point(206, 0);
            this.cellInvoiceAmount.Name = "cellInvoiceAmount";
            this.cellInvoiceAmount.ParentStyleUsing.UseFont = false;
            this.cellInvoiceAmount.Size = new System.Drawing.Size(175, 25);
            this.cellInvoiceAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellDiscount
            // 
            this.cellDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDiscount.Location = new System.Drawing.Point(381, 0);
            this.cellDiscount.Name = "cellDiscount";
            this.cellDiscount.ParentStyleUsing.UseFont = false;
            this.cellDiscount.Size = new System.Drawing.Size(179, 25);
            this.cellDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellDiscountAmount
            // 
            this.cellDiscountAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDiscountAmount.Location = new System.Drawing.Point(560, 0);
            this.cellDiscountAmount.Name = "cellDiscountAmount";
            this.cellDiscountAmount.ParentStyleUsing.UseFont = false;
            this.cellDiscountAmount.Size = new System.Drawing.Size(190, 25);
            this.cellDiscountAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.xrTable1.Location = new System.Drawing.Point(7, 0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.ParentStyleUsing.UseBorders = false;
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell3,
            this.captionDiscount,
            this.captionDiscount2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.ParentStyleUsing.UseFont = false;
            this.xrTableCell4.Size = new System.Drawing.Size(100, 25);
            this.xrTableCell4.Text = "Số hoá đơn";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Location = new System.Drawing.Point(100, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.ParentStyleUsing.UseFont = false;
            this.xrTableCell1.Size = new System.Drawing.Size(106, 25);
            this.xrTableCell1.Text = "Ngày hoá đơn";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell3.Location = new System.Drawing.Point(206, 0);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.ParentStyleUsing.UseFont = false;
            this.xrTableCell3.Size = new System.Drawing.Size(175, 25);
            this.xrTableCell3.Text = "Tiền hoá đơn";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // captionDiscount
            // 
            this.captionDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionDiscount.Location = new System.Drawing.Point(381, 0);
            this.captionDiscount.Name = "captionDiscount";
            this.captionDiscount.ParentStyleUsing.UseFont = false;
            this.captionDiscount.Size = new System.Drawing.Size(179, 25);
            this.captionDiscount.Text = "Chiết khấu quý/năm";
            this.captionDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // captionDiscount2
            // 
            this.captionDiscount2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionDiscount2.Location = new System.Drawing.Point(560, 0);
            this.captionDiscount2.Name = "captionDiscount2";
            this.captionDiscount2.ParentStyleUsing.UseFont = false;
            this.captionDiscount2.Size = new System.Drawing.Size(190, 25);
            this.captionDiscount2.Text = "Tiền chiết khấu";
            this.captionDiscount2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(442, 85);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ParentStyleUsing.UseFont = false;
            this.txtEndDate.Size = new System.Drawing.Size(117, 25);
            this.txtEndDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.Location = new System.Drawing.Point(367, 89);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(75, 25);
            this.xrLabel7.Text = "Đến ngày";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(250, 85);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ParentStyleUsing.UseFont = false;
            this.txtStartDate.Size = new System.Drawing.Size(117, 25);
            this.txtStartDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.Location = new System.Drawing.Point(183, 89);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.ParentStyleUsing.UseFont = false;
            this.xrLabel5.Size = new System.Drawing.Size(66, 25);
            this.xrLabel5.Text = "Từ ngày";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(92, 0);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(667, 50);
            this.xrLabel3.Text = "BÁO CÁO CHIẾT KHẤU KHÁCH HÀNG";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.Location = new System.Drawing.Point(183, 58);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(75, 25);
            this.xrLabel1.Text = "Mã KH:";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.Location = new System.Drawing.Point(258, 58);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ParentStyleUsing.UseFont = false;
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 25);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(442, 58);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ParentStyleUsing.UseFont = false;
            this.txtCustomerName.Size = new System.Drawing.Size(300, 25);
            // 
            // txtCustomerName1
            // 
            this.txtCustomerName1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName1.Location = new System.Drawing.Point(367, 58);
            this.txtCustomerName1.Name = "txtCustomerName1";
            this.txtCustomerName1.ParentStyleUsing.UseFont = false;
            this.txtCustomerName1.Size = new System.Drawing.Size(75, 25);
            this.txtCustomerName1.Text = "Tên KH:";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrTable3});
            this.ReportFooter.Height = 119;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.Location = new System.Drawing.Point(567, 31);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.ParentStyleUsing.UseFont = false;
            this.xrLabel11.Size = new System.Drawing.Size(75, 25);
            this.xrLabel11.Text = "Người lập";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Location = new System.Drawing.Point(7, 0);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.ParentStyleUsing.UseBorders = false;
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.cellTotalInvoiceAmount,
            this.cellTotalDiscount,
            this.cellTotalDiscountAmount});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell5.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.ParentStyleUsing.UseFont = false;
            this.xrTableCell5.Size = new System.Drawing.Size(206, 25);
            this.xrTableCell5.Text = "Tổng cộng";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellTotalInvoiceAmount
            // 
            this.cellTotalInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalInvoiceAmount.Location = new System.Drawing.Point(206, 0);
            this.cellTotalInvoiceAmount.Name = "cellTotalInvoiceAmount";
            this.cellTotalInvoiceAmount.ParentStyleUsing.UseFont = false;
            this.cellTotalInvoiceAmount.Size = new System.Drawing.Size(175, 25);
            xrSummary1.FormatString = "{0:n2}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalInvoiceAmount.Summary = xrSummary1;
            this.cellTotalInvoiceAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellTotalDiscount
            // 
            this.cellTotalDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalDiscount.Location = new System.Drawing.Point(381, 0);
            this.cellTotalDiscount.Name = "cellTotalDiscount";
            this.cellTotalDiscount.ParentStyleUsing.UseFont = false;
            this.cellTotalDiscount.Size = new System.Drawing.Size(179, 25);
            this.cellTotalDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellTotalDiscountAmount
            // 
            this.cellTotalDiscountAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalDiscountAmount.Location = new System.Drawing.Point(560, 0);
            this.cellTotalDiscountAmount.Name = "cellTotalDiscountAmount";
            this.cellTotalDiscountAmount.ParentStyleUsing.UseFont = false;
            this.cellTotalDiscountAmount.Size = new System.Drawing.Size(190, 25);
            xrSummary2.FormatString = "{0:n2}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalDiscountAmount.Summary = xrSummary2;
            this.cellTotalDiscountAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RpDiscountDetail
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(31, 31, 31, 31);
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel txtStartDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel txtEndDate;
        private DevExpress.XtraReports.UI.XRLabel txtCustomerName1;
        private DevExpress.XtraReports.UI.XRLabel txtCustomerName;
        private DevExpress.XtraReports.UI.XRLabel txtCustomerCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellInvoiceNo;
        private DevExpress.XtraReports.UI.XRTableCell cellSaleRequestDate;
        private DevExpress.XtraReports.UI.XRTableCell cellInvoiceAmount;
        private DevExpress.XtraReports.UI.XRTableCell cellDiscount;
        private DevExpress.XtraReports.UI.XRTableCell cellDiscountAmount;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell captionDiscount;
        private DevExpress.XtraReports.UI.XRTableCell captionDiscount2;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalInvoiceAmount;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalDiscount;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalDiscountAmount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
    }
}
