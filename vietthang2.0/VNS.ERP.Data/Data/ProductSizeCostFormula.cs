/************************************************************************
**	ClassName	: 	ProductSizeCostFormula
**	Author		:	Le Phan
**	Company		:	VNS
**	Date		:	01-06-2007 09:58 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace VNS.ERP.Data
{

	/// <summary>
	/// This object represents the properties and methods of a ProductCostFormula.
	/// </summary>
	public class ProductSizeCostFormula : BaseClass 
	{
		public ProductSizeCostFormula()
		{
		}
        public ProductSizeCostFormula(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
                if (!isNull("ProductSizeCode", reader)) productSizeCode = reader.GetString(reader.GetOrdinal("ProductSizeCode"));
                if (!isNull("ProductType", reader)) productType = reader.GetString(reader.GetOrdinal("ProductType"));
			    if (!isNull("Quantity",reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                if (!isNull("Quantity2", reader)) quantity2 = reader.GetDecimal(reader.GetOrdinal("Quantity2"));
			}
		}
		
		#region Public Properties

		protected string periodCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of PeriodCode
		/// </summary>
		public string PeriodCode
		{
			get {return periodCode;}
			set {periodCode = value;}
		}

        protected string productSizeCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of ProductCode
		/// </summary>
        public string ProductSizeCode
		{
            get { return productSizeCode; }
            set { productSizeCode = value; }
		}

        protected string productType = "TS";
        /// <summary>
        /// Gets or sets the value of ProductType
        /// </summary>
        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

		protected decimal quantity;
		/// <summary>
		/// Gets or sets the value of Quantity
		/// </summary>
		public decimal Quantity
		{
			get {return quantity;}
			set {
                quantity = value;
            }
		}

        protected decimal quantity2;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal Quantity2
        {
            get { return quantity2; }
            set
            {
                quantity2 = value;
            }
        }

        protected decimal quantityGS;
        /// <summary>
        /// Gets or sets the value of Quantity
        /// </summary>
        public decimal QuantityGS
        {
            get { return quantityGS; }
            set
            {
                quantityGS = value;
            }
        }
		#endregion
	}

}	
