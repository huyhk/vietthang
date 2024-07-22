

/************************************************************************
**	ClassName	: 	VesselDAL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	25-01-2008 10:45 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data
{
    #region VesselDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of Vessel.
    /// </summary>
    public class VesselDAL : BaseDAL<Vessel>
    {
        public VesselDAL()
        {
        }
        public VesselDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(Vessel t)
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
                cmd.CommandText = "usp_Vessel_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.AnsiString, 10, t.VesselCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselName", System.Data.DbType.String, 50, t.VesselName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
               
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                 db.ExecuteNonQuery(cmd);
              
                    iError = (int)cmd.Parameters["@iError"].Value;
              
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VesselDAL", "Insert(Vessel t)", excp.Message);
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
        public override int Update(Vessel t)
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
                cmd.CommandText = "usp_Vessel_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.AnsiString, 10, t.VesselCode));
                cmd.Parameters.Add(db.CreateParameter("@VesselName", System.Data.DbType.String, 50, t.VesselName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VesselDAL", "Update(Vessel t)", excp.Message);
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
        public override int Delete(Vessel t)
        {

            return this.Delete(t.VesselCode);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(string vesselCode)
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
                cmd.CommandText = "usp_Vessel_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.AnsiString, 10, vesselCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VesselDAL", "Delete(Vessel t)", excp.Message);
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
        public Vessel GetByID(string vesselCode)
        {
            //int iError = 0;
            bool alreadyOpen = false;
            Vessel obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Vessel_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.AnsiString, 10, vesselCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new Vessel(reader);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VesselDAL", "GetByID(string vesselCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_Vessel_SelectAll";
            _spSelectDynamic = "usp_Vessel_SelectDynamic";
            _spDeleteAll = "usp_Vessel_DeleteAll";
            _spDeleteDynamic = "usp_Vessel_DeleteDynamic";
        }

        #endregion
    }
    #endregion
}

