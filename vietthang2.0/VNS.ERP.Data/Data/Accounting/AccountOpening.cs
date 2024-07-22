using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a AccountOpening.
	/// </summary>
	public class AccountOpening : BaseClass 
	{
			
		
		public AccountOpening()
		{
		}
		
		
		
		public AccountOpening(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
				if (!isNull("AccountCode",reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
				if (!isNull("OpeningAmount",reader)) openingAmount = reader.GetDecimal(reader.GetOrdinal("OpeningAmount"));
                if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
                if (!isNull("OpeningAmountNT", reader)) OpeningAmountNT = reader.GetDecimal(reader.GetOrdinal("OpeningAmountNT"));
			}
		}
		
		#region Public Properties

		
		
		protected string periodCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of PeriodCode
		/// </summary>
		public string PeriodCode
		{
			get {return periodCode;}
			set {periodCode = value;}
		}

		protected string accountCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of AccountCode
		/// </summary>
		public string AccountCode
		{
			get {return accountCode;}
			set {accountCode = value;}
		}

		protected string subjectCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of SubjectCode
		/// </summary>
		public string SubjectCode
		{
			get {return subjectCode;}
			set {subjectCode = value;}
		}

		protected decimal openingAmount;
		/// <summary>
		/// Gets or sets the value of OpeningAmount
		/// </summary>
		public decimal OpeningAmount
		{
			get {return openingAmount;}
			set {openingAmount = value;}
		}
        protected decimal openingAmountNT;
        /// <summary>
        /// Gets or sets the value of OpeningAmountNT
        /// </summary>
        public decimal OpeningAmountNT
        {
            get { return openingAmountNT; }
            set { openingAmountNT = value; }
        }
        protected string currencyCode=string.Empty;
        /// <summary>
        /// Gets or sets the value of CurrencyCode
        /// </summary>
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        public decimal DebitOpeningAmount
        {
            get 
            {
                if (this.OpeningAmount > 0) return this.OpeningAmount;
                else return 0;
            }
            set
            {
                this.OpeningAmount = value;
            }
        }
        public decimal CreditOpeningAmount
        {
            get 
            {
                if (this.OpeningAmount < 0) return -this.OpeningAmount;
                else return 0;
            }
            set
            {
                this.OpeningAmount = -value;
            }
        }
        public decimal DebitOpeningAmountNT
        {
            get
            {
                if (this.OpeningAmountNT > 0) return this.OpeningAmountNT;
                else return 0;
            }
            set
            {
                this.OpeningAmountNT = value;
            }
        }
        public decimal CreditOpeningAmountNT
        {
            get
            {
                if (this.OpeningAmountNT < 0) return -this.OpeningAmountNT;
                else return 0;
            }
            set
            {
                this.OpeningAmountNT = -value;
            }
        }
		#endregion
		

	}

}	
