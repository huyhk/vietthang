using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
    public class TransportReportBLL
    {
        TransportReportDAL dal = new TransportReportDAL();

        public DataSet Report_BocxepResults(DateTime fromDate, DateTime toDate)
        {
            return dal.Report_BocxepResults(fromDate, toDate);
        }
        public DataSet Report_TransportResults(DateTime fromDate, DateTime toDate)
        {
            return dal.Report_TransportResults(fromDate, toDate);
        }
        public DataTable Report_BocxepResultGeneral(DateTime fromDate, DateTime toDate)
        {
            return dal.Report_BocxepResultGeneral(fromDate, toDate);
        }

        public DataSet TransportResult_SelectByContractNo(string contractNo, string subjectCode)
        {
            return dal.TransportResult_SelectByContractNo(contractNo, subjectCode);
        }
        public DataSet TransportResult_SelectByContractNoAndDate(string contractNo, string subjectCode, DateTime fromDate, DateTime toDate)
        {
            return dal.TransportResult_SelectByContractNoAndDate(contractNo, subjectCode, fromDate, toDate);
        }
        public DataSet TransportResult_SelectByID(Guid resultID)
        {
            return dal.TransportResult_SelectByID(resultID);
        }
        //public DataSet TCResult_SelectBySubjectAndDate(string subjectCode, DateTime fromDate, DateTime toDate)
        //{
        //    return dal.TCResult_SelectBySubjectAndDate(subjectCode, fromDate, toDate);
        //}
        public DataSet TCResult_SelectByContractAndDate(Guid contractID, DateTime fromDate, DateTime toDate)
        { return dal.TCResult_SelectByContractAndDate(contractID, fromDate, toDate); }

        public DataSet TCResult_Report(DateTime fromDate, DateTime toDate, string stockCode, string subjectCode, string itemType)
        { return dal.TCResult_Report(fromDate, toDate, stockCode, subjectCode, itemType); }

        public DataSet VCResult_ByBatch(Guid batchID)
        { return dal.VCResult_ByBatch(batchID); }

        public DataSet VCResult_Cont(DateTime fromDate, DateTime toDate)
        {
            DataSet ds = dal.VCResult_Cont(fromDate, toDate);
            ds.Relations.Add("Batch", new DataColumn[] { ds.Tables[0].Columns["BatchID"] },
                        new DataColumn[] { ds.Tables[1].Columns["BatchID"] });
            //DataTable dt = ds.Tables[0];

            //dt.Columns.Add(new DataColumn("SLGiaoNet", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("ThucnhapNet", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("Haohuttoanlo", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("TyleHaohut", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("Khoiluongchophep", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("HaohutVC", typeof(decimal))).DefaultValue = 0;
            //dt.Columns.Add(new DataColumn("KLBoithuong", typeof(decimal))).DefaultValue = 0;

            return ds;

        }

        public DataSet TransportReportGeneral(int year)
        {
            DataSet ds = dal.TransportReportGeneral(year);
            return ds;
        }
    }
}
