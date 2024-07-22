using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestEncryptCodeBLL : IBusiness
    {
        ProductTestEncryptCodeDAL dal = new ProductTestEncryptCodeDAL();
        public ProductTestEncryptCodeBLL() { }
        public ListBase<ProductTestEncryptCode> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Update(ProductTestEncryptCode t, string oldItemEncryptCode)
        {
            return dal.Update(t, oldItemEncryptCode);
        }
        public ListBase<ProductTestEncryptCode> GetDynamic(string whereCondition, string OrderByExp)
        {
            return dal.GetObjectDynamic(whereCondition, OrderByExp);
        }
        public DataSet GetByManuDate(DateTime startDate, DateTime endDate)
        {
            return dal.GetByManuDate(startDate, endDate);
        }

        public int Insert(ProductTestEncryptCode t)
        {
            return dal.Insert(t);
        }
        public int Update(ProductTestEncryptCode t)
        {
            return dal.Update(t);
        }
        public int DeleteByItemEncryptCode(string itemEncryptCode)
        {
            return dal.DeleteByItemEncryptCode(itemEncryptCode);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductTestEncryptCode);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductTestEncryptCode);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductTestEncryptCode);
        }
        #endregion
    }
}
