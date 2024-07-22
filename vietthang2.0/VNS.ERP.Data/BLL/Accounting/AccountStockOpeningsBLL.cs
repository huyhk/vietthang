using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockOpeningsBLL : IBusiness
    {
        AccountStockOpeningsDAL dal = new AccountStockOpeningsDAL();
        public AccountStockOpeningsBLL() { }
        public ListBase<AccountStockOpenings> GetAll()
        {
            return dal.GetObjectAll();
        }
        public VNS.Common.ListBase<AccountStockOpenings> GetByPeriodCode(string periodCode)
        {
            return dal.GetByPeriodCode(periodCode);
        }
        public DataTable GetInventoryProduct(DateTime endDate)
        {
            return dal.GetInventoryProduct(endDate);
        }
        public DataTable GetInventoryMaterial(DateTime endDate)
        {
            return dal.GetInventoryMaterial(endDate);
        }
        /// <summary>
        /// Insert a listbase of AccountStockOpenings into database
        /// </summary>
        /// <param name="lst">listbase of AccountStockOpenings</param>
        /// <param name="periodCode">Use to find and delete before insert</param>
        /// <param name="accountCode">MaterialAccount (6111) or ProductAccount (632), Use to find and delete before insert</param>
        /// <returns></returns>
        public int Insert(ListBase<AccountStockOpenings> lst, string periodCode, string accountCode)
        {
            int Error = 0;
            dal.Open();
            dal.BeginTransaction();
            if (lst.Count > 0)
            {
                Error = dal.DeleteDynamic("PeriodCode='" + periodCode + "' and left(AccountCode,"+ accountCode.Length.ToString() +")='" + accountCode +"'");
                if (Error == 0)
                    foreach (AccountStockOpenings accStockOpening in lst)
                    {
                        if (Error == 0)
                        {
                            Error = dal.Insert(accStockOpening);
                        }
                        if (Error != 0) break;
                    }
            }
            else
            {
                Error = dal.DeleteDynamic("PeriodCode='" + periodCode + "' and left(AccountCode," + accountCode.Length.ToString() + ")='" + accountCode + "'");
            }
            if (Error == 0)
                dal.Commit();
            else
                dal.Rollback();

            dal.Close();
            return Error;
        }
        /// <summary>
        /// Insert a listbase of AccountStockOpenings into database
        /// </summary>
        /// <param name="lst">listbase of AccountStockOpenings</param>
        /// <param name="periodCode">Use to find and delete before insert</param>
        /// <returns></returns>
        public int Insert(ListBase<AccountStockOpenings> lst, string periodCode)
        {
            int Error = 0;
            dal.Open();
            dal.BeginTransaction();
            if (lst.Count > 0)
            {
                Error = dal.DeleteByPeriodCode(periodCode);
                if (Error == 0)
                    foreach (AccountStockOpenings accStockOpening in lst)
                    {
                        if (Error == 0)
                        {
                            Error = dal.Insert(accStockOpening);
                        }
                        if (Error != 0) break;
                    }
            }
            else
            {
                Error = dal.DeleteByPeriodCode(periodCode);
            }
            if (Error == 0)
                dal.Commit();
            else
                dal.Rollback();

            dal.Close();
            return Error;
        }
        public int Update(AccountStockOpenings t)
        {
            return dal.Update(t);
        }
        public int Delete(AccountStockOpenings t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountStockOpenings);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountStockOpenings);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountStockOpenings);
        }
        #endregion
    }
}
