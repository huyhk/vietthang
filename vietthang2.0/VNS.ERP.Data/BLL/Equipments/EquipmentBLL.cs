
/************************************************************************
**	ClassName	: 	EquipmentBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 11:48 AM
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
	#region EquipmentBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of Equipment.
	/// </summary>
	public class EquipmentBLL : IBusiness
	{
		private EquipmentDAL dal = new EquipmentDAL();		
		public EquipmentBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Equipment >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Equipment >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(Equipment t)
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
		public int Update(Equipment t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public Equipment GetByID(string equipmentCode )
		{
			           
            return dal.GetByID( equipmentCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string equipmentCode )
		{
			           
            return dal.Delete( equipmentCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(Equipment t)
		{
			           
            return dal.Delete( t.EquipmentCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Equipment);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Equipment);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Equipment);
        }

        #endregion
		
	}
	#endregion
}

