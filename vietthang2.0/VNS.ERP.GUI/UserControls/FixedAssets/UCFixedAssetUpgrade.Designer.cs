namespace VNS.ERP.GUI
{
    partial class UCFixedAssetUpgrade
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
            this.tapFixedAssetUpgrade = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtTap = new System.Windows.Forms.TableLayoutPanel();
            this.lblFixedAssetCode = new System.Windows.Forms.Label();
            this.cboStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cboFixedAssetCode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMonthUsing = new System.Windows.Forms.Label();
            this.txtMonthUsing = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.txtDescription1 = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapFixedAssetUpgrade)).BeginInit();
            this.tapFixedAssetUpgrade.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.txtTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFixedAssetCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthUsing.Properties)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription1.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(788, 476);
            // 
            // tapFixedAssetUpgrade
            // 
            this.tapFixedAssetUpgrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tapFixedAssetUpgrade.Location = new System.Drawing.Point(0, 0);
            this.tapFixedAssetUpgrade.Name = "tapFixedAssetUpgrade";
            this.tapFixedAssetUpgrade.SelectedTabPage = this.xtraTabPage2;
            this.tapFixedAssetUpgrade.Size = new System.Drawing.Size(794, 502);
            this.tapFixedAssetUpgrade.TabIndex = 0;
            this.tapFixedAssetUpgrade.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.tapFixedAssetUpgrade.Text = "xtraTabControl1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panelControl2);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(788, 476);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtTap);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(788, 476);
            this.panelControl2.TabIndex = 0;
            this.panelControl2.Text = "panelControl2";
            // 
            // txtTap
            // 
            this.txtTap.ColumnCount = 2;
            this.txtTap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.txtTap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.txtTap.Controls.Add(this.lblFixedAssetCode, 0, 1);
            this.txtTap.Controls.Add(this.cboStartDate, 1, 2);
            this.txtTap.Controls.Add(this.lblStartDate, 0, 2);
            this.txtTap.Controls.Add(this.cboFixedAssetCode, 1, 1);
            this.txtTap.Controls.Add(this.txtAmount, 1, 3);
            this.txtTap.Controls.Add(this.lblAmount, 0, 3);
            this.txtTap.Controls.Add(this.lblMonthUsing, 0, 4);
            this.txtTap.Controls.Add(this.txtMonthUsing, 1, 4);
            this.txtTap.Controls.Add(this.tableLayoutPanel13, 0, 5);
            this.txtTap.Controls.Add(this.txtDescription1, 1, 5);
            this.txtTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTap.Location = new System.Drawing.Point(4, 4);
            this.txtTap.Name = "txtTap";
            this.txtTap.RowCount = 6;
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.txtTap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.txtTap.Size = new System.Drawing.Size(780, 468);
            this.txtTap.TabIndex = 0;
            // 
            // lblFixedAssetCode
            // 
            this.lblFixedAssetCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFixedAssetCode.AutoSize = true;
            this.lblFixedAssetCode.Location = new System.Drawing.Point(90, 26);
            this.lblFixedAssetCode.Name = "lblFixedAssetCode";
            this.lblFixedAssetCode.Size = new System.Drawing.Size(83, 13);
            this.lblFixedAssetCode.TabIndex = 0;
            this.lblFixedAssetCode.Text = "FixedAssetCode";
            this.lblFixedAssetCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStartDate
            // 
            this.cboStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStartDate.EditValue = new System.DateTime(2007, 5, 17, 15, 1, 52, 0);
            this.cboStartDate.EnterMoveNextControl = true;
            this.cboStartDate.Location = new System.Drawing.Point(179, 48);
            this.cboStartDate.Name = "cboStartDate";
            this.cboStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStartDate.Size = new System.Drawing.Size(206, 20);
            this.cboStartDate.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(121, 51);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(52, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "StartDate";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboFixedAssetCode
            // 
            this.cboFixedAssetCode.EnterMoveNextControl = true;
            this.cboFixedAssetCode.Location = new System.Drawing.Point(179, 23);
            this.cboFixedAssetCode.Name = "cboFixedAssetCode";
            this.cboFixedAssetCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFixedAssetCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FixedAssetCode", "Mã TSCĐ", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FixedAssetName", "Tên TSCĐ", 220)});
            this.cboFixedAssetCode.Properties.DisplayMember = "FixedAssetName";
            this.cboFixedAssetCode.Properties.NullText = "";
            this.cboFixedAssetCode.Properties.PopupWidth = 300;
            this.cboFixedAssetCode.Properties.ValueMember = "FixedAssetCode";
            this.cboFixedAssetCode.Size = new System.Drawing.Size(206, 20);
            this.cboFixedAssetCode.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(179, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Properties.NullText = "0";
            this.txtAmount.Properties.ValidateOnEnterKey = true;
            this.txtAmount.Size = new System.Drawing.Size(206, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(130, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMonthUsing
            // 
            this.lblMonthUsing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMonthUsing.AutoSize = true;
            this.lblMonthUsing.Location = new System.Drawing.Point(109, 101);
            this.lblMonthUsing.Name = "lblMonthUsing";
            this.lblMonthUsing.Size = new System.Drawing.Size(64, 13);
            this.lblMonthUsing.TabIndex = 0;
            this.lblMonthUsing.Text = "MonthUsing";
            this.lblMonthUsing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonthUsing
            // 
            this.txtMonthUsing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMonthUsing.EnterMoveNextControl = true;
            this.txtMonthUsing.Location = new System.Drawing.Point(179, 98);
            this.txtMonthUsing.Name = "txtMonthUsing";
            this.txtMonthUsing.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMonthUsing.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMonthUsing.Properties.Mask.EditMask = "n0";
            this.txtMonthUsing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonthUsing.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMonthUsing.Properties.NullText = "0";
            this.txtMonthUsing.Properties.ValidateOnEnterKey = true;
            this.txtMonthUsing.Size = new System.Drawing.Size(206, 20);
            this.txtMonthUsing.TabIndex = 4;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.lblDescription1, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(170, 340);
            this.tableLayoutPanel13.TabIndex = 4;
            // 
            // lblDescription1
            // 
            this.lblDescription1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription1.AutoSize = true;
            this.lblDescription1.Location = new System.Drawing.Point(107, 22);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(60, 13);
            this.lblDescription1.TabIndex = 0;
            this.lblDescription1.Text = "Description";
            // 
            // txtDescription1
            // 
            this.txtDescription1.EnterMoveNextControl = true;
            this.txtDescription1.Location = new System.Drawing.Point(179, 123);
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.Size = new System.Drawing.Size(563, 59);
            this.txtDescription1.TabIndex = 5;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(788, 476);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // UCFixedAssetUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tapFixedAssetUpgrade);
            this.Name = "UCFixedAssetUpgrade";
            this.Size = new System.Drawing.Size(794, 502);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tapFixedAssetUpgrade)).EndInit();
            this.tapFixedAssetUpgrade.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.txtTap.ResumeLayout(false);
            this.txtTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFixedAssetCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonthUsing.Properties)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription1.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tapFixedAssetUpgrade;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.TableLayoutPanel txtTap;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private System.Windows.Forms.Label lblFixedAssetCode;
        private System.Windows.Forms.Label lblStartDate;
        private DevExpress.XtraEditors.DateEdit cboStartDate;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label lblAmount;
        private DevExpress.XtraEditors.LookUpEdit cboFixedAssetCode;
        private System.Windows.Forms.Label lblMonthUsing;
        private DevExpress.XtraEditors.TextEdit txtMonthUsing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label lblDescription1;
        private DevExpress.XtraEditors.MemoEdit txtDescription1;

    }
}
