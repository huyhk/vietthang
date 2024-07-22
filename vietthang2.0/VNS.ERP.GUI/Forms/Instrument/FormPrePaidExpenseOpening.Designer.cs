namespace VNS.ERP.GUI
{
    partial class FormPrePaidExpenseOpening
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
            this.gridOpenning = new DevExpress.XtraGrid.GridControl();
            this.gridViewOpening = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpSubject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpAccount = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrePaidCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrePaidName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrePaidNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrePaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepClassificationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucPrePaidExpenseOpening1 = new VNS.ERP.GUI.UCPrePaidExpenseOpening();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOpening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccount)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.gridOpenning, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPrePaidExpenseOpening1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 508);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridOpenning
            // 
            this.gridOpenning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOpenning.EmbeddedNavigator.Name = "";
            this.gridOpenning.Location = new System.Drawing.Point(3, 359);
            this.gridOpenning.MainView = this.gridViewOpening;
            this.gridOpenning.Name = "gridOpenning";
            this.gridOpenning.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpSubject,
            this.ItemLookUpAccount});
            this.gridOpenning.Size = new System.Drawing.Size(786, 146);
            this.gridOpenning.TabIndex = 1;
            this.gridOpenning.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOpening});
            // 
            // gridViewOpening
            // 
            this.gridViewOpening.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubjectCode,
            this.colAccountCode,
            this.colPrePaidCode,
            this.colPrePaidName,
            this.colUnit,
            this.colQuantity,
            this.colPrice,
            this.colAmount,
            this.colDescription,
            this.colDepStartDate,
            this.colDepRate,
            this.colDepMonth,
            this.colPrePaidNo,
            this.colPrePaidDate,
            this.colDepAccountCode,
            this.colDepSubjectCode,
            this.colDepClassificationCode});
            this.gridViewOpening.GridControl = this.gridOpenning;
            this.gridViewOpening.GroupCount = 2;
            this.gridViewOpening.Name = "gridViewOpening";
            this.gridViewOpening.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewOpening.OptionsBehavior.Editable = false;
            this.gridViewOpening.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewOpening.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewOpening.OptionsPrint.ExpandAllDetails = true;
            this.gridViewOpening.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOpening.OptionsView.ColumnAutoWidth = false;
            this.gridViewOpening.OptionsView.ShowFooter = true;
            this.gridViewOpening.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubjectCode, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAccountCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.ColumnEdit = this.ItemLookUpSubject;
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSubjectCode.Width = 100;
            // 
            // ItemLookUpSubject
            // 
            this.ItemLookUpSubject.AutoHeight = false;
            this.ItemLookUpSubject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpSubject.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "SubjectName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "SubjectCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpSubject.DisplayMember = "SubjectName";
            this.ItemLookUpSubject.Name = "ItemLookUpSubject";
            this.ItemLookUpSubject.NullText = "";
            this.ItemLookUpSubject.PopupWidth = 200;
            this.ItemLookUpSubject.ValueMember = "SubjectCode";
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "AccountCode";
            this.colAccountCode.ColumnEdit = this.ItemLookUpAccount;
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // ItemLookUpAccount
            // 
            this.ItemLookUpAccount.AutoHeight = false;
            this.ItemLookUpAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpAccount.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "AccountCode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "AccountName", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.ItemLookUpAccount.DisplayMember = "AccountName";
            this.ItemLookUpAccount.Name = "ItemLookUpAccount";
            this.ItemLookUpAccount.NullText = "";
            this.ItemLookUpAccount.PopupWidth = 200;
            this.ItemLookUpAccount.ValueMember = "AccountCode";
            // 
            // colPrePaidCode
            // 
            this.colPrePaidCode.Caption = "PrePaidCode";
            this.colPrePaidCode.FieldName = "PrePaidCode";
            this.colPrePaidCode.Name = "colPrePaidCode";
            this.colPrePaidCode.OptionsFilter.AllowFilter = false;
            this.colPrePaidCode.Visible = true;
            this.colPrePaidCode.VisibleIndex = 0;
            this.colPrePaidCode.Width = 91;
            // 
            // colPrePaidName
            // 
            this.colPrePaidName.Caption = "PrePaidName";
            this.colPrePaidName.FieldName = "PrePaidName";
            this.colPrePaidName.Name = "colPrePaidName";
            this.colPrePaidName.OptionsFilter.AllowFilter = false;
            this.colPrePaidName.Visible = true;
            this.colPrePaidName.VisibleIndex = 1;
            this.colPrePaidName.Width = 223;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "Unit";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsFilter.AllowFilter = false;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            this.colUnit.Width = 36;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.DisplayFormat.FormatString = "n0";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 67;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.DisplayFormat.FormatString = "n2";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsFilter.AllowFilter = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 84;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.DisplayFormat.FormatString = "n0";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsFilter.AllowFilter = false;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            this.colAmount.Width = 81;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 14;
            this.colDescription.Width = 451;
            // 
            // colDepStartDate
            // 
            this.colDepStartDate.Caption = "DepStartDate";
            this.colDepStartDate.DisplayFormat.FormatString = "d";
            this.colDepStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDepStartDate.FieldName = "DepStartDate";
            this.colDepStartDate.Name = "colDepStartDate";
            this.colDepStartDate.OptionsFilter.AllowFilter = false;
            this.colDepStartDate.Visible = true;
            this.colDepStartDate.VisibleIndex = 6;
            this.colDepStartDate.Width = 105;
            // 
            // colDepRate
            // 
            this.colDepRate.Caption = "DepRate";
            this.colDepRate.DisplayFormat.FormatString = "p0";
            this.colDepRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDepRate.FieldName = "DepRate";
            this.colDepRate.Name = "colDepRate";
            this.colDepRate.OptionsFilter.AllowFilter = false;
            this.colDepRate.Visible = true;
            this.colDepRate.VisibleIndex = 7;
            this.colDepRate.Width = 84;
            // 
            // colDepMonth
            // 
            this.colDepMonth.Caption = "DepMonth";
            this.colDepMonth.DisplayFormat.FormatString = "n0";
            this.colDepMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDepMonth.FieldName = "DepMonth";
            this.colDepMonth.Name = "colDepMonth";
            this.colDepMonth.OptionsFilter.AllowFilter = false;
            this.colDepMonth.Visible = true;
            this.colDepMonth.VisibleIndex = 8;
            this.colDepMonth.Width = 114;
            // 
            // colPrePaidNo
            // 
            this.colPrePaidNo.Caption = "PrePaidNo";
            this.colPrePaidNo.FieldName = "PrePaidNo";
            this.colPrePaidNo.Name = "colPrePaidNo";
            this.colPrePaidNo.OptionsFilter.AllowFilter = false;
            this.colPrePaidNo.Visible = true;
            this.colPrePaidNo.VisibleIndex = 9;
            this.colPrePaidNo.Width = 82;
            // 
            // colPrePaidDate
            // 
            this.colPrePaidDate.Caption = "PrePaidDate";
            this.colPrePaidDate.DisplayFormat.FormatString = "d";
            this.colPrePaidDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPrePaidDate.FieldName = "PrePaidDate";
            this.colPrePaidDate.Name = "colPrePaidDate";
            this.colPrePaidDate.OptionsFilter.AllowFilter = false;
            this.colPrePaidDate.Visible = true;
            this.colPrePaidDate.VisibleIndex = 10;
            this.colPrePaidDate.Width = 96;
            // 
            // colDepAccountCode
            // 
            this.colDepAccountCode.Caption = "DepAccountCode";
            this.colDepAccountCode.FieldName = "DepAccountCode";
            this.colDepAccountCode.Name = "colDepAccountCode";
            this.colDepAccountCode.OptionsFilter.AllowFilter = false;
            this.colDepAccountCode.Visible = true;
            this.colDepAccountCode.VisibleIndex = 11;
            this.colDepAccountCode.Width = 77;
            // 
            // colDepSubjectCode
            // 
            this.colDepSubjectCode.Caption = "DepSubjectCode";
            this.colDepSubjectCode.FieldName = "DepSubjectCode";
            this.colDepSubjectCode.Name = "colDepSubjectCode";
            this.colDepSubjectCode.OptionsFilter.AllowFilter = false;
            this.colDepSubjectCode.Visible = true;
            this.colDepSubjectCode.VisibleIndex = 12;
            this.colDepSubjectCode.Width = 79;
            // 
            // colDepClassificationCode
            // 
            this.colDepClassificationCode.Caption = "DepClassificationCode";
            this.colDepClassificationCode.FieldName = "DepClassificationCode";
            this.colDepClassificationCode.Name = "colDepClassificationCode";
            this.colDepClassificationCode.OptionsFilter.AllowFilter = false;
            this.colDepClassificationCode.Visible = true;
            this.colDepClassificationCode.VisibleIndex = 13;
            this.colDepClassificationCode.Width = 78;
            // 
            // ucPrePaidExpenseOpening1
            // 
            this.ucPrePaidExpenseOpening1.Business = null;
            this.ucPrePaidExpenseOpening1.DataSource = null;
            this.ucPrePaidExpenseOpening1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPrePaidExpenseOpening1.Location = new System.Drawing.Point(3, 3);
            this.ucPrePaidExpenseOpening1.Name = "ucPrePaidExpenseOpening1";
            this.ucPrePaidExpenseOpening1.Size = new System.Drawing.Size(786, 350);
            this.ucPrePaidExpenseOpening1.TabIndex = 0;
            // 
            // FormPrePaidExpenseOpening
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucPrePaidExpenseOpening1;
            this.GridControl = this.gridOpenning;
            this.Name = "FormPrePaidExpenseOpening";
            this.Text = "FormPrePaidExpenseOpening";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrePaidExpenseOpening_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOpenning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOpening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridOpenning;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOpening;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDepStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrePaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDepAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDepSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDepClassificationCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpSubject;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpAccount;
        private UCPrePaidExpenseOpening ucPrePaidExpenseOpening1;
    }
}