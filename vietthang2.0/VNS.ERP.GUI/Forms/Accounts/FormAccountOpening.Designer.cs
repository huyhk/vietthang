namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountOpening
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpAccountCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDebitOpeningAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextEditOpeningAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCreditOpeningAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemLookUpCurrencyCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDebitOpeningAmountNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repItemTextEditAmountNT = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCreditOpeningAmountNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCopyFromFixedAssetOpenings = new System.Windows.Forms.Button();
            this.btnFromCustomerDeptSumOpenings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccountCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditOpeningAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCurrencyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditAmountNT)).BeginInit();
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
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 341);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpAccountCode,
            this.ItemTextEditOpeningAmount,
            this.ItemTextSubjectCode,
            this.repItemLookUpCurrencyCode,
            this.repItemTextEditAmountNT});
            this.gridControl.Size = new System.Drawing.Size(806, 335);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colSubjectCode,
            this.colDebitOpeningAmount,
            this.colCreditOpeningAmount,
            this.colCurrencyCode,
            this.colDebitOpeningAmountNT,
            this.colCreditOpeningAmountNT});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_KeyDown);
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "AccountCode";
            this.colAccountCode.ColumnEdit = this.ItemLookUpAccountCode;
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 0;
            this.colAccountCode.Width = 104;
            // 
            // ItemLookUpAccountCode
            // 
            this.ItemLookUpAccountCode.AutoHeight = false;
            this.ItemLookUpAccountCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpAccountCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã tài khoản", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên tài khoản", 220)});
            this.ItemLookUpAccountCode.DisplayMember = "AccountCode";
            this.ItemLookUpAccountCode.Name = "ItemLookUpAccountCode";
            this.ItemLookUpAccountCode.NullText = "";
            this.ItemLookUpAccountCode.PopupWidth = 300;
            this.ItemLookUpAccountCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpAccountCode.ValueMember = "AccountCode";
            this.ItemLookUpAccountCode.Leave += new System.EventHandler(this.ItemLookUpAccountCode_Leave);
            this.ItemLookUpAccountCode.EditValueChanged += new System.EventHandler(this.ItemLookUpAccountCode_EditValueChanged);
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "SubjectCode";
            this.colSubjectCode.ColumnEdit = this.ItemTextSubjectCode;
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 1;
            this.colSubjectCode.Width = 103;
            // 
            // ItemTextSubjectCode
            // 
            this.ItemTextSubjectCode.AutoHeight = false;
            this.ItemTextSubjectCode.Name = "ItemTextSubjectCode";
            this.ItemTextSubjectCode.ValidateOnEnterKey = true;
            this.ItemTextSubjectCode.EditValueChanged += new System.EventHandler(this.ItemTextSubjectCode_EditValueChanged);
            this.ItemTextSubjectCode.Leave += new System.EventHandler(this.ItemTextSubjectCode_Leave);
            // 
            // colDebitOpeningAmount
            // 
            this.colDebitOpeningAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colDebitOpeningAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDebitOpeningAmount.Caption = "Nợ";
            this.colDebitOpeningAmount.ColumnEdit = this.ItemTextEditOpeningAmount;
            this.colDebitOpeningAmount.FieldName = "DebitOpeningAmount";
            this.colDebitOpeningAmount.Name = "colDebitOpeningAmount";
            this.colDebitOpeningAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDebitOpeningAmount.Visible = true;
            this.colDebitOpeningAmount.VisibleIndex = 2;
            this.colDebitOpeningAmount.Width = 114;
            // 
            // ItemTextEditOpeningAmount
            // 
            this.ItemTextEditOpeningAmount.Appearance.Options.UseTextOptions = true;
            this.ItemTextEditOpeningAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemTextEditOpeningAmount.AutoHeight = false;
            this.ItemTextEditOpeningAmount.Mask.EditMask = "n0";
            this.ItemTextEditOpeningAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextEditOpeningAmount.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextEditOpeningAmount.Name = "ItemTextEditOpeningAmount";
            this.ItemTextEditOpeningAmount.NullText = "0";
            this.ItemTextEditOpeningAmount.ValidateOnEnterKey = true;
            // 
            // colCreditOpeningAmount
            // 
            this.colCreditOpeningAmount.Caption = "Có";
            this.colCreditOpeningAmount.ColumnEdit = this.ItemTextEditOpeningAmount;
            this.colCreditOpeningAmount.FieldName = "CreditOpeningAmount";
            this.colCreditOpeningAmount.Name = "colCreditOpeningAmount";
            this.colCreditOpeningAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCreditOpeningAmount.Visible = true;
            this.colCreditOpeningAmount.VisibleIndex = 3;
            this.colCreditOpeningAmount.Width = 115;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.Caption = "Ngoại tệ";
            this.colCurrencyCode.ColumnEdit = this.repItemLookUpCurrencyCode;
            this.colCurrencyCode.FieldName = "CurrencyCode";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.Visible = true;
            this.colCurrencyCode.VisibleIndex = 4;
            this.colCurrencyCode.Width = 92;
            // 
            // repItemLookUpCurrencyCode
            // 
            this.repItemLookUpCurrencyCode.AutoHeight = false;
            this.repItemLookUpCurrencyCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repItemLookUpCurrencyCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName")});
            this.repItemLookUpCurrencyCode.DisplayMember = "CurrencyName";
            this.repItemLookUpCurrencyCode.Name = "repItemLookUpCurrencyCode";
            this.repItemLookUpCurrencyCode.NullText = "";
            this.repItemLookUpCurrencyCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repItemLookUpCurrencyCode.ValueMember = "CurrencyCode";
            // 
            // colDebitOpeningAmountNT
            // 
            this.colDebitOpeningAmountNT.Caption = "Nợ NT";
            this.colDebitOpeningAmountNT.ColumnEdit = this.repItemTextEditAmountNT;
            this.colDebitOpeningAmountNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebitOpeningAmountNT.FieldName = "DebitOpeningAmountNT";
            this.colDebitOpeningAmountNT.Name = "colDebitOpeningAmountNT";
            this.colDebitOpeningAmountNT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDebitOpeningAmountNT.Visible = true;
            this.colDebitOpeningAmountNT.VisibleIndex = 5;
            this.colDebitOpeningAmountNT.Width = 119;
            // 
            // repItemTextEditAmountNT
            // 
            this.repItemTextEditAmountNT.AutoHeight = false;
            this.repItemTextEditAmountNT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditAmountNT.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repItemTextEditAmountNT.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repItemTextEditAmountNT.Name = "repItemTextEditAmountNT";
            // 
            // colCreditOpeningAmountNT
            // 
            this.colCreditOpeningAmountNT.Caption = "Có NT";
            this.colCreditOpeningAmountNT.ColumnEdit = this.repItemTextEditAmountNT;
            this.colCreditOpeningAmountNT.FieldName = "CreditOpeningAmountNT";
            this.colCreditOpeningAmountNT.Name = "colCreditOpeningAmountNT";
            this.colCreditOpeningAmountNT.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCreditOpeningAmountNT.Visible = true;
            this.colCreditOpeningAmountNT.VisibleIndex = 6;
            this.colCreditOpeningAmountNT.Width = 128;
            // 
            // btnCopyFromFixedAssetOpenings
            // 
            this.btnCopyFromFixedAssetOpenings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyFromFixedAssetOpenings.Location = new System.Drawing.Point(599, 43);
            this.btnCopyFromFixedAssetOpenings.Name = "btnCopyFromFixedAssetOpenings";
            this.btnCopyFromFixedAssetOpenings.Size = new System.Drawing.Size(212, 21);
            this.btnCopyFromFixedAssetOpenings.TabIndex = 6;
            this.btnCopyFromFixedAssetOpenings.Text = "Lấy thông tin tồn đầu tài sản cố định";
            this.btnCopyFromFixedAssetOpenings.UseVisualStyleBackColor = true;
            this.btnCopyFromFixedAssetOpenings.Click += new System.EventHandler(this.btnCopyFromFixedAssetOpenings_Click);
            // 
            // btnFromCustomerDeptSumOpenings
            // 
            this.btnFromCustomerDeptSumOpenings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFromCustomerDeptSumOpenings.Location = new System.Drawing.Point(367, 43);
            this.btnFromCustomerDeptSumOpenings.Name = "btnFromCustomerDeptSumOpenings";
            this.btnFromCustomerDeptSumOpenings.Size = new System.Drawing.Size(226, 21);
            this.btnFromCustomerDeptSumOpenings.TabIndex = 7;
            this.btnFromCustomerDeptSumOpenings.Text = "Lấy thông tin tồn đầu công nợ khách hàng";
            this.btnFromCustomerDeptSumOpenings.UseVisualStyleBackColor = true;
            this.btnFromCustomerDeptSumOpenings.Click += new System.EventHandler(this.btnFromCustomerDeptSumOpenings_Click);
            // 
            // FormAccountOpening
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 436);
            this.Controls.Add(this.btnFromCustomerDeptSumOpenings);
            this.Controls.Add(this.btnCopyFromFixedAssetOpenings);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl;
            this.Name = "FormAccountOpening";
            this.Text = "FormAccountOpening";
            this.Load += new System.EventHandler(this.FormAccountOpening_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnCopyFromFixedAssetOpenings, 0);
            this.Controls.SetChildIndex(this.btnFromCustomerDeptSumOpenings, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpAccountCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditOpeningAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemLookUpCurrencyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repItemTextEditAmountNT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitOpeningAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpAccountCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextEditOpeningAmount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextSubjectCode;
        private System.Windows.Forms.Button btnCopyFromFixedAssetOpenings;
        private System.Windows.Forms.Button btnFromCustomerDeptSumOpenings;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditOpeningAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitOpeningAmountNT;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditOpeningAmountNT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repItemLookUpCurrencyCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repItemTextEditAmountNT;
    }
}