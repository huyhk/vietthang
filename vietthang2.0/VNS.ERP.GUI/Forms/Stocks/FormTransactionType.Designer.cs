namespace VNS.ERP.GUI
{
    partial class FormTransactionType
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
            this.gridtransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockTransaction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.usrDetailTransactionType = new VNS.ERP.GUI.UserControl.DetailTransactionType();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtransaction)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(2, 44);
            this.gridControl1.MainView = this.gridtransaction;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(738, 231);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridtransaction});
            // 
            // gridtransaction
            // 
            this.gridtransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionTypeCode,
            this.colDescription,
            this.colStockTransaction,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridtransaction.GridControl = this.gridControl1;
            this.gridtransaction.Name = "gridtransaction";
            this.gridtransaction.OptionsNavigation.AutoFocusNewRow = true;
            this.gridtransaction.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridtransaction.OptionsView.ColumnAutoWidth = false;
            this.gridtransaction.OptionsView.ShowFooter = true;
            this.gridtransaction.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionTypeCode
            // 
            this.colTransactionTypeCode.Caption = "TransactionTypeCode";
            this.colTransactionTypeCode.FieldName = "TransactionTypeCode";
            this.colTransactionTypeCode.Name = "colTransactionTypeCode";
            this.colTransactionTypeCode.OptionsColumn.AllowEdit = false;
            this.colTransactionTypeCode.OptionsColumn.AllowFocus = false;
            this.colTransactionTypeCode.OptionsColumn.ReadOnly = true;
            this.colTransactionTypeCode.OptionsFilter.AllowAutoFilter = false;
            this.colTransactionTypeCode.OptionsFilter.AllowFilter = false;
            this.colTransactionTypeCode.Visible = true;
            this.colTransactionTypeCode.VisibleIndex = 0;
            this.colTransactionTypeCode.Width = 116;
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
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 502;
            // 
            // colStockTransaction
            // 
            this.colStockTransaction.Caption = "StockTransaction";
            this.colStockTransaction.FieldName = "StockTransaction";
            this.colStockTransaction.Name = "colStockTransaction";
            this.colStockTransaction.OptionsColumn.AllowEdit = false;
            this.colStockTransaction.OptionsColumn.AllowFocus = false;
            this.colStockTransaction.OptionsColumn.ReadOnly = true;
            this.colStockTransaction.Width = 74;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowEdit = false;
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            this.colUserCreated.Width = 84;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowEdit = false;
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            this.colDateCreated.Width = 84;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowEdit = false;
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            this.colUserUpdated.Width = 84;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowEdit = false;
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            this.colDateUpdated.Width = 107;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // usrDetailTransactionType
            // 
            this.usrDetailTransactionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usrDetailTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrDetailTransactionType.Location = new System.Drawing.Point(2, 282);
            this.usrDetailTransactionType.Margin = new System.Windows.Forms.Padding(4);
            this.usrDetailTransactionType.Name = "usrDetailTransactionType";
            this.usrDetailTransactionType.Size = new System.Drawing.Size(738, 114);
            this.usrDetailTransactionType.TabIndex = 6;
            // 
            // FormTransactionType
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 426);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.usrDetailTransactionType);
            this.EditControl = this.usrDetailTransactionType;
            this.GridControl = this.gridControl1;
            this.Name = "FormTransactionType";
            this.Text = "FormTransactionTypes";
            this.Load += new System.EventHandler(this.FormTransactionTypes_Load);
            this.Controls.SetChildIndex(this.usrDetailTransactionType, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridtransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridtransaction;
        private VNS.ERP.GUI.UserControl.DetailTransactionType usrDetailTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTypeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStockTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
    }
}

