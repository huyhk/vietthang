using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.KCS
{
    public class MaterialTestTransactionDetail : BaseClass
    {
        public MaterialTestTransactionDetail() { }
        public MaterialTestTransactionDetail(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("TestTransactionID", reader)) testTransactionID = reader.GetGuid(reader.GetOrdinal("TestTransactionID"));
            if (!isNull("TechCode", reader)) techCode = reader.GetString(reader.GetOrdinal("TechCode"));
            if (!isNull("Result", reader)) result = reader.GetString(reader.GetOrdinal("Result"));
        }
        public override void LoadFromDataRow(System.Data.DataRow row)
        {
            base.LoadFromDataRow(row);
            if (!row.IsNull("TestTransactionID")) testTransactionID = (Guid)row["TestTransactionID"];
            if (!row.IsNull("TechCode")) techCode = (string)row["TechCode"];
            if (!row.IsNull("Result")) result = (string)row["Result"];
        }
        private Guid testTransactionID = Guid.Empty;
        public Guid TestTransactionID
        {
            get { return testTransactionID; }
            set { testTransactionID = value; }
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
