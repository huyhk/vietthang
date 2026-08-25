namespace VNS.ERP.GUI.Accounting
{
    partial class FormKetChuyenDauKy
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
            this.btn1526111 = new System.Windows.Forms.Button();
            this.btn155632 = new System.Windows.Forms.Button();
            this.lookUpEditDate = new DevExpress.XtraEditors.LookUpEdit();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).BeginInit();
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
            // btn1526111
            // 
            this.btn1526111.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1526111.Location = new System.Drawing.Point(1, 31);
            this.btn1526111.Name = "btn1526111";
            this.btn1526111.Size = new System.Drawing.Size(210, 113);
            this.btn1526111.TabIndex = 0;
            this.btn1526111.Text = "Kết chuyển nguyên liệu";
            this.btn1526111.UseVisualStyleBackColor = true;
            this.btn1526111.Click += new System.EventHandler(this.btn1526111_Click);
            // 
            // btn155632
            // 
            this.btn155632.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn155632.Location = new System.Drawing.Point(217, 31);
            this.btn155632.Name = "btn155632";
            this.btn155632.Size = new System.Drawing.Size(210, 113);
            this.btn155632.TabIndex = 1;
            this.btn155632.Text = "Kết chuyển thành phẩm";
            this.btn155632.UseVisualStyleBackColor = true;
            this.btn155632.Click += new System.EventHandler(this.btn155632_Click);
            // 
            // lookUpEditDate
            // 
            this.lookUpEditDate.EnterMoveNextControl = true;
            this.lookUpEditDate.Location = new System.Drawing.Point(74, 7);
            this.lookUpEditDate.Name = "lookUpEditDate";
            this.lookUpEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpEditDate.Properties.DisplayMember = "Description";
            this.lookUpEditDate.Properties.NullText = "";
            this.lookUpEditDate.Properties.ShowHeader = false;
            this.lookUpEditDate.Properties.ValueMember = "EndDate";
            this.lookUpEditDate.Size = new System.Drawing.Size(222, 20);
            this.lookUpEditDate.TabIndex = 11;
            this.lookUpEditDate.EditValueChanged += new System.EventHandler(this.lookUpEditDate_EditValueChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(12, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(58, 13);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "Kỳ kế toán";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormKetChuyenDauKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(429, 146);
            this.Controls.Add(this.lookUpEditDate);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btn155632);
            this.Controls.Add(this.btn1526111);
            this.Name = "FormKetChuyenDauKy";
            this.Text = "Kết chuyển đầu kỳ";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1526111;
        private System.Windows.Forms.Button btn155632;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDate;
        private System.Windows.Forms.Label lbTime;
    }
}
