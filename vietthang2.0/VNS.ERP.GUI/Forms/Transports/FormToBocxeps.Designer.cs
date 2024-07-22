namespace VNS.ERP.GUI.Transports
{
    partial class FormToBocxeps
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmSubjectCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmSubjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmToBocxepCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmToBocxepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucToBocxeps1 = new VNS.ERP.GUI.Transports.UCToBocxeps();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.52116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.47884F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucToBocxeps1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 410);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tableLayoutPanel1.SetRowSpan(this.gridControl1, 2);
            this.gridControl1.Size = new System.Drawing.Size(332, 404);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmSubjectCode,
            this.clmSubjectName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // clmSubjectCode
            // 
            this.clmSubjectCode.Caption = "SubjectCode";
            this.clmSubjectCode.FieldName = "SubjectCode";
            this.clmSubjectCode.Name = "clmSubjectCode";
            this.clmSubjectCode.Visible = true;
            this.clmSubjectCode.VisibleIndex = 0;
            this.clmSubjectCode.Width = 102;
            // 
            // clmSubjectName
            // 
            this.clmSubjectName.Caption = "SubjectName";
            this.clmSubjectName.FieldName = "SubjectName";
            this.clmSubjectName.Name = "clmSubjectName";
            this.clmSubjectName.Visible = true;
            this.clmSubjectName.VisibleIndex = 1;
            this.clmSubjectName.Width = 187;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(341, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(636, 305);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmToBocxepCode,
            this.clmToBocxepName,
            this.clmDescription});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // clmToBocxepCode
            // 
            this.clmToBocxepCode.Caption = "ToBocxepCode";
            this.clmToBocxepCode.FieldName = "ToBocxepCode";
            this.clmToBocxepCode.Name = "clmToBocxepCode";
            this.clmToBocxepCode.Visible = true;
            this.clmToBocxepCode.VisibleIndex = 0;
            this.clmToBocxepCode.Width = 94;
            // 
            // clmToBocxepName
            // 
            this.clmToBocxepName.Caption = "ToBocxepName";
            this.clmToBocxepName.FieldName = "ToBocxepName";
            this.clmToBocxepName.Name = "clmToBocxepName";
            this.clmToBocxepName.Visible = true;
            this.clmToBocxepName.VisibleIndex = 1;
            this.clmToBocxepName.Width = 159;
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Description";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 2;
            this.clmDescription.Width = 328;
            // 
            // ucToBocxeps1
            // 
            this.ucToBocxeps1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucToBocxeps1.Business = null;
            this.ucToBocxeps1.DataSource = null;
            this.ucToBocxeps1.Location = new System.Drawing.Point(420, 314);
            this.ucToBocxeps1.Name = "ucToBocxeps1";
            this.ucToBocxeps1.Size = new System.Drawing.Size(478, 93);
            this.ucToBocxeps1.SubjectCode = null;
            this.ucToBocxeps1.TabIndex = 2;
            // 
            // FormToBocxeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(980, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucToBocxeps1;
            this.GridControl = this.gridControl2;
            this.Name = "FormToBocxeps";
            this.Load += new System.EventHandler(this.FormToBocxeps_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
      
        private DevExpress.XtraGrid.Columns.GridColumn clmSubjectCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmSubjectName;
        private DevExpress.XtraGrid.Columns.GridColumn clmToBocxepCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmToBocxepName;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private UCToBocxeps ucToBocxeps1;
    }
}
