
/************************************************************************
**	ClassName	: 	MaterialTestFrequencysBLL
**	Author		:	Huy Ho
**	Company		:	VNS
**	Date		:	19-02-2008 02:23 PM
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
	#region MaterialTestFrequencysBLL
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of MaterialTestFrequencys.
	/// </summary>
	public class MaterialTestFrequencysBLL : IBusiness
	{
		private MaterialTestFrequencysDAL dal = new MaterialTestFrequencysDAL();		
		public MaterialTestFrequencysBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< MaterialTestFrequencys >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< MaterialTestFrequencys >  GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        /// 
        public ListBase<MaterialTestFrequencys> GetByItemCode(string itemCode)
        {
            return dal.GetByItemCode(itemCode);
        }

		public int Insert(MaterialTestFrequencys t)
		{
			return dal.Insert(t);
		}

        public int Delete(MaterialTestFrequencys t)
        {
            return dal.Delete(t);
        }

        public int Update(MaterialTestFrequencys t)
        {
            return dal.Update(t);
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
            return this.Insert(obj as MaterialTestFrequencys);
        }

        public int Update(object obj)
        {
            return this.Update(obj as MaterialTestFrequencys);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as MaterialTestFrequencys);
        }

        #endregion
		
	}
	#endregion
}

