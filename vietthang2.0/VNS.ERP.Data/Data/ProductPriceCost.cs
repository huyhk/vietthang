using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class ProductPriceCost : BaseClass
    {
        public ProductPriceCost()
        {
        }
        public ProductPriceCost(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("ProductCode", reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
                if (!isNull("WrappingCode", reader)) wrappingCode = reader.GetString(reader.GetOrdinal("WrappingCode"));
                if (!isNull("PriceCost", reader)) priceCost = reader.GetDecimal(reader.GetOrdinal("PriceCost"));
            }
        }
        protected string periodCode = String.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

        protected string productCode = String.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        protected decimal priceCost;
        public decimal PriceCost
        {
            get { return priceCost; }
            set { priceCost = value; }
        }
        protected string wrappingCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of WrappingCode
        /// </summary>
        public string WrappingCode
        {
            get { return wrappingCode; }
            set { wrappingCode = value; }
        }
    }
}
