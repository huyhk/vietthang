
using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
   public  class AccountTransactionTypeDetailBLL:IBusiness 
    {
       private AccountTransactionTypeDetailDAL dal = new AccountTransactionTypeDetailDAL();

       public AccountTransactionTypeDetailBLL()
		{}

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<AccountTransactionTypeDetail> GetAll()
       {
           return dal.GetObjectAll();
       }
       /// <summary>
       /// Insert a AccountTransactionTypeDetail object into database
       /// return: 0: success;
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>

       public int Insert(AccountTransactionTypeDetail t)
       {
          return dal.Insert(t);

       }
       /// <summary>
       /// Update  the AccountTransactionTypeDetail into Database.
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public int Update(AccountTransactionTypeDetail t)
       {
                  
           return dal.Update(t);
       }
       /// <summary>
       /// delete a  AccountTransactionTypeDetail object out of database
       /// return: 0: success
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
       public int Delete(AccountTransactionTypeDetail t)
       {
           return dal.Delete(t);
       }

       public ListBase<AccountTransactionTypeDetail> GetListObjectByType(string transactionTypeCode)
       {
           return dal.GetListObjectByType(transactionTypeCode);
       }

       #region IBusiness Members

       public int Insert(object obj)
       {
           return this.Insert(obj as AccountTransactionTypeDetail);
       }

       public int Update(object obj)
       {
           return this.Update(obj as AccountTransactionTypeDetail);
       }

       public int Delete(object obj)
       {
           return this.Delete(obj as AccountTransactionTypeDetail);
       }

       #endregion
   }
}