namespace VNS.ERP.GUI.Manufactures
{
    partial class FormEditManufacturePlanMonth
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
            this.ucManufactPlanMonth1 = new UCManufactPlanMonth();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReportMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
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
            // ucManufactPlanMonth1
            // 
            this.ucManufactPlanMonth1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucManufactPlanMonth1.Business = null;
            this.ucManufactPlanMonth1.DataSource = null;
            this.ucManufactPlanMonth1.Location = new System.Drawing.Point(5, 45);
            this.ucManufactPlanMonth1.Name = "ucManufactPlanMonth1";
            this.ucManufactPlanMonth1.Size = new System.Drawing.Size(745, 357);
            this.ucManufactPlanMonth1.StockCode = null;
            this.ucManufactPlanMonth1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(456, 403);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 24);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In kế hoạch";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReportMaterial
            // 
            this.btnReportMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportMaterial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMaterial.Location = new System.Drawing.Point(557, 403);
            this.btnReportMaterial.Name = "btnReportMaterial";
            this.btnReportMaterial.Size = new System.Drawing.Size(186, 24);
            this.btnReportMaterial.TabIndex = 8;
            this.btnReportMaterial.Text = "Báo cáo nguyên liệu cần thiết";
            this.btnReportMaterial.UseVisualStyleBackColor = true;
            this.btnReportMaterial.Click += new System.EventHandler(this.btnReportMaterial_Click);
            // 
            // FormEditManufacturePlanMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 456);
            this.Controls.Add(this.btnReportMaterial);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ucManufactPlanMonth1);
            this.EditControl = this.ucManufactPlanMonth1;
            this.Name = "FormEditManufacturePlanMonth";
            this.Text = "FormEditManufacturePlanMonth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditManufacturePlanMonth_FormClosing);
            this.Controls.SetChildIndex(this.ucManufactPlanMonth1, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnReportMaterial, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCManufactPlanMonth ucManufactPlanMonth1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReportMaterial;
    }
}