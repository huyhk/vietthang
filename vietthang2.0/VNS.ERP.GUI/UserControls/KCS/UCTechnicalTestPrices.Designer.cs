namespace VNS.ERP.GUI
{
    partial class UCTechnicalTestPrices
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.dateEditStartDate = new DevExpress.XtraEditors.DateEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTechCode = new System.Windows.Forms.Label();
            this.lookUpTechnical = new DevExpress.XtraEditors.LookUpEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnical.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateEditStartDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTechCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpTechnical, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 101);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 57);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Diễn giải";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(93, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(348, 38);
            this.txtDescription.TabIndex = 3;
            // 
            // dateEditStartDate
            // 
            this.dateEditStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEditStartDate.EditValue = new System.DateTime(2008, 2, 19, 0, 0, 0, 0);
            this.dateEditStartDate.EnterMoveNextControl = true;
            this.dateEditStartDate.Location = new System.Drawing.Point(93, 33);
            this.dateEditStartDate.Name = "dateEditStartDate";
            this.dateEditStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStartDate.Size = new System.Drawing.Size(122, 20);
            this.dateEditStartDate.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.EnterMoveNextControl = true;
            this.txtPrice.Location = new System.Drawing.Point(305, 33);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtPrice.Size = new System.Drawing.Size(136, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(221, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Đơn giá";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 36);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 13);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Ngày";
            // 
            // lblTechCode
            // 
            this.lblTechCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTechCode.AutoSize = true;
            this.lblTechCode.Location = new System.Drawing.Point(3, 8);
            this.lblTechCode.Name = "lblTechCode";
            this.lblTechCode.Size = new System.Drawing.Size(84, 13);
            this.lblTechCode.TabIndex = 6;
            this.lblTechCode.Text = "Chỉ Tiêu";
            // 
            // lookUpTechnical
            // 
            this.lookUpTechnical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookUpTechnical.EnterMoveNextControl = true;
            this.lookUpTechnical.Location = new System.Drawing.Point(93, 4);
            this.lookUpTechnical.Name = "lookUpTechnical";
            this.lookUpTechnical.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTechnical.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpTechnical.Properties.NullText = "";
            this.lookUpTechnical.Size = new System.Drawing.Size(122, 20);
            this.lookUpTechnical.TabIndex = 0;
            // 
            // UCTechnicalTestPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCTechnicalTestPrices";
            this.Size = new System.Drawing.Size(451, 106);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnical.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTechCode;
        private DevExpress.XtraEditors.DateEdit dateEditStartDate;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.LookUpEdit lookUpTechnical;
    }
}
