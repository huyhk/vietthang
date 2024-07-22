using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using System.Data;
using VNS.Common;
namespace VNS.ERP.Data
{
    #region VesselInsuranceContractDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of VesselInsuranceContract.
    /// </summary>
    public class VesselInsuranceContractDAL : BaseDAL<VesselInsuranceContract>
    {
        public VesselInsuranceContractDAL()
        {
        }
        public VesselInsuranceContractDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(VesselInsuranceContract t)
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
                cmd.CommandText = "usp_VesselInsuranceContract_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@InsuranceSubjectCode", System.Data.DbType.AnsiString, 10, t.InsuranceSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselTransactionNo", System.Data.DbType.AnsiString, 20, t.VesselTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@InsuranceAmount", System.Data.DbType.Decimal, 9, t.InsuranceAmount));
                cmd.Parameters.Add(db.CreateParameter("@LostAllow", System.Data.DbType.Decimal, 9, t.LostAllow));
                cmd.Parameters.Add(db.CreateParameter("@CompensationPrice", System.Data.DbType.Decimal, 9, t.CompensationPrice));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.AnsiString, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));

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
                Write2Log.WriteLogs("VesselInsuranceContractDAL", "Insert(VesselInsuranceContract t)", excp.Message);
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
        public override int Update(VesselInsuranceContract t)
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
                cmd.CommandText = "usp_VesselInsuranceContract_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.AnsiString, 20, t.ContractNo));
                cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                cmd.Parameters.Add(db.CreateParameter("@InsuranceSubjectCode", System.Data.DbType.AnsiString, 10, t.InsuranceSubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselTransactionNo", System.Data.DbType.AnsiString, 20, t.VesselTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@InsuranceAmount", System.Data.DbType.Decimal, 9, t.InsuranceAmount));
                cmd.Parameters.Add(db.CreateParameter("@LostAllow", System.Data.DbType.Decimal, 9, t.LostAllow));
                cmd.Parameters.Add(db.CreateParameter("@CompensationPrice", System.Data.DbType.Decimal, 9, t.CompensationPrice));
                cmd.Parameters.Add(db.CreateParameter("@CurrencyCode", System.Data.DbType.AnsiString, 3, t.CurrencyCode));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("VesselInsuranceContractDAL", "Update(VesselInsuranceContract t)", excp.Message);
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
        public override int Delete(VesselInsuranceContract t)
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
                cmd.CommandText = "usp_VesselInsuranceContract_Delete";
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
                Write2Log.WriteLogs("VesselInsuranceContractDAL", "Delete(VesselInsuranceContract t)", excp.Message);
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
        public VesselInsuranceContract GetByID(Guid contractID)
        {
            bool alreadyOpen = false;
            VesselInsuranceContract obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VesselInsuranceContract_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, contractID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new VesselInsuranceContract(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselInsuranceContractDAL", "GetByID(Guid contractID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public ListBase<VesselInsuranceContract> GetByDate(DateTime fromDate, DateTime toDate)
        {
            ListBase<VesselInsuranceContract> lstReturn = new ListBase<VesselInsuranceContract>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VesselInsuranceContract_SelectByDate";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new VesselInsuranceContract(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselInsuranceContractDAL", "GetByDate(DateTime fromDate,DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }

        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_VesselInsuranceContract_SelectAll";
            _spSelectDynamic = "usp_VesselInsuranceContract_SelectDynamic";
            _spDeleteAll = "usp_VesselInsuranceContract_DeleteAll";
            _spDeleteDynamic = "usp_VesselInsuranceContract_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}
