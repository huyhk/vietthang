using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class VesselExchangeContract : UserTracking2
    {
        public VesselExchangeContract() { }
        public VesselExchangeContract(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
            if (!isNull("ContractDate", reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
            if (!isNull("ExchangeSubjectCode", reader)) exchangeSubjectCode = reader.GetString(reader.GetOrdinal("ExchangeSubjectCode"));
            if (!isNull("VesselTransactionNo", reader)) vesselTransactionNo = reader.GetString(reader.GetOrdinal("VesselTransactionNo"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("NangsuatbocdoSalan", reader)) nangsuatbocdoSalan = reader.GetDecimal(reader.GetOrdinal("NangsuatbocdoSalan"));
            if (!isNull("GiaphatluuSalan", reader)) giaphatluuSalan = reader.GetDecimal(reader.GetOrdinal("GiaphatluuSalan"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("ExchangeSubjectCode")) exchangeSubjectCode = (string)row["ExchangeSubjectCode"];
            if (!row.IsNull("VesselTransactionNo")) vesselTransactionNo = (string)row["VesselTransactionNo"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("NangsuatbocdoSalan")) nangsuatbocdoSalan = (decimal)row["NangsuatbocdoSalan"];
            if (!row.IsNull("GiaphatluuSalan")) giaphatluuSalan = (decimal)row["GiaphatluuSalan"];
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
        private string exchangeSubjectCode = string.Empty;
        public string ExchangeSubjectCode
        {
            get { return exchangeSubjectCode; }
            set { exchangeSubjectCode = value; }
        }
        private string vesselTransactionNo = string.Empty;
        public string VesselTransactionNo
        {
            get { return vesselTransactionNo; }
            set { vesselTransactionNo = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private decimal nangsuatbocdoSalan = 0;
        public decimal NangsuatbocdoSalan
        {
            get { return nangsuatbocdoSalan; }
            set { nangsuatbocdoSalan = value; }
        }
        private decimal giaphatluuSalan = 0;
        public decimal GiaphatluuSalan
        {
            get { return giaphatluuSalan; }
            set { giaphatluuSalan = value; }
        }
        private ListBase<VesselExchangeContractItem> detail = new ListBase<VesselExchangeContractItem>();
        public ListBase<VesselExchangeContractItem> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
    }
}
