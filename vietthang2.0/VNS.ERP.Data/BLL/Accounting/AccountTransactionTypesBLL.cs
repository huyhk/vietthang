using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionTypesBLL : IBusiness
    {
        AccountTransactionTypesDAL dal = new AccountTransactionTypesDAL();
        public AccountTransactionTypesBLL() { }
        public ListBase<AccountTransactionTypes> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(AccountTransactionTypes t)
        {
            return dal.Insert(t);
        }
        public int Update(AccountTransactionTypes t)
        {
            return dal.Update(t);
        }
        public int Delete(AccountTransactionTypes t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountTransactionTypes);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransactionTypes);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransactionTypes);
        }
        #endregion
    }
}
