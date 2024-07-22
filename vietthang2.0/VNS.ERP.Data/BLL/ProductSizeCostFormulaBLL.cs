using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class ProductSizeCostFormulaBLL:IBusiness
    {
        private ProductSizeCostFormulaDAL dal = new ProductSizeCostFormulaDAL();
        public ProductSizeCostFormulaBLL() { }

        public ListBase<ProductSizeCostFormula> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ProductSizeCostFormula> GetListBaseObjectByPeriodCode(string periodCode)
        {
            return dal.GetListBaseObject(periodCode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lst"></param>
        /// <param name="periodCode"></param>
        /// <returns></returns>
        public int InsertListProductSizeCostFormula(ListBase<ProductSizeCostFormula> lst, string periodCode)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Delete(periodCode);
            if (iError == 0)
                foreach (ProductSizeCostFormula proSize in lst)
                {
                    proSize.PeriodCode = periodCode;
                    iError = dal.Insert(proSize);
                    if (iError != 0)
                        break;
                }
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }

        public int Update(ProductSizeCostFormula t)
        {
            return 0;
        }

        public int Delete(ProductSizeCostFormula t)
        {
            return dal.Delete(t);
        }
        public int Delete(string periodCode)
        {
            return dal.Delete(periodCode);
        }
        public int CopyProductSizeCostFormulaByPeriodCodeLast(string periodCode, string periodCodeLast)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Delete(periodCodeLast);
            if (iError == 0)
               iError=dal.CopyProductSizeCostFormulaByPeriodCodeLast(periodCode, periodCodeLast);
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
            return this.Insert(obj as ProductSizeCostFormula);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ProductSizeCostFormula);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ProductSizeCostFormula);
        }

        #endregion
    }
}