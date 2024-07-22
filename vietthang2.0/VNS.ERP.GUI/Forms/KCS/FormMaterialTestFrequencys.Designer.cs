namespace VNS.ERP.GUI.KCS
{
    partial class FormMaterialTestFrequencys
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
            this.ucMaterialTestFrequencys1 = new VNS.ERP.GUI.UCMaterialTestFrequencys();
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMaterialTestFrequency = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpTechName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFrequencyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpFrequencyType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialTestFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFrequencyType)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // ucMaterialTestFrequencys1
            // 
            this.ucMaterialTestFrequencys1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucMaterialTestFrequencys1.Business = null;
            this.ucMaterialTestFrequencys1.DataSource = null;
            this.ucMaterialTestFrequencys1.ItemCode = "";
            this.ucMaterialTestFrequencys1.Location = new System.Drawing.Point(389, 379);
            this.ucMaterialTestFrequencys1.Name = "ucMaterialTestFrequencys1";
            this.ucMaterialTestFrequencys1.Size = new System.Drawing.Size(536, 128);
            this.ucMaterialTestFrequencys1.TabIndex = 0;
            // 
            // gridControlItems
            // 
            this.gridControlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlItems.EmbeddedNavigator.Name = "";
            this.gridControlItems.Location = new System.Drawing.Point(3, 3);
            this.gridControlItems.MainView = this.gridView1;
            this.gridControlItems.Name = "gridControlItems";
            this.tableLayoutPanel1.SetRowSpan(this.gridControlItems, 2);
            this.gridControlItems.Size = new System.Drawing.Size(298, 504);
            this.gridControlItems.TabIndex = 1;
            this.gridControlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode,
            this.colItemName});
            this.gridView1.GridControl = this.gridControlItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mã sản phẩm";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 174;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Tên sản phẩm";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 1;
            this.colItemName.Width = 245;
            // 
            // gridControlMaterialTestFrequency
            // 
            this.gridControlMaterialTestFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlMaterialTestFrequency.EmbeddedNavigator.Name = "";
            this.gridControlMaterialTestFrequency.Location = new System.Drawing.Point(307, 3);
            this.gridControlMaterialTestFrequency.MainView = this.gridView2;
            this.gridControlMaterialTestFrequency.Name = "gridControlMaterialTestFrequency";
            this.gridControlMaterialTestFrequency.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpTechName,
            this.lookUpFrequencyType});
            this.gridControlMaterialTestFrequency.Size = new System.Drawing.Size(701, 370);
            this.gridControlMaterialTestFrequency.TabIndex = 2;
            this.gridControlMaterialTestFrequency.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colTechName,
            this.colFrequencyType,
            this.colQuantity,
            this.colQuantityLocal,
            this.colDescription,
            this.colDateCreated,
            this.colUserCreated,
            this.colDateUpdated,
            this.colUserUpdated});
            this.gridView2.GridControl = this.gridControlMaterialTestFrequency;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTechName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStartDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 0;
            this.colStartDate.Width = 106;
            // 
            // colTechName
            // 
            this.colTechName.Caption = "Chỉ Tiêu";
            this.colTechName.ColumnEdit = this.lookUpTechName;
            this.colTechName.FieldName = "TechCode";
            this.colTechName.Name = "colTechName";
            this.colTechName.Width = 148;
            // 
            // lookUpTechName
            // 
            this.lookUpTechName.AutoHeight = false;
            this.lookUpTechName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTechName.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.lookUpTechName.Name = "lookUpTechName";
            this.lookUpTechName.NullText = "";
            // 
            // colFrequencyType
            // 
            this.colFrequencyType.Caption = "Loại tần suất";
            this.colFrequencyType.ColumnEdit = this.lookUpFrequencyType;
            this.colFrequencyType.FieldName = "FrequencyType";
            this.colFrequencyType.Name = "colFrequencyType";
            this.colFrequencyType.Visible = true;
            this.colFrequencyType.VisibleIndex = 1;
            this.colFrequencyType.Width = 150;
            // 
            // lookUpFrequencyType
            // 
            this.lookUpFrequencyType.AutoHeight = false;
            this.lookUpFrequencyType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFrequencyType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpFrequencyType.Name = "lookUpFrequencyType";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Tần suất kiểm ngoài";
            this.colQuantity.DisplayFormat.FormatString = "n0";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 148;
            // 
            // colQuantityLocal
            // 
            this.colQuantityLocal.Caption = "Tần suất nội bộ";
            this.colQuantityLocal.DisplayFormat.FormatString = "n0";
            this.colQuantityLocal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityLocal.FieldName = "QuantityLocal";
            this.colQuantityLocal.Name = "colQuantityLocal";
            this.colQuantityLocal.Visible = true;
            this.colQuantityLocal.VisibleIndex = 3;
            this.colQuantityLocal.Width = 139;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 464;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.16815F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.83185F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlMaterialTestFrequency, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucMaterialTestFrequencys1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 510);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FormMaterialTestFrequencys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucMaterialTestFrequencys1;
            this.GridControl = this.gridControlMaterialTestFrequency;
            this.Name = "FormMaterialTestFrequencys";
            this.Text = "FormMaterialTestFrequencys";
            this.Load += new System.EventHandler(this.FormMaterialTestFrequencys_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialTestFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFrequencyType)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCMaterialTestFrequencys ucMaterialTestFrequencys1;
        private DevExpress.XtraGrid.GridControl gridControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlMaterialTestFrequency;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTechName;
        private DevExpress.XtraGrid.Columns.GridColumn colFrequencyType;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpTechName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpFrequencyType;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityLocal;
    }
}