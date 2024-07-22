
namespace VNS.ERP.GUI.KCS
{
    partial class Form_Report_ProductTest_OutSide_Result_For_QLCL
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
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEditProducts = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lookUpEditProductSize = new DevExpress.XtraEditors.LookUpEdit();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditTech = new DevExpress.XtraEditors.LookUpEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProducts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTech.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
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
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.AllowCheckDate = true;
            this.ucDatePeriodSelection1.AllowCheckQuarter = true;
            this.ucDatePeriodSelection1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ucDatePeriodSelection1, 4);
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(601, 74);
            this.ucDatePeriodSelection1.TabIndex = 13;
            this.ucDatePeriodSelection1.WorkingDate = new System.DateTime(2007, 9, 24, 0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditProducts, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditProductSize, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExport, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditTech, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkEdit1, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 414);
            this.tableLayoutPanel1.TabIndex = 14;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loại thành phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditProducts
            // 
            this.lookUpEditProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditProducts.EnterMoveNextControl = true;
            this.lookUpEditProducts.Location = new System.Drawing.Point(152, 83);
            this.lookUpEditProducts.Name = "lookUpEditProducts";
            this.lookUpEditProducts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProducts.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductCode")});
            this.lookUpEditProducts.Properties.DisplayMember = "ProductCode";
            this.lookUpEditProducts.Properties.NullText = "";
            this.lookUpEditProducts.Properties.ValueMember = "ProductCode";
            this.lookUpEditProducts.Size = new System.Drawing.Size(254, 20);
            this.lookUpEditProducts.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(412, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chỉ tiêu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kích cỡ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditProductSize
            // 
            this.lookUpEditProductSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditProductSize.EnterMoveNextControl = true;
            this.lookUpEditProductSize.Location = new System.Drawing.Point(152, 108);
            this.lookUpEditProductSize.Name = "lookUpEditProductSize";
            this.lookUpEditProductSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProductSize.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SizeCode")});
            this.lookUpEditProductSize.Properties.DisplayMember = "SizeCode";
            this.lookUpEditProductSize.Properties.NullText = "";
            this.lookUpEditProductSize.Properties.ValueMember = "SizeCode";
            this.lookUpEditProductSize.Size = new System.Drawing.Size(254, 20);
            this.lookUpEditProductSize.TabIndex = 20;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.Location = new System.Drawing.Point(777, 385);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(88, 23);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "Export Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 5);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repText,
            this.repPercent,
            this.repNumber});
            this.gridControl1.Size = new System.Drawing.Size(862, 243);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colKetQua});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nhà máy";
            this.gridColumn1.FieldName = "StockName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.DisplayFormat.FormatString = "d";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "ManuDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 158;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lot";
            this.gridColumn3.FieldName = "Lot";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 103;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị phân tích";
            this.gridColumn4.FieldName = "TTPT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 221;
            // 
            // colKetQua
            // 
            this.colKetQua.Caption = "Kết quả";
            this.colKetQua.ColumnEdit = this.repText;
            this.colKetQua.FieldName = "Result";
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.OptionsColumn.ReadOnly = true;
            this.colKetQua.Visible = true;
            this.colKetQua.VisibleIndex = 4;
            this.colKetQua.Width = 166;
            // 
            // repText
            // 
            this.repText.AutoHeight = false;
            this.repText.Name = "repText";
            // 
            // repPercent
            // 
            this.repPercent.AutoHeight = false;
            this.repPercent.Mask.EditMask = "p1";
            this.repPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repPercent.Mask.UseMaskAsDisplayFormat = true;
            this.repPercent.Name = "repPercent";
            // 
            // repNumber
            // 
            this.repNumber.AutoHeight = false;
            this.repNumber.Mask.EditMask = "n2";
            this.repNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repNumber.Mask.UseMaskAsDisplayFormat = true;
            this.repNumber.Name = "repNumber";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(777, 54);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 23);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lookUpEditTech
            // 
            this.lookUpEditTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lookUpEditTech, 2);
            this.lookUpEditTech.EnterMoveNextControl = true;
            this.lookUpEditTech.Location = new System.Drawing.Point(551, 83);
            this.lookUpEditTech.Name = "lookUpEditTech";
            this.lookUpEditTech.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTech.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode")});
            this.lookUpEditTech.Properties.DisplayMember = "TechName";
            this.lookUpEditTech.Properties.NullText = "";
            this.lookUpEditTech.Properties.ValueMember = "TechCode";
            this.lookUpEditTech.Size = new System.Drawing.Size(314, 20);
            this.lookUpEditTech.TabIndex = 19;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.checkEdit1, 2);
            this.checkEdit1.Location = new System.Drawing.Point(551, 108);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Chỉ những kết quả đã chấp nhận";
            this.checkEdit1.Size = new System.Drawing.Size(276, 19);
            this.checkEdit1.TabIndex = 23;
            // 
            // Form_Report_ProductTest_OutSide_Result_For_QLCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Report_ProductTest_OutSide_Result_For_QLCL";
            this.Text = "Bảng thống kê  kết quả phân tích thành phẩm";
            this.Load += new System.EventHandler(this.Form_Report_ProductTest_OutSide_Result_For_QLCL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProducts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTech.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQua;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProducts;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTech;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProductSize;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPercent;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumber;
    }
}