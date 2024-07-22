using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class BocxepResultDAL : BaseDAL<BocxepResult>
    {
        public BocxepResultDAL() { }
        public BocxepResultDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_BocxepResult_Select_All";
        }
        private ListBase<BocxepResult> GetFromDataSet(DataSet ds)
        {
            ListBase<BocxepResult> lstReturn = new ListBase<BocxepResult>();

            DataRelation drDetail1 = ds.Relations.Add("Detail1", ds.Tables[0].Columns["ResultID"], ds.Tables[1].Columns["ResultID"]);
            DataRelation drDetail2 = ds.Relations.Add("Detail2", ds.Tables[1].Columns["Detail1ID"], ds.Tables[2].Columns["Detail1ID"]);
            DataRelation drDetail3 = ds.Relations.Add("Detail3", ds.Tables[2].Columns["Detail2ID"], ds.Tables[3].Columns["Detail2ID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BocxepResult bxr = new BocxepResult();
                bxr.FromDataRow(dr);
                foreach (DataRow dr1 in dr.GetChildRows(drDetail1))
                {
                    BocxepResultDetail1 detail1 = new BocxepResultDetail1();
                    detail1.FromDataRow(dr1);
                    foreach (DataRow dr2 in dr1.GetChildRows(drDetail2))
                    {
                        BocxepResultDetail2 detail2 = new BocxepResultDetail2();
                        detail2.FromDataRow(dr2);
                        foreach (DataRow dr3 in dr2.GetChildRows(drDetail3))
                        {
                            BocxepResultDetail3 detail3 = new BocxepResultDetail3();
                            detail3.FromDataRow(dr3);
                            detail2.ListDetail3.Add(detail3);
                        }
                        detail1.ListDetail2.Add(detail2);
                    }
                    bxr.ListDetail1.Add(detail1);
                }
                lstReturn.Add(bxr);
            }
            return lstReturn;
        }
        public ListBase<BocxepResult> GetForContractNoAndStockCode(string contractNo, string stockCode)
        {
            DataSet ds = null;
            ListBase<BocxepResult> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_BocxepResult_Select_For_StockCode_ContractNo";
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BocxepResultDAL", "GetForContractNoAndStockCode(string contractNo, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<BocxepResult> GetForBXSubjectCodeAndStockCode(string bxSubjectCode, string stockCode, DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<BocxepResult> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_BocxepResult_Select_For_StockCode_BXSubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, bxSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BocxepResultDAL", "GetForBXSubjectCodeAndStockCode(string bxSubjectCode, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<BocxepType> GetListTypeCodeForDetail(string bxSubjectCode, string stockCode)
        {
            DbDataReader reader = null;
            ListBase<BocxepType> lstReturn = new ListBase<BocxepType>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_BocxepResult_Select_List_TypeCode_For_Detail";
                cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, bxSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new BocxepType(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BocxepResultDAL", "GetListTypeCodeForDetail(string bxSubjectCode, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public DataTable GetAllForWorkingTypes()
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_WorkingTypes_Select_All";
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetAllForWorkingTypes", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataSet Report_BocxepResults(DateTime fromDate, DateTime toDate)
        {
            bool alreadyOpen = false;
            DataSet ds = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportReport_BocxepResults";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 4, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, toDate));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("KCSReportDAL", "Report_BocxepResults(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public override int Insert(BocxepResult t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResult_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, t.BocxepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepContractNo", System.Data.DbType.String, 20, t.BocxepContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ResultID = (Guid)Cmd.Parameters["@ResultID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDAL", "Insert(BocxepResult t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(BocxepResult t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResult_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, t.BocxepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepContractNo", System.Data.DbType.String, 20, t.BocxepContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDAL", "Update(BocxepResult t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(BocxepResult t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepResult_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDAL", "Delete(BocxepResult t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        #region Detail1
        public int InsertDetail1(BocxepResultDetail1 t)
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
                cmd.CommandText = "usp_BocxepResultDetail1_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@Detail1ID", System.Data.DbType.Guid, 16, 0,System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@StockTransactionNo", System.Data.DbType.AnsiString, 20, t.StockTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@StockTransactionDate", System.Data.DbType.DateTime, 8, t.StockTransactionDate));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.Detail1ID = (Guid)cmd.Parameters["@Detail1ID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetail1DAL", "Insert(BocxepResultDetail1 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteDetail1(Guid resultID)
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
                cmd.CommandText = "usp_BocxepResultDetail1_DeleteByResultID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetail1DAL", "DeleteDetail1(Guid resultID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
        #region Detail2
        public int InsertDetail2(BocxepResultDetail2 t)
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
                cmd.CommandText = "usp_BocxepResultDetail2_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Detail1ID", System.Data.DbType.Guid, 16, t.Detail1ID));
                cmd.Parameters.Add(db.CreateParameter("@Detail2ID", System.Data.DbType.Guid, 16,0,System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.Detail2ID = (Guid)cmd.Parameters["@Detail2ID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetail2DAL", "InsertDetail2(BocxepResultDetail2 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
        #region Detail3
        public int InsertDetail3(BocxepResultDetail3 t)
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
                cmd.CommandText = "usp_BocxepResultDetail3_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Detail2ID", System.Data.DbType.Guid, 16, t.Detail2ID));
                cmd.Parameters.Add(db.CreateParameter("@Detail3ID", System.Data.DbType.Guid, 16,0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@BocxepTypeCode", System.Data.DbType.AnsiString, 20, t.BocxepTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@WorkingType", System.Data.DbType.AnsiString, 20, t.WorkingType));
                cmd.Parameters.Add(db.CreateParameter("@ToBocxepCode", System.Data.DbType.AnsiString, 20, t.ToBocxepCode));
                cmd.Parameters.Add(db.CreateParameter("@Songuoi", System.Data.DbType.Int32, 4, t.Songuoi));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                if (t.ServiceID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@ServiceID", System.Data.DbType.Guid, 16, t.ServiceID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.Detail3ID = (Guid)cmd.Parameters["@Detail3ID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDetail3DAL", "InsertDetail3(BocxepResultDetail3 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion

        public int UpdatePriceByResultID(Guid resultID)
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
                cmd.CommandText = "usp_BocxepResult_UpdatePriceByResultID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));

                //cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);

                //iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDAL", "UpdatePriceByResultID(Guid resultID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int UpdatePriceByDate(DateTime fromDate, DateTime toDate)
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
                cmd.CommandText = "usp_BocxepResult_UpdatePriceByDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                //cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);

                //iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepResultDAL", "UpdatePriceByDate(DateTime fromDate, DateTime toDate)", excp.Message);
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
