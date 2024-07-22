
/************************************************************************
**	ClassName	: 	TechnicalTestBLL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	18-02-2008 01:51 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
using VNS.ERP.Data;

namespace VNS.ERP.Data.KCS
{
	#region TechnicalTestBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TechnicalTest.
	/// </summary>
	public class TechnicalTestBLL : IBusiness
	{
		private TechnicalTestDAL dal = new TechnicalTestDAL();		
		public TechnicalTestBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TechnicalTest >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TechnicalTest >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}
        public ListBase<TechnicalTest> GetForCKSTest()
        {
            return dal.GetObjectDynamic(" KCSTest = 1 ", " TechCode ");
        }
        public ListBase<TechnicalTest> GetForPTNTest()
        {
            return dal.GetObjectDynamic(" PTNTest = 1 ", " TechCode ");
        }
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TechnicalTest t)
		{
            t.UserCreated = Contexts.CurrentUser.LoginName;
            t.UserUpdated = Contexts.CurrentUser.LoginName;
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
		public int Update(TechnicalTest t)
		{
            t.UserUpdated = Contexts.CurrentUser.LoginName;
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public TechnicalTest GetByID(string techCode )
		{
			           
            return dal.GetByID( techCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string techCode )
		{
			           
            return dal.Delete( techCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TechnicalTest t)
		{
			           
            return dal.Delete( t.TechCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TechnicalTest);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TechnicalTest);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TechnicalTest);
        }

        #endregion
		
	}
	#endregion
}

