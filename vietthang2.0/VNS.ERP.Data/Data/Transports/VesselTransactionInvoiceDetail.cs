using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class VesselTransactionInvoiceDetail : BaseClass
    {
        public VesselTransactionInvoiceDetail() { }
        public VesselTransactionInvoiceDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("InvoiceID", reader)) invoiceID = reader.GetGuid(reader.GetOrdinal("InvoiceID"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("InvoiceID")) invoiceID = (Guid)row["InvoiceID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
        }
        private Guid invoiceID = Guid.Empty;
        public Guid InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }
        private string itemCode = string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private decimal quantity = 0;
        public decimal Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                amount = quantity * price;
            }
        }
        private decimal price = 0;
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                amount = quantity * price;
            }
        }
        private decimal amount = 0;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
}
