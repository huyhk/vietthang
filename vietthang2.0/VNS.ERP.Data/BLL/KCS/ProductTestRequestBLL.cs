using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestRequestBLL : IBusiness
    {
        ProductTestRequestDAL dal = new ProductTestRequestDAL();
        ProductTestRequestDetailDAL dalDetail = new ProductTestRequestDetailDAL();
        public ProductTestRequestBLL() { }
        public ListBase<ProductTestRequest> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ProductTestRequest GetByRequestID(Guid requestID)
        {
            return dal.GetByRequestID(requestID);
        }
        public ListBase<ProductTestRequest> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            return dal.GetForPeriod(startDate, endDate);
        }
        public int UpdateIsReceived(ProductTestRequest t)
        {
            dal.Open();
            dal.BeginTransaction();
            int iError = dal.UpdateIsReceived(t);
            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal.Close();
            return iError;
        }
        public int Insert(ProductTestRequest t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new ProductTestRequestDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Insert(t);
            if (iError == 0)
            {
                this.RefreshDetail(t);
                foreach (ProductTestRequestDetail detail in t.Detail)
                {
                    detail.RequestID = t.RequestID;
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
        public int Update(ProductTestRequest t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new ProductTestRequestDetailDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.RequestID);
            }
            if (iError == 0)
            {
                this.RefreshDetail(t);
                foreach (ProductTestRequestDetail detail in t.Detail)
                {
                    detail.RequestID = t.RequestID;
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
        private void RefreshDetail(ProductTestRequest t)
        {
            t.Detail.Clear();
            foreach (DataRow dr in t.DetailTable.Rows)
            {
                string itemEncryptCode = dr["ItemEncryptCode"].ToString();
                string techCode = dr["TechCode"].ToString();
                string subjectCode = dr["SubjectCode"].ToString();

                ProductTestRequestDetail detail = new ProductTestRequestDetail();
                detail.ItemEncryptCode = itemEncryptCode;
                detail.TechCode = techCode;
                detail.SubjectCode = subjectCode;

                t.Detail.Add(detail);
            }
        }
        public int Delete(ProductTestRequest t)
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
            return this.Insert(obj as ProductTestRequest);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ProductTestRequest);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ProductTestRequest);
        }
        #endregion
    }
}
