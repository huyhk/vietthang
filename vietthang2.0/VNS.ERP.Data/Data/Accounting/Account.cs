using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
namespace VNS.ERP.Data.Accounting
{
    public class Account : UserTracking2
    {
        public static readonly DateTime StockAccountingEffectiveDate = new DateTime(2026, 1, 1);
        public const string OldMaterialAccount = "6111";
        public const string NewMaterialAccount = "152";
        public const string OldProductAccount = "6321";
        public const string NewProductAccount = "155";
        public const string OldProductCostAccount = "6311";
        public const string NewProductCostAccount = "154";

        // Compatibility values for existing screens. Posting code must use the
        // date-based account selectors below.
        public static string FuelAccount = NewMaterialAccount;
        public static string MaterialAccount = NewMaterialAccount;
        public static string ExpensesAccount6113 = "6113";
        public static string ExpensesAccount6114 = "6114";
        public static string ExpensesAccount6115 = "6115";
        public static string ExpensesAccount6116 = "6116";
        public static string ExpensesAccount6117 = "6117";
        public static string ExpensesAccount6212 = "6212";
        public static string MaterialAccount152 = "152";
        public static string ProductAccount = OldProductAccount;
        public static string ProductAccountTS = "63211";
        public static string ProductAccountGS = "63212";
        public static string ProductAccountCV = "63213";
        public static string ProductAccount155 = NewProductAccount;
        public static string FixedAssetAccount = "211";
        public static string DiscountAccount521 = "521";
        public static string DiscountAccount5211 = "5211";
        public static string DiscountAccount5212 = "5212";
        public static string DiscountAccount52121 = "52121";
        public static string DiscountAccount52122 = "52122";
        public static string DiscountAccount52123 = "52123";
        public static string DiscountAccount521121 = "521121";
        public static string DiscountAccount521122 = "521122";
        public static string DiscountAccount521123 = "521123";
        public static string GoodReturnAccount52121 = "52121";
        public static string GoodReturnAccount52122 = "52122";
        public static string GoodReturnAccount52123 = "52123";
        public static string DiscountAccount5213 = "5213";
        public static string SaveAndServiceIncome511 = "511";
        public static string SaveAndServiceIncome5111 = "5111";
        public static string SaveAndServiceIncome5112 = "5112";
        public static string SaveAndServiceIncome51121 = "51121";
        public static string SaveAndServiceIncome51122 = "51122";
        public static string SaveAndServiceIncome51123 = "51123";
        public static string SaveAndServiceIncome5113 = "5113";
        public static string IncomeProductAccount = "5112";
        public static string IncomeProductAccountTS = "51121";
        public static string IncomeProductAccountGS = "51122";
        public static string IncomeProductAccountCV = "51123";
        public static string CustomerDeptAccount = "131";
        public static string VATOutAccount = "33311";
        public static string ProductCostAccount = OldProductCostAccount;
        public static string InvoiceDiscountAccount = "521";
        public static string SaleDiscountAccount = "532";
        public static string SaleProductDiscountAccount = "5211";
        public static string SaleProductDiscountAccountTS = "521121";
        public static string SaleProductDiscountAccountGS = "521122";
        public static string SaleProductDiscountAccountCV = "521123";
        public static string VendorDebtAccount = "331";
        public static string VATInAccount = "1331";
        public static string TangibleFixedAssetDep = "2141";
        public static string MaterialExpense="621";
        public static string LabourProductionExpense = "622";
        public static string GeneralProductionExpense = "627";
        public static string PrePaidShortTerm = "142";
        public static string ProfitAccount = "911";
        public static string PrePaidLongTerm = "242";
        public static string ProfitAccount4211 = "4212";

        public static string TempAccount999 = "999";

        public static bool UseNewStockAccounting(DateTime transactionDate)
        {
            return transactionDate.Date >= StockAccountingEffectiveDate;
        }

        public static string GetMaterialAccount(DateTime transactionDate)
        {
            return UseNewStockAccounting(transactionDate) ? NewMaterialAccount : OldMaterialAccount;
        }

