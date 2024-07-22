namespace VNS.ERP.GUI
{
    partial class FormUser
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
            this.usrUser1 = new VNS.ERP.GUI.UserControl.UsrUser();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookupEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
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
            // usrUser1
            // 
            this.usrUser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usrUser1.Location = new System.Drawing.Point(-3, 235);
            this.usrUser1.Name = "usrUser1";
            this.usrUser1.Size = new System.Drawing.Size(799, 209);
            this.usrUser1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(1, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookupEmployee,
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(790, 184);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLoginName,
            this.colIsAdmin,
            this.colUserName,
            this.colEmployeeID,
            this.colDescription,
            this.colBranchCode,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colLoginName
            // 
            this.colLoginName.Caption = "LoginName";
            this.colLoginName.FieldName = "LoginName";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.OptionsColumn.AllowEdit = false;
            this.colLoginName.OptionsColumn.AllowFocus = false;
            this.colLoginName.OptionsColumn.ReadOnly = true;
            this.colLoginName.OptionsFilter.AllowAutoFilter = false;
            this.colLoginName.OptionsFilter.AllowFilter = false;
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 0;
            this.colLoginName.Width = 135;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.Caption = "IsAdmin";
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.OptionsColumn.AllowEdit = false;
            this.colIsAdmin.OptionsColumn.AllowFocus = false;
            this.colIsAdmin.OptionsColumn.ReadOnly = true;
            this.colIsAdmin.OptionsFilter.AllowAutoFilter = false;
            this.colIsAdmin.OptionsFilter.AllowFilter = false;
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 1;
            this.colIsAdmin.Width = 53;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "UserName";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.AllowFocus = false;
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.OptionsFilter.AllowAutoFilter = false;
            this.colUserName.OptionsFilter.AllowFilter = false;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 116;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.ColumnEdit = this.LookupEmployee;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.OptionsColumn.AllowEdit = false;
            this.colEmployeeID.OptionsColumn.AllowFocus = false;
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            this.colEmployeeID.OptionsFilter.AllowAutoFilter = false;
            this.colEmployeeID.OptionsFilter.AllowFilter = false;
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 3;
            this.colEmployeeID.Width = 143;
            // 
            // LookupEmployee
            // 
            this.LookupEmployee.AutoHeight = false;
            this.LookupEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookupEmployee.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "EmployeeName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "EmployeeID", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.LookupEmployee.DisplayMember = "EmployeeName";
            this.LookupEmployee.Name = "LookupEmployee";
            this.LookupEmployee.NullText = "";
            this.LookupEmployee.ValueMember = "EmployeeID";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.OptionsColumn.ReadOnly = true;
            this.colDescription.OptionsFilter.AllowAutoFilter = false;
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 195;
            // 
            // colBranchCode
            // 
            this.colBranchCode.Caption = "Chi nhánh";
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.OptionsColumn.AllowEdit = false;
            this.colBranchCode.OptionsColumn.AllowFocus = false;
            this.colBranchCode.OptionsFilter.AllowFilter = false;
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 5;
            this.colBranchCode.Width = 122;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            this.colUserCreated.Width = 89;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            this.colDateCreated.Width = 94;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            this.colUserUpdated.Width = 109;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            this.colDateUpdated.Width = 86;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '*';
            // 
            // FormUser
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.usrUser1);
            this.EditControl = this.usrUser1;
            this.GridControl = this.gridControl1;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.Controls.SetChildIndex(this.usrUser1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookupEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControl.UsrUser usrUser1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookupEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}