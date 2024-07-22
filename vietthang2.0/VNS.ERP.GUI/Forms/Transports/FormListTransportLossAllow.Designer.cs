namespace VNS.ERP.GUI.Transports
{
    partial class FormListTransportLossAllow
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransportType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLKTransportType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransportItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLKTransportItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLKItemCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLossAllowRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLossAllowRate = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKTransportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKTransportItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKItemCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLossAllowRate)).BeginInit();
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransportType});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.ViewCaption = "Phương tiện";
            // 
            // colTransportType
            // 
            this.colTransportType.Caption = "Phương tiện";
            this.colTransportType.ColumnEdit = this.repLKTransportType;
            this.colTransportType.FieldName = "TransportType";
            this.colTransportType.Name = "colTransportType";
            this.colTransportType.Visible = true;
            this.colTransportType.VisibleIndex = 0;
            this.colTransportType.Width = 300;
            // 
            // repLKTransportType
            // 
            this.repLKTransportType.AutoHeight = false;
            this.repLKTransportType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLKTransportType.DisplayMember = "TypeName";
            this.repLKTransportType.Name = "repLKTransportType";
            this.repLKTransportType.NullText = "";
            this.repLKTransportType.ValueMember = "TypeCode";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "TransportLossAllowTransportTypeList";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "TransportLossAllowTransportItemTypeList";
            gridLevelNode3.LevelTemplate = this.gridView4;
            gridLevelNode3.RelationName = "TransportLossAllowItemList";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(0, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtLossAllowRate,
            this.repLKTransportType,
            this.repLKTransportItemType,
            this.repLKItemCode});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(889, 308);
            this.gridControl1.TabIndex = 105;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView4,
            this.gridView1,
            this.gridView2});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransportItemType});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.ViewCaption = "Loại hàng";
            // 
            // colTransportItemType
            // 
            this.colTransportItemType.Caption = "Loại hàng";
            this.colTransportItemType.ColumnEdit = this.repLKTransportItemType;
            this.colTransportItemType.FieldName = "TransportItemType";
            this.colTransportItemType.Name = "colTransportItemType";
            this.colTransportItemType.Visible = true;
            this.colTransportItemType.VisibleIndex = 0;
            this.colTransportItemType.Width = 300;
            // 
            // repLKTransportItemType
            // 
            this.repLKTransportItemType.AutoHeight = false;
            this.repLKTransportItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLKTransportItemType.DisplayMember = "TypeName";
            this.repLKTransportItemType.Name = "repLKTransportItemType";
            this.repLKTransportItemType.ValueMember = "TypeCode";
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemCode});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ColumnAutoWidth = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.ViewCaption = "Mặt hàng";
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Mặt hàng";
            this.colItemCode.ColumnEdit = this.repLKItemCode;
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 0;
            this.colItemCode.Width = 300;
            // 
            // repLKItemCode
            // 
            this.repLKItemCode.AutoHeight = false;
            this.repLKItemCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLKItemCode.DisplayMember = "ItemName";
            this.repLKItemCode.Name = "repLKItemCode";
            this.repLKItemCode.NullText = "";
            this.repLKItemCode.ValueMember = "ItemCode";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colLossAllowRate,
            this.colDescription});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colStartDate
            // 
            this.colStartDate.Caption = "Ngày bắt đầu";
            this.colStartDate.DisplayFormat.FormatString = "d";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 0;
            this.colStartDate.Width = 109;
            // 
            // colLossAllowRate
            // 
            this.colLossAllowRate.Caption = "Tỉ lệ(%)";
            this.colLossAllowRate.ColumnEdit = this.txtLossAllowRate;
            this.colLossAllowRate.FieldName = "LossAllowRate";
            this.colLossAllowRate.Name = "colLossAllowRate";
            this.colLossAllowRate.Visible = true;
            this.colLossAllowRate.VisibleIndex = 1;
            this.colLossAllowRate.Width = 109;
            // 
            // txtLossAllowRate
            // 
            this.txtLossAllowRate.AutoHeight = false;
            this.txtLossAllowRate.DisplayFormat.FormatString = "p";
            this.txtLossAllowRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtLossAllowRate.Mask.EditMask = "p";
            this.txtLossAllowRate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtLossAllowRate.Name = "txtLossAllowRate";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 594;
            // 
            // FormListTransportLossAllow
            // 
            this.ClientSize = new System.Drawing.Size(889, 373);
            this.Controls.Add(this.gridControl1);
            this.GridControl = this.gridControl1;
            this.Name = "FormListTransportLossAllow";
            this.Text = "Quy định hao hụt vận chuyển";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKTransportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKTransportItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLKItemCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLossAllowRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLossAllowRate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtLossAllowRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLKTransportType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLKTransportItemType;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLKItemCode;
    }
}
