namespace VNS.ERP.GUI.UserControl
{
    partial class UCSelectBranch
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
            this.txtMSThue = new DevExpress.XtraEditors.TextEdit();
            this.lbMSThue = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lookUpBranchCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameText = new DevExpress.XtraEditors.TextEdit();
            this.lbNameText = new System.Windows.Forms.Label();
            this.gbBranch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameText.Properties)).BeginInit();
            this.gbBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMSThue
            // 
            this.txtMSThue.EditValue = "1400437290";
            this.txtMSThue.Location = new System.Drawing.Point(370, 35);
            this.txtMSThue.Name = "txtMSThue";
            this.txtMSThue.Properties.ReadOnly = true;
            this.txtMSThue.Size = new System.Drawing.Size(84, 20);
            this.txtMSThue.TabIndex = 2;
            // 
            // lbMSThue
            // 
            this.lbMSThue.Location = new System.Drawing.Point(317, 36);
            this.lbMSThue.Name = "lbMSThue";
            this.lbMSThue.Size = new System.Drawing.Size(52, 18);
            this.lbMSThue.TabIndex = 6;
            this.lbMSThue.Text = "MS thuế";
            this.lbMSThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.EditValue = "Lô 2 - Lô 4, Khu công nghiệp C, Thị Xã SaĐéc, Tỉnh Đồng Tháp";
            this.txtAddress.Location = new System.Drawing.Point(122, 58);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(332, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lbAddress
            // 
            this.lbAddress.Location = new System.Drawing.Point(70, 58);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(48, 18);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "Địa chỉ";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpBranchCode
            // 
            this.lookUpBranchCode.Location = new System.Drawing.Point(122, 35);
            this.lookUpBranchCode.Name = "lookUpBranchCode";
            this.lookUpBranchCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBranchCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên chi nhánh", 220)});
            this.lookUpBranchCode.Properties.DisplayMember = "SubjectName";
            this.lookUpBranchCode.Properties.NullText = "";
            this.lookUpBranchCode.Properties.PopupWidth = 300;
            this.lookUpBranchCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpBranchCode.Properties.ValueMember = "SubjectCode";
            this.lookUpBranchCode.Size = new System.Drawing.Size(189, 20);
            this.lookUpBranchCode.TabIndex = 1;
            this.lookUpBranchCode.EditValueChanged += new System.EventHandler(this.lookUpBranchCode_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(57, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chi nhánh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNameText
            // 
            this.txtNameText.EditValue = "CÔNG TY CỔ PHẦN THUỶ SẢN VIỆT THẮNG";
            this.txtNameText.Location = new System.Drawing.Point(122, 12);
            this.txtNameText.Name = "txtNameText";
            this.txtNameText.Size = new System.Drawing.Size(332, 20);
            this.txtNameText.TabIndex = 0;
            // 
            // lbNameText
            // 
            this.lbNameText.Location = new System.Drawing.Point(3, 12);
            this.lbNameText.Name = "lbNameText";
            this.lbNameText.Size = new System.Drawing.Size(116, 18);
            this.lbNameText.TabIndex = 4;
            this.lbNameText.Text = "Tên trụ sở kinh doanh";
            this.lbNameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbBranch
            // 
            this.gbBranch.Controls.Add(this.txtNameText);
            this.gbBranch.Controls.Add(this.txtMSThue);
            this.gbBranch.Controls.Add(this.lbNameText);
            this.gbBranch.Controls.Add(this.lbMSThue);
            this.gbBranch.Controls.Add(this.label3);
            this.gbBranch.Controls.Add(this.txtAddress);
            this.gbBranch.Controls.Add(this.lookUpBranchCode);
            this.gbBranch.Controls.Add(this.lbAddress);
            this.gbBranch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBranch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbBranch.Location = new System.Drawing.Point(0, 0);
            this.gbBranch.Name = "gbBranch";
            this.gbBranch.Size = new System.Drawing.Size(463, 83);
            this.gbBranch.TabIndex = 0;
            this.gbBranch.TabStop = false;
            this.gbBranch.Text = "Chi nhánh";
            // 
            // UCSelectBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbBranch);
            this.Name = "UCSelectBranch";
            this.Size = new System.Drawing.Size(463, 83);
            ((System.ComponentModel.ISupportInitialize)(this.txtMSThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBranchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameText.Properties)).EndInit();
            this.gbBranch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMSThue;
        private System.Windows.Forms.Label lbMSThue;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private DevExpress.XtraEditors.LookUpEdit lookUpBranchCode;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNameText;
        private System.Windows.Forms.Label lbNameText;
        private System.Windows.Forms.GroupBox gbBranch;
    }
}
