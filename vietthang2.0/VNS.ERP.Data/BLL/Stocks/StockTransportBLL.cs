using System;
using VNS.Common;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;

namespace  VNS.ERP.Data
{
   public  class StockTransportBLL:IBusiness 
    {
       private StockTransportDAL dal = new StockTransportDAL();

       public StockTransportBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
        //public ListBase<StockTransport > GetAll()
        //{
        //    return dal.GetObjectAll();
        //}
       public ListBase<StockTransport> GetAll(string _StockCode)
       {
           return dal.GetAll(_StockCode);
       }

        /// <summary>
        /// Insert a StockTransports object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(StockTransport t)
           {
               t.UserCreated = Contexts.CurrentUser.LoginName;
              return dal.Insert (t);
               
           }
       /// <summary>
       /// Update  the StockTransports into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Update(StockTransport t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        /// <summary>
        /// delete a  StockTransports object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(StockTransport  t)
        {
            return dal.Delete(t);
        }
       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as StockTransport );
            }

            public int Update(object obj)
            {
                return this.Update(obj as StockTransport);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as StockTransport);
            }

            #endregion
    
    }
}
