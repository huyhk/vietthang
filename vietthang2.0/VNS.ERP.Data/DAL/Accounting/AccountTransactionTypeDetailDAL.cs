using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    class AccountTransactionTypeDetailDAL : StockBaseDAL<AccountTransactionTypeDetail>
    {
        public AccountTransactionTypeDetailDAL()
        { }
        public AccountTransactionTypeDetailDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }

        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountTransactionTypeDetails_Select_All";
        }
        /// <summary>
        /// insert a AccountTransactionTypeDetail object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(AccountTransactionTypeDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionTypeDetails_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, t.DetailTransactionCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionName", System.Data.DbType.String, 50, t.DetailTransactionName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionTypeDetailDAL", "Insert(AccountTransactionTypeDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// update a AccountTransactionTypeDetail object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(AccountTransactionTypeDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionTypeDetails_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, t.TransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, t.DetailTransactionCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionName", System.Data.DbType.String, 50, t.DetailTransactionName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionTypeDetailDAL", "Update(AccountTransactionTypeDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public override int Delete(AccountTransactionTypeDetail t)
        {
            return Delete(t.TransactionTypeCode,t.DetailTransactionCode);
        }


        /// <summary>
        /// Delete a AccountTransactionTypeDetail  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="preiodCode"></param>
        /// <returns></returns>
        public int Delete(string transactionTypeCode, string detailTransactionCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionTypeDetails_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, transactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, detailTransactionCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionTypeDetailDAL", "Delete(string transactionTypeCode, string detailTransactionCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Get List AccountTransactionTypeDetail by TransactionTypeCode
        /// </summary>
        /// <param name="transactionTypeCode"></param>
        /// <returns></returns>
        public ListBase<AccountTransactionTypeDetail> GetListObjectByType(string transactionTypeCode)
        {
       
            bool alreadyOpen = false;
            DbDataReader reader = null;
            AccountTransactionTypeDetail obj = null;
            ListBase<AccountTransactionTypeDetail> lstReturn = new ListBase<AccountTransactionTypeDetail>();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionTypeDetails_SelectByType";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, transactionTypeCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionTypeDetail(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("AccountTransactionTypeDetailDAL", "GetListObjectByType(string transactionTypeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
    }
}