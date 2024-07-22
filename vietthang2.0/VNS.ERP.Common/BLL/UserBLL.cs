using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Common
{
    public class UserBLL:IBusiness
    {
        private UserDAL dal = new UserDAL();

        public UserBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
        public ListBase<UserERP> GetAll()
        {
            return dal.GetObjectAll();
        }
       public UserERP GetbyLoginName(string _LoginName)
        {
            return dal.GetByLoginName(_LoginName);
        }

        /// <summary>
        /// Insert a Users object into database
        /// return: 0: success;
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
   
           public int Insert(UserERP t)
           {
              return dal.Insert (t);
               
           }
       /// <summary>
       /// Update  the Users into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Update(UserERP t)
        {
            return dal.Update(t);
        }
        /// <summary>
        /// delete a  Users object out of database
        /// return: 0: success
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Delete(UserERP  t)
        {
            return dal.Delete(t);
        }
       
            #region IBusiness Members

            public int Insert(object obj)
            {
                return this.Insert(obj as UserERP );
            }

            public int Update(object obj)
            {
                return this.Update(obj as UserERP);
            }

            public int Delete(object obj)
            {
                return this.Delete(obj as UserERP);
            }

            #endregion
    
    }
}
