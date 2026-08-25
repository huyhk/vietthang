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
    public partial class FormKetChuyenCuoiKy : FormBase
    {
        PeriodBLL bll = new PeriodBLL();
        private Period periodObject = null;
        public FormKetChuyenCuoiKy()
        {
            InitializeComponent();
            btn6111152.Text = Account.OldMaterialAccount + "-" + Account.NewMaterialAccount;
            btn632155.Text = Account.OldProductAccount + "-" + Account.NewProductAccount;
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

        private void lookUpEditDate_EditValueChanged(object sender, EventArgs e)
        {
            this.periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
        }

        private bool CanTransferLegacyStockAccounts()
        {
            if (periodObject.EndDate.Date >= Account.StockAccountingEffectiveDate)
            {
                MessageBox.Show("Từ 01/01/2026 kho đã hạch toán trực tiếp vào " + Account.NewMaterialAccount + "/" + Account.NewProductAccount + ", không thực hiện kết chuyển tài khoản kho cuối kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btn6111152_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán!"));
                return;
            }
            if (!CanTransferLegacyStockAccounts()) return;
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENNGUYENLIEUCUOIKY.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Đã có phiếu kết chuyển nguyên liệu cuối kỳ!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển nguyên liệu cuối kỳ");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.EndDate;
                        //obj.NgayCT = this.periodObject.EndDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.OldMaterialAccount;
                        atd2.DebitAccountCode = Account.NewMaterialAccount;
                        decimal d = new AccountTransactionBLL().GetCloseAmount(Account.OldMaterialAccount, this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENNGUYENLIEUCUOIKY.ToString());
                        atd2.Amount = d;
                        obj.Detail2.Add(atd2);
                        AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.NewMaterialAccount;
                        atd1.DebitAmount = d;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.OldMaterialAccount;
                        atd1.CreditAmount = d;
                        obj.Detail1.Add(atd1);
                        f.EditItem();
                    }
                    f.ShowDialog();
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
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu kết chuyển nguyên liệu cuối kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển nguyên liệu cuối kỳ");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENNGUYENLIEUCUOIKY.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                atd2.CreditAccountCode = Account.OldMaterialAccount;
                atd2.DebitAccountCode = Account.NewMaterialAccount;
                decimal d = new AccountTransactionBLL().GetCloseAmount(Account.OldMaterialAccount, this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENNGUYENLIEUCUOIKY.ToString());
                atd2.Amount = d;
                obj.Detail2.Add(atd2);
                AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                atd1.AccountCode = Account.NewMaterialAccount;
                atd1.DebitAmount = d;
                obj.Detail1.Add(atd1);
                atd1 = new AccountTransactionDetail1();
                atd1.AccountCode = Account.OldMaterialAccount;
                atd1.CreditAmount = d;
                obj.Detail1.Add(atd1);
                f.ShowDialog();
            }
        }

        private void btn632155_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            if (!CanTransferLegacyStockAccounts()) return;
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-3", "Đã có phiếu kết chuyển thành phẩm cuối kỳ!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển thành phẩm cuối kỳ");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.OldProductAccount;
                        atd2.DebitAccountCode = Account.NewProductAccount;
                        decimal d = new AccountTransactionBLL().GetCloseAmount(Account.OldProductAccount, this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString());
                        atd2.Amount = d;
                        obj.Detail2.Add(atd2);
                        AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.NewProductAccount;
                        atd1.DebitAmount = d;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.OldProductAccount;
                        atd1.CreditAmount = d;
                        obj.Detail1.Add(atd1);
                        f.EditItem();
                    }
                    f.ShowDialog();
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
                            MessageBox.Show(this.GetTextMessage("Info-4", "Xoá không thành công, không thể tạo lại phiếu kết chuyển thành phẩm cuối kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển thành phẩm cuối kỳ");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                decimal amount = 0;
                decimal d = new AccountTransactionBLL().GetCloseAmount(Account.ProductAccountTS.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProductAccountTS.ToString();
                    atd2.DebitAccountCode = Account.NewProductAccount;

                    atd2.Amount = d;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProductAccountTS.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);

                    amount += d;
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.ProductAccountGS.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProductAccountGS.ToString();
                    atd2.DebitAccountCode = Account.NewProductAccount;

                    atd2.Amount = d;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProductAccountGS.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);

                    amount += d;
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.ProductAccountCV.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENTHANHPHAMCUOIKY.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProductAccountCV.ToString();
                    atd2.DebitAccountCode = Account.NewProductAccount;

                    atd2.Amount = d;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProductAccountCV.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);

                    amount += d;
                }

                AccountTransactionDetail1 atd11 = new AccountTransactionDetail1();
                atd11.AccountCode = Account.NewProductAccount;
                atd11.DebitAmount = amount;
                obj.Detail1.Add(atd11);
                
                f.ShowDialog();
            }
        }

        private void btnKetChuyenKQKD_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-5", "Đã có phiếu kết chuyển kết quả kinh doanh!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                    f.DataSource = lstAccTrans;
                    
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        decimal d = 0;

                        DataSet ds = accTransBLL.GetCloseAmount(this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                        d = accTransBLL.GetCloseAmount(Account.ProfitAccount.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new ListBase<AccountTransactionDetail2>();

                        AccountTransactionDetail2 atd2 = null;
                        AccountTransactionDetail1 atd1 = null;
                        
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            decimal amount = Convert.ToDecimal(dr["Amount"]);
                            d += amount;
                            //string accountCode = dr["AccountCode"].ToString();
                            //string materialExpense = Account.MaterialExpense.ToString();
                            //string labourProductionExpense = Account.LabourProductionExpense.ToString();
                            //string generalProductionExpense = Account.GeneralProductionExpense.ToString();
                            //string materialAccount = Account.MaterialAccount.ToString();
                            //string productAccount = Account.ProductAccount.ToString();

                            //if (accountCode.Length >= materialExpense.Length && accountCode.Substring(0, materialExpense.Length) == materialExpense)
                            //{
                            //    MessageBox.Show(this.GetTextMessage("MsgEditNotSuccess1", "Kết chuyển không thành công!"));
                            //    return;
                            //}
                            //if (accountCode.Length >= labourProductionExpense.Length && accountCode.Substring(0, labourProductionExpense.Length) == labourProductionExpense)
                            //{
                            //    MessageBox.Show(this.GetTextMessage("MsgEditNotSuccess2", "Kết chuyển không thành công"));
                            //    return;
                            //}
                            //if (accountCode.Length >= generalProductionExpense.Length && accountCode.Substring(0, generalProductionExpense.Length) == generalProductionExpense)
                            //{
                            //    MessageBox.Show(this.GetTextMessage("MsgEditNotSuccess3", "Kết chuyển không thành công"));
                            //    return;
                            //}
                            //if (accountCode.Length >= materialAccount.Length && accountCode.Substring(0, materialAccount.Length) == materialAccount)
                            //{
                            //    MessageBox.Show(this.GetTextMessage("MsgEditNotSuccess4", "Kết chuyển không thành công"));
                            //    return;
                            //}
                            //if (accountCode.Length >= productAccount.Length && accountCode.Substring(0, productAccount.Length) == productAccount)
                            //{
                            //    MessageBox.Show(this.GetTextMessage("MsgEditNotSuccess5", "Kết chuyển không thành công"));
                            //    return;
                            //}
                            if (amount > 0)
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = dr["AccountCode"].ToString();
                                atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                                atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                                atd2.Amount = amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.DebitAmount = amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.CreditAmount = amount;
                                obj.Detail1.Add(atd1);
                            }
                            else
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                                atd2.DebitAccountCode = dr["AccountCode"].ToString();
                                atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                                atd2.Amount = -amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.DebitAmount = -amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.CreditAmount = -amount;
                                obj.Detail1.Add(atd1);
                            }
                        }
                        if (d > 0)
                        {
                            atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                            atd2.DebitAccountCode = Account.ProfitAccount4211.ToString();
                            atd2.Amount = d;
                            obj.Detail2.Add(atd2);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount4211.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        if (d < 0)
                        {
                            atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ProfitAccount4211.ToString();
                            atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                            atd2.Amount = -d;
                            obj.Detail2.Add(atd2);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount.ToString();
                            atd1.DebitAmount = -d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount4211.ToString();
                            atd1.CreditAmount = -d;
                            obj.Detail1.Add(atd1);
                        }
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
                            MessageBox.Show(this.GetTextMessage("Info-6", "Xoá không thành công, không thể tạo lại phiếu kết chuyển kết quả kinh doanh!"));
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
                decimal d = 0;
                DataSet ds = accTransBLL.GetCloseAmount(this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                d = accTransBLL.GetCloseAmount(Account.ProfitAccount.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();

                AccountTransactionDetail2 atd2 = null;
                AccountTransactionDetail1 atd1 = null;
                
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    decimal amount = Convert.ToDecimal(dr["Amount"]);
                    d += amount;
                    //string accountCode = dr["AccountCode"].ToString();
                    //string materialExpense = Account.MaterialExpense.ToString();
                    //string labourProductionExpense = Account.LabourProductionExpense.ToString();
                    //string generalProductionExpense = Account.GeneralProductionExpense.ToString();
                    //string materialAccount = Account.MaterialAccount.ToString();
                    //string productAccount = Account.ProductAccount.ToString();

                    //if (accountCode.Length >= materialExpense.Length && accountCode.Substring(0, materialExpense.Length) == materialExpense)
                    //{
                    //    MessageBox.Show(this.GetTextMessage("MsgAddNotSuccess1", "Kết chuyển không thành công"));
                    //    return;
                    //}
                    //if (accountCode.Length >= labourProductionExpense.Length && accountCode.Substring(0, labourProductionExpense.Length) == labourProductionExpense)
                    //{
                    //    MessageBox.Show(this.GetTextMessage("MsgAddNotSuccess2", "Kết chuyển không thành công"));
                    //    return;
                    //}
                    //if (accountCode.Length >= generalProductionExpense.Length && accountCode.Substring(0, generalProductionExpense.Length) == generalProductionExpense)
                    //{
                    //    MessageBox.Show(this.GetTextMessage("MsgAddNotSuccess3", "Kết chuyển không thành công"));
                    //    return;
                    //}
                    //if (accountCode.Length >= materialAccount.Length && accountCode.Substring(0, materialAccount.Length) == materialAccount)
                    //{
                    //    MessageBox.Show(this.GetTextMessage("MsgAddNotSuccess4", "Kết chuyển không thành công"));
                    //    return;
                    //}
                    //if (accountCode.Length >= productAccount.Length && accountCode.Substring(0, productAccount.Length) == productAccount)
                    //{
                    //    MessageBox.Show(this.GetTextMessage("MsgAddNotSuccess5", "Kết chuyển không thành công"));
                    //    return;
                    //}
                    if (amount > 0)
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = dr["AccountCode"].ToString();
                        atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                        atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                        atd2.Amount = amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.DebitAmount = amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.CreditAmount = amount;
                        obj.Detail1.Add(atd1);
                    }
                    else
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                        atd2.DebitAccountCode = dr["AccountCode"].ToString();
                        atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                        atd2.Amount = -amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.DebitAmount = -amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.CreditAmount = -amount;
                        obj.Detail1.Add(atd1);
                    }
                }
                if (d > 0)
                {
                    atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                    atd2.DebitAccountCode = Account.ProfitAccount4211.ToString();
                    atd2.Amount = d;
                    obj.Detail2.Add(atd2);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount4211.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                if (d < 0)
                {
                    atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProfitAccount4211.ToString();
                    atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                    atd2.Amount = -d;
                    obj.Detail2.Add(atd2);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount.ToString();
                    atd1.DebitAmount = -d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount4211.ToString();
                    atd1.CreditAmount = -d;
                    obj.Detail1.Add(atd1);
                }
                f.ShowDialog();
            }
        }

        private void btn5911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("5");
        }
        private void KetChuyenKQKD(string prefixAccount)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString(), periodObject.StartDate, periodObject.EndDate, prefixAccount);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-5", "Phiếu kết chuyển này đã được thực hiện!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        DataSet ds = accTransBLL.GetCloseAmount5678(prefixAccount, this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                        AccountTransaction obj = lstAccTrans[0];
                        if (obj.Detail1 == null) obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new ListBase<AccountTransactionDetail2>();

                        AccountTransactionDetail2 atd2 = null;
                        AccountTransactionDetail1 atd1 = null;

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            decimal amount = Convert.ToDecimal(dr["Amount"]);

                            if (amount > 0)
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = dr["AccountCode"].ToString();
                                atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                                atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                                atd2.Amount = amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.DebitAmount = amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.CreditAmount = amount;
                                obj.Detail1.Add(atd1);
                            }
                            else
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                                atd2.DebitAccountCode = dr["AccountCode"].ToString();
                                atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                                atd2.Amount = -amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.DebitAmount = -amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.CreditAmount = -amount;
                                obj.Detail1.Add(atd1);
                            }
                        }
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
                            MessageBox.Show(this.GetTextMessage("Info-6", "Xoá không thành công, không thể tạo lại phiếu kết chuyển này này!"));
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
                DataSet ds = accTransBLL.GetCloseAmount5678(prefixAccount, this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString());
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();

                AccountTransactionDetail2 atd2 = null;
                AccountTransactionDetail1 atd1 = null;


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    decimal amount = Convert.ToDecimal(dr["Amount"]);

                    if (amount > 0)
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = dr["AccountCode"].ToString();
                        atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                        atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                        atd2.Amount = amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.DebitAmount = amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.CreditAmount = amount;
                        obj.Detail1.Add(atd1);
                    }
                    else
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                        atd2.DebitAccountCode = dr["AccountCode"].ToString();
                        atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                        atd2.Amount = -amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.DebitAmount = -amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.CreditAmount = -amount;
                        obj.Detail1.Add(atd1);
                    }
                }
                f.ShowDialog();
            }
        }
        private void KetChuyenKQKD(string prefixAccount, string specialType)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(specialType, periodObject.StartDate, periodObject.EndDate, prefixAccount);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-5", "Phiếu kết chuyển này đã được thực hiện!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        DataSet ds = accTransBLL.GetCloseAmount5678(prefixAccount, this.periodObject.StartDate, this.periodObject.EndDate, specialType);
                        AccountTransaction obj = lstAccTrans[0];
                        if (obj.Detail1 == null) obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new ListBase<AccountTransactionDetail2>();

                        AccountTransactionDetail2 atd2 = null;
                        AccountTransactionDetail1 atd1 = null;

                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            decimal amount = Convert.ToDecimal(dr["Amount"]);

                            if (amount > 0)
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = dr["AccountCode"].ToString();
                                atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                                atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                                atd2.Amount = amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.DebitAmount = amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.CreditAmount = amount;
                                obj.Detail1.Add(atd1);
                            }
                            else
                            {
                                atd2 = new AccountTransactionDetail2();
                                atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                                atd2.DebitAccountCode = dr["AccountCode"].ToString();
                                atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                                atd2.Amount = -amount;
                                obj.Detail2.Add(atd2);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = dr["AccountCode"].ToString();
                                atd1.SubjectCode = dr["SubjectCode"].ToString();
                                atd1.DebitAmount = -amount;
                                obj.Detail1.Add(atd1);
                                atd1 = new AccountTransactionDetail1();
                                atd1.AccountCode = Account.ProfitAccount.ToString();
                                atd1.CreditAmount = -amount;
                                obj.Detail1.Add(atd1);
                            }
                        }
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
                            MessageBox.Show(this.GetTextMessage("Info-6", "Xoá không thành công, không thể tạo lại phiếu kết chuyển này này!"));
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
                DataSet ds = accTransBLL.GetCloseAmount5678(prefixAccount, this.periodObject.StartDate, this.periodObject.EndDate, specialType);
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = specialType;
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();

                AccountTransactionDetail2 atd2 = null;
                AccountTransactionDetail1 atd1 = null;


                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    decimal amount = Convert.ToDecimal(dr["Amount"]);

                    if (amount > 0)
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = dr["AccountCode"].ToString();
                        atd2.CreditSubjectCode = dr["SubjectCode"].ToString();
                        atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                        atd2.Amount = amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.DebitAmount = amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.CreditAmount = amount;
                        obj.Detail1.Add(atd1);
                    }
                    else
                    {
                        atd2 = new AccountTransactionDetail2();
                        atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                        atd2.DebitAccountCode = dr["AccountCode"].ToString();
                        atd2.DebitSubjectCode = dr["SubjectCode"].ToString();
                        atd2.Amount = -amount;
                        obj.Detail2.Add(atd2);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = dr["AccountCode"].ToString();
                        atd1.SubjectCode = dr["SubjectCode"].ToString();
                        atd1.DebitAmount = -amount;
                        obj.Detail1.Add(atd1);
                        atd1 = new AccountTransactionDetail1();
                        atd1.AccountCode = Account.ProfitAccount.ToString();
                        atd1.CreditAmount = -amount;
                        obj.Detail1.Add(atd1);
                    }
                }
                f.ShowDialog();
            }
        }

        private void btn6911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("6");
        }

        private void btn7911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("7");
        }

        private void btn8911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("8");
        }

        private void btn9114211_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString(), periodObject.StartDate, periodObject.EndDate, "4");
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-5", "Phiếu kết chuyển này đã được thực hiện!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        decimal d = 0;
                        d = accTransBLL.GetCloseAmount(Account.ProfitAccount.ToString(), Account.ProfitAccount4211.ToString(), this.periodObject.StartDate, this.periodObject.EndDate);
                        AccountTransaction obj = lstAccTrans[0];
                        if (obj.Detail1 == null) obj.Detail1 = new ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new ListBase<AccountTransactionDetail2>();

                        AccountTransactionDetail2 atd2 = null;
                        AccountTransactionDetail1 atd1 = null;

                        if (d > 0)
                        {
                            atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                            atd2.DebitAccountCode = Account.ProfitAccount4211.ToString();
                            atd2.Amount = d;
                            obj.Detail2.Add(atd2);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount4211.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        if (d < 0)
                        {
                            atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ProfitAccount4211.ToString();
                            atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                            atd2.Amount = -d;
                            obj.Detail2.Add(atd2);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount.ToString();
                            atd1.DebitAmount = -d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ProfitAccount4211.ToString();
                            atd1.CreditAmount = -d;
                            obj.Detail1.Add(atd1);
                        }
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
                            MessageBox.Show(this.GetTextMessage("Info-6", "Xoá không thành công, không thể tạo lại phiếu kết chuyển này này!"));
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
                decimal d = 0;
                d = accTransBLL.GetCloseAmount(Account.ProfitAccount.ToString(), this.periodObject.StartDate, this.periodObject.EndDate);
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển kết quả kinh doanh");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENKQKINHDOANH.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();

                AccountTransactionDetail2 atd2 = null;
                AccountTransactionDetail1 atd1 = null;

                if (d > 0)
                {
                    atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProfitAccount.ToString();
                    atd2.DebitAccountCode = Account.ProfitAccount4211.ToString();
                    atd2.Amount = d;
                    obj.Detail2.Add(atd2);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount4211.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                if (d < 0)
                {
                    atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ProfitAccount4211.ToString();
                    atd2.DebitAccountCode = Account.ProfitAccount.ToString();
                    atd2.Amount = -d;
                    obj.Detail2.Add(atd2);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount.ToString();
                    atd1.DebitAmount = -d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ProfitAccount4211.ToString();
                    atd1.CreditAmount = -d;
                    obj.Detail1.Add(atd1);
                }
                f.ShowDialog();
            }
        }

        private void btn512511_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("", "Đã có phiếu kết chuyển doanh thu cuối kỳ!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển doanh thu cuối kỳ");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        decimal d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount521.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome511.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome511.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount521.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5211.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount5211.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome5111.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome5111.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount5211.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5212.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount5212.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome5112.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome5112.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount5212.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount52121.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount52121.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount52122.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount52122.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount52123.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount52123.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5213.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount5213.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome5113.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome5113.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount5213.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }

                        #region new
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount521121.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount521121.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount521122.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount521122.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.DiscountAccount521123.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.DiscountAccount521123.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }

                        d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.GoodReturnAccount52121.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.GoodReturnAccount52121.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.GoodReturnAccount52122.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.GoodReturnAccount52122.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                        if (d != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.GoodReturnAccount52123.ToString();
                            atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd2.Amount = d;

                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                            atd1.DebitAmount = d;
                            obj.Detail1.Add(atd1);
                            atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.GoodReturnAccount52123.ToString();
                            atd1.CreditAmount = d;
                            obj.Detail1.Add(atd1);
                        }
                        #endregion
                        
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
                            MessageBox.Show(this.GetTextMessage("Info-4", "Xoá không thành công, không thể tạo lại phiếu kết chuyển doanh thu cuối kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển doanh thu cuối kỳ");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                decimal d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount521.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome511.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome511.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount521.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5211.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount5211.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome5111.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome5111.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount5211.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5212.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount5212.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome5112.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome5112.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount5212.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }

                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount52121.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount52121.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount52122.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount52122.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount52123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount52123.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount52123.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount5213.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount5213.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome5113.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome5113.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount5213.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                #region new
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount521121.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount521121.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount521122.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount521122.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.DiscountAccount521123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.DiscountAccount521123.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.DiscountAccount521123.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }

                d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52121.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.GoodReturnAccount52121.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51121.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.GoodReturnAccount52121.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52122.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.GoodReturnAccount52122.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51122.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.GoodReturnAccount52122.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                d = new AccountTransactionBLL().GetCloseAmount(Account.GoodReturnAccount52123.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYENCHIETKHAU.ToString());
                if (d != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.GoodReturnAccount52123.ToString();
                    atd2.DebitAccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd2.Amount = d;

                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.SaveAndServiceIncome51123.ToString();
                    atd1.DebitAmount = d;
                    obj.Detail1.Add(atd1);
                    atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.GoodReturnAccount52123.ToString();
                    atd1.CreditAmount = d;
                    obj.Detail1.Add(atd1);
                }
                #endregion
                f.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("515", enumAccountSpecialType.KETCHUYENKQKINHDOANH515.ToString());
        }

        private void btn511911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("511", enumAccountSpecialType.KETCHUYENKQKINHDOANH511.ToString());
        }

        private void btn61134566212_Click(object sender, EventArgs e)
        {
            if (lookUpEditDate.ItemIndex == -1)
            {
                MessageBox.Show(this.GetTextMessage("PeriodNullError", "Bạn chưa chọn kỳ kế toán"));
                return;
            }
            bool execNext = true;
            AccountTransactionBLL accTransBLL = new AccountTransactionBLL();
            ListBase<AccountTransaction> lstAccTrans = accTransBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYEN611X_6212.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTrans.Count > 0)
            {
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("", "Đã có phiếu kết chuyển 6113,4,5,6,7 - 6212!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển 6113,4,5,6,7 - 6212");
                    f.DataSource = lstAccTrans;

                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransaction obj = lstAccTrans[0];
                        //obj.AccountTransactionDate = this.periodObject.StartDate;
                        //obj.NgayCT = this.periodObject.StartDate;
                        if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                        if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                        decimal d6113 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6113.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                        decimal d6212 = d6113;
                        if (d6113 != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ExpensesAccount6113.ToString();
                            atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                            atd2.Amount = d6113;
                            obj.Detail2.Add(atd2);

                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ExpensesAccount6113.ToString();
                            atd1.CreditAmount = d6113;
                            obj.Detail1.Add(atd1);
                        }
                        decimal d6114 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6114.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                        d6212 += d6114;
                        if (d6114 != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ExpensesAccount6114.ToString();
                            atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                            atd2.Amount = d6114;
                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ExpensesAccount6114.ToString();
                            atd1.CreditAmount = d6114;
                            obj.Detail1.Add(atd1);
                        }
                        decimal d6115 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6115.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                        d6212 += d6115;
                        if (d6115 != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ExpensesAccount6115.ToString();
                            atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                            atd2.Amount = d6115;
                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ExpensesAccount6115.ToString();
                            atd1.CreditAmount = d6115;
                            obj.Detail1.Add(atd1);
                        }
                        decimal d6116 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6116.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                        d6212 += d6116;
                        if (d6116 != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ExpensesAccount6116.ToString();
                            atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                            atd2.Amount = d6116;
                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ExpensesAccount6116.ToString();
                            atd1.CreditAmount = d6116;
                            obj.Detail1.Add(atd1);
                        }
                        decimal d6117 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6117.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                        d6212 += d6117;
                        if (d6117 != 0)
                        {
                            AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                            atd2.CreditAccountCode = Account.ExpensesAccount6117.ToString();
                            atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                            atd2.Amount = d6117;
                            obj.Detail2.Add(atd2);
                            AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                            atd1.AccountCode = Account.ExpensesAccount6117.ToString();
                            atd1.CreditAmount = d6117;
                            obj.Detail1.Add(atd1);
                        }
                        if (d6212 != 0)
                        {
                            AccountTransactionDetail1 atd11 = new AccountTransactionDetail1();
                            atd11.AccountCode = Account.ExpensesAccount6212.ToString();
                            atd11.DebitAmount = d6212;
                            obj.Detail1.Insert(0,atd11);
                        }
                        
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
                            MessageBox.Show(this.GetTextMessage("Info-4", "Xoá không thành công, không thể tạo lại phiếu kết chuyển doanh thu cuối kỳ!"));
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
                FormEditAccountTransaction f = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển 6113,4,5,6,7 - 6212");
                f.DataSource = new ListBase<AccountTransaction>();
                f.AddNewItem();
                AccountTransaction obj = f.CurrentItem as AccountTransaction;
                obj.SpecialType = enumAccountSpecialType.KETCHUYEN611X_6212.ToString();
                obj.AccountTransactionDate = this.periodObject.EndDate;
                obj.NgayCT = this.periodObject.EndDate;
                if (obj.Detail1 == null) obj.Detail1 = new VNS.Common.ListBase<AccountTransactionDetail1>();
                if (obj.Detail2 == null) obj.Detail2 = new VNS.Common.ListBase<AccountTransactionDetail2>();
                decimal d6113 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6113.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                decimal d6212 = d6113;
                if (d6113 != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ExpensesAccount6113.ToString();
                    atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                    atd2.Amount = d6113;
                    obj.Detail2.Add(atd2);

                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ExpensesAccount6113.ToString();
                    atd1.CreditAmount = d6113;
                    obj.Detail1.Add(atd1);
                }
                decimal d6114 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6114.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                d6212 += d6114;
                if (d6114 != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ExpensesAccount6114.ToString();
                    atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                    atd2.Amount = d6114;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ExpensesAccount6114.ToString();
                    atd1.CreditAmount = d6114;
                    obj.Detail1.Add(atd1);
                }
                decimal d6115 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6115.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                d6212 += d6115;
                if (d6115 != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ExpensesAccount6115.ToString();
                    atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                    atd2.Amount = d6115;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ExpensesAccount6115.ToString();
                    atd1.CreditAmount = d6115;
                    obj.Detail1.Add(atd1);
                }
                decimal d6116 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6116.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                d6212 += d6116;
                if (d6116 != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ExpensesAccount6116.ToString();
                    atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                    atd2.Amount = d6116;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ExpensesAccount6116.ToString();
                    atd1.CreditAmount = d6116;
                    obj.Detail1.Add(atd1);
                }
                decimal d6117 = new AccountTransactionBLL().GetCloseAmount(Account.ExpensesAccount6117.ToString(), this.periodObject.StartDate, this.periodObject.EndDate, enumAccountSpecialType.KETCHUYEN611X_6212.ToString());
                d6212 += d6117;
                if (d6117 != 0)
                {
                    AccountTransactionDetail2 atd2 = new AccountTransactionDetail2();
                    atd2.CreditAccountCode = Account.ExpensesAccount6117.ToString();
                    atd2.DebitAccountCode = Account.ExpensesAccount6212.ToString();
                    atd2.Amount = d6117;
                    obj.Detail2.Add(atd2);
                    AccountTransactionDetail1 atd1 = new AccountTransactionDetail1();
                    atd1.AccountCode = Account.ExpensesAccount6117.ToString();
                    atd1.CreditAmount = d6117;
                    obj.Detail1.Add(atd1);
                }
                if (d6212 != 0)
                {
                    AccountTransactionDetail1 atd11 = new AccountTransactionDetail1();
                    atd11.AccountCode = Account.ExpensesAccount6212.ToString();
                    atd11.DebitAmount = d6212;
                    obj.Detail1.Insert(0,atd11);
                }
                f.ShowDialog();
            }
        }

        private void btn635911_Click(object sender, EventArgs e)
        {
            //this.KetChuyenKQKD("635");
            this.KetChuyenKQKD("635", enumAccountSpecialType.KETCHUYENKQKINHDOANH635.ToString());
        }

        private void btn641911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("641", enumAccountSpecialType.KETCHUYENKQKINHDOANH641.ToString());
        }

        private void btn642911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("642", enumAccountSpecialType.KETCHUYENKQKINHDOANH642.ToString());
        }

        private void btn8211911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("8211", enumAccountSpecialType.KETCHUYENKQKINHDOANH8211.ToString());
        }

        private void btn8212911_Click(object sender, EventArgs e)
        {
            this.KetChuyenKQKD("8212", enumAccountSpecialType.KETCHUYENKQKINHDOANH8212.ToString());
        }
    }
}
