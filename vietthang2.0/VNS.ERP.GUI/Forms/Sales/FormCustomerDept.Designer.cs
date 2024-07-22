namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerDept
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
            this.colNotCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCustomerDept1 = new VNS.ERP.GUI.UserControls.UCCustomerDept();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridControl2.Location = new System.Drawing.Point(6, 45);
            this.gridControl2.MainView = this.gridView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(406, 427);
            this.gridControl2.TabIndex = 5;
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
            this.colProvinces.FieldName = "Province";
            this.colProvinces.Name = "colProvinces";
            this.colProvinces.Visible = true;
            this.colProvinces.VisibleIndex = 0;
            this.colProvinces.Width = 90;
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
            this.gridControl1.Location = new System.Drawing.Point(419, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(530, 275);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colNotCash,
            this.colAmount,
            this.colDays,
            this.colDescription1,
            this.colAmountLimit,
            this.colDateLimit,
            this.colCash,
            this.colUserCreated1,
            this.colDateCreated1,
            this.colUserUpdated1,
            this.colDateUpdated1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
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
            // colNotCash
            // 
            this.colNotCash.Caption = "Cho phép nợ";
            this.colNotCash.FieldName = "NotCash";
            this.colNotCash.Name = "colNotCash";
            this.colNotCash.OptionsColumn.ShowInCustomizationForm = false;
            this.colNotCash.Width = 74;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tối đa ($)";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 73;
            // 
            // colDays
            // 
            this.colDays.Caption = "Hạn trả (ngày)";
            this.colDays.DisplayFormat.FormatString = "n0";
            this.colDays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDays.FieldName = "Days";
            this.colDays.Name = "colDays";
            this.colDays.Visible = true;
            this.colDays.VisibleIndex = 5;
            this.colDays.Width = 91;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "Diễn giải";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 6;
            this.colDescription1.Width = 264;
            // 
            // colAmountLimit
            // 
            this.colAmountLimit.Caption = "Có giới hạn tiền";
            this.colAmountLimit.FieldName = "AmountLimit";
            this.colAmountLimit.Name = "colAmountLimit";
            this.colAmountLimit.Visible = true;
            this.colAmountLimit.VisibleIndex = 2;
            this.colAmountLimit.Width = 89;
            // 
            // colDateLimit
            // 
            this.colDateLimit.Caption = "Có giới hạn ngày";
            this.colDateLimit.FieldName = "DateLimit";
            this.colDateLimit.Name = "colDateLimit";
            this.colDateLimit.Visible = true;
            this.colDateLimit.VisibleIndex = 4;
            this.colDateLimit.Width = 94;
            // 
            // colCash
            // 
            this.colCash.Caption = "Tiền mặt";
            this.colCash.FieldName = "Cash";
            this.colCash.Name = "colCash";
            this.colCash.Visible = true;
            this.colCash.VisibleIndex = 1;
            this.colCash.Width = 59;
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
            this.colDateCreated1.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
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
            this.colDateUpdated1.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated1.FieldName = "DateUpdated";
            this.colDateUpdated1.Name = "colDateUpdated1";
            // 
            // ucCustomerDept1
            // 
            this.ucCustomerDept1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCustomerDept1.Business = null;
            this.ucCustomerDept1.DataSource = null;
            this.ucCustomerDept1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCustomerDept1.Location = new System.Drawing.Point(414, 327);
            this.ucCustomerDept1.Margin = new System.Windows.Forms.Padding(4);
            this.ucCustomerDept1.Name = "ucCustomerDept1";
            this.ucCustomerDept1.Size = new System.Drawing.Size(537, 147);
            this.ucCustomerDept1.TabIndex = 7;
            // 
            // FormCustomerDept
            // 
            this.AllowSaveAndClose = false;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 501);
            this.Controls.Add(this.ucCustomerDept1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.EditControl = this.ucCustomerDept1;
            this.GridControl = this.gridControl1;
            this.Name = "FormCustomerDept";
            this.Text = "Danh mục định mức công nợ khách hàng";
            this.Load += new System.EventHandler(this.FormCustomerDept_Load);
            this.Controls.SetChildIndex(this.gridControl2, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucCustomerDept1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private VNS.ERP.GUI.UserControls.UCCustomerDept ucCustomerDept1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotCash;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDays;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCash;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated1;

    }
}