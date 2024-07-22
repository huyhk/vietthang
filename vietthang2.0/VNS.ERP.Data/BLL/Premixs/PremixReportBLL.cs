using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace VNS.ERP.Data.Premixs
{
    public class PremixReportBLL
    {
        PremixReportDAL dal = new PremixReportDAL();

        public DataTable ReportGrindShiftDetails(string _StockCode, DateTime _Tungay, DateTime _Denngay, string _ItemType)
        {
            return dal.ReportPremixShiftDetails(_StockCode, (int)enumStockTransactionForDepartment.ForPremix, _Tungay, _Denngay, _ItemType);
        }
        public DataTable PremixReportDetail(string stockCode, DateTime fromDate, DateTime toDate)
        {
            return dal.PremixReportDetail(stockCode, fromDate, toDate );
        }
    }
}
