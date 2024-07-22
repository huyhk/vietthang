namespace VNS.ERP.GUI
{
    partial class FormEmployee
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
            this.ucEmployee1 = new VNS.ERP.GUI.UserControls.UCEmployee();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpStockCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpStockCode)).BeginInit();
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
            // ucEmployee1
            // 
            this.ucEmployee1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucEmployee1.Business = null;
            this.ucEmployee1.DataSource = null;
            this.ucEmployee1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmployee1.Location = new System.Drawing.Point(0, 295);
            this.ucEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(775, 41);
            this.ucEmployee1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(4, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemTextEdit5,
            this.repositoryItemTextEdit6,
            this.repositoryItemTextEdit7,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repItemLookUpStockCode});
            this.gridControl1.Size = new System.Drawing.Size(903, 245);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colStockName,
            this.colStockCode,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "Mã nhân viên";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.OptionsColumn.AllowEdit = false;
            this.colEmployeeID.OptionsColumn.AllowFocus = false;
            this.colEmployeeID.OptionsColumn.AllowMove = false;
            this.colEmployeeID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colEmployeeID.OptionsColumn.ReadOnly = true;
            this.colEmployeeID.OptionsFilter.AllowAutoFilter = false;
            this.colEmployeeID.OptionsFilter.AllowFilter = false;
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            this.colEmployeeID.Width = 96;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Tên nhân viên";
            this.colStockName.FieldName = "EmployeeName";
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowEdit = false;
            this.colStockName.OptionsColumn.AllowFocus = false;
            this.colStockName.OptionsColumn.AllowMove = false;
            this.colStockName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colStockName.OptionsColumn.ReadOnly = true;
            this.colStockName.OptionsFilter.AllowAutoFilter = false;
            this.colStockName.OptionsFilter.AllowFilter = false;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 1;
            this.colStockName.Width = 381;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "Người tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowEdit = false;
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowEdit = false;
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "Người cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowEdit = false;
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowEdit = false;
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // repositoryItemTextEdit7
            // 
            this.repositoryItemTextEdit7.AutoHeight = false;
            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DisplayMember = "EmployeeName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Controller", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Controller", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.repositoryItemLookUpEdit2.DisplayMember = "EmployeeName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit2.ValueMember = "EmployeeID";
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "Kho làm việc";
            this.colStockCode.ColumnEdit = this.repItemLookUpStockCode;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.OptionsColumn.ReadOnly = true;
            this.colStockCode.OptionsFilter.AllowAutoFilter = false;
            this.colStockCode.OptionsFilter.AllowFilter = false;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 2;
            this.colStockCode.Width = 120;
            // 
            // repItemLookUpStockCode
            // 
            this.repItemLookUpStockCode.AutoHeight = false;
            this.repItemLookUpStockCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpStockCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.repItemLookUpStockCode.DisplayMember = "StockName";
            this.repItemLookUpStockCode.Name = "repItemLookUpStockCode";
            this.repItemLookUpStockCode.NullText = "";
            this.repItemLookUpStockCode.ValueMember = "StockCode";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 366);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ucEmployee1);
            this.EditControl = this.ucEmployee1;
            this.GridControl = this.gridControl1;
            this.Name = "FormEmployee";
            this.Text = "Danh mục nhân viên";
            this.Controls.SetChildIndex(this.ucEmployee1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpStockCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.UCEmployee ucEmployee1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpStockCode;
    }
}