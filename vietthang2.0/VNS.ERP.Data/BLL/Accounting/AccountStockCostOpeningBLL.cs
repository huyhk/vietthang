using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockCostOpeningBLL : IBusiness
    {
        AccountStockCostOpeningDAL dal = new AccountStockCostOpeningDAL();
        public AccountStockCostOpeningBLL() { }
        public ListBase<AccountStockCostOpening> GetAll()
        {
            return dal.GetObjectAll();
        }
        public VNS.Common.ListBase<AccountStockCostOpening> GetByPeriodCode(string periodCode)
        {
            return dal.GetByPeriodCode(periodCode);
        }
        public int Insert(ListBase<AccountStockCostOpening> lst, string periodCode)
        {
            int Error = 0;
            if (lst.Count > 0)
            {
                dal.Open();
                dal.BeginTransaction();
                Error = dal.DeleteByPeriodCode(periodCode);
                if (Error == 0)
                    foreach (AccountStockCostOpening accStockCostOpening in lst)
                    {
                        if (Error == 0)
                        {
                            Error = dal.Insert(accStockCostOpening);
                        }
                        if (Error != 0) break;
                    }

                if (Error == 0)
                    dal.Commit();
                else
                    dal.Rollback();

                dal.Close();
            }
            else
            {
                Error = dal.DeleteByPeriodCode(periodCode);
            }
            return Error;
        }
        public int Update(AccountStockCostOpening t)
        {
            return dal.Update(t);
        }
        public int Delete(AccountStockCostOpening t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountStockCostOpening);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountStockCostOpening);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountStockCostOpening);
        }
        #endregion
    }
}
