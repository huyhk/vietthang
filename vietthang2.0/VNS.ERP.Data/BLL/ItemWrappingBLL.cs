using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;


namespace  VNS.ERP.Data
{
   public  class ItemWrappingBLL:IBusiness 
    {
        private ItemWrappingDAL dal = new ItemWrappingDAL();

        public ItemWrappingBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<ItemWrapping   > GetAllAll()
        {
            return dal.GetAll ((int)enumItemType .Wrapping );
        }
       public ListBase<ItemWrapping> GetAll()
       {
           return dal.GetActive((int)enumItemType.Wrapping);
       }
        /// <summary>
        /// Insert a ItemWrappings object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(ItemWrapping t)
           {
              t.ItemType = (int)enumItemType.Wrapping ;
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
       /// Update  the ItemWrappings into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Update(ItemWrapping t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            int Error;
            ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            Error = ItemDal.Update((Item)t);

            if (Error == 0)
                Error = dal.Update(t);

            if (Error == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return Error;
        }
        /// <summary>
        /// delete a  ItemWrappings object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(ItemWrapping  t)
        {
            ItemDAL ItemDal = new ItemDAL(dal.DBHelper);
            return ItemDal.Delete((Item)t);
        }
       /// <summary>
       /// Get ItemCode object from Table
       /// </summary>
       /// <param name="_ProductCode"></param>
       /// <param name="_WeightCode"></param>
       /// <returns></returns>
       public string GetItemCode(string _ProductCode, string _WeightCode)
       {
           return dal.GetItemCode(_ProductCode, _WeightCode);
       }

       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as ItemWrapping );
            }

            public int Update(object obj)
            {
                return this.Update(obj as ItemWrapping);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as ItemWrapping);
            }

            #endregion
    
    }
}
