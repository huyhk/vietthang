
/************************************************************************
**	ClassName	: 	EquipmentLogBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 12:31 PM
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
	#region EquipmentLogBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of EquipmentLog.
	/// </summary>
	public class EquipmentLogBLL : IBusiness
	{
		private EquipmentLogDAL dal = new EquipmentLogDAL();		
		public EquipmentLogBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< EquipmentLog >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< EquipmentLog >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(EquipmentLog t)
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
		public int Update(EquipmentLog t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public EquipmentLog GetByID(string equipmentCode,DateTime startDate )
		{
			           
            return dal.GetByID( equipmentCode, startDate);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string equipmentCode,DateTime startDate )
		{
			           
            return dal.Delete( equipmentCode, startDate);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(EquipmentLog t)
		{
			           
            return dal.Delete( t.EquipmentCode, t.StartDate);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as EquipmentLog);
        }

        public int Update(object obj)
        {
            return this.Update(obj as EquipmentLog);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as EquipmentLog);
        }

        #endregion
		
	}
	#endregion
}

