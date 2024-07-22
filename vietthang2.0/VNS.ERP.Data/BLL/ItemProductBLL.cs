using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data
{
   public  class ItemProductBLL:IBusiness 
    {
       private ItemProductDAL dal = new ItemProductDAL();

       public ItemProductBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       
       public ListBase<ItemProduct> GetAll()
       {
           return dal.GetActive((int)enumItemType .Product );
       }
       public ListBase<ItemProduct> GetAllAll()
       {
           return dal.GetAll((int)enumItemType.Product);
       }
        /// <summary>
        /// Insert a ItemProducts object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(ItemProduct t)
           {
               t.ItemType = (int)enumItemType.Product;
               t.UserCreated = Contexts.CurrentUser.LoginName;
               int Error;
               ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
               dal.Open();
               dal.BeginTransaction();
             
               Error = ItemDal.Insert((Item)t);
               if (Error == 0)
                   Error = dal.Insert(t);
               if (Error == 0)
                  
                   dal.Commit();
               else
                   dal.Rollback();
               dal.Close();
               return Error;
               
           }
       /// <summary>
       /// Update  the ItemProducts into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public int Update(ItemProduct t)
        {

            t.UserUpdated = Contexts.CurrentUser.LoginName;
            int Error;
            ItemDAL ItemDal = new ItemDAL(dal .DBHelper );
            dal.Open();
            dal.BeginTransaction();
         
            Error = ItemDal.Update ((Item )t);

            if (Error == 0)
                Error = dal.Update (t);

            if (Error == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return Error;
        }
        /// <summary>
        /// delete a  ItemProducts object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(ItemProduct  t)
        {
             ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
             return ItemDal.Delete ((Item )t);
        }
       /// <summary>
       /// Get Itemcode object from Table
       /// </summary>
       /// <param name="_ProductCode"></param>
       /// <param name="_SizeCode"></param>
       /// <param name="_WeightCode"></param>
       /// <returns></returns>
       public string GetItemCode(string _ProductCode, string _SizeCode, string _WeightCode)
       {
           return dal.GetItemCode(_ProductCode, _SizeCode, _WeightCode);
       }
       public string GetProductCodeByItemCode(string _ItemCode)
       {
           return dal.GetProductCodeByItemCode(_ItemCode);
       }
       public ItemProduct GetByPSW(string _ProductCode, string _SizeCode, string _WeightCode)
       {
           return dal.GetByPSW(_ProductCode, _SizeCode, _WeightCode);
       }
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as ItemProduct );
            }

            public int Update(object obj)
            {
                return this.Update(obj as ItemProduct);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as ItemProduct);
            }

            #endregion
    
    }
}
