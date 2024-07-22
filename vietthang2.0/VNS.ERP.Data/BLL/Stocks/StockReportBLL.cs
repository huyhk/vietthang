using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;

namespace VNS.ERP.Data
{
   public class StockReportBLL
    {
      StockReportDAL dal = new StockReportDAL();
       public DataSet ReportBangkexuathang(DateTime fromDate, DateTime toDate, string stockCode)
       {
           DataSet ds = dal.ReportBangkexuathang(fromDate, toDate, stockCode);
           DataRelation DtRelation = ds.Relations.Add("Details",
                    ds.Tables[0].Columns["TransactionID"],
                    ds.Tables[1].Columns["TransactionID"]);
           ds.Relations.Add("ItemCode", new DataColumn[] { ds.Tables[1].Columns["TransactionID"], ds.Tables[1].Columns["ItemCode"] }, new DataColumn[] { ds.Tables[2].Columns["TransactionID"], ds.Tables[2].Columns["ItemCode"] });
           foreach (DataRow row in ds.Tables[1].Rows)
           {
               foreach (DataRow rowD in row.GetChildRows("ItemCode"))
               {
                   row["CodeSanpham"] = row["CodeSanpham"].ToString() + " " + rowD["GoodCode"];
               }
           }
           return ds;
       }
       public DataSet ReportDoiChieuChuyenKhoNoiBo(DateTime startDate, DateTime endDate)
       {
           return dal.ReportDoiChieuChuyenKhoNoiBo(startDate, endDate);
       }
       public DataTable GetInventory(DateTime _StartDate, DateTime _EndDate, String _StockCode,bool DetailLocation)
       {
           return dal.GetInventory(_StartDate, _EndDate, _StockCode, DetailLocation);
       }
       public DataSet ReportsTinhHinhTonTru(DateTime toDate, string stockCode, int days)
       {
           return dal.ReportsTinhHinhTonTru(toDate, stockCode, days);
       }
       public DataTable Get_Manufactures_Inventory(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.Get_Manufactures_Inventory(_StartDate, _EndDate, _StockCode,enumStockTransactionForDepartment.ForManufacture);
       }
       public DataTable GetGrind(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.GetGrind(_StartDate, _EndDate, _StockCode, enumStockTransactionForDepartment.ForGrind);
       }
       public DataTable GetPremix(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.GetPremix(_StartDate, _EndDate, _StockCode, enumStockTransactionForDepartment.ForPremix);
       }
       public DataTable Get_Stocks_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.Get_Stocks_Report_TransactionDetail(_StartDate, _EndDate, _StockCode);
       }
       public DataTable Get_Stocks_Report_TransactionDetail2(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.Get_Stocks_Report_TransactionDetail2(_StartDate, _EndDate, _StockCode);
       }
       public DataTable Get_Manufacture_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.Get_Manufacture_Report_TransactionDetail(_StartDate, _EndDate, _StockCode, enumStockTransactionForDepartment.ForManufacture);
       }
       public DataTable get_Grinds_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.get_Grinds_Report_TransactionDetail(_StartDate, _EndDate, _StockCode, enumStockTransactionForDepartment.ForGrind);
       }
       public DataTable get_Premixs_Report_TransactionDetail(DateTime _StartDate, DateTime _EndDate, String _StockCode)
       {
           return dal.get_Premixs_Report_TransactionDetail(_StartDate, _EndDate, _StockCode, enumStockTransactionForDepartment.ForPremix);
       }
       public DataTable ReportSaleProductQuantity(DateTime startDate, DateTime endDate, string productType)
       {
           return dal.ReportSaleProductQuantity(startDate, endDate, productType);
       }
       public DataTable ReportTinhhinhtontru2(DateTime toDate, string stockCode, int days, bool groupItem, string itemType)
       {
           return dal.ReportTinhhinhtontru2(toDate, stockCode, days, groupItem, itemType);
       }
       public DataSet GetToolDVVCTD(DateTime fromDate, DateTime toDate, string stockCode, string transactionType)
       {
           return dal.GetToolDVVCTD(fromDate, toDate, stockCode, transactionType);
       }
       public int UpdateToolDVVCTD(Guid transactionID, bool dvvcChecked, string dvvc, bool routeCodeChecked, string routeCode, bool tcRouteCodeChecked, string tcRouteCode, bool dvtcChecked, string dvtc, bool ptvcChecked, string ptvc, bool pttcChecked, string pttc)
       {
           return dal.UpdateToolDVVCTD(transactionID, dvvcChecked, dvvc, routeCodeChecked, routeCode, tcRouteCodeChecked, tcRouteCode, dvtcChecked, dvtc, ptvcChecked, ptvc, pttcChecked, pttc);
       }
       public DataTable BangkeNhaphangChitiet(DateTime fromDate, DateTime toDate, String stockCode)
       { return dal.BangkeNhaphangChitiet(fromDate, toDate, stockCode); }
       public DataTable BangkeXuathangChitiet(DateTime fromDate, DateTime toDate, String stockCode)
       { return dal.BangkeXuathangChitiet(fromDate, toDate, stockCode); }

       public DataTable KiemtraPhieuNhapxuatVaPhieucanxetai(DateTime fromDate, DateTime toDate)
       { return dal.KiemtraPhieuNhapxuatVaPhieucanxetai(fromDate, toDate); }
    }
}
