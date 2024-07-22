namespace VNS.ERP.GUI.Sales
{
    partial class FormRpCustomerPayments
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPaymentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Location = new System.Drawing.Point(460, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 28);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Xem";
            this.btnRefresh.ToolTip = "Refresh Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnReports, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.05556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.944445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 502);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReports.Enabled = false;
            this.btnReports.Location = new System.Drawing.Point(292, 470);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(208, 28);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.ToolTip = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Name = "";
            this.gridControl.Location = new System.Drawing.Point(3, 3);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(786, 461);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPaymentNo,
            this.colPaymentDate,
            this.colCustomerCode,
            this.colSubjectName,
            this.colAmount,
            this.colDescription});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colPaymentNo
            // 
            this.colPaymentNo.Caption = "PaymentNo";
            this.colPaymentNo.FieldName = "PaymentNo";
            this.colPaymentNo.Name = "colPaymentNo";
            this.colPaymentNo.Visible = true;
            this.colPaymentNo.VisibleIndex = 0;
            this.colPaymentNo.Width = 97;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.Caption = "PaymentDate";
            this.colPaymentDate.DisplayFormat.FormatString = "d";
            this.colPaymentDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 1;
            this.colPaymentDate.Width = 109;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.Caption = "CustomerCode";
            this.colCustomerCode.FieldName = "CustomerCode";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.Visible = true;
            this.colCustomerCode.VisibleIndex = 2;
            this.colCustomerCode.Width = 93;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "SubjectName";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 3;
            this.colSubjectName.Width = 194;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Amount";
            this.colAmount.DisplayFormat.FormatString = "{0:###,###,###,###,###,###,##0}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            this.colAmount.Width = 117;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 400;
            // 
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(4, 3);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 9;
            // 
            // FormRpCustomerPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRpCustomerPayments";
            this.Text = "FormRpCustomerPayments";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
    }
}