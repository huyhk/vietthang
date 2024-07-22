using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using VNS.Common ;

namespace VNS.ERP.Data
{
    public class BaseClass : ObjectBase
    {
        public virtual void LoadFromReader(DbDataReader reader)
        {
        }
        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            this.LoadFromReader((DbDataReader)reader);
        }
        public virtual void LoadFromDataRow(DataRow row)
        { }

        protected bool CheckNull(string columnName, DbDataReader reader)
        {
            int n;
            try
            {
                n = reader.GetOrdinal(columnName);
            }
            catch
            { n = -1; }

            if (n >= 0)
                return reader.IsDBNull(n);
            else
                return true;
        }
    }
}

