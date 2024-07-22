namespace VNS.ERP.GUI.Accounting
{
    partial class FormFixedAssetGeneral
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
            this.colDepreciationInput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextEditFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.cboStartDate = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpAccountCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAssetCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFixedAssetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSodudauky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccumulatedDepreciation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentDepreciation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextEditFormatPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTangtrongky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtractDepreciation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccumulatedDepreciationExtract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamtrongky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoducuoiky = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainCodeExtract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDepreciation = new DevExpress.XtraEditors.SimpleButton();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.checkExcel = new DevExpress.XtraEditors.CheckEdit();
            this.btnReportYear = new DevExpress.XtraEditors.SimpleButton();
            this.chkSubTK = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormat)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccountCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormatPercent)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // colDepreciationInput
            // 
            this.colDepreciationInput.Caption = "DepreciationInput";
            this.colDepreciationInput.ColumnEdit = this.ItemTextEditFormat;
            this.colDepreciationInput.FieldName = "DepreciationInput";
            this.colDepreciationInput.Name = "colDepreciationInput";
            this.colDepreciationInput.OptionsFilter.AllowFilter = false;
            this.colDepreciationInput.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDepreciationInput.Visible = true;
            this.colDepreciationInput.VisibleIndex = 7;
            this.colDepreciationInput.Width = 111;
            // 
            // ItemTextEditFormat
            // 
            this.ItemTextEditFormat.AutoHeight = false;
            this.ItemTextEditFormat.Mask.EditMask = "n0";
            this.ItemTextEditFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextEditFormat.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextEditFormat.Name = "ItemTextEditFormat";
            this.ItemTextEditFormat.NullText = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 450);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel2.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCopy, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboStartDate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 37);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(63, 12);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(54, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCopy.Location = new System.Drawing.Point(665, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(169, 29);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cboStartDate
            // 
            this.cboStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStartDate.EnterMoveNextControl = true;
            this.cboStartDate.Location = new System.Drawing.Point(123, 8);
            this.cboStartDate.Name = "cboStartDate";
            this.cboStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PeriodCode", "PeriodCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.cboStartDate.Properties.DisplayMember = "Description";
            this.cboStartDate.Properties.NullText = "";
            this.cboStartDate.Properties.PopupWidth = 200;
            this.cboStartDate.Properties.ValueMember = "PeriodCode";
            this.cboStartDate.Size = new System.Drawing.Size(167, 20);
            this.cboStartDate.TabIndex = 7;
            this.cboStartDate.EditValueChanged += new System.EventHandler(this.cboStartDate_EditValueChanged);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(3, 40);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemTextEditFormat,
            this.ItemTextEditFormatPercent,
            this.ItemLookUpAccountCode,
            this.ItemLookUpSubjectCode});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(831, 372);
            this.gridControl.TabIndex = 1;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colSubjectCode,
            this.colAssetCode,
            this.colFixedAssetName,
            this.colSodudauky,
            this.colOriginalPrice,
            this.colAccumulatedDepreciation,
            this.colRemainCost,
            this.colPercentDepreciation,
            this.colTangtrongky,
            this.colExtractDepreciation,
            this.colAccumulatedDepreciationExtract,
            this.colGiamtrongky,
            this.colSoducuoiky,
            this.colDepreciationInput,
            this.colRemainCodeExtract});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 2;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAccountCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubjectCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "AccountCode";
            this.colAccountCode.ColumnEdit = this.ItemLookUpAccountCode;
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colAccountCode.Width = 108;
            // 
            // ItemLookUpAccountCode
            // 
            this.ItemLookUpAccountCode.AutoHeight = false;
            this.ItemLookUpAccountCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpAccountCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "AccountName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "AccountCode")});
            this.ItemLookUpAccountCode.DisplayMember = "AccountName";
            this.ItemLookUpAccountCode.Name = "ItemLookUpAccountCode";
            this.ItemLookUpAccountCode.NullText = "";
            this.ItemLookUpAccountCode.ValueMember = "AccountCode";
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.ColumnEdit = this.ItemLookUpSubjectCode;
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSubjectCode.Width = 123;
            // 
            // ItemLookUpSubjectCode
            // 
            this.ItemLookUpSubjectCode.AutoHeight = false;
            this.ItemLookUpSubjectCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpSubjectCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName")});
            this.ItemLookUpSubjectCode.DisplayMember = "SubjectName";
            this.ItemLookUpSubjectCode.Name = "ItemLookUpSubjectCode";
            this.ItemLookUpSubjectCode.NullText = "";
            this.ItemLookUpSubjectCode.ValueMember = "SubjectCode";
            // 
            // colAssetCode
            // 
            this.colAssetCode.Caption = "Mã";
            this.colAssetCode.FieldName = "FixedAssetCode";
            this.colAssetCode.Name = "colAssetCode";
            this.colAssetCode.Visible = true;
            this.colAssetCode.VisibleIndex = 0;
            this.colAssetCode.Width = 81;
            // 
            // colFixedAssetName
            // 
            this.colFixedAssetName.Caption = "FixedAssetName";
            this.colFixedAssetName.FieldName = "FixedAssetName";
            this.colFixedAssetName.Name = "colFixedAssetName";
            this.colFixedAssetName.OptionsColumn.AllowEdit = false;
            this.colFixedAssetName.OptionsFilter.AllowFilter = false;
            this.colFixedAssetName.Visible = true;
            this.colFixedAssetName.VisibleIndex = 1;
            this.colFixedAssetName.Width = 233;
            // 
            // colSodudauky
            // 
            this.colSodudauky.Caption = "Nguyên giá đầu kỳ";
            this.colSodudauky.DisplayFormat.FormatString = "n0";
            this.colSodudauky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSodudauky.FieldName = "Sodudauky";
            this.colSodudauky.Name = "colSodudauky";
            this.colSodudauky.OptionsColumn.AllowEdit = false;
            this.colSodudauky.OptionsFilter.AllowAutoFilter = false;
            this.colSodudauky.Visible = true;
            this.colSodudauky.VisibleIndex = 2;
            this.colSodudauky.Width = 114;
            // 
            // colOriginalPrice
            // 
            this.colOriginalPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colOriginalPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOriginalPrice.Caption = "OriginalPrice";
            this.colOriginalPrice.ColumnEdit = this.ItemTextEditFormat;
            this.colOriginalPrice.FieldName = "OriginalPrice";
            this.colOriginalPrice.Name = "colOriginalPrice";
            this.colOriginalPrice.OptionsColumn.AllowEdit = false;
            this.colOriginalPrice.OptionsFilter.AllowFilter = false;
            this.colOriginalPrice.Width = 125;
            // 
            // colAccumulatedDepreciation
            // 
            this.colAccumulatedDepreciation.AppearanceCell.Options.UseTextOptions = true;
            this.colAccumulatedDepreciation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAccumulatedDepreciation.Caption = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.ColumnEdit = this.ItemTextEditFormat;
            this.colAccumulatedDepreciation.FieldName = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.Name = "colAccumulatedDepreciation";
            this.colAccumulatedDepreciation.OptionsColumn.AllowEdit = false;
            this.colAccumulatedDepreciation.OptionsFilter.AllowFilter = false;
            this.colAccumulatedDepreciation.Visible = true;
            this.colAccumulatedDepreciation.VisibleIndex = 3;
            this.colAccumulatedDepreciation.Width = 144;
            // 
            // colRemainCost
            // 
            this.colRemainCost.AppearanceCell.Options.UseTextOptions = true;
            this.colRemainCost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colRemainCost.Caption = "RemainCost";
            this.colRemainCost.ColumnEdit = this.ItemTextEditFormat;
            this.colRemainCost.FieldName = "RemainCost";
            this.colRemainCost.Name = "colRemainCost";
            this.colRemainCost.OptionsColumn.AllowEdit = false;
            this.colRemainCost.OptionsFilter.AllowFilter = false;
            this.colRemainCost.Visible = true;
            this.colRemainCost.VisibleIndex = 4;
            this.colRemainCost.Width = 114;
            // 
            // colPercentDepreciation
            // 
            this.colPercentDepreciation.AppearanceCell.Options.UseTextOptions = true;
            this.colPercentDepreciation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPercentDepreciation.Caption = "PercentDepreciation";
            this.colPercentDepreciation.ColumnEdit = this.ItemTextEditFormatPercent;
            this.colPercentDepreciation.FieldName = "PercentDepreciation";
            this.colPercentDepreciation.Name = "colPercentDepreciation";
            this.colPercentDepreciation.OptionsColumn.AllowEdit = false;
            this.colPercentDepreciation.OptionsFilter.AllowFilter = false;
            this.colPercentDepreciation.Visible = true;
            this.colPercentDepreciation.VisibleIndex = 5;
            this.colPercentDepreciation.Width = 63;
            // 
            // ItemTextEditFormatPercent
            // 
            this.ItemTextEditFormatPercent.AutoHeight = false;
            this.ItemTextEditFormatPercent.Mask.EditMask = "p2";
            this.ItemTextEditFormatPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextEditFormatPercent.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextEditFormatPercent.Name = "ItemTextEditFormatPercent";
            // 
            // colTangtrongky
            // 
            this.colTangtrongky.Caption = "Tăng trong kỳ";
            this.colTangtrongky.DisplayFormat.FormatString = "n0";
            this.colTangtrongky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTangtrongky.FieldName = "Tangtrongky";
            this.colTangtrongky.Name = "colTangtrongky";
            this.colTangtrongky.OptionsColumn.AllowEdit = false;
            this.colTangtrongky.Visible = true;
            this.colTangtrongky.VisibleIndex = 8;
            this.colTangtrongky.Width = 114;
            // 
            // colExtractDepreciation
            // 
            this.colExtractDepreciation.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colExtractDepreciation.AppearanceCell.Options.UseBackColor = true;
            this.colExtractDepreciation.AppearanceCell.Options.UseTextOptions = true;
            this.colExtractDepreciation.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colExtractDepreciation.Caption = "ExtractDepreciation";
            this.colExtractDepreciation.ColumnEdit = this.ItemTextEditFormat;
            this.colExtractDepreciation.FieldName = "ExtractDepreciation";
            this.colExtractDepreciation.Name = "colExtractDepreciation";
            this.colExtractDepreciation.OptionsColumn.AllowEdit = false;
            this.colExtractDepreciation.OptionsFilter.AllowFilter = false;
            this.colExtractDepreciation.Visible = true;
            this.colExtractDepreciation.VisibleIndex = 6;
            this.colExtractDepreciation.Width = 121;
            // 
            // colAccumulatedDepreciationExtract
            // 
            this.colAccumulatedDepreciationExtract.AppearanceCell.Options.UseTextOptions = true;
            this.colAccumulatedDepreciationExtract.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAccumulatedDepreciationExtract.Caption = "AccumulatedDepreciationExtract";
            this.colAccumulatedDepreciationExtract.ColumnEdit = this.ItemTextEditFormat;
            this.colAccumulatedDepreciationExtract.FieldName = "AccumulatedDepreciationExtract";
            this.colAccumulatedDepreciationExtract.Name = "colAccumulatedDepreciationExtract";
            this.colAccumulatedDepreciationExtract.OptionsColumn.AllowEdit = false;
            this.colAccumulatedDepreciationExtract.OptionsFilter.AllowFilter = false;
            this.colAccumulatedDepreciationExtract.Visible = true;
            this.colAccumulatedDepreciationExtract.VisibleIndex = 11;
            this.colAccumulatedDepreciationExtract.Width = 136;
            // 
            // colGiamtrongky
            // 
            this.colGiamtrongky.Caption = "Giảm trong kỳ";
            this.colGiamtrongky.DisplayFormat.FormatString = "#,###";
            this.colGiamtrongky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiamtrongky.FieldName = "Giamtrongky";
            this.colGiamtrongky.Name = "colGiamtrongky";
            this.colGiamtrongky.OptionsColumn.AllowEdit = false;
            this.colGiamtrongky.Visible = true;
            this.colGiamtrongky.VisibleIndex = 9;
            this.colGiamtrongky.Width = 114;
            // 
            // colSoducuoiky
            // 
            this.colSoducuoiky.Caption = "Nguyên giá cuối kỳ";
            this.colSoducuoiky.DisplayFormat.FormatString = "n0";
            this.colSoducuoiky.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoducuoiky.FieldName = "Soducuoiky";
            this.colSoducuoiky.Name = "colSoducuoiky";
            this.colSoducuoiky.OptionsColumn.AllowEdit = false;
            this.colSoducuoiky.Visible = true;
            this.colSoducuoiky.VisibleIndex = 10;
            this.colSoducuoiky.Width = 114;
            // 
            // colRemainCodeExtract
            // 
            this.colRemainCodeExtract.Caption = "RemainCodeExtract";
            this.colRemainCodeExtract.ColumnEdit = this.ItemTextEditFormat;
            this.colRemainCodeExtract.FieldName = "RemainCostExtract";
            this.colRemainCodeExtract.Name = "colRemainCodeExtract";
            this.colRemainCodeExtract.OptionsColumn.AllowEdit = false;
            this.colRemainCodeExtract.OptionsFilter.AllowFilter = false;
            this.colRemainCodeExtract.Visible = true;
            this.colRemainCodeExtract.VisibleIndex = 12;
            this.colRemainCodeExtract.Width = 111;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.Controls.Add(this.btnDepreciation, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReports, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkExcel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkSubTK, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReportYear, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 415);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(837, 35);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnDepreciation
            // 
            this.btnDepreciation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDepreciation.Location = new System.Drawing.Point(3, 3);
            this.btnDepreciation.Name = "btnDepreciation";
            this.btnDepreciation.Size = new System.Drawing.Size(169, 29);
            this.btnDepreciation.TabIndex = 1;
            this.btnDepreciation.Text = "Depreciation";
            this.btnDepreciation.Click += new System.EventHandler(this.btnDepreciation_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReports.Location = new System.Drawing.Point(482, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(167, 29);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // checkExcel
            // 
            this.checkExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkExcel.Location = new System.Drawing.Point(365, 8);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Properties.Caption = "Kết xuất ra excel";
            this.checkExcel.Size = new System.Drawing.Size(111, 19);
            this.checkExcel.TabIndex = 2;
            // 
            // btnReportYear
            // 
            this.btnReportYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReportYear.Location = new System.Drawing.Point(655, 3);
            this.btnReportYear.Name = "btnReportYear";
            this.btnReportYear.Size = new System.Drawing.Size(156, 29);
            this.btnReportYear.TabIndex = 3;
            this.btnReportYear.Text = "Report year";
            this.btnReportYear.Click += new System.EventHandler(this.btnReportYear_Click);
            // 
            // chkSubTK
            // 
            this.chkSubTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSubTK.EditValue = true;
            this.chkSubTK.Location = new System.Drawing.Point(179, 8);
            this.chkSubTK.Name = "chkSubTK";
            this.chkSubTK.Properties.Caption = "TK con";
            this.chkSubTK.Size = new System.Drawing.Size(69, 19);
            this.chkSubTK.TabIndex = 105;
            // 
            // FormFixedAssetGeneral
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl;
            this.Name = "FormFixedAssetGeneral";
            this.Text = "FormFixedAssetGeneral";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFixedAssetGeneral_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormat)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccountCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormatPercent)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubTK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedAssetName;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAccumulatedDepreciation;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentDepreciation;
        private DevExpress.XtraGrid.Columns.GridColumn colExtractDepreciation;
        private DevExpress.XtraGrid.Columns.GridColumn colAccumulatedDepreciationExtract;
        private DevExpress.XtraEditors.LookUpEdit cboStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextEditFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextEditFormatPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciationInput;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainCodeExtract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpAccountCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpSubjectCode;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private DevExpress.XtraEditors.SimpleButton btnDepreciation;
        private DevExpress.XtraEditors.CheckEdit checkExcel;
        private DevExpress.XtraEditors.SimpleButton btnReportYear;
        private DevExpress.XtraGrid.Columns.GridColumn colSodudauky;
        private DevExpress.XtraGrid.Columns.GridColumn colTangtrongky;
        private DevExpress.XtraGrid.Columns.GridColumn colSoducuoiky;
        private DevExpress.XtraEditors.CheckEdit chkSubTK;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamtrongky;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetCode;
    }
}