namespace VNS.ERP.GUI
{
    partial class FormPremixsReportByTime_Month
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
            this.lblStockCode = new System.Windows.Forms.Label();
            this.cboStockCode = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufactureDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShift = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShiftLeader = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBao40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBao25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinesxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeBaoTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDomin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTilebot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrappingWaste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductWeight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaoSD40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaoSD25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colElectricity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWrokingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhepham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaiche = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelayTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // lblStockCode
            // 
            this.lblStockCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Location = new System.Drawing.Point(11, 86);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(58, 13);
            this.lblStockCode.TabIndex = 0;
            this.lblStockCode.Text = "StockCode";
            // 
            // cboStockCode
            // 
            this.cboStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboStockCode.EditValue = "";
            this.cboStockCode.EnterMoveNextControl = true;
            this.cboStockCode.Location = new System.Drawing.Point(75, 83);
            this.cboStockCode.Name = "cboStockCode";
            this.cboStockCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStockCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName", "Tên", 220)});
            this.cboStockCode.Properties.DisplayMember = "StockName";
            this.cboStockCode.Properties.NullText = "";
            this.cboStockCode.Properties.PopupWidth = 300;
            this.cboStockCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboStockCode.Properties.ValueMember = "StockCode";
            this.cboStockCode.Size = new System.Drawing.Size(122, 20);
            this.cboStockCode.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 121);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(110, 1);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlanNo,
            this.colManufactureDate,
            this.colShift,
            this.colShiftLeader,
            this.colEmployeeID1,
            this.colEmployeeID2,
            this.colProductCode,
            this.colSizeCode,
            this.colFormulaCode,
            this.colLot,
            this.colNap,
            this.colEp,
            this.colBao40,
            this.colBao25,
            this.colLinesxNo,
            this.colCodeBaoTP,
            this.colAm,
            this.colDomin,
            this.colTilebot,
            this.colWrappingWaste,
            this.colProductWeight,
            this.colBaoSD40,
            this.colBaoSD25,
            this.colElectricity,
            this.colTotalWrokingTime,
            this.colPhepham,
            this.colTaiche,
            this.colStartTime,
            this.colEndTime,
            this.colDelayTime,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPlanNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colPlanNo
            // 
            this.colPlanNo.Caption = "PlanNo";
            this.colPlanNo.FieldName = "PlanNo";
            this.colPlanNo.Name = "colPlanNo";
            this.colPlanNo.Width = 80;
            // 
            // colManufactureDate
            // 
            this.colManufactureDate.Caption = "ManufactureDate";
            this.colManufactureDate.DisplayFormat.FormatString = "d";
            this.colManufactureDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colManufactureDate.FieldName = "ManufactureDate";
            this.colManufactureDate.Name = "colManufactureDate";
            this.colManufactureDate.Visible = true;
            this.colManufactureDate.VisibleIndex = 0;
            this.colManufactureDate.Width = 94;
            // 
            // colShift
            // 
            this.colShift.AppearanceCell.Options.UseTextOptions = true;
            this.colShift.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShift.AppearanceHeader.Options.UseTextOptions = true;
            this.colShift.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colShift.Caption = "Shift";
            this.colShift.FieldName = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.Visible = true;
            this.colShift.VisibleIndex = 1;
            this.colShift.Width = 40;
            // 
            // colShiftLeader
            // 
            this.colShiftLeader.Caption = "ShiftLeader";
            this.colShiftLeader.FieldName = "ShiftLeader";
            this.colShiftLeader.Name = "colShiftLeader";
            this.colShiftLeader.Visible = true;
            this.colShiftLeader.VisibleIndex = 2;
            this.colShiftLeader.Width = 145;
            // 
            // colEmployeeID1
            // 
            this.colEmployeeID1.Caption = "EmployeeID1";
            this.colEmployeeID1.FieldName = "EmployeeID1";
            this.colEmployeeID1.Name = "colEmployeeID1";
            this.colEmployeeID1.Visible = true;
            this.colEmployeeID1.VisibleIndex = 4;
            this.colEmployeeID1.Width = 144;
            // 
            // colEmployeeID2
            // 
            this.colEmployeeID2.Caption = "EmployeeID2";
            this.colEmployeeID2.FieldName = "EmployeeID2";
            this.colEmployeeID2.Name = "colEmployeeID2";
            this.colEmployeeID2.Visible = true;
            this.colEmployeeID2.VisibleIndex = 5;
            this.colEmployeeID2.Width = 150;
            // 
            // colProductCode
            // 
            this.colProductCode.AppearanceCell.Options.UseTextOptions = true;
            this.colProductCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductCode.Caption = "ProductCode";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 6;
            this.colProductCode.Width = 73;
            // 
            // colSizeCode
            // 
            this.colSizeCode.AppearanceCell.Options.UseTextOptions = true;
            this.colSizeCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSizeCode.Caption = "SizeCode";
            this.colSizeCode.FieldName = "SizeCode";
            this.colSizeCode.Name = "colSizeCode";
            this.colSizeCode.Visible = true;
            this.colSizeCode.VisibleIndex = 7;
            this.colSizeCode.Width = 69;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "FormulaCode";
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 8;
            // 
            // colLot
            // 
            this.colLot.Caption = "Lot";
            this.colLot.FieldName = "Lot";
            this.colLot.Name = "colLot";
            this.colLot.Visible = true;
            this.colLot.VisibleIndex = 9;
            this.colLot.Width = 57;
            // 
            // colNap
            // 
            this.colNap.Caption = "Nap";
            this.colNap.DisplayFormat.FormatString = "n0";
            this.colNap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNap.FieldName = "Nap";
            this.colNap.Name = "colNap";
            this.colNap.Visible = true;
            this.colNap.VisibleIndex = 10;
            // 
            // colEp
            // 
            this.colEp.Caption = "Ep";
            this.colEp.DisplayFormat.FormatString = "n0";
            this.colEp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEp.FieldName = "Ep";
            this.colEp.Name = "colEp";
            this.colEp.Visible = true;
            this.colEp.VisibleIndex = 11;
            // 
            // colBao40
            // 
            this.colBao40.Caption = "Bao40";
            this.colBao40.DisplayFormat.FormatString = "n0";
            this.colBao40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBao40.FieldName = "BaoSp40";
            this.colBao40.Name = "colBao40";
            this.colBao40.Visible = true;
            this.colBao40.VisibleIndex = 12;
            // 
            // colBao25
            // 
            this.colBao25.Caption = "Bao25";
            this.colBao25.DisplayFormat.FormatString = "n0";
            this.colBao25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBao25.FieldName = "BaoSp25";
            this.colBao25.Name = "colBao25";
            this.colBao25.Visible = true;
            this.colBao25.VisibleIndex = 13;
            // 
            // colLinesxNo
            // 
            this.colLinesxNo.AppearanceCell.Options.UseTextOptions = true;
            this.colLinesxNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLinesxNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colLinesxNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLinesxNo.Caption = "LinesxNo";
            this.colLinesxNo.FieldName = "LinesxNo";
            this.colLinesxNo.Name = "colLinesxNo";
            this.colLinesxNo.Visible = true;
            this.colLinesxNo.VisibleIndex = 3;
            this.colLinesxNo.Width = 62;
            // 
            // colCodeBaoTP
            // 
            this.colCodeBaoTP.Caption = "CodeBaoTP";
            this.colCodeBaoTP.FieldName = "CodeBaoTP";
            this.colCodeBaoTP.Name = "colCodeBaoTP";
            this.colCodeBaoTP.Visible = true;
            this.colCodeBaoTP.VisibleIndex = 14;
            // 
            // colAm
            // 
            this.colAm.AppearanceCell.Options.UseTextOptions = true;
            this.colAm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAm.Caption = "Doam";
            this.colAm.FieldName = "Doam";
            this.colAm.Name = "colAm";
            this.colAm.Visible = true;
            this.colAm.VisibleIndex = 15;
            // 
            // colDomin
            // 
            this.colDomin.Caption = "Domin";
            this.colDomin.FieldName = "Domin";
            this.colDomin.Name = "colDomin";
            this.colDomin.Visible = true;
            this.colDomin.VisibleIndex = 16;
            // 
            // colTilebot
            // 
            this.colTilebot.AppearanceCell.Options.UseTextOptions = true;
            this.colTilebot.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTilebot.Caption = "Tilebot";
            this.colTilebot.FieldName = "Tilebot";
            this.colTilebot.Name = "colTilebot";
            this.colTilebot.Visible = true;
            this.colTilebot.VisibleIndex = 17;
            // 
            // colWrappingWaste
            // 
            this.colWrappingWaste.Caption = "WrappingWaste";
            this.colWrappingWaste.DisplayFormat.FormatString = "n0";
            this.colWrappingWaste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colWrappingWaste.FieldName = "WrappingWaste";
            this.colWrappingWaste.Name = "colWrappingWaste";
            this.colWrappingWaste.Visible = true;
            this.colWrappingWaste.VisibleIndex = 26;
            this.colWrappingWaste.Width = 87;
            // 
            // colProductWeight
            // 
            this.colProductWeight.Caption = "ProductWeight";
            this.colProductWeight.DisplayFormat.FormatString = "n0";
            this.colProductWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colProductWeight.FieldName = "ProductWeight";
            this.colProductWeight.Name = "colProductWeight";
            this.colProductWeight.Visible = true;
            this.colProductWeight.VisibleIndex = 18;
            this.colProductWeight.Width = 88;
            // 
            // colBaoSD40
            // 
            this.colBaoSD40.Caption = "BaoSD40";
            this.colBaoSD40.FieldName = "BaoSD40";
            this.colBaoSD40.Name = "colBaoSD40";
            this.colBaoSD40.Visible = true;
            this.colBaoSD40.VisibleIndex = 19;
            // 
            // colBaoSD25
            // 
            this.colBaoSD25.Caption = "BaoSD25";
            this.colBaoSD25.FieldName = "BaoSD25";
            this.colBaoSD25.Name = "colBaoSD25";
            this.colBaoSD25.Visible = true;
            this.colBaoSD25.VisibleIndex = 20;
            // 
            // colElectricity
            // 
            this.colElectricity.Caption = "Electricity";
            this.colElectricity.DisplayFormat.FormatString = "n0";
            this.colElectricity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colElectricity.FieldName = "Electricity";
            this.colElectricity.Name = "colElectricity";
            this.colElectricity.Visible = true;
            this.colElectricity.VisibleIndex = 21;
            // 
            // colTotalWrokingTime
            // 
            this.colTotalWrokingTime.Caption = "TotalWrokingTime";
            this.colTotalWrokingTime.DisplayFormat.FormatString = "n0";
            this.colTotalWrokingTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalWrokingTime.FieldName = "TotalWrokingTime";
            this.colTotalWrokingTime.Name = "colTotalWrokingTime";
            this.colTotalWrokingTime.Visible = true;
            this.colTotalWrokingTime.VisibleIndex = 25;
            this.colTotalWrokingTime.Width = 119;
            // 
            // colPhepham
            // 
            this.colPhepham.Caption = "Phepham";
            this.colPhepham.DisplayFormat.FormatString = "n0";
            this.colPhepham.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPhepham.FieldName = "Phepham";
            this.colPhepham.Name = "colPhepham";
            this.colPhepham.Visible = true;
            this.colPhepham.VisibleIndex = 27;
            this.colPhepham.Width = 66;
            // 
            // colTaiche
            // 
            this.colTaiche.Caption = "Taiche";
            this.colTaiche.DisplayFormat.FormatString = "n0";
            this.colTaiche.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaiche.FieldName = "Taiche";
            this.colTaiche.Name = "colTaiche";
            this.colTaiche.Visible = true;
            this.colTaiche.VisibleIndex = 28;
            // 
            // colStartTime
            // 
            this.colStartTime.AppearanceCell.Options.UseTextOptions = true;
            this.colStartTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colStartTime.Caption = "StartTime";
            this.colStartTime.DisplayFormat.FormatString = "HH:mm";
            this.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 22;
            this.colStartTime.Width = 118;
            // 
            // colEndTime
            // 
            this.colEndTime.AppearanceCell.Options.UseTextOptions = true;
            this.colEndTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colEndTime.Caption = "EndTime";
            this.colEndTime.DisplayFormat.FormatString = "HH:mm";
            this.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 24;
            this.colEndTime.Width = 119;
            // 
            // colDelayTime
            // 
            this.colDelayTime.Caption = "DelayTime";
            this.colDelayTime.DisplayFormat.FormatString = "n0";
            this.colDelayTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDelayTime.FieldName = "DelayTime";
            this.colDelayTime.Name = "colDelayTime";
            this.colDelayTime.Visible = true;
            this.colDelayTime.VisibleIndex = 23;
            this.colDelayTime.Width = 118;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 29;
            this.colDescription.Width = 276;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoadData.Location = new System.Drawing.Point(439, 38);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(113, 36);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Xem";
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 126);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.40273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.59727F));
            this.tableLayoutPanel2.Controls.Add(this.btnLoadData, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 112);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86498F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.13502F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel3.Controls.Add(this.lblStockCode, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cboStockCode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ucDatePeriodSelection1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.41509F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.58491F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 106);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.AllowCheckDate = true;
            this.ucDatePeriodSelection1.AllowCheckQuarter = true;
            this.tableLayoutPanel3.SetColumnSpan(this.ucDatePeriodSelection1, 5);
            this.ucDatePeriodSelection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatePeriodSelection1.GroupText = "Báo cáo";
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(3, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(424, 74);
            this.ucDatePeriodSelection1.TabIndex = 3;
            this.ucDatePeriodSelection1.WorkingDate = new System.DateTime(2008, 9, 19, 0, 0, 0, 0);
            // 
            // FormPremixsReportByTime_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(600, 160);
            this.MinimumSize = new System.Drawing.Size(600, 160);
            this.Name = "FormPremixsReportByTime_Month";
            this.Text = "FormManufactureReportByTime_Month";
            this.Load += new System.EventHandler(this.FormManufactureReportByTime_Month_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStockCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStockCode;
        private DevExpress.XtraEditors.LookUpEdit cboStockCode;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnLoadData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.Columns.GridColumn colManufactureDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShift;
        private DevExpress.XtraGrid.Columns.GridColumn colShiftLeader;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLot;
        private DevExpress.XtraGrid.Columns.GridColumn colNap;
        private DevExpress.XtraGrid.Columns.GridColumn colEp;
        private DevExpress.XtraGrid.Columns.GridColumn colProductWeight;
        private DevExpress.XtraGrid.Columns.GridColumn colLinesxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeBaoTP;
        private DevExpress.XtraGrid.Columns.GridColumn colAm;
        private DevExpress.XtraGrid.Columns.GridColumn colDomin;
        private DevExpress.XtraGrid.Columns.GridColumn colTilebot;
        private DevExpress.XtraGrid.Columns.GridColumn colWrappingWaste;
        private DevExpress.XtraGrid.Columns.GridColumn colElectricity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWrokingTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPhepham;
        private DevExpress.XtraGrid.Columns.GridColumn colTaiche;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDelayTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colBao40;
        private DevExpress.XtraGrid.Columns.GridColumn colBao25;
        private DevExpress.XtraGrid.Columns.GridColumn colBaoSD25;
        private DevExpress.XtraGrid.Columns.GridColumn colBaoSD40;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
    }
}