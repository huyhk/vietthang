namespace VNS.ERP.GUI.Sales
{
    partial class FormRpSaleRequestsItemSale
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
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.btnReportGroup = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.chkExcel = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.Enabled = false;
            this.btnReports.Location = new System.Drawing.Point(436, 650);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(171, 27);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.ToolTip = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReportGroup
            // 
            this.btnReportGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportGroup.Enabled = false;
            this.btnReportGroup.Location = new System.Drawing.Point(634, 650);
            this.btnReportGroup.Name = "btnReportGroup";
            this.btnReportGroup.Size = new System.Drawing.Size(146, 27);
            this.btnReportGroup.TabIndex = 9;
            this.btnReportGroup.Text = "Reports Group";
            this.btnReportGroup.ToolTip = "Reports";
            this.btnReportGroup.Click += new System.EventHandler(this.btnReportGroup_Click);
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.Location = new System.Drawing.Point(6, 70);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUp});
            this.gridControl.Size = new System.Drawing.Size(786, 574);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNo,
            this.colSaleRequestDate,
            this.colCustomerCode,
            this.colSubjectName,
            this.colItemCode,
            this.colQuantity,
            this.colInvoiceAmount});
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "InvoiceNo";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            this.colInvoiceNo.Width = 97;
            // 
            // colSaleRequestDate
            // 
            this.colSaleRequestDate.Caption = "SaleRequestDate";
            this.colSaleRequestDate.DisplayFormat.FormatString = "d";
            this.colSaleRequestDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaleRequestDate.FieldName = "SaleRequestDate";
            this.colSaleRequestDate.Name = "colSaleRequestDate";
            this.colSaleRequestDate.Visible = true;
            this.colSaleRequestDate.VisibleIndex = 1;
            this.colSaleRequestDate.Width = 108;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 2;
            this.colCustomerCode.Width = 113;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 3;
            this.colSubjectName.Width = 172;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.ItemLookUp;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 4;
            this.colItemCode.Width = 157;
            // 
            // ItemLookUp
            // 
            this.ItemLookUp.AutoHeight = false;
            this.ItemLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName")});
            this.ItemLookUp.DisplayMember = "ItemName";
            this.ItemLookUp.Name = "ItemLookUp";
            this.ItemLookUp.NullText = "";
            this.ItemLookUp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUp.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.DisplayFormat.FormatString = "{0:###,###,###,###,###,##0}";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 141;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.Caption = "InvoiceAmount";
            this.colInvoiceAmount.DisplayFormat.FormatString = "{0:###,###,###,###,###,###,##0}";
            this.colInvoiceAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInvoiceAmount.FieldName = "InvoiceAmount";
            this.colInvoiceAmount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.Visible = true;
            this.colInvoiceAmount.VisibleIndex = 6;
            this.colInvoiceAmount.Width = 123;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(511, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.ToolTip = "Refresh Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 2);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 10;
            // 
            // chkExcel
            // 
            this.chkExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExcel.Location = new System.Drawing.Point(332, 653);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Properties.Caption = "Excel";
            this.chkExcel.Size = new System.Drawing.Size(75, 19);
            this.chkExcel.TabIndex = 11;
            // 
            // FormRpSaleRequestsItemSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 689);
            this.Controls.Add(this.chkExcel);
            this.Controls.Add(this.btnReportGroup);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormRpSaleRequestsItemSale";
            this.Text = "FormRpSaleRequestsItems";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnReports;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUp;
        private DevExpress.XtraEditors.SimpleButton btnReportGroup;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.CheckEdit chkExcel;
    }
}