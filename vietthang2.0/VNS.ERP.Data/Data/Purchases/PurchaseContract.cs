using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class PurchaseContract : UserTracking2
    {
        public PurchaseContract() { }
        public PurchaseContract(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
            if (!isNull("ContractDate", reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
            if (!isNull("VendorCode", reader)) vendorCode = reader.GetString(reader.GetOrdinal("VendorCode"));
            if (!isNull("IsOverSea", reader)) isOverSea = reader.GetBoolean(reader.GetOrdinal("IsOverSea"));
            if (!isNull("IsTransported", reader)) isTransported = reader.GetBoolean(reader.GetOrdinal("IsTransported"));
            if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("FromDate", reader)) fromDate = reader.GetDateTime(reader.GetOrdinal("FromDate"));
            if (!isNull("ToDate", reader)) toDate = reader.GetDateTime(reader.GetOrdinal("ToDate"));
            if (!isNull("IsFinished", reader)) isFinished = reader.GetBoolean(reader.GetOrdinal("IsFinished"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("VendorCode")) vendorCode = (string)row["VendorCode"];
            if (!row.IsNull("IsOverSea")) isOverSea = (bool)row["IsOverSea"];
            if (!row.IsNull("IsTransported")) isTransported = (bool)row["IsTransported"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("FromDate")) fromDate = (DateTime)row["FromDate"];
            if (!row.IsNull("ToDate")) toDate = (DateTime)row["ToDate"];
            if (!row.IsNull("IsFinished")) isFinished = (bool)row["IsFinished"];
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
        private string vendorCode = string.Empty;
        public string VendorCode
        {
            get { return vendorCode; }
            set { vendorCode = value; }
        }
        private bool isOverSea = false;
        public bool IsOverSea
        {
            get { return isOverSea; }
            set
            {
                isOverSea = value;
            }
        }
        private bool isTransported = false;
        public bool IsTransported
        {
            get { return isTransported; }
            set { isTransported = value; }
        }
        private string currencyCode= string.Empty;
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DateTime fromDate = Contexts.WorkingEndDate;
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
        private bool isFinished = false;
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }
        private ListBase<PurchaseContractDetail> detail = new ListBase<PurchaseContractDetail>();
        public ListBase<PurchaseContractDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private ListBase<PurchaseContractLinkStock> linkStock = new ListBase<PurchaseContractLinkStock>();
        public ListBase<PurchaseContractLinkStock> LinkStock
        {
            get { return linkStock; }
            set { linkStock = value; }
        }

        public DataSet PurchaseTransaction;
        public DataSet PurchaseInvoice;
    }
}
