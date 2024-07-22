namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerDeptOpening
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
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditCustomerName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditCustomerCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditOrgAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEditInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colPaidAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditPaidAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colRemainAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEditRemainAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDateLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEditDue = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.ItemCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCustomerCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colRemainAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCustomerName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCustomerName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemAppointmentLabel1 = new DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOrgAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaidAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemainAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAppointmentLabel1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 19);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpEditCustomerCode,
            this.lookUpEditCustomerName,
            this.repositoryItemSpinEdit1,
            this.dateEditInvoice,
            this.textEditOrgAmount,
            this.textEditPaidAmount,
            this.textEditRemainAmount,
            this.dateEditDue,
            this.ItemCheck,
            this.cboStockCode});
            this.gridControl1.Size = new System.Drawing.Size(842, 155);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerCode,
            this.colInvoiceNo,
            this.colOrgAmount,
            this.colInvoiceDate,
            this.colPaidAmount,
            this.colRemainAmount,
            this.colDateLimit,
            this.colDueDate,
            this.colStockCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "CustomerName";
            this.colCustomerName.ColumnEdit = this.lookUpEditCustomerName;
            this.colCustomerName.FieldName = "CustomerCode";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.OptionsColumn.AllowEdit = false;
            this.colCustomerName.OptionsColumn.AllowFocus = false;
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 249;
            // 
            // lookUpEditCustomerName
            // 
            this.lookUpEditCustomerName.AutoHeight = false;
            this.lookUpEditCustomerName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCustomerName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.lookUpEditCustomerName.DisplayMember = "SubjectName";
            this.lookUpEditCustomerName.Name = "lookUpEditCustomerName";
            this.lookUpEditCustomerName.NullText = "";
            this.lookUpEditCustomerName.ValueMember = "SubjectCode";
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.ColumnEdit = this.lookUpEditCustomerCode;
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 1;
            this.colCustomerCode.Width = 127;
            // 
            // lookUpEditCustomerCode
            // 
            this.lookUpEditCustomerCode.AutoHeight = false;
            this.lookUpEditCustomerCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCustomerCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã KH", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên KH", 220)});
            this.lookUpEditCustomerCode.DisplayMember = "SubjectCode";
            this.lookUpEditCustomerCode.Name = "lookUpEditCustomerCode";
            this.lookUpEditCustomerCode.NullText = "";
            this.lookUpEditCustomerCode.PopupWidth = 300;
            this.lookUpEditCustomerCode.ShowHeader = false;
            this.lookUpEditCustomerCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditCustomerCode.ValueMember = "SubjectCode";
            this.lookUpEditCustomerCode.EditValueChanged += new System.EventHandler(this.lookUpEditCustomerCode_EditValueChanged);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Số hoá đơn";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 3;
            // 
            // colOrgAmount
            // 
            this.colOrgAmount.Caption = "Tiền hoá đơn";
            this.colOrgAmount.ColumnEdit = this.textEditOrgAmount;
            this.colOrgAmount.FieldName = "OrgAmount";
            this.colOrgAmount.Name = "colOrgAmount";
            this.colOrgAmount.Visible = true;
            this.colOrgAmount.VisibleIndex = 5;
            // 
            // textEditOrgAmount
            // 
            this.textEditOrgAmount.AutoHeight = false;
            this.textEditOrgAmount.Mask.EditMask = "n2";
            this.textEditOrgAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditOrgAmount.Mask.UseMaskAsDisplayFormat = true;
            this.textEditOrgAmount.Name = "textEditOrgAmount";
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Ngày hoá đơn";
            this.colInvoiceDate.ColumnEdit = this.dateEditInvoice;
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 4;
            this.colInvoiceDate.Width = 80;
            // 
            // dateEditInvoice
            // 
            this.dateEditInvoice.AutoHeight = false;
            this.dateEditInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInvoice.Name = "dateEditInvoice";
            // 
            // colPaidAmount
            // 
            this.colPaidAmount.Caption = "Đã trả";
            this.colPaidAmount.ColumnEdit = this.textEditPaidAmount;
            this.colPaidAmount.FieldName = "PaidAmount";
            this.colPaidAmount.Name = "colPaidAmount";
            this.colPaidAmount.Visible = true;
            this.colPaidAmount.VisibleIndex = 6;
            this.colPaidAmount.Width = 112;
            // 
            // textEditPaidAmount
            // 
            this.textEditPaidAmount.AutoHeight = false;
            this.textEditPaidAmount.Mask.EditMask = "n2";
            this.textEditPaidAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditPaidAmount.Mask.UseMaskAsDisplayFormat = true;
            this.textEditPaidAmount.Name = "textEditPaidAmount";
            // 
            // colRemainAmount
            // 
            this.colRemainAmount.Caption = "Còn lại";
            this.colRemainAmount.ColumnEdit = this.textEditRemainAmount;
            this.colRemainAmount.FieldName = "RemainAmount";
            this.colRemainAmount.Name = "colRemainAmount";
            this.colRemainAmount.Visible = true;
            this.colRemainAmount.VisibleIndex = 7;
            this.colRemainAmount.Width = 111;
            // 
            // textEditRemainAmount
            // 
            this.textEditRemainAmount.AutoHeight = false;
            this.textEditRemainAmount.Mask.EditMask = "n2";
            this.textEditRemainAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditRemainAmount.Mask.UseMaskAsDisplayFormat = true;
            this.textEditRemainAmount.Name = "textEditRemainAmount";
            // 
            // colDateLimit
            // 
            this.colDateLimit.Caption = "Có hạn trả";
            this.colDateLimit.FieldName = "DateLimit";
            this.colDateLimit.Name = "colDateLimit";
            this.colDateLimit.Visible = true;
            this.colDateLimit.VisibleIndex = 8;
            this.colDateLimit.Width = 91;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "Hạn trả";
            this.colDueDate.ColumnEdit = this.dateEditDue;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 9;
            this.colDueDate.Width = 97;
            // 
            // dateEditDue
            // 
            this.dateEditDue.AutoHeight = false;
            this.dateEditDue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDue.Name = "dateEditDue";
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "StockCode";
            this.colStockCode.ColumnEdit = this.cboStockCode;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 140;
            // 
            // cboStockCode
            // 
            this.cboStockCode.AutoHeight = false;
            this.cboStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 250)});
            this.cboStockCode.DisplayMember = "StockName";
            this.cboStockCode.Name = "cboStockCode";
            this.cboStockCode.NullText = "";
            this.cboStockCode.PopupWidth = 300;
            this.cboStockCode.ShowHeader = false;
            this.cboStockCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboStockCode.ValueMember = "StockCode";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.UseCtrlIncrement = true;
            // 
            // ItemCheck
            // 
            this.ItemCheck.AutoHeight = false;
            this.ItemCheck.Name = "ItemCheck";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(3, 19);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboCustomerName,
            this.repositoryItemAppointmentLabel1,
            this.cboCustomerCode,
            this.textFormat});
            this.gridControl2.Size = new System.Drawing.Size(556, 149);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerCode2,
            this.colRemainAmount2,
            this.colCustomerName2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerCode2
            // 
            this.colCustomerCode2.Caption = "CustomerCode";
            this.colCustomerCode2.ColumnEdit = this.cboCustomerCode;
            this.colCustomerCode2.FieldName = "CustomerCode";
            this.colCustomerCode2.Name = "colCustomerCode2";
            this.colCustomerCode2.Visible = true;
            this.colCustomerCode2.VisibleIndex = 0;
            this.colCustomerCode2.Width = 126;
            // 
            // cboCustomerCode
            // 
            this.cboCustomerCode.AutoHeight = false;
            this.cboCustomerCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 220)});
            this.cboCustomerCode.DisplayMember = "SubjectCode";
            this.cboCustomerCode.Name = "cboCustomerCode";
            this.cboCustomerCode.NullText = "";
            this.cboCustomerCode.PopupWidth = 300;
            this.cboCustomerCode.ShowHeader = false;
            this.cboCustomerCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboCustomerCode.ValueMember = "SubjectCode";
            this.cboCustomerCode.EditValueChanged += new System.EventHandler(this.cboCustomerCode_EditValueChanged);
            // 
            // colRemainAmount2
            // 
            this.colRemainAmount2.Caption = "RemainAmount";
            this.colRemainAmount2.ColumnEdit = this.textFormat;
            this.colRemainAmount2.FieldName = "RemainAmount";
            this.colRemainAmount2.Name = "colRemainAmount2";
            this.colRemainAmount2.Visible = true;
            this.colRemainAmount2.VisibleIndex = 2;
            this.colRemainAmount2.Width = 159;
            // 
            // textFormat
            // 
            this.textFormat.AutoHeight = false;
            this.textFormat.Mask.EditMask = "n0";
            this.textFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textFormat.Mask.UseMaskAsDisplayFormat = true;
            this.textFormat.Name = "textFormat";
            // 
            // colCustomerName2
            // 
            this.colCustomerName2.Caption = "CustomerName";
            this.colCustomerName2.ColumnEdit = this.cboCustomerName;
            this.colCustomerName2.FieldName = "CustomerCode";
            this.colCustomerName2.Name = "colCustomerName2";
            this.colCustomerName2.OptionsColumn.AllowEdit = false;
            this.colCustomerName2.OptionsColumn.AllowFocus = false;
            this.colCustomerName2.Visible = true;
            this.colCustomerName2.VisibleIndex = 1;
            this.colCustomerName2.Width = 249;
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.AutoHeight = false;
            this.cboCustomerName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 220)});
            this.cboCustomerName.DisplayMember = "SubjectName";
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.NullText = "";
            this.cboCustomerName.PopupWidth = 300;
            this.cboCustomerName.ShowHeader = false;
            this.cboCustomerName.ValueMember = "SubjectCode";
            // 
            // repositoryItemAppointmentLabel1
            // 
            this.repositoryItemAppointmentLabel1.AutoHeight = false;
            this.repositoryItemAppointmentLabel1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAppointmentLabel1.Name = "repositoryItemAppointmentLabel1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 366);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 186);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(848, 177);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi phí:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 177);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FormCustomerDeptOpening
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCustomerDeptOpening";
            this.Text = "FormCustomerDeptOpening";
            this.Load += new System.EventHandler(this.FormCustomerDeptOpening_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCustomerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOrgAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPaidAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditRemainAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAppointmentLabel1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditCustomerCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEditInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditOrgAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditPaidAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textEditRemainAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEditDue;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLimit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ItemCheck;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainAmount2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCustomerName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCustomerCode;
        private DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel repositoryItemAppointmentLabel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit textFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}