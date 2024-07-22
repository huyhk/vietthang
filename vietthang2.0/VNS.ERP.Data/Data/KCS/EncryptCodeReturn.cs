using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeReturn : UserTracking2
    {
        public static DataTable StructDetailMaterialTable;
        public static DataTable StructDetailProductTable;
        public EncryptCodeReturn() { }
        public EncryptCodeReturn(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ReturnID", reader)) returnID = reader.GetGuid(reader.GetOrdinal("ReturnID"));
            if (!isNull("ReturnNo", reader)) returnNo = reader.GetString(reader.GetOrdinal("ReturnNo"));
            if (!isNull("ReturnDate", reader)) returnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("FWQLCL", reader)) fwQLCL = reader.GetBoolean(reader.GetOrdinal("FWQLCL"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ReturnID")) returnID = (Guid)row["ReturnID"];
            if (!row.IsNull("ReturnNo")) returnNo = (string)row["ReturnNo"];
            if (!row.IsNull("ReturnDate")) returnDate = (DateTime)row["ReturnDate"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("FWQLCL")) fwQLCL = Convert.ToBoolean(row["FWQLCL"]);
        }
        public void RefreshDetail()
        {
            this.Detail.Clear();
            foreach (DataRow dr in this.DetailMaterialTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string result = dr["Result"].ToString();

                EncryptCodeReturnDetail detail = new EncryptCodeReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.IsProduct = false;
                this.Detail.Add(detail);
            }
            foreach (DataRow dr in this.DetailProductTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string result = dr["Result"].ToString();

                EncryptCodeReturnDetail detail = new EncryptCodeReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.IsProduct = true;
                this.Detail.Add(detail);
            }
        }
        private Guid returnID = Guid.Empty;
        public Guid ReturnID
        {
            get { return returnID; }
            set { returnID = value; }
        }
        private string returnNo = string.Empty;
        public string ReturnNo
        {
            get { return returnNo; }
            set { returnNo = value; }
        }
        private DateTime returnDate = Contexts.WorkingDate;
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
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
        private bool fwQLCL = false;
        public bool FWQLCL
        {
            get { return fwQLCL; }
            set { fwQLCL = value; }
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
        private DataTable detailMaterialTableForTestRequestReturnCheck = null;
        public DataTable DetailMaterialTableForTestRequestReturnCheck
        {
            get { return detailMaterialTableForTestRequestReturnCheck; }
            set { detailMaterialTableForTestRequestReturnCheck = value; }
        }
        private DataTable detailProductTableForTestRequestReturnCheck = null;
        public DataTable DetailProductTableForTestRequestReturnCheck
        {
            get { return detailProductTableForTestRequestReturnCheck; }
            set { detailProductTableForTestRequestReturnCheck = value; }
        }
        private ListBase<EncryptCodeReturnDetail> detail = new ListBase<EncryptCodeReturnDetail>();
        public ListBase<EncryptCodeReturnDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
    }
}
