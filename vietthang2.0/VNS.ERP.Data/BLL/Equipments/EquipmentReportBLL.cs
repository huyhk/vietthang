using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Equipments
{
    public class EquipmentReportBLL
    {
        EquipmentReportDAL dal = new EquipmentReportDAL();
        public DataSet ReportVattuInventories(DateTime startDate, DateTime endDate)
        {
            return dal.ReportVattuInventories(startDate, endDate);
        }
        public DataSet ReportVattuInventoriesByStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.ReportVattuInventoriesByStockCode(startDate, endDate, stockCode);
        }
        public DataSet ReportVattuInventories_Old(DateTime startDate, DateTime endDate)
        {
            return dal.ReportVattuInventories_Old(startDate, endDate);
        }
        public DataSet ReportVattuInventories_Old_ByStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.ReportVattuInventories_Old_ByStockCode(startDate, endDate, stockCode);
        }
        public DataSet ReportEquipmentSxCodeAmount(DateTime startDate, DateTime endDate)
        {
            return dal.ReportEquipmentSxCodeAmount(startDate, endDate);
        }
        public DataSet ReportXuatTBAmount(DateTime startDate, DateTime endDate)
        {
            return dal.ReportXuatTBAmount(startDate, endDate);
        }

        public int CalVattuOutprice(string periodCode)
        {
            return dal.CalVattuOutprice(periodCode);
        }

        public DataTable Report_ChitietNXVattu(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.Report_ChitietNXVattu(fromDate, toDate, stockCode);
        }
    }
}
