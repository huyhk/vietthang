namespace VNS.ERP.GUI.KCS
{
    partial class UCProductTestRequest
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
            this.dateEditRequest = new DevExpress.XtraEditors.DateEdit();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStockName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colManuDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colShift = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colProduct = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSizeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFormulaCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLot = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colItemEnryptCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandRequest = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.chkIsReceived = new DevExpress.XtraEditors.CheckEdit();
            this.btnReceived = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceived.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateEditRequest
            // 
            this.dateEditRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEditRequest.EditValue = new System.DateTime(2008, 3, 31, 0, 0, 0, 0);
            this.dateEditRequest.EnterMoveNextControl = true;
            this.dateEditRequest.Location = new System.Drawing.Point(63, 3);
            this.dateEditRequest.Name = "dateEditRequest";
            this.dateEditRequest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRequest.Size = new System.Drawing.Size(94, 20);
            this.dateEditRequest.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(3, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(54, 18);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "Ngày";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.Location = new System.Drawing.Point(3, 25);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(54, 62);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(63, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(834, 56);
            this.txtDescription.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 120);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 278);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.bandRequest});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colStockName,
            this.colManuDate,
            this.colShift,
            this.colProduct,
            this.colSizeCode,
            this.colFormulaCode,
            this.colLot,
            this.colItemEnryptCode,
            this.colSubjectName});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colStockName);
            this.gridBand1.Columns.Add(this.colManuDate);
            this.gridBand1.Columns.Add(this.colShift);
            this.gridBand1.Columns.Add(this.colProduct);
            this.gridBand1.Columns.Add(this.colSizeCode);
            this.gridBand1.Columns.Add(this.colFormulaCode);
            this.gridBand1.Columns.Add(this.colLot);
            this.gridBand1.Columns.Add(this.colSubjectName);
            this.gridBand1.Columns.Add(this.colItemEnryptCode);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 717;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colStockName.OptionsColumn.AllowMove = false;
            this.colStockName.OptionsColumn.ReadOnly = true;
            this.colStockName.Visible = true;
            this.colStockName.Width = 71;
            // 
            // colManuDate
            // 
            this.colManuDate.Caption = "Ngày sản xuất";
            this.colManuDate.DisplayFormat.FormatString = "d";
            this.colManuDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colManuDate.FieldName = "ManuDate";
            this.colManuDate.Name = "colManuDate";
            this.colManuDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colManuDate.OptionsColumn.AllowMove = false;
            this.colManuDate.Visible = true;
            this.colManuDate.Width = 60;
            // 
            // colShift
            // 
            this.colShift.Caption = "Ca";
            this.colShift.FieldName = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colShift.OptionsColumn.AllowMove = false;
            this.colShift.Visible = true;
            this.colShift.Width = 42;
            // 
            // colProduct
            // 
            this.colProduct.Caption = "Thành phẩm";
            this.colProduct.FieldName = "ProductCode";
            this.colProduct.Name = "colProduct";
            this.colProduct.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colProduct.OptionsColumn.AllowMove = false;
            this.colProduct.Visible = true;
            this.colProduct.Width = 71;
            // 
            // colSizeCode
            // 
            this.colSizeCode.Caption = "Kích thước";
            this.colSizeCode.FieldName = "SizeCode";
            this.colSizeCode.Name = "colSizeCode";
            this.colSizeCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colSizeCode.OptionsColumn.AllowMove = false;
            this.colSizeCode.Visible = true;
            this.colSizeCode.Width = 56;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "Công thức";
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colFormulaCode.OptionsColumn.AllowMove = false;
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.Width = 90;
            // 
            // colLot
            // 
            this.colLot.Caption = "Lot";
            this.colLot.FieldName = "Lot";
            this.colLot.Name = "colLot";
            this.colLot.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colLot.OptionsColumn.AllowMove = false;
            this.colLot.Visible = true;
            this.colLot.Width = 48;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "ĐVPT";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colSubjectName.OptionsColumn.AllowMove = false;
            this.colSubjectName.Visible = true;
            this.colSubjectName.Width = 183;
            // 
            // colItemEnryptCode
            // 
            this.colItemEnryptCode.Caption = "Mã mẫu";
            this.colItemEnryptCode.FieldName = "ItemEncryptCode";
            this.colItemEnryptCode.Name = "colItemEnryptCode";
            this.colItemEnryptCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colItemEnryptCode.OptionsColumn.AllowMove = false;
            this.colItemEnryptCode.Visible = true;
            this.colItemEnryptCode.Width = 96;
            // 
            // bandRequest
            // 
            this.bandRequest.AppearanceHeader.Options.UseTextOptions = true;
            this.bandRequest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandRequest.Caption = "Chỉ tiêu";
            this.bandRequest.Name = "bandRequest";
            // 
            // chkIsReceived
            // 
            this.chkIsReceived.Location = new System.Drawing.Point(66, 96);
            this.chkIsReceived.Name = "chkIsReceived";
            this.chkIsReceived.Properties.Caption = "Đã nhận";
            this.chkIsReceived.Size = new System.Drawing.Size(75, 19);
            this.chkIsReceived.TabIndex = 3;
            // 
            // btnReceived
            // 
            this.btnReceived.Location = new System.Drawing.Point(134, 96);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(83, 18);
            this.btnReceived.TabIndex = 2;
            this.btnReceived.Text = "Nhận/Bỏ nhận";
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetail.Location = new System.Drawing.Point(875, 96);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(31, 18);
            this.btnEditDetail.TabIndex = 7;
            this.btnEditDetail.Text = "...";
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEditRequest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 87);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // UCProductTestRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.btnReceived);
            this.Controls.Add(this.chkIsReceived);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCProductTestRequest";
            this.Size = new System.Drawing.Size(910, 403);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceived.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEditRequest;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStockName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colManuDate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colShift;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colProduct;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSizeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFormulaCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLot;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemEnryptCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSubjectName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandRequest;
        private DevExpress.XtraEditors.CheckEdit chkIsReceived;
        private DevExpress.XtraEditors.SimpleButton btnReceived;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
