namespace VNS.ERP.GUI.Sales
{
    partial class FormItemSalePrice
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
            this.ucItemSalePrice1 = new VNS.ERP.GUI.UserControls.Sales.UCItemSalePrice();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // ucItemSalePrice1
            // 
            this.ucItemSalePrice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucItemSalePrice1.Business = null;
            this.ucItemSalePrice1.DataSource = null;
            this.ucItemSalePrice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucItemSalePrice1.Location = new System.Drawing.Point(390, 320);
            this.ucItemSalePrice1.Name = "ucItemSalePrice1";
            this.ucItemSalePrice1.Size = new System.Drawing.Size(407, 75);
            this.ucItemSalePrice1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(4, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(380, 351);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã sản phẩm";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên sản phẩm";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 271;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(390, 43);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(462, 271);
            this.gridControl2.TabIndex = 8;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colSalePrice,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày";
            this.colStartDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 0;
            this.colStartDate.Width = 88;
            // 
            // colSalePrice
            // 
            this.colSalePrice.Caption = "Giá bán";
            this.colSalePrice.DisplayFormat.FormatString = "n2";
            this.colSalePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalePrice.FieldName = "SalePrice";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.Visible = true;
            this.colSalePrice.VisibleIndex = 1;
            this.colSalePrice.Width = 108;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 310;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // FormItemSalePrice
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 428);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucItemSalePrice1);
            this.EditControl = this.ucItemSalePrice1;
            this.GridControl = this.gridControl2;
            this.Name = "FormItemSalePrice";
            this.Text = "Danh mục giá bán thành phẩm";
            this.Load += new System.EventHandler(this.FormItemSalePrice_Load);
            this.Controls.SetChildIndex(this.ucItemSalePrice1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.gridControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.Sales.UCItemSalePrice ucItemSalePrice1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
    }
}