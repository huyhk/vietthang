
/************************************************************************
**	ClassName	: 	EquipmentExpens
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	02-08-2008 05:23 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
namespace VNS.ERP.Data.Equipments
{
	#region EquipmentExpens
	/// <summary>
	/// This object represents the properties and methods of a EquipmentExpens.
	/// </summary>
	public class EquipmentExpense : UserTracking2 
	{
			
		
		public EquipmentExpense()
		{
		}
		
		public EquipmentExpense(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		
		public override void FromDataReader(IDataReader reader)
		{
			base.FromDataReader(reader);
			if (reader != null && !reader.IsClosed)
			{						
				if (!isNull("ExpenseID",reader)) expenseID = reader.GetGuid(reader.GetOrdinal("ExpenseID"));
				if (!isNull("ExpenseNo",reader)) expenseNo = reader.GetString(reader.GetOrdinal("ExpenseNo"));
				if (!isNull("ExpenseDate",reader)) expenseDate = reader.GetDateTime(reader.GetOrdinal("ExpenseDate"));
				if (!isNull("StockCode",reader)) stockCode = reader.GetString(reader.GetOrdinal("StockCode"));
				if (!isNull("Amount",reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
				if (!isNull("Description",reader)) description = reader.GetString(reader.GetOrdinal("Description"));
				
			}
		}
		
		public override void FromDataRow(DataRow row)
		{
			base.FromDataRow(row);
			
			if (!row.IsNull("ExpenseID")) expenseID = (Guid)row["ExpenseID"];
			if (!row.IsNull("ExpenseNo")) expenseNo = (string)row["ExpenseNo"];
			if (!row.IsNull("ExpenseDate")) expenseDate = (DateTime)row["ExpenseDate"];
			if (!row.IsNull("StockCode")) stockCode = (string)row["StockCode"];
			if (!row.IsNull("Amount")) amount = (decimal)row["Amount"];
			if (!row.IsNull("Description")) description = (string)row["Description"];
			
		}
		
		#region Public Properties

		
		
		private Guid expenseID = Guid.Empty;
		/// <summary>
		/// Gets or sets the value of ExpenseID
		/// </summary>
		public Guid ExpenseID
		{
			get {return expenseID;}
			set {expenseID = value;}
		}

		private string expenseNo = String.Empty;
		/// <summary>
		/// Gets or sets the value of ExpenseNo
		/// </summary>
		public string ExpenseNo
		{
			get {return expenseNo;}
			set {expenseNo = value;}
		}

       private DateTime expenseDate =Contexts.WorkingDate;
		/// <summary>
		/// Gets or sets the value of ExpenseDate
		/// </summary>
		public DateTime ExpenseDate
		{
			get {return expenseDate;}
			set {expenseDate = value;}
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

		private decimal amount;
		/// <summary>
		/// Gets or sets the value of Amount
		/// </summary>
		public decimal Amount
		{
			get {return amount;}
			set {amount = value;}
		}

		private string description = String.Empty;
		/// <summary>
		/// Gets or sets the value of Description
		/// </summary>
		public string Description
		{
			get {return description;}
			set {description = value;}
		}

		#endregion
		
		#region Lists
		#endregion

        private ListBase<EquipmentExpense> detailStock = new ListBase<EquipmentExpense>();
        public ListBase<EquipmentExpense> DetailStock
        {
            get { return detailStock; }
            set { detailStock = value; }
        }
	}
	#endregion
}	

