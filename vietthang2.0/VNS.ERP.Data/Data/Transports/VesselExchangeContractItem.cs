using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class VesselExchangeContractItem : BaseClass
    {
        public VesselExchangeContractItem() { }
        public VesselExchangeContractItem(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("TransportItemTypeCode", reader)) transportItemTypeCode = reader.GetString(reader.GetOrdinal("TransportItemTypeCode"));
            if (!isNull("TransportTypeCode", reader)) transportTypeCode = reader.GetString(reader.GetOrdinal("TransportTypeCode"));
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("GiaVanchuyen", reader)) giaVanchuyen = reader.GetDecimal(reader.GetOrdinal("GiaVanchuyen"));
            if (!isNull("Haohutchophep", reader)) haohutchophep = reader.GetDecimal(reader.GetOrdinal("Haohutchophep"));
            if (!isNull("Giaboithuong", reader)) giaboithuong = reader.GetDecimal(reader.GetOrdinal("Giaboithuong"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("TransportItemTypeCode")) transportItemTypeCode = (string)row["TransportItemTypeCode"];
            if (!row.IsNull("TransportTypeCode")) transportTypeCode = (string)row["TransportTypeCode"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("GiaVanchuyen")) giaVanchuyen = (decimal)row["GiaVanchuyen"];
            if (!row.IsNull("Haohutchophep")) haohutchophep = (decimal)row["Haohutchophep"];
            if (!row.IsNull("Giaboithuong")) giaboithuong = (decimal)row["Giaboithuong"];
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
        private string transportItemTypeCode = string.Empty;
        public string TransportItemTypeCode
        {
            get { return transportItemTypeCode; }
            set { transportItemTypeCode = value; }
        }
        private string transportTypeCode = string.Empty;
        public string TransportTypeCode
        {
            get { return transportTypeCode; }
            set { transportTypeCode = value; }
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private decimal giaVanchuyen = 0;
        public decimal GiaVanchuyen
        {
            get { return giaVanchuyen; }
            set { giaVanchuyen = value; }
        }
        private decimal haohutchophep = 0;
        public decimal Haohutchophep
        {
            get { return haohutchophep; }
            set { haohutchophep = value; }
        }
        private decimal giaboithuong = 0;
        public decimal Giaboithuong
        {
            get { return giaboithuong; }
            set { giaboithuong = value; }
        }
    }
}