        public static string GetProductAccount(DateTime transactionDate)
        {
            return UseNewStockAccounting(transactionDate) ? NewProductAccount : OldProductAccount;
        }

        public static string GetProductCostAccount(DateTime transactionDate)
        {
            return UseNewStockAccounting(transactionDate) ? NewProductCostAccount : OldProductCostAccount;
        }

        public static bool IsMaterialInventoryAccount(string accountCode)
        {
            return !string.IsNullOrEmpty(accountCode)
                && (accountCode.StartsWith(OldMaterialAccount) || accountCode.StartsWith(NewMaterialAccount));
        }

        public static bool IsProductInventoryAccount(string accountCode)
        {
            return !string.IsNullOrEmpty(accountCode)
                && (accountCode.StartsWith("632") || accountCode.StartsWith(NewProductAccount));
        }

        public static bool IsStockReportPeriodValid(DateTime startDate, DateTime endDate, string accountCode)
        {
            if (startDate.Date < StockAccountingEffectiveDate && endDate.Date >= StockAccountingEffectiveDate)
                return false;
            if (endDate.Date < StockAccountingEffectiveDate)
                return accountCode.StartsWith(OldMaterialAccount) || accountCode.StartsWith("632");
            return accountCode.StartsWith(NewMaterialAccount) || accountCode.StartsWith(NewProductAccount);
        }
        public Account() { }
        public Account(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountCode", reader)) fAccountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("AccountName", reader)) fAccountName = reader.GetString(reader.GetOrdinal("AccountName"));
            if (!isNull("AccountType", reader)) fAccountType = reader.GetByte(reader.GetOrdinal("AccountType"));
            if (!isNull("AccountLevel", reader)) fAccountLevel = reader.GetByte(reader.GetOrdinal("AccountLevel"));
            if (!isNull("AccountParent", reader)) fAccountParent = reader.GetString(reader.GetOrdinal("AccountParent"));
            if (!isNull("Description", reader)) fDescription = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("DetailSubject", reader)) fDetailSubject = reader.GetBoolean(reader.GetOrdinal("DetailSubject"));
            if (!isNull("DetailClassification", reader)) fDetailClassification = reader.GetBoolean(reader.GetOrdinal("DetailClassification"));
            if (!isNull("ClassificationTypeCode", reader)) fClassificationTypeCode = reader.GetString(reader.GetOrdinal("ClassificationTypeCode"));
        }
        private string fAccountCode=string.Empty;
        public string AccountCode
        {
            get { return fAccountCode; }
            set { fAccountCode = value; }
        }
        private string fAccountName = string.Empty;
        public string AccountName
        {
            get { return fAccountName; }
            set { fAccountName = value; }
        }
        private byte fAccountType;
        public byte AccountType
        {
            get { return fAccountType; }
            set { fAccountType = value; }
        }
        private byte fAccountLevel=1;
        public byte AccountLevel
        {
            get { return fAccountLevel; }
            set { fAccountLevel = value; }
        }
        private string fAccountParent = string.Empty;
        public string AccountParent
        {
            get { return fAccountParent; }
            set { fAccountParent = value; }
        }
        private string fDescription = string.Empty;
        public string Description
        {
            get { return fDescription; }
            set { fDescription = value; }
        }
        private bool fDetailSubject;
        public bool DetailSubject
        {
            get { return fDetailSubject; }
            set { fDetailSubject = value; }
        }
        private bool fDetailClassification;
        public bool DetailClassification
        {
            get { return fDetailClassification; }
            set { fDetailClassification = value; }
        }
        private string fClassificationTypeCode = string.Empty;
        public string ClassificationTypeCode
        {
            get { return fClassificationTypeCode; }
            set { fClassificationTypeCode = value; }
        }

        private ListBase<AccountSubjectType> lstAccSubjectType;
        public ListBase<AccountSubjectType> LstAccSubjectType
        {
            get { return lstAccSubjectType; }
            set { lstAccSubjectType = value; }
        }
    }
}
