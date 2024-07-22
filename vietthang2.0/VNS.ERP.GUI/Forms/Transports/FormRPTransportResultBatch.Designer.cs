namespace VNS.ERP.GUI.Transports
{
    partial class FormRPTransportResultBatch
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
            this.ucDatePeriodSelection1 = new VNS.Windows.UserControls.UCDatePeriodSelection();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
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
            // ucDatePeriodSelection1
            // 
            this.ucDatePeriodSelection1.Location = new System.Drawing.Point(1, 2);
            this.ucDatePeriodSelection1.Name = "ucDatePeriodSelection1";
            this.ucDatePeriodSelection1.Size = new System.Drawing.Size(401, 62);
            this.ucDatePeriodSelection1.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(276, 81);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(90, 42);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Xem báo cáo";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // FormRPTransportResultBatch
            // 
            this.ClientSize = new System.Drawing.Size(405, 142);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.ucDatePeriodSelection1);
            this.Name = "FormRPTransportResultBatch";
            this.Text = "Form theo dõi hàng cont";
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VNS.Windows.UserControls.UCDatePeriodSelection ucDatePeriodSelection1;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
    }
}
