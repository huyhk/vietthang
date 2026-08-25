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
    public partial class FormAccountInventoryMaterial : FormEditBase
    {
        PeriodBLL bll = new PeriodBLL();
        DataTable dt = null;
        Period periodObject = null;
        public FormAccountInventoryMaterial()
        {
            InitializeComponent();
            this.navigatorFrmEditBase.Visible = false;
            lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
            if ((lookUpStockCode.Properties.DataSource as ListBase<Stock>).Count > 0)
            {
                lookUpStockCode.ItemIndex = 0;
            }
            lookUpEditDate.Properties.DataSource = bll.GetAll();
           
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            dt = new AccountStockOpeningsBLL().GetInventoryMaterial(Convert.ToDateTime(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
        }
        public override void RefreshButtons()
        {
            base.RefreshButtons();
            this.btnEdit.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            this.btnCancel.Visible = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            lookUpEditDate.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            colInventory.OptionsColumn.ReadOnly = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            btnCopy.Enabled = this.EditMode != VNS.Windows.FormEditMode.VIEW;
            btnFuel.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
            btnMaterial.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
        private void lookUpEditDate_EditValueChanged(object sender, EventArgs e)
        {
            periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
            dt=new AccountStockOpeningsBLL().GetInventoryMaterial(Convert.ToDateTime(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
            gridView1.ExpandAllGroups();
            if (bll.SelectIsClosedFalse(enumModuleID.Accounting.ToString()).Search("PeriodCode", periodObject.PeriodCode) == null)
            {
                this.btnEdit.Enabled = false;
                btnFuel.Enabled = false;
                btnMaterial.Enabled = false;
            }
            else
            {
                this.RefreshButtons();
            }
        }
        protected override bool SaveData()
        {

            Period periodNextObj = bll.SelectObjectLastMonthSpecify(periodObject.EndDate);

            if (periodNextObj != null)
            {
                ErrorMessageType messageType = ErrorMessageType.INSERT;
                string materialAccount = Account.GetMaterialAccount(periodNextObj.StartDate);
                VNS.Common.ListBase<AccountStockOpenings> lst = new VNS.Common.ListBase<AccountStockOpenings>();
                foreach (DataRow dr in dt.Rows)
                {
                    AccountStockOpenings obj = new AccountStockOpenings();
                    obj.PeriodCode = periodNextObj.PeriodCode;
                    obj.AccountCode = materialAccount;
                    obj.ItemCode = dr["ItemCode"].ToString();
                    obj.StockCode = dr["StockCode"].ToString();
                    obj.Quantity = Convert.ToDecimal(dr["Inventory"]);
                    if (obj.Quantity != 0)
                    {
                        lst.Add(obj);
                    }
                }
                int Error = new AccountStockOpeningsBLL().Insert(lst, periodNextObj.PeriodCode, materialAccount);
                if (Error != 0)
                {
                    OnError(Error, messageType);
                    return false;
                }
            }
            return base.SaveData();
        }

        private void FormAccountInventoryMaterial_Load(object sender, EventArgs e)
        {
            if ((lookUpStockCode.Properties.DataSource as ListBase<Stock>).Count > 0)
            {
                lookUpStockCode.ItemIndex = 0;
            }
            try
            {
                lookUpEditDate.EditValue = Contexts.WorkingPeriod.EndDate;
            }
            catch
            {
            }
            this.RefreshButtons();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("StockCreatTransactionNullError", "Chưa chọn kho để tạo phiếu!"));
                return;
            }
            AccountTransactionStockNewBLL accTransStockNewBLL = new AccountTransactionStockNewBLL();
            ListBase<AccountTransactionStockNew> lstAccTransStockNew = accTransStockNewBLL.SelectBySpecialTypeStockCodeAndDate(enumAccountSpecialType.XUATNGUYENLIEUSX.ToString(), lookUpStockCode.EditValue.ToString(), periodObject.StartDate, periodObject.EndDate);
            //ListBase<AccountTransaction> lst = new AccountTransactionBLL().GetByStockTransTypeAndDate(enumAccountTransactionType.STOCKOUT.ToString(), enumStockTransactionType.X11.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTransStockNew.Count > 0)
            {
                foreach (AccountTransactionStockNew accTransStockNew in lstAccTransStockNew)
                {
                    accTransStockNew.AccTransactionStock = accTransStockNewBLL.SelectAccTransStockByAccountTransactionID(accTransStockNew.AccountTransactionID);
                }
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Trong kỳ đã có phiếu xuất nguyên liệu sản xuất!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                    f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTransStockNew;
                    //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                    //Stock stockObj = new StockBLL().GetByMinSoHieu();
                    //if (stockObj != null)
                    //{
                    //    f.StrObject = stockObj.StockCode;
                    //}
                    f.StrObject = lookUpStockCode.EditValue.ToString();
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransactionStockNew obj = lstAccTransStockNew[0];
                        if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                        if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                        obj.AccTransactionStock.Detail.Clear();
                        if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                        foreach (DataRow dr in this.dt.Rows)
                        {
                            string stockCode = dr["StockCode"].ToString();
                            decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                            if (Convert.ToInt16(dr["ItemType"]) != (Int16)enumItemType.Fuel && delta != 0 && stockCode == lookUpStockCode.EditValue.ToString())
                            {
                                AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                                objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                                objDetail.Quantity = delta;
                                objDetail.StockOutCode = stockCode;
                                objDetail.ItemCode = dr["ItemCode"].ToString();
                                obj.AccTransactionStock.Detail.Add(objDetail);
                            }
                        }
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
                        AccountTransactionStockNewBLL atsnbll = new AccountTransactionStockNewBLL();
                        iError = atsnbll.Delete(lstAccTransStockNew);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu xuất nguyên liệu sản xuất!"));
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
                FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                //Stock stockObj = new StockBLL().GetByMinSoHieu();
                //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                //if (stockObj != null)
                //{
                //    f.StrObject = lookUpStockCode.EditValue.ToString();
                //}
                f.StrObject = lookUpStockCode.EditValue.ToString();
                f.AddNewItem();
                AccountTransactionStockNew obj = f.CurrentItem as AccountTransactionStockNew;
                obj.SpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                obj.AccountTransactionTypeCode = enumAccountTransactionType.STOCKOUT.ToString();
                obj.AccTransactionStock.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                obj.AccountTransactionDate = periodObject.EndDate;
                obj.NgayCT = periodObject.EndDate;
                obj.AccTransactionStock.StockTransactionDate = periodObject.EndDate;

                if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                //if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                obj.AccTransactionStock.Tenkho = lookUpStockCode.GetColumnValue("StockName").ToString();
                foreach (DataRow dr in this.dt.Rows)
                {
                    decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                    string stockCode = dr["StockCode"].ToString();
                    if (Convert.ToInt16(dr["ItemType"]) != (Int16)enumItemType.Fuel && delta != 0 && stockCode == f.StrObject && Convert.ToInt16(dr["ItemType"]) != (Int16)enumItemType.WrappingMaterial)
                    {
                        //obj.AccTransactionStock.Tenkho = dr["StockName"].ToString();
                        //if (obj.AccTransactionStock.Tenkho.IndexOf(dr["StockName"].ToString()) < 0)
                        //{
                        //    if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho += ", ";
                        //    obj.AccTransactionStock.Tenkho += dr["StockName"].ToString();
                        //}
                        AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                        objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                        objDetail.Quantity = delta;
                        objDetail.StockOutCode = stockCode;
                        objDetail.ItemCode = dr["ItemCode"].ToString();
                        obj.AccTransactionStock.Detail.Add(objDetail);
                    }
                }

                f.ShowDialog();
            }

        }

        private void btnFuel_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("StockCreatTransactionNullError", "Chưa chọn kho để tạo phiếu!"));
                return;
            }
            AccountTransactionStockNewBLL accTransStockNewBLL = new AccountTransactionStockNewBLL();
            ListBase<AccountTransactionStockNew> lstAccTransStockNew = accTransStockNewBLL.SelectBySpecialTypeStockCodeAndDate(enumAccountSpecialType.XUATNHIENLIEUSX.ToString(), lookUpStockCode.EditValue.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTransStockNew.Count > 0)
            {
                foreach (AccountTransactionStockNew accTransStockNew in lstAccTransStockNew)
                {
                    accTransStockNew.AccTransactionStock = accTransStockNewBLL.SelectAccTransStockByAccountTransactionID(accTransStockNew.AccountTransactionID);
                }
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-3", "Trong kỳ đã có phiếu xuất nhiên liệu sản xuất!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                    f.StockTransactionTypeCode = enumStockTransactionType.X31.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTransStockNew;
                   // f.StrSpecialType = enumAccountSpecialType.XUATNHIENLIEUSX.ToString();
                    //Stock stockObj = new StockBLL().GetByMinSoHieu();
                    //if (stockObj != null)
                    //{
                    //    f.StrObject = stockObj.StockCode;
                    //}
                    f.StrObject = lookUpStockCode.EditValue.ToString();
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransactionStockNew obj = lstAccTransStockNew[0];
                        if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                        if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                        obj.AccTransactionStock.Detail.Clear();
                        if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                        foreach (DataRow dr in this.dt.Rows)
                        {
                            string stockCode = dr["StockCode"].ToString();
                            decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                            if (Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.Fuel && delta != 0 && stockCode == lookUpStockCode.EditValue.ToString())
                            {
                                AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                                objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                                objDetail.Quantity = delta;
                                objDetail.StockOutCode = stockCode;
                                objDetail.ItemCode = dr["ItemCode"].ToString();
                                obj.AccTransactionStock.Detail.Add(objDetail);
                            }
                        }
                        f.EditItem();
                    }
                    f.ShowDialog();
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                {
                    if (MessageBox.Show(this.GetTextMessage("Warning-4", "Bạn có muốn xoá phiếu đi để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int iError = 0;
                        AccountTransactionStockNewBLL atsnbll = new AccountTransactionStockNewBLL();
                        iError = atsnbll.Delete(lstAccTransStockNew);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-4", "Xoá không thành công, không thể tạo lại phiếu xuất nhiên liệu sản xuất!"));
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
                FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                f.StockTransactionTypeCode = enumStockTransactionType.X31.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                //f.StrSpecialType = enumAccountSpecialType.XUATNHIENLIEUSX.ToString();
               // Stock stockObj = new StockBLL().GetByMinSoHieu();
                //if (stockObj != null)
                //{
                //    f.StrObject = stockObj.StockCode;
                //}
                f.StrObject = lookUpStockCode.EditValue.ToString();
                f.AddNewItem();
                AccountTransactionStockNew obj = f.CurrentItem as AccountTransactionStockNew;
                if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                obj.AccountTransactionTypeCode = enumAccountTransactionType.STOCKOUT.ToString();
                obj.SpecialType = enumAccountSpecialType.XUATNHIENLIEUSX.ToString();
                obj.AccTransactionStock.StockTransactionTypeCode = enumStockTransactionType.X31.ToString();
                obj.AccountTransactionDate = periodObject.EndDate;
                obj.NgayCT = periodObject.EndDate;
                obj.AccTransactionStock.StockTransactionDate = periodObject.EndDate;

                if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
               // if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                obj.AccTransactionStock.Tenkho = lookUpStockCode.GetColumnValue("StockName").ToString();
                foreach (DataRow dr in this.dt.Rows)
                {
                    string stockCode = dr["StockCode"].ToString();
                    decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                    if (Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.Fuel && delta != 0 && stockCode == f.StrObject)
                    {
                        //if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho = dr["StockName"].ToString();
                        //if (obj.AccTransactionStock.Tenkho.IndexOf(dr["StockName"].ToString()) < 0)
                        //{
                        //    if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho += ", ";
                        //    obj.AccTransactionStock.Tenkho += dr["StockName"].ToString();
                        //}
                        AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                        objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                        objDetail.Quantity = delta;
                        objDetail.StockOutCode = stockCode;
                        objDetail.ItemCode = dr["ItemCode"].ToString();
                        obj.AccTransactionStock.Detail.Add(objDetail);
                    }
                }
                f.ShowDialog();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in this.dt.Rows)
            {
                dr.BeginEdit();
                dr["Inventory"] = dr["QuantityStock"];
                dr.EndEdit();
            }
        }

        private void btnWrappingMaterial_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("StockCreatTransactionNullError", "Chưa chọn kho để tạo phiếu!"));
                return;
            }
            AccountTransactionStockNewBLL accTransStockNewBLL = new AccountTransactionStockNewBLL();
            ListBase<AccountTransactionStockNew> lstAccTransStockNew = accTransStockNewBLL.SelectBySpecialTypeStockCodeAndDate(enumAccountSpecialType.XUATBBNLSX.ToString(), lookUpStockCode.EditValue.ToString(), periodObject.StartDate, periodObject.EndDate);
            //ListBase<AccountTransaction> lst = new AccountTransactionBLL().GetByStockTransTypeAndDate(enumAccountTransactionType.STOCKOUT.ToString(), enumStockTransactionType.X11.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTransStockNew.Count > 0)
            {
                foreach (AccountTransactionStockNew accTransStockNew in lstAccTransStockNew)
                {
                    accTransStockNew.AccTransactionStock = accTransStockNewBLL.SelectAccTransStockByAccountTransactionID(accTransStockNew.AccountTransactionID);
                }
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Trong kỳ đã có phiếu xuất nguyên liệu sản xuất!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                    f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTransStockNew;
                    //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                    //Stock stockObj = new StockBLL().GetByMinSoHieu();
                    //if (stockObj != null)
                    //{
                    //    f.StrObject = stockObj.StockCode;
                    //}
                    f.StrObject = lookUpStockCode.EditValue.ToString();
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransactionStockNew obj = lstAccTransStockNew[0];
                        if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                        if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                        obj.AccTransactionStock.Detail.Clear();
                        if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                        foreach (DataRow dr in this.dt.Rows)
                        {
                            string stockCode = dr["StockCode"].ToString();
                            decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                            if (Convert.ToInt16(dr["ItemType"]) != (Int16)enumItemType.Fuel && delta != 0 && stockCode == lookUpStockCode.EditValue.ToString())
                            {
                                AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                                objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                                objDetail.Quantity = delta;
                                objDetail.StockOutCode = stockCode;
                                objDetail.ItemCode = dr["ItemCode"].ToString();
                                obj.AccTransactionStock.Detail.Add(objDetail);
                            }
                        }
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
                        AccountTransactionStockNewBLL atsnbll = new AccountTransactionStockNewBLL();
                        iError = atsnbll.Delete(lstAccTransStockNew);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu xuất nguyên liệu sản xuất!"));
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
                FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                //Stock stockObj = new StockBLL().GetByMinSoHieu();
                //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                //if (stockObj != null)
                //{
                //    f.StrObject = lookUpStockCode.EditValue.ToString();
                //}
                f.StrObject = lookUpStockCode.EditValue.ToString();
                f.AddNewItem();
                AccountTransactionStockNew obj = f.CurrentItem as AccountTransactionStockNew;
                obj.SpecialType = enumAccountSpecialType.XUATBBNLSX.ToString();
                if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                obj.AccountTransactionTypeCode = enumAccountTransactionType.STOCKOUT.ToString();
                obj.AccTransactionStock.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                obj.AccountTransactionDate = periodObject.EndDate;
                obj.NgayCT = periodObject.EndDate;
                obj.AccTransactionStock.StockTransactionDate = periodObject.EndDate;

                if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                //if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                obj.AccTransactionStock.Tenkho = lookUpStockCode.GetColumnValue("StockName").ToString();
                foreach (DataRow dr in this.dt.Rows)
                {
                    decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                    string stockCode = dr["StockCode"].ToString();
                    if (delta != 0 && stockCode == f.StrObject && Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.WrappingMaterial && !dr["ItemCode"].ToString().StartsWith("04.BAOPE"))
                    {
                        //obj.AccTransactionStock.Tenkho = dr["StockName"].ToString();
                        //if (obj.AccTransactionStock.Tenkho.IndexOf(dr["StockName"].ToString()) < 0)
                        //{
                        //    if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho += ", ";
                        //    obj.AccTransactionStock.Tenkho += dr["StockName"].ToString();
                        //}
                        AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                        objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                        objDetail.Quantity = delta;
                        objDetail.StockOutCode = stockCode;
                        objDetail.ItemCode = dr["ItemCode"].ToString();
                        obj.AccTransactionStock.Detail.Add(objDetail);
                    }
                }
                if (obj.Detail2.Count > 0)
                    obj.Detail2[0].DebitAccountCode = "6212";
                new AccountTransactionBLL().RefeshDetail1(obj);
                f.ShowDialog();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Excel file|*.xls";
            s.OverwritePrompt = true;
            if (s.ShowDialog() == DialogResult.OK)
            {

                this.gridView1.ExportToXls(s.FileName);
            }
        }

        private void btnWrappingPE_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("StockCreatTransactionNullError", "Chưa chọn kho để tạo phiếu!"));
                return;
            }
            AccountTransactionStockNewBLL accTransStockNewBLL = new AccountTransactionStockNewBLL();
            ListBase<AccountTransactionStockNew> lstAccTransStockNew = accTransStockNewBLL.SelectBySpecialTypeStockCodeAndDate(enumAccountSpecialType.XUATBBPE.ToString(), lookUpStockCode.EditValue.ToString(), periodObject.StartDate, periodObject.EndDate);
            //ListBase<AccountTransaction> lst = new AccountTransactionBLL().GetByStockTransTypeAndDate(enumAccountTransactionType.STOCKOUT.ToString(), enumStockTransactionType.X11.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTransStockNew.Count > 0)
            {
                foreach (AccountTransactionStockNew accTransStockNew in lstAccTransStockNew)
                {
                    accTransStockNew.AccTransactionStock = accTransStockNewBLL.SelectAccTransStockByAccountTransactionID(accTransStockNew.AccountTransactionID);
                }
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Trong kỳ đã có phiếu xuất nguyên liệu sản xuất!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                    f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTransStockNew;
                    //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                    //Stock stockObj = new StockBLL().GetByMinSoHieu();
                    //if (stockObj != null)
                    //{
                    //    f.StrObject = stockObj.StockCode;
                    //}
                    f.StrObject = lookUpStockCode.EditValue.ToString();
                    if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit)
                    {
                        AccountTransactionStockNew obj = lstAccTransStockNew[0];
                        if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                        if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                        obj.AccTransactionStock.Detail.Clear();
                        if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                        foreach (DataRow dr in this.dt.Rows)
                        {
                            string stockCode = dr["StockCode"].ToString();
                            decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                            if (Convert.ToInt16(dr["ItemType"]) != (Int16)enumItemType.Fuel && delta != 0 && stockCode == lookUpStockCode.EditValue.ToString())
                            {
                                AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                                objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                                objDetail.Quantity = delta;
                                objDetail.StockOutCode = stockCode;
                                objDetail.ItemCode = dr["ItemCode"].ToString();
                                obj.AccTransactionStock.Detail.Add(objDetail);
                            }
                        }
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
                        AccountTransactionStockNewBLL atsnbll = new AccountTransactionStockNewBLL();
                        iError = atsnbll.Delete(lstAccTransStockNew);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu xuất nguyên liệu sản xuất!"));
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
                FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKOUT.ToString());
                f.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                //Stock stockObj = new StockBLL().GetByMinSoHieu();
                //f.StrSpecialType = enumAccountSpecialType.XUATNGUYENLIEUSX.ToString();
                //if (stockObj != null)
                //{
                //    f.StrObject = lookUpStockCode.EditValue.ToString();
                //}
                f.StrObject = lookUpStockCode.EditValue.ToString();
                f.AddNewItem();
                AccountTransactionStockNew obj = f.CurrentItem as AccountTransactionStockNew;
                obj.SpecialType = enumAccountSpecialType.XUATBBPE.ToString();
                if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                obj.AccountTransactionTypeCode = enumAccountTransactionType.STOCKOUT.ToString();
                obj.AccTransactionStock.StockTransactionTypeCode = enumStockTransactionType.X11.ToString();
                obj.AccountTransactionDate = periodObject.EndDate;
                obj.NgayCT = periodObject.EndDate;
                obj.AccTransactionStock.StockTransactionDate = periodObject.EndDate;

                if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                //if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                obj.AccTransactionStock.Tenkho = lookUpStockCode.GetColumnValue("StockName").ToString();
                foreach (DataRow dr in this.dt.Rows)
                {
                    decimal delta = Convert.ToDecimal(dr["QuantityAccountStock"]) - Convert.ToDecimal(dr["Inventory"]);
                    string stockCode = dr["StockCode"].ToString();
                    if (delta != 0 && stockCode == f.StrObject && Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.WrappingMaterial && dr["ItemCode"].ToString().StartsWith("04.BAOPE")) 
                    {
                        //obj.AccTransactionStock.Tenkho = dr["StockName"].ToString();
                        //if (obj.AccTransactionStock.Tenkho.IndexOf(dr["StockName"].ToString()) < 0)
                        //{
                        //    if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho += ", ";
                        //    obj.AccTransactionStock.Tenkho += dr["StockName"].ToString();
                        //}
                        AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                        objDetail.CreditAccountCode = Account.GetMaterialAccount(obj.AccountTransactionDate);
                        objDetail.Quantity = delta;
                        objDetail.StockOutCode = stockCode;
                        objDetail.ItemCode = dr["ItemCode"].ToString();
                        obj.AccTransactionStock.Detail.Add(objDetail);
                    }
                }
                if (obj.Detail2.Count > 0)
                    obj.Detail2[0].DebitAccountCode = "64121";
                new AccountTransactionBLL().RefeshDetail1(obj);
                f.ShowDialog();
            }
        }
    }
}
