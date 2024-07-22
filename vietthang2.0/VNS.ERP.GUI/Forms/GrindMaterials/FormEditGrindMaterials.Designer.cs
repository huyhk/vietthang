namespace VNS.ERP.GUI
{
    partial class FormEditGrindMaterials
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UCGrindMaterials1 = new VNS.ERP.GUI.UCGrindMaterials();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UCGrindMaterials1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.59829F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 629);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // UCGrindMaterials1
            // 
            this.UCGrindMaterials1.BackColor = System.Drawing.SystemColors.Window;
            this.UCGrindMaterials1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCGrindMaterials1.Location = new System.Drawing.Point(3, 3);
            this.UCGrindMaterials1.Name = "UCGrindMaterials1";
            this.UCGrindMaterials1.Size = new System.Drawing.Size(766, 623);
            this.UCGrindMaterials1.TabIndex = 0;
            // 
            // FormEditGrindMaterials
            // 
            this.AllowSaveAndClose = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 696);
            this.Controls.Add(this.tableLayoutPanel2);
            this.EditControl = this.UCGrindMaterials1;
            this.MinimumSize = new System.Drawing.Size(16, 400);
            this.Name = "FormEditGrindMaterials";
            this.Text = "EditGrindMaterials";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditGrindMaterials_FormClosing);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private VNS.ERP.GUI.UCGrindMaterials UCGrindMaterials1;
    }
}