using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VNS.Windows.Forms;
using VNS.ERP.Data;
using VNS.ERP.Data.Accounting;
using VNS.Common;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormKetChuyenDauKy : FormBase
    {
        PeriodBLL bll = new PeriodBLL();
        private Period periodObject = null;
        public FormKetChuyenDauKy()
        {
            InitializeComponent();
            lookUpEditDate.Properties.DataSource = bll.SelectIsClosedFalse(enumModuleID.Accounting.ToString());
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            try
            {
                lookUpEditDate.EditValue = Contexts.WorkingPeriod.EndDate;
            }
            catch
            {
            }
        }
        private void btn1526111_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán!"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENNGUYENLIEUDAUKY.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Đã có phiếu kết chuyển nguên liệu đầu kỳ!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển nguyên liệu đầu kỳ");
                    f.DataSource = lstAccTrans;
                    
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.MaterialAccount152.ToString();
                        atd2.DebitAccountCode = Account.MaterialAccount.ToString();
                        decimal d = new AccountOpeningBLL().GetOpenAmount(Account.MaterialAccount152.ToString(), this.periodObject.PeriodCode);
                        atd2.Amount = d;
                        obj.Detail2.Add(atd2);
                        AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.MaterialAccount.ToString();
                        atd1.DebitAmount = d;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.MaterialAccount152.ToString();
                        atd1.CreditAmount = d;
                        obj.Detail1.Add(atd1);
                        f.EditItem();
                    }
                    f.Show();
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                {
                    if (MessageBox.Show(this.GetTextMessage("Warning-3", "Bạn có muốn xoá phiếu đi để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int iError = 0;
                        AccountTransactionBLL atbll = new AccountTransactionBLL();
                        iError = atbll.Delete(lstAccTrans);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu kết chuyển nguyên liệu đầu kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển nguyên liệu đầu kỳ");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENNGUYENLIEUDAUKY.ToString();
                obj.AccountTransactionDate = this.periodObject.StartDate;
                obj.NgayCT = this.periodObject.StartDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                atd2.CreditAccountCode = Account.MaterialAccount152.ToString();
                atd2.DebitAccountCode = Account.MaterialAccount.ToString();
                decimal d = new AccountOpeningBLL().GetOpenAmount(Account.MaterialAccount152.ToString(), this.periodObject.PeriodCode);
                atd2.Amount = d;
                obj.Detail2.Add(atd2);
                AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                atd1.AccountCode = Account.MaterialAccount.ToString();
                atd1.DebitAmount = d;
                obj.Detail1.Add(atd1);
                atd1 = new AccountTransactionDetail1();
                atd1.AccountCode = Account.MaterialAccount152.ToString();
                atd1.CreditAmount = d;
                obj.Detail1.Add(atd1);
                f.Show();
            }
        }

        private void lookUpEditDate_EditValueChanged(object sender, EventArgs e)
        {
            this.periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
        }

        private void btn155632_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENTHANHPHAMDAUKY.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-3", "Đã có phiếu kết chuyển thành phẩm đầu kỳ!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển thành phẩm đầu kỳ");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.ProductAccount155.ToString();
                        atd2.DebitAccountCode = Account.ProductAccount.ToString();
                        decimal d = new AccountOpeningBLL().GetOpenAmount(Account.ProductAccount155.ToString(), this.periodObject.PeriodCode);
                        atd2.Amount = d;
                        obj.Detail2.Add(atd2);
                        AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProductAccount.ToString();
                        atd1.DebitAmount = d;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProductAccount155.ToString();
                        atd1.CreditAmount = d;
                        obj.Detail1.Add(atd1);
                        f.EditItem();
                    }
                    f.Show();
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                {
                    if (MessageBox.Show(this.GetTextMessage("Warning-3", "Bạn có muốn xoá phiếu đi để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int iError = 0;
                        AccountTransactionBLL atbll = new AccountTransactionBLL();
                        iError = atbll.Delete(lstAccTrans);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-4", "Xoá không thành công, không thể tạo lại phiếu kết chuyển thành phẩm đầu kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển thành phẩm đầu kỳ");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENTHANHPHAMDAUKY.ToString();
                obj.AccountTransactionDate = this.periodObject.StartDate;
                obj.NgayCT = this.periodObject.StartDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                
                DataTable dt = new AccountReportBLL().GetAccountStockOpen(this.periodObject.PeriodCode, Account.ProductAccount);
                decimal amount = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string accountCode = row["AccountCode"].ToString();
                    decimal openingAmount = (decimal)row["OpeningAmount"];
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProductAccount155.ToString();
                    atd2.DebitAccountCode = accountCode;
                    atd2.Amount = openingAmount;
                    obj.Detail2.Add(atd2);

                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = accountCode;
                    atd1.DebitAmount = openingAmount;
                    obj.Detail1.Add(atd1);

                    amount += (decimal)row["OpeningAmount"]; ;
                }

                AccountTransactionDetail1 atd1a = new AccountTransactionDetail1();
                atd1a.AccountCode = Account.ProductAccount155;
                atd1a.CreditAmount = amount;
                obj.Detail1.Add(atd1a);
 
                f.Show();
            }
        }
    }
}