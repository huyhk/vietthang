namespace VNS.ERP.GUI
{
    partial class FormReadCanme
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
            this.txtDBFile = new DevExpress.XtraEditors.ButtonEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnReadData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBFile.Properties)).BeginInit();
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
            // txtDBFile
            // 
            this.txtDBFile.Location = new System.Drawing.Point(221, 20);
            this.txtDBFile.Name = "txtDBFile";
            this.txtDBFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDBFile.Size = new System.Drawing.Size(381, 20);
            this.txtDBFile.TabIndex = 0;
            this.txtDBFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDBFile_ButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(221, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(103, 53);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 2;
            this.btnReadData.Text = "simpleButton1";
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // FormReadCanme
            // 
            this.ClientSize = new System.Drawing.Size(697, 344);
            this.Controls.Add(this.btnReadData);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDBFile);
            this.Name = "FormReadCanme";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDBFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit txtDBFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnReadData;
    }
}
