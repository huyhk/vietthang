using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanMonth : UserTracking2
    {
        public ManufacturePlanMonth() { }
        public ManufacturePlanMonth(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ManufacturePlanMonthID", reader)) fManufacturePlanMonthID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanMonthID"));
            if (!isNull("StockCode", reader)) fStockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("YearNo", reader)) fYearNo = reader.GetInt32(reader.GetOrdinal("YearNo"));
            if (!isNull("MonthNo", reader)) fMonthNo = reader.GetInt32(reader.GetOrdinal("MonthNo"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
        }
        private Guid fManufacturePlanMonthID;
        public Guid ManufacturePlanMonthID
        {
            get { return fManufacturePlanMonthID; }
            set { fManufacturePlanMonthID = value; }
        }
        private string fStockCode;
        public string StockCode
        {
            get { return fStockCode; }
            set { fStockCode = value; }
        }
        private Int32 fYearNo = DateTime.Now.Year;
        public Int32 YearNo
        {
            get { return fYearNo; }
            set { fYearNo = value; }
        }
        private Int32 fMonthNo=DateTime.Now.Month;
        public Int32 MonthNo
        {
            get { return fMonthNo; }
            set { fMonthNo = value; }
        }
        private string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
        private ListBase<ManufacturePlanMonthDetail> details;
        public ListBase<ManufacturePlanMonthDetail> Detail
        {
            get { return details; }
            set { details = value; }
        }
    }
}
