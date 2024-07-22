namespace VNS.ERP.GUI.Stocks
{
    partial class FormReportTinhHinhTonTru
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
            this.lstReportFor = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optMaterial = new System.Windows.Forms.RadioButton();
            this.optProduct = new System.Windows.Forms.RadioButton();
            this.dateEditToDate = new DevExpress.XtraEditors.DateEdit();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.txtDays = new DevExpress.XtraEditors.TextEdit();
            this.lookUpStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lbStockCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstReportFor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // lstReportFor
            // 
            this.lstReportFor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReportFor.Appearance.Options.UseFont = true;
            this.lstReportFor.CheckOnClick = true;
            this.lstReportFor.ColumnWidth = 150;
            this.lstReportFor.DisplayMember = "EnumText";
            this.lstReportFor.Enabled = false;
            this.lstReportFor.Location = new System.Drawing.Point(97, 42);
            this.lstReportFor.MultiColumn = true;
            this.lstReportFor.Name = "lstReportFor";
            this.lstReportFor.Size = new System.Drawing.Size(460, 60);
            this.lstReportFor.TabIndex = 0;
            this.lstReportFor.ValueMember = "EnumID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optMaterial);
            this.groupBox1.Controls.Add(this.lstReportFor);
            this.groupBox1.Controls.Add(this.optProduct);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // optMaterial
            // 
            this.optMaterial.AutoSize = true;
            this.optMaterial.Location = new System.Drawing.Point(6, 60);
            this.optMaterial.Name = "optMaterial";
            this.optMaterial.Size = new System.Drawing.Size(81, 17);
            this.optMaterial.TabIndex = 2;
            this.optMaterial.Text = "Nguyên liệu";
            this.optMaterial.UseVisualStyleBackColor = true;
            this.optMaterial.CheckedChanged += new System.EventHandler(this.optMaterial_CheckedChanged);
            // 
            // optProduct
            // 
            this.optProduct.AutoSize = true;
            this.optProduct.Checked = true;
            this.optProduct.Location = new System.Drawing.Point(6, 19);
            this.optProduct.Name = "optProduct";
            this.optProduct.Size = new System.Drawing.Size(84, 17);
            this.optProduct.TabIndex = 1;
            this.optProduct.TabStop = true;
            this.optProduct.Text = "Thành phẩm";
            this.optProduct.UseVisualStyleBackColor = true;
            // 
            // dateEditToDate
            // 
            this.dateEditToDate.EditValue = new System.DateTime(2007, 1, 15, 0, 0, 0, 0);
            this.dateEditToDate.Location = new System.Drawing.Point(300, 18);
            this.dateEditToDate.Name = "dateEditToDate";
            this.dateEditToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditToDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditToDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditToDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditToDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEditToDate.Size = new System.Drawing.Size(88, 22);
            this.dateEditToDate.TabIndex = 1;
            // 
            // lbToDate
            // 
            this.lbToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToDate.Location = new System.Drawing.Point(199, 17);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(98, 22);
            this.lbToDate.TabIndex = 4;
            this.lbToDate.Text = "Tính đến ngày";
            this.lbToDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDay
            // 
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(423, 18);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(92, 22);
            this.lbDay.TabIndex = 5;
            this.lbDay.Text = "Số ngày tính";
            this.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDays
            // 
            this.txtDays.AllowDrop = true;
            this.txtDays.EditValue = 30;
            this.txtDays.EnterMoveNextControl = true;
            this.txtDays.Location = new System.Drawing.Point(516, 19);
            this.txtDays.Name = "txtDays";
            this.txtDays.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDays.Properties.Appearance.Options.UseFont = true;
            this.txtDays.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDays.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDays.Properties.EditFormat.FormatString = "9";
            this.txtDays.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDays.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?";
            this.txtDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtDays.Properties.Mask.PlaceHolder = '\0';
            this.txtDays.Properties.Mask.ShowPlaceHolders = false;
            this.txtDays.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDays.Properties.MaxLength = 20;
            this.txtDays.Size = new System.Drawing.Size(40, 21);
            this.txtDays.TabIndex = 2;
            // 
            // lookUpStockCode
            // 
            this.lookUpStockCode.Location = new System.Drawing.Point(46, 18);
            this.lookUpStockCode.Name = "lookUpStockCode";
            this.lookUpStockCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpStockCode.Properties.Appearance.Options.UseFont = true;
            this.lookUpStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 70),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 130)});
            this.lookUpStockCode.Properties.DisplayMember = "StockName";
            this.lookUpStockCode.Properties.NullText = "";
            this.lookUpStockCode.Properties.PopupWidth = 200;
            this.lookUpStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStockCode.Properties.ValueMember = "StockCode";
            this.lookUpStockCode.Size = new System.Drawing.Size(110, 22);
            this.lookUpStockCode.TabIndex = 0;
            // 
            // lbStockCode
            // 
            this.lbStockCode.Location = new System.Drawing.Point(6, 19);
            this.lbStockCode.Name = "lbStockCode";
            this.lbStockCode.Size = new System.Drawing.Size(33, 18);
            this.lbStockCode.TabIndex = 3;
            this.lbStockCode.Text = "Kho";
            this.lbStockCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbToDate);
            this.groupBox2.Controls.Add(this.lookUpStockCode);
            this.groupBox2.Controls.Add(this.dateEditToDate);
            this.groupBox2.Controls.Add(this.lbStockCode);
            this.groupBox2.Controls.Add(this.lbDay);
            this.groupBox2.Controls.Add(this.txtDays);
            this.groupBox2.Location = new System.Drawing.Point(3, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(429, 161);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(139, 22);
            this.btnExportToExcel.TabIndex = 2;
            this.btnExportToExcel.Text = "Xuất báo cáo ra excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // FormReportTinhHinhTonTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 187);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportTinhHinhTonTru";
            this.Text = "Báo cáo tình hình tồn trữ nguyên liệu/thành phẩm";
            this.Load += new System.EventHandler(this.FormReportTinhHinhTonTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstReportFor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStockCode.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl lstReportFor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMaterial;
        private System.Windows.Forms.RadioButton optProduct;
        private DevExpress.XtraEditors.DateEdit dateEditToDate;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbDay;
        private DevExpress.XtraEditors.TextEdit txtDays;
        private DevExpress.XtraEditors.LookUpEdit lookUpStockCode;
        private System.Windows.Forms.Label lbStockCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportToExcel;
    }
}