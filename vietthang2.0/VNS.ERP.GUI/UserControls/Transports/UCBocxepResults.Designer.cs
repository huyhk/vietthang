
namespace VNS.ERP.GUI.Transports
{
    partial class UCBocxepResults
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtEditSonguoi = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repBtnEditStockTransactionNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colStockTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repNumberic = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repLookUpBocxepTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpWorkingType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpToBocxepCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTxtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBocxepTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkingType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToBocxepCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.styleController2 = new DevExpress.XtraEditors.StyleController(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienGiai = new DevExpress.XtraEditors.MemoEdit();
            this.lookUpEditSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.txtToDate = new DevExpress.XtraEditors.DateEdit();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtContract = new DevExpress.XtraEditors.ButtonEdit();
            this.btnSelectST = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtEditSonguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnEditStockTransactionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTypeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBocxepTypeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpWorkingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpToBocxepCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContract.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colQuantity});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.repLookUpItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 170;
            // 
            // repLookUpItemCode
            // 
            this.repLookUpItemCode.AutoHeight = false;
            this.repLookUpItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpItemCode.DisplayMember = "ItemName";
            this.repLookUpItemCode.Name = "repLookUpItemCode";
            this.repLookUpItemCode.NullText = "";
            this.repLookUpItemCode.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.repTxtEditSonguoi;
            this.colQuantity.DisplayFormat.FormatString = "n0";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsColumn.ReadOnly = true;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 116;
            // 
            // repTxtEditSonguoi
            // 
            this.repTxtEditSonguoi.AutoHeight = false;
            this.repTxtEditSonguoi.Mask.EditMask = "n0";
            this.repTxtEditSonguoi.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtEditSonguoi.Name = "repTxtEditSonguoi";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 4);
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "ListDetail3";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "ListDetail2";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 153);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTypeCode,
            this.repositoryItemSpinEdit1,
            this.repNumberic,
            this.repBtnEditStockTransactionNo,
            this.repLookUpItemCode,
            this.repLookUpBocxepTypeCode,
            this.repLookUpWorkingType,
            this.repLookUpToBocxepCode,
            this.repTxtEditSonguoi,
            this.repTxtQuantity});
            this.gridControl1.Size = new System.Drawing.Size(704, 187);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockTransactionNo,
            this.colStockTransactionDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colStockTransactionNo
            // 
            this.colStockTransactionNo.Caption = "StockTransactionNo";
            this.colStockTransactionNo.ColumnEdit = this.repBtnEditStockTransactionNo;
            this.colStockTransactionNo.FieldName = "StockTransactionNo";
            this.colStockTransactionNo.Name = "colStockTransactionNo";
            this.colStockTransactionNo.OptionsColumn.ReadOnly = true;
            this.colStockTransactionNo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colStockTransactionNo.Visible = true;
            this.colStockTransactionNo.VisibleIndex = 0;
            this.colStockTransactionNo.Width = 130;
            // 
            // repBtnEditStockTransactionNo
            // 
            this.repBtnEditStockTransactionNo.AutoHeight = false;
            this.repBtnEditStockTransactionNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repBtnEditStockTransactionNo.Name = "repBtnEditStockTransactionNo";
            this.repBtnEditStockTransactionNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repBtnEditStockTransactionNo_ButtonClick);
            // 
            // colStockTransactionDate
            // 
            this.colStockTransactionDate.Caption = "StockTransactionDate";
            this.colStockTransactionDate.DisplayFormat.FormatString = "d";
            this.colStockTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStockTransactionDate.FieldName = "StockTransactionDate";
            this.colStockTransactionDate.Name = "colStockTransactionDate";
            this.colStockTransactionDate.OptionsColumn.AllowEdit = false;
            this.colStockTransactionDate.Visible = true;
            this.colStockTransactionDate.VisibleIndex = 1;
            this.colStockTransactionDate.Width = 137;
            // 
            // repTypeCode
            // 
            this.repTypeCode.AutoHeight = false;
            this.repTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeCode", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repTypeCode.DisplayMember = "TypeName";
            this.repTypeCode.Name = "repTypeCode";
            this.repTypeCode.NullText = "";
            this.repTypeCode.PopupWidth = 400;
            this.repTypeCode.ValueMember = "TypeCode";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.UseCtrlIncrement = true;
            // 
            // repNumberic
            // 
            this.repNumberic.AutoHeight = false;
            this.repNumberic.Mask.EditMask = "n0";
            this.repNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic.Name = "repNumberic";
            // 
            // repLookUpBocxepTypeCode
            // 
            this.repLookUpBocxepTypeCode.AutoHeight = false;
            this.repLookUpBocxepTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpBocxepTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceName", "Tên", 250)});
            this.repLookUpBocxepTypeCode.DisplayMember = "ServiceName";
            this.repLookUpBocxepTypeCode.Name = "repLookUpBocxepTypeCode";
            this.repLookUpBocxepTypeCode.NullText = "";
            this.repLookUpBocxepTypeCode.PopupWidth = 400;
            this.repLookUpBocxepTypeCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpBocxepTypeCode.ValueMember = "ServiceID";
            // 
            // repLookUpWorkingType
            // 
            this.repLookUpWorkingType.AutoHeight = false;
            this.repLookUpWorkingType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpWorkingType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeCode", "Mã", 75),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Tên", 150)});
            this.repLookUpWorkingType.DisplayMember = "TypeName";
            this.repLookUpWorkingType.Name = "repLookUpWorkingType";
            this.repLookUpWorkingType.NullText = "";
            this.repLookUpWorkingType.PopupWidth = 250;
            this.repLookUpWorkingType.ValueMember = "TypeCode";
            // 
            // repLookUpToBocxepCode
            // 
            this.repLookUpToBocxepCode.AutoHeight = false;
            this.repLookUpToBocxepCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpToBocxepCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToBocxepCode", "Mã", 75),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToBocxepName", "Tên", 150)});
            this.repLookUpToBocxepCode.DisplayMember = "ToBocxepName";
            this.repLookUpToBocxepCode.Name = "repLookUpToBocxepCode";
            this.repLookUpToBocxepCode.NullText = "";
            this.repLookUpToBocxepCode.PopupWidth = 250;
            this.repLookUpToBocxepCode.ValueMember = "ToBocxepCode";
            // 
            // repTxtQuantity
            // 
            this.repTxtQuantity.AutoHeight = false;
            this.repTxtQuantity.Mask.EditMask = "n0";
            this.repTxtQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtQuantity.Name = "repTxtQuantity";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBocxepTypeCode,
            this.colWorkingType,
            this.colToBocxepCode,
            this.colSonguoi,
            this.colQuantity3});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsCustomization.AllowFilter = false;
            this.gridView3.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.GotFocus += new System.EventHandler(this.gridView3_GotFocus);
            this.gridView3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView3_KeyDown);
            // 
            // colBocxepTypeCode
            // 
            this.colBocxepTypeCode.Caption = "Công việc";
            this.colBocxepTypeCode.ColumnEdit = this.repLookUpBocxepTypeCode;
            this.colBocxepTypeCode.FieldName = "ServiceID";
            this.colBocxepTypeCode.Name = "colBocxepTypeCode";
            this.colBocxepTypeCode.Visible = true;
            this.colBocxepTypeCode.VisibleIndex = 0;
            this.colBocxepTypeCode.Width = 246;
            // 
            // colWorkingType
            // 
            this.colWorkingType.Caption = "WorkingType";
            this.colWorkingType.ColumnEdit = this.repLookUpWorkingType;
            this.colWorkingType.FieldName = "WorkingType";
            this.colWorkingType.Name = "colWorkingType";
            this.colWorkingType.Visible = true;
            this.colWorkingType.VisibleIndex = 1;
            this.colWorkingType.Width = 96;
            // 
            // colToBocxepCode
            // 
            this.colToBocxepCode.Caption = "ToBocxepCode";
            this.colToBocxepCode.ColumnEdit = this.repLookUpToBocxepCode;
            this.colToBocxepCode.FieldName = "ToBocxepCode";
            this.colToBocxepCode.Name = "colToBocxepCode";
            this.colToBocxepCode.Visible = true;
            this.colToBocxepCode.VisibleIndex = 2;
            this.colToBocxepCode.Width = 156;
            // 
            // colSonguoi
            // 
            this.colSonguoi.Caption = "Songuoi";
            this.colSonguoi.ColumnEdit = this.repTxtEditSonguoi;
            this.colSonguoi.DisplayFormat.FormatString = "n0";
            this.colSonguoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSonguoi.FieldName = "Songuoi";
            this.colSonguoi.Name = "colSonguoi";
            this.colSonguoi.Visible = true;
            this.colSonguoi.VisibleIndex = 3;
            this.colSonguoi.Width = 92;
            // 
            // colQuantity3
            // 
            this.colQuantity3.Caption = "Quantity";
            this.colQuantity3.ColumnEdit = this.repTxtQuantity;
            this.colQuantity3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity3.FieldName = "Quantity";
            this.colQuantity3.Name = "colQuantity3";
            this.colQuantity3.Visible = true;
            this.colQuantity3.VisibleIndex = 4;
            this.colQuantity3.Width = 92;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoadData, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNgayt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDienGiai, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditSubject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditStockCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFromDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtToDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContract, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtContract, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectST, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadData.Location = new System.Drawing.Point(24, 128);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(36, 19);
            this.btnLoadData.TabIndex = 14;
            this.btnLoadData.Text = "+";
            this.btnLoadData.ToolTip = "Expand All";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn vị bốc xếp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNgayt
            // 
            this.lblNgayt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgayt.AutoSize = true;
            this.lblNgayt.Location = new System.Drawing.Point(36, 31);
            this.lblNgayt.Name = "lblNgayt";
            this.lblNgayt.Size = new System.Drawing.Size(46, 13);
            this.lblNgayt.TabIndex = 6;
            this.lblNgayt.Text = "Từ ngày";
            this.lblNgayt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đến ngày";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diễn giải";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDienGiai
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDienGiai, 3);
            this.txtDienGiai.EnterMoveNextControl = true;
            this.txtDienGiai.Location = new System.Drawing.Point(88, 78);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(447, 44);
            this.txtDienGiai.TabIndex = 5;
            // 
            // lookUpEditSubject
            // 
            this.lookUpEditSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEditSubject.EnterMoveNextControl = true;
            this.lookUpEditSubject.Location = new System.Drawing.Point(88, 3);
            this.lookUpEditSubject.Name = "lookUpEditSubject";
            this.lookUpEditSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.lookUpEditSubject.Properties.DisplayMember = "SubjectName";
            this.lookUpEditSubject.Properties.NullText = "";
            this.lookUpEditSubject.Properties.ReadOnly = true;
            this.lookUpEditSubject.Properties.ValueMember = "SubjectCode";
            this.lookUpEditSubject.Size = new System.Drawing.Size(244, 20);
            this.lookUpEditSubject.TabIndex = 1;
            // 
            // lookUpEditStockCode
            // 
            this.lookUpEditStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpEditStockCode.EnterMoveNextControl = true;
            this.lookUpEditStockCode.Location = new System.Drawing.Point(406, 3);
            this.lookUpEditStockCode.Name = "lookUpEditStockCode";
            this.lookUpEditStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.lookUpEditStockCode.Properties.DisplayMember = "StockName";
            this.lookUpEditStockCode.Properties.NullText = "";
            this.lookUpEditStockCode.Properties.ReadOnly = true;
            this.lookUpEditStockCode.Properties.ValueMember = "StockCode";
            this.lookUpEditStockCode.Size = new System.Drawing.Size(129, 20);
            this.lookUpEditStockCode.TabIndex = 2;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFromDate.EditValue = new System.DateTime(2008, 5, 27, 0, 0, 0, 0);
            this.txtFromDate.EnterMoveNextControl = true;
            this.txtFromDate.Location = new System.Drawing.Point(88, 28);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFromDate.Size = new System.Drawing.Size(92, 20);
            this.txtFromDate.TabIndex = 3;
            // 
            // txtToDate
            // 
            this.txtToDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtToDate.EditValue = new System.DateTime(2008, 5, 27, 0, 0, 0, 0);
            this.txtToDate.EnterMoveNextControl = true;
            this.txtToDate.Location = new System.Drawing.Point(406, 28);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtToDate.Size = new System.Drawing.Size(88, 20);
            this.txtToDate.TabIndex = 4;
            // 
            // lblContract
            // 
            this.lblContract.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(27, 56);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(55, 13);
            this.lblContract.TabIndex = 11;
            this.lblContract.Text = "Hợp đồng";
            this.lblContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(88, 53);
            this.txtContract.Name = "txtContract";
            this.txtContract.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtContract.Size = new System.Drawing.Size(244, 20);
            this.txtContract.TabIndex = 12;
            this.txtContract.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtContract_ButtonClick);
            this.txtContract.EditValueChanged += new System.EventHandler(this.txtContract_EditValueChanged);
            // 
            // btnSelectST
            // 
            this.btnSelectST.Location = new System.Drawing.Point(85, 125);
            this.btnSelectST.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectST.Name = "btnSelectST";
            this.btnSelectST.Size = new System.Drawing.Size(154, 25);
            this.btnSelectST.TabIndex = 13;
            this.btnSelectST.Text = "Chọn phiếu xuất nhập kho...";
            this.btnSelectST.Click += new System.EventHandler(this.btnSelectST_Click);
            // 
            // UCBocxepResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCBocxepResults";
            this.Size = new System.Drawing.Size(716, 353);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtEditSonguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBtnEditStockTransactionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTypeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBocxepTypeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpWorkingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpToBocxepCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContract.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.StyleController styleController2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit txtDienGiai;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSubject;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStockCode;
        private DevExpress.XtraEditors.DateEdit txtFromDate;
        private DevExpress.XtraEditors.DateEdit txtToDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colBocxepTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkingType;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colToBocxepCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSonguoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBtnEditStockTransactionNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpBocxepTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpWorkingType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpToBocxepCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtEditSonguoi;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtQuantity;
        private System.Windows.Forms.Label lblContract;
        private DevExpress.XtraEditors.ButtonEdit txtContract;
        private DevExpress.XtraEditors.SimpleButton btnSelectST;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
    }
}
