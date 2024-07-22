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
    public class MaterialTestTransactionDAL : BaseDAL<MaterialTestTransaction>
    {
        public MaterialTestTransactionDAL() { }
        public MaterialTestTransactionDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_MaterialTestTransaction_Select_All";
            _spSelectDynamic = "usp_MaterialTestTransaction_Select_Dynamic";
        }
        public ListBase<MaterialTestTransaction> GetFromDataSet(DataSet ds)
        {
            ListBase<MaterialTestTransaction> lstReturn = new ListBase<MaterialTestTransaction>();

            DataRelation drDetail = ds.Relations.Add("Detail", ds.Tables[0].Columns["TestTransactionID"], ds.Tables[1].Columns["TestTransactionID"]);
            //DataRelation drDetailLAB = ds.Relations.Add("DetailLAB", ds.Tables[0].Columns["TestTransactionID"], ds.Tables[2].Columns["TestTransactionID"]);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                MaterialTestTransaction mtt = new MaterialTestTransaction();
                mtt.LoadFromDataRow(dr);
                if (mtt.Detail == null) mtt.Detail = new ListBase<MaterialTestTransactionDetail>();
               // if (mtt.DetailLAB == null) mtt.DetailLAB = new ListBase<MaterialTestTransactionDetailLAB>();
                foreach (DataRow dr1 in dr.GetChildRows(drDetail))
                {
                    MaterialTestTransactionDetail mttd = new MaterialTestTransactionDetail();
                    mttd.LoadFromDataRow(dr1);
                    mtt.Detail.Add(mttd);
                }
                //foreach (DataRow dr2 in dr.GetChildRows(drDetailLAB))
                //{
                //    MaterialTestTransactionDetailLAB mttdLAB = new MaterialTestTransactionDetailLAB();
                //    mttdLAB.LoadFromDataRow(dr2);
                //    mtt.DetailLAB.Add(mttdLAB);
                //}
                lstReturn.Add(mtt);
            }
            return lstReturn;
        }
        public ListBase<MaterialTestTransaction> GetByDate(DateTime startDate, DateTime endDate)
        {
            DataSet ds = null;
            ListBase<MaterialTestTransaction> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialTestTransaction_Select_By_Data";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialTestTransactionDAL", "GetByDate(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        //public ListBase<MaterialTestTransaction> GetByDateAndBranchCode(DateTime startDate, DateTime endDate, string branchCode)
        //{
        //    DataSet ds = null;
        //    ListBase<MaterialTestTransaction> lstReturn = null;
        //    bool alreadyOpen = false;
        //    try
        //    {
        //        if (db.State != System.Data.ConnectionState.Open) db.Open();
        //        else alreadyOpen = true;
        //        DbCommand cmd = db.CreateCommand();
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "usp_MaterialTestTransaction_Select_By_Data_And_BranchCode";
        //        cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
        //        cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
        //        cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 20, branchCode));

        //        ds = db.ExecuteDataSet(cmd);
        //        lstReturn = this.GetFromDataSet(ds);
        //    }
        //    catch (Exception excp)
        //    {
        //        Write2Log.WriteLogs("MaterialTestTransactionDAL", "GetByDate(DateTime startDate, DateTime endDate)", excp.Message);
        //    }
        //    finally
        //    {
        //        if (!alreadyOpen) db.Close();
        //    }
        //    return lstReturn;
        //}
        public ListBase<MaterialTestTransaction> GetByDateAndStockCode(DateTime startDate, DateTime endDate, string stockCode)
        {
            DataSet ds = null;
            ListBase<MaterialTestTransaction> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_MaterialTestTransaction_Select_By_Data_And_StockCode";
                cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 4, startDate));
                cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 4, endDate));
                cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 20, stockCode));

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("MaterialTestTransactionDAL", "GetByDate(DateTime startDate, DateTime endDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(MaterialTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestTransaction_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionNo", System.Data.DbType.String, 20, t.TestTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionDate", System.Data.DbType.DateTime, 8, t.TestTransactionDate));
                //Cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@Location", System.Data.DbType.String, 20, t.Location));
                if (t.SubjectCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                }
                
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));
                //Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                //Cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, t.EndDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
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
                Write2Log.WriteLogs("MaterialTestTransactionDAL", "Insert(MaterialTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(MaterialTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestTransaction_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionNo", System.Data.DbType.String, 20, t.TestTransactionNo));
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionDate", System.Data.DbType.DateTime, 8, t.TestTransactionDate));
                //Cmd.Parameters.Add(db.CreateParameter("@BranchCode", System.Data.DbType.String, 10, t.BranchCode));
                Cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, t.ItemCode));
                Cmd.Parameters.Add(db.CreateParameter("@StockCode", System.Data.DbType.String, 10, t.StockCode));
                Cmd.Parameters.Add(db.CreateParameter("@Location", System.Data.DbType.String, 20, t.Location));
                if (t.SubjectCode == string.Empty)
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, DBNull.Value));
                }
                else
                {
                    Cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, t.SubjectCode));
                }
                Cmd.Parameters.Add(db.CreateParameter("@PTVC", System.Data.DbType.String, 50, t.PTVC));
                //Cmd.Parameters.Add(db.CreateParameter("@StartDate", System.Data.DbType.DateTime, 8, t.StartDate));
                //Cmd.Parameters.Add(db.CreateParameter("@EndDate", System.Data.DbType.DateTime, 8, t.EndDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialTestTransactionDAL", "Update(MaterialTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(MaterialTestTransaction t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_MaterialTestTransaction_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@TestTransactionID", System.Data.DbType.Guid, 16, t.TestTransactionID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("MaterialTestTransactionDAL", "Delete(MaterialTestTransaction t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
    }
}
