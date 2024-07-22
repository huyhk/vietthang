namespace VNS.ERP.GUI.KCS
{
    partial class FormEditEncryptCodeMaterialSendDetail
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
            this.gridCtrlAllItemEncryptCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewAllItemEncryptCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemEncryptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectItemEncryptCode = new DevExpress.XtraEditors.SimpleButton();
            this.gridCtrlSelectedItemEncryptCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewSelectedItemEncryptCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemEncryptCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridControlRequest = new DevExpress.XtraGrid.GridControl();
            this.gridViewRequest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpTechnicalTest1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIsChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlAllItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlSelectedItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedItemEncryptCode)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTechnicalTest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // gridCtrlAllItemEncryptCode
            // 
            this.gridCtrlAllItemEncryptCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlAllItemEncryptCode.EmbeddedNavigator.Name = "";
            this.gridCtrlAllItemEncryptCode.Location = new System.Drawing.Point(7, 16);
            this.gridCtrlAllItemEncryptCode.MainView = this.gridViewAllItemEncryptCode;
            this.gridCtrlAllItemEncryptCode.Name = "gridCtrlAllItemEncryptCode";
            this.gridCtrlAllItemEncryptCode.Size = new System.Drawing.Size(240, 332);
            this.gridCtrlAllItemEncryptCode.TabIndex = 0;
            this.gridCtrlAllItemEncryptCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllItemEncryptCode});
            // 
            // gridViewAllItemEncryptCode
            // 
            this.gridViewAllItemEncryptCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemEncryptCode});
            this.gridViewAllItemEncryptCode.GridControl = this.gridCtrlAllItemEncryptCode;
            this.gridViewAllItemEncryptCode.Name = "gridViewAllItemEncryptCode";
            this.gridViewAllItemEncryptCode.OptionsBehavior.Editable = false;
            this.gridViewAllItemEncryptCode.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewAllItemEncryptCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewAllItemEncryptCode.OptionsView.ShowDetailButtons = false;
            this.gridViewAllItemEncryptCode.OptionsView.ShowGroupPanel = false;
            this.gridViewAllItemEncryptCode.ColumnFilterChanged += new System.EventHandler(this.gridViewAllItemEncryptCode_ColumnFilterChanged);
            // 
            // colItemEncryptCode
            // 
            this.colItemEncryptCode.Caption = "Mã mẫu";
            this.colItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode.Name = "colItemEncryptCode";
            this.colItemEncryptCode.Visible = true;
            this.colItemEncryptCode.VisibleIndex = 0;
            this.colItemEncryptCode.Width = 174;
            // 
            // btnSelectItemEncryptCode
            // 
            this.btnSelectItemEncryptCode.Location = new System.Drawing.Point(252, 35);
            this.btnSelectItemEncryptCode.Name = "btnSelectItemEncryptCode";
            this.btnSelectItemEncryptCode.Size = new System.Drawing.Size(35, 21);
            this.btnSelectItemEncryptCode.TabIndex = 1;
            this.btnSelectItemEncryptCode.Text = ">>";
            this.btnSelectItemEncryptCode.Click += new System.EventHandler(this.btnSelectItemEncryptCode_Click);
            // 
            // gridCtrlSelectedItemEncryptCode
            // 
            this.gridCtrlSelectedItemEncryptCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlSelectedItemEncryptCode.EmbeddedNavigator.Name = "";
            this.gridCtrlSelectedItemEncryptCode.Location = new System.Drawing.Point(290, 16);
            this.gridCtrlSelectedItemEncryptCode.MainView = this.gridViewSelectedItemEncryptCode;
            this.gridCtrlSelectedItemEncryptCode.Name = "gridCtrlSelectedItemEncryptCode";
            this.gridCtrlSelectedItemEncryptCode.Size = new System.Drawing.Size(245, 332);
            this.gridCtrlSelectedItemEncryptCode.TabIndex = 2;
            this.gridCtrlSelectedItemEncryptCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSelectedItemEncryptCode});
            // 
            // gridViewSelectedItemEncryptCode
            // 
            this.gridViewSelectedItemEncryptCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemEncryptCode1});
            this.gridViewSelectedItemEncryptCode.GridControl = this.gridCtrlSelectedItemEncryptCode;
            this.gridViewSelectedItemEncryptCode.Name = "gridViewSelectedItemEncryptCode";
            this.gridViewSelectedItemEncryptCode.OptionsBehavior.Editable = false;
            this.gridViewSelectedItemEncryptCode.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewSelectedItemEncryptCode.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSelectedItemEncryptCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewSelectedItemEncryptCode.OptionsView.ShowDetailButtons = false;
            this.gridViewSelectedItemEncryptCode.OptionsView.ShowGroupPanel = false;
            this.gridViewSelectedItemEncryptCode.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSelectedItemEncryptCode_FocusedRowChanged);
            this.gridViewSelectedItemEncryptCode.ColumnFilterChanged += new System.EventHandler(this.gridViewSelectedItemEncryptCode_ColumnFilterChanged);
            this.gridViewSelectedItemEncryptCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSelectedItemEncryptCode_KeyDown);
            // 
            // colItemEncryptCode1
            // 
            this.colItemEncryptCode1.Caption = "Mã mẫu";
            this.colItemEncryptCode1.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode1.Name = "colItemEncryptCode1";
            this.colItemEncryptCode1.Visible = true;
            this.colItemEncryptCode1.VisibleIndex = 0;
            this.colItemEncryptCode1.Width = 174;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gridControlRequest);
            this.groupBox4.Location = new System.Drawing.Point(548, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 351);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yêu cầu phân tích";
            // 
            // gridControlRequest
            // 
            this.gridControlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRequest.EmbeddedNavigator.Name = "";
            this.gridControlRequest.Location = new System.Drawing.Point(3, 17);
            this.gridControlRequest.MainView = this.gridViewRequest;
            this.gridControlRequest.Name = "gridControlRequest";
            this.gridControlRequest.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpTechnicalTest1,
            this.repositoryItemCheckEdit1});
            this.gridControlRequest.Size = new System.Drawing.Size(214, 331);
            this.gridControlRequest.TabIndex = 0;
            this.gridControlRequest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRequest});
            // 
            // gridViewRequest
            // 
            this.gridViewRequest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTechCode1,
            this.colIsChecked});
            this.gridViewRequest.GridControl = this.gridControlRequest;
            this.gridViewRequest.Name = "gridViewRequest";
            this.gridViewRequest.OptionsCustomization.AllowFilter = false;
            this.gridViewRequest.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewRequest.OptionsView.ColumnAutoWidth = false;
            this.gridViewRequest.OptionsView.ShowDetailButtons = false;
            this.gridViewRequest.OptionsView.ShowGroupPanel = false;
            // 
            // colTechCode1
            // 
            this.colTechCode1.Caption = "Chỉ tiêu";
            this.colTechCode1.ColumnEdit = this.repLookUpTechnicalTest1;
            this.colTechCode1.FieldName = "TechCode";
            this.colTechCode1.Name = "colTechCode1";
            this.colTechCode1.OptionsColumn.ReadOnly = true;
            this.colTechCode1.Visible = true;
            this.colTechCode1.VisibleIndex = 0;
            this.colTechCode1.Width = 125;
            // 
            // repLookUpTechnicalTest1
            // 
            this.repLookUpTechnicalTest1.AutoHeight = false;
            this.repLookUpTechnicalTest1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repLookUpTechnicalTest1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode", "Mã CT", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName", "Tên CT", 200)});
            this.repLookUpTechnicalTest1.DisplayMember = "TechName";
            this.repLookUpTechnicalTest1.Name = "repLookUpTechnicalTest1";
            this.repLookUpTechnicalTest1.NullText = "";
            this.repLookUpTechnicalTest1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpTechnicalTest1.ValueMember = "TechCode";
            // 
            // colIsChecked
            // 
            this.colIsChecked.Caption = "Chọn";
            this.colIsChecked.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsChecked.FieldName = "IsChecked";
            this.colIsChecked.Name = "colIsChecked";
            this.colIsChecked.Visible = true;
            this.colIsChecked.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnSelectItemEncryptCode);
            this.groupBox1.Controls.Add(this.gridCtrlAllItemEncryptCode);
            this.groupBox1.Controls.Add(this.gridCtrlSelectedItemEncryptCode);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã mẫu";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(700, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormEditEncryptCodeMaterialSendDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(769, 381);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormEditEncryptCodeMaterialSendDetail";
            this.Text = "Gửi yều cầu phân tích";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlAllItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlSelectedItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedItemEncryptCode)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTechnicalTest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlAllItemEncryptCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAllItemEncryptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemEncryptCode;
        private DevExpress.XtraEditors.SimpleButton btnSelectItemEncryptCode;
        private DevExpress.XtraGrid.GridControl gridCtrlSelectedItemEncryptCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSelectedItemEncryptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemEncryptCode1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridControlRequest;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRequest;
        private DevExpress.XtraGrid.Columns.GridColumn colTechCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsChecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpTechnicalTest1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}
