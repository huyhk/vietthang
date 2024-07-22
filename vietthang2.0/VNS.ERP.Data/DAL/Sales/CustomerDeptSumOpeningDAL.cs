using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{

	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of FixedAsset.
	/// </summary>
    public class CustomerDeptSumOpeningDAL : StockBaseDAL<CustomerDeptSumOpening>
	{

		public CustomerDeptSumOpeningDAL()
		{
		}
        public CustomerDeptSumOpeningDAL(DBHelper dbHelper)
            : base(dbHelper)
		{
			
		}
      
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public override int Insert(CustomerDeptSumOpening t)
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
                cmd.CommandText = "usp_CustomerDeptSumOpenings_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                cmd.Parameters.Add(db.CreateParameter("@RemainAmount", System.Data.DbType.Decimal, 9, t.RemainAmount));
				
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
				iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptSumOpeningDAL", "Insert(CustomerDeptSumOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
		}
        public override int Update(CustomerDeptSumOpening t)
        {
            return 0;
        }
        public override int Delete(CustomerDeptSumOpening t)
        {
            return Delete(t.PeriodCode);
        }
        /// <summary>
        /// Delete CustomerDeptSumOpening by PeriodCode
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
                cmd.CommandText = "usp_CustomerDeptSumOpenings_Delete_ByPeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
               iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptSumOpeningDAL", "Delete(CustomerDeptSumOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public ListBase<CustomerDeptSumOpening> GetByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<CustomerDeptSumOpening> lstReturn = new ListBase<CustomerDeptSumOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerDeptSumOpenings_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
               reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerDeptSumOpening obj = new CustomerDeptSumOpening(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDeptSumOpeningDAL", "GetByPeriodCodeAndSCode(string periodCode, string stockCode)", excp.Message);
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
