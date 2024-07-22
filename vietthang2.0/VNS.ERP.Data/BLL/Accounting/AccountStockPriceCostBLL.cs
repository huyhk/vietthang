using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStockPriceCostBLL : IBusiness
    {
        AccountStockPriceCostDAL dal = new AccountStockPriceCostDAL();
        public AccountStockPriceCostBLL() { }
        public ListBase<AccountStockPriceCost> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        public void UpdateOutStockCostPriceProduct(string periodCode)
        {
            dal.UpdateOutStockCostPriceProduct(periodCode);
        }
        /// <summary>
        /// Update OutStock CostPrice
        /// </summary>
        /// <param name="periodCode">PeriodCode</param>
        public void UpdateOutStockCostPrice(string periodCode)
        {
            dal.UpdateOutStockCostPrice(periodCode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public DataTable GetMaterialOutStockPrice(string periodCode)
        {
            return dal.GetMaterialOutStockPrice(periodCode);
        }
        public DataTable GetProductOutStockPrice(string periodCode)
        {
            return dal.GetProductOutStockPrice(periodCode);
        }
        public int Insert(ListBase<AccountStockPriceCost> lst, string periodCode, string accountCode)
        {
            int Error = 0;
            dal.Open();
            dal.BeginTransaction();
            if (lst.Count > 0)
            {
                Error = dal.DeleteDynamic("PeriodCode='" + periodCode + "' and left(AccountCode," + accountCode.Length.ToString() + ")='" + accountCode + "'");
                if (Error == 0)
                    foreach (AccountStockPriceCost AccStockPriceCost in lst)
                    {
                        if (Error == 0)
                        {
                            Error = dal.Insert(AccStockPriceCost);
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
        public int Insert(AccountStockPriceCost t)
        {
            return dal.Insert(t);
        }
        public int Update(AccountStockPriceCost t)
        {
            return dal.Update(t);
        }
        public int Delete(AccountStockPriceCost t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountStockPriceCost);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountStockPriceCost);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountStockPriceCost);
        }
        #endregion
    }
}
