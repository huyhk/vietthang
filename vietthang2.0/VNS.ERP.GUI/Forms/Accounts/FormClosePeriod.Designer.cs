namespace VNS.ERP.GUI
{
    partial class FormClosePeriod
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
            this.lookUpPeriod = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClosePeriod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // lookUpPeriod
            // 
            this.lookUpPeriod.Location = new System.Drawing.Point(78, 3);
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
            this.lookUpPeriod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kỳ kế toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClosePeriod
            // 
            this.btnClosePeriod.Location = new System.Drawing.Point(78, 27);
            this.btnClosePeriod.Name = "btnClosePeriod";
            this.btnClosePeriod.Size = new System.Drawing.Size(63, 20);
            this.btnClosePeriod.TabIndex = 2;
            this.btnClosePeriod.Text = "Khoá sổ";
            this.btnClosePeriod.UseVisualStyleBackColor = true;
            this.btnClosePeriod.Click += new System.EventHandler(this.btnClosePeriod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormClosePeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 53);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClosePeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpPeriod);
            this.Name = "FormClosePeriod";
            this.Text = "Khoá sổ";
            this.Load += new System.EventHandler(this.FormClosePeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPeriod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClosePeriod;
        private System.Windows.Forms.Button button1;
    }
}