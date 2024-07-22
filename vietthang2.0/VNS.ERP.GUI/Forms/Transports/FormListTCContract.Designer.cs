namespace VNS.ERP.GUI.Transports
{
    partial class FormListTCContract
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpSubject = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpSubject)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpSubject});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(860, 308);
            this.gridControl1.TabIndex = 105;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContractNo,
            this.colContractDate,
            this.colSubjectCode,
            this.colStartDate,
            this.colEndDate,
            this.colTaxRate,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colContractNo
            // 
            this.colContractNo.Caption = "Số hợp đồng";
            this.colContractNo.FieldName = "ContractNo";
            this.colContractNo.Name = "colContractNo";
            this.colContractNo.Visible = true;
            this.colContractNo.VisibleIndex = 0;
            this.colContractNo.Width = 124;
            // 
            // colContractDate
            // 
            this.colContractDate.Caption = "Ngày";
            this.colContractDate.DisplayFormat.FormatString = "d";
            this.colContractDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colContractDate.FieldName = "ContractDate";
            this.colContractDate.Name = "colContractDate";
            this.colContractDate.Visible = true;
            this.colContractDate.VisibleIndex = 1;
            this.colContractDate.Width = 96;
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "Đơn vị vận chuyển";
            this.colSubjectCode.ColumnEdit = this.repLookUpSubject;
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 2;
            this.colSubjectCode.Width = 231;
            // 
            // repLookUpSubject
            // 
            this.repLookUpSubject.AutoHeight = false;
            this.repLookUpSubject.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpSubject.DisplayMember = "SubjectName";
            this.repLookUpSubject.Name = "repLookUpSubject";
            this.repLookUpSubject.NullText = "";
            this.repLookUpSubject.ValueMember = "SubjectCode";
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày bắt đầu";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 3;
            this.colStartDate.Width = 100;
            // 
            // colEndDate
            // 
            this.colEndDate.Caption = "Ngày kết thúc";
            this.colEndDate.DisplayFormat.FormatString = "d";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 4;
            this.colEndDate.Width = 100;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "Thuế suất VC";
            this.colTaxRate.DisplayFormat.FormatString = "p2";
            this.colTaxRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 5;
            this.colTaxRate.Width = 91;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 6;
            this.colDescription.Width = 287;
            // 
            // FormListTCContract
            // 
            this.ClientSize = new System.Drawing.Size(860, 373);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListTCContract";
            this.Text = "Hợp đồng trung chuyển";
            this.Load += new System.EventHandler(this.FormListTCContract_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colContractDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
    }
}
