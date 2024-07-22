
/************************************************************************
**	ClassName	: 	EquipmentsxsBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	09-07-2008 01:17 PM
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
	#region EquipmentsxBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of Equipmentsxs.
	/// </summary>
    public class EquipmentsxBLL : IBusiness
	{
		private EquipmentsxDAL dal = new EquipmentsxDAL();		
		public EquipmentsxBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Equipmentsx >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Equipmentsx >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(Equipmentsx t)
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
		public int Update(Equipmentsx t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public Equipmentsx GetByID(string equipmentsxCode )
		{
			           
            return dal.GetByID( equipmentsxCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string equipmentsxCode )
		{
			           
            return dal.Delete( equipmentsxCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(Equipmentsx t)
		{
			           
            return dal.Delete( t.EquipmentsxCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Equipmentsx);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Equipmentsx);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Equipmentsx);
        }

        #endregion
		
	}
	#endregion
}

