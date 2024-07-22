namespace VNS.ERP.GUI.UserControls
{
    partial class UCProductFormula2
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
            this.lbFormulaCode = new System.Windows.Forms.Label();
            this.txtFormulaCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colMaterialName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormulaCode
            // 
            this.lbFormulaCode.Location = new System.Drawing.Point(3, 4);
            this.lbFormulaCode.Name = "lbFormulaCode";
            this.lbFormulaCode.Size = new System.Drawing.Size(82, 16);
            this.lbFormulaCode.TabIndex = 0;
            this.lbFormulaCode.Text = "Mã công thức";
            this.lbFormulaCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFormulaCode
            // 
            this.txtFormulaCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFormulaCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFormulaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormulaCode.Location = new System.Drawing.Point(91, 4);
            this.txtFormulaCode.MaxLength = 20;
            this.txtFormulaCode.Name = "txtFormulaCode";
            this.txtFormulaCode.Size = new System.Drawing.Size(125, 20);
            this.txtFormulaCode.TabIndex = 1;
            this.txtFormulaCode.Validated += new System.EventHandler(this.txtFormulaCode_Validated);
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(91, 29);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(480, 23);
            this.txtDescription.TabIndex = 18;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(27, 31);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(58, 16);
            this.lbDescription.TabIndex = 19;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(5, 58);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit4,
            this.repositoryItemLookUpEdit5,
            this.repositoryItemTextEdit1});
            this.gridControl2.Size = new System.Drawing.Size(685, 336);
            this.gridControl2.TabIndex = 20;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialCode,
            this.colMaterialName,
            this.colWeight});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "MaterialCode";
            this.colMaterialCode.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 0;
            this.colMaterialCode.Width = 80;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Mã nguyên liệu", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tên nguyên liệu", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit4.DisplayMember = "ItemCode";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            this.repositoryItemLookUpEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit4.ValueMember = "ItemCode";
            // 
            // colMaterialName
            // 
            this.colMaterialName.Caption = "MaterialName";
            this.colMaterialName.ColumnEdit = this.repositoryItemLookUpEdit5;
            this.colMaterialName.FieldName = "MaterialCode";
            this.colMaterialName.Name = "colMaterialName";
            this.colMaterialName.OptionsColumn.AllowEdit = false;
            this.colMaterialName.OptionsColumn.AllowFocus = false;
            this.colMaterialName.Visible = true;
            this.colMaterialName.VisibleIndex = 1;
            this.colMaterialName.Width = 314;
            // 
            // repositoryItemLookUpEdit5
            // 
            this.repositoryItemLookUpEdit5.AutoHeight = false;
            this.repositoryItemLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit5.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "MaterialCode", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "MaterialName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit5.DisplayMember = "ItemName";
            this.repositoryItemLookUpEdit5.Name = "repositoryItemLookUpEdit5";
            this.repositoryItemLookUpEdit5.NullText = "";
            this.repositoryItemLookUpEdit5.ValueMember = "ItemCode";
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Weight";
            this.colWeight.ColumnEdit = this.repositoryItemTextEdit1;
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.SummaryItem.DisplayFormat = "{0:n2}Kg";
            this.colWeight.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 2;
            this.colWeight.Width = 90;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ValidateOnEnterKey = true;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(222, 6);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(93, 17);
            this.chkIsActive.TabIndex = 22;
            this.chkIsActive.Text = "Đang sử dụng";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // UCProductFormula2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtFormulaCode);
            this.Controls.Add(this.lbFormulaCode);
            this.Name = "UCProductFormula2";
            this.Size = new System.Drawing.Size(695, 397);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormulaCode;
        private System.Windows.Forms.TextBox txtFormulaCode;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.CheckBox chkIsActive;
    }
}
