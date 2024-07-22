using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class PrePaidExpense : BaseClass
    {
        public PrePaidExpense() { }
        public PrePaidExpense(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("PrePaidCode")) prePaidCode = (String)(row["PrePaidCode"]);
            if (!row.IsNull("PrePaidName")) prePaidName = (String)(row["PrePaidName"]);
            if (!row.IsNull("Unit")) unit = (String)(row["Unit"]);
            if (!row.IsNull("Quantity")) quantity = (Decimal)(row["Quantity"]);
            if (!row.IsNull("Price")) price = (Decimal)(row["Price"]);
            if (!row.IsNull("Amount")) amount = (Decimal)(row["Amount"]);
            if (!row.IsNull("Description")) description = (String)(row["Description"]);
            if (!row.IsNull("DepStartDate")) depStartDate = (DateTime)(row["DepStartDate"]);
            if (!row.IsNull("DepRate")) depRate = (Decimal)(row["DepRate"]);
            if (!row.IsNull("DepMonth")) depMonth = (Int32)(row["DepMonth"]);
            if (!row.IsNull("PrePaidNo")) prePaidNo = (String)(row["PrePaidNo"]);
            if (!row.IsNull("PrePaidDate")) prePaidDate = (DateTime)(row["PrePaidDate"]);
            if (!row.IsNull("AccountCode")) accountCode = (String)(row["AccountCode"]);
            if (!row.IsNull("SubjectCode")) subjectCode = (String)(row["SubjectCode"]);
            if (!row.IsNull("DepAccountCode")) depAccountCode = (String)(row["DepAccountCode"]);
            if (!row.IsNull("DepSubjectCode")) depSubjectCode = (String)(row["DepSubjectCode"]);
            if (!row.IsNull("DepClassificationCode")) depClassificationCode = (String)(row["DepClassificationCode"]);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PrePaidCode", reader)) prePaidCode = reader.GetString(reader.GetOrdinal("PrePaidCode"));
            if (!isNull("PrePaidName", reader)) prePaidName = reader.GetString(reader.GetOrdinal("PrePaidName"));
            if (!isNull("Unit", reader)) unit = reader.GetString(reader.GetOrdinal("Unit"));
            if (!isNull("Quantity", reader)) quantity = reader.GetDecimal(reader.GetOrdinal("Quantity"));
            if (!isNull("Price", reader)) price = reader.GetDecimal(reader.GetOrdinal("Price"));
            if (!isNull("Amount", reader)) amount = reader.GetDecimal(reader.GetOrdinal("Amount"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
            if (!isNull("DepStartDate", reader)) depStartDate = reader.GetDateTime(reader.GetOrdinal("DepStartDate"));
            if (!isNull("DepRate", reader)) depRate = reader.GetDecimal(reader.GetOrdinal("DepRate"));
            if (!isNull("DepMonth", reader)) depMonth = reader.GetInt32(reader.GetOrdinal("DepMonth"));
            if (!isNull("PrePaidNo", reader)) prePaidNo = reader.GetString(reader.GetOrdinal("PrePaidNo"));
            if (!isNull("PrePaidDate", reader)) prePaidDate = reader.GetDateTime(reader.GetOrdinal("PrePaidDate"));
            if (!isNull("AccountCode", reader)) accountCode = reader.GetString(reader.GetOrdinal("AccountCode"));
            if (!isNull("SubjectCode", reader)) subjectCode = reader.GetString(reader.GetOrdinal("SubjectCode"));
            if (!isNull("DepAccountCode", reader)) depAccountCode = reader.GetString(reader.GetOrdinal("DepAccountCode"));
            if (!isNull("DepSubjectCode", reader)) depSubjectCode = reader.GetString(reader.GetOrdinal("DepSubjectCode"));
            if (!isNull("DepClassificationCode", reader)) depClassificationCode = reader.GetString(reader.GetOrdinal("DepClassificationCode"));
        }
        private string prePaidCode=string.Empty;
        public string PrePaidCode
        {
            get { return prePaidCode; }
            set { prePaidCode = value; }
        }
        private string prePaidName=string.Empty;
        public string PrePaidName
        {
            get { return prePaidName; }
            set { prePaidName = value; }
        }
        private string unit=string.Empty;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set 
            { 
                quantity = value;
                this.amount = this.quantity * price;
            }
        }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set 
            { 
                price = value;
                this.amount = this.quantity * price;
            }
        }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set 
            { 
                amount = value;
            }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private DateTime depStartDate=Contexts.WorkingDate;
        public DateTime DepStartDate
        {
            get { return depStartDate; }
            set { depStartDate = value; }
        }
        private decimal depRate;
        public decimal DepRate
        {
            get { return depRate; }
            set { depRate = value; }
        }
        private Int32 depMonth;
        public Int32 DepMonth
        {
            get { return depMonth; }
            set { depMonth = value; }
        }
        private string prePaidNo=string.Empty;
        public string PrePaidNo
        {
            get { return prePaidNo; }
            set { prePaidNo = value; }
        }
        private DateTime prePaidDate=Contexts.WorkingDate;
        public DateTime PrePaidDate
        {
            get { return prePaidDate; }
            set { prePaidDate = value; }
        }
        private string accountCode=string.Empty;
        public string AccountCode
        {
            get { return accountCode; }
            set { accountCode = value; }
        }
        private string subjectCode=string.Empty;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        private string depAccountCode=string.Empty;
        public string DepAccountCode
        {
            get { return depAccountCode; }
            set { depAccountCode = value; }
        }
        private string depSubjectCode=string.Empty;
        public string DepSubjectCode
        {
            get { return depSubjectCode; }
            set { depSubjectCode = value; }
        }
        private string depClassificationCode=string.Empty;
        public string DepClassificationCode
        {
            get { return depClassificationCode; }
            set { depClassificationCode = value; }
        }
    }
}
