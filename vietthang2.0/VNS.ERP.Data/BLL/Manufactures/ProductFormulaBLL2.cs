using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;


namespace VNS.ERP.Data.Manufactures
{
    public class ProductFormulaBLL2 : IBusiness
    {
        ProductFormulaDAL2 dal = new ProductFormulaDAL2();
        ProductFormulaUnActiveDAL dal1 = null;
        FormulaDetailDAL dal2 = null;
        public ProductFormulaBLL2() { }
        public ListBase<ProductFormula2> GetAll()
        {
            return dal.GetObjectAll();
            // return null;
        }
        public ListBase<ProductFormula2> GetAll4()
        {
            ListBase<ProductFormula2> lst = new ListBase<ProductFormula2>();
            DataSet ds = dal.GetAll4();
            DataRelation drDetail = ds.Relations.Add(new DataColumn[] { ds.Tables[0].Columns["FormulaCode"], ds.Tables[0].Columns["ProductCode"] },
                new DataColumn[] { ds.Tables[1].Columns["FormulaCode"], ds.Tables[1].Columns["ProductCode"] });

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ProductFormula2 pf = new ProductFormula2();
                pf.FromDataRow(row);

                foreach (DataRow rowD in row.GetChildRows(drDetail))
                {
                    FormulaDetail fd = new FormulaDetail();
                    fd.FromDataRow(rowD);
                    pf.FormulaDetails.Add(fd);
                }

                lst.Add(pf);
            }
            return lst;
        }
        public ListBase<ProductFormula2> GetByProductCode(string productCode)
        {
           return dal.GetByProductCode(productCode);
           // return null;
        }
        public ListBase<ProductFormula2> GetFormulaByProductCode(string productCode)
        {
            return dal.GetFormulaByProductCode(productCode);
        }
        public int Insert(ProductFormula2 t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            //dal.Open();
            dal.BeginTransaction();
            dal1 = new ProductFormulaUnActiveDAL(dal.DBHelper);
            dal2 = new FormulaDetailDAL(dal.DBHelper);
            //Do trong trường hợp này hoặc Insert hoặc Update, 2 phương thức này cùng trả với một mã lỗi với 2 lỗi
            //hoàn toàn khác nhau. Vì vậy phải gán lại mã lỗi để phân biệt
            //if (t.IsNewFormulaCode)
            //{
                iError = dal.Insert(t);//iError=-3 if exists FormulaCode
            //}
            //else
            //{
            //    iError = dal.Update(t);
            //    if (iError == -3) iError = -4;//iError=-3 if not exists FormulaCode
            //}
            if (iError == 0)
            {
                foreach (FormulaDetail fd in t.FormulaDetails)
                {
                    //if (iError == 0)
                    //{
                    fd.FormulaCode = t.FormulaCode;
                    fd.ProductCode = t.ProductCode;
                        if (fd.Weight != 0) iError = dal2.Insert(fd);
                        if (iError == -3) iError = -5;
                        if (iError == -4) iError = -6;
                        if (iError != 0)
                        {
                            break;
                        }
                    //}
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
            int count = t.FormulaDetails.Count;
            if (iError == 0)
            {
                for (int i = count-1; i >= 0; i--)
                {
                    if (t.FormulaDetails[i].Weight == 0)
                    {
                        t.FormulaDetails.RemoveAt(i);
                    }
                }
            }

            if (t.FormulaDetails.Count == 0)
                iError = -100;
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
        public int Update(ProductFormula2 t)
        {
            int iError = 0;
            bool alreadyOpen = false;

            int CountWeightZero = 0;

            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            //dal.Open();
            dal.BeginTransaction();
            dal1 = new ProductFormulaUnActiveDAL(dal.DBHelper);
            dal2 = new FormulaDetailDAL(dal.DBHelper);
            iError = dal.Update(t);

            if (iError == 0)
                iError = dal2.Delete(t.FormulaCode, t.ProductCode);
            if (iError == 0)
            {
                foreach (FormulaDetail fd in t.FormulaDetails)
                {
                    fd.FormulaCode = t.FormulaCode;
                    fd.ProductCode = t.ProductCode;
                    iError = dal2.Insert(fd);
                    if (iError == -3)
                    {
                        iError = -5;
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
            int count = t.FormulaDetails.Count;
            if (iError == 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    if (t.FormulaDetails[i].Weight == 0)
                    {
                        t.FormulaDetails.RemoveAt(i);
                    }
                }
            }

            if (t.FormulaDetails.Count == 0)
                iError = -100;

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
        public int Delete(ProductFormula2 t)
        {
            int iError = 0;
            dal2 = new FormulaDetailDAL();
            iError = dal2.Delete(t.FormulaCode, t.ProductCode);
            
            return iError;
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductFormula2);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductFormula2);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductFormula2);
        }
        #endregion
    }
}
