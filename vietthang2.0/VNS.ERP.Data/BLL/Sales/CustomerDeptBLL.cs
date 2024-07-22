using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDeptBLL:IBusiness
    {
        private CustomerDeptDAL DAL = new CustomerDeptDAL();
        public CustomerDeptBLL() { }
        public ListBase<CustomerDept> GetAll()
        {
            return DAL.GetObjectAll();
        }
        
        public ListBase<CustomerDept> GetBySubjectCode(string subjectCode)
        {
            return DAL.GetBySubjectCode(subjectCode);
        }
        public CustomerDept GetBySubjectCodeAndDate(string subjectCode, DateTime d)
        {
            return DAL.GetBySubjectCodeAndDate(subjectCode, d);
        }
        public int Insert(CustomerDept t)
        {
            return DAL.Insert(t);
        }
        public int Update(CustomerDept t)
        {
            return DAL.Update(t);
        }
        public int Delete(CustomerDept t)
        {
            return DAL.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerDept);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerDept);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerDept);
        }

        #endregion
    }
}
