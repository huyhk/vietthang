using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestEncryptCode : UserTracking2
    {
        public ProductTestEncryptCode() { }
        public ProductTestEncryptCode(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("ManuDate", reader)) manuDate = reader.GetDateTime(reader.GetOrdinal("ManuDate"));
            if (!isNull("Shift", reader)) shift = reader.GetByte(reader.GetOrdinal("Shift"));
            if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            if (!isNull("SizeCode", reader)) sizeCode = reader.GetString(reader.GetOrdinal("SizeCode"));
            if (!isNull("FormulaCode", reader)) formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Lot", reader)) lot = reader.GetString(reader.GetOrdinal("Lot"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string stockCode = string.Empty;
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
        }
        private DateTime manuDate = Contexts.WorkingDate;
        public DateTime ManuDate
        {
            get { return manuDate; }
            set { manuDate = value; }
        }
        private byte shift = 1;
        public byte Shift
        {
            get { return shift; }
            set { shift = value; }
        }
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        private string sizeCode = string.Empty;
        public string SizeCode
        {
            get { return sizeCode; }
            set { sizeCode = value; }
        }
        private string formulaCode = string.Empty;
        public string FormulaCode
        {
            get { return formulaCode; }
            set { formulaCode = value; }
        }
        private string lot = string.Empty;
        public string Lot
        {
            get { return lot; }
            set { lot = value; }
        }
        private string itemEncryptCode = string.Empty;
        public string ItemEncryptCode
        {
            get { return itemEncryptCode; }
            set { itemEncryptCode = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
