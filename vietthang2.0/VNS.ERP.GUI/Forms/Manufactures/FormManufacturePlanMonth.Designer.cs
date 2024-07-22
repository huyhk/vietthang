namespace VNS.ERP.GUI.Manufactures
{
    partial class FormManufacturePlanMonth
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYearNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonthNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbOutStock = new System.Windows.Forms.Label();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colFormulaCode,
            this.colQuantity,
            this.colDescription1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã TP";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "Công thức";
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 1;
            this.colFormulaCode.Width = 84;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 78;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "Diễn giải";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 3;
            this.colDescription1.Width = 321;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Detail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(5, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(684, 314);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYearNo,
            this.colMonthNo,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colYearNo
            // 
            this.colYearNo.Caption = "Năm";
            this.colYearNo.FieldName = "YearNo";
            this.colYearNo.Name = "colYearNo";
            this.colYearNo.Visible = true;
            this.colYearNo.VisibleIndex = 0;
            // 
            // colMonthNo
            // 
            this.colMonthNo.Caption = "Tháng";
            this.colMonthNo.FieldName = "MonthNo";
            this.colMonthNo.Name = "colMonthNo";
            this.colMonthNo.Visible = true;
            this.colMonthNo.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
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
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // lbOutStock
            // 
            this.lbOutStock.Location = new System.Drawing.Point(6, 45);
            this.lbOutStock.Name = "lbOutStock";
            this.lbOutStock.Size = new System.Drawing.Size(55, 16);
            this.lbOutStock.TabIndex = 7;
            this.lbOutStock.Text = "Nhà máy";
            this.lbOutStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStock
            // 
            this.lookUpStock.EnterMoveNextControl = true;
            this.lookUpStock.Location = new System.Drawing.Point(66, 44);
            this.lookUpStock.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpStock.Name = "lookUpStock";
            this.lookUpStock.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 200)});
            this.lookUpStock.Properties.DisplayMember = "StockName";
            this.lookUpStock.Properties.NullText = "";
            this.lookUpStock.Properties.PopupWidth = 250;
            this.lookUpStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStock.Properties.ValueMember = "StockCode";
            this.lookUpStock.Size = new System.Drawing.Size(151, 22);
            this.lookUpStock.TabIndex = 6;
            this.lookUpStock.EditValueChanged += new System.EventHandler(this.lookUpStock_EditValueChanged);
            // 
            // FormManufacturePlanMonth
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 411);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbOutStock);
            this.Controls.Add(this.lookUpStock);
            this.GridControl = this.gridControl1;
            this.Name = "FormManufacturePlanMonth";
            this.Text = "FormManufacturePlanMonth";
            this.Load += new System.EventHandler(this.FormManufacturePlanMonth_Load);
            this.Controls.SetChildIndex(this.lookUpStock, 0);
            this.Controls.SetChildIndex(this.lbOutStock, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOutStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colYearNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
    }
}