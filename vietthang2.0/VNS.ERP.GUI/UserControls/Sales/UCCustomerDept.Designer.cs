namespace VNS.ERP.GUI.UserControls
{
    partial class UCCustomerDept
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
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.chkNotCash = new DevExpress.XtraEditors.CheckEdit();
            this.chkAmountLimit = new DevExpress.XtraEditors.CheckEdit();
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.chkDateLimit = new DevExpress.XtraEditors.CheckEdit();
            this.txtDays = new DevExpress.XtraEditors.TextEdit();
            this.lbDaysUnit = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCash = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNotCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAmountLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDateLimit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCash.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 12);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(100, 16);
            this.lbStartDate.TabIndex = 8;
            this.lbStartDate.Text = "Bắt đầu từ ngày";
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = new System.DateTime(2006, 12, 28, 0, 0, 0, 0);
            this.dateEditStart.EnterMoveNextControl = true;
            this.dateEditStart.Location = new System.Drawing.Point(109, 10);
            this.dateEditStart.Name = "dateEditStart";
            this.dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditStart.Size = new System.Drawing.Size(88, 22);
            this.dateEditStart.TabIndex = 0;
            // 
            // chkNotCash
            // 
            this.chkNotCash.AllowDrop = true;
            this.chkNotCash.Location = new System.Drawing.Point(9, 73);
            this.chkNotCash.Name = "chkNotCash";
            this.chkNotCash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotCash.Properties.Appearance.Options.UseFont = true;
            this.chkNotCash.Properties.Caption = " Cho phép nợ";
            this.chkNotCash.Size = new System.Drawing.Size(97, 21);
            this.chkNotCash.TabIndex = 2;
            this.chkNotCash.CheckedChanged += new System.EventHandler(this.chkNotCash_CheckedChanged);
            // 
            // chkAmountLimit
            // 
            this.chkAmountLimit.AllowDrop = true;
            this.chkAmountLimit.Enabled = false;
            this.chkAmountLimit.Location = new System.Drawing.Point(111, 73);
            this.chkAmountLimit.Name = "chkAmountLimit";
            this.chkAmountLimit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAmountLimit.Properties.Appearance.Options.UseFont = true;
            this.chkAmountLimit.Properties.Caption = "Tối đa";
            this.chkAmountLimit.Size = new System.Drawing.Size(58, 21);
            this.chkAmountLimit.TabIndex = 3;
            this.chkAmountLimit.CheckedChanged += new System.EventHandler(this.chkAmountLimit_CheckedChanged);
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(57, 158);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(24, 22);
            this.txtBackGround.TabIndex = 16;
            this.txtBackGround.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.AllowDrop = true;
            this.txtAmount.Enabled = false;
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(175, 72);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(134, 22);
            this.txtAmount.TabIndex = 4;
            // 
            // chkDateLimit
            // 
            this.chkDateLimit.Enabled = false;
            this.chkDateLimit.Location = new System.Drawing.Point(336, 73);
            this.chkDateLimit.Name = "chkDateLimit";
            this.chkDateLimit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateLimit.Properties.Appearance.Options.UseFont = true;
            this.chkDateLimit.Properties.Caption = "Hạn trả";
            this.chkDateLimit.Size = new System.Drawing.Size(72, 21);
            this.chkDateLimit.TabIndex = 5;
            this.chkDateLimit.CheckedChanged += new System.EventHandler(this.chkDateLimit_CheckedChanged);
            // 
            // txtDays
            // 
            this.txtDays.Enabled = false;
            this.txtDays.EnterMoveNextControl = true;
            this.txtDays.Location = new System.Drawing.Point(414, 73);
            this.txtDays.Name = "txtDays";
            this.txtDays.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDays.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Properties.Appearance.Options.UseBackColor = true;
            this.txtDays.Properties.Appearance.Options.UseFont = true;
            this.txtDays.Properties.Mask.EditMask = "n0";
            this.txtDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDays.Size = new System.Drawing.Size(74, 22);
            this.txtDays.TabIndex = 6;
            // 
            // lbDaysUnit
            // 
            this.lbDaysUnit.AutoSize = true;
            this.lbDaysUnit.Location = new System.Drawing.Point(491, 76);
            this.lbDaysUnit.Name = "lbDaysUnit";
            this.lbDaysUnit.Size = new System.Drawing.Size(41, 16);
            this.lbDaysUnit.TabIndex = 10;
            this.lbDaysUnit.Text = "Ngày";
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(75, 98);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(457, 42);
            this.txtDescription.TabIndex = 7;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(6, 109);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(63, 16);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "$";
            // 
            // chkCash
            // 
            this.chkCash.AllowDrop = true;
            this.chkCash.EditValue = true;
            this.chkCash.Location = new System.Drawing.Point(9, 46);
            this.chkCash.Name = "chkCash";
            this.chkCash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCash.Properties.Appearance.Options.UseFont = true;
            this.chkCash.Properties.Caption = "Thanh toán ngay bằng tiền mặt";
            this.chkCash.Size = new System.Drawing.Size(220, 21);
            this.chkCash.TabIndex = 1;
            this.chkCash.CheckedChanged += new System.EventHandler(this.chkTienMat_CheckedChanged);
            // 
            // UCCustomerDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbDaysUnit);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.chkDateLimit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.chkAmountLimit);
            this.Controls.Add(this.chkNotCash);
            this.Controls.Add(this.dateEditStart);
            this.Controls.Add(this.lbStartDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCustomerDept";
            this.Size = new System.Drawing.Size(538, 147);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNotCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAmountLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDateLimit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCash.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStartDate;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private DevExpress.XtraEditors.CheckEdit chkNotCash;
        private DevExpress.XtraEditors.CheckEdit chkAmountLimit;
        private DevExpress.XtraEditors.TextEdit txtBackGround;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.CheckEdit chkDateLimit;
        private DevExpress.XtraEditors.TextEdit txtDays;
        private System.Windows.Forms.Label lbDaysUnit;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.CheckEdit chkCash;
    }
}
