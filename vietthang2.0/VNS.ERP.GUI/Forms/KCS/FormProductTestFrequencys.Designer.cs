
namespace VNS.ERP.GUI.KCS
{
    partial class FormProductTestFrequencys
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repChiTieu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTanxuat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucProductTestFrequencys1 = new VNS.ERP.GUI.UCProductTestFrequencys();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTanxuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gridControl1, 2);
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repTanxuat,
            this.repChiTieu,
            this.repositoryItemLookUpEdit3});
            this.gridControl1.Size = new System.Drawing.Size(823, 284);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thành phẩm";
            this.gridColumn1.FieldName = "ProductCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 157;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Chỉ tiêu";
            this.gridColumn2.ColumnEdit = this.repChiTieu;
            this.gridColumn2.FieldName = "TechCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 89;
            // 
            // repChiTieu
            // 
            this.repChiTieu.AutoHeight = false;
            this.repChiTieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repChiTieu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TechName")});
            this.repChiTieu.DisplayMember = "TechName";
            this.repChiTieu.HideSelection = false;
            this.repChiTieu.Name = "repChiTieu";
            this.repChiTieu.NullText = "";
            this.repChiTieu.ValueMember = "TechCode";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày bắt đầu";
            this.gridColumn3.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn3.FieldName = "StartDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 141;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tần xuất";
            this.gridColumn4.ColumnEdit = this.repTanxuat;
            this.gridColumn4.FieldName = "FrequencyType";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // repTanxuat
            // 
            this.repTanxuat.AutoHeight = false;
            this.repTanxuat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTanxuat.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.repTanxuat.DisplayMember = "EnumText";
            this.repTanxuat.HideSelection = false;
            this.repTanxuat.Name = "repTanxuat";
            this.repTanxuat.NullText = "";
            this.repTanxuat.ValueMember = "EnumName";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số lượng";
            this.gridColumn5.DisplayFormat.FormatString = "n0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Quantity";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 212;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Diễn giải";
            this.gridColumn6.FieldName = "Description";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 110;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Người tạo";
            this.gridColumn7.FieldName = "UserCreated";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày tạo";
            this.gridColumn8.ColumnEdit = this.repositoryItemDateEdit2;
            this.gridColumn8.FieldName = "DateCreated";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Người sửa";
            this.gridColumn9.FieldName = "UserUpdated";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Ngày sửa";
            this.gridColumn10.FieldName = "DateUpdated";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucProductTestFrequencys1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(829, 403);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // ucProductTestFrequencys1
            // 
            this.ucProductTestFrequencys1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductTestFrequencys1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucProductTestFrequencys1, 2);
            this.ucProductTestFrequencys1.DataSource = null;
            this.ucProductTestFrequencys1.Location = new System.Drawing.Point(3, 293);
            this.ucProductTestFrequencys1.Name = "ucProductTestFrequencys1";
            this.ucProductTestFrequencys1.Size = new System.Drawing.Size(823, 107);
            this.ucProductTestFrequencys1.TabIndex = 19;
            // 
            // FormProductTestFrequencys
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.GridControl = this.gridControl1;
            this.Name = "FormProductTestFrequencys";
            this.Text = "Tần xuất kiểm tra sản phẩm";
            this.Load += new System.EventHandler(this.FormProductTestFrequencys_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repChiTieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTanxuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCProductTestFrequencys ucProductTestFrequencys1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repTanxuat;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repChiTieu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;




    }
}