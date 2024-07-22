using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionDAL : BaseDAL<ProductTestTransaction>
    {
        public ProductTestTransactionDAL() { }
        public ProductTestTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductTestTransaction_Select_All";
        }
        public ListBase<ProductTestTransaction> GetFromDataSet(DataSet ds)
        {
            ListBase<ProductTestTransaction> lstReturn = new ListBase<ProductTestTransaction>();
            ProductTestTransaction.StructTableDetail = ds.Tables[1].Clone();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["TestTransactionID"], ds.Tables[1].Columns["TestTransactionID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ProductTestTransaction ptt = new ProductTestTransaction();
                ptt.LoadFromDataRow(dr);
                ptt.TableDetail = ProductTestTransaction.StructTableDetail.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    DataRow dr2 = ptt.TableDetail.NewRow();
                    foreach (DataColumn dc in ptt.TableDetail.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }
                    
                    ptt.TableDetail.Rows.Add(dr2);
                }
                lstReturn.Add(ptt);
            }
            return lstReturn;
        }
        public ListBase<ProductTestTransaction> GetByDateAndStockCode(string stockCode, DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<ProductTestTransaction> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProductTestTransaction_Select_By_Period_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductTestTransactionDAL", "GetByDateAndStockCode(string stockCode, DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(ProductTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransaction_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@Nguoikiem", System.Data.DbType.String, 50, t.Nguoikiem));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.TestTransactionID = (Guid)Cmd.Parameters["@TestTransactionID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDAL", "Insert(ProductTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransaction_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@TransactionDate", System.Data.DbType.DateTime, 8, t.TransactionDate));
                Cmd.Parameters.Add(db.CreateParameter("@Shift", System.Data.DbType.Byte, 1, t.Shift));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@Nguoikiem", System.Data.DbType.String, 50, t.Nguoikiem));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDAL", "Update(ProductTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestTransaction_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestTransactionDAL", "Delete(ProductTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
