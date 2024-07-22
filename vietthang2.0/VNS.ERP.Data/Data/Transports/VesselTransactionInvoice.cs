using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class VesselTransactionInvoice : BaseClass
    {
        public VesselTransactionInvoice() { }
        public VesselTransactionInvoice(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
            if (!isNull("InvoiceID", reader)) invoiceID = reader.GetGuid(reader.GetOrdinal("InvoiceID"));
            if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
            if (!isNull("InvoiceNo", reader)) invoiceNo = reader.GetString(reader.GetOrdinal("InvoiceNo"));
            if (!isNull("InvoiceDate", reader)) invoiceDate = reader.GetDateTime(reader.GetOrdinal("InvoiceDate"));
            if (!isNull("TotalAmount", reader)) totalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount"));
            if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TransactionID")) transactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("InvoiceID")) invoiceID = (Guid)row["InvoiceID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("InvoiceNo")) invoiceNo = (string)row["InvoiceNo"];
            if (!row.IsNull("InvoiceDate")) invoiceDate = (DateTime)row["InvoiceDate"];
            if (!row.IsNull("TotalAmount")) totalAmount = (decimal)row["TotalAmount"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
        }
        private Guid transactionID = Guid.Empty;
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        private Guid invoiceID = Guid.Empty;
        public Guid InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        private string contractNo = string.Empty;
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }
        private string invoiceNo = string.Empty;
        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }
        private DateTime invoiceDate = Contexts.WorkingDate;
        public DateTime InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
        private decimal totalAmount = 0;
        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        private string currencyCode = string.Empty;
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        private ListBase<VesselTransactionInvoiceDetail> detail = new ListBase<VesselTransactionInvoiceDetail>();
        public ListBase<VesselTransactionInvoiceDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
    }
}
