using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
   public class ProductSizePriceCost: BaseClass
    {
       public ProductSizePriceCost()
		{
		}
       public ProductSizePriceCost(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("ProductSizeCode", reader)) productSizeCode = reader.GetString(reader.GetOrdinal("ProductSizeCode"));
		        if (!isNull("NCPriceCost", reader)) ncpriceCost = reader.GetDecimal(reader.GetOrdinal("NCPriceCost"));
                if (!isNull("SXCPriceCost", reader)) sxcPriceCost = reader.GetDecimal(reader.GetOrdinal("SXCPriceCost"));
                if (!isNull("ProductType", reader)) productType = reader.GetString(reader.GetOrdinal("ProductType"));
			}
		}
        protected string periodCode = String.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

       protected string productSizeCode = String.Empty;
       public string ProductSizeCode
       {
           get { return productSizeCode; }
           set { productSizeCode = value; }
       }

       protected string productType = String.Empty;
       public string ProductType
       {
           get { return productType; }
           set { productType = value; }
       }

       protected decimal ncpriceCost;
       public decimal NCPriceCost
        {
            get { return ncpriceCost; }
            set { ncpriceCost = value; }
        }

       protected decimal sxcPriceCost;
       public decimal SXCPriceCost
        {
            get { return sxcPriceCost; }
            set { sxcPriceCost = value; }
        }
    }
}
