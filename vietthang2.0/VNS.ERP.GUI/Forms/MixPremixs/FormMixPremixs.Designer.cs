namespace VNS.ERP.GUI
{
    partial class FormMixPremixs
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPremixCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrapping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPremixWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrappingWaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMixpremixID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMixDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAddnew = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pTaoPX1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTaoPX = new DevExpress.XtraEditors.SimpleButton();
            this.pXoaPX2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoaPX = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKho = new System.Windows.Forms.Label();
            this.cbokho = new DevExpress.XtraEditors.LookUpEdit();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboPeriodCode = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEmployee)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pTaoPX1)).BeginInit();
            this.pTaoPX1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pXoaPX2)).BeginInit();
            this.pXoaPX2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbokho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPremixCode,
            this.colFormulaCode,
            this.gridColumn1,
            this.colNap,
            this.colWrapping,
            this.colPremixWeight,
            this.colWrappingWaste,
            this.colDescription,
            this.colMixpremixID,
            this.colUserUpdated1,
            this.colDateCreated1,
            this.colDateUpdated1,
            this.colUserCreated1});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.HorzScrollStep = 5;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            // 
            // colPremixCode
            // 
            this.colPremixCode.Caption = "Thuốc";
            this.colPremixCode.FieldName = "PremixCode";
            this.colPremixCode.Name = "colPremixCode";
            this.colPremixCode.OptionsColumn.AllowEdit = false;
            this.colPremixCode.OptionsColumn.AllowFocus = false;
            this.colPremixCode.OptionsColumn.ReadOnly = true;
            this.colPremixCode.OptionsFilter.AllowAutoFilter = false;
            this.colPremixCode.OptionsFilter.AllowFilter = false;
            this.colPremixCode.Visible = true;
            this.colPremixCode.VisibleIndex = 0;
            this.colPremixCode.Width = 94;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "Công thức";
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.OptionsColumn.AllowEdit = false;
            this.colFormulaCode.OptionsColumn.AllowFocus = false;
            this.colFormulaCode.OptionsColumn.ReadOnly = true;
            this.colFormulaCode.OptionsFilter.AllowAutoFilter = false;
            this.colFormulaCode.OptionsFilter.AllowFilter = false;
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 1;
            this.colFormulaCode.Width = 102;
            // 
            // colNap
            // 
            this.colNap.Caption = "Số lượng nạp(Kg)";
            this.colNap.DisplayFormat.FormatString = "{0:###,###,###,##0.00}";
            this.colNap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNap.FieldName = "Nap";
            this.colNap.Name = "colNap";
            this.colNap.OptionsColumn.AllowEdit = false;
            this.colNap.OptionsColumn.AllowFocus = false;
            this.colNap.OptionsColumn.ReadOnly = true;
            this.colNap.OptionsFilter.AllowAutoFilter = false;
            this.colNap.OptionsFilter.AllowFilter = false;
            this.colNap.Visible = true;
            this.colNap.VisibleIndex = 3;
            this.colNap.Width = 103;
            // 
            // colWrapping
            // 
            this.colWrapping.Caption = "Bao bì sử dụng";
            this.colWrapping.DisplayFormat.FormatString = "{0:###,###,###,##0}";
            this.colWrapping.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWrapping.FieldName = "Wrapping";
            this.colWrapping.Name = "colWrapping";
            this.colWrapping.OptionsColumn.AllowEdit = false;
            this.colWrapping.OptionsColumn.AllowFocus = false;
            this.colWrapping.OptionsColumn.ReadOnly = true;
            this.colWrapping.OptionsFilter.AllowAutoFilter = false;
            this.colWrapping.OptionsFilter.AllowFilter = false;
            this.colWrapping.Visible = true;
            this.colWrapping.VisibleIndex = 4;
            this.colWrapping.Width = 106;
            // 
            // colPremixWeight
            // 
            this.colPremixWeight.Caption = "Số lượng(Kg)";
            this.colPremixWeight.DisplayFormat.FormatString = "{0:###,###,###,##0.00}";
            this.colPremixWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPremixWeight.FieldName = "PremixWeight";
            this.colPremixWeight.Name = "colPremixWeight";
            this.colPremixWeight.OptionsColumn.AllowEdit = false;
            this.colPremixWeight.OptionsColumn.AllowFocus = false;
            this.colPremixWeight.OptionsColumn.ReadOnly = true;
            this.colPremixWeight.OptionsFilter.AllowAutoFilter = false;
            this.colPremixWeight.OptionsFilter.AllowFilter = false;
            this.colPremixWeight.Visible = true;
            this.colPremixWeight.VisibleIndex = 5;
            this.colPremixWeight.Width = 84;
            // 
            // colWrappingWaste
            // 
            this.colWrappingWaste.Caption = "Bao bì hư";
            this.colWrappingWaste.DisplayFormat.FormatString = "{0:###,###,###,##0}";
            this.colWrappingWaste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWrappingWaste.FieldName = "WrappingWaste";
            this.colWrappingWaste.Name = "colWrappingWaste";
            this.colWrappingWaste.OptionsColumn.AllowEdit = false;
            this.colWrappingWaste.OptionsColumn.AllowFocus = false;
            this.colWrappingWaste.OptionsColumn.ReadOnly = true;
            this.colWrappingWaste.OptionsFilter.AllowAutoFilter = false;
            this.colWrappingWaste.OptionsFilter.AllowFilter = false;
            this.colWrappingWaste.Visible = true;
            this.colWrappingWaste.VisibleIndex = 6;
            this.colWrappingWaste.Width = 77;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô tả";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AllowAutoFilter = false;
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 323;
            // 
            // colMixpremixID
            // 
            this.colMixpremixID.Caption = "MixpremixID";
            this.colMixpremixID.FieldName = "MixpremixID";
            this.colMixpremixID.Name = "colMixpremixID";
            this.colMixpremixID.OptionsColumn.AllowEdit = false;
            this.colMixpremixID.OptionsColumn.AllowFocus = false;
            this.colMixpremixID.OptionsColumn.ReadOnly = true;
            this.colMixpremixID.OptionsFilter.AllowAutoFilter = false;
            this.colMixpremixID.OptionsFilter.AllowFilter = false;
            // 
            // colUserUpdated1
            // 
            this.colUserUpdated1.Caption = "UserUpdated";
            this.colUserUpdated1.FieldName = "UserUpdated";
            this.colUserUpdated1.Name = "colUserUpdated1";
            this.colUserUpdated1.OptionsColumn.AllowEdit = false;
            this.colUserUpdated1.OptionsColumn.AllowFocus = false;
            this.colUserUpdated1.OptionsColumn.ReadOnly = true;
            this.colUserUpdated1.OptionsFilter.AllowAutoFilter = false;
            this.colUserUpdated1.OptionsFilter.AllowFilter = false;
            // 
            // colDateCreated1
            // 
            this.colDateCreated1.Caption = "DateCreated";
            this.colDateCreated1.FieldName = "DateCreated";
            this.colDateCreated1.Name = "colDateCreated1";
            this.colDateCreated1.OptionsColumn.AllowEdit = false;
            this.colDateCreated1.OptionsColumn.AllowFocus = false;
            this.colDateCreated1.OptionsColumn.ReadOnly = true;
            this.colDateCreated1.OptionsFilter.AllowAutoFilter = false;
            this.colDateCreated1.OptionsFilter.AllowFilter = false;
            // 
            // colDateUpdated1
            // 
            this.colDateUpdated1.Caption = "DateUpdated";
            this.colDateUpdated1.FieldName = "DateUpdated";
            this.colDateUpdated1.Name = "colDateUpdated1";
            this.colDateUpdated1.OptionsColumn.AllowEdit = false;
            this.colDateUpdated1.OptionsColumn.AllowFocus = false;
            this.colDateUpdated1.OptionsColumn.ReadOnly = true;
            this.colDateUpdated1.OptionsFilter.AllowAutoFilter = false;
            this.colDateUpdated1.OptionsFilter.AllowFilter = false;
            // 
            // colUserCreated1
            // 
            this.colUserCreated1.Caption = "UserCreated";
            this.colUserCreated1.FieldName = "UserCreated";
            this.colUserCreated1.Name = "colUserCreated1";
            this.colUserCreated1.OptionsColumn.AllowEdit = false;
            this.colUserCreated1.OptionsColumn.AllowFocus = false;
            this.colUserCreated1.OptionsColumn.ReadOnly = true;
            this.colUserCreated1.OptionsFilter.AllowAutoFilter = false;
            this.colUserCreated1.OptionsFilter.AllowFilter = false;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "LstMixPremix";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpEmployee,
            this.ItemButtonEdit,
            this.ItemLookStatus});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(780, 415);
            this.gridControl.TabIndex = 3;
            this.gridControl.TabStop = false;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView.Appearance.Row.BackColor = System.Drawing.Color.GhostWhite;
            this.gridView.Appearance.Row.Options.UseBackColor = true;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMixDate,
            this.colShift,
            this.colStatus,
            this.colAddnew,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(748, 558, 208, 170);
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.GotFocus += new System.EventHandler(this.gridView_GotFocus);
            // 
            // colMixDate
            // 
            this.colMixDate.Caption = "MixDate";
            this.colMixDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colMixDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMixDate.FieldName = "MixDate";
            this.colMixDate.Name = "colMixDate";
            this.colMixDate.OptionsColumn.AllowEdit = false;
            this.colMixDate.OptionsColumn.AllowFocus = false;
            this.colMixDate.OptionsColumn.ReadOnly = true;
            this.colMixDate.Visible = true;
            this.colMixDate.VisibleIndex = 0;
            this.colMixDate.Width = 125;
            // 
            // colShift
            // 
            this.colShift.Caption = "Shift";
            this.colShift.FieldName = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.OptionsColumn.AllowEdit = false;
            this.colShift.OptionsColumn.AllowFocus = false;
            this.colShift.Visible = true;
            this.colShift.VisibleIndex = 1;
            this.colShift.Width = 61;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.ItemLookStatus;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.AllowFocus = false;
            this.colStatus.OptionsColumn.FixedWidth = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 213;
            // 
            // ItemLookStatus
            // 
            this.ItemLookStatus.AutoHeight = false;
            this.ItemLookStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID", "EnumID", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText", "EnumText", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookStatus.DisplayMember = "EnumText";
            this.ItemLookStatus.Name = "ItemLookStatus";
            this.ItemLookStatus.NullText = "";
            this.ItemLookStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookStatus.ValueMember = "EnumID";
            // 
            // colAddnew
            // 
            this.colAddnew.ColumnEdit = this.ItemButtonEdit;
            this.colAddnew.Name = "colAddnew";
            this.colAddnew.OptionsFilter.AllowAutoFilter = false;
            this.colAddnew.OptionsFilter.AllowFilter = false;
            this.colAddnew.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colAddnew.Visible = true;
            this.colAddnew.VisibleIndex = 3;
            this.colAddnew.Width = 74;
            // 
            // ItemButtonEdit
            // 
            this.ItemButtonEdit.AutoHeight = false;
            this.ItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Thêm chi tiết", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.ItemButtonEdit.Name = "ItemButtonEdit";
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowEdit = false;
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            this.colUserCreated.OptionsFilter.AllowAutoFilter = false;
            this.colUserCreated.OptionsFilter.AllowFilter = false;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowEdit = false;
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            this.colUserUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colUserUpdated.OptionsFilter.AllowFilter = false;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowEdit = false;
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            this.colDateCreated.OptionsFilter.AllowAutoFilter = false;
            this.colDateCreated.OptionsFilter.AllowFilter = false;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowEdit = false;
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            this.colDateUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colDateUpdated.OptionsFilter.AllowFilter = false;
            // 
            // ItemLookUpEmployee
            // 
            this.ItemLookUpEmployee.AutoHeight = false;
            this.ItemLookUpEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEmployee.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "EmployeeID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "EmployeeName", 150)});
            this.ItemLookUpEmployee.DisplayMember = "EmployeeName";
            this.ItemLookUpEmployee.Name = "ItemLookUpEmployee";
            this.ItemLookUpEmployee.NullText = "";
            this.ItemLookUpEmployee.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpEmployee.ValueMember = "EmployeeID";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 506);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55216F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.44784F));
            this.tableLayoutPanel3.Controls.Add(this.pTaoPX1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pXoaPX2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pTaoPX1
            // 
            this.pTaoPX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pTaoPX1.Controls.Add(this.btnTaoPX);
            this.pTaoPX1.Location = new System.Drawing.Point(33, 3);
            this.pTaoPX1.Name = "pTaoPX1";
            this.pTaoPX1.Size = new System.Drawing.Size(180, 32);
            this.pTaoPX1.TabIndex = 0;
            this.pTaoPX1.Text = "panelControl1";
            // 
            // btnTaoPX
            // 
            this.btnTaoPX.Location = new System.Drawing.Point(2, 2);
            this.btnTaoPX.Name = "btnTaoPX";
            this.btnTaoPX.Size = new System.Drawing.Size(176, 28);
            this.btnTaoPX.TabIndex = 1;
            this.btnTaoPX.Text = "Tạo phiếu xuất";
            this.btnTaoPX.Click += new System.EventHandler(this.btnTaoPX_Click);
            // 
            // pXoaPX2
            // 
            this.pXoaPX2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pXoaPX2.Controls.Add(this.btnXoaPX);
            this.pXoaPX2.Location = new System.Drawing.Point(250, 3);
            this.pXoaPX2.Name = "pXoaPX2";
            this.pXoaPX2.Size = new System.Drawing.Size(180, 32);
            this.pXoaPX2.TabIndex = 0;
            this.pXoaPX2.Text = "panelControl1";
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Location = new System.Drawing.Point(2, 2);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(176, 28);
            this.btnXoaPX.TabIndex = 1;
            this.btnXoaPX.Text = "Tạo phiếu xuất";
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.22481F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.77519F));
            this.tableLayoutPanel4.Controls.Add(this.lblKho, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbokho, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblThang, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboPeriodCode, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(786, 29);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lblKho
            // 
            this.lblKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(38, 8);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(70, 13);
            this.lblKho.TabIndex = 0;
            this.lblKho.Text = "Kho sản xuất";
            // 
            // cbokho
            // 
            this.cbokho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbokho.Location = new System.Drawing.Point(114, 4);
            this.cbokho.Name = "cbokho";
            this.cbokho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbokho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 60),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 140)});
            this.cbokho.Properties.DisplayMember = "StockName";
            this.cbokho.Properties.NullText = "";
            this.cbokho.Properties.PopupWidth = 200;
            this.cbokho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbokho.Properties.ValueMember = "StockCode";
            this.cbokho.Size = new System.Drawing.Size(152, 20);
            this.cbokho.TabIndex = 1;
            this.cbokho.EditValueChanged += new System.EventHandler(this.cbokho_EditValueChanged);
            // 
            // lblThang
            // 
            this.lblThang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(613, 8);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(37, 13);
            this.lblThang.TabIndex = 5;
            this.lblThang.Text = "Tháng";
            this.lblThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPeriodCode
            // 
            this.cboPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPeriodCode.EnterMoveNextControl = true;
            this.cboPeriodCode.Location = new System.Drawing.Point(656, 4);
            this.cboPeriodCode.Name = "cboPeriodCode";
            this.cboPeriodCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeriodCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cboPeriodCode.Properties.DisplayMember = "Description";
            this.cboPeriodCode.Properties.NullText = "";
            this.cboPeriodCode.Properties.PopupWidth = 200;
            this.cboPeriodCode.Properties.ValueMember = "PeriodCode";
            this.cboPeriodCode.Size = new System.Drawing.Size(127, 20);
            this.cboPeriodCode.TabIndex = 6;
            this.cboPeriodCode.EditValueChanged += new System.EventHandler(this.cboPeriodCode_EditValueChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(786, 421);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CodePremix";
            this.gridColumn1.FieldName = "PremixWrappingCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 161;
            // 
            // FormMixPremixs
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.GridControl = this.gridControl;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMixPremixs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MixPremixs";
            this.Load += new System.EventHandler(this.FormMixPremixs_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEmployee)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pTaoPX1)).EndInit();
            this.pTaoPX1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pXoaPX2)).EndInit();
            this.pXoaPX2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbokho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.PanelControl pTaoPX1;
        private DevExpress.XtraEditors.SimpleButton btnTaoPX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblKho;
        private DevExpress.XtraEditors.LookUpEdit cbokho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPremixCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colNap;
        private DevExpress.XtraGrid.Columns.GridColumn colWrapping;
        private DevExpress.XtraGrid.Columns.GridColumn colPremixWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingWaste;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colMixpremixID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMixDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShift;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAddnew;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookStatus;
        private DevExpress.XtraEditors.PanelControl pXoaPX2;
        private DevExpress.XtraEditors.SimpleButton btnXoaPX;
        private System.Windows.Forms.Label lblThang;
        private DevExpress.XtraEditors.LookUpEdit cboPeriodCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}