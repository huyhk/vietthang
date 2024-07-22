using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using VNS.Data.BLL;
using VNS.Utils;
namespace VNS.ERP.Data.Accounting
{
   public class FixedAssetGeneralBLL
    {
       public ListBase<FixedAssetGeneral> GetDepreciation(Period period)
       {
           ListBase<FixedAssetGeneral> lstReturn = (new FixedAssetGeneralDAL()).GetListFixedAssetGeneralByPeriodCode(period.PeriodCode);
           ListBase<AccountFixedAssets> lstNew=(new AccountFixedAssetDAL()).GetFixedAssetUpgradeByStartDate_EndDate(period.StartDate,period.EndDate);
           ListBase<FixedAssetUpgrade> lstUpgrade = (new FixedAssetUpgradeDAL()).GetFixedAssetUpgradeByStartDate_EndDate(period.StartDate, period.EndDate);
           ListBase<FixedAssetLiquidate> lstLiquidate = (new FixedAssetLiquidateDAL()).GetFixedAssetLiquidateByStartDate_EndDate(period.StartDate, period.EndDate);
           ListBase<FixedAssetDepreciation> lstDep = (new FixedAssetDepreciationDAL()).GetListFixedAssetDepreciationByPeriodCode(period.PeriodCode);
           foreach (FixedAssetGeneral f in lstReturn)
           {
               f.Sodudauky = f.OriginalPrice;
               if (f.IsSpec)
                   f.AccountCode = Account.TempAccount999;
           }
           foreach (AccountFixedAssets accFixedAsset in lstNew)
           {
               FixedAssetGeneral fGen = new FixedAssetGeneral();
               fGen.AccountCode = accFixedAsset.AccountCode;
               fGen.SubjectCode = accFixedAsset.SubjectCode;
               fGen.FixedAssetCode = accFixedAsset.FixedAssetCode;
               fGen.FixedAssetName = accFixedAsset.FixedAssetName;
               fGen.OriginalPrice = accFixedAsset.OriginalPrice;
               fGen.MonthUsing = accFixedAsset.MonthUsing;
               fGen.RemainCost = accFixedAsset.OriginalPrice;
               fGen.PriceDepreciation = accFixedAsset.OriginalPrice;
               fGen.NgayCT = accFixedAsset.NgayCT;
               fGen.DepAccountCode = accFixedAsset.DepAccountCode;

               //fGen.Sodudauky = 0;
               fGen.Tangtrongky = accFixedAsset.OriginalPrice;

               lstReturn.Add(fGen);
           }
           foreach (FixedAssetUpgrade fUpgrade in lstUpgrade)
           {
               FixedAssetGeneral fGenFine = lstReturn.Search("FixedAssetCode", fUpgrade.FixedAssetCode);
               if (fGenFine != null)
               {
                   fGenFine.OriginalPrice += fUpgrade.Amount;
                   //fGenFine.RemainCost += fUpgrade.Amount;
                   fGenFine.PriceDepreciation = fGenFine.RemainCost + fUpgrade.Amount;
                   fGenFine.MonthUsing = fUpgrade.MonthUsing;

                   fGenFine.Tangtrongky = fUpgrade.Amount;
               }
           
           }
           foreach (FixedAssetLiquidate fLiquidate in lstLiquidate)
           {
               FixedAssetGeneral fGenFine = lstReturn.Search("FixedAssetCode", fLiquidate.FixedAssetCode);
               if (fGenFine != null)
               {
                   //fGenFine.OriginalPrice -= fLiquidate.Amount;
                   //fGenFine.RemainCost += fUpgrade.Amount;
                   //fGenFine.PriceDepreciation = fGenFine.RemainCost + fUpgrade.Amount;
                   //fGenFine.MonthUsing = fUpgrade.MonthUsing;

                   fGenFine.Giamtrongky = fLiquidate.Amount;
               }

           }
           foreach (FixedAssetDepreciation fDep in lstDep)
           {
               FixedAssetGeneral fGenFine = lstReturn.Search("FixedAssetCode", fDep.FixedAssetCode);
               if(fGenFine!=null)
               fGenFine.DepreciationInput = fDep.Amount;
           }
           return lstReturn;
       }

       /// <summary>
       /// Inserts List objects FixedAssetDepreciation into DataBase.
       /// </summary>
       /// <param name="lst"></param>
       /// <param name="periodCode"></param>
       /// <returns></returns>
       public int Insert(ListBase<FixedAssetGeneral> lst, string periodCode, string periodCodeLast)
       {
           FixedAssetDepreciationDAL dal = new FixedAssetDepreciationDAL();
           FixedAssetOpeningDAL dalOpen = new FixedAssetOpeningDAL(dal.DBHelper);
           int iError = 0;
           dal.Open();
           dal.BeginTransaction();
           try
           {
               iError = dal.Delete(periodCode);
               if(iError==0)
                   iError = dalOpen.DeleteByPeriodCode(periodCodeLast);
               if (iError == 0)
               {
                   foreach (FixedAssetGeneral fGen in lst)
                   {
                       ///FixedAssetDepreciation.
                       FixedAssetDepreciation fAdep = new FixedAssetDepreciation();
                       fAdep.PeriodCode = periodCode;
                       fAdep.FixedAssetCode = fGen.FixedAssetCode;
                       fAdep.Amount = fGen.DepreciationInput;
                       iError = dal.Insert(fAdep);
                       if (iError != 0)
                           break;
                       ///FixedAssetOpening.
                       if (fGen.Soducuoiky != 0)
                       {
                           FixedAssetOpening fOpen = new FixedAssetOpening();
                           fOpen.PeriodCode = periodCodeLast;
                           fOpen.FixedAssetCode = fGen.FixedAssetCode;
                           fOpen.FixedAssetName = fGen.FixedAssetName;
                           fOpen.AccountCode = fGen.AccountCode;
                           fOpen.SubjectCode = fGen.SubjectCode;
                           fOpen.StartDate = fGen.StartDate;
                           fOpen.Description = fGen.Description;
                           fOpen.OriginalPrice = fGen.OriginalPrice;
                           fOpen.RemainCost = fGen.RemainCostExtract;
                           fOpen.AccumulatedDepreciation = fGen.AccumulatedDepreciationExtract;
                           fOpen.MonthUsing = fGen.MonthUsing;
                           fOpen.PriceDepreciation = fGen.PriceDepreciation;
                           iError = dalOpen.Insert(fOpen);
                       }
                       if (iError != 0)
                           break;
                   }

               }
              

           }
           catch (Exception excp)
           {
               iError = -1000;
               Write2Log.WriteLogs("FixedAssetGeneralBLL", "Insert(ListBase<FixedAssetGeneral> lst,string periodCode,string periodCodeLast)", excp.Message);
           }
           finally
           {
               if (iError == 0)
                   dal.Commit();
               else
                   dal.Rollback();
               dal.Close();
           }
           return iError;
       }
    }
}
