
using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Premixs
{
   public class PremixInventoryBLL
    {
       private PremixInventoryDAL dal = new PremixInventoryDAL();

       public PremixInventoryBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<PremixInventory> GetbyStockCode(string _StockCode, string _PeriodCode)
        {
            return dal.GetByStockCode(_StockCode, _PeriodCode);
        }

        /// <summary>
        /// Insert a PremixInventory object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

       public int Insert(ListBase<PremixInventory> t, string stockCode, string periodCode)
           {
               int Error=0;
               if (t.Count > 0)
               {
                   dal.Open();
                   dal.BeginTransaction();
                   Error = dal.DeleteByStockCode(stockCode, periodCode);
                   if (Error == 0)
                       foreach (PremixInventory ItemInventory in t)
                       {
                           Error = dal.Insert(ItemInventory);
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
                   Error = dal.DeleteByStockCode(stockCode, periodCode);
               }
               return Error;
                   
               
           }
      
    }
}
