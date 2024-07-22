namespace VNS.ERP.GUI.Accounting
{
    partial class FormReportAccountStockTransactionQuantity
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
            this.lbAccount = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111NhapMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111NhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111XuatSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111XuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632NhapSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632NhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632XuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632XuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colInvoiceSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnPrintReportDetail = new System.Windows.Forms.Button();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnInTheKho = new System.Windows.Forms.Button();
            this.btnExportStockCardToExcel = new System.Windows.Forms.Button();
            this.lookUpAccountCode = new DevExpress.XtraEditors.LookUpEdit();
            this.chkReportToExcel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAccountCode.Properties)).BeginInit();
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
            // lbAccount
            // 
            this.lbAccount.Location = new System.Drawing.Point(413, 9);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(83, 15);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Chọn tài khoản";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(584, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(91, 24);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(2, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(922, 211);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockName,
            this.colItemCode,
            this.colItemname,
            this.colOpenQuantity,
            this.col6111NhapMua,
            this.col6111NhapKhac,
            this.col6111XuatSX,
            this.col6111XuatKhac,
            this.col632NhapSX,
            this.col632NhapKhac,
            this.col632XuatBan,
            this.col632XuatKhac,
            this.colCloseQuantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 0;
            this.colStockName.Width = 112;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã hàng";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 80;
            // 
            // colItemname
            // 
            this.colItemname.Caption = "Tên hàng";
            this.colItemname.FieldName = "ItemName";
            this.colItemname.Name = "colItemname";
            this.colItemname.Visible = true;
            this.colItemname.VisibleIndex = 2;
            this.colItemname.Width = 162;
            // 
            // colOpenQuantity
            // 
            this.colOpenQuantity.Caption = "Tồn đầu";
            this.colOpenQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpenQuantity.FieldName = "OpenQuantity";
            this.colOpenQuantity.Name = "colOpenQuantity";
            this.colOpenQuantity.Visible = true;
            this.colOpenQuantity.VisibleIndex = 3;
            this.colOpenQuantity.Width = 91;
            // 
            // col6111NhapMua
            // 
            this.col6111NhapMua.Caption = "Nhập mua";
            this.col6111NhapMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111NhapMua.FieldName = "NhapMua";
            this.col6111NhapMua.Name = "col6111NhapMua";
            this.col6111NhapMua.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111NhapMua.Visible = true;
            this.col6111NhapMua.VisibleIndex = 4;
            this.col6111NhapMua.Width = 96;
            // 
            // col6111NhapKhac
            // 
            this.col6111NhapKhac.Caption = "Nhập khác";
            this.col6111NhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111NhapKhac.FieldName = "NhapKhac";
            this.col6111NhapKhac.Name = "col6111NhapKhac";
            this.col6111NhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111NhapKhac.Visible = true;
            this.col6111NhapKhac.VisibleIndex = 5;
            this.col6111NhapKhac.Width = 115;
            // 
            // col6111XuatSX
            // 
            this.col6111XuatSX.Caption = "Xuất SX";
            this.col6111XuatSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111XuatSX.FieldName = "XuatSX";
            this.col6111XuatSX.Name = "col6111XuatSX";
            this.col6111XuatSX.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111XuatSX.Visible = true;
            this.col6111XuatSX.VisibleIndex = 6;
            this.col6111XuatSX.Width = 110;
            // 
            // col6111XuatKhac
            // 
            this.col6111XuatKhac.Caption = "Xuất khác";
            this.col6111XuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111XuatKhac.FieldName = "XuatKhac";
            this.col6111XuatKhac.Name = "col6111XuatKhac";
            this.col6111XuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111XuatKhac.Visible = true;
            this.col6111XuatKhac.VisibleIndex = 7;
            this.col6111XuatKhac.Width = 118;
            // 
            // col632NhapSX
            // 
            this.col632NhapSX.Caption = "Nhập SX";
            this.col632NhapSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632NhapSX.FieldName = "NhapSX";
            this.col632NhapSX.Name = "col632NhapSX";
            this.col632NhapSX.OptionsColumn.ShowInCustomizationForm = false;
            this.col632NhapSX.Width = 109;
            // 
            // col632NhapKhac
            // 
            this.col632NhapKhac.Caption = "Nhập khác";
            this.col632NhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632NhapKhac.FieldName = "NhapKhac";
            this.col632NhapKhac.Name = "col632NhapKhac";
            this.col632NhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col632NhapKhac.Width = 97;
            // 
            // col632XuatBan
            // 
            this.col632XuatBan.Caption = "Xuất bán";
            this.col632XuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632XuatBan.FieldName = "XuatBan";
            this.col632XuatBan.Name = "col632XuatBan";
            this.col632XuatBan.OptionsColumn.ShowInCustomizationForm = false;
            this.col632XuatBan.Width = 98;
            // 
            // col632XuatKhac
            // 
            this.col632XuatKhac.Caption = "Xuất khác";
            this.col632XuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632XuatKhac.FieldName = "XuatKhac";
            this.col632XuatKhac.Name = "col632XuatKhac";
            this.col632XuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col632XuatKhac.Width = 103;
            // 
            // colCloseQuantity
            // 
            this.colCloseQuantity.Caption = "Tồn cuối";
            this.colCloseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseQuantity.FieldName = "CloseQuantity";
            this.colCloseQuantity.Name = "colCloseQuantity";
            this.colCloseQuantity.Visible = true;
            this.colCloseQuantity.VisibleIndex = 8;
            this.colCloseQuantity.Width = 128;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(3, 293);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl2.Size = new System.Drawing.Size(922, 276);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockTransactionNo,
            this.colStockTransactionDate,
            this.colInvoiceSo,
            this.colDescription,
            this.colInQuantity1,
            this.colOutQuantity1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colStockTransactionNo
            // 
            this.colStockTransactionNo.Caption = "Số phiếu";
            this.colStockTransactionNo.FieldName = "StockTransactionNo";
            this.colStockTransactionNo.Name = "colStockTransactionNo";
            this.colStockTransactionNo.Visible = true;
            this.colStockTransactionNo.VisibleIndex = 0;
            this.colStockTransactionNo.Width = 86;
            // 
            // colStockTransactionDate
            // 
            this.colStockTransactionDate.Caption = "Ngày";
            this.colStockTransactionDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colStockTransactionDate.FieldName = "StockTransactionDate";
            this.colStockTransactionDate.Name = "colStockTransactionDate";
            this.colStockTransactionDate.Visible = true;
            this.colStockTransactionDate.VisibleIndex = 1;
            this.colStockTransactionDate.Width = 92;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colInvoiceSo
            // 
            this.colInvoiceSo.Caption = "Số hoá đơn";
            this.colInvoiceSo.FieldName = "InvoiceSo";
            this.colInvoiceSo.Name = "colInvoiceSo";
            this.colInvoiceSo.Visible = true;
            this.colInvoiceSo.VisibleIndex = 2;
            this.colInvoiceSo.Width = 97;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 187;
            // 
            // colInQuantity1
            // 
            this.colInQuantity1.Caption = "SL nhập";
            this.colInQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInQuantity1.FieldName = "InQuantity";
            this.colInQuantity1.Name = "colInQuantity1";
            this.colInQuantity1.Visible = true;
            this.colInQuantity1.VisibleIndex = 4;
            this.colInQuantity1.Width = 114;
            // 
            // colOutQuantity1
            // 
            this.colOutQuantity1.Caption = "SL xuất";
            this.colOutQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutQuantity1.FieldName = "OutQuantity";
            this.colOutQuantity1.Name = "colOutQuantity1";
            this.colOutQuantity1.Visible = true;
            this.colOutQuantity1.VisibleIndex = 5;
            this.colOutQuantity1.Width = 109;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.Enabled = false;
            this.btnPrintReport.Location = new System.Drawing.Point(662, 575);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(128, 24);
            this.btnPrintReport.TabIndex = 4;
            this.btnPrintReport.Text = "In báo cáo tổng hợp";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrintReportDetail
            // 
            this.btnPrintReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReportDetail.Enabled = false;
            this.btnPrintReportDetail.Location = new System.Drawing.Point(796, 575);
            this.btnPrintReportDetail.Name = "btnPrintReportDetail";
            this.btnPrintReportDetail.Size = new System.Drawing.Size(128, 24);
            this.btnPrintReportDetail.TabIndex = 5;
            this.btnPrintReportDetail.Text = "In báo cáo chi tiết";
            this.btnPrintReportDetail.UseVisualStyleBackColor = true;
            this.btnPrintReportDetail.Click += new System.EventHandler(this.btnPrintReportDetail_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(2, 4);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(409, 68);
            this.ucDatePeriodSelection1.TabIndex = 8;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(this.ucDatePeriodSelection1_OnEditValueChanged);
            // 
            // btnInTheKho
            // 
            this.btnInTheKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInTheKho.Enabled = false;
            this.btnInTheKho.Location = new System.Drawing.Point(250, 575);
            this.btnInTheKho.Name = "btnInTheKho";
            this.btnInTheKho.Size = new System.Drawing.Size(84, 24);
            this.btnInTheKho.TabIndex = 9;
            this.btnInTheKho.Text = "In thẻ kho";
            this.btnInTheKho.UseVisualStyleBackColor = true;
            this.btnInTheKho.Visible = false;
            this.btnInTheKho.Click += new System.EventHandler(this.btnInTheKho_Click);
            // 
            // btnExportStockCardToExcel
            // 
            this.btnExportStockCardToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportStockCardToExcel.Enabled = false;
            this.btnExportStockCardToExcel.Location = new System.Drawing.Point(573, 575);
            this.btnExportStockCardToExcel.Name = "btnExportStockCardToExcel";
            this.btnExportStockCardToExcel.Size = new System.Drawing.Size(83, 24);
            this.btnExportStockCardToExcel.TabIndex = 3;
            this.btnExportStockCardToExcel.Text = "In thẻ kho";
            this.btnExportStockCardToExcel.UseVisualStyleBackColor = true;
            this.btnExportStockCardToExcel.Click += new System.EventHandler(this.btnExportStockCardToExcel_Click);
            // 
            // lookUpAccountCode
            // 
            this.lookUpAccountCode.Location = new System.Drawing.Point(501, 8);
            this.lookUpAccountCode.Name = "lookUpAccountCode";
            this.lookUpAccountCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpAccountCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã tài khoản", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên tài khoản", 200)});
            this.lookUpAccountCode.Properties.DisplayMember = "AccountCode";
            this.lookUpAccountCode.Properties.NullText = "";
            this.lookUpAccountCode.Properties.PopupWidth = 300;
            this.lookUpAccountCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpAccountCode.Properties.ValueMember = "AccountCode";
            this.lookUpAccountCode.Size = new System.Drawing.Size(80, 20);
            this.lookUpAccountCode.TabIndex = 10;
            this.lookUpAccountCode.EditValueChanged += new System.EventHandler(this.lookUpAccountCode_EditValueChanged);
            // 
            // chkReportToExcel
            // 
            this.chkReportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReportToExcel.AutoSize = true;
            this.chkReportToExcel.Location = new System.Drawing.Point(452, 579);
            this.chkReportToExcel.Name = "chkReportToExcel";
            this.chkReportToExcel.Size = new System.Drawing.Size(118, 17);
            this.chkReportToExcel.TabIndex = 11;
            this.chkReportToExcel.Text = "In báo cáo ra excel";
            this.chkReportToExcel.UseVisualStyleBackColor = true;
            // 
            // FormReportAccountStockTransactionQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 602);
            this.Controls.Add(this.chkReportToExcel);
            this.Controls.Add(this.lookUpAccountCode);
            this.Controls.Add(this.btnExportStockCardToExcel);
            this.Controls.Add(this.btnInTheKho);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.btnPrintReportDetail);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lbAccount);
            this.Name = "FormReportAccountStockTransactionQuantity";
            this.Text = "Sổ tổng hợp chi tiết số lượng kho hàng";
            this.Load += new System.EventHandler(this.FormReportAccountStockTransactionQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAccountCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Button btnReport;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemname;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseQuantity;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colOutQuantity1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnPrintReportDetail;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.Button btnInTheKho;
        private System.Windows.Forms.Button btnExportStockCardToExcel;
        private DevExpress.XtraEditors.LookUpEdit lookUpAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn col6111NhapMua;
        private DevExpress.XtraGrid.Columns.GridColumn col6111NhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col6111XuatSX;
        private DevExpress.XtraGrid.Columns.GridColumn col6111XuatKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632NhapSX;
        private DevExpress.XtraGrid.Columns.GridColumn col632NhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632XuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn col632XuatKhac;
        private System.Windows.Forms.CheckBox chkReportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceSo;
    }
}