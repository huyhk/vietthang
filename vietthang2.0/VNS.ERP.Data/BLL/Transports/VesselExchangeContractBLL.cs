using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class VesselExchangeContractBLL : IBusiness
    {
        VesselExchangeContractDAL dal = new VesselExchangeContractDAL();
        VesselExchangeContractItemDAL dalDetail = new VesselExchangeContractItemDAL();
        public VesselExchangeContractBLL() { }
        public ListBase<VesselExchangeContract> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<VesselExchangeContract> GetByDate(DateTime fromDate, DateTime toDate)
        {
            return dal.GetByDate(fromDate, toDate);
        }
        public int Insert(VesselExchangeContract t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new VesselExchangeContractItemDAL(dal.DBHelper);
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (VesselExchangeContractItem detail in t.Detail)
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
        public int Update(VesselExchangeContract t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dalDetail = new VesselExchangeContractItemDAL(dal.DBHelper);
            dal.BeginTransaction();

            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dalDetail.Delete(t.ContractID);
            }
            if (iError == 0)
            {
                foreach (VesselExchangeContractItem detail in t.Detail)
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
        public int Delete(VesselExchangeContract t)
        {
            return dal.Delete(t);
        }

        public DataTable GetSearch(string exchangeSubjectCode)
        {
            return dal.GetSearch(exchangeSubjectCode);
        }
        public DataTable GetSearch()
        {
            return dal.GetSearch("");
        }

        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as VesselExchangeContract);
        }
        public int Update(object obj)
        {
            return this.Update(obj as VesselExchangeContract);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as VesselExchangeContract);
        }
        #endregion
    }
}
