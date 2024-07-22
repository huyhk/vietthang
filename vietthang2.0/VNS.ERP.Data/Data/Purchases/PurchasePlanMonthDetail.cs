
/************************************************************************
**	ClassName	: 	PurchasePlanMonthDetail
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-11-2008 10:40 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region PurchasePlanMonthDetail
	/// <summary>
	/// This object represents the properties and methods of a PurchasePlanMonthDetail.
	/// </summary>
	public class PurchasePlanMonthDetail : BaseClass 
	{
			
		
		public PurchasePlanMonthDetail()
		{
		}
		
		public PurchasePlanMonthDetail(IDataReader reader)
		{
			this.FromDataReader(reader);
		}

		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				//if (!isNull("PlanID",reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
				if (!isNull("SubjectCode",reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
				if (!isNull("StockCode",reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
				if (!isNull("ItemCode",reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
				if (!isNull("Quantity",reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			//if (!row.IsNull("PlanID")) planID = (Guid)row["PlanID"];
			if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
			if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
			if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
			if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
		}
		
		#region Public Properties

		
		
		private Guid planID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of PlanID
		/// </summary>
		public Guid PlanID
		{
			get {return planID;}
			set {planID = value;}
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

		private string stockCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of StockCode
		/// </summary>
		public string StockCode
		{
			get {return stockCode;}
			set {stockCode = value;}
		}

		private string itemCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of ItemCode
		/// </summary>
		public string ItemCode
		{
			get {return itemCode;}
			set {itemCode = value;}
		}

		private decimal quantity;
		/// <summary>
		/// Gets or sets the value of Quantity
		/// </summary>
		public decimal Quantity
		{
			get {return quantity;}
			set {quantity = value;}
		}

        private string contractNo = String.Empty;
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }
		#endregion
		
		#region Lists
		#endregion
		

	}
	#endregion
}	

