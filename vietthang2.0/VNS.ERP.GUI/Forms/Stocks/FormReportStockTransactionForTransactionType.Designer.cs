namespace VNS.ERP.GUI.Stocks
{
    partial class FormReportStockTransactionForTransactionType
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
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.lookupTransactionTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbLoaiNX = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridFieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldItemCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldDateOrMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridFieldMasapxep = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.AllowCheckDate = false;
            this.ucDatePeriodSelection1.AllowCheckQuarter = false;
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(14, 4);
            this.ucDatePeriodSelection1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(353, 51);
            this.ucDatePeriodSelection1.TabIndex = 0;
            this.ucDatePeriodSelection1.OnEditValueChanged += new VNS.Windows.UserControls.UCDatePeriodSelection.EditPeriodChanged(this.ucDatePeriodSelection1_OnEditValueChanged);
            // 
            // lookupTransactionTypeCode
            // 
            this.lookupTransactionTypeCode.Location = new System.Drawing.Point(587, 18);
            this.lookupTransactionTypeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lookupTransactionTypeCode.Name = "lookupTransactionTypeCode";
            this.lookupTransactionTypeCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookupTransactionTypeCode.Properties.Appearance.Options.UseFont = true;
            this.lookupTransactionTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupTransactionTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeCode", 50, "Mã X/N"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", 150, "Diễn giải")});
            this.lookupTransactionTypeCode.Properties.DisplayMember = "Description";
            this.lookupTransactionTypeCode.Properties.NullText = "";
            this.lookupTransactionTypeCode.Properties.PopupWidth = 200;
            this.lookupTransactionTypeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupTransactionTypeCode.Properties.ValueMember = "TransactionTypeCode";
            this.lookupTransactionTypeCode.Size = new System.Drawing.Size(278, 26);
            this.lookupTransactionTypeCode.TabIndex = 4;
            this.lookupTransactionTypeCode.EditValueChanged += new System.EventHandler(this.lookupTransactionTypeCode_EditValueChanged);
            // 
            // lbLoaiNX
            // 
            this.lbLoaiNX.Location = new System.Drawing.Point(530, 20);
            this.lbLoaiNX.Name = "lbLoaiNX";
            this.lbLoaiNX.Size = new System.Drawing.Size(56, 21);
            this.lbLoaiNX.TabIndex = 5;
            this.lbLoaiNX.Text = "Loại N/X";
            this.lbLoaiNX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(868, 18);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(92, 27);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Xem";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridFieldQuantity,
            this.pivotGridFieldItemCode,
            this.pivotGridFieldItemName,
            this.pivotGridFieldDateOrMonth,
            this.pivotGridFieldMasapxep});
            this.pivotGridControl1.Location = new System.Drawing.Point(3, 111);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowExpand = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowGrandTotalsForSingleValues = true;
            this.pivotGridControl1.Size = new System.Drawing.Size(957, 394);
            this.pivotGridControl1.TabIndex = 7;
            // 
            // pivotGridFieldQuantity
            // 
            this.pivotGridFieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridFieldQuantity.AreaIndex = 0;
            this.pivotGridFieldQuantity.Caption = "Số lượng";
            this.pivotGridFieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridFieldQuantity.FieldName = "Quantity";
            this.pivotGridFieldQuantity.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridFieldQuantity.Name = "pivotGridFieldQuantity";
            this.pivotGridFieldQuantity.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridFieldQuantity.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridFieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // pivotGridFieldItemCode
            // 
            this.pivotGridFieldItemCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldItemCode.AreaIndex = 1;
            this.pivotGridFieldItemCode.Caption = "Mã";
            this.pivotGridFieldItemCode.FieldName = "ItemCode";
            this.pivotGridFieldItemCode.Name = "pivotGridFieldItemCode";
            // 
            // pivotGridFieldItemName
            // 
            this.pivotGridFieldItemName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldItemName.AreaIndex = 2;
            this.pivotGridFieldItemName.Caption = "Tên";
            this.pivotGridFieldItemName.FieldName = "ItemName";
            this.pivotGridFieldItemName.Name = "pivotGridFieldItemName";
            this.pivotGridFieldItemName.Width = 200;
            // 
            // pivotGridFieldDateOrMonth
            // 
            this.pivotGridFieldDateOrMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridFieldDateOrMonth.AreaIndex = 0;
            this.pivotGridFieldDateOrMonth.Caption = "Ngày/tháng";
            this.pivotGridFieldDateOrMonth.FieldName = "DateOrMonth";
            this.pivotGridFieldDateOrMonth.Name = "pivotGridFieldDateOrMonth";
            // 
            // pivotGridFieldMasapxep
            // 
            this.pivotGridFieldMasapxep.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridFieldMasapxep.AreaIndex = 0;
            this.pivotGridFieldMasapxep.FieldName = "Masapxep";
            this.pivotGridFieldMasapxep.MinWidth = 1;
            this.pivotGridFieldMasapxep.Name = "pivotGridFieldMasapxep";
            this.pivotGridFieldMasapxep.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
            this.pivotGridFieldMasapxep.Width = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Location = new System.Drawing.Point(831, 510);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(131, 27);
            this.btnExportToExcel.TabIndex = 8;
            this.btnExportToExcel.Text = "Xuất ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Location = new System.Drawing.Point(394, 18);
            this.lookUpStockCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", 70, "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 130, "Tên")});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(128, 26);
            this.lookUpStockCode.TabIndex = 10;
            this.lookUpStockCode.EditValueChanged += new System.EventHandler(this.lookUpStockCode_EditValueChanged);
            // 
            // lbStockCode
            // 
            this.lbStockCode.Location = new System.Drawing.Point(349, 21);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(38, 22);
            this.lbStockCode.TabIndex = 9;
            this.lbStockCode.Text = "Kho";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Từ tháng";
            // 
            // txtMonth
            // 
            this.txtMonth.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMonth.Location = new System.Drawing.Point(86, 63);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtMonth.Properties.Mask.EditMask = "f0";
            this.txtMonth.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtMonth.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMonth.Size = new System.Drawing.Size(45, 22);
            this.txtMonth.TabIndex = 11;
            // 
            // FormReportStockTransactionForTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lbLoaiNX);
            this.Controls.Add(this.lookupTransactionTypeCode);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReportStockTransactionForTransactionType";
            this.Text = "Báo cáo chi tiết loại hình nhập xuất";
            this.Load += new System.EventHandler(this.FormReportStockTransactionForTransactionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonth.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.LookUpEdit lookupTransactionTypeCode;
        private System.Windows.Forms.Label lbLoaiNX;
        private System.Windows.Forms.Button btnReport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.Button btnExportToExcel;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldItemCode;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldItemName;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldDateOrMonth;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridFieldMasapxep;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit txtMonth;
    }
}