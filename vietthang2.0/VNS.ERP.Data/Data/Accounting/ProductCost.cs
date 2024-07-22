using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{
    public class ProductCost : BaseClass
    {
        public ProductCost()
        {
        }
        protected string periodCode = String.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set { periodCode = value; }
        }

        protected string productCode = String.Empty;
        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }
        protected string wrappingCode = "40";
        /// <summary>
        /// Gets or sets the value of WrappingCode
        /// </summary>
        public string WrappingCode
        {
            get { return wrappingCode; }
            set { wrappingCode = value; }
        }

        protected decimal totalCostAmount;
        public decimal TotalCostAmount
        {
            get { return totalCostAmount; }
            set { totalCostAmount = value; }
        }

        protected ListBase<ProductCostFormula> details;
        public ListBase<ProductCostFormula> Details
        {
            get { return details; }
            set { details = value; }
        }
    }
}
