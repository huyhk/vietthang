namespace VNS.ERP.GUI
{
    partial class RpSaleInvoice
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
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellItemName = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbPaymentType = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAccountNo = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTaxCode = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNam = new DevExpress.XtraReports.UI.XRLabel();
            this.lbThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lbTotalAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.lbReadAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTaxRate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.cellTotalAmount1 = new DevExpress.XtraReports.UI.XRLabel();
            this.cellThueGTGT = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable2.Location = new System.Drawing.Point(11, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.ParentStyleUsing.UseBorders = false;
            this.xrTable2.ParentStyleUsing.UseFont = false;
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(734, 25);
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellSTT,
            this.cellItemName,
            this.cellDVT,
            this.cellQuantity,
            this.cellPrice,
            this.cellAmount});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(734, 25);
            // 
            // cellSTT
            // 
            this.cellSTT.Location = new System.Drawing.Point(0, 0);
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.Size = new System.Drawing.Size(49, 25);
            this.cellSTT.Text = "1";
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellItemName
            // 
            this.cellItemName.Location = new System.Drawing.Point(49, 0);
            this.cellItemName.Name = "cellItemName";
            this.cellItemName.Size = new System.Drawing.Size(231, 25);
            this.cellItemName.Text = "VT5-3.0LY-28%";
            this.cellItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellDVT
            // 
            this.cellDVT.Location = new System.Drawing.Point(280, 0);
            this.cellDVT.Name = "cellDVT";
            this.cellDVT.Size = new System.Drawing.Size(70, 25);
            this.cellDVT.Text = "Kg";
            this.cellDVT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellQuantity
            // 
            this.cellQuantity.Location = new System.Drawing.Point(350, 0);
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.Size = new System.Drawing.Size(95, 25);
            this.cellQuantity.Text = "200";
            this.cellQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellPrice
            // 
            this.cellPrice.Location = new System.Drawing.Point(445, 0);
            this.cellPrice.Name = "cellPrice";
            this.cellPrice.Size = new System.Drawing.Size(116, 25);
            this.cellPrice.Text = "200,000.95";
            this.cellPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellAmount
            // 
            this.cellAmount.Location = new System.Drawing.Point(561, 0);
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.Size = new System.Drawing.Size(173, 25);
            this.cellAmount.Text = "400,000";
            this.cellAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbPaymentType,
            this.xrLabel12,
            this.lbAccountNo,
            this.xrLabel10,
            this.lbTaxCode,
            this.xrLabel8,
            this.lbAddress,
            this.xrLabel6,
            this.lbCustomer,
            this.xrLabel4,
            this.lbNam,
            this.lbThang,
            this.lbNgay});
            this.ReportHeader.Height = 400;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbPaymentType
            // 
            this.lbPaymentType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentType.Location = new System.Drawing.Point(173, 333);
            this.lbPaymentType.Name = "lbPaymentType";
            this.lbPaymentType.ParentStyleUsing.UseFont = false;
            this.lbPaymentType.Size = new System.Drawing.Size(567, 25);
            this.lbPaymentType.Text = "CK";
            this.lbPaymentType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.Location = new System.Drawing.Point(4, 333);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.ParentStyleUsing.UseFont = false;
            this.xrLabel12.Size = new System.Drawing.Size(166, 25);
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbAccountNo
            // 
            this.lbAccountNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountNo.Location = new System.Drawing.Point(100, 305);
            this.lbAccountNo.Name = "lbAccountNo";
            this.lbAccountNo.ParentStyleUsing.UseFont = false;
            this.lbAccountNo.Size = new System.Drawing.Size(633, 25);
            this.lbAccountNo.Text = "0000000000000";
            this.lbAccountNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel10.Location = new System.Drawing.Point(4, 300);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.ParentStyleUsing.UseFont = false;
            this.xrLabel10.Size = new System.Drawing.Size(91, 25);
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTaxCode
            // 
            this.lbTaxCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxCode.Location = new System.Drawing.Point(100, 278);
            this.lbTaxCode.Name = "lbTaxCode";
            this.lbTaxCode.ParentStyleUsing.UseFont = false;
            this.lbTaxCode.Size = new System.Drawing.Size(633, 25);
            this.lbTaxCode.Text = "0000000000000";
            this.lbTaxCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel8.Location = new System.Drawing.Point(4, 275);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.ParentStyleUsing.UseFont = false;
            this.xrLabel8.Size = new System.Drawing.Size(91, 25);
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(75, 250);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.ParentStyleUsing.UseFont = false;
            this.lbAddress.Size = new System.Drawing.Size(658, 25);
            this.lbAddress.Text = "Gò vấp, TPHCM";
            this.lbAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel6.Location = new System.Drawing.Point(4, 250);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.ParentStyleUsing.UseFont = false;
            this.xrLabel6.Size = new System.Drawing.Size(66, 25);
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(142, 225);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.ParentStyleUsing.UseFont = false;
            this.lbCustomer.Size = new System.Drawing.Size(591, 25);
            this.lbCustomer.Text = "Bán lẻ";
            this.lbCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(4, 225);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(133, 25);
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbNam
            // 
            this.lbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(471, 192);
            this.lbNam.Name = "lbNam";
            this.lbNam.ParentStyleUsing.UseFont = false;
            this.lbNam.Size = new System.Drawing.Size(40, 25);
            this.lbNam.Text = "2007";
            this.lbNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbThang
            // 
            this.lbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(390, 192);
            this.lbThang.Name = "lbThang";
            this.lbThang.ParentStyleUsing.UseFont = false;
            this.lbThang.Size = new System.Drawing.Size(40, 25);
            this.lbThang.Text = "4";
            this.lbThang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbNgay
            // 
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(315, 192);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.ParentStyleUsing.UseFont = false;
            this.lbNgay.Size = new System.Drawing.Size(40, 25);
            this.lbNgay.Text = "28";
            this.lbNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbTotalAmount,
            this.lbReadAmount,
            this.xrLabel19,
            this.lbTaxRate,
            this.xrLabel16,
            this.cellTotalAmount1,
            this.cellThueGTGT});
            this.ReportFooter.Height = 139;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.Location = new System.Drawing.Point(575, 0);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.ParentStyleUsing.UseBorders = false;
            this.lbTotalAmount.ParentStyleUsing.UseFont = false;
            this.lbTotalAmount.Size = new System.Drawing.Size(170, 25);
            this.lbTotalAmount.Text = "190,000,000VNĐ";
            this.lbTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lbReadAmount
            // 
            this.lbReadAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReadAmount.Location = new System.Drawing.Point(133, 90);
            this.lbReadAmount.Name = "lbReadAmount";
            this.lbReadAmount.ParentStyleUsing.UseFont = false;
            this.lbReadAmount.Size = new System.Drawing.Size(621, 30);
            this.lbReadAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel19.Location = new System.Drawing.Point(4, 92);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.ParentStyleUsing.UseFont = false;
            this.xrLabel19.Size = new System.Drawing.Size(92, 25);
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTaxRate
            // 
            this.lbTaxRate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxRate.Location = new System.Drawing.Point(142, 27);
            this.lbTaxRate.Name = "lbTaxRate";
            this.lbTaxRate.ParentStyleUsing.UseFont = false;
            this.lbTaxRate.Size = new System.Drawing.Size(62, 25);
            this.lbTaxRate.Text = "5";
            this.lbTaxRate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.Location = new System.Drawing.Point(4, 25);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.ParentStyleUsing.UseFont = false;
            this.xrLabel16.Size = new System.Drawing.Size(133, 25);
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellTotalAmount1
            // 
            this.cellTotalAmount1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalAmount1.Location = new System.Drawing.Point(575, 50);
            this.cellTotalAmount1.Name = "cellTotalAmount1";
            this.cellTotalAmount1.ParentStyleUsing.UseBorders = false;
            this.cellTotalAmount1.ParentStyleUsing.UseFont = false;
            this.cellTotalAmount1.Size = new System.Drawing.Size(170, 26);
            this.cellTotalAmount1.Text = "200,000VNĐ";
            this.cellTotalAmount1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // cellThueGTGT
            // 
            this.cellThueGTGT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellThueGTGT.Location = new System.Drawing.Point(575, 20);
            this.cellThueGTGT.Name = "cellThueGTGT";
            this.cellThueGTGT.ParentStyleUsing.UseBorders = false;
            this.cellThueGTGT.ParentStyleUsing.UseFont = false;
            this.cellThueGTGT.Size = new System.Drawing.Size(170, 25);
            this.cellThueGTGT.Text = "500,000VNĐ";
            this.cellThueGTGT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 25;
            this.PageHeader.Name = "PageHeader";
            // 
            // RpSaleInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(48, 45, 54, 28);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbNgay;
        private DevExpress.XtraReports.UI.XRLabel lbNam;
        private DevExpress.XtraReports.UI.XRLabel lbThang;
        private DevExpress.XtraReports.UI.XRLabel lbCustomer;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel lbAddress;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel lbPaymentType;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel lbAccountNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel lbTaxCode;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTableCell cellItemName;
        private DevExpress.XtraReports.UI.XRTableCell cellDVT;
        private DevExpress.XtraReports.UI.XRTableCell cellQuantity;
        private DevExpress.XtraReports.UI.XRTableCell cellPrice;
        private DevExpress.XtraReports.UI.XRTableCell cellAmount;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel cellTotalAmount1;
        private DevExpress.XtraReports.UI.XRLabel cellThueGTGT;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel lbTaxRate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel lbReadAmount;
        private DevExpress.XtraReports.UI.XRLabel lbTotalAmount;
    }
}
