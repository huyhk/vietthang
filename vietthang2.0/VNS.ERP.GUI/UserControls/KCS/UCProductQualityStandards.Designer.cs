namespace VNS.ERP.GUI
{
    partial class UCProductQualityStandards
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
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditTechCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lookUpEditConditionType = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValueString = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTechCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditConditionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueString.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(93, 74);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(558, 32);
            this.txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(335, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chỉ tiêu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditTechCode
            // 
            this.lookUpEditTechCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditTechCode.EnterMoveNextControl = true;
            this.lookUpEditTechCode.Location = new System.Drawing.Point(415, 7);
            this.lookUpEditTechCode.Name = "lookUpEditTechCode";
            this.lookUpEditTechCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTechCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpEditTechCode.Properties.DisplayMember = "TechName";
            this.lookUpEditTechCode.Properties.NullText = "";
            this.lookUpEditTechCode.Properties.ValueMember = "TechCode";
            this.lookUpEditTechCode.Size = new System.Drawing.Size(236, 20);
            this.lookUpEditTechCode.TabIndex = 1;
            this.lookUpEditTechCode.EditValueChanged += new System.EventHandler(this.lookUpEditTechCode_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày bắt đầu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartDate.EditValue = new System.DateTime(2008, 5, 24, 0, 0, 0, 0);
            this.txtStartDate.EnterMoveNextControl = true;
            this.txtStartDate.Location = new System.Drawing.Point(93, 7);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Size = new System.Drawing.Size(236, 20);
            this.txtStartDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điều kiện";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditTechCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStartDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditConditionType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtValueString, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 109);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lookUpEditConditionType
            // 
            this.lookUpEditConditionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditConditionType.EnterMoveNextControl = true;
            this.lookUpEditConditionType.Location = new System.Drawing.Point(93, 43);
            this.lookUpEditConditionType.Name = "lookUpEditConditionType";
            this.lookUpEditConditionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditConditionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpEditConditionType.Properties.DisplayMember = "EnumText";
            this.lookUpEditConditionType.Properties.NullText = "";
            this.lookUpEditConditionType.Properties.ValueMember = "EnumName";
            this.lookUpEditConditionType.Size = new System.Drawing.Size(236, 20);
            this.lookUpEditConditionType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(335, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Chuỗi giá trị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValueString
            // 
            this.txtValueString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValueString.EnterMoveNextControl = true;
            this.txtValueString.Location = new System.Drawing.Point(415, 43);
            this.txtValueString.Name = "txtValueString";
            this.txtValueString.Properties.DisplayFormat.FormatString = "d";
            this.txtValueString.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtValueString.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValueString.Size = new System.Drawing.Size(236, 20);
            this.txtValueString.TabIndex = 3;
            //this.txtValueString.EditValueChanged += new System.EventHandler(this.txtValueString_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 38);
            this.label6.TabIndex = 11;
            this.label6.Text = "Diễn giải";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCProductQualityStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCProductQualityStandards";
            this.Size = new System.Drawing.Size(660, 115);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTechCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditConditionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValueString.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTechCode;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditConditionType;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtValueString;
        private System.Windows.Forms.Label label6;
    }
}
