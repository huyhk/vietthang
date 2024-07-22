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
    public class AccountFixedAssetDAL : StockBaseDAL<AccountFixedAssets>
	{

		public AccountFixedAssetDAL()
		{
		}
		public AccountFixedAssetDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_FixedAssets_SelectAll";

        }
		#region Stored procedure wrappers
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(AccountFixedAssets t)
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
                cmd.CommandText = "usp_FixedAssets_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetName", System.Data.DbType.String, 50, t.FixedAssetName));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@OriginalPrice", System.Data.DbType.Decimal, 9, t.OriginalPrice));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing", System.Data.DbType.Int32, 4, t.MonthUsing));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, t.AccountCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@DepAccountCode", System.Data.DbType.String, 10, t.DepAccountCode));
                if (t.DepSubjectCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, t.DepSubjectCode));
                if (t.DepClassificationCode == String.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, t.DepClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@NgayCT", System.Data.DbType.DateTime, 8, t.NgayCT));
                cmd.Parameters.Add(db.CreateParameter("@CountryName", System.Data.DbType.String, 50, t.CountryName));
                cmd.Parameters.Add(db.CreateParameter("@SoCT", System.Data.DbType.String, 20, t.SoCT));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountFixedAssetDAL", "Insert(FixedAsset t)", excp.Message);
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
        public override int Update(AccountFixedAssets t)
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
                cmd.CommandText = "usp_FixedAssets_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode",System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetName",System.Data.DbType.String, 50, t.FixedAssetName));
                cmd.Parameters.Add(db.CreateParameter("@Description",System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@StartDate",System.Data.DbType.DateTime, 4, t.StartDate));
                cmd.Parameters.Add(db.CreateParameter("@OriginalPrice",System.Data.DbType.Decimal, 9, t.OriginalPrice));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing",System.Data.DbType.Int32, 4, t.MonthUsing));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode",System.Data.DbType.String, 10, t.AccountCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode",System.Data.DbType.String, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@DepAccountCode", System.Data.DbType.String, 10, t.DepAccountCode));
                if (t.DepSubjectCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DepSubjectCode", System.Data.DbType.String, 10, t.DepSubjectCode));
                if (t.DepClassificationCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DepClassificationCode", System.Data.DbType.String, 10, t.DepClassificationCode));
                cmd.Parameters.Add(db.CreateParameter("@NgayCT", System.Data.DbType.DateTime, 8, t.NgayCT));
                cmd.Parameters.Add(db.CreateParameter("@CountryName", System.Data.DbType.String, 50, t.CountryName));
                cmd.Parameters.Add(db.CreateParameter("@SoCT", System.Data.DbType.String, 20, t.SoCT));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountFixedAssetDAL", "Update(AccountFixedAsset t)", excp.Message);
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
		public override int Delete(AccountFixedAssets t)
		{
			           
            return this.Delete( t.FixedAssetCode);
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
                cmd.CommandText = "usp_FixedAssets_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String , 10, fixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
               	iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountFixedAssetDAL", "Delete(AccountFixedAssets t)", excp.Message);
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
		public AccountFixedAssets GetByID(string fixedAssetCode)
		{
            bool alreadyOpen = false;
            AccountFixedAssets obj = null;
            try
            {
				DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssets_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String , 10, fixedAssetCode));
				
				cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				reader = db.ExecuteReader(cmd);
                if (reader.Read())
                    obj = new AccountFixedAssets(reader);
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountFixedAssetsDAL", "GetByID(string fixedAssetCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
		}
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public int InsertAccountAssets(Guid accountTransactionID, string fixedAssetCode)
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
                cmd.CommandText = "usp_AccountFixedAssets_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, fixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountFixedAssetDAL", "InsertAccountAssets(Guid accountTransactionID, string fixedAssetCode)", excp.Message);
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
        public ListBase<AccountFixedAssets> GetFixedAssetUpgradeByStartDate_EndDate(DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<AccountFixedAssets> lstReturen = new ListBase<AccountFixedAssets>();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbDataReader reader = null;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountFixedAssets_Select_By_StartDate_EndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountFixedAssets obj = new AccountFixedAssets(reader);
                    lstReturen.Add(obj);
                }
                reader.Close();


            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountFixedAssetDAL", " GetFixedAssetUpgradeByStartDate_EndDate(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturen;
        }
		#endregion
	
	}

}

