using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    #region TransportContractDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of TransportContract.
    /// </summary>
    public class TransportContractDAL : BaseDAL<TransportContract>
    {
        public TransportContractDAL()
        {
        }
        public TransportContractDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        public DataSet GetAll()
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TransportContract_SelectAll";

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportContractDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public DataSet GetYear(int year)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TransportContract_SelectYear";

                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 4, year));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportContractDAL", "GetYear(int year)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(TransportContract t)
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
                cmd.CommandText = "usp_TransportContract_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));

                cmd.Parameters.Add(db.CreateParameter("@IsCont", System.Data.DbType.Boolean, 1, t.IsCont));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ContractID = (Guid)cmd.Parameters["@ContractID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDAL", "Insert(TransportContract t)", excp.Message);
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
        public override int Update(TransportContract t)
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
                cmd.CommandText = "usp_TransportContract_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, t.EndDate));
                cmd.Parameters.Add(db.CreateParameter("@TaxRate", System.Data.DbType.Decimal, 9, t.TaxRate));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@IsCont", System.Data.DbType.Boolean, 1, t.IsCont));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDAL", "Update(TransportContract t)", excp.Message);
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
        public override int Delete(TransportContract t)
        {

            return this.Delete(t.ContractID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid contractID)
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
                cmd.CommandText = "usp_TransportContract_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, contractID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportContractDAL", "Delete(TransportContract t)", excp.Message);
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
            _spSelectAll = "usp_TransportContract_SelectAll";
            _spSelectDynamic = "usp_TransportContract_SelectDynamic";
            _spDeleteAll = "usp_TransportContract_DeleteAll";
            _spDeleteDynamic = "usp_TransportContract_DeleteDynamic";
        }

        #endregion

        public ListBase<TransportContract> GetBySubjectCodeAndDate(string subjectCode, DateTime fromDate)
        {
            ListBase<TransportContract> lst = new ListBase<TransportContract>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_TransportContract_SelectBySubjectAndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));

                DataTable dt = db.ExecuteTable(cmd);
                foreach (DataRow row in dt.Rows)
                    lst.Add(new TransportContract(row));
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportContractDAL", "GetBySubjectCodeAndDate(string subjectCode,DateTime fromDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lst;
        }

        public int InsertResult(TransportContractResult t)
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
                cmd.CommandText = "usp_TransportContractResult_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ResultID", System.Data.DbType.Guid, 16, t.ResultID));
                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                cmd.Parameters.Add(db.CreateParameter("@VCAmount", System.Data.DbType.Decimal, 9, t.VCAmount));
                cmd.Parameters.Add(db.CreateParameter("@VCTaxAmount", System.Data.DbType.Decimal, 9, t.VCTaxAmount));
                cmd.Parameters.Add(db.CreateParameter("@DetentionAmount", System.Data.DbType.Decimal, 9, t.DetentionAmount));
                cmd.Parameters.Add(db.CreateParameter("@CompenAmount", System.Data.DbType.Decimal, 9, t.CompenAmount));
                cmd.Parameters.Add(db.CreateParameter("@OverdueAmount", System.Data.DbType.Decimal, 9, t.OverdueAmount));
                cmd.Parameters.Add(db.CreateParameter("@TotalAmount", System.Data.DbType.Decimal, 9, t.TotalAmount));

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
                Write2Log.WriteLogs("TransportContractResultDAL", "Insert(TransportContractResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteResult(Guid resultID)
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
                cmd.CommandText = "usp_TransportContractResult_Delete";
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
                Write2Log.WriteLogs("TransportContractResultDAL", "Delete(TransportContractResult t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
    }
    #endregion
}