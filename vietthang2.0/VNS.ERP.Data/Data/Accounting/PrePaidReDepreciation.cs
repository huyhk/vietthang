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
    public class PrePaidReDepreciation : BaseClass 
	{
		public PrePaidReDepreciation()
		{
		}

        public PrePaidReDepreciation(IDataReader reader)
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
                if (!isNull("DepRate", reader)) depRate = reader.GetDecimal(reader.GetOrdinal("DepRate"));
                if (!isNull("DepMonth", reader)) depMonth = reader.GetInt32(reader.GetOrdinal("DepMonth"));
              
              
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

        protected decimal depRate;
        public decimal DepRate
        {
            get { return depRate; }
            set { depRate = value; }
        }
        protected int depMonth;
        public int DepMonth
        {
            get { return depMonth; }
            set {depMonth = value; }
        }
        protected bool checkEdit=true;
        public bool CheckEdit
        {
            get { return checkEdit; }
            set { checkEdit = value; }
        }
       
    }
}