namespace VNS.ERP.GUI.UserControl
{
    partial class ProductWeightsControl
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
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblweight = new System.Windows.Forms.Label();
            this.lblweightcode = new System.Windows.Forms.Label();
            this.txtweightcode = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdescription = new DevExpress.XtraEditors.MemoEdit();
            this.txtweight = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtweightcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtweight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(22, 36);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(93, 29);
            this.lbldescription.TabIndex = 11;
            this.lbldescription.Text = "Description";
            this.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblweight
            // 
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(230, 3);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(114, 18);
            this.lblweight.TabIndex = 9;
            this.lblweight.Text = "Weight";
            this.lblweight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblweightcode
            // 
            this.lblweightcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweightcode.Location = new System.Drawing.Point(27, 5);
            this.lblweightcode.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblweightcode.Name = "lblweightcode";
            this.lblweightcode.Size = new System.Drawing.Size(90, 18);
            this.lblweightcode.TabIndex = 7;
            this.lblweightcode.Text = "Weight Code";
            this.lblweightcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtweightcode
            // 
            this.txtweightcode.EnterMoveNextControl = true;
            this.txtweightcode.Location = new System.Drawing.Point(128, 3);
            this.txtweightcode.Name = "txtweightcode";
            this.txtweightcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtweightcode.Size = new System.Drawing.Size(96, 20);
            this.txtweightcode.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(451, 88);
            this.groupControl1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.txtweightcode);
            this.panel1.Controls.Add(this.lbldescription);
            this.panel1.Controls.Add(this.lblweightcode);
            this.panel1.Controls.Add(this.lblweight);
            this.panel1.Controls.Add(this.txtweight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 66);
            this.panel1.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescription.EnterMoveNextControl = true;
            this.txtdescription.Location = new System.Drawing.Point(128, 29);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(317, 34);
            this.txtdescription.TabIndex = 2;
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(350, 3);
            this.txtweight.Name = "txtweight";
            this.txtweight.Properties.Mask.EditMask = "#,##0.00;<<#,##0.00>>";
            this.txtweight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtweight.Size = new System.Drawing.Size(96, 20);
            this.txtweight.TabIndex = 1;
            // 
            // ProductWeightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ProductWeightsControl";
            this.Size = new System.Drawing.Size(451, 88);
            ((System.ComponentModel.ISupportInitialize)(this.txtweightcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtweight.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblweightcode;
        public DevExpress.XtraEditors.TextEdit txtweightcode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.MemoEdit txtdescription;
        private DevExpress.XtraEditors.TextEdit txtweight;
    }
}
