using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscountListBLL : IBusiness
    {
        private CustomerDiscountListDAL dal = new CustomerDiscountListDAL();
        public CustomerDiscountListBLL()
		{
		}
		#region Stored procedure wrappers
		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<CustomerDiscountList> GetAll()
		{
			return dal.GetObjectAll();
		}		
		/// <summary>
		/// Gets all objects 
		/// </summary>
        public ListBase<CustomerDiscountList> GetDynamic(string whereCondition, string orderExpression)
		{
			return dal.GetObjectDynamic(whereCondition,orderExpression);
		}		
		/// <summary>
		/// Inserts an object into database by calling Insert StoredProcedure
		/// </summary>
        public int Insert(CustomerDiscountList t)
		{
            t.UserCreated = Contexts.CurrentUser.LoginName;
            t.DiscountID = Guid.NewGuid();
			return dal.Insert(t);
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
		
		/// <summary>
		/// Updates an existing object in database 
		/// </summary>
        public int Update(CustomerDiscountList t)
		{
            t.UserUpdated = Contexts.CurrentUser.LoginName;
			return dal.Update(t);
		}
			
		
		/// <summary>
		/// Deletes an object from database by Id
		/// </summary>		
        public int Delete(Guid discountID)
		{
            return dal.Delete(discountID);
		}
		
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
        public int Delete(CustomerDiscountList t)
		{			           
            return dal.Delete( t.DiscountID);
		}
		
		
		#endregion
		
				
		#region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerDiscountList);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerDiscountList);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerDiscountList);
        }

        #endregion
    }
}
