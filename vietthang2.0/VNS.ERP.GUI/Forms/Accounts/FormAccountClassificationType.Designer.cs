namespace VNS.ERP.GUI.Accounting
{
    partial class FormAccountClassificationType
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
            this.colClassificationTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificationTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucAccountClassificationType1 = new VNS.ERP.GUI.UCAccountClassificationType();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(601, 180);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClassificationTypeCode,
            this.colClassificationTypeName,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateCreated,
            this.colDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colClassificationTypeCode
            // 
            this.colClassificationTypeCode.Caption = "ClassificationTypeCode";
            this.colClassificationTypeCode.FieldName = "ClassificationTypeCode";
            this.colClassificationTypeCode.Name = "colClassificationTypeCode";
            this.colClassificationTypeCode.Visible = true;
            this.colClassificationTypeCode.VisibleIndex = 0;
            this.colClassificationTypeCode.Width = 64;
            // 
            // colClassificationTypeName
            // 
            this.colClassificationTypeName.Caption = "ClassificationTypeName";
            this.colClassificationTypeName.FieldName = "ClassificationTypeName";
            this.colClassificationTypeName.Name = "colClassificationTypeName";
            this.colClassificationTypeName.Visible = true;
            this.colClassificationTypeName.VisibleIndex = 1;
            this.colClassificationTypeName.Width = 298;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 592;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "UserCreated";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            this.colUserCreated.Width = 80;
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "UserUpdated";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            this.colUserUpdated.Width = 80;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 80;
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 80;
            // 
            // ucAccountClassificationType1
            // 
            this.ucAccountClassificationType1.Business = null;
            this.ucAccountClassificationType1.DataSource = null;
            this.ucAccountClassificationType1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucAccountClassificationType1.Location = new System.Drawing.Point(3, 189);
            this.ucAccountClassificationType1.Name = "ucAccountClassificationType1";
            this.ucAccountClassificationType1.Size = new System.Drawing.Size(601, 116);
            this.ucAccountClassificationType1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucAccountClassificationType1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 308);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormAccountClassificationType
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucAccountClassificationType1;
            this.GridControl = this.gridControl1;
            this.Name = "FormAccountClassificationType";
            this.Text = "FormAccountClassificationType";
            this.Load += new System.EventHandler(this.FormAccountClassificationType_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificationTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificationTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private UCAccountClassificationType ucAccountClassificationType1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    }
}