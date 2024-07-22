namespace VNS.ERP.GUI.Accounting
{
    partial class FormFixedAssetOpening
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
            this.colFixedAssetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedAssetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMonthUsing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookAccountCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAccumulatedDepreciation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucFixedAssetOpening1 = new VNS.ERP.GUI.UCFixedAssetOpening();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookAccountCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookSubjectCode)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.ucFixedAssetOpening1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 508);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 285);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemTextFormat,
            this.ItemLookSubjectCode,
            this.ItemLookAccountCode});
            this.gridControl.Size = new System.Drawing.Size(787, 220);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFixedAssetCode,
            this.colFixedAssetName,
            this.colNgayCT,
            this.colStartDate,
            this.colOriginalPrice,
            this.colMonthUsing,
            this.colAccountCode,
            this.colSubjectCode,
            this.colAccumulatedDepreciation,
            this.colRemainCost,
            this.colDescription});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 2;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsPrint.ExpandAllDetails = true;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubjectCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAccountCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colFixedAssetCode
            // 
            this.colFixedAssetCode.Caption = "FixedAssetCode";
            this.colFixedAssetCode.FieldName = "FixedAssetCode";
            this.colFixedAssetCode.Name = "colFixedAssetCode";
            this.colFixedAssetCode.Visible = true;
            this.colFixedAssetCode.VisibleIndex = 0;
            this.colFixedAssetCode.Width = 91;
            // 
            // colFixedAssetName
            // 
            this.colFixedAssetName.Caption = "FixedAssetName";
            this.colFixedAssetName.FieldName = "FixedAssetName";
            this.colFixedAssetName.Name = "colFixedAssetName";
            this.colFixedAssetName.Visible = true;
            this.colFixedAssetName.VisibleIndex = 1;
            this.colFixedAssetName.Width = 187;
            // 
            // colNgayCT
            // 
            this.colNgayCT.Caption = "Ngày CT";
            this.colNgayCT.DisplayFormat.FormatString = "d";
            this.colNgayCT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayCT.FieldName = "NgayCT";
            this.colNgayCT.GroupFormat.FormatString = "d";
            this.colNgayCT.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayCT.Name = "colNgayCT";
            this.colNgayCT.Visible = true;
            this.colNgayCT.VisibleIndex = 2;
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "StartDate";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 73;
            // 
            // colOriginalPrice
            // 
            this.colOriginalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colOriginalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOriginalPrice.Caption = "OriginalPrice";
            this.colOriginalPrice.ColumnEdit = this.ItemTextFormat;
            this.colOriginalPrice.DisplayFormat.FormatString = "OriginalPrice";
            this.colOriginalPrice.FieldName = "OriginalPrice";
            this.colOriginalPrice.Name = "colOriginalPrice";
            this.colOriginalPrice.SummaryItem.DisplayFormat = "{0:###,##0}";
            this.colOriginalPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colOriginalPrice.Visible = true;
            this.colOriginalPrice.VisibleIndex = 4;
            this.colOriginalPrice.Width = 84;
            // 
            // ItemTextFormat
            // 
            this.ItemTextFormat.AutoHeight = false;
            this.ItemTextFormat.Mask.EditMask = "n0";
            this.ItemTextFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextFormat.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextFormat.Name = "ItemTextFormat";
            // 
            // colMonthUsing
            // 
            this.colMonthUsing.Caption = "MonthUsing";
            this.colMonthUsing.ColumnEdit = this.ItemTextFormat;
            this.colMonthUsing.DisplayFormat.FormatString = "MonthUsing";
            this.colMonthUsing.FieldName = "YearUsing";
            this.colMonthUsing.Name = "colMonthUsing";
            this.colMonthUsing.Visible = true;
            this.colMonthUsing.VisibleIndex = 5;
            this.colMonthUsing.Width = 129;
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "AccountCode";
            this.colAccountCode.ColumnEdit = this.ItemLookAccountCode;
            this.colAccountCode.DisplayFormat.FormatString = "AccountCode";
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colAccountCode.Width = 97;
            // 
            // ItemLookAccountCode
            // 
            this.ItemLookAccountCode.AutoHeight = false;
            this.ItemLookAccountCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookAccountCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "AccountCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "AccountName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookAccountCode.DisplayMember = "AccountName";
            this.ItemLookAccountCode.Name = "ItemLookAccountCode";
            this.ItemLookAccountCode.NullText = "";
            this.ItemLookAccountCode.ValueMember = "AccountCode";
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.ColumnEdit = this.ItemLookSubjectCode;
            this.colSubjectCode.DisplayFormat.FormatString = "SubjectCode";
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSubjectCode.Width = 97;
            // 
            // ItemLookSubjectCode
            // 
            this.ItemLookSubjectCode.AutoHeight = false;
            this.ItemLookSubjectCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookSubjectCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookSubjectCode.DisplayMember = "SubjectName";
            this.ItemLookSubjectCode.Name = "ItemLookSubjectCode";
            this.ItemLookSubjectCode.NullText = "";
            this.ItemLookSubjectCode.ValueMember = "SubjectCode";
            // 
            // colAccumulatedDepreciation
            // 
            this.colAccumulatedDepreciation.Caption = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.ColumnEdit = this.ItemTextFormat;
            this.colAccumulatedDepreciation.DisplayFormat.FormatString = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.FieldName = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.Name = "colAccumulatedDepreciation";
            this.colAccumulatedDepreciation.SummaryItem.DisplayFormat = "{0:###,##0}";
            this.colAccumulatedDepreciation.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colAccumulatedDepreciation.Visible = true;
            this.colAccumulatedDepreciation.VisibleIndex = 6;
            this.colAccumulatedDepreciation.Width = 136;
            // 
            // colRemainCost
            // 
            this.colRemainCost.Caption = "RemainCost";
            this.colRemainCost.ColumnEdit = this.ItemTextFormat;
            this.colRemainCost.DisplayFormat.FormatString = "RemainCost";
            this.colRemainCost.FieldName = "RemainCost";
            this.colRemainCost.Name = "colRemainCost";
            this.colRemainCost.SummaryItem.DisplayFormat = "{0:###,##0}";
            this.colRemainCost.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRemainCost.Visible = true;
            this.colRemainCost.VisibleIndex = 7;
            this.colRemainCost.Width = 138;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.DisplayFormat.FormatString = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            this.colDescription.Width = 391;
            // 
            // ucFixedAssetOpening1
            // 
            this.ucFixedAssetOpening1.Business = null;
            this.ucFixedAssetOpening1.DataSource = null;
            this.ucFixedAssetOpening1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFixedAssetOpening1.Location = new System.Drawing.Point(3, 3);
            this.ucFixedAssetOpening1.Name = "ucFixedAssetOpening1";
            this.ucFixedAssetOpening1.Size = new System.Drawing.Size(787, 276);
            this.ucFixedAssetOpening1.TabIndex = 1;
            // 
            // FormFixedAssetOpening
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucFixedAssetOpening1;
            this.GridControl = this.gridControl;
            this.Name = "FormFixedAssetOpening";
            this.Text = "FormFixedAssetOpening";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFixedAssetOpening_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookAccountCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookSubjectCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedAssetCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedAssetName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthUsing;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccumulatedDepreciation;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainCost;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private UCFixedAssetOpening ucFixedAssetOpening1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookSubjectCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCT;
    }
}