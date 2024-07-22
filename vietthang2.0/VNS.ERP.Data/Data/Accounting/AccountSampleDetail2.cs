using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class AccountSampleDetail2 : BaseClass
    {
        public AccountSampleDetail2() { }
        public AccountSampleDetail2(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountSampleCode", reader)) accountSampleCode = reader.GetString(reader.GetOrdinal("AccountSampleCode"));
            if (!isNull("DebitAccountCode", reader)) debitAccountCode = reader.GetString(reader.GetOrdinal("DebitAccountCode"));
            if (!isNull("DebitSubjectCode", reader)) debitSubjectCode = reader.GetString(reader.GetOrdinal("DebitSubjectCode"));
            if (!isNull("DebitClassificationCode", reader)) debitClassificationCode = reader.GetString(reader.GetOrdinal("DebitClassificationCode"));
            if (!isNull("CreditAccountCode", reader)) creditAccountCode = reader.GetString(reader.GetOrdinal("CreditAccountCode"));
            if (!isNull("CreditSubjectCode", reader)) creditSubjectCode = reader.GetString(reader.GetOrdinal("CreditSubjectCode"));
            if (!isNull("CreditClassificationCode", reader)) creditClassificationCode = reader.GetString(reader.GetOrdinal("CreditClassificationCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string accountSampleCode;
        public string AccountSampleCode
        {
            get { return accountSampleCode; }
            set { accountSampleCode = value; }
        }
        private string debitAccountCode=string.Empty;
        public string DebitAccountCode
        {
            get { return debitAccountCode; }
            set 
            {
                if (debitAccountCode != value)
                {
                    DebitSubjectCode = "";
                    DebitClassificationCode = "";
                    debitAccountCode = value; 
                }
            }
        }
        private string debitSubjectCode=string.Empty;
        public string DebitSubjectCode
        {
            get { return debitSubjectCode; }
            set { debitSubjectCode = value; }
        }
        private string debitClassificationCode = string.Empty;
        public string DebitClassificationCode
        {
            get { return debitClassificationCode; }
            set { debitClassificationCode = value; }
        }
        private string creditAccountCode=string.Empty;
        public string CreditAccountCode
        {
            get { return creditAccountCode; }
            set 
            {
                if (creditAccountCode != value)
                {
                    CreditSubjectCode = "";
                    CreditClassificationCode = "";
                    creditAccountCode = value; 
                }
            }
        }
        private string creditSubjectCode=string.Empty;
        public string CreditSubjectCode
        {
            get { return creditSubjectCode; }
            set { creditSubjectCode = value; }
        }
        private string creditClassificationCode = string.Empty;
        public string CreditClassificationCode
        {
            get { return creditClassificationCode; }
            set { creditClassificationCode = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
