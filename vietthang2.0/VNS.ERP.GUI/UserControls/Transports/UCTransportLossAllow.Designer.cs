namespace VNS.ERP.GUI.Transports
{
    partial class UCTransportLossAllow
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
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbLossAllowRate = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.txtLossAllowRate = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.checkListItem = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.checkListTransportType = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.checkListTransportItemType = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLossAllowRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListTransportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListTransportItemType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStartDate
            // 
            this.lbStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbStartDate.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbStartDate, 2);
            this.lbStartDate.Location = new System.Drawing.Point(108, 6);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(72, 13);
            this.lbStartDate.TabIndex = 0;
            this.lbStartDate.Text = "Ngày bắt đầu";
            // 
            // lbLossAllowRate
            // 
            this.lbLossAllowRate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbLossAllowRate.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbLossAllowRate, 2);
            this.lbLossAllowRate.Location = new System.Drawing.Point(153, 31);
            this.lbLossAllowRate.Name = "lbLossAllowRate";
            this.lbLossAllowRate.Size = new System.Drawing.Size(27, 13);
            this.lbLossAllowRate.TabIndex = 0;
            this.lbLossAllowRate.Text = "Tỉ lệ";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbDescription, 2);
            this.lbDescription.Location = new System.Drawing.Point(136, 50);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(44, 13);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Ghi chú";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStartDate.EditValue = new System.DateTime(2009, 10, 27, 0, 0, 0, 0);
            this.txtStartDate.EnterMoveNextControl = true;
            this.txtStartDate.Location = new System.Drawing.Point(186, 3);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Size = new System.Drawing.Size(105, 20);
            this.txtStartDate.TabIndex = 1;
            // 
            // txtLossAllowRate
            // 
            this.txtLossAllowRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLossAllowRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtLossAllowRate.EnterMoveNextControl = true;
            this.txtLossAllowRate.Location = new System.Drawing.Point(186, 28);
            this.txtLossAllowRate.Name = "txtLossAllowRate";
            this.txtLossAllowRate.Properties.DisplayFormat.FormatString = "p";
            this.txtLossAllowRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLossAllowRate.Properties.Mask.EditMask = "p";
            this.txtLossAllowRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLossAllowRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLossAllowRate.Size = new System.Drawing.Size(105, 20);
            this.txtLossAllowRate.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(186, 53);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(177, 56);
            this.txtDescription.TabIndex = 3;
            // 
            // checkListItem
            // 
            this.checkListItem.DisplayMember = "ItemName";
            this.checkListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListItem.Location = new System.Drawing.Point(3, 16);
            this.checkListItem.Name = "checkListItem";
            this.checkListItem.Size = new System.Drawing.Size(158, 292);
            this.checkListItem.TabIndex = 4;
            this.checkListItem.ValueMember = "ItemCode";
            // 
            // checkListTransportType
            // 
            this.checkListTransportType.DisplayMember = "TypeName";
            this.checkListTransportType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListTransportType.Location = new System.Drawing.Point(3, 16);
            this.checkListTransportType.Name = "checkListTransportType";
            this.checkListTransportType.Size = new System.Drawing.Size(151, 292);
            this.checkListTransportType.TabIndex = 4;
            this.checkListTransportType.ValueMember = "TypeCode";
            // 
            // checkListTransportItemType
            // 
            this.checkListTransportItemType.DisplayMember = "TypeName";
            this.checkListTransportItemType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListTransportItemType.Location = new System.Drawing.Point(3, 16);
            this.checkListTransportItemType.Name = "checkListTransportItemType";
            this.checkListTransportItemType.Size = new System.Drawing.Size(151, 292);
            this.checkListTransportItemType.TabIndex = 4;
            this.checkListTransportItemType.ValueMember = "TypeCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkListItem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(369, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkListTransportType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 311);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phương tiện";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkListTransportItemType);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(186, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 311);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại hàng";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtStartDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStartDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLossAllowRate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbLossAllowRate, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 429);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // UCTransportLossAllow
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCTransportLossAllow";
            this.Size = new System.Drawing.Size(536, 429);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLossAllowRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListTransportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListTransportItemType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbLossAllowRate;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.TextEdit txtLossAllowRate;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.CheckedListBoxControl checkListItem;
        private DevExpress.XtraEditors.CheckedListBoxControl checkListTransportType;
        private DevExpress.XtraEditors.CheckedListBoxControl checkListTransportItemType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
