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
	public class PrePaidExpenseOpeningBLL : IBusiness
	{
        private PrePaidExpenseOpeningDAL dal = new PrePaidExpenseOpeningDAL();
        private PrePaidExpenseDAL dalPre;
        public PrePaidExpenseOpeningBLL()
		{
		}

		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<PrePaidExpenseOpening> GetAll()
		{
			return dal.GetObjectAll();
		}		
	
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(PrePaidExpenseOpening t)
		{
            int iError=0;
            dalPre = new PrePaidExpenseDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {
                iError = dalPre.Insert(t as PrePaidExpense);
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
        public int Update(PrePaidExpenseOpening t)
		{
            int iError=0;
            dalPre = new PrePaidExpenseDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {
                iError = dalPre.Update(t as PrePaidExpense);
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
        public int Delete(PrePaidExpenseOpening t)
        {
            int iError=0;
            dalPre = new PrePaidExpenseDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();
            try 
	        {
                iError = dalPre.Delete(t as PrePaidExpense);
                if (iError == 0)
                {
                    iError = dal.Delete(t);
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
        public ListBase<PrePaidExpenseOpening> GetObjectBy()
        {
            return dal.GetObjectAll();
        }
        public ListBase<PrePaidExpenseOpening> GetListPrePaidExpenseOpeningByPeriodCode(string periodCode)
        {
            return dal.GetListPrePaidExpenseOpeningByPeriodCode(periodCode);
        }
        public DataTable GetListPrePaidOpeningByStartDate(DateTime startDate, string periodCode)
        {
            return dal.GetListPrePaidOpeningByStartDate(startDate,periodCode);
        }
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as PrePaidExpenseOpening);
        }

        public int Update(object obj)
        {
            return this.Update(obj as PrePaidExpenseOpening);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as PrePaidExpenseOpening);
        }

        #endregion
		
	}
}

