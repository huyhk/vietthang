namespace VNS.ERP.GUI.Sales
{
    partial class FormRpCustomerDeptOpening
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTungay = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cboTungay = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProvinceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrgAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaidAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTungay.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.84987F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 68);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45902F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.32919F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.34161F));
            this.tableLayoutPanel3.Controls.Add(this.lblTungay, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboTungay, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(168, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(450, 62);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblTungay
            // 
            this.lblTungay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTungay.AutoSize = true;
            this.lblTungay.Location = new System.Drawing.Point(84, 24);
            this.lblTungay.Name = "lblTungay";
            this.lblTungay.Size = new System.Drawing.Size(36, 13);
            this.lblTungay.TabIndex = 0;
            this.lblTungay.Text = "Ngày:";
            this.lblTungay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Location = new System.Drawing.Point(248, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.ToolTip = "Refresh Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboTungay
            // 
            this.cboTungay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTungay.EditValue = new System.DateTime(2007, 2, 9, 0, 0, 0, 0);
            this.cboTungay.Location = new System.Drawing.Point(126, 21);
            this.cboTungay.Name = "cboTungay";
            this.cboTungay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboTungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTungay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cboTungay.Size = new System.Drawing.Size(116, 20);
            this.cboTungay.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnReports, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.08901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.97731F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.933682F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 573);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Enabled = false;
            this.btnReports.Location = new System.Drawing.Point(315, 541);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(162, 28);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "Reports";
            this.btnReports.ToolTip = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 78);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(786, 457);
            this.gridControl.TabIndex = 9;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProvinceName,
            this.colCustomerCode,
            this.colSubjectName,
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colStockCode,
            this.colOrgAmount,
            this.colPaidAmount,
            this.colRemainAmount,
            this.colDueDate,
            this.colDateLimit});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 2;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView.OptionsFilter.AllowMRUFilterList = false;
            this.gridView.OptionsPrint.ExpandAllDetails = true;
            this.gridView.OptionsPrint.ExpandAllGroups = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFilterPanel = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProvinceName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProvinceName
            // 
            this.colProvinceName.Caption = "ProvinceName";
            this.colProvinceName.FieldName = "ProvinceName";
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.Width = 94;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Width = 85;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.OptionsColumn.AllowIncrementalSearch = false;
            this.colSubjectName.OptionsColumn.AllowSize = false;
            this.colSubjectName.OptionsColumn.FixedWidth = true;
            this.colSubjectName.OptionsFilter.AllowAutoFilter = false;
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 0;
            this.colSubjectName.Width = 250;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "InvoiceNo";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 2;
            this.colInvoiceNo.Width = 61;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "InvoiceDate";
            this.colInvoiceDate.DisplayFormat.FormatString = "d";
            this.colInvoiceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 1;
            this.colInvoiceDate.Width = 77;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "StockCode";
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 3;
            this.colStockCode.Width = 84;
            // 
            // colOrgAmount
            // 
            this.colOrgAmount.Caption = "OrgAmount";
            this.colOrgAmount.DisplayFormat.FormatString = "{0:###,###,###,###,##0}";
            this.colOrgAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrgAmount.FieldName = "OrgAmount";
            this.colOrgAmount.Name = "colOrgAmount";
            this.colOrgAmount.OptionsColumn.AllowSize = false;
            this.colOrgAmount.Visible = true;
            this.colOrgAmount.VisibleIndex = 4;
            this.colOrgAmount.Width = 124;
            // 
            // colPaidAmount
            // 
            this.colPaidAmount.Caption = "PaidAmount";
            this.colPaidAmount.DisplayFormat.FormatString = "{0:###,###,###,###,##0}";
            this.colPaidAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaidAmount.FieldName = "PaidAmount";
            this.colPaidAmount.Name = "colPaidAmount";
            this.colPaidAmount.OptionsColumn.AllowSize = false;
            this.colPaidAmount.Visible = true;
            this.colPaidAmount.VisibleIndex = 5;
            this.colPaidAmount.Width = 126;
            // 
            // colRemainAmount
            // 
            this.colRemainAmount.Caption = "RemainAmount";
            this.colRemainAmount.DisplayFormat.FormatString = "{0:###,###,###,###,##0}";
            this.colRemainAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRemainAmount.FieldName = "RemainAmount";
            this.colRemainAmount.Name = "colRemainAmount";
            this.colRemainAmount.OptionsColumn.AllowSize = false;
            this.colRemainAmount.Visible = true;
            this.colRemainAmount.VisibleIndex = 6;
            this.colRemainAmount.Width = 128;
            // 
            // colDueDate
            // 
            this.colDueDate.Caption = "DueDate";
            this.colDueDate.DisplayFormat.FormatString = "d";
            this.colDueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.Visible = true;
            this.colDueDate.VisibleIndex = 7;
            this.colDueDate.Width = 69;
            // 
            // colDateLimit
            // 
            this.colDateLimit.Caption = "DateLimit";
            this.colDateLimit.FieldName = "DateLimit";
            this.colDateLimit.Name = "colDateLimit";
            // 
            // FormRpCustomerDeptOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRpCustomerDeptOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRpCustomerDeptOpening";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTungay.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTungay;
        private DevExpress.XtraEditors.DateEdit cboTungay;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colOrgAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPaidAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainAmount;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLimit;
    }
}