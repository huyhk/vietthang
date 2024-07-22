
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;
using VNS.Utils;

namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Business Layer of AccountOpening.
	/// </summary>
	public class AccountOpeningBLL 
	{
		private AccountOpeningDAL dal = new AccountOpeningDAL();		
		public AccountOpeningBLL()
		{
		}

		/// <summary>
		/// Gets all objects 
		/// </summary>
		public ListBase<AccountOpening>  GetAll()
		{
			return dal.GetObjectAll();
		}		
		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(ListBase<AccountOpening> lst,string periodCode)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                if (lst.Count > 0)
                {
                    iError = dal.Delete(periodCode);
                    if (iError == 0)
                    {
                        foreach (AccountOpening accOpening in lst)
                        {
                            accOpening.PeriodCode = periodCode;
                            if (accOpening.OpeningAmount != 0)
                                iError = dal.Insert(accOpening);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                else
                {
                    iError = dal.Delete(periodCode);
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountOpeningBLL", "Update(AccountOpening t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }
        public ListBase<AccountOpening> GetFromCustomerDeptSumOpenings(string periodCode)
        {
            return dal.GetFromCustomerDeptSumOpenings(periodCode);
        }
        public ListBase<AccountOpening> GetFromFixedAssetOpenings(string periodCode)
        {
            return dal.GetFromFixedAssetOpenings(periodCode);
        }
        public ListBase<AccountOpening> GetListAccountOpeningByPeriodCode(string periodCode)
        {
            return dal.GetListAccountOpeningByPeriodCode(periodCode);
        }
        public decimal GetOpenAmount(string accountCode, string periodCode)
        {
            return dal.GetOpenAmount(accountCode, periodCode);
        }
	}
}

