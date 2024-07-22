namespace VNS.ERP.GUI
{
    partial class RpSaleOutNB
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
            this.lblPTVC = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNguoiVC = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKhoxuat = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNam = new DevExpress.XtraReports.UI.XRLabel();
            this.lbThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lbTotalAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotalQuantity = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblKhonhap = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.xrTableCell1,
            this.cellPrice,
            this.cellAmount});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(734, 25);
            // 
            // cellSTT
            // 
            this.cellSTT.Location = new System.Drawing.Point(0, 0);
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.Size = new System.Drawing.Size(25, 25);
            this.cellSTT.Text = "1";
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellItemName
            // 
            this.cellItemName.Location = new System.Drawing.Point(25, 0);
            this.cellItemName.Name = "cellItemName";
            this.cellItemName.Size = new System.Drawing.Size(345, 25);
            this.cellItemName.Text = "VT5-3.0LY-28%";
            this.cellItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellDVT
            // 
            this.cellDVT.Location = new System.Drawing.Point(370, 0);
            this.cellDVT.Name = "cellDVT";
            this.cellDVT.Size = new System.Drawing.Size(54, 25);
            this.cellDVT.Text = "Kg";
            this.cellDVT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellQuantity
            // 
            this.cellQuantity.Location = new System.Drawing.Point(424, 0);
            this.cellQuantity.Name = "cellQuantity";
            this.cellQuantity.Size = new System.Drawing.Size(61, 25);
            this.cellQuantity.Text = "200";
            this.cellQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellPrice
            // 
            this.cellPrice.Location = new System.Drawing.Point(531, 0);
            this.cellPrice.Name = "cellPrice";
            this.cellPrice.Size = new System.Drawing.Size(85, 25);
            this.cellPrice.Text = "200,000.95";
            this.cellPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellAmount
            // 
            this.cellAmount.Location = new System.Drawing.Point(616, 0);
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.Size = new System.Drawing.Size(118, 25);
            this.cellAmount.Text = "400,000";
            this.cellAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblKhonhap,
            this.lblPTVC,
            this.lblNguoiVC,
            this.lblKhoxuat,
            this.lbNam,
            this.lbThang,
            this.lbNgay});
            this.ReportHeader.Height = 428;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblPTVC
            // 
            this.lblPTVC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPTVC.Location = new System.Drawing.Point(273, 283);
            this.lblPTVC.Name = "lblPTVC";
            this.lblPTVC.ParentStyleUsing.UseFont = false;
            this.lblPTVC.Size = new System.Drawing.Size(294, 23);
            this.lblPTVC.Text = "lblPTVC";
            // 
            // lblNguoiVC
            // 
            this.lblNguoiVC.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblNguoiVC.Location = new System.Drawing.Point(271, 260);
            this.lblNguoiVC.Name = "lblNguoiVC";
            this.lblNguoiVC.ParentStyleUsing.UseFont = false;
            this.lblNguoiVC.Size = new System.Drawing.Size(477, 23);
            this.lblNguoiVC.Text = "lblNguoiVC";
            // 
            // lblKhoxuat
            // 
            this.lblKhoxuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoxuat.Location = new System.Drawing.Point(200, 310);
            this.lblKhoxuat.Name = "lblKhoxuat";
            this.lblKhoxuat.ParentStyleUsing.UseFont = false;
            this.lblKhoxuat.Size = new System.Drawing.Size(529, 25);
            this.lblKhoxuat.Text = "Bán lẻ";
            this.lblKhoxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbNam
            // 
            this.lbNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(450, 175);
            this.lbNam.Name = "lbNam";
            this.lbNam.ParentStyleUsing.UseFont = false;
            this.lbNam.Size = new System.Drawing.Size(40, 25);
            this.lbNam.Text = "2007";
            this.lbNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbThang
            // 
            this.lbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(356, 175);
            this.lbThang.Name = "lbThang";
            this.lbThang.ParentStyleUsing.UseFont = false;
            this.lbThang.Size = new System.Drawing.Size(40, 25);
            this.lbThang.Text = "4";
            this.lbThang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbNgay
            // 
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(281, 175);
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
            this.lblTotalQuantity});
            this.ReportFooter.Height = 212;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.KeepTogether = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(627, 4);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.ParentStyleUsing.UseBorders = false;
            this.lbTotalAmount.ParentStyleUsing.UseFont = false;
            this.lbTotalAmount.Size = new System.Drawing.Size(118, 25);
            this.lbTotalAmount.Text = "190,000,000VNĐ";
            this.lbTotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.Location = new System.Drawing.Point(433, 2);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.ParentStyleUsing.UseBorders = false;
            this.lblTotalQuantity.ParentStyleUsing.UseFont = false;
            this.lblTotalQuantity.Size = new System.Drawing.Size(67, 25);
            this.lblTotalQuantity.Text = "500,000VNĐ";
            this.lblTotalQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 37;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Location = new System.Drawing.Point(485, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Size = new System.Drawing.Size(46, 25);
            // 
            // lblKhonhap
            // 
            this.lblKhonhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhonhap.Location = new System.Drawing.Point(200, 342);
            this.lblKhonhap.Name = "lblKhonhap";
            this.lblKhonhap.ParentStyleUsing.UseFont = false;
            this.lblKhonhap.Size = new System.Drawing.Size(529, 25);
            this.lblKhonhap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // RpSaleOutNB
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(48, 46, 51, 28);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbNgay;
        private DevExpress.XtraReports.UI.XRLabel lbNam;
        private DevExpress.XtraReports.UI.XRLabel lbThang;
        private DevExpress.XtraReports.UI.XRLabel lblKhoxuat;
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
        private DevExpress.XtraReports.UI.XRLabel lblTotalQuantity;
        private DevExpress.XtraReports.UI.XRLabel lbTotalAmount;
        private DevExpress.XtraReports.UI.XRLabel lblNguoiVC;
        private DevExpress.XtraReports.UI.XRLabel lblPTVC;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRLabel lblKhonhap;
    }
}
