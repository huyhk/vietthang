using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    public class AccountClassificationTypeBLL:IBusiness
    {
        private AccountClassificationTypeDAL dal = new AccountClassificationTypeDAL();
        public AccountClassificationTypeBLL() { }
        public ListBase<AccountClassificationType> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(AccountClassificationType t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(AccountClassificationType t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        public int Delete(AccountClassificationType t)
        {
            return dal.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as AccountClassificationType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as AccountClassificationType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as AccountClassificationType);
        }

        #endregion
    }
}
