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
    public class ManufacturePlanWeekDAL : BaseDAL<ManufacturePlanWeek>
    {
        public ManufacturePlanWeekDAL() { }
        public ManufacturePlanWeekDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ManufacturePlanWeek_Select_All";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturePlanWeekID"></param>
        /// <returns></returns>
        public DataTable GetDetailMaterial(Guid manufacturePlanWeekID)
        {
            DataTable dtReturn=new DataTable();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanWeek_Select_Detail_Material";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, manufacturePlanWeekID));
                dtReturn = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "GetDetailMaterial(Guid manufacturePlanMonthID)", excp.Message);
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
        /// 
        public ListBase<ManufacturePlanWeekDetail> GetSumDetail(Guid manufacturePlanWeekID)
        {
            ListBase<ManufacturePlanWeekDetail> lstReturn = new ListBase<ManufacturePlanWeekDetail>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanWeek_Select_Sum_Detail";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, manufacturePlanWeekID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new ManufacturePlanWeekDetail(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "GetDetail(Guid manufacturePlanMonthID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="manufacturePlanWeekID"></param>
        /// <returns></returns>
        public ListBase<ManufacturePlanWeekDetail> GetDetail(Guid manufacturePlanWeekID)
        {
            ListBase<ManufacturePlanWeekDetail> lstReturn = new ListBase<ManufacturePlanWeekDetail>();
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanWeek_Select_Detail";
                cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, manufacturePlanWeekID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new ManufacturePlanWeekDetail(reader));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "GetDetail(Guid manufacturePlanWeekID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<ManufacturePlanWeek> GetByStockCode(string sCode, int year)
        {
            DataSet ds = null;
            ListBase<ManufacturePlanWeek> lstReturn = new ListBase<ManufacturePlanWeek>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ManufacturePlanWeek_Select_By_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, sCode));
                cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, year));
                ds = db.ExecuteDataSet(cmd);

                DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["ManufacturePlanWeekID"], ds.Tables[1].Columns["ManufacturePlanWeekID"]);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ManufacturePlanWeek pc = new ManufacturePlanWeek();
                    pc.FromDataRow(dr);
                    foreach (DataRow dr1 in dr.GetChildRows("Detail"))
                    {
                        ManufacturePlanWeekDetail pcd = new ManufacturePlanWeekDetail();
                        pcd.FromDataRow(dr1);
                        pc.Detail.Add(pcd);
                    }
                    lstReturn.Add(pc);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufacturePlanWeeksDAL", "GetByStockCode(string sCode, int year)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(ManufacturePlanWeek t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeek_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, t.YearNo));
                Cmd.Parameters.Add(db.CreateParameter("@WeekNo", System.Data.DbType.Int32, 4, t.WeekNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                t.ManufacturePlanWeekID = (Guid)Cmd.Parameters["@ManufacturePlanWeekID"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "Insert(ManufacturePlanWeek t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ManufacturePlanWeek t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeek_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@YearNo", System.Data.DbType.Int32, 4, t.YearNo));
                Cmd.Parameters.Add(db.CreateParameter("@WeekNo", System.Data.DbType.Int32, 4, t.WeekNo));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "Update(ManufacturePlanWeek t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ManufacturePlanWeek t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ManufacturePlanWeek_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ManufacturePlanWeekID", System.Data.DbType.Guid, 16, t.ManufacturePlanWeekID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanWeekDAL", "Delete(ManufacturePlanWeek t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
