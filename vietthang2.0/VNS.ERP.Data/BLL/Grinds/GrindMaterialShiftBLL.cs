using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialShiftBLL:IBusiness
    {
        private GrindMaterialShiftDAL dal = new GrindMaterialShiftDAL();
        private GrindMaterialTransactionDAL dal1;

        public ListBase<GrindMaterialShift> GetByStock(string _stockCode)
        {
            return dal.GetByStockCode(_stockCode);
        }
        public int Insert(GrindMaterialShift t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            return dal.Insert(t);
        }
        public int Update(GrindMaterialShift t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            return dal.Update(t);
        }
        public int Delete(GrindMaterialShift t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                if (t.Status == 0)
                {
                    iError = dal.Delete(t.GrindMaterialShiftID);
                }
                else
                {
                    StockTransactionDAL dalTransaction = new StockTransactionDAL(dal.DBHelper);
                    iError = dalTransaction.TestExitsStockTransactionByGenID_Status(t.GrindMaterialShiftID, 0);
                    if (iError == 1)
                    {
                        iError = -3;
                    }
                    else
                    {
                        //delete trans
                        iError = dalTransaction.DeleteByGenID(t.GrindMaterialShiftID);
                        if (iError == 0)
                        {
                            iError = dal.Delete(t.GrindMaterialShiftID);
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureShiftBLL", "Delete(ManufactureShifts t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dal.Commit();
                else
                    dal.Rollback();
                dal.Close();
            }
            return iError;
        }
        public ListBase<GrindMaterialShift> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetObjectByTimeStockCode(startDate, endDate, stockCode);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as GrindMaterialShift);
        }

        public int Update(object obj)
        {
            return this.Update(obj as GrindMaterialShift);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as GrindMaterialShift);
        }

        #endregion
    }
}
