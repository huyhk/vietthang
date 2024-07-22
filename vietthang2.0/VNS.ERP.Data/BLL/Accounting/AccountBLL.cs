using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.Accounting
{
    public class AccountBLL : IBusiness
    {
        AccountDAL dal = new AccountDAL();
        AccountSubjectTypeDAL dal1;
        public AccountBLL() { }

        public ListBase<Account> GetObjectDynamic(string WhereCondition,string OrderByExpression)
        {
          return  dal.GetObjectDynamic(WhereCondition, OrderByExpression);
        }
        public ListBase<AccountSubjectType> GetAccountSubjectType(string accountCode)
        {
            return dal.GetAccountSubjectType(accountCode);
        }
        public ListBase<Account> GetAll()
        {
            return dal.GetObjectAll();
        }
        //public ListBase<Account> GetListAccountByAccountParent()
        //{
        //    return dal.GetListAccountByAccountLevel(1);
        //}
        public ListBase<Account> GetListAccountIsNotParentAccount()
        {
            return dal.GetListAccountIsNotParentAccount();
        }
        public int Insert(Account t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new AccountSubjectTypeDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (AccountSubjectType accst in t.LstAccSubjectType)
                {
                    if (iError == 0)
                    {
                        iError = dal1.Insert(accst);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(Account t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal1 = new AccountSubjectTypeDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError= dal.Update(t);
            if (iError == 0)
            {
                iError = dal1.DeleteByAccountCode(t.AccountCode);
            }
            if (iError == 0)
            {
                foreach (AccountSubjectType accst in t.LstAccSubjectType)
                {
                    if (iError == 0)
                    {
                        iError = dal1.Insert(accst);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(Account t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as Account);
        }
        public int Update(object obj)
        {
            return this.Update(obj as Account);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as Account);
        }
        #endregion

        public ListBase<Account> GetTKTienvay()
        {
            return dal.GetObjectDynamic("left(AccountCode, 3) in ('311','315','341')");
        }
    }
}
