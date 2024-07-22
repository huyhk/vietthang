using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionBLL : IBusiness
    {
        ProductTestTransactionDAL dal = new ProductTestTransactionDAL();
        ProductTestTransactionDetailDAL detailDAL = null;
        ProductTestTransactionRequestDAL requestDAL = null;
        ProductTestTransactionResultDAL resultDAL = null;
        public ProductTestTransactionBLL() { }
        public ListBase<ProductTestTransaction> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<ProductTestTransaction> GetByDateAndStockCode(string stockCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetByDateAndStockCode(stockCode, startDate, endDate);
        }
        private void RefreshDetail(ProductTestTransaction t)
        {
            t.Detail.Clear();
            foreach (DataRow dr in t.TableDetail.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string result = dr["Result"].ToString();
                bool isChecked = Convert.ToBoolean(dr["IsChecked"]);
                string techCode = dr["TechCode"].ToString();
                ProductTestTransactionDetail detail = t.Detail.Search("ItemEncryptCode", itemEncryptCode);
                if (detail == null)
                {
                    detail = new ProductTestTransactionDetail();
                    detail.ProductCode = dr["ProductCode"].ToString();
                    detail.SizeCode = dr["SizeCode"].ToString();
                    detail.FormulaCode = dr["FormulaCode"].ToString();
                    detail.NgayCodeBao = (DateTime)dr["NgayCodeBao"];
                    detail.Lot = dr["Lot"].ToString();
                    detail.ItemEncryptCode = itemEncryptCode;

                    if (isChecked)
                    {
                        ProductTestTransactionRequest requestDetail = new ProductTestTransactionRequest();
                        requestDetail.ItemEncryptCode = itemEncryptCode;
                        requestDetail.TechCode = techCode;
                        detail.RequestDetail.Add(requestDetail);
                    }
                    if (result != string.Empty)
                    {
                        ProductTestTransactionResult resultDetail = new ProductTestTransactionResult();
                        resultDetail.ItemEncryptCode = itemEncryptCode;
                        resultDetail.TechCode = techCode;
                        resultDetail.Result = result;
                        detail.ResultDetail.Add(resultDetail);
                    }
                    t.Detail.Add(detail);
                }
                else
                {
                    if (isChecked)
                    {
                        ProductTestTransactionRequest requestDetail = new ProductTestTransactionRequest();
                        requestDetail.ItemEncryptCode = itemEncryptCode;
                        requestDetail.TechCode = techCode;
                        detail.RequestDetail.Add(requestDetail);
                    }
                    if (result != string.Empty)
                    {
                        ProductTestTransactionResult resultDetail = new ProductTestTransactionResult();
                        resultDetail.ItemEncryptCode = itemEncryptCode;
                        resultDetail.TechCode = techCode;
                        resultDetail.Result = result;
                        detail.ResultDetail.Add(resultDetail);
                    }
                }
            }
        }
        public int Insert(ProductTestTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            detailDAL = new ProductTestTransactionDetailDAL(dal.DBHelper);
            requestDAL = new ProductTestTransactionRequestDAL(dal.DBHelper);
            resultDAL = new ProductTestTransactionResultDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Insert(t);
            if (iError == 0)
            {
                this.RefreshDetail(t);
                foreach (ProductTestTransactionDetail detail in t.Detail)
                {
                    detail.TestTransactionID = t.TestTransactionID;
                    if (iError == 0)
                    {
                        iError = detailDAL.Insert(detail);
                        if (iError == 0)
                        {
                            foreach (ProductTestTransactionRequest requestDetail in detail.RequestDetail)
                            {
                                if (iError == 0)
                                {
                                    iError = requestDAL.Insert(requestDetail);
                                }
                                if (iError != 0) break;
                            }
                        }
                        if (iError == 0)
                        {
                            foreach (ProductTestTransactionResult resultDetail in detail.ResultDetail)
                            {
                                if (iError == 0)
                                {
                                    iError = resultDAL.Insert(resultDetail);
                                }
                                if (iError != 0) break;
                            }
                        }
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(ProductTestTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            detailDAL = new ProductTestTransactionDetailDAL(dal.DBHelper);
            requestDAL = new ProductTestTransactionRequestDAL(dal.DBHelper);
            resultDAL = new ProductTestTransactionResultDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            
            if (iError == 0)
            {
                iError = detailDAL.Delete(t.TestTransactionID);
            }
            if (iError == 0)
            {
                this.RefreshDetail(t);
                foreach (ProductTestTransactionDetail detail in t.Detail)
                {
                    detail.TestTransactionID = t.TestTransactionID;
                    if (iError == 0)
                    {
                        iError = detailDAL.Insert(detail);
                        if (iError == 0)
                        {
                            foreach (ProductTestTransactionRequest requestDetail in detail.RequestDetail)
                            {
                                if (iError == 0)
                                {
                                    iError = requestDAL.Insert(requestDetail);
                                }
                                if (iError != 0) break;
                            }
                        }
                        if (iError == 0)
                        {
                            foreach (ProductTestTransactionResult resultDetail in detail.ResultDetail)
                            {
                                if (iError == 0)
                                {
                                    iError = resultDAL.Insert(resultDetail);
                                }
                                if (iError != 0) break;
                            }
                        }
                    }
                    if (iError != 0) break;
                }
            }
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(ProductTestTransaction t)
        {
            dal.Open();
            dal.BeginTransaction();
            int iError = dal.Delete(t);
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ProductTestTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductTestTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductTestTransaction);
        }
        #endregion
    }
}
