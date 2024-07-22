namespace VNS.ERP.GUI.KCS
{
    partial class FormEditProductTestTransaction
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
            this.ucProductTestTransaction1 = new UCProductTestTransaction();
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
            // ucProductTestTransaction1
            // 
            this.ucProductTestTransaction1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductTestTransaction1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucProductTestTransaction1, 2);
            this.ucProductTestTransaction1.DataSource = null;
            this.ucProductTestTransaction1.Department = VNS.ERP.Data.enumKCSDepartment.KCS;
            this.ucProductTestTransaction1.Location = new System.Drawing.Point(3, 3);
            this.ucProductTestTransaction1.Name = "ucProductTestTransaction1";
            this.ucProductTestTransaction1.Size = new System.Drawing.Size(813, 354);
            this.ucProductTestTransaction1.TabIndex = 5;
            // 
            // btnViewResult
            // 
            this.btnViewResult.Location = new System.Drawing.Point(666, 363);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(86, 24);
            this.btnViewResult.TabIndex = 8;
            this.btnViewResult.Text = "Xem kết quả";
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.01266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.98734F));
            this.tableLayoutPanel1.Controls.Add(this.ucProductTestTransaction1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnViewResult, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 390);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // FormEditProductTestTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(819, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucProductTestTransaction1;
            this.Name = "FormEditProductTestTransaction";
            this.Text = "Kiểm tra thành phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCProductTestTransaction ucProductTestTransaction1;
        private DevExpress.XtraEditors.SimpleButton btnViewResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
