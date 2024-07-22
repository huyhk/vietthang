using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows;
using VNS.Common;


namespace VNS.ERP.GUI
{
    public partial class UCAccountClassification : EditControlBase
    {
        public UCAccountClassification()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set DataSouced of cboClassificationTypeCode.
        /// </summary>
        /// <param name="lstTypeCode"></param>
        public void SetDataSoucedCbo(ListBase<AccountClassificationType> lstTypeCode)
        {
            this.cboClassificationTypeCode.Properties.DataSource = lstTypeCode;
         
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.txtAccountClassificationCode.Text = (dataSource as AccountClassification).ClassificationCode;
                this.txtAccountClassificationName.Text = (dataSource as AccountClassification).ClassificationName;
                this.cboClassificationTypeCode.EditValue = (dataSource as AccountClassification).ClassificationTypeCode;
                this.txtDescription.Text = (dataSource as AccountClassification).Description;
            }
         
        }
        protected override int ValidateData()
        {
            if (this.txtAccountClassificationCode.Text == string.Empty)
            {
                this.txtAccountClassificationCode.Focus();
                return -1;
            }
            if (this.txtAccountClassificationName.Text == string.Empty)
            {
                this.txtAccountClassificationName.Focus();
                return -2;
            }
            if (this.cboClassificationTypeCode.Text == string.Empty)
            {
                this.cboClassificationTypeCode.Focus();
                return -3;
            }
            return 0;
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new AccountClassification();
            (dataSource as AccountClassification).ClassificationCode = this.txtAccountClassificationCode.Text;
            (dataSource as AccountClassification).ClassificationName = this.txtAccountClassificationName.Text;
            (dataSource as AccountClassification).ClassificationTypeCode = this.cboClassificationTypeCode.EditValue.ToString();
            (dataSource as AccountClassification).Description = this.txtDescription.Text;
            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.txtAccountClassificationCode.Properties.ReadOnly = false;
                this.txtAccountClassificationName.Properties.ReadOnly = false;
                this.cboClassificationTypeCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtAccountClassificationCode.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.txtAccountClassificationCode.Properties.ReadOnly = true;
                this.txtAccountClassificationName.Properties.ReadOnly = false;
                this.cboClassificationTypeCode.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.txtAccountClassificationName.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {

                this.txtAccountClassificationCode.Properties.ReadOnly = true;
                this.txtAccountClassificationName.Properties.ReadOnly = true;
                this.cboClassificationTypeCode.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
    }
}
