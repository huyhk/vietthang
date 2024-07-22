namespace VNS.ERP.GUI.KCS
{
    partial class FormProductEncryptCode
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbEncryptCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEditStock = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShift = new DevExpress.XtraEditors.SpinEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpEditProductCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.lookUpEditSizeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lookUpEditFormula = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLot = new DevExpress.XtraEditors.TextEdit();
            this.txtEncryptCode = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSizeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEncryptCode.Properties)).BeginInit();
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(374, 78);
            this.txtDescription.Name = "txtDescription";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescription, 2);
            this.txtDescription.Size = new System.Drawing.Size(206, 47);
            this.txtDescription.TabIndex = 8;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.Location = new System.Drawing.Point(295, 75);
            this.lbDescription.Name = "lbDescription";
            this.tableLayoutPanel1.SetRowSpan(this.lbDescription, 2);
            this.lbDescription.Size = new System.Drawing.Size(73, 53);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbEncryptCode
            // 
            this.lbEncryptCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEncryptCode.Location = new System.Drawing.Point(295, 50);
            this.lbEncryptCode.Name = "lbEncryptCode";
            this.lbEncryptCode.Size = new System.Drawing.Size(73, 25);
            this.lbEncryptCode.TabIndex = 17;
            this.lbEncryptCode.Text = "Mã mẫu";
            this.lbEncryptCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhà máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditStock
            // 
            this.lookUpEditStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditStock.EnterMoveNextControl = true;
            this.lookUpEditStock.Location = new System.Drawing.Point(83, 3);
            this.lookUpEditStock.Name = "lookUpEditStock";
            this.lookUpEditStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Mã", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 200)});
            this.lookUpEditStock.Properties.DisplayMember = "StockName";
            this.lookUpEditStock.Properties.NullText = "";
            this.lookUpEditStock.Properties.PopupWidth = 300;
            this.lookUpEditStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditStock.Properties.ValueMember = "StockCode";
            this.lookUpEditStock.Size = new System.Drawing.Size(206, 20);
            this.lookUpEditStock.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày SX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEdit1
            // 
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEdit1.EditValue = new System.DateTime(2008, 4, 2, 0, 0, 0, 0);
            this.dateEdit1.EnterMoveNextControl = true;
            this.dateEdit1.Location = new System.Drawing.Point(83, 28);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(206, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ca SX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtShift
            // 
            this.txtShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShift.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtShift.EnterMoveNextControl = true;
            this.txtShift.Location = new System.Drawing.Point(83, 53);
            this.txtShift.Name = "txtShift";
            this.txtShift.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtShift.Properties.Mask.EditMask = "n0";
            this.txtShift.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtShift.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtShift.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtShift.Properties.UseCtrlIncrement = false;
            this.txtShift.Size = new System.Drawing.Size(206, 20);
            this.txtShift.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thành phẩm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditProductCode
            // 
            this.lookUpEditProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditProductCode.EnterMoveNextControl = true;
            this.lookUpEditProductCode.Location = new System.Drawing.Point(83, 78);
            this.lookUpEditProductCode.Name = "lookUpEditProductCode";
            this.lookUpEditProductCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditProductCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductCode", "Mã TP", 100)});
            this.lookUpEditProductCode.Properties.DisplayMember = "ProductCode";
            this.lookUpEditProductCode.Properties.NullText = "";
            this.lookUpEditProductCode.Properties.PopupWidth = 100;
            this.lookUpEditProductCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditProductCode.Properties.ValueMember = "ProductCode";
            this.lookUpEditProductCode.Size = new System.Drawing.Size(206, 20);
            this.lookUpEditProductCode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kích thước";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditSizeCode
            // 
            this.lookUpEditSizeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditSizeCode.EnterMoveNextControl = true;
            this.lookUpEditSizeCode.Location = new System.Drawing.Point(83, 103);
            this.lookUpEditSizeCode.Name = "lookUpEditSizeCode";
            this.lookUpEditSizeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSizeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SizeCode", "Mã", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải", 200)});
            this.lookUpEditSizeCode.Properties.DisplayMember = "SizeCode";
            this.lookUpEditSizeCode.Properties.NullText = "";
            this.lookUpEditSizeCode.Properties.PopupWidth = 300;
            this.lookUpEditSizeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditSizeCode.Properties.ValueMember = "SizeCode";
            this.lookUpEditSizeCode.Size = new System.Drawing.Size(206, 20);
            this.lookUpEditSizeCode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(295, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Công thức";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditFormula
            // 
            this.lookUpEditFormula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpEditFormula.EnterMoveNextControl = true;
            this.lookUpEditFormula.Location = new System.Drawing.Point(374, 3);
            this.lookUpEditFormula.Name = "lookUpEditFormula";
            this.lookUpEditFormula.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFormula.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormulaCode", "Mã", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Diễn giải", 200)});
            this.lookUpEditFormula.Properties.DisplayMember = "FormulaCode";
            this.lookUpEditFormula.Properties.NullText = "";
            this.lookUpEditFormula.Properties.PopupWidth = 300;
            this.lookUpEditFormula.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditFormula.Properties.ValueMember = "FormulaCode";
            this.lookUpEditFormula.Size = new System.Drawing.Size(206, 20);
            this.lookUpEditFormula.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(295, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lot";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLot
            // 
            this.txtLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLot.EnterMoveNextControl = true;
            this.txtLot.Location = new System.Drawing.Point(374, 28);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(206, 20);
            this.txtLot.TabIndex = 6;
            // 
            // txtEncryptCode
            // 
            this.txtEncryptCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncryptCode.Location = new System.Drawing.Point(374, 53);
            this.txtEncryptCode.Name = "txtEncryptCode";
            this.txtEncryptCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtEncryptCode.Size = new System.Drawing.Size(206, 20);
            this.txtEncryptCode.TabIndex = 7;
            this.txtEncryptCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtEncryptCode_ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditSizeCode, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEncryptCode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditStock, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditProductCode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLot, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditFormula, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtShift, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateEdit1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbEncryptCode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FormProductEncryptCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(587, 158);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormProductEncryptCode";
            this.Text = "Mã mẫu kiểm thành phẩm";
            this.Load += new System.EventHandler(this.FormProductEncryptCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSizeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFormula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEncryptCode.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbEncryptCode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditStock;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SpinEdit txtShift;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditProductCode;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSizeCode;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFormula;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtLot;
        private DevExpress.XtraEditors.ButtonEdit txtEncryptCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
