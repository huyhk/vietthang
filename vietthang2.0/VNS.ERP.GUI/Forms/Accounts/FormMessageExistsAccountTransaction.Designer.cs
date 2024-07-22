namespace VNS.ERP.GUI
{
    partial class FormMessageExistsAccountTransaction
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
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.btnOpenView = new System.Windows.Forms.Button();
            this.btnOpenEdit = new System.Windows.Forms.Button();
            this.btnDeleteAndCreat = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
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
            // txtMessage
            // 
            this.txtMessage.EditValue = "Phiếu đã được định khoản!";
            this.txtMessage.Location = new System.Drawing.Point(2, 3);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtMessage.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Properties.Appearance.Options.UseBackColor = true;
            this.txtMessage.Properties.Appearance.Options.UseFont = true;
            this.txtMessage.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMessage.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtMessage.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.txtMessage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMessage.Properties.MaxLength = 200;
            this.txtMessage.Properties.ReadOnly = true;
            this.txtMessage.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.Size = new System.Drawing.Size(394, 72);
            this.txtMessage.TabIndex = 4;
            // 
            // btnOpenView
            // 
            this.btnOpenView.Location = new System.Drawing.Point(12, 81);
            this.btnOpenView.Name = "btnOpenView";
            this.btnOpenView.Size = new System.Drawing.Size(74, 27);
            this.btnOpenView.TabIndex = 0;
            this.btnOpenView.Text = "Xem phiếu";
            this.btnOpenView.UseVisualStyleBackColor = true;
            this.btnOpenView.Click += new System.EventHandler(this.btnOpenView_Click);
            // 
            // btnOpenEdit
            // 
            this.btnOpenEdit.Location = new System.Drawing.Point(92, 81);
            this.btnOpenEdit.Name = "btnOpenEdit";
            this.btnOpenEdit.Size = new System.Drawing.Size(74, 27);
            this.btnOpenEdit.TabIndex = 1;
            this.btnOpenEdit.Text = "Sửa phiếu";
            this.btnOpenEdit.UseVisualStyleBackColor = true;
            this.btnOpenEdit.Visible = false;
            this.btnOpenEdit.Click += new System.EventHandler(this.btnOpenEdit_Click);
            // 
            // btnDeleteAndCreat
            // 
            this.btnDeleteAndCreat.Location = new System.Drawing.Point(172, 81);
            this.btnDeleteAndCreat.Name = "btnDeleteAndCreat";
            this.btnDeleteAndCreat.Size = new System.Drawing.Size(119, 27);
            this.btnDeleteAndCreat.TabIndex = 2;
            this.btnDeleteAndCreat.Text = "Xoá phiếu và tạo lại";
            this.btnDeleteAndCreat.UseVisualStyleBackColor = true;
            this.btnDeleteAndCreat.Click += new System.EventHandler(this.btnDeleteAndCreat_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 81);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormMessageExistsAccountTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 112);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAndCreat);
            this.Controls.Add(this.btnOpenEdit);
            this.Controls.Add(this.btnOpenView);
            this.Controls.Add(this.txtMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMessageExistsAccountTransaction";
            this.Text = "Thông báo";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private System.Windows.Forms.Button btnOpenView;
        private System.Windows.Forms.Button btnOpenEdit;
        private System.Windows.Forms.Button btnDeleteAndCreat;
        private System.Windows.Forms.Button btnCancel;
    }
}