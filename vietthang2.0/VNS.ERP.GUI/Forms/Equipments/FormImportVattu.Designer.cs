namespace VNS.ERP.GUI.Equipments
{
    partial class FormImportVattu
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
            this.colVattuCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVattuName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXemmau = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcessImport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(-1, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(841, 355);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVattuCode,
            this.colVattuName,
            this.Description,
            this.UserCreated,
            this.DateCreated,
            this.UserUpdated,
            this.DateUpdated,
            this.colUnit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ViewCaption = "Ma Loai";
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
            // btnXemmau
            // 
            this.btnXemmau.Location = new System.Drawing.Point(58, 370);
            this.btnXemmau.Name = "btnXemmau";
            this.btnXemmau.Size = new System.Drawing.Size(141, 23);
            this.btnXemmau.TabIndex = 9;
            this.btnXemmau.Text = "Xem mẫu file excel";
            this.btnXemmau.Click += new System.EventHandler(this.btnXemmau_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(242, 370);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(141, 23);
            this.btnSelectFile.TabIndex = 10;
            this.btnSelectFile.Text = "Chọn file import";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnProcessImport
            // 
            this.btnProcessImport.Location = new System.Drawing.Point(426, 370);
            this.btnProcessImport.Name = "btnProcessImport";
            this.btnProcessImport.Size = new System.Drawing.Size(141, 23);
            this.btnProcessImport.TabIndex = 11;
            this.btnProcessImport.Text = "Tiến hành import";
            this.btnProcessImport.Click += new System.EventHandler(this.btnProcessImport_Click);
            // 
            // FormImportVattu
            // 
            this.ClientSize = new System.Drawing.Size(839, 417);
            this.Controls.Add(this.btnProcessImport);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnXemmau);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormImportVattu";
            this.Text = "Import mã vật tư từ file excel";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVattuName;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn UserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn UserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn DateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraEditors.SimpleButton btnXemmau;
        private DevExpress.XtraEditors.SimpleButton btnSelectFile;
        private DevExpress.XtraEditors.SimpleButton btnProcessImport;
    }
}
