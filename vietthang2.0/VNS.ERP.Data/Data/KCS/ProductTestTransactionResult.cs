using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class ProductTestTransactionResult : BaseClass
    {
        public ProductTestTransactionResult() { }
        public ProductTestTransactionResult(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("Result", reader)) result = reader.GetString(reader.GetOrdinal("Result"));
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
    }
}
