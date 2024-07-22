namespace VNS.ERP.GUI.KCS
{
    partial class FormListMaterialTestRequest
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
            this.colDateRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(4, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(773, 331);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateRequest,
            this.colDescription,
            this.colIsReceived,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated,
            this.colUserReceived,
            this.colDateReceived});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colDateRequest
            // 
            this.colDateRequest.Caption = "Ngày";
            this.colDateRequest.DisplayFormat.FormatString = "d";
            this.colDateRequest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRequest.FieldName = "DateRequest";
            this.colDateRequest.Name = "colDateRequest";
            this.colDateRequest.Visible = true;
            this.colDateRequest.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 168;
            // 
            // colIsReceived
            // 
            this.colIsReceived.Caption = "Đã nhận";
            this.colIsReceived.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsReceived.FieldName = "IsReceived";
            this.colIsReceived.Name = "colIsReceived";
            this.colIsReceived.Visible = true;
            this.colIsReceived.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 83;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 95;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.FieldName = "DateUdpated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 99;
            // 
            // colUserReceived
            // 
            this.colUserReceived.Caption = "User nhận";
            this.colUserReceived.FieldName = "UserReceived";
            this.colUserReceived.Name = "colUserReceived";
            this.colUserReceived.Width = 103;
            // 
            // colDateReceived
            // 
            this.colDateReceived.Caption = "Ngày nhận";
            this.colDateReceived.FieldName = "DateReceived";
            this.colDateReceived.Name = "colDateReceived";
            this.colDateReceived.Width = 90;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(705, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTip = "Cập nhật phiếu mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(541, 46);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(34, 18);
            this.lbPeriod.TabIndex = 22;
            this.lbPeriod.Text = "Kỳ";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(579, 46);
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
            this.lookUpPeriod.TabIndex = 21;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // FormListMaterialTestRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(780, 432);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListMaterialTestRequest";
            this.Text = "";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRequest;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReceived;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserReceived;
        private DevExpress.XtraGrid.Columns.GridColumn colDateReceived;
    }
}
