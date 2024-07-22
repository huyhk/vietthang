namespace VNS.ERP.GUI.Accounting
{
    partial class FormReportInvoiceInItem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMucThue = new System.Windows.Forms.Label();
            this.txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colTenNguoiBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThueSuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtThueSuat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colThueGTGT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btReport = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.ucSelectBranch1 = new VNS.ERP.GUI.UserControl.UCSelectBranch();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.txtTKKemtheo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtThueSuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKKemtheo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            this.defaultLookAndFeel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // defaultBarAndDocking
            // 
            // 
            // lbMucThue
            // 
            this.lbMucThue.Location = new System.Drawing.Point(3, 90);
            this.lbMucThue.Name = "lbMucThue";
            this.lbMucThue.Size = new System.Drawing.Size(52, 18);
            this.lbMucThue.TabIndex = 9;
            this.lbMucThue.Text = "Mức thuế";
            this.lbMucThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTaxRate.EnterMoveNextControl = true;
            this.txtTaxRate.Location = new System.Drawing.Point(63, 90);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTaxRate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTaxRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxRate.Size = new System.Drawing.Size(70, 20);
            this.txtTaxRate.TabIndex = 0;
            this.txtTaxRate.EditValueChanged += new System.EventHandler(this.txtTaxRate_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 116);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTxtThueSuat,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(933, 378);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKyHieu,
            this.colSoHD,
            this.colNgay,
            this.colTenNguoiBan,
            this.colMSThue,
            this.colMatHang,
            this.colDoanhSo,
            this.colThueSuat,
            this.colThueGTGT,
            this.colGhiChu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Ký hiệu";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 0;
            // 
            // colSoHD
            // 
            this.colSoHD.Caption = "Số HĐ";
            this.colSoHD.FieldName = "SoHD";
            this.colSoHD.Name = "colSoHD";
            this.colSoHD.Visible = true;
            this.colSoHD.VisibleIndex = 1;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.ColumnEdit = this.repositoryItemDateEdit1;
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 2;
            this.colNgay.Width = 80;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colTenNguoiBan
            // 
            this.colTenNguoiBan.Caption = "Tên người bán";
            this.colTenNguoiBan.FieldName = "TenNguoiBan";
            this.colTenNguoiBan.Name = "colTenNguoiBan";
            this.colTenNguoiBan.Visible = true;
            this.colTenNguoiBan.VisibleIndex = 3;
            this.colTenNguoiBan.Width = 214;
            // 
            // colMSThue
            // 
            this.colMSThue.Caption = "MS thuế";
            this.colMSThue.FieldName = "MSThue";
            this.colMSThue.Name = "colMSThue";
            this.colMSThue.Visible = true;
            this.colMSThue.VisibleIndex = 4;
            this.colMSThue.Width = 97;
            // 
            // colMatHang
            // 
            this.colMatHang.Caption = "Mặt hàng";
            this.colMatHang.FieldName = "MatHang";
            this.colMatHang.Name = "colMatHang";
            this.colMatHang.Visible = true;
            this.colMatHang.VisibleIndex = 5;
            this.colMatHang.Width = 149;
            // 
            // colDoanhSo
            // 
            this.colDoanhSo.Caption = "Doanh số";
            this.colDoanhSo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDoanhSo.FieldName = "DoanhSo";
            this.colDoanhSo.Name = "colDoanhSo";
            this.colDoanhSo.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDoanhSo.Visible = true;
            this.colDoanhSo.VisibleIndex = 6;
            this.colDoanhSo.Width = 93;
            // 
            // colThueSuat
            // 
            this.colThueSuat.Caption = "Thuế suất";
            this.colThueSuat.ColumnEdit = this.repTxtThueSuat;
            this.colThueSuat.FieldName = "ThueSuat";
            this.colThueSuat.Name = "colThueSuat";
            this.colThueSuat.Visible = true;
            this.colThueSuat.VisibleIndex = 7;
            this.colThueSuat.Width = 74;
            // 
            // repTxtThueSuat
            // 
            this.repTxtThueSuat.AutoHeight = false;
            this.repTxtThueSuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repTxtThueSuat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtThueSuat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtThueSuat.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtThueSuat.Name = "repTxtThueSuat";
            // 
            // colThueGTGT
            // 
            this.colThueGTGT.Caption = "Thuế GTGT";
            this.colThueGTGT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colThueGTGT.FieldName = "ThueGTGT";
            this.colThueGTGT.Name = "colThueGTGT";
            this.colThueGTGT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colThueGTGT.Visible = true;
            this.colThueGTGT.VisibleIndex = 8;
            this.colThueGTGT.Width = 93;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            this.colGhiChu.Width = 140;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(139, 90);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(67, 20);
            this.btReport.TabIndex = 4;
            this.btReport.Text = "Xem";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.Enabled = false;
            this.btnPrintReport.Location = new System.Drawing.Point(855, 500);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(84, 20);
            this.btnPrintReport.TabIndex = 5;
            this.btnPrintReport.Text = "In báo cáo";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 2);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(418, 85);
            this.ucDatePeriodSelection1.TabIndex = 15;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(this.ucDatePeriodSelection1_OnEditValueChanged);
            // 
            // ucSelectBranch1
            // 
            this.ucSelectBranch1.Location = new System.Drawing.Point(428, 3);
            this.ucSelectBranch1.Name = "ucSelectBranch1";
            this.ucSelectBranch1.Size = new System.Drawing.Size(465, 84);
            this.ucSelectBranch1.TabIndex = 16;
            this.ucSelectBranch1.OnBranchChanged += new VNS.ERP.GUI.UserControl.UCSelectBranch.BranchChanged(this.ucSelectBranch1_OnBranchChanged);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Location = new System.Drawing.Point(722, 500);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(127, 20);
            this.btnExportToExcel.TabIndex = 17;
            this.btnExportToExcel.Text = "Xuất báo cáo ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // txtTKKemtheo
            // 
            this.txtTKKemtheo.EditValue = "";
            this.txtTKKemtheo.EnterMoveNextControl = true;
            this.txtTKKemtheo.Location = new System.Drawing.Point(338, 91);
            this.txtTKKemtheo.Name = "txtTKKemtheo";
            this.txtTKKemtheo.Size = new System.Drawing.Size(70, 20);
            this.txtTKKemtheo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(233, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "TK kèm theo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormReportInvoiceInItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 527);
            this.Controls.Add(this.txtTKKemtheo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.ucSelectBranch1);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.lbMucThue);
            this.Name = "FormReportInvoiceInItem";
            this.Text = "Bảng kê hoá đơn chứng từ hàng hoá dịch vụ mua vào";
            this.Load += new System.EventHandler(this.FormReportInvoiceInItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtThueSuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKKemtheo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbMucThue;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMSThue;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhSo;
        private DevExpress.XtraGrid.Columns.GridColumn colThueSuat;
        private DevExpress.XtraGrid.Columns.GridColumn colThueGTGT;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Button btnPrintReport;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtThueSuat;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private VNS.ERP.GUI.UserControl.UCSelectBranch ucSelectBranch1;
        private System.Windows.Forms.Button btnExportToExcel;
        private DevExpress.XtraEditors.TextEdit txtTKKemtheo;
        private System.Windows.Forms.Label label1;
    }
}