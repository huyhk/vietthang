using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
   public class ItemPriceCost: BaseClass
    {
       public ItemPriceCost()
		{
		}
       public ItemPriceCost(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
		        if (!isNull("PriceCost", reader)) priceCost = reader.GetDecimal(reader.GetOrdinal("PriceCost"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("AmountCost", reader)) amountCost = reader.GetDecimal(reader.GetOrdinal("AmountCost"));
                //if (!isNull("Sum_Quantity",reader)) periodCode = reader.GetString(reader.GetOrdinal("Sum_Quantity"));
                //if (!isNull("PriceCostNVL", reader)) itemCode = reader.GetString(reader.GetOrdinal("PriceCostNVL"));
                //if (!isNull("NCPriceCost", reader)) priceCost = reader.GetDecimal(reader.GetOrdinal("NCPriceCost"));
                //if (!isNull("SXCPriceCost",reader)) periodCode = reader.GetString(reader.GetOrdinal("SXCPriceCost"));
                //if (!isNull("PriceCostCal", reader)) itemCode = reader.GetString(reader.GetOrdinal("PriceCostCal"));
		     
			}
		}
        protected string periodCode = String.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

       protected string itemCode = String.Empty;
       public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

       protected decimal priceCost;
       public decimal PriceCost
        {
            get { return priceCost; }
            set { priceCost = value; }
        }

       protected decimal quantity;
       public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        protected decimal amountCost;
       public decimal AmountCost
        {
            get { return amountCost; }
            set { amountCost = value; }
        }

       //protected decimal priceCostNVL;
       //public decimal PriceCostNVL
       // {
       //     get { return priceCostNVL; }
       //     set { priceCostNVL = value; }
       // }

       //protected decimal nCPriceCost;
       //public decimal NCPriceCost
       // {
       //     get { return nCPriceCost; }
       //     set { nCPriceCost = value; }
       // }

       //protected decimal sXCPriceCost;
       //public decimal SXCPriceCost
       // {
       //     get { return sXCPriceCost; }
       //     set { sXCPriceCost = value;
       //         PriceCostCal
       //     }
       // }

       //protected decimal priceCostCal;
       //public decimal PriceCostCal
       // {
       //     get { return priceCostCal; }
       //     set { priceCostCal = value; }
       // }

       
    }
}
