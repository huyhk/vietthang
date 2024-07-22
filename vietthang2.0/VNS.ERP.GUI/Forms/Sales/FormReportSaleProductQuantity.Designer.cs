namespace VNS.ERP.GUI.Sales
{
    partial class FormReportSaleProductQuantity
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpEditStock = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTextEditDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.checkExcel = new DevExpress.XtraEditors.CheckEdit();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpEditStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(5, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpEditStock,
            this.repItemTextEditDecimal});
            this.gridControl1.Size = new System.Drawing.Size(862, 334);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStock,
            this.colItemCode,
            this.colItemName,
            this.colQuantity,
            this.colAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStock, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStock
            // 
            this.colStock.Caption = "Kho";
            this.colStock.ColumnEdit = this.repItemLookUpEditStock;
            this.colStock.FieldName = "StockCode";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 0;
            // 
            // repItemLookUpEditStock
            // 
            this.repItemLookUpEditStock.AutoHeight = false;
            this.repItemLookUpEditStock.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpEditStock.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.repItemLookUpEditStock.DisplayMember = "StockName";
            this.repItemLookUpEditStock.Name = "repItemLookUpEditStock";
            this.repItemLookUpEditStock.NullText = "";
            this.repItemLookUpEditStock.ValueMember = "StockCode";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã thành phẩm";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên thành phẩm";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Số lượng bán";
            this.colQuantity.ColumnEdit = this.repItemTextEditDecimal;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // repItemTextEditDecimal
            // 
            this.repItemTextEditDecimal.AutoHeight = false;
            this.repItemTextEditDecimal.Mask.EditMask = "n2";
            this.repItemTextEditDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repItemTextEditDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.repItemTextEditDecimal.Name = "repItemTextEditDecimal";
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Thành tiền";
            this.colAmount.ColumnEdit = this.repItemTextEditDecimal;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Appearance.Options.UseFont = true;
            this.btnBaoCao.Location = new System.Drawing.Point(460, 28);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(96, 24);
            this.btnBaoCao.TabIndex = 21;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Location = new System.Drawing.Point(592, 410);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 32);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // checkExcel
            // 
            this.checkExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkExcel.Location = new System.Drawing.Point(703, 417);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkExcel.Properties.Appearance.Options.UseFont = true;
            this.checkExcel.Properties.Caption = "Kết xuất ra Excel";
            this.checkExcel.Size = new System.Drawing.Size(132, 19);
            this.checkExcel.TabIndex = 23;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(5, 2);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 24;
            // 
            // FormReportSaleProductQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 444);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.checkExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormReportSaleProductQuantity";
            this.Text = "FormReportSaleProductQuantity";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpEditStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpEditStock;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEditDecimal;
        private DevExpress.XtraEditors.CheckEdit checkExcel;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
    }
}