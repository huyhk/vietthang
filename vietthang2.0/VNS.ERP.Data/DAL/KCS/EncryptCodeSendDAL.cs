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
    public class EncryptCodeSendDAL : BaseDAL<EncryptCodeSend>
    {
        public EncryptCodeSendDAL() { }
        public EncryptCodeSendDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_EncryptCodeSend_Select_All";
        }
        public ListBase<EncryptCodeSend> GetFromDataSet(DataSet ds)
        {
            ListBase<EncryptCodeSend> lstReturn = new ListBase<EncryptCodeSend>();
            EncryptCodeSend.StructDetailMaterialTable = ds.Tables[1].Clone();
            EncryptCodeSend.StructDetailProductTable = ds.Tables[2].Clone();

            DataRelation drDetailMaterial = ds.Relations.Add("DetailMaterial", ds.Tables[0].Columns["SendID"], ds.Tables[1].Columns["SendID"]);
            DataRelation drDetailProduct = ds.Relations.Add("DetailProduct", ds.Tables[0].Columns["SendID"], ds.Tables[2].Columns["SendID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EncryptCodeSend ecs = new EncryptCodeSend();
                ecs.LoadFromDataRow(dr);
                ecs.DetailMaterialTable = EncryptCodeSend.StructDetailMaterialTable.Clone();
                ecs.DetailProductTable = EncryptCodeSend.StructDetailProductTable.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetailMaterial))
                {
                    DataRow dr2 = ecs.DetailMaterialTable.NewRow();
                    foreach (DataColumn dc in ecs.DetailMaterialTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }

                    ecs.DetailMaterialTable.Rows.Add(dr2);
                }
                foreach (DataRow dr1 in dr.GetChildRows(drDetailProduct))
                {
                    DataRow dr2 = ecs.DetailProductTable.NewRow();
                    foreach (DataColumn dc in ecs.DetailProductTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }

                    ecs.DetailProductTable.Rows.Add(dr2);
                }
                lstReturn.Add(ecs);
            }
            return lstReturn;
        }
        public ListBase<EncryptCodeSend> GetForPeriodAndSubjectCode(DateTime startDate, DateTime endDate, string subjectCode)
        {
            DataSet ds = null;
            ListBase<EncryptCodeSend> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_EncryptCodeSend_Select_By_Period_And_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
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
        public string EncryptCodeSendsSetNewNo(DateTime sendDate)
        {
            string sendNo = string.Empty;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_EncryptCodeSends_SetNewNo";
                cmd.Parameters.Add(db.CreateParameter("@SendDate", System.Data.DbType.DateTime, 8, sendDate));
                sendNo = (string)db.ExecuteScalar(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeSendDAL", "EncryptCodeSendsSetNewNo(DateTime sendDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return sendNo;
        }
        public DataSet GetMaterialEncryptCodeNotSend(string subjectCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VIEWMaterialEncryptCodeNotSend_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeSendDAL", "GetMaterialEncryptCodeNotSend(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public DataSet GetProductEncryptCodeNotSend(string subjectCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VIEWProductEncryptCodeNotSend_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeSendDAL", "GetProductEncryptCodeNotSend(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public override int Insert(EncryptCodeSend t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeSend_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SendID", System.Data.DbType.Guid, 16, t.SendID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@SendNo", System.Data.DbType.String, 20, t.SendNo));
                Cmd.Parameters.Add(db.CreateParameter("@SendDate", System.Data.DbType.DateTime, 8, t.SendDate));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.SendID = (Guid)Cmd.Parameters["@SendID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeSendDAL", "Insert(EncryptCodeSend t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(EncryptCodeSend t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeSend_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SendID", System.Data.DbType.Guid, 16, t.SendID));
                Cmd.Parameters.Add(db.CreateParameter("@SendNo", System.Data.DbType.String, 20, t.SendNo));
                Cmd.Parameters.Add(db.CreateParameter("@SendDate", System.Data.DbType.DateTime, 8, t.SendDate));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeSendDAL", "Update(EncryptCodeSend t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(EncryptCodeSend t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeSend_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@SendID", System.Data.DbType.Guid, 16, t.SendID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeSendDAL", "Delete(EncryptCodeSend t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
