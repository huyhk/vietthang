namespace VNS.ERP.GUI.Equipments
{
    partial class FormVattu
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
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucVattu1 = new VNS.ERP.GUI.Equipments.UCVattu();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52855F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucVattu1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 414);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.grid;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(817, 275);
            this.gridControl1.TabIndex = 7;
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
            this.DateUpdated,
            this.colUnit});
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
            this.colVattuCode.FieldName = "VattuCode";
            this.colVattuCode.Name = "colVattuCode";
            this.colVattuCode.Visible = true;
            this.colVattuCode.VisibleIndex = 0;
            this.colVattuCode.Width = 83;
            // 
            // colVattuName
            // 
            this.colVattuName.Caption = "Tên vật tư";
            this.colVattuName.FieldName = "VattuName";
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
            this.Description.VisibleIndex = 3;
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
            // colUnit
            // 
            this.colUnit.Caption = "Đơn vị";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            // 
            // ucVattu1
            // 
            this.ucVattu1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVattu1.Location = new System.Drawing.Point(3, 284);
            this.ucVattu1.Name = "ucVattu1";
            this.ucVattu1.Size = new System.Drawing.Size(360, 127);
            this.ucVattu1.TabIndex = 8;
            // 
            // FormVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucVattu1;
            this.GridControl = this.gridControl1;
            this.Name = "FormVattu";
            this.Text = "FormVattu";
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
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private UCVattu ucVattu1;
    }
}