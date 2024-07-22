namespace VNS.ERP.GUI
{
    partial class UCMaterialTestFrequencys
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.dateEditStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTechCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblFrequencyType = new System.Windows.Forms.Label();
            this.lookUpFrequencyType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpTechnic = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblQuantityLocal = new System.Windows.Forms.Label();
            this.txtQuantityLocal = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFrequencyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityLocal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEditStartDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTechCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFrequencyType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpFrequencyType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpTechnic, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantityLocal, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantityLocal, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 132);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(362, 29);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantity.Properties.DisplayFormat.FormatString = "n0";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantity.Properties.Mask.EditMask = "n0";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Size = new System.Drawing.Size(144, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // dateEditStartDate
            // 
            this.dateEditStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEditStartDate.EditValue = new System.DateTime(2008, 2, 20, 0, 0, 0, 0);
            this.dateEditStartDate.EnterMoveNextControl = true;
            this.dateEditStartDate.Location = new System.Drawing.Point(95, 3);
            this.dateEditStartDate.Name = "dateEditStartDate";
            this.dateEditStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStartDate.Size = new System.Drawing.Size(140, 20);
            this.dateEditStartDate.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(41, 83);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(48, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Diễn giải";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(57, 6);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(32, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Ngày";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTechCode
            // 
            this.lblTechCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTechCode.Location = new System.Drawing.Point(297, 6);
            this.lblTechCode.Name = "lblTechCode";
            this.lblTechCode.Size = new System.Drawing.Size(59, 13);
            this.lblTechCode.TabIndex = 3;
            this.lblTechCode.Text = "Chỉ tiêu";
            this.lblTechCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.Location = new System.Drawing.Point(250, 33);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(106, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Tần suất kiểm ngoài";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFrequencyType
            // 
            this.lblFrequencyType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFrequencyType.AutoSize = true;
            this.lblFrequencyType.Location = new System.Drawing.Point(21, 33);
            this.lblFrequencyType.Name = "lblFrequencyType";
            this.lblFrequencyType.Size = new System.Drawing.Size(68, 13);
            this.lblFrequencyType.TabIndex = 4;
            this.lblFrequencyType.Text = "Loại tần suất";
            this.lblFrequencyType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpFrequencyType
            // 
            this.lookUpFrequencyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpFrequencyType.EnterMoveNextControl = true;
            this.lookUpFrequencyType.Location = new System.Drawing.Point(95, 29);
            this.lookUpFrequencyType.Name = "lookUpFrequencyType";
            this.lookUpFrequencyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFrequencyType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpFrequencyType.Properties.NullText = "";
            this.lookUpFrequencyType.Size = new System.Drawing.Size(140, 20);
            this.lookUpFrequencyType.TabIndex = 2;
            // 
            // lookUpTechnic
            // 
            this.lookUpTechnic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookUpTechnic.EnterMoveNextControl = true;
            this.lookUpTechnic.Location = new System.Drawing.Point(362, 3);
            this.lookUpTechnic.Name = "lookUpTechnic";
            this.lookUpTechnic.Properties.Appearance.Options.UseTextOptions = true;
            this.lookUpTechnic.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lookUpTechnic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTechnic.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpTechnic.Properties.NullText = "";
            this.lookUpTechnic.Size = new System.Drawing.Size(144, 20);
            this.lookUpTechnic.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 4);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(95, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(411, 43);
            this.txtDescription.TabIndex = 5;
            // 
            // lblQuantityLocal
            // 
            this.lblQuantityLocal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantityLocal.AutoSize = true;
            this.lblQuantityLocal.Location = new System.Drawing.Point(275, 62);
            this.lblQuantityLocal.Name = "lblQuantityLocal";
            this.lblQuantityLocal.Size = new System.Drawing.Size(81, 13);
            this.lblQuantityLocal.TabIndex = 7;
            this.lblQuantityLocal.Text = "Tần suất nội bộ";
            // 
            // txtQuantityLocal
            // 
            this.txtQuantityLocal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuantityLocal.EnterMoveNextControl = true;
            this.txtQuantityLocal.Location = new System.Drawing.Point(362, 58);
            this.txtQuantityLocal.Name = "txtQuantityLocal";
            this.txtQuantityLocal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantityLocal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantityLocal.Properties.DisplayFormat.FormatString = "n0";
            this.txtQuantityLocal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantityLocal.Properties.Mask.EditMask = "n0";
            this.txtQuantityLocal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantityLocal.Size = new System.Drawing.Size(144, 20);
            this.txtQuantityLocal.TabIndex = 4;
            // 
            // UCMaterialTestFrequencys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCMaterialTestFrequencys";
            this.Size = new System.Drawing.Size(509, 132);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFrequencyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityLocal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFrequencyType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTechCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.DateEdit dateEditStartDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpFrequencyType;
        private DevExpress.XtraEditors.LookUpEdit lookUpTechnic;
        private System.Windows.Forms.Label lblQuantityLocal;
        private DevExpress.XtraEditors.TextEdit txtQuantityLocal;
    }
}
