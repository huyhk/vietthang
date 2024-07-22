using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using System.Data.Common;
namespace VNS.ERP.Data.Premixs
{
    class GeneralPremixDAL:StockBaseDAL<GeneralPremix>
    {
            public GeneralPremixDAL()
        {}
        public GeneralPremixDAL(DBHelper dbHelper)
            : base(dbHelper)
        {}

        protected override void SetValues()
        {
            _spSelectAll = "usp_PremixFormulas_Select_All";
        }

    }
}
