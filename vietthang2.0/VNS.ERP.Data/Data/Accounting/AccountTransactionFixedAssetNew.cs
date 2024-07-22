using System;
using System.Collections.Generic;
using System.Text;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionFixedAssetNew:AccountTransaction
    {
        private AccountFixedAssets fixedAsset;

        public AccountFixedAssets FixedAsset
        {
            get { return fixedAsset; }
            set { fixedAsset = value; }
        }
	
    }
}
