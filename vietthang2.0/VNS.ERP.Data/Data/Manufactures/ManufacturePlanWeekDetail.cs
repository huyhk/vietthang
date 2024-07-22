using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Utils;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanWeekDetail : BaseClass
    {
        public ManufacturePlanWeekDetail() { }
        public ManufacturePlanWeekDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ManufacturePlanWeekID", reader)) fManufacturePlanWeekID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanWeekID"));
            if (!isNull("ItemCode", reader)) fItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("FormulaCode", reader)) fFormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Day1", reader)) fDay1 = reader.GetDecimal(reader.GetOrdinal("Day1"));
            if (!isNull("Day2", reader)) fDay2 = reader.GetDecimal(reader.GetOrdinal("Day2"));
            if (!isNull("Day3", reader)) fDay3 = reader.GetDecimal(reader.GetOrdinal("Day3"));
            if (!isNull("Day4", reader)) fDay4 = reader.GetDecimal(reader.GetOrdinal("Day4"));
            if (!isNull("Day5", reader)) fDay5 = reader.GetDecimal(reader.GetOrdinal("Day5"));
            if (!isNull("Day6", reader)) fDay6 = reader.GetDecimal(reader.GetOrdinal("Day6"));
            if (!isNull("Day7", reader)) fDay7 = reader.GetDecimal(reader.GetOrdinal("Day7"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("ManufacturePlanWeekID")) fManufacturePlanWeekID = (Guid)row["ManufacturePlanWeekID"];
            if (!row.IsNull("ItemCode")) fItemCode = (string)row["ItemCode"];
            if (!row.IsNull("FormulaCode")) fFormulaCode = (string)row["FormulaCode"];
            if (!row.IsNull("Day1")) fDay1 = (decimal)row["Day1"];
            if (!row.IsNull("Day2")) fDay2 = (decimal)row["Day2"];
            if (!row.IsNull("Day3")) fDay3 = (decimal)row["Day3"];
            if (!row.IsNull("Day4")) fDay4 = (decimal)row["Day4"];
            if (!row.IsNull("Day5")) fDay5 = (decimal)row["Day5"];
            if (!row.IsNull("Day6")) fDay6 = (decimal)row["Day6"];
            if (!row.IsNull("Day7")) fDay7 = (decimal)row["Day7"];
            if (!row.IsNull("Description")) fDescription = (string)row["Description"];
        }
        private Guid fManufacturePlanWeekID;
        public Guid ManufacturePlanWeekID
        {
            get { return fManufacturePlanWeekID; }
            set { fManufacturePlanWeekID = value; }
        }
        private string fItemCode;
        public string ItemCode
        {
            get { return fItemCode; }
            set { fItemCode = value; }
        }
        private string fFormulaCode;
        public string FormulaCode
        {
            get { return fFormulaCode; }
            set { fFormulaCode = value; }
        }
        private decimal fDay1;
        public decimal Day1
        {
            get { return fDay1; }
            set { fDay1 = value; }
        }
        private decimal fDay2;
        public decimal Day2
        {
            get { return fDay2; }
            set { fDay2 = value; }
        }
        private decimal fDay3;
        public decimal Day3
        {
            get { return fDay3; }
            set { fDay3 = value; }
        }
        private decimal fDay4;
        public decimal Day4
        {
            get { return fDay4; }
            set { fDay4 = value; }
        }
        private decimal fDay5;
        public decimal Day5
        {
            get { return fDay5; }
            set { fDay5 = value; }
        }
        private decimal fDay6;
        public decimal Day6
        {
            get { return fDay6; }
            set { fDay6 = value; }
        }
        private decimal fDay7;
        public decimal Day7
        {
            get { return fDay7; }
            set { fDay7 = value; }
        }
        private string fDescription="";
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
    }
}
