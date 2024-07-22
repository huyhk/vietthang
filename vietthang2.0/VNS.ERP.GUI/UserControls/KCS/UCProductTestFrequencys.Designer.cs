using VNS.Windows.Controls;
namespace VNS.ERP.GUI
{
    partial class UCProductTestFrequencys:EditControlBase
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
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditTechCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.lookUpEditFrequencyCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQuantityLocal = new System.Windows.Forms.Label();
            this.txtQuantityLocal = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTechCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFrequencyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityLocal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditTechCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStartDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpEditFrequencyCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantityLocal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantityLocal, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 116);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(93, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 34);
            this.txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(383, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chỉ tiêu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditTechCode
            // 
            this.lookUpEditTechCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditTechCode.EnterMoveNextControl = true;
            this.lookUpEditTechCode.Location = new System.Drawing.Point(514, 7);
            this.lookUpEditTechCode.Name = "lookUpEditTechCode";
            this.lookUpEditTechCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTechCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpEditTechCode.Properties.DisplayMember = "TechName";
            this.lookUpEditTechCode.Properties.NullText = "";
            this.lookUpEditTechCode.Properties.ValueMember = "TechCode";
            this.lookUpEditTechCode.Size = new System.Drawing.Size(284, 20);
            this.lookUpEditTechCode.TabIndex = 1;
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
            this.txtStartDate.Size = new System.Drawing.Size(284, 20);
            this.txtStartDate.TabIndex = 0;
            this.txtStartDate.EditValueChanged += new System.EventHandler(this.txtStartDate_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tần xuất";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpEditFrequencyCode
            // 
            this.lookUpEditFrequencyCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpEditFrequencyCode.EnterMoveNextControl = true;
            this.lookUpEditFrequencyCode.Location = new System.Drawing.Point(93, 43);
            this.lookUpEditFrequencyCode.Name = "lookUpEditFrequencyCode";
            this.lookUpEditFrequencyCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditFrequencyCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpEditFrequencyCode.Properties.DisplayMember = "EnumText";
            this.lookUpEditFrequencyCode.Properties.NullText = "";
            this.lookUpEditFrequencyCode.Properties.ValueMember = "EnumName";
            this.lookUpEditFrequencyCode.Size = new System.Drawing.Size(284, 20);
            this.lookUpEditFrequencyCode.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(383, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tần suất kiểm ngoài";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.EnterMoveNextControl = true;
            this.txtQuantity.Location = new System.Drawing.Point(514, 43);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.DisplayFormat.FormatString = "d";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantity.Properties.Mask.EditMask = "n0";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantity.Size = new System.Drawing.Size(284, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "Diễn giải";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantityLocal
            // 
            this.lblQuantityLocal.AutoSize = true;
            this.lblQuantityLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantityLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblQuantityLocal.Location = new System.Drawing.Point(383, 71);
            this.lblQuantityLocal.Name = "lblQuantityLocal";
            this.lblQuantityLocal.Size = new System.Drawing.Size(125, 45);
            this.lblQuantityLocal.TabIndex = 8;
            this.lblQuantityLocal.Text = "Tần suất kiểm nội bộ:";
            this.lblQuantityLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantityLocal
            // 
            this.txtQuantityLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantityLocal.EnterMoveNextControl = true;
            this.txtQuantityLocal.Location = new System.Drawing.Point(514, 83);
            this.txtQuantityLocal.Name = "txtQuantityLocal";
            this.txtQuantityLocal.Properties.DisplayFormat.FormatString = "d";
            this.txtQuantityLocal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtQuantityLocal.Properties.Mask.EditMask = "n0";
            this.txtQuantityLocal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantityLocal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtQuantityLocal.Size = new System.Drawing.Size(284, 20);
            this.txtQuantityLocal.TabIndex = 5;
            // 
            // UCProductTestFrequencys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCProductTestFrequencys";
            this.Size = new System.Drawing.Size(809, 119);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTechCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditFrequencyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityLocal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditFrequencyCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditTechCode;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantityLocal;
        private DevExpress.XtraEditors.TextEdit txtQuantityLocal;
    }
}
