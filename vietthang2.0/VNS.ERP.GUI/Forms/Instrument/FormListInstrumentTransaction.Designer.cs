namespace VNS.ERP.GUI
{
    partial class FormListInstrumentTransaction
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebitAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescriptionDetail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountTransactionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colDebitAmount,
            this.colCreditAmount,
            this.colDescriptionDetail1});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.AutoZoomDetail = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "Tài khoản";
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 0;
            this.colAccountCode.Width = 59;
            // 
            // colDebitAmount
            // 
            this.colDebitAmount.Caption = "Nợ";
            this.colDebitAmount.DisplayFormat.FormatString = "#,###";
            this.colDebitAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebitAmount.FieldName = "DebitAmount";
            this.colDebitAmount.Name = "colDebitAmount";
            this.colDebitAmount.Visible = true;
            this.colDebitAmount.VisibleIndex = 1;
            this.colDebitAmount.Width = 110;
            // 
            // colCreditAmount
            // 
            this.colCreditAmount.Caption = "Có";
            this.colCreditAmount.DisplayFormat.FormatString = "#,###";
            this.colCreditAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditAmount.FieldName = "CreditAmount";
            this.colCreditAmount.Name = "colCreditAmount";
            this.colCreditAmount.Visible = true;
            this.colCreditAmount.VisibleIndex = 2;
            this.colCreditAmount.Width = 110;
            // 
            // colDescriptionDetail1
            // 
            this.colDescriptionDetail1.Caption = "Diễn giải";
            this.colDescriptionDetail1.FieldName = "Description";
            this.colDescriptionDetail1.Name = "colDescriptionDetail1";
            this.colDescriptionDetail1.Visible = true;
            this.colDescriptionDetail1.VisibleIndex = 3;
            this.colDescriptionDetail1.Width = 515;
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Detail1";
            this.gridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl.Location = new System.Drawing.Point(3, 74);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(799, 325);
            this.gridControl.TabIndex = 15;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.ChildGridLevelName = "Detail1";
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountTransactionNo,
            this.colAccountTransactionDate,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView.DefaultRelationIndex = 1;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsDetail.ShowDetailTabs = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick_1);
            // 
            // colAccountTransactionNo
            // 
            this.colAccountTransactionNo.Caption = "AccountTransactionNo";
            this.colAccountTransactionNo.FieldName = "AccountTransactionNo";
            this.colAccountTransactionNo.Name = "colAccountTransactionNo";
            this.colAccountTransactionNo.Visible = true;
            this.colAccountTransactionNo.VisibleIndex = 0;
            this.colAccountTransactionNo.Width = 103;
            // 
            // colAccountTransactionDate
            // 
            this.colAccountTransactionDate.Caption = "AccountTransactionDate";
            this.colAccountTransactionDate.DisplayFormat.FormatString = "d";
            this.colAccountTransactionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAccountTransactionDate.FieldName = "AccountTransactionDate";
            this.colAccountTransactionDate.Name = "colAccountTransactionDate";
            this.colAccountTransactionDate.Visible = true;
            this.colAccountTransactionDate.VisibleIndex = 1;
            this.colAccountTransactionDate.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 293;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 97;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 118;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 112;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 101;
            // 
            // lbPeriod
            // 
            this.lbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPeriod.Location = new System.Drawing.Point(607, 45);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(68, 18);
            this.lbPeriod.TabIndex = 14;
            this.lbPeriod.Text = "Kỳ kế toán";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpPeriod.Location = new System.Drawing.Point(679, 45);
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
            this.lookUpPeriod.TabIndex = 13;
            this.lookUpPeriod.EditValueChanged += new System.EventHandler(this.lookUpPeriod_EditValueChanged);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(3, 45);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(36, 24);
            this.btnLoadData.TabIndex = 16;
            this.btnLoadData.Text = "+";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // FormListInstrumentTransaction
            // 
            this.AllowSave = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 425);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.GridControl = this.gridControl;
            this.Name = "FormListInstrumentTransaction";
            this.Text = "FormListInstrumentTransaction";
            this.Controls.SetChildIndex(this.lookUpPeriod, 0);
            this.Controls.SetChildIndex(this.lbPeriod, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            this.Controls.SetChildIndex(this.btnLoadData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDebitAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriptionDetail1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTransactionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
    }
}