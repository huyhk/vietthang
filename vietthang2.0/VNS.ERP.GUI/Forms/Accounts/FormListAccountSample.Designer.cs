namespace VNS.ERP.GUI.Accounting
{
    partial class FormListAccountSample
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
            this.colAccountSampleCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountSampleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTransactionTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpAccTransTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpAccTransTypeCode)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(4, 46);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repItemLookUpAccTransTypeCode});
            this.gridControl1.Size = new System.Drawing.Size(808, 367);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountSampleCode,
            this.colAccountSampleName,
            this.colDescription,
            this.colAccountTransactionTypeCode,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colAccountSampleCode
            // 
            this.colAccountSampleCode.Caption = "Mã template";
            this.colAccountSampleCode.FieldName = "AccountSampleCode";
            this.colAccountSampleCode.Name = "colAccountSampleCode";
            this.colAccountSampleCode.Visible = true;
            this.colAccountSampleCode.VisibleIndex = 0;
            this.colAccountSampleCode.Width = 137;
            // 
            // colAccountSampleName
            // 
            this.colAccountSampleName.Caption = "Tên template";
            this.colAccountSampleName.FieldName = "AccountSampleName";
            this.colAccountSampleName.Name = "colAccountSampleName";
            this.colAccountSampleName.Visible = true;
            this.colAccountSampleName.VisibleIndex = 1;
            this.colAccountSampleName.Width = 254;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 265;
            // 
            // colAccountTransactionTypeCode
            // 
            this.colAccountTransactionTypeCode.Caption = "Loại";
            this.colAccountTransactionTypeCode.ColumnEdit = this.repItemLookUpAccTransTypeCode;
            this.colAccountTransactionTypeCode.FieldName = "AccountTransactionTypeCode";
            this.colAccountTransactionTypeCode.Name = "colAccountTransactionTypeCode";
            this.colAccountTransactionTypeCode.Visible = true;
            this.colAccountTransactionTypeCode.VisibleIndex = 3;
            this.colAccountTransactionTypeCode.Width = 215;
            // 
            // repItemLookUpAccTransTypeCode
            // 
            this.repItemLookUpAccTransTypeCode.AutoHeight = false;
            this.repItemLookUpAccTransTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpAccTransTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountTransactionTypeName")});
            this.repItemLookUpAccTransTypeCode.DisplayMember = "AccountTransactionTypeName";
            this.repItemLookUpAccTransTypeCode.Name = "repItemLookUpAccTransTypeCode";
            this.repItemLookUpAccTransTypeCode.NullText = "";
            this.repItemLookUpAccTransTypeCode.ValueMember = "AccountTransactionTypeCode";
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
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // FormListAccountSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 440);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListAccountSample";
            this.Text = "FormListAccountSample";
            this.Load += new System.EventHandler(this.FormListAccountSample_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpAccTransTypeCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountSampleCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountSampleName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTransactionTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpAccTransTypeCode;
    }
}