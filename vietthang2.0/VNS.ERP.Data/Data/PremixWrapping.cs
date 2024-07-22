using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
   public class PremixWrapping:Item
    {
        
         public PremixWrapping()
        { }

       public PremixWrapping(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
            if (!isNull("PremixCode", reader)) _PremixCode = reader.GetString(reader.GetOrdinal("PremixCode"));
           
        }

      


       protected string _PremixCode;
       public string PremixCode
      {
          get { return _PremixCode; }
          set { _PremixCode = value; }
      }
      
     

    }
    
}
