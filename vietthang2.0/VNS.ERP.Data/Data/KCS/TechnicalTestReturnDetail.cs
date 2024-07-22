using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class TechnicalTestReturnDetail : BaseClass
    {
        public TechnicalTestReturnDetail() { }
        public TechnicalTestReturnDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ReturnID", reader)) returnID = reader.GetGuid(reader.GetOrdinal("ReturnID"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("Result", reader)) result = reader.GetString(reader.GetOrdinal("Result"));
            if (!isNull("IsProduct", reader)) isProduct = reader.GetBoolean(reader.GetOrdinal("IsProduct"));
            if (!isNull("IsApplied", reader)) isApplied = reader.GetBoolean(reader.GetOrdinal("IsApplied"));
            if (!isNull("DateApplied", reader)) dateApplied = reader.GetDateTime(reader.GetOrdinal("DateApplied"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("ReturnID")) returnID = (Guid)row["ReturnID"];
            if (!row.IsNull("ItemEncryptCode")) itemEncryptCode = (string)row["ItemEncryptCode"];
            if (!row.IsNull("TechCode")) techCode = (string)row["TechCode"];
            if (!row.IsNull("Result")) result = (string)row["Result"];
            if (!row.IsNull("IsProduct")) isProduct = (bool)row["IsProduct"];
            if (!row.IsNull("IsApplied")) isApplied = (bool)row["IsApplied"];
            if (!row.IsNull("DateApplied")) dateApplied = (DateTime)row["DateApplied"];
        }
        private Guid returnID = Guid.Empty;
        public Guid ReturnID
        {
            get { return returnID; }
            set { returnID = value; }
        }
        private string itemEncryptCode = string.Empty;
        public string ItemEncryptCode
        {
            get { return itemEncryptCode; }
            set { itemEncryptCode = value; }
        }
        private string techCode = string.Empty;
        public string TechCode
        {
            get { return techCode; }
            set { techCode = value; }
        }
        private string result = string.Empty;
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        private bool isProduct = false;
        public bool IsProduct
        {
            get { return isProduct; }
            set { isProduct = value; }
        }
        private bool isApplied = false;
        public bool IsApplied
        {
            get { return isApplied; }
            set { isApplied = value; }
        }
        private DateTime dateApplied = DateTime.MinValue;
        public DateTime DateApplied
        {
            get { return dateApplied; }
            set { dateApplied = value; }
        }
    }
}
