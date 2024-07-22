namespace VNS.ERP.GUI.Sales
{
    partial class FormReportDiscount
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
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTextEditDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuarterDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxReportDetail = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTextEditDecimaln21 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuarterDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTextEditPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuarterDiscountAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearDiscountAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbQuarter = new System.Windows.Forms.Label();
            this.numUpDnQuarter = new System.Windows.Forms.NumericUpDown();
            this.lbYear = new System.Windows.Forms.Label();
            this.TxtYearNo = new DevExpress.XtraEditors.TextEdit();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnReportDiscountDetail = new System.Windows.Forms.Button();
            this.btnReportDiscount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.groupBoxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditDecimaln2)).BeginInit();
            this.groupBoxReportDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditDecimaln21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).BeginInit();
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
            // groupBoxReport
            // 
            this.groupBoxReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReport.Controls.Add(this.gridControl1);
            this.groupBoxReport.Location = new System.Drawing.Point(2, 31);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(954, 273);
            this.groupBoxReport.TabIndex = 2;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Báo cáo tổng hợp";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 17);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reTextEditDecimaln2});
            this.gridControl1.Size = new System.Drawing.Size(948, 253);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerCode,
            this.colCustomerName,
            this.colProvinceName,
            this.colInvoiceAmount,
            this.colQuarterDiscountAmount,
            this.colYearDiscountAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProvinceName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "Mã KH";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 0;
            this.colCustomerCode.Width = 91;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Tên KH";
            this.colCustomerName.FieldName = "SubjectName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 164;
            // 
            // colProvinceName
            // 
            this.colProvinceName.Caption = "Tỉnh";
            this.colProvinceName.FieldName = "ProvinceName";
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.Visible = true;
            this.colProvinceName.VisibleIndex = 2;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.Caption = "Tổng tiền hoá đơn";
            this.colInvoiceAmount.ColumnEdit = this.reTextEditDecimaln2;
            this.colInvoiceAmount.FieldName = "InvoiceAmount";
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colInvoiceAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInvoiceAmount.Visible = true;
            this.colInvoiceAmount.VisibleIndex = 2;
            this.colInvoiceAmount.Width = 123;
            // 
            // reTextEditDecimaln2
            // 
            this.reTextEditDecimaln2.AutoHeight = false;
            this.reTextEditDecimaln2.Mask.EditMask = "n2";
            this.reTextEditDecimaln2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reTextEditDecimaln2.Mask.UseMaskAsDisplayFormat = true;
            this.reTextEditDecimaln2.Name = "reTextEditDecimaln2";
            // 
            // colQuarterDiscountAmount
            // 
            this.colQuarterDiscountAmount.Caption = "Tổng chiết khấu";
            this.colQuarterDiscountAmount.ColumnEdit = this.reTextEditDecimaln2;
            this.colQuarterDiscountAmount.FieldName = "QuarterDiscountAmount";
            this.colQuarterDiscountAmount.Name = "colQuarterDiscountAmount";
            this.colQuarterDiscountAmount.OptionsColumn.ShowInCustomizationForm = false;
            this.colQuarterDiscountAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colQuarterDiscountAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuarterDiscountAmount.Visible = true;
            this.colQuarterDiscountAmount.VisibleIndex = 3;
            this.colQuarterDiscountAmount.Width = 152;
            // 
            // colYearDiscountAmount
            // 
            this.colYearDiscountAmount.Caption = "Tổng chiết khấu";
            this.colYearDiscountAmount.ColumnEdit = this.reTextEditDecimaln2;
            this.colYearDiscountAmount.FieldName = "YearDiscountAmount";
            this.colYearDiscountAmount.Name = "colYearDiscountAmount";
            this.colYearDiscountAmount.OptionsColumn.ShowInCustomizationForm = false;
            this.colYearDiscountAmount.SummaryItem.DisplayFormat = "{0:n2}";
            this.colYearDiscountAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYearDiscountAmount.Visible = true;
            this.colYearDiscountAmount.VisibleIndex = 4;
            this.colYearDiscountAmount.Width = 155;
            // 
            // groupBoxReportDetail
            // 
            this.groupBoxReportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReportDetail.Controls.Add(this.gridControl2);
            this.groupBoxReportDetail.Location = new System.Drawing.Point(2, 302);
            this.groupBoxReportDetail.Name = "groupBoxReportDetail";
            this.groupBoxReportDetail.Size = new System.Drawing.Size(954, 278);
            this.groupBoxReportDetail.TabIndex = 3;
            this.groupBoxReportDetail.TabStop = false;
            this.groupBoxReportDetail.Text = "Báo cáo chi tiết";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(3, 17);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reTextEditDecimaln21,
            this.reTextEditPercent});
            this.gridControl2.Size = new System.Drawing.Size(948, 258);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colInvoiceAmount1,
            this.colQuarterDiscount,
            this.colQuarterDiscountAmount1,
            this.colYearDiscount,
            this.colYearDiscountAmount1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Số hoá đơn";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            this.colInvoiceNo.Width = 90;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Ngày hoá đơn";
            this.colInvoiceDate.FieldName = "SaleRequestDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 1;
            this.colInvoiceDate.Width = 100;
            // 
            // colInvoiceAmount1
            // 
            this.colInvoiceAmount1.Caption = "Tiền hoá đơn";
            this.colInvoiceAmount1.ColumnEdit = this.reTextEditDecimaln21;
            this.colInvoiceAmount1.FieldName = "InvoiceAmount";
            this.colInvoiceAmount1.Name = "colInvoiceAmount1";
            this.colInvoiceAmount1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colInvoiceAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInvoiceAmount1.Visible = true;
            this.colInvoiceAmount1.VisibleIndex = 2;
            this.colInvoiceAmount1.Width = 105;
            // 
            // reTextEditDecimaln21
            // 
            this.reTextEditDecimaln21.AutoHeight = false;
            this.reTextEditDecimaln21.Mask.EditMask = "n2";
            this.reTextEditDecimaln21.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reTextEditDecimaln21.Mask.UseMaskAsDisplayFormat = true;
            this.reTextEditDecimaln21.Name = "reTextEditDecimaln21";
            // 
            // colQuarterDiscount
            // 
            this.colQuarterDiscount.Caption = "Chiết khấu quý";
            this.colQuarterDiscount.ColumnEdit = this.reTextEditPercent;
            this.colQuarterDiscount.FieldName = "QuarterDiscount";
            this.colQuarterDiscount.Name = "colQuarterDiscount";
            this.colQuarterDiscount.OptionsColumn.ShowInCustomizationForm = false;
            this.colQuarterDiscount.Visible = true;
            this.colQuarterDiscount.VisibleIndex = 3;
            this.colQuarterDiscount.Width = 131;
            // 
            // reTextEditPercent
            // 
            this.reTextEditPercent.AutoHeight = false;
            this.reTextEditPercent.Mask.EditMask = "p";
            this.reTextEditPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reTextEditPercent.Mask.UseMaskAsDisplayFormat = true;
            this.reTextEditPercent.Name = "reTextEditPercent";
            // 
            // colQuarterDiscountAmount1
            // 
            this.colQuarterDiscountAmount1.Caption = "Tiền chiết khấu";
            this.colQuarterDiscountAmount1.ColumnEdit = this.reTextEditDecimaln21;
            this.colQuarterDiscountAmount1.FieldName = "QuarterDiscountAmount";
            this.colQuarterDiscountAmount1.Name = "colQuarterDiscountAmount1";
            this.colQuarterDiscountAmount1.OptionsColumn.ShowInCustomizationForm = false;
            this.colQuarterDiscountAmount1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colQuarterDiscountAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuarterDiscountAmount1.Visible = true;
            this.colQuarterDiscountAmount1.VisibleIndex = 4;
            this.colQuarterDiscountAmount1.Width = 123;
            // 
            // colYearDiscount
            // 
            this.colYearDiscount.Caption = "Chiết khấu năm";
            this.colYearDiscount.ColumnEdit = this.reTextEditPercent;
            this.colYearDiscount.FieldName = "YearDiscount";
            this.colYearDiscount.Name = "colYearDiscount";
            this.colYearDiscount.OptionsColumn.ShowInCustomizationForm = false;
            this.colYearDiscount.Visible = true;
            this.colYearDiscount.VisibleIndex = 5;
            this.colYearDiscount.Width = 112;
            // 
            // colYearDiscountAmount1
            // 
            this.colYearDiscountAmount1.Caption = "Tiền chiết khấu";
            this.colYearDiscountAmount1.ColumnEdit = this.reTextEditDecimaln21;
            this.colYearDiscountAmount1.FieldName = "YearDiscountAmount";
            this.colYearDiscountAmount1.Name = "colYearDiscountAmount1";
            this.colYearDiscountAmount1.OptionsColumn.ShowInCustomizationForm = false;
            this.colYearDiscountAmount1.SummaryItem.DisplayFormat = "{0:n2}";
            this.colYearDiscountAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colYearDiscountAmount1.Visible = true;
            this.colYearDiscountAmount1.VisibleIndex = 6;
            this.colYearDiscountAmount1.Width = 126;
            // 
            // lbQuarter
            // 
            this.lbQuarter.AutoSize = true;
            this.lbQuarter.Location = new System.Drawing.Point(14, 8);
            this.lbQuarter.Name = "lbQuarter";
            this.lbQuarter.Size = new System.Drawing.Size(27, 13);
            this.lbQuarter.TabIndex = 4;
            this.lbQuarter.Text = "Quý";
            // 
            // numUpDnQuarter
            // 
            this.numUpDnQuarter.Location = new System.Drawing.Point(46, 6);
            this.numUpDnQuarter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDnQuarter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnQuarter.Name = "numUpDnQuarter";
            this.numUpDnQuarter.Size = new System.Drawing.Size(33, 20);
            this.numUpDnQuarter.TabIndex = 5;
            this.numUpDnQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDnQuarter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnQuarter.ValueChanged += new System.EventHandler(this.numUpDnQuarter_ValueChanged);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(85, 9);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(28, 13);
            this.lbYear.TabIndex = 6;
            this.lbYear.Text = "Năm";
            // 
            // TxtYearNo
            // 
            this.TxtYearNo.EditValue = "2007";
            this.TxtYearNo.Location = new System.Drawing.Point(118, 5);
            this.TxtYearNo.Name = "TxtYearNo";
            this.TxtYearNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearNo.Properties.Appearance.Options.UseFont = true;
            this.TxtYearNo.Properties.EditFormat.FormatString = "9";
            this.TxtYearNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtYearNo.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?";
            this.TxtYearNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TxtYearNo.Properties.Mask.PlaceHolder = '\0';
            this.TxtYearNo.Properties.Mask.ShowPlaceHolders = false;
            this.TxtYearNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtYearNo.Properties.MaxLength = 20;
            this.TxtYearNo.Size = new System.Drawing.Size(40, 22);
            this.TxtYearNo.TabIndex = 7;
            this.TxtYearNo.EditValueChanged += new System.EventHandler(this.TxtYearNo_EditValueChanged);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(162, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(83, 21);
            this.btnBaoCao.TabIndex = 8;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnReportDiscountDetail
            // 
            this.btnReportDiscountDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportDiscountDetail.Enabled = false;
            this.btnReportDiscountDetail.Location = new System.Drawing.Point(844, 585);
            this.btnReportDiscountDetail.Name = "btnReportDiscountDetail";
            this.btnReportDiscountDetail.Size = new System.Drawing.Size(112, 21);
            this.btnReportDiscountDetail.TabIndex = 9;
            this.btnReportDiscountDetail.Text = "In báo cáo chi tiết";
            this.btnReportDiscountDetail.UseVisualStyleBackColor = true;
            this.btnReportDiscountDetail.Click += new System.EventHandler(this.btnReportDiscountDetail_Click);
            // 
            // btnReportDiscount
            // 
            this.btnReportDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportDiscount.Enabled = false;
            this.btnReportDiscount.Location = new System.Drawing.Point(728, 585);
            this.btnReportDiscount.Name = "btnReportDiscount";
            this.btnReportDiscount.Size = new System.Drawing.Size(112, 21);
            this.btnReportDiscount.TabIndex = 10;
            this.btnReportDiscount.Text = "In báo cáo tổng hợp";
            this.btnReportDiscount.UseVisualStyleBackColor = true;
            this.btnReportDiscount.Click += new System.EventHandler(this.btnReportDiscount_Click);
            // 
            // FormReportDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 610);
            this.Controls.Add(this.btnReportDiscount);
            this.Controls.Add(this.btnReportDiscountDetail);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.TxtYearNo);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.numUpDnQuarter);
            this.Controls.Add(this.lbQuarter);
            this.Controls.Add(this.groupBoxReportDetail);
            this.Controls.Add(this.groupBoxReport);
            this.Name = "FormReportDiscount";
            this.Text = "FormReportDiscount";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.groupBoxReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditDecimaln2)).EndInit();
            this.groupBoxReportDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditDecimaln21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxReport;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reTextEditDecimaln2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuarterDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colYearDiscountAmount;
        private System.Windows.Forms.GroupBox groupBoxReportDetail;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuarterDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reTextEditDecimaln21;
        private DevExpress.XtraGrid.Columns.GridColumn colQuarterDiscountAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colYearDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colYearDiscountAmount1;
        private System.Windows.Forms.Label lbQuarter;
        private System.Windows.Forms.NumericUpDown numUpDnQuarter;
        private System.Windows.Forms.Label lbYear;
        private DevExpress.XtraEditors.TextEdit TxtYearNo;
        private System.Windows.Forms.Button btnBaoCao;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reTextEditPercent;
        private System.Windows.Forms.Button btnReportDiscountDetail;
        private System.Windows.Forms.Button btnReportDiscount;
    }
}