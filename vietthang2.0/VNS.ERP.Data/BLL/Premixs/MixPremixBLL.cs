     
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using VNS.ERP.Data.Manufactures;

namespace VNS.ERP.Data.Premixs
{
    public class MixPremixBLL:IBusiness
    {
        private MixPremixDAL dal ;
        public MixPremixBLL()
        { dal = new MixPremixDAL(); }
        public MixPremixBLL(VNS.Data.DAL.DBHelper dbHelper)
        { dal = new MixPremixDAL(dbHelper); }

        public ListBase<MixPremix> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(MixPremix t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
        
            try
            {
                iError = InsertMixPremix(t);
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixBLL", "Insert(MixPremix t)", excp.Message);
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

        public int InsertMixPremix(MixPremix t)
        {
           int iError=0;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            iError = dal.Insert(t);
            if (iError == 0)
            {
                MixPremixTransactionDAL dalTran = new MixPremixTransactionDAL(dal.DBHelper);

                //lstDieuchinh
                foreach (MixPremixTransaction mixTransaction in t.LstDieuchinh)
                {
                    if (mixTransaction.Quantity != 0)
                    {
                        mixTransaction.MixPremixID = t.MixPremixID;
                        mixTransaction.IsReceived = false;
                        mixTransaction.TransactionType = (int)enumMixPremixTransactionType.AdjustIn;
                        iError = dalTran.Insert(mixTransaction);
                        if (iError != 0)
                            break;
                    }
                }

                //lstProductOut
                if (iError == 0)
                {
                    t.LstPremixOut = new ListBase<MixPremixTransaction>();
                    t.LstPremixOut.Add(new MixPremixTransaction());

                    foreach (MixPremixTransaction mixTransaction in t.LstPremixOut)
                    {
                        if (t.PremixWeight != 0)
                        {
                            mixTransaction.MixPremixID = t.MixPremixID;
                            mixTransaction.ItemCode = t.PremixCode;
                            mixTransaction.IsReceived = true;
                            mixTransaction.Quantity = t.PremixWeight;
                            mixTransaction.TransactionType = (int)enumMixPremixTransactionType.PremixOut;
                            iError = dalTran.Insert(mixTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }

                //lstWrappingIn
                PremixWrappingDAL dalWrap = new PremixWrappingDAL(dal.DBHelper);
                string _ItemCode = dalWrap.GetItemCode(t.PremixCode);
                if (iError == 0)
                {
                    t.LstWrappingIn = new ListBase<MixPremixTransaction>();
                    t.LstWrappingIn.Add(new MixPremixTransaction());
                    foreach (MixPremixTransaction mixTransaction in t.LstWrappingIn)
                    {
                        if (t.Wrapping != 0)
                        {
                            mixTransaction.MixPremixID = t.MixPremixID;
                            mixTransaction.ItemCode = _ItemCode;
                            mixTransaction.IsReceived = false;
                            mixTransaction.Quantity = t.Wrapping;
                            mixTransaction.TransactionType = (int)enumMixPremixTransactionType.WrappingPremixIn;
                            iError = dalTran.Insert(mixTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                //lstWrappingWasteIn
                if (iError == 0)
                {
                    t.LstWrappingWasteIn = new ListBase<MixPremixTransaction>();
                    t.LstWrappingWasteIn.Add(new MixPremixTransaction());
                    foreach (MixPremixTransaction mixTransaction in t.LstWrappingWasteIn)
                    {
                        if (t.WrappingWaste != 0)
                        {
                            mixTransaction.MixPremixID = t.MixPremixID;
                            mixTransaction.ItemCode = _ItemCode;
                            mixTransaction.Quantity = t.WrappingWaste;
                            mixTransaction.IsReceived = false;
                            mixTransaction.TransactionType = (int)enumMixPremixTransactionType.WrappingPremixWasteIn;
                            iError = dalTran.Insert(mixTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                //lstMaterialIn
                if (iError == 0)
                {
                    ListBase<PremixFormulaDetail> lstDetail = (new PremixFormulaDetailDAL(dal.DBHelper)).GetMaterialCodeMixPremix(t.FormulaCode, t.PremixCode, t.Nap);
                    t.LstMaterialIn = new ListBase<MixPremixTransaction>();
                    foreach (PremixFormulaDetail fd in lstDetail)
                    {
                        MixPremixTransaction mt = new MixPremixTransaction();
                        mt.ItemCode = fd.MaterialCode;
                        mt.Quantity = fd.Weight;
                        t.LstMaterialIn.Add(mt);
                    }
                    foreach (MixPremixTransaction trans in t.LstMaterialIn)
                    {
                        if (trans.Quantity != 0)
                        {
                            trans.MixPremixID = t.MixPremixID;
                            trans.IsReceived = false;
                            trans.TransactionType = (int)enumMixPremixTransactionType.MaterialIn;
                            iError = dalTran.Insert(trans);
                            if (iError != 0)
                                break;
                        }
                    }
                }
            }
            return iError;
        }

        public int Update(MixPremix t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
               t.UserUpdated = Contexts.CurrentUser.LoginName;
               iError = dal.Update(t);
               MixPremixTransactionDAL dalTran = new MixPremixTransactionDAL(dal.DBHelper);
               if (iError == 0)
                    iError = dalTran.Delete(t.MixPremixID);
               if (iError == 0)
               {

                   //lstDieuchinh
                   foreach (MixPremixTransaction mixTransaction in t.LstDieuchinh)
                   {
                       if (mixTransaction.Quantity != 0)
                       {
                           mixTransaction.MixPremixID = t.MixPremixID;
                           mixTransaction.IsReceived = false;
                           mixTransaction.TransactionType = (int)enumMixPremixTransactionType.AdjustIn;
                           iError = dalTran.Insert(mixTransaction);
                           if (iError != 0)
                               break;
                       }
                   }

                   //lstProductOut
                   if (iError == 0)
                   {
                       t.LstPremixOut = new ListBase<MixPremixTransaction>();
                       t.LstPremixOut.Add(new MixPremixTransaction());

                       foreach (MixPremixTransaction mixTransaction in t.LstPremixOut)
                       {
                           if (t.PremixWeight != 0)
                           {
                               mixTransaction.MixPremixID = t.MixPremixID;
                               mixTransaction.ItemCode = t.PremixCode;
                               mixTransaction.IsReceived = true;
                               mixTransaction.Quantity = t.PremixWeight;
                               mixTransaction.TransactionType = (int)enumMixPremixTransactionType.PremixOut;
                               iError = dalTran.Insert(mixTransaction);
                               if (iError != 0)
                                   break;
                           }
                       }
                   }
                   //lstWrappingIn
                   PremixWrappingDAL dalWrap = new PremixWrappingDAL(dal.DBHelper);
                   string _ItemCode = dalWrap.GetItemCode(t.PremixCode);
                   if (iError == 0)
                   {
                       t.LstWrappingIn = new ListBase<MixPremixTransaction>();
                       t.LstWrappingIn.Add(new MixPremixTransaction());
                     
                       foreach (MixPremixTransaction mixTransaction in t.LstWrappingIn)
                       {
                           if (t.Wrapping != 0)
                           {
                               mixTransaction.MixPremixID = t.MixPremixID;
                               mixTransaction.ItemCode = _ItemCode;
                               mixTransaction.IsReceived = false;
                               mixTransaction.Quantity = t.Wrapping;
                               mixTransaction.TransactionType = (int)enumMixPremixTransactionType.WrappingPremixIn;
                               iError = dalTran.Insert(mixTransaction);
                               if (iError != 0)
                                   break;
                           }
                       }
                   }
                   //lstWrappingWasteIn
                   if (iError == 0)
                   {
                       t.LstWrappingWasteIn = new ListBase<MixPremixTransaction>();
                       t.LstWrappingWasteIn.Add(new MixPremixTransaction());
                       foreach (MixPremixTransaction mixTransaction in t.LstWrappingWasteIn)
                       {
                           if (t.WrappingWaste != 0)
                           {
                               mixTransaction.MixPremixID = t.MixPremixID;
                               mixTransaction.ItemCode = _ItemCode;
                               mixTransaction.Quantity = t.WrappingWaste;
                               mixTransaction.IsReceived = false;
                               mixTransaction.TransactionType = (int)enumMixPremixTransactionType.WrappingPremixWasteIn;
                               iError = dalTran.Insert(mixTransaction);
                               if (iError != 0)
                                   break;
                           }
                       }
                   }
                   //lstMaterialIn
                   if (iError == 0)
                   {
                       ListBase<PremixFormulaDetail> lstDetail = (new PremixFormulaDetailDAL(dal.DBHelper)).GetMaterialCodeMixPremix(t.FormulaCode, t.PremixCode, t.Nap);
                       t.LstMaterialIn = new ListBase<MixPremixTransaction>();
                       foreach (PremixFormulaDetail fd in lstDetail)
                       {
                           MixPremixTransaction mt = new MixPremixTransaction();
                           mt.ItemCode = fd.MaterialCode;
                           mt.Quantity = fd.Weight;
                           t.LstMaterialIn.Add(mt);
                       }
                       foreach (MixPremixTransaction trans in t.LstMaterialIn)
                       {
                           if (trans.Quantity != 0)
                           {
                               trans.MixPremixID = t.MixPremixID;
                               trans.IsReceived = false;
                               trans.TransactionType = (int)enumMixPremixTransactionType.MaterialIn;
                               iError = dalTran.Insert(trans);
                               if (iError != 0)
                                   break;
                           }
                       }
                   }
               }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixBLL", "Insert(MixPremix t)", excp.Message);
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

        public int UpdateStatusMixPremixShift(Guid _MixPremixShiftID, int _Status)
        {
            return dal.UpdateStatusMixPremixhift(_MixPremixShiftID, _Status, Contexts.CurrentUser.LoginName);
        }

        public int Delete(MixPremix t)
        {
            return Delete(t.MixPremixID);
        }
        public int Delete(Guid _MixPremixID)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Delete(_MixPremixID, Contexts.CurrentUser.LoginName);
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MixPremixBLL", "Delete(Guid _MixPremixID)", excp.Message);
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
        public void GetMixPremixDetail(MixPremix mix)
        {
            dal.GetMixPremixDetail(mix);
        }
    #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as MixPremix);
        }

        public int Update(object obj)
        {
            return this.Update(obj as MixPremix);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as MixPremix);
        }

        #endregion

        #region WS
        //public MixPremixShift GetPremix(string searchString)
        //{
        //    MixPremixShift obj = new MixPremixShift();

        //    ListBase<ManufactureShift> lstMS = new ManufactureShiftBLL().GetHeaderByProductCode(searchString);

        //    if (lstMS != null)
        //    {
        //        ListBase<MixPremixShift> lstMPS = dal
        //    }

        //    return obj;
        //}
        #endregion
    }
}