using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
namespace VNS.ERP.Data.Premixs
{
    class PremixReportDAL : DataAccessBase
    {
        public PremixReportDAL()
        { }
        public PremixReportDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}
        public DataTable ReportPremixShiftDetails(string _StockCode, int _ForDepartment, DateTime _Tungay, DateTime _Denngay, string _ItemType)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Premixs_Report_ShiftDetail2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Int32, 4, _ForDepartment));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, DateTime.Parse(_Tungay.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, DateTime.Parse(_Denngay.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 100, _ItemType));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("GrindReportDAL", "ReportGrindShiftDetails(string _StockCode,DateTime _Tungay,DateTime _Denngay, string _ItemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return dt;
        }
        public DataTable PremixReportDetail(string stockCode, DateTime fromDate, DateTime toDate)
        {
            bool alreadyOpen = false;
            DataTable dt = new DataTable();
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Premix_Report_Detail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 4, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, toDate));
                dt = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PremixReportDAL", "PremixReportDetail(string stockCode, DateTime fromDate, DateTime toDate)", excp.Message);
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
