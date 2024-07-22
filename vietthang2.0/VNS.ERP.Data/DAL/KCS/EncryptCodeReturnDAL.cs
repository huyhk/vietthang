using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using System.Data;
using VNS.Common;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeReturnDAL : BaseDAL<EncryptCodeReturn>
    {
        public EncryptCodeReturnDAL() { }
        public EncryptCodeReturnDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_EncryptCodeReturn_Select_All";
        }
        public ListBase<EncryptCodeReturn> GetFromDataSet(DataSet ds)
        {
            ListBase<EncryptCodeReturn> lstReturn = new ListBase<EncryptCodeReturn>();
            EncryptCodeReturn.StructDetailMaterialTable = ds.Tables[1].Clone();
            EncryptCodeReturn.StructDetailProductTable = ds.Tables[2].Clone();

            DataRelation drDetailMaterial = ds.Relations.Add("DetailMaterial", ds.Tables[0].Columns["ReturnID"], ds.Tables[1].Columns["ReturnID"]);
            DataRelation drDetailProduct = ds.Relations.Add("DetailProduct", ds.Tables[0].Columns["ReturnID"], ds.Tables[2].Columns["ReturnID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EncryptCodeReturn ecr = new EncryptCodeReturn();
                ecr.LoadFromDataRow(dr);
                ecr.DetailMaterialTable = EncryptCodeReturn.StructDetailMaterialTable.Clone();
                ecr.DetailProductTable = EncryptCodeReturn.StructDetailProductTable.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetailMaterial))
                {
                    DataRow dr2 = ecr.DetailMaterialTable.NewRow();
                    foreach (DataColumn dc in ecr.DetailMaterialTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }
                    ecr.DetailMaterialTable.Rows.Add(dr2);
                }
                foreach (DataRow dr1 in dr.GetChildRows(drDetailProduct))
                {
                    DataRow dr2 = ecr.DetailProductTable.NewRow();
                    foreach (DataColumn dc in ecr.DetailProductTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }
                    ecr.DetailProductTable.Rows.Add(dr2);
                }
                lstReturn.Add(ecr);
            }
            return lstReturn;
        }
        public ListBase<EncryptCodeReturn> GetFromDataSetForTestRequestReturnCheck(DataSet ds)
        {
            ListBase<EncryptCodeReturn> lstReturn = new ListBase<EncryptCodeReturn>();

            DataRelation drDetailMaterial = ds.Relations.Add("DetailMaterial", ds.Tables[0].Columns["ReturnID"], ds.Tables[1].Columns["ReturnID"]);
            DataRelation drDetailProduct = ds.Relations.Add("DetailProduct", ds.Tables[0].Columns["ReturnID"], ds.Tables[2].Columns["ReturnID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                EncryptCodeReturn ecr = new EncryptCodeReturn();
                ecr.LoadFromDataRow(dr);
                ecr.DetailMaterialTableForTestRequestReturnCheck = ds.Tables[1].Clone();
                ecr.DetailProductTableForTestRequestReturnCheck = ds.Tables[2].Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetailMaterial))
                {
                    DataRow dr2 = ecr.DetailMaterialTableForTestRequestReturnCheck.NewRow();
                    foreach (DataColumn dc in ecr.DetailMaterialTableForTestRequestReturnCheck.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                    }
                    ecr.DetailMaterialTableForTestRequestReturnCheck.Rows.Add(dr2);
                }
                foreach (DataRow dr1 in dr.GetChildRows(drDetailProduct))
                {
                    DataRow dr2 = ecr.DetailProductTableForTestRequestReturnCheck.NewRow();
                    foreach (DataColumn dc in ecr.DetailProductTableForTestRequestReturnCheck.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                    }
                    ecr.DetailProductTableForTestRequestReturnCheck.Rows.Add(dr2);
                }
                lstReturn.Add(ecr);
            }
            return lstReturn;
        }
        public ListBase<EncryptCodeReturn> GetForPeriodAndSubjectCode(DateTime startDate, DateTime endDate, string subjectCode)
        {
            DataSet ds = null;
            ListBase<EncryptCodeReturn> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_EncryptCodeReturn_Select_By_Period_And_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "GetForPeriodAndSubjectCode(DateTime startDate, DateTime endDate, string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public ListBase<EncryptCodeReturn> GetForTestRequestReturnCheck(Guid returnID)
        {
            DataSet ds = null;
            ListBase<EncryptCodeReturn> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_EncryptCodeReturn_Select_For_TestRequestReturn_Check";
                cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSetForTestRequestReturnCheck(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "GetForTestRequestReturnCheck()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public DataSet GetMaterialEncryptCodeNotReturn(string subjectCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VIEWMaterialEncryptCodeNotReturn_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "GetMaterialEncryptCodeNotReturn(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public DataSet GetProductEncryptCodeNotReturn(string subjectCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VIEWProductEncryptCodeNotReturn_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "GetProductEncryptCodeNotReturn(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public DataSet GetEncryptCodeNotReturn(string subjectCode)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_VIEWEncryptCodeNotReturn_Select_By_SubjectCode";
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 20, subjectCode));
                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "GetEncryptCodeNotReturn(string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public override int Insert(EncryptCodeReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturn_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnNo", System.Data.DbType.String, 20, t.ReturnNo));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnDate", System.Data.DbType.DateTime, 8, t.ReturnDate));
                Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ReturnID = (Guid)Cmd.Parameters["@ReturnID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "Insert(EncryptCodeReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(EncryptCodeReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturn_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnNo", System.Data.DbType.String, 20, t.ReturnNo));
                Cmd.Parameters.Add(db.CreateParameter("@ReturnDate", System.Data.DbType.DateTime, 8, t.ReturnDate));
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
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "Update(EncryptCodeReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(EncryptCodeReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_EncryptCodeReturn_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("EncryptCodeReturnDAL", "Delete(EncryptCodeReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
