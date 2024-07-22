namespace VNS.ERP.GUI
{
    partial class UCVessel
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
            this.lblVesselCode = new System.Windows.Forms.Label();
            this.txtVesselCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblVesselName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtVesselName = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVesselCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVesselName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lblVesselCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVesselCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblVesselName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtVesselName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblVesselCode
            // 
            this.lblVesselCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVesselCode.AutoSize = true;
            this.lblVesselCode.Location = new System.Drawing.Point(18, 9);
            this.lblVesselCode.Name = "lblVesselCode";
            this.lblVesselCode.Size = new System.Drawing.Size(63, 13);
            this.lblVesselCode.TabIndex = 1;
            this.lblVesselCode.Text = "VesselCode";
            this.lblVesselCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVesselCode
            // 
            this.txtVesselCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVesselCode.EnterMoveNextControl = true;
            this.txtVesselCode.Location = new System.Drawing.Point(87, 5);
            this.txtVesselCode.Name = "txtVesselCode";
            this.txtVesselCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVesselCode.Properties.MaxLength = 10;
            this.txtVesselCode.Size = new System.Drawing.Size(106, 20);
            this.txtVesselCode.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(87, 65);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(333, 37);
            this.txtDescription.TabIndex = 3;
            // 
            // lblVesselName
            // 
            this.lblVesselName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVesselName.AutoSize = true;
            this.lblVesselName.Location = new System.Drawing.Point(15, 40);
            this.lblVesselName.Name = "lblVesselName";
            this.lblVesselName.Size = new System.Drawing.Size(66, 13);
            this.lblVesselName.TabIndex = 1;
            this.lblVesselName.Text = "VesselName";
            this.lblVesselName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 77);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVesselName
            // 
            this.txtVesselName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtVesselName.EnterMoveNextControl = true;
            this.txtVesselName.Location = new System.Drawing.Point(87, 36);
            this.txtVesselName.Name = "txtVesselName";
            this.txtVesselName.Properties.MaxLength = 50;
            this.txtVesselName.Size = new System.Drawing.Size(226, 20);
            this.txtVesselName.TabIndex = 2;
            // 
            // UCVessel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCVessel";
            this.Size = new System.Drawing.Size(423, 105);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVesselCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVesselName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblVesselCode;
        private DevExpress.XtraEditors.TextEdit txtVesselCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblVesselName;
        private System.Windows.Forms.Label lblDescription;
        private DevExpress.XtraEditors.TextEdit txtVesselName;
    }
}
