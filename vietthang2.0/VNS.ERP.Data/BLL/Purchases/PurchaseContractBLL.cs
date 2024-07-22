using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data
{
    public class PurchaseContractBLL : IBusiness
    {
        PurchaseContractDAL dal = new PurchaseContractDAL();
        PurchaseContractDetailDAL dalDetail = null;
        public PurchaseContractBLL() { }
        public ListBase<PurchaseContract> GetDynamic(string WhereCondition, string OrderByExpression)
        {
            return dal.GetObjectDynamic(WhereCondition, OrderByExpression);
        }
        public ListBase<PurchaseContract> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<PurchaseContract> GetForPeriod(DateTime startDate, DateTime endDate, Boolean isOverSea)
        {
            return dal.GetForPeriod(startDate, endDate, isOverSea);
        }
        public DataTable GetForContractNo(string vendorcode)
        {   
            DataTable dt=dal.GetForContractNo(vendorcode);
            return dt;
        }
        public DataTable GetByVendor(string vendorcode)
        {
            return dal.GetByVendor(vendorcode);
        }
        public int Insert(PurchaseContract t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new PurchaseContractDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (PurchaseContractDetail detail in t.Detail)
                {
                    detail.ContractID = t.ContractID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
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
        public int Update(PurchaseContract t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new PurchaseContractDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.ContractID);
            }
            if (iError == 0)
            {
                foreach (PurchaseContractDetail detail in t.Detail)
                {
                    detail.ContractID = t.ContractID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(detail);
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
        public int Delete(PurchaseContract t)
        {
            return dal.Delete(t);
        }

        public ListBase<PurchaseContractDetail> GetDetailByContractNo(string contractNo)
        {
            return new PurchaseContractDetailDAL().GetByContractNo(contractNo);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as PurchaseContract);
        }
        public int Update(object obj)
        {
            return this.Update(obj as PurchaseContract);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as PurchaseContract);
        }
        #endregion
    }
}
