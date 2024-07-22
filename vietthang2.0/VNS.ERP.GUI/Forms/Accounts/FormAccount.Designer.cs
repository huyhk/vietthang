namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccount
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
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEditAccountType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAccountLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountParent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailClassification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificationTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpEditClsTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucAccount1 = new VNS.ERP.GUI.UserControls.UCAccount();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEditClsTypeCode)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(5, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEditAccountType,
            this.ItemLookUpEditClsTypeCode});
            this.gridControl1.Size = new System.Drawing.Size(825, 255);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colAccountName,
            this.colAccountType,
            this.colAccountLevel,
            this.colAccountParent,
            this.coDescription,
            this.colDetailSubject,
            this.colDetailClassification,
            this.colClassificationTypeCode,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "Mã tài khoản";
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 0;
            this.colAccountCode.Width = 97;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "Tên tài khoản";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 1;
            this.colAccountName.Width = 255;
            // 
            // colAccountType
            // 
            this.colAccountType.Caption = "Loại tài khoản";
            this.colAccountType.ColumnEdit = this.LookUpEditAccountType;
            this.colAccountType.FieldName = "AccountType";
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.Visible = true;
            this.colAccountType.VisibleIndex = 2;
            this.colAccountType.Width = 102;
            // 
            // LookUpEditAccountType
            // 
            this.LookUpEditAccountType.AutoHeight = false;
            this.LookUpEditAccountType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditAccountType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.LookUpEditAccountType.DisplayMember = "EnumText";
            this.LookUpEditAccountType.Name = "LookUpEditAccountType";
            this.LookUpEditAccountType.NullText = "";
            this.LookUpEditAccountType.ValueMember = "EnumID";
            // 
            // colAccountLevel
            // 
            this.colAccountLevel.Caption = "Cấp tài khoản";
            this.colAccountLevel.FieldName = "AccountLevel";
            this.colAccountLevel.Name = "colAccountLevel";
            this.colAccountLevel.Visible = true;
            this.colAccountLevel.VisibleIndex = 3;
            this.colAccountLevel.Width = 99;
            // 
            // colAccountParent
            // 
            this.colAccountParent.Caption = "Tài khoản cha";
            this.colAccountParent.FieldName = "AccountParent";
            this.colAccountParent.Name = "colAccountParent";
            this.colAccountParent.Visible = true;
            this.colAccountParent.VisibleIndex = 4;
            this.colAccountParent.Width = 107;
            // 
            // coDescription
            // 
            this.coDescription.Caption = "Diễn giải";
            this.coDescription.FieldName = "Description";
            this.coDescription.Name = "coDescription";
            this.coDescription.Visible = true;
            this.coDescription.VisibleIndex = 5;
            this.coDescription.Width = 63;
            // 
            // colDetailSubject
            // 
            this.colDetailSubject.Caption = "Có theo dõi đối tượng";
            this.colDetailSubject.FieldName = "DetailSubject";
            this.colDetailSubject.Name = "colDetailSubject";
            this.colDetailSubject.Visible = true;
            this.colDetailSubject.VisibleIndex = 6;
            this.colDetailSubject.Width = 144;
            // 
            // colDetailClassification
            // 
            this.colDetailClassification.Caption = "Có theo dõi yếu tố";
            this.colDetailClassification.FieldName = "DetailClassification";
            this.colDetailClassification.Name = "colDetailClassification";
            this.colDetailClassification.Visible = true;
            this.colDetailClassification.VisibleIndex = 7;
            this.colDetailClassification.Width = 128;
            // 
            // colClassificationTypeCode
            // 
            this.colClassificationTypeCode.Caption = "Loại yếu tố theo dõi";
            this.colClassificationTypeCode.ColumnEdit = this.ItemLookUpEditClsTypeCode;
            this.colClassificationTypeCode.FieldName = "ClassificationTypeCode";
            this.colClassificationTypeCode.Name = "colClassificationTypeCode";
            this.colClassificationTypeCode.Visible = true;
            this.colClassificationTypeCode.VisibleIndex = 8;
            this.colClassificationTypeCode.Width = 147;
            // 
            // ItemLookUpEditClsTypeCode
            // 
            this.ItemLookUpEditClsTypeCode.AutoHeight = false;
            this.ItemLookUpEditClsTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEditClsTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassificationTypeCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassificationTypeName")});
            this.ItemLookUpEditClsTypeCode.DisplayMember = "ClassificationTypeName";
            this.ItemLookUpEditClsTypeCode.Name = "ItemLookUpEditClsTypeCode";
            this.ItemLookUpEditClsTypeCode.NullText = "";
            this.ItemLookUpEditClsTypeCode.ValueMember = "ClassificationTypeCode";
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "User tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 64;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 61;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "User cập nhật";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 89;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày cập nhật";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 89;
            // 
            // ucAccount1
            // 
            this.ucAccount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucAccount1.Business = null;
            this.ucAccount1.DataSource = null;
            this.ucAccount1.Location = new System.Drawing.Point(6, 328);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(657, 152);
            this.ucAccount1.TabIndex = 6;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(689, 43);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(142, 22);
            this.btnExportExcel.TabIndex = 7;
            this.btnExportExcel.Text = "&Xuất danh sách ra excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 508);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.ucAccount1);
            this.Controls.Add(this.gridControl1);
            this.EditControl = this.ucAccount1;
            this.GridControl = this.gridControl1;
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucAccount1, 0);
            this.Controls.SetChildIndex(this.btnExportExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEditClsTypeCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private VNS.ERP.GUI.UserControls.UCAccount ucAccount1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountParent;
        private DevExpress.XtraGrid.Columns.GridColumn coDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailClassification;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificationTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEditAccountType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpEditClsTypeCode;
        private System.Windows.Forms.Button btnExportExcel;
    }
}