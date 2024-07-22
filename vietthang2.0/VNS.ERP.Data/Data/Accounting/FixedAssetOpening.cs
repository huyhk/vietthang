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
	public class FixedAssetOpening : AccountFixedAssets 
	{
		public FixedAssetOpening()
		{
		}

		public FixedAssetOpening(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
			    if (!isNull("AccumulatedDepreciation",reader)) accumulatedDepreciation = reader.GetDecimal(reader.GetOrdinal("AccumulatedDepreciation"));
				if (!isNull("RemainCost",reader)) remainCost = reader.GetDecimal(reader.GetOrdinal("RemainCost"));
                if (!isNull("PriceDepreciation", reader)) priceDepreciation = reader.GetDecimal(reader.GetOrdinal("PriceDepreciation"));
			}
		}
		
		protected string periodCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of PeriodCode
		/// </summary>
		public string PeriodCode
		{
			get {return periodCode;}
			set {periodCode = value;}
		}

		protected decimal accumulatedDepreciation;
		/// <summary>
		/// Gets or sets the value of AccumulatedDepreciation
		/// </summary>
		public decimal AccumulatedDepreciation
		{
			get {return accumulatedDepreciation;}
			set {
                accumulatedDepreciation = value;
            }
		}

		protected decimal remainCost;
		/// <summary>
		/// Gets or sets the value of RemainCost
		/// </summary>
		public decimal RemainCost
		{
			get {return remainCost;}
			set {
                  remainCost = value;
            }
		}
        protected decimal priceDepreciation;
        /// <summary>
        /// Gets or sets the value of RemainCost
        /// </summary>
        public decimal PriceDepreciation
        {
            get { return priceDepreciation; }
            set
            {
                priceDepreciation = value;
            }
        }
		

	}

}	
