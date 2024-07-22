namespace VNS.ERP.GUI.UserControl
{
    partial class UCInstrumentItem
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
            this.lbItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.lbItemName = new System.Windows.Forms.Label();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.lbUnit = new System.Windows.Forms.Label();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbItemCode
            // 
            this.lbItemCode.AutoSize = true;
            this.lbItemCode.Location = new System.Drawing.Point(40, 6);
            this.lbItemCode.Name = "lbItemCode";
            this.lbItemCode.Size = new System.Drawing.Size(22, 13);
            this.lbItemCode.TabIndex = 4;
            this.lbItemCode.Text = "Mã";
            // 
            // txtItemCode
            // 
            this.txtItemCode.EnterMoveNextControl = true;
            this.txtItemCode.Location = new System.Drawing.Point(68, 3);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItemCode.Properties.MaxLength = 10;
            this.txtItemCode.Size = new System.Drawing.Size(103, 20);
            this.txtItemCode.TabIndex = 0;
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(177, 6);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(26, 13);
            this.lbItemName.TabIndex = 5;
            this.lbItemName.Text = "Tên";
            // 
            // txtItemName
            // 
            this.txtItemName.EnterMoveNextControl = true;
            this.txtItemName.Location = new System.Drawing.Point(209, 3);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(242, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(457, 6);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(60, 13);
            this.lbUnit.TabIndex = 6;
            this.lbUnit.Text = "Đơn vị tính";
            // 
            // txtUnit
            // 
            this.txtUnit.EnterMoveNextControl = true;
            this.txtUnit.Location = new System.Drawing.Point(523, 3);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(103, 20);
            this.txtUnit.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(68, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(558, 50);
            this.txtDescription.TabIndex = 3;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(14, 41);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(48, 13);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Diễn giải";
            // 
            // UCInstrumentItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lbUnit);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lbItemCode);
            this.Name = "UCInstrumentItem";
            this.Size = new System.Drawing.Size(634, 82);
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbItemCode;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private System.Windows.Forms.Label lbItemName;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private System.Windows.Forms.Label lbUnit;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
    }
}
