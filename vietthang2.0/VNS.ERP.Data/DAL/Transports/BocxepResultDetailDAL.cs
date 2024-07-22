using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data
{
    public class BocxepResultDetailDAL : BaseDAL<BocxepResultDetail>
    {
        public BocxepResultDetailDAL() { }
        public BocxepResultDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_BocxepResultDetail_Select_All";
        }
        public override int Insert(BocxepResultDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResultDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                Cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@Ngaythuong", System.Data.DbType.Decimal, 9, t.Ngaythuong));
                Cmd.Parameters.Add(db.CreateParameter("@Ngoaigio", System.Data.DbType.Decimal, 9, t.Ngoaigio));
                Cmd.Parameters.Add(db.CreateParameter("@Chunhat", System.Data.DbType.Decimal, 9, t.Chunhat));
                Cmd.Parameters.Add(db.CreateParameter("@Ngayle", System.Data.DbType.Decimal, 9, t.Ngayle));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@ResultDate", System.Data.DbType.DateTime, 8, t.ResultDate));
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetailDAL", "Insert(BocxepResultDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(BocxepResultDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResultDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                Cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.String, 20, t.TypeCode));
                Cmd.Parameters.Add(db.CreateParameter("@Ngaythuong", System.Data.DbType.Decimal, 9, t.Ngaythuong));
                Cmd.Parameters.Add(db.CreateParameter("@Ngoaigio", System.Data.DbType.Decimal, 9, t.Ngoaigio));
                Cmd.Parameters.Add(db.CreateParameter("@Chunhat", System.Data.DbType.Decimal, 9, t.Chunhat));
                Cmd.Parameters.Add(db.CreateParameter("@Ngayle", System.Data.DbType.Decimal, 9, t.Ngayle));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@ResultDate", System.Data.DbType.DateTime, 8, t.ResultDate));
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetailDAL", "Update(BocxepResultDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(BocxepResultDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResultDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetailDAL", "Delete(BocxepResultDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid resultID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResultDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetailDAL", "Delete(BocxepResultDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
