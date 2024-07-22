namespace VNS.Windows.UserControls
{
    partial class UCDatePeriodSelection
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
            this.grBoxPeriodSelect = new System.Windows.Forms.GroupBox();
            this.txtYearOfMonth = new DevExpress.XtraEditors.SpinEdit();
            this.txtYearOfQuater = new DevExpress.XtraEditors.SpinEdit();
            this.TxtYearNo = new DevExpress.XtraEditors.SpinEdit();
            this.numUpDnMonthNo = new DevExpress.XtraEditors.SpinEdit();
            this.numUpDnQuaterNo = new DevExpress.XtraEditors.SpinEdit();
            this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
            this.optDay = new System.Windows.Forms.RadioButton();
            this.optMonth = new System.Windows.Forms.RadioButton();
            this.optQuater = new System.Windows.Forms.RadioButton();
            this.optYear = new System.Windows.Forms.RadioButton();
            this.grBoxPeriodSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfQuater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMonthNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnQuaterNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grBoxPeriodSelect
            // 
            this.grBoxPeriodSelect.Controls.Add(this.txtYearOfMonth);
            this.grBoxPeriodSelect.Controls.Add(this.txtYearOfQuater);
            this.grBoxPeriodSelect.Controls.Add(this.TxtYearNo);
            this.grBoxPeriodSelect.Controls.Add(this.numUpDnMonthNo);
            this.grBoxPeriodSelect.Controls.Add(this.numUpDnQuaterNo);
            this.grBoxPeriodSelect.Controls.Add(this.dateEditEnd);
            this.grBoxPeriodSelect.Controls.Add(this.lbEndDate);
            this.grBoxPeriodSelect.Controls.Add(this.dateEditStart);
            this.grBoxPeriodSelect.Controls.Add(this.optDay);
            this.grBoxPeriodSelect.Controls.Add(this.optMonth);
            this.grBoxPeriodSelect.Controls.Add(this.optQuater);
            this.grBoxPeriodSelect.Controls.Add(this.optYear);
            this.grBoxPeriodSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxPeriodSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grBoxPeriodSelect.Location = new System.Drawing.Point(0, 0);
            this.grBoxPeriodSelect.Name = "grBoxPeriodSelect";
            this.grBoxPeriodSelect.Size = new System.Drawing.Size(401, 62);
            this.grBoxPeriodSelect.TabIndex = 0;
            this.grBoxPeriodSelect.TabStop = false;
            this.grBoxPeriodSelect.Text = "Chọn khoảng thời gian";
            // 
            // txtYearOfMonth
            // 
            this.txtYearOfMonth.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtYearOfMonth.Enabled = false;
            this.txtYearOfMonth.EnterMoveNextControl = true;
            this.txtYearOfMonth.Location = new System.Drawing.Point(239, 14);
            this.txtYearOfMonth.Name = "txtYearOfMonth";
            this.txtYearOfMonth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearOfMonth.Properties.Appearance.Options.UseFont = true;
            this.txtYearOfMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYearOfMonth.Properties.IsFloatValue = false;
            this.txtYearOfMonth.Properties.Mask.EditMask = "####";
            this.txtYearOfMonth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtYearOfMonth.Properties.MaxValue = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txtYearOfMonth.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtYearOfMonth.Properties.UseCtrlIncrement = false;
            this.txtYearOfMonth.Size = new System.Drawing.Size(51, 21);
            this.txtYearOfMonth.TabIndex = 14;
            // 
            // txtYearOfQuater
            // 
            this.txtYearOfQuater.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtYearOfQuater.Enabled = false;
            this.txtYearOfQuater.EnterMoveNextControl = true;
            this.txtYearOfQuater.Location = new System.Drawing.Point(92, 37);
            this.txtYearOfQuater.Name = "txtYearOfQuater";
            this.txtYearOfQuater.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearOfQuater.Properties.Appearance.Options.UseFont = true;
            this.txtYearOfQuater.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtYearOfQuater.Properties.IsFloatValue = false;
            this.txtYearOfQuater.Properties.Mask.EditMask = "####";
            this.txtYearOfQuater.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtYearOfQuater.Properties.MaxValue = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.txtYearOfQuater.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtYearOfQuater.Properties.UseCtrlIncrement = false;
            this.txtYearOfQuater.Size = new System.Drawing.Size(48, 21);
            this.txtYearOfQuater.TabIndex = 13;
            // 
            // TxtYearNo
            // 
            this.TxtYearNo.EditValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TxtYearNo.Enabled = false;
            this.TxtYearNo.EnterMoveNextControl = true;
            this.TxtYearNo.Location = new System.Drawing.Point(51, 14);
            this.TxtYearNo.Name = "TxtYearNo";
            this.TxtYearNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearNo.Properties.Appearance.Options.UseFont = true;
            this.TxtYearNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.TxtYearNo.Properties.IsFloatValue = false;
            this.TxtYearNo.Properties.Mask.EditMask = "####";
            this.TxtYearNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.TxtYearNo.Properties.MaxValue = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.TxtYearNo.Properties.MinValue = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.TxtYearNo.Properties.UseCtrlIncrement = false;
            this.TxtYearNo.Size = new System.Drawing.Size(51, 21);
            this.TxtYearNo.TabIndex = 12;
            // 
            // numUpDnMonthNo
            // 
            this.numUpDnMonthNo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnMonthNo.Enabled = false;
            this.numUpDnMonthNo.EnterMoveNextControl = true;
            this.numUpDnMonthNo.Location = new System.Drawing.Point(197, 14);
            this.numUpDnMonthNo.Name = "numUpDnMonthNo";
            this.numUpDnMonthNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDnMonthNo.Properties.Appearance.Options.UseFont = true;
            this.numUpDnMonthNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numUpDnMonthNo.Properties.IsFloatValue = false;
            this.numUpDnMonthNo.Properties.Mask.EditMask = "N00";
            this.numUpDnMonthNo.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDnMonthNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnMonthNo.Properties.UseCtrlIncrement = false;
            this.numUpDnMonthNo.Size = new System.Drawing.Size(40, 21);
            this.numUpDnMonthNo.TabIndex = 3;
            this.numUpDnMonthNo.EditValueChanged += new System.EventHandler(this.numUpDnMonthNo_EditValueChanged);
            // 
            // numUpDnQuaterNo
            // 
            this.numUpDnQuaterNo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnQuaterNo.Enabled = false;
            this.numUpDnQuaterNo.EnterMoveNextControl = true;
            this.numUpDnQuaterNo.Location = new System.Drawing.Point(51, 37);
            this.numUpDnQuaterNo.Name = "numUpDnQuaterNo";
            this.numUpDnQuaterNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDnQuaterNo.Properties.Appearance.Options.UseFont = true;
            this.numUpDnQuaterNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numUpDnQuaterNo.Properties.IsFloatValue = false;
            this.numUpDnQuaterNo.Properties.Mask.EditMask = "N00";
            this.numUpDnQuaterNo.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDnQuaterNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnQuaterNo.Properties.UseCtrlIncrement = false;
            this.numUpDnQuaterNo.Size = new System.Drawing.Size(40, 21);
            this.numUpDnQuaterNo.TabIndex = 1;
            this.numUpDnQuaterNo.EditValueChanged += new System.EventHandler(this.numUpDnQuaterNo_EditValueChanged);
            // 
            // dateEditEnd
            // 
            this.dateEditEnd.EditValue = new System.DateTime(2007, 6, 14, 0, 0, 0, 0);
            this.dateEditEnd.EnterMoveNextControl = true;
            this.dateEditEnd.Location = new System.Drawing.Point(313, 36);
            this.dateEditEnd.Name = "dateEditEnd";
            this.dateEditEnd.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditEnd.Properties.Appearance.Options.UseFont = true;
            this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEnd.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditEnd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditEnd.Size = new System.Drawing.Size(85, 21);
            this.dateEditEnd.TabIndex = 6;
            this.dateEditEnd.EditValueChanged += new System.EventHandler(this.dateEditEnd_EditValueChanged);
            // 
            // lbEndDate
            // 
            this.lbEndDate.Location = new System.Drawing.Point(283, 40);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(29, 15);
            this.lbEndDate.TabIndex = 11;
            this.lbEndDate.Text = "Đến";
            this.lbEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEditStart
            // 
            this.dateEditStart.EditValue = new System.DateTime(2007, 6, 14, 0, 0, 0, 0);
            this.dateEditStart.EnterMoveNextControl = true;
            this.dateEditStart.Location = new System.Drawing.Point(197, 37);
            this.dateEditStart.Name = "dateEditStart";
            this.dateEditStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditStart.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditStart.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEditStart.Size = new System.Drawing.Size(85, 21);
            this.dateEditStart.TabIndex = 5;
            this.dateEditStart.EditValueChanged += new System.EventHandler(this.dateEditStart_EditValueChanged);
            // 
            // optDay
            // 
            this.optDay.Checked = true;
            this.optDay.Location = new System.Drawing.Point(142, 39);
            this.optDay.Name = "optDay";
            this.optDay.Size = new System.Drawing.Size(53, 17);
            this.optDay.TabIndex = 10;
            this.optDay.TabStop = true;
            this.optDay.Text = "Từ";
            this.optDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optDay.UseVisualStyleBackColor = true;
            this.optDay.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // optMonth
            // 
            this.optMonth.Location = new System.Drawing.Point(142, 16);
            this.optMonth.Name = "optMonth";
            this.optMonth.Size = new System.Drawing.Size(56, 17);
            this.optMonth.TabIndex = 8;
            this.optMonth.Text = "Tháng";
            this.optMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optMonth.UseVisualStyleBackColor = true;
            this.optMonth.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // optQuater
            // 
            this.optQuater.AutoSize = true;
            this.optQuater.Location = new System.Drawing.Point(6, 38);
            this.optQuater.Name = "optQuater";
            this.optQuater.Size = new System.Drawing.Size(44, 17);
            this.optQuater.TabIndex = 9;
            this.optQuater.Text = "Quý";
            this.optQuater.UseVisualStyleBackColor = true;
            this.optQuater.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // optYear
            // 
            this.optYear.AutoSize = true;
            this.optYear.Location = new System.Drawing.Point(6, 15);
            this.optYear.Name = "optYear";
            this.optYear.Size = new System.Drawing.Size(47, 17);
            this.optYear.TabIndex = 7;
            this.optYear.Text = "Năm";
            this.optYear.UseVisualStyleBackColor = true;
            this.optYear.CheckedChanged += new System.EventHandler(this.opt_CheckedChanged);
            // 
            // UCDatePeriodSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grBoxPeriodSelect);
            this.Name = "UCDatePeriodSelection";
            this.Size = new System.Drawing.Size(401, 62);
            this.grBoxPeriodSelect.ResumeLayout(false);
            this.grBoxPeriodSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOfQuater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYearNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnMonthNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnQuaterNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxPeriodSelect;
        private System.Windows.Forms.RadioButton optYear;
        private System.Windows.Forms.RadioButton optQuater;
        private System.Windows.Forms.RadioButton optMonth;
        private System.Windows.Forms.RadioButton optDay;
        private DevExpress.XtraEditors.DateEdit dateEditEnd;
        private System.Windows.Forms.Label lbEndDate;
        private DevExpress.XtraEditors.DateEdit dateEditStart;
        private DevExpress.XtraEditors.SpinEdit numUpDnMonthNo;
        private DevExpress.XtraEditors.SpinEdit numUpDnQuaterNo;
        private DevExpress.XtraEditors.SpinEdit TxtYearNo;
        private DevExpress.XtraEditors.SpinEdit txtYearOfMonth;
        private DevExpress.XtraEditors.SpinEdit txtYearOfQuater;
    }
}
