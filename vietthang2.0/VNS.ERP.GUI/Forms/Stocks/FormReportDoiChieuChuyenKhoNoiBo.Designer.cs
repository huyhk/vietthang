namespace VNS.ERP.GUI.Stocks
{
    partial class FormReportDoiChieuChuyenKhoNoiBo
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
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnExportToExcel = new System.Windows.Forms.Button();
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
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.AllowCheckDate = true;
            this.ucDatePeriodSelection1.AllowCheckQuarter = true;
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 1);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(411, 65);
            this.ucDatePeriodSelection1.TabIndex = 19;
            this.ucDatePeriodSelection1.WorkingDate = new System.DateTime(2007, 8, 23, 0, 0, 0, 0);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(277, 70);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(139, 22);
            this.btnExportToExcel.TabIndex = 21;
            this.btnExportToExcel.Text = "Xuất báo cáo ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // FormReportDoiChieuChuyenKhoNoiBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 95);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Name = "FormReportDoiChieuChuyenKhoNoiBo";
            this.Text = "Bảng đối chiếu chuyển kho nội bộ";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}