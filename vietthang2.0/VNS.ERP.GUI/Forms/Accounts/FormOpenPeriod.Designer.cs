namespace VNS.ERP.GUI
{
    partial class FormOpenPeriod
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenPeriod = new System.Windows.Forms.Button();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenPeriod
            // 
            this.btnOpenPeriod.Location = new System.Drawing.Point(80, 28);
            this.btnOpenPeriod.Name = "btnOpenPeriod";
            this.btnOpenPeriod.Size = new System.Drawing.Size(63, 20);
            this.btnOpenPeriod.TabIndex = 6;
            this.btnOpenPeriod.Text = "Mở sổ";
            this.btnOpenPeriod.UseVisualStyleBackColor = true;
            this.btnOpenPeriod.Click += new System.EventHandler(this.btnOpenPeriod_Click);
            // 
            // lbPeriod
            // 
            this.lbPeriod.Location = new System.Drawing.Point(2, 3);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(72, 18);
            this.lbPeriod.TabIndex = 5;
            this.lbPeriod.Text = "Kỳ kế toán";
            this.lbPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lookUpPeriod
            // 
            this.lookUpPeriod.Location = new System.Drawing.Point(80, 4);
            this.lookUpPeriod.Name = "lookUpPeriod";
            this.lookUpPeriod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPeriod.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description")});
            this.lookUpPeriod.Properties.DisplayMember = "Description";
            this.lookUpPeriod.Properties.NullText = "";
            this.lookUpPeriod.Properties.ShowHeader = false;
            this.lookUpPeriod.Properties.ValueMember = "PeriodCode";
            this.lookUpPeriod.Size = new System.Drawing.Size(219, 20);
            this.lookUpPeriod.TabIndex = 4;
            // 
            // FormOpenPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 53);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenPeriod);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.lookUpPeriod);
            this.Name = "FormOpenPeriod";
            this.Text = "Mở sổ";
            this.Load += new System.EventHandler(this.FormOpenPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenPeriod;
        private System.Windows.Forms.Label lbPeriod;
        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
    }
}