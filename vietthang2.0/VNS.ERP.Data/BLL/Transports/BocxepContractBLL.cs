using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class BocxepContractBLL : IBusiness
    {
        BocxepContractDAL dal = new BocxepContractDAL();
        BocxepContractPriceDAL dalDetail = new BocxepContractPriceDAL();
        public BocxepContractBLL() { }
        public ListBase<BocxepContract> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<BocxepContract> GetAllFromDataSet()
        {
            return dal.GetAllFromDataSet();
        }
        public int Insert(BocxepContract t)
        {
            return dal.Insert(t);
        }
        public int Update(BocxepContract t)
        {
            return dal.Update(t);
        }
        public int Delete(BocxepContract t)
        {
           return dal.Delete(t);
        }
        public ListBase<BocxepContract> GetBySubjectCodeAndDate(string subjectCode, DateTime fromDate)
        {
            return dal.GetBySubjectCodeAndDate(subjectCode, fromDate);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as BocxepContract);
        }
        public int Update(object obj)
        {
            return this.Update(obj as BocxepContract);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as BocxepContract);
        }
        #endregion
    }
}
