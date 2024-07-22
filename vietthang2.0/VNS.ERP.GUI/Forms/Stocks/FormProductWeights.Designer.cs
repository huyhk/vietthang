namespace VNS.ERP.GUI
{
    partial class FormProductWeights
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
            this.WeightCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Weight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productWeightsControl1 = new VNS.ERP.GUI.UserControl.ProductWeightsControl();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(1, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(718, 199);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WeightCode,
            this.Weight,
            this.Description,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.WeightCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // WeightCode
            // 
            this.WeightCode.Caption = "WeightCode";
            this.WeightCode.FieldName = "WeightCode";
            this.WeightCode.Name = "WeightCode";
            this.WeightCode.OptionsColumn.AllowEdit = false;
            this.WeightCode.OptionsColumn.AllowFocus = false;
            this.WeightCode.OptionsColumn.ReadOnly = true;
            this.WeightCode.OptionsFilter.AllowAutoFilter = false;
            this.WeightCode.OptionsFilter.AllowFilter = false;
            this.WeightCode.Visible = true;
            this.WeightCode.VisibleIndex = 0;
            this.WeightCode.Width = 90;
            // 
            // Weight
            // 
            this.Weight.Caption = "Weight";
            this.Weight.ColumnEdit = this.repositoryItemTextEdit1;
            this.Weight.FieldName = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.OptionsColumn.AllowEdit = false;
            this.Weight.OptionsColumn.AllowFocus = false;
            this.Weight.OptionsColumn.ReadOnly = true;
            this.Weight.OptionsFilter.AllowAutoFilter = false;
            this.Weight.OptionsFilter.AllowFilter = false;
            this.Weight.Visible = true;
            this.Weight.VisibleIndex = 1;
            this.Weight.Width = 90;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.OptionsColumn.AllowFocus = false;
            this.Description.OptionsColumn.ReadOnly = true;
            this.Description.OptionsFilter.AllowAutoFilter = false;
            this.Description.OptionsFilter.AllowFilter = false;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            this.Description.Width = 517;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowEdit = false;
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            this.colUserCreated.OptionsFilter.AllowAutoFilter = false;
            this.colUserCreated.OptionsFilter.AllowFilter = false;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy-hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowEdit = false;
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            this.colDateCreated.OptionsFilter.AllowAutoFilter = false;
            this.colDateCreated.OptionsFilter.AllowFilter = false;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowEdit = false;
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            this.colUserUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colUserUpdated.OptionsFilter.AllowFilter = false;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy-hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowEdit = false;
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            this.colDateUpdated.OptionsFilter.AllowAutoFilter = false;
            this.colDateUpdated.OptionsFilter.AllowFilter = false;
            // 
            // productWeightsControl1
            // 
            this.productWeightsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.productWeightsControl1.Business = null;
            this.productWeightsControl1.DataSource = null;
            this.productWeightsControl1.Location = new System.Drawing.Point(1, 243);
            this.productWeightsControl1.Margin = new System.Windows.Forms.Padding(0);
            this.productWeightsControl1.Name = "productWeightsControl1";
            this.productWeightsControl1.Size = new System.Drawing.Size(718, 105);
            this.productWeightsControl1.TabIndex = 6;
            // 
            // FormProductWeights
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 373);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.productWeightsControl1);
            this.EditControl = this.productWeightsControl1;
            this.GridControl = this.gridControl1;
            this.Name = "FormProductWeights";
            this.Text = "FormProductWeights";
            this.Load += new System.EventHandler(this.ProductWeights_Load);
            this.Controls.SetChildIndex(this.productWeightsControl1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private VNS.ERP.GUI.UserControl.ProductWeightsControl productWeightsControl1;
        private DevExpress.XtraGrid.Columns.GridColumn WeightCode;
        private DevExpress.XtraGrid.Columns.GridColumn Weight;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}