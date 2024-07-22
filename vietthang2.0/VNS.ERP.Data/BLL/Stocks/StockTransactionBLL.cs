using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Common;
using System.Data;
using VNS.ERP.Data.Manufactures;
using VNS.ERP.Data.Premixs;

namespace VNS.ERP.Data
{
    public class StockTransactionBLL : IBusiness
    {
        public static ListBase<WeightItem> lstWeightItemChose;
        private StockTransactionDAL dal = new StockTransactionDAL();
        private StockTransactionDetailDAL dal1;

        private WeightItemDAL dal2;
        private StockTransactionSumDetailDAL dal3;
        private WeightItemContainerDAL dal4 = null;
        
        public StockTransactionBLL() { }
        public System.Data.DataTable GetDetailForReportSaleInvoce(Guid transactionID)
        {
            return dal.GetDetailForReportSaleInvoce(transactionID);
        }
        public DataTable ReportInOutProduct(DateTime startDate, DateTime endDate)
        {
            return dal.ReportInOutProduct(startDate, endDate, (Int16)enumItemType.Product);
        }
        public DataTable ReportInOutProductSumStock(DateTime startDate, DateTime endDate, bool includeTemp)
        {
            return dal.ReportInOutProductSumStock(startDate, endDate, (Int16)enumItemType.Product, includeTemp);
        }
        public DataTable ReportInOutProductForStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.ReportInOutProductForStockCode(startDate, endDate, (Int16)enumItemType.Product, stockCode);
        }
        public ListBase<StockTransactionSumDetail> GetDetailFromSaleRequest(string saleRequestNo)
        {
            return dal.GetDetailFromSaleRequest(saleRequestNo);
        }
        public DataTable ReportInOutMaterial(DateTime startDate, DateTime endDate)
        {
            return dal.ReportInOutMaterial(startDate, endDate);
        }
        public DataTable ReportInOutMaterialSumStock(DateTime startDate, DateTime endDate, bool includeTemp)
        {
            return dal.ReportInOutMaterialSumStock(startDate, endDate, includeTemp);
        }
        public DataTable ReportInOutMaterialForStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.ReportInOutMaterialForStockCode(startDate, endDate, stockCode);
        }
        //public ListBase<StockTransaction> GetBySCSTCT(string _StockCode, enumStockTransaction _StockTransaction, enumStockTransactionCreatedType _CreatedType, bool _OutStock, bool _MoveStock)
        //{
        //    //return dal.GetBySCSTCT(_StockCode,_StockTransaction,_CreatedType,_OutStock, _MoveStock);
        //}
         //public ListBase<StockTransaction>  Get
        public ListBase<StockTransaction> GetForAccountTransactionStockCheck(string transactionTypeCode, Guid accTransactionID, string donvi, string stockCode, bool inStock)
        {
            return dal.GetForAccountTransactionStockCheck(transactionTypeCode, accTransactionID, donvi, stockCode, inStock);
        }
        public StockTransaction GetByTransactionID(Guid transactionID)
        {
            return dal.GetByTransactionID(transactionID);
        }
        public DataTable ReportForTransactionType(DateTime startDate, DateTime endDate, string stockCode, string transactionTypeCode)
        {
            return dal.ReportForTransactionType(startDate, endDate, stockCode, transactionTypeCode);
        }
        public ListBase<StockTransaction> GetListStockTransForAccountTrans(Guid accTransactionID)
        {
            return dal.GetListStockTransForAccountTrans(accTransactionID);
        }
        public ListBase<StockTransaction> GetForDepartmentConfirmForPeriod(string stockCode, byte department, DateTime startDate, DateTime endDate)
        {
            return dal.GetForDepartmentConfirmForPeriod(stockCode, department, startDate, endDate);
        }
        public ListBase<StockTransaction> GetForDepartmentConfirmSales(string stockCode, DateTime startDate, DateTime endDate, string productType)
        {
            return dal.GetForDepartmentConfirmSales(stockCode, (byte)enumStockTransactionForDepartment.ForSale, startDate, endDate, productType);
        }
        public ListBase<StockTransaction> GetData(ParameterStockTransactionGetData pstgd)
        {
            return dal.GetData(pstgd);
        }
        public StockTransaction GetTop1BySuffixTNo(string _Suffix)
        {
            return dal.GetTop1BySuffixTNo(_Suffix);
        }
        public StockTransaction GetByManufactureShiftIDFromManufactureShift(Guid _ManufactureShiftID, bool _OutStock, enumManufactureTransactionType _TransactionType1, enumManufactureTransactionType _TransactionType2, enumStockTransactionGenType _GenType)
        {
            return dal.GetByManufactureShiftIDFromManufactures(_ManufactureShiftID, _OutStock, _TransactionType1, _TransactionType2, _GenType);
        }
        public ListBase<StockTransactionSumDetail> GetDetailsByWeightIDInWeighItemResult(Guid _WeightID, bool _IsReceive)
        {
            return dal.GetDetailsByWeightIDInWeighItemResult(_WeightID, _IsReceive);
        }
        public ListBase<StockTransaction> GetForDepartmentConfirm(string stockCode, byte department)
        {
            return dal.GetForDepartmentConfirm(stockCode, department);
        }
        public int GetDataFromGrindMaterial(Guid _GrindMaterialShiftID)
        {
            int iError = 0;
            StockTransaction[] st = new StockTransaction[4];

           // iError = dal.DeleteByGenID(_GrindMaterialShiftID);
            if (iError == 0)
            {
                st[0] = dal.GetByGrindMaterialShiftIDFromGrindmaterials(_GrindMaterialShiftID, true, (int)enumGrindMaterialTransactionType.MaterialIn, (int)enumGrindMaterialTransactionType.AdjustIn, (byte)enumStockTransactionGenType.Grind_OutMaterial);
                st[1] = dal.GetByGrindMaterialShiftIDFromGrindmaterials(_GrindMaterialShiftID, true, (int)enumGrindMaterialTransactionType.WrappingMaterialIn, (int)enumGrindMaterialTransactionType.WrappingMaterialWasteIn, (byte)enumStockTransactionGenType.Grind_OutWrapping);
                st[2] = dal.GetByGrindMaterialShiftIDFromGrindmaterials(_GrindMaterialShiftID, false, (int)enumGrindMaterialTransactionType.MaterialOut, (int)enumGrindMaterialTransactionType.MaterialOut, (byte)enumStockTransactionGenType.Grind_InMaterial);
                st[3] = dal.GetByGrindMaterialShiftIDFromGrindmaterials(_GrindMaterialShiftID, true, (int)enumGrindMaterialTransactionType.FuelIn, (int)enumGrindMaterialTransactionType.FuelIn, (byte)enumStockTransactionGenType.Grind_OutFuel);
                bool alreadyOpen = false;
                if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.Open();
                else alreadyOpen = true;
                dal1 = new StockTransactionDetailDAL(dal.DBHelper);
                dal3 = new StockTransactionSumDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                
                for (int i = 0; i < 4; i++)
                {
                    if (iError == 0)
                    {
                        st[i].UserCreated = Contexts.CurrentUser.LoginName;
                       // st[i].TransactionID = Guid.Empty;
                        if (st[i].TransactionID == Guid.Empty)
                        {
                            if (st[i].Details.Count > 0)
                            {
                                iError = dal.Insert(st[i]);
                                if (iError == 0)
                                {
                                    foreach (StockTransactionSumDetail stsd in st[i].Details)
                                    {
                                        if (iError == 0)
                                        {
                                            stsd.TransactionID = st[i].TransactionID;
                                            iError = dal3.Insert(stsd);
                                            //if (iError == 0)
                                            //{
                                            //    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                            //    {
                                            //        if (iError == 0)
                                            //        {
                                            //            stsd.TransactionID = st[i].TransactionID;
                                            //            if (std.Quantity != 0) iError = dal1.Insert(std);
                                            //        }
                                            //        if (iError != 0) break;
                                            //    }
                                            //}
                                        }
                                        if (iError != 0) break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (st[i].Details.Count > 0)
                            {
                                decimal d = 0;
                                foreach (StockTransactionSumDetail stsd in st[i].Details)
                                {
                                    d += stsd.Quantity;
                                }
                                if (d == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                                else
                                {
                                    if (iError == 0) iError = dal.Update(st[i]);
                                    if (iError == 0) iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                    if (iError == 0) iError = dal1.DeleteByTransactionID(st[i].TransactionID);

                                    if (iError == 0)
                                    {
                                        foreach (StockTransactionSumDetail stsd in st[i].Details)
                                        {
                                            if (iError == 0)
                                            {
                                                stsd.TransactionID = st[i].TransactionID;
                                                iError = dal3.Insert(stsd);
                                                if (iError == 0)
                                                {
                                                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                                    {
                                                        if (iError == 0)
                                                        {
                                                            std.TransactionID = st[i].TransactionID;
                                                            if (std.Quantity != 0) iError = dal1.Insert(std);
                                                        }
                                                        if (iError != 0) break;
                                                    }
                                                }
                                            }
                                            if (iError != 0) break;
                                        }
                                    }
                                }
                                
                            }
                            else
                            {
                                iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                if (iError == 0)
                                {
                                    iError = dal1.DeleteByTransactionID(st[i].TransactionID);
                                }
                                if (iError == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                            }
                        }
                        if (iError != 0) break;
                    }
                }
                if (iError == 0) iError = dal.UpdateStatusAndUserCreateSTInGrindMaterialShift(_GrindMaterialShiftID, 1, Contexts.CurrentUser.LoginName);
                if (iError != 0) dal.Rollback();
                else dal.Commit();

                if (!alreadyOpen) dal.DBHelper.Close();
            }
            return iError;
        }
        public ListBase<StockTransactionSumDetail> GetDetailsByTransactionID(Guid _TransactionID)
        {
            return dal.GetDetailsByTransactionID(_TransactionID);
        }
        public int GetDataFromMixPremix(Guid _MixPremixShiftID)
        {
            int iError = 0;
            StockTransaction[] st = new StockTransaction[1];
            //iError = dal.DeleteByGenID(_MixPremixShiftID);
            if (iError == 0)
            {
                //st[0] = dal.GetByMixPremixShiftIDFromMixPremixs(_MixPremixShiftID, true, enumMixPremixTransactionType.MaterialIn, enumMixPremixTransactionType.AdjustIn, enumStockTransactionGenType.Premix_OutMaterial);
                //st[1] = dal.GetByMixPremixShiftIDFromMixPremixs(_MixPremixShiftID, true, enumMixPremixTransactionType.WrappingPremixIn, enumMixPremixTransactionType.WrappingPremixWasteIn, enumStockTransactionGenType.Premix_OutWrapping);
                st[0] = dal.GetByMixPremixShiftIDFromMixPremixs(_MixPremixShiftID, false, enumMixPremixTransactionType.PremixOut, enumMixPremixTransactionType.PremixOut, enumStockTransactionGenType.Premix_InPremix);

                bool alreadyOpen = false;
                if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.Open();
                else alreadyOpen = true;
                dal1 = new StockTransactionDetailDAL(dal.DBHelper);
                dal3 = new StockTransactionSumDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                
                for (int i = 0; i < 1; i++)
                {
                    if (iError == 0)
                    {
                        st[i].UserCreated = Contexts.CurrentUser.LoginName;
                        //st[i].TransactionID = Guid.Empty;
                        if (st[i].TransactionID == Guid.Empty)
                        {
                            if (st[i].Details.Count > 0)
                            {
                                iError = dal.Insert(st[i]);
                                if (iError == 0)
                                {
                                    foreach (StockTransactionSumDetail stsd in st[i].Details)
                                    {
                                        if (iError == 0)
                                        {
                                            stsd.TransactionID = st[i].TransactionID;
                                            iError = dal3.Insert(stsd);
                                            //if (iError == 0)
                                            //{
                                            //    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                            //    {
                                            //        if (iError == 0)
                                            //        {
                                            //            std.TransactionID = st[i].TransactionID;
                                            //            if (std.Quantity != 0) iError = dal1.Insert(std);
                                            //        }
                                            //        if (iError != 0) break;
                                            //    }
                                            //}
                                        }
                                        if (iError != 0) break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (st[i].Details.Count > 0)
                            {
                                decimal d = 0;
                                foreach (StockTransactionSumDetail stsd in st[i].Details)
                                {
                                    d += stsd.Quantity;
                                }
                                if (d == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                                else
                                {
                                    iError = dal.Update(st[i]);
                                    if (iError == 0) iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                    if (iError == 0) iError = dal1.DeleteByTransactionID(st[i].TransactionID);
                                    if (iError == 0)
                                    {
                                        foreach (StockTransactionSumDetail stsd in st[i].Details)
                                        {
                                            if (iError == 0)
                                            {
                                                stsd.TransactionID = st[i].TransactionID;
                                                iError = dal3.Insert(stsd);
                                                if (iError == 0)
                                                {
                                                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                                    {
                                                        if (iError == 0)
                                                        {
                                                            std.TransactionID = st[i].TransactionID;
                                                            if (std.Quantity != 0) iError = dal1.Insert(std);
                                                        }
                                                        if (iError != 0) break;
                                                    }
                                                }
                                            }
                                            if (iError != 0) break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                iError = dal1.DeleteByTransactionID(st[i].TransactionID);
                                if (iError == 0)
                                {
                                    iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                }
                                if (iError == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                            }
                        }
                        if (iError != 0) break;
                    }
                }
                if (iError == 0) iError = dal.UpdateStatusAndUserCreateSTInMixPremixShift(_MixPremixShiftID, 1, Contexts.CurrentUser.LoginName);
                if (iError != 0) dal.Rollback();
                else dal.Commit();

                if (!alreadyOpen) dal.DBHelper.Close();
            }
            return iError;
            //st[3] = dal.GetByManufactureShiftIDFromManufactures(_MixPremixShiftID, false, enumManufactureTransactionType.WasteOut, enumManufactureTransactionType.WasteOut, enumStockTransactionGenType.InWaste);
        }
        public int DeleteByGenID(Guid _GenID)
        {
            return dal.DeleteByGenID(_GenID);
        }
        public int GetDataFromManufact(Guid _ManufactureShiftID)
        {
            return GetDataFromManufact(_ManufactureShiftID, new bool[] { true, true, true, true });
        }
        public int GetDataFromManufact(Guid _ManufactureShiftID,bool[] selectType)
        {
            int iError=0;
            StockTransaction[] st = new StockTransaction[4];
            //iError = dal.DeleteByGenID(_ManufactureShiftID);
            if (iError == 0)
            {
                
                st[0] = dal.GetByManufactureShiftIDFromManufactures(_ManufactureShiftID, true, enumManufactureTransactionType.MaterialIn, enumManufactureTransactionType.AdjustIn, enumStockTransactionGenType.OutMaterial);
                st[1] = dal.GetByManufactureShiftIDFromManufactures(_ManufactureShiftID, true, enumManufactureTransactionType.FuelIn, enumManufactureTransactionType.FuelIn, enumStockTransactionGenType.OutFuel);
                st[2] = dal.GetByManufactureShiftIDFromManufactures(_ManufactureShiftID, false, enumManufactureTransactionType.ProductOut, enumManufactureTransactionType.ProductOut, enumStockTransactionGenType.InProduct);
                st[3] = dal.GetByManufactureShiftIDFromManufactures(_ManufactureShiftID, false, enumManufactureTransactionType.WasteOut, enumManufactureTransactionType.WasteOut, enumStockTransactionGenType.InWaste);

                bool alreadyOpen = false;
                if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.Open();
                else alreadyOpen = true;
                dal1 = new StockTransactionDetailDAL(dal.DBHelper);
                dal3 = new StockTransactionSumDetailDAL(dal.DBHelper);
                dal.BeginTransaction();
                //
                for (int i = 0; i < 4; i++)
                {
                    if (iError == 0 && selectType[i])
                    {
                        //st[i].TransactionID = Guid.Empty;
                        st[i].UserCreated = Contexts.CurrentUser.LoginName;
                        if (st[i].TransactionID == Guid.Empty)
                        {
                            if (st[i].Details.Count > 0)
                            {
                                iError = dal.Insert(st[i]);
                                if (iError == 0)
                                {
                                    foreach (StockTransactionSumDetail stsd in st[i].Details)
                                    {
                                        if (iError == 0)
                                        {
                                            stsd.TransactionID = st[i].TransactionID;
                                            iError = dal3.Insert(stsd);
                                            //if (iError == 0)
                                            //{
                                            //    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                            //    {
                                            //        if (iError == 0)
                                            //        {
                                            //            std.TransactionID = st[i].TransactionID;
                                            //            if (std.Quantity != 0) iError = dal1.Insert(std);
                                            //        }
                                            //        if (iError != 0) break;
                                            //    }
                                            //}
                                        }
                                        if (iError != 0) break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (st[i].Details.Count > 0)
                            {
                                decimal d = 0;
                                foreach (StockTransactionSumDetail stsd in st[i].Details)
                                {
                                    d += stsd.Quantity;
                                }
                                if (d == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                                else
                                {
                                    iError = dal.Update(st[i]);
                                    if (iError == 0) iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                    if (iError == 0) iError = dal1.DeleteByTransactionID(st[i].TransactionID);
                                    if (iError == 0)
                                    {
                                        foreach (StockTransactionSumDetail stsd in st[i].Details)
                                        {
                                            if (iError == 0)
                                            {
                                                stsd.TransactionID = st[i].TransactionID;
                                                iError = dal3.Insert(stsd);
                                                if (iError == 0)
                                                {
                                                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                                    {
                                                        if (iError == 0)
                                                        {
                                                            std.TransactionID = st[i].TransactionID;
                                                            if (std.Quantity != 0) iError = dal1.Insert(std);
                                                        }
                                                        if (iError != 0) break;
                                                    }
                                                }
                                            }
                                            if (iError != 0) break;
                                        }
                                    }
                                }
                               
                            }
                            else
                            {
                                iError = dal3.DeleteByTransactionID(st[i].TransactionID);
                                if (iError == 0)
                                {
                                    iError = dal1.DeleteByTransactionID(st[i].TransactionID);
                                }
                                if (iError == 0)
                                {
                                    iError = dal.Delete(st[i]);
                                }
                            }
                        }
                        if (iError != 0) break;
                    }
                }
                if (iError == 0) iError = dal.UpdateStatusAndUserCreateSTInManufactureShift(_ManufactureShiftID, 1, Contexts.CurrentUser.LoginName);
                if (iError != 0) dal.Rollback();
                else dal.Commit();
                //dal.Close();

                if (!alreadyOpen) dal.DBHelper.Close();
            }
            return iError;
            
        }
        public ListBase<StockTransaction> GetDataInStock(string _StockCode, Int16 _StockTransaction)
        {
            return dal.GetDataInStock(_StockCode, _StockTransaction);
        }
        public ListBase<StockTransaction> GetDataInStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)
        {
            return dal.GetDataInStockForPeriod(_StockCode, _StockTransaction, startDate,endDate);
        }
        public ListBase<StockTransaction> GetDataOutStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)
        {
            return dal.GetDataOutStockForPeriod(_StockCode, _StockTransaction, startDate, endDate);
        }
        public ListBase<StockTransaction> GetDataOutStock(string _StockCode, Int16 _StockTransaction)
        {
            return dal.GetDataOutStock(_StockCode, _StockTransaction);
        }
        public ListBase<StockTransaction> GetDataConfirm(string _StockCode)
        {
            return dal.GetDataConfirm(_StockCode);
        }
        public ListBase<StockTransaction> GetDataConfirmForPeriod(string _StockCode, DateTime startDate, DateTime endDate)
        {
            return dal.GetDataConfirmForPeriod(_StockCode, startDate, endDate);
        }
        public DataTable SelectByDateAndStock(DateTime fromDate, DateTime toDate, string stockCode)
        {
            return dal.SelectByDateAndStock(fromDate, toDate, stockCode);
        }
        public DataTable ReportBaocaoTonkhoNLCayhang(DateTime startDate, DateTime endDate, string stockCode, string itemType)
        {
            return dal.ReportBaocaoTonkhoNLCayhang(startDate, endDate, stockCode, itemType);
        }
        public int Insert(StockTransaction t)
        {
            int iError;

            bool alreadyOpen = false;
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;

            dal1 = new StockTransactionDetailDAL(dal.DBHelper);
            dal3 = new StockTransactionSumDetailDAL(dal.DBHelper);
            dal2 = new WeightItemDAL(dal.DBHelper);
            dal4 = new WeightItemContainerDAL(dal.DBHelper);
            //dal.Open();
            dal.BeginTransaction();
            iError = dal.Insert(t);
            if (iError == 0)
            {
                foreach (StockTransactionSumDetail stsd in t.Details)
                {
                    if (iError==0)
                    {
                        stsd.TransactionID=t.TransactionID;
                        if(stsd.Quantity!=0) iError=dal3.Insert(stsd);
                        if (iError == 0)
                        {
                            foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                            {
                                if (iError == 0)
                                {
                                    std.TransactionID = t.TransactionID;
                                    if (std.Quantity != 0) iError = dal1.Insert(std);
                                }
                                if (iError != 0) break;
                            }
                        }
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0 && lstWeightItemChose != null && t.GetByWeightItems)
            {
                foreach (WeightItem wi in lstWeightItemChose)
                {
                    if (iError == 0)
                    {
                        iError = dal2.UpdateTransactionID(wi.WeightID, t.TransactionID);
                        if (iError != 0) break;
                    }
                }
            }
            if (iError == 0 && t.LstWICCheck != null && t.GetByWeightItemContainer)
            {
                foreach (WeightItemContainer wic in t.LstWICCheck)
                {
                    if (iError == 0)
                    {
                        iError = dal4.UpdateTransactionID(wic.WeightContainerID, t.TransactionID);
                        if (iError != 0) break;
                    }
                }
            }
            if (iError == 0 && !t.GetByWeightItemContainer && t.LstWICCheck != null)
            {
                t.LstWICCheck.Clear();
            }

            if (iError == 0)
            {
                int count = t.Details.Count;
                for (int i = 0; i < count; i++)
                {
                    t.Details.ResetItem(i);
                    if (t.Details[i].Quantity == 0)
                    {
                        t.Details.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
                    else
                    {
                        int countstd = t.Details[i].lstStockTransactionDetail.Count;
                        for (int icountstd = 0; icountstd < countstd; icountstd++)
                        {
                            t.Details[i].lstStockTransactionDetail.ResetItem(icountstd);
                            if (t.Details[i].lstStockTransactionDetail[icountstd].Quantity == 0)
                            {
                                t.Details[i].lstStockTransactionDetail.RemoveAt(icountstd);
                                icountstd -= 1;
                                countstd -= 1;
                            }
                        }
                    }
                }
            }
           
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
                StockTransactionBLL.lstWeightItemChose = null;
            }
            //dal.Close();

            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        public int Update(StockTransaction t)
        {
            int iError;
            bool alreadyOpen = false;
            if (t.CreatedType == (byte)enumStockTransactionCreatedType.DefaultValue)
            {
                if (t.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm)
                {
                    return -14;
                }
            }
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
           
            dal1 = new StockTransactionDetailDAL(dal.DBHelper);
            dal3 = new StockTransactionSumDetailDAL(dal.DBHelper);
            dal2 = new WeightItemDAL(dal.DBHelper);
            dal4 = new WeightItemContainerDAL(dal.DBHelper);
            //dal.Open();
            dal.BeginTransaction();
            iError = dal.Update(t);
            if (iError == 0)
            {
                iError = dal1.DeleteByTransactionID(t.TransactionID);
            }
            if (iError == 0)
            {
                iError = dal3.DeleteByTransactionID(t.TransactionID);
            }
            if (iError == 0)
            {
                foreach (StockTransactionSumDetail stsd in t.Details)
                {
                    if (iError == 0)
                    {
                        stsd.TransactionID = t.TransactionID;
                        if (stsd.Quantity != 0) iError = dal3.Insert(stsd);
                        if (iError == 0)
                        {
                            foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                            {
                                if (iError == 0)
                                {
                                    std.TransactionID = t.TransactionID;
                                    if (std.Quantity != 0) iError = dal1.Insert(std);
                                }
                                if (iError != 0) break;
                            }
                        }
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                iError = dal2.MakeNullTransactionID(t.TransactionID);
            }
            //if (iError == 0)
            //{
            //    iError = dal4.MakeNullTransactionID(t.TransactionID);
            //}
            if (iError == 0 && lstWeightItemChose != null)
            {
                if (t.GetByWeightItems)
                {
                    foreach (WeightItem wi in lstWeightItemChose)
                    {
                        if (iError == 0)
                        {
                            iError = dal2.UpdateTransactionID(wi.WeightID, t.TransactionID);
                            if (iError != 0) break;
                        }
                    }
                }
            }
            if (iError == 0 && !t.GetByWeightItems && lstWeightItemChose != null)
            {
                lstWeightItemChose.Clear();
            }
            if (iError == 0 && !t.GetByWeightItemContainer)
                iError = dal4.MakeNullTransactionID(t.TransactionID);

            if (iError == 0 && t.LstWICCheck != null && t.GetByWeightItemContainer)
            {
                if (iError == 0)
                {
                    iError = dal4.MakeNullTransactionID(t.TransactionID);
                }
                foreach (WeightItemContainer wic in t.LstWICCheck)
                {
                    if (iError == 0)
                    {
                        iError = dal4.UpdateTransactionID(wic.WeightContainerID, t.TransactionID);
                        if (iError != 0) break;
                    }
                }
            }
            if (iError == 0 && !t.GetByWeightItemContainer && t.LstWICCheck != null)
            {
                t.LstWICCheck.Clear();
            }
           
            if (iError == 0)
            {
                int count = t.Details.Count;
                for (int i = 0; i < count; i++)
                {
                    t.Details.ResetItem(i);
                    if (t.Details[i].Quantity == 0)
                    {
                        t.Details.RemoveAt(i);
                        i -= 1;
                        count -= 1;
                    }
                    else
                    {
                        int countstd = t.Details[i].lstStockTransactionDetail.Count;
                        for (int icountstd = 0; icountstd < countstd; icountstd++)
                        {
                            t.Details[i].lstStockTransactionDetail.ResetItem(icountstd);
                            if (t.Details[i].lstStockTransactionDetail[icountstd].Quantity == 0)
                            {
                                t.Details[i].lstStockTransactionDetail.RemoveAt(icountstd);
                                icountstd -= 1;
                                countstd -= 1;
                            }
                        }
                    }
                }
            }
            
            if (iError != 0) dal.Rollback();
            else
            {
                dal.Commit();
                StockTransactionBLL.lstWeightItemChose = null;
            }
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }

        public int TestExitsStockTransactionByGenID_Status(Guid _GenID, int _Status)
        {
           return dal.TestExitsStockTransactionByGenID_Status(_GenID, _Status);
        }

        public int Delete(StockTransaction t)
        {
            int iError=0;
            bool alreadyOpen = false;
            if (t.CreatedType == (byte)enumStockTransactionCreatedType.DefaultValue)
            {
                if (t.DepartmentStatus == (byte)enumStockTransactionDepartmentStatus.Confirm)
                {
                    return -5;
                }
            }
            if (dal.DBHelper.State != System.Data.ConnectionState.Open) dal.DBHelper.Open();
            else alreadyOpen = true;
            dal2 = new WeightItemDAL(dal.DBHelper);
            dal1 = new StockTransactionDetailDAL(dal.DBHelper);
            dal4 = new WeightItemContainerDAL(dal.DBHelper);
            //dal.Open();
            if (t.CreatedType != 0)
            {
                iError = -4;
            }
            if (iError == 0)
            {
                dal.BeginTransaction();
                if (iError == 0) iError = dal1.DeleteByTransactionID(t.TransactionID);
                if (iError == 0)
                {
                    iError = dal2.MakeNullTransactionID(t.TransactionID);
                }
                if (iError == 0)
                {
                    iError = dal4.MakeNullTransactionID(t.TransactionID);
                }
                if (iError == 0)
                {
                    iError = dal.Delete(t);
                }
                if (iError != 0) dal.Rollback();
                else
                {
                    dal.Commit();
                }
            }
            //dal.Close();
            if (!alreadyOpen) dal.DBHelper.Close();
            return iError;
        }
        #region IBusiness Members
        public int Insert(object obj)
        {
            return this.Insert(obj as StockTransaction);
        }
        public int Update(object obj)
        {
            return this.Update(obj as StockTransaction);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as StockTransaction);
        }
        #endregion

        public DataSet SelectToCheck(DateTime startDate, DateTime endDate, string stockCode)
        {
            DataSet ds = dal.SelectToCheck(startDate, endDate, stockCode);
            DataRelation drSumDetail = ds.Relations.Add("SumDetail", ds.Tables[0].Columns["TransactionID"], ds.Tables[1].Columns["TransactionID"]);
            return ds;
        }

        #region WS
        public ListBase<StockTransaction> GetByGoodCode(string goodCode)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();
            try
            {
                string dateline = goodCode.Substring(0, 9);
                int lot = Convert.ToInt32(goodCode.Substring(9, 3));
                ListBase<StockTransactionDetail> lstD = new StockTransactionDetailDAL().GetByGoodCode(dateline);

                ListBase<Customer> lstCustomer = null;
                ListBase<Vendor> lstTransport = null;
                foreach (StockTransactionDetail d in lstD)
                {
                    int i = Convert.ToInt32(d.GoodCode.Substring(9, 3));
                    int ii = Convert.ToInt32(d.GoodCode.Substring(13, 3));

                    if (lot >= i && lot <= ii)
                    {
                        StockTransaction st = new StockTransactionDAL().GetByTransactionID(d.TransactionID);
                        if (lstCustomer == null)
                            lstCustomer = new CustomerBLL().GetAll();
                        st.ObjCustomer = lstCustomer.Search("SubjectCode", st.DVNhan);
                        if (st.ObjCustomer == null)
                            st.ObjCustomer = new Customer();

                        if (lstTransport == null)
                            lstTransport = new VendorBLL().GetForVanchuyen();
                        st.ObjTransport = lstTransport.Search("SubjectCode", st.DonviVC);
                        if (st.ObjTransport == null)
                            st.ObjTransport = new Vendor();

                        st.Quantity = 3000;

                        lst.Add(st);
                    }
                }

            }
            catch { }
            return lst;
        }

        public ListBase<StockTransaction> GetMaterialInfo(Guid manufactureShiftID)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();
            StockTransaction st = dal.GetByGenID(manufactureShiftID, "X11");

            if (st != null)
            {
                ListBase<Vendor> lstVendor = null;
                ListBase<Vendor> lstTransport = null;
                ListBase<Item> lstItem = null;
                foreach (StockTransactionSumDetail stsd in st.Details)
                    foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                    {
                        StockTransaction o = dal.GetLastPurchase(std.ItemCode, st.OutStock, std.OutLocation, st.TransactionDate);
                        if (o != null)
                        {
                            //o = new StockTransaction();
                            //o.Details = new ListBase<StockTransactionSumDetail>();

                            if (lstItem == null)
                                lstItem = new ItemBLL().GetAll();
                            Item i = lstItem.Search("ItemCode", std.ItemCode);
                            if (i != null)
                                o.ItemName = i.ItemName;

                            if (lstVendor == null)
                                lstVendor = new VendorBLL().GetForPurchase();
                            o.ObjVendor = lstVendor.Search("SubjectCode", o.DVGiao);
                            if (o.ObjVendor == null)
                                o.ObjVendor = new Vendor();

                            if (lstTransport == null)
                                lstTransport = new VendorBLL().GetForVanchuyen();
                            o.ObjTransport = lstTransport.Search("SubjectCode", st.DonviVC);
                            if (o.ObjTransport == null)
                                o.ObjTransport = new Vendor();

                            lst.Add(o);
                        }
                    }
            }
            return lst;
        }
        public ListBase<StockTransaction> GetMaterialInfo2(string searchString)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();

            string[] st1 = searchString.Split(' ');
            DateTime date = new DateTime(Convert.ToInt32(st1[0].Substring(4, 2)) + 2000,
                Convert.ToInt32(st1[0].Substring(2, 2)), Convert.ToInt32(st1[0].Substring(0, 2)));
            string lineNo = st1[1].Substring(1, st1[1].Length - 4);
            string lot1 = st1[1].Substring(st1[1].Length - 3, 3);
            int lot = Convert.ToInt32(lot1);

            ListBase<ManufactureShift> lstMS = new ManufactureShiftBLL().GetObjectByTimeStockCode(date.AddDays(-1), date.AddDays(10), "");
            ManufactureShift objMS = null;
            foreach (ManufactureShift ms in lstMS)
            {
                foreach (Manufacture m in ms.ListManufacture)
                {
                    if (m.LinesxNo == lineNo && m.CodeBaoTP.Length > 6 && m.CodeBaoTP.Substring(0, 6) == st1[0])
                    {
                        int i = Convert.ToInt32(m.CodeBaoTP.Substring(9, 3));
                        int ii = Convert.ToInt32(m.CodeBaoTP.Substring(13, 3));
                        if (lot >= i && lot <= ii)
                        {

                            objMS = ms;
                            
                        }
                    }
                }
            }
            if (objMS != null)
            {
                StockTransaction st = dal.GetByGenID(objMS.ManufactureShiftID, "X11");

                if (st != null)
                {
                    ListBase<Vendor> lstVendor = null;
                    ListBase<Vendor> lstTransport = null;
                    ListBase<Item> lstItem = null;
                    foreach (StockTransactionSumDetail stsd in st.Details)
                        foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                        {
                            StockTransaction o = dal.GetLastPurchase(std.ItemCode, st.OutStock, std.OutLocation, st.TransactionDate);
                            if (o != null)
                            {
                                //o = new StockTransaction();
                                //o.Details = new ListBase<StockTransactionSumDetail>();

                                if (lstItem == null)
                                    lstItem = new ItemBLL().GetAll();
                                Item i = lstItem.Search("ItemCode", std.ItemCode);
                                if (i != null)
                                    o.ItemName = i.ItemName;

                                if (lstVendor == null)
                                    lstVendor = new VendorBLL().GetForPurchase();
                                o.ObjVendor = lstVendor.Search("SubjectCode", o.DVGiao);
                                if (o.ObjVendor == null)
                                    o.ObjVendor = new Vendor();

                                if (lstTransport == null)
                                    lstTransport = new VendorBLL().GetForVanchuyen();
                                o.ObjTransport = lstTransport.Search("SubjectCode", o.DonviVC);
                                if (o.ObjTransport == null)
                                    o.ObjTransport = new Vendor();

                                lst.Add(o);
                            }
                        }
                }
            }
            return lst;
        }
        public ListBase<StockTransaction> GetWrappingInfo(string searchString)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();
            try
            {
                ListBase<ManufactureShift> lstMS = new ManufactureShiftBLL().GetHeaderByProductCode(searchString);
                if (lstMS != null && lstMS.Count > 0)
                {
                    new ManufactureBLL().GetManufactureDetail(lstMS[0].ObjManufacture);

                    StockTransaction st = new StockTransactionDAL().GetLastOutManu(lstMS[0].ObjManufacture.LstWrappingIn[0].ItemCode,
                        lstMS[0].StockCode, lstMS[0].ManufactureDate, string.Empty);

                    StockTransaction objST = new StockTransactionDAL().GetLastPurchase(st.Details[0].ItemCode,
                        st.OutStock,
                        st.Details[0].lstStockTransactionDetail[0].OutLocation, st.TransactionDate);

                    if (objST != null)
                    {
                        ListBase<Vendor> lstVendor = null;
                        ListBase<Vendor> lstTransport = null;
                        ListBase<Item> lstItem = null;

                        if (lstItem == null)
                            lstItem = new ItemBLL().GetAll();
                        Item i = lstItem.Search("ItemCode", objST.Details[0].ItemCode);
                        if (i != null)
                            objST.ItemName = i.ItemName;

                        if (lstVendor == null)
                            lstVendor = new VendorBLL().GetForPurchase();
                        objST.ObjVendor = lstVendor.Search("SubjectCode", objST.DVGiao);
                        if (objST.ObjVendor == null)
                            objST.ObjVendor = new Vendor();

                        if (lstTransport == null)
                            lstTransport = new VendorBLL().GetForVanchuyen();
                        objST.ObjTransport = lstTransport.Search("SubjectCode", objST.DonviVC);
                        if (objST.ObjTransport == null)
                            objST.ObjTransport = new Vendor();

                        lst.Add(objST);
                    }
                }
            }
            catch { }
            return lst;
        }

        public ListBase<StockTransaction> GetPremixInfo(string searchString)
        {
            ListBase<StockTransaction> lst = new ListBase<StockTransaction>();
            try
            {
                MixPremixShift objMPS = new MixPremixShiftBLL().GetPremix(searchString);
                if (objMPS != null)
                {
                    ListBase<Vendor> lstVendor = null;
                    ListBase<Vendor> lstTransport = null;
                    ListBase<Item> lstItem = null;
                    foreach (MixPremixTransaction mpt in objMPS.ObjMixPremix.LstMaterialIn)
                    {
                        StockTransaction st = new StockTransactionDAL().GetLastOutManu(mpt.ItemCode, objMPS.StockCode,
                            objMPS.MixDate, "X12");
                        if (st != null)
                        {

                            foreach (StockTransactionSumDetail stsd in st.Details)
                                foreach (StockTransactionDetail std in stsd.lstStockTransactionDetail)
                                {
                                    StockTransaction o = dal.GetLastPurchase(std.ItemCode, st.OutStock, std.OutLocation, st.TransactionDate);
                                    if (o != null)
                                    {
                                        //o = new StockTransaction();
                                        //o.Details = new ListBase<StockTransactionSumDetail>();

                                        if (lstItem == null)
                                            lstItem = new ItemBLL().GetAll();
                                        Item i = lstItem.Search("ItemCode", std.ItemCode);
                                        if (i != null)
                                            o.ItemName = i.ItemName;

                                        if (lstVendor == null)
                                            lstVendor = new VendorBLL().GetForPurchase();
                                        o.ObjVendor = lstVendor.Search("SubjectCode", o.DVGiao);
                                        if (o.ObjVendor == null)
                                            o.ObjVendor = new Vendor();

                                        if (lstTransport == null)
                                            lstTransport = new VendorBLL().GetForVanchuyen();
                                        o.ObjTransport = lstTransport.Search("SubjectCode", o.DonviVC);
                                        if (o.ObjTransport == null)
                                            o.ObjTransport = new Vendor();

                                        lst.Add(o);
                                    }
                                }
                        }
                    }
                }
            }
            catch { }

            return lst;
        }
        #endregion
    }
}
