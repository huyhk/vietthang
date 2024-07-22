namespace VNS.ERP.GUI
{
    partial class FormInstrumentTransaction
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
            this.ucInstrumentTransactionAccount1 = new VNS.ERP.GUI.UserControl.UCInstrumentTransactionAccount();
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
            // ucInstrumentTransactionAccount1
            // 
            this.ucInstrumentTransactionAccount1.AccountTransactionTypeCode = null;
            this.ucInstrumentTransactionAccount1.Business = null;
            this.ucInstrumentTransactionAccount1.DataSource = null;
            this.ucInstrumentTransactionAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInstrumentTransactionAccount1.Location = new System.Drawing.Point(0, 42);
            this.ucInstrumentTransactionAccount1.Name = "ucInstrumentTransactionAccount1";
            this.ucInstrumentTransactionAccount1.Size = new System.Drawing.Size(912, 362);
            this.ucInstrumentTransactionAccount1.TabIndex = 5;
            // 
            // FormInstrumentTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 427);
            this.Controls.Add(this.ucInstrumentTransactionAccount1);
            this.EditControl = this.ucInstrumentTransactionAccount1;
            this.Name = "FormInstrumentTransaction";
            this.Text = "FormInstrumentTransaction";
            this.Controls.SetChildIndex(this.ucInstrumentTransactionAccount1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControl.UCInstrumentTransactionAccount ucInstrumentTransactionAccount1;
    }
}