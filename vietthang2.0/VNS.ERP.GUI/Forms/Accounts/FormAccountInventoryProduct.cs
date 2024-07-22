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
    public partial class FormAccountInventoryProduct : VNS.Windows.Forms.FormEditBase
    {
        PeriodBLL bll = new PeriodBLL();
        DataTable dt = null;
        Period periodObject = null;
        public FormAccountInventoryProduct()
        {
            InitializeComponent();
            lookUpStockCode.Properties.DataSource = new StockBLL().GetAll();
            this.navigatorFrmEditBase.Visible = false;
            lookUpEditDate.Properties.DataSource = bll.GetAll();

            btnCancel.Click += new EventHandler(btnCancel_Click);
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            dt = new AccountStockOpeningsBLL().GetInventoryProduct(Convert.ToDateTime(lookUpEditDate.EditValue));
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
            btnProduct.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }

        private void lookUpEditDate_EditValueChanged(object sender, EventArgs e)
        {
            periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
            dt = new AccountStockOpeningsBLL().GetInventoryProduct(Convert.ToDateTime(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
            gridView1.ExpandAllGroups();
            if (bll.SelectIsClosedFalse(enumModuleID.Accounting.ToString()).Search("PeriodCode", periodObject.PeriodCode) == null)
            {
                this.btnEdit.Enabled = false;
                btnProduct.Enabled = false;
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
                VNS.Common.ListBase<AccountStockOpenings> lst = new VNS.Common.ListBase<AccountStockOpenings>();
                foreach (DataRow dr in dt.Rows)
                {
                    AccountStockOpenings obj = new AccountStockOpenings();
                    obj.PeriodCode = periodNextObj.PeriodCode;
                    if (dr["ProductType"].ToString() == "TS")
                        obj.AccountCode = Account.ProductAccountTS;
                    else if (dr["ProductType"].ToString() == "GS")
                        obj.AccountCode = Account.ProductAccountGS;
                    else if (dr["ProductType"].ToString() == "CV")
                        obj.AccountCode = Account.ProductAccountCV;
                    //obj.AccountCode = dr["ProductType"].ToString() == "TS" ? Account.ProductAccountTS : Account.ProductAccountGS;// Account.ProductAccount;
                    obj.ItemCode = dr["ItemCode"].ToString();
                    obj.StockCode = dr["StockCode"].ToString();
                    obj.Quantity = Convert.ToDecimal(dr["Inventory"]);
                    if (obj.Quantity != 0)
                    {
                        lst.Add(obj);
                    }
                }
                int Error = new AccountStockOpeningsBLL().Insert(lst, periodNextObj.PeriodCode, Account.ProductAccount);
                if (Error != 0)
                {
                    OnError(Error, messageType);
                    return false;
                }
            }
            return base.SaveData();
        }

        private void FormAccountInventoryProduct_Load(object sender, EventArgs e)
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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            bool execNext = true;
            if (lookUpStockCode.EditValue == null)
            {
                MessageBox.Show(this.GetTextMessage("StockCreatTransactionNullError", "Chưa chọn kho để tạo phiếu!"));
                return;
            }
            AccountTransactionStockNewBLL accTransStockNewBLL = new AccountTransactionStockNewBLL();
            ListBase<AccountTransactionStockNew> lstAccTransStockNew = accTransStockNewBLL.SelectBySpecialTypeStockCodeAndDate(enumAccountSpecialType.NHAPTHANHPHAMSX.ToString(), lookUpStockCode.EditValue.ToString(), periodObject.StartDate, periodObject.EndDate);
            //ListBase<AccountTransaction> lst = new AccountTransactionBLL().GetByStockTransTypeAndDate(enumAccountTransactionType.STOCKIN.ToString(), enumStockTransactionType.N21.ToString(), periodObject.StartDate, periodObject.EndDate);
            if (lstAccTransStockNew.Count > 0)
            {
                foreach (AccountTransactionStockNew accTransStockNew in lstAccTransStockNew)
                {
                    accTransStockNew.AccTransactionStock = accTransStockNewBLL.SelectAccTransStockByAccountTransactionID(accTransStockNew.AccountTransactionID);
                }
                FormMessageExistsAccountTransaction fCheckAnswer = new FormMessageExistsAccountTransaction();
                enumFormMsgExistAccTransDialogResult answer = fCheckAnswer.ShowDialog(this.GetTextMessage("Info-1", "Trong kỳ đã có phiếu nhập thành phẩm sản xuất!"), "Thông báo");
                if (answer == enumFormMsgExistAccTransDialogResult.Cancel)
                {
                    execNext = false;
                }
                if (answer == enumFormMsgExistAccTransDialogResult.OpenEdit || answer == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKIN.ToString());
                    f.StockTransactionTypeCode = enumStockTransactionType.N21.ToString();
                    SetFormPrivilege(f);
                    f.DataSource = lstAccTransStockNew;
                   // f.StrSpecialType = enumAccountSpecialType.NHAPTHANHPHAMSX.ToString();
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
                            decimal delta = -Convert.ToDecimal(dr["QuantityAccountStock"]) + Convert.ToDecimal(dr["Inventory"]);
                            if (Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.Product && delta != 0 && stockCode == lookUpStockCode.EditValue.ToString())
                            {
                                AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                                objDetail.DebitAccountCode = Account.ProductAccount;
                                objDetail.Quantity = delta;
                                objDetail.StockInCode = stockCode;
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
                    if (MessageBox.Show(this.GetTextMessage("Warning-2", "Bạn có muốn xoá phiếu đi để tạo lại (Y/N?)"), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int iError = 0;
                        AccountTransactionStockNewBLL atsnbll = new AccountTransactionStockNewBLL();
                        iError = atsnbll.Delete(lstAccTransStockNew);
                        if (iError != 0)
                        {
                            MessageBox.Show(this.GetTextMessage("Info-2", "Xoá không thành công, không thể tạo lại phiếu nhập thành phẩm sản xuất!"));
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
                FormEditAccountTransactionStock f = new FormEditAccountTransactionStock(enumAccountTransactionType.STOCKIN.ToString());
                f.StockTransactionTypeCode = enumStockTransactionType.N21.ToString();
                SetFormPrivilege(f);
                f.DataSource = new ListBase<AccountTransactionStockNew>();
                //f.StrSpecialType = enumAccountSpecialType.NHAPTHANHPHAMSX.ToString();
                //Stock stockObj = new StockBLL().GetByMinSoHieu();
                //if (stockObj != null)
                //{
                //    f.StrObject = stockObj.StockCode;
                //}
                 f.StrObject = lookUpStockCode.EditValue.ToString();
                f.AddNewItem();
                AccountTransactionStockNew obj = f.CurrentItem as AccountTransactionStockNew;
                if (obj.AccTransactionStock == null) obj.AccTransactionStock = new AccountTransactionStock();
                obj.SpecialType = enumAccountSpecialType.NHAPTHANHPHAMSX.ToString();
                obj.AccountTransactionTypeCode = enumAccountTransactionType.STOCKIN.ToString();
                obj.AccTransactionStock.StockTransactionTypeCode = enumStockTransactionType.N21.ToString();
                obj.AccountTransactionDate = periodObject.EndDate;
                obj.NgayCT = periodObject.EndDate;
                obj.AccTransactionStock.StockTransactionDate = periodObject.EndDate;

                if (obj.AccTransactionStock.Detail == null) obj.AccTransactionStock.Detail = new ListBase<AccountTransactionStockDetail>();
                //if (obj.AccTransactionStock.Tenkho == null) obj.AccTransactionStock.Tenkho = "";
                obj.AccTransactionStock.Tenkho = lookUpStockCode.GetColumnValue("StockName").ToString();
                foreach (DataRow dr in this.dt.Rows)
                {
                    string stockCode = dr["StockCode"].ToString();
                    decimal delta = -Convert.ToDecimal(dr["QuantityAccountStock"]) + Convert.ToDecimal(dr["Inventory"]);
                    if (Convert.ToInt16(dr["ItemType"]) == (Int16)enumItemType.Product && delta != 0 && stockCode == f.StrObject)
                    {
                        //if (obj.AccTransactionStock.Tenkho.IndexOf(dr["StockName"].ToString()) < 0)
                        //{
                        //    if (obj.AccTransactionStock.Tenkho != "") obj.AccTransactionStock.Tenkho += ", ";
                        //    obj.AccTransactionStock.Tenkho += dr["StockName"].ToString();
                        //}
                        AccountTransactionStockDetail objDetail = new AccountTransactionStockDetail();
                        //objDetail.DebitAccountCode = Account.ProductAccount;
                        if (dr["ProductType"].ToString() == "TS")
                            objDetail.DebitAccountCode = Account.ProductAccountTS;
                        else if (dr["ProductType"].ToString() == "GS")
                            objDetail.DebitAccountCode = Account.ProductAccountGS;
                        else if (dr["ProductType"].ToString() == "CV")
                            objDetail.DebitAccountCode = Account.ProductAccountCV;
                        //objDetail.DebitAccountCode = dr["ProductType"].ToString() == "TS" ? Account.ProductAccountTS : Account.ProductAccountGS;
                        objDetail.Quantity = delta;
                        objDetail.StockInCode = stockCode;
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
    }
}