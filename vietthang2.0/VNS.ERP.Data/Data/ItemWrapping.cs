using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data
{
   public  class ItemWrapping:Item  
    {
         public ItemWrapping()
        { }

       public ItemWrapping(System.Data.IDataReader reader)
        {
            this.FromDataReader(reader);
        }

        public override void FromDataReader(System.Data.IDataReader reader)
        {
            base.FromDataReader(reader);
           
            if (!isNull("ProductCode", reader)) _ProductCode = reader.GetString(reader.GetOrdinal("ProductCode"));
            if (!isNull("WeightCode", reader)) _WeightCode = reader.GetString(reader.GetOrdinal("WeightCode"));
          
            

        }

      

       protected string _ProductCode;
       public string ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }


       protected string _WeightCode;
       public string WeightCode
      {
          get { return _WeightCode; }
          set { _WeightCode = value; }
      }
      
     

    }
}
