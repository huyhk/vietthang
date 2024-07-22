using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSubjectType : BaseClass
    {
        public AccountSubjectType() { }
        public AccountSubjectType(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountCode", reader)) fAccountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("SubjectTypeCode", reader)) fSubjectTypeCode = reader.GetString(reader.GetOrdinal("SubjectTypeCode"));
        }
        private string fAccountCode;
        public string AccountCode
        {
            get { return fAccountCode; }
            set { fAccountCode = value; }
        }
        private string fSubjectTypeCode;
        public string SubjectTypeCode
        {
            get { return fSubjectTypeCode; }
            set { fSubjectTypeCode = value; }
        }
    }
}
