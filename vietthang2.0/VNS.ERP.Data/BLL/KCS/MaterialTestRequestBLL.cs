using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestRequestBLL : IBusiness
    {
        MaterialTestRequestDAL dal = new MaterialTestRequestDAL();
        MaterialTestRequestDetailDAL dalDetail = null;
        public MaterialTestRequestBLL() { }
        public ListBase<MaterialTestRequest> GetAll()
        {
            return dal.GetObjectAll();
        }
        public MaterialTestRequest GetByRequestID(Guid requestID)
        {
            return dal.GetByRequestID(requestID);
        }
        public ListBase<MaterialTestRequest> GetByDate(DateTime startDate, DateTime endDate)
        {
            return dal.GetByDate(startDate, endDate);
        }
        public int UpdateIsReceived(MaterialTestRequest t)
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
        public int Insert(MaterialTestRequest t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new MaterialTestRequestDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            dal.CopyDetailTableToDetail(t);
            if (iError == 0)
            {
                foreach (MaterialTestRequestDetail mtrd in t.Detail)
                {
                    mtrd.RequestID = t.RequestID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(mtrd);
                        if (iError != 0) break;
                    }
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
        public int Update(MaterialTestRequest t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new MaterialTestRequestDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            dal.CopyDetailTableToDetail(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.RequestID);
            }
            if (iError == 0)
            {
                foreach (MaterialTestRequestDetail mtrd in t.Detail)
                {
                    mtrd.RequestID = t.RequestID;
                    if (iError == 0)
                    {
                        iError = dalDetail.Insert(mtrd);
                        if (iError != 0) break;
                    }
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
        public int Delete(MaterialTestRequest t)
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
            return this.Insert(obj as MaterialTestRequest);
        }
        public int Update(object obj)
        {
            return this.Update(obj as MaterialTestRequest);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as MaterialTestRequest);
        }
        #endregion
    }
}
