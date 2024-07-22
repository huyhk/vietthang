
using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Data.DAL;
using VNS.Utils;


namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetLiquidateBLL : AccountTransactionBLL<AccountTransactionFixedAssetLiquidate>, IBusiness
    {
        FixedAssetLiquidateDAL dalFixedAsset;
        public AccountTransactionFixedAssetLiquidateBLL()
        { }

        public int Insert(AccountTransactionFixedAssetLiquidate t)
        {
            dalFixedAsset = new FixedAssetLiquidateDAL(dalAccountTransaction.DBHelper);
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
                Write2Log.WriteLogs("AccountTransactionFixedAssetLiquidateBLL", "Insert(AccountTransactionFixedAssetLiquidate t)", excp.Message);
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

        public void GetDetailAccountTransactionFixedAssetLiquidate(AccountTransactionFixedAssetLiquidate accFixedAsset)
        {
            dalFixedAsset = new FixedAssetLiquidateDAL();
            dalFixedAsset.GetDetailAccountTransactionFixedAssetLiquidate(accFixedAsset);
        }
        public int Update(AccountTransactionFixedAssetLiquidate t)
        {
            dalFixedAsset = new FixedAssetLiquidateDAL(dalAccountTransaction.DBHelper);
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
                Write2Log.WriteLogs("AccountTransactionFixedAssetLiquidateBLL", "Update(AccountTransactionFixedAssetLiquidate t)", excp.Message);
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
        public int Delete(AccountTransactionFixedAssetLiquidate t)
        {
            //int iError = 0;
            //dalFixedAsset = new FixedAssetUpgradeDAL(dalAccountTransaction.DBHelper);
            //if (t.FixedAsset == null)
            //    dal.GetDetailAccountTransactionFixedAssetUpgrade(t);

            //dalAccountTransaction.Open();
            //dalAccountTransaction.BeginTransaction();
            //try
            //{
            //    iError = DeleteBase(t);
            //    //if (iError == 0)
            //    //    iError = dalFixedAsset.Delete(t.FixedAsset.FixedAssetCode);
            //}
            //catch (Exception excp)
            //{
            //    iError = -1000;
            //    Write2Log.WriteLogs("AccountTransactionFixedAssetUpgradeBLL", "Delete(AccountTransactionFixedAssetUpgrade t)", excp.Message);
            //}
            //finally
            //{
            //    if (iError == 0)
            //        dalAccountTransaction.Commit();
            //    else
            //        dalAccountTransaction.Rollback();
            //    dalAccountTransaction.Close();
            //}
            //return iError;
            return DeleteBase(t);
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountTransactionFixedAssetLiquidate);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransactionFixedAssetLiquidate);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransactionFixedAssetLiquidate);
        }
        #endregion
    }
}