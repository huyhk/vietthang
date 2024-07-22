using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of FixedAsset.
	/// </summary>
    public class FixedAssetUpgradeDAL : StockBaseDAL<FixedAssetUpgrade>
	{

		public FixedAssetUpgradeDAL()
		{
		}
		public FixedAssetUpgradeDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_FixedAssetUpgrades_SelectAll";

        }
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(FixedAssetUpgrade t)
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
                cmd.CommandText = "usp_FixedAssetUpgrades_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@Amount",System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing", System.Data.DbType.Int32, 4, t.MonthUsing));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetUpgradeDAL", "Insert(FixedAssetUpgrade t)", excp.Message);
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
        public override int Update(FixedAssetUpgrade t)
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
                cmd.CommandText = "usp_FixedAssetUpgrades_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing", System.Data.DbType.Int32, 4, t.MonthUsing));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetUpgradeDAL", "Update(FixedAssetUpgrade t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        /// <summary>
        /// Select object in database by calling Update StoredProcedure
        /// </summary>
        public ListBase<FixedAssetUpgrade> GetFixedAssetUpgradeByStartDate_EndDate(DateTime startDate,DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<FixedAssetUpgrade> lstReturen = new ListBase<FixedAssetUpgrade>();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbDataReader reader = null;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssetUpgrades_Select_By_StartDate_EndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    FixedAssetUpgrade obj = new FixedAssetUpgrade(reader);
                    lstReturen.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetUpgradeDAL", "GetFixedAssetUpgradeByStartDate_EndDate(DateTime startDate,DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturen;
        }
        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(FixedAssetUpgrade t)
        {

            return this.Delete(t.FixedAssetCode);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(string fixedAssetCode)
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
                cmd.CommandText = "usp_FixedAssetUpgrades_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, fixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetUpgradeDAL", "Delete(FixedAssetUpgrade t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
		#endregion
	
	}

}

