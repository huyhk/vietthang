
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
	
	/// <summary>
	/// This object represents the properties and methods of a Business Layer of Currency.
	/// </summary>
	public class CurrencyBL : IBusiness
	{
		private CurrencyDAL dal = new CurrencyDAL();		
		public CurrencyBL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase< Currency >  GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(Currency t)
		{
			return dal.Insert(t);
		}
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Currency);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Currency);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Currency);
        }

        #endregion
		
	}
	
}

