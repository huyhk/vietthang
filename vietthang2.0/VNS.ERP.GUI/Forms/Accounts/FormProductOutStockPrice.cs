using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Windows.Forms;
using VNS.Common;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormProductOutStockPrice : FormEditBase
    {
        AccountStockPriceCostBLL AccStockPriceCostBLL = new AccountStockPriceCostBLL();
        PeriodBLL bll = new PeriodBLL();
        DataTable dt = null;
        Period periodObject = null;
        public FormProductOutStockPrice()
        {
            InitializeComponent();
            this.repTextEditNumDecimaln0.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            this.repTextEditNumDecimaln0.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            this.colOpenAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colInAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colOutAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colCloseAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.navigatorFrmEditBase.Visible = false;
            lookUpEditDate.Properties.DataSource = bll.GetAll();
            this.button1.Text = "Kết chuyển " + Account.OldProductAccount + ", " + Account.ProfitAccount;

            btnCancel.Click += new EventHandler(btnCancel_Click);
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            dt = AccStockPriceCostBLL.GetProductOutStockPrice(Convert.ToString(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnEdit.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            this.btnCancel.Visible = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            lookUpEditDate.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            colClosePrice.OptionsColumn.ReadOnly = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            btnCopy.Enabled = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            btnUpdate.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            this.button1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.INSERT;
            bool useNewAccounting = Account.UseNewStockAccounting(periodObject.StartDate);
            string productAccount = Account.GetProductAccount(periodObject.StartDate);
            VNS.Common.ListBase<AccountStockPriceCost> lst = new ListBase<AccountStockPriceCost>();
            foreach (DataRow dr in this.dt.Rows)
            {
                AccountStockPriceCost obj = new AccountStockPriceCost();
                obj.PeriodCode = periodObject.PeriodCode;
                //obj.AccountCode = Account.ProductAccount;
                if (useNewAccounting)
                    obj.AccountCode = productAccount;
                else if (dr["ProductType"].ToString() == "TS")
                    obj.AccountCode = Account.ProductAccountTS;
                else if (dr["ProductType"].ToString() == "GS")
                    obj.AccountCode = Account.ProductAccountGS;
                else if (dr["ProductType"].ToString() == "CV")
                    obj.AccountCode = Account.ProductAccountCV;
                //obj.AccountCode = dr["ProductType"].ToString() == "TS" ? Account.ProductAccountTS : Account.ProductAccountGS;// Account.ProductAccount;
                obj.ItemCode = dr["ItemCode"].ToString();
                obj.PriceCost = Convert.ToDecimal(dr["ClosePrice"]);
                lst.Add(obj);
            }
            int Error = new AccountStockPriceCostBLL().Insert(lst, periodObject.PeriodCode, productAccount);
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }

        private void lookUpEditDate_EditValueChanged(object sender, EventArgs e)
        {
            periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>).Search("PeriodCode", lookUpEditDate.EditValue.ToString());
            textEdit1.EditValue = Account.GetProductAccount(periodObject.StartDate);
            //periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
            dt = AccStockPriceCostBLL.GetProductOutStockPrice(Convert.ToString(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
            gridView1.RefreshData();
            gridView1.BestFitColumns();
            if (bll.SelectIsClosedFalse(enumModuleID.Accounting.ToString()).Search("PeriodCode", periodObject.PeriodCode) == null)
            {
                this.btnEdit.Enabled = false;
                btnUpdate.Enabled = false;
                this.button1.Enabled = false;
            }
            else
            {
                this.RefreshButtons();
            }
        }

        private void FormProductOutStockPrice_Load(object sender, EventArgs e)
        {
            try
            {
                lookUpEditDate.EditValue = Contexts.WorkingPeriod.PeriodCode;
            }
            catch
            {
            }
            this.RefreshButtons();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in this.dt.Rows)
            {
                dr.BeginEdit();
                dr["ClosePrice"] = dr["AvgPrice"];
                dr.EndEdit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this.GetTextMessage("ConfirmUpdateOutStockCostPriceProduct", "Chương trình sẽ cập nhật giá xuất thành phẩm bán. Bạn chắc không?"), "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                AccStockPriceCostBLL.UpdateOutStockCostPriceProduct(periodObject.PeriodCode);
                MessageBox.Show(this.GetTextMessage("FinishUpdateOutStockCostPriceProduct", "Đã cập nhật xong giá thành phẩm bán."));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            decimal d = new AccountTransactionStockNewBLL().SumCostAmountX21(this.periodObject.StartDate, this.periodObject.EndDate,"ProductTS");
            decimal d1 = new AccountTransactionStockNewBLL().SumCostAmountX21(this.periodObject.StartDate, this.periodObject.EndDate, "ProductGS");
            decimal dCV = new AccountTransactionStockNewBLL().SumCostAmountX21(this.periodObject.StartDate, this.periodObject.EndDate, "ProductCV");
            decimal d2 = new AccountTransactionStockNewBLL().SumCostAmountX21(this.periodObject.StartDate, this.periodObject.EndDate, "Material");
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Trong kỳ đã có phiếu kết chuyển thành phẩm bán!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển 6321, 911");
                    //f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTrans;
                    //f.StrSpecialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                    //Stock stockObj = new StockBLL().GetByMinSoHieu();
                    //if (stockObj != null)
                    //{
                    //    f.StrObject = stockObj.StockCode;
                    //}
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        f.EditItem();
                        AccountTransaction obj = lstAccTrans[0];
                        //if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                        //if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();

                        lstAccTrans[0].Invoice = new ListBase<Invoice>();
                        lstAccTrans[0].BuyNoInvoice = new ListBase<BuyNoInvoice>();
                        lstAccTrans[0].Detail2 = new ListBase<AccountTransactionDetail2>();
                        lstAccTrans[0].Detail1 = new ListBase<AccountTransactionDetail1>();
                        AccountTransactionDetail1 accDetail1 = new AccountTransactionDetail1();
                        accDetail1.AccountCode = Account.ProductAccount;
                        accDetail1.CreditAmount = d;
                        accDetail1.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                        lstAccTrans[0].Detail1.Add(accDetail1);
                        accDetail1 = new AccountTransactionDetail1();
                        accDetail1.AccountCode = Account.ProfitAccount;
                        accDetail1.DebitAmount = d;
                        accDetail1.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                        lstAccTrans[0].Detail1.Add(accDetail1);
                        if (d2 != 0)
                        {
                            accDetail1 = new AccountTransactionDetail1();
                            accDetail1.AccountCode = Account.ProductAccount;
                            accDetail1.CreditAmount = d2;
                            accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                            lstAccTrans[0].Detail1.Add(accDetail1);
                            accDetail1 = new AccountTransactionDetail1();
                            accDetail1.AccountCode = Account.ProfitAccount;
                            accDetail1.DebitAmount = d2;
                            accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                            lstAccTrans[0].Detail1.Add(accDetail1);
                        }

                        AccountTransactionDetail2 accDetail2 = new AccountTransactionDetail2();
                        accDetail2.CreditAccountCode = Account.ProductAccount;
                        accDetail2.DebitAccountCode = Account.ProfitAccount;
                        accDetail2.Amount = d;
                        accDetail2.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                        accDetail2.Description2 = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                        lstAccTrans[0].Detail2.Add(accDetail2);
                        if (d2 != 0)
                        {
                            accDetail2 = new AccountTransactionDetail2();
                            accDetail2.CreditAccountCode = Account.ProductAccount;
                            accDetail2.DebitAccountCode = Account.ProfitAccount;
                            accDetail2.Amount = d2;
                            accDetail2.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                            accDetail2.Description2 = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                            lstAccTrans[0].Detail2.Add(accDetail2);
                        }
                    }
                    f.ShowDialog();
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                {
                    if (MessageBox.Show(this.GetTextMessage("Warning-1", "Bạn có muốn xoá phiếu đi để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int iError = 0;
                        AccountTransactionBLL atbll = new AccountTransactionBLL();
                        iError = atbll.Delete(lstAccTrans);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu kết chuyển thành phẩm bán!"));
                            execNext = false;
                        }
                    }
                    else
                    {
                        execNext = false;
                    }
                }
            }
            if (execNext)
            {
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển 6321, 911");
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransaction>();
                //f.StrSpecialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                f.AddNewItem();
                AccountTransaction acc = f.CurrentItem as AccountTransaction;
                acc.SpecialType = enumAccountSpecialType.KETCHUYENXUATTHANHPHAMBAN.ToString();
                acc.AccountTransactionDate = this.periodObject.EndDate;
                acc.NgayCT = this.periodObject.EndDate;
                if (acc.Detail1 == null) acc.Detail1 = new ListBase<AccountTransactionDetail1>();
                if (acc.Detail2 == null) acc.Detail2 = new ListBase<AccountTransactionDetail2>();
                AccountTransactionDetail1 accDetail1 = new AccountTransactionDetail1();
                accDetail1.AccountCode = Account.ProductAccountTS;
                accDetail1.CreditAmount = d;
                accDetail1.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                acc.Detail1.Add(accDetail1);
                accDetail1 = new AccountTransactionDetail1();
                accDetail1.AccountCode = Account.ProfitAccount;
                accDetail1.DebitAmount = d;
                accDetail1.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                acc.Detail1.Add(accDetail1);
                if (d1 != 0)
                {
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProductAccountGS;
                    accDetail1.CreditAmount = d1;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProfitAccount;
                    accDetail1.DebitAmount = d1;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                }
                if (dCV != 0)
                {
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProductAccountCV;
                    accDetail1.CreditAmount = dCV;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProfitAccount;
                    accDetail1.DebitAmount = dCV;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                }
                if (d2 != 0)
                {
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProductAccount;
                    accDetail1.CreditAmount = d2;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                    accDetail1 = new AccountTransactionDetail1();
                    accDetail1.AccountCode = Account.ProfitAccount;
                    accDetail1.DebitAmount = d2;
                    accDetail1.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail1.Add(accDetail1);
                    //lstAccTrans[0].Detail1.Add(accDetail1);
                }
                AccountTransactionDetail2 accDetail2 = new AccountTransactionDetail2();
                accDetail2.CreditAccountCode = Account.ProductAccountTS;
                accDetail2.DebitAccountCode = Account.ProfitAccount;
                accDetail2.Amount = d;
                accDetail2.Description = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                accDetail2.Description2 = "Kết chuyển giá vốn thành phẩm xuất bán xđ kqkd trong kỳ";
                acc.Detail2.Add(accDetail2);
                if (d1 != 0)
                {
                    accDetail2 = new AccountTransactionDetail2();
                    accDetail2.CreditAccountCode = Account.ProductAccountGS;
                    accDetail2.DebitAccountCode = Account.ProfitAccount;
                    accDetail2.Amount = d1;
                    accDetail2.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    accDetail2.Description2 = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail2.Add(accDetail2);
                    //lstAccTrans[0].Detail2.Add(accDetail2);
                }
                if (dCV != 0)
                {
                    accDetail2 = new AccountTransactionDetail2();
                    accDetail2.CreditAccountCode = Account.ProductAccountCV;
                    accDetail2.DebitAccountCode = Account.ProfitAccount;
                    accDetail2.Amount = dCV;
                    accDetail2.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    accDetail2.Description2 = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail2.Add(accDetail2);
                    //lstAccTrans[0].Detail2.Add(accDetail2);
                }
                if (d2 != 0)
                {
                    accDetail2 = new AccountTransactionDetail2();
                    accDetail2.CreditAccountCode = Account.ProductAccount;
                    accDetail2.DebitAccountCode = Account.ProfitAccount;
                    accDetail2.Amount = d2;
                    accDetail2.Description = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    accDetail2.Description2 = "Kết chuyển giá vốn nguyên liệu xuất bán xđ kqkd trong kỳ";
                    acc.Detail2.Add(accDetail2);
                    //lstAccTrans[0].Detail2.Add(accDetail2);
                }
                f.ShowDialog();
            }
            //FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển 632, 911");
            //SetFormPrivilege(f);
            //f.DataSource = new ListBase<AccountTransaction>();
            //AccountTransaction acc = new AccountTransactionBLL().GetFor632911(this.periodObject.StartDate, this.periodObject.EndDate);
            //decimal d = new AccountTransactionStockNewBLL().SumCostAmountX21(this.periodObject.StartDate, this.periodObject.EndDate);
            //if (acc == null)
            //{
            //    f.AddNewItem();
            //    acc = f.CurrentItem as AccountTransaction;
            //    acc.AccountTransactionDate = this.periodObject.EndDate;
            //    acc.NgayCT = this.periodObject.EndDate;
            //    if (acc.Detail1 == null) acc.Detail1 = new ListBase<AccountTransactionDetail1>();
            //    if (acc.Detail2 == null) acc.Detail2 = new ListBase<AccountTransactionDetail2>();
            //    AccountTransactionDetail1 accDetail1 = new AccountTransactionDetail1();
            //    accDetail1.AccountCode = Account.ProductAccount;
            //    accDetail1.CreditAmount = d;
            //    acc.Detail1.Add(accDetail1);
            //    accDetail1 = new AccountTransactionDetail1();
            //    accDetail1.AccountCode = Account.ProfitAccount;
            //    accDetail1.DebitAmount = d;
            //    acc.Detail1.Add(accDetail1);
            //    AccountTransactionDetail2 accDetail2 = new AccountTransactionDetail2();
            //    accDetail2.CreditAccountCode = Account.ProductAccount;
            //    accDetail2.DebitAccountCode = Account.ProfitAccount;
            //    accDetail2.Amount = d;
            //    acc.Detail2.Add(accDetail2);

            //}
            //else
            //{
            //    acc.Invoice = new ListBase<Invoice>();
            //    acc.BuyNoInvoice = new ListBase<BuyNoInvoice>();
            //    if (acc.Detail2.Count > 0)
            //    {
            //        acc.Detail2[0].Amount = d;
            //    }
            //    if (acc.Detail1.Count > 0)
            //    {
            //        foreach (AccountTransactionDetail1 accDetail1 in acc.Detail1)
            //        {
            //            if (accDetail1.AccountCode == Account.ProfitAccount)
            //            {
            //                accDetail1.DebitAmount = d;
            //            }
            //            if (accDetail1.AccountCode == Account.ProductAccount)
            //            {
            //                accDetail1.CreditAmount = d;
            //            }
            //        }
            //    }
            //    (f.DataSource as ListBase<AccountTransaction>).Add(acc);
            //    f.CurrentItem = acc;
            //    f.EditItem();
            //}
            ////acc.Detail1.Add(
            //f.ShowDialog();
            //if ((f.DataSource as ListBase<AccountTransaction>).Count > 0)
            //{
            //    this.CurrentItem = f.CurrentItem;
            //}
            //else
            //{
            //    this.CurrentItem = null;
            //}
            //gridControl.RefreshDataSource();
        }
    }
}
