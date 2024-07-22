
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Business Layer of FixedAsset.
	/// </summary>
	public class AccountFixedAssetBLL : IBusiness
	{
        private AccountFixedAssetDAL dal = new AccountFixedAssetDAL();
        public AccountFixedAssetBLL()
		{
		}
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase<AccountFixedAssets>  GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(AccountFixedAssets t)
		{
			return dal.Insert(t);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(AccountFixedAssets t)
		{
			return dal.Update(t);
		}
			
		/// <summary>
		/// Returns an object by ID
		/// </summary>		
        public AccountFixedAssets GetByID(string fixedAssetCode)
		{
			           
            return dal.GetByID( fixedAssetCode);
		}
			
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(AccountFixedAssets t)
		{
			           
            return dal.Delete( t.FixedAssetCode);
		}

		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as AccountFixedAssets);
        }

        public int Update(object obj)
        {
            return this.Update(obj as AccountFixedAssets);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as AccountFixedAssets);
        }

        #endregion
		
	}

}

