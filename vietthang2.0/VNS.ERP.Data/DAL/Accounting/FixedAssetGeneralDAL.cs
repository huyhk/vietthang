using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.ERP.Data;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
	
	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of FixedAssetOpening.
	/// </summary>
	public class FixedAssetGeneralDAL :  StockBaseDAL<FixedAssetGeneral>
	{
		public FixedAssetGeneralDAL()
		{
		}
        public FixedAssetGeneralDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<FixedAssetGeneral> GetListFixedAssetGeneralByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<FixedAssetGeneral> lstReturn = new ListBase<FixedAssetGeneral>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssetOpenings_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@ForDep", System.Data.DbType.Boolean, 1, true));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    FixedAssetGeneral obj = new FixedAssetGeneral(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetGeneralDAL", "GetListFixedAssetGeneralByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
	}

}

