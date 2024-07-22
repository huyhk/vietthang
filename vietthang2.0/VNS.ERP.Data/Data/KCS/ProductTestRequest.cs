using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestRequest : UserTracking2
    {
        public ProductTestRequest() { }
        public ProductTestRequest(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("RequestID", reader)) requestID = reader.GetGuid(reader.GetOrdinal("RequestID"));
            if (!isNull("DateRequest", reader)) dateRequest = reader.GetDateTime(reader.GetOrdinal("DateRequest"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("IsReceived", reader)) isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
            if (!isNull("DateReceived", reader)) dateReceived = reader.GetDateTime(reader.GetOrdinal("DateReceived"));
            if (!isNull("UserReceived", reader)) userReceived = reader.GetString(reader.GetOrdinal("UserReceived"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("RequestID")) requestID = (Guid)row["RequestID"];
            if (!row.IsNull("DateRequest")) dateRequest = (DateTime)row["DateRequest"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("IsReceived")) isReceived = (bool)row["IsReceived"];
            if (!row.IsNull("UserReceived")) userReceived = (string)row["UserReceived"];
            if (!row.IsNull("DateReceived")) dateReceived = (DateTime)row["DateReceived"];
        }
        private Guid requestID = Guid.Empty;
        public Guid RequestID
        {
            get { return requestID; }
            set { requestID = value; }
        }
        private DateTime dateRequest = Contexts.WorkingDate;
        public DateTime DateRequest
        {
            get { return dateRequest; }
            set { dateRequest = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private bool isReceived = false;
        public bool IsReceived
        {
            get { return isReceived; }
            set { isReceived = value; }
        }
        private DateTime dateReceived = Contexts.WorkingDate;
        public DateTime DateReceived
        {
            get { return dateReceived; }
            set { dateReceived = value; }
        }
        private string userReceived = string.Empty;
        public string UserReceived
        {
            get { return userReceived; }
            set { userReceived = value; }
        }
        private ListBase<ProductTestRequestDetail> detail = new ListBase<ProductTestRequestDetail>();
        public ListBase<ProductTestRequestDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private DataTable detailTable = null;
        public DataTable DetailTable
        {
            get { return detailTable; }
            set { detailTable = value; }
        }
        public static DataTable StructDetailTable;
    }
}
