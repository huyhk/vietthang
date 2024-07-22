using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data
{
     class TransportRouteDAL:BaseDAL<TransportRoute>
    {
        public TransportRouteDAL() { }
        public TransportRouteDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_TransportRoute_Select_All";
        }
        public override int Insert(TransportRoute t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TransportRoute_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.String, 20, t.RouteCode));
                Cmd.Parameters.Add(db.CreateParameter("@RouteName", System.Data.DbType.String, 50, t.RouteName));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));

                Cmd.Parameters.Add(db.CreateParameter("@IsTrungchuyen", System.Data.DbType.Boolean, 1, t.IsTrungchuyen));
                Cmd.Parameters.Add(db.CreateParameter("@StockIn", System.Data.DbType.AnsiString, 10, t.StockIn));
                Cmd.Parameters.Add(db.CreateParameter("@StockOut", System.Data.DbType.AnsiString, 10, t.StockOut));

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportRouteDAL", "Insert(TransportRoute t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(TransportRoute t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TransportRoute_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.String, 20, t.RouteCode));
                Cmd.Parameters.Add(db.CreateParameter("@RouteName", System.Data.DbType.String, 50, t.RouteName));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));

                Cmd.Parameters.Add(db.CreateParameter("@IsTrungchuyen", System.Data.DbType.Boolean, 1, t.IsTrungchuyen));
                Cmd.Parameters.Add(db.CreateParameter("@StockIn", System.Data.DbType.AnsiString, 10, t.StockIn));
                Cmd.Parameters.Add(db.CreateParameter("@StockOut", System.Data.DbType.AnsiString, 10, t.StockOut));

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportRouteDAL", "Update(TransportRoute t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(TransportRoute t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TransportRoute_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.String, 20, t.RouteCode));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportRouteDAL", "Delete(TransportRoute t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

    }
}
