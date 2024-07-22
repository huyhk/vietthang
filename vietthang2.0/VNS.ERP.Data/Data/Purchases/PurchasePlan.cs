
/************************************************************************
**	ClassName	: 	PurchasePlan
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	23-07-2009 02:46 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region PurchasePlan
	/// <summary>
	/// This object represents the properties and methods of a PurchasePlan.
	/// </summary>
	public class PurchasePlan : UserTracking 
	{
			
		
		public PurchasePlan()
		{
		}
		
		public PurchasePlan(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public PurchasePlan(DataRow row)
        //{
        //    this.FromDataRow(row);
        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("PlanID",reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
				if (!isNull("YearNo",reader)) yearNo = reader.GetInt32(reader.GetOrdinal("YearNo"));
				if (!isNull("MonthNo",reader)) monthNo = reader.GetInt32(reader.GetOrdinal("MonthNo"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("PlanID")) planID = (Guid)row["PlanID"];
			if (!row.IsNull("YearNo")) yearNo = (int)row["YearNo"];
			if (!row.IsNull("MonthNo")) monthNo = (int)row["MonthNo"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
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

		private int yearNo = DateTime.Now.Year;
		/// <summary>
		/// Gets or sets the value of YearNo
		/// </summary>
		public int YearNo
		{
			get {return yearNo;}
			set {yearNo = value;}
		}

		private int monthNo = DateTime.Now.Month;
		/// <summary>
		/// Gets or sets the value of MonthNo
		/// </summary>
		public int MonthNo
		{
			get {return monthNo;}
			set {monthNo = value;}
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
		private ListBase<PurchasePlanDetail> listPurchasePlanDetail = new ListBase<PurchasePlanDetail>();
		
		public ListBase<PurchasePlanDetail> ListPurchasePlanDetail
		{
			get {return listPurchasePlanDetail;}
			set {listPurchasePlanDetail= value;}
			
		}	
		
		#endregion
		

	}
	#endregion

    #region PurchasePlanDetail
    /// <summary>
    /// This object represents the properties and methods of a PurchasePlanDetail.
    /// </summary>
    public class PurchasePlanDetail : BaseClass
    {


        public PurchasePlanDetail()
        {
        }

        public PurchasePlanDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        //public PurchasePlanDetail(DataRow row)
        //{
        //    this.FromDataRow(row);
        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PlanID", reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PlanID")) planID = (Guid)row["PlanID"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Quantity")) quantity = (decimal)row["Quantity"];
            if (!row.IsNull("Price")) price = (decimal)row["Price"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
        }

        #region Public Properties



        private Guid planID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of PlanID
        /// </summary>
        public Guid PlanID
        {
            get { return planID; }
            set { planID = value; }
        }

        private string itemCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of ItemCode
        /// </summary>
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        private decimal quantity;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal price;
        /// <summary>
        /// Gets or sets the value of Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string description = String.Empty;
        /// <summary>
        /// Gets or sets the value of Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}	

