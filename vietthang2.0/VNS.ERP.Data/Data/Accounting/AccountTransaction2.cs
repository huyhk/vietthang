using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransaction2:AccountTransaction
    {
        public void LoadFromDataRowD1(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            //if (!row.IsNull("AccountTransactionDetail1ID")) accountTransactionDetail1ID = (Guid)row["AccountTransactionDetail1ID"];
            if (!row.IsNull("AccountTransactionID")) AccountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("AccountCode")) accountCode = (string)row["AccountCode"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("ClassificationCode")) classificationCode = (string)row["ClassificationCode"];
            if (!row.IsNull("DebitAmount")) debitAmount = (decimal)row["DebitAmount"];
            if (!row.IsNull("CreditAmount")) creditAmount = (decimal)row["CreditAmount"];
            if (!row.IsNull("CurrencyCode")) currencyCode = (string)row["CurrencyCode"];
            if (!row.IsNull("Rate")) rate = (decimal)row["Rate"];
            if (!row.IsNull("DebitAmountNT")) debitAmountNT = (decimal)row["DebitAmountNT"];
            if (!row.IsNull("CreditAmountNT")) creditAmountNT = (decimal)row["CreditAmountNT"];
            //if (!row.IsNull("Description")) Description = (string)row["Description"];
        }
        private string accountCode = string.Empty;
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        private string subjectCode = string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string classificationCode = string.Empty;
        public string ClassificationCode
        {
            get { return classificationCode; }
            set { classificationCode = value; }
        }
        private decimal debitAmount;
        public decimal DebitAmount
        {
            get { return debitAmount; }
            set
            {
                debitAmount = value;
                if (debitAmount != 0)
                    creditAmount = 0;

            }
        }
        private decimal creditAmount;
        public decimal CreditAmount
        {
            get { return creditAmount; }
            set
            {
                creditAmount = value;
                if (creditAmount != 0)
                    debitAmount = 0;
            }
        }
        private string currencyCode = string.Empty;
        public string CurrencyCode
        {
            get { return currencyCode; }
            set
            {
                currencyCode = value;
                if (currencyCode != string.Empty)
                {
                    if (debitAmount != 0 && Rate != 0)
                        debitAmountNT = decimal.Round(debitAmount / Rate, 2);
                    if (creditAmount != 0 && Rate != 0)
                        creditAmountNT = decimal.Round(creditAmount / Rate, 2);
                }

            }
        }
        private decimal rate;
        public decimal Rate
        {
            get { return rate; }
            set
            {
                rate = value;
                if (currencyCode != string.Empty)
                {
                    if (debitAmount != 0 && rate != 0)
                        debitAmountNT = decimal.Round(debitAmount / rate, 2);
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
    }
}
