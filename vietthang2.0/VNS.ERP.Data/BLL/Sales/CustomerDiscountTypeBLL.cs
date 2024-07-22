using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Sales
{
    public class CustomerDiscountTypeBLL:IBusiness
    {
        private CustomerDiscountTypeDAL dal = new CustomerDiscountTypeDAL();
        public CustomerDiscountTypeBLL() { }
        public ListBase<CustomerDiscountType> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(CustomerDiscountType t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(CustomerDiscountType t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        public int Delete(CustomerDiscountType t)
        {
            return dal.Delete(t);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as CustomerDiscountType);
        }

        public int Update(object obj)
        {
            return this.Update(obj as CustomerDiscountType);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as CustomerDiscountType);
        }

        #endregion
    }
    public static class DiscountType
    {
        public static bool CheckDiscountSystemType(string discountTypeCode)
        {
            bool check = false;
            foreach (string enumType in Enum.GetNames(typeof(enumCustomerDiscountType)))
            {
                if (enumType == discountTypeCode)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
