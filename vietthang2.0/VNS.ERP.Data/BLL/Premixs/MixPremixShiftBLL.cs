
using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using VNS.ERP.Data.Manufactures;
namespace VNS.ERP.Data.Premixs
{
    public class MixPremixShiftBLL : IBusiness
    {
        private MixPremixShiftDAL dal = new MixPremixShiftDAL();
        private MixPremixTransactionDAL dal1;

        public ListBase<MixPremixShift> GetByStock(string _stockCode)
        {
            return dal.GetByStockCode(_stockCode);
        }
        public int Insert(MixPremixShift t)
        {
             t.UserCreated = Contexts.CurrentUser.LoginName;
             return dal.Insert(t);
        }

        public int Delete(MixPremixShift t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                if (t.Status == 0)
                {
                    iError = dal.Delete(t.MixPremixShiftID);
                }
                else
                {
                    StockTransactionDAL dalTransaction = new StockTransactionDAL(dal.DBHelper);
                    iError = dalTransaction.TestExitsStockTransactionByGenID_Status(t.MixPremixShiftID, 0);
                    if (iError == 1)
                    {
                        iError = -3;
                    }
                    else
                    {
                        //delete trans
                        iError = dalTransaction.DeleteByGenID(t.MixPremixShiftID);
                        if (iError == 0)
                        {
                            iError = dal.Delete(t.MixPremixShiftID);
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixShiftBLL", "Delete(MixPremixShifts t)", excp.Message);
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
        public ListBase<MixPremixShift> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetObjectByTimeStockCode(startDate, endDate, stockCode);
        }
     
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as MixPremixShift);
        }

        public int Update(object obj)
        {
            return this.Update(obj as MixPremixShift);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as MixPremixShift);
        }

        #endregion

        #region WS

        public MixPremixShift GetPremix(string searchString)
        {
            MixPremixShift obj = null;

            try
            {
                ListBase<ManufactureShift> lstMS = new ManufactureShiftBLL().GetHeaderByProductCode(searchString);

                if (lstMS != null)
                {
                    string codePremix = lstMS[0].ObjManufacture.CodePremix;
                    int icodePremix = Convert.ToInt32(lstMS[0].ObjManufacture.CodePremix.Substring(13, 4));
                    ListBase<MixPremixShift> lstMPS = dal.GetByCodePremix(codePremix.Substring(0, 13));

                    foreach (MixPremixShift mps in lstMPS)
                    {
                        foreach (MixPremix mp in mps.LstMixPremix)
                        {
                            int i = Convert.ToInt32(mp.PremixWrappingCode.Substring(13, 4));
                            int ii = Convert.ToInt32(mp.PremixWrappingCode.Substring(18, 4));

                            if (icodePremix >= i && icodePremix <= ii)
                            {
                                mps.ObjMixPremix = mp;
                                mps.LstMixPremix = null;

                                mp.PremixWrappingCode = codePremix;
                                new MixPremixDAL().GetMaterialIn(mp);
                                ListBase<Item> lstItem = new ItemBLL().GetAll();

                                foreach (MixPremixTransaction mpt in mp.LstMaterialIn)
                                {
                                    mpt.Quantity = mpt.Quantity / (ii - i + 1);
                                    Item item = lstItem.Search("ItemCode", mpt.ItemCode);
                                    if (item != null)
                                        mpt.ItemName = item.ItemName;
                                }




                                obj = mps;
                                return obj;
                            }
                        }
                    }
                }
            }
            catch { }

            return obj;
        }

        #endregion
    }
}
