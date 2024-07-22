using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class TestRequestReturnDetail : BaseClass
    {
        public TestRequestReturnDetail() { }
        public TestRequestReturnDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ReturnID", reader)) returnID = reader.GetGuid(reader.GetOrdinal("ReturnID"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("Result", reader)) result = reader.GetString(reader.GetOrdinal("Result"));
            if (!isNull("IsProduct", reader)) isProduct = reader.GetBoolean(reader.GetOrdinal("IsProduct"));
            if (!isNull("IsApplied", reader)) isApplied = reader.GetBoolean(reader.GetOrdinal("IsApplied"));
            if (!isNull("DateApplied", reader)) dateApplied = reader.GetDateTime(reader.GetOrdinal("DateApplied"));
        }
        private Guid returnID = Guid.Empty;
        public Guid ReturnID
        {
            get { return returnID; }
            set { returnID = value; }
        }
        private string itemEncryptCode = string.Empty;
        public string ItemEncryptCode
        {
            get { return itemEncryptCode; }
            set { itemEncryptCode = value; }
        }
        private string techCode = string.Empty;
        public string TechCode
        {
            get { return techCode; }
            set { techCode = value; }
        }
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string result = string.Empty;
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        private bool isProduct = false;
        public bool IsProduct
        {
            get { return isProduct; }
            set { isProduct = value; }
        }
        private bool isApplied = false;
        public bool IsApplied
        {
            get { return isApplied; }
            set { isApplied = value; }
        }
        private DateTime dateApplied = Contexts.WorkingDate;
        public DateTime DateApplied
        {
            get { return dateApplied; }
            set { dateApplied = value; }
        }
        private string subjectName = string.Empty;

        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }
        private string description = string.Empty;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

	
	
    }
}
