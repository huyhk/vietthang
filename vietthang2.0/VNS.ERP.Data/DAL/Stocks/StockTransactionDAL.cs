using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
     public struct ParameterStockTransactionGetData
     {
        public bool MoveStock;
        public bool OutStock;
        public string StockCode;
        public enumStockTransaction StockTransaction;
        public enumStockTransactionCreatedType CreatedType;
        public enumStockTransactionGenType GenType1;
        public enumStockTransactionGenType GenType2;
        public enumStockTransactionStatus Status1;
        public enumStockTransactionStatus Status2;
        public Guid GenID;
     }
    public class StockTransactionDAL : StockBaseDAL<StockTransaction>
    {
        BaseClass bc = new BaseClass();
        public StockTransactionDAL() { }
        public StockTransactionDAL(DBHelper dbHelper)
            : base(dbHelper)
        {
        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_StockTransactions_Select_All";
            //base.SetValues();
        }
        public DataTable ReportForTransactionType(DateTime startDate , DateTime endDate, string stockCode, string transactionTypeCode)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_Transaction_For_TransactionType2";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, transactionTypeCode));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportForTransactionTypeAndMonth(DateTime startDate , DateTime endDate, string transactionTypeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable GetDetailForReportSaleInvoce(Guid transactionID)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_GetDetail_ForReportSaleInvoice";
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDetailForReportSaleInvoce(Guid transactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable ReportInOutMaterial(DateTime startDate, DateTime endDate)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Material";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutMaterial(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable ReportInOutMaterialSumStock(DateTime startDate, DateTime endDate, bool includeTemp)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Material";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SumStock", System.Data.DbType.Boolean, 1, true));
                cmd.Parameters.Add(db.CreateParameter("@IncludeTemp", System.Data.DbType.Boolean, 1, includeTemp));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutMaterial(DateTime startDate, DateTime endDate,bool includeTemp)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable ReportInOutMaterialForStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Material_For_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutMaterialForStockCode(DateTime startDate, DateTime endDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable ReportInOutProduct(DateTime startDate, DateTime endDate, Int16 itemType)
        {
            System.Data.DataTable returnObj=null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Product";
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, itemType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutProduct(DateTime startDate, DateTime endDate, Int16 itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            
            return returnObj;
        }
        public DataTable ReportInOutProductSumStock(DateTime startDate, DateTime endDate, Int16 itemType, bool includeTemp)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Product";
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, itemType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SumStock", System.Data.DbType.Boolean, 1, true));
                cmd.Parameters.Add(db.CreateParameter("@IncludeTemp", System.Data.DbType.Boolean, 1, includeTemp));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutProductSumStock(DateTime startDate, DateTime endDate, Int16 itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public DataTable ReportInOutProductForStockCode(DateTime startDate, DateTime endDate, Int16 itemType, string stockCode)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_InOut_Product_For_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.Int16, 2, itemType));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportInOutProductForStockCode(DateTime startDate, DateTime endDate, Int16 itemType, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }
        public StockTransaction GetTop1BySuffixTNo(string _Suffix)
        {
            bool NotFound = true;
            DbDataReader reader = null;
            bool alreadyOpen = false;
            StockTransaction obj = new StockTransaction();
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Get_Top1_By_SuffixTNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, _Suffix));

                reader = db.ExecuteReader(cmd); 
                while (reader.Read())
                {
                    obj = new StockTransaction(reader);
                    //lstst.Add(obj);
                    NotFound = false;
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetTop1BySuffixTNo(string _Suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            if (NotFound)
            {
                obj = null;
            }
           
            return obj;
        }
        public ListBase<StockTransactionSumDetail> GetDetailsByWeightIDInWeighItemResult(Guid _WeightID, bool _IsReceive)
        {
            ListBase<StockTransactionSumDetail> lobj = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransaction_SelectDetails_By_WeightID_In_WeightItemResult";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WeightID", System.Data.DbType.Guid, 16, _WeightID));
                cmd.Parameters.Add(db.CreateParameter("@IsReceive", System.Data.DbType.Boolean, 1, _IsReceive));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionDetail obj1 = new StockTransactionDetail(reader);
                    StockTransactionSumDetail obj2 = lobj.Search("ItemCode", obj1.ItemCode);
                    if (obj2 != null)
                    {
                        obj2.lstStockTransactionDetail.Add(obj1);
                        //obj2.Quantity += obj1.Quantity;
                    }
                    else
                    {
                        obj2 = new StockTransactionSumDetail();
                        obj2.ItemCode = obj1.ItemCode;
                        if (!bc.isNull("QuantityInclWrapping", reader)) obj2.QuantityInclWrapping = reader.GetDecimal(reader.GetOrdinal("QuantityInclWrapping"));
                        if (!bc.isNull("WrappingCounter", reader)) obj2.WrappingCounter = reader.GetInt32(reader.GetOrdinal("WrappingCounter"));
                        obj2.Quantity = 0;
                        obj2.lstStockTransactionDetail.Add(obj1);
                        //obj2.Quantity += obj1.Quantity;
                        lobj.Add(obj2);
                    }
                    //lobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDetailDAL", "GetDetailsByWeightIDInWeighItemResult(Guid _WeightID, bool _IsReceive)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public StockTransaction GetByGrindMaterialShiftIDFromGrindmaterials(Guid _GrindMaterialShiftID, bool _OutStock, int _TransactionType1, int _TransactionType2, byte _GenType)
        {
            DbDataReader reader = null;
            ModuleGrind moduleGrind = new ModuleBLL().GetModuleGrind();

            StockTransaction obj = new StockTransaction();
            obj.Details = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_By_GrindMaterialShiftID_From_GrindMaterialShifts";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, _GrindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.Boolean, 1, _OutStock));
                cmd.Parameters.Add(db.CreateParameter("@GenType", System.Data.DbType.Byte, 1, _GenType));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType1", System.Data.DbType.Byte, 1, (byte)_TransactionType1));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType2", System.Data.DbType.Byte, 1, (byte)_TransactionType2));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    switch (_GenType)
                    {
                        case (byte)enumStockTransactionGenType.DefaultValue:
                            break;
                        case (byte)enumStockTransactionGenType.OutMaterial:
                            break;
                        case (byte)enumStockTransactionGenType.OutFuel:
                            break;
                        case (byte)enumStockTransactionGenType.InProduct:
                            break;
                        case (byte)enumStockTransactionGenType.InWaste:
                            break;
                        case (byte)enumStockTransactionGenType.Premix_OutMaterial:
                            break;
                        case (byte)enumStockTransactionGenType.Premix_OutWrapping:
                            break;
                        case (byte)enumStockTransactionGenType.Premix_InPremix:
                            break;
                        case (byte)enumStockTransactionGenType.Grind_OutMaterial:
                            obj.TransactionTypeCode = new ModuleBLL().GetModuleGrind().StockTransType_OutMaterial;
                            obj.Description = "Xuất nghiền";
                            break;
                        case (byte)enumStockTransactionGenType.Grind_OutWrapping:
                            obj.TransactionTypeCode = new ModuleBLL().GetModuleGrind().StockTransType_OutWrapping;
                            obj.Description = "Xuất nghiền";
                            break;
                        case (byte)enumStockTransactionGenType.Grind_InMaterial:
                            obj.TransactionTypeCode = new ModuleBLL().GetModuleGrind().StockTransType_InMaterial;
                            obj.Description = "Nhập nghiền";
                            break;
                        case (byte)enumStockTransactionGenType.Grind_OutFuel:
                            obj.TransactionTypeCode = (new ModuleBLL()).GetModuleManufacture().StockTransType_OutFuel; //new ModuleBLL().GetModuleGrind().StockTransType_OutFuel;
                            obj.Description = "Xuất nghiền";
                            break;
                        default:
                            break;
                    }
                    if (_OutStock)
                    {
                        obj.OutStock = reader.GetString(reader.GetOrdinal("OutStock"));
                    }
                    else
                    {
                        obj.InStock = reader.GetString(reader.GetOrdinal("InStock"));
                    }
                    obj.TransactionNo = string.Empty;
                    
                    
                    obj.TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                    obj.Shift = reader.GetByte(reader.GetOrdinal("Shift"));
                    obj.Description += ", ca " + obj.Shift;
                    obj.ForDepartment = (byte)enumStockTransactionForDepartment.ForGrind;
                    obj.GenType = (byte)_GenType;
                    obj.Status = (byte)enumStockTransactionStatus.WaitingConfirm;
                    obj.DepartmentStatus = (byte)enumStockTransactionDepartmentStatus.Confirm;
                    obj.CreatedType = (byte)enumStockTransactionCreatedType.ByGrind;
                    obj.GenID = _GrindMaterialShiftID;
                    obj.UserUpdated = Contexts.CurrentUser.LoginName;
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                        stsd.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        stsd.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        obj.Details.Add(stsd);
                    }
                }
                obj.TransactionID = Guid.Empty;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        obj.TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                        obj.Status = reader.GetByte(reader.GetOrdinal("Status"));
                        obj.TransactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                        if (obj.Status == (byte)enumStockTransactionStatus.Confirm)
                        {
                            obj.Status = (byte)enumStockTransactionStatus.WaitingReConfirm;
                        }
                    }
                }
                if (reader.NextResult())
                {
                    ListBase<StockTransactionDetail> lstSTD = new ListBase<StockTransactionDetail>();
                    while (reader.Read())
                    {
                        StockTransactionDetail std = new StockTransactionDetail();
                        std.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        std.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        if (!reader.IsDBNull(reader.GetOrdinal("OutLocation")))
                        {
                            std.OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("InLocation")))
                        {
                            std.InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                        }
                        //std1 = obj.Details.Search("ItemCode", std.ItemCode);
                        lstSTD.Add(std);
                    }
                    int count1 = obj.Details.Count;
                    int count2 = lstSTD.Count;
                    for (int i = 0; i < count2; i++)
                    {
                        bool ItemNotFound = true;
                        for (int j = 0; j < count1; j++)
                        {
                            if (lstSTD[i].ItemCode == obj.Details[j].ItemCode)
                            {
                                ItemNotFound = false;
                                if (obj.Details[j].lstStockTransactionDetail == null)
                                {
                                    obj.Details[j].lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                                }
                                obj.Details[j].lstStockTransactionDetail.Add(lstSTD[i]);
                                j = count1;//break
                            }
                        }
                        if (ItemNotFound)
                        {
                            StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                            if (stsd.lstStockTransactionDetail == null)
                            {
                                stsd.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            }
                            stsd.lstStockTransactionDetail.Add(lstSTD[i]);
                            stsd.ItemCode = lstSTD[i].ItemCode;
                            stsd.TransactionID = lstSTD[i].TransactionID;
                            stsd.Quantity = 0;
                            stsd.QuantityReg = 0;
                            stsd.QuantityInclWrapping = 0;
                            stsd.WrappingCounter = 0;
                            stsd.PriceCost = 0;
                            stsd.AmountCost = 0;
                            stsd.PriceIn = 0;
                            stsd.AmountIn = 0;
                            stsd.PriceOut = 0;
                            stsd.AmountOut = 0;
                            obj.Details.Add(stsd);
                        }
                    }
                    //for (int i = 0; i < count1; i++)
                    //{
                    //    StockTransactionSumDetail std1 = obj.Details[i];
                    //    decimal Quantity = 0;
                    //    bool ItemNotFound = true;
                    //    for (int j = 0; j < count2; j++)
                    //    {
                    //        if (lstSTD[j].ItemCode == std1.ItemCode)
                    //        {
                    //            ItemNotFound = false;
                    //            Quantity += lstSTD[j].Quantity;
                    //        }
                    //    }
                    //    if (std1.Quantity >= Quantity && !ItemNotFound)
                    //    {
                    //        bool MustNewItem = false;
                    //        Quantity = std1.Quantity;
                    //        for (int j = 0; j < count2; j++)
                    //        {
                    //            if (lstSTD[j].ItemCode == std1.ItemCode)
                    //            {
                    //                if (MustNewItem)
                    //                {
                    //                    StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //                    std2.ItemCode = std1.ItemCode;
                    //                    std2.Quantity = lstSTD[j].Quantity;
                    //                    Quantity -= std2.Quantity;
                    //                    //std2.InLocation = lstSTD[j].InLocation;
                    //                    //std2.OutLocation = lstSTD[j].OutLocation;
                    //                    obj.Details.Add(std2);
                    //                }
                    //                else
                    //                {
                    //                    std1.Quantity = lstSTD[j].Quantity;
                    //                    Quantity -= std1.Quantity;
                    //                    //std1.InLocation = lstSTD[j].InLocation;
                    //                    //std1.OutLocation = lstSTD[j].OutLocation;
                    //                    MustNewItem = true;
                    //                }
                    //            }
                    //        }
                    //        if (Quantity > 0)
                    //        {
                    //            StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //            std2.ItemCode = std1.ItemCode;
                    //            std2.Quantity = Quantity;
                    //            obj.Details.Add(std2);
                    //        }
                    //    }
                       
                    //}
                }
                else
                {
                    obj.UserCreated = Contexts.CurrentUser.LoginName;
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByGrindMaterialShiftIDFromGrindmaterials(Guid _GrindMaterialShiftID, bool _OutStock, int _TransactionType1, int _TransactionType2, byte _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public StockTransaction GetByTransactionID(Guid transactionID)
        {
            DbDataReader reader = null;
            StockTransaction obj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Select_By_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new StockTransaction(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByGrindMaterialShiftIDFromGrindmaterials(Guid _GrindMaterialShiftID, bool _OutStock, int _TransactionType1, int _TransactionType2, byte _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public StockTransaction GetByMixPremixShiftIDFromMixPremixs(Guid _MixPremixShiftID, bool _OutStock, enumMixPremixTransactionType _TransactionType1, enumMixPremixTransactionType _TransactionType2, enumStockTransactionGenType _GenType)
        {
            DbDataReader reader = null;
            ModulePremix modulePremix = new ModuleBLL().GetModulePremix();

            StockTransaction obj = new StockTransaction();
            obj.Details = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_By_MixPremixShiftID_From_MixPremixShifts";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, _MixPremixShiftID));
                cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.Boolean, 1, _OutStock));
                cmd.Parameters.Add(db.CreateParameter("@GenType", System.Data.DbType.Byte, 1, (byte)_GenType));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType1", System.Data.DbType.Byte, 1, (byte)_TransactionType1));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType2", System.Data.DbType.Byte, 1, (byte)_TransactionType2));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    switch (_GenType)
                    {
                        case enumStockTransactionGenType.DefaultValue:
                            break;
                        case enumStockTransactionGenType.OutMaterial:
                            break;
                        case enumStockTransactionGenType.OutFuel:
                            break;
                        case enumStockTransactionGenType.InProduct:
                            break;
                        case enumStockTransactionGenType.InWaste:
                            break;
                        case enumStockTransactionGenType.Premix_OutMaterial:
                            obj.TransactionTypeCode = new ModuleBLL().GetModulePremix().StockTransType_OutMaterial;
                            obj.Description = "Xuất sơ chế";
                            break;
                        case enumStockTransactionGenType.Premix_OutWrapping:
                            obj.TransactionTypeCode = new ModuleBLL().GetModulePremix().StockTransType_OutWrapping;
                            obj.Description = "Xuất sơ chế";
                            break;
                        case enumStockTransactionGenType.Premix_InPremix:
                            obj.TransactionTypeCode = new ModuleBLL().GetModulePremix().StockTransType_InPemix;
                            obj.Description = "Nhập sơ chế";
                            break;
                        case enumStockTransactionGenType.Grind_OutMaterial:
                            break;
                        case enumStockTransactionGenType.Grind_OutWrapping:
                            break;
                        case enumStockTransactionGenType.Grind_InMaterial:
                            break;
                        default:
                            break;
                    }
                    if (_OutStock)
                    {
                        obj.OutStock = reader.GetString(reader.GetOrdinal("OutStock"));
                    }
                    else
                    {
                        obj.InStock = reader.GetString(reader.GetOrdinal("InStock"));
                    }
                    obj.TransactionNo = string.Empty;
                    //obj.Description = string.Empty;
                    obj.TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                    obj.Shift = reader.GetByte(reader.GetOrdinal("Shift"));
                    obj.Description += ", ca " + obj.Shift;
                    obj.ForDepartment = (byte)enumStockTransactionForDepartment.ForPremix;
                    obj.GenType = (byte)_GenType;
                    obj.Status = (byte)enumStockTransactionStatus.WaitingConfirm;
                    obj.DepartmentStatus = (byte)enumStockTransactionDepartmentStatus.Confirm;
                    obj.CreatedType = (byte)enumStockTransactionCreatedType.ByPremix;
                    obj.GenID = _MixPremixShiftID;
                    obj.UserUpdated = Contexts.CurrentUser.LoginName;
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                        stsd.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        stsd.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        obj.Details.Add(stsd);
                    }
                }
                obj.TransactionID = Guid.Empty;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        obj.TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                        obj.Status = reader.GetByte(reader.GetOrdinal("Status"));
                        obj.TransactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                        if (obj.Status == (byte)enumStockTransactionStatus.Confirm)
                        {
                            obj.Status = (byte)enumStockTransactionStatus.WaitingReConfirm;
                        }
                    }
                }
                if (reader.NextResult())
                {
                    ListBase<StockTransactionDetail> lstSTD = new ListBase<StockTransactionDetail>();
                    while (reader.Read())
                    {
                        StockTransactionDetail std = new StockTransactionDetail();
                        std.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        std.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        if (!reader.IsDBNull(reader.GetOrdinal("OutLocation")))
                        {
                            std.OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("InLocation")))
                        {
                            std.InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                        }
                        //std1 = obj.Details.Search("ItemCode", std.ItemCode);
                        lstSTD.Add(std);
                    }
                    int count1 = obj.Details.Count;
                    int count2 = lstSTD.Count;
                    for (int i = 0; i < count2; i++)
                    {
                        bool ItemNotFound = true;
                        for (int j = 0; j < count1; j++)
                        {
                            if (lstSTD[i].ItemCode == obj.Details[j].ItemCode)
                            {
                                ItemNotFound = false;
                                if (obj.Details[j].lstStockTransactionDetail == null)
                                {
                                    obj.Details[j].lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                                }
                                obj.Details[j].lstStockTransactionDetail.Add(lstSTD[i]);
                                j = count1;//break
                            }
                        }
                        if (ItemNotFound)
                        {
                            StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                            if (stsd.lstStockTransactionDetail == null)
                            {
                                stsd.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            }
                            stsd.lstStockTransactionDetail.Add(lstSTD[i]);
                            stsd.ItemCode = lstSTD[i].ItemCode;
                            stsd.TransactionID = lstSTD[i].TransactionID;
                            stsd.Quantity = 0;
                            stsd.QuantityReg = 0;
                            stsd.QuantityInclWrapping = 0;
                            stsd.WrappingCounter = 0;
                            stsd.PriceCost = 0;
                            stsd.AmountCost = 0;
                            stsd.PriceIn = 0;
                            stsd.AmountIn = 0;
                            stsd.PriceOut = 0;
                            stsd.AmountOut = 0;
                            obj.Details.Add(stsd);
                        }
                    }
                    //for (int i = 0; i < count1; i++)
                    //{
                    //    StockTransactionSumDetail std1 = obj.Details[i];
                    //    decimal Quantity = 0;
                    //     bool ItemNotFound = true;
                    //    for (int j = 0; j < count2; j++)
                    //    {
                    //        if (lstSTD[j].ItemCode == std1.ItemCode)
                    //        {
                    //            ItemNotFound = false;
                    //            Quantity += lstSTD[j].Quantity;
                    //        }
                    //    }
                    //    if (std1.Quantity >= Quantity && !ItemNotFound)
                    //    {
                    //        bool MustNewItem = false;
                    //        Quantity = std1.Quantity;
                    //        for (int j = 0; j < count2; j++)
                    //        {
                    //            if (lstSTD[j].ItemCode == std1.ItemCode)
                    //            {
                    //                if (MustNewItem)
                    //                {
                    //                    StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //                    std2.ItemCode = std1.ItemCode;
                    //                    std2.Quantity = lstSTD[j].Quantity;
                    //                    Quantity -= std2.Quantity;
                    //                    //std2.InLocation = lstSTD[j].InLocation;
                    //                    //std2.OutLocation = lstSTD[j].OutLocation;
                    //                    obj.Details.Add(std2);
                    //                }
                    //                else
                    //                {
                    //                    std1.Quantity = lstSTD[j].Quantity;
                    //                    Quantity -= std1.Quantity;
                    //                    //std1.InLocation = lstSTD[j].InLocation;
                    //                    //std1.OutLocation = lstSTD[j].OutLocation;
                    //                    MustNewItem = true;
                    //                }
                    //            }
                    //        }
                    //        if (Quantity > 0)
                    //        {
                    //            StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //            std2.ItemCode = std1.ItemCode;
                    //            std2.Quantity = Quantity;
                    //            obj.Details.Add(std2);
                    //        }
                    //    }
                        
                    //}
                }
                else
                {
                    obj.UserCreated = Contexts.CurrentUser.LoginName;
                }
            }
            catch(Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByMixPremixShiftIDFromMixPremixs(Guid _MixPremixShiftID, bool _OutStock, enumMixPremixTransactionType _TransactionType1, enumMixPremixTransactionType _TransactionType2, enumStockTransactionGenType _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public StockTransaction GetByManufactureShiftIDFromManufactures(Guid _ManufactureShiftID, bool _OutStock, enumManufactureTransactionType _TransactionType1, enumManufactureTransactionType _TransactionType2, enumStockTransactionGenType _GenType)
        {
            DbDataReader reader = null;
            ModuleManufacture moduleManufacture = new ModuleBLL().GetModuleManufacture();

            StockTransaction obj = new StockTransaction(); ;
            obj.Details = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_By_ManufactureShiftID_From_ManufactureShifts";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.Boolean, 1, _OutStock));
                cmd.Parameters.Add(db.CreateParameter("@GenType", System.Data.DbType.Byte, 1, (byte)_GenType));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType1", System.Data.DbType.Byte, 1, (byte)_TransactionType1));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType2", System.Data.DbType.Byte, 1, (byte)_TransactionType2));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    //if (!isNull("TransactionID", reader)) _TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                    //if (!isNull("TransactionTypeCode", reader)) _TransactionTypeCode = reader.GetString(reader.GetOrdinal("TransactionTypeCode"));
                    //if (!isNull("InStock", reader)) _InStock = reader.GetString(reader.GetOrdinal("InStock"));
                    switch (_GenType)
                    {
                        case enumStockTransactionGenType.DefaultValue:
                            break;
                        case enumStockTransactionGenType.OutMaterial:
                            obj.TransactionTypeCode = (new ModuleBLL()).GetModuleManufacture().StockTransType_OutMaterial;
                            obj.Description = "Xuất sản xuất";
                            break;
                        case enumStockTransactionGenType.OutFuel:
                            obj.TransactionTypeCode = (new ModuleBLL()).GetModuleManufacture().StockTransType_OutFuel;
                            obj.Description = "Xuất sản xuất";
                            break;
                        case enumStockTransactionGenType.InProduct:
                            obj.TransactionTypeCode = (new ModuleBLL()).GetModuleManufacture().StockTransType_InProduct;
                            obj.Description = "Nhập sản xuất";
                            break;
                        case enumStockTransactionGenType.InWaste:
                            obj.TransactionTypeCode = (new ModuleBLL()).GetModuleManufacture().StockTransType_InWaste;
                            obj.Description = "Nhập sản xuất";
                            break;
                        case enumStockTransactionGenType.Premix_OutMaterial:
                            break;
                        case enumStockTransactionGenType.Premix_OutWrapping:
                            break;
                        case enumStockTransactionGenType.Premix_InPremix:
                            break;
                        case enumStockTransactionGenType.Grind_OutMaterial:
                            break;
                        case enumStockTransactionGenType.Grind_OutWrapping:
                            break;
                        case enumStockTransactionGenType.Grind_InMaterial:
                            break;
                        default:
                            break;
                    }

                    if (_OutStock)
                    {
                        obj.OutStock = reader.GetString(reader.GetOrdinal("OutStock"));

                    }
                    else
                    {
                        obj.InStock = reader.GetString(reader.GetOrdinal("InStock"));
                    }
                    obj.TransactionNo = string.Empty;
                    //obj.Description = string.Empty;
                    //if (!isNull("TransactionNo", reader)) _TransactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                    obj.TransactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                    //if (!isNull("Description", reader)) _Description = reader.GetString(reader.GetOrdinal("Description"));
                    //if (!CheckNull("UserCreated", reader)) UserCreated = reader.GetString(reader.GetOrdinal("UserCreated"));
                    //if (!CheckNull("DateCreated", reader)) DateCreated = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                    //if (!CheckNull("UserUpdated", reader)) UserUpdated = reader.GetString(reader.GetOrdinal("UserUpdated"));
                    //if (!CheckNull("DateUpdated", reader)) DateUpdated = reader.GetDateTime(reader.GetOrdinal("DateUpdated"));
                    obj.Shift = reader.GetByte(reader.GetOrdinal("Shift"));
                    obj.Description += ", ca " + obj.Shift;
                    //obj.GenByManufacture = true;
                    obj.ForDepartment = (byte)enumStockTransactionForDepartment.ForManufacture;
                    obj.GenType = (byte)_GenType;
                    obj.Status = (byte)enumStockTransactionStatus.WaitingConfirm;
                    obj.DepartmentStatus = (byte)enumStockTransactionDepartmentStatus.Confirm;
                    obj.CreatedType = (byte)enumStockTransactionCreatedType.ByManufacture;
                    obj.GenID = _ManufactureShiftID;

                    obj.UserUpdated = Contexts.CurrentUser.LoginName;
                    //if (!isNull("GenByManufacture", reader)) _GenByManufacture = reader.GetBoolean(reader.GetOrdinal("GenByManufacture"));
                    //if (!isNull("GetByWeightItems", reader)) _GetByWeightItems = reader.GetBoolean(reader.GetOrdinal("GetByWeightItems"));
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                        stsd.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        stsd.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        //std.OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                        //std.InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                        obj.Details.Add(stsd);
                    }
                }
                obj.TransactionID = Guid.Empty;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        obj.TransactionID = reader.GetGuid(reader.GetOrdinal("TransactionID"));
                        obj.Status = reader.GetByte(reader.GetOrdinal("Status"));
                        obj.TransactionNo = reader.GetString(reader.GetOrdinal("TransactionNo"));
                        if (obj.Status == (byte)enumStockTransactionStatus.Confirm)
                        {
                            obj.Status = (byte)enumStockTransactionStatus.WaitingReConfirm;
                        }
                    }
                }
                if (reader.NextResult())
                {
                    ListBase<StockTransactionDetail> lstSTD = new ListBase<StockTransactionDetail>();
                    while (reader.Read())
                    {
                        StockTransactionDetail std = new StockTransactionDetail();
                        std.ItemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
                        std.Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
                        if (!reader.IsDBNull(reader.GetOrdinal("OutLocation")))
                        {
                            std.OutLocation = reader.GetString(reader.GetOrdinal("OutLocation"));
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("InLocation")))
                        {
                            std.InLocation = reader.GetString(reader.GetOrdinal("InLocation"));
                        }
                        //std1 = obj.Details.Search("ItemCode", std.ItemCode);
                        
                        //tri
                        std.GoodCode = reader.GetString(reader.GetOrdinal("GoodCode"));
                        //
                        lstSTD.Add(std);
                    }
                    int count1 = obj.Details.Count;
                    int count2 = lstSTD.Count;
                    for (int i = 0; i < count2; i++)
                    {
                        bool ItemNotFound = true;
                        for (int j = 0; j < count1; j++)
                        {
                            if (lstSTD[i].ItemCode == obj.Details[j].ItemCode)
                            {
                                ItemNotFound = false;
                                if (obj.Details[j].lstStockTransactionDetail == null)
                                {
                                    obj.Details[j].lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                                }
                                obj.Details[j].lstStockTransactionDetail.Add(lstSTD[i]);
                                j = count1;//break
                            }
                        }
                        if (ItemNotFound)
                        {
                            StockTransactionSumDetail stsd = new StockTransactionSumDetail();
                            if (stsd.lstStockTransactionDetail == null)
                            {
                                stsd.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            }
                            stsd.lstStockTransactionDetail.Add(lstSTD[i]);
                            stsd.ItemCode = lstSTD[i].ItemCode;
                            stsd.TransactionID = lstSTD[i].TransactionID;
                            stsd.Quantity = 0;
                            stsd.QuantityReg = 0;
                            stsd.QuantityInclWrapping = 0;
                            stsd.WrappingCounter = 0;
                            stsd.PriceCost = 0;
                            stsd.AmountCost = 0;
                            stsd.PriceIn = 0;
                            stsd.AmountIn = 0;
                            stsd.PriceOut = 0;
                            stsd.AmountOut = 0;
                            obj.Details.Add(stsd);
                        }
                    }
                    //                    for (int i = 0; i < count1; i++)
                    //                    {
                    //                        StockTransactionSumDetail std1 = obj.Details[i];
                    //                        decimal Quantity = 0;
                    //                        bool ItemNotFound = true;
                    //                        for (int j = 0; j < count2; j++)
                    //                        {
                    //                            if (lstSTD[j].ItemCode == std1.ItemCode)
                    //                            {
                    //                                ItemNotFound = false;
                    //                                if (std1.lstStockTransactionDetail == null)
                    //                                {
                    //                                    std1.lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                    //                                }
                    //                                std1.lstStockTransactionDetail.Add(lstSTD[j]);
                    //////                                Quantity += lstSTD[j].Quantity;
                    //                            }
                    //                        }

                    //                        //if (std1.Quantity >= Quantity && !ItemNotFound)
                    //                        //{
                    //                        //    bool MustNewItem = false;
                    //                        //    Quantity = std1.Quantity;
                    //                        //    for (int j = 0; j < count2; j++)
                    //                        //    {
                    //                        //        if (lstSTD[j].ItemCode == std1.ItemCode)
                    //                        //        {
                    //                        //            if (MustNewItem)
                    //                        //            {
                    //                        //                StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //                        //                std2.ItemCode = std1.ItemCode;
                    //                        //                std2.Quantity = lstSTD[j].Quantity;
                    //                        //                Quantity -= std2.Quantity;
                    //                        //                //std1.Quantity -= std2.Quantity;
                    //                        //                //std2.InLocation = lstSTD[j].InLocation;
                    //                        //                //std2.OutLocation = lstSTD[j].OutLocation;
                    //                        //                obj.Details.Add(std2);
                    //                        //            }
                    //                        //            else
                    //                        //            {
                    //                        //                std1.Quantity = lstSTD[j].Quantity;
                    //                        //                //std1.Quantity -= std2.Quantity;
                    //                        //                Quantity -= std1.Quantity;
                    //                        //                //std1.InLocation = lstSTD[j].InLocation;
                    //                        //                //std1.OutLocation = lstSTD[j].OutLocation;
                    //                        //                MustNewItem = true;
                    //                        //            }
                    //                        //        }
                    //                        //    }
                    //                        //    if (Quantity > 0)
                    //                        //    {
                    //                        //        StockTransactionSumDetail std2 = new StockTransactionSumDetail();
                    //                        //        std2.ItemCode = std1.ItemCode;
                    //                        //        std2.Quantity = Quantity;
                    //                        //        obj.Details.Add(std2);
                    //                        //    }
                    //                        //}
                    //                        ////if (std1.Quantity > Quantity)
                    //                        ////{
                    //                        ////    StockTransactionDetail std3 = new StockTransactionDetail();
                    //                        ////    std3.ItemCode = std1.ItemCode;
                    //                        ////    std3.Quantity = std1.Quantity - Quantity;
                    //                        ////    obj.Details.Add(std3);
                    //                        ////}
                    //                    }
                }
                else { obj.UserCreated = Contexts.CurrentUser.LoginName; }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByManufactureShiftIDFromManufactures(Guid _ManufactureShiftID, bool _OutStock, enumManufactureTransactionType _TransactionType1, enumManufactureTransactionType _TransactionType2, enumStockTransactionGenType _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public ListBase<StockTransactionSumDetail> GetDetailFromSaleRequest(string saleRequestNo)
        {
            DbDataReader reader = null;
            ListBase<StockTransactionSumDetail> lstReturn = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_Detail_Form_SaleRequest";
                cmd.Parameters.Add(db.CreateParameter("@SaleRequestNo", System.Data.DbType.String, 20, saleRequestNo));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionSumDetail obj = new StockTransactionSumDetail(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDetailFromSaleRequest(string saleRequestNo)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetListStockTransForAccountTrans(Guid accTransactionID)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstReturn = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_ListStockTransForAccountTrans";
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accTransactionID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetListStockTransForAccountTrans(Guid accTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetForAccountTransactionStockCheck(string transactionTypeCode, Guid accTransactionID, string donvi, string stockCode, bool inStock)
        {
            DbDataReader reader = null;
            DataTable dt = null;
            ListBase<StockTransaction> lstReturn = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_For_AccountTransactionStockCheck";
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, transactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@Donvi", System.Data.DbType.String, 20, donvi));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@InStock", System.Data.DbType.Boolean, 1, inStock));
                //reader = db.ExecuteReader(cmd);
                //while (reader.Read())
                //{
                //    StockTransaction obj = new StockTransaction(reader);
                //    lstReturn.Add(obj);
                //}
                //reader.Close();
                dt = db.ExecuteTable(cmd);
                foreach (DataRow row in dt.Rows)
                    lstReturn.Add(new StockTransaction(row));
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetForAccountTransactionStockCheck(string transactionTypeCode, Guid accTransactionID, string donvi, string stockCode, bool inStock)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetForDepartmentConfirm(string stockCode, byte department)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstReturn = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_For_Department_Confirm";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Department", System.Data.DbType.Byte, 1, department));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetForDepartmentConfirm(string stockCode, byte department)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetForDepartmentConfirmForPeriod(string stockCode, byte department, DateTime startDate, DateTime endDate)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstReturn = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_For_Department_Confirm_ForPeriod";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Department", System.Data.DbType.Byte, 1, department));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetForDepartmentConfirm(string stockCode, byte department)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetForDepartmentConfirmSales(string stockCode, byte department, DateTime startDate, DateTime endDate, string productType)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstReturn = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Select_For_Department_Confirm_Sales";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Department", System.Data.DbType.Byte, 1, department));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@ProductType", System.Data.DbType.String, 20, productType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstReturn.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetForDepartmentConfirmSales(string stockCode, byte department)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<StockTransaction> GetDataConfirm(string _StockCode)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Get_Data_Confirm";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataConfirm(string _StockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetDataConfirmForPeriod(string _StockCode, DateTime startDate, DateTime endDate)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_Get_Data_Confirm_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataConfirmForPeriod(string _StockCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetByWaitingConfirm(bool _OutStock)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_By_Waiting_Confirm";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.Boolean, 1, _OutStock));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByStockTransaction(Int16 _StockTransaction)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetDataInStock(string _StockCode, Int16 _StockTransaction)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_Data_In_Stock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, _StockTransaction));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataInStock(string _StockCode, Int16 _StockTransaction, byte _CreatedType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetDataInStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_Data_In_Stock_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, _StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    obj.ExtendFromDataReader(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataInStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetDataOutStock(string _StockCode, Int16 _StockTransaction)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_Data_Out_Stock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, _StockTransaction));
    
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataInStock(string _StockCode, Int16 _StockTransaction, byte _CreatedType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetDataOutStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_Data_Out_Stock_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, _StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, _StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    obj.ExtendFromDataReader(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetDataOutStockForPeriod(string _StockCode, Int16 _StockTransaction, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public ListBase<StockTransaction> GetData(ParameterStockTransactionGetData pstgd)
        {
            DbDataReader reader = null;
            ListBase<StockTransaction> lstst = new ListBase<StockTransaction>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Get_Data";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.Boolean, 1, pstgd.OutStock));
                cmd.Parameters.Add(db.CreateParameter("@MoveStock", System.Data.DbType.Boolean, 1, pstgd.MoveStock));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, pstgd.StockCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransaction", System.Data.DbType.Int16, 2, (Int16)pstgd.StockTransaction));
                cmd.Parameters.Add(db.CreateParameter("@CreatedType", System.Data.DbType.Byte, 1, (byte)pstgd.CreatedType));
                cmd.Parameters.Add(db.CreateParameter("@GenType1", System.Data.DbType.Byte, 1, (byte)pstgd.GenType1));
                cmd.Parameters.Add(db.CreateParameter("@GenType2", System.Data.DbType.Byte, 1, (byte)pstgd.GenType2));
                cmd.Parameters.Add(db.CreateParameter("@Status1", System.Data.DbType.Byte, 1, (byte)pstgd.Status1));
                cmd.Parameters.Add(db.CreateParameter("@Status2", System.Data.DbType.Byte, 1, (byte)pstgd.Status2));
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, pstgd.GenID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransaction obj = new StockTransaction(reader);
                    lstst.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetData(ParameterStockTransactionGetData pstgd)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }
        public int UpdateStatusAndUserCreateSTInMixPremixShift(Guid _MixPremixShiftID, byte _Status, string _UserCreateST)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_MixPremixShift_Update_Status_And_UserCreateST";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@MixPremixShiftID", System.Data.DbType.Guid, 16, _MixPremixShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Byte, 1, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserCreateST", System.Data.DbType.String, 20, _UserCreateST));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "UpdateStatusAndUserCreateSTInMixPremixShift(Guid _MixPremixShiftID, byte _Status, string _UserCreateST)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public int UpdateStatusAndUserCreateSTInGrindMaterialShift(Guid _GrindMaterialShiftID, byte _Status, string _UserCreateST)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_GrindMaterialShift_Update_Status_And_UserCreateST";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GrindMaterialShiftID", System.Data.DbType.Guid, 16, _GrindMaterialShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Byte, 1, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserCreateST", System.Data.DbType.String, 20, _UserCreateST));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "UpdateStatusAndUserCreateSTInGrindMaterialShift(Guid _GrindMaterialShiftID, byte _Status, string _UserCreateST)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public int UpdateStatusAndUserCreateSTInManufactureShift(Guid _ManufactureShiftID, byte _Status, string _UserCreateST)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_ManufactureShift_Update_Status_And_UserCreateST";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ManufactureShiftID", System.Data.DbType.Guid, 16, _ManufactureShiftID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Byte, 1, _Status));
                cmd.Parameters.Add(db.CreateParameter("@UserCreateST", System.Data.DbType.String, 20, _UserCreateST));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "UpdateStatusAndUserCreateSTInManufactureShift(Guid _ManufactureShiftID, byte _Status, string _UserCreateST)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public DataTable ReportBaocaoTonkhoNLCayhang(DateTime startDate, DateTime endDate, string stockCode, string itemType)
        {
            System.Data.DataTable returnObj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_Stock_Report_BaocaoTonkhoNLCayhang";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 50, itemType));
                returnObj = db.ExecuteTable(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "ReportBaocaoTonkhoNLCayhang(DateTime startDate, DateTime endDate, string stockCode, string itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return returnObj;
        }

        public override int Insert(StockTransaction t)
        {
            t.UserCreated = Contexts.CurrentUser.LoginName;
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, new Guid(), System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));

                if (t.InStock == string.Empty)
                { cmd.Parameters.Add(db.CreateParameter("@InStock", System.Data.DbType.String, 10, DBNull.Value)); }
                else { cmd.Parameters.Add(db.CreateParameter("@InStock", System.Data.DbType.String, 10, t.InStock)); }
                if (t.OutStock == string.Empty)
                { cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.String, 10, DBNull.Value)); }
                else { cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.String, 10, t.OutStock)); }
                cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 4, t.TransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
                //cmd.Parameters.Add(db.CreateParameter("@GenByManufacture", System.Data.DbType.Boolean, 1, t.GenByManufacture));
                cmd.Parameters.Add(db.CreateParameter("@GetByWeightItems", System.Data.DbType.Boolean, 1, t.GetByWeightItems));
                cmd.Parameters.Add(db.CreateParameter("@GetByWeightItemContainer", System.Data.DbType.Boolean, 1, t.GetByWeightItemContainer));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, t.ForDepartment));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Byte, 1, (byte)t.Status));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentStatus", System.Data.DbType.Byte, 1, t.DepartmentStatus));
                cmd.Parameters.Add(db.CreateParameter("@CreatedType", System.Data.DbType.Byte, 1, (byte)t.CreatedType));
                cmd.Parameters.Add(db.CreateParameter("@GenType", System.Data.DbType.Byte, 1, (byte)t.GenType));
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, t.GenID));
                cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                cmd.Parameters.Add(db.CreateParameter("@SoHD", System.Data.DbType.String, 20, t.SoHD));
                cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                cmd.Parameters.Add(db.CreateParameter("@SoDH", System.Data.DbType.String, 20, t.SoDH));
                cmd.Parameters.Add(db.CreateParameter("@DonviVC", System.Data.DbType.String, 10, t.DonviVC));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 100, t.PTVC));
                cmd.Parameters.Add(db.CreateParameter("@CTkemTheo", System.Data.DbType.String, 100, t.CTKemTheo));
                cmd.Parameters.Add(db.CreateParameter("@SoHoaDon", System.Data.DbType.String, 20, t.SoHoaDon));
                cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 20, t.NguoiGiaoNhan));
                if (t.VesselCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, t.VesselCode));
                }
                cmd.Parameters.Add(db.CreateParameter("@TransportRouteCode", System.Data.DbType.String, 20, t.TransportRouteCode));

                cmd.Parameters.Add(db.CreateParameter("@DonviTC", System.Data.DbType.String, 10, t.DonviTC));
                cmd.Parameters.Add(db.CreateParameter("@PTTC", System.Data.DbType.String, 50, t.PTTC));
                cmd.Parameters.Add(db.CreateParameter("@TCRouteCode", System.Data.DbType.String, 20, t.TCRouteCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                if (t.VCType!=string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@VCType", System.Data.DbType.String, 20, t.VCType));
                if (t.TCType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@TCType", System.Data.DbType.String, 20, t.TCType));
                if (t.VCItemType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@VCItemType", System.Data.DbType.String, 20, t.VCItemType));

                //cmd.Parameters.Add(db.CreateParameter("@GetByCanme", System.Data.DbType.Boolean, 1, t.GetByCanme));
                //cmd.Parameters.Add(db.CreateParameter("@CanmeStartDate", System.Data.DbType.DateTime, 8, t.CanmeStartDate));
                //cmd.Parameters.Add(db.CreateParameter("@CanmeEndDate", System.Data.DbType.DateTime, 8, t.CanmeEndDate));
                if (t.CanmeNo != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CanmeNo", System.Data.DbType.String, 50, t.CanmeNo));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                    t.TransactionID = (Guid)cmd.Parameters["@TransactionID"].Value;
                
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "Insert(StockTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Insert(t);
        }
        public int UpdateDepartmentStatus(StockTransaction t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_UpdateDepartmentStatus";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentStatus", System.Data.DbType.Byte, 1, t.DepartmentStatus));
                cmd.Parameters.Add(db.CreateParameter("@SoHoaDon", System.Data.DbType.String, 20, t.SoHoaDon));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentDescription", System.Data.DbType.String, 200, t.DepartmentDescription));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "UpdateDepartmentStatus(StockTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(StockTransaction t)
        {
            t.UserUpdated = Contexts.CurrentUser.LoginName;
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 10, t.TransactionTypeCode));
                if (t.InStock == string.Empty)
                { cmd.Parameters.Add(db.CreateParameter("@InStock", System.Data.DbType.String, 10, DBNull.Value)); }
                else { cmd.Parameters.Add(db.CreateParameter("@InStock", System.Data.DbType.String, 10, t.InStock)); }
                if (t.OutStock == string.Empty)
                { cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.String, 10, DBNull.Value)); }
                else { cmd.Parameters.Add(db.CreateParameter("@OutStock", System.Data.DbType.String, 10, t.OutStock)); }
                cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.String, 20, t.TransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 4, t.TransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
                //cmd.Parameters.Add(db.CreateParameter("@GenByManufacture", System.Data.DbType.Boolean, 1, t.GenByManufacture));
                cmd.Parameters.Add(db.CreateParameter("@GetByWeightItems", System.Data.DbType.Boolean, 1, t.GetByWeightItems));
                cmd.Parameters.Add(db.CreateParameter("@GetByWeightItemContainer", System.Data.DbType.Boolean, 1, t.GetByWeightItemContainer));
                cmd.Parameters.Add(db.CreateParameter("@ForDepartment", System.Data.DbType.Byte, 1, t.ForDepartment));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Byte, 1, (byte)t.Status));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentStatus", System.Data.DbType.Byte, 1, t.DepartmentStatus));
                cmd.Parameters.Add(db.CreateParameter("@CreatedType", System.Data.DbType.Byte, 1, (byte)t.CreatedType));
                cmd.Parameters.Add(db.CreateParameter("@GenType", System.Data.DbType.Byte, 1, (byte)t.GenType));
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, t.GenID));
                cmd.Parameters.Add(db.CreateParameter("@KhoGiaoNhan", System.Data.DbType.String, 10, t.KhoGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@DVGiao", System.Data.DbType.String, 10, t.DVGiao));
                cmd.Parameters.Add(db.CreateParameter("@SoHD", System.Data.DbType.String, 20, t.SoHD));
                cmd.Parameters.Add(db.CreateParameter("@DVNhan", System.Data.DbType.String, 10, t.DVNhan));
                cmd.Parameters.Add(db.CreateParameter("@SoDH", System.Data.DbType.String, 20, t.SoDH));
                cmd.Parameters.Add(db.CreateParameter("@DonviVC", System.Data.DbType.String, 10, t.DonviVC));
                cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 100, t.PTVC));
                cmd.Parameters.Add(db.CreateParameter("@CTkemTheo", System.Data.DbType.String, 100, t.CTKemTheo));
                cmd.Parameters.Add(db.CreateParameter("@SoHoaDon", System.Data.DbType.String, 20, t.SoHoaDon));
                cmd.Parameters.Add(db.CreateParameter("@Nguoigiaonhan", System.Data.DbType.String, 20, t.NguoiGiaoNhan));
                if (t.VesselCode == string.Empty)
                {
                    cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@VesselCode", System.Data.DbType.String, 10, t.VesselCode));
                }
                cmd.Parameters.Add(db.CreateParameter("@TransportRouteCode", System.Data.DbType.String, 20, t.TransportRouteCode));
                cmd.Parameters.Add(db.CreateParameter("@DonviTC", System.Data.DbType.String, 10, t.DonviTC));
                cmd.Parameters.Add(db.CreateParameter("@PTTC", System.Data.DbType.String, 50, t.PTTC));
                cmd.Parameters.Add(db.CreateParameter("@TCRouteCode", System.Data.DbType.String, 20, t.TCRouteCode));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                if (t.VCType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@VCType", System.Data.DbType.String, 20, t.VCType));
                if (t.TCType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@TCType", System.Data.DbType.String, 20, t.TCType));
                if (t.VCItemType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@VCItemType", System.Data.DbType.String, 20, t.VCItemType));

                //cmd.Parameters.Add(db.CreateParameter("@GetByCanme", System.Data.DbType.Boolean, 1, t.GetByCanme));
                //cmd.Parameters.Add(db.CreateParameter("@CanmeStartDate", System.Data.DbType.DateTime, 8, t.CanmeStartDate));
                //cmd.Parameters.Add(db.CreateParameter("@CanmeEndDate", System.Data.DbType.DateTime, 8, t.CanmeEndDate));
                if (t.CanmeNo != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@CanmeNo", System.Data.DbType.String, 50, t.CanmeNo));

                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "Update(StockTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public int UpdateByThumua(StockTransaction t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Update_By_Thumua";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentStatus", System.Data.DbType.Byte, 1, t.DepartmentStatus));
                cmd.Parameters.Add(db.CreateParameter("@SoHD", System.Data.DbType.String, 20, t.SoHD));
                cmd.Parameters.Add(db.CreateParameter("@Dotnhap", System.Data.DbType.Int32, 4, t.Dotnhap));
                cmd.Parameters.Add(db.CreateParameter("@DepartmentDescription", System.Data.DbType.String, 200, t.DepartmentDescription));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "UpdateByThumua(StockTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Update(t);
        }
        public override int Delete(StockTransaction t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            //if (t.GenType != (byte)enumStockTransactionGenType.DefaultValue)
            //{
            //    return -1;
            //}
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_Delete_ID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@UserDelete", System.Data.DbType.String, 20, Contexts.CurrentUser.LoginName));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "Delete(StockTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
            //return base.Delete(t);
        }
        /// <summary>
        /// Kiểm tra tạo phiếu xuất
        /// Lê Phán
        /// </summary>
        /// <param name="_ManufactureShiftID"></param>
        /// <param name="_Status"></param>
        /// <returns></returns>
        public int TestExitsStockTransactionByGenID_Status(Guid _GenID, int _Status)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;

                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_TestExits_By_GenID_Status";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, _GenID));
                cmd.Parameters.Add(db.CreateParameter("@Status", System.Data.DbType.Int32, 4, _Status));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "TestExitsStockTransactionByGenID_Status(Guid _GenID, int _Status)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
        }
        
        public int DeleteByGenID(Guid _GenID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactions_DeleteByGenID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, _GenID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionDAL", "DeleteByGenID(Guid _GenID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return iError;
         
        }
        public ListBase<StockTransactionSumDetail> GetDetailsByTransactionID(Guid _TransactionID)
        {
            DbDataReader reader = null;
            ListBase<StockTransactionSumDetail> lobj = new ListBase<StockTransactionSumDetail>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransaction_GetDetails_By_TransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, _TransactionID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    StockTransactionSumDetail obj = new StockTransactionSumDetail(reader);
                    lobj.Add(obj);
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        StockTransactionDetail obj = new StockTransactionDetail(reader);
                        StockTransactionSumDetail stsd = lobj.Search("ItemCode", obj.ItemCode);
                        if (stsd != null)
                        {
                            stsd.lstStockTransactionDetail.Add(obj);
                        }
                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        StockTransactionPurchaseDetail obj = new StockTransactionPurchaseDetail(reader);
                        StockTransactionSumDetail stsd = lobj.Search("ItemCode", obj.ItemCode);
                        if (stsd != null)
                        {
                            stsd.ListPurchaseDetail.Add(obj);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDetailDAL", "GetByTransactionID(Guid _TransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public DataTable SelectByDateAndStock(DateTime fromDate, DateTime toDate, string stockCode)
        {
            DataTable lstst = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransactions_SelectByDateAndStock";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 4, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, toDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                lstst = db.ExecuteTable(cmd);

            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "SelectByDateAndStock(DateTime fromDate, DateTime toDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstst;
        }

        public int InsertPurchaseDetail(StockTransactionPurchaseDetail t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionPurchaseDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.AnsiString, 50, t.ItemCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@PONo", System.Data.DbType.AnsiString, 20, t.PONo));
                cmd.Parameters.Add(db.CreateParameter("@WrappingCounter", System.Data.DbType.Int32, 4, t.WrappingCounter));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionPurchaseDetailDAL", "Insert(StockTransactionPurchaseDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeletePurchaseDetail(Guid transactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransactionPurchaseDetail_DeleteByTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("StockTransactionPurchaseDetailDAL", "Delete(StockTransactionPurchaseDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public DataSet SelectToCheck(DateTime startDate, DateTime endDate, string stockCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_StockTransaction_SelectToCheck";
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "SelectToCheck(DateTime startDate, DateTime endDate, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }

            return ds;
        }
        public StockTransaction GetByGenID(Guid genID, string transactionType)
        {
            DbDataReader reader = null;
            StockTransaction obj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransaction_GetByGenID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@GenID", System.Data.DbType.Guid, 16, genID));
                if (transactionType != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, transactionType));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new StockTransaction(reader);
                    if (reader.NextResult())
                    {
                        obj.Details = new ListBase<StockTransactionSumDetail>();
                        while (reader.Read())
                        {
                            StockTransactionSumDetail objD = new StockTransactionSumDetail(reader);
                            obj.Details.Add(objD);
                        }
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                StockTransactionDetail objDD = new StockTransactionDetail(reader);
                                StockTransactionSumDetail stsd = obj.Details.Search("ItemCode", objDD.ItemCode);
                                if (stsd != null)
                                {
                                    stsd.lstStockTransactionDetail.Add(objDD);
                                }
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByGrindMaterialShiftIDFromGrindmaterials(Guid _GrindMaterialShiftID, bool _OutStock, int _TransactionType1, int _TransactionType2, byte _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }

        public StockTransaction GetLastPurchase(string itemCode, string stockCode, string locationCode, DateTime date)
        {
            DbDataReader reader = null;
            StockTransaction obj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransaction_GetLastPurchase";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@LocationCode", System.Data.DbType.String, 20, locationCode));
                cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 20, date));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new StockTransaction(reader);
                    if (reader.NextResult())
                    {
                        obj.Details = new ListBase<StockTransactionSumDetail>();
                        while (reader.Read())
                        {
                            StockTransactionSumDetail objD = new StockTransactionSumDetail(reader);
                            obj.Details.Add(objD);
                        }
                        if (reader.NextResult())
                        {
                            obj.Details[0].lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            while (reader.Read())
                            {
                                StockTransactionDetail objD = new StockTransactionDetail(reader);
                                obj.Details[0].lstStockTransactionDetail.Add(objD);
                            }
                        }
                        
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetByGrindMaterialShiftIDFromGrindmaterials(Guid _GrindMaterialShiftID, bool _OutStock, int _TransactionType1, int _TransactionType2, byte _GenType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }

        public StockTransaction GetLastOutManu(string itemCode, string stockCode, DateTime date, string transactionTypeCode)
        {
            DbDataReader reader = null;
            StockTransaction obj = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_StockTransaction_GetLastOutManu";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 20, date));
                if (transactionTypeCode != string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@TransactionTypeCode", System.Data.DbType.String, 20, transactionTypeCode));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new StockTransaction(reader);
                    if (reader.NextResult())
                    {
                        obj.Details = new ListBase<StockTransactionSumDetail>();
                        while (reader.Read())
                        {
                            StockTransactionSumDetail objD = new StockTransactionSumDetail(reader);
                            obj.Details.Add(objD);
                        }
                        if (reader.NextResult())
                        {
                            obj.Details[0].lstStockTransactionDetail = new ListBase<StockTransactionDetail>();
                            while (reader.Read())
                            {
                                StockTransactionDetail objD = new StockTransactionDetail(reader);
                                obj.Details[0].lstStockTransactionDetail.Add(objD);
                            }
                        }

                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("StockTransactionDAL", "GetLastOutManu(string itemCode, string stockCode, DateTime date)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
    }
}
