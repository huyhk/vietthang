namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountStockOpening
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
            this.repLookUpEditStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEditNumDecimaln2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(1, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditItemCode,
            this.repLookUpEditItemName,
            this.repLookUpEditAccount,
            this.repTextEditNumDecimaln2,
            this.repLookUpEditStockCode});
            this.gridControl1.Size = new System.Drawing.Size(683, 352);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockCode,
            this.colItemCode,
            this.colItemName,
            this.colAccountCode,
            this.colQuantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Kho";
            this.colStockCode.ColumnEdit = this.repLookUpEditStockCode;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 0;
            this.colStockCode.Width = 146;
            // 
            // repLookUpEditStockCode
            // 
            this.repLookUpEditStockCode.AutoHeight = false;
            this.repLookUpEditStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 220)});
            this.repLookUpEditStockCode.DisplayMember = "StockName";
            this.repLookUpEditStockCode.Name = "repLookUpEditStockCode";
            this.repLookUpEditStockCode.NullText = "";
            this.repLookUpEditStockCode.PopupWidth = 300;
            this.repLookUpEditStockCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditStockCode.ValueMember = "StockCode";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã hàng";
            this.colItemCode.ColumnEdit = this.repLookUpEditItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 98;
            // 
            // repLookUpEditItemCode
            // 
            this.repLookUpEditItemCode.AutoHeight = false;
            this.repLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên", 220)});
            this.repLookUpEditItemCode.DisplayMember = "ItemCode";
            this.repLookUpEditItemCode.Name = "repLookUpEditItemCode";
            this.repLookUpEditItemCode.NullText = "";
            this.repLookUpEditItemCode.PopupWidth = 300;
            this.repLookUpEditItemCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditItemCode.ValueMember = "ItemCode";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên hàng";
            this.colItemName.ColumnEdit = this.repLookUpEditItemName;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 216;
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
            // colAccountCode
            // 
            this.colAccountCode.Caption = "Tài khoản";
            this.colAccountCode.ColumnEdit = this.repLookUpEditAccount;
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 3;
            this.colAccountCode.Width = 89;
            // 
            // repLookUpEditAccount
            // 
            this.repLookUpEditAccount.AutoHeight = false;
            this.repLookUpEditAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên", 220)});
            this.repLookUpEditAccount.DisplayMember = "AccountCode";
            this.repLookUpEditAccount.Name = "repLookUpEditAccount";
            this.repLookUpEditAccount.NullText = "";
            this.repLookUpEditAccount.PopupWidth = 300;
            this.repLookUpEditAccount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpEditAccount.ValueMember = "AccountCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.repTextEditNumDecimaln2;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 116;
            // 
            // repTextEditNumDecimaln2
            // 
            this.repTextEditNumDecimaln2.AutoHeight = false;
            this.repTextEditNumDecimaln2.Mask.EditMask = "n2";
            this.repTextEditNumDecimaln2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTextEditNumDecimaln2.Mask.UseMaskAsDisplayFormat = true;
            this.repTextEditNumDecimaln2.Name = "repTextEditNumDecimaln2";
            // 
            // FormAccountStockOpening
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 416);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormAccountStockOpening";
            this.Text = "Tồn đầu tài khoản kho hàng ngày:";
            this.Load += new System.EventHandler(this.FormAccountStockOpening_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEditNumDecimaln2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEditNumDecimaln2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditStockCode;
    }
}