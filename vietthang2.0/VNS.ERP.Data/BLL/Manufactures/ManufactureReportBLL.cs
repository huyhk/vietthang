using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureReportBLL
    {
        ManufactureReportDAL dal = new ManufactureReportDAL();
        public DataSet GetDSTHNam(int year, string stockCode)
        {
            return dal.GetDSTHNam(year, stockCode);
        }
        public DataTable ReportCompareAutoGen(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.ReportCompareAutoGen(fromDate, toDate, stockCode);
        }

        public DataTable ReportTonkhophe(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.ReportTonkhophe(fromDate, toDate, stockCode);
        }

        public DataSet ReportTHThangNM(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.ReportTHThangNM(fromDate, toDate, stockCode);
        }
        public DataTable Report_TonkhoPremi(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.Report_TonkhoPremi(fromDate, toDate, stockCode);
        }
        public DataTable Report_TonkhoBaobi(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.Report_TonkhoBaobi(fromDate, toDate, stockCode);
        }
    }

}
