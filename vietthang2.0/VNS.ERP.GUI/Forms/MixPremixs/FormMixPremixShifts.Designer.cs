namespace VNS.ERP.GUI
{
    partial class FormMixPremixShifts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucMixPremixShifts1 = new VNS.ERP.GUI.UserControls.UCMixPremixShifts();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 308);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ucMixPremixShifts1);
            this.groupBox1.Location = new System.Drawing.Point(166, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ucMixPremixShifts1
            // 
            this.ucMixPremixShifts1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucMixPremixShifts1.BackColor = System.Drawing.Color.Transparent;
            this.ucMixPremixShifts1.Business = null;
            this.ucMixPremixShifts1.DataSource = null;
            this.ucMixPremixShifts1.Location = new System.Drawing.Point(13, 22);
            this.ucMixPremixShifts1.Name = "ucMixPremixShifts1";
            this.ucMixPremixShifts1.Size = new System.Drawing.Size(363, 116);
            this.ucMixPremixShifts1.TabIndex = 0;
            // 
            // FormMixPremixShifts
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucMixPremixShifts1;
            this.Name = "FormMixPremixShifts";
            this.Text = "FormMixPremixShifts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMixPremixShifts_FormClosing);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private VNS.ERP.GUI.UserControls.UCMixPremixShifts ucMixPremixShifts1;
    }
}