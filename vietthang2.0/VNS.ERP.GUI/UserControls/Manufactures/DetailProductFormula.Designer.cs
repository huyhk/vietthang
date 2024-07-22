namespace VNS.ERP.GUI.UserControl
{
    partial class DetailProductFormula
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
            this.lbFormulaCode = new System.Windows.Forms.Label();
            this.txtFormulaCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulaCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormulaCode
            // 
            this.lbFormulaCode.Location = new System.Drawing.Point(1, 7);
            this.lbFormulaCode.Name = "lbFormulaCode";
            this.lbFormulaCode.Size = new System.Drawing.Size(90, 16);
            this.lbFormulaCode.TabIndex = 12;
            this.lbFormulaCode.Text = "Mã";
            this.lbFormulaCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFormulaCode
            // 
            this.txtFormulaCode.EnterMoveNextControl = true;
            this.txtFormulaCode.Location = new System.Drawing.Point(96, 5);
            this.txtFormulaCode.Name = "txtFormulaCode";
            this.txtFormulaCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFormulaCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormulaCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtFormulaCode.Properties.Appearance.Options.UseFont = true;
            this.txtFormulaCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormulaCode.Properties.MaxLength = 20;
            this.txtFormulaCode.Size = new System.Drawing.Size(104, 22);
            this.txtFormulaCode.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(97, 31);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(285, 50);
            this.txtDescription.TabIndex = 16;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(15, 46);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(76, 16);
            this.lbDescription.TabIndex = 17;
            this.lbDescription.Text = "Description";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(238, 5);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(31, 22);
            this.txtBackGround.TabIndex = 18;
            this.txtBackGround.Visible = false;
            // 
            // DetailProductFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbFormulaCode);
            this.Controls.Add(this.txtFormulaCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetailProductFormula";
            this.Size = new System.Drawing.Size(390, 87);
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulaCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormulaCode;
        private DevExpress.XtraEditors.TextEdit txtFormulaCode;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.TextEdit txtBackGround;
    }
}
