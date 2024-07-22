using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlan : UserTracking2
    {
        public ManufacturePlan()
        { }

        public ManufacturePlan(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("ManufacturePlanID", reader)) _manufacturePlanID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanID"));
                if (!CheckNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!CheckNull("PlanDate", reader)) _planDate = reader.GetDateTime(reader.GetOrdinal("PlanDate"));
                if (!CheckNull("PlanNo", reader)) _planNo = reader.GetString(reader.GetOrdinal("PlanNo"));
                if (!CheckNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!CheckNull("IsFinished", reader)) _isFinished = reader.GetBoolean(reader.GetOrdinal("IsFinished"));
                if (!CheckNull("TyleHaohut", reader)) tyleHaohut = reader.GetDecimal(reader.GetOrdinal("TyleHaohut"));
            }
            base.LoadFromReader(reader);
        }
        #region Public Properties

        protected Guid _manufacturePlanID;
        public Guid ManufacturePlanID
        {
            set { _manufacturePlanID = value; }
            get { return _manufacturePlanID; }
        }

        protected string _stockCode = String.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }

        protected DateTime _planDate = Contexts.WorkingDate;
        public DateTime PlanDate
        {
            set { _planDate = value; }
            get { return _planDate; }
        }

        protected string _planNo = String.Empty;
        public string PlanNo
        {
            set { _planNo = value; }
            get { return _planNo; }
        }

        protected string _description = String.Empty;
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }

        protected bool _isFinished ;
        public bool IsFinished
        {
            set { _isFinished = value; }
            get { return _isFinished; }
        }

        protected decimal tyleHaohut;
        public decimal TyleHaohut
        {
            set { tyleHaohut = value; }
            get { return tyleHaohut; }
        }

        public ListBase<ManufacturePlanDetail> details = new ListBase<ManufacturePlanDetail>();
        public ListBase<ManufacturePlanDetail> Details
        {
            set { details = value; }
            get { return details; }
        }
        #endregion
    }
}
