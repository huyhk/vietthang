using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Sales
{

	/// <summary>
	/// This object represents the properties and methods of a Business Layer of FixedAsset.
	/// </summary>
	public class CustomerDeptSumOpeningBLL 
	{
        private CustomerDeptSumOpeningDAL dal = new CustomerDeptSumOpeningDAL();
        public CustomerDeptSumOpeningBLL()
		{
		}
		

		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(CustomerDeptSumOpening t)
		{
			return dal.Insert(t);
		}
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(CustomerDeptSumOpening t)
		{
			return dal.Update(t);
		}
	
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(CustomerDeptSumOpening t)
		{
            return dal.Delete(t);
		}
        public int Delete(string periodCode)
        {
            return dal.Delete(periodCode);
        }
        public ListBase<CustomerDeptSumOpening> GetByPeriodCode(string periodCode)
        {

            return ConvertRemainAmount(dal.GetByPeriodCode(periodCode));
        }
        private ListBase<CustomerDeptSumOpening> ConvertRemainAmount(ListBase<CustomerDeptSumOpening> lst)
        {
            foreach (CustomerDeptSumOpening cusOpen in lst)
            {
                if (cusOpen.RemainAmount < 0)
                    cusOpen.RemainAmount = (-cusOpen.RemainAmount);
                else
                    cusOpen.RemainAmount = (-cusOpen.RemainAmount);
            }
            return lst; 
        }
      
	}

}
