using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data.Sales
{
	/// <summary>
	/// This object represents the properties and methods of a FixedAssetOpening.
	/// </summary>
	public class CustomerDeptSumOpening : BaseClass 
	{
		public CustomerDeptSumOpening()
		{
		}

        public CustomerDeptSumOpening(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("CustomerCode", reader)) customerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
                if (!isNull("RemainAmount", reader)) remainAmount = reader.GetDecimal(reader.GetOrdinal("RemainAmount"));
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

        protected string customerCode = string.Empty;
		/// <summary>
        /// Gets or sets the value of FixedAssetCode
		/// </summary>
        public string CustomerCode
		{
            get { return customerCode; }
			set {
                customerCode = value;
            }
		}

        protected decimal remainAmount;
		/// <summary>
        /// Gets or sets the value of Amount
		/// </summary>
        public decimal RemainAmount
		{
            get { return remainAmount; }
			set {
                remainAmount = value;
            }
		}
	}
}	
