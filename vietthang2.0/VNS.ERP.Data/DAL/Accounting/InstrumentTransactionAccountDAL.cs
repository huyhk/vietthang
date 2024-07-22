using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Common;
using System.Data.Common;
using VNS.Utils;
using System.Data;

namespace VNS.ERP.Data.Accounting
{
    public class InstrumentTransactionAccountDAL : BaseDAL<InstrumentTransactionAccount>
    {
        public InstrumentTransactionAccountDAL() { }
        public InstrumentTransactionAccountDAL(DBHelper dbHelper) : base(dbHelper) { }
        public ListBase<InstrumentTransactionAccount> GetByTransactionType(string transType)
        {
            ListBase<InstrumentTransactionAccount> lobj = new ListBase<InstrumentTransactionAccount>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_Instrument";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 20, transType));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    InstrumentTransactionAccount obj = new InstrumentTransactionAccount(reader);
                    lobj.Add(obj);
                }
                
                if(reader.NextResult())
                {
                    Guid accountTransactionID = Guid.NewGuid();
                    BaseClass b = new BaseClass();
                    while (reader.Read())
                    {
                        if (!b.isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
                        InstrumentTransaction obj1 = new InstrumentTransaction(reader);
                        foreach (InstrumentTransactionAccount instrTransAccount in lobj)
                        {
                            if (instrTransAccount.AccountTransactionID == accountTransactionID)
                            {
                                instrTransAccount.InstrTrans = obj1;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("InstrumentTransactionAccountDAL", "GetByTransactionType(string transType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<InstrumentTransactionAccount> GetByTransactionTypeForPeriod(string transType, DateTime startDate, DateTime endDate)
        {
            ListBase<InstrumentTransactionAccount> lobj = new ListBase<InstrumentTransactionAccount>();
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_Instrument_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 20, transType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    InstrumentTransactionAccount obj = new InstrumentTransactionAccount(reader);
                    lobj.Add(obj);
                }

                if (reader.NextResult())
                {
                    Guid accountTransactionID = Guid.NewGuid();
                    BaseClass b = new BaseClass();
                    while (reader.Read())
                    {
                        if (!b.isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
                        InstrumentTransaction obj1 = new InstrumentTransaction(reader);
                        foreach (InstrumentTransactionAccount instrTransAccount in lobj)
                        {
                            if (instrTransAccount.AccountTransactionID == accountTransactionID)
                            {
                                instrTransAccount.InstrTrans = obj1;
                            }
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("InstrumentTransactionAccountDAL", "GetByTransactionType(string transType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
        public ListBase<InstrumentTransactionAccount> GetObjectFromDataSet(DataSet ds)
        {
            ListBase<InstrumentTransactionAccount> lstobj = new ListBase<InstrumentTransactionAccount>();
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
            DataRelation drInstruTrans = ds.Relations.Add("InstruTrans",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[5].Columns["AccountTransactionID"]);
            //ds.Tables[5].Columns["TransactionID"].Unique = true;
            DataRelation drInstruTransDetail = ds.Relations.Add("InstruTransDetail",
               ds.Tables[5].Columns["TransactionID"],
               ds.Tables[6].Columns["TransactionID"]);
            //ds.Tables[6].Columns["TransactionDetailID"].Unique = true;
            DataRelation drPrepaidExpenses = ds.Relations.Add("PrepaidExpenses",
               ds.Tables[6].Columns["TransactionDetailID"],
               ds.Tables[7].Columns["InstrumentTransactionDetailID"]);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                InstrumentTransactionAccount t = new InstrumentTransactionAccount();
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
                foreach (DataRow rowInstruTrans in row.GetChildRows(drInstruTrans))
                {
                    InstrumentTransaction inStruTransAccount = new InstrumentTransaction();
                    inStruTransAccount.LoadFromDataRow(rowInstruTrans);
                    t.InstrTrans = inStruTransAccount;
                    t.InstrTrans.Detail = new ListBase<InstrumentTransactionDetail>();
                    foreach (DataRow rowInstruTransDetail in rowInstruTrans.GetChildRows(drInstruTransDetail))
                    {
                        InstrumentTransactionDetail inStruTransAccountDetail = new InstrumentTransactionDetail();
                        inStruTransAccountDetail.LoadFromDataRow(rowInstruTransDetail);
                        foreach (DataRow rowPrepaidExpenses in rowInstruTransDetail.GetChildRows(drPrepaidExpenses))
                        {
                            PrePaidExpense prepaidExp = new PrePaidExpense();
                            prepaidExp.LoadFromDataRow(rowPrepaidExpenses);
                            inStruTransAccountDetail.LstPrePaidExpense.Add(prepaidExp);
                        }
                        t.InstrTrans.Detail.Add(inStruTransAccountDetail);
                    }
                }
                lstobj.Add(t);
            }
            return lstobj;
        }
        public ListBase<InstrumentTransactionAccount> GetWithDetailByTransactionTypeForPeriod(string transType, DateTime startDate, DateTime endDate)
        {
            ListBase<InstrumentTransactionAccount> lobj=null;
            bool alreadyOpen = false;
            try
            {
                DataSet ds = null;
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_With_Detail_And_Instrument_ForPeriod";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.String, 20, transType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                ds = db.ExecuteDataSet(cmd);
                lobj = this.GetObjectFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("InstrumentTransactionAccountDAL", "GetByTransactionType(string transType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lobj;
        }
    }
}
