using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.Data
{
    public class StockLocationDAL:StockBaseDAL<StockLocation>
    {
        public StockLocationDAL() { }
        public StockLocationDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_StockLoctions_Select_All";
            //base.SetValues();
        }
        public override int Insert(StockLocation t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try 
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockLocations_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0,System.Data.ParameterDirection.Output ));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockLocationDAL", "Insert(StockLocations t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public override int Update(StockLocation t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockLocations_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, t.StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10,t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockLocationDAL", "Update(StockLocations t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public int Delete(string _StockLocationCode, string _StockCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockLocations_Delete_PK";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockLocationCode", System.Data.DbType.String, 10, _StockLocationCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", System.Data.DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockLocationDAL", "Delete(string _StockLoactionCode, string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(StockLocation t)
        {
            return Delete(t.StockLocationCode,t.StockCode);
        }
        public int Delete(string _StockCode)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockLocations_Delete_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", System.Data.DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockLocationDAL", "(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<StockLocation> GetByStockCode(string _sCode)
        {
            bool alreadyOpen = false;
            ListBase<StockLocation> lobj = new ListBase<StockLocation>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockLocations_Select_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _sCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockLocation obj = new StockLocation(reader);
                    lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockLocationDAL", "GetByStockCode(string _sCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
    }
}
