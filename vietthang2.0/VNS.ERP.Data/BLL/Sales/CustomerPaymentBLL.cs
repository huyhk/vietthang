using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerPaymentBLL:IBusiness
    {
        private CustomerPaymentDAL dal = new CustomerPaymentDAL();
        public CustomerPaymentBLL()
        { }
        public ListBase<CustomerPayments> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(CustomerPayments t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(CustomerPayments t)
        {
         
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }

        public int Delete(CustomerPayments t)
        {
            return dal.Delete(t);
        }
        public DataTable CustomerPaymentReports(DateTime tungay, DateTime denngay, string productType)
        {
            return dal.CustomerPaymentReports(tungay, denngay, productType);
        }
        public ListBase<CustomerPayments> GetObjectByTime(DateTime startDate, DateTime endDate, string branchCode, string productType)
        {
            return dal.GetObjectByTime(startDate, endDate, branchCode, productType);
        }
        public CustomerPayments GetTopBySuffixCustomerPaymentNo(string suffix)
        {
            return dal.GetTopBySuffixCustomerPaymentNo(suffix);
        }
        public CustomerPayments GetTopBySuffixCustomerPaymentNo5(string suffix)
        {
            return dal.GetTopBySuffixCustomerPaymentNo5(suffix);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerPayments);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerPayments);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerPayments);
        }

        #endregion
    }
}