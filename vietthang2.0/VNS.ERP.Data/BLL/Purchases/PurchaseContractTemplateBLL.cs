
/************************************************************************
**	ClassName	: 	PurchaseContractTemplateBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	13-08-2009 02:02 PM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
	#region PurchaseContractTemplateBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of PurchaseContractTemplate.
	/// </summary>
	public class PurchaseContractTemplateBLL : IBusiness
	{
		private PurchaseContractTemplateDAL dal = new PurchaseContractTemplateDAL();		
		public PurchaseContractTemplateBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchaseContractTemplate >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< PurchaseContractTemplate >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(PurchaseContractTemplate t)
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
		public int Update(PurchaseContractTemplate t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
		public PurchaseContractTemplate GetByID(string templateCode )
		{
			           
            return dal.GetByID( templateCode);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string templateCode )
		{
			           
            return dal.Delete( templateCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(PurchaseContractTemplate t)
		{
			           
            return dal.Delete( t.TemplateCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PurchaseContractTemplate);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PurchaseContractTemplate);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PurchaseContractTemplate);
        }

        #endregion
		
	}
	#endregion
}

