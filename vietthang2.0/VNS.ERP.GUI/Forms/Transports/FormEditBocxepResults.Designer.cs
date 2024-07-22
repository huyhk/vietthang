
namespace VNS.ERP.GUI.Transports
{
    partial class FormEditBocxepResults
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
            this.ucBocxepResults1 = new VNS.ERP.GUI.Transports.UCBocxepResults();
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
            // ucBocxepResults1
            // 
            this.ucBocxepResults1.Business = null;
            this.ucBocxepResults1.DataSource = null;
            this.ucBocxepResults1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBocxepResults1.Location = new System.Drawing.Point(0, 42);
            this.ucBocxepResults1.Name = "ucBocxepResults1";
            this.ucBocxepResults1.Size = new System.Drawing.Size(777, 344);
            this.ucBocxepResults1.StockCode = null;
            this.ucBocxepResults1.SubjectCode = null;
            this.ucBocxepResults1.TabIndex = 5;
            // 
            // FormEditBocxepResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 409);
            this.Controls.Add(this.ucBocxepResults1);
            this.EditControl = this.ucBocxepResults1;
            this.Name = "FormEditBocxepResults";
            this.Text = "FormEditBocxepResults";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.ucBocxepResults1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCBocxepResults ucBocxepResults1;

    }
}