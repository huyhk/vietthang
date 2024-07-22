
/************************************************************************
**	ClassName	: 	ProductCostFormula
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
	public class ProductCostFormula : BaseClass 
	{
		public ProductCostFormula()
		{
		}
		public ProductCostFormula(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		public override void FromDataReader(IDataReader reader)
		{
			if (reader != null && !reader.IsClosed)
			{
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
				if (!isNull("ProductCode",reader)) productCode = reader.GetString(reader.GetOrdinal("ProductCode"));
				if (!isNull("MaterialCode",reader)) materialCode = reader.GetString(reader.GetOrdinal("MaterialCode"));
                if (!isNull("WrappingCode", reader)) wrappingCode = reader.GetString(reader.GetOrdinal("WrappingCode"));
				if (!isNull("Quantity",reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
				if (!isNull("CostPrice",reader)) costPrice = reader.GetDecimal(reader.GetOrdinal("CostPrice"));
				if (!isNull("CostAmount",reader)) costAmount = reader.GetDecimal(reader.GetOrdinal("CostAmount"));

                if (!isNull("STT", reader)) sTT = reader.GetInt32(reader.GetOrdinal("STT"));
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

		protected string productCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of ProductCode
		/// </summary>
		public string ProductCode
		{
			get {return productCode;}
			set {productCode = value;}
		}

		protected string materialCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of MaterialCode
		/// </summary>
		public string MaterialCode
		{
			get {return materialCode;}
			set {materialCode = value;}
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
                if (CostPrice != 0)
                    costAmount = CostPrice * quantity;
            }
		}

		protected decimal costPrice;
		/// <summary>
		/// Gets or sets the value of CostPrice
		/// </summary>
		public decimal CostPrice
		{
			get {return costPrice;}
			set {costPrice = value;
            if (Quantity != 0)
                costAmount = CostPrice * quantity;
            }
		}

		protected decimal costAmount;
		/// <summary>
		/// Gets or sets the value of CostAmount
		/// </summary>
		public decimal CostAmount
		{
			get {return costAmount;}
			set {costAmount = value;}
		}

        protected string wrappingCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of WrappingCode
        /// </summary>
        public string WrappingCode
        {
            get { return wrappingCode; }
            set { wrappingCode = value; }
        }

        private int sTT = 1;

        public int STT
        {
            get { return sTT; }
            set { sTT = value; }
        }
	

		#endregion
	}

}	
