namespace VNS.ERP.GUI.Stocks
{
    partial class FormReportInOutMaterial
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
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemTypeDisplay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonDKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapSoChe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapKK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatSoChe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lstReportFor = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lbReportFor = new System.Windows.Forms.Label();
            this.chkReportPhanloai = new System.Windows.Forms.CheckBox();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.checkEditReportToExcel = new DevExpress.XtraEditors.CheckEdit();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.radStock = new DevExpress.XtraEditors.RadioGroup();
            this.chkIncludeTemp = new DevExpress.XtraEditors.CheckEdit();
            this.colCloseManufactureQty = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstReportFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReportToExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeTemp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Options.UseFont = true;
            this.btnBaoCao.Location = new System.Drawing.Point(595, 110);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(112, 37);
            this.btnBaoCao.TabIndex = 16;
            this.btnBaoCao.Text = "Refresh";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(885, 604);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 32);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(5, 150);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1018, 448);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockCode,
            this.colItemCode,
            this.colItemName,
            this.colItemTypeDisplay,
            this.colTonDKy,
            this.colNhapMua,
            this.colNhapNB,
            this.colNhapSoChe,
            this.colNhapKK,
            this.colNhapKhac,
            this.colXuatSX,
            this.colXuatNB,
            this.colXuatSoChe,
            this.colXuatBan,
            this.colXuatKhac,
            this.colDeltaStock,
            this.colCloseQuantity,
            this.colCloseManufactureQty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Kho";
            this.colStockCode.FieldName = "StockName";
            this.colStockCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 82;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã TP";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên thành phẩm";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 131;
            // 
            // colItemTypeDisplay
            // 
            this.colItemTypeDisplay.Caption = "Loại";
            this.colItemTypeDisplay.FieldName = "ItemTypeDisplay";
            this.colItemTypeDisplay.Name = "colItemTypeDisplay";
            this.colItemTypeDisplay.OptionsColumn.ShowInCustomizationForm = false;
            this.colItemTypeDisplay.Visible = true;
            this.colItemTypeDisplay.VisibleIndex = 15;
            this.colItemTypeDisplay.Width = 80;
            // 
            // colTonDKy
            // 
            this.colTonDKy.Caption = "Tồn đầu kỳ";
            this.colTonDKy.DisplayFormat.FormatString = "n2";
            this.colTonDKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTonDKy.FieldName = "OpenQuantity";
            this.colTonDKy.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTonDKy.Name = "colTonDKy";
            this.colTonDKy.SummaryItem.DisplayFormat = "{0:n0}";
            this.colTonDKy.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTonDKy.Visible = true;
            this.colTonDKy.VisibleIndex = 3;
            this.colTonDKy.Width = 88;
            // 
            // colNhapMua
            // 
            this.colNhapMua.Caption = "Nhập mua";
            this.colNhapMua.DisplayFormat.FormatString = "n2";
            this.colNhapMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapMua.FieldName = "NhapMua";
            this.colNhapMua.Name = "colNhapMua";
            this.colNhapMua.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapMua.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapMua.Visible = true;
            this.colNhapMua.VisibleIndex = 4;
            this.colNhapMua.Width = 87;
            // 
            // colNhapNB
            // 
            this.colNhapNB.Caption = "Nhập nội bộ";
            this.colNhapNB.DisplayFormat.FormatString = "n2";
            this.colNhapNB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapNB.FieldName = "NhapNB";
            this.colNhapNB.Name = "colNhapNB";
            this.colNhapNB.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapNB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapNB.Visible = true;
            this.colNhapNB.VisibleIndex = 5;
            this.colNhapNB.Width = 95;
            // 
            // colNhapSoChe
            // 
            this.colNhapSoChe.Caption = "Nhập nghiền";
            this.colNhapSoChe.DisplayFormat.FormatString = "n2";
            this.colNhapSoChe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapSoChe.FieldName = "NhapSoChe";
            this.colNhapSoChe.Name = "colNhapSoChe";
            this.colNhapSoChe.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapSoChe.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapSoChe.Visible = true;
            this.colNhapSoChe.VisibleIndex = 6;
            this.colNhapSoChe.Width = 91;
            // 
            // colNhapKK
            // 
            this.colNhapKK.Caption = "Nhập kiểm kê";
            this.colNhapKK.DisplayFormat.FormatString = "n2";
            this.colNhapKK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapKK.FieldName = "NhapKK";
            this.colNhapKK.Name = "colNhapKK";
            this.colNhapKK.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapKK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapKK.Visible = true;
            this.colNhapKK.VisibleIndex = 7;
            this.colNhapKK.Width = 89;
            // 
            // colNhapKhac
            // 
            this.colNhapKhac.Caption = "Nhập khác";
            this.colNhapKhac.DisplayFormat.FormatString = "n2";
            this.colNhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapKhac.FieldName = "NhapKhac";
            this.colNhapKhac.Name = "colNhapKhac";
            this.colNhapKhac.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapKhac.Visible = true;
            this.colNhapKhac.VisibleIndex = 8;
            this.colNhapKhac.Width = 90;
            // 
            // colXuatSX
            // 
            this.colXuatSX.Caption = "Xuất sản xuất";
            this.colXuatSX.DisplayFormat.FormatString = "n2";
            this.colXuatSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatSX.FieldName = "XuatSX";
            this.colXuatSX.Name = "colXuatSX";
            this.colXuatSX.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatSX.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatSX.Visible = true;
            this.colXuatSX.VisibleIndex = 9;
            this.colXuatSX.Width = 106;
            // 
            // colXuatNB
            // 
            this.colXuatNB.Caption = "Xuất nội bộ";
            this.colXuatNB.DisplayFormat.FormatString = "n2";
            this.colXuatNB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatNB.FieldName = "XuatNB";
            this.colXuatNB.Name = "colXuatNB";
            this.colXuatNB.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatNB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatNB.Visible = true;
            this.colXuatNB.VisibleIndex = 10;
            this.colXuatNB.Width = 94;
            // 
            // colXuatSoChe
            // 
            this.colXuatSoChe.Caption = "Xuất nghiền";
            this.colXuatSoChe.DisplayFormat.FormatString = "n2";
            this.colXuatSoChe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatSoChe.FieldName = "XuatSoChe";
            this.colXuatSoChe.Name = "colXuatSoChe";
            this.colXuatSoChe.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatSoChe.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatSoChe.Visible = true;
            this.colXuatSoChe.VisibleIndex = 11;
            this.colXuatSoChe.Width = 97;
            // 
            // colXuatBan
            // 
            this.colXuatBan.Caption = "Xuất bán";
            this.colXuatBan.DisplayFormat.FormatString = "n2";
            this.colXuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatBan.FieldName = "XuatBan";
            this.colXuatBan.Name = "colXuatBan";
            this.colXuatBan.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatBan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatBan.Visible = true;
            this.colXuatBan.VisibleIndex = 12;
            this.colXuatBan.Width = 99;
            // 
            // colXuatKhac
            // 
            this.colXuatKhac.Caption = "Xuất khác";
            this.colXuatKhac.DisplayFormat.FormatString = "n2";
            this.colXuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatKhac.FieldName = "XuatKhac";
            this.colXuatKhac.Name = "colXuatKhac";
            this.colXuatKhac.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatKhac.Visible = true;
            this.colXuatKhac.VisibleIndex = 13;
            this.colXuatKhac.Width = 94;
            // 
            // colDeltaStock
            // 
            this.colDeltaStock.Caption = "Chênh lệch kho";
            this.colDeltaStock.DisplayFormat.FormatString = "n2";
            this.colDeltaStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeltaStock.FieldName = "DeltaStock";
            this.colDeltaStock.Name = "colDeltaStock";
            this.colDeltaStock.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDeltaStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDeltaStock.Visible = true;
            this.colDeltaStock.VisibleIndex = 14;
            this.colDeltaStock.Width = 97;
            // 
            // colCloseQuantity
            // 
            this.colCloseQuantity.Caption = "Tồn cuối kỳ";
            this.colCloseQuantity.DisplayFormat.FormatString = "n2";
            this.colCloseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseQuantity.FieldName = "CloseQuantity";
            this.colCloseQuantity.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCloseQuantity.Name = "colCloseQuantity";
            this.colCloseQuantity.SummaryItem.DisplayFormat = "{0:n0}";
            this.colCloseQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseQuantity.Visible = true;
            this.colCloseQuantity.VisibleIndex = 16;
            this.colCloseQuantity.Width = 108;
            // 
            // lstReportFor
            // 
            this.lstReportFor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReportFor.Appearance.Options.UseFont = true;
            this.lstReportFor.CheckOnClick = true;
            this.lstReportFor.ColumnWidth = 150;
            this.lstReportFor.Location = new System.Drawing.Point(595, 7);
            this.lstReportFor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstReportFor.MultiColumn = true;
            this.lstReportFor.Name = "lstReportFor";
            this.lstReportFor.Size = new System.Drawing.Size(420, 95);
            this.lstReportFor.TabIndex = 18;
            // 
            // lbReportFor
            // 
            this.lbReportFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReportFor.Location = new System.Drawing.Point(479, 34);
            this.lbReportFor.Name = "lbReportFor";
            this.lbReportFor.Size = new System.Drawing.Size(107, 28);
            this.lbReportFor.TabIndex = 17;
            this.lbReportFor.Text = "Báo cáo cho:";
            this.lbReportFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkReportPhanloai
            // 
            this.chkReportPhanloai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReportPhanloai.AutoSize = true;
            this.chkReportPhanloai.Checked = true;
            this.chkReportPhanloai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReportPhanloai.Location = new System.Drawing.Point(787, 609);
            this.chkReportPhanloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkReportPhanloai.Name = "chkReportPhanloai";
            this.chkReportPhanloai.Size = new System.Drawing.Size(84, 21);
            this.chkReportPhanloai.TabIndex = 19;
            this.chkReportPhanloai.Text = "Phân loại";
            this.chkReportPhanloai.UseVisualStyleBackColor = true;
            // 
            // lookUpStock
            // 
            this.lookUpStock.Location = new System.Drawing.Point(105, 119);
            this.lookUpStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpStock.Name = "lookUpStock";
            this.lookUpStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", 70, "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 130, "Tên kho")});
            this.lookUpStock.Properties.DisplayMember = "StockName";
            this.lookUpStock.Properties.NullText = "";
            this.lookUpStock.Properties.PopupWidth = 200;
            this.lookUpStock.Properties.ValueMember = "StockCode";
            this.lookUpStock.Size = new System.Drawing.Size(185, 26);
            this.lookUpStock.TabIndex = 20;
            this.lookUpStock.EditValueChanged += new System.EventHandler(this.lookUpStock_EditValueChanged);
            // 
            // checkEditReportToExcel
            // 
            this.checkEditReportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditReportToExcel.Location = new System.Drawing.Point(635, 606);
            this.checkEditReportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditReportToExcel.Name = "checkEditReportToExcel";
            this.checkEditReportToExcel.Properties.Caption = "Kết xuất ra Excel";
            this.checkEditReportToExcel.Size = new System.Drawing.Size(138, 21);
            this.checkEditReportToExcel.TabIndex = 22;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(5, 0);
            this.ucDatePeriodSelection1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(468, 76);
            this.ucDatePeriodSelection1.TabIndex = 23;
            // 
            // radStock
            // 
            this.radStock.Location = new System.Drawing.Point(5, 84);
            this.radStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radStock.Name = "radStock";
            this.radStock.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Việt Thắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chọn kho")});
            this.radStock.Size = new System.Drawing.Size(93, 63);
            this.radStock.TabIndex = 24;
            // 
            // chkIncludeTemp
            // 
            this.chkIncludeTemp.Location = new System.Drawing.Point(105, 89);
            this.chkIncludeTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludeTemp.Name = "chkIncludeTemp";
            this.chkIncludeTemp.Properties.Caption = "Tính cả các kho chờ pt, khách hàng, đi đường...";
            this.chkIncludeTemp.Size = new System.Drawing.Size(313, 21);
            this.chkIncludeTemp.TabIndex = 25;
            this.chkIncludeTemp.EditValueChanged += new System.EventHandler(this.chkIncludeTemp_EditValueChanged);
            // 
            // colCloseManufactureQty
            // 
            this.colCloseManufactureQty.Caption = "Tồn kho sản xuất";
            this.colCloseManufactureQty.DisplayFormat.FormatString = "n2";
            this.colCloseManufactureQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseManufactureQty.FieldName = "CloseManufactureQuantity";
            this.colCloseManufactureQty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCloseManufactureQty.Name = "colCloseManufactureQty";
            this.colCloseManufactureQty.SummaryItem.DisplayFormat = "{0:n0}";
            this.colCloseManufactureQty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseManufactureQty.Visible = true;
            this.colCloseManufactureQty.VisibleIndex = 17;
            this.colCloseManufactureQty.Width = 108;
            // 
            // FormReportInOutMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 638);
            this.Controls.Add(this.chkIncludeTemp);
            this.Controls.Add(this.radStock);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.checkEditReportToExcel);
            this.Controls.Add(this.lookUpStock);
            this.Controls.Add(this.chkReportPhanloai);
            this.Controls.Add(this.lstReportFor);
            this.Controls.Add(this.lbReportFor);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReportInOutMaterial";
            this.Text = "FormReportInOutMaterial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstReportFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReportToExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeTemp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private System.Windows.Forms.Button btnPrint;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colTonDKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapMua;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapNB;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapSoChe;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapKK;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatSX;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatNB;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatSoChe;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatKhac;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaStock;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemTypeDisplay;
        private DevExpress.XtraEditors.CheckedListBoxControl lstReportFor;
        private System.Windows.Forms.Label lbReportFor;
        private System.Windows.Forms.CheckBox chkReportPhanloai;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private DevExpress.XtraEditors.CheckEdit checkEditReportToExcel;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.RadioGroup radStock;
        private DevExpress.XtraEditors.CheckEdit chkIncludeTemp;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseManufactureQty;
    }
}