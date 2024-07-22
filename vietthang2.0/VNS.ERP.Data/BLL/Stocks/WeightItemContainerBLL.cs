using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
namespace VNS.ERP.Data
{
    public class WeightItemContainerBLL : IBusiness
    {
        WeightItemContainerDAL dal = new WeightItemContainerDAL();
        public WeightItemContainerBLL() { }
        public ListBase<WeightItemContainer> GetAll()
        {
            return dal.GetObjectAll();
        }
        public ListBase<WeightItemContainer> GetByIsReceiveForPeriod(string stockCode, bool isReceive, DateTime startDate, DateTime endDate)
        {
            return dal.GetByIsReceiveForPeriod(stockCode, isReceive, startDate, endDate);
        }
        public ListBase<WeightItemContainer> GetByContScale(DateTime startDate, DateTime endDate, string employeeID)
        {
            return dal.GetByContScale(startDate, endDate, employeeID);
        }
        public ListBase<WeightItemContainer> GetByStockCodeAndIsReceive(Guid transactionID, string transactionTypeCode, string stockCode, bool isReceive)
        {
            return dal.GetByStockCodeAndIsReceive(transactionID, transactionTypeCode, stockCode, isReceive);
        }
        public int Insert(WeightItemContainer t)
        {
            //return dal.Insert(t); 
            int iError = dal.Insert(t);

            if (t.IsReceive)
                if (iError == 0)
                    try
                    { this.UpdateMTS(t.WeightContainerID); }
                    catch { }

            return iError;
        }
        public int Update(WeightItemContainer t)
        {
            //return dal.Update(t);


            int iError = dal.Update(t);
            if (t.IsReceive)
                if (iError == 0)
                    try
                    { this.UpdateMTS(t.WeightContainerID); }
                    catch { }

            return iError;
        }
        public int Delete(WeightItemContainer t)
        {
            //return dal.Delete(t);

            int iError = dal.Delete(t);
            if (t.IsReceive)
                if (iError == 0)
                    try
                    { this.UpdateMTS(t.WeightContainerID); }
                    catch { }

            return iError;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as WeightItemContainer);
        }
        public int Update(object obj)
        {
            return this.Update(obj as WeightItemContainer);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as WeightItemContainer);
        }
        #endregion

        public string GetNextNo(string stockCode, DateTime date, string transType)
        {
            return dal.GetNextNo(stockCode, date, transType);
        }

        public int UpdateMTS(Guid weightID)
        {
            
            return new MTSDAL(this.dal.DBHelper).WeightItemContainer(weightID);
        }
    }
}
