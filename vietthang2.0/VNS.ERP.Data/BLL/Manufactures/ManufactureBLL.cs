using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;

namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureBLL:IBusiness
    {
        private ManufactureDAL dal = new ManufactureDAL();
        public ManufactureBLL()
        { }
        public ListBase<Manufacture> GetAll()
        {
            return dal.GetObjectAll();
        }
   
      
        public Manufacture GetObjectsByID(Guid _ManufactureShiftID)
        {
           return dal.GetObjectsByID(_ManufactureShiftID);
        }
        /// <summary>
        /// Insert object Manufactures Into DataBase
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Insert(Manufacture t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                t.UserCreated = Contexts.CurrentUser.LoginName;
                //calculate Total WorkingTime by minute
                t.TotalWorkingTime = (int)(t.EndTime.Subtract(t.StartTime).TotalMinutes) - t.DelayTime;

                //get ItemProductCode
                //ItemProduct Item = new ItemProductBLL().GetByPSW(t.ProductCode, t.SizeCode, t.WeightCode);
                ListBase<ItemProduct> lItem = new ItemProductBLL().GetAllAll();
                ItemProduct Item = lItem.Search("ItemCode", t.ItemProductCode);
                //ItemProductDAL dalItem = new ItemProductDAL(dal.DBHelper);
                //t.ItemProductCode = Item.ItemCode;// dalItem.GetItemCode(t.ProductCode, t.SizeCode, t.WeightCode);
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    ManufactureTransactionDAL dalTran = new ManufactureTransactionDAL(dal.DBHelper);
                    //lstTaiche
                    foreach (ManufactureTransaction trans in t.LstTaiche)
                    {
                        if (trans.Quantity != 0)
                        {
                            trans.ManufactureID = t.ManufactureID;
                            trans.IsReceived = false;
                            trans.TransactionType = (int)enumManufactureTransactionType.WasteIn;
                            iError = dalTran.Insert(trans);
                            if (iError != 0)
                                break;
                        }
                    }
                    //lstNhienlieu
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstNhienlieu)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.FuelIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //LstDieuchinh
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstDieuchinh)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.AdjustIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstPhepham
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstPhepham)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = true;
                                trans.TransactionType = (int)enumManufactureTransactionType.WasteOut;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstProductOut
                    if (iError == 0)
                    {
                        t.LstProductOut = new ListBase<ManufactureTransaction>();
                        t.LstProductOut.Add(new ManufactureTransaction());

                        foreach (ManufactureTransaction trans in t.LstProductOut)
                        {
                            if (t.ProductWeight != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = t.ItemProductCode;
                                trans.IsReceived = true;
                                trans.Quantity = t.ProductWeight;
                                trans.TransactionType = (int)enumManufactureTransactionType.ProductOut;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingIn
                    ItemWrappingDAL dalItemWrapp = new ItemWrappingDAL(dal.DBHelper);
                    //string _ItemCode = dalItemWrapp.GetItemCode(t.ProductCode, t.WeightCode);
                    string _ItemCode = string.Empty;
                    if (t.ItemWrappingCode == string.Empty)
                        _ItemCode = Item.WrappingCode;
                    else
                        _ItemCode = t.ItemWrappingCode;
                    if (iError == 0)
                    {
                        t.LstWrappingIn = new ListBase<ManufactureTransaction>();
                        t.LstWrappingIn.Add(new ManufactureTransaction());
                      
                        foreach (ManufactureTransaction trans in t.LstWrappingIn)
                        {
                            if (t.Wrapping != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = _ItemCode;
                                trans.IsReceived = false;
                                trans.Quantity = t.Wrapping;
                                trans.TransactionType = (int)enumManufactureTransactionType.WrappingIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingWasteIn
                    if (iError == 0)
                    {
                        t.LstWrappingWasteIn = new ListBase<ManufactureTransaction>();
                        t.LstWrappingWasteIn.Add(new ManufactureTransaction());
                        foreach (ManufactureTransaction trans in t.LstWrappingWasteIn)
                        {
                            if (t.WrappingWaste != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = _ItemCode;
                                trans.Quantity = t.WrappingWaste;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.WrappingWasteIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstMaterialIn
                    if (iError == 0)
                    {
                        if (!t.IsSilo)
                        {
                            t.LstMaterialIn.Clear();
                            ListBase<FormulaDetail> lstBOM = (new FormulaDetailDAL(dal.DBHelper)).GetDetailBOM(t.ProductCode, t.FormulaCode, t.Nap);

                            //t.LstMaterialIn = new ListBase<ManufactureTransaction>();
                            foreach (FormulaDetail fd in lstBOM)
                            {
                                ManufactureTransaction mt = new ManufactureTransaction();
                                mt.ItemCode = fd.MaterialCode;
                                mt.Quantity = fd.Weight;
                                t.LstMaterialIn.Add(mt);
                            }
                            foreach (ManufactureTransaction trans in t.LstMaterialIn)
                            {
                                if (trans.Quantity != 0)
                                {
                                    trans.ManufactureID = t.ManufactureID;
                                    trans.IsReceived = false;
                                    trans.TransactionType = (int)enumManufactureTransactionType.MaterialIn;
                                    iError = dalTran.Insert(trans);
                                    if (iError != 0)
                                        break;
                                }
                            }
                        }
                        else
                        {
                            foreach (ManufactureTransaction trans in t.LstMaterialIn)
                            {
                                if (trans.Quantity != 0)
                                {
                                    trans.ManufactureID = t.ManufactureID;
                                    trans.IsReceived = false;
                                    trans.TransactionType = (int)enumManufactureTransactionType.MaterialIn;
                                    iError = dalTran.Insert(trans);
                                    if (iError != 0)
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                iError = -1000;
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
        /// <summary>
        /// Update object Manufactures header into DataBase and no Update fiedl Status on objects ManufactureShifts
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int UpdateHeader(Manufacture t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            t.TotalWorkingTime = (int)(t.EndTime.Subtract(t.StartTime).TotalMinutes) - t.DelayTime;
            return dal.UpdateHeader(t);
        }

        /// <summary>
        /// Update object Manufactures into DataBase and Update fiedl Status on objects ManufactureShifts
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(Manufacture t)
        {

            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {

                t.UserUpdated = Contexts.CurrentUser.LoginName;
                //calculate Total WorkingTime by minute
                t.TotalWorkingTime = (int)(t.EndTime.Subtract(t.StartTime).TotalMinutes) - t.DelayTime;

                //get ItemProductCode
                //ItemProduct Item = new ItemProductBLL().GetByPSW(t.ProductCode, t.SizeCode, t.WeightCode);
                //ItemProductDAL dalItem = new ItemProductDAL(dal.DBHelper);
                //t.ItemProductCode = Item.ItemCode;// dalItem.GetItemCode(t.ProductCode, t.SizeCode, t.WeightCode);
                ListBase<ItemProduct> lItem = new ItemProductBLL().GetAllAll();
                ItemProduct Item = lItem.Search("ItemCode", t.ItemProductCode);
                iError = dal.Update(t);
                if (iError == 0)
                {
                    ManufactureTransactionDAL dalTran = new ManufactureTransactionDAL(dal.DBHelper);
                    iError = dalTran.Delete(t.ManufactureID);
                    //lstTaiche
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstTaiche)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.WasteIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstNhienlieu
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstNhienlieu)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.FuelIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //LstDieuchinh
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstDieuchinh)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.AdjustIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstPhepham
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction trans in t.LstPhepham)
                        {
                            if (trans.Quantity != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.IsReceived = true;
                                trans.TransactionType = (int)enumManufactureTransactionType.WasteOut;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstProductOut
                    if (iError == 0)
                    {
                        t.LstProductOut = new ListBase<ManufactureTransaction>();
                        t.LstProductOut.Add(new ManufactureTransaction());

                        foreach (ManufactureTransaction trans in t.LstProductOut)
                        {
                            if (t.ProductWeight != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = t.ItemProductCode;
                                trans.IsReceived = true;
                                trans.Quantity = t.ProductWeight;
                                trans.TransactionType = (int)enumManufactureTransactionType.ProductOut;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingIn
                    ItemWrappingDAL dalItemWrapp = new ItemWrappingDAL(dal.DBHelper);
                    //string _ItemCode = Item.WrappingCode;// dalItemWrapp.GetItemCode(t.ProductCode, t.WeightCode);
                    string _ItemCode = string.Empty;
                    if (t.ItemWrappingCode == string.Empty)
                        _ItemCode = Item.WrappingCode;
                    else
                        _ItemCode = t.ItemWrappingCode;
                    if (iError == 0)
                    {
                        t.LstWrappingIn = new ListBase<ManufactureTransaction>();
                        t.LstWrappingIn.Add(new ManufactureTransaction());
                        foreach (ManufactureTransaction trans in t.LstWrappingIn)
                        {
                            if (t.Wrapping != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = _ItemCode;
                                trans.IsReceived = false;
                                trans.Quantity = t.Wrapping;
                                trans.TransactionType = (int)enumManufactureTransactionType.WrappingIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstWrappingWasteIn
                    if (iError == 0)
                    {
                        t.LstWrappingWasteIn = new ListBase<ManufactureTransaction>();
                        t.LstWrappingWasteIn.Add(new ManufactureTransaction());
                        foreach (ManufactureTransaction trans in t.LstWrappingWasteIn)
                        {
                            if (t.WrappingWaste != 0)
                            {
                                trans.ManufactureID = t.ManufactureID;
                                trans.ItemCode = _ItemCode;
                                trans.Quantity = t.WrappingWaste;
                                trans.IsReceived = false;
                                trans.TransactionType = (int)enumManufactureTransactionType.WrappingWasteIn;
                                iError = dalTran.Insert(trans);
                                if (iError != 0)
                                    break;
                            }
                        }
                    }
                    //lstMaterialIn
                    if (iError == 0)
                    {
                        if (!t.IsSilo)
                        {
                            t.LstMaterialIn.Clear();
                            ListBase<FormulaDetail> lstBOM = (new FormulaDetailDAL(dal.DBHelper)).GetDetailBOM(t.ProductCode, t.FormulaCode, t.Nap);

                            //t.LstMaterialIn = new ListBase<ManufactureTransaction>();
                            foreach (FormulaDetail fd in lstBOM)
                            {
                                ManufactureTransaction mt = new ManufactureTransaction();
                                mt.ItemCode = fd.MaterialCode;
                                mt.Quantity = fd.Weight;
                                t.LstMaterialIn.Add(mt);
                            }
                            foreach (ManufactureTransaction trans in t.LstMaterialIn)
                            {
                                if (trans.Quantity != 0)
                                {
                                    trans.ManufactureID = t.ManufactureID;
                                    trans.IsReceived = false;
                                    trans.TransactionType = (int)enumManufactureTransactionType.MaterialIn;
                                    iError = dalTran.Insert(trans);
                                    if (iError != 0)
                                        break;
                                }
                            }
                        }
                        else
                        {
                            foreach (ManufactureTransaction trans in t.LstMaterialIn)
                            {
                                if (trans.Quantity != 0)
                                {
                                    trans.ManufactureID = t.ManufactureID;
                                    trans.IsReceived = false;
                                    trans.TransactionType = (int)enumManufactureTransactionType.MaterialIn;
                                    iError = dalTran.Insert(trans);
                                    if (iError != 0)
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                iError = -1000;
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
        public int UpdateManufactureShiftStatus(Guid _ManufactureShiftID, int _Status)
        {
            return dal.UpdateManufactureShiftStatus(_ManufactureShiftID, _Status,Contexts.CurrentUser.LoginName);
        }
        public DataSet Select_WCode_SCode_FCode_by_ProductCode(string _ProductCode)
        {
           return dal.Select_WCode_SCode_FCode_by_ProductCode(_ProductCode);
        }

        public DataSet GetManufacturebyStockCode(string _StockCode)
        {
            return dal.GetManufacturebyStockCode(_StockCode);
        }

        public int Delete(Manufacture t)
        {
            return Delete(t.ManufactureID);
        }
        public int Delete(Guid _ManufactureID)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                iError = dal.Delete(_ManufactureID, Contexts.CurrentUser.LoginName);
            }
            catch(Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ManufactureBLL", "Delete(Guid _ManufactureID)", excp.Message);
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


        public DataTable ReportManufacture(string _StockCode, DateTime _Tungay, DateTime _Denngay)
        {
            return dal.ReportManufacture(_StockCode, _Tungay, _Denngay);
        }
        public DataSet ReportManufactureDS(string _StockCode, DateTime _Tungay, DateTime _Denngay)
        {
            return dal.ReportManufactureDS(_StockCode, _Tungay, _Denngay);
        }
        public DataTable ReportManufactureShiftDetails(string _StockCode, DateTime _Tungay, DateTime _Denngay, string _ItemType)
        {
            return dal.ReportManufactureShiftDetails(_StockCode, (int)enumStockTransactionForDepartment.ForManufacture, _Tungay, _Denngay, _ItemType);
        }

        public void GetManufactureDetail(Manufacture manu)
        {
            dal.GetManufactureDetail(manu);
        }
        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as Manufacture);
        }

        public int Update(object obj)
        {
            return this.Update(obj as Manufacture);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as Manufacture);
        }

        #endregion

        #region ws
        public DataTable GetWasteOrg(Guid manufactureID)
        { return dal.GetWasteOrg(manufactureID); }
        #endregion
    }
}