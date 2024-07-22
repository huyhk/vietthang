using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Common;
using VNS.Utils;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDeptOpeningDAL:StockBaseDAL<CustomerDeptOpening>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomerDeptOpeningDAL() { }
        /// <summary>
        /// Constructor with parameter: DBHelper object
        /// </summary>
        /// <param name="dbHelper">DBHelper object</param>
        public CustomerDeptOpeningDAL(DBHelper dbHelper) : base(dbHelper) { }
        /// <summary>
        /// Init standard store procedures name
        /// </summary>
        protected override void SetValues()
        {
            _spSelectAll = "";
            //base.SetValues();
        }
        /// <summary>
        /// Insert CustomerDeptOpening t to database with parameter t
        /// </summary>
        /// <param name="t">CustomerDeptOpening parameter</param>
        /// <returns></returns>
        public override int Insert(CustomerDeptOpening t)
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
                cmd.CommandText = "usp_CustomerDeptOpening_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, t.PeriodCode));
                cmd.Parameters.Add(db.CreateParameter("@CustomerCode", System.Data.DbType.String, 10, t.CustomerCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                if (t.InvoiceNo != null)
                { cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, t.InvoiceNo)); }
                else { cmd.Parameters.Add(db.CreateParameter("@InvoiceNo", System.Data.DbType.String, 20, DBNull.Value));}
                cmd.Parameters.Add(db.CreateParameter("@InvoiceDate", System.Data.DbType.DateTime, 4, t.InvoiceDate));
                cmd.Parameters.Add(db.CreateParameter("@OrgAmount", System.Data.DbType.Decimal, 9, t.OrgAmount));
                cmd.Parameters.Add(db.CreateParameter("@PaidAmount", System.Data.DbType.Decimal, 9, t.PaidAmount));
                cmd.Parameters.Add(db.CreateParameter("@RemainAmount", System.Data.DbType.Decimal, 9, t.RemainAmount));
                if(t.DateLimit==false)
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DueDate", System.Data.DbType.DateTime, 4, t.DueDate));
                cmd.Parameters.Add(db.CreateParameter("@DateLimit", System.Data.DbType.Boolean, 1, t.DateLimit));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptOpeningDAL", "Insert(CustomerDeptOpening t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public ListBase<CustomerDeptOpening> GetByPeriodCode(string periodCode)
        {
            bool alreadyOpen = false;
            ListBase<CustomerDeptOpening> lstReturn = new ListBase<CustomerDeptOpening>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_CustomerDeptOpenings_Select_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    CustomerDeptOpening obj = new CustomerDeptOpening(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDeptOpeningDAL", "GetByPeriodCodeAndSCode(string periodCode, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
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
                cmd.CommandText = "usp_CustomerDeptOpenings_Delete_By_PeriodCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PeriodCode", System.Data.DbType.String, 10, periodCode));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("CustomerDeptOpeningDAL", "DeleteByPeriodCode(string periodCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public DataSet ReportsCustomerDeptOpening(DateTime ngay, string productType)
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
                cmd.CommandText = "usp_CustomerDeptOpenings_Report";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ngay", System.Data.DbType.DateTime, 4, ngay));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("CustomerDeptOpeningDAL", "ReportsCustomerDeptOpening(DateTime ngay)", excp.Message);
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
