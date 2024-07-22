namespace VNS.ERP.GUI
{
    partial class UCSubjectType
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
            this.txtSubjectTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.lblSubjectTypeCode = new System.Windows.Forms.Label();
            this.lblSubjectTypeName = new System.Windows.Forms.Label();
            this.txtSubjectTypeName = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectTypeName.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(553, 120);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.10053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.89947F));
            this.tableLayoutPanel1.Controls.Add(this.txtSubjectTypeCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubjectTypeCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSubjectTypeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSubjectTypeName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSubjectTypeCode
            // 
            this.txtSubjectTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSubjectTypeCode.EnterMoveNextControl = true;
            this.txtSubjectTypeCode.Location = new System.Drawing.Point(162, 3);
            this.txtSubjectTypeCode.Name = "txtSubjectTypeCode";
            this.txtSubjectTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubjectTypeCode.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtSubjectTypeCode.Size = new System.Drawing.Size(105, 20);
            this.txtSubjectTypeCode.TabIndex = 0;
            // 
            // lblSubjectTypeCode
            // 
            this.lblSubjectTypeCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubjectTypeCode.AutoSize = true;
            this.lblSubjectTypeCode.Location = new System.Drawing.Point(64, 7);
            this.lblSubjectTypeCode.Name = "lblSubjectTypeCode";
            this.lblSubjectTypeCode.Size = new System.Drawing.Size(92, 13);
            this.lblSubjectTypeCode.TabIndex = 0;
            this.lblSubjectTypeCode.Text = "SubjectTypeCode";
            // 
            // lblSubjectTypeName
            // 
            this.lblSubjectTypeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubjectTypeName.AutoSize = true;
            this.lblSubjectTypeName.Location = new System.Drawing.Point(61, 34);
            this.lblSubjectTypeName.Name = "lblSubjectTypeName";
            this.lblSubjectTypeName.Size = new System.Drawing.Size(95, 13);
            this.lblSubjectTypeName.TabIndex = 0;
            this.lblSubjectTypeName.Text = "SubjectTypeName";
            // 
            // txtSubjectTypeName
            // 
            this.txtSubjectTypeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSubjectTypeName.EnterMoveNextControl = true;
            this.txtSubjectTypeName.Location = new System.Drawing.Point(162, 30);
            this.txtSubjectTypeName.Name = "txtSubjectTypeName";
            this.txtSubjectTypeName.Size = new System.Drawing.Size(197, 20);
            this.txtSubjectTypeName.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.06764F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.04936F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.70018F));
            this.tableLayoutPanel3.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDescription, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(547, 54);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(96, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.EditValue = "";
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(162, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(317, 48);
            this.txtDescription.TabIndex = 0;
            // 
            // UCSubjectType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UCSubjectType";
            this.Size = new System.Drawing.Size(553, 120);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubjectTypeName.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtSubjectTypeCode;
        private System.Windows.Forms.Label lblSubjectTypeCode;
        private System.Windows.Forms.Label lblSubjectTypeName;
        private DevExpress.XtraEditors.TextEdit txtSubjectTypeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
    }
}
