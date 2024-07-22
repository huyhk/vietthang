namespace VNS.ERP.GUI.Sales
{
    partial class FormCustomerPayments
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
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerPaymentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookCustomerCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditPaymentType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucCustomerPayments1 = new VNS.ERP.GUI.UCCustomerPayments();
            this.lblBranchCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookCustomerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditPaymentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.ucCustomerPayments1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.78481F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.21519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 440);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookCustomerCode,
            this.LookUpEditStockCode,
            this.LookUpEditPaymentType,
            this.txtAmount});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(786, 314);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockCode,
            this.colCustomerPaymentNo,
            this.colCustomerCode,
            this.colCustomerPaymentDate,
            this.colPaymentType,
            this.colAmount,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(627, 558, 208, 170);
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "StockCode";
            this.colStockCode.ColumnEdit = this.LookUpEditStockCode;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 4;
            this.colStockCode.Width = 179;
            // 
            // LookUpEditStockCode
            // 
            this.LookUpEditStockCode.AutoHeight = false;
            this.LookUpEditStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã ", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên ", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.LookUpEditStockCode.DisplayMember = "SubjectName";
            this.LookUpEditStockCode.Name = "LookUpEditStockCode";
            this.LookUpEditStockCode.NullText = "";
            this.LookUpEditStockCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpEditStockCode.ValueMember = "SubjectCode";
            // 
            // colCustomerPaymentNo
            // 
            this.colCustomerPaymentNo.Caption = "PaymentNo";
            this.colCustomerPaymentNo.FieldName = "PaymentNo";
            this.colCustomerPaymentNo.Name = "colCustomerPaymentNo";
            this.colCustomerPaymentNo.Visible = true;
            this.colCustomerPaymentNo.VisibleIndex = 0;
            this.colCustomerPaymentNo.Width = 111;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.ColumnEdit = this.ItemLookCustomerCode;
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 2;
            this.colCustomerCode.Width = 152;
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
            // colCustomerPaymentDate
            // 
            this.colCustomerPaymentDate.Caption = "PaymentDate";
            this.colCustomerPaymentDate.DisplayFormat.FormatString = "d";
            this.colCustomerPaymentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCustomerPaymentDate.FieldName = "PaymentDate";
            this.colCustomerPaymentDate.Name = "colCustomerPaymentDate";
            this.colCustomerPaymentDate.Visible = true;
            this.colCustomerPaymentDate.VisibleIndex = 1;
            this.colCustomerPaymentDate.Width = 131;
            // 
            // colPaymentType
            // 
            this.colPaymentType.Caption = "PaymentType";
            this.colPaymentType.ColumnEdit = this.LookUpEditPaymentType;
            this.colPaymentType.FieldName = "PaymentType";
            this.colPaymentType.Name = "colPaymentType";
            this.colPaymentType.Visible = true;
            this.colPaymentType.VisibleIndex = 3;
            this.colPaymentType.Width = 121;
            // 
            // LookUpEditPaymentType
            // 
            this.LookUpEditPaymentType.AutoHeight = false;
            this.LookUpEditPaymentType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditPaymentType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID", "", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.LookUpEditPaymentType.DisplayMember = "EnumText";
            this.LookUpEditPaymentType.Name = "LookUpEditPaymentType";
            this.LookUpEditPaymentType.NullText = "";
            this.LookUpEditPaymentType.ValueMember = "EnumID";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.ColumnEdit = this.txtAmount;
            this.colAmount.DisplayFormat.FormatString = "{0:###,###,###,###,###,##0}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            this.colAmount.Width = 104;
            // 
            // txtAmount
            // 
            this.txtAmount.AutoHeight = false;
            this.txtAmount.Mask.EditMask = "n2";
            this.txtAmount.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.NullText = "0";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 520;
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
            // ucCustomerPayments1
            // 
            this.ucCustomerPayments1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomerPayments1.Location = new System.Drawing.Point(3, 323);
            this.ucCustomerPayments1.Name = "ucCustomerPayments1";
            this.ucCustomerPayments1.Size = new System.Drawing.Size(786, 114);
            this.ucCustomerPayments1.TabIndex = 2;
            // 
            // lblBranchCode
            // 
            this.lblBranchCode.AutoSize = true;
            this.lblBranchCode.Location = new System.Drawing.Point(427, 64);
            this.lblBranchCode.Name = "lblBranchCode";
            this.lblBranchCode.Size = new System.Drawing.Size(76, 16);
            this.lblBranchCode.TabIndex = 11;
            this.lblBranchCode.Text = "BranchCode";
            this.lblBranchCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(509, 60);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên ", 150)});
            this.lookUpStockCode.Properties.DisplayMember = "SubjectName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.ValueMember = "SubjectCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(133, 20);
            this.lookUpStockCode.TabIndex = 13;
            this.lookUpStockCode.EditValueChanged += new System.EventHandler(this.lookUpStockCode_EditValueChanged);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 44);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 105;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(694, 58);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 106;
            this.btnGetData.Text = "Refresh";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // FormCustomerPayments
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.lblBranchCode);
            this.EditControl = this.ucCustomerPayments1;
            this.GridControl = this.gridControl;
            this.Name = "FormCustomerPayments";
            this.Text = "CustomerPayments";
            this.Load += new System.EventHandler(this.FormCustomerPayments_Load);
            this.Controls.SetChildIndex(this.lblBranchCode, 0);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.ucDatePeriodSelection1, 0);
            this.Controls.SetChildIndex(this.btnGetData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookCustomerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditPaymentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPaymentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private UCCustomerPayments ucCustomerPayments1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditPaymentType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtAmount;
        private System.Windows.Forms.Label lblBranchCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
    }
}