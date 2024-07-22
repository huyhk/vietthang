namespace VNS.ERP.GUI.Manufactures
{
    partial class FormManufacturePlan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFinished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTyleHaohut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.cboPeriodCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lblThang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 308);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 34);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(751, 271);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlanNo,
            this.colPlanDate,
            this.colDescription,
            this.colIsFinished,
            this.colTyleHaohut,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsFilter.AllowMRUFilterList = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colPlanNo
            // 
            this.colPlanNo.Caption = "PlanNo";
            this.colPlanNo.FieldName = "PlanNo";
            this.colPlanNo.Name = "colPlanNo";
            this.colPlanNo.OptionsColumn.AllowFocus = false;
            this.colPlanNo.Visible = true;
            this.colPlanNo.VisibleIndex = 0;
            this.colPlanNo.Width = 89;
            // 
            // colPlanDate
            // 
            this.colPlanDate.Caption = "PlanDate";
            this.colPlanDate.DisplayFormat.FormatString = "d";
            this.colPlanDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPlanDate.FieldName = "PlanDate";
            this.colPlanDate.Name = "colPlanDate";
            this.colPlanDate.OptionsColumn.AllowFocus = false;
            this.colPlanDate.Visible = true;
            this.colPlanDate.VisibleIndex = 1;
            this.colPlanDate.Width = 82;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 520;
            // 
            // colIsFinished
            // 
            this.colIsFinished.Caption = "IsFinished";
            this.colIsFinished.FieldName = "IsFinished";
            this.colIsFinished.Name = "colIsFinished";
            this.colIsFinished.OptionsColumn.AllowFocus = false;
            this.colIsFinished.Visible = true;
            this.colIsFinished.VisibleIndex = 2;
            this.colIsFinished.Width = 94;
            // 
            // colTyleHaohut
            // 
            this.colTyleHaohut.AppearanceCell.Options.UseTextOptions = true;
            this.colTyleHaohut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTyleHaohut.Caption = "TyleHaohut";
            this.colTyleHaohut.DisplayFormat.FormatString = "p";
            this.colTyleHaohut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTyleHaohut.FieldName = "TyleHaohut";
            this.colTyleHaohut.Name = "colTyleHaohut";
            this.colTyleHaohut.OptionsColumn.AllowEdit = false;
            this.colTyleHaohut.OptionsColumn.AllowFocus = false;
            this.colTyleHaohut.OptionsFilter.AllowAutoFilter = false;
            this.colTyleHaohut.OptionsFilter.AllowFilter = false;
            this.colTyleHaohut.Tag = "";
            this.colTyleHaohut.Width = 102;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsFilter.AllowAutoFilter = false;
            this.colUserCreated.OptionsFilter.AllowFilter = false;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colUserUpdated.OptionsFilter.AllowFilter = false;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsFilter.AllowAutoFilter = false;
            this.colDateCreated.OptionsFilter.AllowFilter = false;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colDateUpdated.OptionsFilter.AllowFilter = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.82813F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.17188F));
            this.tableLayoutPanel2.Controls.Add(this.lblStockCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lookUpStockCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboPeriodCode, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblThang, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(751, 25);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblStockCode
            // 
            this.lblStockCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(24, 6);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(58, 13);
            this.lblStockCode.TabIndex = 9;
            this.lblStockCode.Text = "StockCode";
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpStockCode.EditValue = "";
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(88, 3);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã ", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên ", 150)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(142, 20);
            this.lookUpStockCode.TabIndex = 8;
            this.lookUpStockCode.EditValueChanged += new System.EventHandler(this.lookUpStockCode_EditValueChanged);
            // 
            // cboPeriodCode
            // 
            this.cboPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPeriodCode.EnterMoveNextControl = true;
            this.cboPeriodCode.Location = new System.Drawing.Point(618, 3);
            this.cboPeriodCode.Name = "cboPeriodCode";
            this.cboPeriodCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeriodCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cboPeriodCode.Properties.DisplayMember = "Description";
            this.cboPeriodCode.Properties.NullText = "";
            this.cboPeriodCode.Properties.PopupWidth = 200;
            this.cboPeriodCode.Properties.ValueMember = "PeriodCode";
            this.cboPeriodCode.Size = new System.Drawing.Size(130, 20);
            this.cboPeriodCode.TabIndex = 11;
            this.cboPeriodCode.EditValueChanged += new System.EventHandler(this.cboPeriodCode_EditValueChanged);
            // 
            // lblThang
            // 
            this.lblThang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(575, 6);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(37, 13);
            this.lblThang.TabIndex = 12;
            this.lblThang.Text = "Tháng";
            this.lblThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormManufacturePlan
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl;
            this.Name = "FormManufacturePlan";
            this.Text = "ManufacturePlan";
            this.Load += new System.EventHandler(this.FormManufacturePlan_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lblStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFinished;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colTyleHaohut;
        private DevExpress.XtraEditors.LookUpEdit cboPeriodCode;
        private System.Windows.Forms.Label lblThang;
    }
}