using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;

namespace VNS.ERP.Data.Grinds
{
    class GeneralMaterialDAL:StockBaseDAL<GeneralMaterial>
    {
            public GeneralMaterialDAL()
        {}
        public GeneralMaterialDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_MaterialFormulas_Select_All";
        }

        
       


    }
}
