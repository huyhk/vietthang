using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    public class AccountClassificationBLL:IBusiness
    {
        private AccountClassificationDAL dal = new AccountClassificationDAL();
        public AccountClassificationBLL() { }
        public System.Data.DataTable GetAllToDataTable()
        {
            return dal.GetAll();
        }
        public ListBase<AccountClassification> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(AccountClassification t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(AccountClassification t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        public int Delete(AccountClassification t)
        {
            return dal.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as AccountClassification);
        }

        public int Update(object obj)
        {
            return this.Update(obj as AccountClassification);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as AccountClassification);
        }

        #endregion
    }
}
