namespace VNS.ERP.GUI
{
    partial class FormProductFormula2
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
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFormulaCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucProductFormula21 = new VNS.ERP.GUI.UserControls.UCProductFormula2();
            this.colUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(2, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(375, 443);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductCode,
            this.colProductName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "Mã thành phẩm";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            this.colProductCode.Width = 102;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Tên thành phẩm";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            this.colProductName.Width = 133;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(383, 42);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.ShowOnlyPredefinedDetails = true;
            this.gridControl2.Size = new System.Drawing.Size(568, 186);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFormulaCode,
            this.colDescription,
            this.colIsActive,
            this.colUserCreated});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colFormulaCode
            // 
            this.colFormulaCode.Caption = "Mã công thức";
            this.colFormulaCode.FieldName = "FormulaCode";
            this.colFormulaCode.Name = "colFormulaCode";
            this.colFormulaCode.Visible = true;
            this.colFormulaCode.VisibleIndex = 0;
            this.colFormulaCode.Width = 111;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 309;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Đang sử dụng";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 2;
            this.colIsActive.Width = 90;
            // 
            // ucProductFormula21
            // 
            this.ucProductFormula21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductFormula21.Location = new System.Drawing.Point(380, 234);
            this.ucProductFormula21.Name = "ucProductFormula21";
            this.ucProductFormula21.ProductCode = "";
            this.ucProductFormula21.Size = new System.Drawing.Size(577, 254);
            this.ucProductFormula21.TabIndex = 7;
            // 
            // colUserCreated
            // 
            this.colUserCreated.Caption = "Người tạo";
            this.colUserCreated.FieldName = "UserCreated";
            this.colUserCreated.Name = "colUserCreated";
            // 
            // FormProductFormula2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 518);
            this.Controls.Add(this.ucProductFormula21);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.EditControl = this.ucProductFormula21;
            this.GridControl = this.gridControl2;
            this.Name = "FormProductFormula2";
            this.Text = "FormProductFormula2";
            this.Shown += new System.EventHandler(this.FormProductFormula2_Shown);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.gridControl2, 0);
            this.Controls.SetChildIndex(this.ucProductFormula21, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colFormulaCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private VNS.ERP.GUI.UserControls.UCProductFormula2 ucProductFormula21;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreated;
    }
}