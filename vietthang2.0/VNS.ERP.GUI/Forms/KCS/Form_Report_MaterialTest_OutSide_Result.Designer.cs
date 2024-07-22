using VNS.Windows.Forms;
namespace VNS.ERP.GUI.KCS
{
    partial class Form_Report_MaterialTest_OutSide_Result:FormBase
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
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lookUpEditNguyenLieu = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditChiTieu = new DevExpress.XtraEditors.LookUpEdit();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChiTieu.Properties)).BeginInit();
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
            this.tableLayoutPanel1.SetColumnSpan(this.ucDatePeriodSelection1, 2);
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(542, 74);
            this.ucDatePeriodSelection1.TabIndex = 12;
            this.ucDatePeriodSelection1.WorkingDate = new System.DateTime(2007, 9, 24, 0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditNguyenLieu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditChiTieu, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 415);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên nguyên liệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chỉ tiêu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 142);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repNumber,
            this.repPercent,
            this.repText});
            this.gridControl1.Size = new System.Drawing.Size(655, 240);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colKetQua});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Đơn vị phân tích";
            this.gridColumn1.FieldName = "TTPT";
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
            this.gridColumn2.FieldName = "DateReturn";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // colKetQua
            // 
            this.colKetQua.Caption = "Kết quả";
            this.colKetQua.ColumnEdit = this.repPercent;
            this.colKetQua.FieldName = "Result";
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.OptionsColumn.ReadOnly = true;
            this.colKetQua.Visible = true;
            this.colKetQua.VisibleIndex = 2;
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
            // repText
            // 
            this.repText.AutoHeight = false;
            this.repText.Name = "repText";
            // 
            // lookUpEditNguyenLieu
            // 
            this.lookUpEditNguyenLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditNguyenLieu.EnterMoveNextControl = true;
            this.lookUpEditNguyenLieu.Location = new System.Drawing.Point(139, 85);
            this.lookUpEditNguyenLieu.Name = "lookUpEditNguyenLieu";
            this.lookUpEditNguyenLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNguyenLieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName")});
            this.lookUpEditNguyenLieu.Properties.DisplayMember = "ItemName";
            this.lookUpEditNguyenLieu.Properties.NullText = "";
            this.lookUpEditNguyenLieu.Properties.ValueMember = "ItemCode";
            this.lookUpEditNguyenLieu.Size = new System.Drawing.Size(406, 20);
            this.lookUpEditNguyenLieu.TabIndex = 16;
            // 
            // lookUpEditChiTieu
            // 
            this.lookUpEditChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditChiTieu.EnterMoveNextControl = true;
            this.lookUpEditChiTieu.Location = new System.Drawing.Point(139, 114);
            this.lookUpEditChiTieu.Name = "lookUpEditChiTieu";
            this.lookUpEditChiTieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditChiTieu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpEditChiTieu.Properties.DisplayMember = "TechName";
            this.lookUpEditChiTieu.Properties.NullText = "";
            this.lookUpEditChiTieu.Properties.ValueMember = "TechCode";
            this.lookUpEditChiTieu.Size = new System.Drawing.Size(406, 20);
            this.lookUpEditChiTieu.TabIndex = 17;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportExcel.Location = new System.Drawing.Point(557, 388);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(101, 24);
            this.btnExportExcel.TabIndex = 19;
            this.btnExportExcel.Text = "Export Exel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(557, 113);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form_Report_MaterialTest_OutSide_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Report_MaterialTest_OutSide_Result";
            this.Text = "Bảng thống kê kết quả phân tích nguyên liệu";
            this.Load += new System.EventHandler(this.Form_Report_MaterialTest_OutSide_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditChiTieu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQua;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNguyenLieu;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditChiTieu;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPercent;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText;
    }
}