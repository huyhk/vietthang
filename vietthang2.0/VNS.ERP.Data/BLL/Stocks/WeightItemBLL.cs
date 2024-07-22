using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data
{
    public class WeightItemBLL : IBusiness
    {
        const int numTransportCode = 6;
        private WeightItemDAL dal = new WeightItemDAL();
        private WeightItemDetailDAL dal1;
        private WeightItemResultDAL dal2;
        public WeightItemBLL() { }
        public ListBase<WeightItem> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<WeightItem> GetByIsReceiveForPeriod(bool isReceive, string stockCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetByIsReceiveForPeriod(isReceive, stockCode, startDate, endDate);
        }
        public ListBase<WeightItemResult> GetWeightItemResult(Guid WeightID)
        {
            return dal.GetWeightItemResult(WeightID);
        }
        public ListBase<WeightItem> GetByTransactionIDIsNull(bool isReceive, string stockCode)
        {
            return dal.GetByTransactionIDIsNull(isReceive, stockCode);
        }
        public ListBase<WeightItem> GetForCheckFromStockTransaction(Guid transactionID, bool isReceive, string stockCode)
        {
            return dal.GetForCheckFromStockTransaction(transactionID, isReceive, stockCode);
        }
        public ListBase<WeightItem> GetByIsReceive(bool isReceive, string stockCode)
        {
            return dal.GetByIsReceive(isReceive, stockCode);
        }
        public ListBase<WeightItem> GetPKWithDetails(string _StockCode, string _WeightCode)
        {
            return dal.GetPKWithDetails(_StockCode, _WeightCode);
        }
        public int Insert(WeightItem t)
        {
            int iError, i, count;

            bool alreadyOpen = false;

            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            dal1 = new WeightItemDetailDAL(dal.DBHelper);
            dal2 = new WeightItemResultDAL(dal.DBHelper);
            //dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                for (i = 0; i < numTransportCode; i++)
                {
                    if (t.lstWeightItemDetail[i] != null)
                    {
                        foreach (WeightItemDetail wid in t.lstWeightItemDetail[i])
                        {
                            if (iError == 0)
                            {
                                //wid.BeginEdit();
                                wid.WeightID = t.WeightID;
                                wid.StockCode = t.StockCode;
                                //wid.EndEdit();
                                if (wid.Weight + wid.Quantity != 0) iError = dal1.Insert(wid);
                            }
                            if (iError != 0) break;
                        }
                    }

                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                foreach (WeightItemResult wir in t.lstWeightItemResult)
                {
                    if (iError == 0 && wir.Weight > 0)
                    {
                        wir.WeightID = t.WeightID;
                        iError = dal2.Insert(wir);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                for (i = 0; i < numTransportCode; i++)
                {
                    if (t.lstWeightItemDetail[i] != null)
                    {
                        count = t.lstWeightItemDetail[i].Count;
                        for (int j = 0; j < count; j++)
                        {
                            t.lstWeightItemDetail[i].ResetItem(j);
                            if (t.lstWeightItemDetail[i][j].Quantity + t.lstWeightItemDetail[i][j].Weight == 0)
                            {

                                t.lstWeightItemDetail[i].RemoveAt(j);
                                j -= 1;
                                count -= 1;
                            }
                        }
                    }
                }
            }
            if (iError != 0) dal.Rollback();
            else dal.Commit();
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(WeightItem t)
        {
            int iError, i, count;

            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            dal1 = new WeightItemDetailDAL(dal.DBHelper);
            dal2 = new WeightItemResultDAL(dal.DBHelper);
            //dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal1.DeleteByWeightID(t.WeightID);
            }

            if (iError == 0)
            {
                for (i = 0; i < numTransportCode; i++)
                {
                    if (t.lstWeightItemDetail[i] != null)
                    {
                        foreach (WeightItemDetail wid in t.lstWeightItemDetail[i])
                        {
                            if (iError == 0)
                            {
                                //wid.BeginEdit();
                                wid.WeightID = t.WeightID;
                                wid.StockCode = t.StockCode;
                                //wid.EndEdit();
                                if (wid.Weight + wid.Quantity != 0) iError = dal1.Insert(wid);
                            }
                            if (iError != 0) break;
                        }
                    }

                    if (iError != 0) break;
                }
            }

            if (iError == 0)
            {
                iError = dal2.DeleteByWeightID(t.WeightID);
            }

            if (iError == 0)
            {
                foreach (WeightItemResult wir in t.lstWeightItemResult)
                {
                    if (iError == 0 && wir.Weight > 0)
                    {
                        wir.WeightID = t.WeightID;
                        iError = dal2.Insert(wir);
                    }
                    if (iError != 0) break;
                }
            }

            if (iError == 0)
            {
                for (i = 0; i < numTransportCode; i++)
                {
                    if (t.lstWeightItemDetail[i] != null)
                    {
                        count = t.lstWeightItemDetail[i].Count;
                        for (int j = 0; j < count; j++)
                        {
                            t.lstWeightItemDetail[i].ResetItem(j);
                            if (t.lstWeightItemDetail[i][j].Quantity + t.lstWeightItemDetail[i][j].Weight == 0)
                            {
                                t.lstWeightItemDetail[i].RemoveAt(j);

                                j -= 1;
                                count -= 1;
                            }
                        }
                    }
                }
            }
            if (iError != 0) dal.Rollback();
            else dal.Commit();
            //dal.Close();

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Delete(WeightItem t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal2 = new WeightItemResultDAL(dal.DBHelper);
            dal.Open();
            dal.BeginTransaction();

            iError = dal2.DeleteByWeightID(t.WeightID);
            if (iError == 0)
            {
                iError = dal.Delete(t);
            }
            if (iError != 0) dal.Rollback();
            else dal.Commit();
            dal.Close();

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as WeightItem);
        }
        public int Update(object obj)
        {
            return this.Update(obj as WeightItem);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as WeightItem);
        }
        #endregion
    }
}
