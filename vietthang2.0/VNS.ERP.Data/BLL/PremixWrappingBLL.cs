using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;


namespace VNS.ERP.Data
{
   public class PremixWrappingBLL:IBusiness
    {
        private PremixWrappingDAL dal = new PremixWrappingDAL();

        public PremixWrappingBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<PremixWrapping > GetAll()
        {
            return dal.GetAll ((int)enumItemType .WrappingPremix );
        }
       public string GetItemCode(string _PremixCode)
       {
           return dal.GetItemCode(_PremixCode);
       }
      
        /// <summary>
        /// Insert a PremixWrappings object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(PremixWrapping t)
           {
              t.ItemType = (int)enumItemType.WrappingPremix ;
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
       /// Update  the PremixWrappings into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Update(PremixWrapping t)
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
        /// delete a  PremixWrappings object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(PremixWrapping  t)
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
      

       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as PremixWrapping );
            }

            public int Update(object obj)
            {
                return this.Update(obj as PremixWrapping);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as PremixWrapping);
            }

            #endregion
    }
}
