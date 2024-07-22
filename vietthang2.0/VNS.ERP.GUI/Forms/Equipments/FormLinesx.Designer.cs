namespace VNS.ERP.GUI.Equipments
{
    partial class FormLinesx
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
            this.ucLinesx1 = new VNS.ERP.GUI.Equipments.UCLinesx();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLinesxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNangsuatLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNangsuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucLinesx1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 394);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ucLinesx1
            // 
            this.ucLinesx1.Business = null;
            this.ucLinesx1.DataSource = null;
            this.ucLinesx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLinesx1.Location = new System.Drawing.Point(3, 3);
            this.ucLinesx1.Name = "ucLinesx1";
            this.ucLinesx1.Size = new System.Drawing.Size(804, 106);
            this.ucLinesx1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 115);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(804, 276);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLinesxNo,
            this.colStockCode,
            this.colNangsuatLot,
            this.colNangsuat,
            this.colDescription,
            this.colUserCreated,
            this.colUserUpdated,
            this.colDateUpdated,
            this.colDateCreated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colLinesxNo
            // 
            this.colLinesxNo.Caption = "LinesxNo";
            this.colLinesxNo.DisplayFormat.FormatString = "n0";
            this.colLinesxNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLinesxNo.FieldName = "LinesxNo";
            this.colLinesxNo.Name = "colLinesxNo";
            this.colLinesxNo.Visible = true;
            this.colLinesxNo.VisibleIndex = 0;
            this.colLinesxNo.Width = 122;
            // 
            // colStockCode
            // 
            this.colStockCode.Caption = "StockCode";
            this.colStockCode.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 1;
            this.colStockCode.Width = 109;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.repositoryItemLookUpEdit1.DisplayMember = "StockName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "StockCode";
            // 
            // colNangsuatLot
            // 
            this.colNangsuatLot.Caption = "NangsuatLot";
            this.colNangsuatLot.DisplayFormat.FormatString = "n0";
            this.colNangsuatLot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNangsuatLot.FieldName = "NangsuatLot";
            this.colNangsuatLot.Name = "colNangsuatLot";
            this.colNangsuatLot.Visible = true;
            this.colNangsuatLot.VisibleIndex = 2;
            this.colNangsuatLot.Width = 120;
            // 
            // colNangsuat
            // 
            this.colNangsuat.Caption = "Nangsuat";
            this.colNangsuat.DisplayFormat.FormatString = "n0";
            this.colNangsuat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNangsuat.FieldName = "Nangsuat";
            this.colNangsuat.Name = "colNangsuat";
            this.colNangsuat.Visible = true;
            this.colNangsuat.VisibleIndex = 3;
            this.colNangsuat.Width = 105;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 400;
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
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "DateUpdated";
            this.colDateUpdated.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colDateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            this.colDateUpdated.Width = 120;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "DateCreated";
            this.colDateCreated.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Width = 120;
            // 
            // FormLinesx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucLinesx1;
            this.GridControl = this.gridControl1;
            this.Name = "FormLinesx";
            this.Text = "FormLinesx";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCLinesx ucLinesx1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colNangsuatLot;
        private DevExpress.XtraGrid.Columns.GridColumn colNangsuat;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLinesxNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
    }
}
