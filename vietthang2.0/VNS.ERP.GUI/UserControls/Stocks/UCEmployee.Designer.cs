namespace VNS.ERP.GUI.UserControls
{
    partial class UCEmployee
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
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new DevExpress.XtraEditors.TextEdit();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbStockCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(802, 12);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(24, 22);
            this.txtBackGround.TabIndex = 23;
            this.txtBackGround.Visible = false;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(215, 12);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(92, 16);
            this.lbEmployeeName.TabIndex = 22;
            this.lbEmployeeName.Text = "Tên nhân viên";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.EnterMoveNextControl = true;
            this.txtEmployeeName.Location = new System.Drawing.Point(313, 8);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeName.Properties.MaxLength = 100;
            this.txtEmployeeName.Size = new System.Drawing.Size(236, 22);
            this.txtEmployeeName.TabIndex = 20;
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.Location = new System.Drawing.Point(7, 10);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(91, 16);
            this.lbEmployeeID.TabIndex = 21;
            this.lbEmployeeID.Text = "Mã nhân viên";
            this.lbEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.EnterMoveNextControl = true;
            this.txtEmployeeID.Location = new System.Drawing.Point(105, 9);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmployeeID.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmployeeID.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmployeeID.Properties.MaxLength = 10;
            this.txtEmployeeID.Size = new System.Drawing.Size(109, 22);
            this.txtEmployeeID.TabIndex = 19;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Location = new System.Drawing.Point(656, 9);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 70),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 130)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(110, 22);
            this.lookUpStockCode.TabIndex = 25;
            // 
            // lbStockCode
            // 
            this.lbStockCode.Location = new System.Drawing.Point(556, 10);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(95, 18);
            this.lbStockCode.TabIndex = 24;
            this.lbStockCode.Text = "Kho làm việc";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpStockCode);
            this.Controls.Add(this.lbStockCode);
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.txtEmployeeID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(774, 37);
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtBackGround;
        private System.Windows.Forms.Label lbEmployeeName;
        private DevExpress.XtraEditors.TextEdit txtEmployeeName;
        private System.Windows.Forms.Label lbEmployeeID;
        private DevExpress.XtraEditors.TextEdit txtEmployeeID;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lbStockCode;
    }
}
