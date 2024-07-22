using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockNew: AccountTransaction
    {
        public AccountTransactionStockNew()
        {
        }
        public AccountTransactionStockNew(System.Data.IDataReader reader)
            : base(reader)
        {
        }
        public string Tenkho
        {
            get 
            {
                string tenKho = string.Empty;
                if (this.AccTransactionStock != null)
                {
                    tenKho = this.AccTransactionStock.Tenkho;
                }
                return tenKho;
            }
        }
        public string InvoiceNo
        {
            get
            {
                string invoiceNo = string.Empty;
                if (this.AccTransactionStock != null)
                {
                    invoiceNo = this.AccTransactionStock.InvoiceSo;
                }
                return invoiceNo;
            }
        }
        private AccountTransactionStock accTransactionStock;
        public AccountTransactionStock AccTransactionStock
        {
            get { return accTransactionStock; }
            set { accTransactionStock = value; }
        }
    }
}
