
/************************************************************************
**	ClassName	: 	TransportFee
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	30-11-2009 10:56 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region TransportFee
	/// <summary>
	/// This object represents the properties and methods of a TransportFee.
	/// </summary>
	public class TransportFee : UserTracking2 
	{
			
		
		public TransportFee()
		{
		}
		
		
		
		public TransportFee(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("FeeCode",reader)) feeCode = reader.GetString(reader.GetOrdinal("FeeCode"));
				if (!isNull("FeeName",reader)) feeName = reader.GetString(reader.GetOrdinal("FeeName"));
				if (!isNull("UnitName",reader)) unitName = reader.GetString(reader.GetOrdinal("UnitName"));
				if (!isNull("TaxRate",reader)) taxRate = reader.GetDecimal(reader.GetOrdinal("TaxRate"));
                if (!isNull("TypeCode", reader)) typeCode = reader.GetString(reader.GetOrdinal("TypeCode"));
			}
		}
		
		#region Public Properties

		
		
		private string feeCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of FeeCode
		/// </summary>
		public string FeeCode
		{
			get {return feeCode;}
			set {feeCode = value;}
		}

		private string feeName = String.Empty;
		/// <summary>
		/// Gets or sets the value of FeeName
		/// </summary>
		public string FeeName
		{
			get {return feeName;}
			set {feeName = value;}
		}

		private string unitName = String.Empty;
		/// <summary>
		/// Gets or sets the value of UnitName
		/// </summary>
		public string UnitName
		{
			get {return unitName;}
			set {unitName = value;}
		}

		private decimal taxRate;
		/// <summary>
		/// Gets or sets the value of TaxRate
		/// </summary>
		public decimal TaxRate
		{
			get {return taxRate;}
			set {taxRate = value;}
		}

		private string description = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

        private string typeCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of TypeCode
        /// </summary>
        public string TypeCode
        {
            get { return typeCode; }
            set { typeCode = value; }
        }
		#endregion
		

	}
	#endregion
}	

