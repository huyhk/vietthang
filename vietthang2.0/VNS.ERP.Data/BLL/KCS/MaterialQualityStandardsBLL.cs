using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;

namespace VNS.ERP.Data.KCS
{
    public class MaterialQualityStandardsBLL:IBusiness
   {
       MaterialQualityStandardsDAL dal = new MaterialQualityStandardsDAL();
        #region Stored procedure wrappers

        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<MaterialQualityStandards> GetAll()
        {
            return dal.GetObjectAll();
        }
        /// <summary>
        /// Gets all objects 
        /// </summary>
       public ListBase<MaterialQualityStandards> GetDynamic(string whereCondition, string orderExpression)
        {
            return dal.GetObjectDynamic(whereCondition, orderExpression);
        }
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        /// 
       public ListBase<MaterialQualityStandards> GetByItemCode(string itemCode)
        {
            return dal.GetByItemCode(itemCode);
        }
        public ListBase<MaterialQualityStandards> GetByDate(DateTime  date)
        {
            return dal.GetByDate(date);
        }
       public int Insert(MaterialQualityStandards t)
        {
            return dal.Insert(t);
        }

       public int Delete(MaterialQualityStandards t)
        {
            return dal.Delete(t);
        }

       public int Update(MaterialQualityStandards t)
        {
            return dal.Update(t);
        }
        /// <summary>
        /// Delete all rows 
        /// </summary>
        public int DeleteAll()
        {
            return dal.DeleteAll();
        }
        /// <summary>
        /// Delete rows by dynamic criteria
        /// </summary>
        public int DeleteDynamic(string whereCondidion)
        {
            return dal.DeleteDynamic(whereCondidion);
        }


        #endregion


        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as MaterialQualityStandards);
        }

        public int Update(object obj)
        {
            return this.Update(obj as MaterialQualityStandards);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as MaterialQualityStandards);
        }

        #endregion

        private static Boolean CheckQuality(string sValue, MaterialQualityStandards obj)
        {
            if (obj == null) return true;
            decimal dValue = 0;
            decimal dStandard = 0;
            if (!decimal.TryParse(sValue,out dValue)) return true;
            if (!decimal.TryParse(obj.ValueString,out dStandard)) return true;
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
        private static  MaterialQualityStandards search(ListBase<MaterialQualityStandards> lst,string itemCode,string techCode)
        {
            foreach (MaterialQualityStandards obj in lst)
            {
                if (obj.ItemCode == itemCode && obj.TechCode == techCode)
                    return obj;
            }
            return null;
        }
        public static Boolean CheckQuality(string sValue, ListBase<MaterialQualityStandards> lst, string itemCode, string techCode)
        {
            return CheckQuality(sValue, search(lst, itemCode, techCode));
        }
    }
}
