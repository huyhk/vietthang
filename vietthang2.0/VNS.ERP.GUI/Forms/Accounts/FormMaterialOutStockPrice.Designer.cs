namespace VNS.ERP.GUI.Accounting
{
    partial class FormMaterialOutStockPrice
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lookUpEditDate = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTime = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colOpenAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln0 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colInQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAvgPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).BeginInit();
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(392, 45);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(43, 20);
            this.textEdit1.TabIndex = 16;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(334, 47);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(53, 13);
            this.lbAccount.TabIndex = 15;
            this.lbAccount.Text = "Tài khoản";
            // 
            // lookUpEditDate
            // 
            this.lookUpEditDate.Location = new System.Drawing.Point(104, 44);
            this.lookUpEditDate.Name = "lookUpEditDate";
            this.lookUpEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpEditDate.Properties.DisplayMember = "Description";
            this.lookUpEditDate.Properties.NullText = "";
            this.lookUpEditDate.Properties.ShowHeader = false;
            this.lookUpEditDate.Properties.ValueMember = "PeriodCode";
            this.lookUpEditDate.Size = new System.Drawing.Size(222, 20);
            this.lookUpEditDate.TabIndex = 14;
            this.lookUpEditDate.EditValueChanged += new System.EventHandler(this.lookUpEditDate_EditValueChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(40, 47);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 13);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Kỳ kế toán";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditItemCode,
            this.repLookUpEditItemName,
            this.repLookUpEditAccount,
            this.repTextEditNumDecimaln2,
            this.repLookUpEditStockCode,
            this.repTextEditNumDecimaln0});
            this.gridControl1.Size = new System.Drawing.Size(842, 335);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colOpenQuantity,
            this.colOpenAmount,
            this.colInQuantity,
            this.colInAmount,
            this.colOutQuantity,
            this.colOutAmount,
            this.colCloseQuantity,
            this.colCloseAmount,
            this.colAvgPrice,
            this.colClosePrice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã hàng";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.ReadOnly = true;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 109;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên hàng";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 241;
            // 
            // colOpenQuantity
            // 
            this.colOpenQuantity.Caption = "SL đầu kỳ";
            this.colOpenQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colOpenQuantity.FieldName = "OpenQuantity";
            this.colOpenQuantity.Name = "colOpenQuantity";
            this.colOpenQuantity.OptionsColumn.ReadOnly = true;
            this.colOpenQuantity.Visible = true;
            this.colOpenQuantity.VisibleIndex = 2;
            this.colOpenQuantity.Width = 129;
            // 
            // repTextEditNumDecimaln2
            // 
            this.repTextEditNumDecimaln2.AutoHeight = false;
            this.repTextEditNumDecimaln2.Mask.EditMask = "n2";
            this.repTextEditNumDecimaln2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln2.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln2.Name = "repTextEditNumDecimaln2";
            // 
            // colOpenAmount
            // 
            this.colOpenAmount.Caption = "Thành tiền đầu kỳ";
            this.colOpenAmount.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colOpenAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOpenAmount.FieldName = "OpenAmount";
            this.colOpenAmount.Name = "colOpenAmount";
            this.colOpenAmount.OptionsColumn.ReadOnly = true;
            this.colOpenAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOpenAmount.Visible = true;
            this.colOpenAmount.VisibleIndex = 3;
            this.colOpenAmount.Width = 96;
            // 
            // repTextEditNumDecimaln0
            // 
            this.repTextEditNumDecimaln0.AutoHeight = false;
            this.repTextEditNumDecimaln0.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTextEditNumDecimaln0.Mask.EditMask = "n0";
            this.repTextEditNumDecimaln0.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln0.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln0.Name = "repTextEditNumDecimaln0";
            // 
            // colInQuantity
            // 
            this.colInQuantity.Caption = "SL nhập trong kỳ";
            this.colInQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colInQuantity.FieldName = "InQuantity";
            this.colInQuantity.Name = "colInQuantity";
            this.colInQuantity.OptionsColumn.ReadOnly = true;
            this.colInQuantity.Visible = true;
            this.colInQuantity.VisibleIndex = 4;
            this.colInQuantity.Width = 112;
            // 
            // colInAmount
            // 
            this.colInAmount.Caption = "Tiền nhập trong kỳ";
            this.colInAmount.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colInAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colInAmount.FieldName = "InAmount";
            this.colInAmount.Name = "colInAmount";
            this.colInAmount.OptionsColumn.ReadOnly = true;
            this.colInAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colInAmount.Visible = true;
            this.colInAmount.VisibleIndex = 5;
            // 
            // colOutQuantity
            // 
            this.colOutQuantity.Caption = "SL xuất trong kỳ";
            this.colOutQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colOutQuantity.FieldName = "OutQuantity";
            this.colOutQuantity.Name = "colOutQuantity";
            this.colOutQuantity.OptionsColumn.ReadOnly = true;
            this.colOutQuantity.Visible = true;
            this.colOutQuantity.VisibleIndex = 6;
            // 
            // colOutAmount
            // 
            this.colOutAmount.Caption = "Tiền xuất trong kỳ";
            this.colOutAmount.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colOutAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutAmount.FieldName = "OutAmount";
            this.colOutAmount.Name = "colOutAmount";
            this.colOutAmount.OptionsColumn.ReadOnly = true;
            this.colOutAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOutAmount.Visible = true;
            this.colOutAmount.VisibleIndex = 7;
            // 
            // colCloseQuantity
            // 
            this.colCloseQuantity.Caption = "SL tồn";
            this.colCloseQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colCloseQuantity.FieldName = "CloseQuantity";
            this.colCloseQuantity.Name = "colCloseQuantity";
            this.colCloseQuantity.OptionsColumn.ReadOnly = true;
            this.colCloseQuantity.Visible = true;
            this.colCloseQuantity.VisibleIndex = 8;
            // 
            // colCloseAmount
            // 
            this.colCloseAmount.Caption = "Tiền tồn";
            this.colCloseAmount.ColumnEdit = this.repTextEditNumDecimaln0;
            this.colCloseAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCloseAmount.FieldName = "CloseAmount";
            this.colCloseAmount.Name = "colCloseAmount";
            this.colCloseAmount.OptionsColumn.ReadOnly = true;
            this.colCloseAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCloseAmount.Visible = true;
            this.colCloseAmount.VisibleIndex = 9;
            // 
            // colAvgPrice
            // 
            this.colAvgPrice.Caption = "Giá bình quân";
            this.colAvgPrice.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colAvgPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAvgPrice.FieldName = "AvgPrice";
            this.colAvgPrice.Name = "colAvgPrice";
            this.colAvgPrice.OptionsColumn.ReadOnly = true;
            this.colAvgPrice.Visible = true;
            this.colAvgPrice.VisibleIndex = 10;
            // 
            // colClosePrice
            // 
            this.colClosePrice.Caption = "Giá cuối kỳ";
            this.colClosePrice.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colClosePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colClosePrice.FieldName = "ClosePrice";
            this.colClosePrice.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colClosePrice.Name = "colClosePrice";
            this.colClosePrice.OptionsColumn.ReadOnly = true;
            this.colClosePrice.Visible = true;
            this.colClosePrice.VisibleIndex = 11;
            // 
            // repLookUpEditItemCode
            // 
            this.repLookUpEditItemCode.AutoHeight = false;
            this.repLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditItemCode.DisplayMember = "ItemCode";
            this.repLookUpEditItemCode.Name = "repLookUpEditItemCode";
            this.repLookUpEditItemCode.NullText = "";
            this.repLookUpEditItemCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditItemCode.ValueMember = "ItemCode";
            // 
            // repLookUpEditItemName
            // 
            this.repLookUpEditItemName.AutoHeight = false;
            this.repLookUpEditItemName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.repLookUpEditItemName.DisplayMember = "ItemName";
            this.repLookUpEditItemName.Name = "repLookUpEditItemName";
            this.repLookUpEditItemName.NullText = "";
            this.repLookUpEditItemName.ValueMember = "ItemCode";
            // 
            // repLookUpEditAccount
            // 
            this.repLookUpEditAccount.AutoHeight = false;
            this.repLookUpEditAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditAccount.DisplayMember = "AccountCode";
            this.repLookUpEditAccount.Name = "repLookUpEditAccount";
            this.repLookUpEditAccount.NullText = "";
            this.repLookUpEditAccount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditAccount.ValueMember = "AccountCode";
            // 
            // repLookUpEditStockCode
            // 
            this.repLookUpEditStockCode.AutoHeight = false;
            this.repLookUpEditStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repLookUpEditStockCode.DisplayMember = "SubjectName";
            this.repLookUpEditStockCode.Name = "repLookUpEditStockCode";
            this.repLookUpEditStockCode.NullText = "";
            this.repLookUpEditStockCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditStockCode.ValueMember = "SubjectCode";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(693, 44);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(155, 21);
            this.btnCopy.TabIndex = 18;
            this.btnCopy.Text = "Giá bình quân -> Giá cuối kỳ";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(679, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 26);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Cập nhật giá xuất kho sản xuất";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate1.Location = new System.Drawing.Point(506, 409);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(171, 26);
            this.btnUpdate1.TabIndex = 20;
            this.btnUpdate1.Text = "Cập nhật hệ số tính giá thành";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 409);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(59, 26);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FormMaterialOutStockPrice
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 464);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnUpdate1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lookUpEditDate);
            this.Controls.Add(this.lbTime);
            this.Name = "FormMaterialOutStockPrice";
            this.Text = "Tính giá xuất kho nguyên liệu";
            this.Load += new System.EventHandler(this.FormMaterialOutStockPrice_Load);
            this.Controls.SetChildIndex(this.lbTime, 0);
            this.Controls.SetChildIndex(this.lookUpEditDate, 0);
            this.Controls.SetChildIndex(this.lbAccount, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnUpdate1, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label lbAccount;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDate;
        private System.Windows.Forms.Label lbTime;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln2;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colInQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colInAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colOutQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colOutAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAvgPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colClosePrice;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdate1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln0;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
    }
}
