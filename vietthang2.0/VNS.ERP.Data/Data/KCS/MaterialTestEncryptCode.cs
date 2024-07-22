using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestEncryptCode : UserTracking2
    {
        public MaterialTestEncryptCode() { }
        public MaterialTestEncryptCode(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TestTransactionNo", reader)) testTransactionNo = reader.GetString(reader.GetOrdinal("TestTransactionNo"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string testTransactionNo = string.Empty;
        public string TestTransactionNo
        {
            get { return testTransactionNo; }
            set { testTransactionNo = value; }
        }
        private string itemEncryptCode = string.Empty;
        public string ItemEncryptCode
        {
            get { return itemEncryptCode; }
            set { itemEncryptCode = value; }
        }
        private string description = string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
