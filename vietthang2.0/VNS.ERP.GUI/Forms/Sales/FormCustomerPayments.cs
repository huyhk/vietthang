using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Sales;
using VNS.Common;

namespace VNS.ERP.GUI.Sales
{
    public partial class FormCustomerPayments : FormEditBase
    {
        private ListBase<Customer> lstCustomers=null;
        private ListBase<Period> lstPeriods = null;
        private ListBase<Cash> lstCashs = null;
        private ListBase<Branch> lstBranchs = null;

        string productType;
        public FormCustomerPayments(string pProductType)
        {
            InitializeComponent();
            this.Business = new CustomerPaymentBLL();
            productType = pProductType;
        }

        private void FormCustomerPayments_Load(object sender, EventArgs e)
        {
            lstCustomers = (new CustomerBLL()).GetCustomer(productType);
            //lstCustomers = (new CustomerBLL()).GetAll();
            lstCashs = (new CashBLL()).GetAll();
            lstBranchs = (new BranchBLL()).GetAllByMemberID(enumSubjectType.Branch.ToString(), Contexts.CurrentUser.MemberID);
            this.ucCustomerPayments1.SetlookUpStockCodeDSr((new BankBLL()).GetAll(), lstCashs);
            this.ucCustomerPayments1.SetLookupCustomerCodeDSr(lstCustomers);
            this.ucCustomerPayments1.SetLookupPaymentTypeDSr(EnumDisplays.GetListenumCustomerPayments());
            this.LookUpEditPaymentType.DataSource = EnumDisplays.GetListenumCustomerPayments();
            this.ItemLookCustomerCode.DataSource = lstCustomers;
            this.lookUpStockCode.Properties.DataSource = lstBranchs;
            this.lookUpStockCode.ItemIndex = 0;
            this.LookUpEditStockCode.DataSource = (new SubjectBLL()).GetBankandCash();
            this.colAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
        }

        private void lookUpStockCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpStockCode.ItemIndex != -1)
            {
                GetData();
                
                this.ucCustomerPayments1.branchCode=this.lookUpStockCode.EditValue.ToString();
                this.ucCustomerPayments1.soHieu = lstBranchs[this.lookUpStockCode.ItemIndex].SoHieu;
            }
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.ucDatePeriodSelection1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            lookUpStockCode.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            this.btnGetData.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
        void GetData()
        {
            this.DataSource = (new CustomerPaymentBLL()).GetObjectByTime(this.ucDatePeriodSelection1.StartDate, this.ucDatePeriodSelection1.EndDate, this.lookUpStockCode.EditValue.ToString(), this.productType);
        }
    }
}