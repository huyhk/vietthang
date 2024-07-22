
/************************************************************************
**	ClassName	: 	KheuocvayBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	05-12-2009 11:45 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{
	#region KheuocvayBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of Kheuocvay.
	/// </summary>
	public class KheUocVayBLL : IBusiness
	{
        private KheUocVayDAL dal = new KheUocVayDAL();
        public KheUocVayBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<KheUocVay> GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<KheUocVay> GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(KheUocVay t)
		{
			return dal.Insert(t);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(KheUocVay t)
		{
			return dal.Update(t);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(Guid vayID )
		{      
            return dal.Delete( vayID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(KheUocVay t)
		{
			           
            return dal.Delete( t.VayID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as KheUocVay);
        }

        public int Update(object obj)
        {
            return this.Update(obj as KheUocVay);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as KheUocVay);
        }

        #endregion
		
	}
	#endregion
}

