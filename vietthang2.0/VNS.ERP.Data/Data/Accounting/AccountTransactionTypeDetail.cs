using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionTypeDetail : UserTracking2 
    {
       
        public AccountTransactionTypeDetail()
        { }

        public AccountTransactionTypeDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TransactionTypeCode", reader)) transactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
            if (!isNull("DetailTransactionCode", reader)) detailTransactionCode = reader.GetString(reader.GetOrdinal("DetailTransactionCode"));
            if (!isNull("DetailTransactionName", reader)) detailTransactionName = reader.GetString(reader.GetOrdinal("DetailTransactionName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }

        protected string transactionTypeCode;
        public string TransactionTypeCode
        {
            get { return transactionTypeCode; }
            set { transactionTypeCode = value; }
        }
        protected string detailTransactionCode = string.Empty;
        public string DetailTransactionCode
        {
            get { return detailTransactionCode; }
            set { detailTransactionCode = value; }
        }
 
        protected string detailTransactionName=string.Empty;
        public string DetailTransactionName
        {
            get { return detailTransactionName; }
            set { detailTransactionName = value; }
        }

      
      protected string description=string.Empty;
      public string Description
      {
          get { return description; }
          set { description = value; }
      }
  
    }
}
