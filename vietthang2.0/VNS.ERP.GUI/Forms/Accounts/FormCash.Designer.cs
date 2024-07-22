namespace VNS.ERP.GUI
{
    partial class FormCash
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
            this.colSoHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboBranchCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucCash1 = new VNS.ERP.GUI.UCCash();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBranchCode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboBranchCode});
            this.gridControl.Size = new System.Drawing.Size(786, 316);
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
            this.colDateUpdated,
            this.colSoHieu,
            this.colBranchCode});
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
            this.colSubjectName.Width = 202;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            this.colAddress.Width = 243;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 87;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.OptionsColumn.AllowFocus = false;
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            this.colFax.Width = 81;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "TaxCode";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.OptionsColumn.AllowFocus = false;
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 5;
            this.colTaxCode.Width = 101;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "BankName";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.OptionsColumn.AllowFocus = false;
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 6;
            this.colBankName.Width = 290;
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
            this.colDescription.VisibleIndex = 10;
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
            // colSoHieu
            // 
            this.colSoHieu.AppearanceCell.Options.UseTextOptions = true;
            this.colSoHieu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoHieu.Caption = "SoHieu";
            this.colSoHieu.FieldName = "SoHieu";
            this.colSoHieu.Name = "colSoHieu";
            this.colSoHieu.OptionsColumn.AllowEdit = false;
            this.colSoHieu.OptionsColumn.AllowFocus = false;
            this.colSoHieu.Visible = true;
            this.colSoHieu.VisibleIndex = 8;
            this.colSoHieu.Width = 51;
            // 
            // colBranchCode
            // 
            this.colBranchCode.Caption = "BranchCode";
            this.colBranchCode.ColumnEdit = this.cboBranchCode;
            this.colBranchCode.FieldName = "BranchCode";
            this.colBranchCode.Name = "colBranchCode";
            this.colBranchCode.OptionsColumn.AllowEdit = false;
            this.colBranchCode.OptionsColumn.AllowFocus = false;
            this.colBranchCode.Visible = true;
            this.colBranchCode.VisibleIndex = 9;
            this.colBranchCode.Width = 223;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucCash1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 508);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ucCash1
            // 
            this.ucCash1.Business = null;
            this.ucCash1.DataSource = null;
            this.ucCash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCash1.Location = new System.Drawing.Point(3, 325);
            this.ucCash1.Name = "ucCash1";
            this.ucCash1.Size = new System.Drawing.Size(786, 180);
            this.ucCash1.TabIndex = 7;
            // 
            // FormCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucCash1;
            this.GridControl = this.gridControl;
            this.Name = "FormCash";
            this.Text = "FormCash";
            this.Load += new System.EventHandler(this.FormCash_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBranchCode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCCash ucCash1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboBranchCode;
    }
}