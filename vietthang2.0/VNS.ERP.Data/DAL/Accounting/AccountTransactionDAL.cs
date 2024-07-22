using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.DAL;
using VNS.Utils;
using VNS.ERP.Data;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionDAL<T> : StockBaseDAL<T>
        where T : AccountTransaction, new()
    {
        public AccountTransactionDAL()
        {
        }
        public AccountTransactionDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountTransactions_SelectAll";
            _spSelectDynamic = "usp_AccountTransactions_SelectDynamic";
        }
       
       
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(T t)
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
                cmd.CommandText = "usp_AccountTransactions_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, 0, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, t.AccountTransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionNo", System.Data.DbType.String, 20, t.AccountTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDate", System.Data.DbType.DateTime, 8, t.AccountTransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@PersonName", System.Data.DbType.String, 50, t.PersonName));
                cmd.Parameters.Add(db.CreateParameter("@Address", System.Data.DbType.String, 100, t.Address));
                cmd.Parameters.Add(db.CreateParameter("@CTKemtheo", System.Data.DbType.String, 50, t.CTKemtheo));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@NgayCT", System.Data.DbType.DateTime, 4, t.NgayCT));
                if(t.SubjectCode1==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, t.SubjectCode1));
                if (t.SubjectCode2 == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode2", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode2", System.Data.DbType.String, 10, t.SubjectCode2));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                if(t.DetailTransactionCode==string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, t.DetailTransactionCode));
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, t.SpecialType));

                cmd.Parameters.Add(db.CreateParameter("@SoHopdong", System.Data.DbType.String, 50, t.SoHopdong));


                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.AccountTransactionID = (Guid)cmd.Parameters["@AccountTransactionID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDAL", "Insert(AccountTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        /// <summary>
        /// Updates an existing object in database by calling Update StoredProcedure
        /// </summary>
        public override int Update(T t)
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
                cmd.CommandText = "usp_AccountTransactions_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, t.AccountTransactionTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionNo", System.Data.DbType.String, 20, t.AccountTransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionDate", System.Data.DbType.DateTime, 8, t.AccountTransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@PersonName", System.Data.DbType.String, 50, t.PersonName));
                cmd.Parameters.Add(db.CreateParameter("@Address", System.Data.DbType.String, 100, t.Address));
                cmd.Parameters.Add(db.CreateParameter("@CTKemtheo", System.Data.DbType.String, 50, t.CTKemtheo));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@NgayCT", System.Data.DbType.DateTime, 4, t.NgayCT));
                if (t.SubjectCode1 == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, t.SubjectCode1));
                if (t.SubjectCode2 == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode2", System.Data.DbType.String, 10, DBNull.Value));
                else
                    cmd.Parameters.Add(db.CreateParameter("@SubjectCode2", System.Data.DbType.String, 10, t.SubjectCode2));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                if (t.DetailTransactionCode == string.Empty)
                    cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 10, DBNull.Value));
                else
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, t.DetailTransactionCode));
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, t.SpecialType));

                cmd.Parameters.Add(db.CreateParameter("@SoHopdong", System.Data.DbType.String, 50, t.SoHopdong));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDAL", "Update(AccountTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>
        public override int Delete(T t)
        {
            return this.Delete(t.AccountTransactionID);
        }
        public decimal GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            decimal result = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_CloseAmount_For_AccountCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SpecialTypeNotCalculate", System.Data.DbType.String, 50, specialTypeNotCalculate));
                cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.Decimal, 9, 0, ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return result;
        }
        public decimal GetCloseAmount(string accountCode, string prefixAccountNotCalculate, DateTime startDate, DateTime endDate)
        {
            decimal result = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_CloseAmount_For_AccountCode2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@PrefixAccountNotCalculate", System.Data.DbType.String, 4, prefixAccountNotCalculate));
                cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.Decimal, 9, 0, ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate, string specialTypeNotCalculate, string prefixAccountNotCalculate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return result;
        }
        public decimal GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate)
        {
            decimal result = 0;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_CloseAmount_For_AccountCode1";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.String, 10, accountCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@Result", System.Data.DbType.Decimal, 9, 0, ParameterDirection.Output));
                db.ExecuteNonQuery(cmd);
                result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetCloseAmount(string accountCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return result;
        }
        public DataSet GetCloseAmount(DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            //decimal result = 0;
            bool alreadyOpen = false;
            DataSet ds = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_CloseAmount_For_5678Account";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SpecialTypeNotCalculate", System.Data.DbType.String, 50, specialTypeNotCalculate));
                ds = db.ExecuteDataSet(cmd);
                //result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetCloseAmount(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet GetCloseAmount5678(string prefixAccount, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)
        {
            //decimal result = 0;
            bool alreadyOpen = false;
            DataSet ds = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_CloseAmount_For_Or_5678Account";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@PrefixAccount", System.Data.DbType.String, 5, prefixAccount));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SpecialTypeNotCalculate", System.Data.DbType.String, 50, specialTypeNotCalculate));
                ds = db.ExecuteDataSet(cmd);
                //result = (decimal)cmd.Parameters["@Result"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetCloseAmount5678(string prefixAccount, DateTime startDate, DateTime endDate, string specialTypeNotCalculate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid accountTransactionID)
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
                cmd.CommandText = "usp_AccountTransactions_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                db.ExecuteNonQuery(cmd);
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("AccountTransactionDAL", "Delete(AccountTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        public ListBase<T> SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_SpecialType_And_Date";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, specialType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    T obj = new T();
                    obj.FromDataReader(reader);
                    lstobj.Add(obj);
                }

                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        public ListBase<T> SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate, string prefixAccount)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_SpecialType_And_Date_And_PrefixAccount";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, specialType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                cmd.Parameters.Add(db.CreateParameter("@PrefixAccount", System.Data.DbType.String, 1, prefixAccount));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    T obj = new T();
                    obj.FromDataReader(reader);
                    lstobj.Add(obj);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "SelectBySpecialTypeAndDate(string specialType, DateTime startDate, DateTime endDate, string prefixAccount)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        public ListBase<T> SelectBySpecialTypeStockCodeAndDate(string specialType, string stockCode, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_SpecialType_StockCode_And_Date";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SpecialType", System.Data.DbType.String, 50, specialType));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    T obj = new T();
                    obj.FromDataReader(reader);
                    lstobj.Add(obj);
                }

                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "SelectBySpecialTypeStockCodeAndDate(string specialType, string stockCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        //public AccountTransaction 
        /// <summary>
        /// Get object ListBase AccountTransaction by AccountTransactionTypeCode
        /// </summary>
        /// <param name="accTypeCode"></param>
        public ListBase<T> GetAccountTransactionByTypeCode(string accTypeCode)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select_By_TypeCode";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    T obj = new T();
                    obj.FromDataReader(reader);
                    lstobj.Add(obj);
                }

                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", " GetAccountTransactionByTypeCode(string accTypeCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        /// <summary>
        /// Get object ListBase AccountTransaction by AccountTransactionTypeCode and Time
        /// </summary>
        /// <param name="accTypeCode"></param>
        public ListBase<T> GetObjectByTypeCodeTime(string accTypeCode,DateTime startDate,DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            try
            {
                DataSet ds;
                //DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select_ListObjects";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                //reader = db.ExecuteReader(cmd);
                //while (reader.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(reader);
                //    lstobj.Add(obj);
                //}

                //reader.Close();
                ds = db.ExecuteDataSet(cmd);
                lstobj = GetObjectFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", " GetObjectByTypeCodeTime(string accTypeCode,DateTime startDate,DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        public ListBase<T> GetObjectFromDataSet(DataSet ds)
        {
            ListBase<T> lstobj = new ListBase<T>();
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
            DataRelation drTienvay = ds.Relations.Add("Tienvay",
               ds.Tables[0].Columns["AccountTransactionID"],
               ds.Tables[5].Columns["AccountTransactionID"]);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                T t = new T();
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
                DataRow[] dr = row.GetChildRows(drTienvay);
                if (dr.Length > 0)
                    t.Tienvay = new AccountTransactionTienvay(dr[0]);
                lstobj.Add(t);
            }
            return lstobj;
        }
        /// <summary>
        /// Get object ListBase AccountTransaction by AccountTransactionTypeCode ,Time and Subject
        /// </summary>
        /// <param name="accTypeCode"></param>
        public ListBase<T> GetObjectBySubject(string accTypeCode, DateTime startDate, DateTime endDate,string subjectCode1)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            try
            {
                //DbDataReader reader = null;
                DataSet ds;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select_ListObjects";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, subjectCode1));
                //reader = db.ExecuteReader(cmd);
                ds = db.ExecuteDataSet(cmd);

                lstobj = GetObjectFromDataSet(ds);
                //while (reader.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(reader);
                //    lstobj.Add(obj);
                //}

                //reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetObjectBySubject(string accTypeCode, DateTime startDate, DateTime endDate,string subjectCode1)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        public DataSet GetDSBySubject(string accTypeCode, DateTime startDate, DateTime endDate, string subjectCode1)
        {
            bool alreadyOpen = false;
            DataSet ds=null;
            try
            {
                //DbDataReader reader = null;
                
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select_ListObjects";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, subjectCode1));
                //reader = db.ExecuteReader(cmd);
                ds = db.ExecuteDataSet(cmd);

                
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetObjectBySubject(string accTypeCode, DateTime startDate, DateTime endDate,string subjectCode1)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        /// <summary>
        /// Get object ListBase AccountTransaction by AccountTransactionTypeCode, Time, Subject and DetailTransactionCode.
        /// </summary>
        /// <param name="accTypeCode"></param>
        public ListBase<T> GetObjectBySubjectAndDetail(string accTypeCode, DateTime startDate, DateTime endDate, string subjectCode1, string detailTransactionCode)
        {
            bool alreadyOpen = false;
            ListBase<T> lstobj = new ListBase<T>();
            try
            {
                DataSet ds;
                //DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select_ListObjects";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode1", System.Data.DbType.String, 10, subjectCode1));
                cmd.Parameters.Add(db.CreateParameter("@DetailTransactionCode", System.Data.DbType.String, 20, detailTransactionCode));
                //reader = db.ExecuteReader(cmd);
                //while (reader.Read())
                //{
                //    T obj = new T();
                //    obj.FromDataReader(reader);
                //    lstobj.Add(obj);
                //}
                //reader.Close();
                ds = db.ExecuteDataSet(cmd);
                lstobj = GetObjectFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetObjectBySubjectAndDetail(string accTypeCode, DateTime startDate, DateTime endDate, string subjectCode1, string detailTransactionCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        /// <summary>
        /// Get Top by Suffix of Object AccountTransactions.
        /// </summary>
        /// <param name="suffix"></param>
        /// <returns></returns>
        public T GetTopBySuffixAccountTransactionNo(string suffix)
        {
           
            DbDataReader reader = null;
            bool alreadyOpen = false;
            T obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_AccountTransactions_Get_Top_By_SuffixAccountNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new T();
                    obj.FromDataReader(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetTopBySuffixAccountTransactionNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }

        public T GetTopBySuffixAccountTransactionNo(string suffix, int len)
        {

            DbDataReader reader = null;
            bool alreadyOpen = false;
            T obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_AccountTransactions_Get_Top_By_SuffixAccountNo";
                cmd.Parameters.Add(db.CreateParameter("@Suffix", System.Data.DbType.String, 20, suffix));
                cmd.Parameters.Add(db.CreateParameter("@Len", System.Data.DbType.Int32, 4, len));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new T();
                    obj.FromDataReader(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetTopBySuffixAccountTransactionNo(string suffix)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return obj;
        }
        /// <summary>
        /// Add Detail an object from database by calling Select StoredProcedure
        /// </summary>		
        public void GetDetailAccountTransaction(T obj)
        {

            bool alreadyOpen = false;


            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactions_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, obj.AccountTransactionID));

                reader = db.ExecuteReader(cmd);
                obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                while (reader.Read())
                {
                    AccountTransactionDetail1 obj1 = new AccountTransactionDetail1();
                    obj1 = new AccountTransactionDetail1(reader);
                    obj.Detail1.Add(obj1);
                }
                if (reader.NextResult())
                {
                    obj.Detail2 = new ListBase<AccountTransactionDetail2>();
                    while (reader.Read())
                    {
                        AccountTransactionDetail2 obj2 = new AccountTransactionDetail2();
                        obj2 = new AccountTransactionDetail2(reader);
                        obj.Detail2.Add(obj2);
                    }
                }
                if (reader.NextResult())
                {
                    obj.Invoice = new ListBase<Invoice>();
                    while (reader.Read())
                    {
                        Invoice obj3 = new Invoice();
                        obj3 = new Invoice(reader);
                        obj.Invoice.Add(obj3);
                    }
                }
                if (reader.NextResult())
                {
                    obj.BuyNoInvoice = new ListBase<BuyNoInvoice>();
                    while (reader.Read())
                    {
                        BuyNoInvoice obj4 = new BuyNoInvoice();
                        obj4 = new BuyNoInvoice(reader);
                        obj.BuyNoInvoice.Add(obj4);
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetDetailAccountTransaction(AccountTransaction obj)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
        }

        public int InsertTienvay(AccountTransactionTienvay t)
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
                cmd.CommandText = "usp_AccountTransactionTienvay_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, t.AccountTransactionID));
                cmd.Parameters.Add(db.CreateParameter("@KheuocvayID", System.Data.DbType.Guid, 16, t.KheuocvayID));
                cmd.Parameters.Add(db.CreateParameter("@AccountCode", System.Data.DbType.AnsiString, 10, t.AccountCode));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.AnsiString, 10, t.SubjectCode));
                cmd.Parameters.Add(db.CreateParameter("@AccountCodeDU", System.Data.DbType.AnsiString, 50, t.AccountCodeDU));
                if (!t.LastPaid)
                    cmd.Parameters.Add(db.CreateParameter("@NextDatePaid", System.Data.DbType.DateTime, 8, t.NextDatePaid));
                cmd.Parameters.Add(db.CreateParameter("@DebitAmount", System.Data.DbType.Decimal, 9, t.DebitAmount));
                cmd.Parameters.Add(db.CreateParameter("@CreditAmount", System.Data.DbType.Decimal, 9, t.CreditAmount));

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
                Write2Log.WriteLogs("AccountTransactionTienvayDAL", "Insert(AccountTransactionTienvay t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteTienvay(Guid accountTransactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            AccountTransactionTienvay obj = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionTienvay_DeleteByAccountTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionTienvayDAL", "DeleteTienvay(Guid accountTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
    }

	/// <summary>
	/// This object represents the properties and methods of a Data Access Layer of AccountTransaction.
	/// </summary>
    public class AccountTransactionDAL : AccountTransactionDAL<AccountTransaction>
	{
		public AccountTransactionDAL()
		{
		}
		public AccountTransactionDAL(DBHelper dbHelper): base(dbHelper)
		{

        }
        #region Stored procedure wrappers
        protected override void SetValues()
        {
            _spSelectAll = "usp_AccountTransactions_SelectAll";
            _spSelectDynamic = "usp_AccountTransactions_SelectDynamic";
        }
        public AccountTransaction GetFor632911(DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            AccountTransaction obj = null;
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_For_632911";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    obj = new AccountTransaction(reader);
                }
                if (obj != null)
                {
                    if (reader.NextResult())
                    {
                        if (obj.Detail1 == null) obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                        while (reader.Read())
                        {
                            AccountTransactionDetail1 accDetail1 = new AccountTransactionDetail1(reader);
                            obj.Detail1.Add(accDetail1);
                        }
                    }
                    if (reader.NextResult())
                    {
                        if (obj.Detail2 == null) obj.Detail2 = new ListBase<AccountTransactionDetail2>();
                        while (reader.Read())
                        {
                            AccountTransactionDetail2 accDetail2 = new AccountTransactionDetail2(reader);
                            obj.Detail2.Add(accDetail2);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetByStockTransTypeAndDate(string accTypeCode, string stockTransType, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        public AccountTransaction GetByAccountTransactionID(Guid accountTransactionID)
        {
            bool alreadyOpen = false;
            AccountTransaction obj = null;
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_AccountTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accountTransactionID));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new AccountTransaction(reader);
                }
                if (reader.NextResult())
                {
                    if (obj.Detail1 == null)
                        obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                    while (reader.Read())
                        obj.Detail1.Add(new AccountTransactionDetail1(reader));
                }
                if (reader.NextResult())
                {
                    if (obj.Detail2 == null)
                        obj.Detail2 = new ListBase<AccountTransactionDetail2>();
                    while (reader.Read())
                        obj.Detail2.Add(new AccountTransactionDetail2(reader));
                }
                if (reader.NextResult())
                {
                    if (obj.Invoice == null)
                        obj.Invoice = new ListBase<Invoice>();
                    while (reader.Read())
                        obj.Invoice.Add(new Invoice(reader));
                }
                if (reader.NextResult())
                {
                    if (obj.BuyNoInvoice == null)
                        obj.BuyNoInvoice = new ListBase<BuyNoInvoice>();
                    while (reader.Read())
                        obj.BuyNoInvoice.Add(new BuyNoInvoice(reader));
                }
                if (reader.NextResult())
                {
                    while (reader.Read())
                        obj.Tienvay = new AccountTransactionTienvay(reader);
                }

                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetByAccountTransactionID(Guid accountTransactionID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountTransactionTypeCode"></param>
        /// <param name="stockTransType"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public ListBase<AccountTransaction> GetByStockTransTypeAndDate(string accTypeCode, string stockTransType, DateTime startDate, DateTime endDate)
        {
            bool alreadyOpen = false;
            ListBase<AccountTransaction> lstobj = new ListBase<AccountTransaction>();
            //T obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransaction_Select_By_StockTransTypeAndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionTypeCode", System.Data.DbType.String, 20, accTypeCode));
                cmd.Parameters.Add(db.CreateParameter("@StockTransType", System.Data.DbType.String, 10, stockTransType));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, endDate));
                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    AccountTransaction obj = new AccountTransaction();
                    obj.FromDataReader(reader);
                    lstobj.Add(obj);
                }

                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionDAL", "GetByStockTransTypeAndDate(string accTypeCode, string stockTransType, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstobj;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public ListBase<AccountTransactionStockNew> SelectWithAccountTransactionStock(string accountTransTypeCode, string stockTransTypeCode)
        //{
        //    ListBase<AccountTransactionStockNew> lobj = new ListBase<AccountTransactionStockNew>();
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        DbDataReader reader = null;
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_AccountTransaction_Select_With_AccountTransactionStock";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@AccountTransTypeCode", System.Data.DbType.String, 20, accountTransTypeCode));
        //        cmd.Parameters.Add(db.CreateParameter("@StockTransTypeCode", System.Data.DbType.String, 10, stockTransTypeCode));
        //        reader = db.ExecuteReader(cmd);
        //        while (reader.Read())
        //        {
        //            AccountTransactionStockNew obj = new AccountTransactionStockNew(reader);
        //            lobj.Add(obj);
        //        }
        //        if (reader.NextResult())
        //        {
        //            while (reader.Read())
        //            {
        //                AccountTransactionStock obj1 = new AccountTransactionStock(reader);
        //                foreach (AccountTransactionStockNew obj in lobj)
        //                {
        //                    if (obj.AccountTransactionID == obj1.AccountTransationID)
        //                    {
        //                        obj.AccTransactionStock = obj1;
        //                    }
        //                }
        //            }
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("AccountTransactionDAL", "SelectWithAccountTransactionStock(string accountTransTypeCode, string stockTransTypeCode)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return lobj;
        //}

        #endregion
    }
	
}

