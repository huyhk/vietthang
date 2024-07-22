namespace VNS.ERP.GUI.Sales
{
    partial class FormRpCTXuatTPThang
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboStartDate = new DevExpress.XtraEditors.DateEdit();
            this.cboEndDate = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExports = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLKSoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLKDoanhso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoluongKytruoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoanhsoKytruoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDate.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.18966F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.81035F));
            this.tableLayoutPanel2.Controls.Add(this.btnLoadData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(696, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoadData.Location = new System.Drawing.Point(234, 15);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(122, 29);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Xem";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.22222F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.77778F));
            this.tableLayoutPanel3.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblEndDate, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboStartDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboEndDate, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(225, 54);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(64, 7);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(54, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "StartDate";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(70, 34);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(48, 13);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "EndDate";
            // 
            // cboStartDate
            // 
            this.cboStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStartDate.EditValue = new System.DateTime(2007, 8, 18, 8, 31, 57, 122);
            this.cboStartDate.EnterMoveNextControl = true;
            this.cboStartDate.Location = new System.Drawing.Point(124, 3);
            this.cboStartDate.Name = "cboStartDate";
            this.cboStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboStartDate.Size = new System.Drawing.Size(97, 20);
            this.cboStartDate.TabIndex = 1;
            // 
            // cboEndDate
            // 
            this.cboEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboEndDate.EditValue = new System.DateTime(2007, 8, 18, 8, 31, 57, 122);
            this.cboEndDate.EnterMoveNextControl = true;
            this.cboEndDate.Location = new System.Drawing.Point(124, 30);
            this.cboEndDate.Name = "cboEndDate";
            this.cboEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboEndDate.Size = new System.Drawing.Size(97, 20);
            this.cboEndDate.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnExports, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(702, 440);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnExports
            // 
            this.btnExports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExports.Location = new System.Drawing.Point(290, 409);
            this.btnExports.Name = "btnExports";
            this.btnExports.Size = new System.Drawing.Size(122, 28);
            this.btnExports.TabIndex = 1;
            this.btnExports.Text = "Exports";
            this.btnExports.Click += new System.EventHandler(this.btnExports_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(696, 334);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTinh,
            this.colItemCode,
            this.colSoluong,
            this.colDoanhso,
            this.colLKSoluong,
            this.colLKDoanhso,
            this.colSoluongKytruoc,
            this.colDoanhsoKytruoc,
            this.colCustomerCode,
            this.colSubjectName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTinh, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTinh
            // 
            this.colTinh.Caption = "Tinh";
            this.colTinh.FieldName = "Tinh";
            this.colTinh.Name = "colTinh";
            this.colTinh.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colTinh.Width = 100;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "ItemCode";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsFilter.AllowAutoFilter = false;
            this.colItemCode.OptionsFilter.AllowFilter = false;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 98;
            // 
            // colSoluong
            // 
            this.colSoluong.Caption = "Soluong";
            this.colSoluong.DisplayFormat.FormatString = "n0";
            this.colSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoluong.FieldName = "Soluong";
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.OptionsFilter.AllowAutoFilter = false;
            this.colSoluong.OptionsFilter.AllowFilter = false;
            this.colSoluong.SummaryItem.DisplayFormat = "{0:n0}";
            this.colSoluong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoluong.Visible = true;
            this.colSoluong.VisibleIndex = 2;
            this.colSoluong.Width = 110;
            // 
            // colDoanhso
            // 
            this.colDoanhso.Caption = "Doanhso";
            this.colDoanhso.DisplayFormat.FormatString = "n0";
            this.colDoanhso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDoanhso.FieldName = "Doanhso";
            this.colDoanhso.Name = "colDoanhso";
            this.colDoanhso.OptionsFilter.AllowAutoFilter = false;
            this.colDoanhso.OptionsFilter.AllowFilter = false;
            this.colDoanhso.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDoanhso.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDoanhso.Visible = true;
            this.colDoanhso.VisibleIndex = 3;
            this.colDoanhso.Width = 99;
            // 
            // colLKSoluong
            // 
            this.colLKSoluong.Caption = "LKSoluong";
            this.colLKSoluong.DisplayFormat.FormatString = "n0";
            this.colLKSoluong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLKSoluong.FieldName = "LKSoluong";
            this.colLKSoluong.Name = "colLKSoluong";
            this.colLKSoluong.OptionsFilter.AllowAutoFilter = false;
            this.colLKSoluong.OptionsFilter.AllowFilter = false;
            this.colLKSoluong.SummaryItem.DisplayFormat = "{0:n0}";
            this.colLKSoluong.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLKSoluong.Visible = true;
            this.colLKSoluong.VisibleIndex = 4;
            this.colLKSoluong.Width = 105;
            // 
            // colLKDoanhso
            // 
            this.colLKDoanhso.Caption = "LKDoanhso";
            this.colLKDoanhso.DisplayFormat.FormatString = "n0";
            this.colLKDoanhso.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLKDoanhso.FieldName = "LKDoanhso";
            this.colLKDoanhso.Name = "colLKDoanhso";
            this.colLKDoanhso.OptionsFilter.AllowAutoFilter = false;
            this.colLKDoanhso.OptionsFilter.AllowFilter = false;
            this.colLKDoanhso.SummaryItem.DisplayFormat = "{0:n0}";
            this.colLKDoanhso.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colLKDoanhso.Visible = true;
            this.colLKDoanhso.VisibleIndex = 5;
            this.colLKDoanhso.Width = 100;
            // 
            // colSoluongKytruoc
            // 
            this.colSoluongKytruoc.Caption = "SoluongKytruoc";
            this.colSoluongKytruoc.DisplayFormat.FormatString = "n0";
            this.colSoluongKytruoc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoluongKytruoc.FieldName = "SoluongKytruoc";
            this.colSoluongKytruoc.Name = "colSoluongKytruoc";
            this.colSoluongKytruoc.OptionsFilter.AllowAutoFilter = false;
            this.colSoluongKytruoc.OptionsFilter.AllowFilter = false;
            this.colSoluongKytruoc.SummaryItem.DisplayFormat = "{0:n0}";
            this.colSoluongKytruoc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSoluongKytruoc.Visible = true;
            this.colSoluongKytruoc.VisibleIndex = 6;
            this.colSoluongKytruoc.Width = 99;
            // 
            // colDoanhsoKytruoc
            // 
            this.colDoanhsoKytruoc.Caption = "DoanhsoKytruoc";
            this.colDoanhsoKytruoc.DisplayFormat.FormatString = "n0";
            this.colDoanhsoKytruoc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDoanhsoKytruoc.FieldName = "DoanhsoKytruoc";
            this.colDoanhsoKytruoc.Name = "colDoanhsoKytruoc";
            this.colDoanhsoKytruoc.OptionsFilter.AllowAutoFilter = false;
            this.colDoanhsoKytruoc.OptionsFilter.AllowFilter = false;
            this.colDoanhsoKytruoc.SummaryItem.DisplayFormat = "{0:n0}";
            this.colDoanhsoKytruoc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colDoanhsoKytruoc.Visible = true;
            this.colDoanhsoKytruoc.VisibleIndex = 7;
            this.colDoanhsoKytruoc.Width = 132;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Width = 95;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 0;
            this.colSubjectName.Width = 212;
            // 
            // FormRpCTXuatTPThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRpCTXuatTPThang";
            this.Text = "FormRpCTXuatTPThang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormRpCTXuatTPThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEndDate.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private DevExpress.XtraEditors.DateEdit cboStartDate;
        private DevExpress.XtraEditors.DateEdit cboEndDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhso;
        private DevExpress.XtraGrid.Columns.GridColumn colLKSoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colLKDoanhso;
        private DevExpress.XtraGrid.Columns.GridColumn colSoluongKytruoc;
        private DevExpress.XtraGrid.Columns.GridColumn colDoanhsoKytruoc;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraEditors.SimpleButton btnExports;
    }
}