using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class TestRequestReturn : UserTracking2
    {
        public static DataTable StructMaterialDetailTable = null;
        public static DataTable StructProductDetailTable = null;
        public TestRequestReturn() { }
        public TestRequestReturn(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public void RefreshDetail()
        {
            this.Detail.Clear();
            foreach (DataRow dr in this.MaterialDetailTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string subjectCode = dr["TTPT"].ToString();
                string result = dr["Result"].ToString();

                TestRequestReturnDetail detail = new TestRequestReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.SubjectCode = subjectCode;
                detail.IsProduct = false;
                this.Detail.Add(detail);
            }
            foreach (DataRow dr in this.ProductDetailTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string subjectCode = dr["TTPT"].ToString();
                string result = dr["Result"].ToString();

                TestRequestReturnDetail detail = new TestRequestReturnDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.Result = result;
                detail.SubjectCode = subjectCode;
                detail.IsProduct = true;
                this.Detail.Add(detail);
            }
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ReturnID", reader)) returnID = reader.GetGuid(reader.GetOrdinal("ReturnID"));
            if (!isNull("DateReturn", reader)) dateReturn = reader.GetDateTime(reader.GetOrdinal("DateReturn"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("IsReceived", reader)) isReceived = reader.GetBoolean(reader.GetOrdinal("IsReceived"));
            if (!isNull("UserReceived", reader)) userReceived = reader.GetString(reader.GetOrdinal("UserReceived"));
            if (!isNull("DateReceived", reader)) dateReceived = reader.GetDateTime(reader.GetOrdinal("DateReceived"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ReturnID")) returnID = (Guid)row["ReturnID"];
            if (!row.IsNull("DateReturn")) dateReturn = (DateTime)row["DateReturn"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("IsReceived")) isReceived = (bool)row["IsReceived"];
            if (!row.IsNull("UserReceived")) userReceived = (string)row["UserReceived"];
            if (!row.IsNull("DateReceived")) dateReceived = (DateTime)row["DateReceived"];
        }
        private Guid returnID = Guid.Empty;
        public Guid ReturnID
        {
            get { return returnID; }
            set { returnID = value; }
        }
        private DateTime dateReturn = Contexts.WorkingDate;
        public DateTime DateReturn
        {
            get { return dateReturn; }
            set { dateReturn = value; }
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
        private string userReceived = string.Empty;
        public string UserReceived
        {
            get { return userReceived; }
            set { userReceived = value; }
        }
        private DateTime dateReceived = Contexts.WorkingDate;
        public DateTime DateReceived
        {
            get { return dateReceived; }
            set { dateReceived = value; }
        }
        private ListBase<TestRequestReturnDetail> detail = new ListBase<TestRequestReturnDetail>();
        public ListBase<TestRequestReturnDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private ListBase<TestRequestReturnLink> link = new ListBase<TestRequestReturnLink>();
        public ListBase<TestRequestReturnLink> Link
        {
            get { return link; }
            set { link = value; }
        }
        private DataTable materialDetailTable = null;
        public DataTable MaterialDetailTable
        {
            get { return materialDetailTable; }
            set { materialDetailTable = value; }
        }
        private DataTable productDetailTable = null;
        public DataTable ProductDetailTable
        {
            get { return productDetailTable; }
            set { productDetailTable = value; }
        }
    }
}
