using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
using System.Data;
using System.Collections;
namespace VNS.ERP.Data.Manufactures
{
    public class ManufactureShiftBLL:IBusiness
    {
        private ManufactureShiftDAL dal = new ManufactureShiftDAL();
        private ManufactureShiftTransactionDAL dal1;

        public ListBase<ManufactureShift> GetByStock(string _stockCode)
        {
            return dal.GetByStockCode(_stockCode);
        }
        public int Insert(ManufactureShift t)
        {
            int iError = 0;
            bool alreadyOpen = false;
            t.UserCreated = Contexts.CurrentUser.LoginName;
            try
            {
                if (dal.DBHelper.State != System.Data.ConnectionState.Open)
                    dal.DBHelper.Open();
                else
                    alreadyOpen = true;
                dal1 = new ManufactureShiftTransactionDAL(dal.DBHelper);
                dal.BeginTransaction();
                iError = dal.Insert(t);
                if (iError == 0)
                {
                    foreach (ManufactureShiftTransaction Detail in t.ListFuelInTransaction)
                    {
                        Detail.ManufactureShiftID = t.ManufactureShiftID;
                        if (iError == 0)
                        {
                            if (Detail.Quantity > 0)
                            {
                                iError = dal1.Insert(Detail);
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
                Write2Log.WriteLogs("ManufactureShiftBLL", "Insert(ManufactureShift t)", excp.Message);
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
            return iError;
        }
        public int Update(ManufactureShift t)
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
                dal1 = new ManufactureShiftTransactionDAL(dal.DBHelper);
                dal.BeginTransaction();

                if (t.Status == 1)
                    t.Status = 2;
                iError = dal.Update(t);
                if (iError == 0)
                {
                    iError = dal1.Delete(t.ManufactureShiftID);
                    if (iError == 0)
                    {
                        foreach (ManufactureShiftTransaction Detail in t.ListFuelInTransaction)
                        {
                            Detail.ManufactureShiftID = t.ManufactureShiftID;
                            if (iError == 0)
                            {
                                if (Detail.Quantity > 0)
                                {
                                    iError = dal1.Insert(Detail);
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
                Write2Log.WriteLogs("ManufactureShiftBLL", "Update(ManufactureShift t)", excp.Message);
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
            return iError;
        }
        public int Delete(ManufactureShift t)
        {
            int iError = 0;
            dal.Open();
            dal.BeginTransaction();
            try
            {
                if (t.Status == 0)
                {
                    iError = dal.Delete(t.ManufactureShiftID);
                }
                else
                {
                    StockTransactionDAL dalTransaction = new StockTransactionDAL(dal.DBHelper);
                    iError = dalTransaction.TestExitsStockTransactionByGenID_Status(t.ManufactureShiftID, 0);
                    if (iError == 1)
                    {
                        iError = -3;
                    }
                    else
                    {
                        //delete trans
                        iError = dalTransaction.DeleteByGenID(t.ManufactureShiftID);
                        if (iError == 0)
                        {
                            iError = dal.Delete(t.ManufactureShiftID);
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

        public ListBase<ManufactureShiftTransaction> GetObjectByManutransactionShiftID(Guid manuTransactionShiftID)
        {
            dal1 = new ManufactureShiftTransactionDAL();
            return dal1.GetObjectByManutransactionShiftID(manuTransactionShiftID);
        }

        public int DivideTotalFuel(ManufactureShift t)
        {
            int iError = 0;
            decimal TotalTime = 0;
            if (t.ListFuelInTransaction.Count > 0)
            {
                foreach (Manufacture manu in t.ListManufacture)
                {
                    if (manu.LstNhienlieu == null)
                        manu.LstNhienlieu = new ListBase<ManufactureTransaction>();
                    else
                        manu.LstNhienlieu.Clear();
                    //TotalTime += manu.TotalWorkingTime;
                    TotalTime += manu.Ep;
                }
                if (TotalTime <= 0)
                {
                    return -100;
                }
                foreach (ManufactureShiftTransaction manuShiftTrans in t.ListFuelInTransaction)
                {
                    decimal TotalQuantity = 0;
                    for (int i = 0; i <= t.ListManufacture.Count - 1; i++)
                    {
                        Manufacture manu = t.ListManufacture[i];
                        ManufactureTransaction manuTrans = new ManufactureTransaction();
                        manuTrans.ManufactureID = manu.ManufactureID;
                        manuTrans.ItemCode = manuShiftTrans.ItemCode;
                        manuTrans.TransactionType = (int)enumManufactureTransactionType.FuelIn;
                        manuTrans.IsReceived = false;
                        if (i < t.ListManufacture.Count - 1)
                        {
                            manuTrans.Quantity = decimal.Round(((manuShiftTrans.Quantity * manu.Ep) / TotalTime), 2);
                            TotalQuantity += manuTrans.Quantity;

                        }
                        else
                        {
                            manuTrans.Quantity = manuShiftTrans.Quantity - TotalQuantity;
                        }
                        manu.LstNhienlieu.Add(manuTrans);

                    }
                }
                ManufactureTransactionDAL dalTran = new ManufactureTransactionDAL();
                foreach (Manufacture manu in t.ListManufacture)
                {
                    // delete ManufactureTransaction Type=enumManufactureTransactionType.FuelIn
                    iError = dalTran.Delete(manu.ManufactureID, (int)enumManufactureTransactionType.FuelIn);
                    if (iError == 0)
                    {
                        foreach (ManufactureTransaction manuTrans in manu.LstNhienlieu)
                        {
                            //insert manuTrans

                            iError = dalTran.Insert(manuTrans);
                            if (iError != 0)
                                break;
                        }
                    }
                    else
                        break;
                }
                //update Shift Status =2 if =1
                if (iError == 0)
                {
                    if (t.Status == 1)
                    {
                        t.Status = 2;
                        iError = dal.Update(t);
                    }
                }
            }
            else
                return -99;
            return iError;
        }
        public DataTable GetReportsForEmployee(string stockCode, DateTime tungay, DateTime denngay)
        {
            ListBase<Employee> lstEmployees=(new EmployeeBLL()).GetAll();
            DataSet ds = new DataSet();
            ds = dal.GetReportsManufactures(stockCode, tungay, denngay);
            DataRelation DtRelation = ds.Relations.Add("Manu",
                ds.Tables[0].Columns["ManufactureID"],
                ds.Tables[1].Columns["ManufactureID"]);

            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("Employee", typeof(string));
            dtReturn.Columns.Add("EmployeeName", typeof(string));
            dtReturn.Columns.Add("EmployeeType", typeof(int));
            dtReturn.Columns.Add("L15", typeof(decimal)).DefaultValue=0;

            dtReturn.Columns.Add("L22", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("L30", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("L40", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("L50", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("L80", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("Khac", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("TotalSL", typeof(decimal)).DefaultValue=0;
            ////
            dtReturn.Columns.Add("P1", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("P2", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("P3", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("P4", typeof(decimal)).DefaultValue=0;
            dtReturn.Columns.Add("PP", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("TotalPP", typeof(decimal)).DefaultValue=0;
            /////
            DataView dv=dtReturn.DefaultView;
            dv.Sort="Employee ASC,EmployeeType ASC";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                //ShiftLeader
                Object[] objSearch1 = new Object[2];
                objSearch1[0] = row["ShiftLeader"];
                objSearch1[1] = 1;
                int i = dv.Find(objSearch1);
                if (i >= 0)
                {

                }
                else
                {
                    
                    DataRow newRow = dtReturn.NewRow();
                    newRow["Employee"]=row["ShiftLeader"];
                    newRow["EmployeeType"]=1;
                    newRow["EmployeeName"]= lstEmployees.Search("EmployeeID", row["ShiftLeader"]).EmployeeName;
                        ///
                    dtReturn.Rows.Add(newRow);
                    i = dv.Find(objSearch1);
                }
                decimal d = 0;
                switch (row["Sizecode"].ToString())
                {
                    case "1.5":
                        d = (decimal)(dv[i]["L15"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L15"] = d;
                        break;
                    case "2.2":
                        d = (decimal)(dv[i]["L22"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L22"] = d;
                        break;
                    case "3.0":
                        d = (decimal)(dv[i]["L30"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L30"] = d;
                        break;
                    case "4.0":
                        d = (decimal)(dv[i]["L40"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L40"] = d;
                        break;
                    case "5.0":
                        d = (decimal)(dv[i]["L50"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L50"] = d;
                        break;
                    case "8.0":
                        d = (decimal)(dv[i]["L80"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L80"] = d;
                        break;
                    default:
                        d = (decimal)(dv[i]["Khac"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["Khac"] = d;
                        break;

                }
                d = 0;
                ListBase<Item> lstPhe = new ItemBLL().GetbyItemtype((int) enumItemType.Waste);
                foreach (DataRow rowTran in row.GetChildRows(DtRelation))
                {
                    if ((int)rowTran["TransactionType"] == (int)enumManufactureTransactionType.WasteOut)
                    {
                        Item it = lstPhe.Search("ItemCode", rowTran["ItemCode"].ToString());
                        if (it != null)
                        {
                            switch (it.ItemGroup)
                            {
                                case "P1":
                                    d = (decimal)(dv[i]["P1"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P1"] = d;
                                    break;
                                case "P2":
                                    d = (decimal)(dv[i]["P2"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P2"] = d;
                                    break;
                                case "P3":
                                    d = (decimal)(dv[i]["P3"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P3"] = d;
                                    break;
                                case "P4":
                                    d = (decimal)(dv[i]["P4"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P4"] = d;
                                    break;
                                case "PP":
                                    d = (decimal)(dv[i]["PP"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["PP"] = d;
                                    break;
                            }
                        }
                        //switch (rowTran["ItemCode"].ToString())
                        //{
                        //    case "06.PP01":
                        //        d = (decimal)(dv[i]["P1"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P1"] = d;
                        //        break;
                        //    case "06.PP02":
                        //        d = (decimal)(dv[i]["P2"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P2"] = d;
                        //        break;
                        //    case "06.PP03":
                        //        d = (decimal)(dv[i]["P3"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P3"] = d;
                        //        break;
                        //    case "06.PP04":
                        //        d = (decimal)(dv[i]["P4"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P4"] = d;
                        //        break;
                        //}
                    }
                }

                //Employee Ep

                Object[] objSearch2 = new Object[2];
                objSearch2[0] = row["EmployeeID2"];
                objSearch2[1] = 2;
                i = dv.Find(objSearch2);
                if (i >= 0)
                {

                }
                else
                {
                    DataRow newRow = dtReturn.NewRow();
                    newRow["Employee"] = row["EmployeeID2"];
                    newRow["EmployeeType"] = 2;
                    newRow["EmployeeName"] = lstEmployees.Search("EmployeeID", row["EmployeeID2"]).EmployeeName;

                    ///
                    dtReturn.Rows.Add(newRow);
                    i = dv.Find(objSearch2);
                   
                }
                d = 0;
                switch (row["Sizecode"].ToString())
                {
                    case "1.5":
                        d = (decimal)(dv[i]["L15"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L15"] = d;
                        break;
                    case "2.2":
                        d = (decimal)(dv[i]["L22"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L22"] = d;
                        break;
                    case "3.0":
                        d = (decimal)(dv[i]["L30"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L30"] = d;
                        break;
                    case "4.0":
                        d = (decimal)(dv[i]["L40"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L40"] = d;
                        break;
                    case "5.0":
                        d = (decimal)(dv[i]["L50"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L50"] = d;
                        break;
                    case "8.0":
                        d = (decimal)(dv[i]["L80"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L80"] = d;
                        break;
                    default:
                        d = (decimal)(dv[i]["Khac"]);
                        d +=(decimal)(row["ProductWeight"]);
                        dv[i]["Khac"] = d;
                        break;
                }
                d = 0;
                foreach (DataRow rowTran in row.GetChildRows(DtRelation))
                {
                    if ((int)rowTran["TransactionType"] == (int)enumManufactureTransactionType.WasteOut)
                    {
                        Item it = lstPhe.Search("ItemCode", rowTran["ItemCode"].ToString());
                        if (it != null)
                        {
                            switch (it.ItemGroup)
                            {
                                //case "P1":
                                //    d = (decimal)(dv[i]["P1"]);
                                //    d += (decimal)(rowTran["Quantity"]);
                                //    dv[i]["P1"] = d;
                                //    break;
                                case "P2":
                                    d = (decimal)(dv[i]["P2"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P2"] = d;
                                    break;
                                case "P3":
                                    d = (decimal)(dv[i]["P3"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P3"] = d;
                                    break;
                                case "P4":
                                    d = (decimal)(dv[i]["P4"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P4"] = d;
                                    break;
                                case "PP":
                                    d = (decimal)(dv[i]["PP"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["PP"] = d;
                                    break;
                            }
                        }
                        //switch (rowTran["ItemCode"].ToString())
                        //{
                        //    //case "06.PP01":
                        //    //    d = decimal.Parse(dv[i]["P1"].ToString());
                        //    //    d += decimal.Parse(rowTran["Quantity"].ToString());
                        //    //    dv[i]["P1"] = d;
                        //    //    break;
                        //    case "06.PP02":
                        //        d = (decimal)(dv[i]["P2"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P2"] = d;
                        //        break;
                        //    case "06.PP03":
                        //        d = (decimal)(dv[i]["P3"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P3"] = d;
                        //        break;
                        //    case "06.PP04":
                        //        d = (decimal)(dv[i]["P4"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P4"] = d;
                        //        break;
                        //}
                    }
                }


                //Employee Nghien

                Object[] objSearch3 = new Object[2];
                objSearch3[0] = row["EmployeeID1"];
                objSearch3[1] = 3;
                i = dv.Find(objSearch3);
                if (i >= 0)
                {

                }
                else
                {
                    DataRow newRow = dtReturn.NewRow();
                    newRow["Employee"] = row["EmployeeID1"];
                    newRow["EmployeeType"] = 3;
                    newRow["EmployeeName"] = lstEmployees.Search("EmployeeID", row["EmployeeID1"]).EmployeeName;
                    ///
                    dtReturn.Rows.Add(newRow);
                   i = dv.Find(objSearch3);
                }
                d = 0;
                switch (row["Sizecode"].ToString())
                {
                    case "1.5":
                        d = (decimal)(dv[i]["L15"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L15"] = d;
                        break;
                    case "2.2":
                        d = (decimal)(dv[i]["L22"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L22"] = d;
                        break;
                    case "3.0":
                        d = (decimal)(dv[i]["L30"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L30"] = d;
                        break;
                    case "4.0":
                        d = (decimal)(dv[i]["L40"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L40"] = d;
                        break;
                    case "5.0":
                        d = (decimal)(dv[i]["L50"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L50"] = d;
                        break;
                    case "8.0":
                        d = (decimal)(dv[i]["L80"]);
                        d += (decimal)(row["ProductWeight"]);
                        dv[i]["L80"] = d;
                        break;
                    default:
                        d = (decimal)(dv[i]["Khac"]);
                        d +=(decimal)(row["ProductWeight"]);
                        dv[i]["Khac"] = d;
                        break;
                }
                d = 0;
                foreach (DataRow rowTran in row.GetChildRows(DtRelation))
                {
                    if ((int)rowTran["TransactionType"] == (int)enumManufactureTransactionType.WasteOut)
                    {
                        Item it = lstPhe.Search("ItemCode", rowTran["ItemCode"].ToString());
                        if (it != null)
                        {
                            switch (it.ItemGroup)
                            {
                                case "P1":
                                    d = (decimal)(dv[i]["P1"]);
                                    d += (decimal)(rowTran["Quantity"]);
                                    dv[i]["P1"] = d;
                                    break;
                                //case "P2":
                                //    d = (decimal)(dv[i]["P2"]);
                                //    d += (decimal)(rowTran["Quantity"]);
                                //    dv[i]["P2"] = d;
                                //    break;
                                //case "P3":
                                //    d = (decimal)(dv[i]["P3"]);
                                //    d += (decimal)(rowTran["Quantity"]);
                                //    dv[i]["P3"] = d;
                                //    break;
                                //case "P4":
                                //    d = (decimal)(dv[i]["P4"]);
                                //    d += (decimal)(rowTran["Quantity"]);
                                //    dv[i]["P4"] = d;
                                //    break;
                            }
                        }
                        //switch (rowTran["ItemCode"].ToString())
                        //{
                        //    case "06.PP01":
                        //        d = (decimal)(dv[i]["P1"]);
                        //        d += (decimal)(rowTran["Quantity"]);
                        //        dv[i]["P1"] = d;
                        //        break;
                        //    //case "06.PP02":
                        //    //    d = decimal.Parse(dv[i]["P2"].ToString());
                        //    //    d += decimal.Parse(rowTran["Quantity"].ToString());
                        //    //    dv[i]["P2"] = d;
                        //    //    break;
                        //    //case "06.PP03":
                        //    //    d = decimal.Parse(dv[i]["P3"].ToString());
                        //    //    d += decimal.Parse(rowTran["Quantity"].ToString());
                        //    //    dv[i]["P3"] = d;
                        //    //    break;
                        //    //case "06.PP04":
                        //    //    d = decimal.Parse(dv[i]["P4"].ToString());
                        //    //    d += decimal.Parse(rowTran["Quantity"].ToString());
                        //    //    dv[i]["P4"] = d;
                        //    //    break;
                        //}
                    }
                }
            }
          
            foreach (DataRow dr in dtReturn.Rows)
            {
                dr["TotalSL"] =(decimal)(dr["L15"]) + (decimal)(dr["L22"]) + (decimal)(dr["L30"]) + (decimal)(dr["L40"]) + (decimal)(dr["L50"]) + (decimal)(dr["L80"]) + (decimal)(dr["Khac"]);
                dr["TotalPP"] = (decimal)(dr["P1"]) + (decimal)(dr["P2"]) + (decimal)(dr["P3"]) + (decimal)(dr["P4"]);
            }

            return dtReturn;
          
        }

        public DataTable GetReportsForLineSX(string stockCode, DateTime tungay, DateTime denngay)
        {

          
            DataSet ds = new DataSet();
            ds = dal.GetReportsManufactures(stockCode, tungay, denngay);
            DataRelation DtRelation = ds.Relations.Add("Manu",
                ds.Tables[0].Columns["ManufactureID"],
                ds.Tables[1].Columns["ManufactureID"]);
            ///////Created table temp//////////
            DataTable dtReturnTable = new DataTable();
            dtReturnTable.Columns.Add("LineSX", typeof(string));
            dtReturnTable.Columns.Add("Size", typeof(string));
            dtReturnTable.Columns.Add("Sanluong", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Dien", typeof(decimal)).DefaultValue = 0;

            dtReturnTable.Columns.Add("Dau", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Trauroi", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Haohut", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Nangxuat", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("SLNap", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Taiche", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("TotalTimeWorking", typeof(int)).DefaultValue = 0;
            /////
            DataView dv = dtReturnTable.DefaultView;
            dv.Sort = "LineSX ASC,Size ASC";
            decimal d,k,m,l=0;
            int h = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {

                if ("1.5,2.2,3.0,4.0,5.0,8.0".IndexOf(row["SizeCode"].ToString()) < 0)
                    row["SizeCode"] = "Khac";

                Object[] objSearch = new Object[2];
                objSearch[0] = row["LinesxNo"];
                

                objSearch[1] = row["SizeCode"];
                int i = dv.Find(objSearch);
                if (i >= 0)
                {

                }
                else
                {
                    DataRow newRow = dtReturnTable.NewRow();
                    newRow["LineSX"] = row["LinesxNo"];
                    
                    newRow["Size"]=row["SizeCode"];
                    ///
                    dtReturnTable.Rows.Add(newRow);
                    i = dv.Find(objSearch);
                }
              switch(row["Sizecode"].ToString())
              {
                  case "1.5":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"]=d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k +=(decimal)(row["Electricity"]);
                      dv[i]["Dien"]=k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"]=h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                   
                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"]=m;
                      break;
                  case "2.2":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k += (decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                   

                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
                  case "3.0":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k += (decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;


                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                     

                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
                  case "4.0":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k += (decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                   
                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
                  case "5.0":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k += (decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                   
                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
                  case "8.0":
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k += (decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                      h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                      
                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
                 default:
                      d = (decimal)(dv[i]["Sanluong"]);
                      d += (decimal)(row["ProductWeight"]);
                      dv[i]["Sanluong"] = d;

                      k = (decimal)(dv[i]["Dien"]);
                      if (!row.IsNull("Electricity"))
                      k +=(decimal)(row["Electricity"]);
                      dv[i]["Dien"] = k;

                      h = (int)(dv[i]["TotalTimeWorking"]);
                      if (!row.IsNull("TotalWorkingTime"))
                          h += (int)(row["TotalWorkingTime"]);
                      dv[i]["TotalTimeWorking"] = h;

                      l = (decimal)(dv[i]["Taiche"]);
                      if (!row.IsNull("Taiche"))
                      l += (decimal)(row["Taiche"]);
                      dv[i]["Taiche"] = l;
                      
                      m = (decimal)(dv[i]["SLNap"]);
                      m += (decimal)(row["Nap"]);
                      dv[i]["SLNap"] = m;
                      break;
              }
                d=0;
                k = 0;
                h = 0;
                m = 0;
                decimal o,p=0;
              foreach (DataRow rowTran in row.GetChildRows(DtRelation))
              {
                  if (int.Parse(rowTran["TransactionType"].ToString()) == (int)enumManufactureTransactionType.FuelIn && rowTran["ItemCode"].ToString().StartsWith("05.DAU"))
                  {
                      o = (decimal)(dv[i]["Dau"]);
                      o += (decimal)(rowTran["Quantity"]);
                      dv[i]["Dau"]=o;
                  }
                  if (int.Parse(rowTran["TransactionType"].ToString()) == (int)enumManufactureTransactionType.FuelIn && rowTran["ItemCode"].ToString().StartsWith("05.THAN"))
                  {
                         p = (decimal)(dv[i]["Than"]);
                         p += (decimal)(rowTran["Quantity"]);
                      dv[i]["Than"]=p;
                      
                  }
                  if (int.Parse(rowTran["TransactionType"].ToString()) == (int)enumManufactureTransactionType.FuelIn && rowTran["ItemCode"].ToString().StartsWith("05.TRAU01"))
                  {
                      p = (decimal)(dv[i]["Trauroi"]);
                      p += (decimal)(rowTran["Quantity"]);
                      dv[i]["Trauroi"] = p;

                  }    
              }
              o = 0;
              p = 0;

            }
            foreach (DataRow dr in dtReturnTable.Rows)
            {
                //if (((decimal)(dr["SLNap"]) + (decimal)(dr["Taiche"])) != 0)
                    //dr["Haohut"] = decimal.Round(1 - ((decimal)(dr["Sanluong"]) / ((decimal)(dr["SLNap"]) + (decimal)(dr["Taiche"]))), 4);
                if ((decimal)(dr["Sanluong"]) != 0)
                    dr["Haohut"] = decimal.Round(((decimal)(dr["Sanluong"]) - ((decimal)(dr["SLNap"]) + (decimal)(dr["Taiche"]))) / (decimal)(dr["Sanluong"]), 4);
                else
                    dr["Haohut"] = 0;
                if ((int)(dr["TotalTimeWorking"]) != 0)
                    dr["Nangxuat"] = decimal.Round((((decimal)(dr["Sanluong"]) / 1000) * 60) / (int)(dr["TotalTimeWorking"]), 2);
                else
                    dr["Nangxuat"] = 0.00;
            }


            //////////////////////////Created Table Return///////////////////////////

              DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("LineSX", typeof(string));
            dtReturn.Columns.Add("Loai", typeof(int));
            dtReturn.Columns.Add("Description", typeof(string));
            dtReturn.Columns.Add("L15SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L15DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L22SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L22DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L30SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L30DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L40SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L40DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L50SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L50DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L80SL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("L80DM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("KhacSL", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("KhacDM", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("Total", typeof(decimal)).DefaultValue = 0;
      
            DataView dva = dtReturn.DefaultView;
            dva.Sort = "LineSX ASC,Loai ASC ";
          
            foreach (DataRow row in dtReturnTable.Rows)
            {
         ///////////////////////
               Object[] objSearch = new Object[2];
               objSearch[0] = row["LineSX"];
               objSearch[1] = 1;
               int i = dva.Find(objSearch);
                if (i >= 0)
                {

                }
                else
                {
                    DataRow newRow = dtReturn.NewRow();
                    newRow["LineSX"] = row["LineSX"];
                    newRow["Loai"] =1;
                    newRow["Description"] ="Sản lượng(KG)";
                    ///
                    dtReturn.Rows.Add(newRow);
                    i = dva.Find(objSearch);
                }
              switch(row["Size"].ToString())
              {
                  case "1.5":
                      dva[i]["L15SL"]=row["Sanluong"];
                      break;
                  case "2.2":
                      dva[i]["L22SL"]=row["Sanluong"];
                      break;
                  case "3.0":
                      dva[i]["L30SL"]=row["Sanluong"];
                      break;
                  case "4.0":
                      dva[i]["L40SL"]=row["Sanluong"];
                      break;
                  case "5.0":
                      dva[i]["L50SL"]=row["Sanluong"];
                      break;
                  case "8.0":
                      dva[i]["L80SL"]=row["Sanluong"];
                      break;
                  default :
                      dva[i]["KhacSL"] = row["Sanluong"];
                      break;
              }
           
      ////////////////////////
              Object[] objSearch1 = new Object[2];
              objSearch1[0] = row["LineSX"];
              objSearch1[1] = 2;
              //   objSearch[2] = row["Size"];
              i = dva.Find(objSearch1);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 2;
                  newRow["Description"] = "Điện (KW)";
                  ///
                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearch1);
              }
              if ((decimal)(row["Dien"]) != 0 && (decimal)(row["Sanluong"]) != 0)
              {
                  switch (row["Size"].ToString())
                  {
                      case "1.5":
                          dva[i]["L15SL"] = row["Dien"];
                          dva[i]["L15DM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "2.2":
                          dva[i]["L22SL"] = row["Dien"];
                          dva[i]["L22DM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "3.0":
                          dva[i]["L30SL"] = row["Dien"];
                          dva[i]["L30DM"] = decimal.Round((((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"])))) * 1000), 2);
                          break;
                      case "4.0":
                          dva[i]["L40SL"] = row["Dien"];
                          dva[i]["L40DM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "5.0":
                          dva[i]["L50SL"] = row["Dien"];
                          dva[i]["L50DM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "8.0":
                          dva[i]["L80SL"] = row["Dien"];
                          dva[i]["L80DM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      default:
                          dva[i]["KhacSL"] = row["Dien"];
                          dva[i]["KhacDM"] = decimal.Round(((((decimal)(row["Dien"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                  }
              }

         ////////////////////////////////

              Object[] objSearch2 = new Object[2];
              objSearch2[0] = row["LineSX"];
              objSearch2[1] = 3;
              //   objSearch[2] = row["Size"];
              i = dva.Find(objSearch2);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 3;
                  newRow["Description"] = "Dầu (Lit)";
                  ///
                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearch2);
              }
              if ((decimal)(row["Dau"]) != 0 && (decimal)(row["Sanluong"]) != 0)
              {
                  switch (row["Size"].ToString())
                  {
                      case "1.5":
                          dva[i]["L15SL"] = row["Dau"];
                          dva[i]["L15DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "2.2":
                          dva[i]["L22SL"] = row["Dau"];
                          dva[i]["L22DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "3.0":
                          dva[i]["L30SL"] = row["Dau"];
                          dva[i]["L30DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "4.0":
                          dva[i]["L40SL"] = row["Dau"];
                          dva[i]["L40DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "5.0":
                          dva[i]["L50SL"] = row["Dau"];
                          dva[i]["L50DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "8.0":
                          dva[i]["L80SL"] = row["Dau"];
                          dva[i]["L80DM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      default:
                          dva[i]["KhacSL"] = row["Dau"];
                          dva[i]["KhacDM"] = decimal.Round(((((decimal)(row["Dau"])) / ((decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                  }
              }

              #region Than
              Object[] objSearch3 = new Object[2];
              objSearch3[0] = row["LineSX"];
              objSearch3[1] = 4;
              i = dva.Find(objSearch3);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 4;
                  newRow["Description"] = "Than (KG)";
                  ///
                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearch3);
              }
              if ((decimal)(row["Than"]) != 0 && (decimal)(row["Sanluong"])!=0)
              {
                  switch (row["Size"].ToString())
                  {
                      case "1.5":
                          dva[i]["L15SL"] = row["Than"];
                          dva[i]["L15DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "2.2":
                          dva[i]["L22SL"] = row["Than"];
                          dva[i]["L22DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "3.0":
                          dva[i]["L30SL"] = row["Than"];
                          dva[i]["L30DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "4.0":
                          dva[i]["L40SL"] = row["Than"];
                          dva[i]["L40DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "5.0":
                          dva[i]["L50SL"] = row["Than"];
                          dva[i]["L50DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "8.0":
                          dva[i]["L80SL"] = row["Than"];
                          dva[i]["L80DM"] = decimal.Round((((((decimal)(row["Than"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      default:
                          dva[i]["KhacSL"] = row["Than"];
                          dva[i]["KhacDM"] = decimal.Round(((((decimal)(row["Than"])) / (decimal)(row["Sanluong"])) * 1000), 2);
                          break;
                  }
              }

              #endregion

              #region Trauroi
              Object[] objSearchtrau = new Object[2];
              objSearchtrau[0] = row["LineSX"];
              objSearchtrau[1] = 5;
              i = dva.Find(objSearchtrau);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 5;
                  newRow["Description"] = "Trấu rời (KG)";
                  ///
                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearchtrau);
              }
              if ((decimal)(row["Trauroi"]) != 0 && (decimal)(row["Sanluong"]) != 0)
              {
                  switch (row["Size"].ToString())
                  {
                      case "1.5":
                          dva[i]["L15SL"] = row["Trauroi"];
                          dva[i]["L15DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "2.2":
                          dva[i]["L22SL"] = row["Trauroi"];
                          dva[i]["L22DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "3.0":
                          dva[i]["L30SL"] = row["Trauroi"];
                          dva[i]["L30DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "4.0":
                          dva[i]["L40SL"] = row["Trauroi"];
                          dva[i]["L40DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "5.0":
                          dva[i]["L50SL"] = row["Trauroi"];
                          dva[i]["L50DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      case "8.0":
                          dva[i]["L80SL"] = row["Trauroi"];
                          dva[i]["L80DM"] = decimal.Round((((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"]))) * 1000), 2);
                          break;
                      default:
                          dva[i]["KhacSL"] = row["Trauroi"];
                          dva[i]["KhacDM"] = decimal.Round(((((decimal)(row["Trauroi"])) / (decimal)(row["Sanluong"])) * 1000), 2);
                          break;
                  }
              }

              #endregion
              //////////////////////
              decimal totalSLNap = 0;
              decimal totalSLTaiche = 0;
              decimal totalSanluong = 0;
              int totalWorkingTimes = 0;
              Object[] objSearch4 = new Object[2];
              objSearch4[0] = row["LineSX"];
              objSearch4[1] = 6;
              i = dva.Find(objSearch4);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 6;
                  newRow["Description"] = "Hao hụt (%)";
                  foreach (DataRow var in dtReturnTable.Rows)
                  {
                      if (var["LineSX"].Equals(row["LineSX"]))
                      {
                          totalSLNap += (decimal)var["SLNap"];
                          totalSLTaiche += (decimal)var["Taiche"];
                          totalSanluong += (decimal)var["Sanluong"];
                          totalWorkingTimes += (int)var["TotalTimeWorking"];
                      }
                  }

                  //if (totalSLNap + totalSLTaiche != 0)
                  //    newRow["Total"] = decimal.Round(1 - (totalSanluong / (totalSLNap + totalSLTaiche)), 4);

                  if (totalSanluong != 0)
                      newRow["Total"] = decimal.Round((totalSanluong - (totalSLNap + totalSLTaiche)) / totalSanluong, 4);
                  else
                      newRow["Total"] = 0;
              
                  ///
                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearch4);
              }
              switch (row["Size"].ToString())
              {
                  case "1.5":
                      dva[i]["L15SL"] = row["Haohut"];
                   
                      break;
                  case "2.2":
                      dva[i]["L22SL"] = row["Haohut"];
                    
                      break;
                  case "3.0":
                      dva[i]["L30SL"] = row["Haohut"];
                     
                      break;
                  case "4.0":
                      dva[i]["L40SL"] = row["Haohut"];

                      break;
                  case "5.0":
                      dva[i]["L50SL"] = row["Haohut"];
                    
                      break;
                  case "8.0":
                      dva[i]["L80SL"] = row["Haohut"];
                      
                      break;
                  default:
                      dva[i]["KhacSL"] = row["Haohut"];
                      break;
              }
        //////////////////////
            
              Object[] objSearch5 = new Object[2];
              objSearch5[0] = row["LineSX"];
              objSearch5[1] = 7;
              i = dva.Find(objSearch5);
              if (i >= 0)
              {

              }
              else
              {
                  DataRow newRow = dtReturn.NewRow();
                  newRow["LineSX"] = row["LineSX"];
                  newRow["Loai"] = 7;
                  newRow["Description"] = "Năng xuất (T/H)";
                  ///
                  if (totalWorkingTimes != 0)
                      newRow["Total"] = decimal.Round(((totalSanluong / 1000) * 60) / totalWorkingTimes, 2);
                  else
                      newRow["Total"] = 0.00;

                  dtReturn.Rows.Add(newRow);
                  i = dva.Find(objSearch5);
              }
              switch (row["Size"].ToString())
              {
                  case "1.5":
                      dva[i]["L15SL"] = row["Nangxuat"];

                      break;
                  case "2.2":
                      dva[i]["L22SL"] = row["Nangxuat"];

                      break;
                  case "3.0":
                      dva[i]["L30SL"] = row["Nangxuat"];

                      break;
                  case "4.0":
                      dva[i]["L40SL"] = row["Nangxuat"];

                      break;
                  case "5.0":
                      dva[i]["L50SL"] = row["Nangxuat"];

                      break;
                  case "8.0":
                      dva[i]["L80SL"] = row["Nangxuat"];

                      break;
                  default:
                      dva[i]["KhacSL"] = row["Nangxuat"];
                      break;
              }

        //////////////////////////////
          }
          foreach (DataRow dr in dtReturn.Rows)
          {
              if (int.Parse(dr["Loai"].ToString()) == 1 || int.Parse(dr["Loai"].ToString()) == 2 || int.Parse(dr["Loai"].ToString()) == 3 || int.Parse(dr["Loai"].ToString()) == 4 || int.Parse(dr["Loai"].ToString()) == 5)
              dr["Total"] = (decimal)(dr["L15SL"]) + (decimal)(dr["L22SL"]) + (decimal)(dr["L30SL"]) +(decimal)(dr["L40SL"]) + (decimal)(dr["L50SL"]) + (decimal)(dr["L80SL"]) + (decimal)(dr["KhacSL"]);
          }

          return ConvertTableForDataString(dtReturn); ;

        }

        private DataTable ConvertTableForDataString(DataTable dtIn)
        {
            DataTable dtOut = new DataTable();
            dtOut.Columns.Add("LineSX", typeof(string));
            dtOut.Columns.Add("Loai", typeof(int));
            dtOut.Columns.Add("Description", typeof(string));
            dtOut.Columns.Add("L15SL", typeof(string));
            dtOut.Columns.Add("L15DM", typeof(string));
            dtOut.Columns.Add("L22SL", typeof(string));
            dtOut.Columns.Add("L22DM", typeof(string));
            dtOut.Columns.Add("L30SL", typeof(string));
            dtOut.Columns.Add("L30DM", typeof(string));
            dtOut.Columns.Add("L40SL", typeof(string));
            dtOut.Columns.Add("L40DM", typeof(string));
            dtOut.Columns.Add("L50SL", typeof(string));
            dtOut.Columns.Add("L50DM", typeof(string));
            dtOut.Columns.Add("L80SL", typeof(string));
            dtOut.Columns.Add("L80DM", typeof(string));
            dtOut.Columns.Add("KhacSL", typeof(string));
            dtOut.Columns.Add("KhacDM", typeof(string));
            dtOut.Columns.Add("Total", typeof(string));
            foreach(DataRow dr in dtIn.Rows)
            {
                if (int.Parse(dr["Loai"].ToString()) == 1 || int.Parse(dr["Loai"].ToString()) == 2 || int.Parse(dr["Loai"].ToString()) == 3 || int.Parse(dr["Loai"].ToString()) == 4 || int.Parse(dr["Loai"].ToString()) == 5)
                {
                    DataRow drO = dtOut.NewRow();
                    drO["LineSX"] = dr["LineSX"];
                    drO["Loai"] = dr["Loai"];
                    drO["Description"] = dr["Description"];
                    drO["L15SL"] = ((decimal)(dr["L15SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["L15DM"]) == 0)
                        drO["L15DM"] = "";
                    else
                        drO["L15DM"] = ((decimal)(dr["L15DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["L22SL"] = ((decimal)(dr["L22SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["L22DM"]) == 0)
                        drO["L22DM"] = "";
                    else
                        drO["L22DM"] =((decimal)(dr["L22DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["L30SL"] = ((decimal)(dr["L30SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if((decimal)(dr["L30DM"]) == 0)
                        drO["L30DM"] = "";
                    else
                        drO["L30DM"] = ((decimal)(dr["L30DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["L40SL"] = ((decimal)(dr["L40SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["L40DM"]) == 0)
                        drO["L40DM"] = "";
                    else
                        drO["L40DM"] = ((decimal)(dr["L40DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["L50SL"] = ((decimal)(dr["L50SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["L50DM"]) == 0)
                        drO["L50DM"] = "";
                    else
                        drO["L50DM"] = ((decimal)(dr["L50DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["L80SL"] = ((decimal)(dr["L80SL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["L80DM"]) == 0)
                        drO["L80DM"] = "";
                    else
                        drO["L80DM"] = ((decimal)(dr["L80DM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["KhacSL"] = ((decimal)(dr["KhacSL"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    if ((decimal)(dr["KhacDM"]) == 0)
                        drO["KhacDM"] = "";
                    else
                        drO["KhacDM"] = ((decimal)(dr["KhacDM"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);

                    drO["Total"] = ((decimal)(dr["Total"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    dtOut.Rows.Add(drO);
                }
                decimal d = 0;
                if (int.Parse(dr["Loai"].ToString()) == 6)
                {
                    DataRow drO1 = dtOut.NewRow();
                    drO1["LineSX"] = dr["LineSX"];
                    drO1["Loai"] = dr["Loai"];
                    drO1["Description"] = dr["Description"];

                    d = (decimal)(dr["L15SL"]) * 100;
                    if (d == 0)
                        drO1["L15SL"] = "";
                    else
                        drO1["L15SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";
                    drO1["L15DM"] = (decimal)(dr["L15DM"]);
                    d = (decimal)(dr["L22SL"]) * 100;

                    if (d == 0)
                        drO1["L22SL"] = "";
                    else
                        drO1["L22SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";
                drO1["L22DM"] = ((decimal)(dr["L22DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    d=(decimal)(dr["L30SL"])*100;

                    if (d == 0)
                        drO1["L30SL"] = "";
                    else
                        drO1["L30SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";
                drO1["L30DM"] = ((decimal)(dr["L30DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                d = (decimal)(dr["L40SL"]) * 100;
                    if (d == 0)
                        drO1["L40SL"] = "";
                    else
                        drO1["L40SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";

                drO1["L40DM"] =((decimal)(dr["L40DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    d= (decimal)(dr["L50SL"])*100;
                    if (d == 0)
                        drO1["L50SL"] = "";
                    else
                        drO1["L50SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";

                drO1["L50DM"] = ((decimal)(dr["L50DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ); ;
                    d=(decimal)(dr["L80SL"])*100;

                    if (d == 0)
                        drO1["L80SL"] = "";
                    else
                        drO1["L80SL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";

                drO1["L80DM"] = ((decimal)(dr["L80DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    d=((decimal)(dr["KhacSL"]))*100;
                    if (d == 0)
                        drO1["KhacSL"] = "";
                    else
                        drO1["KhacSL"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";

                drO1["KhacDM"] = ((decimal)(dr["KhacDM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                d = ((decimal)(dr["Total"])) * 100;
                if (d == 0)
                    drO1["Total"] = "";
                else
                    drO1["Total"] = d.ToString(AppConfigs.CONFIG_QUANTITYFORMAT) + "%";


              //  drO1["Total"] = ((decimal)(dr["Total"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);
                    dtOut.Rows.Add(drO1);
                }
                if (int.Parse(dr["Loai"].ToString()) == 7)
                {
                    DataRow drO2 = dtOut.NewRow();
                    drO2["LineSX"] = dr["LineSX"];
                    drO2["Loai"] = dr["Loai"];
                    drO2["Description"] = dr["Description"];

                    if ((decimal)(dr["L15SL"]) == 0)
                        drO2["L15SL"] = "";
                    else
                        drO2["L15SL"] = ((decimal)(dr["L15SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["L15DM"]) == 0)
                        drO2["L15DM"] = "";
                    else
                        drO2["L15DM"] = ((decimal)(dr["L15DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["L22SL"]) == 0)
                        drO2["L22SL"] = "";
                    else
                        drO2["L22SL"] = ((decimal)(dr["L22SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["L22DM"]) == 0)
                        drO2["L22DM"] = "";
                    else
                        drO2["L22DM"] = ((decimal)(dr["L22DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["L30SL"]) == 0)
                        drO2["L30SL"] = "";
                    else
                        drO2["L30SL"] = ((decimal)(dr["L30SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["L30DM"]) == 0)
                        drO2["L30DM"] = "";
                    else
                        drO2["L30DM"] = ((decimal)(dr["L30DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["L40SL"]) == 0)
                        drO2["L40SL"] = "";
                    else
                        drO2["L40SL"] = ((decimal)(dr["L40SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["L40DM"]) == 0)
                        drO2["L40DM"] = "";
                    else
                        drO2["L40DM"] = ((decimal)(dr["L40DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["L50SL"]) == 0)
                        drO2["L50SL"] = "";
                    else
                        drO2["L50SL"] =((decimal)(dr["L50SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if (decimal.Parse(dr["L50DM"].ToString()) == 0)
                        drO2["L50DM"] = "";
                    else
                        drO2["L50DM"] =((decimal)(dr["L50DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["L80SL"]) == 0)
                        drO2["L80SL"] = "";
                    else
                        drO2["L80SL"] = ((decimal)(dr["L80SL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["L80DM"]) == 0)
                        drO2["L80DM"] = "";
                    else
                        drO2["L80DM"] = ((decimal)(dr["L80DM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["KhacSL"]) == 0)
                        drO2["KhacSL"] = "";
                    else
                        drO2["KhacSL"] = ((decimal)(dr["KhacSL"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    if ((decimal)(dr["KhacDM"]) == 0)
                        drO2["KhacDM"] = "";
                    else
                        drO2["KhacDM"] = ((decimal)(dr["KhacDM"])).ToString(AppConfigs.CONFIG_AMOUNTVNFORMATZ);

                    if ((decimal)(dr["Total"]) == 0)
                        drO2["Total"] = "";
                    else
                        drO2["Total"] = ((decimal)(dr["Total"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                 //   drO2["Total"] = ((decimal)(dr["Total"])).ToString(AppConfigs.CONFIG_QUANTITYFORMAT);
                    dtOut.Rows.Add(drO2);
                }
            }
            return dtOut;
        }


        public ListBase<ManufactureShift> GetObjectByTimeStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            return dal.GetObjectByTimeStockCode(startDate, endDate, stockCode);
        }

        public DataSet GetReportsManufacturesByTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo)
        {
            return dal.GetReportsManufacturesByTime(stockCode, startDate, endDate, lineSxNo);
        }
        public DataSet GetReportsManufacturesTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo)
        {
            return dal.GetReportsManufacturesTime(stockCode, startDate, endDate, lineSxNo);
        }
        public DataTable GetObjectReportsManufacturesByTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo)
        {
            return GetObjectReportsManufacturesByTime(stockCode, startDate, endDate, lineSxNo, false);
        }
        public DataTable GetObjectReportsManufacturesByTime(string stockCode, DateTime startDate, DateTime endDate, string lineSxNo, bool getKCSTest)
        {
            ListBase<Employee> lstEmployees = null;
            lstEmployees = new EmployeeBLL().GetAll();
            decimal totalThan = 0, totalThantrau = 0, totalTrauroi = 0;
            decimal totalDau = 0;
            decimal totalP1, totalP2, totalP3, totalP4 = 0, totalP0 = 0, totalP5 = 0, totalPP = 0;
            string domin500 = "", domin315 = "", domin250 = "", domin1000 = "", domin1400 = "", domin180 = "", domin125 = "";
            DataSet ds = new DataSet();
            ds = dal.GetReportsManufacturesByTime(stockCode, startDate, endDate, lineSxNo, getKCSTest);
            DataRelation DtRelation = ds.Relations.Add("Manu",
                ds.Tables[0].Columns["ManufactureID"],
                ds.Tables[1].Columns["ManufactureID"]);
            ///////Created table temp//////////
            DataTable dtReturnTable = new DataTable();
            dtReturnTable.Columns.Add("PlanNo", typeof(string));
            dtReturnTable.Columns.Add("FabNo", typeof(string));
            dtReturnTable.Columns.Add("ManufactureDate", typeof(DateTime));
            dtReturnTable.Columns.Add("ShiftLeader", typeof(string));
            dtReturnTable.Columns.Add("ViceLeader", typeof(string)).DefaultValue = "";
            dtReturnTable.Columns.Add("Electricity", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than01", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than02", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than03", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than04", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Than05", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Trauroi", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Dau", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Thantrau", typeof(decimal)).DefaultValue = 0;

            dtReturnTable.Columns.Add("Shift", typeof(int)).DefaultValue = 1;
            dtReturnTable.Columns.Add("LinesxNo", typeof(string)).DefaultValue = "1";
            dtReturnTable.Columns.Add("EmployeeID1", typeof(string));
            dtReturnTable.Columns.Add("EmployeeID2", typeof(string));
            dtReturnTable.Columns.Add("ProductCode", typeof(string));
            dtReturnTable.Columns.Add("SizeCode", typeof(string));
            dtReturnTable.Columns.Add("FormulaCode", typeof(string));

            dtReturnTable.Columns.Add("ProductWeight", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Lot", typeof(string)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Nap", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Dieuchinh", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("DieuchinhBB", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Ep", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Taiche", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("TaicheP0", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("TPXuly", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Phepham", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("WeightCode", typeof(string));
            dtReturnTable.Columns.Add("CodeBaoTP", typeof(string));
            dtReturnTable.Columns.Add("BaoSp02", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp05", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp10", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp25", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp40", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp400", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoSp500", typeof(decimal)).DefaultValue = 0;

            dtReturnTable.Columns.Add("BaoSpXA", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoTPXL", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("BaoHong", typeof(decimal)).DefaultValue = 0;
            //dtReturnTable.Columns.Add("BaoSD25", typeof(decimal)).DefaultValue = 0;
            //dtReturnTable.Columns.Add("BaoSD40", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P0", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P1", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P2", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P3", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P4", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("P5", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("PP", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Doam", typeof(string));
            dtReturnTable.Columns.Add("Domin", typeof(string));
            dtReturnTable.Columns.Add("Domin500", typeof(string));
            dtReturnTable.Columns.Add("Domin315", typeof(string));
            dtReturnTable.Columns.Add("Domin250", typeof(string));
            dtReturnTable.Columns.Add("Domin1000", typeof(string));
            dtReturnTable.Columns.Add("Domin1400", typeof(string));
            dtReturnTable.Columns.Add("Domin180", typeof(string));
            dtReturnTable.Columns.Add("Domin125", typeof(string));
            dtReturnTable.Columns.Add("Docung", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Tytrong", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Tilebot", typeof(string));
            dtReturnTable.Columns.Add("StartTime", typeof(DateTime));
            dtReturnTable.Columns.Add("EndTime", typeof(DateTime));
            dtReturnTable.Columns.Add("DelayTime", typeof(int)).DefaultValue = 0;
            dtReturnTable.Columns.Add("TotalWorkingTime", typeof(int)).DefaultValue = 0;
            dtReturnTable.Columns.Add("WrappingWaste", typeof(decimal)).DefaultValue = 0;
            dtReturnTable.Columns.Add("Description", typeof(string));
        
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                decimal totalDieuchinh = 0, totalDieuchinhBB = 0;
                totalDau = 0;
                totalThan = 0;
                totalThantrau = 0;
                totalTrauroi = 0;
                totalP1 = 0; totalP2 = 0; totalP3 = 0; totalP4 = 0; totalP0 = 0; totalP5 = 0; totalPP = 0;
                decimal totalTaiche = 0, totalTPXuly = 0, totalTaicheP0 = 0;
                decimal totalThan01 = 0, totalThan02 = 0, totalThan03 = 0, totalThan04 = 0, totalThan05 = 0;
                DataRow rowNew = dtReturnTable.NewRow();
                rowNew["PlanNo"] = row["PlanNo"];
                rowNew["FabNo"] = row["FabNo"];
                rowNew["ManufactureDate"] = row["ManufactureDate"];
                rowNew["ShiftLeader"] = lstEmployees.Search("EmployeeID", row["ShiftLeader"]).EmployeeName;
                Employee em = lstEmployees.Search("EmployeeID", row["ViceLeader"]);
                if (em != null)
                    rowNew["ViceLeader"] = em.EmployeeName;
                rowNew["Electricity"] = row["Electricity"];
                foreach (DataRow dr in row.GetChildRows(DtRelation))// ds.Tables[1].Rows)
                {
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.AdjustIn)
                    {
                        //if (dr["ItemCode"].ToString().StartsWith("04.")
                        //    || dr["ItemCode"].ToString().StartsWith("24.")
                        //    || dr["ItemCode"].ToString().StartsWith("34."))
                        if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Product)
                        {
                            totalTPXuly += (decimal)dr["Quantity"];
                            //row["Nap"] = (decimal)row["Nap"] - (decimal)dr["Quantity"];
                        }
                        else if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Waste)
                        {
                            if (dr["ItemGroup"].ToString() == "P0")
                                totalTaicheP0 += (decimal)dr["Quantity"];
                            else
                                totalTaiche += (decimal)dr["Quantity"];
                            //row["Nap"] = (decimal)row["Nap"] - (decimal)dr["Quantity"];
                        }
                        else
                        {
                            if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Wrapping || Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.WrappingMaterial)
                                totalDieuchinhBB += (decimal)dr["Quantity"];
                            else
                                totalDieuchinh += (decimal)dr["Quantity"];
                        }
                    }
                    //if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.AdjustIn)
                    //{
                        
                    //}
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.FuelIn && dr["ItemCode"].ToString().StartsWith("05.THAN"))
                    {
                        totalThan += (decimal)dr["Quantity"];
                        if (dr["ItemCode"].ToString().Equals("05.THAN01"))
                            totalThan01 += (decimal)dr["Quantity"];
                        if (dr["ItemCode"].ToString().Equals("05.THAN02"))
                            totalThan02 += (decimal)dr["Quantity"];
                        if (dr["ItemCode"].ToString().Equals("05.THAN03"))
                            totalThan03 += (decimal)dr["Quantity"];
                        if (dr["ItemCode"].ToString().Equals("05.THAN04"))
                            totalThan04 += (decimal)dr["Quantity"];
                        if (dr["ItemCode"].ToString().Equals("05.THAN05"))
                            totalThan05 += (decimal)dr["Quantity"];
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.FuelIn && dr["ItemCode"].ToString().StartsWith("05.CUITRA"))
                    {
                        totalThantrau += (decimal)dr["Quantity"];
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.FuelIn && dr["ItemCode"].ToString().StartsWith("05.TRAU01"))
                    {
                        totalTrauroi += (decimal)dr["Quantity"];
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.FuelIn && dr["ItemCode"].ToString().StartsWith("05.DAU"))
                    {
                        totalDau += (decimal)dr["Quantity"];
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.WasteOut)
                    {
                        switch (dr["ItemGroup"].ToString())
                        {
                            case "P0":
                                totalP0 += (decimal)dr["Quantity"];
                                break;
                            case "P1":
                                totalP1 += (decimal)dr["Quantity"];
                                break;
                            case "P2":
                                totalP2 += (decimal)dr["Quantity"];
                                break;
                            case "P3":
                                totalP3 += (decimal)dr["Quantity"];
                                break;
                            case "P4":
                                totalP4 += (decimal)dr["Quantity"];
                                break;
                            case "P5":
                                totalP5 += (decimal)dr["Quantity"];
                                break;
                            case "PP":
                                totalPP += (decimal)dr["Quantity"];
                                break;
                        }
                        //if (dr["ItemCode"].ToString().Length == 7)
                        //{
                        //    if (dr["ItemCode"].ToString().StartsWith("06.PP"))
                        //    {
                        //        switch (dr["ItemCode"].ToString().Substring(6, 1))
                        //        {
                        //            case "1":
                        //                totalP1 += (decimal)dr["Quantity"];
                        //                break;
                        //            case "2":
                        //                totalP2 += (decimal)dr["Quantity"];
                        //                break;
                        //            case "3":
                        //                totalP3 += (decimal)dr["Quantity"];
                        //                break;
                        //            case "4":
                        //                totalP4 += (decimal)dr["Quantity"];
                        //                break;
                        //        }
                        //    }
                        //}
                        //if (dr["ItemCode"].ToString().Length >= 5)
                        //{
                        //    switch (dr["ItemCode"].ToString().Substring(0, 5))
                        //    {
                        //        case "06.P1":
                        //            totalP1 += (decimal)dr["Quantity"];
                        //            break;
                        //        case "06.P2":
                        //            totalP2 += (decimal)dr["Quantity"];
                        //            break;
                        //        case "06.P3":
                        //            totalP3 += (decimal)dr["Quantity"];
                        //            break;
                        //        case "06.P4":
                        //            totalP4 += (decimal)dr["Quantity"];
                        //            break;
                        //    }
                        //}
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.WasteIn)
                    {
                        //if (dr["ItemCode"].ToString().StartsWith("06.") || dr["ItemCode"].ToString().StartsWith("26.") ||
                        //    dr["ItemCode"].ToString().StartsWith("36."))
                        //if ((int)dr["ItemType"] == (int)enumItemType.Waste)
                        //    totalTaiche += (decimal)dr["Quantity"];
                        //if (dr["ItemCode"].ToString().StartsWith("VT") || dr["ItemCode"].ToString().StartsWith("TN"))
                        if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Product)
                            totalTPXuly += (decimal)dr["Quantity"];
                        else if (dr["ItemGroup"].ToString() == "P0")
                            totalTaicheP0 += (decimal)dr["Quantity"];
                        else
                            totalTaiche += (decimal)dr["Quantity"];

                        
                    }
                    if ((int)dr["TransactionType"] == (int)enumManufactureTransactionType.MaterialIn)
                    {
                        if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Product)
                        {
                            totalTPXuly += (decimal)dr["Quantity"];
                            row["Nap"] = (decimal)row["Nap"] - (decimal)dr["Quantity"];
                        }
                        if (Convert.ToInt32(dr["ItemType"]) == (int)enumItemType.Waste)
                        {
                            if (dr["ItemGroup"].ToString() == "P0")
                                totalTaicheP0 += (decimal)dr["Quantity"];
                            else
                                totalTaiche += (decimal)dr["Quantity"];
                            row["Nap"] = (decimal)row["Nap"] - (decimal)dr["Quantity"];
                        }
                    }
                    
                }
                rowNew["Dieuchinh"] = totalDieuchinh;
                rowNew["DieuchinhBB"] = totalDieuchinhBB;
                rowNew["P0"] = totalP0;
                rowNew["P1"] = totalP1;
                rowNew["P2"] = totalP2;
                rowNew["P3"] = totalP3;
                rowNew["P4"] = totalP4;
                rowNew["P5"] = totalP5;
                rowNew["PP"] = totalPP;
                if (row["WeightCode"].Equals("400"))
                {
                    rowNew["BaoSp400"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 400;
                    //rowNew["BaoSD40"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("500"))
                {
                    rowNew["BaoSp500"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 500;
                    //rowNew["BaoSD40"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("40"))
                {
                    rowNew["BaoSp40"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 40;
                    //rowNew["BaoSD40"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("25"))
                {
                    rowNew["BaoSp25"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 25;
                    //rowNew["BaoSD25"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("05"))
                {
                    rowNew["BaoSp05"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 5;
                    //rowNew["BaoSD25"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("10"))
                {
                    rowNew["BaoSp10"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 10;
                    //rowNew["BaoSD25"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("02"))
                {
                    rowNew["BaoSp02"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    rowNew["BaoTPXL"] = totalTPXuly / 2;
                    //rowNew["BaoSD25"] = row["Wrapping"];
                }
                if (row["WeightCode"].Equals("XA"))
                {
                    rowNew["BaoSpXA"] = (decimal)row["ProductWeight"] - totalTPXuly;
                    //rowNew["BaoTPXL"] = totalTPXuly / 2;
                    //rowNew["BaoSD25"] = row["Wrapping"];
                }

                rowNew["BaoHong"] = row["WrappingWaste"];
                rowNew["Than"] = totalThan;
                rowNew["Than01"] = totalThan01;
                rowNew["Than02"] = totalThan02;
                rowNew["Than03"] = totalThan03;
                rowNew["Than04"] = totalThan04;
                rowNew["Than05"] = totalThan05;
                rowNew["Dau"] = totalDau;
                rowNew["Thantrau"] = totalThantrau;
                rowNew["Trauroi"] = totalTrauroi;
                rowNew["Shift"] = row["Shift"];
                rowNew["LinesxNo"] = row["LinesxNo"];
                rowNew["EmployeeID1"] = lstEmployees.Search("EmployeeID", row["EmployeeID1"]).EmployeeName;
                rowNew["EmployeeID2"] = lstEmployees.Search("EmployeeID", row["EmployeeID2"]).EmployeeName;
                rowNew["ProductCode"] = row["ProductCode"];
                rowNew["SizeCode"] = row["SizeCode"];
                rowNew["FormulaCode"] = row["FormulaCode"];
                rowNew["ProductWeight"] = row["ProductWeight"];
                rowNew["Lot"] = row["Lot"];
                rowNew["Nap"] = row["Nap"];
                rowNew["Ep"] = row["Ep"];
                //rowNew["Taiche"] = row["Taiche"];
                rowNew["Taiche"] = totalTaiche;
                rowNew["TaicheP0"] = totalTaicheP0;
                rowNew["TPXuly"] = totalTPXuly;
                rowNew["Phepham"] = row["Phepham"];
                rowNew["WeightCode"] = row["WeightCode"];
                rowNew["CodeBaoTP"] = row["CodeBaoTP"];
                rowNew["Tilebot"] = row["Tilebot"];
                rowNew["Doam"] = row["Am"];
                rowNew["Domin"] = row["Domin"];
                getDomin(row["Domin"].ToString(), out domin1400, out domin1000, out domin500, out domin315, out domin250, out domin180, out domin125);
                rowNew["Domin500"] = domin500;
                rowNew["Domin315"] = domin315;
                rowNew["Domin250"] = domin250;
                rowNew["Domin1000"] = domin1000;
                rowNew["Domin1400"] = domin1400;
                rowNew["Domin180"] = domin180;
                rowNew["Domin125"] = domin125;

                rowNew["Docung"] = row["Docung"];
                rowNew["Tytrong"] = row["Tytrong"];

                rowNew["StartTime"] = row["StartTime"];
                rowNew["EndTime"] = row["EndTime"];
                rowNew["DelayTime"] = row["DelayTime"];
                rowNew["Electricity"] = row["Electricity"];
                rowNew["TotalWorkingTime"] = row["TotalWorkingTime"];
                rowNew["WrappingWaste"] = row["WrappingWaste"];
                rowNew["Description"] = row["Description"];
                dtReturnTable.Rows.Add(rowNew);
            }
            return dtReturnTable;
        }
        private void getDomin(string domin, out string domin1400, out string domin1000, out string domin500, out string domin315, out string domin250, out string domin180, out string domin125)
        {
            domin500 = "";
            domin315 = "";
            domin250 = "";
            domin1000 = "";
            domin1400 = "";
            domin180 = "";
            domin125 = "";
            int t,n=1;
            for (int i = 0; i < domin.Length; i++)
            {
                if (int.TryParse(domin[i].ToString(), out t))
                {
                    switch (n)
                    {
                        case 1:
                            domin1400 += t.ToString().Trim();
                            break;
                        case 2:
                            domin1000 += t.ToString().Trim();
                            break;
                        case 3:
                            domin500 += t.ToString().Trim();
                            break;
                        case 4:
                            domin315 += t.ToString().Trim();
                            break;
                        case 5:
                            domin250 += t.ToString().Trim();
                            break;
                        case 6:
                            domin180 += t.ToString().Trim();
                            break;
                        case 7:
                            domin125 += t.ToString().Trim();
                            break;
                    }
                }
                else
                {
                    n++;
                    if (n == 8)
                        break;
                    //if (domin1400 != "" && domin1000 == "")
                    //    n = 2;
                    //if (domin1000 != "" && domin500 == "")
                    //    n = 3;
                    //if (domin500 != "" && domin315 == "")
                    //    n = 4;
                    //if (domin315 != "" && domin250 == "")
                    //    n = 5;
                    //if (domin250 != "" && domin180 == "")
                    //    n = 6;
                    //if (domin180 != "" && domin125 == "")
                    //    n = 7;
                    //if (domin125 != "")
                    //    break;
                }
            }
        }

        #region IBusiness Members

        public int Insert(object obj)
        {
            return this.Insert(obj as ManufactureShift);
        }

        public int Update(object obj)
        {
            return this.Update(obj as ManufactureShift);
        }

        public int Delete(object obj)
        {
            return this.Delete(obj as ManufactureShift);
        }

        #endregion


        #region WS
        public ListBase<ManufactureShift> Search(string searchString)
        {
            ListBase<ManufactureShift> obj = null;
            //try
            //{
                string[] st = searchString.Split(' ');
                DateTime date = new DateTime(Convert.ToInt32(st[0].Substring(4, 2)) + 2000,
                    Convert.ToInt32(st[0].Substring(2, 2)), Convert.ToInt32(st[0].Substring(0, 2)));
                string lineNo = st[1].Substring(1, st[1].Length - 4);
                int lot = Convert.ToInt32(st[1].Substring(st[1].Length - 3, 3));

                obj = GetByLot(searchString);

                ListBase<Item> lstItem = new ItemBLL().GetAll();
                foreach (ManufactureShift ms in obj)
                    foreach (ManuTranCompare mn in ms.ObjManufacture.LstManuTranCompare)
                    {
                        Item it = lstItem.Search("ItemCode", mn.ItemCode);
                        if (it != null)
                            mn.ItemName = it.ItemName;
                    }


            //}
            //catch { }
            return obj;

        }

        ListBase<ManufactureShift> GetByLot(string searchString)//DateTime date, string lineNo, int lot)
        {
            string[] st = searchString.Split(' ');
            DateTime date = new DateTime(Convert.ToInt32(st[0].Substring(4, 2)) + 2000,
                Convert.ToInt32(st[0].Substring(2, 2)), Convert.ToInt32(st[0].Substring(0, 2)));
            string lineNo = st[1].Substring(1, st[1].Length - 4);
            string lot1 = st[1].Substring(st[1].Length - 3, 3);
            int lot = Convert.ToInt32(lot1);

            ListBase<ManufactureShift> lst = GetObjectByTimeStockCode(date.AddDays(-1), date.AddDays(10), "");
            ListBase<ManufactureShift> obj = new ListBase<ManufactureShift>();
            ListBase<Employee> lstEmployee = new EmployeeBLL().GetAll();
            Employee e = null;
            foreach (ManufactureShift ms in lst)
            {
                

                foreach (Manufacture m in ms.ListManufacture)
                {
                    if (m.LinesxNo == lineNo && m.CodeBaoTP.Length > 6 && m.CodeBaoTP.Substring(0, 6) == st[0])
                    {
                        int i = Convert.ToInt32(m.CodeBaoTP.Substring(9, 3));
                        int ii = Convert.ToInt32(m.CodeBaoTP.Substring(13, 3));
                        if (lot >= i && lot <= ii)
                        {
                            e = lstEmployee.Search("EmployeeID", ms.ShiftLeader);
                            if (e != null)
                                ms.ShiftLeaderName = e.EmployeeName;
                            e = lstEmployee.Search("EmployeeID", ms.ViceLeader);
                            if (e != null)
                                ms.ViceLeaderName = e.EmployeeName;

                            obj.Add(ms);
                            ManufactureBLL mBLL = new ManufactureBLL();
                            mBLL.GetManufactureDetail(m);
                            m.ListWasteOrg = mBLL.GetWasteOrg(m.ManufactureID);
                            RefreshCompare(m);
                            ms.ObjManufacture = m;

                            ms.ListFuelInTransaction = null;
                            ms.ListManufacture = null;
                            e = lstEmployee.Search("EmployeeID", m.EmployeeID1);
                            if (e != null)
                                m.EmployeeID1Name = e.EmployeeName;
                            e = lstEmployee.Search("EmployeeID", m.EmployeeID2);
                            if (e != null)
                                m.EmployeeID2Name = e.EmployeeName;

                            m.Lot = lot1;
                        }
                    }
                }
            }
            return obj;
        }
        public ListBase<ManufactureShift> GetHeaderByProductCode(string searchString)//DateTime date, string lineNo, int lot)
        {
            string[] st = searchString.Split(' ');
            DateTime date = new DateTime(Convert.ToInt32(st[0].Substring(4, 2)) + 2000,
                Convert.ToInt32(st[0].Substring(2, 2)), Convert.ToInt32(st[0].Substring(0, 2)));
            string lineNo = st[1].Substring(1, st[1].Length - 4);
            string lot1 = st[1].Substring(st[1].Length - 3, 3);
            int lot = Convert.ToInt32(lot1);

            ListBase<ManufactureShift> lst = GetObjectByTimeStockCode(date.AddDays(-1), date.AddDays(10), "");
            ListBase<ManufactureShift> obj = new ListBase<ManufactureShift>();
            foreach (ManufactureShift ms in lst)
            {


                foreach (Manufacture m in ms.ListManufacture)
                {
                    if (m.LinesxNo == lineNo && m.CodeBaoTP.Length > 6 && m.CodeBaoTP.Substring(0, 6) == st[0])
                    {
                        int i = Convert.ToInt32(m.CodeBaoTP.Substring(9, 3));
                        int ii = Convert.ToInt32(m.CodeBaoTP.Substring(13, 3));
                        if (lot >= i && lot <= ii)
                        {

                            obj.Add(ms);
                            ms.ObjManufacture = m;
                            try
                            {
                                m.Lot = Convert.ToString(Convert.ToInt32(m.Lot.Substring(0, 3)) + (lot - i)).PadLeft(3, '0');
                                m.CodePremix = m.CodePremix.Substring(0, 13) + Convert.ToString(Convert.ToInt32(m.CodePremix.Substring(13, 4)) + (lot - i)).PadLeft(4, '0');
                            }
                            catch { }
                        }
                    }
                }
            }
            return obj;
        }
        public void RefreshCompare(Manufacture mn)
        {
            if (mn.LstManuTranCompare == null)
                mn.LstManuTranCompare = new ListBase<ManuTranCompare>();
            else
                mn.LstManuTranCompare.Clear();
            ProductFormulaDetailBLL _ProductFormulaDetailBLL = new ProductFormulaDetailBLL();
            DataTable dt;
            dt = _ProductFormulaDetailBLL.GetDetailForWeight(mn.ProductCode, mn.FormulaCode, mn.Nap);
            
            
            foreach (ManufactureTransaction mt in mn.LstMaterialIn)
            {
                ManuTranCompare cp = new ManuTranCompare();
                cp.ItemCode = mt.ItemCode;
                cp.Quantity = mt.Quantity;
                mn.LstManuTranCompare.Add(cp);
            }
            foreach (ManufactureTransaction mt in mn.LstDieuchinh)
            {
                ManuTranCompare cp = mn.LstManuTranCompare.Search("ItemCode", mt.ItemCode);
                if (cp == null)
                {
                    cp = new ManuTranCompare();
                    cp.ItemCode = mt.ItemCode;
                    mn.LstManuTranCompare.Add(cp);
                }
                cp.Quantity += mt.Quantity;
            }
            foreach (DataRow row in dt.Rows)
            {
                string itemCode = (string)row["MaterialCode"];
                decimal quantity = (decimal)row["Weight"];

                ManuTranCompare cp = mn.LstManuTranCompare.Search("ItemCode", itemCode);
                if (cp == null)
                {
                    cp = new ManuTranCompare();
                    cp.ItemCode = itemCode;
                    mn.LstManuTranCompare.Add(cp);
                }
                cp.FormulaQuantity = quantity;

            }
        }
        #endregion
    }
}
