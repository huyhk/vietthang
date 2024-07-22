namespace VNS.ERP.GUI.Manufactures
{
    partial class FormRpManufactures
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
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal1 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal2 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal3 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            DevExpress.XtraPivotGrid.PivotGridCustomTotal pivotGridCustomTotal4 = new DevExpress.XtraPivotGrid.PivotGridCustomTotal();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cboKho = new DevExpress.XtraEditors.LookUpEdit();
            this.lblKho = new System.Windows.Forms.Label();
            this.cboDenngay = new DevExpress.XtraEditors.DateEdit();
            this.lblDenngay = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportMSExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreviews = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldLineNo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShift = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductWeight = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldManufactureDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridTotal = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenngay.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pivotGridControl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.24146F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.991228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel3.Controls.Add(this.btnRefresh, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboKho, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKho, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboDenngay, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDenngay, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(709, 28);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Location = new System.Drawing.Point(393, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.ToolTip = "Refresh Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboKho
            // 
            this.cboKho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboKho.EnterMoveNextControl = true;
            this.cboKho.Location = new System.Drawing.Point(80, 4);
            this.cboKho.Name = "cboKho";
            this.cboKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 220)});
            this.cboKho.Properties.DisplayMember = "StockName";
            this.cboKho.Properties.NullText = "";
            this.cboKho.Properties.PopupWidth = 300;
            this.cboKho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKho.Properties.ValueMember = "StockCode";
            this.cboKho.Size = new System.Drawing.Size(166, 20);
            this.cboKho.TabIndex = 0;
            // 
            // lblKho
            // 
            this.lblKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(21, 7);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(53, 13);
            this.lblKho.TabIndex = 0;
            this.lblKho.Text = "Nhà máy:";
            this.lblKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboDenngay
            // 
            this.cboDenngay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboDenngay.EditValue = new System.DateTime(2007, 8, 8, 0, 0, 0, 0);
            this.cboDenngay.EnterMoveNextControl = true;
            this.cboDenngay.Location = new System.Drawing.Point(325, 4);
            this.cboDenngay.Name = "cboDenngay";
            this.cboDenngay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboDenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDenngay.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.cboDenngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cboDenngay.Properties.Mask.EditMask = "MM/yyyy";
            this.cboDenngay.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cboDenngay.Properties.NullDate = "";
            this.cboDenngay.Size = new System.Drawing.Size(65, 20);
            this.cboDenngay.TabIndex = 1;
            // 
            // lblDenngay
            // 
            this.lblDenngay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDenngay.AutoSize = true;
            this.lblDenngay.Location = new System.Drawing.Point(278, 7);
            this.lblDenngay.Name = "lblDenngay";
            this.lblDenngay.Size = new System.Drawing.Size(41, 13);
            this.lblDenngay.TabIndex = 0;
            this.lblDenngay.Text = "Tháng:";
            this.lblDenngay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.04231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.99013F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.1086F));
            this.tableLayoutPanel4.Controls.Add(this.btnExportMSExcel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPrintPreviews, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 418);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(709, 69);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // btnExportMSExcel
            // 
            this.btnExportMSExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExportMSExcel.Location = new System.Drawing.Point(215, 20);
            this.btnExportMSExcel.Name = "btnExportMSExcel";
            this.btnExportMSExcel.Size = new System.Drawing.Size(156, 28);
            this.btnExportMSExcel.TabIndex = 2;
            this.btnExportMSExcel.Text = "Export To Microsoft Excel";
            this.btnExportMSExcel.ToolTip = "Export To Microsoft Excel";
            this.btnExportMSExcel.Click += new System.EventHandler(this.btnExportMSExcel_Click);
            // 
            // btnPrintPreviews
            // 
            this.btnPrintPreviews.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrintPreviews.Location = new System.Drawing.Point(377, 20);
            this.btnPrintPreviews.Name = "btnPrintPreviews";
            this.btnPrintPreviews.Size = new System.Drawing.Size(156, 28);
            this.btnPrintPreviews.TabIndex = 2;
            this.btnPrintPreviews.Text = "Print Preview";
            this.btnPrintPreviews.ToolTip = "Print Preview";
            this.btnPrintPreviews.Click += new System.EventHandler(this.btnPrintPreviews_Click);
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Appearance.ColumnHeaderArea.Options.UseTextOptions = true;
            this.pivotGridControl.Appearance.ColumnHeaderArea.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridControl.Appearance.FieldHeader.Options.UseTextOptions = true;
            this.pivotGridControl.Appearance.FieldHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldLineNo,
            this.fieldShift,
            this.fieldProductWeight,
            this.fieldManufactureDate,
            this.pivotGridTotal});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 34);
            this.pivotGridControl.Margin = new System.Windows.Forms.Padding(0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pivotGridControl.OptionsSelection.EnableAppearanceFocusedCell = true;
            this.pivotGridControl.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl.Size = new System.Drawing.Size(715, 381);
            this.pivotGridControl.TabIndex = 0;
            // 
            // fieldLineNo
            // 
            this.fieldLineNo.Appearance.Header.Options.UseTextOptions = true;
            this.fieldLineNo.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldLineNo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldLineNo.AreaIndex = 0;
            this.fieldLineNo.Caption = "Line";
            this.fieldLineNo.FieldName = "LinesxNo";
            this.fieldLineNo.GrandTotalText = "Tổng";
            this.fieldLineNo.Name = "fieldLineNo";
            this.fieldLineNo.TotalValueFormat.FormatString = "Tổng  {0}";
            this.fieldLineNo.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldLineNo.ValueFormat.FormatString = "{0}";
            this.fieldLineNo.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldShift
            // 
            this.fieldShift.Appearance.Header.Options.UseTextOptions = true;
            this.fieldShift.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldShift.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShift.AreaIndex = 1;
            this.fieldShift.Caption = "Ca";
            this.fieldShift.FieldName = "Shift";
            this.fieldShift.GrandTotalText = "Tổng";
            this.fieldShift.Name = "fieldShift";
            this.fieldShift.SortBySummaryInfo.Field = this.fieldProductWeight;
            this.fieldShift.SummaryVariation = DevExpress.Data.PivotGrid.PivotSummaryVariation.Absolute;
            this.fieldShift.TotalCellFormat.FormatString = "Tổng";
            this.fieldShift.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
            this.fieldShift.TotalValueFormat.FormatString = "Tổng {0}";
            this.fieldShift.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldShift.ValueFormat.FormatString = "{0}";
            this.fieldShift.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldProductWeight
            // 
            this.fieldProductWeight.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductWeight.AreaIndex = 0;
            this.fieldProductWeight.Caption = "Số lượng";
            this.fieldProductWeight.CellFormat.FormatString = "{0:###,###,###,###,###}";
            this.fieldProductWeight.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductWeight.FieldName = "ProductWeight";
            this.fieldProductWeight.Name = "fieldProductWeight";
            this.fieldProductWeight.ValueFormat.FormatString = "{0:###,###,###,###}";
            this.fieldProductWeight.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldManufactureDate
            // 
            this.fieldManufactureDate.Appearance.Header.Options.UseTextOptions = true;
            this.fieldManufactureDate.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldManufactureDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldManufactureDate.AreaIndex = 1;
            this.fieldManufactureDate.Caption = "Ngày";
            this.fieldManufactureDate.CellFormat.FormatString = "d";
            this.fieldManufactureDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldManufactureDate.FieldName = "ManufactureDate";
            this.fieldManufactureDate.Name = "fieldManufactureDate";
            this.fieldManufactureDate.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldManufactureDate.ValueFormat.FormatString = "d";
            this.fieldManufactureDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldManufactureDate.Width = 120;
            // 
            // pivotGridTotal
            // 
            this.pivotGridTotal.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridTotal.AreaIndex = 0;
            this.pivotGridTotal.Caption = " ";
            pivotGridCustomTotal1.Appearance.BackColor = System.Drawing.SystemColors.Info;
            pivotGridCustomTotal1.Appearance.Options.UseBackColor = true;
            pivotGridCustomTotal2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            pivotGridCustomTotal3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            pivotGridCustomTotal4.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.pivotGridTotal.CustomTotals.AddRange(new DevExpress.XtraPivotGrid.PivotGridCustomTotal[] {
            pivotGridCustomTotal1,
            pivotGridCustomTotal2,
            pivotGridCustomTotal3,
            pivotGridCustomTotal4});
            this.pivotGridTotal.GrandTotalCellFormat.FormatString = "\"\"";
            this.pivotGridTotal.Name = "pivotGridTotal";
            this.pivotGridTotal.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.CustomTotals;
            this.pivotGridTotal.Width = 1;
            // 
            // FormRpManufactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRpManufactures";
            this.Text = "Báo cáo Tổng hợp Sản xuất Tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRpManufactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDenngay.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private System.Windows.Forms.Label lblDenngay;
        private DevExpress.XtraEditors.DateEdit cboDenngay;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblKho;
        private DevExpress.XtraEditors.LookUpEdit cboKho;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btnExportMSExcel;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreviews;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLineNo;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShift;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductWeight;
        private DevExpress.XtraPivotGrid.PivotGridField fieldManufactureDate;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridTotal;
    }
}