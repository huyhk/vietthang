using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

using VNS.Data.BLL;
using VNS.Common;

namespace VNS.ERP.Data.Accounting
{

	/// <summary>
	/// This object represents the properties and methods of a Business Layer of FixedAsset.
	/// </summary>
	public class ProductPriceCostBLL 
	{
        private ProductPriceCostDAL dal1 = new ProductPriceCostDAL();
        private ItemPriceCostDAL dal2 = new ItemPriceCostDAL();
        private ProductSizePriceCostDAL dal3 = new ProductSizePriceCostDAL();
        private AccountTransactionDetail2DAL dal4;
        public ProductPriceCostBLL()
		{
		}
        public int UpdateGiaThanhNew(string periodCode, DataTable dt)
        {
            int iError = 0;
            ItemPriceCostDAL dal = new ItemPriceCostDAL();
            dal.Open();
            dal.BeginTransaction();

            iError = dal.Delete(periodCode);
            if (iError == 0)
                iError = dal.DeleteGiathanhNew(periodCode);
            if (iError == 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ItemPriceCost i = new ItemPriceCost();
                    i.PeriodCode = periodCode;
                    i.ItemCode = (string)row["ItemCode"];
                    i.Quantity = (decimal)row["Quantity"];
                    i.PriceCost = (decimal)row["Price"];
                    i.AmountCost = (decimal)row["Amount"];
                    row["AmountOld"] = row["Amount"];

                    iError = dal.Insert(i);

                    if (iError == 0)
                    {
                        for (int ii = 14; ii <= dt.Columns.Count - 1; ii++)
                        {
                            string accountCode = dt.Columns[ii].Caption;
                            iError = dal.InsertGiathanhNew(periodCode, accountCode, (string)row["ItemCode"], (decimal)row[accountCode]);

                            if (iError != 0)
                                break;
                        }
                    }
                    if (iError != 0)
                        break;
                }
            }

            if (iError == 0)
                dal.Commit();
            else
                dal.Rollback();
            dal1.Close();
            return iError;
        }
        public int InsertProductPrice(ListBase<ProductPriceCost> lst1, ListBase<ProductSizePriceCost> lst2, ListBase<ItemPriceCost> lst3, string periodCode)
        {
            int iError = 0;

            dal1.Open();
            dal1.BeginTransaction();
            iError = dal1.Delete(periodCode);
            if(iError==0)
                 iError = dal2.Delete(periodCode);
            if (iError == 0)
                 iError = dal3.Delete(periodCode);
            if (iError==0)
            foreach (ProductPriceCost pr in lst1)
            {
                iError = dal1.Insert(pr);
                if (iError != 0)
                    break;
            }
            if(iError==0)
                foreach (ProductSizePriceCost ps in lst2)
                {
                    iError = dal3.Insert(ps);
                    if (iError != 0)
                        break;
                }
            if(iError==0)
                foreach (ItemPriceCost it in lst3)
                {
                    iError = dal2.Insert(it);
                    if (iError != 0)
                        break;
                }
            if (iError == 0)
                dal1.Commit();
            else
                dal1.Rollback();
            dal1.Close();
            return iError;
        }
          
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="periodCode"></param>
        public void UpdateInStockCostPriceProduct(string periodCode)
        {
            dal1.UpdateInStockCostPriceProduct(periodCode);
        }
		/// <summary>
		/// Deletes an object from database 
		/// </summary>		
      
