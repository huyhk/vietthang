using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.KCS
{
    public class TestRequestReturnDetailDAL : BaseDAL<TestRequestReturnDetail>
    {
        public TestRequestReturnDetailDAL() { }
        public TestRequestReturnDetailDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_TestRequestReturnDetail_Select_All";
        }
        public int CancelApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturnDetail_Cancel_Apply_Result";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, itemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, techCode));
                if (subjectCode != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, isProduct));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "CancelApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int ApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturnDetail_Apply_Result1";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, itemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, techCode));
                if (subjectCode != string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, isProduct));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "ApplyResult(string itemEncryptCode, string techCode, string subjectCode, bool isProduct)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Insert(TestRequestReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturnDetail_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.String, 50, t.Result));
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, t.IsProduct));
                Cmd.Parameters.Add(db.CreateParameter("@IsApplied", System.Data.DbType.Boolean, 1, t.IsApplied));
                if (t.IsApplied)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateApplied", System.Data.DbType.DateTime, 8, t.DateApplied));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateApplied", System.Data.DbType.DateTime, 8, DBNull.Value));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "Insert(TestRequestReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(TestRequestReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturnDetail_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, t.ItemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, t.TechCode));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.String, 50, t.Result));
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, t.IsProduct));
                Cmd.Parameters.Add(db.CreateParameter("@IsApplied", System.Data.DbType.Boolean, 1, t.IsApplied));
                if (t.IsApplied)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateApplied", System.Data.DbType.DateTime, 8, t.DateApplied));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateApplied", System.Data.DbType.DateTime, 8, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "Update(TestRequestReturnDetail t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(TestRequestReturnDetail t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturnDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "Delete(TestRequestReturnDetail t)", excp.Message);
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
                Cmd.CommandText = "usp_TestRequestReturnDetail_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDetailDAL", "Delete(Guid returnID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
