using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VNS.Windows.Controls;
using VNS.ERP.Data;
using VNS.Windows;
using VNS.Common;
using VNS.ERP.Data.Accounting;
namespace VNS.ERP.GUI.UserControls.Accounts
{
    public partial class UCKheUocVay : VNS.Windows.Controls.EditControlBase
    {
        public UCKheUocVay()
        {
            InitializeComponent();
        }
        protected override void InitDataObject()
        {
            if (!this.DesignMode)
            {
                //string whereCondition = " left(AccountCode, 3) in ('311','315','341')";
                //this.lkAccountCode.Properties.DataSource = new AccountBLL().GetObjectDynamic(whereCondition, " AccountCode");
                this.lkAccountCode.Properties.DataSource = new AccountBLL().GetTKTienvay();
                this.lkSubjectCode.Properties.DataSource = new BankBLL().GetAll();
            }
            base.InitDataObject();
        }
        protected override int ValidateData()
        {
            if (this.TxtVayNo.Text == string.Empty)
            {
                this.TxtVayNo.Focus();
                return -1;
            }
            if (this.lkAccountCode.EditValue.ToString() == string.Empty)
            {
                this.lkAccountCode.Focus();
                return -2;
            }
            if (this.lkSubjectCode.EditValue.ToString() == string.Empty)
            {
                this.lkSubjectCode.Focus();
                return -3;
            }
            return 0;
        }
        protected override void BindData()
        {
            if (this.DataSource != null)
            {
                this.TxtVayNo.Text = (dataSource as KheUocVay).VayNo;
                this.txtVayDate.DateTime = (dataSource as KheUocVay).VayDate;
                this.lkAccountCode.EditValue = (dataSource as KheUocVay).AccountCode;
                this.lkSubjectCode.EditValue = (dataSource as KheUocVay).SubjectCode;
                this.txtVayRate.EditValue = (dataSource as KheUocVay).VayRate;
                this.txtDescription.Text = (dataSource as KheUocVay).Description;
                this.checkIsFinished.Checked = (dataSource as KheUocVay).IsFinished;
            }

            base.BindData();
        }
        protected override void AssignData()
        {
            if (dataSource == null) dataSource = new KheUocVay();
            (dataSource as KheUocVay).VayNo = this.TxtVayNo.Text;
            (dataSource as KheUocVay).VayDate = this.txtVayDate.DateTime;
            (dataSource as KheUocVay).AccountCode = (string)this.lkAccountCode.EditValue;
            (dataSource as KheUocVay).SubjectCode = (string)this.lkSubjectCode.EditValue;
            (dataSource as KheUocVay).VayRate = (decimal)this.txtVayRate.EditValue;
            (dataSource as KheUocVay).Description = this.txtDescription.Text;
            (dataSource as KheUocVay).IsFinished = this.checkIsFinished.Checked;

            base.AssignData();
        }
        public override void RefreshControl()
        {
            if (this.editMode == FormEditMode.ADD)
            {
                this.TxtVayNo.Properties.ReadOnly = false;
                this.txtVayDate.Properties.ReadOnly = false;
                this.lkAccountCode.Properties.ReadOnly = false;
                this.lkSubjectCode.Properties.ReadOnly = false;
                this.txtVayRate.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.checkIsFinished.Properties.ReadOnly = false;
                this.TxtVayNo.Focus();
            }
            else if (this.editMode == FormEditMode.EDIT)
            {
                this.TxtVayNo.Properties.ReadOnly = false;
                this.txtVayDate.Properties.ReadOnly = false;
                this.lkAccountCode.Properties.ReadOnly = false;
                this.lkSubjectCode.Properties.ReadOnly = false;
                this.txtVayRate.Properties.ReadOnly = false;
                this.txtDescription.Properties.ReadOnly = false;
                this.checkIsFinished.Properties.ReadOnly = false;
                this.txtVayDate.Focus();

            }
            else// (this.editMode == FormEditMode.VIEW)
            {
                this.TxtVayNo.Properties.ReadOnly = true;
                this.txtVayDate.Properties.ReadOnly = true;
                this.lkAccountCode.Properties.ReadOnly = true;
                this.lkSubjectCode.Properties.ReadOnly = true;
                this.txtVayRate.Properties.ReadOnly = true;
                this.txtDescription.Properties.ReadOnly = true;
                this.checkIsFinished.Properties.ReadOnly = true;
            }
            base.RefreshControl();
        }
    }
}

