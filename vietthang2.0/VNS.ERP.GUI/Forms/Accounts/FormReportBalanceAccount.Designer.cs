namespace VNS.ERP.GUI.Accounting
{
    partial class FormReportBalanceAccount
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
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuyetMinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTxtEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colOldClosingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpeningAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldOpeningAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowMinus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentRowCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnCopy1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTxtEditAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(4, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemTxtEditAmount});
            this.gridControl1.Size = new System.Drawing.Size(858, 311);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colRowCode,
            this.colThuyetMinh,
            this.colClosingAmount,
            this.colOldClosingAmount,
            this.colOpeningAmount,
            this.colOldOpeningAmount,
            this.colFormula,
            this.colRemain,
            this.colRowAdd,
            this.colRowMinus,
            this.colParentRowCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Chỉ tiêu";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 426;
            // 
            // colRowCode
            // 
            this.colRowCode.Caption = "Mã số";
            this.colRowCode.FieldName = "RowCode";
            this.colRowCode.Name = "colRowCode";
            this.colRowCode.OptionsColumn.ReadOnly = true;
            this.colRowCode.Visible = true;
            this.colRowCode.VisibleIndex = 1;
            this.colRowCode.Width = 48;
            // 
            // colThuyetMinh
            // 
            this.colThuyetMinh.Caption = "Thuyết minh";
            this.colThuyetMinh.FieldName = "Thuyetminh";
            this.colThuyetMinh.Name = "colThuyetMinh";
            this.colThuyetMinh.OptionsColumn.ReadOnly = true;
            this.colThuyetMinh.Visible = true;
            this.colThuyetMinh.VisibleIndex = 2;
            this.colThuyetMinh.Width = 74;
            // 
            // colClosingAmount
            // 
            this.colClosingAmount.Caption = "Số cuối năm (tính toán)";
            this.colClosingAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colClosingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colClosingAmount.FieldName = "ClosingAmount";
            this.colClosingAmount.Name = "colClosingAmount";
            this.colClosingAmount.OptionsColumn.ReadOnly = true;
            this.colClosingAmount.OptionsColumn.ShowInCustomizationForm = false;
            this.colClosingAmount.Visible = true;
            this.colClosingAmount.VisibleIndex = 3;
            this.colClosingAmount.Width = 161;
            // 
            // repItemTxtEditAmount
            // 
            this.repItemTxtEditAmount.AutoHeight = false;
            this.repItemTxtEditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTxtEditAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTxtEditAmount.Mask.EditMask = "n0";
            this.repItemTxtEditAmount.Mask.IgnoreMaskBlank = false;
            this.repItemTxtEditAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repItemTxtEditAmount.Mask.UseMaskAsDisplayFormat = true;
            this.repItemTxtEditAmount.Name = "repItemTxtEditAmount";
            // 
            // colOldClosingAmount
            // 
            this.colOldClosingAmount.Caption = "Số cuối năm (lưu)";
            this.colOldClosingAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colOldClosingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldClosingAmount.FieldName = "OldClosingAmount";
            this.colOldClosingAmount.Name = "colOldClosingAmount";
            this.colOldClosingAmount.OptionsColumn.ReadOnly = true;
            this.colOldClosingAmount.Visible = true;
            this.colOldClosingAmount.VisibleIndex = 4;
            this.colOldClosingAmount.Width = 141;
            // 
            // colOpeningAmount
            // 
            this.colOpeningAmount.Caption = "Số đầu năm (tính toán)";
            this.colOpeningAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colOpeningAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpeningAmount.FieldName = "OpeningAmount";
            this.colOpeningAmount.Name = "colOpeningAmount";
            this.colOpeningAmount.OptionsColumn.ReadOnly = true;
            this.colOpeningAmount.OptionsColumn.ShowInCustomizationForm = false;
            this.colOpeningAmount.Visible = true;
            this.colOpeningAmount.VisibleIndex = 5;
            this.colOpeningAmount.Width = 151;
            // 
            // colOldOpeningAmount
            // 
            this.colOldOpeningAmount.Caption = "Số đầu năm (lưu)";
            this.colOldOpeningAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colOldOpeningAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldOpeningAmount.FieldName = "OldOpeningAmount";
            this.colOldOpeningAmount.Name = "colOldOpeningAmount";
            this.colOldOpeningAmount.OptionsColumn.ReadOnly = true;
            this.colOldOpeningAmount.Visible = true;
            this.colOldOpeningAmount.VisibleIndex = 6;
            this.colOldOpeningAmount.Width = 129;
            // 
            // colFormula
            // 
            this.colFormula.Caption = "Công thức";
            this.colFormula.FieldName = "Formula";
            this.colFormula.Name = "colFormula";
            this.colFormula.OptionsColumn.AllowEdit = false;
            // 
            // colRemain
            // 
            this.colRemain.Caption = "Giá trị lấy";
            this.colRemain.FieldName = "Remain";
            this.colRemain.Name = "colRemain";
            this.colRemain.OptionsColumn.AllowEdit = false;
            // 
            // colRowAdd
            // 
            this.colRowAdd.Caption = "Dòng cộng";
            this.colRowAdd.FieldName = "RowAdd";
            this.colRowAdd.Name = "colRowAdd";
            this.colRowAdd.OptionsColumn.AllowEdit = false;
            // 
            // colRowMinus
            // 
            this.colRowMinus.Caption = "Dòng trừ";
            this.colRowMinus.FieldName = "RowMinus";
            this.colRowMinus.Name = "colRowMinus";
            this.colRowMinus.OptionsColumn.AllowEdit = false;
            // 
            // colParentRowCode
            // 
            this.colParentRowCode.Caption = "Dòng tổng cộng";
            this.colParentRowCode.FieldName = "ParentRowCode";
            this.colParentRowCode.Name = "colParentRowCode";
            this.colParentRowCode.OptionsColumn.AllowEdit = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(663, 63);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(197, 24);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "Tính toán -> lưu (số đầu tháng)";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(440, 52);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 22);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Xem";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 50);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(417, 66);
            this.ucDatePeriodSelection1.TabIndex = 14;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Location = new System.Drawing.Point(770, 432);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(92, 24);
            this.btnExportToExcel.TabIndex = 17;
            this.btnExportToExcel.Text = "Xuất ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnCopy1
            // 
            this.btnCopy1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy1.Location = new System.Drawing.Point(663, 89);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(197, 24);
            this.btnCopy1.TabIndex = 18;
            this.btnCopy1.Text = "Tính toán -> lưu (số cuối tháng)";
            this.btnCopy1.UseVisualStyleBackColor = true;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            // 
            // FormReportBalanceAccount
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 485);
            this.Controls.Add(this.btnCopy1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormReportBalanceAccount";
            this.Text = "Bảng cân đối kế toán";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucDatePeriodSelection1, 0);
            this.Controls.SetChildIndex(this.btnReport, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.Controls.SetChildIndex(this.btnCopy1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTxtEditAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRowCode;
        private DevExpress.XtraGrid.Columns.GridColumn colThuyetMinh;
        private DevExpress.XtraGrid.Columns.GridColumn colOldOpeningAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTxtEditAmount;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnReport;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.Button btnExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colClosingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOldClosingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOpeningAmount;
        private System.Windows.Forms.Button btnCopy1;
        private DevExpress.XtraGrid.Columns.GridColumn colFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colRemain;
        private DevExpress.XtraGrid.Columns.GridColumn colRowAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colRowMinus;
        private DevExpress.XtraGrid.Columns.GridColumn colParentRowCode;
    }
}