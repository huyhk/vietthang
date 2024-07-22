namespace VNS.ERP.GUI
{
    partial class FormEditConfirmStockTransaction
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
            this.ucConfirmStockTransaction1 = new VNS.ERP.GUI.UserControls.Manufactures.UCConfirmStockTransaction();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkHddt = new DevExpress.XtraEditors.CheckEdit();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice2 = new System.Windows.Forms.Button();
            this.btnPrintInvoice3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintInvoice4 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpHddtStock = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHddt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHddtStock.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // ucConfirmStockTransaction1
            // 
            this.ucConfirmStockTransaction1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucConfirmStockTransaction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucConfirmStockTransaction1.ForDepartment = ((byte)(0));
            this.ucConfirmStockTransaction1.Location = new System.Drawing.Point(0, 45);
            this.ucConfirmStockTransaction1.Name = "ucConfirmStockTransaction1";
            this.ucConfirmStockTransaction1.Size = new System.Drawing.Size(966, 469);
            this.ucConfirmStockTransaction1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(873, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Định khoản KT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkHddt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintInvoice, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintInvoice2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintInvoice3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintInvoice4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lookUpHddtStock, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 513);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 29);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // chkHddt
            // 
            this.chkHddt.AllowDrop = true;
            this.chkHddt.Location = new System.Drawing.Point(442, 3);
            this.chkHddt.Name = "chkHddt";
            this.chkHddt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHddt.Properties.Appearance.Options.UseFont = true;
            this.chkHddt.Properties.Caption = "HĐĐT";
            this.chkHddt.Size = new System.Drawing.Size(54, 21);
            this.chkHddt.TabIndex = 136;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInvoice.Location = new System.Drawing.Point(750, 3);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(117, 23);
            this.btnPrintInvoice.TabIndex = 7;
            this.btnPrintInvoice.Text = "In hoá đơn mẫu 9 GS";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnPrintInvoice2
            // 
            this.btnPrintInvoice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintInvoice2.Location = new System.Drawing.Point(622, 3);
            this.btnPrintInvoice2.Name = "btnPrintInvoice2";
            this.btnPrintInvoice2.Size = new System.Drawing.Size(115, 23);
            this.btnPrintInvoice2.TabIndex = 7;
            this.btnPrintInvoice2.Text = "In hoá đơn mẫu 8 TS";
            this.btnPrintInvoice2.UseVisualStyleBackColor = true;
            this.btnPrintInvoice2.Click += new System.EventHandler(this.btnPrintInvoice2_Click);
            // 
            // btnPrintInvoice3
            // 
            this.btnPrintInvoice3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrintInvoice3.Location = new System.Drawing.Point(3, 3);
            this.btnPrintInvoice3.Name = "btnPrintInvoice3";
            this.btnPrintInvoice3.Size = new System.Drawing.Size(102, 23);
            this.btnPrintInvoice3.TabIndex = 8;
            this.btnPrintInvoice3.Text = "In hóa đơn nội bộ";
            this.btnPrintInvoice3.Click += new System.EventHandler(this.btnPrintInvoice3_Click);
            // 
            // btnPrintInvoice4
            // 
            this.btnPrintInvoice4.Location = new System.Drawing.Point(111, 3);
            this.btnPrintInvoice4.Name = "btnPrintInvoice4";
            this.btnPrintInvoice4.Size = new System.Drawing.Size(101, 21);
            this.btnPrintInvoice4.TabIndex = 9;
            this.btnPrintInvoice4.Text = "In hóa đơn mẫu 4";
            this.btnPrintInvoice4.Visible = false;
            this.btnPrintInvoice4.Click += new System.EventHandler(this.btnPrintInvoice4_Click);
            // 
            // lookUpHddtStock
            // 
            this.lookUpHddtStock.EnterMoveNextControl = true;
            this.lookUpHddtStock.Location = new System.Drawing.Point(503, 4);
            this.lookUpHddtStock.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpHddtStock.Name = "lookUpHddtStock";
            this.lookUpHddtStock.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpHddtStock.Properties.Appearance.Options.UseFont = true;
            this.lookUpHddtStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpHddtStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("JubjectCode", "Mã CN"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "Tên CN")});
            this.lookUpHddtStock.Properties.DisplayMember = "SubjectName";
            this.lookUpHddtStock.Properties.NullText = "";
            this.lookUpHddtStock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpHddtStock.Properties.ValueMember = "SubjectCode";
            this.lookUpHddtStock.Size = new System.Drawing.Size(112, 22);
            this.lookUpHddtStock.TabIndex = 105;
            // 
            // FormEditConfirmStockTransaction
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ucConfirmStockTransaction1);
            this.EditControl = this.ucConfirmStockTransaction1;
            this.Name = "FormEditConfirmStockTransaction";
            this.Text = "FormEditConfirmStockTransaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditConfirmStockTransaction_FormClosing);
            this.Load += new System.EventHandler(this.FormEditConfirmStockTransaction_Load);
            this.Controls.SetChildIndex(this.ucConfirmStockTransaction1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkHddt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHddtStock.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControls.Manufactures.UCConfirmStockTransaction ucConfirmStockTransaction1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnPrintInvoice2;
        private DevExpress.XtraEditors.SimpleButton btnPrintInvoice3;
        private DevExpress.XtraEditors.SimpleButton btnPrintInvoice4;
        private DevExpress.XtraEditors.LookUpEdit lookUpHddtStock;
        private DevExpress.XtraEditors.CheckEdit chkHddt;
    }
}