using System;
using System.Collections.Generic;
using System.Text;
using VNS.ERP.Data;
using System.Data;


namespace VNS.ERP.Data.Accounting
{
    public class FixedAssetGeneral:FixedAssetOpening
    {
        public FixedAssetGeneral()
		{
		}

        public FixedAssetGeneral(IDataReader reader)
		{
			this.FromDataReader(reader);
		}
		
		public override void FromDataReader(IDataReader reader)
		{
            base.FromDataReader(reader);
		}
        public decimal PercentDepreciation
        {
            get {
                return (12*PriceDepreciation)/((decimal)MonthUsing * OriginalPrice);

                }
        }
        public decimal ExtractDepreciation
        {
            get
            {
                return Math.Min(decimal.Round(PriceDepreciation / MonthUsing,0),RemainCost);
            }
        }
        public decimal AccumulatedDepreciationExtract
		{
            get
            {
                return AccumulatedDepreciation + DepreciationInput; 
            }
        }

        public decimal RemainCostExtract
        {
            get
            {
                if (giamtrongky == 0)
                    return OriginalPrice - AccumulatedDepreciationExtract;
                else
                    return 0;
            }
        }
        private decimal depreciationInput;
        public decimal DepreciationInput
        {
            get {
                return depreciationInput;
            }
            set
            {
                depreciationInput = value;
            }
        }

        private decimal tangtrongky;
        public decimal Tangtrongky
        {
            get
            {
                return tangtrongky;
            }
            set
            {
                tangtrongky = value;
            }
        }
        private decimal giamtrongky;
        public decimal Giamtrongky
        {
            get
            {
                return giamtrongky;
            }
            set
            {
                giamtrongky = value;
            }
        }
        private decimal sodudauky;
        public decimal Sodudauky
        {
            get { return sodudauky; }
            set { sodudauky = value; }
        }

        public decimal Soducuoiky
        {
            get { return sodudauky + tangtrongky - giamtrongky; }
        }
        

	
    }

}
