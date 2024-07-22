using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data;
using VNS.Utils;
using System.Data.Common;

namespace VNS.ERP.Data.Purchases
{
    public class PurchaseReportDAL : DataAccessBase
    {
        public PurchaseReportDAL()
        { }
        public PurchaseReportDAL(DBHelper dbHelper)
            : base(dbHelper)
        { }

        #region DataSet

        public DataSet PurchaseTransaction_SelectByContractNo(string contractNo, string subjectCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseTransaction_SelectByContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                ds = db.ExecuteDataSet(cmd);

                //DataRelation DtRelation = ds.Relations.Add("PurchaseTransaction",
                //   ds.Tables[0].Columns["ItemCode"],
                //   ds.Tables[1].Columns["ItemCode"]);
                if (ds != null)
                {
                    ds.Tables[0].TableName = "Header";
                    ds.Tables[1].TableName = "Detail";
                    DataRelation dataRelation = new DataRelation("PurchaseTransaction", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                    ds.Relations.Add(dataRelation);
                }
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseReportDAL", "PurchaseTransaction_SelectByContractNo(string contractNo, string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet Baocaomuahang(DateTime fromDate, DateTime toDate, string itemType)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Purchase_Report_Baocaomuahang";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 50, itemType));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Detail1",
                   ds.Tables[0].Columns["ItemCode"],
                   ds.Tables[1].Columns["ItemCode"]);
                DtRelation = ds.Relations.Add("Detail2", 
                    new DataColumn[] {ds.Tables[1].Columns["DVGiao"], ds.Tables[1].Columns["ItemCode"]},
                        new DataColumn[] { ds.Tables[2].Columns["DVGiao"], ds.Tables[2].Columns["ItemCode"] });
                //if (ds != null)
                //{
                //    ds.Tables[0].TableName = "Header";
                //    ds.Tables[1].TableName = "Detail";
                //    DataRelation dataRelation = new DataRelation("PurchaseTransaction", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                //    ds.Relations.Add(dataRelation);
                //}
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseContractDAL", "Baocaomuahang(DateTime fromDate, DateTime toDate)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet TonghopMuahangNam(int year, string itemType, bool group)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                if (group)
                    cmd.CommandText = "usp_Purchase_Report_TonghopMuahangNamGroup";
                else
                    cmd.CommandText = "usp_Purchase_Report_TonghopMuahangNam";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 4, year));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 50, itemType));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Detail",
                   ds.Tables[0].Columns["ItemCode"],
                   ds.Tables[1].Columns["ItemCode"]);
                //if (ds != null)
                //{
                //    ds.Tables[0].TableName = "Header";
                //    ds.Tables[1].TableName = "Detail";
                //    DataRelation dataRelation = new DataRelation("PurchaseTransaction", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                //    ds.Relations.Add(dataRelation);
                //}
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseReportDAL", "Baocaomuahang(int year, string itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet TonghopMuahangNam2(DateTime fromDate, string itemType, bool group)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                if (group)
                    cmd.CommandText = "usp_Purchase_Report_TonghopMuahangNamGroup2";
                else
                    cmd.CommandText = "usp_Purchase_Report_TonghopMuahangNam2";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ItemType", System.Data.DbType.String, 50, itemType));
                ds = db.ExecuteDataSet(cmd);

                DataRelation DtRelation = ds.Relations.Add("Detail",
                   ds.Tables[0].Columns["ItemCode"],
                   ds.Tables[1].Columns["ItemCode"]);
                //if (ds != null)
                //{
                //    ds.Tables[0].TableName = "Header";
                //    ds.Tables[1].TableName = "Detail";
                //    DataRelation dataRelation = new DataRelation("PurchaseTransaction", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                //    ds.Relations.Add(dataRelation);
                //}
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseReportDAL", "Baocaomuahang2(int year, string itemType)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet PurchaseInvoice_SelectByContractNo(string contractNo, string subjectCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_PurchaseInvoice_SelectByContractNo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@ContractNo", System.Data.DbType.String, 20, contractNo));
                cmd.Parameters.Add(db.CreateParameter("@SubjectCode", System.Data.DbType.String, 10, subjectCode));
                ds = db.ExecuteDataSet(cmd);

                //if (ds != null)
                //{
                //    ds.Tables[0].TableName = "Header";
                //    ds.Tables[1].TableName = "Detail";
                //    DataRelation dataRelation = new DataRelation("PurchaseInvoice", new DataColumn[] { ds.Tables["Header"].Columns["Khonhap"], ds.Tables["Header"].Columns["ItemCode"] }, new DataColumn[] { ds.Tables["Detail"].Columns["Khonhap"], ds.Tables["Detail"].Columns["ItemCode"] });
                //    ds.Relations.Add(dataRelation);
                //}
            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseContractDAL", "PurchaseTransaction_SelectByContractNo(string contractNo, string subjectCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet Report_Phantichmuahang(int year, string itemCode)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Purchase_Report_Phantichmuahang";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 4, year));
                cmd.Parameters.Add(db.CreateParameter("@ItemCode", System.Data.DbType.String, 50, itemCode));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseContractDAL", "Report_Phantichmuahang(int year, string itemCode)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        public DataSet Report_Phantichmuahang_Group(int year, string itemGroup)
        {
            bool alreadyOpen = false;
            DataSet ds = new DataSet();
            try
            {

                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Purchase_Report_Phantichmuahang_Group";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@Year", System.Data.DbType.Int32, 4, year));
                cmd.Parameters.Add(db.CreateParameter("@ItemGroup", System.Data.DbType.String, 20, itemGroup));
                ds = db.ExecuteDataSet(cmd);

            }
            catch (Exception excp)
            {

                Write2Log.WriteLogs("PurchaseContractDAL", "Report_Phantichmuahang_Group(int year, string itemGroup)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
            return ds;
        }
        #endregion

        #region DataTable

        public DataTable Purchase_Report_Theodoihopdong(DateTime fromDate, DateTime toDate)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Purchase_Report_Theodoihopdong";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseReportDAL", "Purchase_Report_Theodoihopdong(DateTime fromDate, DateTime toDate)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }
        public DataTable Purchase_Report_Chitietmuahang(DateTime fromDate, DateTime toDate)
        {
            bool alreadyOpen = false;
            DataTable dt = null;
            try
            {
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_Purchase_Report_Chitietmuahang";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@FromDate", System.Data.DbType.DateTime, 8, fromDate));
                cmd.Parameters.Add(db.CreateParameter("@ToDate", System.Data.DbType.DateTime, 8, toDate));
                dt = db.ExecuteTable(cmd);
            }

            catch (Exception excp)
            {
                Write2Log.WriteLogs("PurchaseReportDAL", "Purchase_Report_Chitietmuahang(DateTime fromDate, DateTime toDate)", excp.Message);
            }

            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }

            return dt;
        }

        #endregion
    }
}
