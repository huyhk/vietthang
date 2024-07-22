using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ProductFormulaDetailBLL : IBusiness
    {
        private FormulaDetailDAL dal = new FormulaDetailDAL();
        private ProductFormulaUnActiveDAL dal1;
        public ProductFormulaDetailBLL() { }
        public DataTable GetDetailForWeight(string _PCode, string _FCode, decimal _Weight)
        {
            return dal.GetDetailForWeight(_PCode, _FCode, _Weight);
        }
        public DataTable GetAllFormulaActive()
        {
            return dal.GetAllFormulaActive();
        }
        public int Insert(ProductFormulaDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            int count = t.FormulaDetails.Count;
            int CountWeightZero = 0;
            
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            //dal.Open();
            dal.BeginTransaction();
            dal1 = new ProductFormulaUnActiveDAL(dal.DBHelper);
            for (int i = 0; i <= count - 1; i++)
            {
                if (t.FormulaDetails[i].Weight == 0)
                {
                    //i -= 1;
                    CountWeightZero += 1;
                }
            }
            if (count == CountWeightZero)
            {
                dal.Commit();
                iError = -1;
                if (!alreadyOpen) dal.DBHelper.Close();
                return iError;
            }
            count = t.FormulaDetails.Count;
            foreach (FormulaDetail fd in t.FormulaDetails)
            {
                FormulaDetail fd1 = t.FormulaDetails.Search("MaterialCode", fd.MaterialCode);
                if (fd1 != null && fd1 != fd)
                {
                    if (fd1.Weight != 0 && fd.Weight != 0)
                    {
                        if (fd1.Weight != 0)
                        {
                            iError = -7;
                            break;
                        }
                    }
                }
            }
            if (iError == 0)
            {
                
                foreach (FormulaDetail fd in t.FormulaDetails)
                {
                    if (iError == 0)
                    {
                        fd.FormulaCode = t.FormulaCode;
                        fd.ProductCode = t.ProductCode;
                        if (fd.Weight != 0) iError = dal.Insert(fd);
                        if (iError != 0)
                            break;
                    }
                }
            }
            if (iError == 0)
            {
                if (!t.IsActive)
                {
                    ProductFormulaUnActive pFUnActive = new ProductFormulaUnActive();
                    pFUnActive.FormulaCode = t.FormulaCode;
                    pFUnActive.ProductCode = t.ProductCode;
                    iError = dal1.Insert(pFUnActive);
                }
            }
            if (iError == 0)
            {
                for (int i = 0; i <= count - 1; i++)
                {
                    t.FormulaDetails.ResetItem(i);
                    if (t.FormulaDetails[i].Weight == 0)
                    {
                        t.FormulaDetails.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
                }
            }

            if (iError != 0)
            {
                dal.Rollback();
            }
            else
            {
                dal.Commit();
            }
           // dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(ProductFormulaDetail t)
        {
            int iError = 0;
            
            int count = t.FormulaDetails.Count;
            int CountWeightZero = 0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
           // dal.Open();
            dal.BeginTransaction();
            dal1 = new ProductFormulaUnActiveDAL(dal.DBHelper);
            for (int i = 0; i <= count - 1; i++)
            {
                if (t.FormulaDetails[i].Weight == 0)
                {
                    //i -= 1;
                    CountWeightZero += 1;
                }
            }
            if (count == CountWeightZero)
            {
                dal.Commit();
                iError = -1;
                if (!alreadyOpen) dal.DBHelper.Close();
                return iError;
            }
            count = t.FormulaDetails.Count;

            foreach (FormulaDetail fd in t.FormulaDetails)
            {
                fd.FormulaCode = t.FormulaCode;
                fd.ProductCode = t.ProductCode;
                iError = dal.Delete(fd);
                break;
            }

            //if (count == 0) this.Delete(t);
            if (iError == 0)
            {
                foreach (FormulaDetail fd in t.FormulaDetails)
                {
                    FormulaDetail fd1 = t.FormulaDetails.Search("MaterialCode", fd.MaterialCode);
                    if (fd1 != null && fd1 != fd)
                    {
                        if (fd1.Weight != 0 && fd.Weight!=0)
                        {
                            iError = -7;
                        }
                    }
                    if (iError != 0) break;
                }

                //fd1 = t.FormulaDetails.Search("FormulaCode", "0002");   
                if (iError == 0)
                {
                    foreach (FormulaDetail fd in t.FormulaDetails)
                    {
                        if (iError == 0)
                        {
                            fd.FormulaCode = t.FormulaCode;
                            fd.ProductCode = t.ProductCode;
                            if (fd.Weight != 0) iError = dal.Insert(fd);

                            if (iError != 0)
                                break;
                        }
                    }
                }
                ProductFormulaUnActive pFUnActive = new ProductFormulaUnActive();
                pFUnActive.FormulaCode = t.FormulaCode;
                pFUnActive.ProductCode = t.ProductCode;
                if (iError == 0)
                {
                    iError = dal1.Delete(pFUnActive);
                }
                if (iError == 0)
                {
                    if (!t.IsActive)
                    {
                        iError = dal1.Insert(pFUnActive);
                    }
                }
                if (iError == 0)
                {
                    for (int i = 0; i <= count - 1; i++)
                    {
                        t.FormulaDetails.ResetItem(i);
                        if (t.FormulaDetails[i].Weight == 0)
                        {
                            t.FormulaDetails.RemoveAt(i);
                            i -= 1;
                            count -= 1;
                        }
                    }
                }
                 
            }
            if (iError != 0)
            {
                dal.Rollback();
            }
            else
            {
                dal.Commit();
            }
            dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(ProductFormulaDetail t)
        {
            int iError=0;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
          //  dal.Open();
            dal.BeginTransaction();
            dal1 = new ProductFormulaUnActiveDAL(dal.DBHelper);
            foreach (FormulaDetail fd in t.FormulaDetails)
            {
                fd.FormulaCode = t.FormulaCode;
                fd.ProductCode = t.ProductCode;
                iError = dal.Delete(fd);
                break;
            }
            if (iError == 0)
            {
                ProductFormulaUnActive pFUnActive = new ProductFormulaUnActive();
                pFUnActive.FormulaCode = t.FormulaCode;
                pFUnActive.ProductCode = t.ProductCode;
                iError = dal1.Delete(pFUnActive);
            }
            if (iError != 0)
            {
                dal.Rollback();
            }
            else
            {
                dal.Commit();
            }
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public DataTable GetFormulaCode(string _ProductItem)
        {
            return dal.GetFormulaCode(_ProductItem);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ProductFormulaDetail);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ProductFormulaDetail);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ProductFormulaDetail);
        }

        #endregion
    }
}
