namespace VNS.ERP.GUI.Equipments
{
    partial class FormVattuOldOpening
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucVattuOldOpening1 = new VNS.ERP.GUI.Equipments.UCVattuOldOpening();
            this.lkpStock = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStock.Properties)).BeginInit();
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
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucVattuOldOpening1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lkpStock, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 292);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucVattuOldOpening1
            // 
            this.ucVattuOldOpening1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucVattuOldOpening1.Business = null;
            this.tableLayoutPanel1.SetColumnSpan(this.ucVattuOldOpening1, 3);
            this.ucVattuOldOpening1.DataSource = null;
            this.ucVattuOldOpening1.Location = new System.Drawing.Point(3, 29);
            this.ucVattuOldOpening1.Name = "ucVattuOldOpening1";
            this.ucVattuOldOpening1.Size = new System.Drawing.Size(750, 260);
            this.ucVattuOldOpening1.TabIndex = 8;
            // 
            // lkpStock
            // 
            this.lkpStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lkpStock.Location = new System.Drawing.Point(83, 3);
            this.lkpStock.Name = "lkpStock";
            this.lkpStock.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpStock.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockCode"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StockName")});
            this.lkpStock.Properties.DisplayMember = "StockName";
            this.lkpStock.Properties.NullText = "";
            this.lkpStock.Properties.ValueMember = "StockCode";
            this.lkpStock.Size = new System.Drawing.Size(176, 20);
            this.lkpStock.TabIndex = 7;
            this.lkpStock.EditValueChanged += new System.EventHandler(this.lkpStock_EditValueChanged);
            // 
            // FormVattuOldOpening
            // 
            this.AllowAddNew = false;
            this.AllowDelete = false;
            this.AllowDrop = true;
            this.AllowFormSkin = false;
            this.AllowSaveAndClose = false;
            this.AllowSaveAndNew = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.EditControl = this.ucVattuOldOpening1;
            this.Name = "FormVattuOldOpening";
            this.Text = "FormVattuOldOpening";
            this.Load += new System.EventHandler(this.FormVattuOldOpening_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bdSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDocking.Controller)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStock.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private UCVattuOldOpening ucVattuOldOpening1;
        private DevExpress.XtraEditors.LookUpEdit lkpStock;
    }
}