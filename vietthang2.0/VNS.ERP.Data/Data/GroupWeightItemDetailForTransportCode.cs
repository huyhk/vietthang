using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
    public class GroupWeightItemDetailForTransportCode:BaseClass
    {
        public GroupWeightItemDetailForTransportCode() { }
        protected string _StockTransportCode;
        public string StockTransportCode
        {
            get { return _StockTransportCode; }
            set { _StockTransportCode = value; }
        }
        protected int _Count;
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        protected decimal _SkinTransport;
        public decimal SkinTransport
        {
            get { return _SkinTransport; }
            set { _SkinTransport = value; }
        }
        protected decimal _TotalWeight;
        public decimal TotalWeight
        {
            get { return _TotalWeight; }
            set { _TotalWeight = value; }
        }
    }
}
