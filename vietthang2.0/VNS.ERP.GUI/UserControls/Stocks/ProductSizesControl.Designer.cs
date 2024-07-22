namespace VNS.ERP.GUI.UserControl
{
    partial class ProductSizesControl
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
            this.lblSizeCode = new System.Windows.Forms.Label();
            this.txtsizecode = new DevExpress.XtraEditors.TextEdit();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtdescription = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtsizecode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSizeCode
            // 
            this.lblSizeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeCode.Location = new System.Drawing.Point(1, 4);
            this.lblSizeCode.Name = "lblSizeCode";
            this.lblSizeCode.Size = new System.Drawing.Size(107, 17);
            this.lblSizeCode.TabIndex = 3;
            this.lblSizeCode.Text = "Size Code";
            this.lblSizeCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtsizecode
            // 
            this.txtsizecode.EnterMoveNextControl = true;
            this.txtsizecode.Location = new System.Drawing.Point(111, 3);
            this.txtsizecode.Name = "txtsizecode";
            this.txtsizecode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsizecode.Size = new System.Drawing.Size(108, 20);
            this.txtsizecode.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(4, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdescription
            // 
            this.txtdescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescription.EnterMoveNextControl = true;
            this.txtdescription.Location = new System.Drawing.Point(111, 36);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(541, 43);
            this.txtdescription.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Location = new System.Drawing.Point(0, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 107);
            this.groupControl1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.txtsizecode);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.lblSizeCode);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 85);
            this.panel1.TabIndex = 0;
            // 
            // ProductSizesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ProductSizesControl";
            this.Size = new System.Drawing.Size(659, 106);
            ((System.ComponentModel.ISupportInitialize)(this.txtsizecode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSizeCode;
        public DevExpress.XtraEditors.TextEdit txtsizecode;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.MemoEdit txtdescription;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
    }
}
