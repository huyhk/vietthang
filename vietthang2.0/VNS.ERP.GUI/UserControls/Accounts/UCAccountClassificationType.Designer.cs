namespace VNS.ERP.GUI
{
    partial class UCAccountClassificationType
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAccountClassificationTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.lblAccountClassificationTypeCode = new System.Windows.Forms.Label();
            this.lblAccountClassificationTypeName = new System.Windows.Forms.Label();
            this.txtAccountClassificationTypeName = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountClassificationTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountClassificationTypeName.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(545, 129);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.10053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.89947F));
            this.tableLayoutPanel1.Controls.Add(this.txtAccountClassificationTypeCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAccountClassificationTypeCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAccountClassificationTypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAccountClassificationTypeName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAccountClassificationTypeCode
            // 
            this.txtAccountClassificationTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountClassificationTypeCode.EnterMoveNextControl = true;
            this.txtAccountClassificationTypeCode.Location = new System.Drawing.Point(159, 5);
            this.txtAccountClassificationTypeCode.Name = "txtAccountClassificationTypeCode";
            this.txtAccountClassificationTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountClassificationTypeCode.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtAccountClassificationTypeCode.Size = new System.Drawing.Size(105, 20);
            this.txtAccountClassificationTypeCode.TabIndex = 2;
            // 
            // lblAccountClassificationTypeCode
            // 
            this.lblAccountClassificationTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAccountClassificationTypeCode.AutoSize = true;
            this.lblAccountClassificationTypeCode.Location = new System.Drawing.Point(20, 8);
            this.lblAccountClassificationTypeCode.Name = "lblAccountClassificationTypeCode";
            this.lblAccountClassificationTypeCode.Size = new System.Drawing.Size(133, 13);
            this.lblAccountClassificationTypeCode.TabIndex = 0;
            this.lblAccountClassificationTypeCode.Text = "AccountClassificationCode";
            // 
            // lblAccountClassificationTypeName
            // 
            this.lblAccountClassificationTypeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAccountClassificationTypeName.AutoSize = true;
            this.lblAccountClassificationTypeName.Location = new System.Drawing.Point(17, 39);
            this.lblAccountClassificationTypeName.Name = "lblAccountClassificationTypeName";
            this.lblAccountClassificationTypeName.Size = new System.Drawing.Size(136, 13);
            this.lblAccountClassificationTypeName.TabIndex = 0;
            this.lblAccountClassificationTypeName.Text = "AccountClassificationName";
            // 
            // txtAccountClassificationTypeName
            // 
            this.txtAccountClassificationTypeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAccountClassificationTypeName.EnterMoveNextControl = true;
            this.txtAccountClassificationTypeName.Location = new System.Drawing.Point(159, 35);
            this.txtAccountClassificationTypeName.Name = "txtAccountClassificationTypeName";
            this.txtAccountClassificationTypeName.Size = new System.Drawing.Size(197, 20);
            this.txtAccountClassificationTypeName.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94249F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.92579F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.31725F));
            this.tableLayoutPanel3.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(539, 56);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(92, 21);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(158, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(316, 47);
            this.txtDescription.TabIndex = 1;
            // 
            // UCAccountClassificationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UCAccountClassificationType";
            this.Size = new System.Drawing.Size(545, 129);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountClassificationTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountClassificationTypeName.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtAccountClassificationTypeCode;
        private System.Windows.Forms.Label lblAccountClassificationTypeCode;
        private System.Windows.Forms.Label lblAccountClassificationTypeName;
        private DevExpress.XtraEditors.TextEdit txtAccountClassificationTypeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
