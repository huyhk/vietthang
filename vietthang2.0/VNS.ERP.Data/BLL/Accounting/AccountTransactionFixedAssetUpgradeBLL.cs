
using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Data.DAL;
using VNS.Utils;


namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetUpgradeBLL : AccountTransactionBLL<AccountTransactionFixedAssetUpgrade>, IBusiness
    {
        AccountTransactionFixedAssetUpgradeDAL dal = new AccountTransactionFixedAssetUpgradeDAL();
        FixedAssetUpgradeDAL dalFixedAsset ;
        public AccountTransactionFixedAssetUpgradeBLL()
        {  }

        public int Insert(AccountTransactionFixedAssetUpgrade t)
        {
            dalFixedAsset = new FixedAssetUpgradeDAL(dalAccountTransaction.DBHelper);
            int iError = 0;
            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
            try
            {
                iError = InsertBase(t);
                if (iError == 0)
                {
                    t.FixedAsset.AccountTransactionID = t.AccountTransactionID;
                    iError = dalFixedAsset.Insert(t.FixedAsset);
                }
            }           
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionFixedAssetUpgradeBLL", "Insert(AccountTransactionFixedAssetUpgrade t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dalAccountTransaction.Commit();
                else
                    dalAccountTransaction.Rollback();
                dalAccountTransaction.Close();
            }
            return iError;
        }

        public void GetDetailAccountTransactionFixedAssetUpgrade(AccountTransactionFixedAssetUpgrade accFixedAsset)
        {
            dal.GetDetailAccountTransactionFixedAssetUpgrade(accFixedAsset);
        }
        public int Update(AccountTransactionFixedAssetUpgrade t)
        {
            dalFixedAsset = new FixedAssetUpgradeDAL(dalAccountTransaction.DBHelper);
            int iError = 0;
            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
          
            try
            {
                iError = UpdateBase(t);
                if (iError == 0)
                {
                    t.FixedAsset.AccountTransactionID = t.AccountTransactionID;
                    iError = dalFixedAsset.Update(t.FixedAsset);
                }
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionFixedAssetUpgradeBLL", "Update(AccountTransactionFixedAssetUpgrade t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dalAccountTransaction.Commit();
                else
                    dalAccountTransaction.Rollback();
                dalAccountTransaction.Close();
            }
            return iError;
        }
        public int Delete(AccountTransactionFixedAssetUpgrade t)
        {
            int iError = 0;
            dalFixedAsset = new FixedAssetUpgradeDAL(dalAccountTransaction.DBHelper);
            if (t.FixedAsset == null)
                dal.GetDetailAccountTransactionFixedAssetUpgrade(t);

            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
            try
            {
                iError = DeleteBase(t);
                //if (iError == 0)
                //    iError = dalFixedAsset.Delete(t.FixedAsset.FixedAssetCode);
            }
            catch (Exception excp)
            {
               iError = -1000;
               Write2Log.WriteLogs("AccountTransactionFixedAssetUpgradeBLL", "Delete(AccountTransactionFixedAssetUpgrade t)", excp.Message);
            }
            finally
            {
                if (iError == 0)
                    dalAccountTransaction.Commit();
                else
                    dalAccountTransaction.Rollback();
                dalAccountTransaction.Close();
            }
            return iError;
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountTransactionFixedAssetUpgrade);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransactionFixedAssetUpgrade);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransactionFixedAssetUpgrade);
        }
        #endregion
    }
}