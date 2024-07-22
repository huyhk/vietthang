namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountInventoryMaterial
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
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantityAccountStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInventory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChenhlech = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repLookUpEditStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lookUpEditDate = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnFuel = new System.Windows.Forms.Button();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.btnWrappingMaterial = new System.Windows.Forms.Button();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnWrappingPE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(6, 71);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditItemCode,
            this.repLookUpEditItemName,
            this.repLookUpEditAccount,
            this.repTextEditNumDecimaln2,
            this.repLookUpEditStockCode});
            this.gridControl1.Size = new System.Drawing.Size(1009, 323);
            this.gridControl1.TabIndex = 10;
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
            this.colInventory,
            this.colChenhlech});
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
            this.colQuantityAccountStock.Width = 119;
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
            // colChenhlech
            // 
            this.colChenhlech.Caption = "Chênh lệch";
            this.colChenhlech.FieldName = "Chenhlech";
            this.colChenhlech.Name = "colChenhlech";
            this.colChenhlech.OptionsColumn.AllowEdit = false;
            this.colChenhlech.Visible = true;
            this.colChenhlech.VisibleIndex = 5;
            // 
            // repLookUpEditItemCode
            // 
            this.repLookUpEditItemCode.AutoHeight = false;
            this.repLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên")});
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName")});
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên")});
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên")});
            this.repLookUpEditStockCode.DisplayMember = "SubjectName";
            this.repLookUpEditStockCode.Name = "repLookUpEditStockCode";
            this.repLookUpEditStockCode.NullText = "";
            this.repLookUpEditStockCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditStockCode.ValueMember = "SubjectCode";
            // 
            // lookUpEditDate
            // 
            this.lookUpEditDate.EnterMoveNextControl = true;
            this.lookUpEditDate.Location = new System.Drawing.Point(107, 44);
            this.lookUpEditDate.Name = "lookUpEditDate";
            this.lookUpEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
            this.lookUpEditDate.Properties.DisplayMember = "Description";
            this.lookUpEditDate.Properties.NullText = "";
            this.lookUpEditDate.Properties.ShowHeader = false;
            this.lookUpEditDate.Properties.ValueMember = "EndDate";
            this.lookUpEditDate.Size = new System.Drawing.Size(222, 20);
            this.lookUpEditDate.TabIndex = 9;
            this.lookUpEditDate.EditValueChanged += new System.EventHandler(this.lookUpEditDate_EditValueChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(45, 46);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 13);
            this.lbTime.TabIndex = 8;
            this.lbTime.Text = "Kỳ kế toán";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(337, 47);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(53, 13);
            this.lbAccount.TabIndex = 11;
            this.lbAccount.Text = "Tài khoản";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "6111";
            this.textEdit1.Location = new System.Drawing.Point(395, 45);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(43, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(874, 46);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(141, 20);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "Copy tồn module kho";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterial.Location = new System.Drawing.Point(686, 400);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(170, 26);
            this.btnMaterial.TabIndex = 14;
            this.btnMaterial.Text = "Tạo phiếu xuất nguyên liệu SX";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuel.Location = new System.Drawing.Point(862, 400);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(153, 26);
            this.btnFuel.TabIndex = 15;
            this.btnFuel.Text = "Tạo phiếu xuất nhiên liệu SX";
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // lbStockCode
            // 
            this.lbStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStockCode.Location = new System.Drawing.Point(91, 405);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(68, 16);
            this.lbStockCode.TabIndex = 17;
            this.lbStockCode.Text = "Chọn kho";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpStockCode.Location = new System.Drawing.Point(165, 402);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho")});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(142, 22);
            this.lookUpStockCode.TabIndex = 16;
            // 
            // btnWrappingMaterial
            // 
            this.btnWrappingMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrappingMaterial.Location = new System.Drawing.Point(510, 400);
            this.btnWrappingMaterial.Name = "btnWrappingMaterial";
            this.btnWrappingMaterial.Size = new System.Drawing.Size(170, 26);
            this.btnWrappingMaterial.TabIndex = 18;
            this.btnWrappingMaterial.Text = "Tạo phiếu xuất bao bì NL SX";
            this.btnWrappingMaterial.UseVisualStyleBackColor = true;
            this.btnWrappingMaterial.Click += new System.EventHandler(this.btnWrappingMaterial_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcel.Location = new System.Drawing.Point(12, 400);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 105;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnWrappingPE
            // 
            this.btnWrappingPE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrappingPE.Location = new System.Drawing.Point(334, 399);
            this.btnWrappingPE.Name = "btnWrappingPE";
            this.btnWrappingPE.Size = new System.Drawing.Size(170, 26);
            this.btnWrappingPE.TabIndex = 106;
            this.btnWrappingPE.Text = "Tạo phiếu xuất bao bì PE";
            this.btnWrappingPE.UseVisualStyleBackColor = true;
            this.btnWrappingPE.Click += new System.EventHandler(this.btnWrappingPE_Click);
            // 
            // FormAccountInventoryMaterial
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 455);
            this.Controls.Add(this.btnWrappingPE);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWrappingMaterial);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lookUpEditDate);
            this.Controls.Add(this.lbTime);
            this.Name = "FormAccountInventoryMaterial";
            this.Text = "Kiểm kê cuối kỳ kho nguyên liệu";
            this.Load += new System.EventHandler(this.FormAccountInventoryMaterial_Load);
            this.Controls.SetChildIndex(this.lbTime, 0);
            this.Controls.SetChildIndex(this.lookUpEditDate, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lbAccount, 0);
            this.Controls.SetChildIndex(this.textEdit1, 0);
            this.Controls.SetChildIndex(this.btnCopy, 0);
            this.Controls.SetChildIndex(this.btnMaterial, 0);
            this.Controls.SetChildIndex(this.btnFuel, 0);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.lbStockCode, 0);
            this.Controls.SetChildIndex(this.btnWrappingMaterial, 0);
            this.Controls.SetChildIndex(this.btnExcel, 0);
            this.Controls.SetChildIndex(this.btnWrappingPE, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityStock;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityAccountStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbAccount;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnFuel;
        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Button btnWrappingMaterial;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colChenhlech;
        private System.Windows.Forms.Button btnWrappingPE;
    }
}