using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class EncryptCodeSendDetail : BaseClass
    {
        public EncryptCodeSendDetail() { }
        public EncryptCodeSendDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("SendID", reader)) sendID = reader.GetGuid(reader.GetOrdinal("SendID"));
            if (!isNull("ItemEncryptCode", reader)) itemEncryptCode = reader.GetString(reader.GetOrdinal("ItemEncryptCode"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("IsProduct", reader)) isProduct = reader.GetBoolean(reader.GetOrdinal("IsProduct"));
        }
        private Guid sendID = Guid.Empty;
        public Guid SendID
        {
            get { return sendID; }
            set { sendID = value; }
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
        private bool isProduct = false;
        public bool IsProduct
        {
            get { return isProduct; }
            set { isProduct = value; }
        }
    }
}
