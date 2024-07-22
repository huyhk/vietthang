namespace VNS.ERP.GUI.UserControls
{
    partial class UCCustomerDiscount2
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
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new DevExpress.XtraEditors.TextEdit();
            this.lbDiscountTypeCode = new System.Windows.Forms.Label();
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lookUpEditDiscountTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiscountTypeCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(106, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(472, 42);
            this.txtDescription.TabIndex = 3;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(37, 37);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(63, 16);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDiscountPercent
            // 
            this.lbDiscountPercent.AutoSize = true;
            this.lbDiscountPercent.Location = new System.Drawing.Point(446, 5);
            this.lbDiscountPercent.Name = "lbDiscountPercent";
            this.lbDiscountPercent.Size = new System.Drawing.Size(69, 13);
            this.lbDiscountPercent.TabIndex = 6;
            this.lbDiscountPercent.Text = "% Chiết khấu";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.AllowDrop = true;
            this.txtDiscountPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDiscountPercent.EnterMoveNextControl = true;
            this.txtDiscountPercent.Location = new System.Drawing.Point(521, 1);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDiscountPercent.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.Properties.Appearance.Options.UseBackColor = true;
            this.txtDiscountPercent.Properties.Appearance.Options.UseFont = true;
            this.txtDiscountPercent.Properties.Mask.EditMask = "p";
            this.txtDiscountPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscountPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(57, 22);
            this.txtDiscountPercent.TabIndex = 2;
            // 
            // lbDiscountTypeCode
            // 
            this.lbDiscountTypeCode.AutoSize = true;
            this.lbDiscountTypeCode.Location = new System.Drawing.Point(200, 5);
            this.lbDiscountTypeCode.Name = "lbDiscountTypeCode";
            this.lbDiscountTypeCode.Size = new System.Drawing.Size(80, 13);
            this.lbDiscountTypeCode.TabIndex = 5;
            this.lbDiscountTypeCode.Text = "Loại chiết khấu";
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = new System.DateTime(2006, 12, 28, 0, 0, 0, 0);
            this.dateEditStart.EnterMoveNextControl = true;
            this.dateEditStart.Location = new System.Drawing.Point(106, 2);
            this.dateEditStart.Name = "dateEditStart";
            this.dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditStart.Size = new System.Drawing.Size(88, 22);
            this.dateEditStart.TabIndex = 0;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(18, 4);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(83, 13);
            this.lbStartDate.TabIndex = 4;
            this.lbStartDate.Text = "Bắt đầu từ ngày";
            // 
            // lookUpEditDiscountTypeCode
            // 
            this.lookUpEditDiscountTypeCode.Location = new System.Drawing.Point(289, 2);
            this.lookUpEditDiscountTypeCode.Name = "lookUpEditDiscountTypeCode";
            this.lookUpEditDiscountTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDiscountTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeCode", "Mã", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeName", "Tên chiết khấu", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None)});
            this.lookUpEditDiscountTypeCode.Properties.DisplayMember = "DiscountTypeName";
            this.lookUpEditDiscountTypeCode.Properties.NullText = "";
            this.lookUpEditDiscountTypeCode.Properties.ValueMember = "DiscountTypeCode";
            this.lookUpEditDiscountTypeCode.Size = new System.Drawing.Size(153, 20);
            this.lookUpEditDiscountTypeCode.TabIndex = 1;
            // 
            // UCCustomerDiscount2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditDiscountTypeCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDiscountPercent);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.lbDiscountTypeCode);
            this.Controls.Add(this.dateEditStart);
            this.Controls.Add(this.lbStartDate);
            this.Name = "UCCustomerDiscount2";
            this.Size = new System.Drawing.Size(584, 73);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiscountTypeCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbDiscountPercent;
        private DevExpress.XtraEditors.TextEdit txtDiscountPercent;
        private System.Windows.Forms.Label lbDiscountTypeCode;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private System.Windows.Forms.Label lbStartDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDiscountTypeCode;
    }
}
