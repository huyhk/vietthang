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
    public class FixedAssetDepreciationDAL : StockBaseDAL<FixedAssetDepreciation>
	{

		public FixedAssetDepreciationDAL()
		{
		}
        public FixedAssetDepreciationDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
        protected override void SetValues()
        {
            _spSelectAll = "usp_FixedAssetDepreciations_SelectAll";
        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(FixedAssetDepreciation t)
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
                cmd.CommandText = "usp_FixedAssetDepreciations_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@FixedAssetCode", System.Data.DbType.String, 10, t.FixedAssetCode));
                cmd.Parameters.Add(db.CreateParameter("@Amount",System.Data.DbType.Decimal, 9, t.Amount));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("FixedAssetDepreciationDAL", "Insert(FixedAssetDepreciation t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public override int Update(FixedAssetDepreciation t)
        {
            return 0;
        }
        public override int Delete(FixedAssetDepreciation t)
        {
            return Delete(t.PeriodCode);
        }
        /// <summary>
        /// Delete FixedAssetDepreciation by PeriodCode
        /// </summary>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public int Delete(string periodCode)
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
                cmd.CommandText = "usp_FixedAssetDepreciations_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
               iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("FixedAssetDepreciationDAL", "Delete(FixedAssetDepreciation t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }


        public ListBase<FixedAssetDepreciation> GetListFixedAssetDepreciationByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<FixedAssetDepreciation> lstReturn = new ListBase<FixedAssetDepreciation>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssetDepreciations_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    FixedAssetDepreciation obj = new FixedAssetDepreciation(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
                
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetDepreciationDAL", "GetListFixedAssetDepreciationByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }

        public DataSet GetReportFixedAssetDepreciationByYear(int year)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssetDepreciations_ReportYear";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 10, year));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetDepreciationDAL", "GetReportFixedAssetDepreciationByYear(int year)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet GetReportFixedAssetDepreciationByYear2(DateTime date)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_FixedAssetDepreciations_ReportYear2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 10, date));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("FixedAssetDepreciationDAL", "GetReportFixedAssetDepreciationByYear2(int year)", excp.Message);
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
