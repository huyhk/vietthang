using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Transports
{
    #region TransportResultDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of TransportResult.
    /// </summary>
    public class TransportResultDAL : BaseDAL<TransportResult>
    {
        public TransportResultDAL()
        {
        }
        public TransportResultDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers

        public DataSet GetByRouteAndDate(string routeCode,DateTime fromDate,DateTime toDate)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportResult_Select_RouteAndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.AnsiString, 20, routeCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportResultDAL", "GetByRouteAndDate(string routeCode,DateTime fromDate,DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(TransportResult t)
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
                cmd.CommandText = "usp_TransportResult_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@TransportSubjectCode", System.Data.DbType.AnsiString, 10, t.TransportSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.AnsiString, 20, t.RouteCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@IsTrungchuyen", System.Data.DbType.Boolean, 1, t.IsTrungchuyen));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));

                cmd.Parameters.Add(db.CreateParameter("@TransportContractNo", System.Data.DbType.String, 20, t.TransportContractNo));
                if (t.BatchID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ResultID = (Guid)cmd.Parameters["@ResultID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportResultDAL", "Insert(TransportResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Updates an existing object in database by calling Update StoredProcedure
        /// </summary>
        public override int Update(TransportResult t)
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
                cmd.CommandText = "usp_TransportResult_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@TransportSubjectCode", System.Data.DbType.AnsiString, 10, t.TransportSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.AnsiString, 20, t.RouteCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@IsTrungchuyen", System.Data.DbType.Boolean, 1, t.IsTrungchuyen));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@TransportContractNo", System.Data.DbType.String, 20, t.TransportContractNo));
                if (t.BatchID != Guid.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@BatchID", System.Data.DbType.Guid, 16, t.BatchID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportResultDAL", "Update(TransportResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(TransportResult t)
        {

            return this.Delete(t.ResultID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid resultID)
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
                cmd.CommandText = "usp_TransportResult_Delete";
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
                Write2Log.WriteLogs("TransportResultDAL", "Delete(TransportResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_TransportResult_SelectAll";
            _spSelectDynamic = "usp_TransportResult_SelectDynamic";
            _spDeleteAll = "usp_TransportResult_DeleteAll";
            _spDeleteDynamic = "usp_TransportResult_DeleteDynamic";
        }

        #endregion

        public int InsertDetail1(TransportResultDetail1 t)
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
                cmd.CommandText = "usp_TransportResultDetail1_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@Detail1ID", System.Data.DbType.Guid, 16, t.Detail1ID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));
                cmd.Parameters.Add(db.CreateParameter("@TransportType", System.Data.DbType.AnsiString, 20, t.TransportType));

                cmd.Parameters.Add(db.CreateParameter("@DetentionDay", System.Data.DbType.Decimal, 9, t.DetentionDay));
                cmd.Parameters.Add(db.CreateParameter("@OverdueHour", System.Data.DbType.Decimal, 9, t.OverdueHour));

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
                Write2Log.WriteLogs("TransportResultDetail1DAL", "Insert(TransportResultDetail1 t)", excp.Message);
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
                cmd.CommandText = "usp_TransportResultDetail1_DeleteByResultID";
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
                Write2Log.WriteLogs("TransportResultDAL", "DeleteDetail1(Guid resultID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int InsertDetail2(TransportResultDetail2 t)
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
                cmd.CommandText = "usp_TransportResultDetail2_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Detail1ID", System.Data.DbType.Guid, 16, t.Detail1ID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@SlGiao", System.Data.DbType.Decimal, 9, t.SlGiao));
                cmd.Parameters.Add(db.CreateParameter("@TransportItemType", System.Data.DbType.AnsiString, 20, t.TransportItemType));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportResultDAL", "InsertDetail2(TransportResultDetail2 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int InsertDetail3(TransportResultDetail3 t)
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
                cmd.CommandText = "usp_TransportResultDetail3_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@Detail1ID", System.Data.DbType.Guid, 16, t.Detail1ID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.AnsiString, 20, t.TransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportResultDetail3DAL", "InsertDetail3(TransportResultDetail3 t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public DataSet GetStockTransaction(string routeCode,string subjectCode,string pTVC, DateTime fromDate, DateTime toDate)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportResult_GetStockTransaction";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.AnsiString, 20, routeCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, pTVC));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportResultDAL", "GetStockTransaction(string routeCode,string subjectCode,string pTVC, DateTime fromDate, DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }

    }
    #endregion
}