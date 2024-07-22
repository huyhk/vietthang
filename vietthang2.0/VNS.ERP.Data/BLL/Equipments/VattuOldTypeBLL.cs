
/************************************************************************
**	ClassName	: 	VattuOldTypeBLL
**	Author		:	Cohim2000
**	Company		:	VNS
**	Date		:	11-07-2008 08:36 AM
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
	#region VattuOldTypeBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of VattuOldType.
	/// </summary>
	public class VattuOldTypeBLL : IBusiness
	{
		private VattuOldTypeDAL dal = new VattuOldTypeDAL();		
		public VattuOldTypeBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< VattuOldType >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< VattuOldType >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(VattuOldType t)
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
		public int Update(VattuOldType t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public VattuOldType GetByID(string typeCode )
		{
			           
            return dal.GetByID( typeCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string typeCode )
		{
			           
            return dal.Delete( typeCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(VattuOldType t)
		{
			           
            return dal.Delete( t.TypeCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as VattuOldType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as VattuOldType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as VattuOldType);
        }

        #endregion


        //#region IBusiness Members

        //int IBusiness.Insert(object obj)
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        //int IBusiness.Update(object obj)
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        //int IBusiness.Delete(object obj)
        //{
        //    throw new Exception("The method or operation is not implemented.");
        //}

        //#endregion
    }
	#endregion
}

