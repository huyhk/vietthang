using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    public class ProductCostBLL:IBusiness
    {
        private ProductCostFormulaDAL dal = new ProductCostFormulaDAL();
        public ProductCostBLL() { }

        public ListBase<ProductCost> GetListProductCostByPerodCode(string periodCode)
        {
            ListBase<ProductCostFormula> lst = dal.GetListProductCostFormulaByPeriodCode(periodCode);
            ListBase<ProductCost> lstProCost=new ListBase<ProductCost>();
            ProductCost pr=null;
            string productCode = "", wrappingCode = "";
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].ProductCode != productCode || lst[i].WrappingCode != wrappingCode)
                {
                    productCode = lst[i].ProductCode;
                    wrappingCode = lst[i].WrappingCode;
                    pr = new ProductCost();
                    pr.PeriodCode = periodCode;
                    pr.ProductCode = productCode;
                    pr.WrappingCode = wrappingCode;
                    pr.Details = new ListBase<ProductCostFormula>();
                    lstProCost.Add(pr);
                }
                pr.Details.Add(lst[i]);
                pr.TotalCostAmount += lst[i].CostAmount;
            }

            //foreach (ProductCostFormula proFomula in lst)
            //{
              
            //    ProductCost pr = new ProductCost();
            //    pr.ProductCode = proFomula.ProductCode;
              
               
            //    if(lstProCost.Search("ProductCode",proFomula.ProductCode)==null)
            //    {
            //            pr.PeriodCode = proFomula.PeriodCode;
            //            pr.Details = new ListBase<ProductCostFormula>();
            //            foreach (ProductCostFormula prnext in lst)
            //            {
            //                if (pr.ProductCode == prnext.ProductCode)
            //                {
            //                    pr.Details.Add(prnext);
            //                    pr.TotalCostAmount += prnext.CostAmount;
            //                }
            //            }
            //            lstProCost.Add(pr);
            //    }
            //}
            return lstProCost;
        }

        public int Insert(ProductCost t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            foreach (ProductCostFormula pr in t.Details)
            {
                //ProductCostFormula pInsert = new ProductCostFormula();
                //pInsert.PeriodCode = t.PeriodCode;
                //pInsert.ProductCode = t.ProductCode;
                //pInsert.WrappingCode = t.WrappingCode;
                //pInsert.MaterialCode = pr.MaterialCode;
                //pInsert.Quantity = pr.Quantity;
                //pInsert.CostPrice = pr.CostPrice;
                //pInsert.CostAmount = pr.CostAmount;
                //iError = dal.Insert(pInsert);

                pr.PeriodCode = t.PeriodCode;
                pr.ProductCode = t.ProductCode;
                pr.WrappingCode = t.WrappingCode;
                iError = dal.Insert(pr);

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
        public int Update(ProductCost t)
        {

            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            iError = dal.Delete(t.PeriodCode, t.ProductCode, t.WrappingCode);
            if (iError == 0)
                foreach (ProductCostFormula pr in t.Details)
                {
                    //ProductCostFormula pInsert = new ProductCostFormula();
                    //pInsert.PeriodCode = t.PeriodCode;
                    //pInsert.ProductCode = t.ProductCode;
                    //pInsert.WrappingCode = t.WrappingCode;
                    //pInsert.MaterialCode = pr.MaterialCode;
                    //pInsert.Quantity = pr.Quantity;
                    //pInsert.CostPrice = pr.CostPrice;
                    //pInsert.CostAmount = pr.CostAmount;
                    //iError = dal.Insert(pInsert);

                    pr.PeriodCode = t.PeriodCode;
                    pr.ProductCode = t.ProductCode;
                    pr.WrappingCode = t.WrappingCode;
                    iError = dal.Insert(pr);
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
        public int Delete(ProductCost t)
        {
            return dal.Delete(t.PeriodCode, t.ProductCode, t.WrappingCode);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ProductCost);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ProductCost);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ProductCost);
        }

        #endregion
    }
}
