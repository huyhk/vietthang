namespace VNS.ERP.GUI.KCS
{
    partial class Form_KCS_Report_THPTTP
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.BandCommon = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bancolProducCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.banColTechCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.replkTechCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BandNoiBo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandcolSMPT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolSMDK = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolTB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolMN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolMX = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BandNgoai = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandcolSMPT2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolSMKD2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolTB2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolMN2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandcolMX2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblShift = new System.Windows.Forms.Label();
            this.txtShift = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkTechCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).BeginInit();
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
            this.ucDatePeriodSelection1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.ucDatePeriodSelection1, 3);
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.tableLayoutPanel1.SetRowSpan(this.ucDatePeriodSelection1, 2);
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(514, 61);
            this.ucDatePeriodSelection1.TabIndex = 0;
            this.ucDatePeriodSelection1.WorkingDate = new System.DateTime(2008, 8, 5, 0, 0, 0, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lkStockCode, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblShift, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtShift, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 414);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.Location = new System.Drawing.Point(847, 389);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 22);
            this.btnExportExcel.TabIndex = 3;
            this.btnExportExcel.Text = "ExportExcel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 6);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 70);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.replkTechCode});
            this.gridControl1.Size = new System.Drawing.Size(1018, 313);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.BandCommon,
            this.BandNoiBo,
            this.BandNgoai});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bancolProducCode,
            this.banColTechCode,
            this.bandcolSMPT,
            this.bandcolSMDK,
            this.bandcolTB,
            this.bandcolMN,
            this.bandcolMX,
            this.bandcolSMPT2,
            this.bandcolSMKD2,
            this.bandcolMN2,
            this.bandcolMX2,
            this.bandcolTB2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BandCommon
            // 
            this.BandCommon.Columns.Add(this.bancolProducCode);
            this.BandCommon.Columns.Add(this.banColTechCode);
            this.BandCommon.Name = "BandCommon";
            this.BandCommon.Width = 170;
            // 
            // bancolProducCode
            // 
            this.bancolProducCode.Caption = "Thành phẩm";
            this.bancolProducCode.FieldName = "ProductCode";
            this.bancolProducCode.Name = "bancolProducCode";
            this.bancolProducCode.OptionsColumn.AllowMove = false;
            this.bancolProducCode.OptionsColumn.ShowInCustomizationForm = false;
            this.bancolProducCode.Visible = true;
            this.bancolProducCode.Width = 93;
            // 
            // banColTechCode
            // 
            this.banColTechCode.Caption = "Nguyên liệu";
            this.banColTechCode.ColumnEdit = this.replkTechCode;
            this.banColTechCode.FieldName = "TechCode";
            this.banColTechCode.Name = "banColTechCode";
            this.banColTechCode.Visible = true;
            this.banColTechCode.Width = 77;
            // 
            // replkTechCode
            // 
            this.replkTechCode.AutoHeight = false;
            this.replkTechCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkTechCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.replkTechCode.DisplayMember = "TechName";
            this.replkTechCode.Name = "replkTechCode";
            this.replkTechCode.NullText = "";
            this.replkTechCode.ValueMember = "TechCode";
            // 
            // BandNoiBo
            // 
            this.BandNoiBo.Caption = "PT Nội bộ";
            this.BandNoiBo.Columns.Add(this.bandcolSMPT);
            this.BandNoiBo.Columns.Add(this.bandcolSMDK);
            this.BandNoiBo.Columns.Add(this.bandcolTB);
            this.BandNoiBo.Columns.Add(this.bandcolMN);
            this.BandNoiBo.Columns.Add(this.bandcolMX);
            this.BandNoiBo.Name = "BandNoiBo";
            this.BandNoiBo.Width = 396;
            // 
            // bandcolSMPT
            // 
            this.bandcolSMPT.Caption = "SMPT";
            this.bandcolSMPT.FieldName = "SMPT";
            this.bandcolSMPT.Name = "bandcolSMPT";
            this.bandcolSMPT.Visible = true;
            this.bandcolSMPT.Width = 84;
            // 
            // bandcolSMDK
            // 
            this.bandcolSMDK.Caption = "SMKD";
            this.bandcolSMDK.FieldName = "SMKD";
            this.bandcolSMDK.Name = "bandcolSMDK";
            this.bandcolSMDK.Visible = true;
            this.bandcolSMDK.Width = 87;
            // 
            // bandcolTB
            // 
            this.bandcolTB.Caption = "TB";
            this.bandcolTB.FieldName = "TB";
            this.bandcolTB.Name = "bandcolTB";
            this.bandcolTB.Visible = true;
            this.bandcolTB.Width = 76;
            // 
            // bandcolMN
            // 
            this.bandcolMN.Caption = "Min";
            this.bandcolMN.FieldName = "mn";
            this.bandcolMN.Name = "bandcolMN";
            this.bandcolMN.Visible = true;
            this.bandcolMN.Width = 70;
            // 
            // bandcolMX
            // 
            this.bandcolMX.Caption = "Max";
            this.bandcolMX.FieldName = "mx";
            this.bandcolMX.Name = "bandcolMX";
            this.bandcolMX.Visible = true;
            this.bandcolMX.Width = 79;
            // 
            // BandNgoai
            // 
            this.BandNgoai.Caption = "TT Ngoài";
            this.BandNgoai.Columns.Add(this.bandcolSMPT2);
            this.BandNgoai.Columns.Add(this.bandcolSMKD2);
            this.BandNgoai.Columns.Add(this.bandcolTB2);
            this.BandNgoai.Columns.Add(this.bandcolMN2);
            this.BandNgoai.Columns.Add(this.bandcolMX2);
            this.BandNgoai.Name = "BandNgoai";
            this.BandNgoai.Width = 346;
            // 
            // bandcolSMPT2
            // 
            this.bandcolSMPT2.Caption = "SMPT2";
            this.bandcolSMPT2.FieldName = "SMPT2";
            this.bandcolSMPT2.Name = "bandcolSMPT2";
            this.bandcolSMPT2.Visible = true;
            this.bandcolSMPT2.Width = 85;
            // 
            // bandcolSMKD2
            // 
            this.bandcolSMKD2.Caption = "SMKD2";
            this.bandcolSMKD2.FieldName = "SMKD2";
            this.bandcolSMKD2.Name = "bandcolSMKD2";
            this.bandcolSMKD2.Visible = true;
            this.bandcolSMKD2.Width = 67;
            // 
            // bandcolTB2
            // 
            this.bandcolTB2.Caption = "TB2";
            this.bandcolTB2.FieldName = "TB2";
            this.bandcolTB2.Name = "bandcolTB2";
            this.bandcolTB2.Visible = true;
            this.bandcolTB2.Width = 59;
            // 
            // bandcolMN2
            // 
            this.bandcolMN2.Caption = "Min 2";
            this.bandcolMN2.FieldName = "mn2";
            this.bandcolMN2.Name = "bandcolMN2";
            this.bandcolMN2.Visible = true;
            this.bandcolMN2.Width = 64;
            // 
            // bandcolMX2
            // 
            this.bandcolMX2.Caption = "Max 2";
            this.bandcolMX2.FieldName = "mx2";
            this.bandcolMX2.Name = "bandcolMX2";
            this.bandcolMX2.Visible = true;
            this.bandcolMX2.Width = 71;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // lkStockCode
            // 
            this.lkStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lkStockCode.Location = new System.Drawing.Point(714, 45);
            this.lkStockCode.Name = "lkStockCode";
            this.lkStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.lkStockCode.Properties.DisplayMember = "StockName";
            this.lkStockCode.Properties.NullText = "";
            this.lkStockCode.Properties.ValueMember = "StockCode";
            this.lkStockCode.Size = new System.Drawing.Size(208, 20);
            this.lkStockCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(946, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 19);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblShift
            // 
            this.lblShift.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(688, 14);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(20, 13);
            this.lblShift.TabIndex = 6;
            this.lblShift.Text = "Ca";
            // 
            // txtShift
            // 
            this.txtShift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtShift.EditValue = "0";
            this.txtShift.Location = new System.Drawing.Point(714, 11);
            this.txtShift.Name = "txtShift";
            this.txtShift.Properties.Mask.EditMask = "#";
            this.txtShift.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtShift.Size = new System.Drawing.Size(58, 20);
            this.txtShift.TabIndex = 7;
            // 
            // Form_KCS_Report_THPTTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 418);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_KCS_Report_THPTTP";
            this.Text = "Form_KCS_Report_THPTTP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_KCS_Report_THPTTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replkTechCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShift.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BandCommon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bancolProducCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn banColTechCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit replkTechCode;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BandNoiBo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BandNgoai;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolSMPT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolSMDK;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnExportExcel;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lkStockCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolTB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolMN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolMX;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolSMPT2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolSMKD2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolMN2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolMX2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandcolTB2;
        private System.Windows.Forms.Label lblShift;
        private DevExpress.XtraEditors.TextEdit txtShift;
    }
}