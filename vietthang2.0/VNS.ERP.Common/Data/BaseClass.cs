using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using VNS.Common ;

namespace VNS.ERP.Common
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
        protected bool CheckNull(string columnName, DbDataReader reader)
        {
            int n = reader.GetOrdinal(columnName);
            if (n >= 0)
                return reader.IsDBNull(n);
            else
                return true;
        }
    }
}

