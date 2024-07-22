namespace VNS.ERP.GUI.UserControl
{
    partial class DetailStockLocation
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
            this.lbStockLocationCode = new System.Windows.Forms.Label();
            this.txtStockLocationCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtBackGround = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockLocationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStockLocationCode
            // 
            this.lbStockLocationCode.Location = new System.Drawing.Point(3, 7);
            this.lbStockLocationCode.Name = "lbStockLocationCode";
            this.lbStockLocationCode.Size = new System.Drawing.Size(126, 16);
            this.lbStockLocationCode.TabIndex = 2;
            this.lbStockLocationCode.Text = "StockLocationCode";
            this.lbStockLocationCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStockLocationCode
            // 
            this.txtStockLocationCode.EnterMoveNextControl = true;
            this.txtStockLocationCode.Location = new System.Drawing.Point(134, 5);
            this.txtStockLocationCode.Name = "txtStockLocationCode";
            this.txtStockLocationCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtStockLocationCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockLocationCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtStockLocationCode.Properties.Appearance.Options.UseFont = true;
            this.txtStockLocationCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockLocationCode.Properties.MaxLength = 10;
            this.txtStockLocationCode.Size = new System.Drawing.Size(104, 22);
            this.txtStockLocationCode.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(134, 33);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(286, 50);
            this.txtDescription.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(3, 47);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(126, 16);
            this.lbDescription.TabIndex = 3;
            this.lbDescription.Text = "Description";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBackGround
            // 
            this.txtBackGround.Location = new System.Drawing.Point(301, 7);
            this.txtBackGround.Name = "txtBackGround";
            this.txtBackGround.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBackGround.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackGround.Properties.Appearance.Options.UseBackColor = true;
            this.txtBackGround.Properties.Appearance.Options.UseFont = true;
            this.txtBackGround.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBackGround.Size = new System.Drawing.Size(24, 22);
            this.txtBackGround.TabIndex = 4;
            this.txtBackGround.Visible = false;
            // 
            // DetailStockLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBackGround);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbStockLocationCode);
            this.Controls.Add(this.txtStockLocationCode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DetailStockLocation";
            this.Size = new System.Drawing.Size(428, 91);
            ((System.ComponentModel.ISupportInitialize)(this.txtStockLocationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackGround.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStockLocationCode;
        private DevExpress.XtraEditors.TextEdit txtStockLocationCode;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.TextEdit txtBackGround;
    }
}
