using System;
using System.Collections.Generic;
using System.Text;
using VNS.Data.BLL;
using VNS.Data.DAL;
using VNS.Utils;
using VNS.Common;
using VNS.ERP.Data.Sales;

namespace VNS.ERP.Data.Accounting
{
    public class AccountTransactionStockNewBLL : AccountTransactionBLL<AccountTransactionStockNew>, IBusiness
    {
        AccountTransactionStockNewDAL accTransStocknNewDAL = new AccountTransactionStockNewDAL();
        AccountTransactionStockDAL dalTransStock = new AccountTransactionStockDAL();
        AccountTransactionStockDetailDAL dalTransStockDetail = new AccountTransactionStockDetailDAL();
        //AccountTransactionDAL dalTran = new AccountTransactionDAL();
        //AccountTransactionDetail1DAL dalDetail1 = new AccountTransactionDetail1DAL();
        //AccountTransactionDetail2DAL dalDetail2 = new AccountTransactionDetail2DAL();
        AccountStockDAL accStockDal = new AccountStockDAL();
        //InvoiceDAL invdal = null;
        public AccountTransactionStockNewBLL()
        { }
        public decimal SumCostAmountX21(DateTime startDate, DateTime endDate,string goodType)
        {
            return dalTransStockDetail.SumCostAmountX21(startDate, endDate, goodType);
        }
        public AccountTransactionStock SelectAccTransStockByAccountTransactionID(Guid accountTransactionID)
        {
            return accTransStocknNewDAL.SelectAccTransStockByAccountTransactionID(accountTransactionID);
        }
        public ListBase<AccountTransactionStockDetail> GetAccTransStockDetailByAccTransID(Guid accTransID)
        {
            return dalTransStockDetail.GetByAccTransID(accTransID);
        }
        public ListBase<AccountTransactionStockNew> SelectByStockTransTypeDateSpecialTypeWithAccTransStock(string accTypeCode, string stockTransType, string specialType, DateTime startDate, DateTime endDate)
        {
            return accTransStocknNewDAL.SelectByStockTransTypeDateSpecialTypeWithAccTransStock(accTypeCode, stockTransType, specialType, startDate, endDate);
        }
        public ListBase<AccountTransactionStockNew> SelectWithAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            return accTransStocknNewDAL.SelectWithAccountTransactionStockForPeriod(accountTransTypeCode, stockTransTypeCode, branchCode, startDate,endDate);
        }
        public ListBase<AccountTransactionStockNew> SelectWithDetail1AndAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            return accTransStocknNewDAL.SelectWithDetail1AndAccountTransactionStockForPeriod(accountTransTypeCode, stockTransTypeCode, branchCode, startDate, endDate);
        }
        public ListBase<AccountTransactionStockNew> SelectWithDetailAndAccountTransactionStockForPeriod(string accountTransTypeCode, string stockTransTypeCode, string branchCode, DateTime startDate, DateTime endDate)
        {
            return accTransStocknNewDAL.SelectWithDetailAndAccountTransactionStockForPeriod(accountTransTypeCode, stockTransTypeCode, branchCode, startDate, endDate);
        }
        public void AccountedFromAccTransStock(ref AccountTransactionStockNew t, string donviCode, decimal thueXuat)
        {
            ListBase<Account> lstAccount = null;
            decimal materialAccountAmount = 0;
            Subject subjectObj1 = new SubjectBLL().GetBySubjectCode(t.SubjectCode1);
            Customer customerObj1 = new CustomerBLL().GetBySubjectCode(t.SubjectCode2);
            string tkDoanhthu = string.Empty, tkChietkhau = string.Empty;
            if (customerObj1 != null && customerObj1.ProductType != null)
            {
                if (customerObj1.ProductType.StartsWith("01."))
                {
                    tkDoanhthu = Account.IncomeProductAccountTS;
                    tkChietkhau = Account.SaleProductDiscountAccountTS;
                }
                else if (customerObj1.ProductType.StartsWith("02."))
                {
                    tkDoanhthu = Account.IncomeProductAccountGS;
                    tkChietkhau = Account.SaleProductDiscountAccountGS;
                }
                else
                {
                    tkDoanhthu = Account.IncomeProductAccountCV;
                    tkChietkhau = Account.SaleProductDiscountAccountCV;
                }
            }
            //bỏ qua định khoản 632 (xuất thành phẩm bán), 6111 (Xuất nguyên liệu bán)
            if (t.AccTransactionStock.StockTransactionTypeCode != enumStockTransactionType.X21.ToString() && t.AccTransactionStock.StockTransactionTypeCode != enumStockTransactionType.X14.ToString())
            {
                t.Description = t.AccTransactionStock.Description;
                foreach (AccountTransactionStockDetail atsd in t.AccTransactionStock.Detail)
                {
                    //InStock
                    if (atsd.DebitAccountCode != string.Empty && atsd.DebitAccountCode != null)
                    {
                        bool found = false;
                        foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                        {
                            if (atd1.AccountCode == atsd.DebitAccountCode)
                            {
                                atd1.DebitAmount = 0;
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            AccountTransactionDetail1 atd11 = new AccountTransactionDetail1();
                            atd11.AccountCode = atsd.DebitAccountCode;
                            lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd11.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                            if (subjectObj1 != null && lstAccount.Count > 0)
                            {
                                atd11.ClassificationCode = subjectObj1.BranchCode;
                            }
                            atd11.Description = t.Description;
                            t.Detail1.Add(atd11);
                        }
                    }
                    else if (atsd.CreditAccountCode != string.Empty && atsd.CreditAccountCode != null)//OutStock
                    {
                        bool found = false;
                        foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                        {
                            if (atd1.AccountCode == atsd.CreditAccountCode)
                            {
                                atd1.CreditAmount = 0;
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            AccountTransactionDetail1 atd11 = new AccountTransactionDetail1();
                            atd11.AccountCode = atsd.CreditAccountCode;
                            lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd11.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                            if (subjectObj1 != null && lstAccount.Count > 0)
                            {
                                atd11.ClassificationCode = subjectObj1.BranchCode;
                            }
                            atd11.Description = t.Description;
                            t.Detail1.Add(atd11);
                        }
                    }
                }
                foreach (AccountTransactionStockDetail atsd1 in t.AccTransactionStock.Detail)
                {
                    //InStock
                    int lenMaterialAccount = Account.MaterialAccount.Length;
                    
                    if (atsd1.DebitAccountCode != string.Empty && atsd1.DebitAccountCode != null)
                    {
                        if (atsd1.DebitAccountCode.Length > lenMaterialAccount && atsd1.DebitAccountCode.Substring(0, lenMaterialAccount) == Account.MaterialAccount)
                        {
                            materialAccountAmount += atsd1.CostAmount;
                        }
                        foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                        {
                            if (atd1.AccountCode == atsd1.DebitAccountCode)
                            {
                                atd1.DebitAmount += atsd1.CostAmount;
                                
                            }
                        }
                    }
                    else if (atsd1.CreditAccountCode != string.Empty && atsd1.CreditAccountCode != null)//OutStock
                    {
                        if (atsd1.CreditAccountCode.Length >= lenMaterialAccount && atsd1.CreditAccountCode.Substring(0, lenMaterialAccount) == Account.MaterialAccount)
                        {
                            materialAccountAmount += atsd1.CostAmount;
                        }
                        foreach (AccountTransactionDetail1 atd1 in t.Detail1)
                        {
                            if (atd1.AccountCode == atsd1.CreditAccountCode)
                            {
                                atd1.CreditAmount += atsd1.CostAmount;
                            }
                        }
                    }
                }
            }
            //trường hợp xuất bán
            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString() || t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X14.ToString())
            {
                //Subject subjectObj1 = new SubjectBLL().GetBySubjectCode(t.SubjectCode1); 
                //if (t.Invoice == null) t.Invoice = new ListBase<Invoice>();
                //t.Invoice.Clear();
                foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                {
                    int len1 = Account.IncomeProductAccount.ToString().Length;
                    int len2 = Account.CustomerDeptAccount.ToString().Length;
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail2.Amount = 0;
                        }
                    }
                    len1 = Account.VATOutAccount.ToString().Length;
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.VATOutAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail2.Amount = 0;
                        }
                    }
                }
                foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                {
                    int len1 = Account.IncomeProductAccount.ToString().Length;
                    int len2 = Account.VATOutAccount.ToString().Length;
                    if (accTransDetail1.AccountCode.Length >= len1)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len1) == Account.IncomeProductAccount.ToString())
                        {
                            accTransDetail1.CreditAmount = 0;
                        }
                    }
                    if (accTransDetail1.AccountCode.Length >= len2)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len2) == Account.VATOutAccount.ToString())
                        {
                            accTransDetail1.CreditAmount = 0;
                        }
                    }
                }
                decimal toTalAmount = 0;
                bool detail1NotFound1 = true;
                bool detail2NotFound1 = true;
                bool detail1NotFound2 = true;
                bool detail2NotFound2 = true;
                //bool detail2NotFound3 = true;
                bool detail1NotFound3 = true;
              //  bool detail1NotFound4 = true;
                foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                {
                    int len1 = Account.IncomeProductAccount.ToString().Length;
                    int len2 = Account.CustomerDeptAccount.ToString().Length;
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            detail2NotFound1 = false;
                            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                            {
                                if (customerObj1.ProductType.StartsWith("02."))
                                {
                                    accTransDetail2.Description = "Doanh thu bán thức ăn gia súc";
                                    accTransDetail2.Description2 = "Doanh thu bán thức ăn gia súc";
                                }
                                else
                                {
                                    accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                                    accTransDetail2.Description2 = "Doanh thu bán thức ăn cá";
                                }
                            }
                        }
                    }
                    len1 = Account.VATOutAccount.ToString().Length;
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.VATOutAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            detail2NotFound2 = false;
                            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                            {
                                if (customerObj1.ProductType.StartsWith("02."))
                                {
                                    accTransDetail2.Description = "Thuế GTGT Thức ăn gia súc";
                                    accTransDetail2.Description2 = "Thuế GTGT Thức ăn gia súc";
                                }
                                else
                                {
                                    accTransDetail2.Description = "Thuế GTGT Thức ăn cá";
                                    accTransDetail2.Description2 = "Thuế GTGT Thức ăn cá";
                                }
                            }
                        }
                    }
                    //len1 = Account.MaterialAccount.ToString().Length;
                    //len2 = Account.VendorDebtAccount.ToString().Length;
                    //if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    //{
                    //    if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.MaterialAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.VendorDebtAccount.ToString())
                    //    {
                    //        detail2NotFound3 = false;
                    //        //if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    //        //{
                    //        //    accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                    //        //}
                    //    }
                    //}
                }
                foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                {
                    int len1 = Account.IncomeProductAccount.Length;
                    int len2 = Account.VATOutAccount.Length;
                    int len3 = Account.CustomerDeptAccount.Length;
                   // int len4 = Account.VendorDebtAccount.ToString().Length;
                    if (accTransDetail1.AccountCode.Length >= len1)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len1) == Account.IncomeProductAccount.ToString())
                        {
                            detail1NotFound1 = false;
                            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                            {
                                if (customerObj1.ProductType.StartsWith("02."))
                                    accTransDetail1.Description = "Doanh thu bán thức ăn gia súc";
                                else
                                    accTransDetail1.Description = "Doanh thu bán thức ăn cá";
                            }
                        }
                    }
                    if (accTransDetail1.AccountCode.Length >= len2)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len2) == Account.VATOutAccount.ToString())
                        {
                            detail1NotFound2 = false;
                            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                            {
                                if (customerObj1.ProductType.StartsWith("02."))
                                    accTransDetail1.Description = "Thuế GTGT Thức ăn gia súc";
                                else
                                    accTransDetail1.Description = "Thuế GTGT Thức ăn cá";
                            }
                        }
                    }
                    if (accTransDetail1.AccountCode.Length >= len3)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len3) == Account.CustomerDeptAccount.ToString())
                        {
                            detail1NotFound3 = false;
                            accTransDetail1.Description = t.Description;
                        }
                    }
                    //if (accTransDetail1.AccountCode.Length >= len4)
                    //{
                    //    if (accTransDetail1.AccountCode.Substring(0, len4) == Account.VendorDebtAccount.ToString())
                    //    {
                    //        detail1NotFound4 = false;
                    //        //accTransDetail1.Description = t.Description;
                    //    }
                    //}
                }

                //if (detail1NotFound4)
                //{
                //    AccountTransactionDetail1 accTransDetail1 = new AccountTransactionDetail1();
                //    accTransDetail1.AccountCode = Account.VendorDebtAccount.ToString();
                //    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                //    if (lstAccount.Count > 0 && subjectObj1 != null)
                //    {
                //        accTransDetail1.ClassificationCode = subjectObj1.BranchCode;
                //    }
                //   // accTransDetail1.Description = t.Description;
                //    accTransDetail1.DebitAmount = materialAccountAmount;
                //    t.Detail1.Insert(0,accTransDetail1);
                //}

                if (detail1NotFound3)
                {
                    AccountTransactionDetail1 accTransDetail1 = new AccountTransactionDetail1();
                    accTransDetail1.AccountCode = Account.CustomerDeptAccount.ToString();
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail1.ClassificationCode = subjectObj1.BranchCode;
                    }
                    accTransDetail1.Description = t.Description;
                    t.Detail1.Add(accTransDetail1);
                }

                if (t.AccTransactionStock.DiscountAmount != 0)
                {
                    int len1 = Account.SaleDiscountAccount.ToString().Length;
                    int len2 = tkChietkhau.Length; //Account.SaleProductDiscountAccount.ToString().Length;
                    int len3 = tkDoanhthu.Length;// Account.IncomeProductAccount.ToString().Length;
                   

                    bool detail2NotFound = true;
                    bool detail1NotFound = true;
                    foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                    {
                        if (t.AccTransactionStock.Giamgia)
                        {
                            if (accTransDetail2.CreditAccountCode.Length >= len3 && accTransDetail2.DebitAccountCode.Length >= len1)
                            {
                                if (accTransDetail2.CreditAccountCode.Substring(0, len3) == tkDoanhthu && accTransDetail2.DebitAccountCode.Substring(0, len1) == Account.SaleDiscountAccount.ToString())
                                {
                                    detail2NotFound = false;
                                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                                    {
                                        if (customerObj1.ProductType.StartsWith("02."))
                                        {
                                            accTransDetail2.Description = "Doanh thu bán thức ăn gia súc";
                                            accTransDetail2.Description2 = "Doanh thu bán thức ăn gia súc";
                                        }
                                        else
                                        {
                                            accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                                            accTransDetail2.Description2 = "Doanh thu bán thức ăn cá";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (accTransDetail2.CreditAccountCode.Length >= len3 && accTransDetail2.DebitAccountCode.Length >= len2)
                            {
                                if (accTransDetail2.CreditAccountCode.Substring(0, len3) == tkDoanhthu && accTransDetail2.DebitAccountCode.Substring(0, len2) == tkChietkhau)
                                {
                                    detail2NotFound = false;
                                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                                    {
                                        if (customerObj1.ProductType.StartsWith("02."))
                                        {
                                            accTransDetail2.Description = "Doanh thu bán thức ăn gia súc";
                                            accTransDetail2.Description2 = "Doanh thu bán thức ăn gia súc";
                                        }
                                        else
                                        {
                                            accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                                            accTransDetail2.Description2 = "Doanh thu bán thức ăn cá";
                                        }
                                    }
                                }
                            }
                        }
                    }
                    foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                    {
                        if (t.AccTransactionStock.Giamgia)
                        {
                            if (accTransDetail1.AccountCode.Length >= len1)
                            {
                                if (accTransDetail1.AccountCode.Substring(0, len1) == Account.SaleDiscountAccount.ToString())
                                {
                                    detail1NotFound = false;
                                    accTransDetail1.Description = t.Description;
                                }
                            }
                        }
                        else
                        {
                            if (accTransDetail1.AccountCode.Length >= len2)
                            {
                                if (accTransDetail1.AccountCode.Substring(0, len2) == tkChietkhau)
                                {
                                    detail1NotFound = false;
                                    accTransDetail1.Description = t.Description;
                                }
                            }
                        }
                    }
                    //ListBase<Account> lstAccount = null;
                    if (detail2NotFound)
                    {
                        AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = tkDoanhthu;
                        if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                        {
                            if (customerObj1.ProductType.StartsWith("02."))
                            {
                                atd2.Description = "Doanh thu bán thức ăn gia súc";
                                atd2.Description2 = "Doanh thu bán thức ăn gia súc";
                            }
                            else
                            {
                                atd2.Description = "Doanh thu bán thức ăn cá";
                                atd2.Description2 = "Doanh thu bán thức ăn cá";
                            }
                        }
                        if (t.AccTransactionStock.Giamgia)
                        {
                            atd2.DebitAccountCode = Account.SaleDiscountAccount;

                        }
                        else
                        {
                            atd2.DebitAccountCode = tkChietkhau;
                        }
                        lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd2.DebitAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                        if (lstAccount.Count > 0 && subjectObj1 != null)
                        {
                            atd2.DebitClassificationCode = subjectObj1.BranchCode;
                        }
                        lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd2.CreditAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                        if (lstAccount.Count > 0 && subjectObj1 != null)
                        {
                            atd2.CreditClassificationCode = subjectObj1.BranchCode;
                        }
                        atd2.Amount = t.AccTransactionStock.DiscountAmount;
                        t.Detail2.Add(atd2);
                    }
                    if (detail1NotFound)
                    {
                        AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                        atd1.DebitAmount = t.AccTransactionStock.DiscountAmount;
                        if (t.AccTransactionStock.Giamgia)
                        {
                            atd1.AccountCode = Account.SaleDiscountAccount;
                        }
                        else
                        {
                            atd1.AccountCode = tkChietkhau;
                        }
                        atd1.Description = t.Description;
                        lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                        if (lstAccount.Count > 0 && subjectObj1 != null)
                        {
                            atd1.ClassificationCode = subjectObj1.BranchCode;
                        }
                        t.Detail1.Add(atd1);
                    }
                }

                //if (detail2NotFound3)
                //{
                //    AccountTransactionDetail2 accTransDetail2 = new AccountTransactionDetail2();
                //    accTransDetail2.CreditAccountCode = Account.MaterialAccount.ToString();
                //    //if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                //    //{
                //    //    accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                //    //}
                //    accTransDetail2.DebitAccountCode = Account.VendorDebtAccount.ToString();
                //    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.DebitAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                //    if (lstAccount.Count > 0 && subjectObj1 != null)
                //    {
                //        accTransDetail2.DebitClassificationCode = subjectObj1.BranchCode;
                //    }
                //    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.CreditAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                //    if (lstAccount.Count > 0 && subjectObj1 != null)
                //    {
                //        accTransDetail2.CreditClassificationCode = subjectObj1.BranchCode;
                //    }
                //    accTransDetail2.Amount = materialAccountAmount;
                //    t.Detail2.Add(accTransDetail2);
                //}
                if (detail2NotFound1)
                {
                    AccountTransactionDetail2 accTransDetail2 = new AccountTransactionDetail2();
                    accTransDetail2.CreditAccountCode = tkDoanhthu;// Account.IncomeProductAccount.ToString();
                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        if (customerObj1.ProductType.StartsWith("02."))
                        {
                            accTransDetail2.Description = "Doanh thu bán thức ăn gia súc";
                            accTransDetail2.Description2 = "Doanh thu bán thức ăn gia súc";
                        }
                        else
                        {
                            accTransDetail2.Description = "Doanh thu bán thức ăn cá";
                            accTransDetail2.Description2 = "Doanh thu bán thức ăn cá";
                        }
                    }
                    accTransDetail2.DebitAccountCode = Account.CustomerDeptAccount.ToString();
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.DebitAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail2.DebitClassificationCode = subjectObj1.BranchCode;
                    }
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.CreditAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail2.CreditClassificationCode = subjectObj1.BranchCode;
                    }
                    t.Detail2.Add(accTransDetail2);
                }
                if (detail2NotFound2)
                {
                    AccountTransactionDetail2 accTransDetail2 = new AccountTransactionDetail2();
                    accTransDetail2.CreditAccountCode = Account.VATOutAccount.ToString();
                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        if (customerObj1.ProductType.StartsWith("02."))
                        {
                            accTransDetail2.Description = "Thuế GTGT Thức ăn gia súc";
                            accTransDetail2.Description2 = "Thuế GTGT Thức ăn gia súc";
                        }
                        else
                        {
                            accTransDetail2.Description = "Thuế GTGT Thức ăn cá";
                            accTransDetail2.Description2 = "Thuế GTGT Thức ăn cá";
                        }
                    }
                    accTransDetail2.DebitAccountCode = Account.CustomerDeptAccount.ToString();
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.DebitAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail2.DebitClassificationCode = subjectObj1.BranchCode;
                    }
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail2.CreditAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail2.CreditClassificationCode = subjectObj1.BranchCode;
                    }
                    t.Detail2.Add(accTransDetail2);
                }
                if (detail1NotFound1)
                {
                    AccountTransactionDetail1 accTransDetail1 = new AccountTransactionDetail1();
                    accTransDetail1.AccountCode = tkDoanhthu; //Account.IncomeProductAccount.ToString();
                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        if (customerObj1.ProductType.StartsWith("02."))
                            accTransDetail1.Description = "Doanh thu bán thức ăn gia súc";
                        else
                            accTransDetail1.Description = "Doanh thu bán thức ăn cá";
                    }
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail1.ClassificationCode = subjectObj1.BranchCode;
                    }
                    t.Detail1.Add(accTransDetail1);
                }
                if (detail1NotFound2)
                {
                    AccountTransactionDetail1 accTransDetail1 = new AccountTransactionDetail1();
                    accTransDetail1.AccountCode = Account.VATOutAccount.ToString();
                    if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        if (customerObj1.ProductType.StartsWith("02."))
                            accTransDetail1.Description = "Thuế GTGT Thức ăn gia súc";
                        else
                            accTransDetail1.Description = "Thuế GTGT Thức ăn cá";
                    }
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + accTransDetail1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (lstAccount.Count > 0 && subjectObj1 != null)
                    {
                        accTransDetail1.ClassificationCode = subjectObj1.BranchCode;
                    }
                    t.Detail1.Add(accTransDetail1);
                }
                AccountTransactionDetail2 accTransDetail2Remove = null;
                foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                {
                    //int len1 = Account.IncomeProductAccount.ToString().Length;
                    //int len2 = Account.CustomerDeptAccount.ToString().Length;
                    //tri
                    int len1 = tkDoanhthu.Length;
                    int len2 = Account.CustomerDeptAccount.ToString().Length;
                    //

                   // int len3 = Account.MaterialAccount.ToString().Length;
                    //if (accTransDetail2.CreditAccountCode.Length >= len3)
                    //{
                    //    if (accTransDetail2.CreditAccountCode.Substring(0, len3) == Account.MaterialAccount.ToString())
                    //    {
                    //        accTransDetail2.DebitSubjectCode = t.SubjectCode2;
                    //    }
                    //}
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == tkDoanhthu && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail2.Amount += t.AccTransactionStock.BeforeTaxAmount;
                            toTalAmount += t.AccTransactionStock.BeforeTaxAmount;
                            accTransDetail2.DebitSubjectCode = t.SubjectCode2;
                        }
                    }
                    len1 = Account.VATOutAccount.ToString().Length;
                    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                    {
                        if (accTransDetail2.CreditAccountCode.Substring(0, len1) == Account.VATOutAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail2.Amount += t.AccTransactionStock.TaxAmount;
                            toTalAmount += t.AccTransactionStock.TaxAmount;
                            accTransDetail2.DebitSubjectCode = t.SubjectCode2;
                            if (accTransDetail2.Amount == 0) accTransDetail2Remove = accTransDetail2;
                        }
                    }
                }
                if (accTransDetail2Remove != null)
                {
                    t.Detail2.Remove(accTransDetail2Remove);
                }
                AccountTransactionDetail1 accTransDetail1Remove = null;
                foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                {
                    int len1 = tkDoanhthu.Length;// Account.IncomeProductAccount.Length;
                    int len2 = Account.VATOutAccount.Length;
                    int len3 = Account.CustomerDeptAccount.Length;
                    //int len4 = Account.VendorDebtAccount.Length;
                    if (accTransDetail1.AccountCode.Length >= len1)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len1) == tkDoanhthu)
                        {
                            accTransDetail1.CreditAmount += t.AccTransactionStock.BeforeTaxAmount + t.AccTransactionStock.DiscountAmount;
                        }
                    }
                    if (accTransDetail1.AccountCode.Length >= len2)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len2) == Account.VATOutAccount.ToString())
                        {
                            accTransDetail1.CreditAmount += t.AccTransactionStock.TaxAmount;
                            if (accTransDetail1.CreditAmount == 0)
                            {
                                accTransDetail1Remove = accTransDetail1;
                            }
                        }
                    }
                    if (accTransDetail1.AccountCode.Length >= len3)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len3) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail1.SubjectCode = t.SubjectCode2;
                        }
                    }
                    //if (accTransDetail1.AccountCode.Length >= len4)
                    //{
                    //    if (accTransDetail1.AccountCode.Substring(0, len4) == Account.VendorDebtAccount.ToString())
                    //    {
                    //        accTransDetail1.SubjectCode = t.SubjectCode2;
                    //    }
                    //}
                }
                if (accTransDetail1Remove != null)
                {
                    t.Detail1.Remove(accTransDetail1Remove);
                }
                foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                {
                    int len1 = Account.CustomerDeptAccount.ToString().Length;
                    if (accTransDetail1.AccountCode.Length >= len1)
                    {
                        if (accTransDetail1.AccountCode.Substring(0, len1) == Account.CustomerDeptAccount.ToString())
                        {
                            accTransDetail1.DebitAmount = toTalAmount;
                        }
                    }
                }
            }
            //trường hợp nhập mua
            decimal d1 = 0;
            decimal d2 = 0;
            if (t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.N11.ToString() || t.AccTransactionStock.StockTransactionTypeCode == enumStockTransactionType.N31.ToString())
            {
                foreach (AccountTransactionStockDetail atsd in t.AccTransactionStock.Detail)
                {
                    d1 += atsd.Amount;
                }
                d2 = d1 + Math.Round(d1 * thueXuat, 0);
                d1 = Math.Round(d1 * thueXuat, 0);

                AccountTransactionDetail1 atd1 = t.Detail1.Search("AccountCode", Account.VATInAccount.ToString());
                if (atd1 == null)
                {
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.VATInAccount.ToString();
                    atd1.DebitAmount = t.AccTransactionStock.TaxAmount;
                    //atd1.SubjectCode = donviCode;
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (subjectObj1 != null && lstAccount.Count > 0)
                    {
                        atd1.ClassificationCode = subjectObj1.BranchCode;
                    }
                    atd1.Description = t.Description;
                    if (atd1.DebitAmount!=0) t.Detail1.Add(atd1);
                }
                else
                {
                    //atd1.SubjectCode = donviCode;
                    atd1.DebitAmount = t.AccTransactionStock.TaxAmount;
                    if (atd1.DebitAmount == 0) t.Detail1.Remove(atd1);
                }

                atd1 = t.Detail1.Search("AccountCode", Account.VendorDebtAccount.ToString());
                if (atd1 == null)
                {
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.VendorDebtAccount.ToString();
                    atd1.SubjectCode = donviCode;
                    atd1.CreditAmount = t.AccTransactionStock.InvoiceAmount;
                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                    if (subjectObj1 != null && lstAccount.Count > 0)
                    {
                        atd1.ClassificationCode = subjectObj1.BranchCode;
                    }
                    atd1.Description = t.Description;
                    t.Detail1.Add(atd1);
                }
                else
                {
                    atd1.SubjectCode = donviCode;
                    atd1.CreditAmount = t.AccTransactionStock.InvoiceAmount;
                }
                
                //bool found = false;
                //foreach (AccountTransactionDetail2 atd2 in t.Detail2)
                //{
                //    if (atd2.DebitAccountCode == Account.VendorDebtAccount.ToString() && atd2.CreditAccountCode == Account.VATInAccount.ToString())
                //    {
                //        atd2.Amount = 0;
                //        found = true;
                //        break;
                //    }
                //}
                //if (!found)
                //{
                //    AccountTransactionDetail2 atd22 = new AccountTransactionDetail2();
                //    atd22.CreditAccountCode = Account.VATInAccount.ToString();
                //    atd22.CreditSubjectCode = donviCode;
                //    atd22.DebitAccountCode = Account.VendorDebtAccount.ToString();
                //    t.Detail2.Add(atd22);
                //}
            }
        }
        public ListBase<AccountStock> GetAccStockByAccTransID(Guid accTransID)
        {
            return accStockDal.GetByAccTransID(accTransID);
        }
        public ListBase<AccountTransactionStockNew> SelectWithAccountTransactionStock(string accountTransTypeCode, string stockTransTypeCode)
        {
            return accTransStocknNewDAL.SelectWithAccountTransactionStock(accountTransTypeCode, stockTransTypeCode);
        }
        public AccountTransactionStockNew GetByStockTransactionID(Guid stockTransactionID)
        {
            return accTransStocknNewDAL.GetByStockTransactionID(stockTransactionID);
        }
        public int Insert(AccountTransactionStockNew t)
        {
            //AccountTransaction t1 = t as AccountTransaction;
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            dalTransStock = new AccountTransactionStockDAL(dalAccountTransaction.DBHelper);
            //dalDetail1 = new AccountTransactionDetail1DAL(dalTran.DBHelper);
            //dalDetail2 = new AccountTransactionDetail2DAL(dalTran.DBHelper);
            dalTransStockDetail = new AccountTransactionStockDetailDAL(dalAccountTransaction.DBHelper);
            accStockDal = new AccountStockDAL(dalAccountTransaction.DBHelper);
            //invdal = new InvoiceDAL(dalTran.DBHelper);
            dalAccountTransaction.BeginTransaction();

            iError = base.InsertBase(t);
            if (iError == 0)
            {
                t.AccTransactionStock.AccountTransationID = t.AccountTransactionID;
                iError = dalTransStock.Insert(t.AccTransactionStock);
            }
            if (iError == 0)
            {
                foreach (AccountTransactionStockDetail accTransStockDetail in t.AccTransactionStock.Detail)
                {
                    if (iError == 0)
                    {
                        if (accTransStockDetail.StockOutCode != null && accTransStockDetail.StockOutCode != string.Empty && accTransStockDetail.StockOutCode != "")
                        {
                            AccountTransactionDetail1 accTransDetail1 = t.Detail1.Search("AccountCode", accTransStockDetail.CreditAccountCode);
                            if (accTransDetail1 != null)
                            {
                                accTransStockDetail.AccountTransactionDetail1ID = accTransDetail1.AccountTransactionDetail1ID;
                            }

                            AccountTransactionDetail2 accTransDetail2 = t.Detail2.Search("CreditAccountCode", accTransStockDetail.CreditAccountCode);
                            if (accTransDetail2 != null)
                            {
                                accTransStockDetail.AccountTransactionDetail2ID = accTransDetail2.AccountTransactionDetail2ID;
                            }
                        }
                        accTransStockDetail.AccountTransactionID = t.AccountTransactionID;
                        iError = dalTransStockDetail.Insert(accTransStockDetail);
                    }
                    if (iError != 0) break;
                }
            }

            if (iError == 0)
            {
                foreach (AccountStock accStock in t.AccTransactionStock.LstAccountStock)
                {
                    accStock.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        iError = accStockDal.Insert(accStock);
                    }
                    if (iError != 0) break;
                }
            }

            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }

            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public int Update(AccountTransactionStockNew t)
        {
            //AccountTransaction t1 = t as AccountTransaction;
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            dalTransStock = new AccountTransactionStockDAL(dalAccountTransaction.DBHelper);
            //dalDetail1 = new AccountTransactionDetail1DAL(dalTran.DBHelper);
            //dalDetail2 = new AccountTransactionDetail2DAL(dalTran.DBHelper);
            dalTransStockDetail = new AccountTransactionStockDetailDAL(dalAccountTransaction.DBHelper);
            accStockDal = new AccountStockDAL(dalAccountTransaction.DBHelper);
            //invdal = new InvoiceDAL(dalTran.DBHelper);
            dalAccountTransaction.BeginTransaction();

            iError = dalTransStockDetail.DeleteByAccTransStock(t.AccountTransactionID);
            if (iError == 0)
            {
                iError = base.UpdateBase(t);
            }
           
            if (iError == 0)
            {
                t.AccTransactionStock.AccountTransationID = t.AccountTransactionID;
                iError = dalTransStock.Update(t.AccTransactionStock);
            }
            if (iError == 0)
            {
                foreach (AccountTransactionStockDetail accTransStockDetail in t.AccTransactionStock.Detail)
                {
                    if (iError == 0)
                    {
                        if (accTransStockDetail.StockOutCode != null && accTransStockDetail.StockOutCode != string.Empty && accTransStockDetail.StockOutCode != "")
                        {
                            AccountTransactionDetail1 accTransDetail1 = t.Detail1.Search("AccountCode", accTransStockDetail.CreditAccountCode);
                            if (accTransDetail1 != null)
                            {
                                accTransStockDetail.AccountTransactionDetail1ID = accTransDetail1.AccountTransactionDetail1ID;
                            }
                            AccountTransactionDetail2 accTransDetail2 = t.Detail2.Search("CreditAccountCode", accTransStockDetail.CreditAccountCode);
                            if (accTransDetail2 != null)
                            {
                                accTransStockDetail.AccountTransactionDetail2ID = accTransDetail2.AccountTransactionDetail2ID;
                            }
                        }
                        accTransStockDetail.AccountTransactionID = t.AccountTransactionID;
                        iError = dalTransStockDetail.Insert(accTransStockDetail);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError == 0)
            {
                iError = accStockDal.DeleteByAccTransStock(t.AccountTransactionID);
            }
            if (iError == 0)
            {
                foreach (AccountStock accStock in t.AccTransactionStock.LstAccountStock)
                {
                    accStock.AccountTransactionID = t.AccountTransactionID;
                    if (iError == 0)
                    {
                        iError = accStockDal.Insert(accStock);
                    }
                    if (iError != 0) break;
                }
            }
            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public int Delete(AccountTransactionStockNew t)
        {
            int iError;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            dalAccountTransaction.BeginTransaction();
            iError = base.DeleteBase(t);
            if (iError != 0) dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }
            if (!alreadyOpen) dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public int Delete(ListBase<AccountTransactionStockNew> lst)
        {
            int iError = 0;
            bool alreadyOpen = false;
            if (dalAccountTransaction.DBHelper.State != System.Data.ConnectionState.Open) dalAccountTransaction.DBHelper.Open();
            else alreadyOpen = true;
            dalAccountTransaction.BeginTransaction();
            foreach (AccountTransactionStockNew t in lst)
            {
                if (iError == 0)
                {
                    iError = base.DeleteBase(t);
                }
                if (iError != 0) break;
            }
            if (iError != 0)
                dalAccountTransaction.Rollback();
            else
            {
                dalAccountTransaction.Commit();
            }

            if (!alreadyOpen)
                dalAccountTransaction.DBHelper.Close();
            return iError;
        }
        public void GetDataFromStockTransaction(System.Collections.ArrayList lst, ref AccountTransactionStockNew t, string accountTransactionTypeCode, string stockTransactionTypeCode)
        {
            if (t.AccTransactionStock == null) t.AccTransactionStock = new AccountTransactionStock();
            if (t.AccTransactionStock.Detail == null) t.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
            if (t.AccTransactionStock.LstAccountStock == null) t.AccTransactionStock.LstAccountStock = new ListBase<AccountStock>();
            if (lst.Count > 0)
            {
                t.AccTransactionStock.Detail.Clear();
                t.AccTransactionStock.LstAccountStock.Clear();
               

                StockTransaction t1 = lst[0] as StockTransaction;
                t.AccountTransactionNo = t1.TransactionNo;
                t.AccountTransactionDate = t1.TransactionDate;
                t.Description = t1.Description;
                t.AccTransactionStock.StockTransactionNo = t1.TransactionNo;
                t.AccTransactionStock.StockTransactionDate = t1.TransactionDate;
                t.AccTransactionStock.Nguoigiaonhan = t1.NguoiGiaoNhan;
                t.AccTransactionStock.PTVC = t1.PTVC;
                t.AccTransactionStock.NguoiVC = t1.DonviVC;
                t.AccTransactionStock.Chungtukemtheo = t1.CTKemTheo;
                t.AccTransactionStock.Description = t1.Description;
            }
            t.NgayCT = t.AccountTransactionDate;
            if (accountTransactionTypeCode == enumAccountTransactionType.STOCKIN.ToString())
            {
                foreach (StockTransaction stockTrans in lst)
                {
                    stockTrans.Details = new StockTransactionBLL().GetDetailsByTransactionID(stockTrans.TransactionID);
                    foreach (StockTransactionSumDetail stockTransSumDetail in stockTrans.Details)
                    {
                        bool found = false;
                        foreach (AccountTransactionStockDetail accTransStockDetail in t.AccTransactionStock.Detail)
                        {
                            if (accTransStockDetail.ItemCode == stockTransSumDetail.ItemCode && accTransStockDetail.StockInCode == stockTrans.InStock)
                            {
                                found = true;
                                accTransStockDetail.Quantity += stockTransSumDetail.Quantity;
                                accTransStockDetail.Amount += stockTransSumDetail.AmountIn;
                                accTransStockDetail.CostAmount += stockTransSumDetail.AmountCost;
                                accTransStockDetail.CostAmount = accTransStockDetail.Amount;
                            }
                        }
                        if (!found)
                        {
                            AccountTransactionStockDetail accTransStockDetail1 = new AccountTransactionStockDetail();
                            if (stockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N1.ToString() || stockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.N3.ToString())
                            {
                                accTransStockDetail1.DebitAccountCode = Account.MaterialAccount;
                            }
                            else
                            {
                                accTransStockDetail1.DebitAccountCode = Account.ProductAccount;
                            }
                            accTransStockDetail1.StockInCode = stockTrans.InStock;
                            accTransStockDetail1.ItemCode = stockTransSumDetail.ItemCode;
                            accTransStockDetail1.Quantity = stockTransSumDetail.Quantity;
                            accTransStockDetail1.CostAmount = stockTransSumDetail.AmountCost;
                            accTransStockDetail1.Amount = stockTransSumDetail.AmountIn;
                            accTransStockDetail1.CostAmount = accTransStockDetail1.Amount;
                            accTransStockDetail1.Price = stockTransSumDetail.PriceIn;
                            t.AccTransactionStock.Detail.Add(accTransStockDetail1);
                        }
                    }
                    AccountStock accStock = new AccountStock();
                    accStock.AccountTransactionID = t.AccountTransactionID;
                    accStock.StockTransactionID = stockTrans.TransactionID;
                    t.AccTransactionStock.LstAccountStock.Add(accStock);
                }
            }
            if (accountTransactionTypeCode == enumAccountTransactionType.STOCKOUT.ToString())
            {
                
                foreach (StockTransaction stockTrans in lst)
                {
                    string tkKho = Account.ProductAccountTS;
                    if (stockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        Customer customerObj1 = null;
                        if (stockTrans.SaleRequestObj != null)
                            customerObj1 = new CustomerBLL().GetBySubjectCode(stockTrans.SaleRequestObj.CustomerCode);
                        if (customerObj1 != null)
                        {
                            if (customerObj1.ProductType.StartsWith("02."))
                                tkKho = Account.ProductAccountGS;
                            else if (customerObj1.ProductType.StartsWith("03."))
                                tkKho = Account.ProductAccountCV;
                            else
                                tkKho = Account.ProductAccountTS;
                            //tkKho = customerObj1.ProductType.StartsWith("02.") ? Account.ProductAccountGS : Account.ProductAccountTS;
                        }
                    }
                    stockTrans.Details = new StockTransactionBLL().GetDetailsByTransactionID(stockTrans.TransactionID);
                    foreach (StockTransactionSumDetail stockTransSumDetail in stockTrans.Details)
                    {
                        bool found = false;
                        foreach (AccountTransactionStockDetail accTransStockDetail in t.AccTransactionStock.Detail)
                        {
                            if (accTransStockDetail.ItemCode == stockTransSumDetail.ItemCode && accTransStockDetail.StockOutCode == stockTrans.OutStock)
                            {
                                found = true;
                                accTransStockDetail.Quantity += stockTransSumDetail.Quantity;
                                accTransStockDetail.Amount += stockTransSumDetail.AmountOut;
                                accTransStockDetail.CostAmount += stockTransSumDetail.AmountCost;
                                //t.AccTransactionStock.BeforeTaxAmount
                            }
                        }
                        if (!found)
                        {
                            AccountTransactionStockDetail accTransStockDetail1 = new AccountTransactionStockDetail();
                            if (stockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X1.ToString() || stockTransactionTypeCode.Substring(0, 2) == enumStockTransactionTypeKind.X3.ToString())
                            {
                                accTransStockDetail1.CreditAccountCode = Account.MaterialAccount;
                            }
                            else
                            {

                                accTransStockDetail1.CreditAccountCode = tkKho;// Account.ProductAccount;
                            }
                            accTransStockDetail1.StockOutCode = stockTrans.OutStock;
                            accTransStockDetail1.ItemCode = stockTransSumDetail.ItemCode;
                            accTransStockDetail1.Quantity = stockTransSumDetail.Quantity;
                            accTransStockDetail1.CostAmount = stockTransSumDetail.AmountCost;
                            accTransStockDetail1.Amount = stockTransSumDetail.AmountOut;
                            accTransStockDetail1.Price = stockTransSumDetail.PriceOut;
                            t.AccTransactionStock.Detail.Add(accTransStockDetail1);
                        }
                    }

                    AccountStock accStock = new AccountStock();
                    accStock.AccountTransactionID = t.AccountTransactionID;
                    accStock.StockTransactionID = stockTrans.TransactionID;
                    t.AccTransactionStock.LstAccountStock.Add(accStock);
                }
            }

            if (t.Detail1 == null) t.Detail1 = new ListBase<AccountTransactionDetail1>();
            if (t.Detail2 == null) t.Detail2 = new ListBase<AccountTransactionDetail2>();
            if (lst.Count > 0)
            {
               // Decimal toTalAmount = 0;
                if (stockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                {
                    if (t.Invoice == null) t.Invoice = new ListBase<Invoice>();
                    t.Invoice.Clear();

                    foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                    {
                        int len1 = Account.IncomeProductAccount.ToString().Length;
                        int len2 = Account.CustomerDeptAccount.ToString().Length;
                        if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                        {
                            if (accTransDetail2.CreditAccountCode.Substring(0,len1) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0,len2) == Account.CustomerDeptAccount.ToString())
                            {
                                accTransDetail2.Amount = 0;
                            }
                        }
                        len1 = Account.VATOutAccount.ToString().Length;
                        if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                        {
                            if (accTransDetail2.CreditAccountCode.Substring(0,len1) == Account.VATOutAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0,len2) == Account.CustomerDeptAccount.ToString())
                            {
                                accTransDetail2.Amount = 0;
                            }
                        }
                    }
                    foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                    {
                        int len1 = Account.IncomeProductAccount.ToString().Length;
                        int len2 = Account.VATOutAccount.ToString().Length;
                        if (accTransDetail1.AccountCode.Length >= len1)
                        {
                            if (accTransDetail1.AccountCode.Substring(0,len1) == Account.IncomeProductAccount.ToString())
                            {
                                accTransDetail1.CreditAmount = 0;
                            }
                        }
                        if (accTransDetail1.AccountCode.Length >= len2)
                        {
                            if (accTransDetail1.AccountCode.Substring(0,len2) == Account.VATOutAccount.ToString())
                            {
                                accTransDetail1.CreditAmount = 0;
                            }
                        }
                    }
                }
                Subject subjectObj1 = new SubjectBLL().GetBySubjectCode(t.SubjectCode1);
                //t.AccTransactionStock.BeforeTaxAmount = 0;
                //t.AccTransactionStock.TaxAmount = 0;
                //t.AccTransactionStock.InvoiceAmount = 0;
                //t.AccTransactionStock.DiscountAmount = 0;
                foreach (StockTransaction t1 in lst)
                {
                    if (t1.TransactionTypeCode == enumStockTransactionType.X21.ToString())
                    {
                        if (t1.SaleRequestObj == null)
                        {
                            t1.SaleRequestObj = new SaleRequestBLL().GetBySaleRequestNo(t1.SoDH);
                        }
                        if (t1.SaleRequestObj != null)
                        {
                            foreach (SaleRequestDetails srd in t1.SaleRequestObj.Details)
                            {
                                AccountTransactionStockDetail atsdSearchResult = t.AccTransactionStock.Detail.Search("ItemCode", srd.ItemCode);
                                if (atsdSearchResult != null)
                                {
                                    atsdSearchResult.Price = srd.SalePrice;
                                }
                            }
                            Subject subjectObj = new SubjectBLL().GetBySubjectCode(t1.SaleRequestObj.CustomerCode);
                            Invoice invoiceObj = new Invoice();
                            //t1.SaleRequestObj.PaymentType
                            invoiceObj.SoHoadon = t1.SaleRequestObj.InvoiceNo;
                            t.AccTransactionStock.InvoiceSo = t1.SaleRequestObj.InvoiceNo;
                            invoiceObj.NgayHoadon = t1.SaleRequestObj.InvoiceDate;
                            t.AccTransactionStock.InvoiceNgay = t1.SaleRequestObj.InvoiceDate;
                            t.AccTransactionStock.BeforeTaxAmount = t1.SaleRequestObj.BeforeTaxAmount;
                            t.AccTransactionStock.TaxAmount = t1.SaleRequestObj.TaxAmount;
                            t.AccTransactionStock.InvoiceAmount = t1.SaleRequestObj.InvoiceAmount;
                            t.AccTransactionStock.DiscountAmount = t1.SaleRequestObj.DiscountAmount;
                            if (t1.SaleRequestObj.DiscountAmount != 0)
                            {
                                t.AccTransactionStock.DiscountDescription = t1.SaleRequestObj.DiscountDescription;
                            }
                            t.AccTransactionStock.Giamgia = t1.SaleRequestObj.Giamgia;
                            t.AccTransactionStock.InvoiceMau = t1.SaleRequestObj.InvoiceMau;
                            t.AccTransactionStock.InvoiceSeri = t1.SaleRequestObj.InvoiceSeri;
                            t.AccTransactionStock.InvoiceSo = t1.SaleRequestObj.InvoiceNo;
                            t.AccTransactionStock.InvoiceThuexuat = t1.SaleRequestObj.TaxRate;
                            t.AccTransactionStock.PaymentType = t1.SaleRequestObj.PaymentType;
                             //t.AccTransactionStock.InvoiceNgay 
                           // t.AccTransactionStock.DonviCode = t1.SaleRequestObj.CustomerCode;
                            
                           // subjectObj1 = new SubjectBLL().GetBySubjectCode(t.SubjectCode1);
                            if (subjectObj1 != null)
                            {
                                invoiceObj.BranchCode = subjectObj1.BranchCode;
                            }
                            if (subjectObj != null)
                            {
                                invoiceObj.TenDonvi = subjectObj.SubjectName;
                                invoiceObj.Masothue = subjectObj.TaxCode;
                                t.AccTransactionStock.Donvi = subjectObj.SubjectName;
                                t.AccTransactionStock.DonviCode = subjectObj.SubjectCode;
                            }
                            invoiceObj.Thuexuat = t1.SaleRequestObj.TaxRate;
                            t.AccTransactionStock.InvoiceThuexuat = t1.SaleRequestObj.TaxRate;
                            invoiceObj.Tienthue = t1.SaleRequestObj.TaxAmount;
                            invoiceObj.Doanhso = t1.SaleRequestObj.BeforeTaxAmount;
                            //t.Invoice.Add(invoiceObj);//open this comment


                            if (t1.SaleRequestObj.DiscountAmount != 0)
                            {
                                int len1 = Account.SaleDiscountAccount.ToString().Length;
                                int len2 = Account.SaleProductDiscountAccount.ToString().Length;
                                int len3 = Account.IncomeProductAccount.ToString().Length;
                                
                                bool detail2NotFound = true;
                                bool detail1NotFound = true;
                                foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                                {
                                    if (t1.SaleRequestObj.Giamgia)
                                    {
                                        if (accTransDetail2.CreditAccountCode.Length>=len3 && accTransDetail2.DebitAccountCode.Length >= len1)
                                        {
                                            if (accTransDetail2.CreditAccountCode.Substring(0, len3) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len1) == Account.SaleDiscountAccount.ToString())
                                            {
                                                detail2NotFound = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (accTransDetail2.CreditAccountCode.Length >= len3 && accTransDetail2.DebitAccountCode.Length >= len2)
                                        {
                                            if (accTransDetail2.CreditAccountCode.Substring(0, len3) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0, len2) == Account.SaleProductDiscountAccount.ToString())
                                            {
                                                detail2NotFound = false;
                                            }
                                        }
                                    }
                                }
                                foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                                {
                                    if (t1.SaleRequestObj.Giamgia)
                                    {
                                        if (accTransDetail1.AccountCode.Length >= len1)
                                        {
                                            if (accTransDetail1.AccountCode.Substring(0, len1) == Account.SaleDiscountAccount.ToString())
                                            {
                                                detail1NotFound = false;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (accTransDetail1.AccountCode.Length >= len2)
                                        {
                                            if (accTransDetail1.AccountCode.Substring(0, len2) == Account.SaleProductDiscountAccount.ToString())
                                            {
                                                detail1NotFound = false;
                                            }
                                        }
                                    }
                                }
                                ListBase<Account> lstAccount = null;
                                if (detail2NotFound)
                                {
                                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                                    atd2.CreditAccountCode = Account.IncomeProductAccount;
                                    if (t1.SaleRequestObj.Giamgia)
                                    {
                                        atd2.DebitAccountCode = Account.SaleDiscountAccount;
                                        
                                    }
                                    else
                                    {
                                        atd2.DebitAccountCode = Account.SaleProductDiscountAccount;
                                    }
                                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd2.DebitAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                                    if (lstAccount.Count > 0 && subjectObj1 != null)
                                    {
                                        atd2.DebitClassificationCode = subjectObj1.BranchCode;
                                    }
                                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd2.CreditAccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                                    if (lstAccount.Count > 0 && subjectObj1 != null)
                                    {
                                        atd2.CreditClassificationCode = subjectObj1.BranchCode;
                                    }

                                    atd2.Amount = t1.SaleRequestObj.DiscountAmount;
                                    //t.Detail2.Add(atd2);//open this comment
                                }
                                if (detail1NotFound)
                                {
                                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                                    atd1.DebitAmount = t1.SaleRequestObj.DiscountAmount;
                                    if (t1.SaleRequestObj.Giamgia)
                                    {
                                        atd1.AccountCode = Account.SaleDiscountAccount;
                                    }
                                    else
                                    {
                                        atd1.AccountCode = Account.SaleProductDiscountAccount;
                                    }
                                    lstAccount = new AccountBLL().GetObjectDynamic(" AccountCode='" + atd1.AccountCode + "' and ClassificationTypeCode='" + enumClassificationTypeCode.BRANCH.ToString() + "' ", "");
                                    if (lstAccount.Count > 0 && subjectObj1 != null)
                                    {
                                        atd1.ClassificationCode = subjectObj1.BranchCode;
                                    }
                                    //t.Detail1.Add(atd1);//open this comment
                                }
                            }
                            //open this comment to Accounted (begin 1)
                            //foreach (AccountTransactionDetail2 accTransDetail2 in t.Detail2)
                            //{
                            //    int len1 = Account.IncomeProductAccount.ToString().Length;
                            //    int len2 = Account.CustomerDeptAccount.ToString().Length;
                            //    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                            //    {
                            //        if (accTransDetail2.CreditAccountCode.Substring(0,len1) == Account.IncomeProductAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0,len2) == Account.CustomerDeptAccount.ToString())
                            //        {
                            //            accTransDetail2.Amount += t1.SaleRequestObj.BeforeTaxAmount;
                            //            toTalAmount += t1.SaleRequestObj.BeforeTaxAmount;
                            //            accTransDetail2.DebitSubjectCode = t1.SaleRequestObj.CustomerCode;
                            //        }
                            //    }
                            //    len1 = Account.VATOutAccount.ToString().Length;
                            //    if (accTransDetail2.CreditAccountCode.Length >= len1 && accTransDetail2.DebitAccountCode.Length >= len2)
                            //    {
                            //        if (accTransDetail2.CreditAccountCode.Substring(0,len1) == Account.VATOutAccount.ToString() && accTransDetail2.DebitAccountCode.Substring(0,len2) == Account.CustomerDeptAccount.ToString())
                            //        {
                            //            accTransDetail2.Amount += t1.SaleRequestObj.TaxAmount;
                            //            toTalAmount += t1.SaleRequestObj.TaxAmount;
                            //            accTransDetail2.DebitSubjectCode = t1.SaleRequestObj.CustomerCode;
                            //        }
                            //    }
                            //}
                            //foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                            //{
                            //    int len1 = Account.IncomeProductAccount.Length;
                            //    int len2 = Account.VATOutAccount.Length;
                            //    int len3 = Account.CustomerDeptAccount.Length;
                            //    if (accTransDetail1.AccountCode.Length >= len1)
                            //    {
                            //        if (accTransDetail1.AccountCode.Substring(0,len1) == Account.IncomeProductAccount.ToString())
                            //        {
                            //            accTransDetail1.CreditAmount += t1.SaleRequestObj.BeforeTaxAmount+ t1.SaleRequestObj.DiscountAmount;
                            //        }
                            //    }
                            //    if (accTransDetail1.AccountCode.Length>= len2)
                            //    {
                            //        if (accTransDetail1.AccountCode.Substring(0,len2) == Account.VATOutAccount.ToString())
                            //        {
                            //            accTransDetail1.CreditAmount += t1.SaleRequestObj.TaxAmount;
                            //        }
                            //    }
                            //    if (accTransDetail1.AccountCode.Length >= len3)
                            //    {
                            //        if (accTransDetail1.AccountCode.Substring(0,len3) == Account.CustomerDeptAccount.ToString())
                            //        {
                            //            accTransDetail1.SubjectCode = t1.SaleRequestObj.CustomerCode;
                            //        }
                            //    }
                            //}
                            //open this comment to Accounted (end 1)
                        }
                    }
                }
                //open this comment to Accounted (begin 2)
                //if (stockTransactionTypeCode == enumStockTransactionType.X21.ToString())
                //{
                //    foreach (AccountTransactionDetail1 accTransDetail1 in t.Detail1)
                //    {
                //        int len1 = Account.CustomerDeptAccount.ToString().Length;
                //        if (accTransDetail1.AccountCode.Length >= len1)
                //        {
                //            if (accTransDetail1.AccountCode.Substring(0,len1) == Account.CustomerDeptAccount.ToString())
                //            {
                //                accTransDetail1.DebitAmount = toTalAmount;
                //            }
                //        }
                //    }
                //}
                //open this comment to Accounted (end 2)
            }
        }
        #region IBusiness member
        public int Insert(object obj)
        {
            return this.Insert(obj as AccountTransactionStockNew);
        }
        public int Update(object obj)
        {
            return this.Update(obj as AccountTransactionStockNew);
        }
        public int Delete(object obj)
        {
            return this.Delete(obj as AccountTransactionStockNew);
        }
        #endregion
    }
}
