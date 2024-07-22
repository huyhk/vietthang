using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class BocxepContractPriceBLL : IBusiness
    {
        BocxepContractPriceDAL dal = new BocxepContractPriceDAL();
        BocxepContractPriceDetailDAL dalDetail = null;
        BocxepContractPriceStockDAL dalDetailStock = null;
        public BocxepContractPriceBLL() { }
        public ListBase<BocxepContractPrice> GetAll()
        {
            return dal.GetObjectAll();
        }
        public int Insert(BocxepContractPrice t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new BocxepContractPriceDetailDAL(dal.DBHelper);
            dalDetailStock = new BocxepContractPriceStockDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (BocxepContractPriceDetail detail in t.Detail)
                {
                    detail.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BocxepContractPriceStock detailStock in t.DetailStock)
                {
                    detailStock.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dalDetailStock.Insert(detailStock);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BocxepContractPriceItem detailItem in t.DetailItem)
                {
                    detailItem.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dal.InsertPriceItem(detailItem);
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
        public int Update(BocxepContractPrice t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new BocxepContractPriceDetailDAL(dal.DBHelper);
            dalDetailStock = new BocxepContractPriceStockDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.PriceID);
            }
            if (iError == 0)
            {
                iError = dalDetailStock.Delete(t.PriceID);
            }
            if (iError == 0)
            {
                iError = dal.DeletePriceItem(t.PriceID);
            }
            if (iError == 0)
            {
                foreach (BocxepContractPriceDetail detail in t.Detail)
                {
                    detail.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BocxepContractPriceStock detailStock in t.DetailStock)
                {
                    detailStock.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dalDetailStock.Insert(detailStock);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (BocxepContractPriceItem detailItem in t.DetailItem)
                {
                    detailItem.PriceID = t.PriceID;
                    if (iError == 0)
                    {
                        iError = dal.InsertPriceItem(detailItem);
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
        public int Delete(BocxepContractPrice t)
        {
            return dal.Delete(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as BocxepContractPrice);
        }
        public int Update(object obj)
        {
            return this.Update(obj as BocxepContractPrice);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as BocxepContractPrice);
        }
        #endregion
    }
}
