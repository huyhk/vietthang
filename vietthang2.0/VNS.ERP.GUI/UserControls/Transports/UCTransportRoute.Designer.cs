namespace VNS.ERP.GUI
{
    partial class UCTransportRoute
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
            this.lbStockOut = new System.Windows.Forms.Label();
            this.lbStockIn = new System.Windows.Forms.Label();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.memoMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lkStockIn = new DevExpress.XtraEditors.LookUpEdit();
            this.lkStockOut = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.chIsTrungchuyen = new DevExpress.XtraEditors.CheckEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockOut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chIsTrungchuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbStockOut, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbStockIn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMaLoai, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoMoTa, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lkStockIn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lkStockOut, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenLoai, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.chIsTrungchuyen, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbStockOut
            // 
            this.lbStockOut.AutoSize = true;
            this.lbStockOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStockOut.Location = new System.Drawing.Point(269, 25);
            this.lbStockOut.Name = "lbStockOut";
            this.lbStockOut.Size = new System.Drawing.Size(61, 25);
            this.lbStockOut.TabIndex = 7;
            this.lbStockOut.Text = "Kho xuất";
            this.lbStockOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStockIn
            // 
            this.lbStockIn.AutoSize = true;
            this.lbStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStockIn.Location = new System.Drawing.Point(3, 25);
            this.lbStockIn.Name = "lbStockIn";
            this.lbStockIn.Size = new System.Drawing.Size(71, 25);
            this.lbStockIn.TabIndex = 6;
            this.lbStockIn.Text = "Kho nhập";
            this.lbStockIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaLoai.EnterMoveNextControl = true;
            this.txtMaLoai.Location = new System.Drawing.Point(80, 3);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaLoai.Size = new System.Drawing.Size(180, 20);
            this.txtMaLoai.TabIndex = 0;
            // 
            // memoMoTa
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.memoMoTa, 3);
            this.memoMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoMoTa.EnterMoveNextControl = true;
            this.memoMoTa.Location = new System.Drawing.Point(80, 78);
            this.memoMoTa.Name = "memoMoTa";
            this.memoMoTa.Size = new System.Drawing.Size(439, 39);
            this.memoMoTa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diễn giải";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lkStockIn
            // 
            this.lkStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lkStockIn.Location = new System.Drawing.Point(80, 28);
            this.lkStockIn.Name = "lkStockIn";
            this.lkStockIn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStockIn.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Kho", 150)});
            this.lkStockIn.Properties.DisplayMember = "StockName";
            this.lkStockIn.Properties.NullText = "";
            this.lkStockIn.Properties.PopupWidth = 230;
            this.lkStockIn.Properties.ValueMember = "StockCode";
            this.lkStockIn.Size = new System.Drawing.Size(183, 20);
            this.lkStockIn.TabIndex = 8;
            // 
            // lkStockOut
            // 
            this.lkStockOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lkStockOut.Location = new System.Drawing.Point(336, 28);
            this.lkStockOut.Name = "lkStockOut";
            this.lkStockOut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStockOut.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Kho", 150)});
            this.lkStockOut.Properties.DisplayMember = "StockName";
            this.lkStockOut.Properties.NullText = "";
            this.lkStockOut.Properties.PopupFormWidth = 230;
            this.lkStockOut.Properties.ValueMember = "StockCode";
            this.lkStockOut.Size = new System.Drawing.Size(183, 20);
            this.lkStockOut.TabIndex = 8;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoai.EnterMoveNextControl = true;
            this.txtTenLoai.Location = new System.Drawing.Point(336, 3);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(183, 20);
            this.txtTenLoai.TabIndex = 1;
            // 
            // chIsTrungchuyen
            // 
            this.chIsTrungchuyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.chIsTrungchuyen, 2);
            this.chIsTrungchuyen.Location = new System.Drawing.Point(271, 53);
            this.chIsTrungchuyen.Name = "chIsTrungchuyen";
            this.chIsTrungchuyen.Properties.Caption = "Là trung chuyển";
            this.chIsTrungchuyen.Size = new System.Drawing.Size(246, 19);
            this.chIsTrungchuyen.TabIndex = 9;
            // 
            // UCTransportRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCTransportRoute";
            this.Size = new System.Drawing.Size(522, 120);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockOut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chIsTrungchuyen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private DevExpress.XtraEditors.MemoEdit memoMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStockIn;
        private System.Windows.Forms.Label lbStockOut;
        private DevExpress.XtraEditors.LookUpEdit lkStockIn;
        private DevExpress.XtraEditors.LookUpEdit lkStockOut;
        private DevExpress.XtraEditors.CheckEdit chIsTrungchuyen;
    }
}
