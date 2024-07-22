using System;
using System.Collections.Generic;
using System.Text;
using VNS.ERP.Data;
using VNS.Common;
using VNS.Data.DAL;
using System.Data;
using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data.Manufactures
{
    class ManufactureReportDAL : DataAccessBase
    {
        public ManufactureReportDAL()
        {}
        public ManufactureReportDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}
        public DataSet GetDSTHNam(int year, string stockCode)
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
                cmd.CommandText = "usp_Manufactures_Reports_THNam";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@year", System.Data.DbType.Int32, 4, year));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureReportDAL", "GetDSTHNam(int year, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataTable ReportCompareAutoGen(DateTime fromDate, DateTime toDate, string stockCode)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufacture_Report_CompareAutoGen";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureReportDAL", "ReportCompareAutoGen(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }

        public DataTable ReportTonkhophe(DateTime fromDate, DateTime toDate, string stockCode)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufacture_Report_Tonkhophe";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureReportDAL", "ReportTonkhophe(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }

        public DataSet ReportTHThangNM(DateTime fromDate, DateTime toDate, string stockCode)
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
                cmd.CommandText = "usp_SXReport_THThangNM";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@tungay", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@denngay", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                ds = db.ExecuteDataSet(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("ManufactureReportDAL", "ReportTHThangNM(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return ds;
        }
        public DataTable Report_TonkhoPremi(DateTime fromDate, DateTime toDate, string stockCode)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufacture_Report_TonkhoPremix";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseReportDAL", "Report_TonkhoPremi(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }
        public DataTable Report_TonkhoBaobi(DateTime fromDate, DateTime toDate, string stockCode)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufacture_Report_TonkhoBaobi";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseReportDAL", "Report_TonkhoBaobi(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }
    }
}
