namespace VNS.ERP.GUI.Stocks
{
    partial class FormReportInOutProduct
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonDKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapKK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhapKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatKK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatKhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeltaStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.checkEditReportExcel = new DevExpress.XtraEditors.CheckEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.chkIncludeTemp = new DevExpress.XtraEditors.CheckEdit();
            this.radStock = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReportExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeTemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStock.Properties)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(5, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(894, 369);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockCode,
            this.colItemCode,
            this.colItemName,
            this.colTonDKy,
            this.colNhapSX,
            this.colNhapXL,
            this.colNhapNB,
            this.colNhapKK,
            this.colNhapKhac,
            this.colXuatBan,
            this.colXuatXL,
            this.colXuatNB,
            this.colXuatKK,
            this.colXuatKhac,
            this.colDeltaStock,
            this.colCloseQuantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Kho";
            this.colStockCode.FieldName = "StockName";
            this.colStockCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 82;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã TP";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên thành phẩm";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 131;
            // 
            // colTonDKy
            // 
            this.colTonDKy.Caption = "Tồn đầu kỳ";
            this.colTonDKy.DisplayFormat.FormatString = "n2";
            this.colTonDKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTonDKy.FieldName = "OpenQuantity";
            this.colTonDKy.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTonDKy.Name = "colTonDKy";
            this.colTonDKy.SummaryItem.DisplayFormat = "{0:n0}";
            this.colTonDKy.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTonDKy.Visible = true;
            this.colTonDKy.VisibleIndex = 3;
            this.colTonDKy.Width = 111;
            // 
            // colNhapSX
            // 
            this.colNhapSX.Caption = "Nhập SX";
            this.colNhapSX.DisplayFormat.FormatString = "n2";
            this.colNhapSX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapSX.FieldName = "NhapSX";
            this.colNhapSX.Name = "colNhapSX";
            this.colNhapSX.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapSX.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapSX.Visible = true;
            this.colNhapSX.VisibleIndex = 4;
            this.colNhapSX.Width = 90;
            // 
            // colNhapXL
            // 
            this.colNhapXL.Caption = "Nhập xử lý";
            this.colNhapXL.DisplayFormat.FormatString = "n2";
            this.colNhapXL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapXL.FieldName = "NhapXL";
            this.colNhapXL.Name = "colNhapXL";
            this.colNhapXL.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapXL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapXL.Visible = true;
            this.colNhapXL.VisibleIndex = 5;
            this.colNhapXL.Width = 111;
            // 
            // colNhapNB
            // 
            this.colNhapNB.Caption = "Nhập nội bộ";
            this.colNhapNB.DisplayFormat.FormatString = "n2";
            this.colNhapNB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapNB.FieldName = "NhapNB";
            this.colNhapNB.Name = "colNhapNB";
            this.colNhapNB.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapNB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapNB.Visible = true;
            this.colNhapNB.VisibleIndex = 6;
            this.colNhapNB.Width = 105;
            // 
            // colNhapKK
            // 
            this.colNhapKK.Caption = "Nhập kiểm kê";
            this.colNhapKK.DisplayFormat.FormatString = "n2";
            this.colNhapKK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapKK.FieldName = "NhapKK";
            this.colNhapKK.Name = "colNhapKK";
            this.colNhapKK.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapKK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapKK.Visible = true;
            this.colNhapKK.VisibleIndex = 7;
            this.colNhapKK.Width = 107;
            // 
            // colNhapKhac
            // 
            this.colNhapKhac.Caption = "Nhập khác";
            this.colNhapKhac.DisplayFormat.FormatString = "n2";
            this.colNhapKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNhapKhac.FieldName = "NhapKhac";
            this.colNhapKhac.Name = "colNhapKhac";
            this.colNhapKhac.SummaryItem.DisplayFormat = "{0:n0}";
            this.colNhapKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNhapKhac.Visible = true;
            this.colNhapKhac.VisibleIndex = 8;
            this.colNhapKhac.Width = 107;
            // 
            // colXuatBan
            // 
            this.colXuatBan.Caption = "Xuất bán";
            this.colXuatBan.DisplayFormat.FormatString = "n2";
            this.colXuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatBan.FieldName = "XuatBan";
            this.colXuatBan.Name = "colXuatBan";
            this.colXuatBan.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatBan.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatBan.Visible = true;
            this.colXuatBan.VisibleIndex = 9;
            this.colXuatBan.Width = 110;
            // 
            // colXuatXL
            // 
            this.colXuatXL.Caption = "Xuất XL";
            this.colXuatXL.DisplayFormat.FormatString = "n2";
            this.colXuatXL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatXL.FieldName = "XuatXL";
            this.colXuatXL.Name = "colXuatXL";
            this.colXuatXL.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatXL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatXL.Visible = true;
            this.colXuatXL.VisibleIndex = 10;
            this.colXuatXL.Width = 103;
            // 
            // colXuatNB
            // 
            this.colXuatNB.Caption = "Xuất nội bộ";
            this.colXuatNB.DisplayFormat.FormatString = "n2";
            this.colXuatNB.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatNB.FieldName = "XuatNB";
            this.colXuatNB.Name = "colXuatNB";
            this.colXuatNB.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatNB.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatNB.Visible = true;
            this.colXuatNB.VisibleIndex = 11;
            this.colXuatNB.Width = 90;
            // 
            // colXuatKK
            // 
            this.colXuatKK.Caption = "Xuất KK";
            this.colXuatKK.DisplayFormat.FormatString = "n2";
            this.colXuatKK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatKK.FieldName = "XuatKK";
            this.colXuatKK.Name = "colXuatKK";
            this.colXuatKK.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatKK.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatKK.Visible = true;
            this.colXuatKK.VisibleIndex = 12;
            this.colXuatKK.Width = 105;
            // 
            // colXuatKhac
            // 
            this.colXuatKhac.Caption = "Xuất khác";
            this.colXuatKhac.DisplayFormat.FormatString = "n2";
            this.colXuatKhac.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colXuatKhac.FieldName = "XuatKhac";
            this.colXuatKhac.Name = "colXuatKhac";
            this.colXuatKhac.SummaryItem.DisplayFormat = "{0:n0}";
            this.colXuatKhac.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colXuatKhac.Visible = true;
            this.colXuatKhac.VisibleIndex = 13;
            this.colXuatKhac.Width = 109;
            // 
            // colDeltaStock
            // 
            this.colDeltaStock.Caption = "Chênh lệch kho";
            this.colDeltaStock.DisplayFormat.FormatString = "n2";
            this.colDeltaStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeltaStock.FieldName = "DeltaStock";
            this.colDeltaStock.Name = "colDeltaStock";
            this.colDeltaStock.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDeltaStock.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDeltaStock.Visible = true;
            this.colDeltaStock.VisibleIndex = 14;
            this.colDeltaStock.Width = 115;
            // 
            // colCloseQuantity
            // 
            this.colCloseQuantity.Caption = "Tồn cuối kỳ";
            this.colCloseQuantity.DisplayFormat.FormatString = "n2";
            this.colCloseQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseQuantity.FieldName = "CloseQuantity";
            this.colCloseQuantity.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colCloseQuantity.Name = "colCloseQuantity";
            this.colCloseQuantity.SummaryItem.DisplayFormat = "{0:n0}";
            this.colCloseQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseQuantity.Visible = true;
            this.colCloseQuantity.VisibleIndex = 15;
            this.colCloseQuantity.Width = 127;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(781, 445);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 26);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Options.UseFont = true;
            this.btnBaoCao.Location = new System.Drawing.Point(763, 17);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(127, 34);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Refresh";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // lookUpStock
            // 
            this.lookUpStock.EnterMoveNextControl = true;
            this.lookUpStock.Location = new System.Drawing.Point(498, 42);
            this.lookUpStock.Name = "lookUpStock";
            this.lookUpStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 70),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 130)});
            this.lookUpStock.Properties.DisplayMember = "StockName";
            this.lookUpStock.Properties.NullText = "";
            this.lookUpStock.Properties.PopupSizeable = false;
            this.lookUpStock.Properties.PopupWidth = 200;
            this.lookUpStock.Properties.ValueMember = "StockCode";
            this.lookUpStock.Size = new System.Drawing.Size(159, 22);
            this.lookUpStock.TabIndex = 5;
            this.lookUpStock.EditValueChanged += new System.EventHandler(this.lookUpStock_EditValueChanged);
            // 
            // checkEditReportExcel
            // 
            this.checkEditReportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEditReportExcel.Location = new System.Drawing.Point(647, 451);
            this.checkEditReportExcel.Name = "checkEditReportExcel";
            this.checkEditReportExcel.Properties.Caption = "Kết xuất ra excel";
            this.checkEditReportExcel.Size = new System.Drawing.Size(119, 19);
            this.checkEditReportExcel.TabIndex = 8;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(5, 2);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 10;
            // 
            // chkIncludeTemp
            // 
            this.chkIncludeTemp.Location = new System.Drawing.Point(498, 17);
            this.chkIncludeTemp.Name = "chkIncludeTemp";
            this.chkIncludeTemp.Properties.Caption = "Tính cả các kho chờ pt, khách hàng, đi đường...";
            this.chkIncludeTemp.Size = new System.Drawing.Size(259, 19);
            this.chkIncludeTemp.TabIndex = 27;
            this.chkIncludeTemp.EditValueChanged += new System.EventHandler(this.chkIncludeTemp_EditValueChanged);
            // 
            // radStock
            // 
            this.radStock.Location = new System.Drawing.Point(412, 13);
            this.radStock.Name = "radStock";
            this.radStock.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Việt Thắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chọn kho")});
            this.radStock.Size = new System.Drawing.Size(80, 51);
            this.radStock.TabIndex = 26;
            // 
            // FormReportInOutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 477);
            this.Controls.Add(this.chkIncludeTemp);
            this.Controls.Add(this.radStock);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.checkEditReportExcel);
            this.Controls.Add(this.lookUpStock);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormReportInOutProduct";
            this.Text = "FormReportInOutProduct";
            this.Load += new System.EventHandler(this.FormReportInOutProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditReportExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeTemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStock.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colTonDKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapSX;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapXL;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapNB;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapKK;
        private DevExpress.XtraGrid.Columns.GridColumn colNhapKhac;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXL;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatNB;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatKK;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatKhac;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn colDeltaStock;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseQuantity;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private DevExpress.XtraEditors.CheckEdit checkEditReportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.CheckEdit chkIncludeTemp;
        private DevExpress.XtraEditors.RadioGroup radStock;
    }
}