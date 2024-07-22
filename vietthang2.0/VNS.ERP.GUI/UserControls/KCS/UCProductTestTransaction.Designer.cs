namespace VNS.ERP.GUI.KCS
{
    partial class UCProductTestTransaction
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
            this.lbStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbDate = new System.Windows.Forms.Label();
            this.dateEditTransaction = new DevExpress.XtraEditors.DateEdit();
            this.lbShift = new System.Windows.Forms.Label();
            this.txtShift = new DevExpress.XtraEditors.SpinEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.colNewProductCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNewSizeCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNewFormulaCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNewLot = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNewItemEncryptCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repTxtString = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repTxtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repTxtPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguoikiem = new DevExpress.XtraEditors.TextEdit();
            this.colNewNgayCodeBao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandCommon = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandResult = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandRequest = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoikiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStockCode
            // 
            this.lbStockCode.Location = new System.Drawing.Point(3, 5);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(54, 20);
            this.lbStockCode.TabIndex = 5;
            this.lbStockCode.Text = "Nhà máy";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(58, 6);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", 100, "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", 200, "Tên")});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 300;
            this.lookUpStockCode.Properties.ReadOnly = true;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(268, 20);
            this.lookUpStockCode.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Location = new System.Drawing.Point(3, 31);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(54, 20);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Ngày";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditTransaction
            // 
            this.dateEditTransaction.EditValue = new System.DateTime(2008, 3, 19, 0, 0, 0, 0);
            this.dateEditTransaction.EnterMoveNextControl = true;
            this.dateEditTransaction.Location = new System.Drawing.Point(58, 31);
            this.dateEditTransaction.Name = "dateEditTransaction";
            this.dateEditTransaction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTransaction.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditTransaction.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditTransaction.Size = new System.Drawing.Size(268, 20);
            this.dateEditTransaction.TabIndex = 2;
            // 
            // lbShift
            // 
            this.lbShift.Location = new System.Drawing.Point(338, 6);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(54, 20);
            this.lbShift.TabIndex = 7;
            this.lbShift.Text = "Ca";
            this.lbShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShift
            // 
            this.txtShift.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtShift.EnterMoveNextControl = true;
            this.txtShift.Location = new System.Drawing.Point(393, 6);
            this.txtShift.Name = "txtShift";
            this.txtShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtShift.Properties.Mask.EditMask = "n0";
            this.txtShift.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShift.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtShift.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtShift.Size = new System.Drawing.Size(38, 20);
            this.txtShift.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(338, 30);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(54, 20);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(393, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(431, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetail.Location = new System.Drawing.Point(830, 31);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(43, 22);
            this.btnEditDetail.TabIndex = 9;
            this.btnEditDetail.Text = "...";
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(6, 59);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTxtString,
            this.repTxtDecimal,
            this.repTxtPercent});
            this.gridControl1.Size = new System.Drawing.Size(867, 411);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandCommon,
            this.bandResult,
            this.bandRequest});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colNewProductCode,
            this.colNewSizeCode,
            this.colNewFormulaCode,
            this.colNewItemEncryptCode,
            this.colNewLot,
            this.colNewNgayCodeBao});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNewProductCode
            // 
            this.colNewProductCode.Caption = "Thành phẩm";
            this.colNewProductCode.FieldName = "ProductCode";
            this.colNewProductCode.Name = "colNewProductCode";
            this.colNewProductCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNewProductCode.OptionsColumn.AllowMove = false;
            this.colNewProductCode.Visible = true;
            this.colNewProductCode.Width = 94;
            // 
            // colNewSizeCode
            // 
            this.colNewSizeCode.Caption = "Kích thước";
            this.colNewSizeCode.FieldName = "SizeCode";
            this.colNewSizeCode.Name = "colNewSizeCode";
            this.colNewSizeCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNewSizeCode.OptionsColumn.AllowMove = false;
            this.colNewSizeCode.Visible = true;
            this.colNewSizeCode.Width = 94;
            // 
            // colNewFormulaCode
            // 
            this.colNewFormulaCode.Caption = "Công thức";
            this.colNewFormulaCode.FieldName = "FormulaCode";
            this.colNewFormulaCode.Name = "colNewFormulaCode";
            this.colNewFormulaCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colNewFormulaCode.OptionsColumn.AllowMove = false;
            this.colNewFormulaCode.Visible = true;
            this.colNewFormulaCode.Width = 100;
            // 
            // colNewLot
            // 
            this.colNewLot.Caption = "Lót";
            this.colNewLot.FieldName = "Lot";
            this.colNewLot.Name = "colNewLot";
            this.colNewLot.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNewLot.OptionsColumn.AllowMove = false;
            this.colNewLot.Visible = true;
            // 
            // colNewItemEncryptCode
            // 
            this.colNewItemEncryptCode.Caption = "Mã mẫu";
            this.colNewItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colNewItemEncryptCode.Name = "colNewItemEncryptCode";
            this.colNewItemEncryptCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNewItemEncryptCode.OptionsColumn.AllowMove = false;
            this.colNewItemEncryptCode.Visible = true;
            this.colNewItemEncryptCode.Width = 101;
            // 
            // repTxtString
            // 
            this.repTxtString.AutoHeight = false;
            this.repTxtString.Name = "repTxtString";
            // 
            // repTxtDecimal
            // 
            this.repTxtDecimal.AutoHeight = false;
            this.repTxtDecimal.DisplayFormat.FormatString = "#,###.##";
            this.repTxtDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtDecimal.Mask.EditMask = "n2";
            this.repTxtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtDecimal.Name = "repTxtDecimal";
            // 
            // repTxtPercent
            // 
            this.repTxtPercent.AutoHeight = false;
            this.repTxtPercent.Mask.EditMask = "p";
            this.repTxtPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtPercent.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtPercent.Name = "repTxtPercent";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(457, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Người kiểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoikiem
            // 
            this.txtNguoikiem.Location = new System.Drawing.Point(527, 5);
            this.txtNguoikiem.Name = "txtNguoikiem";
            this.txtNguoikiem.Size = new System.Drawing.Size(297, 20);
            this.txtNguoikiem.TabIndex = 11;
            // 
            // colNewNgayCodeBao
            // 
            this.colNewNgayCodeBao.Caption = "Ngày Code bao";
            this.colNewNgayCodeBao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNewNgayCodeBao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNewNgayCodeBao.FieldName = "NgayCodeBao";
            this.colNewNgayCodeBao.Name = "colNewNgayCodeBao";
            this.colNewNgayCodeBao.Visible = true;
            this.colNewNgayCodeBao.Width = 84;
            // 
            // bandCommon
            // 
            this.bandCommon.Columns.Add(this.colNewProductCode);
            this.bandCommon.Columns.Add(this.colNewSizeCode);
            this.bandCommon.Columns.Add(this.colNewFormulaCode);
            this.bandCommon.Columns.Add(this.colNewLot);
            this.bandCommon.Columns.Add(this.colNewItemEncryptCode);
            this.bandCommon.Columns.Add(this.colNewNgayCodeBao);
            this.bandCommon.MinWidth = 20;
            this.bandCommon.Name = "bandCommon";
            this.bandCommon.OptionsBand.AllowMove = false;
            this.bandCommon.Width = 548;
            // 
            // bandResult
            // 
            this.bandResult.AppearanceHeader.Options.UseTextOptions = true;
            this.bandResult.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandResult.Caption = "Các chỉ tiêu phân tích";
            this.bandResult.MinWidth = 20;
            this.bandResult.Name = "bandResult";
            this.bandResult.OptionsBand.AllowMove = false;
            this.bandResult.Width = 198;
            // 
            // bandRequest
            // 
            this.bandRequest.AppearanceHeader.Options.UseTextOptions = true;
            this.bandRequest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandRequest.Caption = "Các chỉ tiêu yêu cầu";
            this.bandRequest.MinWidth = 20;
            this.bandRequest.Name = "bandRequest";
            this.bandRequest.OptionsBand.AllowMove = false;
            this.bandRequest.Width = 234;
            // 
            // UCProductTestTransaction
            // 
            this.Controls.Add(this.txtNguoikiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.lbShift);
            this.Controls.Add(this.dateEditTransaction);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.lbStockCode);
            this.Name = "UCProductTestTransaction";
            this.Size = new System.Drawing.Size(876, 473);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoikiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lbDate;
        private DevExpress.XtraEditors.DateEdit dateEditTransaction;
        private System.Windows.Forms.Label lbShift;
        private DevExpress.XtraEditors.SpinEdit txtShift;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewProductCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewSizeCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewFormulaCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewItemEncryptCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewLot;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtString;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtPercent;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNguoikiem;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandCommon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNewNgayCodeBao;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandResult;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandRequest;
    }
}
