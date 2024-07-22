using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestTransaction : UserTracking2
    {
        public MaterialTestTransaction() { }
        public MaterialTestTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TestTransactionID", reader)) testTransactionID = reader.GetGuid(reader.GetOrdinal("TestTransactionID"));
            if (!isNull("TestTransactionNo", reader)) testTransactionNo = reader.GetString(reader.GetOrdinal("TestTransactionNo"));
            if (!isNull("TestTransactionDate", reader)) testTransactionDate = reader.GetDateTime(reader.GetOrdinal("TestTransactionDate"));
            //if (!isNull("BranchCode", reader)) branchCode = reader.GetString(reader.GetOrdinal("BranchCode"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("Location", reader)) location = reader.GetString(reader.GetOrdinal("Location"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("PTVC", reader)) pTVC = reader.GetString(reader.GetOrdinal("PTVC"));
            //if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            //if (!isNull("EndDate", reader)) endDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TestTransactionID")) testTransactionID = (Guid)row["TestTransactionID"];
            if (!row.IsNull("TestTransactionNo")) testTransactionNo = (string)row["TestTransactionNo"];
            if (!row.IsNull("TestTransactionDate")) testTransactionDate = (DateTime)row["TestTransactionDate"];
            //if (!row.IsNull("BranchCode")) branchCode = (string)row["BranchCode"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("Location")) location = (string)row["Location"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("PTVC")) pTVC = (string)row["PTVC"];
            //if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            //if (!row.IsNull("EndDate")) endDate = (DateTime)row["EndDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid testTransactionID = Guid.Empty;
        public Guid TestTransactionID
        {
            get { return testTransactionID; }
            set { testTransactionID = value; }
        }
        private string testTransactionNo = string.Empty;
        public string TestTransactionNo
        {
            get { return testTransactionNo; }
            set { testTransactionNo = value; }
        }
        private DateTime testTransactionDate = Contexts.WorkingDate;
        public DateTime TestTransactionDate
        {
            get { return testTransactionDate; }
            set { testTransactionDate = value; }
        }
        //private string branchCode = string.Empty;
        //public string BranchCode
        //{
        //    get { return branchCode; }
        //    set { branchCode = value; }
        //}
        private string itemCode = string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private string location = string.Empty;
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string pTVC = string.Empty;
        public string PTVC
        {
            get { return pTVC; }
            set { pTVC = value; }
        }
        //private DateTime startDate= DateTime.Today;
        //public DateTime StartDate
        //{
        //    get { return startDate; }
        //    set { startDate = value; }
        //}
        //private DateTime endDate = DateTime.Today;
        //public DateTime EndDate
        //{
        //    get { return endDate; }
        //    set { endDate = value; }
        //}
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<MaterialTestTransactionDetail> detail = new ListBase<MaterialTestTransactionDetail>();
        public ListBase<MaterialTestTransactionDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        private string tester = string.Empty;

        public string Tester
        {
            get { return tester; }
            set { tester = value; }
        }
    }
}
