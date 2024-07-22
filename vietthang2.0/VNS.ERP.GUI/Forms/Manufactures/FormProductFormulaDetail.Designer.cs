namespace VNS.ERP.GUI
{
    partial class FormProductFormulaDetail
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
            this.lookUpEditFormulaCode = new DevExpress.XtraEditors.LookUpEdit();
            this.LbFormulaCode = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.usrDetailProductFormulaDetail1 = new VNS.ERP.GUI.UserControl.DetailProductFormulaDetail();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormulaCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
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
            // lookUpEditFormulaCode
            // 
            this.lookUpEditFormulaCode.EditValue = "";
            this.lookUpEditFormulaCode.Location = new System.Drawing.Point(96, 45);
            this.lookUpEditFormulaCode.Name = "lookUpEditFormulaCode";
            this.lookUpEditFormulaCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEditFormulaCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpEditFormulaCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormulaCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormulaCode", "FormulaCode", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditFormulaCode.Properties.DisplayMember = "FormulaCode";
            this.lookUpEditFormulaCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditFormulaCode.Properties.ValueMember = "FormulaCode";
            this.lookUpEditFormulaCode.Size = new System.Drawing.Size(232, 22);
            this.lookUpEditFormulaCode.TabIndex = 0;
            this.lookUpEditFormulaCode.EditValueChanged += new System.EventHandler(this.lookUpEditFormulaCode_EditValueChanged);
            // 
            // LbFormulaCode
            // 
            this.LbFormulaCode.AutoSize = true;
            this.LbFormulaCode.Location = new System.Drawing.Point(4, 47);
            this.LbFormulaCode.Name = "LbFormulaCode";
            this.LbFormulaCode.Size = new System.Drawing.Size(90, 16);
            this.LbFormulaCode.TabIndex = 13;
            this.LbFormulaCode.Text = "FormulaCode";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(5, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(729, 191);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.gridControl1_QueryContinueDrag);
            this.gridControl1.BindingContextChanged += new System.EventHandler(this.gridControl1_BindingContextChanged);
            this.gridControl1.ViewRemoved += new DevExpress.XtraGrid.ViewOperationEventHandler(this.gridControl1_ViewRemoved);
            this.gridControl1.RegionChanged += new System.EventHandler(this.gridControl1_RegionChanged);
            this.gridControl1.DefaultViewChanged += new System.EventHandler(this.gridControl1_DefaultViewChanged);
            this.gridControl1.PaddingChanged += new System.EventHandler(this.gridControl1_PaddingChanged);
            this.gridControl1.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControl1_FocusedViewChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductCode,
            this.colProductName,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.ShowFilterPopupListBox += new DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventHandler(this.gridView1_ShowFilterPopupListBox);
            this.gridView1.CustomFilterDialog += new DevExpress.XtraGrid.Views.Grid.CustomFilterDialogEventHandler(this.gridView1_CustomFilterDialog);
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "ProductCode";
            this.colProductCode.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.OptionsColumn.AllowEdit = false;
            this.colProductCode.OptionsColumn.AllowFocus = false;
            this.colProductCode.OptionsFilter.AllowAutoFilter = false;
            this.colProductCode.OptionsFilter.AllowFilter = false;
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 100;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductCode", "ProductCode", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "ProductName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductCode";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "ProductCode";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colProductName.FieldName = "ProductCode";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.OptionsColumn.AllowFocus = false;
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.OptionsFilter.AllowAutoFilter = false;
            this.colProductName.OptionsFilter.AllowFilter = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 303;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AllowFocused = false;
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ReadOnly = true;
            this.repositoryItemLookUpEdit2.ValueMember = "ProductCode";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colDescription.FieldName = "ProductCode";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AllowAutoFilter = false;
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 305;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DisplayMember = "Description";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "ProductCode";
            // 
            // usrDetailProductFormulaDetail1
            // 
            this.usrDetailProductFormulaDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usrDetailProductFormulaDetail1.Business = null;
            this.usrDetailProductFormulaDetail1.DataSource = null;
            this.usrDetailProductFormulaDetail1.Location = new System.Drawing.Point(-1, 267);
            this.usrDetailProductFormulaDetail1.Name = "usrDetailProductFormulaDetail1";
            this.usrDetailProductFormulaDetail1.Size = new System.Drawing.Size(740, 238);
            this.usrDetailProductFormulaDetail1.TabIndex = 15;
            // 
            // FormProductFormulaDetail
            // 
            this.AllowSaveAndClose = false;
            this.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 535);
            this.Controls.Add(this.usrDetailProductFormulaDetail1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.LbFormulaCode);
            this.Controls.Add(this.lookUpEditFormulaCode);
            this.EditControl = this.usrDetailProductFormulaDetail1;
            this.GridControl = this.gridControl1;
            this.Name = "FormProductFormulaDetail";
            this.Text = "FormFormulaDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProductFormulaDetail_FormClosing);
            this.Controls.SetChildIndex(this.lookUpEditFormulaCode, 0);
            this.Controls.SetChildIndex(this.LbFormulaCode, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.usrDetailProductFormulaDetail1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormulaCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormulaCode;
        private System.Windows.Forms.Label LbFormulaCode;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private VNS.ERP.GUI.UserControl.DetailProductFormulaDetail usrDetailProductFormulaDetail1;
    }
}