using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufacturePlanBLL:IBusiness
    {
        private ManufacturePlanDAL dal = new ManufacturePlanDAL();
        private ManufacturePlanDetailDAL dal1;
        public ManufacturePlanBLL()
        { }
        public ListBase<ManufacturePlan> GetAll()
        {
            return dal.GetObjectAll();
        }
        public DataTable GetDetailMaterial(Guid manufacturePlanID, DateTime planDate)
        {
            return dal.GetDetailMaterial(manufacturePlanID,planDate);
        }
        public int Insert(ManufacturePlan t)
        {
            int iError=0;
            bool alreadyOpen = false;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new ManufacturePlanDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    foreach (ManufacturePlanDetail ManuDetail in t.Details)
                    {
                        ManuDetail.ManufacturePlanID = t.ManufacturePlanID;
                        if (iError == 0)
                        {
                            if (ManuDetail.PlanWeight > 0)
                            {
                                iError = dal1.Insert(ManuDetail);
                            }
                        }
                        else
                            break;
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanBLL", "Insert(ManufacturePlan t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                   dal.Commit();
               else
                   dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            if (iError==0)
                try
                { this.UpdateMTS(t.ManufacturePlanID); }
                catch { }
            return iError;

        }
        public int Update(ManufacturePlan t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new ManufacturePlanDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Update(t);
                if (iError == 0)
                {
                    iError= dal1.Delete(t.ManufacturePlanID);
                    if (iError == 0)
                    {
                        foreach (ManufacturePlanDetail ManuDetail in t.Details)
                        {
                            ManuDetail.ManufacturePlanID = t.ManufacturePlanID;
                            if (iError == 0)
                            {
                                if (ManuDetail.PlanWeight > 0)
                                {
                                    iError = dal1.Insert(ManuDetail);
                                }
                            }
                            else
                                break;
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufacturePlanBLL", "Update(ManufacturePlan t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                if (!alreadyOpen)
                    dal.Close();
            }
            if (iError == 0)
                try
                { this.UpdateMTS(t.ManufacturePlanID); }
                catch { }
            return iError;
        }

        public int Delete(ManufacturePlan t)
        {
            int iError = dal.Delete(t);
            if (iError == 0)
                try
                { this.UpdateMTS(t.ManufacturePlanID); }
                catch { }
            return iError;
        }
        public ListBase<ManufacturePlan> GetAllManufacturePlanByStockCode(string _StockCode)
        {
            return dal.GetAllManufacturePlanByStockCode(_StockCode);
        }
        public ListBase<ManufacturePlan> GetManufacturePlanByStockCode(string _StockCode)
        {
            return dal.GetManufacturePlanByStockCode(_StockCode);
        }
        public ListBase<ManufacturePlanDetail> GetManufacturePlanDetailByID(Guid _ManufacturePlanID)
        {
            dal1 = new ManufacturePlanDetailDAL(dal.DBHelper);
            return dal1.GetManufacturePlanDetailByID(_ManufacturePlanID);
        }
        /// <summary>
        /// Get List Object By Time and Stock.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="stockCode"></param>
        /// <returns></returns>
        public ListBase<ManufacturePlan> GetListObjectByTime(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetListObjectByTime(startDate, endDate, stockCode);
        }


        public DataTable GetReportForItemCode(string planNo)
        {
            dal1 = new ManufacturePlanDetailDAL(dal.DBHelper);
            return dal1.GetReportForItemCode(planNo);
        }

        public DataTable GetReportForSizeCode(string planNo)
        {
            dal1 = new ManufacturePlanDetailDAL(dal.DBHelper);
            return dal1.GetReportForSizeCode(planNo);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ManufacturePlan);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ManufacturePlan);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ManufacturePlan);
        }

        #endregion

        public int UpdateMTS(Guid planID)
        { return new MTSDAL(this.dal.DBHelper).ManufacturePlan(planID); }
    }
}
