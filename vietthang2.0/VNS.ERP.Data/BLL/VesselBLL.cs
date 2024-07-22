
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data
{
	#region VesselBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of Vessel.
	/// </summary>
    public class VesselBLL : IBusiness
	{
		private VesselDAL dal = new VesselDAL();		
		public VesselBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Vessel >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Vessel >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(Vessel t)
		{
            t.UserCreated = Contexts.CurrentUser.LoginName;
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
		public int Update(Vessel t)
		{
            t.UserUpdated = Contexts.CurrentUser.LoginName;
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public Vessel GetByID(string vesselCode )
		{			           
            return dal.GetByID( vesselCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string vesselCode )
		{			           
            return dal.Delete( vesselCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(Vessel t)
		{			           
            return dal.Delete( t.VesselCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Vessel);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Vessel);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Vessel);
        }

        #endregion
		
	}
	#endregion
}

