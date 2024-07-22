namespace VNS.ERP.GUI
{
    partial class FormInstrumentOpening
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
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTextEditQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTextEditAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditAmount)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(1, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpItemCode,
            this.repLookUpEditItemCode,
            this.repItemTextEditQuantity,
            this.repItemTextEditAmount});
            this.gridControl1.Size = new System.Drawing.Size(779, 319);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colQuantity,
            this.colAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã";
            this.colItemCode.ColumnEdit = this.repLookUpEditItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 107;
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
            // colItemName
            // 
            this.colItemName.Caption = "Tên";
            this.colItemName.ColumnEdit = this.repItemLookUpItemCode;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 212;
            // 
            // repItemLookUpItemCode
            // 
            this.repItemLookUpItemCode.AutoHeight = false;
            this.repItemLookUpItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.repItemLookUpItemCode.DisplayMember = "ItemName";
            this.repItemLookUpItemCode.Name = "repItemLookUpItemCode";
            this.repItemLookUpItemCode.NullText = "";
            this.repItemLookUpItemCode.ValueMember = "ItemCode";
            this.repItemLookUpItemCode.EditValueChanged += new System.EventHandler(this.repLookUpEditItemCode_EditValueChanged);
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.repItemTextEditQuantity;
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 212;
            // 
            // repItemTextEditQuantity
            // 
            this.repItemTextEditQuantity.AutoHeight = false;
            this.repItemTextEditQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditQuantity.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditQuantity.Mask.EditMask = "n0";
            this.repItemTextEditQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repItemTextEditQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.repItemTextEditQuantity.Name = "repItemTextEditQuantity";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tiền";
            this.colAmount.ColumnEdit = this.repItemTextEditAmount;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 218;
            // 
            // repItemTextEditAmount
            // 
            this.repItemTextEditAmount.AutoHeight = false;
            this.repItemTextEditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditAmount.Mask.EditMask = "n0";
            this.repItemTextEditAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repItemTextEditAmount.Name = "repItemTextEditAmount";
            // 
            // lbStockCode
            // 
            this.lbStockCode.AutoSize = true;
            this.lbStockCode.Location = new System.Drawing.Point(56, 49);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(25, 13);
            this.lbStockCode.TabIndex = 10;
            this.lbStockCode.Text = "Kho";
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(84, 44);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 220)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 300;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(142, 22);
            this.lookUpStockCode.TabIndex = 0;
            this.lookUpStockCode.EditValueChanged += new System.EventHandler(this.lookUpStockCode_EditValueChanged);
            // 
            // FormInstrumentOpening
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 413);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormInstrumentOpening";
            this.Text = "FormInstrumentOpening";
            this.Load += new System.EventHandler(this.FormInstrumentOpening_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lookUpStockCode, 0);
            this.Controls.SetChildIndex(this.lbStockCode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lbStockCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEditQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEditAmount;
    }
}