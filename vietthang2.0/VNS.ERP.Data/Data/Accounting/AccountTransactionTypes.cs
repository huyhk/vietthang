using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionTypes : BaseClass
    {
        public AccountTransactionTypes() { }
        public AccountTransactionTypes(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionTypeCode", reader)) accountTransactionTypeCode = reader.GetString(reader.GetOrdinal("AccountTransactionTypeCode"));
            if (!isNull("AccountTransactionTypeName", reader)) accountTransactionTypeName = reader.GetString(reader.GetOrdinal("AccountTransactionTypeName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string accountTransactionTypeCode = string.Empty;
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set { accountTransactionTypeCode = value; }
        }
        private string accountTransactionTypeName = string.Empty;
        public string AccountTransactionTypeName
        {
            get { return accountTransactionTypeName; }
            set { accountTransactionTypeName = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
