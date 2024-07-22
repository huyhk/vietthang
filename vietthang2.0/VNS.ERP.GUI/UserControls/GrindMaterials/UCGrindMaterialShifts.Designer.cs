namespace VNS.ERP.GUI.UserControls
{
    partial class UCGrindMaterialShifts
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
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblCa = new System.Windows.Forms.Label();
            this.cboCa = new DevExpress.XtraEditors.SpinEdit();
            this.lblTruongca = new System.Windows.Forms.Label();
            this.cboTruongca = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTruongca.Properties)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.lblNgay, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCa, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboCa, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblKho
            // 
            this.lblKho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblKho.AutoSize = true;
            this.lblKho.Location = new System.Drawing.Point(74, 10);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(26, 13);
            this.lblKho.TabIndex = 3;
            this.lblKho.Text = "Kho";
            // 
            // cboNgay
            // 
            this.cboNgay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNgay.EditValue = new System.DateTime(2007, 1, 29, 0, 0, 0, 0);
            this.cboNgay.EnterMoveNextControl = true;
            this.cboNgay.Location = new System.Drawing.Point(106, 39);
            this.cboNgay.Name = "cboNgay";
            this.cboNgay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboNgay.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboNgay.Properties.Appearance.Options.UseBackColor = true;
            this.cboNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgay.Size = new System.Drawing.Size(124, 23);
            this.cboNgay.TabIndex = 1;
            // 
            // cboKho
            // 
            this.cboKho.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboKho.Enabled = false;
            this.cboKho.EnterMoveNextControl = true;
            this.cboKho.Location = new System.Drawing.Point(106, 5);
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
            this.cboKho.Size = new System.Drawing.Size(124, 23);
            this.cboKho.TabIndex = 0;
            // 
            // lblNgay
            // 
            this.lblNgay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(68, 44);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(32, 13);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày";
            // 
            // lblCa
            // 
            this.lblCa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCa.AutoSize = true;
            this.lblCa.Location = new System.Drawing.Point(80, 79);
            this.lblCa.Name = "lblCa";
            this.lblCa.Size = new System.Drawing.Size(20, 13);
            this.lblCa.TabIndex = 0;
            this.lblCa.Text = "Ca";
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
            this.cboCa.Location = new System.Drawing.Point(106, 76);
            this.cboCa.Name = "cboCa";
            this.cboCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cboCa.Properties.Mask.EditMask = "n0";
            this.cboCa.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.cboCa.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.cboCa.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cboCa.Properties.UseCtrlIncrement = false;
            this.cboCa.Size = new System.Drawing.Size(51, 20);
            this.cboCa.TabIndex = 2;
            // 
            // lblTruongca
            // 
            this.lblTruongca.AutoSize = true;
            this.lblTruongca.Location = new System.Drawing.Point(50, 123);
            this.lblTruongca.Name = "lblTruongca";
            this.lblTruongca.Size = new System.Drawing.Size(56, 13);
            this.lblTruongca.TabIndex = 1;
            this.lblTruongca.Text = "Trưởng ca";
            // 
            // cboTruongca
            // 
            this.cboTruongca.EnterMoveNextControl = true;
            this.cboTruongca.Location = new System.Drawing.Point(112, 119);
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
            this.cboTruongca.Size = new System.Drawing.Size(150, 23);
            this.cboTruongca.TabIndex = 5;
            // 
            // UCGrindMaterialShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cboTruongca);
            this.Controls.Add(this.lblTruongca);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCGrindMaterialShifts";
            this.Size = new System.Drawing.Size(493, 155);
            this.Load += new System.EventHandler(this.UCGrindMaterialShifts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTruongca.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblKho;
        private DevExpress.XtraEditors.LookUpEdit cboKho;
        private DevExpress.XtraEditors.DateEdit cboNgay;
        private System.Windows.Forms.Label lblCa;
        private System.Windows.Forms.Label lblNgay;
        private DevExpress.XtraEditors.SpinEdit cboCa;
        private System.Windows.Forms.Label lblTruongca;
        private DevExpress.XtraEditors.LookUpEdit cboTruongca;
    }
}
