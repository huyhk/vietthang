using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data.Common;
using VNS.Utils;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data
{
    public class BocxepContractDAL : BaseDAL<BocxepContract>
    {
        public BocxepContractDAL() { }
        public BocxepContractDAL(DBHelper dbHelper) : base(dbHelper) { }
        protected override void SetValues()
        {
            _spSelectAll = "usp_BocxepContract_Select_All";
        }
        private ListBase<BocxepContract> GetFromDataSet(DataSet ds)
        {
            ListBase<BocxepContract> lstReturn = new ListBase<BocxepContract>();

            DataRelation drPrice = ds.Relations.Add("Price", ds.Tables[0].Columns["ContractID"], ds.Tables[1].Columns["ContractID"]);
            DataRelation drPriceDetail = ds.Relations.Add("PriceDetail", ds.Tables[1].Columns["PriceID"], ds.Tables[2].Columns["PriceID"]);
            DataRelation drPriceStock = ds.Relations.Add("PriceStock", ds.Tables[1].Columns["PriceID"], ds.Tables[3].Columns["PriceID"]);
            DataRelation drPriceItem = ds.Relations.Add("PriceItem", ds.Tables[1].Columns["PriceID"], ds.Tables[4].Columns["PriceID"]);

            DataRelation drService = ds.Relations.Add("Service", ds.Tables[0].Columns["ContractID"], ds.Tables[5].Columns["ContractID"]);
            DataRelation drBocxepService = ds.Relations.Add("BocxepService", ds.Tables[5].Columns["ServiceID"], ds.Tables[6].Columns["ServiceID"]);
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                BocxepContract bxc = new BocxepContract();
                bxc.LoadFromDataRow(dr);
                #region get list Price
                foreach (DataRow dr1 in dr.GetChildRows(drPrice))
                {
                    BocxepContractPrice bxcp = new BocxepContractPrice();
                    bxcp.LoadFromDataRow(dr1);
                    foreach (DataRow dr2 in dr1.GetChildRows(drPriceDetail))
                    {
                        BocxepContractPriceDetail bxcpd = new BocxepContractPriceDetail();
                        bxcpd.LoadFromDataRow(dr2);
                        bxcp.Detail.Add(bxcpd);
                    }
                    foreach (DataRow dr3 in dr1.GetChildRows(drPriceStock))
                    {
                        BocxepContractPriceStock bxcps = new BocxepContractPriceStock();
                        bxcps.LoadFromDataRow(dr3);
                        bxcp.DetailStock.Add(bxcps);
                    }
                    foreach (DataRow dr4 in dr1.GetChildRows(drPriceItem))
                    {
                        BocxepContractPriceItem bxcps = new BocxepContractPriceItem();
                        bxcps.LoadFromDataRow(dr4);
                        bxcp.DetailItem.Add(bxcps);
                    }
                    bxc.Detail.Add(bxcp);
                }
                #endregion
                #region get list Service
                foreach (DataRow rowService in dr.GetChildRows(drService))
                {
                    BocxepContractService service = new BocxepContractService(rowService);
                    foreach (DataRow rowBocxepService in rowService.GetChildRows(drBocxepService))
                        service.ListBocxepService.Add(new BocxepService(rowBocxepService));
                    bxc.ListBocxepContractService.Add(service);
                }
                #endregion
                lstReturn.Add(bxc);
            }
            return lstReturn;
        }
        public ListBase<BocxepContract> GetAllFromDataSet()
        {
            DataSet ds = null;
            ListBase<BocxepContract> lstReturn = null;
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "usp_BocxepContract_Select_All_With_Detail";

                ds = db.ExecuteDataSet(cmd);
                lstReturn = this.GetFromDataSet(ds);
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BocxepContractDAL", "GetAllFromDataSet()", excp.Message);
            }
            finally
            {
                if (!alreadyOpen) db.Close();
            }
            return lstReturn;
        }
        public override int Insert(BocxepContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContract_Insert";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID, System.Data.ParameterDirection.Output));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, t.BocxepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserCreated", System.Data.DbType.String, 20, t.UserCreated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
                if (iError == 0)
                {
                    t.ContractID = (Guid)Cmd.Parameters["@ContractID"].Value;
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractDAL", "Insert(BocxepContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Update(BocxepContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContract_Update";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, t.ContractNo));
                Cmd.Parameters.Add(db.CreateParameter("@ContractDate", System.Data.DbType.DateTime, 8, t.ContractDate));
                Cmd.Parameters.Add(db.CreateParameter("@BocxepSubjectCode", System.Data.DbType.String, 10, t.BocxepSubjectCode));
                Cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, t.FromDate));
                Cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, t.ToDate));
                Cmd.Parameters.Add(db.CreateParameter("@Description", System.Data.DbType.String, 100, t.Description));
                Cmd.Parameters.Add(db.CreateParameter("@UserUpdated", System.Data.DbType.String, 20, t.UserUpdated));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractDAL", "Update(BocxepContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }
        public override int Delete(BocxepContract t)
        {
            int iError = 0;
            bool AlreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open) db.Open();
                else AlreadyOpen = true;
                DbCommand Cmd = db.CreateCommand();
                Cmd.CommandText = "usp_BocxepContract_Delete";
                Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                Cmd.Parameters.Add(db.CreateParameter("@ContractID", System.Data.DbType.Guid, 16, t.ContractID));
                Cmd.Parameters.Add(db.CreateParameter("@iError", System.Data.DbType.Int32, 4, 0, System.Data.ParameterDirection.Output));
                iError = db.ExecuteNonQuery(Cmd);
                iError = (int)Cmd.Parameters["@iError"].Value;
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("BocxepContractDAL", "Delete(BocxepContract t)", excp.Message);
            }
            finally
            {
                if (!AlreadyOpen) db.Close();
            }
            return iError;
        }

        public ListBase<BocxepContract> GetBySubjectCodeAndDate(string subjectCode,DateTime fromDate)
        {
            ListBase<BocxepContract> lst = new ListBase<BocxepContract>();
            bool alreadyOpen = false;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_BocxepContract_SelectBySubjectAndDate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));

                DataTable dt = db.ExecuteTable(cmd);
                foreach (DataRow row in dt.Rows)
                    lst.Add(new BocxepContract(row));
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("BocxepContractDAL", "GetBySubjectCodeAndDate(string subjectCode,DateTime fromDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return lst;
        }
    }
}
