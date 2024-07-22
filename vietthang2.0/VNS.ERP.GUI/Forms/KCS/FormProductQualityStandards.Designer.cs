namespace VNS.ERP.GUI.KCS
{
    partial class FormProductQualityStandards
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
            this.ucProductQualityStandards1 = new VNS.ERP.GUI.UCProductQualityStandards();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repFrequencyType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repTechCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colConditionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repConditionType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colValueString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoChiTieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repChiTieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repFrequencyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTechCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repConditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // ucProductQualityStandards1
            // 
            this.ucProductQualityStandards1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucProductQualityStandards1, 2);
            this.ucProductQualityStandards1.DataSource = null;
            this.ucProductQualityStandards1.Location = new System.Drawing.Point(3, 283);
            this.ucProductQualityStandards1.Name = "ucProductQualityStandards1";
            this.ucProductQualityStandards1.ProductCode = null;
            this.ucProductQualityStandards1.Size = new System.Drawing.Size(512, 107);
            this.ucProductQualityStandards1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repFrequencyType,
            this.repTechCode});
            this.gridControl1.Size = new System.Drawing.Size(253, 274);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSP,
            this.colTenSP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMaSP
            // 
            this.colMaSP.Caption = "Mã sản phẩm";
            this.colMaSP.FieldName = "ProductCode";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Visible = true;
            this.colMaSP.VisibleIndex = 0;
            this.colMaSP.Width = 103;
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên sản phẩm";
            this.colTenSP.FieldName = "ProductName";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 1;
            this.colTenSP.Width = 133;
            // 
            // repFrequencyType
            // 
            this.repFrequencyType.AutoHeight = false;
            this.repFrequencyType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repFrequencyType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumName")});
            this.repFrequencyType.DisplayMember = "EnumName";
            this.repFrequencyType.Name = "repFrequencyType";
            this.repFrequencyType.NullText = "";
            this.repFrequencyType.ValueMember = "EnumText";
            // 
            // repTechCode
            // 
            this.repTechCode.AutoHeight = false;
            this.repTechCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTechCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.repTechCode.Name = "repTechCode";
            this.repTechCode.NullText = "";
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl3, 2);
            this.gridControl3.EmbeddedNavigator.Name = "";
            this.gridControl3.Location = new System.Drawing.Point(262, 3);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repConditionType,
            this.repChiTieu,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemTextEdit1,
            this.repoChiTieu,
            this.repText,
            this.repPercent,
            this.repDecimal});
            this.gridControl3.Size = new System.Drawing.Size(384, 274);
            this.gridControl3.TabIndex = 20;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.colConditionType,
            this.colValueString,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.colTechCode});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.GroupCount = 1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowFooter = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTechCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView3.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView3_CustomRowCellEdit);
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Ngày bắt đầu";
            this.gridColumn13.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn13.FieldName = "StartDate";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 119;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colConditionType
            // 
            this.colConditionType.Caption = "Điều kiện";
            this.colConditionType.ColumnEdit = this.repConditionType;
            this.colConditionType.FieldName = "ConditionType";
            this.colConditionType.Name = "colConditionType";
            this.colConditionType.Visible = true;
            this.colConditionType.VisibleIndex = 1;
            this.colConditionType.Width = 132;
            // 
            // repConditionType
            // 
            this.repConditionType.AutoHeight = false;
            this.repConditionType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repConditionType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.repConditionType.DisplayMember = "EnumText";
            this.repConditionType.Name = "repConditionType";
            this.repConditionType.NullText = "";
            this.repConditionType.ValueMember = "EnumName";
            // 
            // colValueString
            // 
            this.colValueString.Caption = "Chuỗi giá trị";
            this.colValueString.ColumnEdit = this.repPercent;
            this.colValueString.FieldName = "ValueString";
            this.colValueString.Name = "colValueString";
            this.colValueString.Visible = true;
            this.colValueString.VisibleIndex = 2;
            this.colValueString.Width = 130;
            // 
            // repPercent
            // 
            this.repPercent.AutoHeight = false;
            this.repPercent.Mask.EditMask = "p";
            this.repPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repPercent.Mask.UseMaskAsDisplayFormat = true;
            this.repPercent.Name = "repPercent";
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Diễn giải";
            this.gridColumn16.FieldName = "Description";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 3;
            this.gridColumn16.Width = 182;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Người tạo";
            this.gridColumn17.FieldName = "UserCreated";
            this.gridColumn17.Name = "gridColumn17";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Ngày tạo";
            this.gridColumn18.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn18.FieldName = "DateCreated";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Người sửa";
            this.gridColumn19.FieldName = "UserUpdated";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Ngày sửa";
            this.gridColumn20.FieldName = "DateUpdated";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // colTechCode
            // 
            this.colTechCode.Caption = "Chỉ tiêu";
            this.colTechCode.ColumnEdit = this.repoChiTieu;
            this.colTechCode.FieldName = "TechCode";
            this.colTechCode.Name = "colTechCode";
            this.colTechCode.Visible = true;
            this.colTechCode.VisibleIndex = 4;
            // 
            // repoChiTieu
            // 
            this.repoChiTieu.AutoHeight = false;
            this.repoChiTieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoChiTieu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.repoChiTieu.DisplayMember = "TechName";
            this.repoChiTieu.Name = "repoChiTieu";
            this.repoChiTieu.NullText = "";
            this.repoChiTieu.ValueMember = "TechCode";
            // 
            // repChiTieu
            // 
            this.repChiTieu.AutoHeight = false;
            this.repChiTieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repChiTieu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.repChiTieu.DisplayMember = "TechName";
            this.repChiTieu.HideSelection = false;
            this.repChiTieu.Name = "repChiTieu";
            this.repChiTieu.NullText = "";
            this.repChiTieu.ValueMember = "TechCode";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repText
            // 
            this.repText.AutoHeight = false;
            this.repText.Name = "repText";
            // 
            // repDecimal
            // 
            this.repDecimal.AutoHeight = false;
            this.repDecimal.Mask.EditMask = "n2";
            this.repDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.repDecimal.Name = "repDecimal";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucProductQualityStandards1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 395);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // FormProductQualityStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucProductQualityStandards1;
            this.GridControl = this.gridControl3;
            this.Name = "FormProductQualityStandards";
            this.Text = "FormProductQualityStandards";
            this.Load += new System.EventHandler(this.FormProductQualityStandards_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repFrequencyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTechCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repConditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCProductQualityStandards ucProductQualityStandards1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repFrequencyType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTechCode;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colConditionType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repConditionType;
        private DevExpress.XtraGrid.Columns.GridColumn colValueString;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn colTechCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoChiTieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repChiTieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPercent;
    }
}