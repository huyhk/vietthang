using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeSend : UserTracking2
    {
        public static DataTable StructDetailMaterialTable;
        public static DataTable StructDetailProductTable;
        public EncryptCodeSend() { }
        public void RefreshDetail()
        {
            this.Detail.Clear();
            foreach (DataRow dr in this.DetailMaterialTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();

                EncryptCodeSendDetail detail = new EncryptCodeSendDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.IsProduct = false;
                this.Detail.Add(detail);
            }
            foreach (DataRow dr in this.DetailProductTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();

                EncryptCodeSendDetail detail = new EncryptCodeSendDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.IsProduct = true;
                this.Detail.Add(detail);
            }
        }
        public EncryptCodeSend(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("SendID", reader)) sendID = reader.GetGuid(reader.GetOrdinal("SendID"));
            if (!isNull("SendNo", reader)) sendNo = reader.GetString(reader.GetOrdinal("SendNo"));
            if (!isNull("SendDate", reader)) sendDate = reader.GetDateTime(reader.GetOrdinal("SendDate"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("SendID")) sendID = (Guid)row["SendID"];
            if (!row.IsNull("SendNo")) sendNo = (string)row["SendNo"];
            if (!row.IsNull("SendDate")) sendDate = (DateTime)row["SendDate"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid sendID = Guid.Empty;
        public Guid SendID
        {
            get { return sendID; }
            set { sendID = value; }
        }
        private string sendNo = string.Empty;
        public string SendNo
        {
            get { return sendNo; }
            set { sendNo = value; }
        }
        private DateTime sendDate = DateTime.Today;
        public DateTime SendDate
        {
            get { return sendDate; }
            set { sendDate = value; }
        }
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DataTable detailMaterialTable = null;
        public DataTable DetailMaterialTable
        {
            get { return detailMaterialTable; }
            set { detailMaterialTable = value; }
        }
        private DataTable detailProductTable = null;
        public DataTable DetailProductTable
        {
            get { return detailProductTable; }
            set { detailProductTable = value; }
        }
        private ListBase<EncryptCodeSendDetail> detail = new ListBase<EncryptCodeSendDetail>();
        public ListBase<EncryptCodeSendDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
    }
}
