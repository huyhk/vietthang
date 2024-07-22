using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanMonthDetail : BaseClass
    {
        public ManufacturePlanMonthDetail() { }
        public ManufacturePlanMonthDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ManufacturePlanMonthID", reader)) fManufacturePlanMonthID = reader.GetGuid(reader.GetOrdinal("ManufacturePlanMonthID"));
            if (!isNull("ItemCode", reader)) fItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("FormulaCode", reader)) fFormulaCode = reader.GetString(reader.GetOrdinal("FormulaCode"));
            if (!isNull("Quantity", reader)) fQuantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
        }
        private Guid fManufacturePlanMonthID;
        public Guid ManufacturePlanMonthID
        {
            get { return fManufacturePlanMonthID; }
            set { fManufacturePlanMonthID = value; }
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
        private decimal fQuantity;
        public decimal Quantity
        {
            get { return fQuantity; }
            set { fQuantity = value; }
        }
        private string fDescription="";
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
    }
}
