namespace VNS.ERP.GUI.UserControls.Sales
{
    partial class UCItemSalePrice
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
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbSalePrice = new System.Windows.Forms.Label();
            this.txtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = new System.DateTime(2006, 12, 28, 0, 0, 0, 0);
            this.dateEditStart.EnterMoveNextControl = true;
            this.dateEditStart.Location = new System.Drawing.Point(109, 4);
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
            this.lbStartDate.Location = new System.Drawing.Point(6, 6);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(100, 16);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "Bắt đầu từ ngày";
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.AutoSize = true;
            this.lbSalePrice.Location = new System.Drawing.Point(203, 7);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(53, 16);
            this.lbSalePrice.TabIndex = 4;
            this.lbSalePrice.Text = "Giá tiền";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.AllowDrop = true;
            this.txtSalePrice.EnterMoveNextControl = true;
            this.txtSalePrice.Location = new System.Drawing.Point(260, 4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtSalePrice.Properties.Appearance.Options.UseFont = true;
            this.txtSalePrice.Properties.Mask.EditMask = "n2";
            this.txtSalePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalePrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtSalePrice.Size = new System.Drawing.Size(134, 22);
            this.txtSalePrice.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(109, 29);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(285, 42);
            this.txtDescription.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(42, 40);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(63, 16);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(3, 25);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(24, 22);
            this.txtBackGround.TabIndex = 6;
            this.txtBackGround.Visible = false;
            // 
            // UCItemSalePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.lbSalePrice);
            this.Controls.Add(this.dateEditStart);
            this.Controls.Add(this.lbStartDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCItemSalePrice";
            this.Size = new System.Drawing.Size(403, 76);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbSalePrice;
        private DevExpress.XtraEditors.TextEdit txtSalePrice;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.TextEdit txtBackGround;
    }
}
