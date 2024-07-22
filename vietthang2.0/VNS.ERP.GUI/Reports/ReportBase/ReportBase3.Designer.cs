namespace VNS.ERP.GUI
{
    partial class ReportBase3
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lbYear = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lbYear,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.TopMargin.Height = 105;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2;
            this.xrLine1.Location = new System.Drawing.Point(4, 94);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.Size = new System.Drawing.Size(792, 9);
            // 
            // lbYear
            // 
            this.lbYear.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(7, 83);
            this.lbYear.Name = "lbYear";
            this.lbYear.ParentStyleUsing.UseFont = false;
            this.lbYear.Size = new System.Drawing.Size(575, 16);
            this.lbYear.Text = "Cho năm tài chính kết thúc ngày 31 tháng 12 năm 2006";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.Location = new System.Drawing.Point(7, 67);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.ParentStyleUsing.UseFont = false;
            this.xrLabel3.Size = new System.Drawing.Size(575, 16);
            this.xrLabel3.Text = "BÁO CÁO TÀI CHÍNH";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Location = new System.Drawing.Point(7, 50);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Size = new System.Drawing.Size(575, 17);
            this.xrLabel2.Text = "Địa chỉ: Lô 4 - 2, Khu C, Khu công nghiệp Sa Đéc, xã Tân Quy Đông, thị xã Sa Đéc," +
                " tỉnh Đồng Tháp";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.Location = new System.Drawing.Point(7, 25);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.ParentStyleUsing.UseFont = false;
            this.xrLabel1.Size = new System.Drawing.Size(450, 25);
            this.xrLabel1.Text = "CÔNG TY CỔ PHẦN THUỶ SẢN VIỆT THẮNG";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4});
            this.BottomMargin.Height = 41;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.Location = new System.Drawing.Point(7, 0);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.ParentStyleUsing.UseFont = false;
            this.xrLabel4.Size = new System.Drawing.Size(409, 17);
            this.xrLabel4.Text = "Báo cáo này phải được đọc cùng với bản thuyết minh báo cáo tài chính";
            // 
            // ReportBase2
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(23, 27, 105, 41);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        //private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lbYear;
    }
}
