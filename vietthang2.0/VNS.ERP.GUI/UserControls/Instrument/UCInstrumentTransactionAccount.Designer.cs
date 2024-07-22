namespace VNS.ERP.GUI.UserControl
{
    partial class UCInstrumentTransactionAccount
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageCCDC = new System.Windows.Forms.TabPage();
            this.ucInstrumentTransaction1 = new VNS.ERP.GUI.UserControl.UCInstrumentTransaction();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCCDC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageCCDC);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 540);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chứng từ kế toán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageCCDC
            // 
            this.tabPageCCDC.Controls.Add(this.ucInstrumentTransaction1);
            this.tabPageCCDC.Location = new System.Drawing.Point(4, 22);
            this.tabPageCCDC.Name = "tabPageCCDC";
            this.tabPageCCDC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCCDC.Size = new System.Drawing.Size(729, 514);
            this.tabPageCCDC.TabIndex = 1;
            this.tabPageCCDC.Text = "Công cụ dụng cụ";
            this.tabPageCCDC.UseVisualStyleBackColor = true;
            // 
            // ucInstrumentTransaction1
            // 
            this.ucInstrumentTransaction1.Business = null;
            this.ucInstrumentTransaction1.DataSource = null;
            this.ucInstrumentTransaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInstrumentTransaction1.Location = new System.Drawing.Point(3, 3);
            this.ucInstrumentTransaction1.Name = "ucInstrumentTransaction1";
            this.ucInstrumentTransaction1.Size = new System.Drawing.Size(723, 508);
            this.ucInstrumentTransaction1.TabIndex = 0;
            this.ucInstrumentTransaction1.TransactionType = null;
            // 
            // UCInstrumentTransactionAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCInstrumentTransactionAccount";
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCCDC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageCCDC;
        private UCInstrumentTransaction ucInstrumentTransaction1;
    }
}
