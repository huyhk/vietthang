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
    public partial class FormMaterialOutStockPrice : FormEditBase
    {
        AccountStockPriceCostBLL AccStockPriceCostBLL = new AccountStockPriceCostBLL();
        PeriodBLL bll = new PeriodBLL();
        DataTable dt = null;
        Period periodObject = null;
        public FormMaterialOutStockPrice()
        {
            InitializeComponent();
            colOpenAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colInAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colOutAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colCloseAmount.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colAvgPrice.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colClosePrice.DisplayFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            colOpenAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colInAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colOutAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            colCloseAmount.SummaryItem.DisplayFormat = AppConfigs.CONFIG_AMOUNTVNFORMAT_STRING;
            this.repTextEditNumDecimaln0.EditFormat.FormatString = AppConfigs.CONFIG_AMOUNTVNFORMAT;
            this.navigatorFrmEditBase.Visible = false;
            lookUpEditDate.Properties.DataSource = bll.GetAll();

            btnCancel.Click += new EventHandler(btnCancel_Click);
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            dt = AccStockPriceCostBLL.GetMaterialOutStockPrice(Convert.ToString(lookUpEditDate.EditValue));
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
            btnUpdate1.Enabled = this.EditMode == VNS.Windows.FormEditMode.VIEW;
        }
        protected override bool SaveData()
        {
            ErrorMessageType messageType = ErrorMessageType.INSERT;
            VNS.Common.ListBase<AccountStockPriceCost> lst = new ListBase<AccountStockPriceCost>();
            foreach (DataRow dr in this.dt.Rows)
            {
                AccountStockPriceCost obj = new AccountStockPriceCost();
                obj.PeriodCode = periodObject.PeriodCode;
                obj.AccountCode = Account.MaterialAccount;
                obj.ItemCode = dr["ItemCode"].ToString();
                obj.PriceCost = Convert.ToDecimal(dr["ClosePrice"]);
                lst.Add(obj);
            }
            int Error = new AccountStockPriceCostBLL().Insert(lst, periodObject.PeriodCode, Account.MaterialAccount);
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
            //periodObject = (lookUpEditDate.Properties.DataSource as ListBase<Period>)[lookUpEditDate.ItemIndex];
            dt = AccStockPriceCostBLL.GetMaterialOutStockPrice(Convert.ToString(lookUpEditDate.EditValue));
            gridControl1.DataSource = dt;
            gridView1.RefreshData();
            gridView1.BestFitColumns();
            if (bll.SelectIsClosedFalse(enumModuleID.Accounting.ToString()).Search("PeriodCode", periodObject.PeriodCode) == null)
            {
                this.btnEdit.Enabled = false;
                btnUpdate.Enabled = false;
                btnUpdate1.Enabled = false;
            }
            else
            {
                this.RefreshButtons();
            }
        }

        private void FormMaterialOutStockPrice_Load(object sender, EventArgs e)
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
            dialogResult = MessageBox.Show(this.GetTextMessage("ConfirmUpdateOutStockCostPrice", "Chương trình sẽ cập nhật giá xuất kho sản xuất. Bạn chắc không?"), "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                AccStockPriceCostBLL.UpdateOutStockCostPrice(periodObject.PeriodCode);
                MessageBox.Show(this.GetTextMessage("FinishUpdateOutStockCostPrice", "Đã cập nhật xong giá xuất kho sản xuất."));
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show(this.GetTextMessage("ConfirmUpdateProductCostFormulaCostPrice", "Chương trình sẽ cập nhật hệ số tính giá thành. Bạn chắc không?"), "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                new ProductCostFormulaBLL().UpdateCostPrice(periodObject.PeriodCode);
                MessageBox.Show(this.GetTextMessage("FinishUpdateProductCostFormulaCostPrice", "Đã cập nhật xong hệ số tính giá thành."));
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dl = new SaveFileDialog();
            dl.DefaultExt = ".xls";
            if (dl.ShowDialog()==DialogResult.OK)
                this.gridControl1.ExportToXls(dl.FileName);
        }
    }
}