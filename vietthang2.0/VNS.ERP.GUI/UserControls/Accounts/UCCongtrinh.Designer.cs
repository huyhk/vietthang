namespace VNS.ERP.GUI.UserControls
{
    partial class UCCongtrinh
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
            this.txtCongtrinhName = new DevExpress.XtraEditors.TextEdit();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txtCongtrinhCode = new DevExpress.XtraEditors.TextEdit();
            this.lbAccountCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongtrinhName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongtrinhCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(567, 50);
            this.txtDescription.TabIndex = 15;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(37, 44);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(48, 13);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Diễn giải";
            // 
            // txtCongtrinhName
            // 
            this.txtCongtrinhName.Location = new System.Drawing.Point(273, 4);
            this.txtCongtrinhName.Name = "txtCongtrinhName";
            this.txtCongtrinhName.Size = new System.Drawing.Size(381, 20);
            this.txtCongtrinhName.TabIndex = 14;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(197, 7);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(76, 13);
            this.lbAccountName.TabIndex = 17;
            this.lbAccountName.Text = "Tên công trình";
            // 
            // txtCongtrinhCode
            // 
            this.txtCongtrinhCode.Location = new System.Drawing.Point(87, 5);
            this.txtCongtrinhCode.Name = "txtCongtrinhCode";
            this.txtCongtrinhCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongtrinhCode.Properties.Appearance.Options.UseFont = true;
            this.txtCongtrinhCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCongtrinhCode.Properties.MaxLength = 20;
            this.txtCongtrinhCode.Size = new System.Drawing.Size(104, 19);
            this.txtCongtrinhCode.TabIndex = 13;
            // 
            // lbAccountCode
            // 
            this.lbAccountCode.AutoSize = true;
            this.lbAccountCode.Location = new System.Drawing.Point(15, 8);
            this.lbAccountCode.Name = "lbAccountCode";
            this.lbAccountCode.Size = new System.Drawing.Size(72, 13);
            this.lbAccountCode.TabIndex = 16;
            this.lbAccountCode.Text = "Mã công trình";
            // 
            // UCCongtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtCongtrinhName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.txtCongtrinhCode);
            this.Controls.Add(this.lbAccountCode);
            this.Name = "UCCongtrinh";
            this.Size = new System.Drawing.Size(657, 80);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongtrinhName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongtrinhCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.TextEdit txtCongtrinhName;
        private System.Windows.Forms.Label lbAccountName;
        private DevExpress.XtraEditors.TextEdit txtCongtrinhCode;
        private System.Windows.Forms.Label lbAccountCode;
    }
}
