using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;


namespace VNS.ERP.Data.Manufactures
{
    public class ProductFormulaBLL:IBusiness
    {
        private ProductFormulaDAL dal = new ProductFormulaDAL();
        public ProductFormulaBLL() { }
        public ListBase<ProductFormula> GetAll()
        {
            return dal.GetAll();
        }
        public int Insert(ProductFormula t)
        {
            return dal.Insert(t);
        }
        public int Update(ProductFormula t)
        {
            return dal.Update(t);
        }
        public int Delete(ProductFormula t)
        {
            return dal.Delete(t);
        }
        public DataTable GetAllFormulaActive()
        {
            return (new FormulaDetailDAL()).GetAllFormulaActive();
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductFormula);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductFormula);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductFormula);
        }
        #endregion

        public ListBase<ProductFormula> GetActiveByProductCode(string productCode)
        { return dal.GetActiveByProductCode(productCode); }
        public ListBase<ProductFormula> GetActiveByItemCode(string itemCode)
        { return dal.GetActiveByItemCode(itemCode); }
    }
}
