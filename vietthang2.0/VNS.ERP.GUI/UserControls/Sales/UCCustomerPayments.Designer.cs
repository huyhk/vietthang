namespace VNS.ERP.GUI
{
    partial class UCCustomerPayments
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
            this.lblStockCode = new System.Windows.Forms.Label();
            this.cboPaymentTpye = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPaymentNo = new DevExpress.XtraEditors.ButtonEdit();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.cboCustomerCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblPaymentNo = new System.Windows.Forms.Label();
            this.cboNgayPaymentDate = new DevExpress.XtraEditors.DateEdit();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentTpye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgayPaymentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02841F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.30114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.06818F));
            this.tableLayoutPanel1.Controls.Add(this.lblStockCode, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboPaymentTpye, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPaymentNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpStockCode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboCustomerCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboNgayPaymentDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPaymentType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblStockCode
            // 
            this.lblStockCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(375, 57);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(60, 13);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "StockCode";
            this.lblStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPaymentTpye
            // 
            this.cboPaymentTpye.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPaymentTpye.EnterMoveNextControl = true;
            this.cboPaymentTpye.Location = new System.Drawing.Point(145, 53);
            this.cboPaymentTpye.Name = "cboPaymentTpye";
            this.cboPaymentTpye.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboPaymentTpye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPaymentTpye.Properties.Appearance.Options.UseBackColor = true;
            this.cboPaymentTpye.Properties.Appearance.Options.UseFont = true;
            this.cboPaymentTpye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPaymentTpye.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText", "Danh mục", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID", "EnumID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.cboPaymentTpye.Properties.DisplayMember = "EnumText";
            this.cboPaymentTpye.Properties.NullText = "";
            this.cboPaymentTpye.Properties.PopupWidth = 200;
            this.cboPaymentTpye.Properties.ValueMember = "EnumID";
            this.cboPaymentTpye.Size = new System.Drawing.Size(151, 20);
            this.cboPaymentTpye.TabIndex = 4;
            this.cboPaymentTpye.EditValueChanged += new System.EventHandler(this.cboPaymentTpye_EditValueChanged_1);
            // 
            // txtPaymentNo
            // 
            this.txtPaymentNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPaymentNo.EditValue = "";
            this.txtPaymentNo.EnterMoveNextControl = true;
            this.txtPaymentNo.Location = new System.Drawing.Point(145, 3);
            this.txtPaymentNo.Name = "txtPaymentNo";
            this.txtPaymentNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPaymentNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaymentNo.Size = new System.Drawing.Size(151, 20);
            this.txtPaymentNo.TabIndex = 0;
            this.txtPaymentNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtPaymentNo_ButtonClick);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(392, 31);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpStockCode.EnterMoveNextControl = true;
            this.lookUpStockCode.Location = new System.Drawing.Point(441, 53);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên ", 150)});
            this.lookUpStockCode.Properties.DisplayMember = "SubjectName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 300;
            this.lookUpStockCode.Properties.ValueMember = "SubjectCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(167, 20);
            this.lookUpStockCode.TabIndex = 5;
            // 
            // cboCustomerCode
            // 
            this.cboCustomerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboCustomerCode.EnterMoveNextControl = true;
            this.cboCustomerCode.Location = new System.Drawing.Point(145, 28);
            this.cboCustomerCode.Name = "cboCustomerCode";
            this.cboCustomerCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboCustomerCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerCode.Properties.Appearance.Options.UseBackColor = true;
            this.cboCustomerCode.Properties.Appearance.Options.UseFont = true;
            this.cboCustomerCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCustomerCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã KH", 50),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên KH", 150)});
            this.cboCustomerCode.Properties.DisplayMember = "SubjectName";
            this.cboCustomerCode.Properties.NullText = "";
            this.cboCustomerCode.Properties.PopupWidth = 300;
            this.cboCustomerCode.Properties.ValueMember = "SubjectCode";
            this.cboCustomerCode.Size = new System.Drawing.Size(151, 20);
            this.cboCustomerCode.TabIndex = 2;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(63, 31);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(76, 13);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "CustomerCode";
            this.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentNo
            // 
            this.lblPaymentNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentNo.AutoSize = true;
            this.lblPaymentNo.Location = new System.Drawing.Point(77, 6);
            this.lblPaymentNo.Name = "lblPaymentNo";
            this.lblPaymentNo.Size = new System.Drawing.Size(62, 13);
            this.lblPaymentNo.TabIndex = 0;
            this.lblPaymentNo.Text = "PaymentNo";
            this.lblPaymentNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNgayPaymentDate
            // 
            this.cboNgayPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboNgayPaymentDate.EditValue = new System.DateTime(2007, 3, 16, 16, 21, 40, 879);
            this.cboNgayPaymentDate.EnterMoveNextControl = true;
            this.cboNgayPaymentDate.Location = new System.Drawing.Point(441, 3);
            this.cboNgayPaymentDate.Name = "cboNgayPaymentDate";
            this.cboNgayPaymentDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNgayPaymentDate.Properties.Appearance.Options.UseFont = true;
            this.cboNgayPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNgayPaymentDate.Size = new System.Drawing.Size(100, 20);
            this.cboNgayPaymentDate.TabIndex = 1;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(364, 6);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(71, 13);
            this.lblPaymentDate.TabIndex = 0;
            this.lblPaymentDate.Text = "PaymentDate";
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(67, 57);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(72, 13);
            this.lblPaymentType.TabIndex = 0;
            this.lblPaymentType.Text = "PaymentType";
            this.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(441, 28);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(167, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 133);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.14204F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.6875F));
            this.tableLayoutPanel3.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(710, 56);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(79, 21);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EditValue = "";
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(145, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Size = new System.Drawing.Size(528, 50);
            this.txtDescription.TabIndex = 0;
            // 
            // UCCustomerPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UCCustomerPayments";
            this.Size = new System.Drawing.Size(710, 133);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPaymentTpye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaymentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCustomerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNgayPaymentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPaymentNo;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.DateEdit cboNgayPaymentDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private DevExpress.XtraEditors.LookUpEdit cboCustomerCode;
        private DevExpress.XtraEditors.LookUpEdit cboPaymentTpye;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.ButtonEdit txtPaymentNo;
    }
}
