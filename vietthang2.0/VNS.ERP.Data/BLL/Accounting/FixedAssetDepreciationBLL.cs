
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
	public class FixedAssetDepreciationBLL : IBusiness
	{
        private FixedAssetDepreciationDAL dal = new FixedAssetDepreciationDAL();
        private AccountTransactionDetail1DAL dalTranDetail1;
        public FixedAssetDepreciationBLL()
		{
		}
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<FixedAssetDepreciation> GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(FixedAssetDepreciation t)
		{
			return dal.Insert(t);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(FixedAssetDepreciation t)
		{
			return dal.Update(t);
		}
	
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(FixedAssetDepreciation t)
		{
            return dal.Delete(t);
		}
        public ListBase<AccountTransactionDetail1> GetListBaseDetal1ByPeriodCode(string periodCode)
        {
            dalTranDetail1 = new AccountTransactionDetail1DAL();
            return dalTranDetail1.GetListBaseByPeriodCodeFromFixedAssetDepreciations(periodCode);
         }
        public ListBase<AccountTransactionDetail2> GetListBaseDetail2ByPeriodCode(string periodCode, bool subTK)
        {
            AccountTransactionDetail2DAL dalTranDetail2 = new AccountTransactionDetail2DAL();
            return dalTranDetail2.GetListBaseByPeriodCodeFromFixedAssetDepreciations(periodCode, subTK);
        }
        public DataSet GetReportFixedAssetDepreciationByYear(int year)
        {
            return dal.GetReportFixedAssetDepreciationByYear(year);
        }
        public DataSet GetReportFixedAssetDepreciationByYear2(DateTime date)
        {
            return dal.GetReportFixedAssetDepreciationByYear2(date);
        }
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as FixedAssetDepreciation);
        }

        public int Update(object obj)
        {
            return this.Update(obj as FixedAssetDepreciation);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as FixedAssetDepreciation);
        }

        #endregion
		
	}

}
