namespace VNS.ERP.GUI.UserControls
{
    partial class UCAccountTransactionStock1
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
            this.tCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucAccTransStock = new VNS.ERP.GUI.UserControls.UCAccountTransactionStock();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.tCtrl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(705, 422);
            // 
            // tCtrl
            // 
            this.tCtrl.Controls.Add(this.tabPage1);
            this.tCtrl.Controls.Add(this.tabPage2);
            this.tCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtrl.Location = new System.Drawing.Point(0, 0);
            this.tCtrl.Name = "tCtrl";
            this.tCtrl.SelectedIndex = 0;
            this.tCtrl.Size = new System.Drawing.Size(705, 422);
            this.tCtrl.TabIndex = 3;
            this.tCtrl.SelectedIndexChanged += new System.EventHandler(this.tCtrl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage3";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucAccTransStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucAccTransStock
            // 
            this.ucAccTransStock.AccountTransactionTypeCode = null;
            this.ucAccTransStock.chkGetFromStockTransactionCheckedValue = false;
            this.ucAccTransStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAccTransStock.Location = new System.Drawing.Point(3, 3);
            this.ucAccTransStock.Name = "ucAccTransStock";
            this.ucAccTransStock.Size = new System.Drawing.Size(691, 390);
            this.ucAccTransStock.StockTransactionTypeCode = null;
            this.ucAccTransStock.TabIndex = 0;
            // 
            // UCAccountTransactionStock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tCtrl);
            this.Name = "UCAccountTransactionStock1";
            this.Size = new System.Drawing.Size(705, 422);
            this.Load += new System.EventHandler(this.UCAccountTransactionStock1_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.tCtrl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.tCtrl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UCAccountTransactionStock ucAccTransStock;
        //private System.Windows.Forms.TabControl TCtrl;
        //private System.Windows.Forms.TabPage tabPage1;
        //private System.Windows.Forms.TabPage tabPage2;
        //private VNS.ERP.GUI.UserControls.UCAccountTransactionStock ucAccTransStock;

        #endregion
    }
}
