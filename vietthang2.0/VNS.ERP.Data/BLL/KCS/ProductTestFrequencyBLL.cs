using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestFrequencyBLL : IBusiness
    {
        ProductTestFrequencyDAL dal = new ProductTestFrequencyDAL();
        public ProductTestFrequencyBLL() { }
        public ListBase<ProductTestFrequency> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ProductTestFrequency> GetByProductCode(string productCode)
        {
            return dal.GetByProductCode(productCode);
        }
        public int Insert(ProductTestFrequency t)
        {
            return dal.Insert(t);
        }
        public int Update(ProductTestFrequency t)
        {
            return dal.Update(t);
        }
        public int Delete(ProductTestFrequency t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductTestFrequency);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductTestFrequency);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductTestFrequency);
        }
        #endregion
    }
}
