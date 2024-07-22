namespace VNS.ERP.GUI.Manufactures
{
    partial class FormManufacturePlanDetail
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
            this.ucManufacturePlanDetail1 = new VNS.ERP.GUI.Manufactures.UCManufacturePlanDetail();
            this.btnPrintMaterial = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ckExportExcel = new DevExpress.XtraEditors.CheckEdit();
            this.btnMTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckExportExcel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // ucManufacturePlanDetail1
            // 
            this.ucManufacturePlanDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManufacturePlanDetail1.Location = new System.Drawing.Point(0, 0);
            this.ucManufacturePlanDetail1.Margin = new System.Windows.Forms.Padding(0);
            this.ucManufacturePlanDetail1.Name = "ucManufacturePlanDetail1";
            this.ucManufacturePlanDetail1.Size = new System.Drawing.Size(773, 397);
            this.ucManufacturePlanDetail1.StockCode = null;
            this.ucManufacturePlanDetail1.TabIndex = 5;
            // 
            // btnPrintMaterial
            // 
            this.btnPrintMaterial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrintMaterial.Location = new System.Drawing.Point(645, 3);
            this.btnPrintMaterial.Name = "btnPrintMaterial";
            this.btnPrintMaterial.Size = new System.Drawing.Size(125, 23);
            this.btnPrintMaterial.TabIndex = 6;
            this.btnPrintMaterial.Text = "Báo cáo nguyên liệu cần thiết";
            this.btnPrintMaterial.UseVisualStyleBackColor = true;
            this.btnPrintMaterial.Click += new System.EventHandler(this.btnPrintMaterial_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReports.Location = new System.Drawing.Point(515, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(124, 23);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Báo cáo";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucManufacturePlanDetail1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 426);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Controls.Add(this.btnPrintMaterial, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReports, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ckExportExcel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMTS, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 397);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(773, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // ckExportExcel
            // 
            this.ckExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ckExportExcel.Location = new System.Drawing.Point(404, 5);
            this.ckExportExcel.Name = "ckExportExcel";
            this.ckExportExcel.Properties.Caption = "ExportExcel";
            this.ckExportExcel.Size = new System.Drawing.Size(101, 19);
            this.ckExportExcel.TabIndex = 7;
            // 
            // btnMTS
            // 
            this.btnMTS.Location = new System.Drawing.Point(3, 3);
            this.btnMTS.Name = "btnMTS";
            this.btnMTS.Size = new System.Drawing.Size(115, 23);
            this.btnMTS.TabIndex = 8;
            this.btnMTS.Text = "Cập nhật MTS";
            this.btnMTS.UseVisualStyleBackColor = true;
            this.btnMTS.Click += new System.EventHandler(this.btnMTS_Click);
            // 
            // FormManufacturePlanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucManufacturePlanDetail1;
            this.Name = "FormManufacturePlanDetail";
            this.Text = "ManufacturePlanDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManufacturePlanDetail_FormClosing);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckExportExcel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCManufacturePlanDetail ucManufacturePlanDetail1;
        private System.Windows.Forms.Button btnPrintMaterial;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.CheckEdit ckExportExcel;
        private System.Windows.Forms.Button btnMTS;
    }
}