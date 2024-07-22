using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class TestRequestReturnLink : BaseClass
    {
        public TestRequestReturnLink() { }
        public TestRequestReturnLink(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("RequestReturnID", reader)) requestReturnID = reader.GetGuid(reader.GetOrdinal("RequestReturnID"));
            if (!isNull("EncryptCodeReturnID", reader)) encryptCodeReturnID = reader.GetGuid(reader.GetOrdinal("EncryptCodeReturnID"));
        }
        private Guid requestReturnID = Guid.Empty;
        public Guid RequestReturnID
        {
            get { return requestReturnID; }
            set { requestReturnID = value; }
        }
        private Guid encryptCodeReturnID = Guid.Empty;
        public Guid EncryptCodeReturnID
        {
            get { return encryptCodeReturnID; }
            set { encryptCodeReturnID = value; }
        }
    }
}
