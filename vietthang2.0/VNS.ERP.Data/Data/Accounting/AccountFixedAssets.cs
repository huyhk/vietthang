using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a FixedAsset.
	/// </summary>
    public class AccountFixedAssets : BaseClass 
	{
			
		
		public AccountFixedAssets()
		{
		}
		
		public AccountFixedAssets(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("FixedAssetCode",reader)) fixedAssetCode = reader.GetString(reader.GetOrdinal("FixedAssetCode"));
				if (!isNull("FixedAssetName",reader)) fixedAssetName = reader.GetString(reader.GetOrdinal("FixedAssetName"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("OriginalPrice",reader)) originalPrice = reader.GetDecimal(reader.GetOrdinal("OriginalPrice"));
				if (!isNull("MonthUsing",reader)) monthUsing = reader.GetInt32(reader.GetOrdinal("MonthUsing"));
				if (!isNull("AccountCode",reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("DepAccountCode", reader)) depAccountCode = reader.GetString(reader.GetOrdinal("DepAccountCode"));
                if (!isNull("DepSubjectCode", reader)) depSubjectCode = reader.GetString(reader.GetOrdinal("DepSubjectCode"));
                if (!isNull("DepClassificationCode", reader)) depClassificationCode = reader.GetString(reader.GetOrdinal("DepClassificationCode"));
                if (!isNull("NgayCT", reader)) ngayCT = reader.GetDateTime(reader.GetOrdinal("NgayCT"));
                if (!isNull("CountryName", reader)) countryName = reader.GetString(reader.GetOrdinal("CountryName"));
                if (!isNull("SoCT", reader)) soCT = reader.GetString(reader.GetOrdinal("SoCT"));

                if (!isNull("IsSpec", reader)) isSpec = reader.GetBoolean(reader.GetOrdinal("IsSpec"));
			}
		}
		
		#region Public Properties

		
		
		protected string fixedAssetCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of FixedAssetCode
		/// </summary>
		public string FixedAssetCode
		{
			get {return fixedAssetCode;}
			set {fixedAssetCode = value;}
		}

		protected string fixedAssetName = String.Empty;
		/// <summary>
		/// Gets or sets the value of FixedAssetName
		/// </summary>
		public string FixedAssetName
		{
			get {return fixedAssetName;}
			set {fixedAssetName = value;}
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

		protected DateTime startDate=DateTime.Today;
		/// <summary>
		/// Gets or sets the value of StartDate
		/// </summary>
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

		protected decimal originalPrice;
		/// <summary>
		/// Gets or sets the value of OriginalPrice
		/// </summary>
		public decimal OriginalPrice
		{
			get {return originalPrice;}
			set {
                originalPrice = value;
            }
		}

		protected int monthUsing;
		/// <summary>
		/// Gets or sets the value of MonthUsing
		/// </summary>
		public int MonthUsing
		{
			get {return monthUsing;}
            set { monthUsing =value; }
		}
        public int YearUsing
        {
            get { return monthUsing/12; }
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

        protected string depAccountCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of DepAccountCode
        /// </summary>
        public string DepAccountCode
        {
            get { return depAccountCode; }
            set { depAccountCode = value; }
        }

        protected string depSubjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of DepSubjectCode
        /// </summary>
        public string DepSubjectCode
        {
            get { return depSubjectCode; }
            set { depSubjectCode = value; }
        }

        protected string depClassificationCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string DepClassificationCode
        {
            get { return depClassificationCode; }
            set { depClassificationCode = value; }
        }

        protected DateTime ngayCT = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of StartDate
        /// </summary>
        public DateTime NgayCT
        {
            get { return ngayCT; }
            set { ngayCT = value; }
        }

        protected string countryName = String.Empty;
        /// <summary>
        /// Gets or sets the value of CountryName
        /// </summary>
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        protected string soCT = String.Empty;
        /// <summary>
        /// Gets or sets the value of SoCT
        /// </summary>
        public string SoCT
        {
            get { return soCT; }
            set { soCT = value; }
        }

        private Boolean isSpec = false;

        public Boolean IsSpec
        {
            get { return isSpec; }
            set { isSpec = value; }
        }
		#endregion
		

	}

}	
