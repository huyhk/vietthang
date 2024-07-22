namespace VNS.ERP.GUI
{
    partial class FormEditUynhiemchiPrint
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
            this.ucUynhiemchiPrint1 = new VNS.ERP.GUI.UserControls.UCUynhiemchiPrint();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(6, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(400, 191);
            this.gridControl1.TabIndex = 105;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ucUynhiemchiPrint1
            // 
            this.ucUynhiemchiPrint1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUynhiemchiPrint1.Location = new System.Drawing.Point(5, 242);
            this.ucUynhiemchiPrint1.Name = "ucUynhiemchiPrint1";
            this.ucUynhiemchiPrint1.Size = new System.Drawing.Size(607, 511);
            this.ucUynhiemchiPrint1.TabIndex = 106;
            // 
            // FormEditUynhiemchiPrint
            // 
            this.ClientSize = new System.Drawing.Size(617, 782);
            this.Controls.Add(this.ucUynhiemchiPrint1);
            this.Controls.Add(this.gridControl1);
            this.EditControl = this.ucUynhiemchiPrint1;
            this.GridControl = this.gridControl1;
            this.Name = "FormEditUynhiemchiPrint";
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.ucUynhiemchiPrint1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private VNS.ERP.GUI.UserControls.UCUynhiemchiPrint ucUynhiemchiPrint1;
    }
}
