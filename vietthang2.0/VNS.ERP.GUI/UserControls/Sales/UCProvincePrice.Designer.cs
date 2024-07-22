namespace VNS.ERP.GUI.UserControls.Sales
{
    partial class UCProvincePrice
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lokProvince = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbProductType);
            this.layoutControl1.Controls.Add(this.txtAmount);
            this.layoutControl1.Controls.Add(this.txtStartDate);
            this.layoutControl1.Controls.Add(this.lokProvince);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(362, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "TS",
            "GS",
            "CV"});
            this.cbProductType.Location = new System.Drawing.Point(94, 36);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(256, 21);
            this.cbProductType.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(94, 85);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Mask.EditMask = "n0";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(256, 20);
            this.txtAmount.StyleController = this.layoutControl1;
            this.txtAmount.TabIndex = 6;
            // 
            // txtStartDate
            // 
            this.txtStartDate.EditValue = null;
            this.txtStartDate.Location = new System.Drawing.Point(94, 61);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStartDate.Size = new System.Drawing.Size(256, 20);
            this.txtStartDate.StyleController = this.layoutControl1;
            this.txtStartDate.TabIndex = 5;
            // 
            // lokProvince
            // 
            this.lokProvince.Location = new System.Drawing.Point(94, 12);
            this.lokProvince.Name = "lokProvince";
            this.lokProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lokProvince.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Kh")});
            this.lokProvince.Properties.DisplayMember = "StockName";
            this.lokProvince.Properties.NullText = "";
            this.lokProvince.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lokProvince.Properties.ValueMember = "StockCode";
            this.lokProvince.Size = new System.Drawing.Size(256, 20);
            this.lokProvince.StyleController = this.layoutControl1;
            this.lokProvince.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(362, 118);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lokProvince;
            this.layoutControlItem1.CustomizationFormText = "Kho";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem1.Text = "Kho";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtStartDate;
            this.layoutControlItem2.CustomizationFormText = "Từ ngày";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(342, 24);
            this.layoutControlItem2.Text = "Từ ngày";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtAmount;
            this.layoutControlItem3.CustomizationFormText = "Số tiền";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(342, 25);
            this.layoutControlItem3.Text = "Số tiền";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbProductType;
            this.layoutControlItem4.CustomizationFormText = "Loại thành phẩm";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(342, 25);
            this.layoutControlItem4.Text = "Loại thành phẩm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 13);
            // 
            // UCProvincePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UCProvincePrice";
            this.Size = new System.Drawing.Size(362, 118);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraEditors.LookUpEdit lokProvince;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ComboBox cbProductType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
