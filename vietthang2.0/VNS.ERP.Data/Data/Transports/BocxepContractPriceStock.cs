using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class BocxepContractPriceStock : BaseClass
    {
        public BocxepContractPriceStock() { }
        public BocxepContractPriceStock(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
        }
        private Guid priceID = Guid.Empty;
        public Guid PriceID
        {
            get { return priceID; }
            set { priceID = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
    }
}
