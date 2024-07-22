namespace VNS.ERP.GUI.UserControl
{
    partial class DetailStockTransactionDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQuantity1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colOutLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupOutLocation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colInLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupInLocation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colGoodCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantityReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQuantityReg = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantityInclWrapping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQuantityInclWrapping = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colWrappingCounter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtWrappingCounter = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPriceCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPriceCost = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmountCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAmountCost = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPriceIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPriceIn = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmountIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAmountIn = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPriceOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPriceOut = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmountOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAmountOut = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lookUpInStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lbInStock = new System.Windows.Forms.Label();
            this.lbOutStock = new System.Windows.Forms.Label();
            this.lookUpOutStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTransactionNo = new System.Windows.Forms.Label();
            this.dateEditTransaction = new DevExpress.XtraEditors.DateEdit();
            this.lbDate = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.ChkGetByWeightItem = new DevExpress.XtraEditors.CheckEdit();
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            this.lbTransactionTypeCode = new System.Windows.Forms.Label();
            this.lookupTransactionTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTransactionTypeCode = new DevExpress.XtraEditors.MemoEdit();
            this.lbShift = new System.Windows.Forms.Label();
            this.txtShift = new DevExpress.XtraEditors.TextEdit();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.lbForDepartment = new System.Windows.Forms.Label();
            this.lookUpEditForDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTransactionNo = new DevExpress.XtraEditors.ButtonEdit();
            this.chkConfirm = new DevExpress.XtraEditors.CheckEdit();
            this.lbKhoGiao = new System.Windows.Forms.Label();
            this.lookUpEditKhoGiao = new DevExpress.XtraEditors.LookUpEdit();
            this.lbDVGiao = new System.Windows.Forms.Label();
            this.lookUpEditDVGiao = new DevExpress.XtraEditors.LookUpEdit();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.lbSoDH = new System.Windows.Forms.Label();
            this.lbDVVanChuyen = new System.Windows.Forms.Label();
            this.txtPTVanChuyen = new DevExpress.XtraEditors.TextEdit();
            this.lbPTVanChuyen = new System.Windows.Forms.Label();
            this.txtCTKemTheo = new DevExpress.XtraEditors.TextEdit();
            this.lbCTKemTheo = new System.Windows.Forms.Label();
            this.btnCheck = new DevExpress.XtraEditors.ButtonEdit();
            this.lookUpEditKhoNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.lbKhoNhan = new System.Windows.Forms.Label();
            this.lookUpEditDVNhan = new DevExpress.XtraEditors.LookUpEdit();
            this.lbDVNhan = new System.Windows.Forms.Label();
            this.btnEditSoHD = new DevExpress.XtraEditors.ButtonEdit();
            this.btnEditSoDH = new DevExpress.XtraEditors.ButtonEdit();
            this.lookUpEditDVVanChuyen = new DevExpress.XtraEditors.LookUpEdit();
            this.txtInStockName = new DevExpress.XtraEditors.TextEdit();
            this.txtOutStockName = new DevExpress.XtraEditors.TextEdit();
            this.chkDepartmentConfirm = new DevExpress.XtraEditors.CheckEdit();
            this.lbNguoiNhan = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new DevExpress.XtraEditors.TextEdit();
            this.lbNguoiGiao = new System.Windows.Forms.Label();
            this.txtNguoiGiao = new DevExpress.XtraEditors.TextEdit();
            this.ChkGetByWeightItemContainer = new DevExpress.XtraEditors.CheckEdit();
            this.btnCheckWeightItemContainer = new DevExpress.XtraEditors.ButtonEdit();
            this.lookUpEditVesselCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbVesselCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransportRoute = new DevExpress.XtraEditors.LookUpEdit();
            this.lokDVTC = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPTTC = new DevExpress.XtraEditors.TextEdit();
            this.lblPTTC = new System.Windows.Forms.Label();
            this.lblDVTC = new System.Windows.Forms.Label();
            this.lblTCRoute = new System.Windows.Forms.Label();
            this.txtTCRoute = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVCType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTCType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtVCItemType = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCanme = new System.Windows.Forms.Label();
            this.txtCanmeNo = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupOutLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupInLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityInclWrapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWrappingCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGetByWeightItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditForDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTVanChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCTKemTheo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSoHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSoDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVVanChuyen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutStockName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDepartmentConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiGiao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGetByWeightItemContainer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckWeightItemContainer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVesselCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportRoute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokDVTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCRoute.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVCType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVCItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCanmeNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity1,
            this.colOutLocation,
            this.colInLocation,
            this.colGoodCode});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.ViewCaption = "Chi tiết Lô";
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            this.gridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Số lượng";
            this.colQuantity1.ColumnEdit = this.txtQuantity1;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 0;
            // 
            // txtQuantity1
            // 
            this.txtQuantity1.AutoHeight = false;
            this.txtQuantity1.Mask.EditMask = "n2";
            this.txtQuantity1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity1.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantity1.Name = "txtQuantity1";
            // 
            // colOutLocation
            // 
            this.colOutLocation.Caption = "Lô xuất";
            this.colOutLocation.ColumnEdit = this.LookupOutLocation;
            this.colOutLocation.FieldName = "OutLocation";
            this.colOutLocation.Name = "colOutLocation";
            this.colOutLocation.Width = 120;
            // 
            // LookupOutLocation
            // 
            this.LookupOutLocation.AutoHeight = false;
            this.LookupOutLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupOutLocation.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockLocationCode", "S.lô"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải")});
            this.LookupOutLocation.DisplayMember = "StockLocationCode";
            this.LookupOutLocation.Name = "LookupOutLocation";
            this.LookupOutLocation.NullText = "";
            this.LookupOutLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupOutLocation.ValueMember = "StockLocationCode";
            // 
            // colInLocation
            // 
            this.colInLocation.Caption = "Lô nhập";
            this.colInLocation.ColumnEdit = this.LookupInLocation;
            this.colInLocation.FieldName = "InLocation";
            this.colInLocation.Name = "colInLocation";
            this.colInLocation.Width = 120;
            // 
            // LookupInLocation
            // 
            this.LookupInLocation.AutoHeight = false;
            this.LookupInLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupInLocation.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockLocationCode", "S.lô"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải")});
            this.LookupInLocation.DisplayMember = "StockLocationCode";
            this.LookupInLocation.Name = "LookupInLocation";
            this.LookupInLocation.NullText = "";
            this.LookupInLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupInLocation.ValueMember = "StockLocationCode";
            // 
            // colGoodCode
            // 
            this.colGoodCode.Caption = "Code";
            this.colGoodCode.FieldName = "GoodCode";
            this.colGoodCode.Name = "colGoodCode";
            this.colGoodCode.Visible = true;
            this.colGoodCode.VisibleIndex = 1;
            this.colGoodCode.Width = 163;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "lstStockTransactionDetail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(4, 219);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPriceIn,
            this.txtAmountIn,
            this.LookupOutLocation,
            this.LookupItem,
            this.LookupInLocation,
            this.txtPriceOut,
            this.LookUpItemName,
            this.btnEdit,
            this.txtAmountOut,
            this.txtQuantityReg,
            this.txtQuantityInclWrapping,
            this.txtWrappingCounter,
            this.txtPriceCost,
            this.txtAmountCost,
            this.txtQuantity1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(941, 303);
            this.gridControl1.TabIndex = 28;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colQuantity,
            this.colItemName,
            this.colQuantityReg,
            this.colQuantityInclWrapping,
            this.colWrappingCounter,
            this.colPriceCost,
            this.colAmountCost,
            this.colPriceIn,
            this.colAmountIn,
            this.colPriceOut,
            this.colAmountOut});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.LookupItem;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colItemCode.OptionsFilter.AllowAutoFilter = false;
            this.colItemCode.OptionsFilter.AllowFilter = false;
            this.colItemCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 102;
            // 
            // LookupItem
            // 
            this.LookupItem.AutoHeight = false;
            this.LookupItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", 100, "ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", 200, "ItemName")});
            this.LookupItem.DisplayMember = "ItemCode";
            this.LookupItem.Name = "LookupItem";
            this.LookupItem.NullText = "";
            this.LookupItem.PopupWidth = 300;
            this.LookupItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupItem.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.btnEdit;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsColumn.AllowFocus = false;
            this.colQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:n2}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 114;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdit.Mask.EditMask = "n2";
            this.btnEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnEdit.Mask.UseMaskAsDisplayFormat = true;
            this.btnEdit.Name = "btnEdit";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "ItemName";
            this.colItemName.ColumnEdit = this.LookUpItemName;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.OptionsFilter.AllowAutoFilter = false;
            this.colItemName.OptionsFilter.AllowFilter = false;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 210;
            // 
            // LookUpItemName
            // 
            this.LookUpItemName.AutoHeight = false;
            this.LookUpItemName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpItemName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName")});
            this.LookUpItemName.DisplayMember = "ItemName";
            this.LookUpItemName.Name = "LookUpItemName";
            this.LookUpItemName.NullText = "";
            this.LookUpItemName.ValueMember = "ItemCode";
            // 
            // colQuantityReg
            // 
            this.colQuantityReg.Caption = "Số lượng giao";
            this.colQuantityReg.ColumnEdit = this.txtQuantityReg;
            this.colQuantityReg.DisplayFormat.FormatString = "n2";
            this.colQuantityReg.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityReg.FieldName = "QuantityReg";
            this.colQuantityReg.GroupFormat.FormatString = "n2";
            this.colQuantityReg.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityReg.Name = "colQuantityReg";
            this.colQuantityReg.OptionsColumn.AllowEdit = false;
            this.colQuantityReg.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantityReg.OptionsColumn.ShowInCustomizationForm = false;
            this.colQuantityReg.Visible = true;
            this.colQuantityReg.VisibleIndex = 3;
            this.colQuantityReg.Width = 93;
            // 
            // txtQuantityReg
            // 
            this.txtQuantityReg.AutoHeight = false;
            this.txtQuantityReg.Mask.EditMask = "n2";
            this.txtQuantityReg.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantityReg.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantityReg.Name = "txtQuantityReg";
            // 
            // colQuantityInclWrapping
            // 
            this.colQuantityInclWrapping.Caption = "Số lượng chưa trừ bì";
            this.colQuantityInclWrapping.ColumnEdit = this.txtQuantityInclWrapping;
            this.colQuantityInclWrapping.FieldName = "QuantityInclWrapping";
            this.colQuantityInclWrapping.Name = "colQuantityInclWrapping";
            this.colQuantityInclWrapping.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQuantityInclWrapping.Visible = true;
            this.colQuantityInclWrapping.VisibleIndex = 4;
            this.colQuantityInclWrapping.Width = 113;
            // 
            // txtQuantityInclWrapping
            // 
            this.txtQuantityInclWrapping.AutoHeight = false;
            this.txtQuantityInclWrapping.Mask.EditMask = "n2";
            this.txtQuantityInclWrapping.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantityInclWrapping.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantityInclWrapping.Name = "txtQuantityInclWrapping";
            // 
            // colWrappingCounter
            // 
            this.colWrappingCounter.Caption = "Số bao";
            this.colWrappingCounter.ColumnEdit = this.txtWrappingCounter;
            this.colWrappingCounter.FieldName = "WrappingCounter";
            this.colWrappingCounter.Name = "colWrappingCounter";
            this.colWrappingCounter.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colWrappingCounter.Visible = true;
            this.colWrappingCounter.VisibleIndex = 5;
            // 
            // txtWrappingCounter
            // 
            this.txtWrappingCounter.AutoHeight = false;
            this.txtWrappingCounter.Mask.EditMask = "n0";
            this.txtWrappingCounter.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtWrappingCounter.Mask.UseMaskAsDisplayFormat = true;
            this.txtWrappingCounter.Name = "txtWrappingCounter";
            // 
            // colPriceCost
            // 
            this.colPriceCost.Caption = "Giá vốn";
            this.colPriceCost.ColumnEdit = this.txtPriceCost;
            this.colPriceCost.FieldName = "PriceCost";
            this.colPriceCost.Name = "colPriceCost";
            this.colPriceCost.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPriceCost.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtPriceCost
            // 
            this.txtPriceCost.AutoHeight = false;
            this.txtPriceCost.Mask.EditMask = "n2";
            this.txtPriceCost.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPriceCost.Mask.UseMaskAsDisplayFormat = true;
            this.txtPriceCost.Name = "txtPriceCost";
            // 
            // colAmountCost
            // 
            this.colAmountCost.Caption = "Tiền vốn";
            this.colAmountCost.ColumnEdit = this.txtAmountCost;
            this.colAmountCost.FieldName = "AmountCost";
            this.colAmountCost.Name = "colAmountCost";
            this.colAmountCost.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmountCost.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtAmountCost
            // 
            this.txtAmountCost.AutoHeight = false;
            this.txtAmountCost.Mask.EditMask = "n2";
            this.txtAmountCost.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountCost.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountCost.Name = "txtAmountCost";
            // 
            // colPriceIn
            // 
            this.colPriceIn.Caption = "Giá mua";
            this.colPriceIn.ColumnEdit = this.txtPriceIn;
            this.colPriceIn.FieldName = "PriceIn";
            this.colPriceIn.Name = "colPriceIn";
            this.colPriceIn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPriceIn.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtPriceIn
            // 
            this.txtPriceIn.AutoHeight = false;
            this.txtPriceIn.Mask.EditMask = "n2";
            this.txtPriceIn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPriceIn.Mask.UseMaskAsDisplayFormat = true;
            this.txtPriceIn.Name = "txtPriceIn";
            // 
            // colAmountIn
            // 
            this.colAmountIn.Caption = "Tiền mua";
            this.colAmountIn.ColumnEdit = this.txtAmountIn;
            this.colAmountIn.FieldName = "AmountIn";
            this.colAmountIn.Name = "colAmountIn";
            this.colAmountIn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmountIn.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtAmountIn
            // 
            this.txtAmountIn.AutoHeight = false;
            this.txtAmountIn.Mask.EditMask = "n2";
            this.txtAmountIn.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountIn.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountIn.Name = "txtAmountIn";
            // 
            // colPriceOut
            // 
            this.colPriceOut.Caption = "Giá bán";
            this.colPriceOut.ColumnEdit = this.txtPriceOut;
            this.colPriceOut.FieldName = "PriceOut";
            this.colPriceOut.Name = "colPriceOut";
            this.colPriceOut.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPriceOut.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtPriceOut
            // 
            this.txtPriceOut.AutoHeight = false;
            this.txtPriceOut.Mask.EditMask = "n2";
            this.txtPriceOut.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPriceOut.Mask.UseMaskAsDisplayFormat = true;
            this.txtPriceOut.Name = "txtPriceOut";
            // 
            // colAmountOut
            // 
            this.colAmountOut.Caption = "Tiền bán";
            this.colAmountOut.ColumnEdit = this.txtAmountOut;
            this.colAmountOut.FieldName = "AmountOut";
            this.colAmountOut.Name = "colAmountOut";
            this.colAmountOut.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAmountOut.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // txtAmountOut
            // 
            this.txtAmountOut.AutoHeight = false;
            this.txtAmountOut.Mask.EditMask = "n2";
            this.txtAmountOut.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountOut.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountOut.Name = "txtAmountOut";
            // 
            // lookUpInStock
            // 
            this.lookUpInStock.EnterMoveNextControl = true;
            this.lookUpInStock.Location = new System.Drawing.Point(668, 4);
            this.lookUpInStock.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpInStock.Name = "lookUpInStock";
            this.lookUpInStock.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpInStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpInStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpInStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho")});
            this.lookUpInStock.Properties.DisplayMember = "StockName";
            this.lookUpInStock.Properties.NullText = "";
            this.lookUpInStock.Properties.ValueMember = "StockCode";
            this.lookUpInStock.Size = new System.Drawing.Size(88, 26);
            this.lookUpInStock.TabIndex = 1;
            this.lookUpInStock.Visible = false;
            this.lookUpInStock.EditValueChanged += new System.EventHandler(this.lookUpInStock_EditValueChanged);
            this.lookUpInStock.VisibleChanged += new System.EventHandler(this.lookUpInStock_VisibleChanged);
            this.lookUpInStock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lookUpInStock_MouseMove);
            // 
            // lbInStock
            // 
            this.lbInStock.Location = new System.Drawing.Point(561, 4);
            this.lbInStock.Name = "lbInStock";
            this.lbInStock.Size = new System.Drawing.Size(88, 19);
            this.lbInStock.TabIndex = 29;
            this.lbInStock.Text = "InStock";
            this.lbInStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbOutStock
            // 
            this.lbOutStock.Location = new System.Drawing.Point(23, 6);
            this.lbOutStock.Name = "lbOutStock";
            this.lbOutStock.Size = new System.Drawing.Size(88, 16);
            this.lbOutStock.TabIndex = 26;
            this.lbOutStock.Text = "Kho xuất";
            this.lbOutStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpOutStock
            // 
            this.lookUpOutStock.EnterMoveNextControl = true;
            this.lookUpOutStock.Location = new System.Drawing.Point(117, 4);
            this.lookUpOutStock.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpOutStock.Name = "lookUpOutStock";
            this.lookUpOutStock.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpOutStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpOutStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpOutStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho")});
            this.lookUpOutStock.Properties.DisplayMember = "StockName";
            this.lookUpOutStock.Properties.NullText = "";
            this.lookUpOutStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpOutStock.Properties.ValueMember = "StockCode";
            this.lookUpOutStock.Size = new System.Drawing.Size(88, 26);
            this.lookUpOutStock.TabIndex = 0;
            this.lookUpOutStock.Visible = false;
            this.lookUpOutStock.EditValueChanged += new System.EventHandler(this.lookUpOutStock_EditValueChanged);
            this.lookUpOutStock.VisibleChanged += new System.EventHandler(this.lookUpOutStock_VisibleChanged);
            this.lookUpOutStock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lookUpOutStock_MouseMove);
            // 
            // lbTransactionNo
            // 
            this.lbTransactionNo.Location = new System.Drawing.Point(212, 56);
            this.lbTransactionNo.Name = "lbTransactionNo";
            this.lbTransactionNo.Size = new System.Drawing.Size(63, 16);
            this.lbTransactionNo.TabIndex = 33;
            this.lbTransactionNo.Text = "Số phiếu";
            this.lbTransactionNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditTransaction
            // 
            this.dateEditTransaction.EditValue = new System.DateTime(2006, 12, 28, 0, 0, 0, 0);
            this.dateEditTransaction.EnterMoveNextControl = true;
            this.dateEditTransaction.Location = new System.Drawing.Point(116, 54);
            this.dateEditTransaction.Name = "dateEditTransaction";
            this.dateEditTransaction.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditTransaction.Properties.Appearance.Options.UseFont = true;
            this.dateEditTransaction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTransaction.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditTransaction.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditTransaction.Size = new System.Drawing.Size(88, 26);
            this.dateEditTransaction.TabIndex = 7;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(-1, 56);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(112, 16);
            this.lbDate.TabIndex = 32;
            this.lbDate.Text = "Ngày";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(482, 182);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(461, 21);
            this.txtDescription.TabIndex = 27;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(418, 188);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(75, 20);
            this.lbDescription.TabIndex = 43;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChkGetByWeightItem
            // 
            this.ChkGetByWeightItem.AllowDrop = true;
            this.ChkGetByWeightItem.Location = new System.Drawing.Point(789, 30);
            this.ChkGetByWeightItem.Name = "ChkGetByWeightItem";
            this.ChkGetByWeightItem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGetByWeightItem.Properties.Appearance.Options.UseFont = true;
            this.ChkGetByWeightItem.Properties.Caption = "Phiếu cân xe phao";
            this.ChkGetByWeightItem.Size = new System.Drawing.Size(130, 24);
            this.ChkGetByWeightItem.TabIndex = 22;
            this.ChkGetByWeightItem.CheckedChanged += new System.EventHandler(this.ChkGetByWeightItem_CheckedChanged);
            this.ChkGetByWeightItem.VisibleChanged += new System.EventHandler(this.ChkGetByWeightItem_VisibleChanged);
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(6, 0);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(24, 26);
            this.txtBackGround.TabIndex = 25;
            this.txtBackGround.Visible = false;
            // 
            // lbTransactionTypeCode
            // 
            this.lbTransactionTypeCode.Location = new System.Drawing.Point(57, 31);
            this.lbTransactionTypeCode.Name = "lbTransactionTypeCode";
            this.lbTransactionTypeCode.Size = new System.Drawing.Size(53, 16);
            this.lbTransactionTypeCode.TabIndex = 30;
            this.lbTransactionTypeCode.Text = "Mã NX";
            this.lbTransactionTypeCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookupTransactionTypeCode
            // 
            this.lookupTransactionTypeCode.EnterMoveNextControl = true;
            this.lookupTransactionTypeCode.Location = new System.Drawing.Point(117, 29);
            this.lookupTransactionTypeCode.Margin = new System.Windows.Forms.Padding(4);
            this.lookupTransactionTypeCode.Name = "lookupTransactionTypeCode";
            this.lookupTransactionTypeCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupTransactionTypeCode.Properties.Appearance.Options.UseFont = true;
            this.lookupTransactionTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupTransactionTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeCode", 50, "Mã X/N"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 150, "Diễn giải")});
            this.lookupTransactionTypeCode.Properties.DisplayMember = "TransactionTypeCode";
            this.lookupTransactionTypeCode.Properties.NullText = "";
            this.lookupTransactionTypeCode.Properties.PopupWidth = 200;
            this.lookupTransactionTypeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupTransactionTypeCode.Properties.ValueMember = "TransactionTypeCode";
            this.lookupTransactionTypeCode.Size = new System.Drawing.Size(56, 26);
            this.lookupTransactionTypeCode.TabIndex = 4;
            this.lookupTransactionTypeCode.EditValueChanged += new System.EventHandler(this.lookupTransactionTypeCode_EditValueChanged);
            // 
            // txtTransactionTypeCode
            // 
            this.txtTransactionTypeCode.EnterMoveNextControl = true;
            this.txtTransactionTypeCode.Location = new System.Drawing.Point(178, 29);
            this.txtTransactionTypeCode.Name = "txtTransactionTypeCode";
            this.txtTransactionTypeCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTransactionTypeCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionTypeCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtTransactionTypeCode.Properties.Appearance.Options.UseFont = true;
            this.txtTransactionTypeCode.Properties.MaxLength = 200;
            this.txtTransactionTypeCode.Properties.ReadOnly = true;
            this.txtTransactionTypeCode.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTransactionTypeCode.Size = new System.Drawing.Size(239, 22);
            this.txtTransactionTypeCode.TabIndex = 5;
            // 
            // lbShift
            // 
            this.lbShift.Location = new System.Drawing.Point(433, 57);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(43, 16);
            this.lbShift.TabIndex = 34;
            this.lbShift.Text = "Ca";
            this.lbShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShift
            // 
            this.txtShift.EnterMoveNextControl = true;
            this.txtShift.Location = new System.Drawing.Point(482, 54);
            this.txtShift.Name = "txtShift";
            this.txtShift.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtShift.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Properties.Appearance.Options.UseBackColor = true;
            this.txtShift.Properties.Appearance.Options.UseFont = true;
            this.txtShift.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShift.Properties.Mask.EditMask = "n0";
            this.txtShift.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShift.Properties.MaxLength = 20;
            this.txtShift.Properties.ReadOnly = true;
            this.txtShift.Size = new System.Drawing.Size(38, 26);
            this.txtShift.TabIndex = 9;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(-100, -100);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(81, 16);
            this.lbStatus.TabIndex = 60;
            this.lbStatus.Text = "Status";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbStatus.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(-100, -100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Properties.Appearance.Options.UseBackColor = true;
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.MaxLength = 20;
            this.txtStatus.Properties.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(87, 26);
            this.txtStatus.TabIndex = 61;
            this.txtStatus.Visible = false;
            // 
            // lbForDepartment
            // 
            this.lbForDepartment.Location = new System.Drawing.Point(420, 32);
            this.lbForDepartment.Name = "lbForDepartment";
            this.lbForDepartment.Size = new System.Drawing.Size(59, 16);
            this.lbForDepartment.TabIndex = 31;
            this.lbForDepartment.Text = "Bộ phận";
            this.lbForDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditForDepartment
            // 
            this.lookUpEditForDepartment.EnterMoveNextControl = true;
            this.lookUpEditForDepartment.Location = new System.Drawing.Point(482, 29);
            this.lookUpEditForDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditForDepartment.Name = "lookUpEditForDepartment";
            this.lookUpEditForDepartment.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditForDepartment.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditForDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditForDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText", "EnumText")});
            this.lookUpEditForDepartment.Properties.DisplayMember = "EnumText";
            this.lookUpEditForDepartment.Properties.NullText = "";
            this.lookUpEditForDepartment.Properties.ReadOnly = true;
            this.lookUpEditForDepartment.Properties.ValueMember = "EnumID";
            this.lookUpEditForDepartment.Size = new System.Drawing.Size(156, 26);
            this.lookUpEditForDepartment.TabIndex = 6;
            // 
            // txtTransactionNo
            // 
            this.txtTransactionNo.EnterMoveNextControl = true;
            this.txtTransactionNo.Location = new System.Drawing.Point(275, 54);
            this.txtTransactionNo.Name = "txtTransactionNo";
            this.txtTransactionNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionNo.Properties.Appearance.Options.UseFont = true;
            this.txtTransactionNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtTransactionNo.Size = new System.Drawing.Size(121, 26);
            this.txtTransactionNo.TabIndex = 8;
            this.txtTransactionNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtTransactionNo_ButtonClick);
            // 
            // chkConfirm
            // 
            this.chkConfirm.AllowDrop = true;
            this.chkConfirm.Location = new System.Drawing.Point(855, 8);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirm.Properties.Appearance.Options.UseFont = true;
            this.chkConfirm.Properties.Caption = "Xác nhận";
            this.chkConfirm.Size = new System.Drawing.Size(80, 24);
            this.chkConfirm.TabIndex = 21;
            // 
            // lbKhoGiao
            // 
            this.lbKhoGiao.Location = new System.Drawing.Point(214, 7);
            this.lbKhoGiao.Name = "lbKhoGiao";
            this.lbKhoGiao.Size = new System.Drawing.Size(72, 16);
            this.lbKhoGiao.TabIndex = 27;
            this.lbKhoGiao.Text = "Kho giao";
            this.lbKhoGiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditKhoGiao
            // 
            this.lookUpEditKhoGiao.EnterMoveNextControl = true;
            this.lookUpEditKhoGiao.Location = new System.Drawing.Point(288, 4);
            this.lookUpEditKhoGiao.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditKhoGiao.Name = "lookUpEditKhoGiao";
            this.lookUpEditKhoGiao.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditKhoGiao.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditKhoGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditKhoGiao.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 130, "Tên kho")});
            this.lookUpEditKhoGiao.Properties.DisplayMember = "StockName";
            this.lookUpEditKhoGiao.Properties.NullText = "";
            this.lookUpEditKhoGiao.Properties.PopupWidth = 200;
            this.lookUpEditKhoGiao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditKhoGiao.Properties.ValueMember = "StockCode";
            this.lookUpEditKhoGiao.Size = new System.Drawing.Size(88, 26);
            this.lookUpEditKhoGiao.TabIndex = 2;
            // 
            // lbDVGiao
            // 
            this.lbDVGiao.Location = new System.Drawing.Point(244, 81);
            this.lbDVGiao.Name = "lbDVGiao";
            this.lbDVGiao.Size = new System.Drawing.Size(56, 16);
            this.lbDVGiao.TabIndex = 36;
            this.lbDVGiao.Text = "ĐV giao";
            this.lbDVGiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditDVGiao
            // 
            this.lookUpEditDVGiao.EnterMoveNextControl = true;
            this.lookUpEditDVGiao.Location = new System.Drawing.Point(299, 79);
            this.lookUpEditDVGiao.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditDVGiao.Name = "lookUpEditDVGiao";
            this.lookUpEditDVGiao.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditDVGiao.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditDVGiao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDVGiao.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã ĐV", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", 370, "Tên ĐV")});
            this.lookUpEditDVGiao.Properties.DisplayMember = "SubjectName";
            this.lookUpEditDVGiao.Properties.NullText = "";
            this.lookUpEditDVGiao.Properties.PopupWidth = 450;
            this.lookUpEditDVGiao.Properties.ReadOnly = true;
            this.lookUpEditDVGiao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDVGiao.Properties.ValueMember = "SubjectCode";
            this.lookUpEditDVGiao.Size = new System.Drawing.Size(233, 23);
            this.lookUpEditDVGiao.TabIndex = 11;
            // 
            // lbSoHD
            // 
            this.lbSoHD.Location = new System.Drawing.Point(4, 82);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(106, 16);
            this.lbSoHD.TabIndex = 35;
            this.lbSoHD.Text = "Số HĐ";
            this.lbSoHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSoDH
            // 
            this.lbSoDH.Location = new System.Drawing.Point(514, 81);
            this.lbSoDH.Name = "lbSoDH";
            this.lbSoDH.Size = new System.Drawing.Size(106, 16);
            this.lbSoDH.TabIndex = 37;
            this.lbSoDH.Text = "Lệnh xuất kho";
            this.lbSoDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDVVanChuyen
            // 
            this.lbDVVanChuyen.Location = new System.Drawing.Point(15, 106);
            this.lbDVVanChuyen.Name = "lbDVVanChuyen";
            this.lbDVVanChuyen.Size = new System.Drawing.Size(97, 16);
            this.lbDVVanChuyen.TabIndex = 40;
            this.lbDVVanChuyen.Text = "ĐV vận chuyển";
            this.lbDVVanChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPTVanChuyen
            // 
            this.txtPTVanChuyen.EnterMoveNextControl = true;
            this.txtPTVanChuyen.Location = new System.Drawing.Point(376, 103);
            this.txtPTVanChuyen.Name = "txtPTVanChuyen";
            this.txtPTVanChuyen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTVanChuyen.Properties.Appearance.Options.UseFont = true;
            this.txtPTVanChuyen.Size = new System.Drawing.Size(156, 26);
            this.txtPTVanChuyen.TabIndex = 17;
            // 
            // lbPTVanChuyen
            // 
            this.lbPTVanChuyen.Location = new System.Drawing.Point(275, 105);
            this.lbPTVanChuyen.Name = "lbPTVanChuyen";
            this.lbPTVanChuyen.Size = new System.Drawing.Size(97, 16);
            this.lbPTVanChuyen.TabIndex = 41;
            this.lbPTVanChuyen.Text = "PT vận chuyển";
            this.lbPTVanChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCTKemTheo
            // 
            this.txtCTKemTheo.EnterMoveNextControl = true;
            this.txtCTKemTheo.Location = new System.Drawing.Point(116, 182);
            this.txtCTKemTheo.Name = "txtCTKemTheo";
            this.txtCTKemTheo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCTKemTheo.Properties.Appearance.Options.UseFont = true;
            this.txtCTKemTheo.Size = new System.Drawing.Size(301, 26);
            this.txtCTKemTheo.TabIndex = 26;
            // 
            // lbCTKemTheo
            // 
            this.lbCTKemTheo.Location = new System.Drawing.Point(20, 182);
            this.lbCTKemTheo.Name = "lbCTKemTheo";
            this.lbCTKemTheo.Size = new System.Drawing.Size(86, 16);
            this.lbCTKemTheo.TabIndex = 42;
            this.lbCTKemTheo.Text = "CT kèm theo";
            this.lbCTKemTheo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCheck
            // 
            this.btnCheck.EnterMoveNextControl = true;
            this.btnCheck.Location = new System.Drawing.Point(918, 31);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCheck.Size = new System.Drawing.Size(21, 22);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnCheck_ButtonClick);
            // 
            // lookUpEditKhoNhan
            // 
            this.lookUpEditKhoNhan.EnterMoveNextControl = true;
            this.lookUpEditKhoNhan.Location = new System.Drawing.Point(466, 4);
            this.lookUpEditKhoNhan.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditKhoNhan.Name = "lookUpEditKhoNhan";
            this.lookUpEditKhoNhan.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditKhoNhan.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditKhoNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditKhoNhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 130, "Tên kho")});
            this.lookUpEditKhoNhan.Properties.DisplayMember = "StockName";
            this.lookUpEditKhoNhan.Properties.NullText = "";
            this.lookUpEditKhoNhan.Properties.PopupWidth = 200;
            this.lookUpEditKhoNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditKhoNhan.Properties.ValueMember = "StockCode";
            this.lookUpEditKhoNhan.Size = new System.Drawing.Size(88, 26);
            this.lookUpEditKhoNhan.TabIndex = 3;
            // 
            // lbKhoNhan
            // 
            this.lbKhoNhan.Location = new System.Drawing.Point(392, 7);
            this.lbKhoNhan.Name = "lbKhoNhan";
            this.lbKhoNhan.Size = new System.Drawing.Size(72, 16);
            this.lbKhoNhan.TabIndex = 28;
            this.lbKhoNhan.Text = "Kho nhận";
            this.lbKhoNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditDVNhan
            // 
            this.lookUpEditDVNhan.Location = new System.Drawing.Point(301, 79);
            this.lookUpEditDVNhan.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditDVNhan.Name = "lookUpEditDVNhan";
            this.lookUpEditDVNhan.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditDVNhan.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditDVNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDVNhan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã ĐV", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", 370, "Tên ĐV")});
            this.lookUpEditDVNhan.Properties.DisplayMember = "SubjectName";
            this.lookUpEditDVNhan.Properties.NullText = "";
            this.lookUpEditDVNhan.Properties.PopupWidth = 450;
            this.lookUpEditDVNhan.Properties.ReadOnly = true;
            this.lookUpEditDVNhan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDVNhan.Properties.ValueMember = "SubjectCode";
            this.lookUpEditDVNhan.Size = new System.Drawing.Size(232, 23);
            this.lookUpEditDVNhan.TabIndex = 15;
            // 
            // lbDVNhan
            // 
            this.lbDVNhan.Location = new System.Drawing.Point(243, 81);
            this.lbDVNhan.Name = "lbDVNhan";
            this.lbDVNhan.Size = new System.Drawing.Size(58, 16);
            this.lbDVNhan.TabIndex = 14;
            this.lbDVNhan.Text = "ĐV nhận";
            this.lbDVNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditSoHD
            // 
            this.btnEditSoHD.EnterMoveNextControl = true;
            this.btnEditSoHD.Location = new System.Drawing.Point(116, 79);
            this.btnEditSoHD.Name = "btnEditSoHD";
            this.btnEditSoHD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSoHD.Properties.Appearance.Options.UseFont = true;
            this.btnEditSoHD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditSoHD.Size = new System.Drawing.Size(123, 26);
            this.btnEditSoHD.TabIndex = 10;
            // 
            // btnEditSoDH
            // 
            this.btnEditSoDH.Location = new System.Drawing.Point(626, 79);
            this.btnEditSoDH.Name = "btnEditSoDH";
            this.btnEditSoDH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSoDH.Properties.Appearance.Options.UseFont = true;
            this.btnEditSoDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEditSoDH.Size = new System.Drawing.Size(123, 26);
            this.btnEditSoDH.TabIndex = 86;
            this.btnEditSoDH.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditSoDH_ButtonClick);
            // 
            // lookUpEditDVVanChuyen
            // 
            this.lookUpEditDVVanChuyen.EnterMoveNextControl = true;
            this.lookUpEditDVVanChuyen.Location = new System.Drawing.Point(116, 103);
            this.lookUpEditDVVanChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditDVVanChuyen.Name = "lookUpEditDVVanChuyen";
            this.lookUpEditDVVanChuyen.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditDVVanChuyen.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditDVVanChuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDVVanChuyen.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã ĐV", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", 370, "Tên ĐV")});
            this.lookUpEditDVVanChuyen.Properties.DisplayMember = "SubjectName";
            this.lookUpEditDVVanChuyen.Properties.NullText = "";
            this.lookUpEditDVVanChuyen.Properties.PopupWidth = 450;
            this.lookUpEditDVVanChuyen.Properties.ReadOnly = true;
            this.lookUpEditDVVanChuyen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDVVanChuyen.Properties.ValueMember = "SubjectCode";
            this.lookUpEditDVVanChuyen.Size = new System.Drawing.Size(156, 26);
            this.lookUpEditDVVanChuyen.TabIndex = 16;
            // 
            // txtInStockName
            // 
            this.txtInStockName.Location = new System.Drawing.Point(-100, -100);
            this.txtInStockName.Name = "txtInStockName";
            this.txtInStockName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtInStockName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInStockName.Properties.Appearance.Options.UseBackColor = true;
            this.txtInStockName.Properties.Appearance.Options.UseFont = true;
            this.txtInStockName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInStockName.Properties.Mask.EditMask = "n0";
            this.txtInStockName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInStockName.Properties.MaxLength = 20;
            this.txtInStockName.Properties.ReadOnly = true;
            this.txtInStockName.Size = new System.Drawing.Size(38, 26);
            this.txtInStockName.TabIndex = 88;
            // 
            // txtOutStockName
            // 
            this.txtOutStockName.Location = new System.Drawing.Point(-100, -100);
            this.txtOutStockName.Name = "txtOutStockName";
            this.txtOutStockName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtOutStockName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutStockName.Properties.Appearance.Options.UseBackColor = true;
            this.txtOutStockName.Properties.Appearance.Options.UseFont = true;
            this.txtOutStockName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutStockName.Properties.Mask.EditMask = "n0";
            this.txtOutStockName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOutStockName.Properties.MaxLength = 20;
            this.txtOutStockName.Properties.ReadOnly = true;
            this.txtOutStockName.Size = new System.Drawing.Size(38, 26);
            this.txtOutStockName.TabIndex = 89;
            this.txtOutStockName.VisibleChanged += new System.EventHandler(this.txtOutStockName_VisibleChanged);
            // 
            // chkDepartmentConfirm
            // 
            this.chkDepartmentConfirm.AllowDrop = true;
            this.chkDepartmentConfirm.Location = new System.Drawing.Point(660, 29);
            this.chkDepartmentConfirm.Name = "chkDepartmentConfirm";
            this.chkDepartmentConfirm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDepartmentConfirm.Properties.Appearance.Options.UseFont = true;
            this.chkDepartmentConfirm.Properties.Caption = "Bộ phận xác nhận";
            this.chkDepartmentConfirm.Properties.ReadOnly = true;
            this.chkDepartmentConfirm.Size = new System.Drawing.Size(130, 24);
            this.chkDepartmentConfirm.TabIndex = 7;
            this.chkDepartmentConfirm.TabStop = false;
            // 
            // lbNguoiNhan
            // 
            this.lbNguoiNhan.Location = new System.Drawing.Point(539, 82);
            this.lbNguoiNhan.Name = "lbNguoiNhan";
            this.lbNguoiNhan.Size = new System.Drawing.Size(82, 16);
            this.lbNguoiNhan.TabIndex = 38;
            this.lbNguoiNhan.Text = "Người nhận";
            this.lbNguoiNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.EnterMoveNextControl = true;
            this.txtNguoiNhan.Location = new System.Drawing.Point(627, 79);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNhan.Properties.Appearance.Options.UseFont = true;
            this.txtNguoiNhan.Size = new System.Drawing.Size(232, 26);
            this.txtNguoiNhan.TabIndex = 39;
            // 
            // lbNguoiGiao
            // 
            this.lbNguoiGiao.Location = new System.Drawing.Point(624, 81);
            this.lbNguoiGiao.Name = "lbNguoiGiao";
            this.lbNguoiGiao.Size = new System.Drawing.Size(82, 16);
            this.lbNguoiGiao.TabIndex = 12;
            this.lbNguoiGiao.Text = "Người giao";
            this.lbNguoiGiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoiGiao
            // 
            this.txtNguoiGiao.EnterMoveNextControl = true;
            this.txtNguoiGiao.Location = new System.Drawing.Point(712, 79);
            this.txtNguoiGiao.Name = "txtNguoiGiao";
            this.txtNguoiGiao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGiao.Properties.Appearance.Options.UseFont = true;
            this.txtNguoiGiao.Size = new System.Drawing.Size(232, 26);
            this.txtNguoiGiao.TabIndex = 13;
            // 
            // ChkGetByWeightItemContainer
            // 
            this.ChkGetByWeightItemContainer.AllowDrop = true;
            this.ChkGetByWeightItemContainer.Location = new System.Drawing.Point(789, 52);
            this.ChkGetByWeightItemContainer.Name = "ChkGetByWeightItemContainer";
            this.ChkGetByWeightItemContainer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkGetByWeightItemContainer.Properties.Appearance.Options.UseFont = true;
            this.ChkGetByWeightItemContainer.Properties.Caption = "Phiếu cân xe tải";
            this.ChkGetByWeightItemContainer.Size = new System.Drawing.Size(120, 24);
            this.ChkGetByWeightItemContainer.TabIndex = 90;
            this.ChkGetByWeightItemContainer.CheckedChanged += new System.EventHandler(this.ChkGetByWeightItemContainer_CheckedChanged);
            this.ChkGetByWeightItemContainer.VisibleChanged += new System.EventHandler(this.ChkGetByWeightItemContainer_VisibleChanged);
            // 
            // btnCheckWeightItemContainer
            // 
            this.btnCheckWeightItemContainer.EnterMoveNextControl = true;
            this.btnCheckWeightItemContainer.Location = new System.Drawing.Point(918, 53);
            this.btnCheckWeightItemContainer.Name = "btnCheckWeightItemContainer";
            this.btnCheckWeightItemContainer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnCheckWeightItemContainer.Size = new System.Drawing.Size(21, 22);
            this.btnCheckWeightItemContainer.TabIndex = 91;
            this.btnCheckWeightItemContainer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnCheckWeightItemContainer_ButtonClick);
            // 
            // lookUpEditVesselCode
            // 
            this.lookUpEditVesselCode.EnterMoveNextControl = true;
            this.lookUpEditVesselCode.Location = new System.Drawing.Point(116, 128);
            this.lookUpEditVesselCode.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEditVesselCode.Name = "lookUpEditVesselCode";
            this.lookUpEditVesselCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditVesselCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditVesselCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditVesselCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VesselCode", "Mã tàu", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VesselName", 370, "Tên tàu")});
            this.lookUpEditVesselCode.Properties.DisplayMember = "VesselName";
            this.lookUpEditVesselCode.Properties.NullText = "";
            this.lookUpEditVesselCode.Properties.PopupWidth = 450;
            this.lookUpEditVesselCode.Properties.ReadOnly = true;
            this.lookUpEditVesselCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditVesselCode.Properties.ValueMember = "VesselCode";
            this.lookUpEditVesselCode.Size = new System.Drawing.Size(156, 26);
            this.lookUpEditVesselCode.TabIndex = 19;
            // 
            // lbVesselCode
            // 
            this.lbVesselCode.Location = new System.Drawing.Point(0, 131);
            this.lbVesselCode.Name = "lbVesselCode";
            this.lbVesselCode.Size = new System.Drawing.Size(110, 16);
            this.lbVesselCode.TabIndex = 93;
            this.lbVesselCode.Text = "Tàu vận chuyển";
            this.lbVesselCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Tuyến đường";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTransportRoute
            // 
            this.txtTransportRoute.EnterMoveNextControl = true;
            this.txtTransportRoute.Location = new System.Drawing.Point(377, 128);
            this.txtTransportRoute.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransportRoute.Name = "txtTransportRoute";
            this.txtTransportRoute.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportRoute.Properties.Appearance.Options.UseFont = true;
            this.txtTransportRoute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTransportRoute.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RouteCode", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RouteName", 370, "Tên")});
            this.txtTransportRoute.Properties.DisplayMember = "RouteName";
            this.txtTransportRoute.Properties.NullText = "";
            this.txtTransportRoute.Properties.PopupWidth = 450;
            this.txtTransportRoute.Properties.ReadOnly = true;
            this.txtTransportRoute.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTransportRoute.Properties.ValueMember = "RouteCode";
            this.txtTransportRoute.Size = new System.Drawing.Size(156, 26);
            this.txtTransportRoute.TabIndex = 20;
            // 
            // lokDVTC
            // 
            this.lokDVTC.EnterMoveNextControl = true;
            this.lokDVTC.Location = new System.Drawing.Point(116, 154);
            this.lokDVTC.Margin = new System.Windows.Forms.Padding(4);
            this.lokDVTC.Name = "lokDVTC";
            this.lokDVTC.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lokDVTC.Properties.Appearance.Options.UseFont = true;
            this.lokDVTC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lokDVTC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã ĐV", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", 370, "Tên ĐV")});
            this.lokDVTC.Properties.DisplayMember = "SubjectName";
            this.lokDVTC.Properties.NullText = "";
            this.lokDVTC.Properties.PopupWidth = 450;
            this.lokDVTC.Properties.ReadOnly = true;
            this.lokDVTC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lokDVTC.Properties.ValueMember = "SubjectCode";
            this.lokDVTC.Size = new System.Drawing.Size(156, 26);
            this.lokDVTC.TabIndex = 22;
            // 
            // txtPTTC
            // 
            this.txtPTTC.EnterMoveNextControl = true;
            this.txtPTTC.Location = new System.Drawing.Point(376, 154);
            this.txtPTTC.Name = "txtPTTC";
            this.txtPTTC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTTC.Properties.Appearance.Options.UseFont = true;
            this.txtPTTC.Size = new System.Drawing.Size(156, 26);
            this.txtPTTC.TabIndex = 23;
            // 
            // lblPTTC
            // 
            this.lblPTTC.AutoSize = true;
            this.lblPTTC.Location = new System.Drawing.Point(272, 156);
            this.lblPTTC.Name = "lblPTTC";
            this.lblPTTC.Size = new System.Drawing.Size(131, 20);
            this.lblPTTC.TabIndex = 99;
            this.lblPTTC.Text = "PT trung chuyển";
            this.lblPTTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDVTC
            // 
            this.lblDVTC.AutoSize = true;
            this.lblDVTC.Location = new System.Drawing.Point(7, 157);
            this.lblDVTC.Name = "lblDVTC";
            this.lblDVTC.Size = new System.Drawing.Size(133, 20);
            this.lblDVTC.TabIndex = 98;
            this.lblDVTC.Text = "ĐV trung chuyển";
            this.lblDVTC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTCRoute
            // 
            this.lblTCRoute.AutoSize = true;
            this.lblTCRoute.Location = new System.Drawing.Point(711, 153);
            this.lblTCRoute.Name = "lblTCRoute";
            this.lblTCRoute.Size = new System.Drawing.Size(81, 20);
            this.lblTCRoute.TabIndex = 101;
            this.lblTCRoute.Text = "Tuyến TC";
            this.lblTCRoute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTCRoute
            // 
            this.txtTCRoute.EnterMoveNextControl = true;
            this.txtTCRoute.Location = new System.Drawing.Point(787, 152);
            this.txtTCRoute.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCRoute.Name = "txtTCRoute";
            this.txtTCRoute.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCRoute.Properties.Appearance.Options.UseFont = true;
            this.txtTCRoute.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTCRoute.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RouteCode", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RouteName", 370, "Tên")});
            this.txtTCRoute.Properties.DisplayMember = "RouteName";
            this.txtTCRoute.Properties.NullText = "";
            this.txtTCRoute.Properties.PopupWidth = 450;
            this.txtTCRoute.Properties.ReadOnly = true;
            this.txtTCRoute.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTCRoute.Properties.ValueMember = "RouteCode";
            this.txtTCRoute.Size = new System.Drawing.Size(156, 26);
            this.txtTCRoute.TabIndex = 25;
            // 
            // txtVCType
            // 
            this.txtVCType.EnterMoveNextControl = true;
            this.txtVCType.Location = new System.Drawing.Point(550, 103);
            this.txtVCType.Margin = new System.Windows.Forms.Padding(4);
            this.txtVCType.Name = "txtVCType";
            this.txtVCType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCType.Properties.Appearance.Options.UseFont = true;
            this.txtVCType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVCType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.txtVCType.Properties.DisplayMember = "TypeName";
            this.txtVCType.Properties.NullText = "";
            this.txtVCType.Properties.PopupWidth = 450;
            this.txtVCType.Properties.ShowHeader = false;
            this.txtVCType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtVCType.Properties.ValueMember = "TypeCode";
            this.txtVCType.Size = new System.Drawing.Size(125, 26);
            this.txtVCType.TabIndex = 18;
            // 
            // txtTCType
            // 
            this.txtTCType.EnterMoveNextControl = true;
            this.txtTCType.Location = new System.Drawing.Point(550, 154);
            this.txtTCType.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCType.Name = "txtTCType";
            this.txtTCType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCType.Properties.Appearance.Options.UseFont = true;
            this.txtTCType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTCType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.txtTCType.Properties.DisplayMember = "TypeName";
            this.txtTCType.Properties.NullText = "";
            this.txtTCType.Properties.PopupWidth = 450;
            this.txtTCType.Properties.ShowHeader = false;
            this.txtTCType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTCType.Properties.ValueMember = "TypeCode";
            this.txtTCType.Size = new System.Drawing.Size(125, 26);
            this.txtTCType.TabIndex = 24;
            // 
            // txtVCItemType
            // 
            this.txtVCItemType.EnterMoveNextControl = true;
            this.txtVCItemType.Location = new System.Drawing.Point(787, 126);
            this.txtVCItemType.Margin = new System.Windows.Forms.Padding(4);
            this.txtVCItemType.Name = "txtVCItemType";
            this.txtVCItemType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVCItemType.Properties.Appearance.Options.UseFont = true;
            this.txtVCItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVCItemType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.txtVCItemType.Properties.DisplayMember = "TypeName";
            this.txtVCItemType.Properties.NullText = "";
            this.txtVCItemType.Properties.PopupWidth = 450;
            this.txtVCItemType.Properties.ShowHeader = false;
            this.txtVCItemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtVCItemType.Properties.ValueMember = "TypeCode";
            this.txtVCItemType.Size = new System.Drawing.Size(156, 26);
            this.txtVCItemType.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 105;
            this.label2.Text = "Loại hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCanme
            // 
            this.lblCanme.Location = new System.Drawing.Point(577, 56);
            this.lblCanme.Name = "lblCanme";
            this.lblCanme.Size = new System.Drawing.Size(89, 16);
            this.lblCanme.TabIndex = 106;
            this.lblCanme.Text = "Phiếu cân mẻ";
            this.lblCanme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCanmeNo
            // 
            this.txtCanmeNo.Location = new System.Drawing.Point(665, 53);
            this.txtCanmeNo.Name = "txtCanmeNo";
            this.txtCanmeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCanmeNo.Size = new System.Drawing.Size(121, 22);
            this.txtCanmeNo.TabIndex = 107;
            this.txtCanmeNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCanmeNo_ButtonClick);
            // 
            // DetailStockTransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCanmeNo);
            this.Controls.Add(this.lblCanme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVCItemType);
            this.Controls.Add(this.txtTCType);
            this.Controls.Add(this.txtVCType);
            this.Controls.Add(this.lblTCRoute);
            this.Controls.Add(this.txtTCRoute);
            this.Controls.Add(this.lokDVTC);
            this.Controls.Add(this.txtPTTC);
            this.Controls.Add(this.lblPTTC);
            this.Controls.Add(this.lblDVTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransportRoute);
            this.Controls.Add(this.lbVesselCode);
            this.Controls.Add(this.lookUpEditVesselCode);
            this.Controls.Add(this.lbDVNhan);
            this.Controls.Add(this.btnCheckWeightItemContainer);
            this.Controls.Add(this.ChkGetByWeightItemContainer);
            this.Controls.Add(this.txtNguoiGiao);
            this.Controls.Add(this.lbNguoiGiao);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.lbNguoiNhan);
            this.Controls.Add(this.chkDepartmentConfirm);
            this.Controls.Add(this.txtOutStockName);
            this.Controls.Add(this.txtInStockName);
            this.Controls.Add(this.lookUpEditDVVanChuyen);
            this.Controls.Add(this.btnEditSoDH);
            this.Controls.Add(this.btnEditSoHD);
            this.Controls.Add(this.lookUpEditDVNhan);
            this.Controls.Add(this.lookUpEditKhoNhan);
            this.Controls.Add(this.lbKhoNhan);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCTKemTheo);
            this.Controls.Add(this.lbCTKemTheo);
            this.Controls.Add(this.txtPTVanChuyen);
            this.Controls.Add(this.lbPTVanChuyen);
            this.Controls.Add(this.lbDVVanChuyen);
            this.Controls.Add(this.lbSoDH);
            this.Controls.Add(this.lbSoHD);
            this.Controls.Add(this.lookUpEditDVGiao);
            this.Controls.Add(this.lbDVGiao);
            this.Controls.Add(this.lookUpEditKhoGiao);
            this.Controls.Add(this.lbKhoGiao);
            this.Controls.Add(this.lbTransactionNo);
            this.Controls.Add(this.chkConfirm);
            this.Controls.Add(this.txtTransactionNo);
            this.Controls.Add(this.lookUpEditForDepartment);
            this.Controls.Add(this.lbForDepartment);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.lbShift);
            this.Controls.Add(this.txtTransactionTypeCode);
            this.Controls.Add(this.lookupTransactionTypeCode);
            this.Controls.Add(this.lbTransactionTypeCode);
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ChkGetByWeightItem);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.dateEditTransaction);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbOutStock);
            this.Controls.Add(this.lookUpOutStock);
            this.Controls.Add(this.lbInStock);
            this.Controls.Add(this.lookUpInStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailStockTransactionDetail";
            this.Size = new System.Drawing.Size(948, 529);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupOutLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupInLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityInclWrapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWrappingCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpInStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpOutStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGetByWeightItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditForDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransactionNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTVanChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCTKemTheo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditKhoNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSoHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditSoDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDVVanChuyen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutStockName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDepartmentConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiGiao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkGetByWeightItemContainer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckWeightItemContainer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditVesselCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportRoute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokDVTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCRoute.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVCType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTCType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVCItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCanmeNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpInStock;
        private System.Windows.Forms.Label lbInStock;
        private System.Windows.Forms.Label lbOutStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpOutStock;
        private System.Windows.Forms.Label lbTransactionNo;
        private DevExpress.XtraEditors.DateEdit dateEditTransaction;
        private System.Windows.Forms.Label lbDate;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.CheckEdit ChkGetByWeightItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPriceIn;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtAmountIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupOutLocation;
        private DevExpress.XtraEditors.TextEdit txtBackGround;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupInLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPriceOut;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpItemName;
        private System.Windows.Forms.Label lbTransactionTypeCode;
        private DevExpress.XtraEditors.LookUpEdit lookupTransactionTypeCode;
        private DevExpress.XtraEditors.MemoEdit txtTransactionTypeCode;
        private System.Windows.Forms.Label lbShift;
        private DevExpress.XtraEditors.TextEdit txtShift;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private System.Windows.Forms.Label lbStatus;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private System.Windows.Forms.Label lbForDepartment;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditForDepartment;
        private DevExpress.XtraEditors.ButtonEdit txtTransactionNo;
        private DevExpress.XtraEditors.CheckEdit chkConfirm;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colOutLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colInLocation;
        private System.Windows.Forms.Label lbKhoGiao;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditKhoGiao;
        private System.Windows.Forms.Label lbDVGiao;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDVGiao;
        private System.Windows.Forms.Label lbSoHD;
        private System.Windows.Forms.Label lbSoDH;
        private System.Windows.Forms.Label lbDVVanChuyen;
        private DevExpress.XtraEditors.TextEdit txtPTVanChuyen;
        private System.Windows.Forms.Label lbPTVanChuyen;
        private DevExpress.XtraEditors.TextEdit txtCTKemTheo;
        private System.Windows.Forms.Label lbCTKemTheo;
        private DevExpress.XtraEditors.ButtonEdit btnCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityReg;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityInclWrapping;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingCounter;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceCost;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceIn;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountIn;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceOut;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountOut;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditKhoNhan;
        private System.Windows.Forms.Label lbKhoNhan;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDVNhan;
        private System.Windows.Forms.Label lbDVNhan;
        private DevExpress.XtraEditors.ButtonEdit btnEditSoHD;
        private DevExpress.XtraEditors.ButtonEdit btnEditSoDH;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDVVanChuyen;
        private DevExpress.XtraEditors.TextEdit txtInStockName;
        private DevExpress.XtraEditors.TextEdit txtOutStockName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtQuantityReg;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtAmountOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtQuantityInclWrapping;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtWrappingCounter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPriceCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtAmountCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtQuantity1;
        private DevExpress.XtraEditors.CheckEdit chkDepartmentConfirm;
        private System.Windows.Forms.Label lbNguoiNhan;
        private DevExpress.XtraEditors.TextEdit txtNguoiNhan;
        private System.Windows.Forms.Label lbNguoiGiao;
        private DevExpress.XtraEditors.TextEdit txtNguoiGiao;
        private DevExpress.XtraEditors.CheckEdit ChkGetByWeightItemContainer;
        private DevExpress.XtraEditors.ButtonEdit btnCheckWeightItemContainer;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditVesselCode;
        private System.Windows.Forms.Label lbVesselCode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit txtTransportRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodCode;
        private DevExpress.XtraEditors.LookUpEdit lokDVTC;
        private DevExpress.XtraEditors.TextEdit txtPTTC;
        private System.Windows.Forms.Label lblPTTC;
        private System.Windows.Forms.Label lblDVTC;
        private System.Windows.Forms.Label lblTCRoute;
        private DevExpress.XtraEditors.LookUpEdit txtTCRoute;
        private DevExpress.XtraEditors.LookUpEdit txtVCType;
        private DevExpress.XtraEditors.LookUpEdit txtTCType;
        private DevExpress.XtraEditors.LookUpEdit txtVCItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCanme;
        private DevExpress.XtraEditors.ButtonEdit txtCanmeNo;
    }
}
