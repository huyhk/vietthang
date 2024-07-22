using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class ProductCostFormulaBLL:IBusiness
    {
        private ProductCostFormulaDAL dal = new ProductCostFormulaDAL();
        public ProductCostFormulaBLL() { }

        public ListBase<ProductCostFormula> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(ProductCostFormula t)
        {
            return dal.Insert(t);
        }

        public int Update(ProductCostFormula t)
        {
            return dal.Update(t);
        }
        public void UpdateCostPrice(string periodCode)
        {
            dal.UpdateCostPrice(periodCode);
        }
        public int Delete(ProductCostFormula t)
        {
            return dal.Delete(t);
        }
        public int Delete(string periodCode)
        {
            return dal.Delete(periodCode);
        }
        public int Delete(string periodCode, string productCode, string wrappingCode)
        {
            return dal.Delete(periodCode, productCode, wrappingCode);
        }
        public int CopyProductCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Delete(periodCodeLast);
            if (iError == 0)
                iError= dal.CopyProductCostFormulaByPeriodCodeLast(periodCode, periodCodeLast);
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;

        }

        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ProductCostFormula);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ProductCostFormula);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ProductCostFormula);
        }

        #endregion
    }
}