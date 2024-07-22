using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSubjectTypeBLL : IBusiness
    {
        AccountSubjectTypeDAL dal = new AccountSubjectTypeDAL();
        public AccountSubjectTypeBLL() { }
        public ListBase<AccountSubjectType> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(AccountSubjectType t)
        {
            return dal.Insert(t);
        }
        public int Update(AccountSubjectType t)
        {
            return dal.Update(t);
        }
        public int Delete(AccountSubjectType t)
        {
            return dal.Delete(t);
        }

        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountSubjectType);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountSubjectType);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountSubjectType);
        }
        #endregion
    }
}
