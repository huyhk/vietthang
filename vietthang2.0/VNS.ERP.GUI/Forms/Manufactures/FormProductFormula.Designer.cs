namespace VNS.ERP.GUI
{
    partial class FormProductFormula
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
            this.usrDetailProductFormula1 = new VNS.ERP.GUI.UserControl.DetailProductFormula();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetail = new System.Windows.Forms.Button();
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
            // usrDetailProductFormula1
            // 
            this.usrDetailProductFormula1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usrDetailProductFormula1.Business = null;
            this.usrDetailProductFormula1.DataSource = null;
            this.usrDetailProductFormula1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrDetailProductFormula1.Location = new System.Drawing.Point(5, 305);
            this.usrDetailProductFormula1.Name = "usrDetailProductFormula1";
            this.usrDetailProductFormula1.Size = new System.Drawing.Size(386, 87);
            this.usrDetailProductFormula1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 44);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(745, 258);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFormulaCode,
            this.colDescription,
            this.colUserCreated,
            this.colDateCreated,
            this.colUserUpdated,
            this.colDateUpdated});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(590, 420, 208, 170);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "FormulaCode";
            this.colFormulaCode.ColumnEdit = this.repositoryItemTextEdit1;
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.OptionsColumn.AllowEdit = false;
            this.colFormulaCode.OptionsColumn.AllowFocus = false;
            this.colFormulaCode.OptionsColumn.ReadOnly = true;
            this.colFormulaCode.OptionsFilter.AllowAutoFilter = false;
            this.colFormulaCode.OptionsFilter.AllowFilter = false;
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 0;
            this.colFormulaCode.Width = 109;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
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
            this.colDescription.Width = 527;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.OptionsColumn.AllowEdit = false;
            this.colUserCreated.OptionsColumn.AllowFocus = false;
            this.colUserCreated.OptionsColumn.ReadOnly = true;
            this.colUserCreated.Width = 109;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.OptionsColumn.AllowEdit = false;
            this.colDateCreated.OptionsColumn.AllowFocus = false;
            this.colDateCreated.OptionsColumn.ReadOnly = true;
            this.colDateCreated.Width = 109;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.OptionsColumn.AllowEdit = false;
            this.colUserUpdated.OptionsColumn.AllowFocus = false;
            this.colUserUpdated.OptionsColumn.ReadOnly = true;
            this.colUserUpdated.Width = 109;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy - hh:mm:ss";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.OptionsColumn.AllowEdit = false;
            this.colDateUpdated.OptionsColumn.AllowFocus = false;
            this.colDateUpdated.OptionsColumn.ReadOnly = true;
            this.colDateUpdated.Width = 114;
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetail.Location = new System.Drawing.Point(397, 337);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(249, 45);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // FormProductFormula
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 424);
            this.Controls.Add(this.usrDetailProductFormula1);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormProductFormula";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.btnDetail, 0);
            this.Controls.SetChildIndex(this.usrDetailProductFormula1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControl.DetailProductFormula usrDetailProductFormula1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.Button btnDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}