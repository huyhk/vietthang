namespace VNS.ERP.GUI.Accounting
{
    partial class FormReport_Accounting_Chitietbanhang_KH
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayghiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoChungtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChungtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienGiai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKDU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colItemCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colThanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTienvon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumeric3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLaigop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnRPKhachhang = new DevExpress.XtraEditors.SimpleButton();
            this.btnTonghopExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumeric3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayghiso,
            this.colSoChungtu,
            this.colNgayChungtu,
            this.colDienGiai,
            this.colTKDU,
            this.colSoluong2,
            this.colDongia,
            this.colItemCode1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colNgayghiso
            // 
            this.colNgayghiso.Caption = "Ngày ghi sổ";
            this.colNgayghiso.DisplayFormat.FormatString = "d";
            this.colNgayghiso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayghiso.FieldName = "NgayGhiso";
            this.colNgayghiso.Name = "colNgayghiso";
            this.colNgayghiso.Visible = true;
            this.colNgayghiso.VisibleIndex = 0;
            this.colNgayghiso.Width = 100;
            // 
            // colSoChungtu
            // 
            this.colSoChungtu.Caption = "Số chứng từ";
            this.colSoChungtu.FieldName = "SoChungtu";
            this.colSoChungtu.Name = "colSoChungtu";
            this.colSoChungtu.Visible = true;
            this.colSoChungtu.VisibleIndex = 1;
            this.colSoChungtu.Width = 114;
            // 
            // colNgayChungtu
            // 
            this.colNgayChungtu.Caption = "Ngày chứng từ";
            this.colNgayChungtu.DisplayFormat.FormatString = "d";
            this.colNgayChungtu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayChungtu.FieldName = "NgayChungtu";
            this.colNgayChungtu.Name = "colNgayChungtu";
            this.colNgayChungtu.Visible = true;
            this.colNgayChungtu.VisibleIndex = 2;
            this.colNgayChungtu.Width = 91;
            // 
            // colDienGiai
            // 
            this.colDienGiai.Caption = "Sản phẩm";
            this.colDienGiai.FieldName = "ItemName";
            this.colDienGiai.Name = "colDienGiai";
            this.colDienGiai.Visible = true;
            this.colDienGiai.VisibleIndex = 4;
            this.colDienGiai.Width = 290;
            // 
            // colTKDU
            // 
            this.colTKDU.Caption = "TK đối ứng";
            this.colTKDU.FieldName = "TKDU";
            this.colTKDU.Name = "colTKDU";
            this.colTKDU.Visible = true;
            this.colTKDU.VisibleIndex = 3;
            this.colTKDU.Width = 113;
            // 
            // colSoluong2
            // 
            this.colSoluong2.Caption = "Số lượng";
            this.colSoluong2.ColumnEdit = this.repNumberic6;
            this.colSoluong2.FieldName = "Soluong";
            this.colSoluong2.Name = "colSoluong2";
            this.colSoluong2.Visible = true;
            this.colSoluong2.VisibleIndex = 5;
            this.colSoluong2.Width = 82;
            // 
            // repNumberic6
            // 
            this.repNumberic6.AutoHeight = false;
            this.repNumberic6.Mask.EditMask = "n0";
            this.repNumberic6.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic6.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic6.Name = "repNumberic6";
            // 
            // colDongia
            // 
            this.colDongia.Caption = "Đơn giá";
            this.colDongia.ColumnEdit = this.repNumberic5;
            this.colDongia.FieldName = "Dongia";
            this.colDongia.Name = "colDongia";
            this.colDongia.Visible = true;
            this.colDongia.VisibleIndex = 6;
            this.colDongia.Width = 105;
            // 
            // repNumberic5
            // 
            this.repNumberic5.AutoHeight = false;
            this.repNumberic5.Mask.EditMask = "n2";
            this.repNumberic5.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic5.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic5.Name = "repNumberic5";
            // 
            // colItemCode1
            // 
            this.colItemCode1.Caption = "Mã nguyên liệu";
            this.colItemCode1.FieldName = "ItemCode";
            this.colItemCode1.Name = "colItemCode1";
            this.colItemCode1.Width = 112;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 2);
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "ChildView";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repNumberic,
            this.repNumberic2,
            this.repNumeric3,
            this.repNumberic4,
            this.repNumberic5,
            this.repNumberic6});
            this.gridControl1.Size = new System.Drawing.Size(855, 334);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName,
            this.colItemCode,
            this.colSoluong,
            this.colThanhtien,
            this.colTienvon,
            this.colLaigop});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên khách hàng";
            this.colItemName.FieldName = "SubjectName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 157;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã khách hàng";
            this.colItemCode.FieldName = "SubjectCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 111;
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Số lượng";
            this.colSoluong.ColumnEdit = this.repNumberic;
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.SummaryItem.DisplayFormat = "{0:n0}";
            this.colSoluong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 2;
            this.colSoluong.Width = 116;
            // 
            // repNumberic
            // 
            this.repNumberic.AutoHeight = false;
            this.repNumberic.Mask.EditMask = "n0";
            this.repNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic.Name = "repNumberic";
            // 
            // colThanhtien
            // 
            this.colThanhtien.Caption = "Thành tiền";
            this.colThanhtien.ColumnEdit = this.repNumberic2;
            this.colThanhtien.FieldName = "Thanhtien";
            this.colThanhtien.Name = "colThanhtien";
            this.colThanhtien.SummaryItem.DisplayFormat = "{0:n0}";
            this.colThanhtien.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colThanhtien.Visible = true;
            this.colThanhtien.VisibleIndex = 3;
            this.colThanhtien.Width = 119;
            // 
            // repNumberic2
            // 
            this.repNumberic2.AutoHeight = false;
            this.repNumberic2.Mask.EditMask = "n0";
            this.repNumberic2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic2.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic2.Name = "repNumberic2";
            // 
            // colTienvon
            // 
            this.colTienvon.Caption = "Tiền vốn";
            this.colTienvon.ColumnEdit = this.repNumeric3;
            this.colTienvon.FieldName = "Tienvon";
            this.colTienvon.Name = "colTienvon";
            this.colTienvon.SummaryItem.DisplayFormat = "{0:n0}";
            this.colTienvon.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTienvon.Visible = true;
            this.colTienvon.VisibleIndex = 4;
            this.colTienvon.Width = 128;
            // 
            // repNumeric3
            // 
            this.repNumeric3.AutoHeight = false;
            this.repNumeric3.Mask.EditMask = "n0";
            this.repNumeric3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumeric3.Mask.UseMaskAsDisplayFormat = true;
            this.repNumeric3.Name = "repNumeric3";
            // 
            // colLaigop
            // 
            this.colLaigop.Caption = "Lãi gộp";
            this.colLaigop.ColumnEdit = this.repNumberic4;
            this.colLaigop.FieldName = "Laigop";
            this.colLaigop.Name = "colLaigop";
            this.colLaigop.SummaryItem.DisplayFormat = "{0:n0}";
            this.colLaigop.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLaigop.Visible = true;
            this.colLaigop.VisibleIndex = 5;
            this.colLaigop.Width = 120;
            // 
            // repNumberic4
            // 
            this.repNumberic4.AutoHeight = false;
            this.repNumberic4.Mask.EditMask = "n0";
            this.repNumberic4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic4.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic4.Name = "repNumberic4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 746F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 4);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(497, 62);
            this.ucDatePeriodSelection1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(783, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(618, 2);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(132, 23);
            this.btnExportExcel.TabIndex = 4;
            this.btnExportExcel.Text = "In báo cáo excel chi tiết";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(755, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "In báo cáo chi tiết";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnRPKhachhang);
            this.groupControl1.Controls.Add(this.btnTonghopExcel);
            this.groupControl1.Controls.Add(this.btnExport);
            this.groupControl1.Controls.Add(this.btnExportExcel);
            this.groupControl1.Location = new System.Drawing.Point(2, 416);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(861, 28);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnRPKhachhang
            // 
            this.btnRPKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRPKhachhang.Location = new System.Drawing.Point(278, 2);
            this.btnRPKhachhang.Name = "btnRPKhachhang";
            this.btnRPKhachhang.Size = new System.Drawing.Size(143, 23);
            this.btnRPKhachhang.TabIndex = 6;
            this.btnRPKhachhang.Text = "Báo cáo theo mặt hàng";
            this.btnRPKhachhang.Click += new System.EventHandler(this.btnRPKhachhang_Click);
            // 
            // btnTonghopExcel
            // 
            this.btnTonghopExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTonghopExcel.Location = new System.Drawing.Point(491, 2);
            this.btnTonghopExcel.Name = "btnTonghopExcel";
            this.btnTonghopExcel.Size = new System.Drawing.Size(114, 23);
            this.btnTonghopExcel.TabIndex = 5;
            this.btnTonghopExcel.Text = "Tổng hợp excel";
            this.btnTonghopExcel.Click += new System.EventHandler(this.btnTonghopExcel_Click);
            // 
            // FormReport_Accounting_Chitietbanhang_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 447);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReport_Accounting_Chitietbanhang_KH";
            this.Text = "FormReport_Accounting_Chitietbanhang";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumeric3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhtien;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic2;
        private DevExpress.XtraGrid.Columns.GridColumn colTienvon;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumeric3;
        private DevExpress.XtraGrid.Columns.GridColumn colLaigop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic4;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayghiso;
        private DevExpress.XtraGrid.Columns.GridColumn colSoChungtu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChungtu;
        private DevExpress.XtraGrid.Columns.GridColumn colDienGiai;
        private DevExpress.XtraGrid.Columns.GridColumn colTKDU;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong2;
        private DevExpress.XtraGrid.Columns.GridColumn colDongia;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic6;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode1;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTonghopExcel;
        private DevExpress.XtraEditors.SimpleButton btnRPKhachhang;
    }
}