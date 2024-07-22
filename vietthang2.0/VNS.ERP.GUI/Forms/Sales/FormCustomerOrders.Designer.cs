namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerOrders
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookCustomerCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFinished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.cboNgay = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpCustomerCodes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriptions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookCustomerCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpCustomerCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.28329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.7167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 485);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookCustomerCode});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(786, 199);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerOrderNo,
            this.colCustomerCode,
            this.colCustomerOrderDate,
            this.colDescription,
            this.colIsFinished,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(627, 558, 208, 170);
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colCustomerOrderNo
            // 
            this.colCustomerOrderNo.Caption = "CustomerOrderNo";
            this.colCustomerOrderNo.FieldName = "CustomerOrderNo";
            this.colCustomerOrderNo.Name = "colCustomerOrderNo";
            this.colCustomerOrderNo.Visible = true;
            this.colCustomerOrderNo.VisibleIndex = 0;
            this.colCustomerOrderNo.Width = 101;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.ColumnEdit = this.ItemLookCustomerCode;
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 3;
            this.colCustomerCode.Width = 229;
            // 
            // ItemLookCustomerCode
            // 
            this.ItemLookCustomerCode.AutoHeight = false;
            this.ItemLookCustomerCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookCustomerCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookCustomerCode.DisplayMember = "SubjectName";
            this.ItemLookCustomerCode.Name = "ItemLookCustomerCode";
            this.ItemLookCustomerCode.NullText = "";
            this.ItemLookCustomerCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookCustomerCode.ValueMember = "SubjectCode";
            // 
            // colCustomerOrderDate
            // 
            this.colCustomerOrderDate.Caption = "CustomerOrderDate";
            this.colCustomerOrderDate.DisplayFormat.FormatString = "d";
            this.colCustomerOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCustomerOrderDate.FieldName = "CustomerOrderDate";
            this.colCustomerOrderDate.Name = "colCustomerOrderDate";
            this.colCustomerOrderDate.Visible = true;
            this.colCustomerOrderDate.VisibleIndex = 1;
            this.colCustomerOrderDate.Width = 84;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 520;
            // 
            // colIsFinished
            // 
            this.colIsFinished.Caption = "IsFinished";
            this.colIsFinished.FieldName = "IsFinished";
            this.colIsFinished.Name = "colIsFinished";
            this.colIsFinished.Visible = true;
            this.colIsFinished.VisibleIndex = 2;
            this.colIsFinished.Width = 112;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91935F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.08064F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(780, 254);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.36951F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.63049F));
            this.tableLayoutPanel3.Controls.Add(this.lblNgay, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboNgay, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(774, 31);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(53, 9);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(32, 13);
            this.lblNgay.TabIndex = 9;
            this.lblNgay.Text = "Ngày";
            // 
            // cboNgay
            // 
            this.cboNgay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNgay.EditValue = new System.DateTime(2007, 4, 25, 9, 18, 5, 30);
            this.cboNgay.Location = new System.Drawing.Point(91, 5);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboNgay.Size = new System.Drawing.Size(133, 20);
            this.cboNgay.TabIndex = 10;
            this.cboNgay.EditValueChanged += new System.EventHandler(this.cboNgay_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpItemCode,
            this.ItemLookUpCustomerCodes});
            this.gridControl1.Size = new System.Drawing.Size(774, 211);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colItemCode,
            this.colQuantity,
            this.colQuantityOut,
            this.colDescriptions});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "CustomerCode";
            this.colCustomerName.ColumnEdit = this.ItemLookUpCustomerCodes;
            this.colCustomerName.FieldName = "CustomerCode";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 209;
            // 
            // ItemLookUpCustomerCodes
            // 
            this.ItemLookUpCustomerCodes.AutoHeight = false;
            this.ItemLookUpCustomerCodes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpCustomerCodes.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpCustomerCodes.DisplayMember = "SubjectName";
            this.ItemLookUpCustomerCodes.Name = "ItemLookUpCustomerCodes";
            this.ItemLookUpCustomerCodes.NullText = "";
            this.ItemLookUpCustomerCodes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpCustomerCodes.ValueMember = "SubjectCode";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.ItemLookUpItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 134;
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
            this.colQuantity.DisplayFormat.FormatString = "n2";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.DisplayFormat = "{0:n0}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 119;
            // 
            // colQuantityOut
            // 
            this.colQuantityOut.Caption = "QuantityOut";
            this.colQuantityOut.DisplayFormat.FormatString = "n2";
            this.colQuantityOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityOut.FieldName = "QuantityOut";
            this.colQuantityOut.Name = "colQuantityOut";
            this.colQuantityOut.OptionsColumn.AllowEdit = false;
            this.colQuantityOut.OptionsColumn.AllowFocus = false;
            this.colQuantityOut.OptionsColumn.ReadOnly = true;
            this.colQuantityOut.Width = 110;
            // 
            // colDescriptions
            // 
            this.colDescriptions.Caption = "Description";
            this.colDescriptions.FieldName = "Description";
            this.colDescriptions.Name = "colDescriptions";
            this.colDescriptions.Visible = true;
            this.colDescriptions.VisibleIndex = 3;
            this.colDescriptions.Width = 844;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(426, 76);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(58, 13);
            this.lblStockCode.TabIndex = 9;
            this.lblStockCode.Text = "StockCode";
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Location = new System.Drawing.Point(500, 71);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã ", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên ", 150)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(142, 22);
            this.lookUpStockCode.TabIndex = 8;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(6, 45);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 105;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(678, 68);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(90, 27);
            this.btnGetData.TabIndex = 106;
            this.btnGetData.Text = "Refresh";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // FormCustomerOrders
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 629);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lookUpStockCode);
            this.GridControl = this.gridControl;
            this.Name = "FormCustomerOrders";
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.FormCustomerOrders_Load);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lblStockCode, 0);
            this.Controls.SetChildIndex(this.ucDatePeriodSelection1, 0);
            this.Controls.SetChildIndex(this.btnGetData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookCustomerCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpCustomerCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFinished;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private System.Windows.Forms.Label lblStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookCustomerCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblNgay;
        private DevExpress.XtraEditors.DateEdit cboNgay;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityOut;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptions;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpCustomerCodes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
    }
}