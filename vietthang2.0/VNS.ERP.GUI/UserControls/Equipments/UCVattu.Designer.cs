namespace VNS.ERP.GUI.Equipments
{
    partial class UCVattu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVattuCode = new DevExpress.XtraEditors.TextEdit();
            this.txtVattuName = new DevExpress.XtraEditors.TextEdit();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.txtDienGiai = new DevExpress.XtraEditors.MemoEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVattuCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVattuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVattuCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVattuName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUnit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDienGiai, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 42);
            this.label4.TabIndex = 1;
            this.label4.Text = "Diễn giải";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên vật tư";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVattuCode
            // 
            this.txtVattuCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVattuCode.EnterMoveNextControl = true;
            this.txtVattuCode.Location = new System.Drawing.Point(98, 6);
            this.txtVattuCode.Name = "txtVattuCode";
            this.txtVattuCode.Properties.Appearance.Options.UseBorderColor = true;
            this.txtVattuCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVattuCode.Properties.MaxLength = 20;
            this.txtVattuCode.Size = new System.Drawing.Size(259, 20);
            this.txtVattuCode.TabIndex = 2;
            // 
            // txtVattuName
            // 
            this.txtVattuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVattuName.EnterMoveNextControl = true;
            this.txtVattuName.Location = new System.Drawing.Point(98, 37);
            this.txtVattuName.Name = "txtVattuName";
            this.txtVattuName.Size = new System.Drawing.Size(259, 20);
            this.txtVattuName.TabIndex = 3;
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnit.EnterMoveNextControl = true;
            this.txtUnit.Location = new System.Drawing.Point(98, 67);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(259, 20);
            this.txtUnit.TabIndex = 4;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienGiai.EnterMoveNextControl = true;
            this.txtDienGiai.Location = new System.Drawing.Point(98, 95);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(259, 36);
            this.txtDienGiai.TabIndex = 5;
            // 
            // UCVattu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FirstControl = this.txtVattuCode;
            this.Name = "UCVattu";
            this.Size = new System.Drawing.Size(366, 140);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVattuCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVattuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienGiai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtVattuCode;
        private DevExpress.XtraEditors.TextEdit txtVattuName;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.MemoEdit txtDienGiai;
    }
}
