using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanWeek : UserTracking2
    {
        public ManufacturePlanWeek() { }
        public ManufacturePlanWeek(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ManufacturePlanWeekID", reader)) fManufacturePlanWeekID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanWeekID"));
            if (!isNull("StockCode", reader)) fStockCode = reader.GetString(reader.GetOrdinal("StockCode"));
            if (!isNull("YearNo", reader)) fYearNo = reader.GetInt32(reader.GetOrdinal("YearNo"));
            if (!isNull("WeekNo", reader)) fWeekNo = reader.GetInt32(reader.GetOrdinal("WeekNo"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
        }
        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ManufacturePlanWeekID")) fManufacturePlanWeekID = (Guid)row["ManufacturePlanWeekID"];
            if (!row.IsNull("StockCode")) fStockCode = (string)row["StockCode"];
            if (!row.IsNull("YearNo")) fYearNo = (int)row["YearNo"];
            if (!row.IsNull("WeekNo")) fWeekNo = (int)row["WeekNo"];
            if (!row.IsNull("Description")) fDescription = (string)row["Description"];
        }
        private Guid fManufacturePlanWeekID;
        public Guid ManufacturePlanWeekID
        {
            get { return fManufacturePlanWeekID; }
            set { fManufacturePlanWeekID = value; }
        }
        private string fStockCode;
        public string StockCode
        {
            get { return fStockCode; }
            set { fStockCode = value; }
        }
        private Int32 fYearNo=DateTime.Now.Year;
        public Int32 YearNo
        {
            get { return fYearNo; }
            set { fYearNo = value; }
        }
        private Int32 fWeekNo = VNS.Utils.Week.FromDate(Contexts.WorkingDate).WeekNumber;
        public Int32 WeekNo
        {
            get { return fWeekNo; }
            set { fWeekNo = value; }
        }
        private string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
        private ListBase<ManufacturePlanWeekDetail> details = new ListBase<ManufacturePlanWeekDetail>();
        public ListBase<ManufacturePlanWeekDetail> Detail
        {
            get { return details; }
            set { details = value; }
        }

        public DateTime StartDate
        {
            get { return Week.FromWeekNumber(fWeekNo, fYearNo).StartDate; }
        }

        public DateTime EndDate
        {
            get { return Week.FromWeekNumber(fWeekNo, fYearNo).EndDate; }
        }

    }
}
