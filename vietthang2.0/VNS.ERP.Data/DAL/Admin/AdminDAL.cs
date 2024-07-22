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
    class AdminDAL : DataAccessBase
    {
        public DataSet GetJobHistory()
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
                cmd.CommandText = "usp_GetJobHistory";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                ds = db.ExecuteDataSet(cmd);

                DataRelation dr = ds.Relations.Add("Detail",ds.Tables[0].Columns[0], ds.Tables[1].Columns[0]);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AdminDAL", "GetJobHistory()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
    }
}
