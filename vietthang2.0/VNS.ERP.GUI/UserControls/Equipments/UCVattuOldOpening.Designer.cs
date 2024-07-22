namespace VNS.ERP.GUI.Equipments
{
    partial class UCVattuOldOpening
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVattuCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.replkVattu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVattuOldType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.replkVattuOldType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNumberic1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.replkStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkVattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkVattuOldType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkStockCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repNumberic,
            this.replkStockCode,
            this.replkVattu,
            this.replkVattuOldType,
            this.repNumberic1});
            this.gridControl1.Size = new System.Drawing.Size(460, 245);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVattuCode,
            this.colVattuOldType,
            this.colQuantity,
            this.colAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.GotFocus += new System.EventHandler(this.gridView1_GotFocus);
            // 
            // colVattuCode
            // 
            this.colVattuCode.Caption = "Vật tư";
            this.colVattuCode.ColumnEdit = this.replkVattu;
            this.colVattuCode.FieldName = "VattuCode";
            this.colVattuCode.Name = "colVattuCode";
            this.colVattuCode.Visible = true;
            this.colVattuCode.VisibleIndex = 0;
            this.colVattuCode.Width = 79;
            // 
            // replkVattu
            // 
            this.replkVattu.AutoHeight = false;
            this.replkVattu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkVattu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VattuCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VattuName")});
            this.replkVattu.DisplayMember = "VattuName";
            this.replkVattu.Name = "replkVattu";
            this.replkVattu.NullText = "";
            this.replkVattu.ValueMember = "VattuCode";
            // 
            // colVattuOldType
            // 
            this.colVattuOldType.Caption = "Vật tư cũ";
            this.colVattuOldType.ColumnEdit = this.replkVattuOldType;
            this.colVattuOldType.FieldName = "VattuOldType";
            this.colVattuOldType.Name = "colVattuOldType";
            this.colVattuOldType.Visible = true;
            this.colVattuOldType.VisibleIndex = 1;
            this.colVattuOldType.Width = 109;
            // 
            // replkVattuOldType
            // 
            this.replkVattuOldType.AutoHeight = false;
            this.replkVattuOldType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkVattuOldType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName")});
            this.replkVattuOldType.DisplayMember = "TypeName";
            this.replkVattuOldType.Name = "replkVattuOldType";
            this.replkVattuOldType.NullText = "";
            this.replkVattuOldType.ValueMember = "TypeCode";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng";
            this.colQuantity.ColumnEdit = this.repNumberic;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 105;
            // 
            // repNumberic
            // 
            this.repNumberic.AutoHeight = false;
            this.repNumberic.Mask.EditMask = "n0";
            this.repNumberic.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic.Name = "repNumberic";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Lượng";
            this.colAmount.ColumnEdit = this.repNumberic1;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            this.colAmount.Width = 146;
            // 
            // repNumberic1
            // 
            this.repNumberic1.AutoHeight = false;
            this.repNumberic1.Mask.EditMask = "n0";
            this.repNumberic1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumberic1.Mask.UseMaskAsDisplayFormat = true;
            this.repNumberic1.Name = "repNumberic1";
            // 
            // replkStockCode
            // 
            this.replkStockCode.AutoHeight = false;
            this.replkStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.replkStockCode.DisplayMember = "StockName";
            this.replkStockCode.Name = "replkStockCode";
            this.replkStockCode.ValueMember = "StockCode";
            // 
            // UCVattuOldOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCVattuOldOpening";
            this.Size = new System.Drawing.Size(472, 257);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkVattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkVattuOldType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumberic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkStockCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuOldType;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replkStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replkVattu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replkVattuOldType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumberic1;
    }
}
