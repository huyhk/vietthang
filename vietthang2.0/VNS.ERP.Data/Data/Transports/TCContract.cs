
/************************************************************************
**	ClassName	: 	TCContract
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	14-12-2009 02:46 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data.Transports
{
	#region TCContract
	/// <summary>
	/// This object represents the properties and methods of a TCContract.
	/// </summary>
	public class TCContract : UserTracking2 
	{
			
		
		public TCContract()
		{
		}
		
		
		
		public TCContract(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
        public TCContract(DataRow row)
        {
            this.FromDataRow(row);
        }
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("ContractID",reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
				if (!isNull("ContractNo",reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
				if (!isNull("ContractDate",reader)) contractDate = reader.GetDateTime(reader.GetOrdinal("ContractDate"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
				if (!isNull("StartDate",reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
				if (!isNull("EndDate",reader)) endDate = reader.GetDateTime(reader.GetOrdinal("EndDate"));
				if (!isNull("TaxRate",reader)) taxRate = reader.GetDecimal(reader.GetOrdinal("TaxRate"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			}
		}
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("ContractDate")) contractDate = (DateTime)row["ContractDate"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("EndDate")) endDate = (DateTime)row["EndDate"];
            if (!row.IsNull("TaxRate")) taxRate = (decimal)row["TaxRate"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

		#region Public Properties

		private Guid contractID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of ContractID
		/// </summary>
		public Guid ContractID
		{
			get {return contractID;}
			set {contractID = value;}
		}

		private string contractNo = String.Empty;
		/// <summary>
		/// Gets or sets the value of ContractNo
		/// </summary>
		public string ContractNo
		{
			get {return contractNo;}
			set {contractNo = value;}
		}

        private DateTime contractDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of ContractDate
		/// </summary>
		public DateTime ContractDate
		{
			get {return contractDate;}
			set {contractDate = value;}
		}

		private string subjectCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of SubjectCode
		/// </summary>
		public string SubjectCode
		{
			get {return subjectCode;}
			set {subjectCode = value;}
		}

        private DateTime startDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of StartDate
		/// </summary>
		public DateTime StartDate
		{
			get {return startDate;}
			set {startDate = value;}
		}

        private DateTime endDate = Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of EndDate
		/// </summary>
		public DateTime EndDate
		{
			get {return endDate;}
			set {endDate = value;}
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

		#endregion
		
		#region Lists
        private ListBase<TCContractPrice> listTCContractPrice = new ListBase<TCContractPrice>();

        public ListBase<TCContractPrice> ListTCContractPrice
		{
            get { return listTCContractPrice; }
            set { listTCContractPrice = value; }
			
		}	
		
		#endregion

        private DataSet dSTCResult;
        public DataSet DSTCResult
        {
            get { return dSTCResult; }
            set
            {
                dSTCResult = value;
                ResultTCAmount = 0;
                foreach (DataRow row in dSTCResult.Tables[0].Rows)
                    ResultTCAmount += (decimal)row["TCAmount"];
            }
        }
        //public decimal VCTaxRate = 0.05M;
        public decimal ResultTCAmount = 0;
        public decimal ResultTCTaxAmount
        {
            get { return decimal.Round(ResultTCAmount * TaxRate, 0); }
        }

        public decimal ResultTotalAmount
        {
            get { return ResultTCAmount + ResultTCTaxAmount; }
        }

        public bool ResultAll = true;
        public DateTime ResultFromDate = DateTime.Today;
        public DateTime ResultToDate = DateTime.Today;

	}
	#endregion


    #region TCContractPrices
    /// <summary>
    /// This object represents the properties and methods of a TransportContractPriceDetail.
    /// </summary>
    public class TCContractPrice : ObjectBase
    {

        public TCContractPrice()
        {
        }

        public TCContractPrice(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public TCContractPrice(DataRow row)
        {
            this.FromDataRow(row);
        }

        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("ContractID", reader)) contractID = reader.GetGuid(reader.GetOrdinal("ContractID"));
                if (!isNull("TCRouteCode", reader)) tCRouteCode = reader.GetString(reader.GetOrdinal("TCRouteCode"));
                if (!isNull("StartDate", reader)) startDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
                if (!isNull("ItemType", reader)) itemType = reader.GetString(reader.GetOrdinal("ItemType"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);
            if (!row.IsNull("ContractID")) contractID = (Guid)row["ContractID"];
            if (!row.IsNull("TCRouteCode")) tCRouteCode = (string)row["TCRouteCode"];
            if (!row.IsNull("StartDate")) startDate = (DateTime)row["StartDate"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("ItemType")) itemType = (string)row["ItemType"];
        }

        #region Public Properties

        private Guid contractID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of ContractID
        /// </summary>
        public Guid ContractID
        {
            get { return contractID; }
            set { contractID = value; }
        }

        private string tCRouteCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of TranportItemType
        /// </summary>
        public string TCRouteCode
        {
            get { return tCRouteCode; }
            set { tCRouteCode = value; }
        }

        private DateTime startDate = Contexts.WorkingDate;
        /// <summary>
        /// Gets or sets the value of StartDate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private decimal price;
        /// <summary>
        /// Gets or sets the value of Haohut
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string itemType = "NL";
        /// <summary>
        /// Gets or sets the value of ItemType
        /// </summary>
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        #endregion

    }
    #endregion
}	

