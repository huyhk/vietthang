namespace VNS.ERP.GUI.Accounting
{
    partial class FormProductCostFormula
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCopyCreate = new DevExpress.XtraEditors.SimpleButton();
            this.checkExcel = new DevExpress.XtraEditors.CheckEdit();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrappingCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucProducCostFormula1 = new VNS.ERP.GUI.UCProducCostFormula();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPeriodCode = new System.Windows.Forms.Label();
            this.cboPeriodCode = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "The Asphalt World";
            // 
            // defaultBarAndDocking
            // 
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucProducCostFormula1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 560);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 3);
            this.groupControl1.Controls.Add(this.btnCopyCreate);
            this.groupControl1.Controls.Add(this.checkExcel);
            this.groupControl1.Controls.Add(this.btnReport);
            this.groupControl1.Controls.Add(this.btnReport2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 519);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(792, 41);
            this.groupControl1.TabIndex = 105;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnCopyCreate
            // 
            this.btnCopyCreate.Location = new System.Drawing.Point(12, 3);
            this.btnCopyCreate.Name = "btnCopyCreate";
            this.btnCopyCreate.Size = new System.Drawing.Size(116, 33);
            this.btnCopyCreate.TabIndex = 5;
            this.btnCopyCreate.Text = "Copy tạo mới";
            this.btnCopyCreate.Click += new System.EventHandler(this.btnCopyCreate_Click);
            // 
            // checkExcel
            // 
            this.checkExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkExcel.Location = new System.Drawing.Point(656, 9);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Properties.Caption = "Kết xuất Excel";
            this.checkExcel.Size = new System.Drawing.Size(118, 19);
            this.checkExcel.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReport.Location = new System.Drawing.Point(507, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(139, 35);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnReport2
            // 
            this.btnReport2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReport2.Location = new System.Drawing.Point(358, 3);
            this.btnReport2.Name = "btnReport2";
            this.btnReport2.Size = new System.Drawing.Size(139, 35);
            this.btnReport2.TabIndex = 3;
            this.btnReport2.Text = "BC Tổng hợp ra Excel";
            this.btnReport2.Click += new System.EventHandler(this.btnReport2_Click);
            // 
            // gridControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 3);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(786, 199);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductCode,
            this.colWrappingCode,
            this.colTotalCostAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "ProductCode";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 108;
            // 
            // colWrappingCode
            // 
            this.colWrappingCode.Caption = "Bao bì";
            this.colWrappingCode.FieldName = "WrappingCode";
            this.colWrappingCode.Name = "colWrappingCode";
            this.colWrappingCode.Visible = true;
            this.colWrappingCode.VisibleIndex = 1;
            // 
            // colTotalCostAmount
            // 
            this.colTotalCostAmount.Caption = "TotalCostAmount";
            this.colTotalCostAmount.DisplayFormat.FormatString = "n0";
            this.colTotalCostAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCostAmount.FieldName = "TotalCostAmount";
            this.colTotalCostAmount.Name = "colTotalCostAmount";
            this.colTotalCostAmount.SummaryItem.DisplayFormat = "{0:#,##0}";
            this.colTotalCostAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalCostAmount.Visible = true;
            this.colTotalCostAmount.VisibleIndex = 2;
            this.colTotalCostAmount.Width = 150;
            // 
            // ucProducCostFormula1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ucProducCostFormula1, 3);
            this.ucProducCostFormula1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProducCostFormula1.Location = new System.Drawing.Point(3, 244);
            this.ucProducCostFormula1.Name = "ucProducCostFormula1";
            this.ucProducCostFormula1.Size = new System.Drawing.Size(786, 272);
            this.ucProducCostFormula1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblPeriodCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboPeriodCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCopy, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 30);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblPeriodCode
            // 
            this.lblPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPeriodCode.AutoSize = true;
            this.lblPeriodCode.Location = new System.Drawing.Point(5, 8);
            this.lblPeriodCode.Name = "lblPeriodCode";
            this.lblPeriodCode.Size = new System.Drawing.Size(62, 13);
            this.lblPeriodCode.TabIndex = 0;
            this.lblPeriodCode.Text = "PeriodCode";
            this.lblPeriodCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPeriodCode
            // 
            this.cboPeriodCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPeriodCode.EnterMoveNextControl = true;
            this.cboPeriodCode.Location = new System.Drawing.Point(73, 5);
            this.cboPeriodCode.Name = "cboPeriodCode";
            this.cboPeriodCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPeriodCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Tháng")});
            this.cboPeriodCode.Properties.DisplayMember = "Description";
            this.cboPeriodCode.Properties.NullText = "";
            this.cboPeriodCode.Properties.PopupWidth = 200;
            this.cboPeriodCode.Properties.ValueMember = "PeriodCode";
            this.cboPeriodCode.Size = new System.Drawing.Size(172, 20);
            this.cboPeriodCode.TabIndex = 1;
            this.cboPeriodCode.EditValueChanged += new System.EventHandler(this.cboPeriodCode_EditValueChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCopy.Location = new System.Drawing.Point(292, 2);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(119, 25);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy đến tháng trước";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // FormProductCostFormula
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucProducCostFormula1;
            this.GridControl = this.gridControl1;
            this.Name = "FormProductCostFormula";
            this.Text = "FormProductCostFormula";
            this.Load += new System.EventHandler(this.FormProductCostFormula_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPeriodCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCostAmount;
        private UCProducCostFormula ucProducCostFormula1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblPeriodCode;
        private DevExpress.XtraEditors.LookUpEdit cboPeriodCode;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.CheckEdit checkExcel;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraEditors.SimpleButton btnReport2;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingCode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCopyCreate;
    }
}