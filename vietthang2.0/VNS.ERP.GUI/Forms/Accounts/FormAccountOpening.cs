using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;
using VNS.Windows;
using DevExpress.XtraGrid.Views.Grid;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormAccountOpening : FormEditBase
    {
        private string periodCode = "";
        private ListBase<Account> lstAccount = null;
        private DataView dv = null;
        public FormAccountOpening()
        {
            InitializeComponent();
        }

        private void FormAccountOpening_Load(object sender, EventArgs e)
        {
            Period period= (new PeriodBLL()).GetMin();
            periodCode = period.PeriodCode;
            this.DataSource = (new AccountOpeningBLL()).GetListAccountOpeningByPeriodCode(periodCode);
            lstAccount= (new AccountBLL()).GetAll();//.GetListAccountIsNotParentAccount();
            foreach (Account acc in lstAccount)
            {
                if (acc.LstAccSubjectType == null)
                {
                    acc.LstAccSubjectType = new AccountBLL().GetAccountSubjectType(acc.AccountCode);
                }
            }
            ListBase<Currency> lstCur = new CurrencyBL().GetAll();
            lstCur.Insert(0,new Currency());
            repItemLookUpCurrencyCode.DataSource = lstCur;
            this.colCreditOpeningAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.colDebitOpeningAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.repItemTextEditAmountNT.Mask.EditMask = AppConfigs.CONFIG_AMOUNTNTMASK;
            this.repItemTextEditAmountNT.Mask.UseMaskAsDisplayFormat = true;
            this.colCreditOpeningAmountNT.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.colDebitOpeningAmountNT.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTNTFORMAT_STRING;
            this.ItemLookUpAccountCode.DataSource = lstAccount;
            dv = ((new SubjectBLL()).GetAllToDataTable()).DefaultView;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            this.Text = this.Text + " " + period.StartDate.ToString(AppConfigs.CONFIG_DATEFORMAT);
            PeriodBLL periodBLL = new PeriodBLL();
            if (periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Count > 0)
            {
                this.btnEdit.Enabled = false;
            }
            this.navigatorFrmEditBase.Visible = false;
        }

        private void ItemTextSubjectCode_EditValueChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if (this.gridView.ActiveEditor != null)
                (cr.Current as AccountOpening).SubjectCode = this.gridView.ActiveEditor.Text;

        }

        private void ItemTextSubjectCode_Leave(object sender, EventArgs e)
        {

            string strFilter = "";
            int index = -1;
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountOpening).AccountCode);
                if (index >= 0)
                {
                    foreach (AccountSubjectType accObj in lstAccount[index].LstAccSubjectType)
                    {
                        strFilter += "'" + accObj.SubjectTypeCode + "',";
                    }
                    if (!strFilter.Equals(""))
                    {
                        strFilter = "SubjectTypeCode in (" + strFilter + ")";
                        dv.RowFilter = strFilter;
                    }
                }
                if ((cr.Current as AccountOpening).SubjectCode == "")
                {
                    if ((cr.Current as AccountOpening).AccountCode != "")
                        if (this.gridView.ActiveEditor == null)
                        {

                            SetDataRowCellSubjectCode(dv, this.gridView, this.colSubjectCode);
                        }
                        else
                            CheckValueCellSubjectCodeFocus(this.gridView.ActiveEditor.Text, dv, this.gridView, this.colSubjectCode);
                }
                else
                    CheckValueCellSubjectCodeFocus((cr.Current as AccountOpening).SubjectCode, dv, this.gridView, this.colSubjectCode);
            }
        }
        /// <summary>
        /// Kiểm tra AccountCode trước khi Leave khỏi cell của Gridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemLookUpAccountCode_Leave(object sender, EventArgs e)
        {
           int index = -1;
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
                index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountOpening).AccountCode);
                if (index >= 0)
                {
                    if (lstAccount[index].DetailSubject == false)
                    {
                        (cr.Current as AccountOpening).SubjectCode = "";
                        this.colSubjectCode.OptionsColumn.AllowFocus = false;
                    }
                    else
                        this.colSubjectCode.OptionsColumn.AllowFocus = true;
                }
            }
        }

        private void ItemLookUpAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if (this.gridView.ActiveEditor != null)
                (cr.Current as AccountOpening).AccountCode = this.gridView.ActiveEditor.Text;
        }

        /// <summary>
        /// Check text in cell of columns  SubjectCode
        /// </summary>
        /// <param name="value"></param>
        /// <param name="dv"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void CheckValueCellSubjectCodeFocus(string value, DataView dv, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            dv.Sort = "SubjectCode ASC";
            if (dv.Find(value) < 0)
            {
                SetDataRowCellSubjectCode(dv, gv, col);
            }
        }
        /// <summary>
        /// Select DataSource for cell of columns SubjectCode
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="gv"></param>
        /// <param name="col"></param>
        private void SetDataRowCellSubjectCode(DataView dv, GridView gv, DevExpress.XtraGrid.Columns.GridColumn col)
        {
            if (dv.Count > 0)
            {
                string[] fields ={ "SubjectCode", "SubjectName" };
                string[] header ={ "Mã đối tượng", "Tên đối tượng" };
                DataRowView drv = (FormSearch.ShowSearch(dv, fields, header) as DataRowView);
                if (this.editMode == FormEditMode.ADD || this.editMode == FormEditMode.EDIT)
                {
                    if (drv != null)
                    {
                        gv.SetRowCellValue(gv.FocusedRowHandle, col, drv["SubjectCode"].ToString());
                    }
                }
            }
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CurrencyManager cr = this.BindingContext[this.gridControl.DataSource] as CurrencyManager;
            if (cr.Count > 0)
            {
             int index = ItemLookUpAccountCode.GetDataSourceRowIndex("AccountCode", (cr.Current as AccountOpening).AccountCode);
                if (index >= 0)
                {
                    if (lstAccount[index].DetailSubject == false)
                    {
                        (cr.Current as AccountOpening).SubjectCode = "";
                        this.colSubjectCode.OptionsColumn.AllowFocus = false;
                    }
                    else
                    {
                        this.colSubjectCode.OptionsColumn.AllowFocus = true;
                    }
                }
            }
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.EditMode != FormEditMode.VIEW)
                if (e.KeyCode == Keys.Delete)
                    this.gridView.DeleteRow(this.gridView.FocusedRowHandle);
        }

        public override void RefreshButtons()
        {
            this.btnEdit.Enabled = this.editMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.editMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.editMode == FormEditMode.EDIT;
            btnCopyFromFixedAssetOpenings.Enabled = this.editMode != FormEditMode.VIEW;
            btnFromCustomerDeptSumOpenings.Enabled = this.editMode != FormEditMode.VIEW;
            gridView.OptionsBehavior.Editable = this.EditMode == FormEditMode.EDIT;
            if (this.EditMode == FormEditMode.VIEW)
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            else
            {
                gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            }

        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            if (periodCode != "")
            {
                this.DataSource = (new AccountOpeningBLL()).GetListAccountOpeningByPeriodCode(periodCode);
                this.gridControl.RefreshDataSource();
            }
        }
        protected override int ValidateData()
        {
            foreach (AccountOpening accOpen in (this.gridControl.DataSource as ListBase<AccountOpening>))
            {
                if (accOpen.AccountCode == string.Empty)
                    return -1;
                if (CheckDataInCellSubjectCode(accOpen.SubjectCode, accOpen.AccountCode) == false)
                    return -2;
                if (accOpen.OpeningAmount == 0)
                    return -3;
            }
            return 0;
        }

        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = new AccountOpeningBLL().Insert((this.gridControl.DataSource as ListBase<AccountOpening>) ,periodCode);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

        /// <summary>
        /// Kiểm tra giá trị của SubjectCode trong rows.
        /// return: true,false.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckDataInCellSubjectCode(string value, string accountCode)
        {
            bool check = false;
            string strFilter = "";
            Account acc = lstAccount.Search("AccountCode", accountCode);
            if (acc.DetailSubject == false)
                return true;
            else
            {
                foreach (AccountSubjectType accObj in acc.LstAccSubjectType)
                {
                    strFilter += "'" + accObj.SubjectTypeCode + "',";
                }
                if (!strFilter.Equals(""))
                {
                    strFilter = "SubjectTypeCode in (" + strFilter + ")";
                    dv.RowFilter = strFilter;
                }
                dv.Sort = "SubjectCode ASC";
                if (dv.Find(value) < 0)
                    check = false;
                else
                    check = true;
            }
            return check;
        }

        private void btnFromCustomerDeptSumOpenings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.GetTextMessage("Info-1", "Chương trình sẽ lấy thông tin từ tồn đầu công nợ khách hàng (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                ListBase<AccountOpening> lst = this.gridControl.DataSource as ListBase<AccountOpening>;
                ListBase<AccountOpening> lstNew = new AccountOpeningBLL().GetFromCustomerDeptSumOpenings(this.periodCode);
                int count = lst.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    AccountOpening ao = lst[i];
                    if (ao.AccountCode.Length >= Account.CustomerDeptAccount.Length)
                    {
                        if (ao.AccountCode.Substring(0, Account.CustomerDeptAccount.Length) == Account.CustomerDeptAccount)
                        {
                            lst.Remove(ao);
                        }
                    }
                }
                foreach (AccountOpening ao in lstNew)
                {
                    AccountOpening ao1 = (AccountOpening)ao.Clone();
                    lst.Add(ao1);
                }
            }
        }

        private void btnCopyFromFixedAssetOpenings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.GetTextMessage("Info-2", "Chương trình sẽ lấy thông tin từ tồn đầu tài sản cố định (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListBase<AccountOpening> lst = this.gridControl.DataSource as ListBase<AccountOpening>;
                ListBase<AccountOpening> lstNew = new AccountOpeningBLL().GetFromFixedAssetOpenings(this.periodCode);
                int count = lst.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    AccountOpening ao = lst[i];
                    if (ao.AccountCode.Length >= Account.FixedAssetAccount.Length)
                    {
                        if (ao.AccountCode.Substring(0, Account.FixedAssetAccount.Length) == Account.FixedAssetAccount)
                        {
                            lst.Remove(ao);
                        }
                    }
                }
                foreach (AccountOpening ao in lstNew)
                {
                    AccountOpening ao1 = (AccountOpening)ao.Clone();
                    lst.Add(ao1);
                }
            }
        }
    }
}