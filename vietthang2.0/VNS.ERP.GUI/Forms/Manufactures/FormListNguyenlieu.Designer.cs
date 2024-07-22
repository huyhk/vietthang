namespace VNS.ERP.GUI
{
    partial class FormListNguyenlieu
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
            this.colMaterialCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.ItemLookUpItemProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemProduct)).BeginInit();
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
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.85969F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.14031F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 449);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorEdit1,
            this.ItemLookUpItemProduct});
            this.gridControl.Size = new System.Drawing.Size(367, 383);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaterialCode,
            this.colItemCode,
            this.colWeight});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.Caption = "MaterialCode";
            this.colMaterialCode.FieldName = "MaterialCode";
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.Visible = true;
            this.colMaterialCode.VisibleIndex = 0;
            this.colMaterialCode.Width = 96;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "MaterialName";
            this.colItemCode.FieldName = "ItemName";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 162;
            // 
            // colWeight
            // 
            this.colWeight.Caption = "Weight";
            this.colWeight.DisplayFormat.FormatString = "n2";
            this.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWeight.FieldName = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.SummaryItem.DisplayFormat = "{0:n2}";
            this.colWeight.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colWeight.SummaryItem.Tag = 0;
            this.colWeight.Visible = true;
            this.colWeight.VisibleIndex = 2;
            this.colWeight.Width = 88;
            // 
            // repositoryItemColorEdit1
            // 
            this.repositoryItemColorEdit1.AutoHeight = false;
            this.repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            // 
            // ItemLookUpItemProduct
            // 
            this.ItemLookUpItemProduct.AutoHeight = false;
            this.ItemLookUpItemProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpItemProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpItemProduct.DisplayMember = "ItemName";
            this.ItemLookUpItemProduct.Name = "ItemLookUpItemProduct";
            this.ItemLookUpItemProduct.NullText = "";
            this.ItemLookUpItemProduct.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpItemProduct.ValueMember = "ItemCode";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.Location = new System.Drawing.Point(149, 407);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormListNguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(381, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(381, 476);
            this.Name = "FormListNguyenlieu";
            this.Text = "ListNguyenlieu";
            this.Load += new System.EventHandler(this.FormListNguyenlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpItemProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialCode;
        private DevExpress.XtraGrid.Columns.GridColumn colWeight;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpItemProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
    }
}