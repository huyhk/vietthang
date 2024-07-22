using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;
namespace VNS.ERP.Data.Accounting
{
    public class AccountTransaction : UserTracking2
    {
        public AccountTransaction() { }
        public AccountTransaction(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
            if (!isNull("AccountTransactionTypeCode", reader)) accountTransactionTypeCode = reader.GetString(reader.GetOrdinal("AccountTransactionTypeCode"));
            if (!isNull("AccountTransactionNo", reader)) accountTransactionNo = reader.GetString(reader.GetOrdinal("AccountTransactionNo"));
            if (!isNull("AccountTransactionDate", reader)) accountTransactionDate = reader.GetDateTime(reader.GetOrdinal("AccountTransactionDate"));
            if (!isNull("PersonName", reader)) personName = reader.GetString(reader.GetOrdinal("PersonName"));
            if (!isNull("Address", reader)) address = reader.GetString(reader.GetOrdinal("Address"));
            if (!isNull("CTKemtheo", reader)) cTKemtheo = reader.GetString(reader.GetOrdinal("CTKemtheo"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("NgayCT", reader)) ngayCT = reader.GetDateTime(reader.GetOrdinal("NgayCT"));
            if (!isNull("SubjectCode1", reader)) subjectCode1 = reader.GetString(reader.GetOrdinal("SubjectCode1"));
            if (!isNull("SubjectCode2", reader)) subjectCode2 = reader.GetString(reader.GetOrdinal("SubjectCode2"));
            if (!isNull("DetailTransactionCode", reader)) detailTransactionCode = reader.GetString(reader.GetOrdinal("DetailTransactionCode"));
            if (!isNull("SpecialType", reader)) specialType = reader.GetString(reader.GetOrdinal("SpecialType"));
            if (!isNull("SoHopdong", reader)) soHopdong = reader.GetString(reader.GetOrdinal("SoHopdong"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["accountTransactionID"];
            if (!row.IsNull("AccountTransactionTypeCode")) accountTransactionTypeCode = (string)row["AccountTransactionTypeCode"];
            if (!row.IsNull("AccountTransactionNo")) accountTransactionNo = (string)row["AccountTransactionNo"];
            if (!row.IsNull("AccountTransactionDate")) accountTransactionDate = (DateTime)row["AccountTransactionDate"];
            if (!row.IsNull("PersonName")) personName = (string)row["PersonName"];
            if (!row.IsNull("Address")) address = (string)row["Address"];
            if (!row.IsNull("CTKemtheo")) cTKemtheo = (string)row["CTKemtheo"];
            if (!row.IsNull("Description")) description = (string)row["Description"];
            if (!row.IsNull("NgayCT")) ngayCT = (DateTime)row["NgayCT"];
            if (!row.IsNull("SubjectCode1")) subjectCode1 = (string)row["SubjectCode1"];
            if (!row.IsNull("SubjectCode2")) subjectCode2 = (string)row["SubjectCode2"];
            if (!row.IsNull("DetailTransactionCode")) detailTransactionCode = (string)row["DetailTransactionCode"];
            if (!row.IsNull("SpecialType")) specialType = (string)row["SpecialType"];
            if (!row.IsNull("SoHopdong")) soHopdong = (string)row["SoHopdong"];
        }
        private Guid accountTransactionID;
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }
        private string accountTransactionTypeCode = string.Empty;
        public string AccountTransactionTypeCode
        {
            get { return accountTransactionTypeCode; }
            set { accountTransactionTypeCode = value; }
        }
        private string accountTransactionNo=string.Empty;
        public string AccountTransactionNo
        {
            get { return accountTransactionNo; }
            set { accountTransactionNo = value; }
        }
        private DateTime accountTransactionDate = Contexts.WorkingDate;
        public DateTime AccountTransactionDate
        {
            get { return accountTransactionDate; }
            set { accountTransactionDate = value; }
        }

        private string personName = string.Empty;
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        private string address = string.Empty;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string cTKemtheo = string.Empty;
        public string CTKemtheo
        {
            get { return cTKemtheo; }
            set { cTKemtheo = value; }
        }
        private DateTime ngayCT = Contexts.WorkingDate;
        public DateTime NgayCT
        {
            get { return ngayCT; }
            set { ngayCT = value; }
        }
        private string subjectCode1 = string.Empty;
        public string SubjectCode1
        {
            get { return subjectCode1; }
            set { subjectCode1 = value; }
        }
        private string subjectCode2 = string.Empty;
        public string SubjectCode2
        {
            get { return subjectCode2; }
            set { subjectCode2 = value; }
        }

        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string soHopdong = string.Empty;
        public string SoHopdong
        {
            get { return soHopdong; }
            set { soHopdong = value; }
        }

        private string detailTransactionCode = string.Empty;
        public string DetailTransactionCode
        {
            get { return detailTransactionCode; }
            set { detailTransactionCode = value; }
        }

        private ListBase<AccountTransactionDetail1> detail1;
        public ListBase<AccountTransactionDetail1> Detail1
        {
            get { return detail1; }
            set { detail1 = value; }
        }
        private ListBase<AccountTransactionDetail2> detail2;
        public ListBase<AccountTransactionDetail2> Detail2
        {
            get { return detail2; }
            set { detail2 = value; }
        }
        private ListBase<Invoice> invoice;
        public ListBase<Invoice> Invoice
        {
            get { return invoice; }
            set { invoice = value; }
        }

        private ListBase<BuyNoInvoice> buyNoInvoice;
        public ListBase<BuyNoInvoice> BuyNoInvoice
        {
            get { return buyNoInvoice; }
            set { buyNoInvoice = value; }
        }
        private string specialType = string.Empty;
        public string SpecialType
        {
            get { return specialType; }
            set { specialType = value; }
        }

        private AccountTransactionTienvay tienvay = new AccountTransactionTienvay();
        public AccountTransactionTienvay Tienvay
        {
            get { return tienvay; }
            set { tienvay = value; }
        }


        public bool Check133()
        {
            decimal amount133 = 0;
            foreach (AccountTransactionDetail1 dt in this.Detail1)
            {
                if (dt.AccountCode.Substring(0,3) == "133")
                    amount133 += dt.DebitAmount;
            }
            decimal amountTax = 0;
            foreach (Invoice i in this.Invoice)
            {
                if (i.Dauvao)
                    amountTax += i.Tienthue;
            }
            return amount133 == amountTax;
        }
    }

    #region AccountTransactionTienvay
    /// <summary>
    /// This object represents the properties and methods of a AccountTransactionTienvay.
    /// </summary>
    public class AccountTransactionTienvay : ObjectBase
    {


        public AccountTransactionTienvay()
        {
        }

        public AccountTransactionTienvay(IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public AccountTransactionTienvay(DataRow row)
        {
            this.FromDataRow(row);
        }

        //public override void CopyFrom(object obj)
        //{
        //    base.CopyFrom(obj);

        //    accountTransactionID = (obj as AccountTransactionTienvay).accountTransactionID;
        //    kheuocvayID = (obj as AccountTransactionTienvay).kheuocvayID;
        //    accountCode = (obj as AccountTransactionTienvay).accountCode;
        //    subjectCode = (obj as AccountTransactionTienvay).subjectCode;
        //    accountCodeDU = (obj as AccountTransactionTienvay).accountCodeDU;
        //    nextDatePaid = (obj as AccountTransactionTienvay).nextDatePaid;
        //    debitAmount = (obj as AccountTransactionTienvay).debitAmount;
        //    creditAmount = (obj as AccountTransactionTienvay).creditAmount;

        //}

        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
            if (reader != null && !reader.IsClosed)
            {
                if (!isNull("AccountTransactionID", reader)) accountTransactionID = reader.GetGuid(reader.GetOrdinal("AccountTransactionID"));
                if (!isNull("KheuocvayID", reader)) kheuocvayID = reader.GetGuid(reader.GetOrdinal("KheuocvayID"));
                if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
                if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
                if (!isNull("AccountCodeDU", reader)) accountCodeDU = reader.GetString(reader.GetOrdinal("AccountCodeDU"));
                if (!isNull("NextDatePaid", reader))
                {
                    nextDatePaid = reader.GetDateTime(reader.GetOrdinal("NextDatePaid"));
                    lastPaid = false;
                }
                else
                    lastPaid = true;
                if (!isNull("DebitAmount", reader)) debitAmount = reader.GetDecimal(reader.GetOrdinal("DebitAmount"));
                if (!isNull("CreditAmount", reader)) creditAmount = reader.GetDecimal(reader.GetOrdinal("CreditAmount"));
            }
        }

        public override void FromDataRow(DataRow row)
        {
            base.FromDataRow(row);

            if (!row.IsNull("AccountTransactionID")) accountTransactionID = (Guid)row["AccountTransactionID"];
            if (!row.IsNull("KheuocvayID")) kheuocvayID = (Guid)row["KheuocvayID"];
            if (!row.IsNull("AccountCode")) accountCode = (string)row["AccountCode"];
            if (!row.IsNull("SubjectCode")) subjectCode = (string)row["SubjectCode"];
            if (!row.IsNull("AccountCodeDU")) accountCodeDU = (string)row["AccountCodeDU"];
            if (!row.IsNull("NextDatePaid"))
            {
                nextDatePaid = (DateTime)row["NextDatePaid"];
                lastPaid = false;
            }
            else
                lastPaid = true;

            if (!row.IsNull("DebitAmount")) debitAmount = (decimal)row["DebitAmount"];
            if (!row.IsNull("CreditAmount")) creditAmount = (decimal)row["CreditAmount"];
        }

        #region Public Properties



        private Guid accountTransactionID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of AccountTransactionID
        /// </summary>
        public Guid AccountTransactionID
        {
            get { return accountTransactionID; }
            set { accountTransactionID = value; }
        }

        private Guid kheuocvayID = Guid.Empty;
        /// <summary>
        /// Gets or sets the value of KheuocvayID
        /// </summary>
        public Guid KheuocvayID
        {
            get { return kheuocvayID; }
            set { kheuocvayID = value; }
        }

        private string accountCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of AccountCode
        /// </summary>
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }

        private string subjectCode = String.Empty;
        /// <summary>
        /// Gets or sets the value of SubjectCode
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }

        private string accountCodeDU = String.Empty;
        /// <summary>
        /// Gets or sets the value of AccountCodeDU
        /// </summary>
        public string AccountCodeDU
        {
            get { return accountCodeDU; }
            set { accountCodeDU = value; }
        }

        private bool lastPaid = false;
        public bool LastPaid
        {
            get { return lastPaid; }
            set { lastPaid = value; }
        }

        private DateTime nextDatePaid = DateTime.Today;
        /// <summary>
        /// Gets or sets the value of NextDatePaid
        /// </summary>
        public DateTime NextDatePaid
        {
            get { return nextDatePaid; }
            set { nextDatePaid = value; }
        }

        private decimal debitAmount;
        /// <summary>
        /// Gets or sets the value of DebitAmount
        /// </summary>
        public decimal DebitAmount
        {
            get { return debitAmount; }
            set { debitAmount = value; }
        }

        private decimal creditAmount;
        /// <summary>
        /// Gets or sets the value of CreditAmount
        /// </summary>
        public decimal CreditAmount
        {
            get { return creditAmount; }
            set { creditAmount = value; }
        }
        #endregion

        #region Lists
        #endregion


    }
    #endregion
}
