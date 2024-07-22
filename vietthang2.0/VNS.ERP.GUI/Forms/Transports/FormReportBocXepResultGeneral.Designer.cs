namespace VNS.ERP.GUI.Transports
{
    partial class FormReportBocXepResultGeneral
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
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colStockName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemTypeName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTransactionTypeName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colServiceName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colAmountTronggio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colAmountNgoaigio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colBocxepSubjectName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colToBocxepName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colStockTransactionDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
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
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Appearance.Cell.BackColor = System.Drawing.Color.White;
            this.pivotGridControl1.Appearance.Cell.Options.UseBackColor = true;
            this.pivotGridControl1.AppearancePrint.Cell.BackColor = System.Drawing.Color.White;
            this.pivotGridControl1.AppearancePrint.Cell.Options.UseBackColor = true;
            this.pivotGridControl1.AppearancePrint.Cell.Options.UseTextOptions = true;
            this.pivotGridControl1.AppearancePrint.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pivotGridControl1.AppearancePrint.TotalCell.BackColor = System.Drawing.Color.White;
            this.pivotGridControl1.AppearancePrint.TotalCell.Options.UseBackColor = true;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colStockName,
            this.colItemTypeName,
            this.colItemName,
            this.colTransactionTypeName,
            this.colServiceName,
            this.colQuantity,
            this.colAmountTronggio,
            this.colAmountNgoaigio,
            this.colBocxepSubjectName,
            this.colToBocxepName,
            this.colStockTransactionDate});
            this.pivotGridControl1.Location = new System.Drawing.Point(1, 72);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pivotGridControl1.OptionsPrint.UsePrintAppearance = true;
            this.pivotGridControl1.OptionsView.FilterSeparatorBarPadding = 0;
            this.pivotGridControl1.OptionsView.ShowFilterSeparatorBar = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(924, 293);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // colStockName
            // 
            this.colStockName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colStockName.Appearance.Value.Options.UseBackColor = true;
            this.colStockName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colStockName.AreaIndex = 0;
            this.colStockName.Caption = "Kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            // 
            // colItemTypeName
            // 
            this.colItemTypeName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colItemTypeName.Appearance.Value.Options.UseBackColor = true;
            this.colItemTypeName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colItemTypeName.AreaIndex = 1;
            this.colItemTypeName.Caption = "Loại hàng";
            this.colItemTypeName.FieldName = "ItemTypeName";
            this.colItemTypeName.Name = "colItemTypeName";
            // 
            // colItemName
            // 
            this.colItemName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colItemName.Appearance.Value.Options.UseBackColor = true;
            this.colItemName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colItemName.AreaIndex = 2;
            this.colItemName.Caption = "Mặt hàng";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 150;
            // 
            // colTransactionTypeName
            // 
            this.colTransactionTypeName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colTransactionTypeName.Appearance.Value.Options.UseBackColor = true;
            this.colTransactionTypeName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colTransactionTypeName.AreaIndex = 3;
            this.colTransactionTypeName.Caption = "Loại nhập xuất";
            this.colTransactionTypeName.FieldName = "TransactionTypeName";
            this.colTransactionTypeName.Name = "colTransactionTypeName";
            this.colTransactionTypeName.Width = 150;
            // 
            // colServiceName
            // 
            this.colServiceName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colServiceName.Appearance.Value.Options.UseBackColor = true;
            this.colServiceName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colServiceName.AreaIndex = 4;
            this.colServiceName.Caption = "Công việc";
            this.colServiceName.FieldName = "ServiceName";
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.colQuantity.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colQuantity.Appearance.Value.Options.UseBackColor = true;
            this.colQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colQuantity.AreaIndex = 0;
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.CellFormat.FormatString = "n0";
            this.colQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colAmountTronggio
            // 
            this.colAmountTronggio.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.colAmountTronggio.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colAmountTronggio.Appearance.Value.Options.UseBackColor = true;
            this.colAmountTronggio.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colAmountTronggio.AreaIndex = 1;
            this.colAmountTronggio.Caption = "Tiền trong giờ";
            this.colAmountTronggio.CellFormat.FormatString = "n0";
            this.colAmountTronggio.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmountTronggio.FieldName = "AmountTronggio";
            this.colAmountTronggio.Name = "colAmountTronggio";
            // 
            // colAmountNgoaigio
            // 
            this.colAmountNgoaigio.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.colAmountNgoaigio.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colAmountNgoaigio.Appearance.Value.Options.UseBackColor = true;
            this.colAmountNgoaigio.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colAmountNgoaigio.AreaIndex = 2;
            this.colAmountNgoaigio.Caption = "Tiền ngoài giờ";
            this.colAmountNgoaigio.CellFormat.FormatString = "n0";
            this.colAmountNgoaigio.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmountNgoaigio.FieldName = "AmountNgoaigio";
            this.colAmountNgoaigio.Name = "colAmountNgoaigio";
            // 
            // colBocxepSubjectName
            // 
            this.colBocxepSubjectName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colBocxepSubjectName.Appearance.Value.Options.UseBackColor = true;
            this.colBocxepSubjectName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colBocxepSubjectName.AreaIndex = 0;
            this.colBocxepSubjectName.Caption = "Đơn vị bốc xếp";
            this.colBocxepSubjectName.FieldName = "BocxepSubjectName";
            this.colBocxepSubjectName.Name = "colBocxepSubjectName";
            // 
            // colToBocxepName
            // 
            this.colToBocxepName.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colToBocxepName.Appearance.Value.Options.UseBackColor = true;
            this.colToBocxepName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colToBocxepName.AreaIndex = 1;
            this.colToBocxepName.Caption = "Tổ bốc xếp";
            this.colToBocxepName.FieldName = "ToBocxepName";
            this.colToBocxepName.Name = "colToBocxepName";
            // 
            // colStockTransactionDate
            // 
            this.colStockTransactionDate.Appearance.Value.BackColor = System.Drawing.Color.White;
            this.colStockTransactionDate.Appearance.Value.Options.UseBackColor = true;
            this.colStockTransactionDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colStockTransactionDate.AreaIndex = 2;
            this.colStockTransactionDate.Caption = "Ngày";
            this.colStockTransactionDate.CellFormat.FormatString = "dd/mm/yyyy";
            this.colStockTransactionDate.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStockTransactionDate.FieldName = "StockTransactionDate";
            this.colStockTransactionDate.Name = "colStockTransactionDate";
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 4);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(410, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Location = new System.Drawing.Point(794, 370);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(102, 25);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Xem báo cáo";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEdit1.Location = new System.Drawing.Point(691, 373);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Xuất ra excel";
            this.checkEdit1.Size = new System.Drawing.Size(91, 19);
            this.checkEdit1.TabIndex = 10;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.pivotGridControl1;
            this.printableComponentLink1.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.printableComponentLink1.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(null, new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "Page [Page # of Pages #]",
                ""}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            // 
            // FormReportBocXepResultGeneral
            // 
            this.ClientSize = new System.Drawing.Size(924, 401);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "FormReportBocXepResultGeneral";
            this.Text = "Bốc xếp tổng quát";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExportToExcel;
        private DevExpress.XtraPivotGrid.PivotGridField colStockName;
        private DevExpress.XtraPivotGrid.PivotGridField colItemTypeName;
        private DevExpress.XtraPivotGrid.PivotGridField colItemName;
        private DevExpress.XtraPivotGrid.PivotGridField colTransactionTypeName;
        private DevExpress.XtraPivotGrid.PivotGridField colServiceName;
        private DevExpress.XtraPivotGrid.PivotGridField colQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField colAmountTronggio;
        private DevExpress.XtraPivotGrid.PivotGridField colAmountNgoaigio;
        private DevExpress.XtraPivotGrid.PivotGridField colBocxepSubjectName;
        private DevExpress.XtraPivotGrid.PivotGridField colToBocxepName;
        private DevExpress.XtraPivotGrid.PivotGridField colStockTransactionDate;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
    }
}
