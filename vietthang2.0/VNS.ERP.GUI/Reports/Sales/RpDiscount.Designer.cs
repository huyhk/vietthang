namespace VNS.ERP.GUI
{
    partial class RpDiscount
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
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellCustomerCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellCustomerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellInvoiceAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDiscountAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtTotalDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtStartDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.txtEndDate = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.txtProvince = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalInvoiceAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalDiscountAmount = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtEndDate,
            this.xrLabel7,
            this.txtStartDate,
            this.xrLabel5,
            this.xrLabel3});
            this.ReportHeader.Height = 80;
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
            this.xrTable2.Location = new System.Drawing.Point(8, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.ParentStyleUsing.UseBorders = false;
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellCustomerCode,
            this.cellCustomerName,
            this.cellInvoiceAmount,
            this.cellDiscountAmount});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(750, 25);
            // 
            // cellCustomerCode
            // 
            this.cellCustomerCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellCustomerCode.Location = new System.Drawing.Point(0, 0);
            this.cellCustomerCode.Name = "cellCustomerCode";
            this.cellCustomerCode.ParentStyleUsing.UseFont = false;
            this.cellCustomerCode.Size = new System.Drawing.Size(125, 25);
            this.cellCustomerCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellCustomerName
            // 
            this.cellCustomerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellCustomerName.Location = new System.Drawing.Point(125, 0);
            this.cellCustomerName.Name = "cellCustomerName";
            this.cellCustomerName.ParentStyleUsing.UseFont = false;
            this.cellCustomerName.Size = new System.Drawing.Size(242, 25);
            this.cellCustomerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellInvoiceAmount
            // 
            this.cellInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellInvoiceAmount.Location = new System.Drawing.Point(367, 0);
            this.cellInvoiceAmount.Name = "cellInvoiceAmount";
            this.cellInvoiceAmount.ParentStyleUsing.UseFont = false;
            this.cellInvoiceAmount.Size = new System.Drawing.Size(193, 25);
            this.cellInvoiceAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.xrTable1.Location = new System.Drawing.Point(8, 0);
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
            this.xrTableCell2,
            this.txtTotalDiscount});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.ParentStyleUsing.UseFont = false;
            this.xrTableCell4.Size = new System.Drawing.Size(125, 25);
            this.xrTableCell4.Text = "Mã KH";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Location = new System.Drawing.Point(125, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.ParentStyleUsing.UseFont = false;
            this.xrTableCell1.Size = new System.Drawing.Size(242, 25);
            this.xrTableCell1.Text = "Tên KH";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Location = new System.Drawing.Point(367, 0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.ParentStyleUsing.UseFont = false;
            this.xrTableCell2.Size = new System.Drawing.Size(193, 25);
            this.xrTableCell2.Text = "Tổng tiền hoá đơn";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(560, 0);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ParentStyleUsing.UseFont = false;
            this.txtTotalDiscount.Size = new System.Drawing.Size(190, 25);
            this.txtTotalDiscount.Text = "Tổng chiết khấu";
            this.txtTotalDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.Location = new System.Drawing.Point(267, 53);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.ParentStyleUsing.UseFont = false;
            this.xrLabel5.Size = new System.Drawing.Size(66, 25);
            this.xrLabel5.Text = "Từ ngày";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(333, 51);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ParentStyleUsing.UseFont = false;
            this.txtStartDate.Size = new System.Drawing.Size(117, 25);
            this.txtStartDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.Location = new System.Drawing.Point(433, 53);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(75, 25);
            this.xrLabel7.Text = "Đến ngày";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(508, 51);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ParentStyleUsing.UseFont = false;
            this.txtEndDate.Size = new System.Drawing.Size(117, 25);
            this.txtEndDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProvinceName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.Height = 25;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Location = new System.Drawing.Point(8, 0);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.ParentStyleUsing.UseBorders = false;
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtProvince,
            this.xrLabel26});
            this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell9.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.ParentStyleUsing.UseFont = false;
            this.xrTableCell9.Size = new System.Drawing.Size(367, 25);
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(58, 0);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.ParentStyleUsing.UseBorders = false;
            this.txtProvince.ParentStyleUsing.UseFont = false;
            this.txtProvince.Size = new System.Drawing.Size(150, 25);
            this.txtProvince.Scripts.OnSummaryGetResult = "private object OnGetResult(System.Collections.ArrayList accumulatedValues) {\r\n   " +
                " return null;\r\n}\r\n";
            this.txtProvince.Scripts.OnSummaryReset = "private void OnReset() {\r\n}\r\n";
            this.txtProvince.Scripts.OnSummaryRowChanged = "private void OnRowChanged() {\r\n}\r\n";
            //this.txtProvince.Summary = xrSummary4;
            this.txtProvince.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel26.Location = new System.Drawing.Point(8, 0);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.ParentStyleUsing.UseBorders = false;
            this.xrLabel26.ParentStyleUsing.UseFont = false;
            this.xrLabel26.Size = new System.Drawing.Size(50, 25);
            this.xrLabel26.Text = "Tỉnh:";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell11.Location = new System.Drawing.Point(367, 0);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.ParentStyleUsing.UseFont = false;
            this.xrTableCell11.Size = new System.Drawing.Size(193, 25);
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell12.Location = new System.Drawing.Point(560, 0);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.ParentStyleUsing.UseFont = false;
            this.xrTableCell12.Size = new System.Drawing.Size(190, 25);
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrTable4});
            this.ReportFooter.Height = 59;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel11.Location = new System.Drawing.Point(583, 25);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.ParentStyleUsing.UseFont = false;
            this.xrLabel11.Size = new System.Drawing.Size(75, 25);
            this.xrLabel11.Text = "Người lập";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Location = new System.Drawing.Point(8, 0);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.ParentStyleUsing.UseBorders = false;
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.cellTotalInvoiceAmount,
            this.cellTotalDiscountAmount});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Size = new System.Drawing.Size(750, 25);
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell10.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.ParentStyleUsing.UseFont = false;
            this.xrTableCell10.Size = new System.Drawing.Size(367, 25);
            this.xrTableCell10.Text = "Tổng cộng";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellTotalInvoiceAmount
            // 
            this.cellTotalInvoiceAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalInvoiceAmount.Location = new System.Drawing.Point(367, 0);
            this.cellTotalInvoiceAmount.Name = "cellTotalInvoiceAmount";
            this.cellTotalInvoiceAmount.ParentStyleUsing.UseFont = false;
            this.cellTotalInvoiceAmount.Size = new System.Drawing.Size(193, 25);
            xrSummary5.FormatString = "{0:n2}";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalInvoiceAmount.Summary = xrSummary5;
            this.cellTotalInvoiceAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellTotalDiscountAmount
            // 
            this.cellTotalDiscountAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalDiscountAmount.Location = new System.Drawing.Point(560, 0);
            this.cellTotalDiscountAmount.Name = "cellTotalDiscountAmount";
            this.cellTotalDiscountAmount.ParentStyleUsing.UseFont = false;
            this.cellTotalDiscountAmount.Size = new System.Drawing.Size(190, 25);
            xrSummary6.FormatString = "{0:n2}";
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalDiscountAmount.Summary = xrSummary6;
            this.cellTotalDiscountAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RpDiscount
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.GroupHeader1,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(31, 30, 30, 30);
            this.PageHeight = 1299;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4Plus;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel txtEndDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel txtStartDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell txtTotalDiscount;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellCustomerCode;
        private DevExpress.XtraReports.UI.XRTableCell cellCustomerName;
        private DevExpress.XtraReports.UI.XRTableCell cellInvoiceAmount;
        private DevExpress.XtraReports.UI.XRTableCell cellDiscountAmount;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel txtProvince;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalInvoiceAmount;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalDiscountAmount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
    }
}
