using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VNS.Data.DAL;
using System.Configuration;
using Microsoft.SqlServer.Replication;
using Microsoft.SqlServer.Management;
using SQLDMO;
using ADODB;
using ADOR;
namespace VNS.ERP.DataSynchronize
{
    public class test
    {
        DBHelper db = new DBHelper();
        DBHelper db1 = new DBHelper(ConfigurationManager.AppSettings["Server1"], ConfigurationManager.AppSettings["Database1"], ConfigurationManager.AppSettings["UserName1"], VNS.Security.Crypto.DecryptString(ConfigurationManager.AppSettings["Password1"]));
        DBHelper db2 = new DBHelper(ConfigurationManager.AppSettings["Server2"], ConfigurationManager.AppSettings["Database2"], ConfigurationManager.AppSettings["UserName2"], VNS.Security.Crypto.DecryptString(ConfigurationManager.AppSettings["Password2"]));
        string serverName2 = "LAIVUNG";
        
        public test()
        {
            
        }
        public void process()
        {
            try
            {
                db.Open();
                db1.Open();
                db2.Open();
                DoStockTransaction(DateTime.Parse("1/1/2007"));
            }
            catch
            { }
            finally
            {
                db.Close();
                db1.Close();
                db2.Close();
            }
        }
        public void DoStockTransaction(DateTime date)
        {

            DataSet1.StockTransactionsDataTable st = new DataSet1.StockTransactionsDataTable();
            DataSet1 ds = new DataSet1();
            
            
            string sql = "Select * from StockTransactions where TransactionDate>='" + date.ToString() + "' and ServerCreated='" + serverName2+"'";
            sql += "\n" + "Select dt.* from StockTransactionSumDetails dt inner join StockTransactions st on dt.TransactionID=st.TransactionID where st.TransactionDate>='" + date.ToString() + "' and ServerCreated='" + serverName2 + "'";
            sql += "\n" + "Select dt.* from StockTransactionDetails dt inner join StockTransactions st on dt.TransactionID=st.TransactionID where st.TransactionDate>='" + date.ToString() + "' and ServerCreated='" + serverName2 + "'";
            DataSet ds1 = db1.ExecuteDataSet(sql);
            DataSet ds2 = db2.ExecuteDataSet(sql);
            //delete Items exists in db1 and not exists in db2
            DataView view2 = ds2.Tables[0].DefaultView;
            view2.Sort = "TransactionID";
            foreach (DataRow row1 in ds1.Tables[0].Rows)
            {
                if (view2.Find(row1["TransactionID"]) < 0)
                { }
            }
            //update Items in db1 older than in db2
            //insert new items in db2 that not exists in db1
        }
    }
}
