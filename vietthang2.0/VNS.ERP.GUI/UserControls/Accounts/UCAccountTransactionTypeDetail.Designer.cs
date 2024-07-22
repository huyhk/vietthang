namespace VNS.ERP.GUI
{
    partial class UCAccountTransactionTypeDetail
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
            this.lblTransactionTypeCode = new System.Windows.Forms.Label();
            this.lblDetailTransactionCode = new System.Windows.Forms.Label();
            this.lblDetailTransactionName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboTransactionTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDetailTransactionCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDetailTransactionName = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailTransactionCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailTransactionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.94929F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.05071F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Controls.Add(this.lblTransactionTypeCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDetailTransactionCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDetailTransactionName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboTransactionTypeCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDetailTransactionCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDetailTransactionName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTransactionTypeCode
            // 
            this.lblTransactionTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTransactionTypeCode.AutoSize = true;
            this.lblTransactionTypeCode.Location = new System.Drawing.Point(37, 6);
            this.lblTransactionTypeCode.Name = "lblTransactionTypeCode";
            this.lblTransactionTypeCode.Size = new System.Drawing.Size(112, 13);
            this.lblTransactionTypeCode.TabIndex = 0;
            this.lblTransactionTypeCode.Text = "TransactionTypeCode";
            // 
            // lblDetailTransactionCode
            // 
            this.lblDetailTransactionCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDetailTransactionCode.AutoSize = true;
            this.lblDetailTransactionCode.Location = new System.Drawing.Point(34, 31);
            this.lblDetailTransactionCode.Name = "lblDetailTransactionCode";
            this.lblDetailTransactionCode.Size = new System.Drawing.Size(115, 13);
            this.lblDetailTransactionCode.TabIndex = 0;
            this.lblDetailTransactionCode.Text = "DetailTransactionCode";
            // 
            // lblDetailTransactionName
            // 
            this.lblDetailTransactionName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDetailTransactionName.AutoSize = true;
            this.lblDetailTransactionName.Location = new System.Drawing.Point(31, 56);
            this.lblDetailTransactionName.Name = "lblDetailTransactionName";
            this.lblDetailTransactionName.Size = new System.Drawing.Size(118, 13);
            this.lblDetailTransactionName.TabIndex = 0;
            this.lblDetailTransactionName.Text = "DetailTransactionName";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(89, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // cboTransactionTypeCode
            // 
            this.cboTransactionTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboTransactionTypeCode.EnterMoveNextControl = true;
            this.cboTransactionTypeCode.Location = new System.Drawing.Point(155, 3);
            this.cboTransactionTypeCode.Name = "cboTransactionTypeCode";
            this.cboTransactionTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTransactionTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumName", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText", "Tên", 220)});
            this.cboTransactionTypeCode.Properties.DisplayMember = "EnumText";
            this.cboTransactionTypeCode.Properties.NullText = "";
            this.cboTransactionTypeCode.Properties.PopupWidth = 300;
            this.cboTransactionTypeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTransactionTypeCode.Properties.ValueMember = "EnumName";
            this.cboTransactionTypeCode.Size = new System.Drawing.Size(202, 20);
            this.cboTransactionTypeCode.TabIndex = 0;
            // 
            // txtDetailTransactionCode
            // 
            this.txtDetailTransactionCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDetailTransactionCode.EditValue = "";
            this.txtDetailTransactionCode.EnterMoveNextControl = true;
            this.txtDetailTransactionCode.Location = new System.Drawing.Point(155, 28);
            this.txtDetailTransactionCode.Name = "txtDetailTransactionCode";
            this.txtDetailTransactionCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetailTransactionCode.Size = new System.Drawing.Size(202, 20);
            this.txtDetailTransactionCode.TabIndex = 1;
            // 
            // txtDetailTransactionName
            // 
            this.txtDetailTransactionName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDetailTransactionName.EnterMoveNextControl = true;
            this.txtDetailTransactionName.Location = new System.Drawing.Point(155, 53);
            this.txtDetailTransactionName.Name = "txtDetailTransactionName";
            this.txtDetailTransactionName.Size = new System.Drawing.Size(202, 20);
            this.txtDetailTransactionName.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EditValue = "";
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(155, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(452, 50);
            this.txtDescription.TabIndex = 3;
            // 
            // UCAccountTransactionTypeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCAccountTransactionTypeDetail";
            this.Size = new System.Drawing.Size(644, 131);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboTransactionTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailTransactionCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetailTransactionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTransactionTypeCode;
        private System.Windows.Forms.Label lblDetailTransactionCode;
        private System.Windows.Forms.Label lblDetailTransactionName;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.LookUpEdit cboTransactionTypeCode;
        private DevExpress.XtraEditors.TextEdit txtDetailTransactionCode;
        private DevExpress.XtraEditors.TextEdit txtDetailTransactionName;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}
