namespace VNS.ERP.GUI.KCS
{
    partial class FormEditEncryptCodeReturnDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectItemEncryptCode = new DevExpress.XtraEditors.SimpleButton();
            this.gridCtrlAllItemEncryptCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewAllItemEncryptCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemEncryptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCtrlSelectedItemEncryptCode = new DevExpress.XtraGrid.GridControl();
            this.gridViewSelectedItemEncryptCode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemEncryptCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridCtrlResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reLookUpTechCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colResult1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtString = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repTxtPercent = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repTxtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlAllItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlSelectedItemEncryptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedItemEncryptCode)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpTechCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnSelectItemEncryptCode);
            this.groupBox1.Controls.Add(this.gridCtrlAllItemEncryptCode);
            this.groupBox1.Controls.Add(this.gridCtrlSelectedItemEncryptCode);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 418);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã mẫu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSelectItemEncryptCode
            // 
            this.btnSelectItemEncryptCode.Location = new System.Drawing.Point(252, 35);
            this.btnSelectItemEncryptCode.Name = "btnSelectItemEncryptCode";
            this.btnSelectItemEncryptCode.Size = new System.Drawing.Size(35, 21);
            this.btnSelectItemEncryptCode.TabIndex = 1;
            this.btnSelectItemEncryptCode.Text = ">>";
            this.btnSelectItemEncryptCode.Click += new System.EventHandler(this.btnSelectItemEncryptCode_Click);
            // 
            // gridCtrlAllItemEncryptCode
            // 
            this.gridCtrlAllItemEncryptCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlAllItemEncryptCode.EmbeddedNavigator.Name = "";
            this.gridCtrlAllItemEncryptCode.Location = new System.Drawing.Point(7, 16);
            this.gridCtrlAllItemEncryptCode.MainView = this.gridViewAllItemEncryptCode;
            this.gridCtrlAllItemEncryptCode.Name = "gridCtrlAllItemEncryptCode";
            this.gridCtrlAllItemEncryptCode.Size = new System.Drawing.Size(240, 399);
            this.gridCtrlAllItemEncryptCode.TabIndex = 0;
            this.gridCtrlAllItemEncryptCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllItemEncryptCode});
            // 
            // gridViewAllItemEncryptCode
            // 
            this.gridViewAllItemEncryptCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemEncryptCode});
            this.gridViewAllItemEncryptCode.GridControl = this.gridCtrlAllItemEncryptCode;
            this.gridViewAllItemEncryptCode.Name = "gridViewAllItemEncryptCode";
            this.gridViewAllItemEncryptCode.OptionsBehavior.Editable = false;
            this.gridViewAllItemEncryptCode.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewAllItemEncryptCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewAllItemEncryptCode.OptionsView.ShowDetailButtons = false;
            this.gridViewAllItemEncryptCode.OptionsView.ShowGroupPanel = false;
            this.gridViewAllItemEncryptCode.ColumnFilterChanged += new System.EventHandler(this.gridViewAllItemEncryptCode_ColumnFilterChanged);
            // 
            // colItemEncryptCode
            // 
            this.colItemEncryptCode.Caption = "Mã mẫu";
            this.colItemEncryptCode.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode.Name = "colItemEncryptCode";
            this.colItemEncryptCode.Visible = true;
            this.colItemEncryptCode.VisibleIndex = 0;
            this.colItemEncryptCode.Width = 174;
            // 
            // gridCtrlSelectedItemEncryptCode
            // 
            this.gridCtrlSelectedItemEncryptCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gridCtrlSelectedItemEncryptCode.EmbeddedNavigator.Name = "";
            this.gridCtrlSelectedItemEncryptCode.Location = new System.Drawing.Point(290, 16);
            this.gridCtrlSelectedItemEncryptCode.MainView = this.gridViewSelectedItemEncryptCode;
            this.gridCtrlSelectedItemEncryptCode.Name = "gridCtrlSelectedItemEncryptCode";
            this.gridCtrlSelectedItemEncryptCode.Size = new System.Drawing.Size(245, 399);
            this.gridCtrlSelectedItemEncryptCode.TabIndex = 2;
            this.gridCtrlSelectedItemEncryptCode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSelectedItemEncryptCode});
            // 
            // gridViewSelectedItemEncryptCode
            // 
            this.gridViewSelectedItemEncryptCode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemEncryptCode1});
            this.gridViewSelectedItemEncryptCode.GridControl = this.gridCtrlSelectedItemEncryptCode;
            this.gridViewSelectedItemEncryptCode.Name = "gridViewSelectedItemEncryptCode";
            this.gridViewSelectedItemEncryptCode.OptionsBehavior.Editable = false;
            this.gridViewSelectedItemEncryptCode.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewSelectedItemEncryptCode.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewSelectedItemEncryptCode.OptionsView.ColumnAutoWidth = false;
            this.gridViewSelectedItemEncryptCode.OptionsView.ShowDetailButtons = false;
            this.gridViewSelectedItemEncryptCode.OptionsView.ShowGroupPanel = false;
            this.gridViewSelectedItemEncryptCode.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSelectedItemEncryptCode_FocusedRowChanged);
            this.gridViewSelectedItemEncryptCode.ColumnFilterChanged += new System.EventHandler(this.gridViewSelectedItemEncryptCode_ColumnFilterChanged);
            this.gridViewSelectedItemEncryptCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSelectedItemEncryptCode_KeyDown);
            // 
            // colItemEncryptCode1
            // 
            this.colItemEncryptCode1.Caption = "Mã mẫu";
            this.colItemEncryptCode1.FieldName = "ItemEncryptCode";
            this.colItemEncryptCode1.Name = "colItemEncryptCode1";
            this.colItemEncryptCode1.Visible = true;
            this.colItemEncryptCode1.VisibleIndex = 0;
            this.colItemEncryptCode1.Width = 174;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gridCtrlResult);
            this.groupBox4.Location = new System.Drawing.Point(550, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 418);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết quả phân tích";
            // 
            // gridCtrlResult
            // 
            this.gridCtrlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCtrlResult.EmbeddedNavigator.Name = "";
            this.gridCtrlResult.Location = new System.Drawing.Point(6, 16);
            this.gridCtrlResult.MainView = this.gridView1;
            this.gridCtrlResult.Name = "gridCtrlResult";
            this.gridCtrlResult.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reLookUpTechCode,
            this.repTxtPercent,
            this.repTxtDecimal,
            this.repTxtString});
            this.gridCtrlResult.Size = new System.Drawing.Size(284, 399);
            this.gridCtrlResult.TabIndex = 12;
            this.gridCtrlResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTechCode1,
            this.colResult1});
            this.gridView1.GridControl = this.gridCtrlResult;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            // 
            // colTechCode1
            // 
            this.colTechCode1.Caption = "Chỉ tiêu";
            this.colTechCode1.ColumnEdit = this.reLookUpTechCode;
            this.colTechCode1.FieldName = "TechCode";
            this.colTechCode1.Name = "colTechCode1";
            this.colTechCode1.OptionsColumn.ReadOnly = true;
            this.colTechCode1.Visible = true;
            this.colTechCode1.VisibleIndex = 0;
            this.colTechCode1.Width = 111;
            // 
            // reLookUpTechCode
            // 
            this.reLookUpTechCode.AutoHeight = false;
            this.reLookUpTechCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.reLookUpTechCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode", "Mã CT", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName", "Tên CT", 200)});
            this.reLookUpTechCode.DisplayMember = "TechName";
            this.reLookUpTechCode.Name = "reLookUpTechCode";
            this.reLookUpTechCode.NullText = "";
            this.reLookUpTechCode.PopupWidth = 300;
            this.reLookUpTechCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.reLookUpTechCode.ValueMember = "TechCode";
            // 
            // colResult1
            // 
            this.colResult1.Caption = "Kết quả";
            this.colResult1.ColumnEdit = this.repTxtString;
            this.colResult1.FieldName = "Result";
            this.colResult1.Name = "colResult1";
            this.colResult1.Visible = true;
            this.colResult1.VisibleIndex = 1;
            this.colResult1.Width = 133;
            // 
            // repTxtString
            // 
            this.repTxtString.AutoHeight = false;
            this.repTxtString.Name = "repTxtString";
            // 
            // repTxtPercent
            // 
            this.repTxtPercent.AutoHeight = false;
            this.repTxtPercent.Mask.EditMask = "p";
            this.repTxtPercent.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtPercent.Mask.UseMaskAsDisplayFormat = true;
            this.repTxtPercent.Name = "repTxtPercent";
            // 
            // repTxtDecimal
            // 
            this.repTxtDecimal.AutoHeight = false;
            this.repTxtDecimal.DisplayFormat.FormatString = "#.##";
            this.repTxtDecimal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtDecimal.Name = "repTxtDecimal";
            //this.repTxtDecimal.AutoHeight = false;
            //this.repTxtDecimal.Mask.EditMask = "n2";
            //this.repTxtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //this.repTxtDecimal.Mask.UseMaskAsDisplayFormat = true;
            //this.repTxtDecimal.Name = "repTxtDecimal";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(776, 421);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(64, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FormEditEncryptCodeReturnDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(847, 447);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditEncryptCodeReturnDetail";
            this.Text = "Kể quả gửi phân tích ngoài";
            this.Load += new System.EventHandler(this.FormEditEncryptCodeReturnDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlAllItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAllItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlSelectedItemEncryptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSelectedItemEncryptCode)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reLookUpTechCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDecimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSelectItemEncryptCode;
        private DevExpress.XtraGrid.GridControl gridCtrlAllItemEncryptCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAllItemEncryptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemEncryptCode;
        private DevExpress.XtraGrid.GridControl gridCtrlSelectedItemEncryptCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSelectedItemEncryptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemEncryptCode1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl gridCtrlResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTechCode1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reLookUpTechCode;
        private DevExpress.XtraGrid.Columns.GridColumn colResult1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtString;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtPercent;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtDecimal;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}
