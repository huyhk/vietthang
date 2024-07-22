namespace VNS.ERP.GUI
{
    partial class FormMainBase
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblDBServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDBServer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 241);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(279, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 241);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(279, 241);
            this.treeView1.TabIndex = 9;
            // 
            // lblDBServer
            // 
            this.lblDBServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBServer.ForeColor = System.Drawing.Color.Navy;
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(27, 17);
            this.lblDBServer.Text = "abc";
            this.lblDBServer.DoubleClick += new System.EventHandler(this.lblDBServer_DoubleClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(578, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // FormMainBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 263);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMainBase";
            this.ShowInTaskbar = true;
            this.Text = "FormMainBase";
            this.Activated += new System.EventHandler(this.FormMainBase_Activated);
            this.Load += new System.EventHandler(this.FormMainBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.ListView listView1;
        protected System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripStatusLabel lblDBServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}