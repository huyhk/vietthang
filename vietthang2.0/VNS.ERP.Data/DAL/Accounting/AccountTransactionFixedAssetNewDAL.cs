using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using System.Data;
using VNS.Common;
using System.Data.Common;
using VNS.Utils;

namespace VNS.ERP.Data.Accounting
{
    class AccountTransactionFixedAssetNewDAL:BaseDAL<AccountTransactionFixedAssetNew>
    {
        public AccountTransactionFixedAssetNewDAL() { }
        public AccountTransactionFixedAssetNewDAL(DBHelper dbHelper) : base(dbHelper) { }
        public void GetDetailAccountTransactionFixedAssetNew(AccountTransactionFixedAssetNew accFixedAsset)
        {
            bool alreadyOpen = false;
            try
            {
                DbDataReader reader = null;
                if (db.State != System.Data.ConnectionState.Open)
                    db.Open();
                else
                    alreadyOpen = true;
                DbCommand cmd = db.CreateCommand();
                cmd.CommandText = "usp_AccountTransactionFixedAssetNew_Select";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(db.CreateParameter("@AccountTransactionID", System.Data.DbType.Guid, 16, accFixedAsset.AccountTransactionID));

                reader = db.ExecuteReader(cmd);
                while (reader.Read())
                {
                          accFixedAsset.FixedAsset  = new AccountFixedAssets(reader);
                }
                reader.Close();
            }
            catch (Exception excp)
            {
                Write2Log.WriteLogs("AccountTransactionFixedAssetNewDAL", "GetDetailAccountTransactionFixedAssetNew(AccountTransactionFixedAssetNew accFixedAsset)", excp.Message);
            }
            finally
            {
                if (!alreadyOpen)
                    db.Close();
            }
        }
    }
}
