namespace VNS.ERP.GUI.Accounting
{
    partial class FormListAccountTransactionStock
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
            this.colSubjectCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTKemtheo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditTransactionType = new DevExpress.XtraEditors.LookUpEdit();
            this.lbLoaiNX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpBranchCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintCTPS = new DevExpress.XtraEditors.SimpleButton();
            this.btnChk133 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransactionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).BeginInit();
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
            this.gridControl.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Detail1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(2, 67);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(891, 305);
            this.gridControl.TabIndex = 13;
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
            this.colSubjectCode2,
            this.colInvoiceNo,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated,
            this.colPersonName,
            this.colAddress,
            this.colCTKemtheo,
            this.colNgayCT,
            this.colTenKho});
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
            this.gridView.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // colSubjectCode2
            // 
            this.colSubjectCode2.Caption = "Mã KH";
            this.colSubjectCode2.FieldName = "SubjectCode2";
            this.colSubjectCode2.Name = "colSubjectCode2";
            this.colSubjectCode2.Visible = true;
            this.colSubjectCode2.VisibleIndex = 3;
            this.colSubjectCode2.Width = 97;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Số hoá đơn";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 4;
            this.colInvoiceNo.Width = 93;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 293;
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
            this.colPersonName.VisibleIndex = 5;
            this.colPersonName.Width = 150;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 8;
            this.colAddress.Width = 253;
            // 
            // colCTKemtheo
            // 
            this.colCTKemtheo.Caption = "CTKemtheo";
            this.colCTKemtheo.FieldName = "CTKemtheo";
            this.colCTKemtheo.Name = "colCTKemtheo";
            this.colCTKemtheo.Visible = true;
            this.colCTKemtheo.VisibleIndex = 9;
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
            this.colNgayCT.VisibleIndex = 7;
            this.colNgayCT.Width = 98;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên kho";
            this.colTenKho.FieldName = "Tenkho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 2;
            this.colTenKho.Width = 80;
            // 
            // lookUpEditTransactionType
            // 
            this.lookUpEditTransactionType.Location = new System.Drawing.Point(96, 43);
            this.lookUpEditTransactionType.Name = "lookUpEditTransactionType";
            this.lookUpEditTransactionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTransactionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeCode", "Mã NX", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải", 250)});
            this.lookUpEditTransactionType.Properties.DisplayMember = "Description";
            this.lookUpEditTransactionType.Properties.NullText = "";
            this.lookUpEditTransactionType.Properties.PopupWidth = 300;
            this.lookUpEditTransactionType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditTransactionType.Properties.ValueMember = "TransactionTypeCode";
            this.lookUpEditTransactionType.Size = new System.Drawing.Size(236, 20);
            this.lookUpEditTransactionType.TabIndex = 5;
            this.lookUpEditTransactionType.EditValueChanged += new System.EventHandler(this.lookUpEditTransactionType_EditValueChanged);
            // 
            // lbLoaiNX
            // 
            this.lbLoaiNX.AutoSize = true;
            this.lbLoaiNX.Location = new System.Drawing.Point(49, 45);
            this.lbLoaiNX.Name = "lbLoaiNX";
            this.lbLoaiNX.Size = new System.Drawing.Size(42, 13);
            this.lbLoaiNX.TabIndex = 6;
            this.lbLoaiNX.Text = "Loại NX";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(352, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpBranchCode
            // 
            this.lookUpBranchCode.EnterMoveNextControl = true;
            this.lookUpBranchCode.Location = new System.Drawing.Point(396, 42);
            this.lookUpBranchCode.Name = "lookUpBranchCode";
            this.lookUpBranchCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpBranchCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpBranchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBranchCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 220)});
            this.lookUpBranchCode.Properties.DisplayMember = "StockName";
            this.lookUpBranchCode.Properties.NullText = "";
            this.lookUpBranchCode.Properties.PopupWidth = 300;
            this.lookUpBranchCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpBranchCode.Properties.ValueMember = "StockCode";
            this.lookUpBranchCode.Size = new System.Drawing.Size(160, 22);
            this.lookUpBranchCode.TabIndex = 9;
            this.lookUpBranchCode.EditValueChanged += new System.EventHandler(this.lookUpBranchCode_EditValueChanged);
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(646, 44);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(116, 18);
            this.lbPeriod.TabIndex = 12;
            this.lbPeriod.Text = "Kỳ kế toán";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(766, 44);
            this.lookUpPeriod.Name = "lookUpPeriod";
            this.lookUpPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpPeriod.Properties.DisplayMember = "Description";
            this.lookUpPeriod.Properties.NullText = "";
            this.lookUpPeriod.Properties.ShowHeader = false;
            this.lookUpPeriod.Properties.ValueMember = "PeriodCode";
            this.lookUpPeriod.Size = new System.Drawing.Size(125, 20);
            this.lookUpPeriod.TabIndex = 11;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(2, 41);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(36, 24);
            this.btnLoadData.TabIndex = 14;
            this.btnLoadData.Text = "+";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnPrintCTPS
            // 
            this.btnPrintCTPS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintCTPS.Location = new System.Drawing.Point(787, 376);
            this.btnPrintCTPS.Name = "btnPrintCTPS";
            this.btnPrintCTPS.Size = new System.Drawing.Size(75, 23);
            this.btnPrintCTPS.TabIndex = 106;
            this.btnPrintCTPS.Text = "In CTPS";
            this.btnPrintCTPS.Click += new System.EventHandler(this.btnPrintCTPS_Click);
            // 
            // btnChk133
            // 
            this.btnChk133.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChk133.Location = new System.Drawing.Point(671, 376);
            this.btnChk133.Name = "btnChk133";
            this.btnChk133.Size = new System.Drawing.Size(75, 23);
            this.btnChk133.TabIndex = 107;
            this.btnChk133.Text = "Kiểm 133";
            this.btnChk133.Click += new System.EventHandler(this.btnChk133_Click);
            // 
            // FormListAccountTransactionStock
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 430);
            this.Controls.Add(this.btnChk133);
            this.Controls.Add(this.btnPrintCTPS);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.Controls.Add(this.lookUpBranchCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLoaiNX);
            this.Controls.Add(this.lookUpEditTransactionType);
            this.GridControl = this.gridControl;
            this.Name = "FormListAccountTransactionStock";
            this.Text = "FormListAccountTransactionStock";
            this.Load += new System.EventHandler(this.FormListAccountTransactionStock_Load);
            this.Controls.SetChildIndex(this.lookUpEditTransactionType, 0);
            this.Controls.SetChildIndex(this.lbLoaiNX, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lookUpBranchCode, 0);
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            this.Controls.SetChildIndex(this.btnLoadData, 0);
            this.Controls.SetChildIndex(this.btnPrintCTPS, 0);
            this.Controls.SetChildIndex(this.btnChk133, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransactionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditTransactionType;
        private System.Windows.Forms.Label lbLoaiNX;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpBranchCode;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptionDetail1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode2;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private DevExpress.XtraEditors.SimpleButton btnPrintCTPS;
        private DevExpress.XtraEditors.SimpleButton btnChk133;
    }
}