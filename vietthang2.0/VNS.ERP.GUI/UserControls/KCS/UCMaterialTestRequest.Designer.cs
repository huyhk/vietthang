namespace VNS.ERP.GUI.KCS
{
    partial class UCMaterialTestRequest
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
            this.lbRequestDate = new System.Windows.Forms.Label();
            this.dateEditRequest = new DevExpress.XtraEditors.DateEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.chkIsReceived = new DevExpress.XtraEditors.CheckEdit();
            this.btnReceived = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colStockName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTestTransactionDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colVendorName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPTVC = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemEncryptCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDVPT = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTechName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colIsCheckedTechCode = new DevExpress.XtraPivotGrid.PivotGridField();
            this.btnEditDetail = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colItemName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colStockName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTestTransactionDate1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colVendorName1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPTVC1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colItemEncryptCode1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDVPT1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandRequest = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.repLookUpDVPT = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceived.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVPT)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRequestDate
            // 
            this.lbRequestDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRequestDate.Location = new System.Drawing.Point(3, 0);
            this.lbRequestDate.Name = "lbRequestDate";
            this.lbRequestDate.Size = new System.Drawing.Size(54, 25);
            this.lbRequestDate.TabIndex = 6;
            this.lbRequestDate.Text = "Ngày";
            this.lbRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditRequest
            // 
            this.dateEditRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEditRequest.EditValue = new System.DateTime(2008, 3, 6, 0, 0, 0, 0);
            this.dateEditRequest.EnterMoveNextControl = true;
            this.dateEditRequest.Location = new System.Drawing.Point(63, 3);
            this.dateEditRequest.Name = "dateEditRequest";
            this.dateEditRequest.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditRequest.Size = new System.Drawing.Size(84, 20);
            this.dateEditRequest.TabIndex = 0;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.Location = new System.Drawing.Point(3, 25);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(54, 41);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Ghi chú";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(63, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(684, 35);
            this.txtDescription.TabIndex = 1;
            // 
            // chkIsReceived
            // 
            this.chkIsReceived.Location = new System.Drawing.Point(66, 75);
            this.chkIsReceived.Name = "chkIsReceived";
            this.chkIsReceived.Properties.Caption = "Đã nhận";
            this.chkIsReceived.Size = new System.Drawing.Size(68, 19);
            this.chkIsReceived.TabIndex = 2;
            // 
            // btnReceived
            // 
            this.btnReceived.Location = new System.Drawing.Point(136, 74);
            this.btnReceived.Name = "btnReceived";
            this.btnReceived.Size = new System.Drawing.Size(90, 22);
            this.btnReceived.TabIndex = 3;
            this.btnReceived.Text = "Nhận/Bỏ nhận";
            this.btnReceived.Click += new System.EventHandler(this.btnReceived_Click);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colItemName,
            this.colStockName,
            this.colTestTransactionDate,
            this.colVendorName,
            this.colPTVC,
            this.colItemEncryptCode,
            this.colDVPT,
            this.colTechName,
            this.colIsCheckedTechCode});
            this.pivotGridControl1.Location = new System.Drawing.Point(422, 286);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(28, 26);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colItemName.AreaIndex = 0;
            this.colItemName.Caption = "Nguyên liệu";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            // 
            // colStockName
            // 
            this.colStockName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colStockName.AreaIndex = 1;
            this.colStockName.Caption = "Kho";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            // 
            // colTestTransactionDate
            // 
            this.colTestTransactionDate.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colTestTransactionDate.AreaIndex = 2;
            this.colTestTransactionDate.Caption = "Ngày phiếu kiểm";
            this.colTestTransactionDate.FieldName = "TestTransactionDate";
            this.colTestTransactionDate.Name = "colTestTransactionDate";
            // 
            // colVendorName
            // 
            this.colVendorName.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colVendorName.AreaIndex = 3;
            this.colVendorName.Caption = "Khách hàng";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            // 
            // colPTVC
            // 
            this.colPTVC.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea;
            this.colPTVC.AreaIndex = 4;
            this.colPTVC.Caption = "PTVC";
            this.colPTVC.FieldName = "PTVC";
            this.colPTVC.Name = "colPTVC";
            // 
            // colItemEncryptCode
            // 
            this.colItemEncryptCode.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colItemEncryptCode.AreaIndex = 0;
            this.colItemEncryptCode.Caption = "Mã mẫu";
            this.colItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode.Name = "colItemEncryptCode";
            // 
            // colDVPT
            // 
            this.colDVPT.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colDVPT.AreaIndex = 1;
            this.colDVPT.Caption = "ĐV phân tích";
            this.colDVPT.FieldName = "DVPT";
            this.colDVPT.Name = "colDVPT";
            this.colDVPT.Width = 300;
            // 
            // colTechName
            // 
            this.colTechName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colTechName.AreaIndex = 0;
            this.colTechName.Caption = "Chỉ tiêu";
            this.colTechName.FieldName = "TechName";
            this.colTechName.Name = "colTechName";
            // 
            // colIsCheckedTechCode
            // 
            this.colIsCheckedTechCode.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colIsCheckedTechCode.AreaIndex = 0;
            this.colIsCheckedTechCode.Caption = "Chi tiết";
            this.colIsCheckedTechCode.FieldName = "IsCheckedTechCode";
            this.colIsCheckedTechCode.Name = "colIsCheckedTechCode";
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetail.Location = new System.Drawing.Point(720, 77);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(37, 22);
            this.btnEditDetail.TabIndex = 4;
            this.btnEditDetail.Text = "...";
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(7, 105);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpDVPT});
            this.gridControl1.Size = new System.Drawing.Size(750, 324);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.bandRequest});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colItemName1,
            this.colStockName1,
            this.colTestTransactionDate1,
            this.colVendorName1,
            this.colPTVC1,
            this.colItemEncryptCode1,
            this.colDVPT1});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.colItemName1);
            this.gridBand2.Columns.Add(this.colStockName1);
            this.gridBand2.Columns.Add(this.colTestTransactionDate1);
            this.gridBand2.Columns.Add(this.colVendorName1);
            this.gridBand2.Columns.Add(this.colPTVC1);
            this.gridBand2.Columns.Add(this.colItemEncryptCode1);
            this.gridBand2.Columns.Add(this.colDVPT1);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 717;
            // 
            // colItemName1
            // 
            this.colItemName1.Caption = "Nguyên liệu";
            this.colItemName1.FieldName = "ItemName";
            this.colItemName1.Name = "colItemName1";
            this.colItemName1.Visible = true;
            this.colItemName1.Width = 136;
            // 
            // colStockName1
            // 
            this.colStockName1.Caption = "Kho";
            this.colStockName1.FieldName = "StockName";
            this.colStockName1.Name = "colStockName1";
            this.colStockName1.Visible = true;
            this.colStockName1.Width = 79;
            // 
            // colTestTransactionDate1
            // 
            this.colTestTransactionDate1.Caption = "Ngày";
            this.colTestTransactionDate1.DisplayFormat.FormatString = "d";
            this.colTestTransactionDate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTestTransactionDate1.FieldName = "TestTransactionDate";
            this.colTestTransactionDate1.Name = "colTestTransactionDate1";
            this.colTestTransactionDate1.Visible = true;
            this.colTestTransactionDate1.Width = 67;
            // 
            // colVendorName1
            // 
            this.colVendorName1.Caption = "Khách hàng";
            this.colVendorName1.FieldName = "VendorName";
            this.colVendorName1.Name = "colVendorName1";
            this.colVendorName1.Visible = true;
            this.colVendorName1.Width = 161;
            // 
            // colPTVC1
            // 
            this.colPTVC1.Caption = "PTVC";
            this.colPTVC1.FieldName = "PTVC";
            this.colPTVC1.Name = "colPTVC1";
            this.colPTVC1.Visible = true;
            this.colPTVC1.Width = 81;
            // 
            // colItemEncryptCode1
            // 
            this.colItemEncryptCode1.Caption = "Mã mẫu";
            this.colItemEncryptCode1.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode1.Name = "colItemEncryptCode1";
            this.colItemEncryptCode1.Visible = true;
            this.colItemEncryptCode1.Width = 80;
            // 
            // colDVPT1
            // 
            this.colDVPT1.Caption = "ĐV phân tích";
            this.colDVPT1.ColumnEdit = this.repLookUpDVPT;
            this.colDVPT1.FieldName = "DVPTCode";
            this.colDVPT1.Name = "colDVPT1";
            this.colDVPT1.Visible = true;
            this.colDVPT1.Width = 113;
            // 
            // bandRequest
            // 
            this.bandRequest.AppearanceHeader.Options.UseTextOptions = true;
            this.bandRequest.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandRequest.Caption = "Chi tiết";
            this.bandRequest.Name = "bandRequest";
            this.bandRequest.Width = 75;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbRequestDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateEditRequest, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 66);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // repLookUpDVPT
            // 
            this.repLookUpDVPT.AutoHeight = false;
            this.repLookUpDVPT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpDVPT.DisplayMember = "SubjectName";
            this.repLookUpDVPT.Name = "repLookUpDVPT";
            this.repLookUpDVPT.ValueMember = "SubjectCode";
            // 
            // UCMaterialTestRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnEditDetail);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.btnReceived);
            this.Controls.Add(this.chkIsReceived);
            this.Name = "UCMaterialTestRequest";
            this.Size = new System.Drawing.Size(765, 435);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsReceived.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpDVPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRequestDate;
        private DevExpress.XtraEditors.DateEdit dateEditRequest;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.CheckEdit chkIsReceived;
        private DevExpress.XtraEditors.SimpleButton btnReceived;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField colItemName;
        private DevExpress.XtraPivotGrid.PivotGridField colStockName;
        private DevExpress.XtraPivotGrid.PivotGridField colTestTransactionDate;
        private DevExpress.XtraPivotGrid.PivotGridField colVendorName;
        private DevExpress.XtraPivotGrid.PivotGridField colPTVC;
        private DevExpress.XtraPivotGrid.PivotGridField colItemEncryptCode;
        private DevExpress.XtraPivotGrid.PivotGridField colDVPT;
        private DevExpress.XtraPivotGrid.PivotGridField colTechName;
        private DevExpress.XtraPivotGrid.PivotGridField colIsCheckedTechCode;
        private DevExpress.XtraEditors.SimpleButton btnEditDetail;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStockName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTestTransactionDate1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colVendorName1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPTVC1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemEncryptCode1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDVPT1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandRequest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpDVPT;
    }
}
