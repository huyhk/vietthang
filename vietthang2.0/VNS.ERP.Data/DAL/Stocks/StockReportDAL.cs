using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;



namespace VNS.ERP.Data
{
    class StockReportDAL : DataAccessBase 
    {
            public StockReportDAL()
        {}
        public StockReportDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}
        public DataSet ReportBangkexuathang(DateTime fromDate, DateTime toDate, string stockCode)
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

                cmd.CommandText = "usp_Stock_Report_BangkeXuathang";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "ReportBangkexuathang(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet ReportDoiChieuChuyenKhoNoiBo(DateTime startDate, DateTime endDate)
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

                cmd.CommandText = "usp_Stock_Report_DoiChieu_ChuyenKho_NoiBo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "ReportDoiChieuChuyenKhoNoiBo(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet ReportsTinhHinhTonTru(DateTime toDate, string stockCode, int days)
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
                
                cmd.CommandText = "usp_Stocks_Reports_TinhhinhTontru";//Check Location
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Days", System.Data.DbType.Int16, 2, days));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "ReportsTinhHinhTonTru(DateTime toDate, string stockCode, int days)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataTable GetInventory(DateTime _StartDate,DateTime _EndDate,String _StockCode,bool DetailLocation)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                if (DetailLocation)
                cmd.CommandText = "usp_Stocks_Report_Inventories_kk";//Check Location
                else
                cmd.CommandText = "usp_Stocks_Report_Inventories2_kk";//Not check Location
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "GetInventory(DateTime _StartDate,DateTime _EndDate,String _StockCode,bool DetailLocation)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable Get_Manufactures_Inventory(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Report_Inventories";//Check Location
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "Get_Manufactures_Inventory(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable GetGrind(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Grinds_Report_Inventories";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "GetGrind(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable GetPremix(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Premixs_Report_Inventories";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "GetGrind(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable Get_Stocks_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stocks_Report_TransactionDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "Get_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable Get_Stocks_Report_TransactionDetail2(DateTime _StartDate, DateTime _EndDate, String _StockCode)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stocks_Report_TransactionDetail2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "Get_Report_TransactionDetail2(DateTime _StartDate, DateTime _EndDate, String _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable Get_Manufacture_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Manufactures_Report_TransactionDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "Get_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode,enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }

        public DataTable get_Grinds_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Grinds_Report_TransactionDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "get_Grinds_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable get_Premixs_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Premixs_Report_TransactionDetail";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, DateTime.Parse(_StartDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, DateTime.Parse(_EndDate.ToShortDateString())));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, (byte)_ForDepartment));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "get_Premixs_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode, enumStockTransactionForDepartment _ForDepartment)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable ReportSaleProductQuantity(DateTime startDate, DateTime endDate, string productType)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Report_Sale_Product_Quantity";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.Date, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.Date, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "ReportSaleProductQuantity(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable ReportTinhhinhtontru2(DateTime toDate, string stockCode, int days, bool groupItem, string itemType)
        {
            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stock_Report_Tinhhinhtontru2";

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.Date, 4, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Days", System.Data.DbType.Int32, 4, days));
                cmd.Parameters.Add(db.CreateParameter("@GroupItem", System.Data.DbType.Boolean, 1, groupItem));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.AnsiString, 50, itemType));
                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "ReportTinhhinhtontru2(DateTime toDate, string stockCode, int days, bool groupItem, string itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataSet GetToolDVVCTD(DateTime fromDate, DateTime toDate, string stockCode, string transactionType)
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

                cmd.CommandText = "usp_Stock_ToolDVVCTD_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 10, transactionType));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "GetToolDVVCTD(DateTime fromDate, DateTime toDate, string stockCode, string transactionType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public int UpdateToolDVVCTD(Guid transactionID, bool dvvcChecked, string dvvc, bool routeCodeChecked, string routeCode, bool tcRouteCodeChecked, string tcRouteCode, bool dvtcChecked, string dvtc, bool ptvcChecked, string ptvc, bool pttcChecked, string pttc)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stock_ToolDVVCTD_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@DVVCChecked", System.Data.DbType.Boolean, 1, dvvcChecked));
                cmd.Parameters.Add(db.CreateParameter("@DVVC", System.Data.DbType.String, 10, dvvc));
                cmd.Parameters.Add(db.CreateParameter("@RouteCodeChecked", System.Data.DbType.Boolean, 1, routeCodeChecked));
                cmd.Parameters.Add(db.CreateParameter("@RouteCode", System.Data.DbType.String, 20, routeCode));
                cmd.Parameters.Add(db.CreateParameter("@TCRouteCodeChecked", System.Data.DbType.Boolean, 1, tcRouteCodeChecked));
                cmd.Parameters.Add(db.CreateParameter("@TCRouteCode", System.Data.DbType.String, 20, tcRouteCode));
                cmd.Parameters.Add(db.CreateParameter("@DVTCChecked", System.Data.DbType.Boolean, 1, dvtcChecked));
                cmd.Parameters.Add(db.CreateParameter("@DVTC", System.Data.DbType.String, 10, dvtc));
                cmd.Parameters.Add(db.CreateParameter("@PTVCChecked", System.Data.DbType.Boolean, 1, ptvcChecked));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 100, ptvc));
                cmd.Parameters.Add(db.CreateParameter("@PTTCChecked", System.Data.DbType.Boolean, 1, pttcChecked));
                cmd.Parameters.Add(db.CreateParameter("@PTTC", System.Data.DbType.String, 50, pttc));
                //cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                //iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockReportDAL", "UpdateToolDVVCTD(Guid transactionID, string dvvc, string routeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }

        public DataTable BangkeNhaphangChitiet(DateTime fromDate, DateTime toDate, String stockCode)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stock_Report_BangkeNhaphangChitiet";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "BangkeNhaphangChitiet(DateTime fromDate, DateTime toDate, String stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
        public DataTable BangkeXuathangChitiet(DateTime fromDate, DateTime toDate, String stockCode)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stock_Report_BangkeXuathangChitiet";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "BangkeXuathangChitiet(DateTime fromDate, DateTime toDate, String stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }

        public DataTable KiemtraPhieuNhapxuatVaPhieucanxetai(DateTime fromDate, DateTime toDate)
        {

            bool alreadyOpen = false;
            DataTable reader = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Stock_TestTransactionAndWeightItemContainer";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));

                reader = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockReportDAL", "KiemtraPhieuNhapxuatVaPhieucanxetai(DateTime fromDate, DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return reader;
        }
    }
}
