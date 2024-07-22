namespace VNS.ERP.GUI
{
    partial class UCMaterialQualityStandards
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
            this.txtValueString = new DevExpress.XtraEditors.TextEdit();
            this.dateEditStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTechCode = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblConditionType = new System.Windows.Forms.Label();
            this.lookUpConditionType = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpTechnic = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpConditionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtValueString, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateEditStartDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTechCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblConditionType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpConditionType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpTechnic, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 102);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtValueString
            // 
            this.txtValueString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValueString.EnterMoveNextControl = true;
            this.txtValueString.Location = new System.Drawing.Point(329, 29);
            this.txtValueString.Name = "txtValueString";
            this.txtValueString.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValueString.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValueString.Size = new System.Drawing.Size(160, 20);
            this.txtValueString.TabIndex = 3;
            // 
            // dateEditStartDate
            // 
            this.dateEditStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEditStartDate.EditValue = new System.DateTime(2008, 2, 20, 0, 0, 0, 0);
            this.dateEditStartDate.EnterMoveNextControl = true;
            this.dateEditStartDate.Location = new System.Drawing.Point(88, 3);
            this.dateEditStartDate.Name = "dateEditStartDate";
            this.dateEditStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStartDate.Size = new System.Drawing.Size(160, 20);
            this.dateEditStartDate.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(3, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 48);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Diễn giải";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(50, 6);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(32, 13);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Ngày";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTechCode
            // 
            this.lblTechCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTechCode.Location = new System.Drawing.Point(264, 6);
            this.lblTechCode.Name = "lblTechCode";
            this.lblTechCode.Size = new System.Drawing.Size(59, 13);
            this.lblTechCode.TabIndex = 3;
            this.lblTechCode.Text = "Chỉ tiêu";
            this.lblTechCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantity.Location = new System.Drawing.Point(264, 33);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 13);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Giá trị";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConditionType
            // 
            this.lblConditionType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConditionType.AutoSize = true;
            this.lblConditionType.Location = new System.Drawing.Point(30, 33);
            this.lblConditionType.Name = "lblConditionType";
            this.lblConditionType.Size = new System.Drawing.Size(52, 13);
            this.lblConditionType.TabIndex = 4;
            this.lblConditionType.Text = "Điều kiện";
            this.lblConditionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpConditionType
            // 
            this.lookUpConditionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpConditionType.EnterMoveNextControl = true;
            this.lookUpConditionType.Location = new System.Drawing.Point(88, 29);
            this.lookUpConditionType.Name = "lookUpConditionType";
            this.lookUpConditionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpConditionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpConditionType.Properties.NullText = "";
            this.lookUpConditionType.Size = new System.Drawing.Size(160, 20);
            this.lookUpConditionType.TabIndex = 2;
            // 
            // lookUpTechnic
            // 
            this.lookUpTechnic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpTechnic.EnterMoveNextControl = true;
            this.lookUpTechnic.Location = new System.Drawing.Point(329, 3);
            this.lookUpTechnic.Name = "lookUpTechnic";
            this.lookUpTechnic.Properties.Appearance.Options.UseTextOptions = true;
            this.lookUpTechnic.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lookUpTechnic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTechnic.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpTechnic.Properties.NullText = "";
            this.lookUpTechnic.Size = new System.Drawing.Size(160, 20);
            this.lookUpTechnic.TabIndex = 1;
            this.lookUpTechnic.EditValueChanged += new System.EventHandler(this.lookUpTechnic_EditValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(88, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(401, 35);
            this.txtDescription.TabIndex = 4;
            // 
            // UCMaterialQualityStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCMaterialQualityStandards";
            this.Size = new System.Drawing.Size(498, 109);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpConditionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtValueString;
        private DevExpress.XtraEditors.DateEdit dateEditStartDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTechCode;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblConditionType;
        private DevExpress.XtraEditors.LookUpEdit lookUpConditionType;
        private DevExpress.XtraEditors.LookUpEdit lookUpTechnic;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}
