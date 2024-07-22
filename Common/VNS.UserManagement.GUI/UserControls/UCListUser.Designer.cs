namespace VNS.UserManagement.GUI
{
    partial class UCListUser
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
            this.gridControlUser = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUser
            // 
            this.gridControlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gridControlUser.EmbeddedNavigator.Name = "";
            this.gridControlUser.Location = new System.Drawing.Point(3, 28);
            this.gridControlUser.MainView = this.gridView1;
            this.gridControlUser.Name = "gridControlUser";
            this.gridControlUser.Size = new System.Drawing.Size(619, 347);
            this.gridControlUser.TabIndex = 2;
            this.gridControlUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMemberID,
            this.colMemberName,
            this.colDescription});
            this.gridView1.GridControl = this.gridControlUser;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMemberID
            // 
            this.colMemberID.Caption = "Mã";
            this.colMemberID.FieldName = "MemberID";
            this.colMemberID.Name = "colMemberID";
            this.colMemberID.Visible = true;
            this.colMemberID.VisibleIndex = 0;
            // 
            // colMemberName
            // 
            this.colMemberName.Caption = "Tên";
            this.colMemberName.FieldName = "MemberName";
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.Visible = true;
            this.colMemberName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // UCListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.gridControlUser);
            this.GridControl = this.gridControlUser;
            this.Name = "UCListUser";
            this.Load += new System.EventHandler(this.UCListUser_Load);
            this.Controls.SetChildIndex(this.gridControlUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}
