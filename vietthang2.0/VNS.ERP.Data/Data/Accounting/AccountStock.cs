using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountStock : BaseClass
    {
        public AccountStock() { }
        public AccountStock(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("StockTransactionID", reader)) stockTransactionID = reader.GetGuid(reader.GetOrdinal("StockTransactionID"));
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set {accountTransactionID = value; }
        }
        private Guid stockTransactionID;
        public Guid StockTransactionID
        {
            get { return stockTransactionID; }
            set { stockTransactionID = value; }
        }
    }
}
