using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Common;
using VNS.Data.DAL;
using VNS.Utils;

namespace VNS.ERP.Data.Equipments
{
    #region VattuTransactionDAL
    /// <summary>
    /// This object represents the properties and methods of a Data Access Layer of VattuTransaction.
    /// </summary>
    public class VattuTransactionDAL : BaseDAL<VattuTransaction>
    {
        public VattuTransactionDAL()
        {
        }
        public VattuTransactionDAL(DBHelper dbHelper)
            : base(dbHelper)
        {

        }
        #region Stored procedure wrappers
        /// <summary>
        /// Inserts an object into database by calling Insert StoredProcedure
        /// </summary>
        public override int Insert(VattuTransaction t)
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
                cmd.CommandText = "usp_VattuTransaction_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID, System.Data.ParameterDirection.Output));
                cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.AnsiString, 20, t.TransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.AnsiString, 20, t.TransactionType));
                cmd.Parameters.Add(db.CreateParameter("@StockIn", System.Data.DbType.AnsiString, 10, t.StockIn));
                cmd.Parameters.Add(db.CreateParameter("@StockOut", System.Data.DbType.AnsiString, 10, t.StockOut));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
                cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@DVGiaoNhan", System.Data.DbType.String, 50, t.DVGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@CTKemtheo", System.Data.DbType.String, 50, t.CTKemtheo));

                //cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));

                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.TransactionID = (Guid)cmd.Parameters["@TransactionID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuTransactionDAL", "Insert(VattuTransaction t)", excp.Message);
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
        public override int Update(VattuTransaction t)
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
                cmd.CommandText = "usp_VattuTransaction_Update";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@TransactionNo", System.Data.DbType.AnsiString, 20, t.TransactionNo));
                cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.AnsiString, 20, t.TransactionType));
                cmd.Parameters.Add(db.CreateParameter("@StockIn", System.Data.DbType.AnsiString, 10, t.StockIn));
                cmd.Parameters.Add(db.CreateParameter("@StockOut", System.Data.DbType.AnsiString, 10, t.StockOut));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 200, t.Description));
               // cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.AnsiString, 20, t.UserCreated));
                cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.AnsiString, 20, t.UserUpdated));
                cmd.Parameters.Add(db.CreateParameter("@DVGiaoNhan", System.Data.DbType.String, 50, t.DVGiaoNhan));
                cmd.Parameters.Add(db.CreateParameter("@CTKemtheo", System.Data.DbType.String, 50, t.CTKemtheo));


                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuTransactionDAL", "Update(VattuTransaction t)", excp.Message);
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
        public override int Delete(VattuTransaction t)
        {

            return this.Delete(t.TransactionID);
        }

        /// <summary>
        /// Deletes an object from database by calling Delete StoredProcedure
        /// </summary>		
        public int Delete(Guid transactionID)
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
                cmd.CommandText = "usp_VattuTransaction_Delete";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                    iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuTransactionDAL", "Delete(VattuTransaction t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        /// <summary>
        /// Returns an object from database by calling Select StoredProcedure
        /// </summary>		
        //public VattuTransaction GetByID(Guid transactionID)
        //{
        //    //int iError = 0;
        //    bool alreadyOpen = false;
        //    VattuTransaction obj = null;
        //    try
        //    {
        //        DbDataReader reader = null;
        //        if (db.State != System.Data.ConnectionState.Open)
        //            db.Open();
        //        else
        //            alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandText = "usp_VattuTransaction_Select";
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));

        //        cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

        //        reader = db.ExecuteReader(cmd);
        //        if (reader.Read())
        //            obj = new VattuTransaction(reader);
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("VattuTransactionDAL", "GetByID(Guid transactionID)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen)
        //            db.Close();
        //    }
        //    return obj;
        //}

        public VattuTransaction GetByID(Guid transactionID)
        {
            int iError = 0;
            bool alreadyOpen = false;
            VattuTransaction obj = null;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuTransaction_SelectByID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));

                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    obj = new VattuTransaction(reader);
                    if (reader.NextResult())
                    {
                        while (reader.Read())
                            obj.ListVattuTransactionDetail.Add(new VattuTransactionDetail(reader));
                    }
                }
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseContractDAL", "GetByID(Guid contractID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return obj;
        }

        public DataSet GetByStockAndTypeAndDate(string stockCode,string transactionType,DateTime fromDate,DateTime toDate)
        {
            bool alreadyOpen = false;
            DataSet ds = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuTransaction_SelectByStockAndTypeAndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@TransactionType", System.Data.DbType.AnsiString, 10, transactionType));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VattuTransactionDAL", "GetByStockAndTypeAndDate(string stockCode,string transactionType,DateTime fromDate,DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }

        public string GetNextTransactionNo(string typeCode, DateTime date, string stockCode)
        {
            bool alreadyOpen = false;
            string transactionNo = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuTransaction_GetNextTransactionNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TypeCode", System.Data.DbType.AnsiString, 20, typeCode));
                cmd.Parameters.Add(db.CreateParameter("@Date", System.Data.DbType.DateTime, 8, date));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.AnsiString, 10, stockCode));

                transactionNo = db.ExecuteScalar(cmd).ToString();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VattuTransactionDAL", "GetNextTransactionNo(string typeCode, DateTime date, string stockCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return transactionNo;
        }
        #endregion
        #region private methods

        protected override void SetValues()
        {
            _spSelectAll = "usp_VattuTransaction_SelectAll";
            _spSelectDynamic = "usp_VattuTransaction_SelectDynamic";
            _spDeleteAll = "usp_VattuTransaction_DeleteAll";
            _spDeleteDynamic = "usp_VattuTransaction_DeleteDynamic";
        }

        #endregion

        #region VattuTransactionDetailDAL
        public int InsertDetail(VattuTransactionDetail t)
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
                cmd.CommandText = "usp_VattuTransactionDetail_Insert";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, t.TransactionID));
                cmd.Parameters.Add(db.CreateParameter("@VattuCode", System.Data.DbType.AnsiString, 20, t.VattuCode));
                cmd.Parameters.Add(db.CreateParameter("@Quantity", System.Data.DbType.Decimal, 9, t.Quantity));
                cmd.Parameters.Add(db.CreateParameter("@Price", System.Data.DbType.Decimal, 9, t.Price));
                cmd.Parameters.Add(db.CreateParameter("@Amount", System.Data.DbType.Decimal, 9, t.Amount));
                cmd.Parameters.Add(db.CreateParameter("@LineSxNo", System.Data.DbType.Int32, 4, t.LineSxNo));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentSxCode", System.Data.DbType.AnsiString, 10, t.EquipmentSxCode));
                cmd.Parameters.Add(db.CreateParameter("@EquipmentCode", System.Data.DbType.AnsiString, 10, t.EquipmentCode));
                cmd.Parameters.Add(db.CreateParameter("@VattuOldType", System.Data.DbType.AnsiString, 10, t.VattuOldType));
                cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
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
                iError = -1;
                Write2Log.WriteLogs("VattuTransactionDetailDAL", "Insert(VattuTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }

        public int DeleteDetail(Guid transactionID)
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
                cmd.CommandText = "usp_VattuTransactionDetail_DeleteByTransactionID";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@TransactionID", System.Data.DbType.Guid, 16, transactionID));
                cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));

                iError = db.ExecuteNonQuery(cmd);
                //if (iError == 0)
                iError = (int)cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1;
                Write2Log.WriteLogs("VattuTransactionDetailDAL", "Delete(VattuTransactionDetail t)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return iError;
        }
        #endregion

        #region VattuTransactionTypeDAL
        public ListBase<VattuTransactionType> GetVattuTransactionTypeDynamic(string whereCondition, string orderByExpression)
        {
            bool alreadyOpen = false;
            ListBase<VattuTransactionType> lstReturn = new ListBase<VattuTransactionType>();
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_VattuTransactionType_SelectDynamic";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@WhereCondition", System.Data.DbType.String, 500, whereCondition));
                cmd.Parameters.Add(db.CreateParameter("@OrderByExpression", System.Data.DbType.String, 250, orderByExpression));


                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                    lstReturn.Add(new VattuTransactionType(reader));
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("VattuTransactionDAL", "GetVattuTransactionTypeDynamic(string whereCondition, string orderByExpression)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lstReturn;
        }
        #endregion
    }
    #endregion
}
