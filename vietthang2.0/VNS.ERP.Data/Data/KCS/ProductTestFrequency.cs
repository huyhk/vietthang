using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestFrequency : UserTracking2
    {
        public ProductTestFrequency() { }
        public ProductTestFrequency(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            if (!isNull("FrequencyType", reader)) frequencyType = reader.GetString(reader.GetOrdinal("FrequencyType"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("QuantityLocal", reader)) quantityLocal = reader.GetDecimal(reader.GetOrdinal("QuantityLocal"));
        }
        private string productCode = string.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        private string techCode = string.Empty;
        public string TechCode
        {
            get { return techCode; }
            set { techCode = value; }
        }
        private DateTime startDate = Contexts.WorkingDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        private string frequencyType = string.Empty;
        public string FrequencyType
        {
            get { return frequencyType; }
            set { frequencyType = value; }
        }
        private decimal quantity = 0;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private decimal quantityLocal = 0;
        public decimal QuantityLocal
        {
            get { return quantityLocal; }
            set { quantityLocal = value; }
        }
    }
}
