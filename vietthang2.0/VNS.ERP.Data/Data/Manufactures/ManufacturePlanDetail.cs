using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanDetail : UserTracking2
    {
        public ManufacturePlanDetail()
        { }

        public ManufacturePlanDetail(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("ManufacturePlanID", reader)) _manufacturePlanID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanID"));
                if (!CheckNull("FormulaCode", reader)) _formulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
                if (!CheckNull("ItemCode", reader)) _itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                if (!CheckNull("DetailDate", reader)) _detailDate = reader.GetDateTime(reader.GetOrdinal("DetailDate"));
                if (!CheckNull("Shift", reader)) _shift = reader.GetByte(reader.GetOrdinal("Shift"));
                if (!CheckNull("LinesxNo", reader)) _linesxNo = reader.GetString(reader.GetOrdinal("LinesxNo"));
                if (!CheckNull("PlanWeight", reader)) _planWeight = reader.GetDecimal(reader.GetOrdinal("PlanWeight"));
                if (!CheckNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!CheckNull("PlanWrapping", reader)) planWrapping = reader.GetDecimal(reader.GetOrdinal("PlanWrapping"));
              
            }
           
        }
        #region Public Properties

        protected Guid _manufacturePlanID;
        public Guid ManufacturePlanID
        {
            set { _manufacturePlanID = value; }
            get { return _manufacturePlanID; }
        }

        protected string _formulaCode = String.Empty;
        public string FormulaCode
        {
            set { _formulaCode = value; }
            get { return _formulaCode; }
        }
        protected string _itemCode = String.Empty;
        public string ItemCode
        {
            set { _itemCode = value; }
            get { return _itemCode; }
        }

        protected DateTime _detailDate=DateTime.Today;
        public DateTime DetailDate
        {
            set { _detailDate = value; }
            get { return _detailDate; }
        }
        protected int _shift=1;
        public int Shift
        {
            set { _shift = value; }
            get { return _shift; }
        }
        protected string _linesxNo = string.Empty;
        public string LinesxNo
        {
            set { _linesxNo = value; }
            get { return _linesxNo; }
        }


        protected decimal _planWeight ;
        public decimal PlanWeight
        {
            set { _planWeight = value; }
            get { return _planWeight; }
        }
        protected decimal planWrapping;
        public decimal PlanWrapping
        {
            set { planWrapping = value; }
            get { return planWrapping; }
        }

        protected string _description = String.Empty;
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
      
        #endregion
    }
}

