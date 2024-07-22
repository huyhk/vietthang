namespace VNS.ERP.GUI
{
    partial class FormVessel
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmVesselCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmVesselName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucVessel1 = new VNS.ERP.GUI.UCVessel();
            this.clmUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmUserUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmDateUpdated = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.ucVessel1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.76624F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.23376F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(756, 355);
            this.tableLayoutPanelMain.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(750, 202);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmVesselCode,
            this.clmVesselName,
            this.clmDescription,
            this.clmUserCreated,
            this.clmDateCreated,
            this.clmUserUpdated,
            this.clmDateUpdated});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clmVesselCode
            // 
            this.clmVesselCode.Caption = "VesselCode";
            this.clmVesselCode.FieldName = "VesselCode";
            this.clmVesselCode.Name = "clmVesselCode";
            this.clmVesselCode.Visible = true;
            this.clmVesselCode.VisibleIndex = 0;
            this.clmVesselCode.Width = 100;
            // 
            // clmVesselName
            // 
            this.clmVesselName.Caption = "VesselName";
            this.clmVesselName.FieldName = "VesselName";
            this.clmVesselName.Name = "clmVesselName";
            this.clmVesselName.Visible = true;
            this.clmVesselName.VisibleIndex = 1;
            this.clmVesselName.Width = 165;
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Description";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 2;
            this.clmDescription.Width = 386;
            // 
            // ucVessel1
            // 
            this.ucVessel1.Business = null;
            this.ucVessel1.DataSource = null;
            this.ucVessel1.Location = new System.Drawing.Point(3, 211);
            this.ucVessel1.Name = "ucVessel1";
            this.ucVessel1.Size = new System.Drawing.Size(631, 105);
            this.ucVessel1.TabIndex = 1;
            // 
            // clmUserCreated
            // 
            this.clmUserCreated.Caption = "UserCreated";
            this.clmUserCreated.FieldName = "UserCreated";
            this.clmUserCreated.Name = "clmUserCreated";
            // 
            // clmDateCreated
            // 
            this.clmDateCreated.Caption = "DateCreated";
            this.clmDateCreated.FieldName = "DateCreated";
            this.clmDateCreated.Name = "clmDateCreated";
            // 
            // clmUserUpdated
            // 
            this.clmUserUpdated.Caption = "UserUpdated";
            this.clmUserUpdated.FieldName = "UserUpdated";
            this.clmUserUpdated.Name = "clmUserUpdated";
            // 
            // clmDateUpdated
            // 
            this.clmDateUpdated.Caption = "DateUpdated";
            this.clmDateUpdated.FieldName = "DateUpdated";
            this.clmDateUpdated.Name = "clmDateUpdated";
            // 
            // FormVessel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 420);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.EditControl = this.ucVessel1;
            this.GridControl = this.gridControl1;
            this.Name = "FormVessel";
            this.Text = "FormVessel";
            this.Load += new System.EventHandler(this.FormVessel_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanelMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clmVesselCode;
        private DevExpress.XtraGrid.Columns.GridColumn clmVesselName;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private UCVessel ucVessel1;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn clmDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserUpdated;
        private DevExpress.XtraGrid.Columns.GridColumn clmDateUpdated;
    }
}