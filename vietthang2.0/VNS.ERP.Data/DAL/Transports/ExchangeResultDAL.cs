using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data
{
    #region ExchangeResultDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of ExchangeResult.
    /// </summary>
    public class ExchangeResultDAL : BaseDAL<ExchangeResult>
    {
        public ExchangeResultDAL()
        {
        }
        public ExchangeResultDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(ExchangeResult t)
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
                cmd.CommandText = "usp_ExchangeResult_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16,0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ExchangeSubjectCode", System.Data.DbType.AnsiString, 10, t.ExchangeSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselExchangeContractNo", System.Data.DbType.AnsiString, 20, t.VesselExchangeContractNo));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));

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
                iError = -1;
                Write2Log.WriteLogs("ExchangeResultDAL", "Insert(ExchangeResult t)", excp.Message);
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
        public override int Update(ExchangeResult t)
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
                cmd.CommandText = "usp_ExchangeResult_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@ExchangeSubjectCode", System.Data.DbType.AnsiString, 10, t.ExchangeSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselExchangeContractNo", System.Data.DbType.AnsiString, 20, t.VesselExchangeContractNo));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ExchangeResultDAL", "Update(ExchangeResult t)", excp.Message);
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
        public override int Delete(ExchangeResult t)
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
                cmd.CommandText = "usp_ExchangeResult_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ExchangeResultDAL", "Delete(ExchangeResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Returns an object from database by calling Select StoredProcedure
        /// </summary>		
        public ExchangeResult GetByID(Guid resultID)
        {
            bool alreadyOpen = false;
            ExchangeResult obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ExchangeResult_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new ExchangeResult(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ExchangeResultDAL", "GetByID(Guid resultID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public DataSet GetDSByDate(DateTime fromDate, DateTime toDate)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ExchangeResult_Select_ByDate";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ExchangeResultDAL", "GetDSByDate(DateTime fromDate,DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }

        #region detail
        public int InsertDetail(ExchangeResultDetail t)
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
                cmd.CommandText = "usp_ExchangeResultDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@TransportType", System.Data.DbType.AnsiString, 20, t.TransportType));
                cmd.Parameters.Add(db.CreateParameter("@TransportItemType", System.Data.DbType.AnsiString, 20, t.TransportItemType));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, t.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@DateLeave", System.Data.DbType.DateTime, 8, t.DateLeave));
                cmd.Parameters.Add(db.CreateParameter("@DateArrive", System.Data.DbType.DateTime, 8, t.DateArrive));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@Songaymuabao", System.Data.DbType.Int32, 4, t.Songaymuabao));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.AnsiString, 20, t.PTVC));
                cmd.Parameters.Add(db.CreateParameter("@Sobao", System.Data.DbType.Int32, 4, t.Sobao));
                cmd.Parameters.Add(db.CreateParameter("@NhantaitauChuatrubi", System.Data.DbType.Decimal, 9, t.NhantaitauChuatrubi));
                cmd.Parameters.Add(db.CreateParameter("@NhantaitauDatrubi", System.Data.DbType.Decimal, 9, t.NhantaitauDatrubi));
                cmd.Parameters.Add(db.CreateParameter("@GiaonhamayDatrubi", System.Data.DbType.Decimal, 9, t.GiaonhamayDatrubi));
                cmd.Parameters.Add(db.CreateParameter("@Ghichu", System.Data.DbType.String, 100, t.Ghichu));

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
                iError = -1;
                Write2Log.WriteLogs("ExchangeResultDAL", "InsertDetail(ExchangeResultDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public int DeleteDetail(Guid resultID)
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
                cmd.CommandText = "usp_ExchangeResultDetail_DeleteByResultID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, resultID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("ExchangeResultDAL", "DeleteDetail(Guid resultID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion
        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_ExchangeResult_SelectAll";
            _spSelectDynamic = "usp_ExchangeResult_SelectDynamic";
            _spDeleteAll = "usp_ExchangeResult_DeleteAll";
            _spDeleteDynamic = "usp_ExchangeResult_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}
