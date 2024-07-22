using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class BocxepContract : UserTracking2
    {
        public BocxepContract() { }
        public BocxepContract(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public BocxepContract(DataRow row)
        {
            this.LoadFromDataRow(row);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
            if (!isNull("ContractDate", reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
            if (!isNull("BocxepSubjectCode", reader)) bocxepSubjectCode = reader.GetString(reader.GetOrdinal("BocxepSubjectCode"));
            if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
            if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("BocxepSubjectCode")) bocxepSubjectCode = (string)row["BocxepSubjectCode"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid contractID = Guid.Empty;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        private string contractNo = string.Empty;
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }
        private DateTime contractDate = Contexts.WorkingDate;
        public DateTime ContractDate
        {
            get { return contractDate; }
            set { contractDate = value; }
        }
        private string bocxepSubjectCode = string.Empty;
        public string BocxepSubjectCode
        {
            get { return bocxepSubjectCode; }
            set { bocxepSubjectCode = value; }
        }
        private DateTime fromDate = Contexts.WorkingDate;
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private DateTime toDate = Contexts.WorkingEndDate;
        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<BocxepContractPrice> detail = new ListBase<BocxepContractPrice>();
        public ListBase<BocxepContractPrice> Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        private ListBase<BocxepContractService> listBocxepContractService = new ListBase<BocxepContractService>();

        public ListBase<BocxepContractService> ListBocxepContractService
        {
            get { return listBocxepContractService; }
            set { listBocxepContractService = value; }
        }
	
    }
}
