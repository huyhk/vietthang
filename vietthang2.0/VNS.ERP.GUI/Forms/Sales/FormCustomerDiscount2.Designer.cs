namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerDiscount2
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProvinces = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditProvince = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpEditDiscountTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCustomerDiscount21 = new VNS.ERP.GUI.UserControls.UCCustomerDiscount2();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportAllDataToExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpEditDiscountTypeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
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
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(2, 44);
            this.gridControl2.MainView = this.gridView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditProvince});
            this.gridControl2.Size = new System.Drawing.Size(478, 368);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProvinces,
            this.colSubjectCode,
            this.colSubjectName,
            this.colAddress,
            this.colPhone,
            this.colFax,
            this.colTaxCode,
            this.colBankName,
            this.colBankAccountNo,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl2;
            this.gridView.GroupCount = 1;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProvinces, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.ColumnFilterChanged += new System.EventHandler(this.gridView_ColumnFilterChanged);
            // 
            // colProvinces
            // 
            this.colProvinces.Caption = "ProvinceName";
            this.colProvinces.ColumnEdit = this.repLookUpEditProvince;
            this.colProvinces.FieldName = "Province";
            this.colProvinces.Name = "colProvinces";
            this.colProvinces.Visible = true;
            this.colProvinces.VisibleIndex = 0;
            this.colProvinces.Width = 90;
            // 
            // repLookUpEditProvince
            // 
            this.repLookUpEditProvince.AutoHeight = false;
            this.repLookUpEditProvince.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditProvince.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProvinceCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProvinceName")});
            this.repLookUpEditProvince.DisplayMember = "ProvinceName";
            this.repLookUpEditProvince.Name = "repLookUpEditProvince";
            this.repLookUpEditProvince.NullText = "";
            this.repLookUpEditProvince.ValueMember = "ProvinceCode";
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.OptionsColumn.AllowFocus = false;
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 0;
            this.colSubjectCode.Width = 85;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.OptionsColumn.AllowFocus = false;
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 1;
            this.colSubjectName.Width = 157;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.Width = 185;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.Width = 104;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowFocus = false;
            this.colFax.Width = 86;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "TaxCode";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.OptionsColumn.AllowFocus = false;
            this.colTaxCode.Width = 81;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "BankName";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowFocus = false;
            this.colBankName.Width = 140;
            // 
            // colBankAccountNo
            // 
            this.colBankAccountNo.Caption = "BankAccountNo";
            this.colBankAccountNo.FieldName = "BankAccountNo";
            this.colBankAccountNo.Name = "colBankAccountNo";
            this.colBankAccountNo.OptionsColumn.AllowFocus = false;
            this.colBankAccountNo.Width = 164;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.Width = 358;
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
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(483, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpEditDiscountTypeCode});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(487, 366);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colDiscountTypeCode,
            this.colDiscountPercent,
            this.colDescription1,
            this.colUserCreated1,
            this.colDateCreated1,
            this.colUserUpdated1,
            this.colDateUpdated1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStartDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày";
            this.colStartDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 0;
            this.colStartDate.Width = 88;
            // 
            // colDiscountTypeCode
            // 
            this.colDiscountTypeCode.Caption = "Loại chiết khấu";
            this.colDiscountTypeCode.ColumnEdit = this.repItemLookUpEditDiscountTypeCode;
            this.colDiscountTypeCode.DisplayFormat.FormatString = "p";
            this.colDiscountTypeCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountTypeCode.FieldName = "DiscountTypeCode";
            this.colDiscountTypeCode.Name = "colDiscountTypeCode";
            this.colDiscountTypeCode.Visible = true;
            this.colDiscountTypeCode.VisibleIndex = 0;
            this.colDiscountTypeCode.Width = 108;
            // 
            // repItemLookUpEditDiscountTypeCode
            // 
            this.repItemLookUpEditDiscountTypeCode.AutoHeight = false;
            this.repItemLookUpEditDiscountTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpEditDiscountTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeName")});
            this.repItemLookUpEditDiscountTypeCode.DisplayMember = "DiscountTypeName";
            this.repItemLookUpEditDiscountTypeCode.Name = "repItemLookUpEditDiscountTypeCode";
            this.repItemLookUpEditDiscountTypeCode.NullText = "";
            this.repItemLookUpEditDiscountTypeCode.ValueMember = "DiscountTypeCode";
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.Caption = "% Chiết khấu";
            this.colDiscountPercent.DisplayFormat.FormatString = "p";
            this.colDiscountPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 1;
            this.colDiscountPercent.Width = 91;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "Diễn giải";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            this.colDescription1.Width = 310;
            // 
            // colUserCreated1
            // 
            this.colUserCreated1.Caption = "User tạo";
            this.colUserCreated1.FieldName = "UserCreated";
            this.colUserCreated1.Name = "colUserCreated1";
            // 
            // colDateCreated1
            // 
            this.colDateCreated1.Caption = "Ngày tạo";
            this.colDateCreated1.FieldName = "DateCreated";
            this.colDateCreated1.Name = "colDateCreated1";
            // 
            // colUserUpdated1
            // 
            this.colUserUpdated1.Caption = "User cập nhật";
            this.colUserUpdated1.FieldName = "UserUpdated";
            this.colUserUpdated1.Name = "colUserUpdated1";
            // 
            // colDateUpdated1
            // 
            this.colDateUpdated1.Caption = "Ngày cập nhật";
            this.colDateUpdated1.FieldName = "DateUpdated";
            this.colDateUpdated1.Name = "colDateUpdated1";
            // 
            // ucCustomerDiscount21
            // 
            this.ucCustomerDiscount21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCustomerDiscount21.CustomerCode = "";
            this.ucCustomerDiscount21.Location = new System.Drawing.Point(382, 416);
            this.ucCustomerDiscount21.Name = "ucCustomerDiscount21";
            this.ucCustomerDiscount21.Size = new System.Drawing.Size(585, 74);
            this.ucCustomerDiscount21.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Chọn ngày";
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateEdit1.EditValue = new System.DateTime(2009, 9, 15, 0, 0, 0, 0);
            this.dateEdit1.EnterMoveNextControl = true;
            this.dateEdit1.Location = new System.Drawing.Point(75, 424);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 106;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportExcel.Location = new System.Drawing.Point(185, 424);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(176, 23);
            this.btnExportExcel.TabIndex = 107;
            this.btnExportExcel.Text = "Xuất dữ liệu theo ngày ra excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportAllDataToExcel
            // 
            this.btnExportAllDataToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportAllDataToExcel.Location = new System.Drawing.Point(185, 453);
            this.btnExportAllDataToExcel.Name = "btnExportAllDataToExcel";
            this.btnExportAllDataToExcel.Size = new System.Drawing.Size(176, 23);
            this.btnExportAllDataToExcel.TabIndex = 107;
            this.btnExportAllDataToExcel.Text = "Xuất toàn bộ dữ liệu ra excel";
            this.btnExportAllDataToExcel.Click += new System.EventHandler(this.btnExportAllDataToExcel_Click);
            // 
            // FormCustomerDiscount2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.btnExportAllDataToExcel);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucCustomerDiscount21);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.EditControl = this.ucCustomerDiscount21;
            this.GridControl = this.gridControl1;
            this.Name = "FormCustomerDiscount2";
            this.Text = "FormCustomerDiscount2";
            this.Load += new System.EventHandler(this.FormCustomerDiscount2_Load);
            this.Controls.SetChildIndex(this.gridControl2, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucCustomerDiscount21, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dateEdit1, 0);
            this.Controls.SetChildIndex(this.btnExportExcel, 0);
            this.Controls.SetChildIndex(this.btnExportAllDataToExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpEditDiscountTypeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinces;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated1;
        private VNS.ERP.GUI.UserControls.UCCustomerDiscount2 ucCustomerDiscount21;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpEditDiscountTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditProvince;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.SimpleButton btnExportAllDataToExcel;

    }
}