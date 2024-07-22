using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionDetail1 : BaseClass
    {
        public AccountTransactionDetail1() { }
        public AccountTransactionDetail1(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionDetail1ID", reader)) accountTransactionDetail1ID = reader.GetGuid(reader.GetOrdinal("AccountTransactionDetail1ID"));
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("ClassificationCode", reader)) classificationCode = reader.GetString(reader.GetOrdinal("ClassificationCode"));
            if (!isNull("DebitAmount", reader)) debitAmount = reader.GetDecimal(reader.GetOrdinal("DebitAmount"));
            if (!isNull("CreditAmount", reader)) creditAmount = reader.GetDecimal(reader.GetOrdinal("CreditAmount"));
            if (!isNull("CurrencyCode", reader)) currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
            if (!isNull("Rate", reader)) rate = reader.GetDecimal(reader.GetOrdinal("Rate"));
            if (!isNull("DebitAmountNT", reader)) debitAmountNT = reader.GetDecimal(reader.GetOrdinal("DebitAmountNT"));
            if (!isNull("CreditAmountNT", reader)) creditAmountNT = reader.GetDecimal(reader.GetOrdinal("CreditAmountNT"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("CongtrinhCode", reader)) congtrinhCode = reader.GetString(reader.GetOrdinal("CongtrinhCode"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionDetail1ID")) accountTransactionDetail1ID = (Guid)row["AccountTransactionDetail1ID"];
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("AccountCode")) accountCode = (string)row["AccountCode"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("ClassificationCode")) classificationCode = (string)row["ClassificationCode"];
            if (!row.IsNull("DebitAmount")) debitAmount = (decimal)row["DebitAmount"];
            if (!row.IsNull("CreditAmount")) creditAmount = (decimal)row["CreditAmount"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("Rate")) rate = (decimal)row["Rate"];
            if (!row.IsNull("DebitAmountNT")) debitAmountNT = (decimal)row["DebitAmountNT"];
            if (!row.IsNull("CreditAmountNT")) creditAmountNT = (decimal)row["CreditAmountNT"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("CongtrinhCode")) congtrinhCode = (string)row["CongtrinhCode"];
        }
        private Guid accountTransactionDetail1ID;
        public Guid AccountTransactionDetail1ID
        {
            get { return accountTransactionDetail1ID; }
            set { accountTransactionDetail1ID = value; }
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }
        private string accountCode=string.Empty;
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        public string DebitAccountCode
        {
            get 
            {
                return debitAmount != 0 ? accountCode : string.Empty;
            }
        }
        public string CreditAccountCode
        {
            get
            {
                return creditAmount != 0 ? accountCode : string.Empty;
            }
        }

        private string subjectCode=string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string classificationCode=string.Empty;
        public string ClassificationCode
        {
            get { return classificationCode; }
            set { classificationCode = value; }
        }
        private bool isTest = false;

        public bool IsTest
        {
            get { return isTest; }
            set { isTest = value; }
        }

	
        private decimal debitAmount;
        public decimal DebitAmount
        {
            get { return debitAmount; }
            set {
                debitAmount = value;
                if (debitAmount != 0 && !isTest)
                    creditAmount = 0;
              
            }
        }
        private decimal creditAmount;
        public decimal CreditAmount
        {
            get { return creditAmount; }
            set {
                creditAmount = value;
                if (creditAmount != 0 && !isTest)
                    debitAmount = 0;
            }
        }
        private string currencyCode=string.Empty;
        public string CurrencyCode
        {
            get { return currencyCode; }
            set {
                currencyCode = value;
                if (currencyCode != string.Empty)
                {
                    if (debitAmount != 0 && Rate != 0)
                        debitAmountNT = decimal.Round(debitAmount / Rate, 2);
                    if (creditAmount != 0 && Rate != 0)
                        creditAmountNT = decimal.Round(creditAmount / Rate, 2);
                }
                else
                {
                    rate = 0;
                    debitAmountNT = 0;
                    creditAmountNT = 0;
                }
               
                }
        }
        private decimal rate;
        public decimal Rate
        {
            get { return rate; }
            set {
                rate = value;
                if (currencyCode != string.Empty)
                {
                    if (debitAmount != 0 && rate!=0)
                        debitAmountNT = decimal.Round( debitAmount / rate,2);
                    if (creditAmount != 0 && rate != 0)
                        creditAmountNT = decimal.Round(creditAmount / rate, 2);
                }
                }
        }
        private decimal debitAmountNT;
        public decimal DebitAmountNT
        {
            get { return debitAmountNT; }
            set { debitAmountNT = value; }
        }
        private decimal creditAmountNT;
        public decimal CreditAmountNT
        {
            get { return creditAmountNT; }
            set { creditAmountNT = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string congtrinhCode = string.Empty;
        public string CongtrinhCode
        {
            get { return congtrinhCode; }
            set { congtrinhCode = value; }
        }
    }
}
