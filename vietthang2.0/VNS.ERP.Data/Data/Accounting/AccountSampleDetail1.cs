using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSampleDetail1 : BaseClass
    {
        public AccountSampleDetail1() { }
        public AccountSampleDetail1(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountSampleCode", reader)) accountSampleCode = reader.GetString(reader.GetOrdinal("AccountSampleCode"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("ClassificationCode", reader)) classificationCode = reader.GetString(reader.GetOrdinal("ClassificationCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string accountSampleCode=string.Empty;
        public string AccountSampleCode
        {
            get { return accountSampleCode; }
            set { accountSampleCode = value; }
        }
        private string accountCode=string.Empty;
        public string AccountCode
        {
            get { return accountCode; }
            set 
            { 
                //accountCode = value;
                if (accountCode != value)
                {
                    SubjectCode = "";
                    ClassificationCode = "";
                    accountCode = value;
                }
            }
        }
        private string subjectCode=string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string classificationCode = string.Empty;
        public string ClassificationCode
        {
            get { return classificationCode; }
            set { classificationCode = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
