using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountInstrumentTransaction : BaseClass
    {
        public AccountInstrumentTransaction() { }
        public AccountInstrumentTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("InstrumentTransactionID", reader)) instrumentTransactionID = reader.GetGuid(reader.GetOrdinal("InstrumentTransactionID"));
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }
        private Guid instrumentTransactionID;
        public Guid InstrumentTransactionID
        {
            get { return instrumentTransactionID; }
            set { instrumentTransactionID = value; }
        }
    }
}
