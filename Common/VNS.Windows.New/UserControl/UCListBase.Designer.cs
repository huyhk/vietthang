namespace VNS.Windows.Controls
{
    partial class UCListBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListBase));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannelHeader = new DevExpress.XtraEditors.ButtonEdit();
            this.localeControllerUC = new VNS.Windows.LocaleController();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pannelHeader.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewItem,
            this.mnuEditItem,
            this.mnuNewItem,
            this.mnuDeleteItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
            // 
            // mnuViewItem
            // 
            this.mnuViewItem.Name = "mnuViewItem";
            this.mnuViewItem.Size = new System.Drawing.Size(139, 22);
            this.mnuViewItem.Text = "View item";
            this.mnuViewItem.Click += new System.EventHandler(this.mnuViewItem_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.Image = global::VNS.Windows.Properties.Resources.edit16;
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(139, 22);
            this.mnuEditItem.Text = "Edit item";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // mnuNewItem
            // 
            this.mnuNewItem.Image = global::VNS.Windows.Properties.Resources.add2;
            this.mnuNewItem.Name = "mnuNewItem";
            this.mnuNewItem.Size = new System.Drawing.Size(139, 22);
            this.mnuNewItem.Text = "New item";
            this.mnuNewItem.Click += new System.EventHandler(this.mnuNewItem_Click);
            // 
            // mnuDeleteItem
            // 
            this.mnuDeleteItem.Image = global::VNS.Windows.Properties.Resources.selection_delete;
            this.mnuDeleteItem.Name = "mnuDeleteItem";
            this.mnuDeleteItem.Size = new System.Drawing.Size(139, 22);
            this.mnuDeleteItem.Text = "Delete item";
            this.mnuDeleteItem.Click += new System.EventHandler(this.mnuDeleteItem_Click);
            // 
            // pannelHeader
            // 
            this.pannelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelHeader.EditValue = "";
            this.pannelHeader.EnterMoveNextControl = true;
            this.pannelHeader.Location = new System.Drawing.Point(0, 0);
            this.pannelHeader.Name = "pannelHeader";
            this.pannelHeader.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pannelHeader.Properties.Appearance.Options.UseFont = true;
            this.pannelHeader.Properties.Appearance.Options.UseTextOptions = true;
            this.pannelHeader.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.pannelHeader.Properties.AutoHeight = false;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject1.Options.UseTextOptions = true;
            serializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.pannelHeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Near, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Near, ((System.Drawing.Image)(resources.GetObject("pannelHeader.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Thêm mới", "1"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Center, global::VNS.Windows.Properties.Resources.edit16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Sửa", "2"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 30, true, true, false, DevExpress.Utils.HorzAlignment.Center, global::VNS.Windows.Properties.Resources.selection_delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Xóa", "3"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 10, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.pannelHeader.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.pannelHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pannelHeader.Size = new System.Drawing.Size(625, 27);
            this.pannelHeader.TabIndex = 1;
            this.pannelHeader.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.pannelHeader_ButtonClick);
            // 
            // localeControllerUC
            // 
            this.localeControllerUC.Parent = this;
            // 
            // UCListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pannelHeader);
            this.Name = "UCListBase";
            this.Size = new System.Drawing.Size(625, 378);
            this.Load += new System.EventHandler(this.UCListBase_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pannelHeader.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuViewItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteItem;
        protected LocaleController localeControllerUC;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewItem;
        private DevExpress.XtraEditors.ButtonEdit pannelHeader;
    }
}
