
/************************************************************************
**	ClassName	: 	VattuOldOpening
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	10-07-2008 02:38 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
	#region VattuOldOpening
	/// <summary>
	/// This object represents the properties and methods of a VattuOldOpening.
	/// </summary>
    public class VattuOldOpening : ObjectBase 
	{
			
		
		public VattuOldOpening()
		{
		}
		
		public VattuOldOpening(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);
			
        //    periodCode = (obj as VattuOldOpening).periodCode;
        //    stockCode = (obj as VattuOldOpening).stockCode;
        //    vattuCode = (obj as VattuOldOpening).vattuCode;
        //    vattuOldType = (obj as VattuOldOpening).vattuOldType;
        //    quantity = (obj as VattuOldOpening).quantity;
        //    serverCreated = (obj as VattuOldOpening).serverCreated;

        //}
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("PeriodCode",reader)) periodCode = reader.GetString(reader.GetOrdinal("PeriodCode"));
				if (!isNull("StockCode",reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
				if (!isNull("VattuCode",reader)) vattuCode = reader.GetString(reader.GetOrdinal("VattuCode"));
				if (!isNull("VattuOldType",reader)) vattuOldType = reader.GetString(reader.GetOrdinal("VattuOldType"));
				if (!isNull("Quantity",reader)) quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount")); ;
				
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("PeriodCode")) periodCode = (string)row["PeriodCode"];
			if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
			if (!row.IsNull("VattuCode")) vattuCode = (string)row["VattuCode"];
			if (!row.IsNull("VattuOldType")) vattuOldType = (string)row["VattuOldType"];
			if (!row.IsNull("Quantity")) quantity = (int)row["Quantity"];
            if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
			
		}
		
		#region Public Properties

		
		
		private string periodCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of PeriodCode
		/// </summary>
		public string PeriodCode
		{
			get {return periodCode;}
			set {periodCode = value;}
		}

		private string stockCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of StockCode
		/// </summary>
		public string StockCode
		{
			get {return stockCode;}
			set {stockCode = value;}
		}

		private string vattuCode = String.Empty;
		/// <summary>
		/// Gets or sets the value of VattuCode
		/// </summary>
		public string VattuCode
		{
			get {return vattuCode;}
			set {vattuCode = value;}
		}

		private string vattuOldType = String.Empty;
		/// <summary>
		/// Gets or sets the value of VattuOldType
		/// </summary>
		public string VattuOldType
		{
			get {return vattuOldType;}
			set {vattuOldType = value;}
		}

		private int quantity;
		/// <summary>
		/// Gets or sets the value of Quantity
		/// </summary>
		public int Quantity
		{
			get {return quantity;}
			set {quantity = value;}
		}
        private decimal amount=0;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
		#endregion
		
		#region Lists
		#endregion
       	

	}
    public class VattuOldOpeningList : ObjectBase
    {
        private ListBase<VattuOldOpening> _listVattuOldOpening;
        public ListBase<VattuOldOpening> ListVattuOldOpening
        {
            get { return _listVattuOldOpening; }
            set { _listVattuOldOpening = value; }
        }
    }	
	#endregion
}	

