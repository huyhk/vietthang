using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace VNS.ERP.Data.Grinds
{
    public class GrindReportBLL
    {
        GrindReportDAL dal = new GrindReportDAL();

        public DataTable ReportGrindShiftDetails(string _StockCode, DateTime _Tungay, DateTime _Denngay, string _ItemType)
        {
            return dal.ReportGrindShiftDetails(_StockCode, (int)enumStockTransactionForDepartment.ForGrind, _Tungay, _Denngay, _ItemType);
        }
    }
}
