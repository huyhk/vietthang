namespace VNS.ERP.GUI.Sales
{
    partial class UCCustomerOrderDetail
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
            this.colSaleRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriptionD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCodeYC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSLThucxuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDeliverDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantityOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateCustomerOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCustomerOrderDate = new System.Windows.Forms.Label();
            this.checkIsFinished = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustomerOrderNo = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblCustomerOrderNo = new System.Windows.Forms.Label();
            this.cboCustomerCode = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPhieuyeucau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookItem)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateCustomerOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsFinished.Properties)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaleRequestDate,
            this.colQuantityD,
            this.colDescriptionD});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSaleRequestDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colSaleRequestDate
            // 
            this.colSaleRequestDate.Caption = "Ngày";
            this.colSaleRequestDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colSaleRequestDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaleRequestDate.FieldName = "SaleRequestDate";
            this.colSaleRequestDate.Name = "colSaleRequestDate";
            this.colSaleRequestDate.Visible = true;
            this.colSaleRequestDate.VisibleIndex = 0;
            this.colSaleRequestDate.Width = 103;
            // 
            // colQuantityD
            // 
            this.colQuantityD.Caption = "Số lượng";
            this.colQuantityD.DisplayFormat.FormatString = "{0:###,###,###,###,##0.00}";
            this.colQuantityD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityD.FieldName = "Quantity";
            this.colQuantityD.Name = "colQuantityD";
            this.colQuantityD.SummaryItem.DisplayFormat = "{0:###,###,###,###,##0.00}";
            this.colQuantityD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantityD.Visible = true;
            this.colQuantityD.VisibleIndex = 1;
            this.colQuantityD.Width = 133;
            // 
            // colDescriptionD
            // 
            this.colDescriptionD.Caption = "Ghi chú";
            this.colDescriptionD.FieldName = "Description";
            this.colDescriptionD.Name = "colDescriptionD";
            this.colDescriptionD.Visible = true;
            this.colDescriptionD.VisibleIndex = 2;
            this.colDescriptionD.Width = 640;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "SaleRequests";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookItem});
            this.gridControl1.Size = new System.Drawing.Size(774, 186);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCodeYC,
            this.colSLThucxuat,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colItemCodeYC
            // 
            this.colItemCodeYC.Caption = "ItemCode";
            this.colItemCodeYC.ColumnEdit = this.ItemLookItem;
            this.colItemCodeYC.FieldName = "ItemCode";
            this.colItemCodeYC.Name = "colItemCodeYC";
            this.colItemCodeYC.Visible = true;
            this.colItemCodeYC.VisibleIndex = 0;
            this.colItemCodeYC.Width = 144;
            // 
            // ItemLookItem
            // 
            this.ItemLookItem.AutoHeight = false;
            this.ItemLookItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookItem.DisplayMember = "ItemName";
            this.ItemLookItem.Name = "ItemLookItem";
            this.ItemLookItem.NullText = "";
            this.ItemLookItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookItem.ValueMember = "ItemCode";
            // 
            // colSLThucxuat
            // 
            this.colSLThucxuat.Caption = "SLThucxuat";
            this.colSLThucxuat.DisplayFormat.FormatString = "{0:###,###,###,###,##0.00}";
            this.colSLThucxuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSLThucxuat.FieldName = "SLThucxuat";
            this.colSLThucxuat.Name = "colSLThucxuat";
            this.colSLThucxuat.SummaryItem.DisplayFormat = "{0:###,###,###,###,##0.00}";
            this.colSLThucxuat.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSLThucxuat.Visible = true;
            this.colSLThucxuat.VisibleIndex = 1;
            this.colSLThucxuat.Width = 111;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "QuantityOut";
            this.gridColumn4.DisplayFormat.FormatString = "{0:###,###,###,###,###,##0.00}";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "QuantityOut";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Width = 110;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPhieuyeucau, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.10145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.89855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 125);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpItemCode,
            this.ItemTextFormat,
            this.ItemDateEdit});
            this.gridControl.Size = new System.Drawing.Size(780, 182);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDeliverDate,
            this.colItemCode,
            this.colQuantity,
            this.colQuantityOut,
            this.colDescription});
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colDeliverDate
            // 
            this.colDeliverDate.Caption = "DeliverDate";
            this.colDeliverDate.ColumnEdit = this.ItemDateEdit;
            this.colDeliverDate.DisplayFormat.FormatString = "d";
            this.colDeliverDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDeliverDate.FieldName = "DeliverDate";
            this.colDeliverDate.Name = "colDeliverDate";
            this.colDeliverDate.Visible = true;
            this.colDeliverDate.VisibleIndex = 0;
            this.colDeliverDate.Width = 90;
            // 
            // ItemDateEdit
            // 
            this.ItemDateEdit.AutoHeight = false;
            this.ItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
            this.ItemDateEdit.Name = "ItemDateEdit";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.ItemLookUpItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 144;
            // 
            // ItemLookUpItemCode
            // 
            this.ItemLookUpItemCode.AutoHeight = false;
            this.ItemLookUpItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpItemCode.DisplayMember = "ItemName";
            this.ItemLookUpItemCode.Name = "ItemLookUpItemCode";
            this.ItemLookUpItemCode.NullText = "";
            this.ItemLookUpItemCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpItemCode.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.ItemTextFormat;
            this.colQuantity.DisplayFormat.FormatString = "{0:###,###,###,###,##0}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.DisplayFormat = "{0:###,###,###,##0}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 111;
            // 
            // ItemTextFormat
            // 
            this.ItemTextFormat.AutoHeight = false;
            this.ItemTextFormat.Mask.EditMask = "n0";
            this.ItemTextFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextFormat.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextFormat.Name = "ItemTextFormat";
            this.ItemTextFormat.ValidateOnEnterKey = true;
            // 
            // colQuantityOut
            // 
            this.colQuantityOut.Caption = "QuantityOut";
            this.colQuantityOut.DisplayFormat.FormatString = "{0:###,###,###,###,###,##0.00}";
            this.colQuantityOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityOut.FieldName = "QuantityOut";
            this.colQuantityOut.Name = "colQuantityOut";
            this.colQuantityOut.OptionsColumn.AllowEdit = false;
            this.colQuantityOut.OptionsColumn.AllowFocus = false;
            this.colQuantityOut.OptionsColumn.ReadOnly = true;
            this.colQuantityOut.Width = 110;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 484;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.43372F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.56628F));
            this.tableLayoutPanel2.Controls.Add(this.lblStockCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lookUpStockCode, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 26);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // lblStockCode
            // 
            this.lblStockCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockCode.Location = new System.Drawing.Point(61, 5);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(88, 16);
            this.lblStockCode.TabIndex = 63;
            this.lblStockCode.Text = "Stock Code";
            this.lblStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(152, 3);
            this.lookUpStockCode.Margin = new System.Windows.Forms.Padding(0);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.BackColor = System.Drawing.Color.Azure;
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 40),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 160)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(166, 20);
            this.lookUpStockCode.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 205);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã bán";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.33842F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.66158F));
            this.tableLayoutPanel4.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(786, 43);
            this.tableLayoutPanel4.TabIndex = 3;
            this.tableLayoutPanel4.TabStop = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(152, 1);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(599, 41);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.Location = new System.Drawing.Point(67, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 16);
            this.lblDescription.TabIndex = 65;
            this.lblDescription.Text = "Desciption";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35897F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.51282F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel3.Controls.Add(this.dateCustomerOrderDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCustomerOrderDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkIsFinished, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 26);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.TabStop = true;
            // 
            // dateCustomerOrderDate
            // 
            this.dateCustomerOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateCustomerOrderDate.EditValue = new System.DateTime(2007, 3, 6, 0, 0, 0, 0);
            this.dateCustomerOrderDate.EnterMoveNextControl = true;
            this.dateCustomerOrderDate.Location = new System.Drawing.Point(152, 3);
            this.dateCustomerOrderDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateCustomerOrderDate.Name = "dateCustomerOrderDate";
            this.dateCustomerOrderDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateCustomerOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.dateCustomerOrderDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCustomerOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.dateCustomerOrderDate.Properties.Appearance.Options.UseFont = true;
            this.dateCustomerOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCustomerOrderDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateCustomerOrderDate.Size = new System.Drawing.Size(166, 20);
            this.dateCustomerOrderDate.TabIndex = 3;
            // 
            // lblCustomerOrderDate
            // 
            this.lblCustomerOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomerOrderDate.Location = new System.Drawing.Point(37, 5);
            this.lblCustomerOrderDate.Name = "lblCustomerOrderDate";
            this.lblCustomerOrderDate.Size = new System.Drawing.Size(112, 16);
            this.lblCustomerOrderDate.TabIndex = 64;
            this.lblCustomerOrderDate.Text = "CustomerOrderDate";
            this.lblCustomerOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkIsFinished
            // 
            this.checkIsFinished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkIsFinished.Location = new System.Drawing.Point(434, 3);
            this.checkIsFinished.Name = "checkIsFinished";
            this.checkIsFinished.Properties.Caption = "IsFinished";
            this.checkIsFinished.Size = new System.Drawing.Size(167, 19);
            this.checkIsFinished.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.43372F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.26512F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.38481F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.87344F));
            this.tableLayoutPanel5.Controls.Add(this.txtCustomerOrderNo, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCustomerCode, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCustomerOrderNo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboCustomerCode, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(786, 27);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.TabStop = true;
            // 
            // txtCustomerOrderNo
            // 
            this.txtCustomerOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerOrderNo.EnterMoveNextControl = true;
            this.txtCustomerOrderNo.Location = new System.Drawing.Point(152, 3);
            this.txtCustomerOrderNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustomerOrderNo.Name = "txtCustomerOrderNo";
            this.txtCustomerOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerOrderNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCustomerOrderNo.Size = new System.Drawing.Size(166, 20);
            this.txtCustomerOrderNo.TabIndex = 1;
            this.txtCustomerOrderNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCustomerOrderNo_ButtonClick);
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomerCode.Location = new System.Drawing.Point(331, 5);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerCode.TabIndex = 64;
            this.lblCustomerCode.Text = "CustomerCode";
            this.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerOrderNo
            // 
            this.lblCustomerOrderNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomerOrderNo.Location = new System.Drawing.Point(46, 5);
            this.lblCustomerOrderNo.Name = "lblCustomerOrderNo";
            this.lblCustomerOrderNo.Size = new System.Drawing.Size(103, 16);
            this.lblCustomerOrderNo.TabIndex = 64;
            this.lblCustomerOrderNo.Text = "CustomerOrderNo";
            this.lblCustomerOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCustomerCode
            // 
            this.cboCustomerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCustomerCode.EnterMoveNextControl = true;
            this.cboCustomerCode.Location = new System.Drawing.Point(432, 3);
            this.cboCustomerCode.Margin = new System.Windows.Forms.Padding(0);
            this.cboCustomerCode.Name = "cboCustomerCode";
            this.cboCustomerCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerCode.Properties.Appearance.Options.UseFont = true;
            this.cboCustomerCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên", 220)});
            this.cboCustomerCode.Properties.DisplayMember = "SubjectName";
            this.cboCustomerCode.Properties.NullText = "";
            this.cboCustomerCode.Properties.PopupWidth = 300;
            this.cboCustomerCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboCustomerCode.Properties.ValueMember = "SubjectCode";
            this.cboCustomerCode.Size = new System.Drawing.Size(167, 20);
            this.cboCustomerCode.TabIndex = 2;
            // 
            // btnPhieuyeucau
            // 
            this.btnPhieuyeucau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhieuyeucau.Location = new System.Drawing.Point(308, 524);
            this.btnPhieuyeucau.Name = "btnPhieuyeucau";
            this.btnPhieuyeucau.Size = new System.Drawing.Size(170, 30);
            this.btnPhieuyeucau.TabIndex = 4;
            this.btnPhieuyeucau.Text = "Tạo phiếu yêu cầu";
            this.btnPhieuyeucau.Click += new System.EventHandler(this.btnPhieuyeucau_Click);
            // 
            // UCCustomerOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCCustomerOrderDetail";
            this.Size = new System.Drawing.Size(786, 557);
            this.Load += new System.EventHandler(this.UCCustomerOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookItem)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateCustomerOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIsFinished.Properties)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private DevExpress.XtraEditors.DateEdit dateCustomerOrderDate;
        private System.Windows.Forms.Label lblCustomerOrderDate;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCustomerOrderNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.CheckEdit checkIsFinished;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LookUpEdit cboCustomerCode;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliverDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityOut;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCodeYC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookItem;
        private DevExpress.XtraGrid.Columns.GridColumn colSLThucxuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityD;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleRequestDate;
        private DevExpress.XtraEditors.SimpleButton btnPhieuyeucau;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptionD;
        private DevExpress.XtraEditors.ButtonEdit txtCustomerOrderNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ItemDateEdit;
    }
}
