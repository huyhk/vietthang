using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Grinds
{
   public class GeneralMaterial:MaterialFormular
    {
       public GeneralMaterial()
        { }

       public GeneralMaterial(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("MaterialPCode", reader)) _MaterialPCode = reader.GetString(reader.GetOrdinal("MaterialPCode"));
        }

       protected string _MaterialPCode;
       public string MaterialPCode
        {
            get { return _MaterialPCode; }
            set { _MaterialPCode = value; }
        }
    }
}
