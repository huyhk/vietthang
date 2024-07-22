using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class TechnicalTestReturnDAL : BaseDAL<TechnicalTestReturn>
    {
        public TechnicalTestReturnDAL() { }
        public TechnicalTestReturnDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_TechnicalTestReturn_Select_All";
        }
        //public TechnicalTestReturn GetByReturnID(Guid returnID)
        //{
        //    TechnicalTestReturn t = null;
        //    DbDataReader reader = null;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "usp_TechnicalTestReturn_Get_By_ReturnID";
        //        cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
        //        reader = db.ExecuteReader(cmd);
        //        if (reader.Read())
        //        {
        //            t = new TechnicalTestReturn(reader);
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("TechnicalTestReturnDAL", "GetByReturnID(Guid returnID)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return t;
        //}
        public int UpdateIsReceived(TechnicalTestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Update_IsReceived";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                if (t.UserReceived == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                }

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "UpdateIsReceived(TechnicalTestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int AppliedProductResult(Guid returnID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Applied_Product_Result";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "ApplieProductResult(Guid returnID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<TechnicalTestReturn> GetFromDataSet(DataSet ds)
        {
            ListBase<TechnicalTestReturn> lstReturn = new ListBase<TechnicalTestReturn>();
            TechnicalTestReturn.StructMaterialDetailTable = ds.Tables[1].Clone();
            TechnicalTestReturn.StructProductDetailTable = ds.Tables[2].Clone();

            DataRelation drDetail1 = ds.Relations.Add("Detail1", ds.Tables[0].Columns["ReturnID"], ds.Tables[1].Columns["ReturnID"]);
            DataRelation drDetail2 = ds.Relations.Add("Detail2", ds.Tables[0].Columns["ReturnID"], ds.Tables[2].Columns["ReturnID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TechnicalTestReturn ttr = new TechnicalTestReturn();
                ttr.LoadFromDataRow(dr);
                ttr.MaterialDetailTable = TechnicalTestReturn.StructMaterialDetailTable.Clone();
                ttr.ProductDetailTable = TechnicalTestReturn.StructProductDetailTable.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail1))
                {
                    DataRow dr2 = ttr.MaterialDetailTable.NewRow();
                    foreach (DataColumn dc in ttr.MaterialDetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        //if (dr2.IsNull(dc.Caption))
                        //{
                        //    dr2[dc.Caption] = string.Empty;
                        //}
                    }
                    ttr.MaterialDetailTable.Rows.Add(dr2);
                }
                foreach (DataRow dr1 in dr.GetChildRows(drDetail2))
                {
                    DataRow dr2 = ttr.ProductDetailTable.NewRow();
                    foreach (DataColumn dc in ttr.ProductDetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        //if (dr2.IsNull(dc.Caption))
                        //{
                        //    dr2[dc.Caption] = string.Empty;
                        //}
                    }

                    ttr.ProductDetailTable.Rows.Add(dr2);
                }
                lstReturn.Add(ttr);
            }
            return lstReturn;
        }
        public ListBase<TechnicalTestReturn> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<TechnicalTestReturn> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TechnicalTestReturn_Select_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "GetForPeriod(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

        public ListBase<TechnicalTestReturn> GetForPeriodAndStock(DateTime startDate, DateTime endDate, string stockCode)
        {
            DataSet ds = null;
            ListBase<TechnicalTestReturn> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TechnicalTestReturn_Select_For_Period_And_Stock";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "GetForPeriodAndStoc(DateTime startDate, DateTime endDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

        public int CheckResultImportStatus(Guid returnID, string itemEncryptCode, string techCode, bool isProduct)
        {
            int status = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Check_Result_Import_Status";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                if (returnID == null || returnID == Guid.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
                }
                Cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, itemEncryptCode));
                Cmd.Parameters.Add(db.CreateParameter("@TechCode", System.Data.DbType.String, 10, techCode));
                Cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, isProduct));
                Cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                status = db.ExecuteNonQuery(Cmd);
                status = (int)Cmd.Parameters["@Status"].Value;
               
            }
            catch (Exception excp)
            {
                status = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "CheckResultImportStatus(Guid returnID, string itemEncryptCode, string techCode, bool isProduct)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return status;
        }
        public override int Insert(TechnicalTestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID, ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnDate", System.Data.DbType.DateTime, 8, t.ReturnDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                //Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ReturnID = (Guid)Cmd.Parameters["@ReturnID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "Insert(TechnicalTestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(TechnicalTestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnDate", System.Data.DbType.DateTime, 8, t.ReturnDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                //Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "Update(TechnicalTestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(TechnicalTestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TechnicalTestReturn_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TechnicalTestReturnDAL", "Delete(TechnicalTestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
