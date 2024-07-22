using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data
{
  public  class InventoryBLL
    {
      private InventoryDAL   dal = new InventoryDAL ();

      public InventoryBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<Inventory> GetbyStockCode(string _StockCode,string _PeriodCode)
        {
            return dal.GetByStockCode(_StockCode,_PeriodCode);
        }

        /// <summary>
        /// Insert a Items object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

      public int Insert(ListBase<Inventory>  t,string StockCode,string PeriodCode)
           {
               int Error=0;
               if (t.Count > 0)
               {
                   dal.Open();
                   dal.BeginTransaction();
                   Error = dal.DeleteByStockCode(StockCode, PeriodCode);
                   if (Error == 0)
                       foreach (Inventory ItemInventory in t)
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
                   Error = dal.DeleteByStockCode(StockCode, PeriodCode);
               }
               return Error;
                   
               
           }
       
           
    
    }
}
