using System;
using System.Collections.Generic;
using System.Text;
namespace VNS.ERP.Data.Accounting
{
    public class InstrumentItem : UserTracking2
    {
        public InstrumentItem() { }
        public InstrumentItem(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("ItemCode", reader)) itemCode = reader.GetString(reader.GetOrdinal("ItemCode"));
            if (!isNull("ItemName", reader)) itemName = reader.GetString(reader.GetOrdinal("ItemName"));
            if (!isNull("Unit", reader)) unit = reader.GetString(reader.GetOrdinal("Unit"));
            if (!isNull("Description", reader)) description = reader.GetString(reader.GetOrdinal("Description"));
        }
        private string itemCode=string.Empty;
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }
        private string itemName=string.Empty;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string unit=string.Empty;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        private string description=string.Empty;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
