using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionDetail2 : BaseClass
    {
        public AccountTransactionDetail2() { }
        public AccountTransactionDetail2(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("AccountTransactionDetail2ID", reader)) accountTransactionDetail2ID = reader.GetGuid(reader.GetOrdinal("AccountTransactionDetail2ID"));
            if (!isNull("DebitAccountCode", reader)) debitAccountCode = reader.GetString(reader.GetOrdinal("DebitAccountCode"));
            if (!isNull("DebitSubjectCode", reader)) debitSubjectCode = reader.GetString(reader.GetOrdinal("DebitSubjectCode"));
            if (!isNull("DebitClassificationCode", reader)) debitClassificationCode = reader.GetString(reader.GetOrdinal("DebitClassificationCode"));
            if (!isNull("CreditAccountCode", reader)) creditAccountCode = reader.GetString(reader.GetOrdinal("CreditAccountCode"));
            if (!isNull("CreditSubjectCode", reader)) creditSubjectCode = reader.GetString(reader.GetOrdinal("CreditSubjectCode"));
            if (!isNull("CreditClassificationCode", reader)) creditClassificationCode = reader.GetString(reader.GetOrdinal("CreditClassificationCode"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            if (!isNull("AmountNT", reader)) amountNT = reader.GetDecimal(reader.GetOrdinal("AmountNT"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("Description2", reader)) description2 = reader.GetString(reader.GetOrdinal("Description2"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("AccountTransactionDetail2ID")) accountTransactionDetail2ID = (Guid)row["AccountTransactionDetail2ID"];
            if (!row.IsNull("DebitAccountCode")) debitAccountCode = (string)row["DebitAccountCode"];
            if (!row.IsNull("DebitSubjectCode")) debitSubjectCode = (string)row["DebitSubjectCode"];
            if (!row.IsNull("DebitClassificationCode")) debitClassificationCode = (string)row["DebitClassificationCode"];
            if (!row.IsNull("CreditAccountCode")) creditAccountCode = (string)row["CreditAccountCode"];
            if (!row.IsNull("CreditSubjectCode")) creditSubjectCode = (string)row["CreditSubjectCode"];
            if (!row.IsNull("CreditClassificationCode")) creditClassificationCode = (string)row["CreditClassificationCode"];
            if (!row.IsNull("Amount")) amount= (decimal)row["Amount"];
            if (!row.IsNull("AmountNT")) amountNT =(decimal)row["AmountNT"];
            if (!row.IsNull("Description")) description =(string)row["Description"];
            if (!row.IsNull("Description2")) description2 = (string)row["Description2"];
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }
        private Guid accountTransactionDetail2ID;
        public Guid AccountTransactionDetail2ID
        {
            get { return accountTransactionDetail2ID; }
            set { accountTransactionDetail2ID = value; }
        }
        private string debitAccountCode=string.Empty;
        public string DebitAccountCode
        {
            get { return debitAccountCode; }
            set { debitAccountCode = value; }
        }
        private string debitSubjectCode=string.Empty;
        public string DebitSubjectCode
        {
            get { return debitSubjectCode; }
            set { debitSubjectCode = value; }
        }
        private string debitClassificationCode=string.Empty;
        public string DebitClassificationCode
        {
            get { return debitClassificationCode; }
            set { debitClassificationCode = value; }
        }
        private string creditAccountCode=string.Empty;
        public string CreditAccountCode
        {
            get { return creditAccountCode; }
            set { creditAccountCode = value; }
        }
        private string creditSubjectCode=string.Empty;
        public string CreditSubjectCode
        {
            get { return creditSubjectCode; }
            set { creditSubjectCode = value; }
        }
        private string creditClassificationCode=string.Empty;
        public string CreditClassificationCode
        {
            get { return creditClassificationCode; }
            set { creditClassificationCode = value; }
        }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private decimal amountNT;
        public decimal AmountNT
        {
            get { return amountNT; }
            set { amountNT = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string description2 = string.Empty;
        public string Description2
        {
            get { return description2; }
            set { description2 = value; }
        }
    }
}
