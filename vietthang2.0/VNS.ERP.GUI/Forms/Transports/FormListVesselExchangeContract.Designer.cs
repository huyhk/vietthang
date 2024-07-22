namespace VNS.ERP.GUI.Transports
{
    partial class FormListVesselExchangeContract
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.replkExchangeSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colVesselTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemButtonVesselTransactionNo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colNangsuatbocdo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colGiaphatluusalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spinEditYear = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkExchangeSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemButtonVesselTransactionNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).BeginInit();
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
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.spinEditYear, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 316);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(711, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(459, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 4);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.replkExchangeSubjectCode,
            this.repItemButtonVesselTransactionNo,
            this.repDecimal,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(815, 281);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContractNo,
            this.colContractDate,
            this.colExchangeSubjectCode,
            this.colVesselTransactionNo,
            this.colNangsuatbocdo,
            this.colGiaphatluusalan,
            this.colDescription,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colContractNo
            // 
            this.colContractNo.Caption = "Số hợp đồng";
            this.colContractNo.FieldName = "ContractNo";
            this.colContractNo.Name = "colContractNo";
            this.colContractNo.Visible = true;
            this.colContractNo.VisibleIndex = 0;
            this.colContractNo.Width = 111;
            // 
            // colContractDate
            // 
            this.colContractDate.Caption = "Ngày";
            this.colContractDate.DisplayFormat.FormatString = "d";
            this.colContractDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colContractDate.FieldName = "ContractDate";
            this.colContractDate.Name = "colContractDate";
            this.colContractDate.Visible = true;
            this.colContractDate.VisibleIndex = 1;
            this.colContractDate.Width = 108;
            // 
            // colExchangeSubjectCode
            // 
            this.colExchangeSubjectCode.Caption = "Đ/v giao nhận";
            this.colExchangeSubjectCode.ColumnEdit = this.replkExchangeSubjectCode;
            this.colExchangeSubjectCode.FieldName = "ExchangeSubjectCode";
            this.colExchangeSubjectCode.Name = "colExchangeSubjectCode";
            this.colExchangeSubjectCode.Visible = true;
            this.colExchangeSubjectCode.VisibleIndex = 2;
            this.colExchangeSubjectCode.Width = 109;
            // 
            // replkExchangeSubjectCode
            // 
            this.replkExchangeSubjectCode.AutoHeight = false;
            this.replkExchangeSubjectCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkExchangeSubjectCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.replkExchangeSubjectCode.DisplayMember = "SubjectName";
            this.replkExchangeSubjectCode.Name = "replkExchangeSubjectCode";
            this.replkExchangeSubjectCode.ValueMember = "SubjectCode";
            // 
            // colVesselTransactionNo
            // 
            this.colVesselTransactionNo.Caption = "Mã chuyến tàu";
            this.colVesselTransactionNo.ColumnEdit = this.repItemButtonVesselTransactionNo;
            this.colVesselTransactionNo.FieldName = "VesselTransactionNo";
            this.colVesselTransactionNo.Name = "colVesselTransactionNo";
            this.colVesselTransactionNo.Visible = true;
            this.colVesselTransactionNo.VisibleIndex = 3;
            this.colVesselTransactionNo.Width = 116;
            // 
            // repItemButtonVesselTransactionNo
            // 
            this.repItemButtonVesselTransactionNo.AutoHeight = false;
            this.repItemButtonVesselTransactionNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repItemButtonVesselTransactionNo.Name = "repItemButtonVesselTransactionNo";
            // 
            // colNangsuatbocdo
            // 
            this.colNangsuatbocdo.Caption = "Năng suất bốc dỡ";
            this.colNangsuatbocdo.ColumnEdit = this.repDecimal;
            this.colNangsuatbocdo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNangsuatbocdo.FieldName = "NangsuatbocdoSalan";
            this.colNangsuatbocdo.Name = "colNangsuatbocdo";
            this.colNangsuatbocdo.Visible = true;
            this.colNangsuatbocdo.VisibleIndex = 4;
            this.colNangsuatbocdo.Width = 113;
            // 
            // repDecimal
            // 
            this.repDecimal.AutoHeight = false;
            this.repDecimal.Mask.EditMask = "n0";
            this.repDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.repDecimal.Name = "repDecimal";
            // 
            // colGiaphatluusalan
            // 
            this.colGiaphatluusalan.Caption = "Giá phạt lưu sà lan";
            this.colGiaphatluusalan.ColumnEdit = this.repDecimal;
            this.colGiaphatluusalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiaphatluusalan.FieldName = "GiaphatluuSalan";
            this.colGiaphatluusalan.Name = "colGiaphatluusalan";
            this.colGiaphatluusalan.Visible = true;
            this.colGiaphatluusalan.VisibleIndex = 5;
            this.colGiaphatluusalan.Width = 119;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 111;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UserCreated";
            this.gridColumn1.FieldName = "UserCreated";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Date Created";
            this.gridColumn2.FieldName = "DateCreated";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "User Updated";
            this.gridColumn3.FieldName = "UserUpdated";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Date Updated";
            this.gridColumn4.FieldName = "DateUpdated";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // spinEditYear
            // 
            this.spinEditYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.spinEditYear.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditYear.Location = new System.Drawing.Point(624, 4);
            this.spinEditYear.Name = "spinEditYear";
            this.spinEditYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinEditYear.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditYear.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.spinEditYear.Properties.UseCtrlIncrement = false;
            this.spinEditYear.Size = new System.Drawing.Size(81, 20);
            this.spinEditYear.TabIndex = 4;
            // 
            // FormListVesselExchangeContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListVesselExchangeContract";
            this.Text = "FormListVesselExchangeContract";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkExchangeSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemButtonVesselTransactionNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeSubjectCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replkExchangeSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVesselTransactionNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repItemButtonVesselTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNangsuatbocdo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDecimal;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaphatluusalan;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SpinEdit spinEditYear;
    }
}