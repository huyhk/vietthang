namespace VNS.ERP.GUI.KCS
{
    partial class FormListMaterialTestTransaction
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repLookUpBranchCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTestTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repItemLookUpStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpVendor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPTVC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbBranchCode = new System.Windows.Forms.Label();
            this.lookUpBranchCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBranchCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).BeginInit();
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(758, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTip = "Cập nhật phiếu mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(594, 45);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(34, 18);
            this.lbPeriod.TabIndex = 19;
            this.lbPeriod.Text = "Kỳ";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(632, 45);
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
            this.lookUpPeriod.TabIndex = 18;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpItem,
            this.repItemLookUpStock,
            this.repLookUpVendor,
            this.repLookUpBranchCode});
            this.gridControl1.Size = new System.Drawing.Size(824, 340);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTestTransactionNo,
            this.colTestTransactionDate,
            this.colItemCode,
            this.colLocation,
            this.colVendorCode,
            this.colPTVC,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // repLookUpBranchCode
            // 
            this.repLookUpBranchCode.AutoHeight = false;
            this.repLookUpBranchCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpBranchCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.repLookUpBranchCode.DisplayMember = "SubjectName";
            this.repLookUpBranchCode.Name = "repLookUpBranchCode";
            this.repLookUpBranchCode.NullText = "";
            this.repLookUpBranchCode.ValidateOnEnterKey = true;
            this.repLookUpBranchCode.ValueMember = "SubjectCode";
            // 
            // colTestTransactionNo
            // 
            this.colTestTransactionNo.Caption = "Số";
            this.colTestTransactionNo.FieldName = "TestTransactionNo";
            this.colTestTransactionNo.Name = "colTestTransactionNo";
            this.colTestTransactionNo.Visible = true;
            this.colTestTransactionNo.VisibleIndex = 0;
            this.colTestTransactionNo.Width = 94;
            // 
            // colTestTransactionDate
            // 
            this.colTestTransactionDate.Caption = "Ngày";
            this.colTestTransactionDate.DisplayFormat.FormatString = "d";
            this.colTestTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTestTransactionDate.FieldName = "TestTransactionDate";
            this.colTestTransactionDate.Name = "colTestTransactionDate";
            this.colTestTransactionDate.Visible = true;
            this.colTestTransactionDate.VisibleIndex = 1;
            this.colTestTransactionDate.Width = 91;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Nguyên liệu";
            this.colItemCode.ColumnEdit = this.repLookUpItem;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 2;
            this.colItemCode.Width = 132;
            // 
            // repLookUpItem
            // 
            this.repLookUpItem.AutoHeight = false;
            this.repLookUpItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.repLookUpItem.DisplayMember = "ItemName";
            this.repLookUpItem.Name = "repLookUpItem";
            this.repLookUpItem.NullText = "";
            this.repLookUpItem.ValueMember = "ItemCode";
            // 
            // repItemLookUpStock
            // 
            this.repItemLookUpStock.AutoHeight = false;
            this.repItemLookUpStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.repItemLookUpStock.DisplayMember = "StockName";
            this.repItemLookUpStock.Name = "repItemLookUpStock";
            this.repItemLookUpStock.NullText = "";
            this.repItemLookUpStock.ValueMember = "StockCode";
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Lô hàng";
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 3;
            this.colLocation.Width = 111;
            // 
            // colVendorCode
            // 
            this.colVendorCode.Caption = "Khách hàng";
            this.colVendorCode.ColumnEdit = this.repLookUpVendor;
            this.colVendorCode.FieldName = "SubjectCode";
            this.colVendorCode.Name = "colVendorCode";
            this.colVendorCode.Visible = true;
            this.colVendorCode.VisibleIndex = 4;
            this.colVendorCode.Width = 132;
            // 
            // repLookUpVendor
            // 
            this.repLookUpVendor.AutoHeight = false;
            this.repLookUpVendor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpVendor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.repLookUpVendor.DisplayMember = "SubjectName";
            this.repLookUpVendor.Name = "repLookUpVendor";
            this.repLookUpVendor.NullText = "";
            this.repLookUpVendor.ValueMember = "SubjectCode";
            // 
            // colPTVC
            // 
            this.colPTVC.Caption = "PTVC";
            this.colPTVC.FieldName = "PTVC";
            this.colPTVC.Name = "colPTVC";
            this.colPTVC.Visible = true;
            this.colPTVC.VisibleIndex = 5;
            this.colPTVC.Width = 104;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 135;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // lbBranchCode
            // 
            this.lbBranchCode.Location = new System.Drawing.Point(13, 46);
            this.lbBranchCode.Name = "lbBranchCode";
            this.lbBranchCode.Size = new System.Drawing.Size(69, 15);
            this.lbBranchCode.TabIndex = 22;
            this.lbBranchCode.Text = "Kho";
            this.lbBranchCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpBranchCode
            // 
            this.lookUpBranchCode.Location = new System.Drawing.Point(83, 45);
            this.lookUpBranchCode.Name = "lookUpBranchCode";
            this.lookUpBranchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBranchCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 150),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 200)});
            this.lookUpBranchCode.Properties.DisplayMember = "StockName";
            this.lookUpBranchCode.Properties.NullText = "";
            this.lookUpBranchCode.Properties.PopupWidth = 350;
            this.lookUpBranchCode.Properties.ValueMember = "StockCode";
            this.lookUpBranchCode.Size = new System.Drawing.Size(129, 20);
            this.lookUpBranchCode.TabIndex = 23;
            this.lookUpBranchCode.EditValueChanged += new System.EventHandler(this.lookUpBranchCode_EditValueChanged);
            // 
            // FormListMaterialTestTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.lookUpBranchCode);
            this.Controls.Add(this.lbBranchCode);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.GridControl = this.gridControl1;
            this.Name = "FormListMaterialTestTransaction";
            this.Text = "Phiếu kiểm nguyên liệu";
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lbBranchCode, 0);
            this.Controls.SetChildIndex(this.lookUpBranchCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpBranchCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTestTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTestTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPTVC;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpBranchCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpVendor;
        private System.Windows.Forms.Label lbBranchCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpBranchCode;
    }
}
