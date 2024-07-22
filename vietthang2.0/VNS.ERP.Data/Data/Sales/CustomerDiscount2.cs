using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscount2 : UserTracking2
    {
        public CustomerDiscount2() { }
        public CustomerDiscount2(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("CustomerCode", reader)) fCustomerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
            if (!isNull("DiscountTypeCode", reader)) fDiscountTypeCode = reader.GetString(reader.GetOrdinal("DiscountTypeCode"));
            if (!isNull("StartDate", reader)) fStartDate = reader.GetDateTime(reader.GetOrdinal("StartDate"));
            if (!isNull("DiscountPercent", reader)) fDiscountPercent = reader.GetDecimal(reader.GetOrdinal("DiscountPercent"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string fCustomerCode;
        public string CustomerCode
        {
            get { return fCustomerCode; }
            set { fCustomerCode = value; }
        }
        private string fDiscountTypeCode;
        public string DiscountTypeCode
        {
            get { return fDiscountTypeCode; }
            set { fDiscountTypeCode = value; }
        }
        private DateTime fStartDate = Contexts.WorkingDate;
        public DateTime StartDate
        {
            get { return fStartDate; }
            set { fStartDate = value; }
        }
        private decimal fDiscountPercent;
        public decimal DiscountPercent
        {
            get { return fDiscountPercent; }
            set { fDiscountPercent = value; }
        }
        private string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
    }
}
