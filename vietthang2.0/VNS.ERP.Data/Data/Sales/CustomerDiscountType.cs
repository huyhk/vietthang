using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscountType : UserTracking2
    {
        public CustomerDiscountType()
        { }

        public CustomerDiscountType(DbDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("DiscountTypeCode", reader)) discountTypeCode = reader.GetString(reader.GetOrdinal("DiscountTypeCode"));
                if (!isNull("DiscountTypeName", reader)) discountTypeName = reader.GetString(reader.GetOrdinal("DiscountTypeName"));
                if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            }
        }
      
        #region Public Properties
        protected string discountTypeCode = string.Empty;
        public string DiscountTypeCode
        {
            set { discountTypeCode = value; }
            get { return discountTypeCode; }
        }
        protected string discountTypeName = string.Empty;
        public string DiscountTypeName
        {
            set { discountTypeName = value; }
            get { return discountTypeName; }
        }
        protected string description = string.Empty;
        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        #endregion
    }
}
