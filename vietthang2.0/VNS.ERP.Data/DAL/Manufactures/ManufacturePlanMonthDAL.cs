using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanMonthDAL : BaseDAL<ManufacturePlanMonth>
    {
        public ManufacturePlanMonthDAL() { }
        public ManufacturePlanMonthDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufacturePlanMonth_Select_All";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturePlanWeekID"></param>
        /// <returns></returns>
        public DataTable GetDetailMaterial(Guid manufacturePlanMonthID)
        {
            DataTable dtReturn = new DataTable();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanMonth_Select_Detail_Material";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, manufacturePlanMonthID));
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "GetDetailMaterial(Guid manufacturePlanMonthID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dtReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturePlanMonthID"></param>
        /// <returns></returns>
        public ListBase<ManufacturePlanMonthDetail> GetSumDetail(Guid manufacturePlanMonthID)
        {
            ListBase<ManufacturePlanMonthDetail> lstReturn = new ListBase<ManufacturePlanMonthDetail>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanMonth_Select_Sum_Detail";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, manufacturePlanMonthID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new ManufacturePlanMonthDetail(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "GetDetail(Guid manufacturePlanMonthID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// Return listbase of Detail
        /// </summary>
        /// <param name="manufacturePlanMonthID"></param>
        /// <returns></returns>
        public ListBase<ManufacturePlanMonthDetail> GetDetail(Guid manufacturePlanMonthID)
        {
            ListBase<ManufacturePlanMonthDetail> lstReturn = new ListBase<ManufacturePlanMonthDetail>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanMonth_Select_Detail";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, manufacturePlanMonthID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new ManufacturePlanMonthDetail(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "GetDetail(Guid manufacturePlanMonthID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<ManufacturePlanMonth> GetByStockCode(string sCode)
        {
            ListBase<ManufacturePlanMonth> lstReturn = new ListBase<ManufacturePlanMonth>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanMonth_Select_By_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, sCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new ManufacturePlanMonth(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "GetByStockCode(string sCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(ManufacturePlanMonth t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanMonth_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, t.ManufacturePlanMonthID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, t.YearNo));
                Cmd.Parameters.Add(db.CreateParameter("@MonthNo", System.Data.DbType.Int32, 4, t.MonthNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                t.ManufacturePlanMonthID = (Guid)Cmd.Parameters["@ManufacturePlanMonthID"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "Insert(ManufacturePlanMonth t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ManufacturePlanMonth t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanMonth_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, t.ManufacturePlanMonthID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, t.YearNo));
                Cmd.Parameters.Add(db.CreateParameter("@MonthNo", System.Data.DbType.Int32, 4, t.MonthNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "Update(ManufacturePlanMonth t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ManufacturePlanMonth t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanMonth_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanMonthID", System.Data.DbType.Guid, 16, t.ManufacturePlanMonthID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanMonthDAL", "Delete(ManufacturePlanMonth t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
