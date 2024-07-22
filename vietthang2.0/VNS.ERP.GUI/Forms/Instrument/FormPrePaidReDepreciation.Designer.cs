namespace VNS.ERP.GUI.Accounting
{
    partial class FormPrePaidReDepreciation
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cboPeriodCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lblThang = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPrePaidCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrePaidName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpPrePaidName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpDescription = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDepRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextFormat1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDepMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextFormat2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCheckEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpPrePaid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpPrePaidName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpPrePaid)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel2.Controls.Add(this.cboPeriodCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblThang, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // cboPeriodCode
            // 
            this.cboPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPeriodCode.EnterMoveNextControl = true;
            this.cboPeriodCode.Location = new System.Drawing.Point(139, 4);
            this.cboPeriodCode.Name = "cboPeriodCode";
            this.cboPeriodCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeriodCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cboPeriodCode.Properties.DisplayMember = "Description";
            this.cboPeriodCode.Properties.NullText = "";
            this.cboPeriodCode.Properties.PopupWidth = 200;
            this.cboPeriodCode.Properties.ValueMember = "PeriodCode";
            this.cboPeriodCode.Size = new System.Drawing.Size(172, 20);
            this.cboPeriodCode.TabIndex = 2;
            this.cboPeriodCode.EditValueChanged += new System.EventHandler(this.cboPeriodCode_EditValueChanged);
            // 
            // lblThang
            // 
            this.lblThang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(96, 8);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(37, 13);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng";
            this.lblThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpPrePaid,
            this.ItemLookUpPrePaidName,
            this.ItemLookUpDescription,
            this.ItemTextFormat1,
            this.ItemTextFormat2});
            this.gridControl1.Size = new System.Drawing.Size(786, 273);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPrePaidCode,
            this.colPrePaidName,
            this.colDescription,
            this.colDepRate,
            this.colDepMonth,
            this.colCheckEdit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colPrePaidCode
            // 
            this.colPrePaidCode.Caption = "PrePaidCode";
            this.colPrePaidCode.FieldName = "PrePaidCode";
            this.colPrePaidCode.Name = "colPrePaidCode";
            this.colPrePaidCode.OptionsColumn.AllowEdit = false;
            this.colPrePaidCode.OptionsColumn.AllowFocus = false;
            this.colPrePaidCode.Visible = true;
            this.colPrePaidCode.VisibleIndex = 1;
            this.colPrePaidCode.Width = 98;
            // 
            // colPrePaidName
            // 
            this.colPrePaidName.Caption = "PrePaidName";
            this.colPrePaidName.ColumnEdit = this.ItemLookUpPrePaidName;
            this.colPrePaidName.FieldName = "PrePaidCode";
            this.colPrePaidName.Name = "colPrePaidName";
            this.colPrePaidName.OptionsColumn.AllowEdit = false;
            this.colPrePaidName.OptionsColumn.AllowFocus = false;
            this.colPrePaidName.Visible = true;
            this.colPrePaidName.VisibleIndex = 2;
            this.colPrePaidName.Width = 176;
            // 
            // ItemLookUpPrePaidName
            // 
            this.ItemLookUpPrePaidName.AutoHeight = false;
            this.ItemLookUpPrePaidName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpPrePaidName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrePaidName", "PrePaidName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrePaidCode", "PrePaidCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpPrePaidName.DisplayMember = "PrePaidName";
            this.ItemLookUpPrePaidName.Name = "ItemLookUpPrePaidName";
            this.ItemLookUpPrePaidName.NullText = "";
            this.ItemLookUpPrePaidName.ValueMember = "PrePaidCode";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnEdit = this.ItemLookUpDescription;
            this.colDescription.FieldName = "PrePaidCode";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
            this.colDescription.Width = 512;
            // 
            // ItemLookUpDescription
            // 
            this.ItemLookUpDescription.AutoHeight = false;
            this.ItemLookUpDescription.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpDescription.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrePaidCode", "PrePaidCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 512)});
            this.ItemLookUpDescription.DisplayMember = "Description";
            this.ItemLookUpDescription.Name = "ItemLookUpDescription";
            this.ItemLookUpDescription.NullText = "";
            this.ItemLookUpDescription.PopupWidth = 512;
            this.ItemLookUpDescription.ValueMember = "PrePaidCode";
            // 
            // colDepRate
            // 
            this.colDepRate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colDepRate.AppearanceCell.Options.UseBackColor = true;
            this.colDepRate.AppearanceCell.Options.UseTextOptions = true;
            this.colDepRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDepRate.Caption = "DepRate";
            this.colDepRate.ColumnEdit = this.ItemTextFormat1;
            this.colDepRate.FieldName = "DepRate";
            this.colDepRate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDepRate.Name = "colDepRate";
            this.colDepRate.Visible = true;
            this.colDepRate.VisibleIndex = 4;
            this.colDepRate.Width = 97;
            // 
            // ItemTextFormat1
            // 
            this.ItemTextFormat1.Appearance.Options.UseTextOptions = true;
            this.ItemTextFormat1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemTextFormat1.AutoHeight = false;
            this.ItemTextFormat1.Mask.EditMask = "p0";
            this.ItemTextFormat1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextFormat1.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextFormat1.Name = "ItemTextFormat1";
            // 
            // colDepMonth
            // 
            this.colDepMonth.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colDepMonth.AppearanceCell.Options.UseBackColor = true;
            this.colDepMonth.AppearanceCell.Options.UseTextOptions = true;
            this.colDepMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDepMonth.Caption = "DepMonth";
            this.colDepMonth.ColumnEdit = this.ItemTextFormat2;
            this.colDepMonth.FieldName = "DepMonth";
            this.colDepMonth.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colDepMonth.Name = "colDepMonth";
            this.colDepMonth.Visible = true;
            this.colDepMonth.VisibleIndex = 5;
            this.colDepMonth.Width = 104;
            // 
            // ItemTextFormat2
            // 
            this.ItemTextFormat2.AutoHeight = false;
            this.ItemTextFormat2.Mask.EditMask = "n0";
            this.ItemTextFormat2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextFormat2.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextFormat2.Name = "ItemTextFormat2";
            // 
            // colCheckEdit
            // 
            this.colCheckEdit.FieldName = "CheckEdit";
            this.colCheckEdit.Name = "colCheckEdit";
            this.colCheckEdit.Visible = true;
            this.colCheckEdit.VisibleIndex = 0;
            this.colCheckEdit.Width = 28;
            // 
            // ItemLookUpPrePaid
            // 
            this.ItemLookUpPrePaid.AutoHeight = false;
            this.ItemLookUpPrePaid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpPrePaid.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrePaidCode", "PrePaidCode", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrePaidName", "PrePaidName", 120),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 150)});
            this.ItemLookUpPrePaid.DisplayMember = "PrePaidCode";
            this.ItemLookUpPrePaid.Name = "ItemLookUpPrePaid";
            this.ItemLookUpPrePaid.NullText = "";
            this.ItemLookUpPrePaid.PopupWidth = 350;
            this.ItemLookUpPrePaid.ShowHeader = false;
            this.ItemLookUpPrePaid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpPrePaid.ValueMember = "PrePaidCode";
            this.ItemLookUpPrePaid.EditValueChanged += new System.EventHandler(this.ItemLookUpPrePaid_EditValueChanged);
            // 
            // FormPrePaidReDepreciation
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPrePaidReDepreciation";
            this.Text = "FormPrePaidReDepreciation";
            this.Load += new System.EventHandler(this.FormPrePaidReDepreciation_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpPrePaidName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpPrePaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LookUpEdit cboPeriodCode;
        private System.Windows.Forms.Label lblThang;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDepRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepMonth;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpPrePaid;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpPrePaidName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextFormat1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextFormat2;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckEdit;
    }
}