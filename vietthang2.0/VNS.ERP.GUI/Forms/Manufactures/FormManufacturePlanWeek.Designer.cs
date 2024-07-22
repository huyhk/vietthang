namespace VNS.ERP.GUI.Manufactures
{
    partial class FormManufacturePlanWeek
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDay7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYearNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeekNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbOutStock = new System.Windows.Forms.Label();
            this.lookUpStock = new DevExpress.XtraEditors.LookUpEdit();
            this.lblYear = new System.Windows.Forms.Label();
            this.spinYear = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear.Properties)).BeginInit();
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
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7,
            this.colDescription1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
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
            // colDay1
            // 
            this.colDay1.Caption = "Thứ 2";
            this.colDay1.FieldName = "Day1";
            this.colDay1.Name = "colDay1";
            this.colDay1.Visible = true;
            this.colDay1.VisibleIndex = 2;
            this.colDay1.Width = 78;
            // 
            // colDay2
            // 
            this.colDay2.Caption = "Thứ 3";
            this.colDay2.FieldName = "Day2";
            this.colDay2.Name = "colDay2";
            this.colDay2.Visible = true;
            this.colDay2.VisibleIndex = 3;
            // 
            // colDay3
            // 
            this.colDay3.Caption = "Thứ 4";
            this.colDay3.FieldName = "Day4";
            this.colDay3.Name = "colDay3";
            this.colDay3.Visible = true;
            this.colDay3.VisibleIndex = 4;
            // 
            // colDay4
            // 
            this.colDay4.Caption = "Thứ 5";
            this.colDay4.FieldName = "Day4";
            this.colDay4.Name = "colDay4";
            this.colDay4.Visible = true;
            this.colDay4.VisibleIndex = 5;
            // 
            // colDay5
            // 
            this.colDay5.Caption = "Thứ 6";
            this.colDay5.FieldName = "Day5";
            this.colDay5.Name = "colDay5";
            this.colDay5.Visible = true;
            this.colDay5.VisibleIndex = 6;
            // 
            // colDay6
            // 
            this.colDay6.Caption = "Thứ 7";
            this.colDay6.FieldName = "Day6";
            this.colDay6.Name = "colDay6";
            this.colDay6.Visible = true;
            this.colDay6.VisibleIndex = 7;
            // 
            // colDay7
            // 
            this.colDay7.Caption = "Chủ nhật";
            this.colDay7.FieldName = "Day7";
            this.colDay7.Name = "colDay7";
            this.colDay7.Visible = true;
            this.colDay7.VisibleIndex = 8;
            // 
            // colDescription1
            // 
            this.colDescription1.Caption = "Diễn giải";
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 9;
            this.colDescription1.Width = 321;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode2.LevelTemplate = this.gridView2;
            gridLevelNode2.RelationName = "Detail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(5, 68);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(684, 314);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYearNo,
            this.colWeekNo,
            this.colStartDate,
            this.colEndDate,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colYearNo
            // 
            this.colYearNo.Caption = "Năm";
            this.colYearNo.FieldName = "YearNo";
            this.colYearNo.Name = "colYearNo";
            // 
            // colWeekNo
            // 
            this.colWeekNo.Caption = "Tuần";
            this.colWeekNo.FieldName = "WeekNo";
            this.colWeekNo.Name = "colWeekNo";
            this.colWeekNo.Visible = true;
            this.colWeekNo.VisibleIndex = 0;
            this.colWeekNo.Width = 121;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Từ ngày";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 1;
            this.colStartDate.Width = 98;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "Đến ngày";
            this.colEndDate.DisplayFormat.FormatString = "d";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 2;
            this.colEndDate.Width = 102;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 384;
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
            this.lbOutStock.TabIndex = 10;
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
            this.lookUpStock.TabIndex = 9;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(238, 49);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(31, 14);
            this.lblYear.TabIndex = 105;
            this.lblYear.Text = "Năm";
            // 
            // spinYear
            // 
            this.spinYear.EditValue = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.spinYear.Location = new System.Drawing.Point(275, 46);
            this.spinYear.Name = "spinYear";
            this.spinYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinYear.Properties.Mask.EditMask = "f0";
            this.spinYear.Properties.UseCtrlIncrement = false;
            this.spinYear.Size = new System.Drawing.Size(61, 20);
            this.spinYear.TabIndex = 106;
            // 
            // FormManufacturePlanWeek
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 417);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.spinYear);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lbOutStock);
            this.Controls.Add(this.lookUpStock);
            this.GridControl = this.gridControl1;
            this.Name = "FormManufacturePlanWeek";
            this.Text = "FormManufacturePlanWeek";
            this.Load += new System.EventHandler(this.FormManufacturePlanWeek_Load);
            this.Controls.SetChildIndex(this.lookUpStock, 0);
            this.Controls.SetChildIndex(this.lbOutStock, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.spinYear, 0);
            this.Controls.SetChildIndex(this.lblYear, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDay1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colYearNo;
        private DevExpress.XtraGrid.Columns.GridColumn colWeekNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private System.Windows.Forms.Label lbOutStock;
        private DevExpress.XtraEditors.LookUpEdit lookUpStock;
        private DevExpress.XtraGrid.Columns.GridColumn colDay2;
        private DevExpress.XtraGrid.Columns.GridColumn colDay3;
        private DevExpress.XtraGrid.Columns.GridColumn colDay4;
        private DevExpress.XtraGrid.Columns.GridColumn colDay5;
        private DevExpress.XtraGrid.Columns.GridColumn colDay6;
        private DevExpress.XtraGrid.Columns.GridColumn colDay7;
        private System.Windows.Forms.Label lblYear;
        private DevExpress.XtraEditors.SpinEdit spinYear;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
    }
}