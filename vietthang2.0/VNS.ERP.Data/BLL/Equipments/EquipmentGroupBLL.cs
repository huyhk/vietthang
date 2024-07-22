
/************************************************************************
**	ClassName	: 	EquipmentGroupBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	10-07-2008 10:32 AM
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
	#region EquipmentGroupBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of EquipmentGroup.
	/// </summary>
	public class EquipmentGroupBLL : IBusiness
	{
		private EquipmentGroupDAL dal = new EquipmentGroupDAL();		
		public EquipmentGroupBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< EquipmentGroup >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< EquipmentGroup >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(EquipmentGroup t)
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
		public int Update(EquipmentGroup t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public EquipmentGroup GetByID(string groupCode )
		{
			           
            return dal.GetByID( groupCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string groupCode )
		{
			           
            return dal.Delete( groupCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(EquipmentGroup t)
		{
			           
            return dal.Delete( t.GroupCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as EquipmentGroup);
        }

        public int Update(object obj)
        {
            return this.Update(obj as EquipmentGroup);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as EquipmentGroup);
        }

        #endregion
		
	}
	#endregion
}

