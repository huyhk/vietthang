namespace VNS.ERP.GUI.Manufactures
{
    partial class FormEditManufacturePlanWeek
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucManufacturePlanWeek1 = new VNS.ERP.GUI.Manufactures.UCManufacturePlanWeek();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReportMaterial = new System.Windows.Forms.Button();
            this.checkExcel = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            this.defaultLookAndFeel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            this.defaultLookAndFeel.LookAndFeel.UseWindowsXPTheme = false;
            // 
            // defaultBarAndDocking
            // 
            // 
            // ucManufacturePlanWeek1
            // 
            this.ucManufacturePlanWeek1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucManufacturePlanWeek1.Location = new System.Drawing.Point(-2, 45);
            this.ucManufacturePlanWeek1.Name = "ucManufacturePlanWeek1";
            this.ucManufacturePlanWeek1.Size = new System.Drawing.Size(857, 343);
            this.ucManufacturePlanWeek1.StockCode = null;
            this.ucManufacturePlanWeek1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(558, 388);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 24);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "In kế hoạch";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReportMaterial
            // 
            this.btnReportMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportMaterial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMaterial.Location = new System.Drawing.Point(660, 388);
            this.btnReportMaterial.Name = "btnReportMaterial";
            this.btnReportMaterial.Size = new System.Drawing.Size(186, 24);
            this.btnReportMaterial.TabIndex = 7;
            this.btnReportMaterial.Text = "Báo cáo nguyên liệu cần thiết";
            this.btnReportMaterial.UseVisualStyleBackColor = true;
            this.btnReportMaterial.Click += new System.EventHandler(this.btnReportMaterial_Click);
            // 
            // checkExcel
            // 
            this.checkExcel.Location = new System.Drawing.Point(477, 391);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Properties.Caption = "In ra Excel";
            this.checkExcel.Size = new System.Drawing.Size(75, 19);
            this.checkExcel.TabIndex = 105;
            // 
            // FormEditManufacturePlanWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 441);
            this.Controls.Add(this.checkExcel);
            this.Controls.Add(this.btnReportMaterial);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ucManufacturePlanWeek1);
            this.EditControl = this.ucManufacturePlanWeek1;
            this.Name = "FormEditManufacturePlanWeek";
            this.Text = "FormEditManufacturePlanWeek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditManufacturePlanWeek_FormClosing);
            this.Controls.SetChildIndex(this.ucManufacturePlanWeek1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnReportMaterial, 0);
            this.Controls.SetChildIndex(this.checkExcel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCManufacturePlanWeek ucManufacturePlanWeek1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReportMaterial;
        private DevExpress.XtraEditors.CheckEdit checkExcel;
    }
}