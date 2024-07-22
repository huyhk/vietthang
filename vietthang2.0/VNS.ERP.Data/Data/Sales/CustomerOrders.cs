using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.Sales
{
    public class CustomerOrders : UserTracking2
    {
        public CustomerOrders()
        { }

        public CustomerOrders(DbDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        public override void LoadFromReader(DbDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                if (!CheckNull("CustomerOrderID", reader)) _customerOrderID = reader.GetGuid(reader.GetOrdinal("CustomerOrderID"));
                if (!CheckNull("CustomerCode", reader)) _customerCode = reader.GetString(reader.GetOrdinal("CustomerCode"));
                if (!CheckNull("StockCode", reader)) _stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
                if (!CheckNull("CustomerOrderNo", reader)) _customerOrderNo = reader.GetString(reader.GetOrdinal("CustomerOrderNo"));
                if (!CheckNull("CustomerOrderDate", reader)) _customerOrderDate = reader.GetDateTime(reader.GetOrdinal("CustomerOrderDate"));
                if (!CheckNull("Description", reader)) _description = reader.GetString(reader.GetOrdinal("Description"));
                if (!CheckNull("IsFinished", reader)) _isFinished = reader.GetBoolean(reader.GetOrdinal("IsFinished"));

            }
            base.LoadFromReader(reader);
        }
        #region Public Properties

        protected Guid _customerOrderID;
        public Guid CustomerOrderID
        {
            set { _customerOrderID = value; }
            get { return _customerOrderID; }
        }

        protected string _stockCode = String.Empty;
        public string StockCode
        {
            set { _stockCode = value; }
            get { return _stockCode; }
        }
        protected string _customerOrderNo = String.Empty;
        public string CustomerOrderNo
        {
            set { _customerOrderNo = value; }
            get { return _customerOrderNo; }
        }

        protected DateTime _customerOrderDate = Contexts.WorkingDate;
        public DateTime CustomerOrderDate
        {
            set { _customerOrderDate = value; }
            get { return _customerOrderDate; }
        }

        protected string _customerCode = String.Empty;
        public string CustomerCode
        {
            set { _customerCode = value; }
            get { return _customerCode; }
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


        protected ListBase<CustomerOrderDetails> details = new ListBase<CustomerOrderDetails>();
        public ListBase<CustomerOrderDetails> Details
        {
            set { details = value; }
            get { return details; }
        }
        public DataSet DetailIsFinished ;


        #endregion
    }
}
