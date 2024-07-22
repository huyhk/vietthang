using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data
{
    class TransportItemTypeDAL : DataAccessBase
    {
        public DataTable GetAll()
        {
            DataTable dt = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TransportItemTypes_GetAll";
                //cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                //cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TransportItemTypeDAL", "GetAll()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return dt;
        }
    }
}
