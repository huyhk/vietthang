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
    class ManufactureShiftDAL : StockBaseDAL<ManufactureShift>
    {
        public ManufactureShiftDAL() { }
        public ManufactureShiftDAL(DBHelper dbHelper) : base(dbHelper) { }
        public ListBase<ManufactureShift> GetByStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<ManufactureShift> lstShift = new ListBase<ManufactureShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_Select_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation= ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["ManufactureShiftID"],
                   ds.Tables[1].Columns["ManufactureShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ManufactureShift shift = new ManufactureShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation)) 
                    {
                        Manufacture mn = new Manufacture();
                        mn.LoadFromDataRow(drM);
                        shift.ListManufacture.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetManufacturebyStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }

        public DataSet GetReportsManufactures(string stockCode, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Reports_ByStockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 10, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 10, endDate));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetReportsManufactures(string stockCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet GetReportsManufacturesByTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo)
        {
            return GetReportsManufacturesByTime(stockCode, startDate, endDate, lineSxNo, false);
        }
        public DataSet GetReportsManufacturesByTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo, bool getKCSTest)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Reports_ByTime";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 10, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 10, endDate));
                cmd.Parameters.Add(db.CreateParameter("@LineSxNo", System.Data.DbType.String, 10, lineSxNo));
                cmd.Parameters.Add(db.CreateParameter("@GetKCSTest", System.Data.DbType.Boolean, 1, getKCSTest));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetReportsManufactures(string stockCode, DateTime startDate, DateTime endDate, int lineSxNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet GetReportsManufacturesTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Reports_Time";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 10, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 10, endDate));
                cmd.Parameters.Add(db.CreateParameter("@LineSxNo", System.Data.DbType.String, 10, lineSxNo));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetReportsManufactures(string stockCode, DateTime startDate, DateTime endDate, int lineSxNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Insert Object ManufactureShift into DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int  Insert(ManufactureShift t)
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
                cmd.CommandText = "usp_ManufactureShifts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@ShiftLeader", System.Data.DbType.String, 10, t.ShiftLeader));
                cmd.Parameters.Add(db.CreateParameter("@ViceLeader", System.Data.DbType.String, 10, t.ViceLeader));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureDate", System.Data.DbType.DateTime, 4, t.ManufactureDate));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, t.Status));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ManufactureShiftID = (Guid)cmd.Parameters["@ManufactureShiftID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureShiftDAL", "Insert(ManufactureShift t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Update objects ManufactureShift into DateBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Update(ManufactureShift t)
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
                cmd.CommandText = "usp_ManufactureShift_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, t.ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@ShiftLeader", System.Data.DbType.String, 10, t.ShiftLeader));
                cmd.Parameters.Add(db.CreateParameter("@ViceLeader", System.Data.DbType.String, 10, t.ViceLeader));
                cmd.Parameters.Add(db.CreateParameter("@ManufactureDate", System.Data.DbType.DateTime, 4, t.ManufactureDate));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, t.Status));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;

            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureDAL", "InsertManufactureShift(Manufacture t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Delete object ManufactureShift into DataBase;
        /// </summary>
        /// <param name="manufactureShiftID"></param>
        /// <returns></returns>
        public override int Delete(ManufactureShift t)
        {
            return Delete(t.ManufactureShiftID);
        }
        /// <summary>
        /// Delete object ManufactureShift by ID
        /// </summary>
        /// <param name="manufactureShiftID"></param>
        /// <returns></returns>
        public int Delete(Guid manufactureShiftID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, manufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureShiftDAL", "Delete(Guid manufactureShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;


        }
        public ListBase<ManufactureShift> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<ManufactureShift> lstShift = new ListBase<ManufactureShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShifts_SelectByTime_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (stockCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["ManufactureShiftID"],
                   ds.Tables[1].Columns["ManufactureShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ManufactureShift shift = new ManufactureShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation))
                    {
                        Manufacture mn = new Manufacture();
                        mn.LoadFromDataRow(drM);
                        shift.ListManufacture.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetObjectByTimeStockCode(DateTime startDate, DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }

        public ListBase<ManufactureShift> GetObjectByCodeBaoTP(string codeBaoTP)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<ManufactureShift> lstShift = new ListBase<ManufactureShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufacture_Select_By_CodeBaoTP";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CodeBaoTP", System.Data.DbType.String, 50, codeBaoTP));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["ManufactureShiftID"],
                   ds.Tables[1].Columns["ManufactureShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ManufactureShift shift = new ManufactureShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation))
                    {
                        Manufacture mn = new Manufacture();
                        mn.LoadFromDataRow(drM);
                        shift.ListManufacture.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureShiftDAL", "GetObjectByCodeBaoTP(string codeBaoTP)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }
        
    }
}
