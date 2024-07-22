namespace VNS.ERP.GUI.Accounting
{
    partial class FormReportAccountStockTransactionAmount
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
            this.btnReport = new System.Windows.Forms.Button();
            this.lbAccount = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colInvoiceSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonviCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInCostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutCostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111NhapMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111TienNhapMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111NhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111TienNhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111XuatSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111TienXuatSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111XuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col6111TienXuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632NhapSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632TienNhapSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632NhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632TienNhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632XuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632TienXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632XuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col632TienXuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnPrintReportDetail = new System.Windows.Forms.Button();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.lookUpAccountCode = new DevExpress.XtraEditors.LookUpEdit();
            this.chkReportToExcel = new System.Windows.Forms.CheckBox();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAccountCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(593, 7);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(91, 24);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lbAccount
            // 
            this.lbAccount.Location = new System.Drawing.Point(417, 9);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(83, 15);
            this.lbAccount.TabIndex = 8;
            this.lbAccount.Text = "Chọn tài khoản";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Location = new System.Drawing.Point(4, 288);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl2.Size = new System.Drawing.Size(922, 263);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockTransactionNo,
            this.colStockTransactionDate,
            this.colInvoiceSo,
            this.colStockName,
            this.colDonviCode,
            this.colDescription,
            this.colInQuantity1,
            this.colInPrice,
            this.colInCostAmount,
            this.colOutQuantity1,
            this.colOutPrice,
            this.colOutCostAmount});
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
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colInvoiceSo
            // 
            this.colInvoiceSo.Caption = "Số hoá đơn";
            this.colInvoiceSo.FieldName = "InvoiceSo";
            this.colInvoiceSo.Name = "colInvoiceSo";
            this.colInvoiceSo.Visible = true;
            this.colInvoiceSo.VisibleIndex = 2;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 3;
            // 
            // colDonviCode
            // 
            this.colDonviCode.Caption = "Mã khách hàng";
            this.colDonviCode.FieldName = "DonviCode";
            this.colDonviCode.Name = "colDonviCode";
            this.colDonviCode.Visible = true;
            this.colDonviCode.VisibleIndex = 4;
            this.colDonviCode.Width = 112;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 187;
            // 
            // colInQuantity1
            // 
            this.colInQuantity1.Caption = "SL nhập";
            this.colInQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInQuantity1.FieldName = "InQuantity";
            this.colInQuantity1.Name = "colInQuantity1";
            this.colInQuantity1.Visible = true;
            this.colInQuantity1.VisibleIndex = 6;
            this.colInQuantity1.Width = 114;
            // 
            // colInPrice
            // 
            this.colInPrice.Caption = "Giá nhập";
            this.colInPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInPrice.FieldName = "InPrice";
            this.colInPrice.Name = "colInPrice";
            this.colInPrice.Visible = true;
            this.colInPrice.VisibleIndex = 7;
            this.colInPrice.Width = 87;
            // 
            // colInCostAmount
            // 
            this.colInCostAmount.Caption = "Tiền nhập";
            this.colInCostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInCostAmount.FieldName = "InCostAmount";
            this.colInCostAmount.Name = "colInCostAmount";
            this.colInCostAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInCostAmount.Visible = true;
            this.colInCostAmount.VisibleIndex = 8;
            this.colInCostAmount.Width = 109;
            // 
            // colOutQuantity1
            // 
            this.colOutQuantity1.Caption = "SL xuất";
            this.colOutQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutQuantity1.FieldName = "OutQuantity";
            this.colOutQuantity1.Name = "colOutQuantity1";
            this.colOutQuantity1.Visible = true;
            this.colOutQuantity1.VisibleIndex = 9;
            this.colOutQuantity1.Width = 109;
            // 
            // colOutPrice
            // 
            this.colOutPrice.Caption = "Giá xuất";
            this.colOutPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutPrice.FieldName = "OutPrice";
            this.colOutPrice.Name = "colOutPrice";
            this.colOutPrice.Visible = true;
            this.colOutPrice.VisibleIndex = 10;
            this.colOutPrice.Width = 91;
            // 
            // colOutCostAmount
            // 
            this.colOutCostAmount.Caption = "Tiền xuất";
            this.colOutCostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutCostAmount.FieldName = "OutCostAmount";
            this.colOutCostAmount.Name = "colOutCostAmount";
            this.colOutCostAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutCostAmount.Visible = true;
            this.colOutCostAmount.VisibleIndex = 11;
            this.colOutCostAmount.Width = 108;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(4, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(922, 215);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.gridColumn1,
            this.colItemname,
            this.colOpenQuantity,
            this.colOpenAmount,
            this.col6111NhapMua,
            this.col6111TienNhapMua,
            this.col6111NhapKhac,
            this.col6111TienNhapKhac,
            this.col6111XuatSX,
            this.col6111TienXuatSX,
            this.col6111XuatKhac,
            this.col6111TienXuatKhac,
            this.col632NhapSX,
            this.col632TienNhapSX,
            this.col632NhapKhac,
            this.col632TienNhapKhac,
            this.col632XuatBan,
            this.col632TienXuatBan,
            this.col632XuatKhac,
            this.col632TienXuatKhac,
            this.colCloseQuantity,
            this.colCloseAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã hàng";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
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
            // colOpenAmount
            // 
            this.colOpenAmount.Caption = "Tiền";
            this.colOpenAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOpenAmount.Visible = true;
            this.colOpenAmount.VisibleIndex = 4;
            // 
            // col6111NhapMua
            // 
            this.col6111NhapMua.Caption = "Nhập mua";
            this.col6111NhapMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111NhapMua.FieldName = "NhapMua";
            this.col6111NhapMua.Name = "col6111NhapMua";
            this.col6111NhapMua.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111NhapMua.Visible = true;
            this.col6111NhapMua.VisibleIndex = 5;
            this.col6111NhapMua.Width = 88;
            // 
            // col6111TienNhapMua
            // 
            this.col6111TienNhapMua.Caption = "Tiền nhập mua";
            this.col6111TienNhapMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111TienNhapMua.FieldName = "TienNhapMua";
            this.col6111TienNhapMua.Name = "col6111TienNhapMua";
            this.col6111TienNhapMua.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111TienNhapMua.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col6111TienNhapMua.Visible = true;
            this.col6111TienNhapMua.VisibleIndex = 6;
            this.col6111TienNhapMua.Width = 113;
            // 
            // col6111NhapKhac
            // 
            this.col6111NhapKhac.Caption = "Nhập khác";
            this.col6111NhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111NhapKhac.FieldName = "NhapKhac";
            this.col6111NhapKhac.Name = "col6111NhapKhac";
            this.col6111NhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111NhapKhac.Visible = true;
            this.col6111NhapKhac.VisibleIndex = 7;
            // 
            // col6111TienNhapKhac
            // 
            this.col6111TienNhapKhac.Caption = "Tiền nhập khác";
            this.col6111TienNhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111TienNhapKhac.FieldName = "TienNhapKhac";
            this.col6111TienNhapKhac.Name = "col6111TienNhapKhac";
            this.col6111TienNhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111TienNhapKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col6111TienNhapKhac.Visible = true;
            this.col6111TienNhapKhac.VisibleIndex = 8;
            this.col6111TienNhapKhac.Width = 95;
            // 
            // col6111XuatSX
            // 
            this.col6111XuatSX.Caption = "Xuất SX";
            this.col6111XuatSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111XuatSX.FieldName = "XuatSX";
            this.col6111XuatSX.Name = "col6111XuatSX";
            this.col6111XuatSX.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111XuatSX.Visible = true;
            this.col6111XuatSX.VisibleIndex = 9;
            // 
            // col6111TienXuatSX
            // 
            this.col6111TienXuatSX.Caption = "Tiền xuất SX";
            this.col6111TienXuatSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111TienXuatSX.FieldName = "TienXuatSX";
            this.col6111TienXuatSX.Name = "col6111TienXuatSX";
            this.col6111TienXuatSX.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111TienXuatSX.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col6111TienXuatSX.Visible = true;
            this.col6111TienXuatSX.VisibleIndex = 10;
            // 
            // col6111XuatKhac
            // 
            this.col6111XuatKhac.Caption = "Xuất khác";
            this.col6111XuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111XuatKhac.FieldName = "XuatKhac";
            this.col6111XuatKhac.Name = "col6111XuatKhac";
            this.col6111XuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111XuatKhac.Visible = true;
            this.col6111XuatKhac.VisibleIndex = 11;
            // 
            // col6111TienXuatKhac
            // 
            this.col6111TienXuatKhac.Caption = "Tiền xuất khác";
            this.col6111TienXuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col6111TienXuatKhac.FieldName = "TienXuatKhac";
            this.col6111TienXuatKhac.Name = "col6111TienXuatKhac";
            this.col6111TienXuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col6111TienXuatKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col6111TienXuatKhac.Visible = true;
            this.col6111TienXuatKhac.VisibleIndex = 12;
            this.col6111TienXuatKhac.Width = 95;
            // 
            // col632NhapSX
            // 
            this.col632NhapSX.Caption = "Nhập SX";
            this.col632NhapSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632NhapSX.FieldName = "NhapSX";
            this.col632NhapSX.Name = "col632NhapSX";
            this.col632NhapSX.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // col632TienNhapSX
            // 
            this.col632TienNhapSX.Caption = "Tiền nhập SX";
            this.col632TienNhapSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632TienNhapSX.FieldName = "TienNhapSX";
            this.col632TienNhapSX.Name = "col632TienNhapSX";
            this.col632TienNhapSX.OptionsColumn.ShowInCustomizationForm = false;
            this.col632TienNhapSX.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col632TienNhapSX.Width = 88;
            // 
            // col632NhapKhac
            // 
            this.col632NhapKhac.Caption = "Nhập khác";
            this.col632NhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632NhapKhac.FieldName = "NhapKhac";
            this.col632NhapKhac.Name = "col632NhapKhac";
            this.col632NhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // col632TienNhapKhac
            // 
            this.col632TienNhapKhac.Caption = "Tiền nhập khác";
            this.col632TienNhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632TienNhapKhac.FieldName = "TienNhapKhac";
            this.col632TienNhapKhac.Name = "col632TienNhapKhac";
            this.col632TienNhapKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col632TienNhapKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col632TienNhapKhac.Width = 107;
            // 
            // col632XuatBan
            // 
            this.col632XuatBan.Caption = "Xuất bán";
            this.col632XuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632XuatBan.FieldName = "XuatBan";
            this.col632XuatBan.Name = "col632XuatBan";
            this.col632XuatBan.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // col632TienXuatBan
            // 
            this.col632TienXuatBan.Caption = "Tiền xuất bán";
            this.col632TienXuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632TienXuatBan.FieldName = "TienXuatBan";
            this.col632TienXuatBan.Name = "col632TienXuatBan";
            this.col632TienXuatBan.OptionsColumn.ShowInCustomizationForm = false;
            this.col632TienXuatBan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col632TienXuatBan.Width = 96;
            // 
            // col632XuatKhac
            // 
            this.col632XuatKhac.Caption = "Xuất khác";
            this.col632XuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632XuatKhac.FieldName = "XuatKhac";
            this.col632XuatKhac.Name = "col632XuatKhac";
            this.col632XuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // col632TienXuatKhac
            // 
            this.col632TienXuatKhac.Caption = "Tiền xuất khác";
            this.col632TienXuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col632TienXuatKhac.FieldName = "TienXuatKhac";
            this.col632TienXuatKhac.Name = "col632TienXuatKhac";
            this.col632TienXuatKhac.OptionsColumn.ShowInCustomizationForm = false;
            this.col632TienXuatKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.col632TienXuatKhac.Width = 91;
            // 
            // colCloseQuantity
            // 
            this.colCloseQuantity.Caption = "Tồn cuối";
            this.colCloseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseQuantity.FieldName = "CloseQuantity";
            this.colCloseQuantity.Name = "colCloseQuantity";
            this.colCloseQuantity.Visible = true;
            this.colCloseQuantity.VisibleIndex = 13;
            this.colCloseQuantity.Width = 117;
            // 
            // colCloseAmount
            // 
            this.colCloseAmount.Caption = "Tiền";
            this.colCloseAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseAmount.FieldName = "CloseAmount";
            this.colCloseAmount.Name = "colCloseAmount";
            this.colCloseAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseAmount.Visible = true;
            this.colCloseAmount.VisibleIndex = 14;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.Enabled = false;
            this.btnPrintReport.Location = new System.Drawing.Point(666, 557);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(126, 24);
            this.btnPrintReport.TabIndex = 3;
            this.btnPrintReport.Text = "In báo cáo tổng hợp";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnPrintReportDetail
            // 
            this.btnPrintReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReportDetail.Enabled = false;
            this.btnPrintReportDetail.Location = new System.Drawing.Point(798, 557);
            this.btnPrintReportDetail.Name = "btnPrintReportDetail";
            this.btnPrintReportDetail.Size = new System.Drawing.Size(126, 24);
            this.btnPrintReportDetail.TabIndex = 4;
            this.btnPrintReportDetail.Text = "In báo cáo chi tiết";
            this.btnPrintReportDetail.UseVisualStyleBackColor = true;
            this.btnPrintReportDetail.Click += new System.EventHandler(this.btnPrintReportDetail_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 1);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(411, 65);
            this.ucDatePeriodSelection1.TabIndex = 7;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(this.ucDatePeriodSelection1_OnEditValueChanged);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Location = new System.Drawing.Point(548, 557);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(112, 24);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "In toàn bộ chi tiết";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // lookUpAccountCode
            // 
            this.lookUpAccountCode.Location = new System.Drawing.Point(507, 9);
            this.lookUpAccountCode.Name = "lookUpAccountCode";
            this.lookUpAccountCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpAccountCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", 100, "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", 200, "Tên tài khoản")});
            this.lookUpAccountCode.Properties.DisplayMember = "AccountCode";
            this.lookUpAccountCode.Properties.NullText = "";
            this.lookUpAccountCode.Properties.PopupWidth = 300;
            this.lookUpAccountCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpAccountCode.Properties.ValueMember = "AccountCode";
            this.lookUpAccountCode.Size = new System.Drawing.Size(80, 20);
            this.lookUpAccountCode.TabIndex = 11;
            this.lookUpAccountCode.EditValueChanged += new System.EventHandler(this.lookUpAccountCode_EditValueChanged);
            // 
            // chkReportToExcel
            // 
            this.chkReportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReportToExcel.AutoSize = true;
            this.chkReportToExcel.Checked = true;
            this.chkReportToExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReportToExcel.Location = new System.Drawing.Point(427, 560);
            this.chkReportToExcel.Name = "chkReportToExcel";
            this.chkReportToExcel.Size = new System.Drawing.Size(118, 17);
            this.chkReportToExcel.TabIndex = 12;
            this.chkReportToExcel.Text = "In báo cáo ra excel";
            this.chkReportToExcel.UseVisualStyleBackColor = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã 2";
            this.gridColumn1.FieldName = "Code2";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // FormReportAccountStockTransactionAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 587);
            this.Controls.Add(this.chkReportToExcel);
            this.Controls.Add(this.lookUpAccountCode);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnPrintReportDetail);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Name = "FormReportAccountStockTransactionAmount";
            this.Text = "Sổ tổng hợp chi tiết tài khoản kho hàng";
            this.Load += new System.EventHandler(this.FormReportAccountStockTransactionAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpAccountCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lbAccount;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colInQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colOutQuantity1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemname;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colInCostAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutCostAmount;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnPrintReportDetail;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraGrid.Columns.GridColumn colInPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colOutPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDonviCode;
        private System.Windows.Forms.Button btnExportToExcel;
        private DevExpress.XtraEditors.LookUpEdit lookUpAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn col6111NhapMua;
        private DevExpress.XtraGrid.Columns.GridColumn col6111TienNhapMua;
        private DevExpress.XtraGrid.Columns.GridColumn col6111NhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col6111TienNhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col6111XuatSX;
        private DevExpress.XtraGrid.Columns.GridColumn col6111TienXuatSX;
        private DevExpress.XtraGrid.Columns.GridColumn col6111XuatKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col6111TienXuatKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632NhapSX;
        private DevExpress.XtraGrid.Columns.GridColumn col632TienNhapSX;
        private DevExpress.XtraGrid.Columns.GridColumn col632NhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632TienNhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632XuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn col632TienXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn col632XuatKhac;
        private DevExpress.XtraGrid.Columns.GridColumn col632TienXuatKhac;
        private System.Windows.Forms.CheckBox chkReportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceSo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}