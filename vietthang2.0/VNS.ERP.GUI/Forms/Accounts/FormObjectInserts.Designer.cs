namespace VNS.ERP.GUI
{
    partial class FormObjectInserts
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubjectType = new System.Windows.Forms.Label();
            this.cboSubject = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBranchCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ucObjectInserts1 = new VNS.ERP.GUI.UCObjectInserts();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBranchCode)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucObjectInserts1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 508);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.42523F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.57478F));
            this.tableLayoutPanel2.Controls.Add(this.lblSubjectType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboSubject, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSubjectType
            // 
            this.lblSubjectType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubjectType.AutoSize = true;
            this.lblSubjectType.Location = new System.Drawing.Point(68, 8);
            this.lblSubjectType.Name = "lblSubjectType";
            this.lblSubjectType.Size = new System.Drawing.Size(67, 13);
            this.lblSubjectType.TabIndex = 0;
            this.lblSubjectType.Text = "SubjectType";
            this.lblSubjectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSubject
            // 
            this.cboSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboSubject.EditValue = "";
            this.cboSubject.EnterMoveNextControl = true;
            this.cboSubject.Location = new System.Drawing.Point(141, 5);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSubject.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectTypeCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectTypeName", "Tên", 220)});
            this.cboSubject.Properties.DisplayMember = "SubjectTypeName";
            this.cboSubject.Properties.NullText = "";
            this.cboSubject.Properties.PopupWidth = 300;
            this.cboSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSubject.Properties.ValueMember = "SubjectTypeCode";
            this.cboSubject.Size = new System.Drawing.Size(233, 20);
            this.cboSubject.TabIndex = 1;
            this.cboSubject.EditValueChanged += new System.EventHandler(this.cboSubject_EditValueChanged);
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 33);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboBranchCode});
            this.gridControl.Size = new System.Drawing.Size(786, 312);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubjectCode,
            this.colSubjectName,
            this.colAddress,
            this.colPhone,
            this.colFax,
            this.colTaxCode,
            this.colBankName,
            this.colBankAccountNo,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.OptionsColumn.AllowFocus = false;
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 0;
            this.colSubjectCode.Width = 85;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.OptionsColumn.AllowFocus = false;
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 1;
            this.colSubjectName.Width = 222;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 244;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 85;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowFocus = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            this.colFax.Width = 76;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "TaxCode";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.OptionsColumn.AllowFocus = false;
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 5;
            this.colTaxCode.Width = 106;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "BankName";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowFocus = false;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 6;
            this.colBankName.Width = 262;
            // 
            // colBankAccountNo
            // 
            this.colBankAccountNo.Caption = "BankAccountNo";
            this.colBankAccountNo.FieldName = "BankAccountNo";
            this.colBankAccountNo.Name = "colBankAccountNo";
            this.colBankAccountNo.OptionsColumn.AllowFocus = false;
            this.colBankAccountNo.Visible = true;
            this.colBankAccountNo.VisibleIndex = 7;
            this.colBankAccountNo.Width = 164;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowFocus = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 8;
            this.colDescription.Width = 358;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // cboBranchCode
            // 
            this.cboBranchCode.AutoHeight = false;
            this.cboBranchCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBranchCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cboBranchCode.DisplayMember = "SubjectName";
            this.cboBranchCode.Name = "cboBranchCode";
            this.cboBranchCode.NullText = "";
            this.cboBranchCode.ValueMember = "SubjectCode";
            // 
            // ucObjectInserts1
            // 
            this.ucObjectInserts1.Business = null;
            this.ucObjectInserts1.DataSource = null;
            this.ucObjectInserts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucObjectInserts1.Location = new System.Drawing.Point(3, 351);
            this.ucObjectInserts1.Name = "ucObjectInserts1";
            this.ucObjectInserts1.Size = new System.Drawing.Size(786, 154);
            this.ucObjectInserts1.SubjectType = "";
            this.ucObjectInserts1.TabIndex = 7;
            // 
            // FormObjectInserts
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucObjectInserts1;
            this.GridControl = this.gridControl;
            this.Name = "FormObjectInserts";
            this.Text = "FormObjectInserts";
            this.Load += new System.EventHandler(this.FormObjectInserts_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBranchCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSubjectType;
        private DevExpress.XtraEditors.LookUpEdit cboSubject;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankAccountNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboBranchCode;
        private UCObjectInserts ucObjectInserts1;
    }
}