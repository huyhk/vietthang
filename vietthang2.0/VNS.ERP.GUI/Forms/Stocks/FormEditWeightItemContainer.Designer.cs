namespace VNS.ERP.GUI.Stocks
{
    partial class FormEditWeightItemContainer
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
            this.ucWeightItemContainer1 = new VNS.ERP.GUI.UserControl.UCWeightItemContainer();
            this.btnPrintReport = new System.Windows.Forms.Button();
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
            // ucWeightItemContainer1
            // 
            this.ucWeightItemContainer1.Business = null;
            this.ucWeightItemContainer1.DataSource = null;
            this.ucWeightItemContainer1.IsReceive = true;
            this.ucWeightItemContainer1.Location = new System.Drawing.Point(3, 46);
            this.ucWeightItemContainer1.Name = "ucWeightItemContainer1";
            this.ucWeightItemContainer1.Size = new System.Drawing.Size(820, 277);
            this.ucWeightItemContainer1.TabIndex = 5;
            this.ucWeightItemContainer1.OnNextWeight += new VNS.ERP.GUI.UserControl.UCWeightItemContainer.NextWeight(this.ucWeightItemContainer1_OnNextWeight);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(735, 325);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(82, 25);
            this.btnPrintReport.TabIndex = 6;
            this.btnPrintReport.Text = "In phiếu cân";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // FormEditWeightItemContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 375);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.ucWeightItemContainer1);
            this.EditControl = this.ucWeightItemContainer1;
            this.Name = "FormEditWeightItemContainer";
            this.Text = "Phiếu cân hàng";
            this.Controls.SetChildIndex(this.ucWeightItemContainer1, 0);
            this.Controls.SetChildIndex(this.btnPrintReport, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VNS.ERP.GUI.UserControl.UCWeightItemContainer ucWeightItemContainer1;
        private System.Windows.Forms.Button btnPrintReport;
    }
}