        public DataTable GetDetaiProductByPeriodCode(string periodCode, DateTime startDate, DateTime endDate,decimal totalCostAmount)
        {
            decimal totalAmountCalculator = 0;
            ListBase<ProductPriceCost> lstProCost;
            DataTable dt = new DataTable();
            dt = dal1.GetDetaiProductByPeriodCode(periodCode, startDate, endDate);
            lstProCost = dal1.GetListProductPriceCostByPeriodCode(periodCode);
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("ProductCode", typeof(string));
            dtReturn.Columns.Add("WrappingCode", typeof(string));
            dtReturn.Columns.Add("CostAmount", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("Quantity", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("CostCalculator", typeof(decimal)).DefaultValue = 0;

            dtReturn.Columns.Add("AmountCalculator", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("PriceCost", typeof(decimal)).DefaultValue = 0;

            DataView dv = dtReturn.DefaultView;
            dv.Sort = "ProductCode ASC,WrappingCode";

            foreach (DataRow row in dt.Rows)
            {
                if(decimal.Parse(row["Quantity"].ToString())>0)
                {
                    DataRow newRow = dtReturn.NewRow();
                    newRow["ProductCode"] = row["ProductCode"];
                    newRow["WrappingCode"] = row["WrappingCode"];
                    newRow["CostAmount"] = row["CostAmount"];
                    newRow["Quantity"] = row["Quantity"];
                    newRow["CostCalculator"] = (decimal.Parse(row["Quantity"].ToString()) * decimal.Parse(row["CostAmount"].ToString()))/1000;
                    totalAmountCalculator += decimal.Parse(newRow["CostCalculator"].ToString());
                    if (lstProCost.Count > 0)
                    {
                        foreach (ProductPriceCost pr in lstProCost)
                        {
                            if (pr.ProductCode.Equals(row["ProductCode"]) && pr.WrappingCode.Equals(row["WrappingCode"]))
                            {
                                newRow["PriceCost"] = pr.PriceCost;
                            }
                        }
                    }
                    dtReturn.Rows.Add(newRow);
                }
            }

            foreach (DataRow dr in dtReturn.Rows)
            {
                if (decimal.Parse(dr["Quantity"].ToString()) != 0 && totalAmountCalculator!=0) 
                dr["AmountCalculator"] = decimal.Round(((totalCostAmount / totalAmountCalculator) * decimal.Parse(dr["CostCalculator"].ToString()))/decimal.Parse(dr["Quantity"].ToString()), 2);
            }
            return dtReturn;

            

        }
        public DataTable GetDetaiProductSizeCodeByPeriodCode(string periodCode, DateTime startDate, DateTime endDate, decimal total1, decimal total2)
        {
            decimal totalAmountCalculator = 0;
            ListBase<ProductSizePriceCost> lstProSizeCost;
            DataTable dt = new DataTable();
            dt = dal3.GetDetaiProductSizeCodeByPeriodCode(periodCode, startDate, endDate);
            lstProSizeCost = dal3.GetListProductSizePriceCostByPeriodCode(periodCode);
            DataTable dtReturn = new DataTable();
            dtReturn.Columns.Add("ProductSizeCode", typeof(string));
            dtReturn.Columns.Add("ProductType", typeof(string));
            dtReturn.Columns.Add("Capacity", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("Quantity", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("Times", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("AmountCalculatorNC", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("AmountCalculatorSXC", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("NCPriceCost", typeof(decimal)).DefaultValue = 0;
            dtReturn.Columns.Add("SXCPriceCost", typeof(decimal)).DefaultValue = 0;

            DataView dv = dtReturn.DefaultView;
            dv.Sort = "ProductType,ProductSizeCode ASC";

            foreach (DataRow row in dt.Rows)
            {
                if (decimal.Parse(row["Quantity"].ToString()) > 0)
                {
                    DataRow newRow = dtReturn.NewRow();
                    newRow["ProductSizeCode"] = row["ProductSizeCode"];
                    newRow["ProductType"] = row["ProductType"];
                    newRow["Capacity"] = row["Capacity"];
                    newRow["Quantity"] = row["Quantity"];
                    if (decimal.Parse(row["Capacity"].ToString()) != 0)
                        newRow["Times"] = decimal.Round((decimal.Parse(row["Quantity"].ToString()) / decimal.Parse(row["Capacity"].ToString())), 2);
                    totalAmountCalculator += decimal.Parse(newRow["Times"].ToString());
                    if (lstProSizeCost.Count > 0)
                    {
                        foreach (ProductSizePriceCost pr in lstProSizeCost)
                        {
                            if (pr.ProductSizeCode.Equals(row["ProductSizeCode"]) && pr.ProductType.Equals(row["ProductType"]))
                            {
                                newRow["NCPriceCost"] = pr.NCPriceCost;
                                newRow["SXCPriceCost"] = pr.SXCPriceCost;
                            }
                        }
                    }
                    dtReturn.Rows.Add(newRow);
                }
            }

            foreach (DataRow dr in dtReturn.Rows)
            {
                if (decimal.Parse(dr["Quantity"].ToString()) != 0 && totalAmountCalculator != 0)
                {
                    dr["AmountCalculatorNC"] = decimal.Round(((total1 / totalAmountCalculator) * decimal.Parse(dr["Times"].ToString())) / decimal.Parse(dr["Quantity"].ToString()), 2);
                    dr["AmountCalculatorSXC"] = decimal.Round(((total2 / totalAmountCalculator) * decimal.Parse(dr["Times"].ToString())) / decimal.Parse(dr["Quantity"].ToString()), 2);

                }
            }
            return dtReturn;
        }
        public DataTable GetDetaiItemCodeByPeriodCode(string periodCode, DateTime startDate, DateTime endDate)
        {
            DataTable dtReturn = new DataTable();
            ListBase<ItemPriceCost> lstItems;
            dtReturn= dal2.GetListItemProductByPeriodCode(periodCode, startDate, endDate);
            //dtReturn.Columns.Add("PriceCostInput", typeof(decimal)).DefaultValue = 0;
            //dtReturn.Columns.Add("AmountCost", typeof(decimal)).DefaultValue = 0;
            lstItems = dal2.GetListItemPriceCostByPeriodCode(periodCode);
            if (lstItems.Count > 0)
            {
                foreach (DataRow dr in dtReturn.Rows)
                {
                    ItemPriceCost itemPrice=lstItems.Search("ItemCode",dr["ItemCode"]);
                    if (itemPrice != null)
                    {
                        dr["PriceCostInput"] = itemPrice.PriceCost;
                        dr["AmountCost"] = itemPrice.AmountCost;
                    }
                }
            }
            return dtReturn;
        }
        public DataTable GetCostAmountCalculatorProductCode(DateTime startDate, DateTime endDate)
        {
            dal4 = new AccountTransactionDetail2DAL(dal1.DBHelper);
            return dal4.GetByStartDate_EndDate_And_DebitAccountCode(startDate, endDate, Account.GetProductCostAccount(startDate));
        }
        public DataTable GetCloseAmountByAccountCode(DateTime startDate, DateTime endDate)
        {
            dal4 = new AccountTransactionDetail2DAL(dal1.DBHelper);
            return dal4.GetCloseAmountByAccountCode(startDate, endDate);
        }
        public DataTable GiathanhNew(string periodCode)
        {
            DataSet ds = dal1.GiathanhNew(periodCode);
            decimal TongHesoType = (decimal)ds.Tables[2].Rows[0]["TongHesoType"];
            decimal TongHesoSize = (decimal)ds.Tables[2].Rows[0]["TongHesoSize"];
            decimal TongHesoSize2 = (decimal)ds.Tables[2].Rows[0]["TongHesoSize2"];
            DataTable dt = ds.Tables[1];
            if (dt.Rows.Count == 0)
                return dt;
            dt.Columns.Add("Amount", typeof(decimal)).DefaultValue = 0;
            dt.Columns.Add("Price", typeof(decimal)).DefaultValue = 0;
            foreach (DataRow row in dt.Rows)
                row["Amount"] = 0;
            foreach (DataRow rowTK in ds.Tables[0].Rows)
            {
                string TK = rowTK["CreditAccountCode"].ToString();
                decimal Amount = (decimal)rowTK["Amount"];
                dt.Columns.Add(TK, typeof(decimal)).DefaultValue = 0;
                decimal tAmount = 0;
                foreach (DataRow rowP in dt.Rows)
                {
                    if (TK.StartsWith("621") && TongHesoType!=0)
                    {
                        decimal HesoType = (decimal)rowP["HesoType"];
                        decimal pAmount = Math.Round(Amount * HesoType / TongHesoType, 0, MidpointRounding.AwayFromZero);
                        tAmount += pAmount;
                        rowP[TK] = pAmount;
                        rowP["Amount"] = (decimal)rowP["Amount"] + pAmount;
                    }
                    else if (TK.StartsWith("622") && TongHesoSize != 0)
                    {
                        decimal HesoSize = (decimal)rowP["HesoSize"];
                        decimal pAmount = Math.Round(Amount * HesoSize / TongHesoSize, 0, MidpointRounding.AwayFromZero);
                        tAmount += pAmount;
                        rowP[TK] = pAmount;
                        rowP["Amount"] = (decimal)rowP["Amount"] + pAmount;
                    }
                    else if (TK.StartsWith("627") && TongHesoSize2 != 0)
                    {
                        decimal HesoSize2 = (decimal)rowP["HesoSize2"];
                        decimal pAmount = Math.Round(Amount * HesoSize2 / TongHesoSize2, 0, MidpointRounding.AwayFromZero);
                        tAmount += pAmount;
                        rowP[TK] = pAmount;
                        rowP["Amount"] = (decimal)rowP["Amount"] + pAmount;
                    }
                }
                if (Amount != tAmount)
                {
                    dt.Rows[dt.Rows.Count - 1][TK] = Amount - tAmount + (decimal)dt.Rows[dt.Rows.Count - 1][TK];
                    dt.Rows[dt.Rows.Count - 1]["Amount"] = Amount - tAmount + (decimal)dt.Rows[dt.Rows.Count - 1]["Amount"];
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                if ((decimal)row["Quantity"] != 0)
                    row["Price"] = Math.Round((decimal)row["Amount"] / (decimal)row["Quantity"], 2, MidpointRounding.AwayFromZero);
            }
            return dt;
        }
	}

}
