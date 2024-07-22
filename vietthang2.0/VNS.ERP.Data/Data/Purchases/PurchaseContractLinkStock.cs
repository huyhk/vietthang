using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data
{
    public class PurchaseContractLinkStock : BaseClass
    {
        public PurchaseContractLinkStock() { }
        public PurchaseContractLinkStock(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("StockTransactionNo", reader)) stockTransactionNo = reader.GetString(reader.GetOrdinal("StockTransactionNo"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("StockTransactionNo")) stockTransactionNo = (string)row["StockTransactionNo"];
        }
        private Guid contractID = Guid.Empty;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        private string stockTransactionNo = string.Empty;
        public string StockTransactionNo
        {
            get { return stockTransactionNo; }
            set { stockTransactionNo = value; }
        }
    }
}
