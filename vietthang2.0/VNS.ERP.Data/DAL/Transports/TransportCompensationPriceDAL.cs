using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Transports
{
    #region TransportCompensationPriceDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of TransportCompensationPrice.
    /// </summary>
    public class TransportCompensationPriceDAL : BaseDAL<TransportCompensationPrice>
    {
        public TransportCompensationPriceDAL()
        {
        }
        public TransportCompensationPriceDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(TransportCompensationPrice t)
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
                cmd.CommandText = "usp_TransportCompensationPrice_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@CompensationID", System.Data.DbType.Guid, 16, t.CompensationID));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));

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
                Write2Log.WriteLogs("TransportCompensationPriceDAL", "Insert(TransportCompensationPrice t)", excp.Message);
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
        public override int Update(TransportCompensationPrice t)
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
                cmd.CommandText = "usp_TransportCompensationPrice_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@CompensationID", System.Data.DbType.Guid, 16, t.CompensationID));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportCompensationPriceDAL", "Update(TransportCompensationPrice t)", excp.Message);
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
        public override int Delete(TransportCompensationPrice t)
        {

            return this.Delete(t.CompensationID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid compensationID)
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
                cmd.CommandText = "usp_TransportCompensationPrice_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@CompensationID", System.Data.DbType.Guid, 16, compensationID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TransportCompensationPriceDAL", "Delete(TransportCompensationPrice t)", excp.Message);
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
            _spSelectAll = "usp_TransportCompensationPrice_SelectAll";
            _spSelectDynamic = "usp_TransportCompensationPrice_SelectDynamic";
            _spDeleteAll = "usp_TransportCompensationPrice_DeleteAll";
            _spDeleteDynamic = "usp_TransportCompensationPrice_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}