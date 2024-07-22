using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentOpeningBLL : IBusiness
    {
        InstrumentOpeningDAL dal = new InstrumentOpeningDAL();
        public InstrumentOpeningBLL() { }
        public ListBase<InstrumentOpening> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(ListBase<InstrumentOpening> lst, string periodCode, string stockCode)
        {
            int Error = 0;
            dal.Open();
            dal.BeginTransaction();
            if (lst.Count > 0)
            {
                Error = dal.DeleteByPeriodCodeAndStockCode(periodCode,stockCode);
                if (Error == 0)
                    foreach (InstrumentOpening instrOpening in lst)
                    {
                        if (Error == 0)
                        {
                            Error = dal.Insert(instrOpening);
                        }
                        if (Error != 0) break;
                    }
            }
            else
            {
                Error = dal.DeleteByPeriodCodeAndStockCode(periodCode, stockCode);
            }
            if (Error == 0)
                dal.Commit();
            else
                dal.Rollback();

            dal.Close();
            return Error;
        }
        public ListBase<InstrumentOpening> GetByPeriodCodeAndStockCode(string periodCode, string stockCode)
        {
            return dal.GetByPeriodCodeAndStockCode(periodCode, stockCode);
        }
        public int Insert(InstrumentOpening t)
        {
            return dal.Insert(t);
        }
        public int Update(InstrumentOpening t)
        {
            return dal.Update(t);
        }
        public int Delete(InstrumentOpening t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as InstrumentOpening);
        }
        public int Update(object obj)
        {
            return this.Update(obj as InstrumentOpening);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as InstrumentOpening);
        }
        #endregion
    }
}
