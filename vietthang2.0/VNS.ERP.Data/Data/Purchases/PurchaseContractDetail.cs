using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class PurchaseContractDetail : BaseClass
    {
        public PurchaseContractDetail() { }
        public PurchaseContractDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            if (!isNull("PriceNT", reader)) priceNT = reader.GetDecimal(reader.GetOrdinal("PriceNT"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("VesselCode", reader)) vesselCode = reader.GetString(reader.GetOrdinal("VesselCode"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("PriceNT")) priceNT = (decimal)row["PriceNT"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("VesselCode")) vesselCode = (string)row["VesselCode"];
        }
        private Guid contractID = Guid.Empty;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
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
            set { quantity = value; }
        }
        private decimal price = 0;
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private decimal priceNT = 0;
        public decimal PriceNT
        {
            get { return priceNT; }
            set { priceNT = value; }
        }

        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }

        private string vesselCode = string.Empty;
        public string VesselCode
        {
            get { return vesselCode; }
            set { vesselCode = value; }
        }
    }
}
