using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data
{

	/// <summary>
	/// This object represents the properties and methods of a Currency.
	/// </summary>
	public class Currency : BaseClass 
	{
			
		public Currency()
		{
		}
		public Currency(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("CurrencyCode",reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
				if (!isNull("CurrencyName",reader)) currencyName = reader.GetString(reader.GetOrdinal("CurrencyName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			}
		}
		
		#region Public Properties

		
		
		protected string currencyCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of CurrencyCode
		/// </summary>
		public string CurrencyCode
		{
			get {return currencyCode;}
			set {currencyCode = value;}
		}

		protected string currencyName = String.Empty;
		/// <summary>
		/// Gets or sets the value of CurrencyName
		/// </summary>
		public string CurrencyName
		{
			get {return currencyName;}
			set {currencyName = value;}
		}

		protected string description = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
		public string Description
		{
			get {return description;}
			set {description = value;}
		}
		#endregion
		

	}
	
}	
