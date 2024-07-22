using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class ExchangeResultBLL : IBusiness
    {
        private ExchangeResultDAL dal = new ExchangeResultDAL();

        public int Insert(ExchangeResult t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (ExchangeResultDetail detail in t.ListExchangeResultDetail)
                {
                    detail.ResultID = t.ResultID;
                    if (iError == 0)
                    {
                        iError = dal.InsertDetail(detail);
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

        public int Update(ExchangeResult t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal.DeleteDetail(t.ResultID);
            }
            if (iError == 0)
            {
                foreach (ExchangeResultDetail detail in t.ListExchangeResultDetail)
                {
                    detail.ResultID = t.ResultID;
                    if (iError == 0)
                    {
                        iError = dal.InsertDetail(detail);
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
        public int Delete(ExchangeResult t)
        {
            return dal.Delete(t);
        }

        public ListBase<ExchangeResult> GetByDate(DateTime fromDate, DateTime toDate)
        {
            return GetFromDataSet(dal.GetDSByDate(fromDate, toDate));
        }
        private ListBase<ExchangeResult> GetFromDataSet(DataSet ds)
        {
            ListBase<ExchangeResult> lstReturn = new ListBase<ExchangeResult>();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["ResultID"], ds.Tables[1].Columns["ResultID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ExchangeResult t = new ExchangeResult();
                t.LoadFromDataRow(dr);
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    ExchangeResultDetail tDetail = new ExchangeResultDetail();
                    tDetail.FromDataRow(dr1);
                    t.ListExchangeResultDetail.Add(tDetail);
                }
                lstReturn.Add(t);
            }
            return lstReturn;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as ExchangeResult);
        }
        public int Update(object obj)
        {
            return this.Update(obj as ExchangeResult);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as ExchangeResult);
        }
        #endregion
    }
}
