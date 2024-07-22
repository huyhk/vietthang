using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscountList : UserTracking2
    {
        public CustomerDiscountList()
        { }
        public CustomerDiscountList(IDataReader Reader)
        {
            this.FromDataReader(Reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("DiscountID", reader)) discountID = reader.GetGuid(reader.GetOrdinal("discountID"));
                if (!isNull("DiscountName", reader)) discountName = reader.GetString(reader.GetOrdinal("DiscountName"));
                if (!isNull("DiscountType", reader)) discountType = reader.GetString(reader.GetOrdinal("DiscountType"));
                if (!isNull("InActive", reader)) inActive = reader.GetBoolean(reader.GetOrdinal("InActive"));
            }
            base.FromDataReader(reader);
        }
        #region Public Properties
        protected Guid discountID;
        public Guid DiscountID
        {
            get { return discountID; }
            set { discountID = value; }
        }
        protected string discountName;
        public string DiscountName
        {
            get { return discountName; }
            set { discountName = value; }
        }
        protected string discountType;
        public string DiscountType
        {
            get { return discountType; }
            set { discountType = value; }
        }
        private Boolean inActive;
        public Boolean InActive
        {
            get { return inActive; }
            set { inActive = value; }
        }
        #endregion
    }
}
