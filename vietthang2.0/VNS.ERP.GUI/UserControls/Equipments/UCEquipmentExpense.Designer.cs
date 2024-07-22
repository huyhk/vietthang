namespace VNS.ERP.GUI.Equipments
{
    partial class UCEquipmentExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpenseNo = new DevExpress.XtraEditors.TextEdit();
            this.lkStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtExpenseDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpenseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpenseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenseNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lkStockCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtExpenseDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 101);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số phí tổn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(243, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày phí tổn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(243, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 43);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diễn giải";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExpenseNo
            // 
            this.txtExpenseNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpenseNo.EnterMoveNextControl = true;
            this.txtExpenseNo.Location = new System.Drawing.Point(79, 4);
            this.txtExpenseNo.Name = "txtExpenseNo";
            this.txtExpenseNo.Size = new System.Drawing.Size(158, 20);
            this.txtExpenseNo.TabIndex = 1;
            // 
            // lkStockCode
            // 
            this.lkStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lkStockCode.EnterMoveNextControl = true;
            this.lkStockCode.Location = new System.Drawing.Point(79, 33);
            this.lkStockCode.Name = "lkStockCode";
            this.lkStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.lkStockCode.Properties.DisplayMember = "StockName";
            this.lkStockCode.Properties.NullText = "";
            this.lkStockCode.Properties.ValueMember = "StockCode";
            this.lkStockCode.Size = new System.Drawing.Size(158, 20);
            this.lkStockCode.TabIndex = 3;
            // 
            // txtExpenseDate
            // 
            this.txtExpenseDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExpenseDate.EditValue = new System.DateTime(2008, 8, 4, 0, 0, 0, 0);
            this.txtExpenseDate.EnterMoveNextControl = true;
            this.txtExpenseDate.Location = new System.Drawing.Point(325, 4);
            this.txtExpenseDate.Name = "txtExpenseDate";
            this.txtExpenseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtExpenseDate.Size = new System.Drawing.Size(158, 20);
            this.txtExpenseDate.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(79, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(404, 37);
            this.txtDescription.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(325, 33);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(158, 20);
            this.txtAmount.TabIndex = 4;
            // 
            // UCEquipmentExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCEquipmentExpense";
            this.Size = new System.Drawing.Size(493, 109);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpenseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpenseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtExpenseNo;
        private DevExpress.XtraEditors.LookUpEdit lkStockCode;
        private DevExpress.XtraEditors.DateEdit txtExpenseDate;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtAmount;
    }
}
