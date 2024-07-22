namespace VNS.ERP.GUI.Stocks
{
    partial class FormListWeightItemContainer
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsAuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpTransactionTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWeightDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWeight1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtWeight = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWeightTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightTime2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrappingWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTongBB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrappingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoGiaoNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpKhoGiaoNhan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockLocationCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpDVGiaoNhan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDVNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTTrungChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVVanChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpDVVanChuyen = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTime = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTransactionTypeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpKhoGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVGiaoNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVVanChuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(5, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpTransactionTypeCode,
            this.repLookUpEmployee,
            this.repLookUpKhoGiaoNhan,
            this.repLookUpDVGiaoNhan,
            this.repLookUpDVVanChuyen,
            this.repLookUpItem,
            this.repTxtWeight,
            this.repTime,
            this.repTxtQuantity});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(819, 332);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsAuto,
            this.colTransactionTypeCode,
            this.colWeightDate,
            this.colWeightCode,
            this.colItemCode,
            this.colEmployeeID,
            this.colWeight1,
            this.colWeightTime1,
            this.colWeight2,
            this.colWeightTime2,
            this.colWrappingWeight,
            this.colQuantity,
            this.colTongBB,
            this.colPalletWeight,
            this.colItemWeight,
            this.colStockLocationCode,
            this.colWrappingType,
            this.colKhoGiaoNhan,
            this.colStockLocationCode2,
            this.colDVGiao,
            this.colDVNhan,
            this.colPTVanChuyen,
            this.colPTTrungChuyen,
            this.colDVVanChuyen,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated,
            this.colIsSelected,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTransactionTypeCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIsAuto
            // 
            this.colIsAuto.Caption = "Phiếu tự động";
            this.colIsAuto.FieldName = "IsAuto";
            this.colIsAuto.Name = "colIsAuto";
            this.colIsAuto.Visible = true;
            this.colIsAuto.VisibleIndex = 0;
            // 
            // colTransactionTypeCode
            // 
            this.colTransactionTypeCode.Caption = "Mã N/X";
            this.colTransactionTypeCode.ColumnEdit = this.repLookUpTransactionTypeCode;
            this.colTransactionTypeCode.FieldName = "TransactionTypeCode";
            this.colTransactionTypeCode.Name = "colTransactionTypeCode";
            // 
            // repLookUpTransactionTypeCode
            // 
            this.repLookUpTransactionTypeCode.AutoHeight = false;
            this.repLookUpTransactionTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpTransactionTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeCode", "TransactionTypeCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
            this.repLookUpTransactionTypeCode.DisplayMember = "Description";
            this.repLookUpTransactionTypeCode.Name = "repLookUpTransactionTypeCode";
            this.repLookUpTransactionTypeCode.NullText = "";
            this.repLookUpTransactionTypeCode.ValueMember = "TransactionTypeCode";
            // 
            // colWeightDate
            // 
            this.colWeightDate.Caption = "Ngày cân";
            this.colWeightDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colWeightDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWeightDate.FieldName = "WeightDate";
            this.colWeightDate.Name = "colWeightDate";
            this.colWeightDate.Visible = true;
            this.colWeightDate.VisibleIndex = 1;
            this.colWeightDate.Width = 99;
            // 
            // colWeightCode
            // 
            this.colWeightCode.Caption = "Số phiếu";
            this.colWeightCode.FieldName = "WeightCode";
            this.colWeightCode.Name = "colWeightCode";
            this.colWeightCode.Visible = true;
            this.colWeightCode.VisibleIndex = 2;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Loại hàng";
            this.colItemCode.ColumnEdit = this.repLookUpItem;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 3;
            this.colItemCode.Width = 132;
            // 
            // repLookUpItem
            // 
            this.repLookUpItem.AutoHeight = false;
            this.repLookUpItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName")});
            this.repLookUpItem.DisplayMember = "ItemName";
            this.repLookUpItem.Name = "repLookUpItem";
            this.repLookUpItem.NullText = "";
            this.repLookUpItem.ValueMember = "ItemCode";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "Nhân viên cân";
            this.colEmployeeID.ColumnEdit = this.repLookUpEmployee;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 10;
            this.colEmployeeID.Width = 128;
            // 
            // repLookUpEmployee
            // 
            this.repLookUpEmployee.AutoHeight = false;
            this.repLookUpEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEmployee.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "EmployeeID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "EmployeeName")});
            this.repLookUpEmployee.DisplayMember = "EmployeeName";
            this.repLookUpEmployee.Name = "repLookUpEmployee";
            this.repLookUpEmployee.NullText = "";
            this.repLookUpEmployee.ValueMember = "EmployeeID";
            // 
            // colWeight1
            // 
            this.colWeight1.Caption = "Cân lần 1";
            this.colWeight1.ColumnEdit = this.repTxtWeight;
            this.colWeight1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight1.FieldName = "Weight1";
            this.colWeight1.Name = "colWeight1";
            this.colWeight1.Visible = true;
            this.colWeight1.VisibleIndex = 11;
            // 
            // repTxtWeight
            // 
            this.repTxtWeight.AutoHeight = false;
            this.repTxtWeight.DisplayFormat.FormatString = "n2";
            this.repTxtWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtWeight.EditFormat.FormatString = "n2";
            this.repTxtWeight.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtWeight.Mask.EditMask = "n2";
            this.repTxtWeight.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtWeight.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtWeight.Name = "repTxtWeight";
            // 
            // colWeightTime1
            // 
            this.colWeightTime1.Caption = "Lúc (1)";
            this.colWeightTime1.DisplayFormat.FormatString = "dd/MM/yy HH:mm:ss";
            this.colWeightTime1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWeightTime1.FieldName = "WeightTime1";
            this.colWeightTime1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colWeightTime1.Name = "colWeightTime1";
            this.colWeightTime1.Visible = true;
            this.colWeightTime1.VisibleIndex = 12;
            // 
            // colWeight2
            // 
            this.colWeight2.Caption = "Cân lần 2";
            this.colWeight2.ColumnEdit = this.repTxtWeight;
            this.colWeight2.FieldName = "Weight2";
            this.colWeight2.Name = "colWeight2";
            this.colWeight2.Visible = true;
            this.colWeight2.VisibleIndex = 13;
            // 
            // colWeightTime2
            // 
            this.colWeightTime2.Caption = "Lúc (2)";
            this.colWeightTime2.DisplayFormat.FormatString = "dd/MM/yy HH:mm:ss";
            this.colWeightTime2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colWeightTime2.FieldName = "WeightTime2";
            this.colWeightTime2.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colWeightTime2.Name = "colWeightTime2";
            this.colWeightTime2.Visible = true;
            this.colWeightTime2.VisibleIndex = 14;
            // 
            // colWrappingWeight
            // 
            this.colWrappingWeight.Caption = "Bì bao";
            this.colWrappingWeight.FieldName = "WrappingWeight";
            this.colWrappingWeight.Name = "colWrappingWeight";
            this.colWrappingWeight.Visible = true;
            this.colWrappingWeight.VisibleIndex = 4;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số bao";
            this.colQuantity.ColumnEdit = this.repTxtQuantity;
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            // 
            // repTxtQuantity
            // 
            this.repTxtQuantity.AutoHeight = false;
            this.repTxtQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtQuantity.Name = "repTxtQuantity";
            // 
            // colTongBB
            // 
            this.colTongBB.Caption = "Tổng bì bao";
            this.colTongBB.ColumnEdit = this.repTxtWeight;
            this.colTongBB.FieldName = "TotalWrappingWeight";
            this.colTongBB.Name = "colTongBB";
            this.colTongBB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTongBB.Visible = true;
            this.colTongBB.VisibleIndex = 6;
            this.colTongBB.Width = 97;
            // 
            // colPalletWeight
            // 
            this.colPalletWeight.Caption = "Pallet";
            this.colPalletWeight.DisplayFormat.FormatString = "n2";
            this.colPalletWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPalletWeight.FieldName = "PalletWeight";
            this.colPalletWeight.Name = "colPalletWeight";
            this.colPalletWeight.Visible = true;
            this.colPalletWeight.VisibleIndex = 7;
            this.colPalletWeight.Width = 67;
            // 
            // colItemWeight
            // 
            this.colItemWeight.Caption = "Tổng TL hàng";
            this.colItemWeight.ColumnEdit = this.repTxtWeight;
            this.colItemWeight.FieldName = "ItemWeight";
            this.colItemWeight.Name = "colItemWeight";
            this.colItemWeight.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colItemWeight.Visible = true;
            this.colItemWeight.VisibleIndex = 8;
            this.colItemWeight.Width = 106;
            // 
            // colStockLocationCode
            // 
            this.colStockLocationCode.Caption = "Lô hàng";
            this.colStockLocationCode.FieldName = "StockLocationCode";
            this.colStockLocationCode.Name = "colStockLocationCode";
            this.colStockLocationCode.Visible = true;
            this.colStockLocationCode.VisibleIndex = 9;
            // 
            // colWrappingType
            // 
            this.colWrappingType.Caption = "Loại bao bì";
            this.colWrappingType.FieldName = "WrappingType";
            this.colWrappingType.Name = "colWrappingType";
            this.colWrappingType.Visible = true;
            this.colWrappingType.VisibleIndex = 15;
            this.colWrappingType.Width = 79;
            // 
            // colKhoGiaoNhan
            // 
            this.colKhoGiaoNhan.Caption = "Kho giao nhận";
            this.colKhoGiaoNhan.ColumnEdit = this.repLookUpKhoGiaoNhan;
            this.colKhoGiaoNhan.FieldName = "KhoGiaoNhan";
            this.colKhoGiaoNhan.Name = "colKhoGiaoNhan";
            this.colKhoGiaoNhan.Visible = true;
            this.colKhoGiaoNhan.VisibleIndex = 16;
            this.colKhoGiaoNhan.Width = 121;
            // 
            // repLookUpKhoGiaoNhan
            // 
            this.repLookUpKhoGiaoNhan.AutoHeight = false;
            this.repLookUpKhoGiaoNhan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpKhoGiaoNhan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "StockName")});
            this.repLookUpKhoGiaoNhan.DisplayMember = "StockName";
            this.repLookUpKhoGiaoNhan.Name = "repLookUpKhoGiaoNhan";
            this.repLookUpKhoGiaoNhan.NullText = "";
            this.repLookUpKhoGiaoNhan.ValueMember = "StockCode";
            // 
            // colStockLocationCode2
            // 
            this.colStockLocationCode2.Caption = "Lô giao/nhận";
            this.colStockLocationCode2.FieldName = "StockLocationCode2";
            this.colStockLocationCode2.Name = "colStockLocationCode2";
            this.colStockLocationCode2.Visible = true;
            this.colStockLocationCode2.VisibleIndex = 17;
            // 
            // colDVGiao
            // 
            this.colDVGiao.Caption = "ĐV giao";
            this.colDVGiao.ColumnEdit = this.repLookUpDVGiaoNhan;
            this.colDVGiao.FieldName = "DVGiao";
            this.colDVGiao.Name = "colDVGiao";
            this.colDVGiao.Visible = true;
            this.colDVGiao.VisibleIndex = 18;
            this.colDVGiao.Width = 78;
            // 
            // repLookUpDVGiaoNhan
            // 
            this.repLookUpDVGiaoNhan.AutoHeight = false;
            this.repLookUpDVGiaoNhan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpDVGiaoNhan.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName")});
            this.repLookUpDVGiaoNhan.DisplayMember = "SubjectName";
            this.repLookUpDVGiaoNhan.Name = "repLookUpDVGiaoNhan";
            this.repLookUpDVGiaoNhan.NullText = "";
            this.repLookUpDVGiaoNhan.ValueMember = "SubjectCode";
            // 
            // colDVNhan
            // 
            this.colDVNhan.Caption = "ĐV nhận";
            this.colDVNhan.ColumnEdit = this.repLookUpDVGiaoNhan;
            this.colDVNhan.FieldName = "DVNhan";
            this.colDVNhan.Name = "colDVNhan";
            this.colDVNhan.Visible = true;
            this.colDVNhan.VisibleIndex = 19;
            this.colDVNhan.Width = 79;
            // 
            // colPTVanChuyen
            // 
            this.colPTVanChuyen.Caption = "PT vận chuyển";
            this.colPTVanChuyen.FieldName = "PTVanChuyen";
            this.colPTVanChuyen.Name = "colPTVanChuyen";
            this.colPTVanChuyen.Visible = true;
            this.colPTVanChuyen.VisibleIndex = 20;
            this.colPTVanChuyen.Width = 105;
            // 
            // colPTTrungChuyen
            // 
            this.colPTTrungChuyen.Caption = "PT trung chuyển";
            this.colPTTrungChuyen.FieldName = "PTTrungChuyen";
            this.colPTTrungChuyen.Name = "colPTTrungChuyen";
            this.colPTTrungChuyen.Visible = true;
            this.colPTTrungChuyen.VisibleIndex = 21;
            this.colPTTrungChuyen.Width = 108;
            // 
            // colDVVanChuyen
            // 
            this.colDVVanChuyen.Caption = "ĐV vận chuyển";
            this.colDVVanChuyen.ColumnEdit = this.repLookUpDVVanChuyen;
            this.colDVVanChuyen.FieldName = "DVVanChuyen";
            this.colDVVanChuyen.Name = "colDVVanChuyen";
            this.colDVVanChuyen.Visible = true;
            this.colDVVanChuyen.VisibleIndex = 22;
            this.colDVVanChuyen.Width = 112;
            // 
            // repLookUpDVVanChuyen
            // 
            this.repLookUpDVVanChuyen.AutoHeight = false;
            this.repLookUpDVVanChuyen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpDVVanChuyen.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName")});
            this.repLookUpDVVanChuyen.DisplayMember = "SubjectName";
            this.repLookUpDVVanChuyen.Name = "repLookUpDVVanChuyen";
            this.repLookUpDVVanChuyen.NullText = "";
            this.repLookUpDVVanChuyen.ValueMember = "SubjectCode";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 23;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 76;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.FieldName = "DateCeated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 92;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 94;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 93;
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Đã chọn phiếu kho";
            this.colIsSelected.FieldName = "IsSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 24;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lượt";
            this.gridColumn1.FieldName = "Luot";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 25;
            // 
            // repTime
            // 
            this.repTime.AutoHeight = false;
            this.repTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repTime.DisplayFormat.FormatString = "HH:mm:ss";
            this.repTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repTime.EditFormat.FormatString = "HH:mm:ss";
            this.repTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repTime.Mask.EditMask = "HH:mm:ss";
            this.repTime.Mask.UseMaskAsDisplayFormat = true;
            this.repTime.Name = "repTime";
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(555, 44);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(27, 18);
            this.lbPeriod.TabIndex = 17;
            this.lbPeriod.Text = "Kỳ";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(586, 45);
            this.lookUpPeriod.Name = "lookUpPeriod";
            this.lookUpPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
            this.lookUpPeriod.Properties.DisplayMember = "Description";
            this.lookUpPeriod.Properties.NullText = "";
            this.lookUpPeriod.Properties.ShowHeader = false;
            this.lookUpPeriod.Properties.ValueMember = "PeriodCode";
            this.lookUpPeriod.Size = new System.Drawing.Size(125, 20);
            this.lookUpPeriod.TabIndex = 16;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Location = new System.Drawing.Point(33, 45);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", 70, "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 130, "Tên")});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(110, 19);
            this.lookUpStockCode.TabIndex = 15;
            this.lookUpStockCode.EditValueChanged += new System.EventHandler(this.lookUpStockCode_EditValueChanged);
            // 
            // lbStockCode
            // 
            this.lbStockCode.Location = new System.Drawing.Point(3, 44);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(30, 18);
            this.lbStockCode.TabIndex = 14;
            this.lbStockCode.Text = "Kho";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Location = new System.Drawing.Point(719, 44);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(103, 23);
            this.btnExportToExcel.TabIndex = 105;
            this.btnExportToExcel.Text = "Xuất ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // FormListWeightItemContainer
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 431);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListWeightItemContainer";
            this.Text = "Phiếu cân hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListWeightItemContainer_FormClosed);
            this.Load += new System.EventHandler(this.FormListWeightItemContainer_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lbStockCode, 0);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.btnExportToExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTransactionTypeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpKhoGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVGiaoNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVVanChuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoGiaoNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colDVGiao;
        private DevExpress.XtraGrid.Columns.GridColumn colDVNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightTime1;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight2;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightTime2;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTongBB;
        private DevExpress.XtraGrid.Columns.GridColumn colItemWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingType;
        private DevExpress.XtraGrid.Columns.GridColumn colPTVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colDVVanChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colPTTrungChuyen;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpTransactionTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpKhoGiaoNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpDVGiaoNhan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpDVVanChuyen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtWeight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colStockLocationCode;
        private System.Windows.Forms.Button btnExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAuto;
        private DevExpress.XtraGrid.Columns.GridColumn colPalletWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colStockLocationCode2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}