namespace VNS.Windows.Forms
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTerm = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cboFields = new System.Windows.Forms.ToolStripComboBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSearchNext = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnSelect = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            // grdSearch
            // 
            this.grdSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grdSearch.EmbeddedNavigator.Name = "";
            this.grdSearch.Location = new System.Drawing.Point(0, 25);
            this.grdSearch.MainView = this.gridView1;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(596, 238);
            this.grdSearch.TabIndex = 1;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grdSearch_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearch;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowFilterPanel = false;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtTerm,
            this.toolStripLabel2,
            this.cboFields,
            this.btnSearch,
            this.btnSearchNext,
            this.btnClose,
            this.btnSelect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(596, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Search text";
            // 
            // txtTerm
            // 
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel2.Text = "Search Column";
            // 
            // cboFields
            // 
            this.cboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFields.Name = "cboFields";
            this.cboFields.Size = new System.Drawing.Size(121, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 22);
            this.btnSearch.Text = "Find";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchNext
            // 
            this.btnSearchNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchNext.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchNext.Image")));
            this.btnSearchNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchNext.Name = "btnSearchNext";
            this.btnSearchNext.Size = new System.Drawing.Size(57, 22);
            this.btnSearchNext.Text = "Find Next";
            this.btnSearchNext.Click += new System.EventHandler(this.btnSearchNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(40, 22);
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 263);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearch";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormSearch_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTerm;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cboFields;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSelect;
        private System.Windows.Forms.ToolStripButton btnSearchNext;
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}