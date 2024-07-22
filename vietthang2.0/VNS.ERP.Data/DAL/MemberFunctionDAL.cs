using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Utils;
using VNS.Data.DAL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class MemberFunctionDAL : StockBaseDAL<MemberFunction>
    {
        public MemberFunctionDAL() { }
        public MemberFunctionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_MemberFunctions_GetAll";
            //base.SetValues();
        }
        public ListBase<MemberFunction> GetAllForMemberID(string _MemberID)
        {
            ListBase<MemberFunction> lobj = new ListBase<MemberFunction>();
            bool alreadyOpen = false;
            DbDataReader reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MemberFunctions_GetAll_For_MemberID";
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _MemberID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    MemberFunction obj = new MemberFunction(reader);
                    lobj.Add(obj);
                }
                reader.Close();

            }
            catch (Exception excp)
            {
                //iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "GetByMemberIDForDesign(string _MemberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lobj;
        }
        public DataTable DTGetByMemberID(string _MemberID)
        {
           
            DataTable DT = new DataTable();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_MemberFunctions_GetByMemberID";
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _MemberID));
                cmd.Parameters.Add(db.CreateParameter("@ForEdit", System.Data.DbType.Boolean, 1, 1));
                DT=db.ExecuteTable(cmd);
              
            }
            catch (Exception excp)
            {
                //iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "DTGetByMemberID(string _MemberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return DT;
        }
        public int DeleteByMemberID(string _MemberID)
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
                cmd.CommandText = "usp_MemberFunctions_Delete_By_MemberID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, _MemberID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Update(MemberFunction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Insert(MemberFunction t)
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
                cmd.CommandText = "usp_MemberFunctions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@Functionname", System.Data.DbType.String, 50, t.FunctionName));
                cmd.Parameters.Add(db.CreateParameter("@AllowView", System.Data.DbType.Boolean, 1, t.AllowView));
                cmd.Parameters.Add(db.CreateParameter("@AllowAdd", System.Data.DbType.Boolean, 1, t.AllowAdd));
                cmd.Parameters.Add(db.CreateParameter("@AllowEdit", System.Data.DbType.Boolean, 1, t.AllowEdit));
                cmd.Parameters.Add(db.CreateParameter("@AllowDelete", System.Data.DbType.Boolean, 1, t.AllowDelete));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@AllowEditOther", System.Data.DbType.Boolean, 1, t.AllowEditOther));
                cmd.Parameters.Add(db.CreateParameter("@AllowDeleteOther", System.Data.DbType.Boolean, 1, t.AllowDeleteOther));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Insert(MemberFunction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Update(MemberFunction t)
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
                cmd.CommandText = "usp_MemberFunctions_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@Functionname", System.Data.DbType.String, 50, t.FunctionName));
                cmd.Parameters.Add(db.CreateParameter("@AllowView", System.Data.DbType.Boolean, 1, t.AllowView));
                cmd.Parameters.Add(db.CreateParameter("@AllowAdd", System.Data.DbType.Boolean, 1, t.AllowAdd));
                cmd.Parameters.Add(db.CreateParameter("@AllowEdit", System.Data.DbType.Boolean, 1, t.AllowEdit));
                cmd.Parameters.Add(db.CreateParameter("@AllowDelete", System.Data.DbType.Boolean, 1, t.AllowDelete));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Update(MemberFunction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public override int Delete(MemberFunction t)
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
                cmd.CommandText = "usp_MemberFunctions_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MemberID", System.Data.DbType.String, 20, t.MemberID));
                cmd.Parameters.Add(db.CreateParameter("@Functionname", System.Data.DbType.String, 50, t.FunctionName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ItemDAL", "Delete(MemberFunction t)", excp.Message);
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
