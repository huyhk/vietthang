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
	/// This object represents the properties and methods of a Business Layer of FixedAssetOpening.
	/// </summary>
	public class PrePaidReDepreciationBLL : IBusiness
	{
        private PrePaidReDepreciationDAL dal = new PrePaidReDepreciationDAL();
        public PrePaidReDepreciationBLL()
		{
		}

	
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int InsertListPrePaidReDepreciation(ListBase<PrePaidReDepreciation> lst,string preiodCode)
		{
            int iError=0;
            dal.Open();
            dal.BeginTransaction();
            try 
	        {
                iError = dal.DeleteByPeriodCode(preiodCode);
                if (iError == 0)
                {
                    foreach (PrePaidReDepreciation t in lst)
                    {

                        t.PeriodCode = preiodCode;
                        if(t.CheckEdit==true)
                            iError = dal.Insert(t);
                        else
                        {
                            t.DepRate = 0;
                            t.DepMonth = 0;
                        }
                        if (iError != 0)
                            break;
                    }
                }
	        }
	        catch
	        {
                iError=-1000;
	        }
            finally
            {
                if (iError != 0)
                    dal.Rollback();
                else
                    dal.Commit();
                dal.Close();
            }
            return iError;
		}
        /// <summary>
        /// Updates an object into database by calling Updates StoredProcedure
        /// </summary>
        public int Update(PrePaidReDepreciation t)
		{
            return 0;
		}
        /// <summary>
        /// Deletes an object into database by calling Deletes StoredProcedure
        /// </summary>
        public int Delete(PrePaidReDepreciation t)
        {
            return 0;
        }
      
        public int DeleteByPeriodCode(string periodCode)
        {
            return dal.DeleteByPeriodCode(periodCode);
        }

        public ListBase<PrePaidReDepreciation> GetListPrePaidReDepreciationByPeriodCode(string periodCode)
        {
            return dal.GetListPrePaidReDepreciationByPeriodCode(periodCode);
        }
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PrePaidReDepreciation);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PrePaidReDepreciation);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PrePaidReDepreciation);
        }

        #endregion
		
	}
}

