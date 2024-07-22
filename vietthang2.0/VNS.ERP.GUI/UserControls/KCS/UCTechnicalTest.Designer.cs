namespace VNS.ERP.GUI
{
    partial class UCTechnicalTest
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
            this.lblTechCode = new System.Windows.Forms.Label();
            this.lblTechName = new System.Windows.Forms.Label();
            this.lblResultType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTechName = new DevExpress.XtraEditors.TextEdit();
            this.txtTechCode = new DevExpress.XtraEditors.TextEdit();
            this.lookUpResultType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtThutu = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.chkKCSTest = new DevExpress.XtraEditors.CheckEdit();
            this.chkPTNTest = new DevExpress.XtraEditors.CheckEdit();
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.txtDisplayText = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpResultType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThutu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKCSTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPTNTest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTechCode
            // 
            this.lblTechCode.AutoSize = true;
            this.lblTechCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTechCode.Location = new System.Drawing.Point(3, 0);
            this.lblTechCode.Name = "lblTechCode";
            this.lblTechCode.Size = new System.Drawing.Size(84, 27);
            this.lblTechCode.TabIndex = 6;
            this.lblTechCode.Text = "Mã chỉ tiêu";
            this.lblTechCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTechName
            // 
            this.lblTechName.AutoSize = true;
            this.lblTechName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTechName.Location = new System.Drawing.Point(3, 27);
            this.lblTechName.Name = "lblTechName";
            this.lblTechName.Size = new System.Drawing.Size(84, 28);
            this.lblTechName.TabIndex = 7;
            this.lblTechName.Text = "Tên chỉ tiêu";
            this.lblTechName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultType
            // 
            this.lblResultType.AutoSize = true;
            this.lblResultType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultType.Location = new System.Drawing.Point(231, 27);
            this.lblResultType.Name = "lblResultType";
            this.lblResultType.Size = new System.Drawing.Size(76, 28);
            this.lblResultType.TabIndex = 8;
            this.lblResultType.Text = "Kiểu kết quả";
            this.lblResultType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 49);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Diễn giải";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.Controls.Add(this.txtTechName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTechCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTechCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTechName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblResultType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpResultType, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtThutu, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkKCSTest, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkPTNTest, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDisplayText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDisplayText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTechName
            // 
            this.txtTechName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTechName.EnterMoveNextControl = true;
            this.txtTechName.Location = new System.Drawing.Point(93, 30);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(132, 20);
            this.txtTechName.TabIndex = 2;
            // 
            // txtTechCode
            // 
            this.txtTechCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTechCode.EnterMoveNextControl = true;
            this.txtTechCode.Location = new System.Drawing.Point(93, 3);
            this.txtTechCode.Name = "txtTechCode";
            this.txtTechCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTechCode.Size = new System.Drawing.Size(132, 20);
            this.txtTechCode.TabIndex = 0;
            // 
            // lookUpResultType
            // 
            this.lookUpResultType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpResultType.EnterMoveNextControl = true;
            this.lookUpResultType.Location = new System.Drawing.Point(313, 30);
            this.lookUpResultType.Name = "lookUpResultType";
            this.lookUpResultType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpResultType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpResultType.Properties.NullText = "";
            this.lookUpResultType.Size = new System.Drawing.Size(146, 20);
            this.lookUpResultType.TabIndex = 3;
            // 
            // txtThutu
            // 
            this.txtThutu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThutu.EnterMoveNextControl = true;
            this.txtThutu.Location = new System.Drawing.Point(313, 3);
            this.txtThutu.Name = "txtThutu";
            this.txtThutu.Properties.Mask.EditMask = "n0";
            this.txtThutu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtThutu.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtThutu.Size = new System.Drawing.Size(146, 20);
            this.txtThutu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(231, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thứ tự";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkKCSTest
            // 
            this.chkKCSTest.Location = new System.Drawing.Point(93, 133);
            this.chkKCSTest.Name = "chkKCSTest";
            this.chkKCSTest.Properties.Caption = "KCS kiểm";
            this.chkKCSTest.Size = new System.Drawing.Size(132, 19);
            this.chkKCSTest.TabIndex = 6;
            // 
            // chkPTNTest
            // 
            this.chkPTNTest.Location = new System.Drawing.Point(313, 133);
            this.chkPTNTest.Name = "chkPTNTest";
            this.chkPTNTest.Properties.Caption = "PTN kiểm";
            this.chkPTNTest.Size = new System.Drawing.Size(138, 19);
            this.chkPTNTest.TabIndex = 7;
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayText.Location = new System.Drawing.Point(3, 55);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(84, 26);
            this.lblDisplayText.TabIndex = 12;
            this.lblDisplayText.Text = "DisplayText";
            this.lblDisplayText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayText.EnterMoveNextControl = true;
            this.txtDisplayText.Location = new System.Drawing.Point(93, 58);
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(132, 20);
            this.txtDisplayText.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(93, 84);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(358, 41);
            this.txtDescription.TabIndex = 5;
            // 
            // UCTechnicalTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCTechnicalTest";
            this.Size = new System.Drawing.Size(462, 155);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpResultType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThutu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkKCSTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPTNTest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDisplayText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTechCode;
        private System.Windows.Forms.Label lblTechName;
        private System.Windows.Forms.Label lblResultType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtTechName;
        private DevExpress.XtraEditors.TextEdit txtTechCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpResultType;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.CheckEdit chkPTNTest;
        private DevExpress.XtraEditors.CheckEdit chkKCSTest;
        private DevExpress.XtraEditors.TextEdit txtThutu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplayText;
        private DevExpress.XtraEditors.TextEdit txtDisplayText;
    }
}
