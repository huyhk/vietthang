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
    public class MaterialTestRequestDAL : BaseDAL<MaterialTestRequest>
    {
        public MaterialTestRequestDAL() { }
        public MaterialTestRequestDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_MaterialTestRequest_Select_All";
        }
        public void CopyDetailTableToDetail(MaterialTestRequest t)
        {
            t.Detail.Clear();
            foreach (DataRow dr in t.DetailTable.Rows)
            {
                MaterialTestRequestDetail mtrd = new MaterialTestRequestDetail();
                mtrd.ItemEncryptCode = dr["ItemEncryptCode"].ToString();
                mtrd.TechCode = dr["TechCode"].ToString();
                mtrd.SubjectCode = dr["DVPTCode"].ToString();
                t.Detail.Add(mtrd);
            }
        }
        public ListBase<MaterialTestRequest> GetFromDataSet(DataSet ds)
        {
            ListBase<MaterialTestRequest> lstReturn = new ListBase<MaterialTestRequest>();
            MaterialTestRequest.StructDTDetail = ds.Tables[1].Clone();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["RequestID"], ds.Tables[1].Columns["RequestID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                MaterialTestRequest mtr = new MaterialTestRequest();
                mtr.LoadFromDataRow(dr);
                mtr.DetailTable = MaterialTestRequest.StructDTDetail.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    DataRow dr2 = mtr.DetailTable.NewRow();
                    foreach (DataColumn dc in mtr.DetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                    }
                    mtr.DetailTable.Rows.Add(dr2);
                }
                lstReturn.Add(mtr);
            }
            return lstReturn;
        }
        public ListBase<MaterialTestRequest> GetByDate(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<MaterialTestRequest> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialTestRequest_Select_By_Date";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialTestRequestDAL", "GetByDate(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public MaterialTestRequest GetByRequestID(Guid requestID)
        {
            MaterialTestRequest t = null;
            DbDataReader reader = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialTestRequest_Get_By_RequestID";
                cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, requestID));
                reader = db.ExecuteReader(cmd);
                if (reader.Read())
                {
                    t = new MaterialTestRequest(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialTestRequestDAL", "GetByRequestID(Guid requestID)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return t;
        }
        public int UpdateIsReceived(MaterialTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestRequest_Update_IsReceived";
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
                Write2Log.WriteLogs("MaterialTestRequestDAL", "Update(MaterialTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Insert(MaterialTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestRequest_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@DateRequest", System.Data.DbType.DateTime, 8, t.DateRequest));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
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
                Write2Log.WriteLogs("MaterialTestRequestDAL", "Insert(MaterialTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(MaterialTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestRequest_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID));
                Cmd.Parameters.Add(db.CreateParameter("@DateRequest", System.Data.DbType.DateTime, 8, t.DateRequest));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialTestRequestDAL", "Update(MaterialTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(MaterialTestRequest t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestRequest_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@RequestID", System.Data.DbType.Guid, 16, t.RequestID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialTestRequestDAL", "Delete(MaterialTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
