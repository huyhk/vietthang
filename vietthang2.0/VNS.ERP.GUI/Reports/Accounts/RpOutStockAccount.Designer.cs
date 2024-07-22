namespace VNS.ERP.GUI
{
    partial class RpOutStockAccount
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
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.cellSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.celItemName = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDVT = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellSLYC = new DevExpress.XtraReports.UI.XRTableCell();
            this.celSLTXN = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellDGia = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellThanhTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.txtLyDo = new DevExpress.XtraReports.UI.XRLabel();
            this.txtNguoiGiaoNhan = new DevExpress.XtraReports.UI.XRLabel();
            this.txtPTVC = new DevExpress.XtraReports.UI.XRLabel();
            this.txtNguoiVC = new DevExpress.XtraReports.UI.XRLabel();
            this.txtKho = new DevExpress.XtraReports.UI.XRLabel();
            this.txtDonVi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbThang = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNam = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.txtSoPhieu = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.lblNgaybt = new DevExpress.XtraReports.UI.XRLabel();
            this.lblNambt = new DevExpress.XtraReports.UI.XRLabel();
            this.lblThangbt = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBangchu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalYC = new DevExpress.XtraReports.UI.XRTableCell();
            this.celTotalSLTXN = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.cellTotalThanhTien = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Height = 25;
            this.Detail.Name = "Detail";
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable1
            // 
            this.xrTable1.Location = new System.Drawing.Point(4, 0);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.ParentStyleUsing.UseBorders = false;
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.Size = new System.Drawing.Size(767, 22);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.cellSTT,
            this.celItemName,
            this.cellDVT,
            this.cellSLYC,
            this.celSLTXN,
            this.cellDGia,
            this.cellThanhTien});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Size = new System.Drawing.Size(767, 22);
            // 
            // cellSTT
            // 
            this.cellSTT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellSTT.Location = new System.Drawing.Point(0, 0);
            this.cellSTT.Name = "cellSTT";
            this.cellSTT.ParentStyleUsing.UseFont = false;
            this.cellSTT.Size = new System.Drawing.Size(38, 22);
            this.cellSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.cellSTT.Visible = false;
            // 
            // celItemName
            // 
            this.celItemName.CanGrow = false;
            this.celItemName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celItemName.ForeColor = System.Drawing.Color.Black;
            this.celItemName.Location = new System.Drawing.Point(38, 0);
            this.celItemName.Name = "celItemName";
            this.celItemName.ParentStyleUsing.UseFont = false;
            this.celItemName.ParentStyleUsing.UseForeColor = false;
            this.celItemName.Size = new System.Drawing.Size(208, 22);
            this.celItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cellDVT
            // 
            this.cellDVT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDVT.Location = new System.Drawing.Point(246, 0);
            this.cellDVT.Name = "cellDVT";
            this.cellDVT.ParentStyleUsing.UseFont = false;
            this.cellDVT.Size = new System.Drawing.Size(50, 22);
            this.cellDVT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellSLYC
            // 
            this.cellSLYC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellSLYC.Location = new System.Drawing.Point(296, 0);
            this.cellSLYC.Name = "cellSLYC";
            this.cellSLYC.ParentStyleUsing.UseFont = false;
            this.cellSLYC.Size = new System.Drawing.Size(92, 22);
            this.cellSLYC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.cellSLYC.TextChanged += new System.EventHandler(this.cellSLYC_TextChanged);
            // 
            // celSLTXN
            // 
            this.celSLTXN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celSLTXN.ForeColor = System.Drawing.Color.Black;
            this.celSLTXN.Location = new System.Drawing.Point(388, 0);
            this.celSLTXN.Name = "celSLTXN";
            this.celSLTXN.ParentStyleUsing.UseFont = false;
            this.celSLTXN.ParentStyleUsing.UseForeColor = false;
            this.celSLTXN.Size = new System.Drawing.Size(99, 22);
            this.celSLTXN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.celSLTXN.TextChanged += new System.EventHandler(this.celSLTXN_TextChanged);
            // 
            // cellDGia
            // 
            this.cellDGia.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellDGia.Location = new System.Drawing.Point(487, 0);
            this.cellDGia.Name = "cellDGia";
            this.cellDGia.ParentStyleUsing.UseFont = false;
            this.cellDGia.Size = new System.Drawing.Size(169, 22);
            this.cellDGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellThanhTien
            // 
            this.cellThanhTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellThanhTien.ForeColor = System.Drawing.Color.Black;
            this.cellThanhTien.Location = new System.Drawing.Point(656, 0);
            this.cellThanhTien.Name = "cellThanhTien";
            this.cellThanhTien.ParentStyleUsing.UseFont = false;
            this.cellThanhTien.ParentStyleUsing.UseForeColor = false;
            this.cellThanhTien.Size = new System.Drawing.Size(111, 22);
            this.cellThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
            this.PageHeader.Height = 25;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Location = new System.Drawing.Point(17, 0);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Size = new System.Drawing.Size(700, 25);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.txtLyDo,
            this.txtNguoiGiaoNhan,
            this.txtPTVC,
            this.txtNguoiVC,
            this.txtKho,
            this.txtDonVi,
            this.lbThang,
            this.lbNam,
            this.lbNgay,
            this.txtSoPhieu});
            this.ReportHeader.Height = 174;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDo.Location = new System.Drawing.Point(100, 123);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.ParentStyleUsing.UseBorders = false;
            this.txtLyDo.ParentStyleUsing.UseFont = false;
            this.txtLyDo.Size = new System.Drawing.Size(275, 22);
            this.txtLyDo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // txtNguoiGiaoNhan
            // 
            this.txtNguoiGiaoNhan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGiaoNhan.Location = new System.Drawing.Point(167, 71);
            this.txtNguoiGiaoNhan.Name = "txtNguoiGiaoNhan";
            this.txtNguoiGiaoNhan.ParentStyleUsing.UseBorders = false;
            this.txtNguoiGiaoNhan.ParentStyleUsing.UseFont = false;
            this.txtNguoiGiaoNhan.Size = new System.Drawing.Size(217, 22);
            this.txtNguoiGiaoNhan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // txtPTVC
            // 
            this.txtPTVC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTVC.Location = new System.Drawing.Point(183, 95);
            this.txtPTVC.Name = "txtPTVC";
            this.txtPTVC.ParentStyleUsing.UseBorders = false;
            this.txtPTVC.ParentStyleUsing.UseFont = false;
            this.txtPTVC.Size = new System.Drawing.Size(192, 22);
            this.txtPTVC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // txtNguoiVC
            // 
            this.txtNguoiVC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiVC.Location = new System.Drawing.Point(508, 95);
            this.txtNguoiVC.Name = "txtNguoiVC";
            this.txtNguoiVC.ParentStyleUsing.UseBorders = false;
            this.txtNguoiVC.ParentStyleUsing.UseFont = false;
            this.txtNguoiVC.Size = new System.Drawing.Size(250, 22);
            this.txtNguoiVC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // txtKho
            // 
            this.txtKho.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKho.Location = new System.Drawing.Point(475, 123);
            this.txtKho.Name = "txtKho";
            this.txtKho.ParentStyleUsing.UseBorders = false;
            this.txtKho.ParentStyleUsing.UseFont = false;
            this.txtKho.Size = new System.Drawing.Size(276, 22);
            this.txtKho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(442, 71);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ParentStyleUsing.UseBorders = false;
            this.txtDonVi.ParentStyleUsing.UseFont = false;
            this.txtDonVi.Size = new System.Drawing.Size(325, 22);
            this.txtDonVi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // lbThang
            // 
            this.lbThang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(420, 31);
            this.lbThang.Name = "lbThang";
            this.lbThang.ParentStyleUsing.UseFont = false;
            this.lbThang.Size = new System.Drawing.Size(40, 25);
            this.lbThang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbNam
            // 
            this.lbNam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNam.Location = new System.Drawing.Point(492, 31);
            this.lbNam.Name = "lbNam";
            this.lbNam.ParentStyleUsing.UseFont = false;
            this.lbNam.Size = new System.Drawing.Size(40, 25);
            this.lbNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbNgay
            // 
            this.lbNgay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.Location = new System.Drawing.Point(350, 31);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.ParentStyleUsing.UseFont = false;
            this.lbNgay.Size = new System.Drawing.Size(40, 25);
            this.lbNgay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoPhieu.Location = new System.Drawing.Point(625, 7);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ParentStyleUsing.UseFont = false;
            this.txtSoPhieu.Size = new System.Drawing.Size(150, 25);
            this.txtSoPhieu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblNgaybt,
            this.lblNambt,
            this.lblThangbt,
            this.lblBangchu,
            this.xrLabel7,
            this.xrTable2});
            this.ReportFooter.Name = "ReportFooter";
            // 
            // lblNgaybt
            // 
            this.lblNgaybt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaybt.Location = new System.Drawing.Point(533, 65);
            this.lblNgaybt.Name = "lblNgaybt";
            this.lblNgaybt.ParentStyleUsing.UseFont = false;
            this.lblNgaybt.Size = new System.Drawing.Size(40, 25);
            this.lblNgaybt.Text = "lblNgaybt";
            this.lblNgaybt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblNambt
            // 
            this.lblNambt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNambt.Location = new System.Drawing.Point(675, 65);
            this.lblNambt.Name = "lblNambt";
            this.lblNambt.ParentStyleUsing.UseFont = false;
            this.lblNambt.Size = new System.Drawing.Size(40, 25);
            this.lblNambt.Text = "lblNambt";
            this.lblNambt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblThangbt
            // 
            this.lblThangbt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThangbt.Location = new System.Drawing.Point(604, 65);
            this.lblThangbt.Name = "lblThangbt";
            this.lblThangbt.ParentStyleUsing.UseFont = false;
            this.lblThangbt.Size = new System.Drawing.Size(40, 25);
            this.lblThangbt.Text = "lblThangbt";
            this.lblThangbt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblBangchu
            // 
            this.lblBangchu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBangchu.Location = new System.Drawing.Point(117, 33);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.ParentStyleUsing.UseBorders = false;
            this.lblBangchu.ParentStyleUsing.UseFont = false;
            this.lblBangchu.Size = new System.Drawing.Size(650, 25);
            this.lblBangchu.Text = "bnnnnnnnnnnnnnn";
            this.lblBangchu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.Location = new System.Drawing.Point(8, 27);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.ParentStyleUsing.UseFont = false;
            this.xrLabel7.Size = new System.Drawing.Size(84, 25);
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            // 
            // xrTable2
            // 
            this.xrTable2.Location = new System.Drawing.Point(4, 0);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.ParentStyleUsing.UseBorders = false;
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.Size = new System.Drawing.Size(767, 25);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.cellTotalYC,
            this.celTotalSLTXN,
            this.xrTableCell6,
            this.cellTotalThanhTien});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Size = new System.Drawing.Size(767, 25);
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.ForeColor = System.Drawing.Color.Black;
            this.xrTableCell2.Location = new System.Drawing.Point(0, 0);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.ParentStyleUsing.UseFont = false;
            this.xrTableCell2.ParentStyleUsing.UseForeColor = false;
            this.xrTableCell2.Size = new System.Drawing.Size(296, 25);
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cellTotalYC
            // 
            this.cellTotalYC.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalYC.Location = new System.Drawing.Point(296, 0);
            this.cellTotalYC.Name = "cellTotalYC";
            this.cellTotalYC.ParentStyleUsing.UseFont = false;
            this.cellTotalYC.Size = new System.Drawing.Size(92, 25);
            xrSummary1.FormatString = "{0:#,##0.#0}";
            this.cellTotalYC.Summary = xrSummary1;
            this.cellTotalYC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // celTotalSLTXN
            // 
            this.celTotalSLTXN.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTotalSLTXN.ForeColor = System.Drawing.Color.Black;
            this.celTotalSLTXN.Location = new System.Drawing.Point(388, 0);
            this.celTotalSLTXN.Name = "celTotalSLTXN";
            this.celTotalSLTXN.ParentStyleUsing.UseFont = false;
            this.celTotalSLTXN.ParentStyleUsing.UseForeColor = false;
            this.celTotalSLTXN.Size = new System.Drawing.Size(99, 25);
            xrSummary2.FormatString = "{0:#,##0.#0}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.celTotalSLTXN.Summary = xrSummary2;
            this.celTotalSLTXN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell6.Location = new System.Drawing.Point(487, 0);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.ParentStyleUsing.UseFont = false;
            this.xrTableCell6.Size = new System.Drawing.Size(173, 25);
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // cellTotalThanhTien
            // 
            this.cellTotalThanhTien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTotalThanhTien.ForeColor = System.Drawing.Color.Black;
            this.cellTotalThanhTien.Location = new System.Drawing.Point(660, 0);
            this.cellTotalThanhTien.Name = "cellTotalThanhTien";
            this.cellTotalThanhTien.ParentStyleUsing.UseFont = false;
            this.cellTotalThanhTien.ParentStyleUsing.UseForeColor = false;
            this.cellTotalThanhTien.Size = new System.Drawing.Size(107, 25);
            xrSummary3.FormatString = "{0:n0}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.cellTotalThanhTien.Summary = xrSummary3;
            this.cellTotalThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RpOutStockAccount
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader,
            this.ReportHeader,
            this.ReportFooter});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(30, 21, 9, 23);
            this.PageHeight = 827;
            this.PageWidth = 583;
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbThang;
        private DevExpress.XtraReports.UI.XRLabel lbNam;
        private DevExpress.XtraReports.UI.XRLabel lbNgay;
        private DevExpress.XtraReports.UI.XRLabel txtSoPhieu;
        private DevExpress.XtraReports.UI.XRLabel txtLyDo;
        private DevExpress.XtraReports.UI.XRLabel txtNguoiGiaoNhan;
        private DevExpress.XtraReports.UI.XRLabel txtPTVC;
        private DevExpress.XtraReports.UI.XRLabel txtNguoiVC;
        private DevExpress.XtraReports.UI.XRLabel txtKho;
        private DevExpress.XtraReports.UI.XRLabel txtDonVi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell cellSTT;
        private DevExpress.XtraReports.UI.XRTableCell celItemName;
        private DevExpress.XtraReports.UI.XRTableCell cellDVT;
        private DevExpress.XtraReports.UI.XRTableCell cellSLYC;
        private DevExpress.XtraReports.UI.XRTableCell celSLTXN;
        private DevExpress.XtraReports.UI.XRTableCell cellDGia;
        private DevExpress.XtraReports.UI.XRTableCell cellThanhTien;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalYC;
        private DevExpress.XtraReports.UI.XRTableCell celTotalSLTXN;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell cellTotalThanhTien;
        private DevExpress.XtraReports.UI.XRLabel lblBangchu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel lblNgaybt;
        private DevExpress.XtraReports.UI.XRLabel lblNambt;
        private DevExpress.XtraReports.UI.XRLabel lblThangbt;
    }
}
