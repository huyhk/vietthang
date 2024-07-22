namespace VNS.ERP.GUI
{
    partial class FormTransportRoute
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
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repStockIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStockOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repStockOut = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIsTrungChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucTransportRoute1 = new VNS.ERP.GUI.UCTransportRoute();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockOut)).BeginInit();
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
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.grid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStockIn,
            this.repStockOut});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(942, 253);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TypeCode,
            this.TypeName,
            this.colStockIn,
            this.colStockOut,
            this.colIsTrungChuyen,
            this.Description,
            this.UserCreated,
            this.DateCreated,
            this.UserUpdated,
            this.DateUpdated});
            this.grid.GridControl = this.gridControl1;
            this.grid.Name = "grid";
            this.grid.OptionsBehavior.Editable = false;
            this.grid.OptionsView.ColumnAutoWidth = false;
            this.grid.OptionsView.ShowFooter = true;
            this.grid.OptionsView.ShowGroupPanel = false;
            this.grid.ViewCaption = "Ma Loai";
            // 
            // TypeCode
            // 
            this.TypeCode.Caption = "Mã";
            this.TypeCode.FieldName = "RouteCode";
            this.TypeCode.Name = "TypeCode";
            this.TypeCode.Visible = true;
            this.TypeCode.VisibleIndex = 0;
            this.TypeCode.Width = 141;
            // 
            // TypeName
            // 
            this.TypeName.Caption = "Tên";
            this.TypeName.FieldName = "RouteName";
            this.TypeName.Name = "TypeName";
            this.TypeName.Visible = true;
            this.TypeName.VisibleIndex = 1;
            this.TypeName.Width = 280;
            // 
            // colStockIn
            // 
            this.colStockIn.Caption = "Kho nhập";
            this.colStockIn.ColumnEdit = this.repStockIn;
            this.colStockIn.FieldName = "StockIn";
            this.colStockIn.Name = "colStockIn";
            this.colStockIn.Visible = true;
            this.colStockIn.VisibleIndex = 2;
            this.colStockIn.Width = 140;
            // 
            // repStockIn
            // 
            this.repStockIn.AutoHeight = false;
            this.repStockIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStockIn.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Kho", 150)});
            this.repStockIn.DisplayMember = "StockName";
            this.repStockIn.Name = "repStockIn";
            this.repStockIn.NullText = "";
            this.repStockIn.PopupWidth = 230;
            this.repStockIn.ValueMember = "StockCode";
            // 
            // colStockOut
            // 
            this.colStockOut.Caption = "Kho xuất";
            this.colStockOut.ColumnEdit = this.repStockOut;
            this.colStockOut.FieldName = "StockOut";
            this.colStockOut.Name = "colStockOut";
            this.colStockOut.Visible = true;
            this.colStockOut.VisibleIndex = 3;
            this.colStockOut.Width = 140;
            // 
            // repStockOut
            // 
            this.repStockOut.AutoHeight = false;
            this.repStockOut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStockOut.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Kho", 150)});
            this.repStockOut.DisplayMember = "StockName";
            this.repStockOut.Name = "repStockOut";
            this.repStockOut.NullText = "";
            this.repStockOut.PopupWidth = 230;
            this.repStockOut.ValueMember = "StockCode";
            // 
            // colIsTrungChuyen
            // 
            this.colIsTrungChuyen.Caption = "Là trung chuyển";
            this.colIsTrungChuyen.FieldName = "IsTrungchuyen";
            this.colIsTrungChuyen.Name = "colIsTrungChuyen";
            this.colIsTrungChuyen.Visible = true;
            this.colIsTrungChuyen.VisibleIndex = 4;
            this.colIsTrungChuyen.Width = 106;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 5;
            this.Description.Width = 304;
            // 
            // UserCreated
            // 
            this.UserCreated.Caption = "Người tạo";
            this.UserCreated.FieldName = "UserCreated";
            this.UserCreated.Name = "UserCreated";
            // 
            // DateCreated
            // 
            this.DateCreated.Caption = "Ngày tạo";
            this.DateCreated.FieldName = "DateCreated";
            this.DateCreated.Name = "DateCreated";
            // 
            // UserUpdated
            // 
            this.UserUpdated.Caption = "Người sửa";
            this.UserUpdated.FieldName = "UserUpdated";
            this.UserUpdated.Name = "UserUpdated";
            // 
            // DateUpdated
            // 
            this.DateUpdated.Caption = "Ngày sửa";
            this.DateUpdated.FieldName = "DateUpdated";
            this.DateUpdated.Name = "DateUpdated";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucTransportRoute1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 389);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ucTransportRoute1
            // 
            this.ucTransportRoute1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ucTransportRoute1, 2);
            this.ucTransportRoute1.Location = new System.Drawing.Point(174, 262);
            this.ucTransportRoute1.Name = "ucTransportRoute1";
            this.ucTransportRoute1.Size = new System.Drawing.Size(600, 124);
            this.ucTransportRoute1.TabIndex = 8;
            // 
            // FormTransportRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl1;
            this.Name = "FormTransportRoute";
            this.Text = "FormTransportRoute";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStockOut)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraGrid.Columns.GridColumn TypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn TypeName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn UserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn UserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn DateUpdated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCTransportRoute ucTransportRoute1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockIn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repStockIn;
        private DevExpress.XtraGrid.Columns.GridColumn colStockOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repStockOut;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTrungChuyen;
    }
}