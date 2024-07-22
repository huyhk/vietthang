using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;

using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace VNS.ERP.Data
{
    class ModuleDAL:BaseDAL<Module>
    {
        public ModuleDAL()
        { }
        public ModuleDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }
        public Module GetObjectByID(int _moduleID)
        {
            Module obj = null;
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Modules_Select_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@ModuleID", System.Data.DbType.Int32, 4, _moduleID));

                oDR = db.ExecuteReader(cmd);
                if (oDR.Read())
                {
                    obj = new Module(oDR, true);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ModuleDAL", "GetObjectByID(int _moduleID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        /// <summary>
        /// Returns a list of modules for a specified member
        /// Added by Huy Ho 2007-02-23
        /// </summary>
        /// <param name="memberID">The memberID to get module list</param>
        /// <returns>Module list to return</returns>
        public System.Collections.ArrayList GetByMember(string memberID)
        {
            System.Collections.ArrayList obj = new System.Collections.ArrayList();
            DbDataReader oDR = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Modules_GetByMember";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@memberID", System.Data.DbType.String, 20, memberID));

                oDR = db.ExecuteReader(cmd);
                while (oDR.Read())
                {
                    obj.Add(oDR.GetInt32(oDR.GetOrdinal("ModuleID")));
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ModuleDAL", "GetByMember(string memberID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public int InsertUpdateConfig(int _moduleID, int _configID, string _configValue)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ModuleConfigs_InsertUpdate";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ModuleID", System.Data.DbType.Int32, 4, _moduleID));
                Cmd.Parameters.Add(db.CreateParameter("@ConfigID", System.Data.DbType.Int32, 4, _configID));
                Cmd.Parameters.Add(db.CreateParameter("@ConfigValue", System.Data.DbType.String, 100, _configValue));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ModuleDAL", "InsertUpdate(int _moduleID, int _configID, string _configValue)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
