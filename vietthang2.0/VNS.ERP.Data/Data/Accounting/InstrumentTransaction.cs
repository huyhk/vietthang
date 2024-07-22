using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransaction : BaseClass
    {
        public InstrumentTransaction() { }
        public InstrumentTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TransactionID")) transactionID = (Guid)(row["TransactionID"]);
            if (!row.IsNull("TransactionType")) transactionType = (String)(row["TransactionType"]);
            if (!row.IsNull("TransactionNo")) transactionNo = (String)(row["TransactionNo"]);
            if (!row.IsNull("TransactionDate")) transactionDate = (DateTime)(row["TransactionDate"]);
            if (!row.IsNull("Description")) description = (String)(row["Description"]);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
            if (!isNull("TransactionType", reader)) transactionType = reader.GetString(reader.GetOrdinal("TransactionType"));
            if (!isNull("TransactionNo", reader)) transactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
            if (!isNull("TransactionDate", reader)) transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private Guid transactionID;
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        private string transactionType=string.Empty;
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }
        private string transactionNo=string.Empty;
        public string TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }
        private DateTime transactionDate=Contexts.WorkingDate;
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<InstrumentTransactionDetail> detail;
        public ListBase<InstrumentTransactionDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
    }
}
