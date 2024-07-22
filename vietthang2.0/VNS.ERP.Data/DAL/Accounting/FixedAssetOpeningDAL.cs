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
	public class FixedAssetOpeningDAL :  StockBaseDAL<FixedAssetOpening>
	{
		public FixedAssetOpeningDAL()
		{
		}
		public FixedAssetOpeningDAL(DBHelper dbHelper): base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_FixedAssetOpenings_SelectAll";
        }

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public override int Insert(FixedAssetOpening t)
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
                cmd.CommandText = "usp_FixedAssetOpenings_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
				
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode",System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode",System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@OriginalPrice",System.Data.DbType.Decimal, 9, t.OriginalPrice));
                cmd.Parameters.Add(db.CreateParameter("@AccumulatedDepreciation",System.Data.DbType.Decimal, 9, t.AccumulatedDepreciation));
                cmd.Parameters.Add(db.CreateParameter("@RemainCost",System.Data.DbType.Decimal, 9, t.RemainCost));
                cmd.Parameters.Add(db.CreateParameter("@PriceDepreciation", System.Data.DbType.Decimal, 9, t.PriceDepreciation));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing", System.Data.DbType.Int32, 4, t.MonthUsing));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetOpeningDAL", "Insert(FixedAssetOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
		public override int Update(FixedAssetOpening t)
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
                cmd.CommandText = "usp_FixedAssetOpenings_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@OriginalPrice", System.Data.DbType.Decimal, 9, t.OriginalPrice));
                cmd.Parameters.Add(db.CreateParameter("@AccumulatedDepreciation", System.Data.DbType.Decimal, 9, t.AccumulatedDepreciation));
                cmd.Parameters.Add(db.CreateParameter("@RemainCost", System.Data.DbType.Decimal, 9, t.RemainCost));
                cmd.Parameters.Add(db.CreateParameter("@PriceDepreciation", System.Data.DbType.Decimal, 9, t.OriginalPrice));
                cmd.Parameters.Add(db.CreateParameter("@MonthUsing", System.Data.DbType.Int32, 4, t.MonthUsing));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetOpeningDAL", "Update(FixedAssetOpening t)", excp.Message);
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
        public override int Delete(FixedAssetOpening t)
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
                cmd.CommandText = "usp_FixedAssetOpenings_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, fixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
               iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetOpeningDAL", "Delete(FixedAssetOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Get ListBase Objects From DataBase by PeriodCode.
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public ListBase<FixedAssetOpening> GetListFixedAssetOpeningByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<FixedAssetOpening> lstReturn = new ListBase<FixedAssetOpening>();
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
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    FixedAssetOpening obj = new FixedAssetOpening(reader);
                    lstReturn.Add(obj);
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetOpeningDAL", "GetListFixedAssetOpeningByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int DeleteByPeriodCode(string periodCode)
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
                cmd.CommandText = "usp_FixedAssetOpenings_Delete_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("FixedAssetOpeningDAL", "Delete(string periodCode)", excp.Message);
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

