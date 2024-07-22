namespace VNS.ERP.GUI.KCS
{
    partial class UCEncryptCodeSend
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
            this.lbSendNo = new System.Windows.Forms.Label();
            this.lbSendDate = new System.Windows.Forms.Label();
            this.dateEditSend = new DevExpress.XtraEditors.DateEdit();
            this.lbSubjectCode = new System.Windows.Forms.Label();
            this.lookUpSubjectCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colItemEncryptCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandDetailMaterial = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colItemEncryptCodeProduct = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandDetailProduct = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.btnEditDetailMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditDetailProduct = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEditSendNo = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSendNo.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSendNo
            // 
            this.lbSendNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSendNo.Location = new System.Drawing.Point(3, 0);
            this.lbSendNo.Name = "lbSendNo";
            this.lbSendNo.Size = new System.Drawing.Size(54, 25);
            this.lbSendNo.TabIndex = 8;
            this.lbSendNo.Text = "Số";
            this.lbSendNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSendDate
            // 
            this.lbSendDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSendDate.Location = new System.Drawing.Point(224, 0);
            this.lbSendDate.Name = "lbSendDate";
            this.lbSendDate.Size = new System.Drawing.Size(44, 25);
            this.lbSendDate.TabIndex = 9;
            this.lbSendDate.Text = "Ngày";
            this.lbSendDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditSend
            // 
            this.dateEditSend.EditValue = new System.DateTime(2008, 4, 4, 0, 0, 0, 0);
            this.dateEditSend.EnterMoveNextControl = true;
            this.dateEditSend.Location = new System.Drawing.Point(274, 3);
            this.dateEditSend.Name = "dateEditSend";
            this.dateEditSend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSend.Size = new System.Drawing.Size(116, 20);
            this.dateEditSend.TabIndex = 1;
            // 
            // lbSubjectCode
            // 
            this.lbSubjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubjectCode.Location = new System.Drawing.Point(3, 25);
            this.lbSubjectCode.Name = "lbSubjectCode";
            this.lbSubjectCode.Size = new System.Drawing.Size(54, 25);
            this.lbSubjectCode.TabIndex = 10;
            this.lbSubjectCode.Text = "TTPT";
            this.lbSubjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpSubjectCode
            // 
            this.lookUpSubjectCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpSubjectCode.EnterMoveNextControl = true;
            this.lookUpSubjectCode.Location = new System.Drawing.Point(63, 28);
            this.lookUpSubjectCode.Name = "lookUpSubjectCode";
            this.lookUpSubjectCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSubjectCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectCode", "Mã TT", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName", "TTPT", 200)});
            this.lookUpSubjectCode.Properties.DisplayMember = "SubjectName";
            this.lookUpSubjectCode.Properties.NullText = "";
            this.lookUpSubjectCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpSubjectCode.Properties.ValueMember = "SubjectCode";
            this.lookUpSubjectCode.Size = new System.Drawing.Size(155, 20);
            this.lookUpSubjectCode.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescription.Location = new System.Drawing.Point(3, 50);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(54, 53);
            this.lbDescription.TabIndex = 11;
            this.lbDescription.Text = "Diễn giải";
            this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(63, 53);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(425, 47);
            this.txtDescription.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(464, 300);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.bandDetailMaterial});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colItemEncryptCode});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colItemEncryptCode);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 157;
            // 
            // colItemEncryptCode
            // 
            this.colItemEncryptCode.Caption = "Mã mẫu";
            this.colItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode.Name = "colItemEncryptCode";
            this.colItemEncryptCode.Visible = true;
            this.colItemEncryptCode.Width = 157;
            // 
            // bandDetailMaterial
            // 
            this.bandDetailMaterial.AppearanceHeader.Options.UseTextOptions = true;
            this.bandDetailMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandDetailMaterial.Caption = "Chi tiết";
            this.bandDetailMaterial.Name = "bandDetailMaterial";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 319);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nguyên liệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(479, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 319);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thành phẩm";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(3, 16);
            this.gridControl2.MainView = this.bandedGridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(465, 300);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView2});
            // 
            // bandedGridView2
            // 
            this.bandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.bandDetailProduct});
            this.bandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colItemEncryptCodeProduct});
            this.bandedGridView2.GridControl = this.gridControl2;
            this.bandedGridView2.Name = "bandedGridView2";
            this.bandedGridView2.OptionsBehavior.Editable = false;
            this.bandedGridView2.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand3
            // 
            this.gridBand3.Columns.Add(this.colItemEncryptCodeProduct);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 157;
            // 
            // colItemEncryptCodeProduct
            // 
            this.colItemEncryptCodeProduct.Caption = "Mã mẫu";
            this.colItemEncryptCodeProduct.FieldName = "ItemEncryptCode";
            this.colItemEncryptCodeProduct.Name = "colItemEncryptCodeProduct";
            this.colItemEncryptCodeProduct.Visible = true;
            this.colItemEncryptCodeProduct.Width = 157;
            // 
            // bandDetailProduct
            // 
            this.bandDetailProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.bandDetailProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandDetailProduct.Caption = "Chi tiết";
            this.bandDetailProduct.Name = "bandDetailProduct";
            // 
            // btnEditDetailMaterial
            // 
            this.btnEditDetailMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetailMaterial.Location = new System.Drawing.Point(432, 3);
            this.btnEditDetailMaterial.Name = "btnEditDetailMaterial";
            this.btnEditDetailMaterial.Size = new System.Drawing.Size(41, 19);
            this.btnEditDetailMaterial.TabIndex = 4;
            this.btnEditDetailMaterial.Text = "...";
            this.btnEditDetailMaterial.Click += new System.EventHandler(this.btnEditDetailMaterial_Click);
            // 
            // btnEditDetailProduct
            // 
            this.btnEditDetailProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditDetailProduct.Location = new System.Drawing.Point(909, 3);
            this.btnEditDetailProduct.Name = "btnEditDetailProduct";
            this.btnEditDetailProduct.Size = new System.Drawing.Size(41, 19);
            this.btnEditDetailProduct.TabIndex = 6;
            this.btnEditDetailProduct.Text = "...";
            this.btnEditDetailProduct.Click += new System.EventHandler(this.btnEditDetailProduct_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 537F));
            this.tableLayoutPanel1.Controls.Add(this.lbSendNo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSendDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSubjectCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lookUpSubjectCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEditSendNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateEditSend, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 103);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // buttonEditSendNo
            // 
            this.buttonEditSendNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditSendNo.Location = new System.Drawing.Point(63, 3);
            this.buttonEditSendNo.Name = "buttonEditSendNo";
            this.buttonEditSendNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditSendNo.Size = new System.Drawing.Size(155, 20);
            this.buttonEditSendNo.TabIndex = 12;
            this.buttonEditSendNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditSendNo_ButtonClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnEditDetailMaterial, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEditDetailProduct, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 109);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(953, 350);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // UCEncryptCodeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCEncryptCodeSend";
            this.Size = new System.Drawing.Size(968, 462);
            this.Load += new System.EventHandler(this.UCEncryptCodeSend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditSendNo.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSendNo;
        private System.Windows.Forms.Label lbSendDate;
        private DevExpress.XtraEditors.DateEdit dateEditSend;
        private System.Windows.Forms.Label lbSubjectCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpSubjectCode;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemEncryptCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandDetailMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colItemEncryptCodeProduct;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandDetailProduct;
        private DevExpress.XtraEditors.SimpleButton btnEditDetailMaterial;
        private DevExpress.XtraEditors.SimpleButton btnEditDetailProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.ButtonEdit buttonEditSendNo;
    }
}
