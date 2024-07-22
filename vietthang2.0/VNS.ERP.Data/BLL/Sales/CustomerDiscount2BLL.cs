using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscount2BLL : IBusiness
    {
        CustomerDiscount2DAL dal = new CustomerDiscount2DAL();
        public CustomerDiscount2BLL() { }
        public ListBase<CustomerDiscount2> GetBySubjectCode(string subjectCode)
        {
            return dal.GetBySubjectCode(subjectCode);
        }
        public ListBase<CustomerDiscount2> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(CustomerDiscount2 t)
        {
            return dal.Insert(t);
        }
        public int Update(CustomerDiscount2 t)
        {
            return dal.Update(t);
        }
        public int Delete(CustomerDiscount2 t)
        {
            return dal.Delete(t);
        }

        public CustomerDiscount2 GetInvoiceDiscount(string customerCode, DateTime invoiceDate, out Boolean error)
        {
            return dal.GetDiscount(customerCode, invoiceDate, enumCustomerDiscountType.INVOICE.ToString(), out error);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerDiscount2);
        }
        public int Update(object obj)
        {
            return this.Update(obj as CustomerDiscount2);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerDiscount2);
        }
        #endregion
    }
}
