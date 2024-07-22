using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data
{
    public class BocxepContractPrice : UserTracking2
    {
        public BocxepContractPrice() { }
        public BocxepContractPrice(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
            if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
            if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }
        private Guid contractID = Guid.Empty;
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }
        private Guid priceID = Guid.Empty;
        public Guid PriceID
        {
            get { return priceID; }
            set { priceID = value; }
        }
        private DateTime startDate = Contexts.WorkingDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private ListBase<BocxepContractPriceDetail> detail = new ListBase<BocxepContractPriceDetail>();
        public ListBase<BocxepContractPriceDetail> Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private ListBase<BocxepContractPriceStock> detailStock = new ListBase<BocxepContractPriceStock>();
        public ListBase<BocxepContractPriceStock> DetailStock
        {
            get { return detailStock; }
            set { detailStock = value; }
        }

        private ListBase<BocxepContractPriceItem> detailItem = new ListBase<BocxepContractPriceItem>();
        public ListBase<BocxepContractPriceItem> DetailItem
        {
            get { return detailItem; }
            set { detailItem = value; }
        }
    }

    public class BocxepContractPriceItem : BaseClass
    {
        public BocxepContractPriceItem() { }
        public BocxepContractPriceItem(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PriceID", reader)) priceID = reader.GetGuid(reader.GetOrdinal("PriceID"));
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("PriceID")) priceID = (Guid)row["PriceID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
        }
        private Guid priceID = Guid.Empty;
        public Guid PriceID
        {
            get { return priceID; }
            set { priceID = value; }
        }
        private string itemCode = string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
    }
}
