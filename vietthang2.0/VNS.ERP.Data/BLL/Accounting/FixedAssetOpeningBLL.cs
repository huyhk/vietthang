
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
	public class FixedAssetOpeningBLL : IBusiness
	{
		private FixedAssetOpeningDAL dal = new FixedAssetOpeningDAL();
        private AccountFixedAssetDAL dalAcc;
		public FixedAssetOpeningBLL()
		{
		}

		
		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase<FixedAssetOpening>  GetAll()
		{
			return dal.GetObjectAll();
		}		
	
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
		public int Insert(FixedAssetOpening t)
		{
            int iError=0;
            dalAcc = new AccountFixedAssetDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {	        
                iError= dalAcc.Insert(t as AccountFixedAssets);
        		if(iError==0)
                    iError=dal.Insert(t);
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
        public int Update(FixedAssetOpening t)
		{
            int iError=0;
            dalAcc = new AccountFixedAssetDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {	        
                iError= dalAcc.Update(t as AccountFixedAssets);
        		if(iError==0)
                    iError=dal.Update(t);
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
        /// Deletes an object into database by calling Deletes StoredProcedure
        /// </summary>
        public int Delete(FixedAssetOpening t)
        {
            int iError=0;
            dalAcc = new AccountFixedAssetDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {	        
                iError= dalAcc.Delete(t.FixedAssetCode);
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
        public ListBase<FixedAssetOpening> GetObjectBy()
        {
            return dal.GetObjectAll();
        }
        public ListBase<FixedAssetOpening> GetListFixedAssetOpeningByPeriodCode(string periodCode)
        {
            return dal.GetListFixedAssetOpeningByPeriodCode(periodCode);
        }
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as FixedAssetOpening);
        }

        public int Update(object obj)
        {
            return this.Update(obj as FixedAssetOpening);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as FixedAssetOpening);
        }

        #endregion
		
	}
}

