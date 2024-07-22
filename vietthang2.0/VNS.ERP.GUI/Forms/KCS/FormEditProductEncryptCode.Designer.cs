namespace VNS.ERP.GUI.KCS
{
    partial class FormEditProductEncryptCode
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtEncryptCode = new DevExpress.XtraEditors.TextEdit();
            this.lbEncryptCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEncryptCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            this.defaultLookAndFeel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // defaultBarAndDocking
            // 
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(58, 25);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(219, 38);
            this.txtDescription.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(2, 25);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(51, 17);
            this.lbDescription.TabIndex = 5;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEncryptCode
            // 
            this.txtEncryptCode.EnterMoveNextControl = true;
            this.txtEncryptCode.Location = new System.Drawing.Point(58, 2);
            this.txtEncryptCode.Name = "txtEncryptCode";
            this.txtEncryptCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEncryptCode.Size = new System.Drawing.Size(219, 20);
            this.txtEncryptCode.TabIndex = 0;
            // 
            // lbEncryptCode
            // 
            this.lbEncryptCode.Location = new System.Drawing.Point(2, 3);
            this.lbEncryptCode.Name = "lbEncryptCode";
            this.lbEncryptCode.Size = new System.Drawing.Size(51, 17);
            this.lbEncryptCode.TabIndex = 4;
            this.lbEncryptCode.Text = "Mã mẫu";
            this.lbEncryptCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormEditProductEncryptCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(281, 92);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtEncryptCode);
            this.Controls.Add(this.lbEncryptCode);
            this.Name = "FormEditProductEncryptCode";
            this.Text = "Mã mẫu kiểm thành phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEncryptCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.TextEdit txtEncryptCode;
        private System.Windows.Forms.Label lbEncryptCode;
    }
}
