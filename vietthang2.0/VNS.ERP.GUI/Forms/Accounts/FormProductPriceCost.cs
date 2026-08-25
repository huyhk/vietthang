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
using DevExpress.Utils;
using VNS.Windows;
using Microsoft.Office.Interop.Excel;

namespace VNS.ERP.GUI.Accounting
{
    public partial class FormProductPriceCost : FormEditBase
    {
        private ListBase<Period> lstPeriods;
        private ProductPriceCostBLL productPriceCostBLL = null;
        private AccountTransactionBLL accBLL=null;
        private System.Data.DataTable dtGrid1 = null;
        private System.Data.DataTable dtGrid2 = null;
        private System.Data.DataTable dtGrid3 = null;
        private System.Data.DataTable dtPriceCost = null;
        private ListBase<ProductPriceCost> lstProprice;
        private ListBase<ProductSizePriceCost> lstSizeProprice;
        private ListBase<ItemPriceCost> lstItemPriceCost;
        private PeriodBLL periodBLL = null;
        private Period period = null;
        public FormProductPriceCost()
        {
            InitializeComponent();
            this.colTotalAmount.DisplayFormat.FormatType = FormatType.Numeric;
            this.colTotalAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            this.colTotalAmount.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Far;
            this.colQuantityAll.DisplayFormat.FormatType = FormatType.Numeric;
            this.colQuantityAll.DisplayFormat.FormatString = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT;
            this.colQuantityAll.SummaryItem.DisplayFormat = AppConfigs.CONFIG_QUANTITYPRODUCTFORMAT_STRING;
            this.colPriceCostPro.DisplayFormat.FormatType = FormatType.Numeric;
            this.colPriceCostPro.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;
            this.colPriceCostNC.DisplayFormat.FormatType = FormatType.Numeric;
            this.colPriceCostNC.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;
            this.colPriceCostSXC.DisplayFormat.FormatType = FormatType.Numeric;
            this.colPriceCostSXC.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;
            this.colPriceCostCal.DisplayFormat.FormatType = FormatType.Numeric;
            this.colPriceCostCal.DisplayFormat.FormatString = AppConfigs.CONFIG_PRICEVNFORMAT;
        }
        private void LoadDataSourced(int index)
        {
            period = lstPeriods[index];
            //Chi phí tính giá thành.
            dtPriceCost = productPriceCostBLL.GetCostAmountCalculatorProductCode(period.StartDate, period.EndDate);
            this.gridControl1.DataSource = dtPriceCost;
            SumPriceCostProduct(dtPriceCost);
            //this.txtTotalAmount.Text=this.colTotalAmount.SummaryText;
            this.ItemLookAccountCode.DataSource = (new AccountBLL()).GetListAccountIsNotParentAccount();
            //Chi tiết thành phẩm.
            dtGrid1 = productPriceCostBLL.GetDetaiProductByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate, decimal.Parse(this.txtTotalAmount.EditValue.ToString()));
            this.gridControl2.DataSource = dtGrid1;
            dtGrid2 = productPriceCostBLL.GetDetaiProductSizeCodeByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate, decimal.Parse(this.textEdit1.EditValue.ToString()), decimal.Parse(this.textEdit2.EditValue.ToString()));
            this.gridControl3.DataSource = dtGrid2;
            dtGrid3 = productPriceCostBLL.GetDetaiItemCodeByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate);
            this.gridControl4.DataSource = dtGrid3;
            if (dtGrid1.Rows.Count > 0 && dtGrid2.Rows.Count > 0)
                this.btnEdit.Enabled = true;
            else
                this.btnEdit.Enabled = false;
        }
        private void cboPeriodCode_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cboPeriodCode.ItemIndex >= 0)
            {
                LoadDataSourced(this.cboPeriodCode.ItemIndex);
                if (periodBLL.SelectIsClosedTrue(enumModuleID.Accounting.ToString()).Search("PeriodCode", this.cboPeriodCode.EditValue.ToString()) != null)
                {
                    this.btnEdit.Enabled = false;
                    this.btnDinhkhoan.Enabled = false;
                    this.btnUpdateGia.Enabled = false;
                }
                else
                {
                    this.btnDinhkhoan.Enabled = true;
                    this.btnUpdateGia.Enabled = true;
                }
            }
        }
        private void SumPriceCostProduct(System.Data.DataTable dt)
        {
            decimal totalMaterialExpense = 0;
            decimal totalLabourProductionExpense = 0;
            decimal totalGeneralProductionExpense = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["CreditAccountCode"].ToString().Substring(0, 3).Equals(Account.MaterialExpense))
                {
                    totalMaterialExpense += (decimal)(dr["TotalAmount"]);
                }
                else if (dr["CreditAccountCode"].ToString().Substring(0, 3).Equals(Account.LabourProductionExpense))
                {
                    totalLabourProductionExpense += (decimal)(dr["TotalAmount"]);
                }
                else if(dr["CreditAccountCode"].ToString().Substring(0, 3).Equals(Account.GeneralProductionExpense))
                {
                    totalGeneralProductionExpense += (decimal)(dr["TotalAmount"]);
                }
            }
            this.txtTotalAmount.EditValue = totalMaterialExpense;
            this.textEdit1.EditValue = totalLabourProductionExpense;
            this.textEdit2.EditValue = totalGeneralProductionExpense;
            this.txtSum.EditValue = totalMaterialExpense + totalLabourProductionExpense + totalGeneralProductionExpense;
        }


        private void FormProductPriceCost_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Period perMin = null;
                periodBLL = new PeriodBLL();
                accBLL = new AccountTransactionBLL();
                productPriceCostBLL = new ProductPriceCostBLL();
                lstPeriods = periodBLL.GetAll();
                perMin = periodBLL.GetMin();
                this.cboPeriodCode.Properties.DataSource = lstPeriods;
                this.cboPeriodCode.EditValue = Contexts.WorkingPeriod.PeriodCode;
                RefreshButtons();
               
            }
        }
        public override void RefreshButtons()
        {
            this.txtTotalAmount.Properties.ReadOnly = true;
            base.RefreshButtons();
            this.btnEdit.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnSave.Enabled = this.EditMode == FormEditMode.EDIT;
            this.btnCancel.Visible = this.EditMode == FormEditMode.EDIT;
            this.btnCopy.Enabled = this.EditMode == FormEditMode.EDIT;
            this.cboPeriodCode.Properties.ReadOnly = this.EditMode == FormEditMode.EDIT;
            this.colPriceCost.OptionsColumn.AllowEdit= this.EditMode == FormEditMode.EDIT;
            this.colPriceCost.OptionsColumn.AllowFocus = this.EditMode == FormEditMode.EDIT;
            this.colNCPriceCost.OptionsColumn.AllowFocus = this.EditMode == FormEditMode.EDIT;
            this.colSXCPriceCost.OptionsColumn.AllowFocus = this.EditMode == FormEditMode.EDIT;
            this.colPriceCostInput.OptionsColumn.AllowFocus = this.EditMode == FormEditMode.EDIT;
            this.colAmountCost.OptionsColumn.AllowFocus = this.EditMode == FormEditMode.EDIT;
            this.btnUpdateGia.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnDinhkhoan.Enabled = this.EditMode == FormEditMode.VIEW;
            this.btnPrint.Enabled = this.EditMode == FormEditMode.VIEW;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyAmountCalculator();
        }
        private void CopyAmountCalculator()
        {
        
            if (this.gridView2.RowCount > 0)
            {
                foreach (DataRow dr in dtGrid1.Rows)
                {
                    dr["PriceCost"] = dr["AmountCalculator"];
                    foreach (DataRow row3 in dtGrid3.Rows)
                    {
                        if (row3["ProductCode"].Equals(dr["ProductCode"]) && row3["WrappingCode"].Equals(dr["WrappingCode"]))
                        {
                            row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) - (decimal)(row3["PriceCostNVL"]);
                            row3["PriceCostNVL"] = dr["PriceCost"];
                            row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) + (decimal)(row3["PriceCostNVL"]);
                        }
                    }
                }
            }
            if (this.gridView3.RowCount>0)
            {
                foreach (DataRow dr2 in dtGrid2.Rows)
                {
                    dr2["NCPriceCost"] = dr2["AmountCalculatorNC"];
                    dr2["SXCPriceCost"] = dr2["AmountCalculatorSXC"];
                    foreach (DataRow row3 in dtGrid3.Rows)
                    {
                        if (row3["SizeCode"].Equals(dr2["ProductSizeCode"]) && row3["ProductType"].Equals(dr2["ProductType"]))
                        {
                            row3["PriceCostCal"] =(decimal)(row3["PriceCostCal"]) - ((decimal)(row3["NCPriceCost"]) + (decimal)(row3["SXCPriceCost"]));
                            row3["NCPriceCost"] = dr2["NCPriceCost"];
                            row3["SXCPriceCost"] = dr2["SXCPriceCost"];
                            row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) + (decimal)(row3["NCPriceCost"]) + (decimal)(row3["SXCPriceCost"]);
                            row3["AmountCal"] = decimal.Round((decimal)(row3["PriceCostCal"]) * (decimal)row3["Sum_Quantity"],0);
                        }
                    }
                }
            }
           
            this.gridControl2.RefreshDataSource();
            this.gridControl3.RefreshDataSource();
            if (this.gridView4.RowCount > 0)
            {
                foreach (DataRow dr4 in dtGrid3.Rows)
                {
                    dr4["PriceCostInput"] = dr4["PriceCostCal"];
                    dr4["AmountCost"] = dr4["AmountCal"];
                  
                }
            }
  
            this.gridControl4.RefreshDataSource();
        }
       
        protected override void AssignData()
        {
            lstProprice = new ListBase<ProductPriceCost>();
            lstSizeProprice = new ListBase<ProductSizePriceCost>();
            lstItemPriceCost = new ListBase<ItemPriceCost>();
            System.Data.DataTable dt1 = (this.gridControl2.DataSource as System.Data.DataTable);
            System.Data.DataTable dt2 = (this.gridControl3.DataSource as System.Data.DataTable);
            System.Data.DataTable dt3 = (this.gridControl4.DataSource as System.Data.DataTable);
            foreach (DataRow row1 in dt1.Rows)
            {
                ProductPriceCost pr = new ProductPriceCost();
                pr.PeriodCode = this.cboPeriodCode.EditValue.ToString();
                pr.ProductCode = row1["ProductCode"].ToString();
                pr.WrappingCode = row1["WrappingCode"].ToString();
                pr.PriceCost = (decimal)(row1["PriceCost"]);
                lstProprice.Add(pr);
            }
            foreach (DataRow row2 in dt2.Rows)
            {
                ProductSizePriceCost pr = new ProductSizePriceCost();
                pr.PeriodCode = this.cboPeriodCode.EditValue.ToString();
                pr.ProductSizeCode = row2["ProductSizeCode"].ToString();
                pr.ProductType = row2["ProductType"].ToString();
                pr.NCPriceCost = (decimal)(row2["NCPriceCost"]);
                pr.SXCPriceCost = (decimal)(row2["SXCPriceCost"]);
                lstSizeProprice.Add(pr);
            }
            foreach (DataRow row3 in dt3.Rows)
            {
                ItemPriceCost it = new ItemPriceCost();
                it.PeriodCode = this.cboPeriodCode.EditValue.ToString();
                it.ItemCode = row3["ItemCode"].ToString();
                it.PriceCost = (decimal)(row3["PriceCostInput"]);
                it.Quantity = (decimal)row3["Sum_Quantity"];
                it.AmountCost = (decimal)(row3["AmountCost"]);
                lstItemPriceCost.Add(it);
            }

        }
        protected override bool SaveData()
        {
            AssignData();
            ErrorMessageType messageType = ErrorMessageType.VALIDATE;
            int ret = ValidateData();
            if (ret != 0)
            {
                OnError(ret, messageType);
                return false;
            }
            messageType = ErrorMessageType.INSERT;
            int Error = productPriceCostBLL.InsertProductPrice(lstProprice,lstSizeProprice,lstItemPriceCost, this.cboPeriodCode.EditValue.ToString());
            if (Error != 0)
            {
                OnError(Error, messageType);
                return false;
            }
            return base.SaveData();
        }
        public override void CancelItem()
        {
            if (this.EditMode != FormEditMode.ADD)
            {
                dtGrid1 = productPriceCostBLL.GetDetaiProductByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate, decimal.Parse(this.txtTotalAmount.EditValue.ToString()));
                this.gridControl2.DataSource = dtGrid1;
                dtGrid2 = productPriceCostBLL.GetDetaiProductSizeCodeByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate, decimal.Parse(this.textEdit1.EditValue.ToString()), decimal.Parse(this.textEdit2.EditValue.ToString()));
                this.gridControl3.DataSource = dtGrid2;
                dtGrid3 = productPriceCostBLL.GetDetaiItemCodeByPeriodCode(period.PeriodCode, period.StartDate, period.EndDate);
                this.gridControl4.DataSource = dtGrid3;
            }
            base.CancelItem();
        }

        private void btnUpdateGia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this.GetTextMessage("CONFIRM-UpdatePrice",""), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                productPriceCostBLL.UpdateInStockCostPriceProduct(this.period.PeriodCode);
                MessageBox.Show(this.GetTextMessage("FinishUpdateInStockCostPriceProduct",this.GetTextMessage("RESPONSE-UpdatePrice","")));
            }
        }

        private void ItemTextFormat2_EditValueChanged(object sender, EventArgs e)
        {
            if (this.gridControl2.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                if (this.gridView2.ActiveEditor != null)
                    (cr.Current as DataRowView)["PriceCost"] = this.gridView2.ActiveEditor.Text;
            }
        }

        private void ItemTextFormat2_Leave(object sender, EventArgs e)
        {
            if (this.gridControl2.DataSource != null)
            {
                UpdateNVLPriceCost();
            }
        }

        private void ItemTextFormatNC_EditValueChanged(object sender, EventArgs e)
        {
            if (this.gridControl3.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                if (this.gridView3.ActiveEditor != null)
                    (cr.Current as DataRowView)["NCPriceCost"] = this.gridView3.ActiveEditor.Text;
            }
        }


        private void ItemTextFormatNC_Leave(object sender, EventArgs e)
        {
            if (this.gridControl3.DataSource != null)
            {
                UpdateNCPriceCost();
            }
        }

        private void ItemTextFormatSXC_EditValueChanged(object sender, EventArgs e)
        {
            if (this.gridControl3.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                if (this.gridView3.ActiveEditor != null)
                    (cr.Current as DataRowView)["SXCPriceCost"] = this.gridView3.ActiveEditor.Text;
            }
        }

        private void ItemTextFormatSXC_Leave(object sender, EventArgs e)
        {
            if (this.gridControl3.DataSource != null)
            {
                UpdateSXCPriceCost();
            }
        }
        private void UpdateSXCPriceCost()
        {
            CurrencyManager cr = null;
            if (this.EditMode == FormEditMode.EDIT)
            {
                foreach (DataRow row3 in dtGrid3.Rows)
                {
                    cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                    if (row3["SizeCode"].Equals((cr.Current as DataRowView)["ProductSizeCode"]) && row3["ProductType"].Equals((cr.Current as DataRowView)["ProductType"]))
                    {
                        row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) - (decimal)(row3["SXCPriceCost"]);
                        row3["SXCPriceCost"] = (cr.Current as DataRowView)["SXCPriceCost"];
                        row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) + (decimal)(row3["SXCPriceCost"]);
                        row3["AmountCal"] = decimal.Round((decimal)(row3["PriceCostCal"]) * (decimal)(row3["Sum_Quantity"]), 0);
                    }
                }
            }
        }
        private void UpdateNCPriceCost()
        {
            CurrencyManager cr = null;
            if (this.EditMode == FormEditMode.EDIT)
            {
                foreach (DataRow row3 in dtGrid3.Rows)
                {
                    cr = this.BindingContext[this.gridControl3.DataSource] as CurrencyManager;
                    if (row3["SizeCode"].Equals((cr.Current as DataRowView)["ProductSizeCode"]) && row3["ProductType"].Equals((cr.Current as DataRowView)["ProductType"]))
                    {
                        row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) - (decimal)(row3["NCPriceCost"]);
                        row3["NCPriceCost"] = (cr.Current as DataRowView)["NCPriceCost"];
                        row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) + (decimal)(row3["NCPriceCost"]);
                        row3["AmountCal"] = decimal.Round((decimal)(row3["PriceCostCal"]) * (decimal)(row3["Sum_Quantity"]),0);
                    }
                }
            }
        }
        private void UpdateNVLPriceCost()
        {
            CurrencyManager cr = null;
            if (this.EditMode == FormEditMode.EDIT)
            {
                cr = this.BindingContext[this.gridControl2.DataSource] as CurrencyManager;
                foreach (DataRow row3 in dtGrid3.Rows)
                {
                    if (row3["ProductCode"].Equals((cr.Current as DataRowView)["ProductCode"]) && row3["WrappingCode"].Equals((cr.Current as DataRowView)["WrappingCode"]))
                    {
                        if ((cr.Current as DataRowView)["PriceCost"].Equals(row3["PriceCostNVL"]))
                        { }
                        else
                        {
                            row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) - (decimal)(row3["PriceCostNVL"]);
                            row3["PriceCostNVL"] = (cr.Current as DataRowView)["PriceCost"];
                            row3["PriceCostCal"] = (decimal)(row3["PriceCostCal"]) + (decimal)(row3["PriceCostNVL"]);
                            row3["AmountCal"] =  decimal.Round((decimal)(row3["PriceCostCal"]) * (decimal)(row3["Sum_Quantity"]),0);
                        }
                    }
                }
            }
        }
        private void UpdateAmountCost()
        {
            CurrencyManager cr = null;
            if (this.EditMode == FormEditMode.EDIT)
            {
                cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                foreach (DataRow row4 in dtGrid3.Rows)
                {
                    if (row4["ItemCode"].Equals((cr.Current as DataRowView)["ItemCode"]))
                    {
                         this.gridView4.SetRowCellValue(this.gridView4.FocusedRowHandle, colAmountCost, decimal.Round((decimal)(row4["Sum_Quantity"]) * (decimal)(row4["PriceCostInput"]),2));
                         break;
                    }
                }
            }
        }
        private void UpdatePriceCostInput()
        {
            CurrencyManager cr = null;
            if (this.EditMode == FormEditMode.EDIT)
            {
                cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                foreach (DataRow row4 in dtGrid3.Rows)
                {
                    if (row4["ItemCode"].Equals((cr.Current as DataRowView)["ItemCode"]))
                    {
                        this.gridView4.SetRowCellValue(this.gridView4.FocusedRowHandle, colPriceCostInput, decimal.Round((decimal)(row4["AmountCost"]) / (decimal)(row4["Sum_Quantity"]),2));
                        break;
                    }
                }
            }
        }

        private void ItemTextEditFormat_EditValueChanged(object sender, EventArgs e)
        {

            if (this.gridControl4.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                if (this.gridView4.ActiveEditor != null)
                    (cr.Current as DataRowView)["PriceCostInput"] = this.gridView4.ActiveEditor.Text;
            }
        }

        private void ItemTextEditFormat_Leave(object sender, EventArgs e)
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                UpdateAmountCost();
            }
        }

        private void ItemFormatAmount_Leave(object sender, EventArgs e)
        {
            if (this.EditMode == FormEditMode.EDIT)
            {
                UpdatePriceCostInput();
            }
        }

        private void ItemFormatAmount_EditValueChanged(object sender, EventArgs e)
        {
            if (this.gridControl4.DataSource != null)
            {
                CurrencyManager cr = this.BindingContext[this.gridControl4.DataSource] as CurrencyManager;
                if (this.gridView4.ActiveEditor != null)
                    (cr.Current as DataRowView)["AmountCost"] = this.gridView4.ActiveEditor.Text;
            }
        }

        private void btnDinhkhoan_Click(object sender, EventArgs e)
        {
            FormMessageExistsAccountTransaction frmMessage=null;
            FormEditAccountTransaction frm=null;
            int iError = 0;
            ListBase<AccountTransaction> lstAccountTran = accBLL.SelectBySpecialTypeAndDate(enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString(), period.StartDate, period.EndDate);
            if (lstAccountTran.Count == 0)
            {
                frm = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển tính giá thành");//, enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString());
                SetFormPrivilege(frm);
                frm.DataSource = new AccountTransaction();
                frm.AddNewItem();
                frm.CurrentItem = GetDataSourceDinhkhoan();
                frm.ShowDialog();
                LoadDataSourced(this.cboPeriodCode.ItemIndex);
            }
            else
            {
                frmMessage = new FormMessageExistsAccountTransaction();
                frmMessage.ShowDialog(this.GetTextMessage("MESSAGE-1", ""), "Thông báo");
                if (frmMessage.AnswerResult == enumFormMsgExistAccTransDialogResult.OpenEdit)
                {
                    lstAccountTran[0].Detail1 = GetListDetail1();
                    frm = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển tính giá thành");//, enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString());
                    SetFormPrivilege(frm);
                    frm.DataSource = new AccountTransaction();
                    frm.EditItem();
                    frm.CurrentItem =lstAccountTran[0];
                    frm.ShowDialog();
                    LoadDataSourced(this.cboPeriodCode.ItemIndex);
                }
                else if (frmMessage.AnswerResult == enumFormMsgExistAccTransDialogResult.DeleteAndCreat)
                {
                    iError = accBLL.Delete(lstAccountTran[0]);
                    if (iError == 0)
                    {
                        frm = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển tính giá thành");//, enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString());
                        SetFormPrivilege(frm);
                        frm.DataSource = new AccountTransaction();
                        frm.AddNewItem();
                        frm.CurrentItem = GetDataSourceDinhkhoan();
                        frm.ShowDialog();
                        LoadDataSourced(this.cboPeriodCode.ItemIndex);
                    }
                    else
                    {
                        MessageBox.Show(this.GetTextMessage("MESSAGE-2", ""), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (frmMessage.AnswerResult == enumFormMsgExistAccTransDialogResult.OpenView)
                {
                    frm = new FormEditAccountTransaction(enumAccountTransactionType.GENERAL.ToString(), "Kết chuyển tính giá thành");//, enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString());
                    SetFormPrivilege(frm);
                    frm.DataSource = new AccountTransaction();
                    frm.CurrentItem = lstAccountTran[0];
                    frm.ShowDialog();
                }

            }

        }
        private AccountTransaction GetDataSourceDinhkhoan()
        {
            AccountTransaction acc = new AccountTransaction();
            acc.AccountTransactionDate = Contexts.WorkingEndDate;
            acc.NgayCT = Contexts.WorkingEndDate;
            acc.SpecialType = enumAccountSpecialType.KETCHUYENTINHGIATHANH.ToString();
            acc.Detail1 = GetListDetail1();
            return acc;
        }
        private ListBase<AccountTransactionDetail1> GetListDetail1()
        {
            ListBase<AccountTransactionDetail1> lstDetail1=new ListBase<AccountTransactionDetail1>();
    
            decimal debitAmount = 0;
            System.Data.DataTable dt = productPriceCostBLL.GetCloseAmountByAccountCode(period.StartDate, period.EndDate);
            if (dt.Rows.Count > 0)
                foreach (DataRow dr in dt.Rows)
                {
                    AccountTransactionDetail1 accdetail = new AccountTransactionDetail1();
                    accdetail.AccountCode=dr["AccountCode"].ToString();
                    accdetail.SubjectCode = dr["SubjectCode"].ToString();
                    accdetail.CreditAmount  =(decimal)dr["Amount"];
                    lstDetail1.Add(accdetail);
                    debitAmount += (decimal)dr["Amount"];
                }
            AccountTransactionDetail1 accdetail1 = new AccountTransactionDetail1();
            accdetail1.AccountCode = Account.GetProductCostAccount(period.StartDate);
            accdetail1.DebitAmount = debitAmount;
            lstDetail1.Insert(0, accdetail1);
            return lstDetail1;
        }

        FormProgressBar dlg = null;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Export to excel BangTinhGiaThanhSanPham.xls
            if (this.checkEditExportExcel.Checked.Equals(true))
            {
                dlg = new FormProgressBar();
                if (dlg != null)
                {
                    dlg.Text = "Đang xuất Giá thành Sản phẩm ra excel";
                    dlg.Show();
                }
                this.Cursor = Cursors.WaitCursor;
                ExportToExcel();
                this.Cursor = Cursors.Default;
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
            }
            else
            {
                RpProductPriceCost rp = new RpProductPriceCost();
                RpProductPriceCost.Params pr = new RpProductPriceCost.Params();
                pr.period = cboPeriodCode.GetColumnValue("Description").ToString();
                pr.sumNVL = Convert.ToDecimal(txtTotalAmount.Text);
                pr.sumNC = Convert.ToDecimal(textEdit1.Text);
                pr.sumSXC = Convert.ToDecimal(textEdit2.Text);

                pr.dtNVL = dtGrid1;
                pr.dtNCSXC = dtGrid2;

                rp.RpParams = pr;
                rp.DataSource = dtGrid3;
                rp.BinData();
                rp.ShowPreview();
            }
        }

        private void ExportToExcel()
        {
            Workbook wb = null;
            if (!System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangTinhGiaThanhSanPham.xls"))
            {
                MessageBox.Show(this.GetTextMessage("TemplateFileNotExists", "Không tìm thấy tập tin mẫu ...\\Baocaomau\\KeToan\\BangTinhGiaThanhSanPham.xls"));
                if (dlg != null)
                    dlg.Dispose();
                dlg = null;
                this.Cursor = Cursors.Default;
                return;
            }
            decimal totalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            decimal sumNC = Convert.ToDecimal(textEdit1.Text);
            decimal sumSXC = Convert.ToDecimal(textEdit2.Text);

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = false;
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
            wb = excelApp.Workbooks.Add(System.Windows.Forms.Application.StartupPath + "\\Baocaomau\\KeToan\\BangTinhGiaThanhSanPham.xls");
            Worksheet ws = (Worksheet)wb.Worksheets[1];
           
            int currentLine = 11;
            ws.Cells[4, 3] = "Kỳ kế toán: " + cboPeriodCode.GetColumnValue("Description").ToString(); 
            ws.Cells[6, 2] = totalAmount;
            ws.Cells[6, 4] = sumNC;
            ws.Cells[6, 6] = sumSXC;
            ws.Cells[6, 8] = (totalAmount + sumNC + sumSXC);
            if (dlg != null)
                dlg.SetProgressBarMaximum(dtGrid1.Rows.Count + dtGrid2.Rows.Count + dtGrid3.Rows.Count);
            foreach (DataRow row in dtGrid1.Rows)
            {
                ws.get_Range("A10", "A10").EntireRow.Copy(Type.Missing);
                //((Range)ws.Cells[currentLine + 1, currentLine]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                (ws.Rows[currentLine + 1, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);
                ws.Cells[currentLine, 1] = row["ProductCode"];
                ws.Cells[currentLine, 2] = row["CostAmount"];
                ws.Cells[currentLine, 3] = row["Quantity"];
                ws.Cells[currentLine, 4] = row["CostCalculator"];
                ws.Cells[currentLine, 5] = row["PriceCost"];
                currentLine = currentLine + 1;
                if (dlg != null)
                    dlg.IncreProgressBarValue();
            }
            ws.get_Range(ws.Cells[currentLine, 1],ws.Cells[currentLine, 1]).EntireRow.Delete(true);
            ws.get_Range("A10", "A10").EntireRow.Delete(true);
            currentLine = currentLine + 3;
            int pos = currentLine-1;
            foreach (DataRow row in dtGrid2.Rows)
            {
                ws.get_Range(ws.Cells[pos, 1], ws.Cells[pos, 1]).EntireRow.Copy(Type.Missing);
                //((Range)ws.Cells[currentLine + 1, currentLine]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                (ws.Rows[currentLine + 1, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);
                ws.Cells[currentLine, 1] = row["ProductSizeCode"];
                ws.Cells[currentLine, 2] = row["Capacity"];
                ws.Cells[currentLine, 3] = row["Quantity"];
                ws.Cells[currentLine, 4] = row["Times"];
                ws.Cells[currentLine, 5] = row["NCPriceCost"];
                ws.Cells[currentLine, 6] = row["SXCPriceCost"];
                currentLine = currentLine + 1;
                if (dlg != null)
                    dlg.IncreProgressBarValue();
            }
            //ws.get_Range(ws.Cells[currentLine+1, 1], ws.Cells[currentLine+1, 1]).EntireRow.Delete(true);
            (ws.Rows[currentLine, Type.Missing] as Range).EntireRow.Delete(true);
            (ws.Rows[pos, Type.Missing] as Range).EntireRow.Select();
            (ws.Rows[pos, Type.Missing] as Range).EntireRow.Delete(true);
            currentLine = currentLine + 3;
            pos = currentLine - 1;
            foreach (DataRow row in dtGrid3.Rows)
            {
                ws.get_Range(ws.Cells[pos, 1], ws.Cells[pos, 1]).EntireRow.Copy(Type.Missing);
                //((Range)ws.Cells[currentLine + 1, currentLine]).Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                (ws.Rows[currentLine + 1, Type.Missing] as Range).EntireRow.Insert(Type.Missing, Type.Missing);
                ws.Cells[currentLine, 1] = row["ItemCode"];
                ws.Cells[currentLine, 2] = row["Sum_Quantity"];
                ws.Cells[currentLine, 3] = row["PriceCostNVL"];
                ws.Cells[currentLine, 4] = row["NCPriceCost"];
                ws.Cells[currentLine, 5] = row["SXCPriceCost"];
                ws.Cells[currentLine, 6] = row["PriceCostInput"];
                ws.Cells[currentLine, 7] = row["AmountCost"];
                currentLine = currentLine + 1;
                if (dlg != null)
                    dlg.IncreProgressBarValue();
            }
            //ws.get_Range(ws.Cells[currentLine + 1, 1], ws.Cells[currentLine + 1, 1]).EntireRow.Delete(true);
            (ws.Rows[currentLine + 1, Type.Missing] as Range).EntireRow.Delete(true);
            (ws.Rows[currentLine, Type.Missing] as Range).EntireRow.Delete(true);
            (ws.Rows[pos, Type.Missing] as Range).EntireRow.Select();
            (ws.Rows[pos, Type.Missing] as Range).EntireRow.Delete(true);
            excelApp.Visible = true;
        }
    }

}
