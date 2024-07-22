namespace VNS.ERP.GUI.KCS
{
    partial class FormTechnicalTestPrices
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
            this.ucTechnicalTestPrices1 = new VNS.ERP.GUI.UCTechnicalTestPrices();
            this.gridControlSubject = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpSubjectCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechnical = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpTechnical = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
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
            // ucTechnicalTestPrices1
            // 
            this.ucTechnicalTestPrices1.Business = null;
            this.ucTechnicalTestPrices1.DataSource = null;
            this.ucTechnicalTestPrices1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucTechnicalTestPrices1.Location = new System.Drawing.Point(0, 337);
            this.ucTechnicalTestPrices1.Name = "ucTechnicalTestPrices1";
            this.ucTechnicalTestPrices1.Size = new System.Drawing.Size(927, 106);
            this.ucTechnicalTestPrices1.SubjectCode = "";
            this.ucTechnicalTestPrices1.TabIndex = 5;
            // 
            // gridControlSubject
            // 
            this.gridControlSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlSubject.EmbeddedNavigator.Name = "";
            this.gridControlSubject.Location = new System.Drawing.Point(5, 45);
            this.gridControlSubject.MainView = this.gridView1;
            this.gridControlSubject.Name = "gridControlSubject";
            this.gridControlSubject.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpSubjectCode});
            this.gridControlSubject.Size = new System.Drawing.Size(400, 286);
            this.gridControlSubject.TabIndex = 6;
            this.gridControlSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubjectCode,
            this.colSubjectName});
            this.gridView1.GridControl = this.gridControlSubject;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.Caption = "Mã Trung tâm";
            this.colSubjectCode.FieldName = "SubjectCode";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.Visible = true;
            this.colSubjectCode.VisibleIndex = 0;
            this.colSubjectCode.Width = 210;
            // 
            // colSubjectName
            // 
            this.colSubjectName.Caption = "Tên trung tâm";
            this.colSubjectName.FieldName = "SubjectName";
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.Visible = true;
            this.colSubjectName.VisibleIndex = 1;
            this.colSubjectName.Width = 622;
            // 
            // lookUpSubjectCode
            // 
            this.lookUpSubjectCode.AutoHeight = false;
            this.lookUpSubjectCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSubjectCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubjectName")});
            this.lookUpSubjectCode.Name = "lookUpSubjectCode";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(411, 45);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpTechnical,
            this.txtPrice});
            this.gridControl2.Size = new System.Drawing.Size(511, 286);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colTechnical,
            this.colPrice,
            this.colDescription,
            this.colDateCreated,
            this.colUserCreated,
            this.colDateUpdated,
            this.colUserUpdated});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStartDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.GroupFormat.FormatString = "d";
            this.colStartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Width = 82;
            // 
            // colTechnical
            // 
            this.colTechnical.Caption = "Chỉ tiêu";
            this.colTechnical.ColumnEdit = this.lookUpTechnical;
            this.colTechnical.FieldName = "TechCode";
            this.colTechnical.Name = "colTechnical";
            this.colTechnical.Visible = true;
            this.colTechnical.VisibleIndex = 0;
            this.colTechnical.Width = 124;
            // 
            // lookUpTechnical
            // 
            this.lookUpTechnical.AutoHeight = false;
            this.lookUpTechnical.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTechnical.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpTechnical.Name = "lookUpTechnical";
            this.lookUpTechnical.NullText = "";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Đơn giá";
            this.colPrice.ColumnEdit = this.txtPrice;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 94;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoHeight = false;
            this.txtPrice.Name = "txtPrice";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 413;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Ngày tạo";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "Người tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // colDateUpdated
            // 
            this.colDateUpdated.Caption = "Ngày sửa";
            this.colDateUpdated.FieldName = "DateUpdated";
            this.colDateUpdated.Name = "colDateUpdated";
            // 
            // colUserUpdated
            // 
            this.colUserUpdated.Caption = "Người sửa";
            this.colUserUpdated.FieldName = "UserUpdated";
            this.colUserUpdated.Name = "colUserUpdated";
            // 
            // FormTechnicalTestPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 466);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControlSubject);
            this.Controls.Add(this.ucTechnicalTestPrices1);
            this.EditControl = this.ucTechnicalTestPrices1;
            this.GridControl = this.gridControl2;
            this.Name = "FormTechnicalTestPrices";
            this.Text = "FormTechnicalTestPrices";
            this.Load += new System.EventHandler(this.FormTechnicalTestPrices_Load);
            this.Controls.SetChildIndex(this.ucTechnicalTestPrices1, 0);
            this.Controls.SetChildIndex(this.gridControlSubject, 0);
            this.Controls.SetChildIndex(this.gridControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSubjectCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechnical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTechnicalTestPrices ucTechnicalTestPrices1;
        private DevExpress.XtraGrid.GridControl gridControlSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colSubjectName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTechnical;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpTechnical;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
    }
}