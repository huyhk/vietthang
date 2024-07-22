using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetUpgrade:AccountTransaction
    {
        private FixedAssetUpgrade fixedAsset;

        public FixedAssetUpgrade FixedAsset
        {
            get { return fixedAsset; }
            set { fixedAsset = value; }
        }
    }
}
