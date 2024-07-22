namespace VNS.ERP.GUI.UserControls
{
    partial class UCAccount
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
            this.lbAccountCode = new System.Windows.Forms.Label();
            this.TxtAcountCode = new DevExpress.XtraEditors.TextEdit();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new DevExpress.XtraEditors.TextEdit();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lookUpEditAccountType = new DevExpress.XtraEditors.LookUpEdit();
            this.lbAccountLevel = new System.Windows.Forms.Label();
            this.numUpDownAccountLevel = new System.Windows.Forms.NumericUpDown();
            this.lbParentAccount = new System.Windows.Forms.Label();
            this.TxtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lbDescription = new System.Windows.Forms.Label();
            this.btn = new DevExpress.XtraEditors.ButtonEdit();
            this.lookupEditClassificationTypeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.chkDetailSubject = new DevExpress.XtraEditors.CheckEdit();
            this.chkDetailClassification = new DevExpress.XtraEditors.CheckEdit();
            this.lstCheckeDetailSubject = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lookUpEditParentAccount = new DevExpress.XtraEditors.LookUpEdit();
            this.lst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAccountType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAccountLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditClassificationTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetailSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetailClassification.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCheckeDetailSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditParentAccount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAccountCode
            // 
            this.lbAccountCode.AutoSize = true;
            this.lbAccountCode.Location = new System.Drawing.Point(9, 6);
            this.lbAccountCode.Name = "lbAccountCode";
            this.lbAccountCode.Size = new System.Drawing.Size(69, 13);
            this.lbAccountCode.TabIndex = 9;
            this.lbAccountCode.Text = "Mã tài khoản";
            // 
            // TxtAcountCode
            // 
            this.TxtAcountCode.Location = new System.Drawing.Point(81, 3);
            this.TxtAcountCode.Name = "TxtAcountCode";
            this.TxtAcountCode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAcountCode.Properties.Appearance.Options.UseFont = true;
            this.TxtAcountCode.Properties.EditFormat.FormatString = "9";
            this.TxtAcountCode.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TxtAcountCode.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.TxtAcountCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.TxtAcountCode.Properties.Mask.PlaceHolder = '\0';
            this.TxtAcountCode.Properties.Mask.ShowPlaceHolders = false;
            this.TxtAcountCode.Properties.MaxLength = 20;
            this.TxtAcountCode.Size = new System.Drawing.Size(104, 19);
            this.TxtAcountCode.TabIndex = 0;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(191, 5);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(73, 13);
            this.lbAccountName.TabIndex = 10;
            this.lbAccountName.Text = "Tên tài khoản";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(267, 2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(381, 20);
            this.txtAccountName.TabIndex = 1;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(4, 78);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(74, 13);
            this.lbAccountType.TabIndex = 13;
            this.lbAccountType.Text = "Loại tài khoản";
            // 
            // lookUpEditAccountType
            // 
            this.lookUpEditAccountType.Location = new System.Drawing.Point(81, 76);
            this.lookUpEditAccountType.Name = "lookUpEditAccountType";
            this.lookUpEditAccountType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditAccountType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumID", "Mã", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EnumText")});
            this.lookUpEditAccountType.Properties.DisplayMember = "EnumText";
            this.lookUpEditAccountType.Properties.DropDownRows = 3;
            this.lookUpEditAccountType.Properties.NullText = "";
            this.lookUpEditAccountType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditAccountType.Properties.ValueMember = "EnumID";
            this.lookUpEditAccountType.Size = new System.Drawing.Size(104, 20);
            this.lookUpEditAccountType.TabIndex = 3;
            // 
            // lbAccountLevel
            // 
            this.lbAccountLevel.AutoSize = true;
            this.lbAccountLevel.Location = new System.Drawing.Point(191, 79);
            this.lbAccountLevel.Name = "lbAccountLevel";
            this.lbAccountLevel.Size = new System.Drawing.Size(76, 13);
            this.lbAccountLevel.TabIndex = 14;
            this.lbAccountLevel.Text = "Tài khoản cấp";
            // 
            // numUpDownAccountLevel
            // 
            this.numUpDownAccountLevel.Location = new System.Drawing.Point(268, 77);
            this.numUpDownAccountLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownAccountLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownAccountLevel.Name = "numUpDownAccountLevel";
            this.numUpDownAccountLevel.ReadOnly = true;
            this.numUpDownAccountLevel.Size = new System.Drawing.Size(33, 20);
            this.numUpDownAccountLevel.TabIndex = 4;
            this.numUpDownAccountLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownAccountLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbParentAccount
            // 
            this.lbParentAccount.AutoSize = true;
            this.lbParentAccount.Location = new System.Drawing.Point(307, 79);
            this.lbParentAccount.Name = "lbParentAccount";
            this.lbParentAccount.Size = new System.Drawing.Size(90, 13);
            this.lbParentAccount.TabIndex = 15;
            this.lbParentAccount.Text = "Mã tài khoản cha";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(81, 24);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.Properties.Appearance.Options.UseFont = true;
            this.TxtDescription.Properties.MaxLength = 200;
            this.TxtDescription.Size = new System.Drawing.Size(567, 50);
            this.TxtDescription.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(31, 42);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(48, 13);
            this.lbDescription.TabIndex = 12;
            this.lbDescription.Text = "Diễn giải";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(213, 98);
            this.btn.Name = "btn";
            this.btn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btn.Size = new System.Drawing.Size(19, 18);
            this.btn.TabIndex = 16;
            this.btn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_ButtonClick);
            // 
            // lookupEditClassificationTypeCode
            // 
            this.lookupEditClassificationTypeCode.AllowDrop = true;
            this.lookupEditClassificationTypeCode.Enabled = false;
            this.lookupEditClassificationTypeCode.Location = new System.Drawing.Point(196, 120);
            this.lookupEditClassificationTypeCode.Name = "lookupEditClassificationTypeCode";
            this.lookupEditClassificationTypeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEditClassificationTypeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassificationTypeCode", "Mã", 80),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClassificationTypeName", "Tên", 200)});
            this.lookupEditClassificationTypeCode.Properties.DisplayMember = "ClassificationTypeName";
            this.lookupEditClassificationTypeCode.Properties.NullText = "";
            this.lookupEditClassificationTypeCode.Properties.PopupWidth = 280;
            this.lookupEditClassificationTypeCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookupEditClassificationTypeCode.Properties.ValueMember = "ClassificationTypeCode";
            this.lookupEditClassificationTypeCode.Size = new System.Drawing.Size(104, 20);
            this.lookupEditClassificationTypeCode.TabIndex = 8;
            // 
            // chkDetailSubject
            // 
            this.chkDetailSubject.Location = new System.Drawing.Point(78, 96);
            this.chkDetailSubject.Name = "chkDetailSubject";
            this.chkDetailSubject.Properties.Caption = "Có theo dõi đối tượng";
            this.chkDetailSubject.Properties.ReadOnly = true;
            this.chkDetailSubject.Size = new System.Drawing.Size(129, 18);
            this.chkDetailSubject.TabIndex = 6;
            this.chkDetailSubject.CheckedChanged += new System.EventHandler(this.chkDetailSubject_CheckedChanged);
            // 
            // chkDetailClassification
            // 
            this.chkDetailClassification.Location = new System.Drawing.Point(77, 120);
            this.chkDetailClassification.Name = "chkDetailClassification";
            this.chkDetailClassification.Properties.Caption = "Có theo dõi yếu tố";
            this.chkDetailClassification.Size = new System.Drawing.Size(113, 18);
            this.chkDetailClassification.TabIndex = 7;
            this.chkDetailClassification.CheckedChanged += new System.EventHandler(this.chkDetailClassification_CheckedChanged);
            // 
            // lstCheckeDetailSubject
            // 
            this.lstCheckeDetailSubject.CheckOnClick = true;
            this.lstCheckeDetailSubject.DisplayMember = "(None)";
            this.lstCheckeDetailSubject.Location = new System.Drawing.Point(232, 8);
            this.lstCheckeDetailSubject.Name = "lstCheckeDetailSubject";
            this.lstCheckeDetailSubject.Size = new System.Drawing.Size(159, 110);
            this.lstCheckeDetailSubject.TabIndex = 11;
            this.lstCheckeDetailSubject.ValueMember = "(None)";
            this.lstCheckeDetailSubject.Validated += new System.EventHandler(this.lstCheckeDetailSubject_Validated);
            this.lstCheckeDetailSubject.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.lstCheckeDetailSubject_ItemCheck);
            // 
            // lookUpEditParentAccount
            // 
            this.lookUpEditParentAccount.Location = new System.Drawing.Point(398, 76);
            this.lookUpEditParentAccount.Name = "lookUpEditParentAccount";
            this.lookUpEditParentAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditParentAccount.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountCode", "Mã TK", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Tên TK", 220)});
            this.lookUpEditParentAccount.Properties.DisplayMember = "AccountCode";
            this.lookUpEditParentAccount.Properties.NullText = "";
            this.lookUpEditParentAccount.Properties.PopupWidth = 300;
            this.lookUpEditParentAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditParentAccount.Properties.ValueMember = "AccountCode";
            this.lookUpEditParentAccount.Size = new System.Drawing.Size(84, 20);
            this.lookUpEditParentAccount.TabIndex = 5;
            this.lookUpEditParentAccount.EditValueChanged += new System.EventHandler(this.lookUpEditParentAccount_EditValueChanged);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(232, 9);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(157, 108);
            this.lst.TabIndex = 29;
            this.lst.Visible = false;
            this.lst.Validated += new System.EventHandler(this.lst_Validated);
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditParentAccount);
            this.Controls.Add(this.chkDetailClassification);
            this.Controls.Add(this.chkDetailSubject);
            this.Controls.Add(this.lookupEditClassificationTypeCode);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbParentAccount);
            this.Controls.Add(this.numUpDownAccountLevel);
            this.Controls.Add(this.lbAccountLevel);
            this.Controls.Add(this.lookUpEditAccountType);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.TxtAcountCode);
            this.Controls.Add(this.lbAccountCode);
            this.Controls.Add(this.lstCheckeDetailSubject);
            this.Controls.Add(this.lst);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(652, 145);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditAccountType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAccountLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEditClassificationTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetailSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDetailClassification.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCheckeDetailSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditParentAccount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountCode;
        private DevExpress.XtraEditors.TextEdit TxtAcountCode;
        private System.Windows.Forms.Label lbAccountName;
        private DevExpress.XtraEditors.TextEdit txtAccountName;
        private System.Windows.Forms.Label lbAccountType;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditAccountType;
        private System.Windows.Forms.Label lbAccountLevel;
        private System.Windows.Forms.NumericUpDown numUpDownAccountLevel;
        private System.Windows.Forms.Label lbParentAccount;
        private DevExpress.XtraEditors.MemoEdit TxtDescription;
        private System.Windows.Forms.Label lbDescription;
        private DevExpress.XtraEditors.ButtonEdit btn;
        private DevExpress.XtraEditors.LookUpEdit lookupEditClassificationTypeCode;
        private DevExpress.XtraEditors.CheckEdit chkDetailSubject;
        private DevExpress.XtraEditors.CheckEdit chkDetailClassification;
        private DevExpress.XtraEditors.CheckedListBoxControl lstCheckeDetailSubject;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditParentAccount;
        private System.Windows.Forms.ListBox lst;
    }
}
