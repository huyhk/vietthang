
/************************************************************************
**	ClassName	: 	TransportFeeBLL
**	Author		:	Tuan
**	Company		:	VNS
**	Date		:	30-11-2009 10:58 AM
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
	#region TransportFeeBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TransportFee.
	/// </summary>
	public class TransportFeeBLL : IBusiness
	{
		private TransportFeeDAL dal = new TransportFeeDAL();		
		public TransportFeeBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TransportFee >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TransportFee >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TransportFee t)
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
		public int Update(TransportFee t)
		{
			return dal.Update(t);
		}
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
		public int Delete(string feeCode )
		{       
            return dal.Delete( feeCode);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
		public int Delete(TransportFee t)
		{
			           
            return dal.Delete( t.FeeCode);
		}

        public TransportFee GetByID(string feeCode)
        {
            return dal.GetByID(feeCode);
        }
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TransportFee);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TransportFee);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TransportFee);
        }

        #endregion
		
	}
	#endregion
}

