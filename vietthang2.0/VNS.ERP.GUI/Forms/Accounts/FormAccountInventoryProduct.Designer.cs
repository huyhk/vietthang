namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountInventoryProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantityAccountStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lookUpEditDate = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
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
            this.textEdit1.EditValue = "6321";
            this.textEdit1.Location = new System.Drawing.Point(395, 46);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(43, 20);
            this.textEdit1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tài khoản";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditItemCode,
            this.repLookUpEditItemName,
            this.repLookUpEditAccount,
            this.repTextEditNumDecimaln2,
            this.repLookUpEditStockCode});
            this.gridControl1.Size = new System.Drawing.Size(800, 337);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockName,
            this.colItemCode,
            this.colItemName,
            this.colQuantityStock,
            this.colQuantityAccountStock,
            this.colInventory});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStockName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Tên kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.ReadOnly = true;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 0;
            this.colStockName.Width = 144;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã hàng";
            this.colItemCode.FieldName = "ItemCode";
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
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 241;
            // 
            // colQuantityStock
            // 
            this.colQuantityStock.Caption = "Tồn kho";
            this.colQuantityStock.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colQuantityStock.FieldName = "QuantityStock";
            this.colQuantityStock.Name = "colQuantityStock";
            this.colQuantityStock.OptionsColumn.ReadOnly = true;
            this.colQuantityStock.Visible = true;
            this.colQuantityStock.VisibleIndex = 2;
            this.colQuantityStock.Width = 129;
            // 
            // repTextEditNumDecimaln2
            // 
            this.repTextEditNumDecimaln2.AutoHeight = false;
            this.repTextEditNumDecimaln2.Mask.EditMask = "n2";
            this.repTextEditNumDecimaln2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln2.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln2.Name = "repTextEditNumDecimaln2";
            // 
            // colQuantityAccountStock
            // 
            this.colQuantityAccountStock.Caption = "Tồn kho kế toán";
            this.colQuantityAccountStock.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colQuantityAccountStock.FieldName = "QuantityAccountStock";
            this.colQuantityAccountStock.Name = "colQuantityAccountStock";
            this.colQuantityAccountStock.OptionsColumn.ReadOnly = true;
            this.colQuantityAccountStock.Visible = true;
            this.colQuantityAccountStock.VisibleIndex = 3;
            this.colQuantityAccountStock.Width = 113;
            // 
            // colInventory
            // 
            this.colInventory.Caption = "Kiểm kê";
            this.colInventory.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colInventory.FieldName = "Inventory";
            this.colInventory.Name = "colInventory";
            this.colInventory.Visible = true;
            this.colInventory.VisibleIndex = 4;
            this.colInventory.Width = 112;
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
            // lookUpEditDate
            // 
            this.lookUpEditDate.Location = new System.Drawing.Point(107, 45);
            this.lookUpEditDate.Name = "lookUpEditDate";
            this.lookUpEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpEditDate.Properties.DisplayMember = "Description";
            this.lookUpEditDate.Properties.NullText = "";
            this.lookUpEditDate.Properties.ShowHeader = false;
            this.lookUpEditDate.Properties.ValueMember = "EndDate";
            this.lookUpEditDate.Size = new System.Drawing.Size(222, 20);
            this.lookUpEditDate.TabIndex = 14;
            this.lookUpEditDate.EditValueChanged += new System.EventHandler(this.lookUpEditDate_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kỳ kế toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.Location = new System.Drawing.Point(600, 412);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(206, 26);
            this.btnProduct.TabIndex = 18;
            this.btnProduct.Text = "Tạo phiếu nhập thành phẩm sản xuất";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(672, 46);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 20);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy tồn Module kho";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbStockCode
            // 
            this.lbStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStockCode.Location = new System.Drawing.Point(382, 417);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(68, 16);
            this.lbStockCode.TabIndex = 21;
            this.lbStockCode.Text = "Chọn kho";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpStockCode.Location = new System.Drawing.Point(454, 415);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(142, 22);
            this.lookUpStockCode.TabIndex = 20;
            // 
            // FormAccountInventoryProduct
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lookUpEditDate);
            this.Controls.Add(this.label1);
            this.Name = "FormAccountInventoryProduct";
            this.Text = "Kiểm kê kho thành phẩm";
            this.Load += new System.EventHandler(this.FormAccountInventoryProduct_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lookUpEditDate, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.btnProduct, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.lbStockCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityAccountStock;
        private DevExpress.XtraGrid.Columns.GridColumn colInventory;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
    }
}