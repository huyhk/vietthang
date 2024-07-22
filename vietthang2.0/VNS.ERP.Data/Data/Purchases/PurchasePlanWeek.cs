
/************************************************************************
**	ClassName	: 	PurchasePlanWeek
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-12-2008 04:01 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Utils;
namespace VNS.ERP.Data
{
	#region PurchasePlanWeek
	/// <summary>
	/// This object represents the properties and methods of a PurchasePlanWeek.
	/// </summary>
	public class PurchasePlanWeek : UserTracking2 
	{
			
		
		public PurchasePlanWeek()
		{
		}
		
		public PurchasePlanWeek(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("PlanID",reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
				if (!isNull("YearNo",reader)) yearNo = reader.GetInt32(reader.GetOrdinal("YearNo"));
				if (!isNull("WeekNo",reader)) weekNo = reader.GetInt32(reader.GetOrdinal("WeekNo"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("PlanID")) planID = (Guid)row["PlanID"];
			if (!row.IsNull("YearNo")) yearNo = (int)row["YearNo"];
			if (!row.IsNull("WeekNo")) weekNo = (int)row["WeekNo"];
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
			set 
            {
                yearNo = value;
            }
		}

        private int weekNo = Week.FromDate(DateTime.Now).WeekNumber;
		/// <summary>
		/// Gets or sets the value of WeekNo
		/// </summary>
		public int WeekNo
		{
			get {return weekNo;}
			set 
            {
                weekNo = value;
            }
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

        public DateTime StartDate
        {
            get { return Week.FromWeekNumber(weekNo, yearNo).StartDate; }
        }

        public DateTime EndDate
        {
            get { return Week.FromWeekNumber(weekNo, yearNo).EndDate; }
        }

		#endregion
		
		#region Lists
        private ListBase<PurchasePlanWeekDetail> listPurchasePlanWeekDetail = new ListBase<PurchasePlanWeekDetail>();

        public ListBase<PurchasePlanWeekDetail> ListPurchasePlanWeekDetail
		{
            get { return listPurchasePlanWeekDetail; }
            set { listPurchasePlanWeekDetail = value; }
			
		}	
		
		#endregion
		

	}
	#endregion
    #region PurchasePlanWeekDetail
    /// <summary>
    /// This object represents the properties and methods of a PurchasePlanWeekDetail.
    /// </summary>
    public class PurchasePlanWeekDetail : BaseClass
    {


        public PurchasePlanWeekDetail()
        {
        }

        public PurchasePlanWeekDetail(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("PlanID", reader)) planID = reader.GetGuid(reader.GetOrdinal("PlanID"));
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("ContractNo", reader)) contractNo = reader.GetString(reader.GetOrdinal("ContractNo"));
                if (!isNull("StockCode", reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!isNull("Day1", reader)) day1 = reader.GetDecimal(reader.GetOrdinal("Day1"));
                if (!isNull("Day2", reader)) day2 = reader.GetDecimal(reader.GetOrdinal("Day2"));
                if (!isNull("Day3", reader)) day3 = reader.GetDecimal(reader.GetOrdinal("Day3"));
                if (!isNull("Day4", reader)) day4 = reader.GetDecimal(reader.GetOrdinal("Day4"));
                if (!isNull("Day5", reader)) day5 = reader.GetDecimal(reader.GetOrdinal("Day5"));
                if (!isNull("Day6", reader)) day6 = reader.GetDecimal(reader.GetOrdinal("Day6"));
                if (!isNull("Day7", reader)) day7 = reader.GetDecimal(reader.GetOrdinal("Day7"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("PlanID")) planID = (Guid)row["PlanID"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("ContractNo")) contractNo = (string)row["ContractNo"];
            if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
            if (!row.IsNull("ItemCode")) itemCode = (string)row["ItemCode"];
            if (!row.IsNull("Day1")) day1 = (decimal)row["Day1"];
            if (!row.IsNull("Day2")) day2 = (decimal)row["Day2"];
            if (!row.IsNull("Day3")) day3 = (decimal)row["Day3"];
            if (!row.IsNull("Day4")) day4 = (decimal)row["Day4"];
            if (!row.IsNull("Day5")) day5 = (decimal)row["Day5"];
            if (!row.IsNull("Day6")) day6 = (decimal)row["Day6"];
            if (!row.IsNull("Day7")) day7 = (decimal)row["Day7"];
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

        private string subjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        private string contractNo = String.Empty;
        /// <summary>
        /// Gets or sets the value of ContractNo
        /// </summary>
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }

        private string stockCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockCode
        /// </summary>
        public string StockCode
        {
            get { return stockCode; }
            set { stockCode = value; }
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

        private decimal day1;
        /// <summary>
        /// Gets or sets the value of Day1
        /// </summary>
        public decimal Day1
        {
            get { return day1; }
            set { day1 = value; }
        }

        private decimal day2;
        /// <summary>
        /// Gets or sets the value of Day2
        /// </summary>
        public decimal Day2
        {
            get { return day2; }
            set { day2 = value; }
        }

        private decimal day3;
        /// <summary>
        /// Gets or sets the value of Day3
        /// </summary>
        public decimal Day3
        {
            get { return day3; }
            set { day3 = value; }
        }

        private decimal day4;
        /// <summary>
        /// Gets or sets the value of Day4
        /// </summary>
        public decimal Day4
        {
            get { return day4; }
            set { day4 = value; }
        }

        private decimal day5;
        /// <summary>
        /// Gets or sets the value of Day5
        /// </summary>
        public decimal Day5
        {
            get { return day5; }
            set { day5 = value; }
        }

        private decimal day6;
        /// <summary>
        /// Gets or sets the value of Day6
        /// </summary>
        public decimal Day6
        {
            get { return day6; }
            set { day6 = value; }
        }

        private decimal day7;
        /// <summary>
        /// Gets or sets the value of Day7
        /// </summary>
        public decimal Day7
        {
            get { return day7; }
            set { day7 = value; }
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

        public decimal Sum
        {
            get { return day1 + day2 + day3 + day4 + day5 + day6 + day7; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}	

