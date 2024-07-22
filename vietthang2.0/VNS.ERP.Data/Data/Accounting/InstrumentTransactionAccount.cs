using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionAccount:AccountTransaction
    {
        public InstrumentTransactionAccount()
        {
        }
        public InstrumentTransactionAccount(System.Data.IDataReader reader)
            : base(reader)
        {
        }
        private InstrumentTransaction instrTrans;
        public InstrumentTransaction InstrTrans
        {
            get { return instrTrans; }
            set { instrTrans = value; }
        }
    }
}
