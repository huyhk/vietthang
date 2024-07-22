namespace VNS.ERP.GUI.KCS
{
    partial class FormEditProductTestRequest
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
            this.ucProductTestRequest1 = new UCProductTestRequest();
            this.btnViewResult = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // ucProductTestRequest1
            // 
            this.ucProductTestRequest1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucProductTestRequest1, 2);
            this.ucProductTestRequest1.DataSource = null;
            this.ucProductTestRequest1.Department = VNS.ERP.Data.enumKCSDepartment.QLCL;
            this.ucProductTestRequest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductTestRequest1.Location = new System.Drawing.Point(3, 3);
            this.ucProductTestRequest1.Name = "ucProductTestRequest1";
            this.ucProductTestRequest1.Size = new System.Drawing.Size(778, 356);
            this.ucProductTestRequest1.TabIndex = 5;
            // 
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(639, 365);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(86, 24);
            this.btnViewResult.TabIndex = 7;
            this.btnViewResult.Text = "Xem kết quả";
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.24191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75809F));
            this.tableLayoutPanel1.Controls.Add(this.ucProductTestRequest1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewResult, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 392);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // FormEditProductTestRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucProductTestRequest1;
            this.Name = "FormEditProductTestRequest";
            this.Text = "Phiếu yêu cầu kiểm tra thành phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCProductTestRequest ucProductTestRequest1;
        private DevExpress.XtraEditors.SimpleButton btnViewResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
