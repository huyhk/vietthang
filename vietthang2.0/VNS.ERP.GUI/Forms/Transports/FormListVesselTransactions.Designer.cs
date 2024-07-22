namespace VNS.ERP.GUI.Transports
{
    partial class FormListVesselTransactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEditTransactionDate = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repVendorCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVesselCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repVesselCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStartPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstimateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransactionDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVendorCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVesselCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(385, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kỳ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditTransactionDate
            // 
            this.lookUpEditTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditTransactionDate.Location = new System.Drawing.Point(470, 4);
            this.lookUpEditTransactionDate.Name = "lookUpEditTransactionDate";
            this.lookUpEditTransactionDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTransactionDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpEditTransactionDate.Properties.DisplayMember = "Description";
            this.lookUpEditTransactionDate.Properties.NullText = "";
            this.lookUpEditTransactionDate.Properties.ValueMember = "PeriodCode";
            this.lookUpEditTransactionDate.Size = new System.Drawing.Size(201, 20);
            this.lookUpEditTransactionDate.TabIndex = 6;
            this.lookUpEditTransactionDate.EditValueChanged += new System.EventHandler(this.lookUpEditTransactionDate_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 4);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repVendorCode,
            this.repVesselCode,
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(778, 262);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionNo,
            this.colTransactionDate,
            this.colVendorCode,
            this.colVesselCode,
            this.colStartPlace,
            this.colEndPlace,
            this.colEstimateDate,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colTransactionNo
            // 
            this.colTransactionNo.Caption = "Số hợp đồng";
            this.colTransactionNo.FieldName = "TransactionNo";
            this.colTransactionNo.Name = "colTransactionNo";
            this.colTransactionNo.Visible = true;
            this.colTransactionNo.VisibleIndex = 0;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "Ngày làm hợp đồng";
            this.colTransactionDate.DisplayFormat.FormatString = "d";
            this.colTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 1;
            // 
            // colVendorCode
            // 
            this.colVendorCode.Caption = "Khách hàng";
            this.colVendorCode.ColumnEdit = this.repVendorCode;
            this.colVendorCode.FieldName = "VendorCode";
            this.colVendorCode.Name = "colVendorCode";
            this.colVendorCode.Visible = true;
            this.colVendorCode.VisibleIndex = 2;
            this.colVendorCode.Width = 142;
            // 
            // repVendorCode
            // 
            this.repVendorCode.AutoHeight = false;
            this.repVendorCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repVendorCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.repVendorCode.DisplayMember = "SubjectName";
            this.repVendorCode.Name = "repVendorCode";
            this.repVendorCode.NullText = "";
            this.repVendorCode.ValueMember = "SubjectCode";
            // 
            // colVesselCode
            // 
            this.colVesselCode.Caption = "Tàu";
            this.colVesselCode.ColumnEdit = this.repVesselCode;
            this.colVesselCode.FieldName = "VesselCode";
            this.colVesselCode.Name = "colVesselCode";
            this.colVesselCode.Visible = true;
            this.colVesselCode.VisibleIndex = 3;
            this.colVesselCode.Width = 99;
            // 
            // repVesselCode
            // 
            this.repVesselCode.AutoHeight = false;
            this.repVesselCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repVesselCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VesselCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VesselName")});
            this.repVesselCode.DisplayMember = "VesselName";
            this.repVesselCode.Name = "repVesselCode";
            this.repVesselCode.ValueMember = "VesselCode";
            // 
            // colStartPlace
            // 
            this.colStartPlace.Caption = "Nơi xuất phát";
            this.colStartPlace.FieldName = "StartPlace";
            this.colStartPlace.Name = "colStartPlace";
            this.colStartPlace.Visible = true;
            this.colStartPlace.VisibleIndex = 4;
            this.colStartPlace.Width = 134;
            // 
            // colEndPlace
            // 
            this.colEndPlace.Caption = "Nơi đến";
            this.colEndPlace.FieldName = "EndPlace";
            this.colEndPlace.Name = "colEndPlace";
            this.colEndPlace.Visible = true;
            this.colEndPlace.VisibleIndex = 5;
            this.colEndPlace.Width = 151;
            // 
            // colEstimateDate
            // 
            this.colEstimateDate.Caption = "Ngày dự kiến";
            this.colEstimateDate.DisplayFormat.FormatString = "d";
            this.colEstimateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEstimateDate.FieldName = "EstimateDate";
            this.colEstimateDate.Name = "colEstimateDate";
            this.colEstimateDate.Visible = true;
            this.colEstimateDate.VisibleIndex = 6;
            this.colEstimateDate.Width = 156;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 395;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditTransactionDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 296);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Location = new System.Drawing.Point(695, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 20);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormListVesselTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListVesselTransactions";
            this.Text = "FormListVesselTransactions";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTransactionDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVendorCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repVesselCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTransactionDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVesselCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStartPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colEndPlace;
        private DevExpress.XtraGrid.Columns.GridColumn colEstimateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repVendorCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repVesselCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
    }
}