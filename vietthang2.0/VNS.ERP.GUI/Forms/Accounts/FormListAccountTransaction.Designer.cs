namespace VNS.ERP.GUI.Accounting
{
    partial class FormListAccountTransaction
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
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriptionDetail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTKemtheo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubjectCode1 = new System.Windows.Forms.Label();
            this.lblTransactionTypeCode = new System.Windows.Forms.Label();
            this.cboTransactionTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.cboPeriodCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboSubjectCode1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrintCTPS = new DevExpress.XtraEditors.SimpleButton();
            this.btnChk133 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectCode1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colDebitAmount,
            this.colCreditAmount,
            this.colDescriptionDetail1});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.AutoZoomDetail = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "Tài khoản";
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 0;
            this.colAccountCode.Width = 59;
            // 
            // colDebitAmount
            // 
            this.colDebitAmount.Caption = "Nợ";
            this.colDebitAmount.DisplayFormat.FormatString = "#,###";
            this.colDebitAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebitAmount.FieldName = "DebitAmount";
            this.colDebitAmount.Name = "colDebitAmount";
            this.colDebitAmount.Visible = true;
            this.colDebitAmount.VisibleIndex = 1;
            this.colDebitAmount.Width = 110;
            // 
            // colCreditAmount
            // 
            this.colCreditAmount.Caption = "Có";
            this.colCreditAmount.DisplayFormat.FormatString = "#,###";
            this.colCreditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditAmount.FieldName = "CreditAmount";
            this.colCreditAmount.Name = "colCreditAmount";
            this.colCreditAmount.Visible = true;
            this.colCreditAmount.VisibleIndex = 2;
            this.colCreditAmount.Width = 110;
            // 
            // colDescriptionDetail1
            // 
            this.colDescriptionDetail1.Caption = "Diễn giải";
            this.colDescriptionDetail1.FieldName = "Description";
            this.colDescriptionDetail1.Name = "colDescriptionDetail1";
            this.colDescriptionDetail1.Visible = true;
            this.colDescriptionDetail1.VisibleIndex = 3;
            this.colDescriptionDetail1.Width = 515;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Detail1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(0, 73);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(978, 361);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.ChildGridLevelName = "Detail1";
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountTransactionNo,
            this.colAccountTransactionDate,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated,
            this.colPersonName,
            this.colAddress,
            this.colCTKemtheo,
            this.colNgayCT,
            this.colSubjectCode2});
            this.gridView.DefaultRelationIndex = 1;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsDetail.ShowDetailTabs = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colAccountTransactionNo
            // 
            this.colAccountTransactionNo.Caption = "AccountTransactionNo";
            this.colAccountTransactionNo.FieldName = "AccountTransactionNo";
            this.colAccountTransactionNo.Name = "colAccountTransactionNo";
            this.colAccountTransactionNo.Visible = true;
            this.colAccountTransactionNo.VisibleIndex = 0;
            this.colAccountTransactionNo.Width = 103;
            // 
            // colAccountTransactionDate
            // 
            this.colAccountTransactionDate.Caption = "AccountTransactionDate";
            this.colAccountTransactionDate.DisplayFormat.FormatString = "d";
            this.colAccountTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAccountTransactionDate.FieldName = "AccountTransactionDate";
            this.colAccountTransactionDate.Name = "colAccountTransactionDate";
            this.colAccountTransactionDate.Visible = true;
            this.colAccountTransactionDate.VisibleIndex = 1;
            this.colAccountTransactionDate.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 556;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 97;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 118;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 112;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 101;
            // 
            // colPersonName
            // 
            this.colPersonName.Caption = "PersonName";
            this.colPersonName.FieldName = "PersonName";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.Visible = true;
            this.colPersonName.VisibleIndex = 3;
            this.colPersonName.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            this.colAddress.Width = 253;
            // 
            // colCTKemtheo
            // 
            this.colCTKemtheo.Caption = "CTKemtheo";
            this.colCTKemtheo.FieldName = "CTKemtheo";
            this.colCTKemtheo.Name = "colCTKemtheo";
            this.colCTKemtheo.Visible = true;
            this.colCTKemtheo.VisibleIndex = 7;
            this.colCTKemtheo.Width = 279;
            // 
            // colNgayCT
            // 
            this.colNgayCT.Caption = "NgayCT";
            this.colNgayCT.DisplayFormat.FormatString = "d";
            this.colNgayCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayCT.FieldName = "NgayCT";
            this.colNgayCT.Name = "colNgayCT";
            this.colNgayCT.Visible = true;
            this.colNgayCT.VisibleIndex = 5;
            this.colNgayCT.Width = 98;
            // 
            // colSubjectCode2
            // 
            this.colSubjectCode2.Caption = "SubjectCode2";
            this.colSubjectCode2.FieldName = "SubjectCode2";
            this.colSubjectCode2.Name = "colSubjectCode2";
            this.colSubjectCode2.Visible = true;
            this.colSubjectCode2.VisibleIndex = 2;
            this.colSubjectCode2.Width = 98;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 31);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.40171F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.94017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.508547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.700855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.46442F));
            this.tableLayoutPanel1.Controls.Add(this.btnLoadData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubjectCode1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTransactionTypeCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboTransactionTypeCode, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPeriodCode, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblThang, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboSubjectCode1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 31);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadData.Location = new System.Drawing.Point(3, 3);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(36, 25);
            this.btnLoadData.TabIndex = 7;
            this.btnLoadData.Text = "+";
            this.btnLoadData.ToolTip = "Expand All";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // lblSubjectCode1
            // 
            this.lblSubjectCode1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubjectCode1.AutoSize = true;
            this.lblSubjectCode1.Location = new System.Drawing.Point(53, 9);
            this.lblSubjectCode1.Name = "lblSubjectCode1";
            this.lblSubjectCode1.Size = new System.Drawing.Size(74, 13);
            this.lblSubjectCode1.TabIndex = 0;
            this.lblSubjectCode1.Text = "SubjectCode1";
            // 
            // lblTransactionTypeCode
            // 
            this.lblTransactionTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTransactionTypeCode.AutoSize = true;
            this.lblTransactionTypeCode.Location = new System.Drawing.Point(572, 9);
            this.lblTransactionTypeCode.Name = "lblTransactionTypeCode";
            this.lblTransactionTypeCode.Size = new System.Drawing.Size(74, 13);
            this.lblTransactionTypeCode.TabIndex = 0;
            this.lblTransactionTypeCode.Text = "SubjectCode1";
            // 
            // cboTransactionTypeCode
            // 
            this.cboTransactionTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTransactionTypeCode.EnterMoveNextControl = true;
            this.cboTransactionTypeCode.Location = new System.Drawing.Point(652, 5);
            this.cboTransactionTypeCode.Name = "cboTransactionTypeCode";
            this.cboTransactionTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTransactionTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DetailTransactionCode", 80, "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DetailTransactionName", 200, "Tên")});
            this.cboTransactionTypeCode.Properties.DisplayMember = "DetailTransactionName";
            this.cboTransactionTypeCode.Properties.NullText = "";
            this.cboTransactionTypeCode.Properties.PopupWidth = 280;
            this.cboTransactionTypeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTransactionTypeCode.Properties.ValueMember = "DetailTransactionCode";
            this.cboTransactionTypeCode.Size = new System.Drawing.Size(114, 20);
            this.cboTransactionTypeCode.TabIndex = 2;
            // 
            // cboPeriodCode
            // 
            this.cboPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPeriodCode.EnterMoveNextControl = true;
            this.cboPeriodCode.Location = new System.Drawing.Point(816, 5);
            this.cboPeriodCode.Name = "cboPeriodCode";
            this.cboPeriodCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeriodCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng")});
            this.cboPeriodCode.Properties.DisplayMember = "Description";
            this.cboPeriodCode.Properties.NullText = "";
            this.cboPeriodCode.Properties.PopupWidth = 200;
            this.cboPeriodCode.Properties.ValueMember = "PeriodCode";
            this.cboPeriodCode.Size = new System.Drawing.Size(122, 20);
            this.cboPeriodCode.TabIndex = 12;
            this.cboPeriodCode.EditValueChanged += new System.EventHandler(this.cboPeriodCode_EditValueChanged);
            // 
            // lblThang
            // 
            this.lblThang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(773, 9);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(37, 13);
            this.lblThang.TabIndex = 13;
            this.lblThang.Text = "Tháng";
            this.lblThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSubjectCode1
            // 
            this.cboSubjectCode1.EnterMoveNextControl = true;
            this.cboSubjectCode1.Location = new System.Drawing.Point(133, 3);
            this.cboSubjectCode1.MenuManager = this.barManager;
            this.cboSubjectCode1.Name = "cboSubjectCode1";
            this.cboSubjectCode1.Properties.AutoComplete = false;
            this.cboSubjectCode1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cboSubjectCode1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubjectCode1.Properties.DisplayMember = "SubjectName";
            this.cboSubjectCode1.Properties.ImmediatePopup = true;
            this.cboSubjectCode1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboSubjectCode1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSubjectCode1.Properties.ValueMember = "SubjectCode";
            this.cboSubjectCode1.Properties.View = this.gridLookUpEdit1View;
            this.cboSubjectCode1.Size = new System.Drawing.Size(424, 20);
            this.cboSubjectCode1.TabIndex = 14;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã";
            this.gridColumn1.FieldName = "SubjectCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 149;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên";
            this.gridColumn2.FieldName = "SubjectName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 433;
            // 
            // btnPrintCTPS
            // 
            this.btnPrintCTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCTPS.Location = new System.Drawing.Point(877, 437);
            this.btnPrintCTPS.Name = "btnPrintCTPS";
            this.btnPrintCTPS.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCTPS.TabIndex = 105;
            this.btnPrintCTPS.Text = "In CTPS";
            this.btnPrintCTPS.Click += new System.EventHandler(this.btnPrintCTPS_Click);
            // 
            // btnChk133
            // 
            this.btnChk133.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChk133.Location = new System.Drawing.Point(718, 437);
            this.btnChk133.Name = "btnChk133";
            this.btnChk133.Size = new System.Drawing.Size(75, 23);
            this.btnChk133.TabIndex = 106;
            this.btnChk133.Text = "Kiểm 133";
            this.btnChk133.Click += new System.EventHandler(this.btnChk133_Click);
            // 
            // FormListAccountTransaction
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 490);
            this.Controls.Add(this.btnChk133);
            this.Controls.Add(this.btnPrintCTPS);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel1);
            this.GridControl = this.gridControl;
            this.Name = "FormListAccountTransaction";
            this.Text = "FormListAccountTransaction";
            this.Load += new System.EventHandler(this.FormListAccountTransaction_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            this.Controls.SetChildIndex(this.btnPrintCTPS, 0);
            this.Controls.SetChildIndex(this.btnChk133, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubjectCode1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCTKemtheo;
        private System.Windows.Forms.Label lblSubjectCode1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LookUpEdit cboTransactionTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;

        private DevExpress.XtraGrid.Columns.GridColumn colDescriptionDetail1;
        private System.Windows.Forms.Label lblThang;
        private DevExpress.XtraEditors.LookUpEdit cboPeriodCode;
        private System.Windows.Forms.Label lblTransactionTypeCode;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode2;
        private DevExpress.XtraEditors.SimpleButton btnPrintCTPS;
        private DevExpress.XtraEditors.SimpleButton btnChk133;
        private DevExpress.XtraEditors.GridLookUpEdit cboSubjectCode1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}