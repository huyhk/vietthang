namespace VNS.ERP.GUI.KCS
{
    partial class FormReportResultOutside
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
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxFormReportTestExpense = new System.Windows.Forms.GroupBox();
            this.rbReturnDate = new System.Windows.Forms.RadioButton();
            this.rbSendDate = new System.Windows.Forms.RadioButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemEncryptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repTxtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repTxtPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxFormReportTestExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxFormReportTestExpense, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(413, 59);
            this.ucDatePeriodSelection1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(950, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.Location = new System.Drawing.Point(950, 390);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 21);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "ExportExcel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBoxFormReportTestExpense
            // 
            this.groupBoxFormReportTestExpense.Controls.Add(this.rbReturnDate);
            this.groupBoxFormReportTestExpense.Controls.Add(this.rbSendDate);
            this.groupBoxFormReportTestExpense.Location = new System.Drawing.Point(422, 3);
            this.groupBoxFormReportTestExpense.Name = "groupBoxFormReportTestExpense";
            this.groupBoxFormReportTestExpense.Size = new System.Drawing.Size(141, 59);
            this.groupBoxFormReportTestExpense.TabIndex = 4;
            this.groupBoxFormReportTestExpense.TabStop = false;
            // 
            // rbReturnDate
            // 
            this.rbReturnDate.AutoSize = true;
            this.rbReturnDate.Location = new System.Drawing.Point(9, 37);
            this.rbReturnDate.Name = "rbReturnDate";
            this.rbReturnDate.Size = new System.Drawing.Size(124, 17);
            this.rbReturnDate.TabIndex = 1;
            this.rbReturnDate.Text = "Tính theo ngày nhận";
            this.rbReturnDate.UseVisualStyleBackColor = true;
            // 
            // rbSendDate
            // 
            this.rbSendDate.AutoSize = true;
            this.rbSendDate.Checked = true;
            this.rbSendDate.Location = new System.Drawing.Point(9, 14);
            this.rbSendDate.Name = "rbSendDate";
            this.rbSendDate.Size = new System.Drawing.Size(115, 17);
            this.rbSendDate.TabIndex = 0;
            this.rbSendDate.TabStop = true;
            this.rbSendDate.Text = "Tính theo ngày gửi";
            this.rbSendDate.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCheckEdit1,
            this.repTxtDecimal,
            this.repTxtPercent});
            this.gridControl1.Size = new System.Drawing.Size(1022, 312);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubjectCode,
            this.colSendDate,
            this.colItemEncryptCode,
            this.colItemName,
            this.colNgayNhap,
            this.colFormula,
            this.colLot,
            this.colShift,
            this.colKho,
            this.colKhachhang,
            this.colIsProduct});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "Nơi gửi";
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 0;
            this.colSubjectCode.Width = 85;
            // 
            // colSendDate
            // 
            this.colSendDate.Caption = "Ngày gửi";
            this.colSendDate.DisplayFormat.FormatString = "d";
            this.colSendDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSendDate.FieldName = "SendDate";
            this.colSendDate.Name = "colSendDate";
            this.colSendDate.Visible = true;
            this.colSendDate.VisibleIndex = 1;
            this.colSendDate.Width = 85;
            // 
            // colItemEncryptCode
            // 
            this.colItemEncryptCode.Caption = "Mã mẫu";
            this.colItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode.Name = "colItemEncryptCode";
            this.colItemEncryptCode.Visible = true;
            this.colItemEncryptCode.VisibleIndex = 2;
            this.colItemEncryptCode.Width = 120;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên nguyên liệu";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            this.colItemName.Width = 103;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.Caption = "Ngày nhập_SX";
            this.colNgayNhap.DisplayFormat.FormatString = "d";
            this.colNgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayNhap.FieldName = "Ngaynhap";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 4;
            this.colNgayNhap.Width = 88;
            // 
            // colLot
            // 
            this.colLot.Caption = "Lot";
            this.colLot.FieldName = "Lot";
            this.colLot.Name = "colLot";
            this.colLot.Visible = true;
            this.colLot.VisibleIndex = 6;
            this.colLot.Width = 51;
            // 
            // colShift
            // 
            this.colShift.Caption = "Ca";
            this.colShift.FieldName = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.Visible = true;
            this.colShift.VisibleIndex = 7;
            this.colShift.Width = 47;
            // 
            // colKho
            // 
            this.colKho.Caption = "Kho";
            this.colKho.FieldName = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.Visible = true;
            this.colKho.VisibleIndex = 8;
            this.colKho.Width = 64;
            // 
            // colKhachhang
            // 
            this.colKhachhang.Caption = "Khách hàng";
            this.colKhachhang.FieldName = "Khachhang";
            this.colKhachhang.Name = "colKhachhang";
            this.colKhachhang.Visible = true;
            this.colKhachhang.VisibleIndex = 9;
            this.colKhachhang.Width = 71;
            // 
            // colIsProduct
            // 
            this.colIsProduct.Caption = "Thành phẩm";
            this.colIsProduct.ColumnEdit = this.repCheckEdit1;
            this.colIsProduct.FieldName = "IsProduct";
            this.colIsProduct.Name = "colIsProduct";
            this.colIsProduct.Visible = true;
            this.colIsProduct.VisibleIndex = 10;
            // 
            // repCheckEdit1
            // 
            this.repCheckEdit1.AutoHeight = false;
            this.repCheckEdit1.Name = "repCheckEdit1";
            // 
            // repTxtDecimal
            // 
            this.repTxtDecimal.AutoHeight = false;
            this.repTxtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtDecimal.Name = "repTxtDecimal";
            // 
            // repTxtPercent
            // 
            this.repTxtPercent.AutoHeight = false;
            this.repTxtPercent.Name = "repTxtPercent";
            // 
            // colFormula
            // 
            this.colFormula.Caption = "Code CT";
            this.colFormula.FieldName = "FormulaCode";
            this.colFormula.Name = "colFormula";
            this.colFormula.Visible = true;
            this.colFormula.VisibleIndex = 5;
            this.colFormula.Width = 117;
            // 
            // FormReportResultOutside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 418);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReportResultOutside";
            this.Text = "FormReportResultOutside";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportResultOutside_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxFormReportTestExpense.ResumeLayout(false);
            this.groupBoxFormReportTestExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSendDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colLot;
        private DevExpress.XtraGrid.Columns.GridColumn colShift;
        private DevExpress.XtraGrid.Columns.GridColumn colKho;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachhang;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNoKQ;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPercent;
        //private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDecimal;
        private DevExpress.XtraGrid.Columns.GridColumn colIsProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtPercent;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBoxFormReportTestExpense;
        private System.Windows.Forms.RadioButton rbReturnDate;
        private System.Windows.Forms.RadioButton rbSendDate;
        private DevExpress.XtraGrid.Columns.GridColumn colItemEncryptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFormula;
    }
}