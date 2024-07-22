namespace VNS.ERP.GUI.KCS
{
    partial class FormMaterialQualityStandards
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
            this.gridControlItems = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMaterialQualityStandarts = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpTechName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCoditionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpConditionType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colValueString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ucMaterialQualityStandards1 = new VNS.ERP.GUI.UCMaterialQualityStandards();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialQualityStandarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpConditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlMaterialQualityStandarts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucMaterialQualityStandards1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 316);
            this.tableLayoutPanel1.TabIndex = 5;
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
            this.gridControlItems.Size = new System.Drawing.Size(237, 200);
            this.gridControlItems.TabIndex = 2;
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
            // gridControlMaterialQualityStandarts
            // 
            this.gridControlMaterialQualityStandarts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControlMaterialQualityStandarts, 2);
            this.gridControlMaterialQualityStandarts.EmbeddedNavigator.Name = "";
            this.gridControlMaterialQualityStandarts.Location = new System.Drawing.Point(246, 3);
            this.gridControlMaterialQualityStandarts.MainView = this.gridView2;
            this.gridControlMaterialQualityStandarts.Name = "gridControlMaterialQualityStandarts";
            this.gridControlMaterialQualityStandarts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpTechName,
            this.lookUpConditionType,
            this.repDecimal,
            this.repPercent,
            this.repText});
            this.gridControlMaterialQualityStandarts.Size = new System.Drawing.Size(562, 200);
            this.gridControlMaterialQualityStandarts.TabIndex = 3;
            this.gridControlMaterialQualityStandarts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStartDate,
            this.colTechName,
            this.colCoditionType,
            this.colValueString,
            this.colDescription,
            this.colDateCreated,
            this.colUserCreated,
            this.colDateUpdated,
            this.colUserUpdated});
            this.gridView2.GridControl = this.gridControlMaterialQualityStandarts;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTechName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colStartDate, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView2_CustomRowCellEdit);
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
            this.colStartDate.Width = 124;
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
            // colCoditionType
            // 
            this.colCoditionType.Caption = "Điều kiện";
            this.colCoditionType.ColumnEdit = this.lookUpConditionType;
            this.colCoditionType.FieldName = "ConditionType";
            this.colCoditionType.Name = "colCoditionType";
            this.colCoditionType.Visible = true;
            this.colCoditionType.VisibleIndex = 1;
            this.colCoditionType.Width = 151;
            // 
            // lookUpConditionType
            // 
            this.lookUpConditionType.AutoHeight = false;
            this.lookUpConditionType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpConditionType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpConditionType.Name = "lookUpConditionType";
            // 
            // colValueString
            // 
            this.colValueString.Caption = "Giá trị";
            this.colValueString.ColumnEdit = this.repText;
            this.colValueString.FieldName = "ValueString";
            this.colValueString.Name = "colValueString";
            this.colValueString.Visible = true;
            this.colValueString.VisibleIndex = 2;
            this.colValueString.Width = 121;
            // 
            // repText
            // 
            this.repText.AutoHeight = false;
            this.repText.Name = "repText";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 3;
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
            // repDecimal
            // 
            this.repDecimal.AutoHeight = false;
            this.repDecimal.Mask.EditMask = "n2";
            this.repDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.repDecimal.Name = "repDecimal";
            // 
            // repPercent
            // 
            this.repPercent.AutoHeight = false;
            this.repPercent.Mask.EditMask = "p";
            this.repPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repPercent.Mask.UseMaskAsDisplayFormat = true;
            this.repPercent.Name = "repPercent";
            // 
            // ucMaterialQualityStandards1
            // 
            this.ucMaterialQualityStandards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMaterialQualityStandards1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucMaterialQualityStandards1, 2);
            this.ucMaterialQualityStandards1.DataSource = null;
            this.ucMaterialQualityStandards1.ItemCode = "";
            this.ucMaterialQualityStandards1.Location = new System.Drawing.Point(3, 209);
            this.ucMaterialQualityStandards1.Name = "ucMaterialQualityStandards1";
            this.ucMaterialQualityStandards1.Size = new System.Drawing.Size(480, 104);
            this.ucMaterialQualityStandards1.TabIndex = 0;
            // 
            // FormMaterialQualityStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 393);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucMaterialQualityStandards1;
            this.GridControl = this.gridControlMaterialQualityStandarts;
            this.Name = "FormMaterialQualityStandards";
            this.Text = "FormMaterialQualityStandards";
            this.Load += new System.EventHandler(this.FormMaterialQualityStandards_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialQualityStandarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTechName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpConditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCMaterialQualityStandards ucMaterialQualityStandards1;
        private DevExpress.XtraGrid.GridControl gridControlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.GridControl gridControlMaterialQualityStandarts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTechName;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpTechName;
        private DevExpress.XtraGrid.Columns.GridColumn colCoditionType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpConditionType;
        private DevExpress.XtraGrid.Columns.GridColumn colValueString;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDateUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn colUserUpdated;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repText;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repPercent;
    }
}