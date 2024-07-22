using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentPrepaid : BaseClass
    {
        public InstrumentPrepaid() { }
        public InstrumentPrepaid(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("InstrumentTransactionDetailID", reader)) instrumentTransactionDetailID = reader.GetGuid(reader.GetOrdinal("InstrumentTransactionDetailID"));
            if (!isNull("PrePaidCode", reader)) prePaidCode = reader.GetString(reader.GetOrdinal("PrePaidCode"));
        }
        private Guid instrumentTransactionDetailID;
        public Guid InstrumentTransactionDetailID
        {
            get { return instrumentTransactionDetailID; }
            set { instrumentTransactionDetailID = value; }
        }
        private string prePaidCode=string.Empty;
        public string PrePaidCode
        {
            get { return prePaidCode; }
            set { prePaidCode = value; }
        }
    }
}
