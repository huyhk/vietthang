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
	public class FixedAssetDepreciation : BaseClass 
	{
		public FixedAssetDepreciation()
		{
		}

        public FixedAssetDepreciation(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("FixedAssetCode", reader)) fixedAssetCode = reader.GetString(reader.GetOrdinal("FixedAssetCode"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
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

        protected string fixedAssetCode=string.Empty;
		/// <summary>
        /// Gets or sets the value of FixedAssetCode
		/// </summary>
        public string FixedAssetCode
		{
            get { return fixedAssetCode; }
			set {
                fixedAssetCode = value;
            }
		}

		protected decimal amount;
		/// <summary>
        /// Gets or sets the value of Amount
		/// </summary>
        public decimal Amount
		{
            get { return amount; }
			set {
                amount = value;
            }
		}
	}
}	
