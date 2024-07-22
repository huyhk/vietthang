using VNS.Data.DAL;
using VNS.Utils;
using System.Data.Common;
using VNS.Common;
using System;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    class AccountClassificationDAL : StockBaseDAL<AccountClassification>
    {
        public AccountClassificationDAL()
        {}
        public AccountClassificationDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountClassifications_Select_All";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetAll()
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_AccountClassifications_Select_All";
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountClassificationDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        /// <summary>
        /// insert a AccountClassification object into database 
        /// return: 0: successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(AccountClassification t)
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
                cmd.CommandText = "usp_AccountClassifications_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ClassificationCode", System.Data.DbType.String, 10, t.ClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@ClassificationName", System.Data.DbType.String, 50, t.ClassificationName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String,10, t.ClassificationTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountClassificationDAL", "Insert(AccountClassification t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
                return iError;
        }
        /// <summary>
        /// update a AccountClassification object into database
        /// return: 0: successful, -1: error
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(AccountClassification t)
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
                cmd.CommandText = "usp_AccountClassifications_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ClassificationCode", System.Data.DbType.String, 10, t.ClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@ClassificationName", System.Data.DbType.String, 50, t.ClassificationName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@ClassificationTypeCode", System.Data.DbType.String, 10, t.ClassificationTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountClassificationDAL", "Update(AccountClassification t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// delete a AccountClassification object in the database
        /// Return: 0:successful
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(AccountClassification t)
        {
            return Delete(t.ClassificationCode);
        }
        /// <summary>
        /// Delete a AccountClassification  object by the ID
        /// Return: 0:successful
        /// </summary>
        /// <param name="classificationCode"></param>
        /// <returns></returns>
        public int Delete(string classificationCode)
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
                cmd.CommandText = "usp_AccountClassifications_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ClassificationCode", System.Data.DbType.String, 10, classificationCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountClassificationDAL", "Delete(string classificationCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
      
     
    }
}

