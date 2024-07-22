namespace VNS.ERP.GUI.KCS
{
    partial class FormEditMaterialTestTransaction
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
            this.ucMaterialTestTransaction1 = new UCMaterialTestTransaction();
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
            // ucMaterialTestTransaction1
            // 
            this.ucMaterialTestTransaction1.Business = null;
            this.ucMaterialTestTransaction1.DataSource = null;
            this.ucMaterialTestTransaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMaterialTestTransaction1.Location = new System.Drawing.Point(0, 42);
            this.ucMaterialTestTransaction1.Name = "ucMaterialTestTransaction1";
            this.ucMaterialTestTransaction1.Size = new System.Drawing.Size(833, 366);
            this.ucMaterialTestTransaction1.TabIndex = 5;
            // 
            // FormEditMaterialTestTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(833, 431);
            this.Controls.Add(this.ucMaterialTestTransaction1);
            this.EditControl = this.ucMaterialTestTransaction1;
            this.Name = "FormEditMaterialTestTransaction";
            this.Text = "Phiếu kiểm nguyên liệu";
            this.Controls.SetChildIndex(this.ucMaterialTestTransaction1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCMaterialTestTransaction ucMaterialTestTransaction1;
    }
}
