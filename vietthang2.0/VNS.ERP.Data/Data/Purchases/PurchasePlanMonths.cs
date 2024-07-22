
/************************************************************************
**	ClassName	: 	PurchasePlanMonths
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-11-2008 10:39 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data
{
	#region PurchasePlanMonths
	/// <summary>
	/// This object represents the properties and methods of a PurchasePlanMonths.
	/// </summary>
	public class PurchasePlanMonths : UserTracking2 
	{
			
		
		public PurchasePlanMonths()
		{
		}
		
		public PurchasePlanMonths(IDataReader reader)
		{
			this.FromDataReader(reader);
		}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PlanID", reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
                if (!isNull("YearNo", reader)) yearNo = reader.GetInt32(reader.GetOrdinal("YearNo"));
                if (!isNull("MonthNo", reader)) monthNo = reader.GetInt32(reader.GetOrdinal("MonthNo"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
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
        private ListBase<PurchasePlanMonthDetail> listPurchasePlanMonthDetail = new ListBase<PurchasePlanMonthDetail>();

        public ListBase<PurchasePlanMonthDetail> ListPurchasePlanMonthDetail
		{
            get { return listPurchasePlanMonthDetail; }
            set { listPurchasePlanMonthDetail = value; }
			
		}	
		
		#endregion
		

	}
	#endregion
}	

