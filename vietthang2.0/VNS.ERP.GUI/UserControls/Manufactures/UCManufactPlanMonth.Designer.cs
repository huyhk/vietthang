namespace VNS.ERP.GUI.Manufactures
{
    partial class UCManufactPlanMonth
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
            this.lbOutStock = new System.Windows.Forms.Label();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lbYearNo = new System.Windows.Forms.Label();
            this.lbMonthNo = new System.Windows.Forms.Label();
            this.numUpDnMonthNo = new System.Windows.Forms.NumericUpDown();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reLookUpEditFormula = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTextEditQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtYearNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMonthNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOutStock
            // 
            this.lbOutStock.Location = new System.Drawing.Point(3, 2);
            this.lbOutStock.Name = "lbOutStock";
            this.lbOutStock.Size = new System.Drawing.Size(55, 16);
            this.lbOutStock.TabIndex = 5;
            this.lbOutStock.Text = "Nhà máy";
            this.lbOutStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStock
            // 
            this.lookUpStock.Location = new System.Drawing.Point(63, 2);
            this.lookUpStock.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpStock.Name = "lookUpStock";
            this.lookUpStock.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã kho", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên kho", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpStock.Properties.DisplayMember = "StockName";
            this.lookUpStock.Properties.NullText = "";
            this.lookUpStock.Properties.ReadOnly = true;
            this.lookUpStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStock.Properties.ValueMember = "StockCode";
            this.lookUpStock.Size = new System.Drawing.Size(151, 22);
            this.lookUpStock.TabIndex = 0;
            // 
            // lbYearNo
            // 
            this.lbYearNo.Location = new System.Drawing.Point(221, 2);
            this.lbYearNo.Name = "lbYearNo";
            this.lbYearNo.Size = new System.Drawing.Size(43, 16);
            this.lbYearNo.TabIndex = 6;
            this.lbYearNo.Text = "Năm";
            this.lbYearNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMonthNo
            // 
            this.lbMonthNo.Location = new System.Drawing.Point(316, 2);
            this.lbMonthNo.Name = "lbMonthNo";
            this.lbMonthNo.Size = new System.Drawing.Size(43, 16);
            this.lbMonthNo.TabIndex = 7;
            this.lbMonthNo.Text = "Tháng";
            this.lbMonthNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numUpDnMonthNo
            // 
            this.numUpDnMonthNo.Location = new System.Drawing.Point(365, 2);
            this.numUpDnMonthNo.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDnMonthNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnMonthNo.Name = "numUpDnMonthNo";
            this.numUpDnMonthNo.Size = new System.Drawing.Size(35, 20);
            this.numUpDnMonthNo.TabIndex = 2;
            this.numUpDnMonthNo.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(63, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(468, 42);
            this.txtDescription.TabIndex = 3;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(-25, 36);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(82, 16);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reLookUpEditItemCode,
            this.reLookUpEditItemName,
            this.reLookUpEditFormula,
            this.reTextEditQuantity});
            this.gridControl1.Size = new System.Drawing.Size(731, 264);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colFormulaCode,
            this.colQuantity,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã thành phẩm";
            this.colItemCode.ColumnEdit = this.reLookUpEditItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 113;
            // 
            // reLookUpEditItemCode
            // 
            this.reLookUpEditItemCode.AutoHeight = false;
            this.reLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã TP", 75),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên TP", 225)});
            this.reLookUpEditItemCode.DisplayMember = "ItemCode";
            this.reLookUpEditItemCode.Name = "reLookUpEditItemCode";
            this.reLookUpEditItemCode.NullText = "";
            this.reLookUpEditItemCode.PopupWidth = 300;
            this.reLookUpEditItemCode.ValueMember = "ItemCode";
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên Thành phẩm";
            this.colItemName.ColumnEdit = this.reLookUpEditItemName;
            this.colItemName.FieldName = "ItemCode";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsColumn.AllowFocus = false;
            this.colItemName.OptionsColumn.ReadOnly = true;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 186;
            // 
            // reLookUpEditItemName
            // 
            this.reLookUpEditItemName.AutoHeight = false;
            this.reLookUpEditItemName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reLookUpEditItemName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.reLookUpEditItemName.DisplayMember = "ItemName";
            this.reLookUpEditItemName.Name = "reLookUpEditItemName";
            this.reLookUpEditItemName.NullText = "";
            this.reLookUpEditItemName.ValueMember = "ItemCode";
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "Công thức";
            this.colFormulaCode.ColumnEdit = this.reLookUpEditFormula;
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 2;
            this.colFormulaCode.Width = 129;
            // 
            // reLookUpEditFormula
            // 
            this.reLookUpEditFormula.AutoHeight = false;
            this.reLookUpEditFormula.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F12), "F12")});
            this.reLookUpEditFormula.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormulaCode", "Mã CT", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải", 220)});
            this.reLookUpEditFormula.DisplayMember = "FormulaCode";
            this.reLookUpEditFormula.Name = "reLookUpEditFormula";
            this.reLookUpEditFormula.NullText = "";
            this.reLookUpEditFormula.PopupWidth = 300;
            this.reLookUpEditFormula.ValueMember = "FormulaCode";
            this.reLookUpEditFormula.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.reLookUpEditFormula_ButtonClick);
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.reTextEditQuantity;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.SummaryItem.DisplayFormat = "{0:n0}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 117;
            // 
            // reTextEditQuantity
            // 
            this.reTextEditQuantity.AutoHeight = false;
            this.reTextEditQuantity.Mask.EditMask = "n0";
            this.reTextEditQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reTextEditQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.reTextEditQuantity.Name = "reTextEditQuantity";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 343;
            // 
            // TxtYearNo
            // 
            this.TxtYearNo.EditValue = "2007";
            this.TxtYearNo.Location = new System.Drawing.Point(270, 2);
            this.TxtYearNo.Name = "TxtYearNo";
            this.TxtYearNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearNo.Properties.Appearance.Options.UseFont = true;
            this.TxtYearNo.Properties.EditFormat.FormatString = "9";
            this.TxtYearNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtYearNo.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?";
            this.TxtYearNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TxtYearNo.Properties.Mask.PlaceHolder = '\0';
            this.TxtYearNo.Properties.Mask.ShowPlaceHolders = false;
            this.TxtYearNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtYearNo.Properties.MaxLength = 20;
            this.TxtYearNo.Size = new System.Drawing.Size(40, 22);
            this.TxtYearNo.TabIndex = 1;
            // 
            // UCManufactPlanMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtYearNo);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.numUpDnMonthNo);
            this.Controls.Add(this.lbMonthNo);
            this.Controls.Add(this.lbYearNo);
            this.Controls.Add(this.lbOutStock);
            this.Controls.Add(this.lookUpStock);
            this.Name = "UCManufactPlanMonth";
            this.Size = new System.Drawing.Size(742, 341);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMonthNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOutStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private System.Windows.Forms.Label lbYearNo;
        private System.Windows.Forms.Label lbMonthNo;
        private System.Windows.Forms.NumericUpDown numUpDnMonthNo;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditFormula;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reTextEditQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.TextEdit TxtYearNo;
    }
}
