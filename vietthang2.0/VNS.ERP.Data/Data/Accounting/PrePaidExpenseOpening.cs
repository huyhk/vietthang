
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data.Accounting
{
	/// <summary>
	/// This object represents the properties and methods of a FixedAssetOpening.
	/// </summary>
    public class PrePaidExpenseOpening : PrePaidExpense 
	{
		public PrePaidExpenseOpening()
		{
		}

        public PrePaidExpenseOpening(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
                if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("AccumulatedDepreciation", reader)) accumulatedDepreciation = reader.GetDecimal(reader.GetOrdinal("AccumulatedDepreciation"));
                if (!isNull("RemainCost", reader)) remainCost = reader.GetDecimal(reader.GetOrdinal("RemainCost"));
              
              
            }
        }
        protected string periodCode = string.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }
       
        protected decimal accumulatedDepreciation;
        public decimal AccumulatedDepreciation
        {
            get { return accumulatedDepreciation; }
            set
            {
                accumulatedDepreciation = value;
            }
        }

        protected decimal remainCost;
        public decimal RemainCost
        {
            get { return remainCost; }
            set
            {
                remainCost = value;
            }
        }
       
    }
}