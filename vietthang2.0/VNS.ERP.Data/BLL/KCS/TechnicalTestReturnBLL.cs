using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data.KCS
{
    public class TechnicalTestReturnBLL : IBusiness
    {
        TechnicalTestReturnDAL dal = new TechnicalTestReturnDAL();
        TechnicalTestReturnDetailDAL dalDetail = new TechnicalTestReturnDetailDAL();
        public TechnicalTestReturnBLL() { }
        public ListBase<TechnicalTestReturn> GetAll()
        {
            return dal.GetObjectAll();
        }
        //public TechnicalTestReturn GetByReturnID(Guid returnID)
        //{
        //    return dal.GetByReturnID(returnID);
        //}
        public int UpdateIsReceived(TechnicalTestReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();
            iError= dal.UpdateIsReceived(t);
            if (iError == 0 && t.IsReceived) iError = dal.AppliedProductResult(t.ReturnID);
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
            }
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public ListBase<TechnicalTestReturn> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            return dal.GetForPeriod(startDate, endDate);
        }
        public ListBase<TechnicalTestReturn> GetForPeriodAndStock(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetForPeriodAndStock(startDate, endDate, stockCode);
        }
        public int CheckResultImportStatus(Guid returnID, string itemEncryptCode, string techCode, bool isProduct)
        {
            return dal.CheckResultImportStatus(returnID, itemEncryptCode, techCode, isProduct);
        }
        public int Insert(TechnicalTestReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new TechnicalTestReturnDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (TechnicalTestReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
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
        public int Update(TechnicalTestReturn t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new TechnicalTestReturnDetailDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.ReturnID);
            }
            if (iError == 0)
            {
                t.RefreshDetail();
                foreach (TechnicalTestReturnDetail detail in t.Detail)
                {
                    detail.ReturnID = t.ReturnID;
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
        public int Delete(TechnicalTestReturn t)
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
            return this.Insert(obj as TechnicalTestReturn);
        }
        public int Update(object obj)
        {
            return this.Update(obj as TechnicalTestReturn);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as TechnicalTestReturn);
        }
        #endregion
    }
}
