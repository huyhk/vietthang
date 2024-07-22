using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data
{
    public class SubjectTypeDAL : StockBaseDAL<SubjectType>
    {
        public SubjectTypeDAL()
        { }
        public SubjectTypeDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_SubjectTypes_Select_All";
        }
        /// <summary>
        /// Insert object SubjectType in to DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(SubjectType t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_SubjectTypes_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SubjectTypeCode", System.Data.DbType.String, 10, t.SubjectTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectTypeName", System.Data.DbType.String, 50, t.SubjectTypeName));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SubjectTypeDAL", "Insert(SubjectType t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Update object SubjectType into Database
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(SubjectType t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_SubjectTypes_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SubjectTypeCode", System.Data.DbType.String, 10, t.SubjectTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectTypeName", System.Data.DbType.String, 50, t.SubjectTypeName));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SubjectTypeDAL", "Update(SubjectType t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;

        }

        /// <summary>
        /// Delete Object SubjectType out DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Delete(SubjectType t)
        {
            return Delete(t.SubjectTypeCode);
        }
        public int Delete(string subjectTypeCode)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_SubjectTypes_Delete_ID";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SubjectTypeCode", System.Data.DbType.String, 10, subjectTypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("SubjectTypeDAL", "Delete(string subjectTypeCode)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
