using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountDAL : BaseDAL<Account>
    {
        public AccountDAL() { }
        public AccountDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_Account_Select_All";
            _spSelectDynamic = "usp_Account_SelectDynamic";
        }
        public ListBase<Account> GetListAccountIsNotParentAccount()
        {
            ListBase<Account> lstReturn = new ListBase<Account>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Accounts_Select_AccountCode_Is_Not_ParentAccount";
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new Account(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountDAL", "GetListAccountIsNotParentAccount()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<AccountSubjectType> GetAccountSubjectType(string accountCode)
        {
            ListBase<AccountSubjectType> lstReturn = new ListBase<AccountSubjectType>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Account_Select_AccountSubjectType";
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new AccountSubjectType(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountDAL", "GetAccountSubjectType(string accountCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(Account t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Account_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@AccountName", System.Data.DbType.String, 100, t.AccountName));
                Cmd.Parameters.Add(db.CreateParameter("@AccountType", System.Data.DbType.Byte, 1, t.AccountType));
                Cmd.Parameters.Add(db.CreateParameter("@AccountLevel", System.Data.DbType.Byte, 1, t.AccountLevel));
                if (t.AccountParent != null && t.AccountParent != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountParent", System.Data.DbType.String, 10, t.AccountParent));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountParent", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@DetailSubject", System.Data.DbType.Boolean, 1, t.DetailSubject));
                Cmd.Parameters.Add(db.CreateParameter("@DetailClassification", System.Data.DbType.Boolean, 1, t.DetailClassification));
                if (t.ClassificationTypeCode != null && t.ClassificationTypeCode != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String, 10, t.ClassificationTypeCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountDAL", "Insert(Account t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(Account t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Account_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@AccountName", System.Data.DbType.String, 100, t.AccountName));
                Cmd.Parameters.Add(db.CreateParameter("@AccountType", System.Data.DbType.Byte, 1, t.AccountType));
                Cmd.Parameters.Add(db.CreateParameter("@AccountLevel", System.Data.DbType.Byte, 1, t.AccountLevel));
                if (t.AccountParent != null && t.AccountParent != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountParent", System.Data.DbType.String, 10, t.AccountParent));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@AccountParent", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@DetailSubject", System.Data.DbType.Boolean, 1, t.DetailSubject));
                Cmd.Parameters.Add(db.CreateParameter("@DetailClassification", System.Data.DbType.Boolean, 1, t.DetailClassification));
                if (t.ClassificationTypeCode != null && t.ClassificationTypeCode != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String, 10, t.ClassificationTypeCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountDAL", "Update(Account t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(Account t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_Account_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountDAL", "Delete(Account t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        //public ListBase<Account> GetListAccountByAccountLevel(int accountLevel)
        //{
        //    ListBase<Account> lstReturn = new ListBase<Account>();
        //    DbDataReader reader = null;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_Accounts_Select_ByAccountLevel";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@AccountLevel", System.Data.DbType.Int32, 4, accountLevel));

        //        reader = db.ExecuteReader(cmd);
        //        while (reader.Read())
        //        {
        //            lstReturn.Add(new Account(reader));
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("AccountDAL", " GetListAccountByAccountLevel(int accountLevel)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return lstReturn;
        //}
    }
}
