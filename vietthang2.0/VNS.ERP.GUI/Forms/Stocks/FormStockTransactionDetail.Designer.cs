namespace VNS.ERP.GUI.Stocks
{
    partial class FormStockTransactionDetail
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
            this.usrDetailStockTransactionDetail1 = new VNS.ERP.GUI.UserControl.DetailStockTransactionDetail();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
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
            // usrDetailStockTransactionDetail1
            // 
            this.usrDetailStockTransactionDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usrDetailStockTransactionDetail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrDetailStockTransactionDetail1.Location = new System.Drawing.Point(5, 44);
            this.usrDetailStockTransactionDetail1.Margin = new System.Windows.Forms.Padding(4);
            this.usrDetailStockTransactionDetail1.Name = "usrDetailStockTransactionDetail1";
            this.usrDetailStockTransactionDetail1.Size = new System.Drawing.Size(944, 402);
            this.usrDetailStockTransactionDetail1.TabIndex = 5;
            this.usrDetailStockTransactionDetail1.TransactionTypeCode = null;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(851, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 26);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 740F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 439);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 32);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(636, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 26);
            this.button2.TabIndex = 98;
            this.button2.Text = "In theo mẫu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(743, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 97;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // FormStockTransactionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.usrDetailStockTransactionDetail1);
            this.EditControl = this.usrDetailStockTransactionDetail1;
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "FormStockTransactionDetail";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FormStockTransactionDetail";
            this.Load += new System.EventHandler(this.FormStockTransactionDetail_Load);
            this.SizeChanged += new System.EventHandler(this.FormStockTransactionDetail_SizeChanged);
            this.Shown += new System.EventHandler(this.FormStockTransactionDetail_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStockTransactionDetail_FormClosing);
            this.Controls.SetChildIndex(this.usrDetailStockTransactionDetail1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControl.DetailStockTransactionDetail usrDetailStockTransactionDetail1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}