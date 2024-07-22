namespace VNS.ERP.GUI.Manufactures
{
    partial class UCManufactureShifts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblKho = new System.Windows.Forms.Label();
            this.cboNgay = new DevExpress.XtraEditors.DateEdit();
            this.cboKho = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTruongca = new System.Windows.Forms.Label();
            this.cboTruongca = new DevExpress.XtraEditors.LookUpEdit();
            this.cboCa = new DevExpress.XtraEditors.SpinEdit();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.gridNhienlieu = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhienlieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCodeNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpNL = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantityNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemTextEditFormat = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPhanboNL = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhoca = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTruongca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhienlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhienlieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhoca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.69312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.30688F));
            this.tableLayoutPanel1.Controls.Add(this.lblKho, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboNgay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboKho, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNgay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCa, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(456, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblKho
            // 
            this.lblKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(69, 12);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(26, 13);
            this.lblKho.TabIndex = 0;
            this.lblKho.Text = "Kho";
            // 
            // cboNgay
            // 
            this.cboNgay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNgay.EditValue = new System.DateTime(2007, 1, 29, 0, 0, 0, 0);
            this.cboNgay.EnterMoveNextControl = true;
            this.cboNgay.Location = new System.Drawing.Point(101, 47);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboNgay.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboNgay.Properties.Appearance.Options.UseBackColor = true;
            this.cboNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgay.Size = new System.Drawing.Size(86, 20);
            this.cboNgay.TabIndex = 2;
            // 
            // cboKho
            // 
            this.cboKho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboKho.Enabled = false;
            this.cboKho.EnterMoveNextControl = true;
            this.cboKho.Location = new System.Drawing.Point(101, 9);
            this.cboKho.Name = "cboKho";
            this.cboKho.Properties.Appearance.BackColor = System.Drawing.Color.Azure;
            this.cboKho.Properties.Appearance.Options.UseBackColor = true;
            this.cboKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "StockCode", 60),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "StockName", 150)});
            this.cboKho.Properties.DisplayMember = "StockName";
            this.cboKho.Properties.NullText = "";
            this.cboKho.Properties.PopupWidth = 200;
            this.cboKho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKho.Properties.ValueMember = "StockCode";
            this.cboKho.Size = new System.Drawing.Size(191, 20);
            this.cboKho.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81564F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.71508F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.46927F));
            this.tableLayoutPanel2.Controls.Add(this.lblTruongca, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboTruongca, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboCa, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(98, 76);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 38);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTruongca
            // 
            this.lblTruongca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTruongca.AutoSize = true;
            this.lblTruongca.Location = new System.Drawing.Point(103, 12);
            this.lblTruongca.Name = "lblTruongca";
            this.lblTruongca.Size = new System.Drawing.Size(56, 13);
            this.lblTruongca.TabIndex = 0;
            this.lblTruongca.Text = "Trưởng ca";
            // 
            // cboTruongca
            // 
            this.cboTruongca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTruongca.EnterMoveNextControl = true;
            this.cboTruongca.Location = new System.Drawing.Point(165, 9);
            this.cboTruongca.Name = "cboTruongca";
            this.cboTruongca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTruongca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Tên", 220)});
            this.cboTruongca.Properties.DisplayMember = "EmployeeName";
            this.cboTruongca.Properties.NullText = "";
            this.cboTruongca.Properties.PopupWidth = 300;
            this.cboTruongca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTruongca.Properties.ValueMember = "EmployeeID";
            this.cboTruongca.Size = new System.Drawing.Size(150, 20);
            this.cboTruongca.TabIndex = 4;
            // 
            // cboCa
            // 
            this.cboCa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCa.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboCa.EnterMoveNextControl = true;
            this.cboCa.Location = new System.Drawing.Point(3, 9);
            this.cboCa.Name = "cboCa";
            this.cboCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboCa.Properties.Mask.EditMask = "n0";
            this.cboCa.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cboCa.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cboCa.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboCa.Properties.UseCtrlIncrement = false;
            this.cboCa.Size = new System.Drawing.Size(86, 20);
            this.cboCa.TabIndex = 3;
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(63, 50);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(32, 13);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // lblCa
            // 
            this.lblCa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(75, 88);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(20, 13);
            this.lblCa.TabIndex = 0;
            this.lblCa.Text = "Ca";
            // 
            // gridNhienlieu
            // 
            this.gridNhienlieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhienlieu.EmbeddedNavigator.Name = "";
            this.gridNhienlieu.Location = new System.Drawing.Point(3, 163);
            this.gridNhienlieu.MainView = this.gridViewNhienlieu;
            this.gridNhienlieu.Name = "gridNhienlieu";
            this.gridNhienlieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpNL,
            this.repositoryItemTextEdit1,
            this.ItemTextEditFormat});
            this.gridNhienlieu.Size = new System.Drawing.Size(456, 186);
            this.gridNhienlieu.TabIndex = 1;
            this.gridNhienlieu.TabStop = false;
            this.gridNhienlieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhienlieu});
            // 
            // gridViewNhienlieu
            // 
            this.gridViewNhienlieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCodeNL,
            this.colQuantityNL});
            this.gridViewNhienlieu.GridControl = this.gridNhienlieu;
            this.gridViewNhienlieu.Name = "gridViewNhienlieu";
            this.gridViewNhienlieu.OptionsCustomization.AllowFilter = false;
            this.gridViewNhienlieu.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewNhienlieu.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewNhienlieu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewNhienlieu.OptionsView.ShowDetailButtons = false;
            this.gridViewNhienlieu.OptionsView.ShowFooter = true;
            this.gridViewNhienlieu.OptionsView.ShowGroupPanel = false;
            this.gridViewNhienlieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewNhienlieu_KeyDown);
            // 
            // colItemCodeNL
            // 
            this.colItemCodeNL.Caption = "Nhiên liệu";
            this.colItemCodeNL.ColumnEdit = this.ItemLookUpNL;
            this.colItemCodeNL.FieldName = "ItemCode";
            this.colItemCodeNL.Name = "colItemCodeNL";
            this.colItemCodeNL.Visible = true;
            this.colItemCodeNL.VisibleIndex = 0;
            this.colItemCodeNL.Width = 115;
            // 
            // ItemLookUpNL
            // 
            this.ItemLookUpNL.AutoHeight = false;
            this.ItemLookUpNL.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpNL.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "ItemCode", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "ItemName", 220)});
            this.ItemLookUpNL.DisplayMember = "ItemName";
            this.ItemLookUpNL.Name = "ItemLookUpNL";
            this.ItemLookUpNL.NullText = "";
            this.ItemLookUpNL.PopupWidth = 300;
            this.ItemLookUpNL.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpNL.ValueMember = "ItemCode";
            // 
            // colQuantityNL
            // 
            this.colQuantityNL.Caption = "Số lượng";
            this.colQuantityNL.ColumnEdit = this.ItemTextEditFormat;
            this.colQuantityNL.DisplayFormat.FormatString = "n2";
            this.colQuantityNL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityNL.FieldName = "Quantity";
            this.colQuantityNL.Name = "colQuantityNL";
            this.colQuantityNL.SummaryItem.DisplayFormat = "{0:###,###,###,##0.00}";
            this.colQuantityNL.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantityNL.SummaryItem.Tag = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.colQuantityNL.Visible = true;
            this.colQuantityNL.VisibleIndex = 1;
            this.colQuantityNL.Width = 100;
            // 
            // ItemTextEditFormat
            // 
            this.ItemTextEditFormat.AutoHeight = false;
            this.ItemTextEditFormat.Mask.EditMask = "n2";
            this.ItemTextEditFormat.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ItemTextEditFormat.Mask.UseMaskAsDisplayFormat = true;
            this.ItemTextEditFormat.Name = "ItemTextEditFormat";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gridNhienlieu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.08108F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 397);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.29437F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.70563F));
            this.tableLayoutPanel4.Controls.Add(this.btnPhanboNL, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 352);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(462, 45);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnPhanboNL
            // 
            this.btnPhanboNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhanboNL.Location = new System.Drawing.Point(337, 3);
            this.btnPhanboNL.Name = "btnPhanboNL";
            this.btnPhanboNL.Size = new System.Drawing.Size(122, 39);
            this.btnPhanboNL.TabIndex = 5;
            this.btnPhanboNL.Text = "Phân bổ Nhiên liệu";
            this.btnPhanboNL.Click += new System.EventHandler(this.btnPhanboNL_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboPhoca);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(101, 117);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(352, 34);
            this.panelControl1.TabIndex = 4;
            this.panelControl1.Text = "panelControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phó ca";
            // 
            // cboPhoca
            // 
            this.cboPhoca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPhoca.EnterMoveNextControl = true;
            this.cboPhoca.Location = new System.Drawing.Point(162, 7);
            this.cboPhoca.Name = "cboPhoca";
            this.cboPhoca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPhoca.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Tên", 220)});
            this.cboPhoca.Properties.DisplayMember = "EmployeeName";
            this.cboPhoca.Properties.NullText = "";
            this.cboPhoca.Properties.PopupWidth = 300;
            this.cboPhoca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPhoca.Properties.ValueMember = "EmployeeID";
            this.cboPhoca.Size = new System.Drawing.Size(150, 20);
            this.cboPhoca.TabIndex = 5;
            // 
            // UCManufactureShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "UCManufactureShifts";
            this.Size = new System.Drawing.Size(462, 397);
            this.Load += new System.EventHandler(this.UCManufactureShifts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTruongca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhienlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhienlieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTextEditFormat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPhoca.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblKho;
        private DevExpress.XtraEditors.LookUpEdit cboKho;
        private DevExpress.XtraEditors.DateEdit cboNgay;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTruongca;
        private DevExpress.XtraEditors.LookUpEdit cboTruongca;
        private DevExpress.XtraGrid.GridControl gridNhienlieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhienlieu;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCodeNL;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpNL;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityNL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnPhanboNL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ItemTextEditFormat;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SpinEdit cboCa;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboPhoca;
        private System.Windows.Forms.Label label1;
    }
}
