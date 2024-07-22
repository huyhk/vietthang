using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class TransportRoute :  UserTracking2
    {
        public TransportRoute() { }
        public TransportRoute(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("RouteCode", reader)) routeCode = reader.GetString(reader.GetOrdinal("RouteCode"));
            if (!isNull("RouteName", reader)) routeName = reader.GetString(reader.GetOrdinal("RouteName"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("IsTrungchuyen", reader)) isTrungchuyen = reader.GetBoolean(reader.GetOrdinal("IsTrungchuyen"));
            if (!isNull("StockIn", reader)) stockIn = reader.GetString(reader.GetOrdinal("StockIn"));
            if (!isNull("StockOut", reader)) stockOut = reader.GetString(reader.GetOrdinal("StockOut"));
        }
        private string routeCode = string.Empty;
        public string RouteCode
        {
            get { return routeCode; }
            set { routeCode  = value; }
        }
        private string routeName = string.Empty;
        public string RouteName
        {
            get { return routeName; }
            set { routeName = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private bool isTrungchuyen = false;
        /// <summary>
        /// Gets or sets the value of IsTrungchuyen
        /// </summary>
        public bool IsTrungchuyen
        {
            get { return isTrungchuyen; }
            set { isTrungchuyen = value; }
        }

        private string stockIn = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockIn
        /// </summary>
        public string StockIn
        {
            get { return stockIn; }
            set { stockIn = value; }
        }

        private string stockOut = String.Empty;
        /// <summary>
        /// Gets or sets the value of StockOut
        /// </summary>
        public string StockOut
        {
            get { return stockOut; }
            set { stockOut = value; }
        }
    }
}
