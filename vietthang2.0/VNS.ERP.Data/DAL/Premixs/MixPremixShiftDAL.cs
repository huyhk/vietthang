using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Premixs
{
    class MixPremixShiftDAL : StockBaseDAL<MixPremixShift>
    {
        public MixPremixShiftDAL() { }
        public MixPremixShiftDAL(DBHelper dbHelper) : base(dbHelper) { }
        public ListBase<MixPremixShift> GetByStockCode(string _StockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<MixPremixShift> lstShift = new ListBase<MixPremixShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixShifts_Select_StockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation= ds.Relations.Add("lstMixPremix",
                   ds.Tables[0].Columns["MixPremixShiftID"],
                   ds.Tables[1].Columns["MixPremixShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    MixPremixShift shift = new MixPremixShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation)) 
                    {
                        MixPremix mn = new MixPremix();
                        mn.LoadFromDataRow(drM);
                        shift.LstMixPremix.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MixPremixShiftDAL", "GetMixPremixbyStockCode(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }

        public ListBase<MixPremixShift> GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<MixPremixShift> lstShift = new ListBase<MixPremixShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixShifts_Select_ByTimeStockCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation= ds.Relations.Add("lstMixPremix",
                   ds.Tables[0].Columns["MixPremixShiftID"],
                   ds.Tables[1].Columns["MixPremixShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    MixPremixShift shift = new MixPremixShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation)) 
                    {
                        MixPremix mn = new MixPremix();
                        mn.LoadFromDataRow(drM);
                        shift.LstMixPremix.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MixPremixShiftDAL", "GetObjectByTimeStockCode(DateTime startDate,DateTime endDate,string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstShift;
        }
        
        /// <summary>
        /// Insert Object MixPremixShift into DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override int Insert(MixPremixShift t)
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
                cmd.CommandText = "usp_MixPremixShifts_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Int32, 4, t.Shift));
                cmd.Parameters.Add(db.CreateParameter("@MixDate", System.Data.DbType.DateTime, 4, t.MixDate));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, t.Status));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.MixPremixShiftID = (Guid)cmd.Parameters["@MixPremixShiftID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixShiftDAL", "Insert(MixPremixShift t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Delete object MixPremixShift into DataBase;
        /// </summary>
        /// <param name="mixPremixShiftID"></param>
        /// <returns></returns>
        public override int Delete(MixPremixShift t)
        {
            return Delete(t.MixPremixShiftID);
        }
        /// <summary>
        /// Delete object MixPremixShift by ID
        /// </summary>
        /// <param name="grindMaterialShiftID"></param>
        /// <returns></returns>
        public int Delete(Guid mixPremixShiftID)
        {
           int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixShifts_Delete_By_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, mixPremixShiftID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixShiftDAL", "Delete(Guid mixPremixShiftID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<MixPremixShift> GetByCodePremix(string codePremix)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            ListBase<MixPremixShift> lstShift = new ListBase<MixPremixShift>();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixs_Select_By_CodePremix";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CodePremix", System.Data.DbType.String, 50, codePremix));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("lstMixPremix",
                   ds.Tables[0].Columns["MixPremixShiftID"],
                   ds.Tables[1].Columns["MixPremixShiftID"]);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    MixPremixShift shift = new MixPremixShift();
                    shift.LoadFromDataRow(dr);
                    foreach (DataRow drM in dr.GetChildRows(DtRelation))
                    {
                        MixPremix mn = new MixPremix();
                        mn.LoadFromDataRow(drM);
                        shift.LstMixPremix.Add(mn);
                    }
                    lstShift.Add(shift);
                }


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MixPremixShiftDAL", String.Format("GetByCodePremix(string {0}))", codePremix), excp.Message);
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