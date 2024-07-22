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
    public class TestRequestReturnDAL : BaseDAL<TestRequestReturn>
    {
        public TestRequestReturnDAL() { }
        public TestRequestReturnDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_TestRequestReturn_Select_All";
        }
        //public TestRequestReturn GetByReturnID(Guid returnID)
        //{
        //    TestRequestReturn t = null;
        //    DbDataReader reader = null;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "usp_TestRequestReturn_Get_By_ReturnID";
        //        cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, returnID));
        //        reader = db.ExecuteReader(cmd);
        //        if (reader.Read())
        //        {
        //            t = new TestRequestReturn(reader);
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("TestRequestReturnDAL", "GetByReturnID(Guid returnID)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return t;
        //}
        public ListBase<TestRequestReturn> GetFromDataSet(DataSet ds)
        {
            ListBase<TestRequestReturn> lstReturn = new ListBase<TestRequestReturn>();
            TestRequestReturn.StructMaterialDetailTable = ds.Tables[1].Clone();
            TestRequestReturn.StructProductDetailTable = ds.Tables[2].Clone();

            DataRelation drDetail1 = ds.Relations.Add("Detail1", ds.Tables[0].Columns["ReturnID"], ds.Tables[1].Columns["ReturnID"]);
            DataRelation drDetail2 = ds.Relations.Add("Detail2", ds.Tables[0].Columns["ReturnID"], ds.Tables[2].Columns["ReturnID"]);
            DataRelation drDetail3 = ds.Relations.Add("Detail3", ds.Tables[0].Columns["ReturnID"], ds.Tables[3].Columns["RequestReturnID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                TestRequestReturn trr = new TestRequestReturn();
                trr.LoadFromDataRow(dr);
                trr.MaterialDetailTable = TestRequestReturn.StructMaterialDetailTable.Clone();
                trr.ProductDetailTable = TestRequestReturn.StructProductDetailTable.Clone();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail1))
                {
                    DataRow dr2 = trr.MaterialDetailTable.NewRow();
                    foreach (DataColumn dc in trr.MaterialDetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }

                    trr.MaterialDetailTable.Rows.Add(dr2);
                }
                foreach (DataRow dr1 in dr.GetChildRows(drDetail2))
                {
                    DataRow dr2 = trr.ProductDetailTable.NewRow();
                    foreach (DataColumn dc in trr.ProductDetailTable.Columns)
                    {
                        dr2[dc.Caption] = dr1[dc.Caption];
                        if (dr2.IsNull(dc.Caption))
                        {
                            dr2[dc.Caption] = string.Empty;
                        }
                    }

                    trr.ProductDetailTable.Rows.Add(dr2);
                }
                foreach (DataRow drLink in dr.GetChildRows(drDetail3))
                {
                    TestRequestReturnLink trrl = new TestRequestReturnLink();
                    trrl.RequestReturnID = (Guid)drLink["RequestReturnID"];
                    trrl.EncryptCodeReturnID = (Guid)drLink["EncryptCodeReturnID"];
                    trr.Link.Add(trrl);
                }
                lstReturn.Add(trr);
            }
            return lstReturn;
        }
        public ListBase<TestRequestReturn> GetForPeriod(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<TestRequestReturn> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TestRequestReturn_Select_For_Period";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TestRequestReturnDAL", "GetForPeriod(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public int UpdateIsReceived(TestRequestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturn_Update_IsReceived";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
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
                Write2Log.WriteLogs("TestRequestReturnDAL", "Update(MaterialTestRequest t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public DataSet GetForApplyResult(string itemEncryptCode, bool isProduct)
        {
            DataSet ds = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_TestRequestReturn_Select_For_Apply_Result2";
                cmd.Parameters.Add(db.CreateParameter("@ItemEncryptCode", System.Data.DbType.String, 50, itemEncryptCode));
                cmd.Parameters.Add(db.CreateParameter("@IsProduct", System.Data.DbType.Boolean, 1, isProduct));

                ds = db.ExecuteDataSet(cmd);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("TestRequestReturnDAL", "GetForApplyResult(string itemEncryptCode, bool isProduct)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return ds;
        }
        public override int Insert(TestRequestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturn_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@DateReturn", System.Data.DbType.DateTime, 8, t.DateReturn));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                if (t.IsReceived)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, t.DateReceived));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, DBNull.Value));
                }
                
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
                Write2Log.WriteLogs("TestRequestReturnDAL", "Insert(TestRequestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(TestRequestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturn_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@DateReturn", System.Data.DbType.DateTime, 8, t.DateReturn));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@IsReceived", System.Data.DbType.Boolean, 1, t.IsReceived));
                Cmd.Parameters.Add(db.CreateParameter("@UserReceived", System.Data.DbType.String, 20, t.UserReceived));
                if (t.IsReceived)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, t.DateReceived));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@DateReceived", System.Data.DbType.DateTime, 8, DBNull.Value));
                }
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDAL", "Update(TestRequestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(TestRequestReturn t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_TestRequestReturn_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ReturnID", System.Data.DbType.Guid, 16, t.ReturnID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("TestRequestReturnDAL", "Delete(TestRequestReturn t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
