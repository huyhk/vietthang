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
    public class ProductTestRequestDAL : BaseDAL<ProductTestRequest>
    {
        ListBase<TechnicalTest> lstTechnicalTest = null;
        public ProductTestRequestDAL() { }
        public ProductTestRequestDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_ProductTestRequest_Select_All";
        }
        public ProductTestRequest GetByRequestID(Guid requestID)
        {
            ProductTestRequest t = null;
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProductTestRequest_Get_By_RequestID";
                cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, requestID));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    t = new ProductTestRequest(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductTestRequestDAL", "GetByRequestID(Guid requestID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return t;
        }
        public int UpdateIsReceived(ProductTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestRequest_Update_IsReceived";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                if (t.UserReceived == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                }

                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestRequestDAL", "UpdateIsReceived(ProductTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public ListBase<ProductTestRequest> GetFromDataSet(DataSet ds)
        {
            ListBase<ProductTestRequest> lstReturn = new ListBase<ProductTestRequest>();
            ProductTestRequest.StructDetailTable = ds.Tables[1].Clone();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["RequestID"], ds.Tables[1].Columns["RequestID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ProductTestRequest ptr = new ProductTestRequest();
                ptr.LoadFromDataRow(dr);
                ptr.DetailTable = ProductTestRequest.StructDetailTable.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    DataRow dr2 = ptr.DetailTable.NewRow();
                    foreach (DataColumn dc in ptr.DetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }

                    ptr.DetailTable.Rows.Add(dr2);
                }
                lstReturn.Add(ptr);
            }
            return lstReturn;
        }
        public ListBase<ProductTestRequest> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<ProductTestRequest> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProductTestRequest_Select_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("ProductTestRequestDAL", "GetForPeriod(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(ProductTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestRequest_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@DateRequest", System.Data.DbType.DateTime, 8, t.DateRequest));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, t.DateReceived));
                if (t.UserReceived == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.RequestID = (Guid)Cmd.Parameters["@RequestID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestRequestDAL", "Insert(ProductTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(ProductTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestRequest_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID));
                Cmd.Parameters.Add(db.CreateParameter("@DateRequest", System.Data.DbType.DateTime, 8, t.DateRequest));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, t.DateReceived));
                if (t.UserReceived == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                }
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestRequestDAL", "Update(ProductTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(ProductTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestRequest_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestRequestDAL", "Delete(ProductTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public int Delete(Guid requestID)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_ProductTestRequest_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, requestID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("ProductTestRequestDAL", "Delete(Guid requestID)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
