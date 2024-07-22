using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Common;
using System.Data;
using System.Data.Common;
using VNS.Utils;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockNewDAL : BaseDAL<AccountTransactionStockNew>
    {
        public AccountTransactionStockNewDAL() { }
        public AccountTransactionStockNewDAL(DBHelper dbHelper) : base(dbHelper) { }
        public AccountTransactionStock SelectAccTransStockByAccountTransactionID(Guid accountTransactionID)
        {
            AccountTransactionStock obj = new AccountTransactionStock();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionStock_Select_By_AccountTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransactionStock(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectAccTransStockByAccountTransactionID(Guid accountTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        public ListBase<AccountTransactionStockNew> SelectWithAccountTransactionStock(string accountTransTypeCode, string stockTransTypeCode)
        {
            ListBase<AccountTransactionStockNew> lobj = new ListBase<AccountTransactionStockNew>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_AccountTransactionStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransTypeCode", System.Data.DbType.String, 20, accountTransTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransTypeCode", System.Data.DbType.String, 10, stockTransTypeCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountTransactionStockNew obj = new AccountTransactionStockNew(reader);
                    lobj.Add(obj);
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        AccountTransactionStock obj1 = new AccountTransactionStock(reader);
                        foreach (AccountTransactionStockNew obj in lobj)
                        {
                            if (obj.AccountTransactionID == obj1.AccountTransationID)
                            {
                                obj.AccTransactionStock = obj1;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectWithAccountTransactionStock(string accountTransTypeCode, string stockTransTypeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<AccountTransactionStockNew> GetObjectFromDataSet(DataSet ds)
        {
            ListBase<AccountTransactionStockNew> lstobj = new ListBase<AccountTransactionStockNew>();
            DataRelation drDetail1 = ds.Relations.Add("Detail1",
                   ds.Tables[0].Columns["AccountTransactionID"],
                   ds.Tables[1].Columns["AccountTransactionID"]);
            DataRelation drDetail2 = ds.Relations.Add("Detail2",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[2].Columns["AccountTransactionID"]);
            DataRelation drInvoice = ds.Relations.Add("Invoice",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[3].Columns["AccountTransactionID"]);
            DataRelation drBuyNoInvoice = ds.Relations.Add("BuyNoInvoice",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[4].Columns["AccountTransactionID"]);
            DataRelation drTransStock = ds.Relations.Add("TransStock",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[5].Columns["AccountTransationID"]);
            DataRelation drTransStockDetails = ds.Relations.Add("TransStockDetail",
               ds.Tables[5].Columns["AccountTransationID"],
               ds.Tables[6].Columns["AccountTransactionID"]);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                AccountTransactionStockNew t = new AccountTransactionStockNew();
                t.LoadFromDataRow(row);
                t.Detail1 = new ListBase<AccountTransactionDetail1>();
                t.Detail2 = new ListBase<AccountTransactionDetail2>();
                t.Invoice = new ListBase<Invoice>();
                t.BuyNoInvoice = new ListBase<BuyNoInvoice>();
                foreach (DataRow rowDetail1 in row.GetChildRows(drDetail1))
                {
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.LoadFromDataRow(rowDetail1);
                    t.Detail1.Add(atd1);
                }
                foreach (DataRow rowDetail2 in row.GetChildRows(drDetail2))
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.LoadFromDataRow(rowDetail2);
                    t.Detail2.Add(atd2);
                }
                foreach (DataRow rowInvoice in row.GetChildRows(drInvoice))
                {
                    Invoice inv = new Invoice();
                    inv.LoadFromDataRow(rowInvoice);
                    t.Invoice.Add(inv);
                }
                foreach (DataRow rowInvoice in row.GetChildRows(drBuyNoInvoice))
                {
                    BuyNoInvoice inv = new BuyNoInvoice();
                    inv.LoadFromDataRow(rowInvoice);
                    t.BuyNoInvoice.Add(inv);
                }
                foreach (DataRow rowTransStock in row.GetChildRows(drTransStock))
                {
                    AccountTransactionStock accTransStock = new AccountTransactionStock();
                    accTransStock.LoadFromDataRow(rowTransStock);
                    t.AccTransactionStock = accTransStock;
                    t.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                    foreach(DataRow rowAccTransStockDetail in rowTransStock.GetChildRows(drTransStockDetails))
                    {
                        AccountTransactionStockDetail accTransStockDetail = new AccountTransactionStockDetail();
                        accTransStockDetail.LoadFromDataRow(rowAccTransStockDetail);
                        t.AccTransactionStock.Detail.Add(accTransStockDetail);
                    }
                }
                lstobj.Add(t);
            }
            return lstobj;
        }
        public ListBase<AccountTransactionStockNew> SelectWithDetailAndAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            ListBase<AccountTransactionStockNew> lobj = null;
            bool alreadyOpen = false;
            try
            {
                DataSet ds = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_Detail_And_AccountTransactionStock_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransTypeCode", System.Data.DbType.String, 20, accountTransTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransTypeCode", System.Data.DbType.String, 10, stockTransTypeCode));
                if (branchCode != "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, branchCode));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);
                lobj = this.GetObjectFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectWithAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<AccountTransactionStockNew> SelectWithDetail1AndAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            ListBase<AccountTransactionStockNew> lobj = new ListBase<AccountTransactionStockNew>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_Detail1_And_AccountTransactionStock_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransTypeCode", System.Data.DbType.String, 20, accountTransTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransTypeCode", System.Data.DbType.String, 10, stockTransTypeCode));
                if (branchCode != "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, branchCode));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountTransactionStockNew obj = new AccountTransactionStockNew(reader);
                    obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                    lobj.Add(obj);
                }
                int count = lobj.Count;
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        AccountTransactionDetail1 objDetail1 = new AccountTransactionDetail1(reader);
                        for (int i = 0; i < count; i++)
                        {
                            AccountTransactionStockNew obj = lobj[i];
                            if (obj.AccountTransactionID == objDetail1.AccountTransactionID)
                            {
                                obj.Detail1.Add(objDetail1);
                                i = count;
                            }
                        }
                    }
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        AccountTransactionStock obj1 = new AccountTransactionStock(reader);
                        for (int i = 0; i < count; i++)
                        {
                            AccountTransactionStockNew obj = lobj[i];
                            if (obj.AccountTransactionID == obj1.AccountTransationID)
                            {
                                obj.AccTransactionStock = obj1;
                                i = count;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectWithAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<AccountTransactionStockNew> SelectWithAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            ListBase<AccountTransactionStockNew> lobj = new ListBase<AccountTransactionStockNew>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_AccountTransactionStock_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransTypeCode", System.Data.DbType.String, 20, accountTransTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransTypeCode", System.Data.DbType.String, 10, stockTransTypeCode));
                if (branchCode != "")
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, branchCode));
                }
                else
                {
                    cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountTransactionStockNew obj = new AccountTransactionStockNew(reader);
                    lobj.Add(obj);
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        AccountTransactionStock obj1 = new AccountTransactionStock(reader);
                        foreach (AccountTransactionStockNew obj in lobj)
                        {
                            if (obj.AccountTransactionID == obj1.AccountTransationID)
                            {
                                obj.AccTransactionStock = obj1;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectWithAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<AccountTransactionStockNew> SelectByStockTransTypeDateSpecialTypeWithAccTransStock(string accTypeCode, string stockTransType, string specialType, DateTime startDate, DateTime endDate)
        {
            ListBase<AccountTransactionStockNew> lobj = new ListBase<AccountTransactionStockNew>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_StockTransType_Date_SpecialType_With_AccTransStock";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransType", System.Data.DbType.String, 10, stockTransType));
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, specialType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountTransactionStockNew obj = new AccountTransactionStockNew(reader);
                    lobj.Add(obj);
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        AccountTransactionStock obj1 = new AccountTransactionStock(reader);
                        foreach (AccountTransactionStockNew obj in lobj)
                        {
                            if (obj.AccountTransactionID == obj1.AccountTransationID)
                            {
                                obj.AccTransactionStock = obj1;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "SelectByStockTransTypeDateSpecialTypeWithAccTransStock(string accTypeCode, string stockTransType, string specialType, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public AccountTransactionStockNew GetByStockTransactionID(Guid stockTransactionID)
        {
            AccountTransactionStockNew obj = null;
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_AccTransStock_StockTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockTransactionID", System.Data.DbType.Guid, 16, stockTransactionID));
                reader = db.ExecuteReader(cmd);
                if(reader.Read())
                {
                    obj = new AccountTransactionStockNew(reader);
                }
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        AccountTransactionStock obj1 = new AccountTransactionStock(reader);
                        obj.AccTransactionStock = obj1;
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionStockNewDAL", "GetByStockTransactionID(Guid stockTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
    }
}
