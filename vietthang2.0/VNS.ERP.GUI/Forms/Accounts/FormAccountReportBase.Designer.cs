namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountReportBase
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
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuyetMinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTxtEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowMinus = new DevExpress.XtraGrid.Columns.GridColumn();
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
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.Enabled = false;
            this.btnExportToExcel.Location = new System.Drawing.Point(745, 415);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(92, 24);
            this.btnExportToExcel.TabIndex = 14;
            this.btnExportToExcel.Text = "Xuất ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(733, 84);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(104, 24);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Tính toán -> lưu";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(633, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "In báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(440, 52);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(84, 24);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Xem";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 41);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(406, 66);
            this.ucDatePeriodSelection1.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(4, 110);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemTxtEditAmount});
            this.gridControl1.Size = new System.Drawing.Size(833, 299);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colRowCode,
            this.colThuyetMinh,
            this.colOldAmount,
            this.colAmount,
            this.colPreAmount,
            this.colFormula,
            this.colRemain,
            this.colRowAdd,
            this.colRowMinus});
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
            this.colThuyetMinh.FieldName = "ThuyetMinh";
            this.colThuyetMinh.Name = "colThuyetMinh";
            this.colThuyetMinh.OptionsColumn.ReadOnly = true;
            this.colThuyetMinh.Visible = true;
            this.colThuyetMinh.VisibleIndex = 2;
            // 
            // colOldAmount
            // 
            this.colOldAmount.Caption = "Kỳ này (đã tính)";
            this.colOldAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colOldAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOldAmount.FieldName = "OldAmount";
            this.colOldAmount.Name = "colOldAmount";
            this.colOldAmount.OptionsColumn.ReadOnly = true;
            this.colOldAmount.OptionsColumn.ShowInCustomizationForm = false;
            this.colOldAmount.Visible = true;
            this.colOldAmount.VisibleIndex = 4;
            this.colOldAmount.Width = 118;
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
            // colAmount
            // 
            this.colAmount.Caption = "Kỳ này (cập nhật)";
            this.colAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 171;
            // 
            // colPreAmount
            // 
            this.colPreAmount.Caption = "Kỳ trước";
            this.colPreAmount.ColumnEdit = this.repItemTxtEditAmount;
            this.colPreAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPreAmount.FieldName = "PreAmount";
            this.colPreAmount.Name = "colPreAmount";
            this.colPreAmount.OptionsColumn.ReadOnly = true;
            this.colPreAmount.Visible = true;
            this.colPreAmount.VisibleIndex = 5;
            this.colPreAmount.Width = 208;
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
            // FormAccountReportBase
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormAccountReportBase";
            this.Text = "FormAccountReportBase";
            this.Load += new System.EventHandler(this.FormAccountReportBase_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucDatePeriodSelection1, 0);
            this.Controls.SetChildIndex(this.btnReport, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.btnExportToExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTxtEditAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReport;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colRowCode;
        private DevExpress.XtraGrid.Columns.GridColumn colThuyetMinh;
        private DevExpress.XtraGrid.Columns.GridColumn colOldAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTxtEditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPreAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colRemain;
        private DevExpress.XtraGrid.Columns.GridColumn colRowAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colRowMinus;
    }
}