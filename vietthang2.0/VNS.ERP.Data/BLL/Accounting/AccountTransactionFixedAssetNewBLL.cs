using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Data.DAL;
using VNS.Utils;


namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetNewBLL : AccountTransactionBLL<AccountTransactionFixedAssetNew>, IBusiness
    {
        AccountTransactionFixedAssetNewDAL dal = new AccountTransactionFixedAssetNewDAL();
        AccountFixedAssetDAL dalFixedAsset ;
        public AccountTransactionFixedAssetNewBLL()
        {  }

        public int Insert(AccountTransactionFixedAssetNew t)
        {
            dalFixedAsset = new AccountFixedAssetDAL(dalAccountTransaction.DBHelper);
            int iError = 0;
            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
            try
            {
               iError=InsertBase(t);
                if (iError == 0)
                {
                    iError = dalFixedAsset.Insert(t.FixedAsset);
                    if (iError == 0)
                        iError = dalFixedAsset.InsertAccountAssets(t.AccountTransactionID, t.FixedAsset.FixedAssetCode);
                }
                 
            }           
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionFixedAssetNewBLL", "Insert(AccountTransactionFixedAssetNew t)", excp.Message);
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

        public void GetDetailAccountTransactionFixedAssetNew(AccountTransactionFixedAssetNew accFixedAsset)
        {
            dal.GetDetailAccountTransactionFixedAssetNew(accFixedAsset);
        }
        public int Update(AccountTransactionFixedAssetNew t)
        {
            dalFixedAsset = new AccountFixedAssetDAL(dalAccountTransaction.DBHelper);
            int iError = 0;
            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
            try
            {
               iError = UpdateBase(t);
               if(iError==0)
                    iError = dalFixedAsset.Update(t.FixedAsset);
            }
            catch (Exception excp)
            {
                iError = -1000;
                Write2Log.WriteLogs("AccountTransactionFixedAssetNewBLL", "Insert(AccountTransactionFixedAssetNew t)", excp.Message);
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
        public int Delete(AccountTransactionFixedAssetNew t)
        {
            if (t.FixedAsset == null)
                dal.GetDetailAccountTransactionFixedAssetNew(t);
            dalFixedAsset = new AccountFixedAssetDAL(dalAccountTransaction.DBHelper);
            int iError = 0;
            dalAccountTransaction.Open();
            dalAccountTransaction.BeginTransaction();
            try
            {
                iError = DeleteBase(t);
                if (iError == 0)
                    iError = dalFixedAsset.Delete(t.FixedAsset.FixedAssetCode);
            }
            catch (Exception excp)
            {
               iError = -1000;
                Write2Log.WriteLogs("AccountTransactionFixedAssetNewBLL", "Delete(AccountTransactionFixedAssetNew t)", excp.Message);
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
            return this.Insert(obj as AccountTransactionFixedAssetNew);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransactionFixedAssetNew);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransactionFixedAssetNew);
        }
        #endregion
    }
}
