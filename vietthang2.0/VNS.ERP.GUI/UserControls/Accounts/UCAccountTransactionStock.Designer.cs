namespace VNS.ERP.GUI.UserControls
{
    partial class UCAccountTransactionStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLoaiNX = new System.Windows.Forms.Label();
            this.lookUpEditStockTransactionTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbSo = new System.Windows.Forms.Label();
            this.dateEditStockTransaction = new DevExpress.XtraEditors.DateEdit();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbKho = new System.Windows.Forms.Label();
            this.txtTenkho = new DevExpress.XtraEditors.TextEdit();
            this.lbNguoiGiao = new System.Windows.Forms.Label();
            this.txtNguoigiaonhan = new DevExpress.XtraEditors.TextEdit();
            this.lbNguoiNhan = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbPTVC = new System.Windows.Forms.Label();
            this.txtPTVC = new DevExpress.XtraEditors.TextEdit();
            this.lbLyDoNX = new System.Windows.Forms.Label();
            this.txtLydoNX = new DevExpress.XtraEditors.TextEdit();
            this.lbCTKemTheo = new System.Windows.Forms.Label();
            this.txtCTKT = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDebitAccountCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditDebitAccountCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockInCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditStockIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCreditAccountCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditCreditAccountCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockOutCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditStockOut = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lbNguoiVC = new System.Windows.Forms.Label();
            this.txtNguoiVC = new DevExpress.XtraEditors.TextEdit();
            this.chkGetFromStockTransaction = new DevExpress.XtraEditors.CheckEdit();
            this.btnGetFromStockTransaction = new DevExpress.XtraEditors.ButtonEdit();
            this.lookUpEditDonVi = new DevExpress.XtraEditors.LookUpEdit();
            this.lbInvoiceMau = new System.Windows.Forms.Label();
            this.txtInvoiceMau = new DevExpress.XtraEditors.TextEdit();
            this.txtInvoiceSeri = new DevExpress.XtraEditors.TextEdit();
            this.lbInvoiceSeri = new System.Windows.Forms.Label();
            this.lbInvoiceNo = new System.Windows.Forms.Label();
            this.txtInvoiceSo = new DevExpress.XtraEditors.TextEdit();
            this.lbInvoiceNgay = new System.Windows.Forms.Label();
            this.dateEditInvoice = new DevExpress.XtraEditors.DateEdit();
            this.txtInvoiceThueXuat = new DevExpress.XtraEditors.TextEdit();
            this.lbInvoiceThueXuat = new System.Windows.Forms.Label();
            this.grBoxInvoice = new System.Windows.Forms.GroupBox();
            this.txtPaidDays = new DevExpress.XtraEditors.SpinEdit();
            this.lblPaidDays = new System.Windows.Forms.Label();
            this.chkVAT = new DevExpress.XtraEditors.CheckEdit();
            this.txtHTTT = new DevExpress.XtraEditors.TextEdit();
            this.lbHTTT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkGiamgia = new DevExpress.XtraEditors.CheckEdit();
            this.txtInvoiceAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeforeTaxAmount = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscountDescription = new DevExpress.XtraEditors.TextEdit();
            this.lbDiscountDescription = new System.Windows.Forms.Label();
            this.btnEditDonvi = new DevExpress.XtraEditors.ButtonEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStockTransactionNo = new DevExpress.XtraEditors.ButtonEdit();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrintReportA4 = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnCopyDescription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStockTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoigiaonhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLydoNX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCTKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditDebitAccountCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditCreditAccountCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGetFromStockTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFromStockTransaction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceMau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceThueXuat.Properties)).BeginInit();
            this.grBoxInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGiamgia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeTaxAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDonvi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockTransactionNo.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoaiNX
            // 
            this.lbLoaiNX.AutoSize = true;
            this.lbLoaiNX.Location = new System.Drawing.Point(29, 10);
            this.lbLoaiNX.Name = "lbLoaiNX";
            this.lbLoaiNX.Size = new System.Drawing.Size(45, 13);
            this.lbLoaiNX.TabIndex = 16;
            this.lbLoaiNX.Text = "Loại NX";
            this.lbLoaiNX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditStockTransactionTypeCode
            // 
            this.lookUpEditStockTransactionTypeCode.EnterMoveNextControl = true;
            this.lookUpEditStockTransactionTypeCode.Location = new System.Drawing.Point(78, 6);
            this.lookUpEditStockTransactionTypeCode.Name = "lookUpEditStockTransactionTypeCode";
            this.lookUpEditStockTransactionTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStockTransactionTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionTypeCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditStockTransactionTypeCode.Properties.DisplayMember = "Description";
            this.lookUpEditStockTransactionTypeCode.Properties.NullText = "";
            this.lookUpEditStockTransactionTypeCode.Properties.ReadOnly = true;
            this.lookUpEditStockTransactionTypeCode.Properties.ValueMember = "TransactionTypeCode";
            this.lookUpEditStockTransactionTypeCode.Size = new System.Drawing.Size(149, 20);
            this.lookUpEditStockTransactionTypeCode.TabIndex = 0;
            this.lookUpEditStockTransactionTypeCode.EditValueChanged += new System.EventHandler(this.lookUpEditStockTransactionTypeCode_EditValueChanged);
            // 
            // lbSo
            // 
            this.lbSo.Location = new System.Drawing.Point(250, 8);
            this.lbSo.Name = "lbSo";
            this.lbSo.Size = new System.Drawing.Size(60, 13);
            this.lbSo.TabIndex = 22;
            this.lbSo.Text = "Số phiếu";
            this.lbSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditStockTransaction
            // 
            this.dateEditStockTransaction.EditValue = new System.DateTime(2007, 5, 8, 10, 38, 57, 390);
            this.dateEditStockTransaction.EnterMoveNextControl = true;
            this.dateEditStockTransaction.Location = new System.Drawing.Point(494, 5);
            this.dateEditStockTransaction.Name = "dateEditStockTransaction";
            this.dateEditStockTransaction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStockTransaction.Size = new System.Drawing.Size(82, 20);
            this.dateEditStockTransaction.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(456, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(32, 13);
            this.lbDate.TabIndex = 25;
            this.lbDate.Text = "Ngày";
            // 
            // lbKho
            // 
            this.lbKho.AutoSize = true;
            this.lbKho.Location = new System.Drawing.Point(608, 8);
            this.lbKho.Name = "lbKho";
            this.lbKho.Size = new System.Drawing.Size(26, 13);
            this.lbKho.TabIndex = 26;
            this.lbKho.Text = "Kho";
            // 
            // txtTenkho
            // 
            this.txtTenkho.EnterMoveNextControl = true;
            this.txtTenkho.Location = new System.Drawing.Point(639, 5);
            this.txtTenkho.Name = "txtTenkho";
            this.txtTenkho.Size = new System.Drawing.Size(207, 20);
            this.txtTenkho.TabIndex = 3;
            // 
            // lbNguoiGiao
            // 
            this.lbNguoiGiao.Location = new System.Drawing.Point(8, 31);
            this.lbNguoiGiao.Name = "lbNguoiGiao";
            this.lbNguoiGiao.Size = new System.Drawing.Size(67, 13);
            this.lbNguoiGiao.TabIndex = 17;
            this.lbNguoiGiao.Text = "Người giao";
            this.lbNguoiGiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoigiaonhan
            // 
            this.txtNguoigiaonhan.EnterMoveNextControl = true;
            this.txtNguoigiaonhan.Location = new System.Drawing.Point(78, 28);
            this.txtNguoigiaonhan.Name = "txtNguoigiaonhan";
            this.txtNguoigiaonhan.Size = new System.Drawing.Size(149, 20);
            this.txtNguoigiaonhan.TabIndex = 4;
            // 
            // lbNguoiNhan
            // 
            this.lbNguoiNhan.Location = new System.Drawing.Point(8, 44);
            this.lbNguoiNhan.Name = "lbNguoiNhan";
            this.lbNguoiNhan.Size = new System.Drawing.Size(67, 13);
            this.lbNguoiNhan.TabIndex = 18;
            this.lbNguoiNhan.Text = "Người nhận";
            this.lbNguoiNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDonVi
            // 
            this.lbDonVi.Location = new System.Drawing.Point(21, 115);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(51, 13);
            this.lbDonVi.TabIndex = 21;
            this.lbDonVi.Text = "Đơn vị";
            this.lbDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPTVC
            // 
            this.lbPTVC.Location = new System.Drawing.Point(233, 31);
            this.lbPTVC.Name = "lbPTVC";
            this.lbPTVC.Size = new System.Drawing.Size(81, 13);
            this.lbPTVC.TabIndex = 23;
            this.lbPTVC.Text = "PT vận chuyển";
            // 
            // txtPTVC
            // 
            this.txtPTVC.EnterMoveNextControl = true;
            this.txtPTVC.Location = new System.Drawing.Point(321, 28);
            this.txtPTVC.Name = "txtPTVC";
            this.txtPTVC.Size = new System.Drawing.Size(256, 20);
            this.txtPTVC.TabIndex = 5;
            // 
            // lbLyDoNX
            // 
            this.lbLyDoNX.Location = new System.Drawing.Point(583, 32);
            this.lbLyDoNX.Name = "lbLyDoNX";
            this.lbLyDoNX.Size = new System.Drawing.Size(51, 13);
            this.lbLyDoNX.TabIndex = 27;
            this.lbLyDoNX.Text = "Lý do NX";
            // 
            // txtLydoNX
            // 
            this.txtLydoNX.EnterMoveNextControl = true;
            this.txtLydoNX.Location = new System.Drawing.Point(639, 28);
            this.txtLydoNX.Name = "txtLydoNX";
            this.txtLydoNX.Size = new System.Drawing.Size(207, 20);
            this.txtLydoNX.TabIndex = 6;
            // 
            // lbCTKemTheo
            // 
            this.lbCTKemTheo.Location = new System.Drawing.Point(244, 53);
            this.lbCTKemTheo.Name = "lbCTKemTheo";
            this.lbCTKemTheo.Size = new System.Drawing.Size(70, 13);
            this.lbCTKemTheo.TabIndex = 24;
            this.lbCTKemTheo.Text = "CT kèm theo";
            // 
            // txtCTKT
            // 
            this.txtCTKT.EnterMoveNextControl = true;
            this.txtCTKT.Location = new System.Drawing.Point(321, 50);
            this.txtCTKT.Name = "txtCTKT";
            this.txtCTKT.Size = new System.Drawing.Size(256, 20);
            this.txtCTKT.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(78, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(768, 38);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.EditValueChanged += new System.EventHandler(this.txtDescription_EditValueChanged);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(22, 83);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(51, 13);
            this.lbDescription.TabIndex = 20;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 137);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditDebitAccountCode,
            this.repLookUpEditCreditAccountCode,
            this.repLookUpEditItemCode,
            this.repLookUpEditStockIn,
            this.repLookUpEditStockOut,
            this.repTextEditNumDecimaln2,
            this.repLookUpEditItemName,
            this.repTextEditNumDecimaln0});
            this.gridControl1.Size = new System.Drawing.Size(953, 272);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDebitAccountCode1,
            this.colStockInCode,
            this.colCreditAccountCode1,
            this.colStockOutCode,
            this.colItemCode,
            this.colQuantity,
            this.colPrice,
            this.colPrice1,
            this.colAmount1,
            this.colAmount11,
            this.colCostPrice,
            this.colCostAmount,
            this.colDescription3,
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridView1_BeforeLeaveRow);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colDebitAccountCode1
            // 
            this.colDebitAccountCode1.Caption = "TK nợ";
            this.colDebitAccountCode1.ColumnEdit = this.repLookUpEditDebitAccountCode;
            this.colDebitAccountCode1.FieldName = "DebitAccountCode";
            this.colDebitAccountCode1.Name = "colDebitAccountCode1";
            this.colDebitAccountCode1.Visible = true;
            this.colDebitAccountCode1.VisibleIndex = 0;
            this.colDebitAccountCode1.Width = 74;
            // 
            // repLookUpEditDebitAccountCode
            // 
            this.repLookUpEditDebitAccountCode.AutoHeight = false;
            this.repLookUpEditDebitAccountCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditDebitAccountCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditDebitAccountCode.DisplayMember = "AccountCode";
            this.repLookUpEditDebitAccountCode.Name = "repLookUpEditDebitAccountCode";
            this.repLookUpEditDebitAccountCode.NullText = "";
            this.repLookUpEditDebitAccountCode.PopupWidth = 350;
            this.repLookUpEditDebitAccountCode.ShowHeader = false;
            this.repLookUpEditDebitAccountCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditDebitAccountCode.ValueMember = "AccountCode";
            // 
            // colStockInCode
            // 
            this.colStockInCode.Caption = "Kho nhập";
            this.colStockInCode.ColumnEdit = this.repLookUpEditStockIn;
            this.colStockInCode.FieldName = "StockInCode";
            this.colStockInCode.Name = "colStockInCode";
            this.colStockInCode.Visible = true;
            this.colStockInCode.VisibleIndex = 1;
            this.colStockInCode.Width = 137;
            // 
            // repLookUpEditStockIn
            // 
            this.repLookUpEditStockIn.AutoHeight = false;
            this.repLookUpEditStockIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditStockIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditStockIn.DisplayMember = "StockName";
            this.repLookUpEditStockIn.Name = "repLookUpEditStockIn";
            this.repLookUpEditStockIn.NullText = "";
            this.repLookUpEditStockIn.ShowHeader = false;
            this.repLookUpEditStockIn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditStockIn.ValueMember = "StockCode";
            // 
            // colCreditAccountCode1
            // 
            this.colCreditAccountCode1.Caption = "TK có";
            this.colCreditAccountCode1.ColumnEdit = this.repLookUpEditCreditAccountCode;
            this.colCreditAccountCode1.FieldName = "CreditAccountCode";
            this.colCreditAccountCode1.Name = "colCreditAccountCode1";
            this.colCreditAccountCode1.Visible = true;
            this.colCreditAccountCode1.VisibleIndex = 2;
            this.colCreditAccountCode1.Width = 74;
            // 
            // repLookUpEditCreditAccountCode
            // 
            this.repLookUpEditCreditAccountCode.AutoHeight = false;
            this.repLookUpEditCreditAccountCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditCreditAccountCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditCreditAccountCode.DisplayMember = "AccountCode";
            this.repLookUpEditCreditAccountCode.Name = "repLookUpEditCreditAccountCode";
            this.repLookUpEditCreditAccountCode.NullText = "";
            this.repLookUpEditCreditAccountCode.PopupWidth = 350;
            this.repLookUpEditCreditAccountCode.ShowHeader = false;
            this.repLookUpEditCreditAccountCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditCreditAccountCode.ValueMember = "AccountCode";
            // 
            // colStockOutCode
            // 
            this.colStockOutCode.Caption = "Kho xuất";
            this.colStockOutCode.ColumnEdit = this.repLookUpEditStockOut;
            this.colStockOutCode.FieldName = "StockOutCode";
            this.colStockOutCode.Name = "colStockOutCode";
            this.colStockOutCode.Visible = true;
            this.colStockOutCode.VisibleIndex = 3;
            this.colStockOutCode.Width = 119;
            // 
            // repLookUpEditStockOut
            // 
            this.repLookUpEditStockOut.AutoHeight = false;
            this.repLookUpEditStockOut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditStockOut.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditStockOut.DisplayMember = "StockName";
            this.repLookUpEditStockOut.Name = "repLookUpEditStockOut";
            this.repLookUpEditStockOut.NullText = "";
            this.repLookUpEditStockOut.ShowHeader = false;
            this.repLookUpEditStockOut.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditStockOut.ValueMember = "StockCode";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã TP";
            this.colItemCode.ColumnEdit = this.repLookUpEditItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 4;
            this.colItemCode.Width = 81;
            // 
            // repLookUpEditItemCode
            // 
            this.repLookUpEditItemCode.AutoHeight = false;
            this.repLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditItemCode.DisplayMember = "ItemCode";
            this.repLookUpEditItemCode.Name = "repLookUpEditItemCode";
            this.repLookUpEditItemCode.NullText = "";
            this.repLookUpEditItemCode.PopupWidth = 250;
            this.repLookUpEditItemCode.ShowHeader = false;
            this.repLookUpEditItemCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditItemCode.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            // 
            // repTextEditNumDecimaln2
            // 
            this.repTextEditNumDecimaln2.AutoHeight = false;
            this.repTextEditNumDecimaln2.Mask.EditMask = "n2";
            this.repTextEditNumDecimaln2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln2.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln2.Name = "repTextEditNumDecimaln2";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Giá bán";
            this.colPrice.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 9;
            this.colPrice.Width = 85;
            // 
            // colPrice1
            // 
            this.colPrice1.Caption = "Giá mua";
            this.colPrice1.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.Visible = true;
            this.colPrice1.VisibleIndex = 7;
            // 
            // colAmount1
            // 
            this.colAmount1.Caption = "Tiền bán";
            this.colAmount1.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 10;
            this.colAmount1.Width = 70;
            // 
            // repTextEditNumDecimaln0
            // 
            this.repTextEditNumDecimaln0.AutoHeight = false;
            this.repTextEditNumDecimaln0.Mask.EditMask = "n0";
            this.repTextEditNumDecimaln0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln0.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln0.Name = "repTextEditNumDecimaln0";
            // 
            // colAmount11
            // 
            this.colAmount11.Caption = "Tiền mua";
            this.colAmount11.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colAmount11.FieldName = "Amount";
            this.colAmount11.Name = "colAmount11";
            this.colAmount11.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount11.Visible = true;
            this.colAmount11.VisibleIndex = 8;
            // 
            // colCostPrice
            // 
            this.colCostPrice.Caption = "Giá vốn";
            this.colCostPrice.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colCostPrice.FieldName = "CostPrice";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.Visible = true;
            this.colCostPrice.VisibleIndex = 11;
            // 
            // colCostAmount
            // 
            this.colCostAmount.Caption = "Tiền vốn";
            this.colCostAmount.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colCostAmount.FieldName = "CostAmount";
            this.colCostAmount.Name = "colCostAmount";
            this.colCostAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCostAmount.Visible = true;
            this.colCostAmount.VisibleIndex = 12;
            this.colCostAmount.Width = 70;
            // 
            // colDescription3
            // 
            this.colDescription3.Caption = "Diễn giải";
            this.colDescription3.FieldName = "Description";
            this.colDescription3.Name = "colDescription3";
            this.colDescription3.Visible = true;
            this.colDescription3.VisibleIndex = 13;
            this.colDescription3.Width = 200;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên TP";
            this.colItemName.ColumnEdit = this.repLookUpEditItemName;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            this.colItemName.Width = 149;
            // 
            // repLookUpEditItemName
            // 
            this.repLookUpEditItemName.AutoHeight = false;
            this.repLookUpEditItemName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã TP", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.repLookUpEditItemName.DisplayMember = "ItemName";
            this.repLookUpEditItemName.Name = "repLookUpEditItemName";
            this.repLookUpEditItemName.NullText = "";
            this.repLookUpEditItemName.ValueMember = "ItemCode";
            // 
            // lbNguoiVC
            // 
            this.lbNguoiVC.Location = new System.Drawing.Point(5, 53);
            this.lbNguoiVC.Name = "lbNguoiVC";
            this.lbNguoiVC.Size = new System.Drawing.Size(70, 13);
            this.lbNguoiVC.TabIndex = 19;
            this.lbNguoiVC.Text = "Người VC";
            this.lbNguoiVC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNguoiVC
            // 
            this.txtNguoiVC.EnterMoveNextControl = true;
            this.txtNguoiVC.Location = new System.Drawing.Point(78, 50);
            this.txtNguoiVC.Name = "txtNguoiVC";
            this.txtNguoiVC.Size = new System.Drawing.Size(149, 20);
            this.txtNguoiVC.TabIndex = 7;
            // 
            // chkGetFromStockTransaction
            // 
            this.chkGetFromStockTransaction.Location = new System.Drawing.Point(638, 49);
            this.chkGetFromStockTransaction.Name = "chkGetFromStockTransaction";
            this.chkGetFromStockTransaction.Properties.Caption = "Lấy từ phiếu N/X kho";
            this.chkGetFromStockTransaction.Properties.ReadOnly = true;
            this.chkGetFromStockTransaction.Size = new System.Drawing.Size(127, 18);
            this.chkGetFromStockTransaction.TabIndex = 28;
            this.chkGetFromStockTransaction.CheckedChanged += new System.EventHandler(this.chkGetFromStockTransaction_CheckedChanged1);
            // 
            // btnGetFromStockTransaction
            // 
            this.btnGetFromStockTransaction.EnterMoveNextControl = true;
            this.btnGetFromStockTransaction.Location = new System.Drawing.Point(765, 49);
            this.btnGetFromStockTransaction.Name = "btnGetFromStockTransaction";
            this.btnGetFromStockTransaction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnGetFromStockTransaction.Size = new System.Drawing.Size(20, 20);
            this.btnGetFromStockTransaction.TabIndex = 29;
            this.btnGetFromStockTransaction.EditValueChanged += new System.EventHandler(this.btnGetFromStockTransaction_EditValueChanged);
            this.btnGetFromStockTransaction.Click += new System.EventHandler(this.btnGetFromStockTransaction_Click1);
            // 
            // lookUpEditDonVi
            // 
            this.lookUpEditDonVi.EnterMoveNextControl = true;
            this.lookUpEditDonVi.Location = new System.Drawing.Point(78, 112);
            this.lookUpEditDonVi.Name = "lookUpEditDonVi";
            this.lookUpEditDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDonVi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã đơn vị", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên đơn vị", 150)});
            this.lookUpEditDonVi.Properties.DisplayMember = "SubjectCode";
            this.lookUpEditDonVi.Properties.NullText = "";
            this.lookUpEditDonVi.Properties.PopupWidth = 300;
            this.lookUpEditDonVi.Properties.ReadOnly = true;
            this.lookUpEditDonVi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditDonVi.Properties.ValueMember = "SubjectCode";
            this.lookUpEditDonVi.Size = new System.Drawing.Size(104, 20);
            this.lookUpEditDonVi.TabIndex = 10;
            this.lookUpEditDonVi.EditValueChanged += new System.EventHandler(this.lookUpEditDonVi_EditValueChanged);
            // 
            // lbInvoiceMau
            // 
            this.lbInvoiceMau.Location = new System.Drawing.Point(26, 41);
            this.lbInvoiceMau.Name = "lbInvoiceMau";
            this.lbInvoiceMau.Size = new System.Drawing.Size(37, 13);
            this.lbInvoiceMau.TabIndex = 13;
            this.lbInvoiceMau.Text = "Mẫu";
            this.lbInvoiceMau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInvoiceMau
            // 
            this.txtInvoiceMau.EnterMoveNextControl = true;
            this.txtInvoiceMau.Location = new System.Drawing.Point(66, 38);
            this.txtInvoiceMau.Name = "txtInvoiceMau";
            this.txtInvoiceMau.Size = new System.Drawing.Size(92, 20);
            this.txtInvoiceMau.TabIndex = 0;
            // 
            // txtInvoiceSeri
            // 
            this.txtInvoiceSeri.EnterMoveNextControl = true;
            this.txtInvoiceSeri.Location = new System.Drawing.Point(219, 38);
            this.txtInvoiceSeri.Name = "txtInvoiceSeri";
            this.txtInvoiceSeri.Size = new System.Drawing.Size(92, 20);
            this.txtInvoiceSeri.TabIndex = 1;
            // 
            // lbInvoiceSeri
            // 
            this.lbInvoiceSeri.Location = new System.Drawing.Point(187, 41);
            this.lbInvoiceSeri.Name = "lbInvoiceSeri";
            this.lbInvoiceSeri.Size = new System.Drawing.Size(29, 13);
            this.lbInvoiceSeri.TabIndex = 15;
            this.lbInvoiceSeri.Text = "Seri";
            this.lbInvoiceSeri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbInvoiceNo
            // 
            this.lbInvoiceNo.Location = new System.Drawing.Point(317, 41);
            this.lbInvoiceNo.Name = "lbInvoiceNo";
            this.lbInvoiceNo.Size = new System.Drawing.Size(27, 13);
            this.lbInvoiceNo.TabIndex = 17;
            this.lbInvoiceNo.Text = "Số";
            this.lbInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInvoiceSo
            // 
            this.txtInvoiceSo.EnterMoveNextControl = true;
            this.txtInvoiceSo.Location = new System.Drawing.Point(347, 38);
            this.txtInvoiceSo.Name = "txtInvoiceSo";
            this.txtInvoiceSo.Size = new System.Drawing.Size(104, 20);
            this.txtInvoiceSo.TabIndex = 2;
            // 
            // lbInvoiceNgay
            // 
            this.lbInvoiceNgay.AutoSize = true;
            this.lbInvoiceNgay.Location = new System.Drawing.Point(465, 41);
            this.lbInvoiceNgay.Name = "lbInvoiceNgay";
            this.lbInvoiceNgay.Size = new System.Drawing.Size(32, 13);
            this.lbInvoiceNgay.TabIndex = 18;
            this.lbInvoiceNgay.Text = "Ngày";
            // 
            // dateEditInvoice
            // 
            this.dateEditInvoice.EditValue = new System.DateTime(2007, 5, 8, 10, 38, 57, 390);
            this.dateEditInvoice.EnterMoveNextControl = true;
            this.dateEditInvoice.Location = new System.Drawing.Point(500, 37);
            this.dateEditInvoice.Name = "dateEditInvoice";
            this.dateEditInvoice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditInvoice.Size = new System.Drawing.Size(82, 20);
            this.dateEditInvoice.TabIndex = 3;
            // 
            // txtInvoiceThueXuat
            // 
            this.txtInvoiceThueXuat.EditValue = 0;
            this.txtInvoiceThueXuat.EnterMoveNextControl = true;
            this.txtInvoiceThueXuat.Location = new System.Drawing.Point(650, 36);
            this.txtInvoiceThueXuat.Name = "txtInvoiceThueXuat";
            this.txtInvoiceThueXuat.Properties.Appearance.Options.UseTextOptions = true;
            this.txtInvoiceThueXuat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtInvoiceThueXuat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtInvoiceThueXuat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtInvoiceThueXuat.Properties.Mask.EditMask = "n0";
            this.txtInvoiceThueXuat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInvoiceThueXuat.Properties.Mask.PlaceHolder = '\0';
            this.txtInvoiceThueXuat.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtInvoiceThueXuat.Size = new System.Drawing.Size(92, 20);
            this.txtInvoiceThueXuat.TabIndex = 4;
            this.txtInvoiceThueXuat.EditValueChanged += new System.EventHandler(this.txtInvoiceThueXuat_EditValueChanged);
            // 
            // lbInvoiceThueXuat
            // 
            this.lbInvoiceThueXuat.Location = new System.Drawing.Point(588, 40);
            this.lbInvoiceThueXuat.Name = "lbInvoiceThueXuat";
            this.lbInvoiceThueXuat.Size = new System.Drawing.Size(57, 13);
            this.lbInvoiceThueXuat.TabIndex = 20;
            this.lbInvoiceThueXuat.Text = "Thuế xuất";
            this.lbInvoiceThueXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grBoxInvoice
            // 
            this.grBoxInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grBoxInvoice.Controls.Add(this.txtPaidDays);
            this.grBoxInvoice.Controls.Add(this.lblPaidDays);
            this.grBoxInvoice.Controls.Add(this.chkVAT);
            this.grBoxInvoice.Controls.Add(this.txtHTTT);
            this.grBoxInvoice.Controls.Add(this.lbHTTT);
            this.grBoxInvoice.Controls.Add(this.label3);
            this.grBoxInvoice.Controls.Add(this.chkGiamgia);
            this.grBoxInvoice.Controls.Add(this.txtInvoiceAmount);
            this.grBoxInvoice.Controls.Add(this.lbInvoiceMau);
            this.grBoxInvoice.Controls.Add(this.txtDiscount);
            this.grBoxInvoice.Controls.Add(this.txtInvoiceThueXuat);
            this.grBoxInvoice.Controls.Add(this.txtTaxAmount);
            this.grBoxInvoice.Controls.Add(this.txtInvoiceMau);
            this.grBoxInvoice.Controls.Add(this.lbDiscount);
            this.grBoxInvoice.Controls.Add(this.label2);
            this.grBoxInvoice.Controls.Add(this.lbInvoiceThueXuat);
            this.grBoxInvoice.Controls.Add(this.lbInvoiceSeri);
            this.grBoxInvoice.Controls.Add(this.txtBeforeTaxAmount);
            this.grBoxInvoice.Controls.Add(this.lbInvoiceNgay);
            this.grBoxInvoice.Controls.Add(this.dateEditInvoice);
            this.grBoxInvoice.Controls.Add(this.label1);
            this.grBoxInvoice.Controls.Add(this.lbInvoiceNo);
            this.grBoxInvoice.Controls.Add(this.txtDiscountDescription);
            this.grBoxInvoice.Controls.Add(this.txtInvoiceSeri);
            this.grBoxInvoice.Controls.Add(this.txtInvoiceSo);
            this.grBoxInvoice.Controls.Add(this.lbDiscountDescription);
            this.grBoxInvoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grBoxInvoice.Location = new System.Drawing.Point(4, 411);
            this.grBoxInvoice.Name = "grBoxInvoice";
            this.grBoxInvoice.Size = new System.Drawing.Size(952, 85);
            this.grBoxInvoice.TabIndex = 12;
            this.grBoxInvoice.TabStop = false;
            this.grBoxInvoice.Text = "Hoá đơn";
            // 
            // txtPaidDays
            // 
            this.txtPaidDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPaidDays.Location = new System.Drawing.Point(347, 11);
            this.txtPaidDays.Name = "txtPaidDays";
            this.txtPaidDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPaidDays.Properties.UseCtrlIncrement = false;
            this.txtPaidDays.Size = new System.Drawing.Size(103, 20);
            this.txtPaidDays.TabIndex = 25;
            this.txtPaidDays.Visible = false;
            // 
            // lblPaidDays
            // 
            this.lblPaidDays.AutoSize = true;
            this.lblPaidDays.Location = new System.Drawing.Point(283, 14);
            this.lblPaidDays.Name = "lblPaidDays";
            this.lblPaidDays.Size = new System.Drawing.Size(61, 13);
            this.lblPaidDays.TabIndex = 24;
            this.lblPaidDays.Text = "Số ngày nợ";
            this.lblPaidDays.Visible = false;
            // 
            // chkVAT
            // 
            this.chkVAT.Location = new System.Drawing.Point(64, 15);
            this.chkVAT.Name = "chkVAT";
            this.chkVAT.Properties.Caption = "VAT";
            this.chkVAT.Size = new System.Drawing.Size(68, 18);
            this.chkVAT.TabIndex = 12;
            // 
            // txtHTTT
            // 
            this.txtHTTT.EnterMoveNextControl = true;
            this.txtHTTT.Location = new System.Drawing.Point(501, 59);
            this.txtHTTT.Name = "txtHTTT";
            this.txtHTTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHTTT.Properties.Appearance.Options.UseFont = true;
            this.txtHTTT.Properties.ReadOnly = true;
            this.txtHTTT.Size = new System.Drawing.Size(82, 22);
            this.txtHTTT.TabIndex = 10;
            // 
            // lbHTTT
            // 
            this.lbHTTT.Location = new System.Drawing.Point(452, 62);
            this.lbHTTT.Name = "lbHTTT";
            this.lbHTTT.Size = new System.Drawing.Size(45, 16);
            this.lbHTTT.TabIndex = 19;
            this.lbHTTT.Text = "HTTT";
            this.lbHTTT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(744, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tiền hoá đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkGiamgia
            // 
            this.chkGiamgia.Location = new System.Drawing.Point(591, 59);
            this.chkGiamgia.Name = "chkGiamgia";
            this.chkGiamgia.Properties.Caption = "Giảm giá";
            this.chkGiamgia.Size = new System.Drawing.Size(68, 18);
            this.chkGiamgia.TabIndex = 11;
            // 
            // txtInvoiceAmount
            // 
            this.txtInvoiceAmount.EditValue = "0";
            this.txtInvoiceAmount.EnterMoveNextControl = true;
            this.txtInvoiceAmount.Location = new System.Drawing.Point(825, 59);
            this.txtInvoiceAmount.Name = "txtInvoiceAmount";
            this.txtInvoiceAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceAmount.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtInvoiceAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtInvoiceAmount.Properties.Mask.EditMask = "n0";
            this.txtInvoiceAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInvoiceAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtInvoiceAmount.Properties.ReadOnly = true;
            this.txtInvoiceAmount.Size = new System.Drawing.Size(119, 22);
            this.txtInvoiceAmount.TabIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.EnterMoveNextControl = true;
            this.txtDiscount.Location = new System.Drawing.Point(66, 60);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Properties.Appearance.Options.UseFont = true;
            this.txtDiscount.Properties.Mask.EditMask = "n0";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Properties.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(92, 22);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.txtDiscount_EditValueChanged);
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.EditValue = "0";
            this.txtTaxAmount.EnterMoveNextControl = true;
            this.txtTaxAmount.Location = new System.Drawing.Point(825, 35);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount.Properties.Appearance.Options.UseFont = true;
            this.txtTaxAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTaxAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTaxAmount.Properties.Mask.EditMask = "n0";
            this.txtTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTaxAmount.Properties.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(119, 22);
            this.txtTaxAmount.TabIndex = 6;
            this.txtTaxAmount.EditValueChanged += new System.EventHandler(this.txtTaxAmount_EditValueChanged);
            // 
            // lbDiscount
            // 
            this.lbDiscount.Location = new System.Drawing.Point(3, 60);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(61, 16);
            this.lbDiscount.TabIndex = 14;
            this.lbDiscount.Text = "Chiết khấu";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(764, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tiền thuế";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBeforeTaxAmount
            // 
            this.txtBeforeTaxAmount.EditValue = "0";
            this.txtBeforeTaxAmount.EnterMoveNextControl = true;
            this.txtBeforeTaxAmount.Location = new System.Drawing.Point(825, 11);
            this.txtBeforeTaxAmount.Name = "txtBeforeTaxAmount";
            this.txtBeforeTaxAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeforeTaxAmount.Properties.Appearance.Options.UseFont = true;
            this.txtBeforeTaxAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBeforeTaxAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBeforeTaxAmount.Properties.Mask.EditMask = "n0";
            this.txtBeforeTaxAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBeforeTaxAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBeforeTaxAmount.Properties.ReadOnly = true;
            this.txtBeforeTaxAmount.Size = new System.Drawing.Size(118, 22);
            this.txtBeforeTaxAmount.TabIndex = 5;
            this.txtBeforeTaxAmount.Tag = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(725, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tiền trước thuế";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscountDescription
            // 
            this.txtDiscountDescription.EnterMoveNextControl = true;
            this.txtDiscountDescription.Location = new System.Drawing.Point(219, 60);
            this.txtDiscountDescription.Name = "txtDiscountDescription";
            this.txtDiscountDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountDescription.Properties.ReadOnly = true;
            this.txtDiscountDescription.Size = new System.Drawing.Size(232, 22);
            this.txtDiscountDescription.TabIndex = 9;
            // 
            // lbDiscountDescription
            // 
            this.lbDiscountDescription.Location = new System.Drawing.Point(162, 60);
            this.lbDiscountDescription.Name = "lbDiscountDescription";
            this.lbDiscountDescription.Size = new System.Drawing.Size(55, 16);
            this.lbDiscountDescription.TabIndex = 16;
            this.lbDiscountDescription.Text = "Nội dung";
            this.lbDiscountDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditDonvi
            // 
            this.btnEditDonvi.EnterMoveNextControl = true;
            this.btnEditDonvi.Location = new System.Drawing.Point(184, 112);
            this.btnEditDonvi.Name = "btnEditDonvi";
            this.btnEditDonvi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4))});
            this.btnEditDonvi.Size = new System.Drawing.Size(190, 20);
            this.btnEditDonvi.TabIndex = 30;
            this.btnEditDonvi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(856, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Định khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStockTransactionNo
            // 
            this.txtStockTransactionNo.EnterMoveNextControl = true;
            this.txtStockTransactionNo.Location = new System.Drawing.Point(321, 3);
            this.txtStockTransactionNo.Name = "txtStockTransactionNo";
            this.txtStockTransactionNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockTransactionNo.Properties.Appearance.Options.UseFont = true;
            this.txtStockTransactionNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStockTransactionNo.Size = new System.Drawing.Size(129, 22);
            this.txtStockTransactionNo.TabIndex = 1;
            this.txtStockTransactionNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtStockTransactionNo_ButtonClick);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.Location = new System.Drawing.Point(387, 4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(90, 21);
            this.btnPrintReport.TabIndex = 0;
            this.btnPrintReport.Text = "In phiếu";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrintReportA4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintReport, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintInvoice, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 495);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 30);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnPrintReportA4
            // 
            this.btnPrintReportA4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReportA4.Location = new System.Drawing.Point(483, 4);
            this.btnPrintReportA4.Name = "btnPrintReportA4";
            this.btnPrintReportA4.Size = new System.Drawing.Size(92, 21);
            this.btnPrintReportA4.TabIndex = 1;
            this.btnPrintReportA4.Text = "In phiếu A4";
            this.btnPrintReportA4.UseVisualStyleBackColor = true;
            this.btnPrintReportA4.Click += new System.EventHandler(this.btnPrintReportA4_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(883, 3);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(77, 24);
            this.btnPrintInvoice.TabIndex = 2;
            this.btnPrintInvoice.Text = "In hoá đơn";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnCopyDescription
            // 
            this.btnCopyDescription.Location = new System.Drawing.Point(852, 89);
            this.btnCopyDescription.Name = "btnCopyDescription";
            this.btnCopyDescription.Size = new System.Drawing.Size(42, 21);
            this.btnCopyDescription.TabIndex = 15;
            this.btnCopyDescription.Text = "Copy";
            this.btnCopyDescription.UseVisualStyleBackColor = true;
            this.btnCopyDescription.Visible = false;
            this.btnCopyDescription.Click += new System.EventHandler(this.btnCopyDescription_Click);
            // 
            // UCAccountTransactionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyDescription);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtStockTransactionNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditDonvi);
            this.Controls.Add(this.grBoxInvoice);
            this.Controls.Add(this.lookUpEditDonVi);
            this.Controls.Add(this.btnGetFromStockTransaction);
            this.Controls.Add(this.chkGetFromStockTransaction);
            this.Controls.Add(this.txtNguoiVC);
            this.Controls.Add(this.lbNguoiVC);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCTKT);
            this.Controls.Add(this.lbCTKemTheo);
            this.Controls.Add(this.txtLydoNX);
            this.Controls.Add(this.lbLyDoNX);
            this.Controls.Add(this.txtPTVC);
            this.Controls.Add(this.lbPTVC);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbNguoiNhan);
            this.Controls.Add(this.txtNguoigiaonhan);
            this.Controls.Add(this.lbNguoiGiao);
            this.Controls.Add(this.txtTenkho);
            this.Controls.Add(this.lbKho);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dateEditStockTransaction);
            this.Controls.Add(this.lbSo);
            this.Controls.Add(this.lookUpEditStockTransactionTypeCode);
            this.Controls.Add(this.lbLoaiNX);
            this.Name = "UCAccountTransactionStock";
            this.Size = new System.Drawing.Size(963, 525);
            this.Load += new System.EventHandler(this.UCAccountTransactionStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStockTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoigiaonhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLydoNX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCTKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditDebitAccountCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditCreditAccountCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGetFromStockTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGetFromStockTransaction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceMau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceThueXuat.Properties)).EndInit();
            this.grBoxInvoice.ResumeLayout(false);
            this.grBoxInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHTTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkGiamgia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBeforeTaxAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDonvi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockTransactionNo.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoaiNX;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStockTransactionTypeCode;
        private System.Windows.Forms.Label lbSo;
        private DevExpress.XtraEditors.DateEdit dateEditStockTransaction;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbKho;
        private DevExpress.XtraEditors.TextEdit txtTenkho;
        private System.Windows.Forms.Label lbNguoiGiao;
        private DevExpress.XtraEditors.TextEdit txtNguoigiaonhan;
        private System.Windows.Forms.Label lbNguoiNhan;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbPTVC;
        private DevExpress.XtraEditors.TextEdit txtPTVC;
        private System.Windows.Forms.Label lbLyDoNX;
        private DevExpress.XtraEditors.TextEdit txtLydoNX;
        private System.Windows.Forms.Label lbCTKemTheo;
        private DevExpress.XtraEditors.TextEdit txtCTKT;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAccountCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockInCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAccountCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockOutCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colCostAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription3;
        private System.Windows.Forms.Label lbNguoiVC;
        private DevExpress.XtraEditors.TextEdit txtNguoiVC;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditDebitAccountCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditCreditAccountCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockOut;
        private DevExpress.XtraEditors.CheckEdit chkGetFromStockTransaction;
        private DevExpress.XtraEditors.ButtonEdit btnGetFromStockTransaction;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount11;
        private DevExpress.XtraGrid.Columns.GridColumn colCostPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln0;
        private System.Windows.Forms.Label lbInvoiceMau;
        private DevExpress.XtraEditors.TextEdit txtInvoiceMau;
        private DevExpress.XtraEditors.TextEdit txtInvoiceSeri;
        private System.Windows.Forms.Label lbInvoiceSeri;
        private System.Windows.Forms.Label lbInvoiceNo;
        private DevExpress.XtraEditors.TextEdit txtInvoiceSo;
        private System.Windows.Forms.Label lbInvoiceNgay;
        private DevExpress.XtraEditors.DateEdit dateEditInvoice;
        private DevExpress.XtraEditors.TextEdit txtInvoiceThueXuat;
        private System.Windows.Forms.Label lbInvoiceThueXuat;
        private System.Windows.Forms.GroupBox grBoxInvoice;
        private DevExpress.XtraEditors.ButtonEdit btnEditDonvi;
        private System.Windows.Forms.Button button1;
        public DevExpress.XtraEditors.ButtonEdit txtStockTransactionNo;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditDonVi;
        private DevExpress.XtraEditors.TextEdit txtDiscountDescription;
        private System.Windows.Forms.Label lbDiscountDescription;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private DevExpress.XtraEditors.CheckEdit chkGiamgia;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBeforeTaxAmount;
        private DevExpress.XtraEditors.TextEdit txtTaxAmount;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtInvoiceAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintReport;
        private DevExpress.XtraEditors.TextEdit txtHTTT;
        private System.Windows.Forms.Label lbHTTT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintReportA4;
        private DevExpress.XtraEditors.CheckEdit chkVAT;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnCopyDescription;
        private DevExpress.XtraEditors.SpinEdit txtPaidDays;
        private System.Windows.Forms.Label lblPaidDays;
    }
}
