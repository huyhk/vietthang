namespace VNS.ERP.GUI
{
    partial class ReportBusinessResult
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
            DevExpress.XtraReports.UI.XRControlStyle xrControlStyle3 = new DevExpress.XtraReports.UI.XRControlStyle();
            DevExpress.XtraReports.UI.XRControlStyle xrControlStyle4 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellRowCode = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellThuyetMinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellPreAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbCaptionAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lbCaptionPreAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPeriodText = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine5,
            this.xrLine4,
            this.xrTable2});
            this.Detail.Height = 33;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrLine5
            // 
            this.xrLine5.Location = new System.Drawing.Point(658, 0);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.Size = new System.Drawing.Size(138, 8);
            this.xrLine5.Visible = false;
            // 
            // xrLine4
            // 
            this.xrLine4.Location = new System.Drawing.Point(479, 0);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.Size = new System.Drawing.Size(142, 8);
            this.xrLine4.Visible = false;
            // 
            // xrTable2
            // 
            this.xrTable2.Location = new System.Drawing.Point(4, 8);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(792, 25);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellDescription,
            this.cellRowCode,
            this.cellThuyetMinh,
            this.cellAmount,
            this.xrTableCell12,
            this.cellPreAmount});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(792, 25);
            // 
            // cellDescription
            // 
            this.cellDescription.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDescription.Location = new System.Drawing.Point(0, 0);
            this.cellDescription.Name = "cellDescription";
            this.cellDescription.ParentStyleUsing.UseFont = false;
            this.cellDescription.Size = new System.Drawing.Size(367, 25);
            this.cellDescription.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellRowCode
            // 
            this.cellRowCode.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellRowCode.Location = new System.Drawing.Point(367, 0);
            this.cellRowCode.Multiline = true;
            this.cellRowCode.Name = "cellRowCode";
            this.cellRowCode.ParentStyleUsing.UseFont = false;
            this.cellRowCode.Size = new System.Drawing.Size(50, 25);
            this.cellRowCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellThuyetMinh
            // 
            this.cellThuyetMinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellThuyetMinh.Location = new System.Drawing.Point(417, 0);
            this.cellThuyetMinh.Multiline = true;
            this.cellThuyetMinh.Name = "cellThuyetMinh";
            this.cellThuyetMinh.ParentStyleUsing.UseFont = false;
            this.cellThuyetMinh.Size = new System.Drawing.Size(58, 25);
            this.cellThuyetMinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellAmount
            // 
            this.cellAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellAmount.Location = new System.Drawing.Point(475, 0);
            this.cellAmount.Name = "cellAmount";
            this.cellAmount.ParentStyleUsing.UseBorders = false;
            this.cellAmount.ParentStyleUsing.UseFont = false;
            this.cellAmount.Size = new System.Drawing.Size(142, 25);
            this.cellAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Location = new System.Drawing.Point(617, 0);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Size = new System.Drawing.Size(37, 25);
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellPreAmount
            // 
            this.cellPreAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellPreAmount.Location = new System.Drawing.Point(654, 0);
            this.cellPreAmount.Name = "cellPreAmount";
            this.cellPreAmount.ParentStyleUsing.UseBorders = false;
            this.cellPreAmount.ParentStyleUsing.UseFont = false;
            this.cellPreAmount.Size = new System.Drawing.Size(138, 25);
            this.cellPreAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.Height = 33;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Location = new System.Drawing.Point(4, 0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(792, 33);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.lbCaptionAmount,
            this.xrTableCell11,
            this.lbCaptionPreAmount});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(792, 33);
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.ParentStyleUsing.UseFont = false;
            this.xrTableCell1.Size = new System.Drawing.Size(367, 33);
            this.xrTableCell1.Text = "CHỈ TIÊU";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.Location = new System.Drawing.Point(367, 0);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.ParentStyleUsing.UseFont = false;
            this.xrTableCell2.Size = new System.Drawing.Size(50, 33);
            this.xrTableCell2.Text = "Mã\r\nsố";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.Location = new System.Drawing.Point(417, 0);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.ParentStyleUsing.UseFont = false;
            this.xrTableCell4.Size = new System.Drawing.Size(58, 33);
            this.xrTableCell4.Text = "Thuyết\r\nminh";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbCaptionAmount
            // 
            this.lbCaptionAmount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCaptionAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaptionAmount.Location = new System.Drawing.Point(475, 0);
            this.lbCaptionAmount.Name = "lbCaptionAmount";
            this.lbCaptionAmount.ParentStyleUsing.UseBorders = false;
            this.lbCaptionAmount.ParentStyleUsing.UseFont = false;
            this.lbCaptionAmount.Size = new System.Drawing.Size(142, 33);
            this.lbCaptionAmount.Text = "Năm nay";
            this.lbCaptionAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Location = new System.Drawing.Point(617, 0);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Size = new System.Drawing.Size(37, 33);
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // lbCaptionPreAmount
            // 
            this.lbCaptionPreAmount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.lbCaptionPreAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaptionPreAmount.Location = new System.Drawing.Point(654, 0);
            this.lbCaptionPreAmount.Name = "lbCaptionPreAmount";
            this.lbCaptionPreAmount.ParentStyleUsing.UseBorders = false;
            this.lbCaptionPreAmount.ParentStyleUsing.UseFont = false;
            this.lbCaptionPreAmount.Size = new System.Drawing.Size(138, 33);
            this.lbCaptionPreAmount.Text = "Năm trước";
            this.lbCaptionPreAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 17;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(8, 8);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(775, 25);
            this.xrLabel4.Text = "BÁO CÁO KẾT QUẢ HOẠT ĐỘNG KINH DOANH";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbPeriodText
            // 
            this.lbPeriodText.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriodText.Location = new System.Drawing.Point(8, 33);
            this.lbPeriodText.Name = "lbPeriodText";
            this.lbPeriodText.ParentStyleUsing.UseFont = false;
            this.lbPeriodText.Size = new System.Drawing.Size(775, 25);
            this.lbPeriodText.Text = "Năm 2006";
            this.lbPeriodText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.lbPeriodText,
            this.xrLabel4});
            this.ReportHeader.Height = 92;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Location = new System.Drawing.Point(667, 67);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Size = new System.Drawing.Size(116, 25);
            this.xrLabel6.Text = "Đơn vị tính: VND";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrLine2,
            this.xrLabel7});
            this.ReportFooter.Height = 44;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLine3
            // 
            this.xrLine3.Location = new System.Drawing.Point(479, 0);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.Size = new System.Drawing.Size(142, 8);
            // 
            // xrLine2
            // 
            this.xrLine2.Location = new System.Drawing.Point(658, 0);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.Size = new System.Drawing.Size(138, 8);
            // 
            // xrLabel7
            // 
            this.xrLabel7.Location = new System.Drawing.Point(567, 17);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Size = new System.Drawing.Size(225, 25);
            this.xrLabel7.Text = "Ngày ......... tháng ......... năm ...............";
            // 
            // ReportBusinessResult
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.PageFooter,
            this.ReportHeader,
            this.ReportFooter});
            this.Margins = new System.Drawing.Printing.Margins(23, 27, 105, 25);
            xrControlStyle3.BackColor = System.Drawing.Color.Transparent;
            xrControlStyle4.BackColor = System.Drawing.Color.Transparent;
            this.StyleSheet.Add("Style1", xrControlStyle3);
            this.StyleSheet.Add("Style2", xrControlStyle4);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel lbPeriodText;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell lbCaptionAmount;
        private DevExpress.XtraReports.UI.XRTableCell lbCaptionPreAmount;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell cellDescription;
        private DevExpress.XtraReports.UI.XRTableCell cellRowCode;
        private DevExpress.XtraReports.UI.XRTableCell cellThuyetMinh;
        private DevExpress.XtraReports.UI.XRTableCell cellAmount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell cellPreAmount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
    }
}
