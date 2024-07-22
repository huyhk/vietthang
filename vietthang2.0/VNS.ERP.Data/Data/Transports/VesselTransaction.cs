using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class VesselTransaction : UserTracking2
    {
        public VesselTransaction() { }
        public VesselTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TransactionID", reader)) transactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
            if (!isNull("TransactionNo", reader)) transactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
            if (!isNull("TransactionDate", reader)) transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
            if (!isNull("VesselCode", reader)) vesselCode = reader.GetString(reader.GetOrdinal("VesselCode"));
            if (!isNull("VendorCode", reader)) vendorCode = reader.GetString(reader.GetOrdinal("VendorCode"));
            if (!isNull("StartPlace", reader)) startPlace = reader.GetString(reader.GetOrdinal("StartPlace"));
            if (!isNull("EndPlace", reader)) endPlace = reader.GetString(reader.GetOrdinal("EndPlace"));
            if (!isNull("EstimateDate", reader)) estimateDate = reader.GetDateTime(reader.GetOrdinal("EstimateDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TransactionID")) transactionID = (Guid)row["TransactionID"];
            if (!row.IsNull("TransactionNo")) transactionNo = (string)row["TransactionNo"];
            if (!row.IsNull("TransactionDate")) transactionDate = (DateTime)row["TransactionDate"];
            if (!row.IsNull("VesselCode")) vesselCode = (string)row["VesselCode"];
            if (!row.IsNull("VendorCode")) vendorCode = (string)row["VendorCode"];
            if (!row.IsNull("StartPlace")) startPlace = (string)row["StartPlace"];
            if (!row.IsNull("EndPlace")) endPlace = (string)row["EndPlace"];
            if (!row.IsNull("EstimateDate")) estimateDate = (DateTime)row["EstimateDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid transactionID = Guid.Empty;
        public Guid TransactionID
        {
            get { return transactionID; }
            set { transactionID = value; }
        }
        private string transactionNo = string.Empty;
        public string TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }
        private DateTime transactionDate = Contexts.WorkingDate;
        public DateTime TransactionDate
        {
            get { return transactionDate; }
            set { transactionDate = value; }
        }
        private string vesselCode = string.Empty;
        public string VesselCode
        {
            get { return vesselCode; }
            set { vesselCode = value; }
        }
        private string vendorCode = string.Empty;
        public string VendorCode
        {
            get { return vendorCode; }
            set { vendorCode = value; }
        }
        private string startPlace = string.Empty;
        public string StartPlace
        {
            get { return startPlace; }
            set { startPlace = value; }
        }
        private string endPlace = string.Empty;
        public string EndPlace
        {
            get { return endPlace; }
            set { endPlace = value; }
        }
        private DateTime estimateDate = Contexts.WorkingEndDate;
        public DateTime EstimateDate
        {
            get { return estimateDate; }
            set { estimateDate = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<VesselTransactionInvoice> detailInvoice = new ListBase<VesselTransactionInvoice>();
        public ListBase<VesselTransactionInvoice> DetailInvoice
        {
            get { return detailInvoice; }
            set { detailInvoice = value; }
        }
    }
}
