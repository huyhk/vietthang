namespace VNS.ERP.GUI.UserControls.Transports
{
    partial class UCTransportContractDetentionPrice
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
            this.lbDate = new System.Windows.Forms.Label();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransportType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpTransportType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDetentionPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTransportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(5, 11);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(75, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Ngày bắt đầu:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.EditValue = new System.DateTime(2009, 3, 14, 0, 0, 0, 0);
            this.txtStartDate.EnterMoveNextControl = true;
            this.txtStartDate.Location = new System.Drawing.Point(84, 8);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Size = new System.Drawing.Size(102, 20);
            this.txtStartDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ghi chú:";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 65);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpTransportType,
            this.repTxtPrice});
            this.gridControl1.Size = new System.Drawing.Size(432, 237);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransportType,
            this.colDetentionPrice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTransportType
            // 
            this.colTransportType.Caption = "Loại vận chuyển";
            this.colTransportType.ColumnEdit = this.repLookUpTransportType;
            this.colTransportType.FieldName = "TransportType";
            this.colTransportType.Name = "colTransportType";
            this.colTransportType.Visible = true;
            this.colTransportType.VisibleIndex = 0;
            this.colTransportType.Width = 250;
            // 
            // repLookUpTransportType
            // 
            this.repLookUpTransportType.AutoHeight = false;
            this.repLookUpTransportType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpTransportType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeCode", "Mã", 100),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Tên", 126)});
            this.repLookUpTransportType.DisplayMember = "TypeName";
            this.repLookUpTransportType.Name = "repLookUpTransportType";
            this.repLookUpTransportType.NullText = "";
            this.repLookUpTransportType.PopupWidth = 226;
            this.repLookUpTransportType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repLookUpTransportType.ValueMember = "TypeCode";
            // 
            // colDetentionPrice
            // 
            this.colDetentionPrice.Caption = "Giá lưu phương tiện";
            this.colDetentionPrice.ColumnEdit = this.repTxtPrice;
            this.colDetentionPrice.DisplayFormat.FormatString = "n2";
            this.colDetentionPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDetentionPrice.FieldName = "DetentionPrice";
            this.colDetentionPrice.Name = "colDetentionPrice";
            this.colDetentionPrice.OptionsColumn.AllowSize = false;
            this.colDetentionPrice.Visible = true;
            this.colDetentionPrice.VisibleIndex = 1;
            this.colDetentionPrice.Width = 125;
            // 
            // repTxtPrice
            // 
            this.repTxtPrice.AutoHeight = false;
            this.repTxtPrice.Mask.EditMask = "n2";
            this.repTxtPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repTxtPrice.Name = "repTxtPrice";
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(84, 37);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 200;
            this.txtDescription.Size = new System.Drawing.Size(320, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // UCTransportContractDetentionPrice
            // 
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.lbDate);
            this.Name = "UCTransportContractDetentionPrice";
            this.Size = new System.Drawing.Size(438, 302);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpTransportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpTransportType;
        private DevExpress.XtraGrid.Columns.GridColumn colDetentionPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtPrice;
    }
}
