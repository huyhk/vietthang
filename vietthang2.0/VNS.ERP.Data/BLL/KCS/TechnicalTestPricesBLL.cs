
/************************************************************************
**	ClassName	: 	TechnicalTestPriceBLL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 11:50 AM
************************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.KCS
{
	#region TechnicalTestPriceBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of TechnicalTestPrice.
	/// </summary>
	public class TechnicalTestPriceBLL : IBusiness
	{
		private TechnicalTestPriceDAL dal = new TechnicalTestPriceDAL();		
		public TechnicalTestPriceBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< TechnicalTestPrice >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        /// 

        public ListBase<TechnicalTestPrice> GetBySubjectCode(string subjectCode)
        {
            return dal.GetBySubjectCode(subjectCode);
        }
		public ListBase< TechnicalTestPrice >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(TechnicalTestPrice t)
		{
			return dal.Insert(t);
		}

        public int Update(TechnicalTestPrice t)
        {
            return dal.Update(t);
        }

        public int Delete(TechnicalTestPrice t)
        {
            return dal.Delete(t);
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
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as TechnicalTestPrice);
        }

        public int Update(object obj)
        {
            return this.Update(obj as TechnicalTestPrice);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as TechnicalTestPrice);
        }

        #endregion
		
	}
	#endregion
}

