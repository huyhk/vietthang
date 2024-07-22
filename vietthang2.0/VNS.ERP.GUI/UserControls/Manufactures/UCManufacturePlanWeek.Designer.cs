namespace VNS.ERP.GUI.Manufactures
{
    partial class UCManufacturePlanWeek
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
            this.reLookUpEditItemName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reLookUpEditFormula = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.reLookUpEditItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TxtYearNo = new DevExpress.XtraEditors.TextEdit();
            this.colDay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTextEditQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbWeekNo = new System.Windows.Forms.Label();
            this.lbYearNo = new System.Windows.Forms.Label();
            this.lbOutStock = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDay2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStartDate = new DevExpress.XtraEditors.TextEdit();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtEndDate = new DevExpress.XtraEditors.TextEdit();
            this.numUpDnWeekNo = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnWeekNo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.colFormulaCode.Width = 119;
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
            // reLookUpEditItemCode
            // 
            this.reLookUpEditItemCode.AutoHeight = false;
            this.reLookUpEditItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reLookUpEditItemCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã TP", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên TP", 220)});
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
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 10;
            this.colDescription.Width = 343;
            // 
            // TxtYearNo
            // 
            this.TxtYearNo.EditValue = "2007";
            this.TxtYearNo.Location = new System.Drawing.Point(272, 4);
            this.TxtYearNo.Name = "TxtYearNo";
            this.TxtYearNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearNo.Properties.Appearance.Options.UseFont = true;
            this.TxtYearNo.Properties.EditFormat.FormatString = "9";
            this.TxtYearNo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtYearNo.Properties.Mask.EditMask = "f0";
            this.TxtYearNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtYearNo.Properties.Mask.PlaceHolder = '\0';
            this.TxtYearNo.Properties.Mask.ShowPlaceHolders = false;
            this.TxtYearNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtYearNo.Properties.MaxLength = 20;
            this.TxtYearNo.Size = new System.Drawing.Size(40, 22);
            this.TxtYearNo.TabIndex = 10;
            this.TxtYearNo.EditValueChanged += new System.EventHandler(this.TxtYearNo_EditValueChanged);
            // 
            // colDay1
            // 
            this.colDay1.Caption = "Thứ 2";
            this.colDay1.ColumnEdit = this.reTextEditQuantity;
            this.colDay1.FieldName = "Day1";
            this.colDay1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colDay1.Name = "colDay1";
            this.colDay1.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay1.Visible = true;
            this.colDay1.VisibleIndex = 3;
            this.colDay1.Width = 117;
            // 
            // reTextEditQuantity
            // 
            this.reTextEditQuantity.AutoHeight = false;
            this.reTextEditQuantity.Mask.EditMask = "n0";
            this.reTextEditQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.reTextEditQuantity.Mask.UseMaskAsDisplayFormat = true;
            this.reTextEditQuantity.Name = "reTextEditQuantity";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã thành phẩm";
            this.colItemCode.ColumnEdit = this.reLookUpEditItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 99;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(65, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(468, 42);
            this.txtDescription.TabIndex = 12;
            // 
            // lbWeekNo
            // 
            this.lbWeekNo.Location = new System.Drawing.Point(318, 4);
            this.lbWeekNo.Name = "lbWeekNo";
            this.lbWeekNo.Size = new System.Drawing.Size(43, 16);
            this.lbWeekNo.TabIndex = 16;
            this.lbWeekNo.Text = "Tuần";
            this.lbWeekNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbYearNo
            // 
            this.lbYearNo.Location = new System.Drawing.Point(223, 4);
            this.lbYearNo.Name = "lbYearNo";
            this.lbYearNo.Size = new System.Drawing.Size(43, 16);
            this.lbYearNo.TabIndex = 15;
            this.lbYearNo.Text = "Năm";
            this.lbYearNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbOutStock
            // 
            this.lbOutStock.Location = new System.Drawing.Point(5, 4);
            this.lbOutStock.Name = "lbOutStock";
            this.lbOutStock.Size = new System.Drawing.Size(55, 16);
            this.lbOutStock.TabIndex = 14;
            this.lbOutStock.Text = "Nhà máy";
            this.lbOutStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(8, 74);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reLookUpEditItemCode,
            this.reLookUpEditItemName,
            this.reLookUpEditFormula,
            this.reTextEditQuantity});
            this.gridControl1.Size = new System.Drawing.Size(831, 264);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName,
            this.colFormulaCode,
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDay2
            // 
            this.colDay2.Caption = "Thứ 3";
            this.colDay2.ColumnEdit = this.reTextEditQuantity;
            this.colDay2.FieldName = "Day2";
            this.colDay2.Name = "colDay2";
            this.colDay2.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay2.Visible = true;
            this.colDay2.VisibleIndex = 4;
            // 
            // colDay3
            // 
            this.colDay3.Caption = "Thứ 4";
            this.colDay3.ColumnEdit = this.reTextEditQuantity;
            this.colDay3.FieldName = "Day3";
            this.colDay3.Name = "colDay3";
            this.colDay3.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay3.Visible = true;
            this.colDay3.VisibleIndex = 5;
            // 
            // colDay4
            // 
            this.colDay4.Caption = "Thứ 5";
            this.colDay4.ColumnEdit = this.reTextEditQuantity;
            this.colDay4.FieldName = "Day4";
            this.colDay4.Name = "colDay4";
            this.colDay4.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay4.Visible = true;
            this.colDay4.VisibleIndex = 6;
            // 
            // colDay5
            // 
            this.colDay5.Caption = "Thứ 6";
            this.colDay5.ColumnEdit = this.reTextEditQuantity;
            this.colDay5.FieldName = "Day5";
            this.colDay5.Name = "colDay5";
            this.colDay5.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay5.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay5.Visible = true;
            this.colDay5.VisibleIndex = 7;
            // 
            // colDay6
            // 
            this.colDay6.Caption = "Thứ 7";
            this.colDay6.ColumnEdit = this.reTextEditQuantity;
            this.colDay6.FieldName = "Day6";
            this.colDay6.Name = "colDay6";
            this.colDay6.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay6.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay6.Visible = true;
            this.colDay6.VisibleIndex = 8;
            // 
            // colDay7
            // 
            this.colDay7.Caption = "Chủ nhật";
            this.colDay7.ColumnEdit = this.reTextEditQuantity;
            this.colDay7.FieldName = "Day7";
            this.colDay7.Name = "colDay7";
            this.colDay7.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDay7.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDay7.Visible = true;
            this.colDay7.VisibleIndex = 9;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(-7, 38);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(66, 16);
            this.lbDescription.TabIndex = 17;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpStock
            // 
            this.lookUpStock.Location = new System.Drawing.Point(65, 4);
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
            this.lookUpStock.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(427, 6);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(53, 14);
            this.lblStartDate.TabIndex = 24;
            this.lblStartDate.Text = "Từ ngày";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(486, 3);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.DisplayFormat.FormatString = "d";
            this.txtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(116, 20);
            this.txtStartDate.TabIndex = 25;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(622, 5);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(59, 14);
            this.lblEndDate.TabIndex = 26;
            this.lblEndDate.Text = "Đến ngày";
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(687, 3);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.DisplayFormat.FormatString = "d";
            this.txtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtEndDate.Properties.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(114, 20);
            this.txtEndDate.TabIndex = 27;
            // 
            // numUpDnWeekNo
            // 
            this.numUpDnWeekNo.EditValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDnWeekNo.EnterMoveNextControl = true;
            this.numUpDnWeekNo.Location = new System.Drawing.Point(367, 4);
            this.numUpDnWeekNo.Name = "numUpDnWeekNo";
            this.numUpDnWeekNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numUpDnWeekNo.Properties.Mask.EditMask = "f0";
            this.numUpDnWeekNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.numUpDnWeekNo.Properties.MaxValue = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.numUpDnWeekNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnWeekNo.Properties.UseCtrlIncrement = false;
            this.numUpDnWeekNo.Size = new System.Drawing.Size(51, 20);
            this.numUpDnWeekNo.TabIndex = 28;
            this.numUpDnWeekNo.EditValueChanged += new System.EventHandler(this.numUpDnWeekNo_EditValueChanged);
            // 
            // UCManufacturePlanWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numUpDnWeekNo);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.TxtYearNo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbWeekNo);
            this.Controls.Add(this.lbYearNo);
            this.Controls.Add(this.lbOutStock);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lookUpStock);
            this.Name = "UCManufacturePlanWeek";
            this.Size = new System.Drawing.Size(845, 345);
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpEditItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTextEditQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnWeekNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditFormula;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpEditItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.TextEdit TxtYearNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDay1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit reTextEditQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbWeekNo;
        private System.Windows.Forms.Label lbYearNo;
        private System.Windows.Forms.Label lbOutStock;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private DevExpress.XtraGrid.Columns.GridColumn colDay2;
        private DevExpress.XtraGrid.Columns.GridColumn colDay3;
        private DevExpress.XtraGrid.Columns.GridColumn colDay4;
        private DevExpress.XtraGrid.Columns.GridColumn colDay5;
        private DevExpress.XtraGrid.Columns.GridColumn colDay6;
        private DevExpress.XtraGrid.Columns.GridColumn colDay7;
        private System.Windows.Forms.Label lblStartDate;
        private DevExpress.XtraEditors.TextEdit txtStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private DevExpress.XtraEditors.TextEdit txtEndDate;
        private DevExpress.XtraEditors.SpinEdit numUpDnWeekNo;
    }
}
