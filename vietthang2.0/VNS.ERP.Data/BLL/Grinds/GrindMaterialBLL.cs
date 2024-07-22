using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;

namespace VNS.ERP.Data.Grinds
{
    public class GrindMaterialBLL:IBusiness
    {
        private GrindMaterialDAL dal ;
        public GrindMaterialBLL()
        { dal = new GrindMaterialDAL(); }
        public GrindMaterialBLL(VNS.Data.DAL.DBHelper dbHelper)
        { dal = new GrindMaterialDAL(dbHelper); }

        public ListBase<GrindMaterials> GetAll()
        {
            return dal.GetObjectAll();
        }

        public int Insert(GrindMaterials t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
        
            try
            {
                iError = InsertGrindMaterial(t);
               
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialBLL", "Insert(GrindMaterials t)", excp.Message);
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

        public int InsertGrindMaterial(GrindMaterials t)
        {
           int iError=0;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            iError = dal.Insert(t);
            if (iError == 0)
            {
                GrindMaterialTransactionDAL dalTran = new GrindMaterialTransactionDAL(dal.DBHelper);

                //lstDieuchinh
                foreach (GrindMaterialTransactions grindTransaction in t.LstDieuchinh)
                {
                    if (grindTransaction.Quantity != 0)
                    {
                        grindTransaction.GrindMaterialID = t.GrindMaterialID;
                        grindTransaction.IsReceived = false;
                        grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.AdjustIn;
                        iError = dalTran.Insert(grindTransaction);
                        if (iError != 0)
                            break;
                    }
                }

                //LstNhienlieu
                foreach (GrindMaterialTransactions grindTransaction in t.LstNhienlieu)
                {
                    if (grindTransaction.Quantity != 0)
                    {
                        grindTransaction.GrindMaterialID = t.GrindMaterialID;
                        grindTransaction.IsReceived = false;
                        grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.FuelIn;
                        iError = dalTran.Insert(grindTransaction);
                        if (iError != 0)
                            break;
                    }
                }
                //LstTaiche
                foreach (GrindMaterialTransactions grindTransaction in t.LstTaiche)
                {
                    if (grindTransaction.Quantity != 0)
                    {
                        grindTransaction.GrindMaterialID = t.GrindMaterialID;
                        grindTransaction.IsReceived = false;
                        grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WasteIn;
                        iError = dalTran.Insert(grindTransaction);
                        if (iError != 0)
                            break;
                    }
                }
                //LstPhepham
                foreach (GrindMaterialTransactions grindTransaction in t.LstPhepham)
                {
                    if (grindTransaction.Quantity != 0)
                    {
                        grindTransaction.GrindMaterialID = t.GrindMaterialID;
                        grindTransaction.IsReceived = true;
                        grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WasteOut;
                        iError = dalTran.Insert(grindTransaction);
                        if (iError != 0)
                            break;
                    }
                }

                //lstProductOut
                if (iError == 0)
                {
                    t.LstMaterialOut = new ListBase<GrindMaterialTransactions>();
                    t.LstMaterialOut.Add(new GrindMaterialTransactions());

                    foreach (GrindMaterialTransactions grindTransaction in t.LstMaterialOut)
                    {
                        if (t.MaterialWeight != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.ItemCode = t.GrindCode;
                            grindTransaction.IsReceived = true;
                            grindTransaction.Quantity = t.MaterialWeight;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.MaterialOut;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                //lstWrappingIn
                ItemDAL dalItem = new ItemDAL(dal.DBHelper);
                string _ItemCode = dalItem.GetItemBy_Type_UnitWeight((int)enumItemType.WrappingMaterial, dalItem.GetUnitWeight(t.GrindCode).UnitWeight);
                if (iError == 0)
                {
                    t.LstWrappingIn = new ListBase<GrindMaterialTransactions>();
                    t.LstWrappingIn.Add(new GrindMaterialTransactions());
                 

                    foreach (GrindMaterialTransactions grindTransaction in t.LstWrappingIn)
                    {
                        if (t.Wrapping != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.ItemCode = _ItemCode;
                            grindTransaction.IsReceived = false;
                            grindTransaction.Quantity = t.Wrapping;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WrappingMaterialIn;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                //lstWrappingWasteIn
                if (iError == 0)
                {
                    t.LstWrappingWasteIn = new ListBase<GrindMaterialTransactions>();
                    t.LstWrappingWasteIn.Add(new GrindMaterialTransactions());
                    foreach (GrindMaterialTransactions grindTransaction in t.LstWrappingWasteIn)
                    {
                        if (t.WrappingWaste != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.ItemCode = _ItemCode;
                            grindTransaction.Quantity = t.WrappingWaste;
                            grindTransaction.IsReceived = false;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WrappingMaterialWasteIn;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                }
                //lstMaterialIn
                if (iError == 0)
                {
                    ListBase<MaterialFormularDetail> lstDetail = (new MaterialFormularDetailDAL(dal.DBHelper)).GetMaterialCodeGrindMaterial(t.GrindCode, t.FormulaCode, t.Nap);
                    t.LstMaterialIn = new ListBase<GrindMaterialTransactions>();
                    foreach (MaterialFormularDetail fd in lstDetail)
                    {
                        GrindMaterialTransactions mt = new GrindMaterialTransactions();
                        mt.ItemCode = fd.MaterialCode;
                        mt.Quantity = fd.Weight;
                        t.LstMaterialIn.Add(mt);
                    }

                    foreach (GrindMaterialTransactions trans in t.LstMaterialIn)
                    {
                        if (trans.Quantity != 0)
                        {
                            trans.GrindMaterialID = t.GrindMaterialID;
                            trans.IsReceived = false;
                            trans.TransactionType = (int)enumGrindMaterialTransactionType.MaterialIn;
                            iError = dalTran.Insert(trans);
                            if (iError != 0)
                                break;
                        }
                    }
                }
            }
            return iError;
        }

        public int Update(GrindMaterials t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                t.UserUpdated = Contexts.CurrentUser.LoginName;
                iError = dal.Update(t);
                GrindMaterialTransactionDAL dalTran = new GrindMaterialTransactionDAL(dal.DBHelper);
                if (iError == 0)
                    iError = dalTran.Delete(t.GrindMaterialID);
                if (iError == 0)
                {
                    //lstDieuchinh
                    foreach (GrindMaterialTransactions grindTransaction in t.LstDieuchinh)
                    {
                        if (grindTransaction.Quantity != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.IsReceived = false;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.AdjustIn;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                    //LstNhienlieu
                    foreach (GrindMaterialTransactions grindTransaction in t.LstNhienlieu)
                    {
                        if (grindTransaction.Quantity != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.IsReceived = false;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.FuelIn;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                    //LstTaiche
                    foreach (GrindMaterialTransactions grindTransaction in t.LstTaiche)
                    {
                        if (grindTransaction.Quantity != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.IsReceived = false;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WasteIn;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }
                    //LstPhepham
                    foreach (GrindMaterialTransactions grindTransaction in t.LstPhepham)
                    {
                        if (grindTransaction.Quantity != 0)
                        {
                            grindTransaction.GrindMaterialID = t.GrindMaterialID;
                            grindTransaction.IsReceived = true;
                            grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WasteOut;
                            iError = dalTran.Insert(grindTransaction);
                            if (iError != 0)
                                break;
                        }
                    }

                    //lstProductOut
                    if (iError == 0)
                    {
                        t.LstMaterialOut = new ListBase<GrindMaterialTransactions>();
                        t.LstMaterialOut.Add(new GrindMaterialTransactions());

                        foreach (GrindMaterialTransactions grindTransaction in t.LstMaterialOut)
                        {
                            if (t.MaterialWeight != 0)
                            {
                                grindTransaction.GrindMaterialID = t.GrindMaterialID;
                                grindTransaction.ItemCode = t.GrindCode;
                                grindTransaction.IsReceived = true;
                                grindTransaction.Quantity = t.MaterialWeight;
                                grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.MaterialOut;
                                iError = dalTran.Insert(grindTransaction);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingIn
                    ItemDAL dalItem = new ItemDAL(dal.DBHelper);
                    string _ItemCode = dalItem.GetItemBy_Type_UnitWeight((int)enumItemType.WrappingMaterial, dalItem.GetUnitWeight(t.GrindCode).UnitWeight);

                    if (iError == 0)
                    {
                        t.LstWrappingIn = new ListBase<GrindMaterialTransactions>();
                        t.LstWrappingIn.Add(new GrindMaterialTransactions());

                        foreach (GrindMaterialTransactions grindTransaction in t.LstWrappingIn)
                        {
                            if (t.Wrapping != 0)
                            {
                                grindTransaction.GrindMaterialID = t.GrindMaterialID;
                                grindTransaction.ItemCode = _ItemCode;
                                grindTransaction.IsReceived = false;
                                grindTransaction.Quantity = t.Wrapping;
                                grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WrappingMaterialIn;
                                iError = dalTran.Insert(grindTransaction);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingWasteIn
                    if (iError == 0)
                    {
                        t.LstWrappingWasteIn = new ListBase<GrindMaterialTransactions>();
                        t.LstWrappingWasteIn.Add(new GrindMaterialTransactions());
                        foreach (GrindMaterialTransactions grindTransaction in t.LstWrappingWasteIn)
                        {
                            if (t.WrappingWaste != 0)
                            {
                                grindTransaction.GrindMaterialID = t.GrindMaterialID;
                                grindTransaction.ItemCode = _ItemCode;
                                grindTransaction.Quantity = t.WrappingWaste;
                                grindTransaction.IsReceived = false;
                                grindTransaction.TransactionType = (int)enumGrindMaterialTransactionType.WrappingMaterialWasteIn;
                                iError = dalTran.Insert(grindTransaction);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstMaterialIn
                    if (iError == 0)
                    {
                        ListBase<MaterialFormularDetail> lstDetail = (new MaterialFormularDetailDAL(dal.DBHelper)).GetMaterialCodeGrindMaterial(t.GrindCode, t.FormulaCode, t.Nap);
                        t.LstMaterialIn = new ListBase<GrindMaterialTransactions>();
                        foreach (MaterialFormularDetail fd in lstDetail)
                        {
                            GrindMaterialTransactions mt = new GrindMaterialTransactions();
                            mt.ItemCode = fd.MaterialCode;
                            mt.Quantity = fd.Weight;
                            t.LstMaterialIn.Add(mt);
                        }
                        foreach (GrindMaterialTransactions trans in t.LstMaterialIn)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.GrindMaterialID = t.GrindMaterialID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumGrindMaterialTransactionType.MaterialIn;
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
                Write2Log.WriteLogs("GrindMaterialBLL", "Insert(GrindMaterials t)", excp.Message);
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

        public int UpdateStatusGrindMaterialShift(Guid _GrindMaterialShiftID, int _Status)
        {
            return dal.UpdateStatusGrindMaterialShift(_GrindMaterialShiftID, _Status, Contexts.CurrentUser.LoginName);
        }

        public int Delete(GrindMaterials t)
        {
            return Delete(t.GrindMaterialID);
        }
        public int Delete(Guid _GrindMaterialID)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Delete(_GrindMaterialID, Contexts.CurrentUser.LoginName);
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("GrindMaterialBLL", "Delete(Guid _GrindMaterialID)", excp.Message);
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
        public void GetGrindMaterialDetail(GrindMaterials grind)
        {
            dal.GetGrindMaterialDetail(grind);
        }
       
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as GrindMaterials);
        }

        public int Update(object obj)
        {
            return this.Update(obj as GrindMaterials);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as GrindMaterials);
        }

        #endregion
    }
}