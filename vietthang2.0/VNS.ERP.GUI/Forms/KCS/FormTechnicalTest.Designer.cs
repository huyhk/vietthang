namespace VNS.ERP.GUI.KCS
{
    partial class FormTechnicalTest
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
            this.ucTechnicalTest1 = new VNS.ERP.GUI.UCTechnicalTest();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResultType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpResultType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOderBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.clmKCSTest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPTNTest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpResultType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            // ucTechnicalTest1
            // 
            this.ucTechnicalTest1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTechnicalTest1.Business = null;
            this.ucTechnicalTest1.DataSource = null;
            this.ucTechnicalTest1.Location = new System.Drawing.Point(3, 3);
            this.ucTechnicalTest1.Name = "ucTechnicalTest1";
            this.ucTechnicalTest1.Size = new System.Drawing.Size(638, 157);
            this.ucTechnicalTest1.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 166);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpResultType,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(815, 190);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTechCode,
            this.colTechName,
            this.colResultType,
            this.colDescription,
            this.colOderBy,
            this.clmKCSTest,
            this.clmPTNTest,
            this.colDisplayText});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTechCode
            // 
            this.colTechCode.Caption = "Mã chỉ tiêu";
            this.colTechCode.FieldName = "TechCode";
            this.colTechCode.Name = "colTechCode";
            this.colTechCode.Visible = true;
            this.colTechCode.VisibleIndex = 0;
            this.colTechCode.Width = 94;
            // 
            // colTechName
            // 
            this.colTechName.Caption = "Tên chỉ tiêu";
            this.colTechName.FieldName = "TechName";
            this.colTechName.Name = "colTechName";
            this.colTechName.Visible = true;
            this.colTechName.VisibleIndex = 1;
            this.colTechName.Width = 86;
            // 
            // colResultType
            // 
            this.colResultType.Caption = "Kiểu kết quả";
            this.colResultType.ColumnEdit = this.lookUpResultType;
            this.colResultType.FieldName = "ResultType";
            this.colResultType.Name = "colResultType";
            this.colResultType.Visible = true;
            this.colResultType.VisibleIndex = 2;
            this.colResultType.Width = 95;
            // 
            // lookUpResultType
            // 
            this.lookUpResultType.AutoHeight = false;
            this.lookUpResultType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpResultType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpResultType.Name = "lookUpResultType";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Diễn giải";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 243;
            // 
            // colOderBy
            // 
            this.colOderBy.Caption = "Thứ tự";
            this.colOderBy.ColumnEdit = this.repositoryItemTextEdit1;
            this.colOderBy.DisplayFormat.FormatString = "n0";
            this.colOderBy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOderBy.FieldName = "OrderBy";
            this.colOderBy.Name = "colOderBy";
            this.colOderBy.Visible = true;
            this.colOderBy.VisibleIndex = 3;
            this.colOderBy.Width = 68;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n2";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // clmKCSTest
            // 
            this.clmKCSTest.Caption = "KCS kiểm";
            this.clmKCSTest.FieldName = "KCSTest";
            this.clmKCSTest.Name = "clmKCSTest";
            this.clmKCSTest.Visible = true;
            this.clmKCSTest.VisibleIndex = 4;
            this.clmKCSTest.Width = 84;
            // 
            // clmPTNTest
            // 
            this.clmPTNTest.Caption = "PTN kiểm";
            this.clmPTNTest.FieldName = "PTNTest";
            this.clmPTNTest.Name = "clmPTNTest";
            this.clmPTNTest.Visible = true;
            this.clmPTNTest.VisibleIndex = 5;
            this.clmPTNTest.Width = 86;
            // 
            // colDisplayText
            // 
            this.colDisplayText.Caption = "DisplayText";
            this.colDisplayText.FieldName = "DisplayText";
            this.colDisplayText.Name = "colDisplayText";
            this.colDisplayText.Visible = true;
            this.colDisplayText.VisibleIndex = 6;
            this.colDisplayText.Width = 84;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.tableLayoutPanel1.Controls.Add(this.ucTechnicalTest1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 359);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // FormTechnicalTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 433);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucTechnicalTest1;
            this.GridControl = this.gridControl1;
            this.Name = "FormTechnicalTest";
            this.Text = "FormTechnicalTest";
            this.Load += new System.EventHandler(this.FormTechnicalTest_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpResultType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCTechnicalTest ucTechnicalTest1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTechCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTechName;
        private DevExpress.XtraGrid.Columns.GridColumn colResultType;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpResultType;
        private DevExpress.XtraGrid.Columns.GridColumn colOderBy;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn clmKCSTest;
        private DevExpress.XtraGrid.Columns.GridColumn clmPTNTest;
    }
}