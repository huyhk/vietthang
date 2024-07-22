using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.KCS
{
    public class ProductQualityStandardsBLL : IBusiness
    {
        ProductQualityStandardsDAL dal = new ProductQualityStandardsDAL();
        public ProductQualityStandardsBLL() { }
        public ListBase<ProductQualityStandards> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ProductQualityStandards> GetByDate(DateTime  date)
        {
            return dal.GetByDate(date);
        }
        public ListBase<ProductQualityStandards> GetByProductCode(string productCode)
        {
            return dal.GetByProductCode(productCode);
        }
        public int Insert(ProductQualityStandards t)
        {
            return dal.Insert(t);
        }
        public int Update(ProductQualityStandards t)
        {
            return dal.Update(t);
        }
        public int Delete(ProductQualityStandards t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductQualityStandards);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductQualityStandards);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductQualityStandards);
        }
        #endregion

        private static Boolean CheckQuality(string sValue, ProductQualityStandards obj)
        {
            if (obj == null) return true;
            decimal dValue = 0;
            decimal dStandard = 0;
            if (!decimal.TryParse(sValue, out dValue)) return true;
            if (!decimal.TryParse(obj.ValueString, out dStandard)) return true;
            if (obj.ConditionType == enumKCSConditionType.MIN.ToString())
            {
                return (dValue >= dStandard);
            }
            else if (obj.ConditionType == enumKCSConditionType.MAX.ToString())
            {
                return (dValue <= dStandard);
            }
            return true;
        }
        private static ProductQualityStandards search(ListBase<ProductQualityStandards> lst, string productCode, string techCode)
        {
            foreach (ProductQualityStandards obj in lst)
            {
                if (obj.ProductCode == productCode && obj.TechCode == techCode)
                    return obj;
            }
            return null;
        }
        public static Boolean CheckQuality(string sValue, ListBase<ProductQualityStandards> lst, string itemCode, string techCode)
        {
            return CheckQuality(sValue, search(lst, itemCode, techCode));
        }
    }
}
