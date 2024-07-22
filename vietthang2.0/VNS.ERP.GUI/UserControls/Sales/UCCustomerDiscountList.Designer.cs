namespace VNS.ERP.GUI.UserControls
{
    partial class UCCustomerDiscountList
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDiscountTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscountName = new DevExpress.XtraEditors.TextEdit();
            this.chkInActive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiscountTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại chiết khấu";
            // 
            // lookUpEditDiscountTypeCode
            // 
            this.lookUpEditDiscountTypeCode.Location = new System.Drawing.Point(147, 30);
            this.lookUpEditDiscountTypeCode.Name = "lookUpEditDiscountTypeCode";
            this.lookUpEditDiscountTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDiscountTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeCode", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiscountTypeName", "Tên chiết khấu")});
            this.lookUpEditDiscountTypeCode.Properties.DisplayMember = "DiscountTypeName";
            this.lookUpEditDiscountTypeCode.Properties.NullText = "";
            this.lookUpEditDiscountTypeCode.Properties.ValueMember = "DiscountTypeCode";
            this.lookUpEditDiscountTypeCode.Size = new System.Drawing.Size(272, 20);
            this.lookUpEditDiscountTypeCode.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên chiết khấu";
            // 
            // txtDiscountName
            // 
            this.txtDiscountName.Location = new System.Drawing.Point(147, 61);
            this.txtDiscountName.Name = "txtDiscountName";
            this.txtDiscountName.Size = new System.Drawing.Size(272, 20);
            this.txtDiscountName.TabIndex = 4;
            // 
            // chkInActive
            // 
            this.chkInActive.Location = new System.Drawing.Point(145, 101);
            this.chkInActive.Name = "chkInActive";
            this.chkInActive.Properties.Caption = "Không còn sử dụng";
            this.chkInActive.Size = new System.Drawing.Size(132, 19);
            this.chkInActive.TabIndex = 5;
            // 
            // UCCustomerDiscountList
            // 
            this.Controls.Add(this.chkInActive);
            this.Controls.Add(this.txtDiscountName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookUpEditDiscountTypeCode);
            this.Controls.Add(this.labelControl1);
            this.Name = "UCCustomerDiscountList";
            this.Size = new System.Drawing.Size(543, 184);
            this.Load += new System.EventHandler(this.UCCustomerDiscountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDiscountTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInActive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDiscountTypeCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDiscountName;
        private DevExpress.XtraEditors.CheckEdit chkInActive;
    }
}
