namespace VNS.ERP.GUI.KCS
{
    partial class FormListEncryptCodeSend
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
            this.colSendNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSendDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbTTPT = new System.Windows.Forms.Label();
            this.lookUpSubjectCode = new DevExpress.XtraEditors.LookUpEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode.Properties)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(832, 280);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSendNo,
            this.colSendDate,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colSendNo
            // 
            this.colSendNo.Caption = "Số phiếu";
            this.colSendNo.FieldName = "SendNo";
            this.colSendNo.Name = "colSendNo";
            this.colSendNo.Visible = true;
            this.colSendNo.VisibleIndex = 0;
            this.colSendNo.Width = 104;
            // 
            // colSendDate
            // 
            this.colSendDate.Caption = "Ngày";
            this.colSendDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.colSendDate.FieldName = "SendDate";
            this.colSendDate.Name = "colSendDate";
            this.colSendDate.Visible = true;
            this.colSendDate.VisibleIndex = 1;
            this.colSendDate.Width = 112;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 285;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // lbTTPT
            // 
            this.lbTTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTTPT.Location = new System.Drawing.Point(270, 44);
            this.lbTTPT.Name = "lbTTPT";
            this.lbTTPT.Size = new System.Drawing.Size(53, 22);
            this.lbTTPT.TabIndex = 4;
            this.lbTTPT.Text = "TTPT";
            this.lbTTPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpSubjectCode
            // 
            this.lookUpSubjectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpSubjectCode.Location = new System.Drawing.Point(329, 46);
            this.lookUpSubjectCode.Name = "lookUpSubjectCode";
            this.lookUpSubjectCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSubjectCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã TT", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "TTPT", 200)});
            this.lookUpSubjectCode.Properties.DisplayMember = "SubjectName";
            this.lookUpSubjectCode.Properties.NullText = "";
            this.lookUpSubjectCode.Properties.PopupWidth = 300;
            this.lookUpSubjectCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSubjectCode.Properties.ValueMember = "SubjectCode";
            this.lookUpSubjectCode.Size = new System.Drawing.Size(264, 20);
            this.lookUpSubjectCode.TabIndex = 0;
            this.lookUpSubjectCode.EditValueChanged += new System.EventHandler(this.lookUpSubjectCode_EditValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(761, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTip = "Cập nhật phiếu mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(597, 46);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(34, 18);
            this.lbPeriod.TabIndex = 28;
            this.lbPeriod.Text = "Kỳ";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(635, 46);
            this.lookUpPeriod.Name = "lookUpPeriod";
            this.lookUpPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpPeriod.Properties.DisplayMember = "Description";
            this.lookUpPeriod.Properties.NullText = "";
            this.lookUpPeriod.Properties.ShowHeader = false;
            this.lookUpPeriod.Properties.ValueMember = "PeriodCode";
            this.lookUpPeriod.Size = new System.Drawing.Size(125, 20);
            this.lookUpPeriod.TabIndex = 1;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // FormListEncryptCodeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 373);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.Controls.Add(this.lookUpSubjectCode);
            this.Controls.Add(this.lbTTPT);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListEncryptCodeSend";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lbTTPT, 0);
            this.Controls.SetChildIndex(this.lookUpSubjectCode, 0);
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label lbTTPT;
        private DevExpress.XtraEditors.LookUpEdit lookUpSubjectCode;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colSendNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSendDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
    }
}
