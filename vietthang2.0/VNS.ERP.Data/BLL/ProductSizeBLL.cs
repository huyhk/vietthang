using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;

namespace  VNS.ERP.Data
{
  public   class ProductSizeBLL:IBusiness
    {
        private ProductSizeDAL dal = new ProductSizeDAL();
        public ProductSizeBLL() { }
        public ListBase<ProductSize> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(ProductSize p)
        {
            p.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(p);
        }
        public int Delete(ProductSize p)
        {
            return dal.Delete(p);
        }
        public int Update(ProductSize p)
        {
            p.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(p);
        }
        public int Insert(object obj)
        { return Insert(obj as ProductSize); }
        public int Delete(object obj)
        { return Delete(obj as ProductSize); }
        public int Update(object obj)
        { return Update(obj as ProductSize); }
    }
}
