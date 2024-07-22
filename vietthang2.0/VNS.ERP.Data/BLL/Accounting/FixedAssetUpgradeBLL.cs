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
	public class FixedAssetUpgradeBLL : IBusiness
	{
        private FixedAssetUpgradeDAL dal = new FixedAssetUpgradeDAL();
        public FixedAssetUpgradeBLL()
		{
		}
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<FixedAssetUpgrade> GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(FixedAssetUpgrade t)
		{
			return dal.Insert(t);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(FixedAssetUpgrade t)
		{
			return dal.Update(t);
		}
	
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(FixedAssetUpgrade t)
		{
            return 0;
		}

		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as FixedAssetUpgrade);
        }

        public int Update(object obj)
        {
            return this.Update(obj as FixedAssetUpgrade);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as FixedAssetUpgrade);
        }

        #endregion
		
	}

}
