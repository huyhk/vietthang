
/************************************************************************
**	ClassName	: 	ToBocxepBLL
**	Author		:	Ai Tang
**	Company		:	VNS
**	Date		:	25-08-2008 11:46 AM
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
	#region ToBocxepBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of ToBocxep.
	/// </summary>
	public class ToBocxepBLL : IBusiness
	{
		private ToBocxepDAL dal = new ToBocxepDAL();		
		public ToBocxepBLL()
		{
		}
		#region Stored procedure wrappers
		public ListBase< ToBocxep >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		public ListBase< ToBocxep >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		public int Insert(ToBocxep t)
		{
			return dal.Insert(t);
		}
		public int DeleteAll()
		{
			return dal.DeleteAll();
		}
		public int DeleteDynamic(string whereCondidion)
		{
			return dal.DeleteDynamic(whereCondidion);
		}
		public int Update(ToBocxep t)
		{
			return dal.Update(t);
		}
        public ListBase<ToBocxep> GetBySubjectCode(string subjectCode)
        {
            return dal.GetBySubjectCode(subjectCode);
        }
		public ToBocxep GetByID(string toBocxepCode )
		{
            return dal.GetByID( toBocxepCode);
		}
		public int Delete(string toBocxepCode )
		{
			           
            return dal.Delete( toBocxepCode);
		}
		public int Delete(ToBocxep t)
		{
			           
            return dal.Delete( t.ToBocxepCode);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ToBocxep);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ToBocxep);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ToBocxep);
        }

        #endregion
		
	}
	#endregion
}

