using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSample : UserTracking2
    {
        public AccountSample() { }
        public AccountSample(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountSampleCode", reader)) accountSampleCode = reader.GetString(reader.GetOrdinal("AccountSampleCode"));
            if (!isNull("AccountSampleName", reader)) accountSampleName = reader.GetString(reader.GetOrdinal("AccountSampleName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("AccountTransactionTypeCode", reader)) accountTransactionTypeCode = reader.GetString(reader.GetOrdinal("AccountTransactionTypeCode"));
        }
        private string accountSampleCode;
        public string AccountSampleCode
        {
            get { return accountSampleCode; }
            set { accountSampleCode = value; }
        }
        private string accountSampleName;
        public string AccountSampleName
        {
            get { return accountSampleName; }
            set { accountSampleName = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string accountTransactionTypeCode=string.Empty;
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set { accountTransactionTypeCode = value; }
        }
        private ListBase<AccountSampleDetail1> detail1;
        public ListBase<AccountSampleDetail1> Detail1
        {
            get { return detail1; }
            set { detail1 = value; }
        }
        private ListBase<AccountSampleDetail2> detail2;
        public ListBase<AccountSampleDetail2> Detail2
        {
            get { return detail2; }
            set { detail2 = value; }
        }
    }
}
