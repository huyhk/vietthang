namespace VNS.ERP.GUI.Manufactures
{
    partial class FormEditManufactures
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
            this.UCManufactures1 = new VNS.ERP.GUI.Manufactures.UCManufactures();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
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
            // UCManufactures1
            // 
            this.UCManufactures1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCManufactures1.Location = new System.Drawing.Point(0, 42);
            this.UCManufactures1.Name = "UCManufactures1";
            this.UCManufactures1.Size = new System.Drawing.Size(927, 511);
            this.UCManufactures1.TabIndex = 5;
            // 
            // FormEditManufactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 578);
            this.Controls.Add(this.UCManufactures1);
            this.EditControl = this.UCManufactures1;
            this.Name = "FormEditManufactures";
            this.Text = "Edit Manufactures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditManufactures_FormClosing);
            this.Controls.SetChildIndex(this.UCManufactures1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      private UCManufactures UCManufactures1;
    }
}