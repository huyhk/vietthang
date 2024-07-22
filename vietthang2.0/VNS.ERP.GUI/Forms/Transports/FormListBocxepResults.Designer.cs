namespace VNS.ERP.GUI.Transports
{
    partial class FormListBocxepResults
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
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditBocxepSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBocxepSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditBocxepSubject, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditStockCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpPeriod, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(887, 387);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditBocxepSubject
            // 
            this.lookUpEditBocxepSubject.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lookUpEditBocxepSubject.Location = new System.Drawing.Point(111, 6);
            this.lookUpEditBocxepSubject.Name = "lookUpEditBocxepSubject";
            this.lookUpEditBocxepSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditBocxepSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "", 300, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditBocxepSubject.Properties.DisplayMember = "SubjectName";
            this.lookUpEditBocxepSubject.Properties.NullText = "";
            this.lookUpEditBocxepSubject.Properties.PopupWidth = 400;
            this.lookUpEditBocxepSubject.Properties.ValueMember = "SubjectCode";
            this.lookUpEditBocxepSubject.Size = new System.Drawing.Size(213, 20);
            this.lookUpEditBocxepSubject.TabIndex = 2;
            this.lookUpEditBocxepSubject.EditValueChanged += new System.EventHandler(this.lookUpEditBocxepSubject_EditValueChanged);
            // 
            // lookUpEditStockCode
            // 
            this.lookUpEditStockCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lookUpEditStockCode.Location = new System.Drawing.Point(388, 6);
            this.lookUpEditStockCode.Name = "lookUpEditStockCode";
            this.lookUpEditStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.lookUpEditStockCode.Properties.DisplayMember = "StockName";
            this.lookUpEditStockCode.Properties.NullText = "";
            this.lookUpEditStockCode.Properties.ValueMember = "StockCode";
            this.lookUpEditStockCode.Size = new System.Drawing.Size(180, 20);
            this.lookUpEditStockCode.TabIndex = 3;
            this.lookUpEditStockCode.EditValueChanged += new System.EventHandler(this.lookUpEditStockCode_EditValueChanged);
            // 
            // gridControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 8);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repSubjectCode,
            this.repStockCode});
            this.gridControl1.Size = new System.Drawing.Size(881, 348);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Từ ngày";
            this.gridColumn3.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn3.FieldName = "FromDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 184;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đến ngày";
            this.gridColumn4.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn4.FieldName = "ToDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 262;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Diễn giải";
            this.gridColumn6.FieldName = "Description";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 362;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người tạo";
            this.gridColumn7.FieldName = "UserCreated";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày tạo";
            this.gridColumn8.FieldName = "DateCreated";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Người sửa";
            this.gridColumn9.FieldName = "UserUpdated";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ngày sửa";
            this.gridColumn10.FieldName = "DateUpdate";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // repSubjectCode
            // 
            this.repSubjectCode.AutoHeight = false;
            this.repSubjectCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSubjectCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.repSubjectCode.DisplayMember = "SubjectName";
            this.repSubjectCode.Name = "repSubjectCode";
            this.repSubjectCode.NullText = "";
            this.repSubjectCode.ValueMember = "SubjectCode";
            // 
            // repStockCode
            // 
            this.repStockCode.AutoHeight = false;
            this.repStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.repStockCode.DisplayMember = "StockName";
            this.repStockCode.Name = "repStockCode";
            this.repStockCode.NullText = "";
            this.repStockCode.ValueMember = "StockCode";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(791, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 27);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tháng";
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpPeriod.Location = new System.Drawing.Point(638, 6);
            this.lookUpPeriod.Name = "lookUpPeriod";
            this.lookUpPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpPeriod.Properties.DisplayMember = "Description";
            this.lookUpPeriod.Properties.NullText = "";
            this.lookUpPeriod.Properties.ValueMember = "PeriodCode";
            this.lookUpPeriod.Size = new System.Drawing.Size(147, 20);
            this.lookUpPeriod.TabIndex = 7;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho vận";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormListBocxepResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 452);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListBocxepResults";
            this.Text = "Biên bản bốc xếp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListBocxepResults_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditBocxepSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditBocxepSubject;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStockCode;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repSubjectCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repStockCode;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
    }
}