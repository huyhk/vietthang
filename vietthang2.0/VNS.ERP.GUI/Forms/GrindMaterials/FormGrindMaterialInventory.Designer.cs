namespace VNS.ERP.GUI
{
    partial class FormGrindMaterialInventory
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupPeriod = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LookupStockLocation = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lbStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupStockLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
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
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(-1, 69);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookupPeriod,
            this.LookupStockLocation,
            this.LookupItem,
            this.LookupItemName});
            this.gridControl.Size = new System.Drawing.Size(714, 230);
            this.gridControl.TabIndex = 17;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colQuantity});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.ColumnEdit = this.LookupItem;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 118;
            // 
            // LookupItem
            // 
            this.LookupItem.AutoHeight = false;
            this.LookupItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã hàng", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên hàng", 200)});
            this.LookupItem.DisplayMember = "ItemCode";
            this.LookupItem.Name = "LookupItem";
            this.LookupItem.NullText = "";
            this.LookupItem.PopupWidth = 300;
            this.LookupItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupItem.ValueMember = "ItemCode";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "ItemName";
            this.colItemName.ColumnEdit = this.LookupItemName;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 419;
            // 
            // LookupItemName
            // 
            this.LookupItemName.AutoHeight = false;
            this.LookupItemName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupItemName.DisplayMember = "ItemName";
            this.LookupItemName.Name = "LookupItemName";
            this.LookupItemName.NullText = "";
            this.LookupItemName.ValueMember = "ItemCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // LookupPeriod
            // 
            this.LookupPeriod.AutoHeight = false;
            this.LookupPeriod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupPeriod.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PeriodCode", "Mã tồn", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StartDate", "Ngày bắt đầu", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.LookupPeriod.DisplayMember = "PeriodCode";
            this.LookupPeriod.Name = "LookupPeriod";
            this.LookupPeriod.NullText = "";
            this.LookupPeriod.ValueMember = "PeriodCode";
            // 
            // LookupStockLocation
            // 
            this.LookupStockLocation.AutoHeight = false;
            this.LookupStockLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupStockLocation.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockLocationCode", "Mã vị trí", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Mô tả", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.LookupStockLocation.DisplayMember = "StockLocationCode";
            this.LookupStockLocation.Name = "LookupStockLocation";
            this.LookupStockLocation.NullText = "";
            this.LookupStockLocation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookupStockLocation.ValueMember = "StockLocationCode";
            // 
            // lookUpStock
            // 
            this.lookUpStock.Location = new System.Drawing.Point(96, 45);
            this.lookUpStock.Name = "lookUpStock";
            this.lookUpStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 200)});
            this.lookUpStock.Properties.DisplayMember = "StockName";
            this.lookUpStock.Properties.NullText = "";
            this.lookUpStock.Properties.PopupWidth = 250;
            this.lookUpStock.Properties.ValueMember = "StockCode";
            this.lookUpStock.Size = new System.Drawing.Size(159, 22);
            this.lookUpStock.TabIndex = 11;
            this.lookUpStock.EditValueChanged += new System.EventHandler(this.lookUpStock_EditValueChanged);
            // 
            // lbStock
            // 
            this.lbStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.Location = new System.Drawing.Point(24, 46);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(70, 21);
            this.lbStock.TabIndex = 12;
            this.lbStock.Text = "Chọn kho";
            this.lbStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormGrindMaterialInventory
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 323);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lookUpStock);
            this.Controls.Add(this.gridControl);
            this.GridControl = this.gridControl;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FormGrindMaterialInventory";
            this.Text = "FormGrindMaterialInventory";
            this.Load += new System.EventHandler(this.FormGrindMaterialInventory_Load);
            this.Controls.SetChildIndex(this.gridControl, 0);
            this.Controls.SetChildIndex(this.lookUpStock, 0);
            this.Controls.SetChildIndex(this.lbStock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupStockLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private System.Windows.Forms.Label lbStock;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupItem;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupPeriod;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupStockLocation;
    }
}