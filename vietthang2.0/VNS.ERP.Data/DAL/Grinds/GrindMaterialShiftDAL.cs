using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Grinds
{
    class GrindMaterialShiftDAL : StockBaseDAL<GrindMaterialShift>
    {
        public GrindMaterialShiftDAL() { }
        public GrindMaterialShiftDAL(DBHelper dbHelper) : base(dbHelper) { }
        public ListBase<GrindMaterialShift> GetByStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<GrindMaterialShift> lstShift = new ListBase<GrindMaterialShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GrindMaterialShifts_Select_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation= ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["GrindMaterialShiftID"],
                   ds.Tables[1].Columns["GrindMaterialShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    GrindMaterialShift shift = new GrindMaterialShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation)) 
                    {
                        GrindMaterials mn = new GrindMaterials();
                        mn.LoadFromDataRow(drM);
                        shift.LstGrindMaterial.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("GrindMaterialShiftDAL", "GetByStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }
        public ListBase<GrindMaterialShift> GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<GrindMaterialShift> lstShift = new ListBase<GrindMaterialShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GrindMaterialShifts_Select_ByTimeStockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Manu",
                   ds.Tables[0].Columns["GrindMaterialShiftID"],
                   ds.Tables[1].Columns["GrindMaterialShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    GrindMaterialShift shift = new GrindMaterialShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation))
                    {
                        GrindMaterials mn = new GrindMaterials();
                        mn.LoadFromDataRow(drM);
                        shift.LstGrindMaterial.Add(mn);
                    }
                    lstShift.Add(shift);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("GrindMaterialShiftDAL", " GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }

        /// <summary>
        /// Insert Object GrindMaterialShift into DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(GrindMaterialShift t)
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
                cmd.CommandText = "usp_GrindMaterialShifts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@GrindDate", System.Data.DbType.DateTime, 4, t.GrindDate));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, t.Status));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@ShiftLeader", System.Data.DbType.String, 10, t.ShiftLeader));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.GrindMaterialShiftID = (Guid)cmd.Parameters["@GrindMaterialShiftID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialShiftDAL", "Insert(GrindMaterialShift t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(GrindMaterialShift t)
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
                cmd.CommandText = "usp_GrindMaterialShifts_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@GrindDate", System.Data.DbType.DateTime, 4, t.GrindDate));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, t.Status));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, t.GrindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                cmd.Parameters.Add(db.CreateParameter("@ShiftLeader", System.Data.DbType.String, 10, t.ShiftLeader));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                //if (iError == 0)
                //{
                //    t.GrindMaterialShiftID = (Guid)cmd.Parameters["@GrindMaterialShiftID"].Value;
                //}
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialShiftDAL", "Update(GrindMaterialShift t)", excp.Message);
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
        public override int Delete(GrindMaterialShift t)
        {
            return Delete(t.GrindMaterialShiftID);
        }
        /// <summary>
        /// Delete object GrindMaterialShift by ID
        /// </summary>
        /// <param name="grindMaterialShiftID"></param>
        /// <returns></returns>
        public int Delete(Guid grindMaterialShiftID)
        {
           int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GrindMaterialShifts_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, grindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialShiftDAL", "Delete(Guid grindMaterialShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
    }
}