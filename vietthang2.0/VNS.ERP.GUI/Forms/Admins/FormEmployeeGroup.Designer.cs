namespace VNS.ERP.GUI
{
    partial class FormEmployeeGroup
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
            this.gridControlTitle = new DevExpress.XtraGrid.GridControl();
            this.gridViewTitle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnumID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemLookUpText = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEnumName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucEmployeeGroup1 = new VNS.ERP.GUI.UCEmployeeGroup();
            this.grboxEmployeeGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.grboxEmployeeGroup.SuspendLayout();
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
            // gridControlTitle
            // 
            this.gridControlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTitle.EmbeddedNavigator.Name = "";
            this.gridControlTitle.Location = new System.Drawing.Point(3, 3);
            this.gridControlTitle.MainView = this.gridViewTitle;
            this.gridControlTitle.Name = "gridControlTitle";
            this.gridControlTitle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemLookUpText});
            this.gridControlTitle.Size = new System.Drawing.Size(683, 201);
            this.gridControlTitle.TabIndex = 0;
            this.gridControlTitle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTitle,
            this.gridView2});
            // 
            // gridViewTitle
            // 
            this.gridViewTitle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnumID,
            this.colEnumName});
            this.gridViewTitle.GridControl = this.gridControlTitle;
            this.gridViewTitle.GroupCount = 1;
            this.gridViewTitle.Name = "gridViewTitle";
            this.gridViewTitle.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewTitle.OptionsBehavior.Editable = false;
            this.gridViewTitle.OptionsCustomization.AllowFilter = false;
            this.gridViewTitle.OptionsCustomization.AllowSort = false;
            this.gridViewTitle.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewTitle.OptionsView.ShowFooter = true;
            this.gridViewTitle.OptionsView.ShowGroupPanel = false;
            this.gridViewTitle.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEnumID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewTitle.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewTitle_FocusedRowChanged);
            // 
            // colEnumID
            // 
            this.colEnumID.ColumnEdit = this.ItemLookUpText;
            this.colEnumID.FieldName = "EnumID";
            this.colEnumID.Name = "colEnumID";
            this.colEnumID.Visible = true;
            this.colEnumID.VisibleIndex = 0;
            // 
            // ItemLookUpText
            // 
            this.ItemLookUpText.AutoHeight = false;
            this.ItemLookUpText.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpText.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.ItemLookUpText.DisplayMember = "EnumText";
            this.ItemLookUpText.Name = "ItemLookUpText";
            this.ItemLookUpText.NullText = "";
            this.ItemLookUpText.PopupWidth = 300;
            this.ItemLookUpText.ShowHeader = false;
            this.ItemLookUpText.ValueMember = "EnumID";
            // 
            // colEnumName
            // 
            this.colEnumName.Caption = "EnumText";
            this.colEnumName.FieldName = "EnumText";
            this.colEnumName.Name = "colEnumName";
            this.colEnumName.Visible = true;
            this.colEnumName.VisibleIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlTitle;
            this.gridView2.Name = "gridView2";
            // 
            // ucEmployeeGroup1
            // 
            this.ucEmployeeGroup1.Business = null;
            this.ucEmployeeGroup1.DataSource = null;
            this.ucEmployeeGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmployeeGroup1.Location = new System.Drawing.Point(3, 17);
            this.ucEmployeeGroup1.Name = "ucEmployeeGroup1";
            this.ucEmployeeGroup1.Size = new System.Drawing.Size(677, 248);
            this.ucEmployeeGroup1.TabIndex = 1;
            // 
            // grboxEmployeeGroup
            // 
            this.grboxEmployeeGroup.Controls.Add(this.ucEmployeeGroup1);
            this.grboxEmployeeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grboxEmployeeGroup.Location = new System.Drawing.Point(3, 210);
            this.grboxEmployeeGroup.Name = "grboxEmployeeGroup";
            this.grboxEmployeeGroup.Size = new System.Drawing.Size(683, 268);
            this.grboxEmployeeGroup.TabIndex = 2;
            this.grboxEmployeeGroup.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grboxEmployeeGroup, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 481);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FormEmployeeGroup
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucEmployeeGroup1;
            this.MaximizeBox = false;
            this.Name = "FormEmployeeGroup";
            this.Text = "FormEmployeeGroup";
            this.Load += new System.EventHandler(this.FormEmployeeGroup_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.grboxEmployeeGroup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTitle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTitle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private UCEmployeeGroup ucEmployeeGroup1;
        private System.Windows.Forms.GroupBox grboxEmployeeGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colEnumID;
        private DevExpress.XtraGrid.Columns.GridColumn colEnumName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ItemLookUpText;
    }
}