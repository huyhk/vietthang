using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetLiquidate : AccountTransaction
    {
        private FixedAssetLiquidate fixedAsset;

        public FixedAssetLiquidate FixedAsset
        {
            get { return fixedAsset; }
            set { fixedAsset = value; }
        }
    }
}
