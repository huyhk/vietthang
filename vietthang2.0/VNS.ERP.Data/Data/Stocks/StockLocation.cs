using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class StockLocation:UserTracking2
    {
        public StockLocation() { }
        public StockLocation(IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("StockLocationCode", reader)) _StockLocationCode = reader.GetString(reader.GetOrdinal("StockLocationCode"));
                if (!isNull("StockCode", reader)) _StockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            base.FromDataReader(reader);
        }

        #region Public Properties
        protected string _StockLocationCode;
        public string StockLocationCode
        {
            get { return _StockLocationCode; }
            set { _StockLocationCode = value; }
        }
        protected string _StockCode="";
        public string StockCode
        {
            get { return _StockCode; }
            set { _StockCode = value; }
        }
        protected string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        #endregion
    }
}
