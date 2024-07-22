using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common;
using VNS.Data.Data;
using VNS.Utils;

namespace VNS.Data.DAL
{
    class AppSettingDAL:DataAccessBase
    {
        //public AppSettingBase GetAppSetting()
        //{
        //    AppSettingBase t = new AppSettingBase();
        //    DataTable dt = null;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open)
        //            db.Open();
        //        else
        //            alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "AppSettings";
        //        cmd.CommandType = System.Data.CommandType.TableDirect;

        //        dt = db.ExecuteTable(cmd);
        //        t.FromDataTable(dt);
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("AppSettingDAL", "GetAppSetting()", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen)
        //            db.Close();
        //    }
        //    return t;
        //}

        public DataTable GetDataTableAppSetting()
        {
            DataTable dt = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "select * from AppSettings";
                cmd.CommandType = System.Data.CommandType.Text;

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AppSettingDAL", "GetAppSetting()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }

        public int InsertUpdate(string propertyID, string propertyValue)
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
                cmd.CommandText = "usp_AppSetting_InsertUpdate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PropertyID", System.Data.DbType.String, 20, propertyID));
                if (propertyValue != null)
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, propertyValue));
                else
                    cmd.Parameters.Add(db.CreateParameter("@PropertyValue", System.Data.DbType.String, 100, DBNull.Value));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AppSettingDAL", "InsertUpdate(string propertyID, string propertyValue)", excp.Message);
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
