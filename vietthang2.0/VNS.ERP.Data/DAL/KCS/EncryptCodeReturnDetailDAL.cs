using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeReturnDetailDAL : BaseDAL<EncryptCodeReturnDetail>
    {
        public EncryptCodeReturnDetailDAL() { }
        public EncryptCodeReturnDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_EncryptCodeReturnDetail_Select_All";
        }
        public override int Insert(EncryptCodeReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturnDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.String, 50, t.Result));
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, t.IsProduct));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDetailDAL", "Insert(EncryptCodeReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(EncryptCodeReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturnDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.String, 50, t.Result));
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, t.IsProduct));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDetailDAL", "Update(EncryptCodeReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(EncryptCodeReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturnDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDetailDAL", "Delete(EncryptCodeReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid returnID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturnDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDetailDAL", "Delete(EncryptCodeReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
