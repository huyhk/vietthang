namespace VNS.ERP.GUI.Equipments
{
    partial class FormVattuOldType
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVattuCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVattuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucVattuOldType1 = new VNS.ERP.GUI.Equipments.UCVattuOldType();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucVattuOldType1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 292);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.gridControl1.Size = new System.Drawing.Size(797, 185);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid});
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVattuCode,
            this.colVattuName,
            this.Description,
            this.UserCreated,
            this.DateCreated,
            this.UserUpdated,
            this.DateUpdated});
            this.grid.GridControl = this.gridControl1;
            this.grid.Name = "grid";
            this.grid.OptionsBehavior.Editable = false;
            this.grid.OptionsView.ShowFooter = true;
            this.grid.OptionsView.ShowGroupPanel = false;
            this.grid.ViewCaption = "Ma Loai";
            // 
            // colVattuCode
            // 
            this.colVattuCode.Caption = "Mã vật tư";
            this.colVattuCode.FieldName = "TypeCode";
            this.colVattuCode.Name = "colVattuCode";
            this.colVattuCode.Visible = true;
            this.colVattuCode.VisibleIndex = 0;
            this.colVattuCode.Width = 83;
            // 
            // colVattuName
            // 
            this.colVattuName.Caption = "Tên vật tư";
            this.colVattuName.FieldName = "TypeName";
            this.colVattuName.Name = "colVattuName";
            this.colVattuName.Visible = true;
            this.colVattuName.VisibleIndex = 1;
            this.colVattuName.Width = 128;
            // 
            // Description
            // 
            this.Description.Caption = "Mô tả";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 2;
            this.Description.Width = 335;
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
            this.DateCreated.DisplayFormat.FormatString = "d";
            this.DateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
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
            this.DateUpdated.DisplayFormat.FormatString = "d";
            this.DateUpdated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateUpdated.FieldName = "DateUpdated";
            this.DateUpdated.Name = "DateUpdated";
            // 
            // ucVattuOldType1
            // 
            this.ucVattuOldType1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVattuOldType1.Business = null;
            this.ucVattuOldType1.DataSource = null;
            this.ucVattuOldType1.Location = new System.Drawing.Point(3, 194);
            this.ucVattuOldType1.Name = "ucVattuOldType1";
            this.ucVattuOldType1.Size = new System.Drawing.Size(343, 95);
            this.ucVattuOldType1.TabIndex = 9;
            // 
            // FormVattuOldType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 369);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucVattuOldType1;
            this.GridControl = this.gridControl1;
            this.Name = "FormVattuOldType";
            this.Text = "FormVattuOldType";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grid;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn UserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn UserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn DateUpdated;
        private VNS.ERP.GUI.Equipments.UCVattuOldType ucVattuOldType1;
    }
}