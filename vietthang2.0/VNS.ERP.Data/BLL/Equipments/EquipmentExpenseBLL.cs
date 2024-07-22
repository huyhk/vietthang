
/************************************************************************
**	ClassName	: 	EquipmentExpensBLL
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	02-08-2008 05:44 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Equipments
{
	#region EquipmentExpensBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of EquipmentExpens.
	/// </summary>
	public class EquipmentExpensBLL : IBusiness
	{
		private EquipmentExpensDAL dal = new EquipmentExpensDAL();		
		public EquipmentExpensBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<EquipmentExpense> GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        ///
        public ListBase<EquipmentExpense> GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetByDateAndStockCode(startDate, endDate, stockCode);
        }
        public ListBase<EquipmentExpense> GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(EquipmentExpense t)
		{
			return dal.Insert(t);
		}
		/// <summary>
		/// Delete all rows 
		/// </summary>
		public int DeleteAll()
		{
			return dal.DeleteAll();
		}
		/// <summary>
		/// Delete rows by dynamic criteria
		/// </summary>
		public int DeleteDynamic(string whereCondidion)
		{
			return dal.DeleteDynamic(whereCondidion);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(EquipmentExpense t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
        public EquipmentExpense GetByID(Guid expenseID)
		{
			           
            return dal.GetByID( expenseID);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid expenseID )
		{
			           
            return dal.Delete( expenseID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(EquipmentExpense t)
		{
			           
            return dal.Delete( t.ExpenseID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as EquipmentExpense);
        }

        public int Update(object obj)
        {
            return this.Update(obj as EquipmentExpense);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as EquipmentExpense);
        }

        #endregion
		
	}
	#endregion
}

