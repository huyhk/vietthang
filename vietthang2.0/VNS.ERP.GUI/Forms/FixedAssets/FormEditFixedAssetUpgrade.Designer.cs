namespace VNS.ERP.GUI.Accounting
{
    partial class FormEditFixedAssetUpgrade
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucFixedAssetUpgrade1 = new VNS.ERP.GUI.UCFixedAssetUpgrade();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucFixedAssetUpgrade1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 508);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ucFixedAssetUpgrade1
            // 
            this.ucFixedAssetUpgrade1.AccountTransactionTypeCode = null;
            this.ucFixedAssetUpgrade1.Business = null;
            this.ucFixedAssetUpgrade1.DataSource = null;
            this.ucFixedAssetUpgrade1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFixedAssetUpgrade1.Location = new System.Drawing.Point(3, 3);
            this.ucFixedAssetUpgrade1.Name = "ucFixedAssetUpgrade1";
            this.ucFixedAssetUpgrade1.Size = new System.Drawing.Size(786, 502);
            this.ucFixedAssetUpgrade1.TabIndex = 0;
            // 
            // FormEditFixedAssetUpgrade
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucFixedAssetUpgrade1;
            this.Name = "FormEditFixedAssetUpgrade";
            this.Text = "FormEditFixedAssetUpgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditFixedAssetUpgrade_FormClosing);
            this.Load += new System.EventHandler(this.FormEditFixedAssetUpgrade_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCFixedAssetUpgrade ucFixedAssetUpgrade1;
    }
}