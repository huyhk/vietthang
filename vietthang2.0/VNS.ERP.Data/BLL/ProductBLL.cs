using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Utils;
using VNS.Data.BLL;
using System.Data.Common;
namespace  VNS.ERP.Data
{
   public  class ProductBLL :IBusiness
    {
        private ProductDAL dal = new ProductDAL();
        public ProductBLL() { }
        public ListBase<Product> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(Product p)
        {
            p.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(p);
        }
        public int Delete(Product p)
        {
            return dal.Delete(p);
        }
        public int Update(Product p)
        {
            p.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(p);
        }
        public int Insert(object obj)
        { return Insert(obj as Product); }
        public int Delete(object obj)
        { return Delete(obj as Product); }
        public int Update(object obj)
        { return Update(obj as Product); }

    }
}
