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
    public class PrePaidDepreciation : BaseClass 
	{
		public PrePaidDepreciation()
		{
		}

        public PrePaidDepreciation(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{
                if (!isNull("PeriodCode", reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("PrePaidCode", reader)) prePaidCode = reader.GetString(reader.GetOrdinal("PrePaidCode"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            }
        }
        protected string periodCode = string.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

        protected string prePaidCode=string.Empty;
        public string PrePaidCode
        {
            get { return prePaidCode; }
            set { prePaidCode = value;}
        }

        protected decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
       
    }
}